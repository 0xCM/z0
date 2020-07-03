//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static NumericKinds;

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

    partial class XTend
    {
        /// <summary>
        /// Determines the numeric kind of a type
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static NumericKind NumericKind(this Type src)
            => kind(src);

        /// <summary>
        /// Determines the numeric kind of a type-code identified type
        /// </summary>
        /// <param name="tc">The type code to evaluate</param>
        [MethodImpl(Inline)]
        public static NumericKind NumericKind(this TypeCode tc)
            => kind(tc);            

        /// <summary>
        /// Determines the system type represented by a numeric kind
        /// </summary>
        /// <param name="src">The source kind</param>
        public static Type SystemType(this NumericKind src)
            => type(src);

        public static TypeCode TypeCode(this NumericKind src)
            => Type.GetTypeCode(type(src));            
    }    
}