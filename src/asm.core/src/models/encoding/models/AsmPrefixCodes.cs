//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static Hex8Seq;

    using H = Hex8Seq;

    public readonly struct AsmPrefixCodes
    {
        public static RexPrefixCode RexW => RexPrefixCode.W;

        public static RexPrefixCode RexB => RexPrefixCode.B;

        /// <summary>
        /// Classifies prefix domains
        /// </summary>
        public enum PrefixKind : byte
        {
            None = 0,

            [Domain(typeof(SegOverrideCode))]

            SegOverride = 2,

            [Domain(typeof(SizeOverrideCode))]
            SizeOverride = 3,

            [Domain(typeof(EscapeCode))]
            Escape = 4,

            [Domain(typeof(LockPrefixCode))]
            Lock = 5,

            [Domain(typeof(BndPrefixCode))]
            Bnd = 6,

            [Domain(typeof(BranchHintCode))]
            BranchHint = 7,

            [Domain(typeof(RepPrefixCode))]
            Rep = 8,

            [Domain(typeof(MandatoryPrefixCode))]
            Mandatory = 9,

            [Domain(typeof(RexPrefixCode))]
            Rex = 10,

            Vex = 11,
        }

        /// <summary>
        /// Defines the lock prefix code
        /// </summary>
        [SymSource]
        public enum LockPrefixCode : byte
        {
            None = 0,

            [Symbol("f0", "Lock Prefix")]
            LOCK = xf0,
        }

        [SymSource]
        public enum BranchHintCode : byte
        {
            None = 0,

            /// <summary>
            /// Branch taken
            /// </summary>
            [Symbol("BT", "2e - Branch Taken")]
            BT = x2e,

            /// <summary>
            /// Branch not taken
            /// </summary>
            [Symbol("BT", "3e - Branch Not Taken")]
            BNT = x3e,
        }

        [SymSource]
        public enum SizeOverrideCode
        {
            None = 0,

            /// <summary>
            /// Operand size override
            /// </summary>
            /// <remarks>
            /// The operand-size override prefix allows a program to switch between 16- and 32-bit operand sizes.
            /// Either size can be the default; use of the prefix selects the non-default size
            /// </remarks>
            [Symbol("66","Operand size override")]
            OPSZ = x66,

            /// <summary>
            /// Address size override
            /// </summary>
            /// <remarks>
            /// The address-size override prefix allows programs to switch between 16- and 32-bit addressing.
            /// Either size can be the default; the prefix selects the non-default size
            /// </remarks>
            [Symbol("67", "Address size override")]
            ADSZ = x67,
        }

        /// <summary>
        /// Defines the mandatory prefix codes as specified by Intel Vol II, 2.1.2
        /// </summary>
        [SymSource]
        public enum MandatoryPrefixCode : byte
        {
            None = 0,

            [Symbol("66")]
            x66 = H.x66,

            [Symbol("f2")]
            F2 = xf2,

            [Symbol("f3")]
            F3 = xf3,
        }

        [SymSource]
        public enum EscapeCode : ushort
        {
            None = 0,

            [Symbol("0f")]
            x0F = 0x0F,

            [Symbol("0f 38")]
            x0F38 = 0x0F38,

            [Symbol("0f 3a")]
            x0F3A = 0x0F3A,
        }

        [SymSource]
        public enum BndPrefixCode : byte
        {
            None = 0,

            [Symbol("BND")]
            BND = xf2
        }

        /// <summary>
        /// The segment override codes as specified by Intel Vol II, 2.1.1
        /// </summary>
        public enum SegOverrideCode : byte
        {
            None = 0,

            [Symbol("cs", "CS segment override")]
            CS = x2e,

            [Symbol("ss", "SS segment override")]
            SS = x36,

            [Symbol("ds","DS segment override")]
            DS = x3e,

            [Symbol("es", "ES segment override")]
            ES = x26,

            [Symbol("fs", "FS segment override")]
            FS = x64,

            [Symbol("gs", "GS segment override")]
            GS = x65,
        }

        [SymSource]
        public enum VsibField : byte
        {
            /// <summary>
            /// VSIB.base, Bits [3:0]
            /// </summary>
            [Symbol("base")]
            Base = 0,

            /// <summary>
            /// VSIB.index, Bits [5:3]
            /// </summary>
            [Symbol("index")]
            Index = 3,

            /// <summary>
            /// VSIB.SS, Bits [7:6]
            /// </summary>
            [Symbol("SS")]
            SS = 6,
        }

        /// <summary>
        /// Classfies vex prefix codes
        /// </summary>
        [SymSource]
        public enum VexPrefixKind : byte
        {
            [Symbol("xC4", "The leading byte of a 3-byte vex prefix sequence")]
            xC4 = H.xc4,

            [Symbol("xC5", "The leading byte of a 2-byte vex prefix sequence")]
            xC5 = H.xc5,
        }

        /// <summary>
        /// Defines REX field identifiers
        /// </summary>
        [SymSource]
        public enum RexFieldIndex : byte
        {
            [Symbol("b")]
            B = 0,

            [Symbol("x")]
            X = 1,

            [Symbol("r")]
            R = 2,

            [Symbol("w")]
            W = 3,
        }

        /// <summary>
        /// [0100 0001] | W:0 | R:0 | X:0 | B:1
        /// </summary>
        [Flags]
        public enum RexPrefixCode : byte
        {
            /// <summary>
            /// [0100 0000] => [W:0 | R:0 | X:0 | B:0]
            /// </summary>
            [Symbol("REX", "[0100 0000] => [W:0 | R:0 | X:0 | B:0]")]
            Base = x40,

            /// <summary>
            /// Extends one of:
            /// - The reg field in the ModR/M byte
            /// - The index field in the SIB byte
            /// - The reg field in the opcode byte
            /// </summary>
            [Symbol("REX.B", "[0100 0001] => [W:0 | R:0 | X:0 | B:1]")]
            B = x41,

            /// <summary>
            /// Extends the index field in the SIB byte
            /// </summary>
            [Symbol("REX.X", "[0100 0010] => [W:0 | R:0 | X:1 | B:0]")]
            X = x42,

            /// <summary>
            /// Extends the reg field in the ModR/M byte
            /// </summary>
            [Symbol("REX.R", "[0100 0100] =>[W:0 | R:1 | X:0 | B:0]")]
            R = x44,

            /// <summary>
            /// Wide, enables 64-bit execution
            /// </summary>
            [Symbol("REX.W", "[0100 1000] => [W:1 | R:0 | X:0 | B:0]")]
            W = x48,
        }

        [SymSource]
        public enum RepPrefixCode : byte
        {
            None = 0,

            [Symbol("F2")]
            REPNZ = xf2,

            [Symbol("F3")]
            REPZ = xf3,
        }
    }
}