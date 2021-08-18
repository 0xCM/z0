//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static Hex8Seq;
    using static Pow2x8;

    using H = Hex8Seq;
    using K = AsmPrefixCodes.LegacyPrefixKind;

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

            [Domain(typeof(RepeatPrefixCode))]
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
            [Symbol("x66","Operand size override")]
            OPSZ = x66,

            /// <summary>
            /// Address size override
            /// </summary>
            /// <remarks>
            /// The address-size override prefix allows programs to switch between 16- and 32-bit addressing.
            /// Either size can be the default; the prefix selects the non-default size
            /// </remarks>
            [Symbol("x64", "Address size override")]
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
        /// Unifies the legacy prefix codes
        /// </summary>
        [SymSource]
        public enum LegacyPrefixCode : byte
        {
            None = 0,

            [Symbol("ES", "Seg override prefix, x26")]
            ES = SegOverrideCode.ES,

            [Symbol("CS", "Seg override prefix, x2E")]
            CS = SegOverrideCode.CS,

            [Symbol("BT", "Branch hint prefix, x2E")]
            BT = BranchHintCode.BT,

            [Symbol("DS", "Seg override prefix, x3E")]
            DS = SegOverrideCode.DS,

            [Symbol("BNT", "Branch hint prefix, x3E")]
            BNT = BranchHintCode.BNT,

            [Symbol("OPSZ", "Seg override prefix, x66")]
            OPSZ = SizeOverrideCode.OPSZ,

            [Symbol("FS", "Seg override prefix, x64")]
            FS = SegOverrideCode.FS,

            [Symbol("GS", "Seg override prefix, x65")]
            GS = SegOverrideCode.GS,

            [Symbol("x66", "Mandatory prefix, x66")]
            x66 = MandatoryPrefixCode.x66,

            [Symbol("ADSZ", "Address size override,  x67")]
            ADSZ = SizeOverrideCode.ADSZ,

            [Symbol("SS", "Seg override prefix, x36")]
            SS = SegOverrideCode.SS,

            [Symbol("LOCK", "Lock prefix, xF0")]
            LOCK = LockPrefixCode.LOCK,

            [Symbol("F2", "Mandatory prefix, xF2")]
            F2 = MandatoryPrefixCode.F2,

            [Symbol("F3", "Mandatory prefix, xF3")]
            F3 = MandatoryPrefixCode.F3,

            [Symbol("REPNZ", "Repeat prefix, xF2")]
            REPNZ = RepeatPrefixCode.REPNZ,

            [Symbol("REPZ", "Repeat prefix, xF3")]
            REPZ = RepeatPrefixCode.REPZ,

            [Symbol("BND", "BND prefix, xF2")]
            BND = BndPrefixCode.BND,
        }

        /// <summary>
        /// Defines legacy prefix classifiers
        /// </summary>
        [Flags]
        public enum LegacyPrefixKind : byte
        {
            None = 0,

            Lock = P2ᐞ00,

            Repeat = P2ᐞ01,

            Bnd = P2ᐞ02,

            SegOverride = P2ᐞ03,

            BranchHint = P2ᐞ04,

            OperandSizeOverride = P2ᐞ05,

            AddressSizeOverride = P2ᐞ06
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

            Code = 4,
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
        public enum RepeatPrefixCode : byte
        {
            None = 0,

            [Symbol("f2")]
            REPNZ = xf2,

            [Symbol("f3")]
            REPZ = xf3,
        }

        /// <summary>
        /// Partitions legacy prefixes according to Intel V2.2-1
        /// </summary>
        [Flags]
        public enum LegacyPrefixGroup : byte
        {
            None = 0,

            Group1 = K.Lock | K.Repeat | K.Bnd,

            Group2 = K.SegOverride | K.BranchHint,

            Group3 = K.OperandSizeOverride,

            Group4 = K.AddressSizeOverride,
        }
    }
}