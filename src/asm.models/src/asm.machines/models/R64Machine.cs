//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly ref struct R64Machine
    {
        public const byte RegisterCount = 16;

        readonly NatSpan<N16,R64> Registers;

        [MethodImpl(Inline)]
        internal R64Machine(R64[] src)
        {
            Registers = NatSpan.load(src,n16);
        }
    }
}