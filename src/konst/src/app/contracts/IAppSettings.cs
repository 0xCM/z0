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

    /// <summary>
    /// Characterizes an app settings collection
    /// </summary>
    public interface IAppSettings : IEnumerable<IAppSetting>
    {
        Option<string> Setting(string name);
        
        Option<T> Setting<T>(string name);

        string this[string name] {get;}

        IEnumerable<IAppSetting> All {get;}

        IEnumerator<IAppSetting> IEnumerable<IAppSetting>.GetEnumerator() 
            => All.GetEnumerator();
        
        IEnumerator IEnumerable.GetEnumerator()
            => All.GetEnumerator();
    }
}