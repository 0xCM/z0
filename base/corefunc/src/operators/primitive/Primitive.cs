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

    using static zfunc;

    public static class Primitive
    {
        /// <summary>
        /// Determines whether a parametric type is of specified kind
        /// </summary>
        /// <param name="kind">The kind</param>
        /// <param name="t">A type value representative</param>
        /// <typeparam name="T">The type to test</typeparam>
        [MethodImpl(Inline)]
        public static bit iskind<T>(PrimalKind kind, T t = default)
            where T : unmanaged
                => iskind_u(kind,t);

        /// <summary>
        /// Returns a primal type's kind classifier
        /// </summary>
        /// <param name="t">A type value representative</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static PrimalKind kind<T>(T t = default)
            where T : unmanaged
                => kind_u(t);

        /// <summary>
        /// Returns 1 if a parametric type is a primal signed type and 0 otherwise
        /// </summary>
        /// <typeparam name="T">The type to test</typeparam>
        [MethodImpl(Inline)]
        public static bit signed<T>(T t = default)
            => typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short)
            || typeof(T) == typeof(int)
            || typeof(T) == typeof(long)
            || typeof(T) == typeof(float) 
            || typeof(T) == typeof(double);            

        /// <summary>
        /// Returns 1 if a parametric type is a primal integer and 0 otherwise
        /// </summary>
        /// <typeparam name="T">The type to test</typeparam>
        [MethodImpl(Inline)]
        public static bit integral<T>(T t = default)
            => typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(byte)
            || typeof(T) == typeof(short)
            || typeof(T) == typeof(ushort)
            || typeof(T) == typeof(int)
            || typeof(T) == typeof(uint)
            || typeof(T) == typeof(long)
            || typeof(T) == typeof(ulong);

        /// <summary>
        /// Returns 1 if a parametric type is a primal floating-point type and 0 otherwise
        /// </summary>
        /// <typeparam name="T">The type to test</typeparam>
        [MethodImpl(Inline)]
        public static bit floating<T>(T t = default)
            => typeof(T) == typeof(float) 
            || typeof(T) == typeof(double);    

        /// <summary>
        /// Returns 1 if parametric type is a primal unsigned integer and 0 otherwise
        /// </summary>
        /// <typeparam name="T">The type to test</typeparam>
        [MethodImpl(Inline)]
        public static bit unsigned<T>(T t = default)
            => typeof(T) == typeof(byte)
            || typeof(T) == typeof(ushort)
            || typeof(T) == typeof(uint)
            || typeof(T) == typeof(ulong);

        /// <summary>
        /// Returns a primal type's kind classifier
        /// </summary>
        /// <typeparam name="T">The type to test</typeparam>
        [MethodImpl(Inline)]
        public static PrimalKind kind(Type t)
            => Type.GetTypeCode(t) switch{
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

        [MethodImpl(Inline)]
        public static int size(PrimalKind kind)
            => kind switch{
                PrimalKind.U8 => 1,
                PrimalKind.I8 => 1,
                PrimalKind.U16 => 2,
                PrimalKind.I16 => 2,
                PrimalKind.I32 => 4,
                PrimalKind.U32 => 4,
                PrimalKind.F32 => 4,
                PrimalKind.I64 => 8,
                PrimalKind.U64 => 8,
                PrimalKind.F64 => 8,
                _ => 0
             };

        [MethodImpl(Inline)]
        public static int size(Type t)
            => size(kind(t));
            
        [MethodImpl(Inline)]
        public static int bitsize(PrimalKind kind)
            => size(kind) * 8;

        [MethodImpl(Inline)]
        public static int bitsize(Type t)
            => size(t) * 8;

        /// <summary>
        /// Determines whether a kind is one of the signed integer types
        /// </summary>
        /// <typeparam name="T">The type to test</typeparam>
        [MethodImpl(Inline)]
        public static bit signedint(PrimalKind k)
            => (k & PrimalKind.SignedIntegral) != 0;

        /// <summary>
        /// Determines whether a kind is one of the signed integer types
        /// </summary>
        /// <typeparam name="T">The type to test</typeparam>
        [MethodImpl(Inline)]
        public static bit unsignedint(PrimalKind k)
            => (k & PrimalKind.UnsignedIntegral) != 0;

        /// <summary>
        /// Determines whether a type is a primal integer
        /// </summary>
        /// <typeparam name="T">The type to test</typeparam>
        [MethodImpl(Inline)]
        public static bit integral(PrimalKind k)
            => (k & PrimalKind.Integral) != 0;

        /// <summary>
        /// Determines whether a type is a primal float
        /// </summary>
        /// <typeparam name="T">The type to test</typeparam>
        [MethodImpl(Inline)]
        public static bit floating(PrimalKind k)
            => (k & PrimalKind.Float) != 0;
        
        /// <summary>
        /// Produces a character {i | u | f} indicating whether the source type is signed, unsigned or float
        /// </summary>
        /// <param name="t">A type representative</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]   
        public static char indicator(PrimalKind k)
            => floating(k) ? AsciLower.f 
            : signedint(k) ? AsciLower.i
            : unsignedint(k) ? AsciLower.u
            : AsciDigits.A0;

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

        [MethodImpl(Inline)]
        static bit iskind_u<T>(PrimalKind kind, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return (kind & PrimalKind.U8) != PrimalKind.None;
            else if(typeof(T) == typeof(ushort))
                return (kind & PrimalKind.U16) != PrimalKind.None;
            else if(typeof(T) == typeof(uint))
                return (kind & PrimalKind.U32) != PrimalKind.None;
            else if(typeof(T) == typeof(ulong))
                return (kind & PrimalKind.U64) != PrimalKind.None;
            else
                return iskind_i(kind,t);
        }

        [MethodImpl(Inline)]
        static bit iskind_i<T>(PrimalKind kind, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return (kind & PrimalKind.I8) != PrimalKind.None;
            else if(typeof(T) == typeof(short))
                return (kind & PrimalKind.I16) != PrimalKind.None;
            else if(typeof(T) == typeof(int))
                return (kind & PrimalKind.I32) != PrimalKind.None;
            else if(typeof(T) == typeof(long))
                return (kind & PrimalKind.I64) != PrimalKind.None;
            else
                return iskind_f(kind,t);
        }

        [MethodImpl(Inline)]
        static bit iskind_f<T>(PrimalKind kind, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return (kind & PrimalKind.F32) != PrimalKind.None;
            else if(typeof(T) == typeof(double))
                return (kind & PrimalKind.F64) != PrimalKind.None;
            else
                return bit.Off;
        }
    }
}