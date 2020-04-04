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

    public readonly struct I8 : INumericKind<sbyte> 
    { 
        [MethodImpl(Inline)]
        public static implicit operator NK(I8 src) => NK.I8; 

        [MethodImpl(Inline)]
        public static implicit operator I8(NK<sbyte> src) => default;

        [MethodImpl(Inline)]
        public static implicit operator NK<sbyte>(I8 src) => default;
    }
}