//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;    
    using System.Linq;

    using static Root;

    public interface IPairProvider<T>
    {
        IEnumerable<Pair<T>> Pairs {get;}
    }

    public readonly struct PairProvider<T> : IPairProvider<T>
    {
        public PairProvider(IEnumerable<Pair<T>> src)
        {
            this.Pairs = src;
        }

        public IEnumerable<Pair<T>> Pairs {get;}

    }

    public interface IAppSettings : IPairProvider<string>
    {
        Option<string> Setting(string name);
        
        Option<T> Setting<T>(string name);

        string this[string name] {get;}

    }

}