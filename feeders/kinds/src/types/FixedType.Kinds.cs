//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Kinds;

    public readonly struct FixedType<F> : IFixedKind<F>
        where F : unmanaged, IFixed
    {
        public static int BitCount => bitsize<F>();

        public FixedWidth FixedWidth { [MethodImpl(Inline)] get=> (FixedWidth) BitCount;}
    }

}