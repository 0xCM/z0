//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public interface IToolCmd : ITooling
    {
        string[] Args {get;}

        KeyedValues<string,string> Options {get;}
    }

    public interface IToolCmd<T> : IToolCmd, ITooling<T>
        where T : struct, ITool<T>
    {
        
    }

    public interface IToolCmd<T,F> : IToolCmd<T>
        where T : struct, ITool<T,F>
        where F : unmanaged, Enum
    {
        new KeyedValues<F,string> Options {get;}

        KeyedValues<string,string> IToolCmd.Options
            => new KeyedValues<string, string>(Options.Pairs.Map(p => new KeyedValue<string,string>(p.Key.ToString(), p.Value)));
    }   
}