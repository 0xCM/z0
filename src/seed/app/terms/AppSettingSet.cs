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
            => AppSettings.From<S>(src);
        
        public IEnumerable<IAppSetting> Settings 
            => AppSettings.Get<S>(this).Cast<IAppSetting>();

        public string Format()
            => AppSettings.Format(Settings);
        
        public void Save(FilePath dst)
            => AppSettings.Save(this,dst);
    }
}