//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public readonly struct FixedType<F> : IFixedKind<F>
        where F : unmanaged, IFixed
    {
        public static int BitCount => bitsize<F>();

        public FixedWidth FixedWidth { [MethodImpl(Inline)] get=> (FixedWidth) BitCount;}
    }

    public readonly struct FixedNumeric<F,T> : IFixedKind<F>
        where F : unmanaged, IFixed
        where T : unmanaged
    {
        public static int BitCount => bitsize<T>();

        [MethodImpl(Inline)]
        public static implicit operator FixedType<F>(FixedNumeric<F,T> src)
            =>  default;

        public FixedWidth FixedWidth { [MethodImpl(Inline)] get => (FixedWidth)BitCount;}
    }
}