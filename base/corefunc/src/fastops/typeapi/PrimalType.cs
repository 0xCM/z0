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
        public static string keyword(PrimalKind k)
            => k switch {
                PrimalKind.U8 => "byte",
                PrimalKind.I8 => "sbyte",
                PrimalKind.U16 => "ushort",
                PrimalKind.I16 => "short",
                PrimalKind.U32 => "uint",
                PrimalKind.I32 => "int",
                PrimalKind.I64 => "long",
                PrimalKind.U64 => "ulong",
                PrimalKind.F32 => "float",
                PrimalKind.F64 => "double",
                _ => throw unsupported(k)
            };

        /// <summary>
        /// Specifies the keyword used to designate a kind-identified primal type, if possible; throws an exception otherwise
        /// </summary>
        [MethodImpl(Inline)]
        public static PrimalKind kind(PrimalId k)
            => k switch {
                PrimalId.U8 => PrimalKind.U8,
                PrimalId.I8 => PrimalKind.I8,
                PrimalId.U16 => PrimalKind.U16,
                PrimalId.I16 => PrimalKind.I16,
                PrimalId.U32 => PrimalKind.U32,
                PrimalId.I32 => PrimalKind.I32,
                PrimalId.I64 => PrimalKind.I64,
                PrimalId.U64 => PrimalKind.U64,
                PrimalId.F32 => PrimalKind.F32,
                PrimalId.F64 => PrimalKind.F64,
                _ => throw unsupported(k)
            };

        /// <summary>
        /// Returns a primal type's kind classifier
        /// </summary>
        [MethodImpl(Inline | Optimize)]
        public static PrimalKind kind(Type t)
            => Type.GetTypeCode(t.EffectiveType()) 
                switch
                {
                    TypeCode.Byte => PrimalKind.U8,
                    TypeCode.SByte => PrimalKind.I8,
                    TypeCode.Int16 => PrimalKind.I16,
                    TypeCode.UInt16 => PrimalKind.U16,
                    TypeCode.Int32 => PrimalKind.I32,
                    TypeCode.UInt32 => PrimalKind.U32,
                    TypeCode.Int64 => PrimalKind.I64,
                    TypeCode.UInt64 => PrimalKind.U64,
                    TypeCode.Single => PrimalKind.F32,
                    TypeCode.Double => PrimalKind.F64,
                    _ => PrimalKind.None
                };

        /// <summary>
        /// Returns a kind-identified system type if possible; throws an exception otherwise
        /// </summary>
        [MethodImpl(Inline | Optimize)]
        public static Type type(PrimalKind k)
            => k switch {
                PrimalKind.U8 => typeof(byte),
                PrimalKind.I8 => typeof(sbyte),
                PrimalKind.U16 => typeof(ushort),
                PrimalKind.I16 => typeof(short),
                PrimalKind.U32 => typeof(uint),
                PrimalKind.I32 => typeof(int),
                PrimalKind.I64 => typeof(long),
                PrimalKind.U64 => typeof(ulong),
                PrimalKind.F32 => typeof(float),
                PrimalKind.F64 => typeof(double),
                _ => throw unsupported(k)
            };

        /// <summary>
        /// Determines the number of bits covered by a k-kinded type
        /// </summary>
        /// <param name="k">The type kine</param>
        [MethodImpl(Inline)]
        public static int width(PrimalKind k)
            => k switch {
                PrimalKind.U8 => 8,
                PrimalKind.I8 => 8,
                PrimalKind.U16 => 16,
                PrimalKind.I16 => 16,
                PrimalKind.U32 => 32,
                PrimalKind.I32 => 32,
                PrimalKind.I64 => 64,
                PrimalKind.U64 => 64,
                PrimalKind.F32 => 32,
                PrimalKind.F64 => 64,
                _ => 0
            };

        /// <summary>
        /// Determines the number of bytes covered by a k-kinded type
        /// </summary>
        /// <param name="k">The type kine</param>
        [MethodImpl(Inline)]
        public static int size(PrimalKind kind)
            => width(kind)/8;

        /// <summary>
        /// Determines whether a type is a primal float
        /// </summary>
        /// <typeparam name="T">The type to test</typeparam>
        [MethodImpl(Inline)]
        public static bit floating(PrimalKind k)
            => (k & PrimalKind.Fractional) != 0;

        /// <summary>
        /// Determines whether a kind is one of the signed integer types
        /// </summary>
        /// <typeparam name="T">The type to test</typeparam>
        [MethodImpl(Inline)]
        public static bit signed(PrimalKind k)
            => (k & PrimalKind.Signed) != 0;

        /// <summary>
        /// Determines whether a kind is one of the signed integer types
        /// </summary>
        /// <typeparam name="T">The type to test</typeparam>
        [MethodImpl(Inline)]
        public static bit unsigned(PrimalKind k)
            => (k & PrimalKind.Unsigned) != 0;

        /// <summary>
        /// Determines whether a type is a primal integer
        /// </summary>
        /// <typeparam name="T">The type to test</typeparam>
        [MethodImpl(Inline)]
        public static bit integral(PrimalKind k)
            => signed(k) || unsigned(k);

        /// <summary>
        /// Produces a character {i | u | f} indicating whether the source type is signed, unsigned or float
        /// </summary>
        /// <param name="k">The primal classifier</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]   
        public static char indicator(PrimalKind k)
        {
            if(k == PrimalKind.None)
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
        public static PrimalId id(PrimalKind k)
            => (PrimalId)((((uint)k << 8) >> 24) << 16);

        /// <summary>
        /// Produces an identifier {bitsize(k)}{u | i | f} for a primal kind k
        /// </summary>
        /// <param name="k">The primal kind</param>
        [MethodImpl(Inline)]   
        public static string signature(PrimalKind k)
            => $"{width(k)}{indicator(k)}";        

        /// <summary>
        /// Produces a canonical designator of the form {bitsize[T]}{u | i | f} for a primal type
        /// </summary>
        /// <param name="t">A primal type representative</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]   
        public static string signature<T>(T t = default)
            => signature(typeof(T).Kind());

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

        public static IEnumerable<PrimalKind> closures(MemberInfo m)
            => m.CustomAttribute<PrimalClosuresAttribute>().MapValueOrElse(a => a.SystemPrimitive.DistinctKinds(), () => items<PrimalKind>());

        /// <summary>
        /// Determines whether a type is classified as primal
        /// </summary>
        /// <param name="t">The type to test</param>
        [MethodImpl(Inline)]
        public static bool test(Type t)
            => kind(t) != PrimalKind.None;

        /// <summary>
        /// Determines the primal kind (if any) of a parametrically-identifed type
        /// </summary>
        /// <param name="t">A type value representative</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static PrimalKind kind<T>(T t = default)
            where T : unmanaged
                => kind_u(t);
        
        [MethodImpl(Inline)]
        public static FixedWidth width(Type t)
        {
            var k = kind(t);
            if(k != PrimalKind.None)
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
        static PrimalKind kind_u<T>(T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return PrimalKind.U8;
            else if(typeof(T) == typeof(ushort))
                return PrimalKind.U16;
            else if(typeof(T) == typeof(uint))
                return PrimalKind.U32;
            else if(typeof(T) == typeof(ulong))
                return PrimalKind.U64;
            else
                return kind_i(t);
        }

        [MethodImpl(Inline)]
        static PrimalKind kind_i<T>(T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return PrimalKind.I8;
            else if(typeof(T) == typeof(short))
                return PrimalKind.I16;
            else if(typeof(T) == typeof(int))
                return PrimalKind.I32;
            else if(typeof(T) == typeof(long))
                return PrimalKind.I64;
            else
                return kind_f(t);
        }

        [MethodImpl(Inline)]
        static PrimalKind kind_f<T>(T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return PrimalKind.F32;
            else if(typeof(T) == typeof(double))
                return PrimalKind.F64;
            else
                return PrimalKind.None;            
        }
    }
}