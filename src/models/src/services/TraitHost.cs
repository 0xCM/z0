//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct TraitHost
    {
        [MethodImpl(Inline)]
        public static F host<F,T>()
            where T : class
            where F : T, new()
                => new F();        
        
        [MethodImpl(Inline)]
        public static T trait<F,T>(F rep = default)
            where T : class
            where F : T, new()
                => host<F,T>();
    }
    
    public readonly struct TraitHost<F,T> : ITraitHost<F,T>
        where T : class
        where F : T, new()
    {
        public static T Trait
        {
            [MethodImpl(Inline)]
            get => new F();
        }

        public static F Host
        {
            [MethodImpl(Inline)]
            get => new F();
        }
    }

    public readonly struct TraitHost<T> : ITraitHost<TraitHost<T>>
        where T : class
    {

        [MethodImpl(Inline)]
        public static T trait<F>(F rep = default)
            where F : T, new()
                => new F();
    }    
}