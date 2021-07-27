//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static AsmOpCodes;

    public readonly partial struct IntelOpCodes
    {
        public struct OpCodeRecord
        {
            public AsmOpCodeExpr Expr;

            public AsmSigExpr Sig;

            public EncodingCrossRef EncodingRef;

            public Mode64Kind Mode64;

            public LegacyModeKind LegacyMode;

            public Mode64x32Kind Mode64x32;

            public CpuIdFeature CpuId;

            public TextBlock Description;
        }

        public struct EncodingRecord
        {

        }

        public enum Mode64x32Kind
        {
            None = 0,

            [Symbol("V/V")]
            VV,

            [Symbol("V/N. E.")]
            VNE,

            [Symbol("V 1 /V")]
            V1V,

            [Symbol("V/I 2")]
            VI2,
        }

        public enum EncodingCrossRef : byte
        {
            None,

            [Symbol("A")]
            A,

            [Symbol("B")]
            B,

            [Symbol("C")]
            C,

            [Symbol("RVM")]
            RVM,

            [Symbol("MVR")]
            MVR

        }

        public enum Mode64Kind : byte
        {
            None = 0,

            [Symbol("Valid")]
            Valid,

            [Symbol("N.E.")]
            NE,

            [Symbol("V/N.E.")]
            VNE,
        }

        public enum LegacyModeKind : byte
        {
            None = 0,

            [Symbol("Valid")]
            Valid,

            [Symbol("N.E.")]
            NE,
        }

        [Flags]
        public enum CpuIdFeature : ulong
        {
            None = 0,

            SSE4_1,

            AVX,

            AVX2,

            AVX512F,

            AVX512BW,

            AVX512DQ,
        }

        public enum EncodingExprKind : byte
        {
            None = 0,

            ExplicitReg,

            Imm,

            ModRM,

            Vex,

            Evex,

            Vsib

        }

        public readonly struct EncodingExpr
        {

        }

        public readonly struct OpCodeArithmeticExpr
        {
            // opcode + rd (w)
            // opcode + rd (r)
            // opcode + rd (r, w)

        }

        // AL/AX/EAX/RAX
        public readonly struct ExplicitRegExpr
        {
            readonly ulong Data;
        }

        // imm8
        // imm8/16/32
        public readonly struct ImmExpr
        {
            readonly byte Data;

            [MethodImpl(Inline)]
            public ImmExpr(byte data)
            {
                Data = data;
            }

            public bit Imm8() => (Data & 1) != 0;

            public bit Imm16() => (Data & 2) != 0;

            public bit Imm32() => (Data & 4) != 0;

            public static ImmExpr Empty => default;
        }

        // ModRM:r/m (r)
        // ModRM:r/m (w)
        // ModRM:r/m (r, ModRM:[7:6] must be 11b)
        // ModRM:r/m (w, ModRM:[7:6] must not be 11b)
        // ModRM:reg (r)
        // ModRM:reg (w)
        // ModRM:reg (r,w)
        public readonly struct ModRMExpr
        {
        }

        // VEX.vvvv
        // VEX.vvvv (r, w)
        // VEX.vvvv (r)
        // VEX.1vvv (r)
        public readonly struct VexExpr
        {
        }

        // EVEX.vvvv
        // EVEX.R
        // EVEX.V'
        // EVEX.R'
        // EVEX.vvvv (r)
        // EVEX.RC
        // EVEX.RX
        // EVEX.RXB
        public readonly struct EvexExpr
        {
        }

        // BaseReg (R): VSIB:base, VectorReg(R): VSIB:index
        public readonly struct VsibExpr
        {

        }
    }
}