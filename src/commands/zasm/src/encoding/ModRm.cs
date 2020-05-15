//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Encoding
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    /// <summary>
    /// Defines a byte that follows an opcode that specifies either
    /// a) two register operands or,
    /// b) one register operand and a memory operand together win an addressing mode
    /// </summary>
    public struct ModRm
    {
        byte data;

        [MethodImpl(Inline)]
        public static ModRm Init(byte src)        
            => new ModRm(src);

        [MethodImpl(Inline)]
        ModRm(byte src)
        {
            data = src;
        }

        /// <summary>
        /// The mod field is used with the r/m field to specify the addressing mode for an operand
        /// </summary>
        public byte Mod
        {
            [MethodImpl(Inline)]
            get => Bits.slice(data, 6, 2);
            
            [MethodImpl(Inline)]
            set => data = Bits.copy(value, 6, 2, data);
        }

        public byte Reg
        {
            [MethodImpl(Inline)]
            get => Bits.slice(data, 3, 3);
            
            [MethodImpl(Inline)]
            set => data = Bits.copy(value, 3, 5, data);
        }

        public byte Rm
        {
            [MethodImpl(Inline)]
            get => Bits.slice(data, 0, 3);
            
            [MethodImpl(Inline)]
            set => data = Bits.copy(value, 0, 2, data);
        }
    }
}