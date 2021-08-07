//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    [Record(TableId)]
    public struct AsmDisassembly : IRecord<AsmDisassembly>
    {
        public const string TableId = "asm.disassembly";

        public const byte FieldCount = 4;

        public MemoryAddress Offset;

        public AsmExpr Statement;

        public AsmHexCode Code;

        public AsmBitstring Bitstring;

        [MethodImpl(Inline)]
        public AsmDisassembly(MemoryAddress offset, AsmExpr expr, AsmHexCode code, AsmBitstring bs)
        {
            Offset = offset;
            Statement = expr;
            Code = code;
            Bitstring = bs;
        }

        [MethodImpl(Inline)]
        public AsmDisassembly(MemoryAddress offset, AsmExpr expr)
        {
            Offset = offset;
            Statement = expr;
            Code = AsmHexCode.Empty;
            Bitstring = AsmBitstring.Empty;
        }

        public static ReadOnlySpan<byte> RenderWidths => new byte[FieldCount]{12,64,32,32};
    }
}