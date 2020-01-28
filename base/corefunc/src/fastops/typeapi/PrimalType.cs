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

    public static class PrimalType
    {
        /// <summary>
        /// Specifies the keyword used to designate a kind-identified primal type, if possible; throws an exception otherwise
        /// </summary>
        [MethodImpl(Inline)]
        public static string keyword(NumericKind k)
            => k switch {
                NumericKind.U8 => "byte",
                NumericKind.I8 => "sbyte",
                NumericKind.U16 => "ushort",
                NumericKind.I16 => "short",
                NumericKind.U32 => "uint",
                NumericKind.I32 => "int",
                NumericKind.I64 => "long",
                NumericKind.U64 => "ulong",
                NumericKind.F32 => "float",
                NumericKind.F64 => "double",
                _ => throw unsupported(k)
            };

        /// <summary>
        /// Specifies the keyword used to designate a kind-identified primal type, if possible; throws an exception otherwise
        /// </summary>
        [MethodImpl(Inline)]
        public static NumericKind kind(PrimalId k)
            => k switch {
                PrimalId.U8 => NumericKind.U8,
                PrimalId.I8 => NumericKind.I8,
                PrimalId.U16 => NumericKind.U16,
                PrimalId.I16 => NumericKind.I16,
                PrimalId.U32 => NumericKind.U32,
                PrimalId.I32 => NumericKind.I32,
                PrimalId.I64 => NumericKind.I64,
                PrimalId.U64 => NumericKind.U64,
                PrimalId.F32 => NumericKind.F32,
                PrimalId.F64 => NumericKind.F64,
                _ => throw unsupported(k)
            };

        /// <summary>
        /// Returns a primal type's kind classifier
        /// </summary>
        [MethodImpl(Inline | Optimize)]
        public static NumericKind kind(Type t)
            => Type.GetTypeCode(t.EffectiveType()) 
                switch
                {
                    TypeCode.Byte => NumericKind.U8,
                    TypeCode.SByte => NumericKind.I8,
                    TypeCode.Int16 => NumericKind.I16,
                    TypeCode.UInt16 => NumericKind.U16,
                    TypeCode.Int32 => NumericKind.I32,
                    TypeCode.UInt32 => NumericKind.U32,
                    TypeCode.Int64 => NumericKind.I64,
                    TypeCode.UInt64 => NumericKind.U64,
                    TypeCode.Single => NumericKind.F32,
                    TypeCode.Double => NumericKind.F64,
                    _ => NumericKind.None
                };

        /// <summary>
        /// Returns a kind-identified system type if possible; throws an exception otherwise
        /// </summary>
        [MethodImpl(Inline | Optimize)]
        public static Type type(NumericKind k)
            => k switch {
                NumericKind.U8 => typeof(byte),
                NumericKind.I8 => typeof(sbyte),
                NumericKind.U16 => typeof(ushort),
                NumericKind.I16 => typeof(short),
                NumericKind.U32 => typeof(uint),
                NumericKind.I32 => typeof(int),
                NumericKind.I64 => typeof(long),
                NumericKind.U64 => typeof(ulong),
                NumericKind.F32 => typeof(float),
                NumericKind.F64 => typeof(double),
                _ => throw unsupported(k)
            };

        /// <summary>
        /// Determines the number of bits covered by a k-kinded type
        /// </summary>
        /// <param name="k">The type kine</param>
        [MethodImpl(Inline)]
        public static int width(NumericKind k)
            => k switch {
                NumericKind.U8 => 8,
                NumericKind.I8 => 8,
                NumericKind.U16 => 16,
                NumericKind.I16 => 16,
                NumericKind.U32 => 32,
                NumericKind.I32 => 32,
                NumericKind.I64 => 64,
                NumericKind.U64 => 64,
                NumericKind.F32 => 32,
                NumericKind.F64 => 64,
                _ => 0
            };

        /// <summary>
        /// Determines the number of bytes covered by a k-kinded type
        /// </summary>
        /// <param name="k">The type kine</param>
        [MethodImpl(Inline)]
        public static int size(NumericKind kind)
            => width(kind)/8;

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
        /// Determines whether a type is a primal integer
        /// </summary>
        /// <typeparam name="T">The type to test</typeparam>
        [MethodImpl(Inline)]
        public static bit integral(NumericKind k)
            => signed(k) || unsigned(k);

        /// <summary>
        /// Produces a character {i | u | f} indicating whether the source type is signed, unsigned or float
        /// </summary>
        /// <param name="k">The primal classifier</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]   
        public static char indicator(NumericKind k)
        {
            if(k == NumericKind.None)
                return AsciLower.o;
            else if(unsigned(k))
                return AsciLower.u;
            else if(signed(k))
                return AsciLower.i;
            else if(floating(k))
                return AsciLower.f;
            else
                return AsciLower.e;
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
            => $"{width(k)}{indicator(k)}";        

        /// <summary>
        /// Produces a canonical designator of the form {bitsize[T]}{u | i | f} for a primal type
        /// </summary>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]   
        public static string signature(Type t)
            => signature(t.Kind());

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
            => m.CustomAttribute<PrimalClosuresAttribute>().MapValueOrElse(a => a.SystemPrimitive.DistinctKinds(), () => items<NumericKind>());

        /// <summary>
        /// Determines whether a type is classified as primal
        /// </summary>
        /// <param name="t">The type to test</param>
        [MethodImpl(Inline)]
        public static bool test(Type t)
            => kind(t) != NumericKind.None;

        /// <summary>
        /// Determines the primal kind (if any) of a parametrically-identifed type
        /// </summary>
        /// <param name="t">A type value representative</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static NumericKind kind<T>(T t = default)
            where T : unmanaged
                => kind_u(t);
        
        [MethodImpl(Inline)]
        public static FixedWidth width(Type t)
        {
            var k = kind(t);
            if(k != NumericKind.None)
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