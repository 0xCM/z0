//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Dsl
{        
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;
     
    public readonly struct imm : IImmOp        
    {
        readonly ulong Data;

        public DataWidth Width {get;}

        [MethodImpl(Inline)]
        public imm(byte data)
        {
            Data = data;
            Width = DataWidth.W8;
        }

        [MethodImpl(Inline)]
        public imm(ushort data)
        {
            Data = data;
            Width = DataWidth.W16;
        }

        [MethodImpl(Inline)]
        public imm(uint data)
        {
            Data = data;
            Width = DataWidth.W32;
        }

        [MethodImpl(Inline)]
        public imm(ulong data)
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