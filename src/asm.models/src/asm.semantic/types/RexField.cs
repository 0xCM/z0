//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct AsmSemantic
    {
        public readonly struct RexField
        {
            readonly uint4 Data;

            [MethodImpl(Inline)]
            public RexField(uint4 src)
                => Data = src;

            public uint1 B
            {
                [MethodImpl(Inline)]
                get => (uint1)Data;
            }

            public uint1 X
            {
                [MethodImpl(Inline)]
                get => (uint1)(Data >> 1);
            }

            public uint1 R
            {
                [MethodImpl(Inline)]
                get => (uint1)(Data >> 2);
            }

            public uint1 W
            {
                [MethodImpl(Inline)]
                get => (uint1)(Data >> 3);
            }

        }
    }
}