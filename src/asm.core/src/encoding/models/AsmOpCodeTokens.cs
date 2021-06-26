//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct AsmOpCodeTokens
    {
        [Flags]
        public enum TokenKind : byte
        {
            None = 0,

            Prefix = 1,

            RegExtension = 2,

            RegOpCodeMod = 4,

            SegOverride = 8,

            Offset = 16,

            ImmSize = 32,
        }

        [SymbolSource]
        public enum Prefix : byte
        {
            [Symbol("66")]
            x66 = 0,

            [Symbol("F2")]
            F2 = 1,

            [Symbol("F3")]
            F3 = 2,

            [Symbol("0F")]
            x0F = 3,

            [Symbol("0F38")]
            x0F38 = 4,

            [Symbol("VEX")]
            VEX = 5,

            [Symbol("REX")]
            Rex = 6,

            [Symbol("REX.W")]
            RexW = 7,

            [Symbol("LZ")]
            LZ = 8,

            [Symbol("LIG")]
            LIG = 9,

            [Symbol("WIG")]
            WIG = 10,

            [Symbol("W0")]
            W0 = 11,

            [Symbol("W1")]
            W1 = 12,
        }

        [SymbolSource]
        public enum Offset : byte
        {
            [Symbol("cb", "Indicates a 1-byte value follows the opcode to specify a code offset and/or new value for the code segment register")]
            cb,

            [Symbol("cw", "Indicates a 2-byte value follows the opcode to specify a code offset and/or new value for the code segment register")]
            cw,

            [Symbol("cd", "Indicates a 4-byte value follows the opcode to specify a code offset and/or new value for the code segment register")]
            cd,

            [Symbol("cp", "Indicates a 6-byte value follows the opcode to specify a code offset and/or new value for the code segment register")]
            cp,

            [Symbol("co", "Indicates an 8-byte value follows the opcode to specify a code offset and/or new value for the code segment register")]
            co,

            [Symbol("ct", "Indicates a 10-byte value follows the opcode to specify a code offset and/or new value for the code segment register")]
            ct,
        }

        [SymbolSource]
        public enum SegOverride : byte
        {
            [Symbol("cs", "CS segment override")]
            CS,

            [Symbol("ss", "SS segment override")]
            SS,

            [Symbol("ds", "DS segment override")]
            DS,

            [Symbol("es", "ES segment override")]
            ES,

            [Symbol("fs", "FS segment override")]
            FS,

            [Symbol("gs", "GS segment override")]
            GS,
        }

        [SymbolSource("Specifies a '/r' token where r = 0..7. A digit between 0 and 7 indicates that the ModR/M byte of the instruction uses only the r/m (register or memory) operand. The reg field contains the digit that provides an extension to the instruction's opcode.")]
        public enum RegDigitCode : byte
        {
            [Symbol("/0", "Indicates the ModR/M byte of the instruction uses only the r/m operand; The register field digit 0 provides an extension to the instruction's opcode")]
            r0,

            [Symbol("/1", "The ModR/M byte of the instruction uses only the r/m operand; The register field digit 1 provides an extension to the instruction's opcode")]
            r1,

            [Symbol("/2", "The ModR/M byte of the instruction uses only the r/m operand; The register field digit 2 provides an extension to the instruction's opcode")]
            r2,

            [Symbol("/3", "The ModR/M byte of the instruction uses only the r/m operand; The register field digit 3 provides an extension to the instruction's opcode")]
            r3,

            [Symbol("/4", "The ModR/M byte of the instruction uses only the r/m operand; The register field digit 4 provides an extension to the instruction's opcode")]
            r4,

            [Symbol("/5", "The ModR/M byte of the instruction uses only the r/m operand; The register field digit 5 provides an extension to the instruction's opcode")]
            r5,

            [Symbol("/6", "The ModR/M byte of the instruction uses only the r/m operand; The register field digit 6 provides an extension to the instruction's opcode")]
            r6,

            [Symbol("/7", "The ModR/M byte of the instruction uses only the r/m operand; The register field digit 7 provides an extension to the instruction's opcode")]
            r7,
        }

        [SymbolSource("Defines symbols that modify the op code value")]
        public enum RegOpCodeMod
        {
            [Symbol("+rb", "For an 8-bit register, indicates the four bit field of REX.b and opcode[2:0] field encodes the register operand of the instruction")]
            rb,

            [Symbol("+rw", "For a 16-bit register, indicates the four bit field of REX.b and opcode[2:0] field encodes the register operand of the instruction")]
            rw,

            [Symbol("+rd", "For a 32-bit register, indicates the four bit field of REX.b and opcode[2:0] field encodes the register operand of the instruction")]
            rd,

            [Symbol("+ro", "For a 64-bit register, indicates the four bit field of REX.b and opcode[2:0] field encodes the register operand of the instruction")]
            ro,
        }

        [SymbolSource("Specifies the size of an immediate operand in the context of an opcode specification")]
        public enum ImmSizeKind : byte
        {
            [Symbol("ib", "Indicates a 1-byte immediate operand to the instruction that follows the opcode or ModR/M bytes or scale-indexing bytes.")]
            ib,

            [Symbol("iw", "Indicates a 2-byte immediate operand to the instruction that follows the opcode or ModR/M bytes or scale-indexing bytes.")]
            iw,

            [Symbol("id", "Indicates a 4-byte immediate operand to the instruction that follows the opcode or ModR/M bytes or scale-indexing bytes.")]
            id,

            [Symbol("io", "Indicates An 8-byte immediate operand to the instruction that follows the opcode or ModR/M bytes or scale-indexing bytes")]
            io,
        }

        public static ReadOnlySpan<Prefix> Prefixes
            => new Prefix[]{Prefix.x66,Prefix.F2,Prefix.F3,Prefix.x0F,Prefix.x0F38, Prefix.Rex, Prefix.RexW, Prefix.VEX, Prefix.LZ,Prefix.LIG, Prefix.WIG, Prefix.W0, Prefix.W1};

        public static ReadOnlySpan<SegOverride> SegOverrides
            => new SegOverride[]{SegOverride.CS, SegOverride.SS, SegOverride.DS, SegOverride.ES, SegOverride.FS, SegOverride.GS};

        public static ReadOnlySpan<RegOpCodeMod> RegOpCodeMods
            => new RegOpCodeMod[]{RegOpCodeMod.rb, RegOpCodeMod.rw, RegOpCodeMod.rd,  RegOpCodeMod.ro};

        public static ReadOnlySpan<RegDigitCode> RegExtensions
            => new RegDigitCode[]{RegDigitCode.r0, RegDigitCode.r1,RegDigitCode.r2,RegDigitCode.r3,RegDigitCode.r4,RegDigitCode.r5,RegDigitCode.r6,RegDigitCode.r7};

        public static ReadOnlySpan<Offset> Offsets
            => new Offset[]{Offset.cb, Offset.cw, Offset.cd, Offset.cp, Offset.co, Offset.ct};

        public static ReadOnlySpan<ImmSizeKind> ImmSizes
            => new ImmSizeKind[]{ImmSizeKind.ib, ImmSizeKind.iw, ImmSizeKind.id, ImmSizeKind.io};


        public readonly struct ImmSize
        {
            public ImmSizeKind Token {get;}

            [MethodImpl(Inline)]
            public ImmSize(ImmSizeKind src)
            {
                Token = src;
            }

            [MethodImpl(Inline)]
            public static implicit operator ImmSize(ImmSizeKind src)
                => new ImmSize(src);

            [MethodImpl(Inline)]
            public static implicit operator ImmSizeKind(ImmSize src)
                => src.Token;

            [MethodImpl(Inline)]
            public static explicit operator byte(ImmSize src)
                => (byte)src.Token;
        }

        /// <summary>
        /// Represents a register digit 0..7 that occurs within an op code expression
        /// </summary>
        public struct RegDigit
        {
            public RegDigitCode _Code;

            [MethodImpl(Inline)]
            public RegDigit(RegDigitCode code)
                => _Code = code;

            public byte Encoded
            {
                [MethodImpl(Inline)]
                get => (byte)_Code;
            }

            public RegDigitCode Code()
                => _Code;

            public void Code(RegDigitCode code)
                => _Code = code;

            [MethodImpl(Inline)]
            public static implicit operator RegDigit(byte src)
                => new RegDigit((RegDigitCode)src);

            [MethodImpl(Inline)]
            public static implicit operator RegDigit(RegDigitCode src)
                => new RegDigit(src);

            [MethodImpl(Inline)]
            public static explicit operator byte(RegDigit src)
                => src.Encoded;
        }
    }
}