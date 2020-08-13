//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;    
    using System.Linq;

    public interface IAppSettings<F> : IAppSettingsProvider<F>
        where F : IAppSettings<F>, new()
    {
        IEnumerable<IAppSetting> IAppSettingsProvider.Settings 
            => AppSettings.Get<F>(this).Cast<IAppSetting>();

        void IAppSettingsProvider.Save(FilePath dst)
            => AppSettings.Save(this,dst);      

        string ITextual.Format()
            => AppSettings.Format(Settings);                  
    }

    public abstract class AppSettings<F> : IAppSettings<F>
        where F : AppSettings<F>, new()
    {
        public static F From(IAppSettings src)
            => AppSettings.From<F>(src);        
    }
}