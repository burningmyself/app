using System;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;


namespace Common.Core.Packs
{
    /// <summary>
    /// ����Osharpģ�������
    /// </summary>
    public interface IOsharpPackManager
    {
        /// <summary>
        /// ��ȡ �Զ�������������ģ����Ϣ
        /// </summary>
        IEnumerable<OsharpPack> SourcePacks { get; }

        /// <summary>
        /// ��ȡ ���ռ��ص�ģ����Ϣ����
        /// </summary>
        IEnumerable<OsharpPack> LoadedPacks { get; }

        /// <summary>
        /// ����ģ�����
        /// </summary>
        /// <param name="services">��������</param>
        /// <returns>��������</returns>
        IServiceCollection LoadPacks(IServiceCollection services);

        /// <summary>
        /// Ӧ��ģ�����
        /// </summary>
        /// <param name="provider">�����ṩ��</param>
        void UsePack(IServiceProvider provider);
    }
}