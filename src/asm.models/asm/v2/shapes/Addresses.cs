//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    public readonly struct Addresses<B,R,S,T>
        where B : unmanaged, IAddress<S>
        where R : unmanaged, IAddress<T>
        where T : unmanaged
        where S : unmanaged
    {
        public readonly B Base;

        public readonly R[] Relative;

        [MethodImpl(Inline)]
        public Addresses(B @base, R[] relative)
        {
            Base = @base;
            Relative = relative;
        }
    }
}