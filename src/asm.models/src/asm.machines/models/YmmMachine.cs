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

    public readonly ref struct YmmMachine
    {
        public const byte RegisterCount = 16;

        readonly NatSpan<N16,Ymm> Registers;

        [MethodImpl(Inline)]
        internal YmmMachine(Ymm[] src)
        {
            Registers = NatSpan.load(src,n16);
        }
    }
}