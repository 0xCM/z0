//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static BitSet;
        
    public struct SimpleEncoding
    {
        public byte Code;

        public ModRm ModRm;

        public static SimpleEncoding Example 
            => encode(0x38, ModRm.Define(RegisterCode.r6, RegisterCode.r1));        

        public static SimpleEncoding encode(byte code, ModRm modRm)
            => new SimpleEncoding(code,modRm);

        public SimpleEncoding(byte code, ModRm modRm)
        {
            this.Code = code;
            this.ModRm = modRm;
        }
        
        public uint Encoded
        {
            get => ((uint)ModRm.Encoded << 8) |  (uint)Code;
        }

        public string Format()
            => Encoded.FormatHex(false,true,true);            
    }

    /// <summary>
    /// Defines a byte that follows an opcode that specifies either
    /// a) two register operands or,
    /// b) one register operand and a memory operand together with an addressing mode
    /// </summary>
    /// <remarks>See Section 1.4 of vol 3 in AMD's manual</remarks>
    public struct ModRm
    {   
        [MethodImpl(Inline)]
        public static ModRm Define(RegisterCode r0, RegisterCode r1, Duet mod = Duet.b11)
            => new ModRm((Triad)r0, (Triad)r1, mod);

        /// <summary>
        /// Defines bits [2:0] of the modrm byte
        /// </summary>
        /// <remarks>
        /// Designates a register or, if joined with the mod field, it can
        /// encode an addressing mode
        /// </remarks>
        public triad rm;

        /// <summary>
        /// Defines bits [5:3] of the modrm byte
        /// </summary>
        /// <remarks>
        /// Designates either a register number or 3 more bits of opcode data; the
        /// primary opcode reveals the agenda of this field
        /// </remarks>
        public triad reg;

        /// <summary>
        /// Defines bits [7:6] of the modrm byte
        /// </summary>
        /// <remarks>
        /// When mod and rm fields are joined, it creates as surface for 32 possible values
        /// comprising 8 registers and 24 addressing modes
        /// </remarks>
        public duet mod;

        [MethodImpl(Inline)]
        public static implicit operator ModRm(byte src)
            => new ModRm(src);

        public ModRm(Triad rm, Triad reg, Duet mod = Duet.b11)
        {
            this.rm = rm;
            this.reg = reg;
            this.mod = mod;
        }

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