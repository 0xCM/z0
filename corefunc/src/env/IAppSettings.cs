//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;    

    public interface IAppSettings
    {
        Option<string> Read(string name);
        
        Option<T> Read<T>(string name);

        string this[string name] {get;}

        IEnumerable<Pair<string>> Pairs {get;}
    }
}