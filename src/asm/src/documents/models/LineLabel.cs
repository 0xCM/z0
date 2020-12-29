//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct AsmDocParts
    {
        public readonly struct LineLabel
        {
            internal ulong Offset {get;}

            internal DataWidth Width {get;}

            [MethodImpl(Inline)]
            internal LineLabel(byte offset)
            {
                Offset = offset;
                Width = DataWidth.W8;
            }

            [MethodImpl(Inline)]
            internal LineLabel(ushort offset)
            {
                Offset = offset;
                Width = DataWidth.W16;
            }

            [MethodImpl(Inline)]
            internal LineLabel(uint offset)
            {
                Offset = offset;
                Width = DataWidth.W32;
            }

            [MethodImpl(Inline)]
            internal LineLabel(ulong offset)
            {
                Offset = offset;
                Width = DataWidth.W64;
            }
        }
    }
}