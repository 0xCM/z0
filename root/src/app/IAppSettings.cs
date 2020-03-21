//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;    
    using System.Runtime.CompilerServices;    
    using System.Linq;

    using static Root;

    public interface IAppSettings
    {
        Option<string> Setting(string name);
        
        Option<T> Setting<T>(string name);

        string this[string name] {get;}

        IEnumerable<AppSetting> All {get;}
    }

    public interface IAppSettingSet : ICustomFormattable
    {
        IEnumerable<AppSetting> Settings{get;}
        
        void Save(FilePath dst);        
    }

    public interface IAppSettingSet<S> : IAppSettingSet, IFormattable<S>
        where S : IAppSettingSet<S>, new()
    {
        static S From(IAppSettings src)
            => AppSettingsOps.From<S>(src);
        
        IEnumerable<AppSetting> IAppSettingSet.Settings 
            => AppSettingsOps.Get<S>(this);

        string ICustomFormattable.Format()
            => AppSettingsOps.Format(Settings);
        
        void IAppSettingSet.Save(FilePath dst)
            => AppSettingsOps.Save(this,dst);
    }
}