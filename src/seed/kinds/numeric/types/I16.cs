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

    public readonly struct I16 : INumericKind<short> 
    {
        [MethodImpl(Inline)]
        public static implicit operator NK(I16 src) => NK.I16; 

        [MethodImpl(Inline)]
        public static implicit operator I16(NK<short> src) => default;

        [MethodImpl(Inline)]
        public static implicit operator NK<short>(I16 src) => default;
    }

}