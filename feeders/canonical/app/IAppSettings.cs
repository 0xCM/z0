//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;    
    using System.Linq;

    public interface IAppSetting : ICustomFormattable
    {
        string Name {get;}        

        string Value {get;}        
    }

    public interface IAppSettings
    {
        Option<string> Setting(string name);
        
        Option<T> Setting<T>(string name);

        string this[string name] {get;}

        IEnumerable<IAppSetting> All {get;}
    }

    public interface IAppSettingSet : ICustomFormattable
    {
        IEnumerable<IAppSetting> Settings{get;}
        
        void Save(FilePath dst);        
    }

    public interface IAppSettingSet<S> : IAppSettingSet, IFormattable<S>
        where S : IAppSettingSet<S>, new()
    {
        
    }
}