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
        public static int BitCount => (int)Width;

        public static FixedWidth Width => default(F).FixedWidth;

        public FixedWidth FixedWidth { [MethodImpl(Inline)] get=> Width;}
    }

    public readonly struct FixedType<F,T> : IFixedNumericKind<F,T>
        where F : unmanaged, IFixed
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public static implicit operator FixedType<F>(FixedType<F,T> src)
            =>  default;

        public static FixedWidth Width => default(F).FixedWidth;

        public static int BitCount => (int)Width;

        public FixedWidth FixedWidth { [MethodImpl(Inline)] get=> Width;}
    }
}