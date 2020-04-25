//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;    
    using System.Linq;

    public abstract class AppSettings<F> : IAppSettingsProvider<F>
        where F : IAppSettingsProvider<F>, new()
    {
        public static F From(IAppSettings src)
            => AppSettings.From<F>(src);
        
        public IEnumerable<IAppSetting> Settings 
            => AppSettings.Get<F>(this).Cast<IAppSetting>();

        public string Format()
            => AppSettings.Format(Settings);
        
        public void Save(FilePath dst)
            => AppSettings.Save(this,dst);
    }
}