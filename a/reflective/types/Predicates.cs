//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Linq.Expressions;

    using static ReflectionFlags;
    
    partial class Reflective
    {
        /// <summary>
        /// Determines whether a type is a struct
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsStruct(this Type t)
            => t.IsValueType && !t.IsEnum;

        /// <summary>
        /// Determines whether the specified type is a delegate type
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsDelegate(this Type t)
            => t.IsSubclassOf(typeof(Delegate));

        /// <summary>
        /// Determines whether the enum value corresponds to a defined literal
        /// </summary>
        /// <param name="src">The enum value to check</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static bool IsLiteral<E>(this E src)
            where E : Enum
                => Enum.IsDefined(typeof(E), src);

        /// <summary>
        /// Returns true if the source type is either non-generic or a generic type that has been closed over all parameters
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static bool IsConcrete(this Type src)
            => !src.ContainsGenericParameters && !src.IsGenericParameter && !src.IsAbstract;

        /// <summary>
        /// Determines whether a type is static
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsStatic(this Type t)
            => t.IsAbstract && t.IsSealed;

        /// <summary>
        /// Determines whether an attribute of parametric type is applied to a source type
        /// </summary>
        /// <param name="src">The source type</param>
        /// <typeparam name="A">The attribute type</typeparam>
        public static bool IsAttributed<A>(this Type src)
            where A : Attribute
                => System.Attribute.IsDefined(src,typeof(A));

        /// <summary>
        /// Determines whether a type implements a specified interface
        /// </summary>
        /// <param name="t">The type to examine</param>
        /// <param name="interfaceType">The interface type</param>
        public static bool Realizes(this Type t, Type interfaceType)
            => interfaceType.IsInterface && t.Interfaces().Contains(interfaceType);

        /// <summary>
        /// Determines whether a type implements a specific interface
        /// </summary>
        /// <typeparam name="T">The interface type</typeparam>
        /// <param name="t">The type to examine</param>
        public static bool Realizes<T>(this Type t)        
            => typeof(T).IsInterface && t.Interfaces().Contains(typeof(T)); 

        /// <summary>
        /// Determines whether a type is nullable
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsNullableType(this Type t)
            =>  (t.IsGenericType && t.GetGenericTypeDefinition() == typeof(Nullable<>))
              | (t.IsGenericRef() && t.GetElementType().GetGenericTypeDefinition() == typeof(Nullable<>));

        /// <summary>
        /// Determine whether a type is a nullable type with a given underlying type
        /// </summary>
        /// <typeparam name="T">The underlying type</typeparam>
        /// <param name="t">The type to check</param>
        /// <returns>
        /// Returns true if t is both a nullable type and is of type T
        /// </returns>
        public static bool IsNullable<T>(this Type t)
            => t.IsNullableType() && Nullable.GetUnderlyingType(t) == typeof(T);

        public static bool IsNullable(this Type subject, Type match)
            => subject.IsNullableType() && Nullable.GetUnderlyingType(subject) == match;

        /// <summary>
        /// Determines whether a source type is predicated on a specified match type, including nullable wrappers, references and enums
        /// </summary>
        /// <typeparam name="T">The type to match</typeparam>
        /// <param name="candidate">The source type</param>
        /// <param name="match">The type to match</param>
        public static bool IsTypeOf(this Type candidate, Type match)
            => candidate.EffectiveType() == match
            || candidate.EffectiveType().IsNullable(match)
            || candidate.EffectiveType().IsEnum && candidate.EffectiveType().GetEnumUnderlyingType() == match;

        /// <summary>
        /// Determines whether a source type is predicated on a parametric type, including nullable wrappers, references and enums
        /// </summary>
        /// <param name="match">The source type</param>
        /// <typeparam name="T">The type to match</typeparam>
        public static bool IsTypeOf<T>(this Type match)
            => match.EffectiveType() == typeof(T) 
            || match.EffectiveType().IsNullable<T>()
            || match.EffectiveType().IsEnum && match.EffectiveType().GetEnumUnderlyingType() == typeof(T);

        /// <summary>
        /// Returns true if the source type is non-null and non-void; otherwise, returns false
        /// </summary>
        /// <param name="src">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsSome(this Type src)
            => src != null && src != typeof(void);

        /// <summary>
        /// Determines whether the type is a (memory) reference
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static bool IsRef(this Type src)
            => src.UnderlyingSystemType.IsByRef;

        /// <summary>
        /// Determines whether a type is a reference to a generic type
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsGenericRef(this Type t)
            => t.IsRef() && t.GetElementType().IsGenericType;

        /// <summary>
        /// Determines whether a type is an unconstructed generic type, also called an open generic type
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsOpenGeneric(this Type src, bool effective = true)
        {
            var t = effective ? src.EffectiveType() : src;
            return (t.IsGenericType || t.IsGenericTypeDefinition) && !t.IsConstructedGenericType;
        }

        /// <summary>
        /// Determines whether a type is a constructed generic type
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsClosedGeneric(this Type t, bool effective = true)
            => effective ? t.EffectiveType().IsConstructedGenericType : t.IsConstructedGenericType;

        /// <summary>
        /// Determines whether a type has a public default constructor
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool HasDefaultPublicConstructor(this Type t)
            => t.GetConstructor(new Type[] { }) != null;

        /// <summary>
        /// Determines whether a type has a public default constructor
        /// </summary>
        /// <typeparam name="T">The type to examine</typeparam>
        public static bool HasDefaultPublicConstructor<T>()
            where T : class 
                => typeof(T).GetConstructor(new Type[] { }) != null; 

        /// <summary>
        /// Determines whether a supplied type is predicated on a double, including enums, nullable wrappers and references
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsDecimal(this Type t)
            => t.IsTypeOf<decimal>();

        /// <summary>
        /// Determines whether a supplied type is predicated on a bool, including nullable wrappers and references
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsBool(this Type t)
            => t.IsTypeOf<bool>();

        /// <summary>
        /// Determines whether a supplied type is predicated on a string, including references
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsString(this Type t)
            => t.IsTypeOf<string>();

        /// <summary>
        /// Determines whether a supplied type is predicated on a string, including references
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsObject(this Type t)
            => t.IsTypeOf<object>();

        /// <summary>
        /// Determines whether a supplied type is of type Void
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsVoid(this Type t)
            => t == typeof(void);

        /// <summary>
        /// Determines whether a supplied type is predicated on a char, including nullable wrappers and references
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static bool IsChar(this Type src)
            => src.IsTypeOf<Char>();

        /// <summary>
        /// Determines whether a type is the sytem-defined 8-bit unsigned integer type or a system-defined variation thereof
        /// </summary>
        /// <param name="t">The type to examine</param>
        /// <remarks>
        /// Variations accounted for include
        /// A) System-defined nullable parametric closures over the type 
        /// B) System-defined reference types that cover the type, including ref/out parameters and such
        /// C) THe sytem-defined pseudo-refinement mechanism known as an Enum
        /// </remarks>
        public static bool IsByte(this Type t)
            => t.IsTypeOf<byte>();

        /// <summary>
        /// Determines whether a type the sytem-defined 8-bit signed integer type or a system-defined variation thereof
        /// </summary>
        /// <param name="t">The type to examine</param>
        /// <remarks>
        /// Variations accounted for include
        /// A) System-defined nullable parametric closures over the type 
        /// B) System-defined reference types that cover the type, including ref/out parameters and such
        /// C) THe sytem-defined pseudo-refinement mechanism known as an Enum
        /// </remarks>
        public static bool IsSByte(this Type t)
            => t.IsTypeOf<sbyte>();

        /// <summary>
        /// Determines whether a type the sytem-defined 8-bit unsigned integer type or a system-defined variation thereof
        /// </summary>
        /// <param name="t">The type to examine</param>
        /// <remarks>
        /// Variations accounted for include
        /// A) System-defined nullable parametric closures over the type 
        /// B) System-defined reference types that cover the type, including ref/out parameters and such
        /// C) THe sytem-defined pseudo-refinement mechanism known as an Enum
        /// </remarks>
        public static bool IsUInt8(this Type t)
            => t.IsTypeOf<byte>();

        /// <summary>
        /// Determines whether a type the sytem-defined 8-bit signed integer type or a system-defined variation thereof
        /// </summary>
        /// <param name="t">The type to examine</param>
        /// <remarks>
        /// Variations accounted for include
        /// A) System-defined nullable parametric closures over the type 
        /// B) System-defined reference types that cover the type, including ref/out parameters and such
        /// C) THe sytem-defined pseudo-refinement mechanism known as an Enum
        /// </remarks>
        public static bool IsInt8(this Type t)
            => t.IsTypeOf<sbyte>();

        /// <summary>
        /// Determines whether a type the sytem-defined 16-bit unsigned integer type or a system-defined variation thereof
        /// </summary>
        /// <param name="t">The type to examine</param>
        /// <remarks>
        /// Variations accounted for include
        /// A) System-defined nullable parametric closures over the type 
        /// B) System-defined reference types that cover the type, including ref/out parameters and such
        /// C) THe sytem-defined pseudo-refinement mechanism known as an Enum
        /// </remarks>
        public static bool IsUInt16(this Type t)
            => t.IsTypeOf<ushort>();

        /// <summary>
        /// Determines whether a type the sytem-defined 16-bit signed integer type or a system-defined variation thereof
        /// </summary>
        /// <param name="t">The type to examine</param>
        /// <remarks>
        /// Variations accounted for include
        /// A) System-defined nullable parametric closures over the type 
        /// B) System-defined reference types that cover the type, including ref/out parameters and such
        /// C) THe sytem-defined pseudo-refinement mechanism known as an Enum
        /// </remarks>
        public static bool IsInt16(this Type t)
            => t.IsTypeOf<short>();

        /// <summary>
        /// Determines whether a type the sytem-defined 32-bit unsigned integer type or a system-defined variation thereof
        /// </summary>
        /// <param name="t">The type to examine</param>
        /// <remarks>
        /// Variations accounted for include
        /// A) System-defined nullable parametric closures over the type 
        /// B) System-defined reference types that cover the type, including ref/out parameters and such
        /// C) THe sytem-defined pseudo-refinement mechanism known as an Enum
        /// </remarks>
        public static bool IsUInt32(this Type t)
            => t.IsTypeOf<uint>();

        /// <summary>
        /// Determines whether a type the sytem-defined 32-bit signed integer type or a system-defined variation thereof
        /// </summary>
        /// <param name="t">The type to examine</param>
        /// <remarks>
        /// Variations accounted for include
        /// A) System-defined nullable parametric closures over the type 
        /// B) System-defined reference types that cover the type, including ref/out parameters and such
        /// C) THe sytem-defined pseudo-refinement mechanism known as an Enum
        /// </remarks>
        public static bool IsInt32(this Type t)
            => t.IsTypeOf<int>();

        /// <summary>
        /// Determines whether a type the sytem-defined 64-bit unsigned integer type or a system-defined variation thereof
        /// </summary>
        /// <param name="t">The type to examine</param>
        /// <remarks>
        /// Variations accounted for include
        /// A) System-defined nullable parametric closures over the type 
        /// B) System-defined reference types that cover the type, including ref/out parameters and such
        /// C) THe sytem-defined pseudo-refinement mechanism known as an Enum
        /// </remarks>
        public static bool IsUInt64(this Type t)
            => t.IsTypeOf<ulong>();

        /// <summary>
        /// Determines whether a type the sytem-defined 64-bit signed integer type or a system-defined variation thereof
        /// </summary>
        /// <param name="t">The type to examine</param>
        /// <remarks>
        /// Variations accounted for include
        /// A) System-defined nullable parametric closures over the type 
        /// B) System-defined reference types that cover the type, including ref/out parameters and such
        /// C) THe sytem-defined pseudo-refinement mechanism known as an Enum
        /// </remarks>
        public static bool IsInt64(this Type t)
            => t.IsTypeOf<long>();

        /// <summary>
        /// Determines whether a type the sytem-defined 32-bit floating-point type or a system-defined variation thereof
        /// </summary>
        /// <param name="t">The type to examine</param>
        /// <remarks>
        /// Variations accounted for include
        /// A) System-defined nullable parametric closures over the type 
        /// B) System-defined reference types that cover the type, including ref/out parameters and such
        /// C) THe sytem-defined pseudo-refinement mechanism known as an Enum
        /// </remarks>
        public static bool IsSingle(this Type t)
            => t.IsTypeOf<float>();

        /// <summary>
        /// Determines whether a type the sytem-defined 32-bit floating-point type or a system-defined variation thereof
        /// </summary>
        /// <param name="t">The type to examine</param>
        /// <remarks>
        /// Variations accounted for include
        /// A) System-defined nullable parametric closures over the type 
        /// B) System-defined reference types that cover the type, including ref/out parameters and such
        /// C) THe sytem-defined pseudo-refinement mechanism known as an Enum
        /// </remarks>
        public static bool IsFloat32(this Type t)
            => t.IsTypeOf<float>();

        /// <summary>
        /// Determines whether a type the sytem-defined 64-bit floating-point type or a system-defined variation thereof
        /// </summary>
        /// <param name="t">The type to examine</param>
        /// <remarks>
        /// Variations accounted for include
        /// A) System-defined nullable parametric closures over the type 
        /// B) System-defined reference types that cover the type, including ref/out parameters and such
        /// C) THe sytem-defined pseudo-refinement mechanism known as an Enum
        /// </remarks>
        public static bool IsDouble(this Type t)
            => t.IsTypeOf<double>();

        /// <summary>
        /// Determines whether a type the sytem-defined 64-bit floating-point type or a system-defined variation thereof
        /// </summary>
        /// <param name="t">The type to examine</param>
        /// <remarks>
        /// Variations accounted for include
        /// A) System-defined nullable parametric closures over the type 
        /// B) System-defined reference types that cover the type, including ref/out parameters and such
        /// C) THe sytem-defined pseudo-refinement mechanism known as an Enum
        /// </remarks>
        public static bool IsFloat64(this Type t)
            => t.IsTypeOf<double>();

        /// <summary>
        /// Determines whether a type is a system-defined and architecture-supported unsigned integral type or a system-defined variation thereof
        /// </summary>
        /// <param name="t">The type to examine</param>
        /// <remarks>
        /// Variations accounted for include
        /// A) System-defined nullable parametric closures over the type 
        /// B) System-defined reference types that cover the type, including ref/out parameters and such
        /// C) THe sytem-defined pseudo-refinement mechanism known as an Enum
        /// </remarks>
        public static bool IsSignedInt(this Type t)
            => t.IsInt8() || t.IsInt16() || t.IsInt32() || t.IsInt64();

        /// <summary>
        /// Determines whether a type is a system-defined and architecture-supported signed integral type or a system-defined variation thereof
        /// </summary>
        /// <param name="t">The type to examine</param>
        /// <remarks>
        /// Variations accounted for include
        /// A) System-defined nullable parametric closures over the type 
        /// B) System-defined reference types that cover the type, including ref/out parameters and such
        /// C) THe sytem-defined pseudo-refinement mechanism known as an Enum
        /// </remarks>
        public static bool IsUnsignedInt(this Type t)
            => t.IsUInt8() || t.IsUInt16() || t.IsUInt32() || t.IsUInt64();

        /// <summary>
        /// Determines whether a type is a system-defined and architecture-supported floating-point type or a system-defined variation thereof
        /// </summary>
        /// <param name="t">The type to examine</param>
        /// <remarks>
        /// Variations accounted for include
        /// A) System-defined nullable parametric closures over the type 
        /// B) System-defined reference types that cover the type, including ref/out parameters and such
        /// C) THe sytem-defined pseudo-refinement mechanism known as an Enum
        /// </remarks>
        public static bool IsFloating(this Type t)
            => t.IsFloat32() || t.IsFloat64();
        
        /// <summary>
        /// Determines whether a type is a system-defined and architecture-supported integral type or a system-defined variation thereof
        /// </summary>
        /// <param name="t">The type to examine</param>
        /// <remarks>
        /// Variations accounted for include
        /// A) System-defined nullable parametric closures over the type 
        /// B) System-defined reference types that cover the type, including ref/out parameters and such
        /// C) THe sytem-defined pseudo-refinement mechanism known as an Enum
        /// </remarks>
        public static bool IsIntegral(this Type t)
            => t.IsSignedInt() || t.IsUnsignedInt();

        /// <summary>
        /// Determines whether a type is a system-defined and architecture-suppored numeric type or a system-defined variation thereof
        /// </summary>
        /// <param name="t">The type to examine</param>
         /// <remarks>
        /// Variations accounted for include
        /// A) System-defined nullable parametric closures over the type 
        /// B) System-defined reference types that cover the type, including ref/out parameters and such
        /// C) THe sytem-defined pseudo-refinement mechanism known as an Enum
        /// </remarks>
        public static bool IsSysNumeric(this Type t)
            => t.IsFloating() || t.IsIntegral();
    
        public static bool IsSysNonNumeric(this Type src)
            => src.IsBool() || src.IsVoid() || src.IsChar() || src.IsString() || src.IsObject();

        /// <summary>
        /// Determines whether a type is system-defined primitive
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static bool IsSystemType(this Type src)
            => src.IsSysNumeric() || src.IsSysNonNumeric();
    }
}