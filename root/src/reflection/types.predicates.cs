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
 
    using static ReflectionFlags;
    using GK = GenericKind;

    partial class RootReflections
    {
        /// <summary>
        /// Returns true if the source type is either non-generic or a generic type that has been closed over all parameters
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static bool Concrete(this Type src)
            => !src.ContainsGenericParameters && !src.IsGenericParameter && !src.IsAbstract;

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
        /// Determines whether a type is static
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsStatic(this Type t)
            => t.IsAbstract && t.IsSealed;

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
        /// <param name="candidate">The source type</param>
        /// <typeparam name="T">The type to match</typeparam>
        public static bool IsTypeOf<T>(this Type candidate)
            => candidate.EffectiveType() == typeof(T) 
            || candidate.EffectiveType().IsNullable<T>()
            || candidate.EffectiveType().IsEnum && candidate.EffectiveType().GetEnumUnderlyingType() == typeof(T);

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
        /// Determines whether a supplied type is predicated on a byte, including enums, nullable wrappers and references
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsByte(this Type t)
            => t.IsTypeOf<byte>();

        /// <summary>
        /// Determines whether a supplied type is predicated on an sbyte, including enums, nullable wrappers and references
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsSByte(this Type t)
            => t.IsTypeOf<sbyte>();

        /// <summary>
        /// Determines whether a supplied type is predicated on a ushort, including enums, nullable wrappers and references
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsUInt16(this Type t)
            => t.IsTypeOf<ushort>();

        /// <summary>
        /// Determines whether a supplied type is predicated on a short, including enums, nullable wrappers and references
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsInt16(this Type t)
            => t.IsTypeOf<short>();

        /// <summary>
        /// Determines whether a supplied type is predicated on a uint, including enums, nullable wrappers and references
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsUInt32(this Type t)
            => t.IsTypeOf<uint>();

        /// <summary>
        /// Determines whether a supplied type is predicated on an int, including enums, nullable wrappers and references
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsInt32(this Type t)
            => t.IsTypeOf<int>();

        /// <summary>
        /// Determines whether a supplied type is predicated on a ulong, including enums, nullable wrappers and references
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsUInt64(this Type t)
            => t.IsTypeOf<ulong>();

        /// <summary>
        /// Determines whether a supplied type is predicated on a long, including enums, nullable wrappers and references
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsInt64(this Type t)
            => t.IsTypeOf<long>();

        /// <summary>
        /// Determines whether a supplied type is predicated on a float, including enums, nullable wrappers and references
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsSingle(this Type t)
            => t.IsTypeOf<float>();

        /// <summary>
        /// Determines whether a supplied type is predicated on a double, including enums, nullable wrappers and references
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsDouble(this Type t)
            => t.IsTypeOf<double>();

        /// <summary>
        /// Determines whether a type is a non-numeric primitive
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static bool IsPrimalNonNumeric(this Type src)
            => src.IsBool() || src.IsVoid() || src.IsChar() || src.IsString();

        /// <summary>
        /// Determines whether a type is a primitive
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static bool IsPrimal(this Type src)
            => src.IsNumeric() || src.IsPrimalNonNumeric();

        public static GenericKind GenericKind(this Type src, bool effective)
            =>   src.IsOpenGeneric(false) ? GK.Open 
               : src.IsClosedGeneric(false) ? GK.Closed 
               : src.IsGenericTypeDefinition ? GK.Definition 
               : 0;

        public static GenericKind GenericKind(this MethodInfo src, bool effective)
            =>   src.IsOpenGeneric() ? GK.Open 
               : src.IsClosedGeneric() ? GK.Closed 
               : src.IsGenericMethodDefinition ? GK.Definition 
               : 0;
    }
}