//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using NK = NumericKind;
    using TC = System.TypeCode;

    partial class NumericKinds
    {            
        /// <summary>
        /// Determines the numeric kind of a system type
        /// </summary>
        /// <param name="src">The source type</param>
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
    }
}