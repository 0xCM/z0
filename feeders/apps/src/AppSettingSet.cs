//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;    
    using System.Linq;

    public abstract class AppSettingSet<S> : IAppSettingSet<S>
        where S : IAppSettingSet<S>, new()
    {
        public static S From(IAppSettings src)
            => AppSettingsOps.From<S>(src);
        
        public IEnumerable<IAppSetting> Settings 
            => AppSettingsOps.Get<S>(this).Cast<IAppSetting>();

        public string Format()
            => AppSettingsOps.Format(Settings);
        
        public void Save(FilePath dst)
            => AppSettingsOps.Save(this,dst);
    }
}