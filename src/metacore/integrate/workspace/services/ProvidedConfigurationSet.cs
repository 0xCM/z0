//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MetaCore
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Collections.Concurrent;
    using System.Linq;
    using System.Reflection;
    using System.Linq.Expressions;

    using static Konst;

    /// <summary>
    /// Implements a <see cref="IConfigurationProvider"/>
    /// </summary>
    public sealed class ProvidedConfigurationSet : IConfigurationProvider
    {    

        public ProvidedConfigurationSet(IEnumerable<ConfigurationSetting> settings)
            => SettingsIndex = settings.ToDictionary(x => x.Name, x => x.Value).ToConcurrentDictionary();

        public ProvidedConfigurationSet(IReadOnlyDictionary<string,object> settings)
            => SettingsIndex = new ConcurrentDictionary<string, object>(settings);

        ConcurrentDictionary<string, object> SettingsIndex { get; }

        string Environment { get; }
            = String.Empty;

        string Component { get; }
            = String.Empty;

        string IConfigurationProvider.ComponentName 
            => Component;

        string IConfigurationProvider.EnvironmentName 
            => Environment;

        T IConfigurationProvider.PutSetting<T>(string settingName, T value, string description)
        {
            SettingsIndex.AddOrUpdate(settingName, value, (_, __) => value);
            return value;
        }

        void IConfigurationProvider.PutSettings(IReadOnlyDictionary<string, object> settings)
        {
            foreach (var setting in settings)
                SettingsIndex.AddOrUpdate(setting.Key, setting.Value, (_, __) => setting.Value);
        }

        IReadOnlyDictionary<string, object> IConfigurationProvider.GetSettings()
            => SettingsIndex.Select(x => (x.Key, x.Value)).ToDictionary();

        T IConfigurationProvider.GetSetting<T>(string settingName)
        {
            var value = SettingsIndex.TryFind(settingName).OnNone(() =>
            {
                throw new ArgumentException($"The setting {settingName} is unspecified");
            }).Require();        
            return z.cast<T>(value);
        }

        bool IConfigurationProvider.HasSetting(string settingName)
            => SettingsIndex.ContainsKey(settingName);    
    }
}