//-----------------------------------------------------------------------------
// Copyright   : Intel Corporation, 2020
// License     : Apache
// Source      : xed-iclass-enum.h
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct XedModels
    {
        /// <summary>
        /// datafiles/xed-operand-types.txt
        /// </summary>
        [SymSource(xed)]
        public enum OperandType : byte
        {
            [Symbol("i1")]
            I1,

            [Symbol("i8")]
            I8,

            [Symbol("i16")]
            I16,

            [Symbol("i32")]
            I32,

            [Symbol("i64")]
            I64,

            [Symbol("u8")]
            U8,

            [Symbol("u16")]
            U16,

            [Symbol("u64")]
            U64,

            [Symbol("u128")]
            U128,

            [Symbol("u256")]
            U256,

            [Symbol("f32")]
            F32,

            [Symbol("f64")]
            F64,

            [Symbol("f80")]
            F80,

            [Symbol("b80")]
            B80
        }
    }
}