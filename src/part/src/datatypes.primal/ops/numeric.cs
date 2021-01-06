//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using NK = PrimalNumericKind;
    using TC = System.TypeCode;

    partial struct SystemPrimitives
    {
        /// <summary>
        /// Determines the numeric kind, if any, of a system type
        /// </summary>
        /// <param name="src">The source type</param>
        [Op]
        public static NK numeric(Type src)
        {
            var k = src.IsEnum
                ? NK.None
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
    }
}