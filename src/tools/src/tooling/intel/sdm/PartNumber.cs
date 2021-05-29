//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    using System;
    using System.Runtime.CompilerServices;

    using static core;
    using static Root;

    partial struct IntelSdm
    {
        public readonly struct PartNumber
        {
            readonly Cell32 Data;

            [MethodImpl(Inline)]
            public PartNumber(byte a0)
            {
                Data = Cells.cell(a0,z8,z8,z8);
            }

            [MethodImpl(Inline)]
            public PartNumber(byte a0, byte a1)
            {
                Data = Cells.cell(a0, a1, z8, z8);
            }

            [MethodImpl(Inline)]
            public PartNumber(byte a0, byte a1, byte a2)
            {
                Data = Cells.cell(a0, a1, a2, z8);
            }

            [MethodImpl(Inline)]
            public PartNumber(byte a0, byte a1, byte a2, byte a3)
            {
                Data = Cells.cell(a0, a1, a2, a3);
            }


            internal ReadOnlySpan<byte> Bytes
            {
                [MethodImpl(Inline)]
                get => Data.Bytes;
            }
        }
    }
}