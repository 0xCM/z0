//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;
    using static ImmOps;
     
    public readonly struct ImmOp : IImmOp        
    {
        readonly ulong Data;

        public DataWidth Width {get;}

        [MethodImpl(Inline)]
        public ImmOp(byte data)
        {
            Data = data;
            Width = DataWidth.W8;
        }

        [MethodImpl(Inline)]
        public ImmOp(ushort data)
        {
            Data = data;
            Width = DataWidth.W16;
        }

        [MethodImpl(Inline)]
        public ImmOp(uint data)
        {
            Data = data;
            Width = DataWidth.W32;
        }

        [MethodImpl(Inline)]
        public ImmOp(ulong data)
        {
            Data = data;
            Width = DataWidth.W64;
        }

        public imm8 Imm8
        {
            [MethodImpl(Inline)]
            get => (byte)Data;
        }

        public imm16 Imm16
        {
            [MethodImpl(Inline)]
            get => (ushort)Data;
        }

        public imm32 Imm32
        {
            [MethodImpl(Inline)]
            get => (uint)Data;
        }

        public imm64 Imm64
        {
            [MethodImpl(Inline)]
            get => Data;
        }
    }
}