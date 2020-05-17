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


    class ModRmByte
    {

        public enum OpCodes : byte
        {
            Cmp = 0x38,            
        }

        public enum R8 : byte
        {
            al = 0b000,
            
            cl = 0b001,
            
            dl = 0b010,
            
            bl = 0b011,
            
            ah = 0b100,

            ch = 0b101,
            
            dh = 0b110,

            bh = 0b111,
        }

        public struct Encoding
        {
            public OpCodes Code;

            public ModRM ModRm;

            public static Encoding encode(OpCodes code, ModRM modRm)
                => new Encoding(code,modRm);

            public Encoding(OpCodes code, ModRM modRm)
            {
                this.Code = code;
                this.ModRm = modRm;
            }
            
            public uint Encoded
            {
                get => (ModRm.Encoded << 8) |  (uint)Code;
            }

            public string Format()
                => Encoded.FormatHex(false,true,true);
            
        }

        public struct ModRM
        {
            public static ModRM Define(R8 r0, R8 r1, BinaryKind2 mod = BinaryKind2.b11)
                => new ModRM((BinaryKind3)r0, (BinaryKind3)r1, mod);

            public ModRM(BinaryKind3 rm, BinaryKind3 reg, BinaryKind2 mod = BinaryKind2.b11)
            {
                this.rm = rm;
                this.reg = reg;
                this.mod = mod;
            }

            public BinaryKind3 rm;

            public BinaryKind3 reg;

            public BinaryKind2 mod;

            public uint Encoded
            {
                get => ((uint)mod << 6) | ((uint)reg << 3) | (uint)rm;
            }
        }

        public static Encoding Example 
            => Encoding.encode(OpCodes.Cmp, ModRM.Define(R8.dh, R8.cl));


        const uint CMP_ENCODED = 0xCE38;



    }
    
    /// <summary>
    /// Defines a byte that follows an opcode that specifies either
    /// a) two register operands or,
    /// b) one register operand and a memory operand together with an addressing mode
    /// </summary>
    /// <remarks>See Section 1.4 of vol 3 in AMD's manual</remarks>
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