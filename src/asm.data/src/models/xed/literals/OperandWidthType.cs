//-----------------------------------------------------------------------------
// Copyright   : Intel Corporation, 2020
// License     : Apache
// Source      : xed-operand-width-enum.h
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct XedModels
    {
        [SymbolSource(xed)]
        public enum OperandWidthType : byte
        {
            None,

            ASZ,

            SSZ,

            PSEUDO,

            PSEUDOX87,

            A16,

            A32,

            [Symbol("b")]
            B,

            [Symbol("d")]
            D,

            [Symbol("i8")]
            I8,

            [Symbol("u8")]
            U8,

            [Symbol("i16")]
            I16,

            [Symbol("u16")]
            U16,

            [Symbol("i32")]
            I32,

            [Symbol("u32")]
            U32,

            [Symbol("i64")]
            I64,

            [Symbol("u64")]
            U64,

            [Symbol("f16")]
            F16,

            [Symbol("f32")]
            F32,

            [Symbol("f64")]
            F64,

            [Symbol("dq")]
            DQ,

            XUB,

            XUW,

            [Symbol("xud")]
            XUD,

            [Symbol("xuq")]
            XUQ,

            X128,

            XB,

            XW,

            XD,

            XQ,

            ZB,

            ZW,

            ZD,

            ZQ,

            MB,

            MW,

            MD,

            MQ,

            [Symbol("m64int")]
            M64INT,

            [Symbol("m64real")]
            M64REAL,

            [Symbol("mem108")]
            MEM108,

            [Symbol("mem14")]
            MEM14,

            [Symbol("mem16")]
            MEM16,

            [Symbol("mem16int")]
            MEM16INT,

            MEM28,

            MEM32INT,

            MEM32REAL,

            MEM80DEC,

            MEM80REAL,

            F80,

            MEM94,

            MFPXENV,

            MXSAVE,

            MPREFETCH,

            P,

            P2,

            PD,

            PS,

            PI,

            Q,

            S,

            S64,

            SD,

            SI,

            SS,

            [Symbol("v")]
            V,

            [Symbol("y")]
            Y,

            W,

            Z,

            SPW8,

            SPW,

            SPW5,

            SPW3,

            SPW2,

            I1,

            I2,

            I3,

            I4,

            I5,

            I6,

            I7,

            VAR,

            [Symbol("bnd32")]
            BND32,

            [Symbol("bnd64")]
            BND64,

            PMMSZ16,

            PMMSZ32,

            QQ,

            YUB,

            YUW,

            YUD,

            YUQ,

            Y128,

            YB,

            YW,

            YD,

            YQ,

            YPS,

            YPD,

            ZBF16,

            VV,

            ZV,

            WRD,

            [Symbol("mskw")]
            MSKW,

            ZMSKW,

            ZF32,

            ZF64,

            ZUB,

            ZUW,

            ZUD,

            ZUQ,

            ZI8,

            ZI16,

            ZI32,

            ZI64,

            ZU8,

            ZU16,

            ZU32,

            ZU64,

            ZU128,

            M384,

            M512,

            PTR,

            TMEMROW,

            TMEMCOL,

            TV,
        }
    }
}