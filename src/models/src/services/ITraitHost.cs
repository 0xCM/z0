//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public interface ITraitHost
    {

    }
    
    public interface ITraitHost<F> : ITraitHost
        where F : new()        
    {
        F Host
        {
            [MethodImpl(Inline)]
            get => new F();
        }
    }

    public interface ITraitHost<F,T> : ITraitHost<F>
        where F : T, new()
        where T : class
    {
        T Trait
        {
            [MethodImpl(Inline)]
            get => new F();
        }
    }
}