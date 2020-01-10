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


    partial class Classified
    {
        /// <summary>
        /// Specifies the unsigned primal integer types
        /// </summary>
        public static Type[] UnsignedTypes
            => new Type[]{typeof(byte),typeof(ushort),typeof(uint),typeof(ulong)};

        /// <summary>
        /// Specifies the signed primal integer types
        /// </summary>
        public static Type[] SignedTypes
            => new Type[]{typeof(sbyte),typeof(short),typeof(int),typeof(long)};

        /// <summary>
        /// Specifies the primal integer types
        /// </summary>
        public static Type[] IntegralTypes
            => new Type[]{typeof(byte),typeof(sbyte),typeof(ushort),typeof(short),typeof(uint),typeof(ulong),typeof(long)};

        /// <summary>
        /// Specifies the primal floating-point types
        /// </summary>
        public static Type[] FloatingTypes
            => new Type[]{typeof(float),typeof(double)};

        public static IEnumerable<PrimalKind> UnsignedKinds
            => items(PrimalKind.U8, PrimalKind.U16, PrimalKind.U32, PrimalKind.U64);

        public static IEnumerable<PrimalKind> SignedKinds
            => items(PrimalKind.I8, PrimalKind.I16, PrimalKind.I32, PrimalKind.I64);

        public static IEnumerable<PrimalKind> FloatingKinds
            => items(PrimalKind.F32, PrimalKind.F64);

        public static IEnumerable<PrimalKind> IntegralKinds
            => UnsignedKinds.Union(SignedKinds);

        /// <summary>
        /// Determines the primal kind (if any) of a parametrically-identifed type
        /// </summary>
        /// <param name="t">A type value representative</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static PrimalKind primalkind<T>(T t = default)
            where T : unmanaged
                => primalkind_u(t);

        /// <summary>
        /// Returns a primal type's kind classifier
        /// </summary>
        /// <typeparam name="T">The type to test</typeparam>
        [MethodImpl(Inline)]
        public static PrimalKind primalkind(Type t)
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

        /// <summary>
        /// Returns a kind-identified system type if possible; throws an exception otherwise
        /// </summary>
        [MethodImpl(Inline)]
        public static Type primaltype(PrimalKind k)
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
        /// Returns the keyword used to designate a kind-identified primal type, if possible; throws an exception otherwise
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
        /// Determines whether a parametric type is of a specified kind
        /// </summary>
        /// <param name="kind">The kind</param>
        /// <param name="t">A type value representative</param>
        /// <typeparam name="T">The type to test</typeparam>
        [MethodImpl(Inline)]
        public static bit iskind<T>(PrimalKind kind, T t = default)
            where T : unmanaged
                => primalkind<T>() == kind;

        [MethodImpl(Inline)]
        public static bit isprimal<T>(T t = default)
            where T : unmanaged
                => primalkind<T>() != PrimalKind.None;

        /// <summary>
        /// Determines the number of bits covered by a k-kinded type
        /// </summary>
        /// <param name="k">The type kine</param>
        [MethodImpl(Inline)]
        public static int width(PrimalKind k)
            => width((uint)k);

        /// <summary>
        /// Determines the number of bytes covered by a k-kinded type
        /// </summary>
        /// <param name="k">The type kine</param>
        [MethodImpl(Inline)]
        public static int size(PrimalKind kind)
            => width(kind)/8;

        /// <summary>
        /// Determines whether a kind identifies a signed type
        /// </summary>
        /// <typeparam name="T">The type to test</typeparam>
        [MethodImpl(Inline)]
        public static bit signed(PrimalKind k)
            => signed((uint)k);

        /// <summary>
        /// Determines whether a type is a primal float
        /// </summary>
        /// <typeparam name="T">The type to test</typeparam>
        [MethodImpl(Inline)]
        public static bit floating(PrimalKind k)
            => floating((uint)k);

        /// <summary>
        /// Determines whether a kind is one of the signed integer types
        /// </summary>
        /// <typeparam name="T">The type to test</typeparam>
        [MethodImpl(Inline)]
        public static bit signedint(PrimalKind k)
            => signedint((uint)k);

        /// <summary>
        /// Determines whether a kind is one of the signed integer types
        /// </summary>
        /// <typeparam name="T">The type to test</typeparam>
        [MethodImpl(Inline)]
        public static bit unsignedint(PrimalKind k)
            => unsignedint((uint)k);

        /// <summary>
        /// Determines whether a type is a primal integer
        /// </summary>
        /// <typeparam name="T">The type to test</typeparam>
        [MethodImpl(Inline)]
        public static bit integral(PrimalKind k)
            => integral((uint)k);
        
        /// <summary>
        /// Produces a character {i | u | f} indicating whether the source type is signed, unsigned or float
        /// </summary>
        /// <param name="k">The primal classifier</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]   
        public static char sign(PrimalKind k)
            => sign((uint)k);

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
        /// Returns true if the spedified type is a 32-bit or 64-bit floating point
        /// </summary>
        /// <typeparam name="T">The type to evaluate</typeparam>
        [MethodImpl(Inline)]
        public static bool floating<T>()
            where T : unmanaged
                => typeof(T) == typeof(float) 
                || typeof(T) == typeof(double);

        /// <summary>
        /// If the source type is primal, intrinsic, or blocked, returns the bit-width; otherwise, returns 0
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static int bitwidth(Type t)
        {
            if(vector(t))
                return vectorwidth(t);
            else if(blocked(t))
                return blockwidth(t);
            else
                return t.PrimalBitWidth();
        }

        /// <summary>
        /// Determines whether a method is a primal shift operator
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool primalshift(MethodInfo m)        
            => m.IsBinaryFunc() 
            && m.ReturnType == m.ParameterTypes().First() 
            && m.ParameterTypes().Second() == typeof(byte);

        /// <summary>
        /// Determines whether a method defines a predicate that returns a bit or bool value
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool predicate(MethodInfo m)
            => m.ParameterTypes().Distinct().Count() == 1 
            && (m.ReturnType == typeof(bit) || m.ReturnType == typeof(bool));

        /// <summary>
        /// Determines whether a method is an action
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool action(MethodInfo m)
            => m.ReturnType == typeof(void);

        /// <summary>
        /// Determines whether a method is an action with specified arity
        /// </summary>
        /// <param name="m">The method to examine</param>
        /// <param name="arity">The arity to match</param>
        public static bool action(MethodInfo m, int arity)
            => action(m) && m.HasArity(arity);

        /// <summary>
        /// Determines whether a method is a function
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool function(MethodInfo m)
            => m.ReturnType != typeof(void);

        /// <summary>
        /// Determines whether a method is a function with specified arity
        /// </summary>
        /// <param name="m">The method to examine</param>
        /// <param name="arity">The arith to match</param>
        public static bool function(this MethodInfo m, int arity)
            => function(m) && m.HasArity(arity);

        /// <summary>
        /// Determines whether a method defines a predicate that returns a bit value
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool bitpredicate(MethodInfo m)        
            => m.ParameterTypes().Distinct().Count() == 1 
            && (m.ReturnType == typeof(bit));

        /// <summary>
        /// Determines whether a method defines an operator over a (common) domain
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool isoperator(MethodInfo m)
            => m.IsFunction() && homogenous(m) && m.Arity() >= 1;
    
        /// <summary>
        /// Determines whether a method is an emitter, i.e. a method that returns a value but accepts no input
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool emitter(MethodInfo m)
            => m.IsFunction() && m.HasArity(0);

        /// <summary>
        /// Determines whether a method defines a parameter that requires an immediate
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool immrequired(MethodInfo m)        
            => m.GetParameters().Where(p => p.Attributed<ImmAttribute>()).Any();

        /// <summary>
        /// Returns a method's parameter types
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static IEnumerable<Type> immediates(MethodInfo m)
            => m.GetParameters().Select(p => p.ParameterType);

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