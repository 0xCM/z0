//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Encoding
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Analogs;
    
    /// <summary>
    /// Defines a byte that follows an opcode that specifies either
    /// a) two register operands or,
    /// b) one register operand and a memory operand together with an addressing mode
    /// </summary>
    public struct ModRm
    {   
        /// <summary>
        /// Defines bits [2:0] of the modrm byte
        /// </summary>
        /// <remarks>
        /// Designates a register or, if joined with the mod field, it can
        /// encode an addressing mode
        /// </remarks>
        public uint3_t rm;

        /// <summary>
        /// Defines bits [5:3] of the modrm byte
        /// </summary>
        /// <remarks>
        /// Designates either a register number or 3 more bits of opcode data; the
        /// primary opcode reveals the agenda of this field
        /// </remarks>
        public uint3_t reg;

        /// <summary>
        /// Defines bits [7:6] of the modrm byte
        /// </summary>
        /// <remarks>
        /// When mod and rm fields are joined, it creates as surface for 32 possible values
        /// comprising 8 registers and 24 addressing modes
        /// </remarks>
        public uint2_t mod;

        [MethodImpl(Inline)]
        public static implicit operator ModRm(byte src)
            => new ModRm(src);

        [MethodImpl(Inline)]
        public ModRm(byte src)
        {
            rm = uint3(src);
            reg = uint3(src >> 3);
            mod = uint2(src >> 6);
        }

        public byte Encoded
        {
            [MethodImpl(Inline)]
            get => math.or((byte)rm, (byte)((byte)reg << 3), (byte)((byte)mod << 6));
        }

        [MethodImpl(Inline)]
        public string Format()
            => BitFormatter.format(Encoded);

        public override string ToString()
            => Format();
    }
}