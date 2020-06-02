//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    using NK = NumericKind;

    public readonly struct U32 : INumericKind<uint>
    {
        [MethodImpl(Inline)]
        public static implicit operator NK(U32 src) => NK.U32; 

        [MethodImpl(Inline)]
        public static implicit operator U32(NK<uint> src) => default;

        [MethodImpl(Inline)]
        public static implicit operator NK<uint>(U32 src) => default;
    }

}