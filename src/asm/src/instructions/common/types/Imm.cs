//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;

    partial class InstructionModels
    {
        [MethodImpl(Inline)]
        public static Imm8 imm8(byte src)
            => src;

        [MethodImpl(Inline)]
        public static Imm16 imm16(ushort src)
            => src;

        [MethodImpl(Inline)]
        public static Imm32 imm32(uint src)
            => src;

        [MethodImpl(Inline)]
        public static Imm64 imm64(ulong src)
            => src;

        public readonly struct Imm : IImm
        {
            readonly byte[] Cells;

            public OperandSize Width {get;}

            [MethodImpl(Inline)]
            public Imm(byte[] data)
            {
                Cells = data;
                Width = (OperandSize)(data.Length * 8);
            }

            public ReadOnlySpan<byte> Data
            {
                [MethodImpl(Inline)]
                get => Cells;
            }        
        }
    }
}