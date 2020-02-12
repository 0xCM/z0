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
            => $"{k.Width()}{k.Indicator().Format()}";        

        public static IEnumerable<NumericKind> NumericClosures(this MemberInfo m)
            => m.CustomAttribute<NumericClosuresAttribute>().MapValueOrElse(a => a.NumericPrimitive.DistinctKinds(), () => items<NumericKind>());
    }
}