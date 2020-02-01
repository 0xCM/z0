//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    using static zfunc;

    public static class NumericType
    {
        /// <summary>
        /// Determines the number of bytes covered by a k-kinded type
        /// </summary>
        /// <param name="k">The type kine</param>
        [MethodImpl(Inline)]
        public static int size(NumericKind kind)
            => kind.Width()/8;

        /// <summary>
        /// Determines whether a type is a primal float
        /// </summary>
        /// <typeparam name="T">The type to test</typeparam>
        [MethodImpl(Inline)]
        public static bit floating(NumericKind k)
            => (k & NumericKind.Fractional) != 0;

        /// <summary>
        /// Determines whether a kind is one of the signed integer types
        /// </summary>
        /// <typeparam name="T">The type to test</typeparam>
        [MethodImpl(Inline)]
        public static bit signed(NumericKind k)
            => (k & NumericKind.Signed) != 0;

        /// <summary>
        /// Determines whether a kind is one of the signed integer types
        /// </summary>
        /// <typeparam name="T">The type to test</typeparam>
        [MethodImpl(Inline)]
        public static bit unsigned(NumericKind k)
            => (k & NumericKind.Unsigned) != 0;        

        /// <summary>
        /// Produces a character {i | u | f} indicating whether the source type is signed, unsigned or float
        /// </summary>
        /// <param name="k">The primal classifier</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]   
        public static NumericIndicator indicator(NumericKind k)
        {
            if(unsigned(k))
                return NumericIndicator.Unsigned;
            else if(signed(k))
                return NumericIndicator.Signed;
            else if(floating(k))
                return NumericIndicator.Float;
            else
                return NumericIndicator.None;
        }

        /// <summary>
        /// Determines the kind identifier
        /// </summary>
        /// <param name="k">The primal classifier</param>
        [MethodImpl(Inline)]   
        public static PrimalId id(NumericKind k)
            => (PrimalId)((((uint)k << 8) >> 24) << 16);

        /// <summary>
        /// Produces an identifier {bitsize(k)}{u | i | f} for a primal kind k
        /// </summary>
        /// <param name="k">The primal kind</param>
        [MethodImpl(Inline)]   
        public static string signature(NumericKind k)
            => $"{k.Width()}{indicator(k).Format()}";        

        /// <summary>
        /// Produces a canonical designator of the form {bitsize[T]}{u | i | f} for a primal type
        /// </summary>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]   
        public static string signature(Type t)
            => signature(t.NumericKind());

        /// <summary>
        /// Returns true if the primal source type is signed, false otherwise
        /// </summary>
        /// <typeparam name="T">The primal source type</typeparam>
        [MethodImpl(Inline)]
        public static bool signed<T>()
            where T : unmanaged
            => typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long);

        /// <summary>
        /// Returns true if the source type is a primal signed type, false otherwise
        /// </summary>
        /// <typeparam name="T">The primal source type</typeparam>
        [MethodImpl(Inline)]
        public static bool signed(Type t)
            => t == typeof(sbyte) 
            || t == typeof(short) 
            || t == typeof(int) 
            || t == typeof(long);

        /// <summary>
        /// Returns true if the specified type is an unsigned primal integral type
        /// </summary>
        /// <typeparam name="T">The type to evaluate</typeparam>
        [MethodImpl(Inline)]
        public static bool unsigned<T>()
            where T : unmanaged
            => typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong);

        /// <summary>
        /// Returns true if the source type is a primal unsigned type, false otherwise
        /// </summary>
        [MethodImpl(Inline)]
        public static bool unsigned(Type t)
            => t == typeof(byte) 
            || t == typeof(ushort) 
            || t == typeof(uint) 
            || t == typeof(ulong);

        /// <summary>
        /// Returns true if the spedified type is a 32-bit or 64-bit floating point
        /// </summary>
        /// <typeparam name="T">The type to evaluate</typeparam>
        [MethodImpl(Inline)]
        public static bool floating<T>()
            where T : unmanaged
                => typeof(T) == typeof(float) 
                || typeof(T) == typeof(double);

        /// <summary>
        /// Returns true if the source type is a primal floating point type, false otherwise
        /// </summary>
        [MethodImpl(Inline)]
        public static bool floating(Type t)
            => t == typeof(float) 
            || t == typeof(double);

        public static IEnumerable<NumericKind> closures(MemberInfo m)
            => m.CustomAttribute<NumericClosuresAttribute>().MapValueOrElse(a => a.NumericPrimitive.DistinctKinds(), () => items<NumericKind>());

        /// <summary>
        /// Determines whether a type is classified as primal
        /// </summary>
        /// <param name="t">The type to test</param>
        [MethodImpl(Inline)]
        public static bool test(Type t)
            => t.NumericKind().IsSome();

        /// <summary>
        /// Determines the primal kind (if any) of a parametrically-identifed type
        /// </summary>
        /// <param name="t">A type value representative</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static NumericKind kind<T>(T t = default)
            where T : unmanaged
                => kind_u(t);
        
        /// <summary>
        /// Attempts to parse a numeric kind from a string in the form {width}{indicator} 
        /// </summary>
        /// <param name="src">The source text</param>
        public static Option<NumericKind> ParseKind(string src)
        {
            var fail = none<NumericKind>();
            var input = src.Trim();
            if(string.IsNullOrWhiteSpace(input))
                return fail;
            
            var indicator = (NumericIndicator)input.Last();
            if(!indicator.IsLiteral() || indicator == NumericIndicator.None)
                return fail;
            
            var width = 0u;
            if(!uint.TryParse(input.Substring(0, input.Length - 1), out width))
                return fail;
            
            var fw = (FixedWidth)width;
            if(!fw.IsLiteral())
                return fail;
            
            var kind = fw.ToNumericKind(indicator);
            if(!kind.IsLiteral())
                return fail;
            
            return kind;                            
        }

        [MethodImpl(Inline)]
        public static FixedWidth width(Type t)
        {
            var k = t.NumericKind();
            if(k.IsSome())
                return (FixedWidth)(ushort)k;
            else
                return FixedWidth.None;            
        }

        [MethodImpl(Inline)]
        public static Option<char> indicator(Type t)
        {
            if(signed(t))
                return AsciLower.i;
            else if(unsigned(t))
                return AsciLower.u;
            else if(floating(t))
                return AsciLower.f;
            else
                return default;
        }

        [MethodImpl(Inline)]
        static NumericKind kind_u<T>(T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return NumericKind.U8;
            else if(typeof(T) == typeof(ushort))
                return NumericKind.U16;
            else if(typeof(T) == typeof(uint))
                return NumericKind.U32;
            else if(typeof(T) == typeof(ulong))
                return NumericKind.U64;
            else
                return kind_i(t);
        }

        [MethodImpl(Inline)]
        static NumericKind kind_i<T>(T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return NumericKind.I8;
            else if(typeof(T) == typeof(short))
                return NumericKind.I16;
            else if(typeof(T) == typeof(int))
                return NumericKind.I32;
            else if(typeof(T) == typeof(long))
                return NumericKind.I64;
            else
                return kind_f(t);
        }

        [MethodImpl(Inline)]
        static NumericKind kind_f<T>(T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return NumericKind.F32;
            else if(typeof(T) == typeof(double))
                return NumericKind.F64;
            else
                return NumericKind.None;            
        }
    }
}