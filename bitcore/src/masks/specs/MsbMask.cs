//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;

    using static zfunc;


    public readonly struct MsbMask<F,D,T> : IMaskSpec<F,D,T>
        where F : unmanaged, ITypeNat
        where D : unmanaged, ITypeNat
        where T : unmanaged
    {
        public F f => default;

        public D d => default;

        public T t => default;

        public MsbMask<F,D,S> As<S>(S s = default)
            where S : unmanaged
                => default;

        public override string ToString()
            => $"msb, f:{natval<F>()}, d:{natval<D>()}, t:{primalsig<T>()}";
    }


}