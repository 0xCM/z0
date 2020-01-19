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
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    using static zfunc;

    public static class PrimalType
    {
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
                => primalkind_u(t);

        /// <summary>
        /// Returns a kind-identified system type if possible; throws an exception otherwise
        /// </summary>
        [MethodImpl(Inline | Optimize)]
        public static Type fromkind(PrimalKind k)
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
        
        public static PrimalWidth width(Type t)
        {
            var k = kind(t);
            if(k != PrimalKind.None)
                return (PrimalWidth)(ushort)k;
            else
                return PrimalWidth.None;            
        }

        [MethodImpl(Inline)]
        public static char indicator(Type t)
        {
            if(signed(t))
                return AsciLower.i;
            else if(unsigned(t))
                return AsciLower.u;
            else if(floating(t))
                return AsciLower.f;
            else
                return AsciLower.x;
        }

        [MethodImpl(Inline)]
        static PrimalKind primalkind_u<T>(T t = default)
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
                return primalkind_i(t);
        }

        [MethodImpl(Inline)]
        static PrimalKind primalkind_i<T>(T t = default)
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
                return primalkind_f(t);
        }

        [MethodImpl(Inline)]
        static PrimalKind primalkind_f<T>(T t = default)
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