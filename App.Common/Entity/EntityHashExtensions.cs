using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

using Common.Collections;
using Common.Core.Data;
using Common.Core.Systems;
using Common.Data;
using Common.Extensions;


namespace Common.Entity
{
    /// <summary>
    /// ʵ��Hash��չ����
    /// </summary>
    public static class EntityHashExtensions
    {
        /// <summary>
        /// ���ָ��ʵ���Hashֵ�������Ƿ���Ҫ�������ݿ�ͬ��
        /// </summary>
        public static bool CheckSyncByHash(this IEnumerable<IEntityHash> entityHashes, IServiceProvider provider, ILogger logger)
        {
            IEntityHash[] hashes = entityHashes as IEntityHash[] ?? entityHashes.ToArray();
            if (hashes.Length == 0)
            {
                return false;
            }
            string hash = hashes.Select(m => m.GetHash()).ExpandAndToString().ToMd5Hash();
            IKeyValueStore store = provider.GetService<IKeyValueStore>();
            string entityType = hashes[0].GetType().FullName;
            string key = $"Common.Initialize.SyncToDatabaseHash-{entityType}";
            IKeyValue keyValue = store.GetKeyValue(key);
            if (keyValue != null && keyValue.Value?.ToString() == hash)
            {
                logger.LogInformation($"{hashes.Length}���������ݡ�{entityType}��������ǩ�� {hash} ���ϴ���ͬ��ȡ�����ݿ�ͬ��");
                return false;
            }
            OperationResult result = store.CreateOrUpdateKeyValue(key, hash).Result;
            logger.LogInformation($"{hashes.Length}���������ݡ�{entityType}��������ǩ�� {hash} ���ϴ� {keyValue?.Value} ��ͬ�����������ݿ�ͬ��");
            return true;
        }

        /// <summary>
        /// ��ȡָ��ʵ���Hashֵ
        /// </summary>
        /// <param name="entity">ʵ�����</param>
        public static string GetHash(this IEntityHash entity)
        {
            Type type = entity.GetType();
            StringBuilder sb = new StringBuilder();
            foreach (PropertyInfo property in type.GetProperties(BindingFlags.Public | BindingFlags.Instance).Where(m => m.CanWrite && m.Name != "Id"))
            {
                sb.Append(property.GetValue(entity));
            }
            return sb.ToString().ToMd5Hash();
        }
    }
}