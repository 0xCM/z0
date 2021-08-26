//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using llvm;

    using static Root;
    using static core;


    public partial class AsmEncoder : Service<AsmEncoder>
    {
        public byte Encode(AsmId id, Span<byte> dst)
        {
            var size = z8;

            return size;
        }

        public byte Encode(AsmId id, in AsmOperand a, Span<byte> dst)
        {
            var size = z8;

            return size;
        }

        public byte Encode(AsmId id, in AsmOperand a, in AsmOperand b, Span<byte> dst)
        {
            var size = z8;

            return size;
        }

        public byte Encode(AsmId id, in AsmOperand a, in AsmOperand b, in AsmOperand c, Span<byte> dst)
        {
            var size = z8;

            return size;
        }

        public byte Encode(AsmId id, in AsmOperand a, in AsmOperand b, in AsmOperand c, in AsmOperand d, Span<byte> dst)
        {
            var size = z8;

            return size;
        }

    }
}