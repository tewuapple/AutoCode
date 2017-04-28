using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;

namespace AutoCode
{
    /// <summary>
    /// ��exe.Config�ļ��е�appSettings�ν��ж�д���ò���
    /// ע�⣺����ʱ��д������д��vhost.exe.config�ļ���
    /// </summary>
    public class ConfigAppSettings
    {
        /// <summary>
        /// д��ֵ
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public static void SetValue(string key, string value)
        {
            //���ӵ�����д��appSettings���� <add key="RegCode" value="0"/>
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            if (config.AppSettings.Settings[key] == null)
            {
                config.AppSettings.Settings.Add(key, value);
            }
            else
            {
                config.AppSettings.Settings[key].Value = value;
            }
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");//���¼����µ������ļ� 
        }

        /// <summary>
        /// ��ȡָ��key��ֵ
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string GetValue(string key)
        { 
            System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            if (config.AppSettings.Settings[key] == null)
                return "";
            else
                return config.AppSettings.Settings[key].Value;
        }

    }
}
