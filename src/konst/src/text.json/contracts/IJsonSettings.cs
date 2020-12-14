//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    using api = JsonSettings;

    public interface ISettingsAdapter<T>
        where T : ISettingsAdapter<T>, new()
    {
        T Adapt(IJsonSettings source);
    }

    public interface IJsonSetting : ISetting
    {

    }

    /// <summary>
    /// Characterizes an app settings collection
    /// </summary>
    public interface IJsonSettings : IEnumerable<ISetting>, ITextual
    {
        Option<string> Setting(string name);

        Option<T> Setting<T>(string name);

        string this[string name] {get;}

        IEnumerable<ISetting> All {get;}

        IEnumerator<ISetting> IEnumerable<ISetting>.GetEnumerator()
            => All.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
            => All.GetEnumerator();

        string ITextual.Format()
            => api.format(this);

        ISettingsAdapter<T> Adapt<T>()
            where T : ISettingsAdapter<T>, new()
        {
            var adapter = new T();
            return adapter.Adapt(this);
        }
    }

    public interface IJsonSettings<F> : ISettingSource<F>
        where F : IJsonSettings<F>, new()
    {
        IEnumerable<ISetting> ISettingSource.Settings
            => JsonSettings.Get<F>(this).Cast<ISetting>();

        void ISettingSource.Save(FilePath dst)
            => JsonSettings.Save(this,dst);

        string ITextual.Format()
            => JsonSettings.Format(Settings);
    }
}