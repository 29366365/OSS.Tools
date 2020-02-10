#region Copyright (C) 2016 Kevin (OSS��Դϵ��) ���ںţ�OSSCore

/***************************************************************************
*����	�ļ�����������ȫ�ֲ�� -  �������ӿ�
*
*����	�����ˣ� Kevin
*       ������Email��1985088337@qq.com
*       
*       
*****************************************************************************/

#endregion

using System;

namespace OSS.Tools.Cache
{
    /// <summary>
    /// �������ӿ�
    /// </summary>
    public interface IToolCache
    {
        /// <summary> 
        /// ���ʱ��ι��ڻ���
        /// ������������
        /// </summary>
        /// <typeparam name="T">��ӻ����������</typeparam>
        /// <param name="key">��Ӷ����key</param>
        /// <param name="obj">ֵ</param>
        /// <param name="slidingExpiration">��Թ��ڵ�TimeSpan</param>
        /// <returns>�Ƿ���ӳɹ�</returns>
        bool Set<T>(string key, T obj, TimeSpan slidingExpiration);

        /// <summary>
        /// ��ӹ̶�����ʱ�仺��,������������
        /// </summary>
        /// <typeparam name="T">��ӻ����������</typeparam>
        /// <param name="key">��Ӷ����key</param>
        /// <param name="obj">ֵ</param>
        /// <param name="absoluteExpiration"> ���Թ���ʱ��,��Ϊ�����վ��Թ���ʱ����� </param>
        /// <returns>�Ƿ���ӳɹ�</returns>
        bool SetAbsolute<T>(string key, T obj, TimeSpan absoluteExpiration);

        [Obsolete("��ʹ��SetAbsolute")]
        bool Set<T>(string key, T obj, DateTime absoluteExpiration);

        /// <summary>
        /// ��ȡ�������
        /// </summary>
        /// <typeparam name="T">��ȡ�����������</typeparam>
        /// <param name="key">key</param>
        /// <returns>��ȡָ��key��Ӧ��ֵ </returns>
        T Get<T>(string key);

        /// <summary>
        /// �Ƴ��������
        /// </summary>
        /// <param name="key"></param>
        /// <returns>�Ƿ�ɹ�</returns>
        bool Remove(string key);

    }
}