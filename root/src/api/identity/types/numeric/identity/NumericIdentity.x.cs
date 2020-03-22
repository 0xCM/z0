//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Root;

    using NK = NumericKind;
    using NI = NumericIndicator;
    using FW = FixedWidth;

    public static class NumericIdentityOps
    {
        /// <summary>
        /// Determines the numeric kind of a type, possibly none
        /// </summary>
        /// <param name="src">The type to examine</param>
        [MethodImpl(Inline)]
        public static NK NumericKind(this Type src)
            => NumericIdentity.kind(src).ValueOrDefault();

        /// <summary>
        /// Determines the numeric kind identified by a type code, if any
        /// </summary>
        /// <param name="tc">The type code to evaluate</param>
        [MethodImpl(Inline)]
        public static NumericKind NumericKind(this TypeCode tc)
            => NumericIdentity.kind(tc);

        /// <summary>
        /// Returns true if the source type represents a primal numeric type
        /// </summary>
        /// <param name="src">The source type</param>
        [MethodImpl(Inline)]
        public static bool IsNumeric(this Type src)
            => TypeIdentities.IsNumeric(src);

        /// <summary>
        /// Determines whether a method has numeric operands (if any) and a numeric return type (if any)
        /// </summary>
        /// <param name="src">The method to examine</param>
        public static bool IsNumeric(this MethodInfo src)
            => TypeIdentities.IsNumeric(src);

        /// <summary>
        /// Computes the primal types identified by a specified kind
        /// </summary>
        /// <param name="k">The primal kind</param>
        public static ISet<Type> DistinctTypes(this NK k)
            => NumericIdentity.typeset(k);

        /// <summary>
        /// Convers a source value, which is hopefully a supported kind, to a target kind
        /// </summary>
        /// <param name="k">The primal kind</param>
        [MethodImpl(Inline)]
        public static object Convert(this NK dst, object src)
            => Cast.ocast(src,dst);

        [MethodImpl(Inline)]
        public static NK ToNumericKind(this FixedWidth width, NumericIndicator indicator) 
            => indicator switch {
                NI.Signed 
                    => width switch {                    
                        FW.W8  => NK.I8,
                        FW.W16 => NK.I16,
                        FW.W32 => NK.I32,
                        FW.W64 => NK.I64,
                        _ => NK.None
                    },
                NI.Unsigned 
                    => width switch {
                        FW.W8  => NK.U8,
                        FW.W16 => NK.U16,
                        FW.W32 => NK.U32,
                        FW.W64 => NK.U64,
                        _ => NK.None
                    },
                NI.Float 
                    => width switch {
                        FW.W32 => NK.F32,
                        FW.W64 => NK.F64,
                        _ => NK.None
                    },
                _ => NK.None
            };
            

        [MethodImpl(Inline)]
        public static Option<NI> NumericIndicator(this Type t)
        {
            if(t == typeof(bit))
                return NI.Unsigned; 
            var i = t.NumericKind().Indicator();
            return i.IsSome() ? some(i) : none<NI>();
        }
            
    }
}