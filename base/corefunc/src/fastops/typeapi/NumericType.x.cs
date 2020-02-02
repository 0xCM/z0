//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using System.Reflection;
    using System.Linq;
    using System.Collections.Generic;

    using static zfunc;
    using static NumericKind;
    
    partial class FastOpX
    {
        /// <summary>
        /// Returns a kind-identified system type if possible; throws an exception otherwise
        /// </summary>
        /// <param name="k">The identifying kind</param>
        [MethodImpl(Inline)]
        public static Option<Type> ToClrType(this NumericKind k)
            => k switch {
                U8 => typeof(byte),
                I8 => typeof(sbyte),
                U16 => typeof(ushort),
                I16 => typeof(short),
                U32 => typeof(uint),
                I32 => typeof(int),
                I64 => typeof(long),
                U64 => typeof(ulong),
                F32 => typeof(float),
                F64 => typeof(double),
                _ => default
            };

        /// <summary>
        /// Determines a sub-classification c := {'u' | 'i' | 'f'} according to whether a classified primal type
        /// is unsigned integral, signed integral or floating-point
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static NumericIndicator Indicator(this NumericKind k)
            => NumericType.indicator(k);

        [MethodImpl(Inline)]
        public static Option<char> NumericTypeIndicator(this Type t)
        {
            var i = NumericType.indicator(t);
            if(i.IsNone())
            {
                if(t == typeof(bit))
                    return AsciLower.u;
                else 
                    return default;
            }
            else
                return i.Value;            
        }

        /// <summary>
        /// Specifies the bit-width of a classified cpu vector
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static string Signature(this NumericKind k)
            => NumericType.signature(k);

        /// <summary>
        /// Determines whether a supplied type is predicated on a byte, including enums, nullable wrappers and references
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsByte(this Type t)
            => t.IsTypeOf<byte>();

        /// <summary>
        /// Determines whether a supplied type is predicated on an sbyte, including enums, nullable wrappers and references
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsSByte(this Type t)
            => t.IsTypeOf<sbyte>();

        /// <summary>
        /// Determines whether a supplied type is predicated on a ushort, including enums, nullable wrappers and references
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsUInt16(this Type t)
            => t.IsTypeOf<ushort>();

        /// <summary>
        /// Determines whether a supplied type is predicated on a short, including enums, nullable wrappers and references
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsInt16(this Type t)
            => t.IsTypeOf<short>();

        /// <summary>
        /// Determines whether a supplied type is predicated on a uint, including enums, nullable wrappers and references
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsUInt32(this Type t)
            => t.IsTypeOf<uint>();

        /// <summary>
        /// Determines whether a supplied type is predicated on an int, including enums, nullable wrappers and references
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsInt32(this Type t)
            => t.IsTypeOf<int>();

        /// <summary>
        /// Determines whether a supplied type is predicated on a ulong, including enums, nullable wrappers and references
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsUInt64(this Type t)
            => t.IsTypeOf<ulong>();

        /// <summary>
        /// Determines whether a supplied type is predicated on a long, including enums, nullable wrappers and references
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsInt64(this Type t)
            => t.IsTypeOf<long>();

        /// <summary>
        /// Determines whether a supplied type is predicated on a float, including enums, nullable wrappers and references
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsSingle(this Type t)
            => t.IsTypeOf<float>();

        /// <summary>
        /// Determines whether a supplied type is predicated on a double, including enums, nullable wrappers and references
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsDouble(this Type t)
            => t.IsTypeOf<double>();

        public static IEnumerable<NumericKind> NumericClosures(this MemberInfo m)
            => m.CustomAttribute<NumericClosuresAttribute>().MapValueOrElse(a => a.NumericPrimitive.DistinctKinds(), () => items<NumericKind>());
    }
}