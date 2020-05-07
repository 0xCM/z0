//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using NK = NumericKind;

    using static Seed;

    partial class NumericKinds
    {            
        /// <summary>
        /// Specifies the C# keyword used to designate a kind-identified primal type
        /// </summary>
        [Op]
        public static string keyword(NumericKind k)
            => k switch {
                NK.U8 => "byte",
                NK.I8 => "sbyte",
                NK.U16 => "ushort",
                NK.I16 => "short",
                NK.U32 => "uint",
                NK.I32 => "int",
                NK.I64 => "long",
                NK.U64 => "ulong",
                NK.F32 => "float",
                NK.F64 => "double",
                 _ => string.Empty
           };

        /// <summary>
        /// Specifies the keyword not used in C# to designate a kind-identified primal type
        /// </summary>
        [Op]
        public static string nonkeyword(NumericKind k)
            => k switch {
                NK.U8 => "uint8",
                NK.I8 => "int8",
                NK.U16 => "uint16",
                NK.I16 => "int16",
                NK.U32 => "uint32",
                NK.I32 => "int32",
                NK.I64 => "int64",
                NK.U64 => "uint64",
                NK.F32 => "float32",
                NK.F64 => "float64",
                 _ => string.Empty
           };

    }
}