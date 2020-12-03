//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using NK = NumericKind;
    using TC = System.TypeCode;
    using NI = NumericIndicator;
    using NW = NumericWidth;

    partial class NumericKinds
    {
        /// <summary>
        /// Determines the numeric kind of a system type
        /// </summary>
        /// <param name="src">The source type</param>
        [Op]
        public static NumericKind kind(Type src)
        {
            var k = src.IsEnum
                ? NumericKind.None
                : Type.GetTypeCode(src.EffectiveType())
                switch
                {
                    TC.SByte => NK.I8,
                    TC.Byte => NK.U8,
                    TC.Int16 => NK.I16,
                    TC.UInt16 => NK.U16,
                    TC.Int32 => NK.I32,
                    TC.UInt32 => NK.U32,
                    TC.Int64 => NK.I64,
                    TC.UInt64 => NK.U64,
                    TC.Single => NK.F32,
                    TC.Double => NK.F64,
                    _ => NK.None
                };
            return k;
        }

        /// <summary>
        /// Determines the numeric kind identified by a type code, if any
        /// </summary>
        /// <param name="tc">The type code to evaluate</param>
        [Op]
        public static NumericKind kind(TypeCode tc)
        {
            switch(tc)
            {
                case TC.SByte:
                    return NK.I8;

                case TC.Byte:
                    return NK.U8;

                case TC.Int16:
                    return NK.I16;

                case TC.UInt16:
                    return NK.U16;

                case TC.Int32:
                    return NK.I32;

                case TC.UInt32:
                    return NK.U32;

                case TC.Int64:
                    return NK.I64;

                case TC.UInt64:
                    return NK.U64;

                case TC.Single:
                    return NK.F32;

                case TC.Double:
                    return NK.F64;
            }

            return NK.None;
        }

        /// <summary>
        /// Computes the numeric kind determined by a bit-width and numeric indicator
        /// </summary>
        /// <param name="nw">The type width, in bits</param>
        /// <param name="ni">The numeric indicator</param>
        [Op]
        public static NK kind(NumericWidth nw, NumericIndicator ni)
            => ni switch {
                NI.Signed
                    => nw switch {
                        NW.W8  => NK.I8,
                        NW.W16 => NK.I16,
                        NW.W32 => NK.I32,
                        NW.W64 => NK.I64,
                        _ => NK.None
                    },
                NI.Unsigned
                    => nw switch {
                        NW.W8  => NK.U8,
                        NW.W16 => NK.U16,
                        NW.W32 => NK.U32,
                        NW.W64 => NK.U64,
                        _ => NK.None
                    },
                NI.Float
                    => nw switch {
                        NW.W32 => NK.F32,
                        NW.W64 => NK.F64,
                        _ => NK.None
                    },
                _ => NK.None
            };
    }
}