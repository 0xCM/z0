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
    using System.Runtime.Intrinsics;
    using System.ComponentModel;
    using System.Collections.Concurrent;

    using static zfunc;
    using static ReflectionFlags;

    partial class Reflections
    {        

        /// <summary>
        /// Returns true if the source type is either non-generic or a generic type that has been closed over all parameters
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static bool Reified(this Type src)
            => !src.ContainsGenericParameters && !src.IsGenericParameter;

        /// <summary>
        /// Determines whether the type is a (memory) reference
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static bool IsRef(this Type src)
            => src.UnderlyingSystemType.IsByRef;

        /// <summary>
        /// If the source type is a type reference, returns the referenced type; otherwise, returns the original type
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static Type EffectiveType(this Type src)
            =>  src.IsRef()  ? src.GetElementType() : src;

        public static Type Unwrap(this Type src)
            => src.GetElementType() ?? src;

        /// <summary>
        /// Determines whether a type is a reference to a generic type
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsGenericRef(this Type t)
            => t.IsRef() && t.GetElementType().IsGenericType;
        
        /// <summary>
        /// For a generic type or reference to a generic type, retrieves the generic type definition;
        /// otherwise, returns none
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static Option<Type> GenericDefinition(this Type t)
        {
            var effective = t.EffectiveType();
            if(effective.IsConstructedGenericType)
                return effective.GetGenericTypeDefinition();
            else if(effective.IsGenericTypeDefinition)
                return effective;
            else
                return default;            
        }

        public static bool IsClosedGeneric(this Type t, bool effective = true)
            => effective ? t.EffectiveType().IsConstructedGenericType : t.IsConstructedGenericType;

        /// <summary>
        /// Determines whether a type is an open generic type
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsOpenGeneric(this Type src, bool effective = true)
        {
            var t = effective ? src.EffectiveType() : src;
            return (t.IsGenericType || t.IsGenericTypeDefinition) && !t.IsConstructedGenericType;
        }

        public static bool IsParametric(this ParameterInfo src)
            => src.ParameterType.IsGenericParameter 
            || src.ParameterType.IsGenericMethodParameter 
            || src.ParameterType.IsGenericTypeParameter;

        /// <summary>
        /// If a type is non-generic, returns an emtpy list.
        /// If a type is open generic, returns a list of generic arguments
        /// If a type is closed generic, returns a list of the types that were supplied as arguments to construct the type
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static Type[] GenericParameters(this Type src, bool effective = true)
        {
            var t = effective ? src.EffectiveType() : src;
            return !(t.IsGenericType && !t.IsGenericTypeDefinition) ? new Type[]{} 
               : t.IsConstructedGenericType
               ? t.GetGenericArguments()
               : t.GetGenericTypeDefinition().GetGenericArguments();
        }

        /// <summary>
        /// For a non-constructed generic type or a generic type definition, returns an
        /// array of the method's type parameters; otherwise, returns an empty array
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static Type[] OpenTypeParameters(this Type t)
        {
            var effective = t.EffectiveType();
            return effective.ContainsGenericParameters ? effective.GetGenericTypeDefinition().GetGenericArguments()
             : effective.IsGenericTypeDefinition ? effective.GetGenericArguments()
             : array<Type>();
        }

        public static int OpenTypeParameterCount(this Type t)
            => t.OpenTypeParameters().Length;

        public static int TypeParamerCount(this Type t)
            => t.GenericParameters().Length;

        public static IEnumerable<Type> SuppliedTypeArgs(this Type t)
        {
            var x = t.EffectiveType();
            if(x.IsConstructedGenericType)
                return x.GetGenericArguments();
            else
                return  items<Type>();
        }

        /// <summary>
        /// Selects the types from a stream that implement a specific interface
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The interface type</typeparam>
        public static IEnumerable<Type> Realize<T>(this IEnumerable<Type> src)
            => src.Where(t => t.Interfaces().Contains(typeof(T)));

        /// <summary>
        /// Selects the concrete (not abstract) types from a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<Type> Concrete(this IEnumerable<Type> src)
            => src.Where(t => !t.IsAbstract);

        /// <summary>
        /// Selects the abstract types from a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<Type> Abstract(this IEnumerable<Type> src)
            => src.Where(t => t.IsAbstract);

        /// <summary>
        /// Selects the nested types from a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<Type> Nested(this IEnumerable<Type> src)
            => src.Where(t => t.IsNested);

        /// <summary>
        /// Selects the static types from a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<Type> Static(this IEnumerable<Type> src)
            => src.Where(p => p.IsStatic());

        /// <summary>
        /// Selects the literal fields defined by a type
        /// </summary>
        /// <param name="src">The source type</param>
        /// <param name="declared">Whether a literal is rquired to be declared by the type</param>
        public static IEnumerable<FieldInfo> LiteralFields(this Type src, bool declared = true)
            => src.Fields(declared).Literal();

        /// <summary>
        /// Enumerates the literals defined by a type indexed by declaration order
        /// </summary>
        /// <param name="src">The source type</param>
        /// <param name="declared">Whether a literal is rquired to be declared by the type</param>
        public static IEnumerable<Pair<int,T>> LiteralValues<T>(this Type src, int? maxcount = null)  
            where T : unmanaged  
        {
            var literals = src.LiteralFields().ToArray();
            var count = Math.Min(maxcount ?? literals.Length, literals.Length);
            for(var i=0; i<count; i++)
                yield return (i, (T)Convert.ChangeType(literals[i].GetValue(null), typeof(T)));
        }

        /// <summary>
        /// Gets the value of a constant field if it exists; otherwise, returns a default value
        /// </summary>
        /// <param name="t">The type to examine</param>
        /// <param name="name">The name of the field</param>
        /// <param name="@default">The value to return if the field is not found</param>
        /// <typeparam name="T">The field value type</typeparam>
        public static T LiteralFieldValue<T>(this Type t, string name, T @default = default)
        {
            var f = t.Fields().Literal().FirstOrDefault();
            if(f != null)
                return (T)f.GetValue(null);
            else
                return @default;
        }

        /// <summary>
        /// Selects the public types from a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<Type> Public(this IEnumerable<Type> src)
            => src.Where(t => t.IsPublic);

        /// <summary>
        /// Selects the non-public types from a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<Type> NonPublic(this IEnumerable<Type> src)
            => src.Where(t => !t.IsPublic);

        [MethodImpl(Inline)]
        public static bool IsStatic(this PropertyInfo p)
            => p.GetGetMethod()?.IsStatic == true 
            || p.GetSetMethod().IsStatic == true;

        /// <summary>
        /// Determines whether a type is static
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsStatic(this Type t)
            => t.IsAbstract && t.IsSealed;

        /// <summary>
        /// Determines whether a type is static
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsAttributed<A>(this Type t)
            where A : Attribute
                => t.CustomAttribute<A>().IsSome();

        /// <summary>
        /// Determines whether a type has a public default constructor
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool HasDefaultPublicConstructor(this Type t)
            => t.GetConstructor(new Type[] { }) != null;

        /// <summary>
        /// Determines whether a type has a public default constructor
        /// </summary>
        /// <typeparam name="T">The type to examine</typeparam>
        [MethodImpl(Inline)]
        public static bool HasDefaultPublicConstructor<T>()
            where T : class 
                => typeof(T).GetConstructor(new Type[] { }) != null;

        /// <summary>
        /// Determines whether the member instance classification is equivalent to static
        /// </summary>
        /// <param name="mit">The instance classification</param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static bool IsStaticType(this MemberInstanceType mit)
            => mit == MemberInstanceType.Static;

        /// <summary>
        /// Returns all interfaces realized by the type, including those inherited from
        /// supertypes
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static IEnumerable<Type> Interfaces(this Type t)
            => t.GetInterfaces() ?? new Type[]{};

        /// <summary>
        /// Returns all source types which ar interfaces
        /// </summary>
        /// <param name="src">The source types</param>
        [MethodImpl(Inline)]
        public static IEnumerable<Type> Interfaces(this IEnumerable<Type> src)
            => src.Where(t => t.IsInterface);

        /// <summary>
        /// Returns all source types which are classes
        /// </summary>
        /// <param name="src">The source types</param>
        [MethodImpl(Inline)]
        public static IEnumerable<Type> Classes(this IEnumerable<Type> src)
            => src.Where(t => t.IsClass);

        /// <summary>
        /// Returns all source types which are structs
        /// </summary>
        /// <param name="src">The source types</param>
        [MethodImpl(Inline)]
        public static IEnumerable<Type> Structs(this IEnumerable<Type> src)
            => src.Where(t => t.IsStruct());

        /// <summary>
        /// Returns all source types which are delegates
        /// </summary>
        /// <param name="src">The source types</param>
        [MethodImpl(Inline)]
        public static IEnumerable<Type> Delegates(this IEnumerable<Type> src)
            => src.Where(t => t.IsDelegate());

        /// <summary>
        /// Returns all source types which are enums
        /// </summary>
        /// <param name="src">The source types</param>
        [MethodImpl(Inline)]
        public static IEnumerable<Type> Enums(this IEnumerable<Type> src)
            => src.Where(t => t.IsEnum);

        /// <summary>
        /// Determines whether a type implements a specified interface
        /// </summary>
        /// <param name="t">The type to examine</param>
        /// <param name="interfaceType">The interface type</param>
        [MethodImpl(Inline)]
        public static bool Realizes(this Type t, Type interfaceType)
            => interfaceType.IsInterface && t.Interfaces().Contains(interfaceType);

        /// <summary>
        /// Determines whether a type implements a specific interface
        /// </summary>
        /// <typeparam name="T">The interface type</typeparam>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool Realizes<T>(this Type t)
            => typeof(T).IsInterface && t.Interfaces().Contains(typeof(T));

        /// <summary>
        /// Determines whether a type is nullable
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
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
        [MethodImpl(Inline)]
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
        [MethodImpl(Inline)]
        public static bool IsTypeOf<T>(this Type candidate)
            => candidate.EffectiveType() == typeof(T) 
            || candidate.EffectiveType().IsNullable<T>()
            || candidate.EffectiveType().IsEnum && candidate.EffectiveType().GetEnumUnderlyingType() == typeof(T);


        /// <summary>
        /// Determines whether a supplied type is predicated on a guid, including enums, nullable wrappers and references
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsGuid(this Type t)
            => t.IsTypeOf<Guid>();


        /// <summary>
        /// Determines whether a type is anonymous
        /// </summary>
        /// <param name="src">The type to test</param>
        /// <remarks>
        /// Lifted from: https://github.com/NancyFx/Nancy/blob/master/src/Nancy/ViewEngines/Extensions.cs
        /// </remarks>
        public static bool IsAnonymous(this Type src)
            => src == null ? false : src.GetTypeInfo().IsGenericType
                    && (src.GetTypeInfo().Attributes & TypeAttributes.NotPublic) == TypeAttributes.NotPublic
                    && (src.Name.StartsWith("<>", StringComparison.OrdinalIgnoreCase) || src.Name.StartsWith("VB$", StringComparison.OrdinalIgnoreCase))
                    && (src.Name.Contains("AnonymousType") || src.Name.Contains("AnonType"))
                    && src.GetTypeInfo().GetCustomAttributes(typeof(CompilerGeneratedAttribute)).Any();

        /// <summary>
        /// Determines whether the type is an option type and if so returns the underlying option
        /// type encapsulated within an option ( ! ). Otherwise, none
        /// </summary>
        /// <param name="candidate">the type to test</param>
        [MethodImpl(Inline)]
        public static bool IsOption(this Type candidate)
            => candidate.Realizes<IOption>();

        /// <summary>
        /// Determines whether a type has a name
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsNamed(this Type t)
            => !t.IsAnonymous();

        /// <summary>
        /// Determines whether a type is a struct
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsStruct(this Type t)
            => t.IsValueType && !t.IsEnum;

        /// <summary>
        /// Determines whether the specified type is a delegate type
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsDelegate(this Type t)
            => t.IsSubclassOf(typeof(Delegate));

        static readonly ConcurrentDictionary<Type, IReadOnlyList<ValueMember>> ValueMemberCache
            = new ConcurrentDictionary<Type, IReadOnlyList<ValueMember>>();

        /// <summary>
        /// Selects the types from a specified namespace
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static IEnumerable<Type> InNamespace(this IEnumerable<Type> src, string match)
            => src.Where(t => t.Namespace == match);

        /// <summary>
        /// Selects all instance/static and public/non-public fields declared by a type
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static IEnumerable<FieldInfo> DeclaredFields(this Type src)
            => src.GetFields(BF_Declared);

        /// <summary>
        /// Selects all instance/static and public/non-public fields declared by a type
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static IEnumerable<FieldInfo> Fields(this Type src, bool declared = false)
            => src.GetFields(declared ? BF_Declared : BF_All);

        /// <summary>
        /// Attempts to retrieve a name-identified field from a type
        /// </summary>
        /// <param name="src">The type to examine</param>
        /// <param name="name">The name of the field</param>
        /// <param name="declared"></param>
        public static Option<FieldInfo> Field(this Type src, string name, bool declared = false)
            => src.Fields(declared).FirstOrDefault(f => f.Name == name);

        public static object FieldValue(this Type src, string name, object instance = null)
            => src.Fields(false).FirstOrDefault(f => f.Name == name)?.GetValue(instance);

        /// <summary>
        /// Selects the public immutable  fields defined by the type
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static IEnumerable<FieldInfo> DeclaredPublicImmutableFields(this Type t, MemberInstanceType mit)
            => from f in (mit.IsStaticType() 
                    ? t.GetFields(BF_DeclaredPublicStatic) 
                    : t.GetFields(BF_DeclaredPublicInstance))
            where f.IsInitOnly || f.IsLiteral
            select f;

        /// <summary>
        /// Selects all instance/static and public/non-public fields declared and/or inheritied by the type
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static IEnumerable<FieldInfo> AllFields(this Type t)
            => t.GetFields(BF_All);

        /// <summary>
        /// Selects the public and non-public static fields declared by a type
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static IEnumerable<FieldInfo> DeclaredInstanceFields(this Type t)
            => t.GetFields(BF_DeclaredInstance);

        /// <summary>
        /// Selects the public and nonpublic immutable fields defined by the type
        /// </summary>
        /// <param name="t">The type to examine</param>
        static IEnumerable<FieldInfo> DeclaredImmutableFields(this Type t)
              => t.Fields().Immutable();

        /// <summary>
        /// Selects all instance/static and public/non-public fields inhertited by a type
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static IEnumerable<FieldInfo> InheritedFields(this Type t)
            => t.Fields(false).Except(t.Fields(true));

        /// <summary>
        /// Selects the public fields declared by a type
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static IEnumerable<FieldInfo> DeclaredPublicFields(this Type src)
            => src.GetFields(BF_DeclaredPublic);

        /// <summary>
        /// Retrieves the non-public fields declared by a type
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static IEnumerable<FieldInfo> DeclaredNonPublicFields(this Type src)
            => src.GetFields(BF_DeclaredPublic);


        /// <summary>
        /// Retrieves the public instance Fields declared by a supertype
        /// </summary>
        /// <param name="src">The type to examine</param>
        /// <returns></returns>
        public static IEnumerable<FieldInfo> InheritedPublicFields(this Type src)
            => src.BaseType?.GetFields(BF_AllPublicInstance) ?? new FieldInfo[] { };

        /// <summary>
        /// Retrieves all public instance Fields declared or inherited by a type
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static IEnumerable<FieldInfo> PublicFields(this Type t)
            => t.InheritedPublicFields().Union(t.GetFields());

        /// <summary>
        /// Attempts to retrieves a static field by name, irrespective of its visibility
        /// </summary>
        /// <param name="t">The declaring type</param>
        /// <param name="name">The name of the method</param>
        public static Option<FieldInfo> DeclaredStaticField(this Type t, string name) 
            => t.Fields().Static().Where(f => f.Name == name).FirstOrDefault();


        /// <summary>
        /// Retrieves a public or non-public setter for a property if it exists
        /// </summary>
        /// <param name="p">The property to examine</param>
        public static Option<MethodInfo> Setter(this PropertyInfo p)
            => p.GetSetMethod() ?? p.GetSetMethod(true);

        /// <summary>
        /// Retrieves a public or non-public getter for a property if it exists
        /// </summary>
        /// <param name="p">The property to examine</param>
        public static Option<MethodInfo> Getter(this PropertyInfo p)
            => p.GetGetMethod() ?? p.GetGetMethod(true);

        /// <summary>
        /// Retrieves all instance/static and public/non-public properties declared by a type
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static IEnumerable<PropertyInfo> DeclaredProperties(this Type t)
            => t.GetProperties(BF_Declared);

        /// <summary>
        /// Retrieves all instance/static and public/non-public properties iherited or declared by a type
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static IEnumerable<PropertyInfo> AllProperties(this Type src)
            => src.GetProperties(BF_All);

        /// <summary>
        /// Retrieves all instance/static and public/non-public properties 
        /// </summary>
        /// <param name="src">The types to examine</param>
        public static IEnumerable<PropertyInfo> Properties(this IEnumerable<Type> src, bool declared = true)
            => (declared ? src.Select(DeclaredProperties) : src.Select(x => x.Properties(declared))).SelectMany(x => x);

        /// <summary>
        /// Retrieves all instance/static and public/non-public properties 
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static IEnumerable<PropertyInfo> Properties(this Type src, bool declared = true)
            => src.GetProperties(declared ? BF_Declared : BF_All);

        /// <summary>
        /// Selects the first method found on the type, if any, that has a specified name
        /// </summary>
        /// <param name="src">The type to examine</param>
        /// <param name="name">The name to match</param>
        public static Option<MethodInfo> Method(this Type src, string name)
            => src.DeclaredMethods().WithName(name).FirstOrDefault();

        /// <summary>
        /// Selects the public/non-public static/instance methods declared by a type
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static IEnumerable<MethodInfo> DeclaredMethods(this Type src)
            => src.GetMethods(BF_Declared);

        /// <summary>
        /// Selects the public/non-public static/instance methods declared by a type that have a specific name
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static IEnumerable<MethodInfo> DeclaredMethods(this Type src, string name)
            => src.GetMethods(BF_Declared).Where(m => m.Name == name);

        /// <summary>
        /// Selects the public/non-public static/instance methods declared or exposed by a type
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static IEnumerable<MethodInfo> Methods(this Type src, bool declared = true)
            => declared ? src.GetMethods(BF_Declared) : src.GetMethods(BF_All);
 
        /// <summary>
        /// Selects the public/non-public static/instance methods declared by stream of types
        /// </summary>
        /// <param name="src">The types to examine</param>
        public static IEnumerable<MethodInfo> DeclaredMethods(this IEnumerable<Type> src)
            => src.Select(x => x.DeclaredMethods()).SelectMany(x => x);

        public static IEnumerable<MethodInfo> Methods(this IEnumerable<Type> src, bool declared)
            => src.Select(x => x.Methods(declared)).SelectMany(x => x);

        public static IEnumerable<object> Values(this IEnumerable<FieldInfo> src, object o = null)
            => src.Select(x => x.GetValue(o));

        public static IEnumerable<T> Values<T>(this IEnumerable<FieldInfo> src, object o = null)
            => src.Select(x => x.GetValue(o)).Where(x => x is T).Cast<T>();

        /// <summary>
        /// Retrieves a type's default constructor, if present; otherwise, none
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static Option<ConstructorInfo> DefaultConstructor(this Type t)
            => t.GetConstructor(BF_DeclaredInstance, null, new Type[] { }, new ParameterModifier[] { });

        /// <summary>
        /// If a reference type, returns the type; if a value type and not an enum, returns 
        /// the type; if an enum returns the unerlying integral type; if a nullable value type
        /// that is not an enum, returns the underlying type; if anullable enum returns the 
        /// non-nullable underlying integral type
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static Type GetUnderlyingType(this Type t)
        {
            if (t.IsNullableType())
            {
                var _t = Nullable.GetUnderlyingType(t);
                return _t.IsEnum ? _t.GetEnumUnderlyingType() : _t;
            }
            else
                return t.IsEnum ? t.GetEnumUnderlyingType() : t;
        }

        /// <summary>
        /// Retrieves the type's public inherited immutable instance fields
        /// </summary>
        /// <param name="t"></param>
        public static IEnumerable<FieldInfo> InheritedPublicImmutableFields(this Type t, MemberInstanceType mit)
            => from f in ((
                    mit.IsStaticType() 
                ? t.BaseType?.GetFields(BF_AllPublicStatic) 
                : t.BaseType?.GetFields(BF_AllPublicInstance)) 
                ?? new FieldInfo[] { }
                )
            where f.IsInitOnly || f.IsLiteral
            select f;

        /// <summary>
        /// Retrieves the type's non-public fields
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static IEnumerable<FieldInfo> PublicImmutableFields(this Type src, MemberInstanceType mit)
            => src.InheritedPublicImmutableFields(mit).Union(src.DeclaredPublicImmutableFields(mit));

        /// <summary>
        /// Retrieves the non-public immutable instance fields inherited by the type
        /// </summary>
        /// <param name="t">The type to examine</param>
        /// <returns></returns>
        static IEnumerable<FieldInfo> GetInheritedRestrictedImmutableFields(this Type t)
            => t.BaseType?.GetFields(BF_AllRestrictedInstance)
                        ?.Where(f => f.IsInitOnly || f.IsLiteral) ?? new FieldInfo[] { };

        /// <summary>
        /// Retrieves the immutable instance fields inherited and declared by the type
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static IEnumerable<FieldInfo> RestrictedImmutableFields(this Type t)
            => t.GetInheritedRestrictedImmutableFields().Union(t.Fields().NonPublic().Immutable().Instance());

        /// <summary>
        /// Retrieves the public properties declared by a type
        /// </summary>
        /// <param name="t">The type to examine</param>
        /// <param name="mit">The instance type</param>
        /// <param name="requireSetters">Whether the existence of setters are requied to satisfy matches</param>
        public static IEnumerable<PropertyInfo> DeclaredPublicProperties(this Type t, 
            MemberInstanceType mit,  bool requireSetters = false)
                => (mit == MemberInstanceType.Instance 
                    ? t.GetProperties(BF_DeclaredPublicInstance) 
                    : t.GetProperties(BF_DeclaredPublicStatic)
                    ).Where(p => !p.IsIndexer() && (requireSetters ? p.HasSetter() : true));
        
        /// <summary>
        /// Retrieves the public instance properties declared by a type
        /// </summary>
        /// <param name="t">The type to examine</param>
        /// <param name="mit">The instance type</param>
        /// <param name="requireSetters">Whether the existence of setters are requied to satisfy matches</param>
        public static IEnumerable<PropertyInfo> GetDeclaredPublicInstanceProperties(this Type t, bool requireSetters = false)
            => t.DeclaredPublicProperties(MemberInstanceType.Instance, requireSetters);
        
        /// <summary>
        /// Retrieves the non-public properties declared by a type
        /// </summary>
        /// <param name="t">The type to examine</param>
        /// <param name="mit">The instance type</param>
        /// <param name="requireSetters">Whether the existence of setters are requied to satisfy matches</param>
        public static IEnumerable<PropertyInfo> DeclaredNonPublicProperties(this Type t, 
            MemberInstanceType mit, bool requireSetters = false)
                => (mit == MemberInstanceType.Instance
                    ? t.GetProperties(BF_DeclaredNonPublicInstance)
                    : t.GetProperties(BF_DeclaredNonPublicStatic)
                    ).Where(p => !p.IsIndexer() && (requireSetters ? p.HasSetter() : true));
                    
        /// <summary>
        /// Searches for non-public methods delcared by the type
        /// </summary>
        /// <param name="t">The type to search</param>
        /// <param name="mit">The instance type</param>
        public static IEnumerable<MethodInfo> DeclaredNonPublicMethods(this Type t,
            MemberInstanceType mit)
                => (mit == MemberInstanceType.Instance
                    ? t.GetMethods(BF_DeclaredNonPublicInstance)
                    : t.GetMethods(BF_DeclaredNonPublicStatic)
                    );

        /// <summary>
        /// Retrieves the public instance properties declared by a supertype
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static IEnumerable<PropertyInfo> InheritedPublicProperties(this Type t, bool requireSetters = false)
            => t.BaseType?.GetProperties(BF_AllPublicInstance)
                        .Where(p => !p.IsIndexer() && (requireSetters ? p.HasSetter() : true))
                        ?? new PropertyInfo[] { };

        /// <summary>
        /// Retrieves the inheritance chain for a specifed type, up to, but not including, <see cref="object"/>
        /// </summary>
        /// <param name="child">The type to examine</param>
        /// <returns></returns>
        public static IEnumerable<Type> BaseTypes(this Type child)
        {
            if (child.BaseType != null && child.BaseType != typeof(object))
            {
                var parent = child.BaseType;
                yield return parent;

                foreach (var grandfather in BaseTypes(parent))
                    yield return grandfather;
            }
        }

        /// <summary>
        /// Retrieves all public instance properties declared or inherited by a type
        /// </summary>
        /// <param name="t">The type to examine</param>
        /// <param name="requireSetters"></param>
        public static IEnumerable<PropertyInfo> PublicPropertySearch(this Type t, bool deduplicate, bool requireSetters = false)
        {
            //This approach is good enough for most cases but fails miserably in the general 
            //case because it doesn't deal with properties declared with new nor does it deal
            //properly with properties that have been overridden
            var props = new List<PropertyInfo>();
            var types = new List<Type>(t.BaseTypes());
            types.Add(t);
            foreach (var type in types)
            {
                iter(type.DeclaredPublicProperties(MemberInstanceType.Instance, requireSetters),
                    p =>
                    {
                        if (deduplicate)
                        {
                            var duplicate = props.FirstOrDefault(x => x.Name == p.Name);
                            if (duplicate != null)
                                props.Remove(duplicate);
                        }
                        props.Add(p);
                    });
            }

            if (deduplicate && props.Count != props.Distinct().Count())
                throw new Exception($"Deduplication of the properties of type {t} was requested but deduplication failed");
            return props;
        }

        /// <summary>
        /// Gets the public methods inherited by a type
        /// </summary>
        /// <param name="t">The type to examine</param>
        /// <param name="InstanceType">The instance type classification</param>
        public static IEnumerable<MethodInfo> InheritedPublicMethods(this Type t, MemberInstanceType InstanceType)
            => (InstanceType.IsStaticType()
                ? t.BaseType?.GetMethods(BF_AllPublicStatic)
                : t.BaseType?.GetMethods(BF_AllPublicInstance)) 
                ?? new MethodInfo[] { };

        /// <summary>
        /// Gets the public methods declared by a type
        /// </summary>
        /// <param name="t">The type to examine</param>
        /// <param name="InstanceType">The instance type classification</param>
        /// <returns></returns>
        public static IEnumerable<MethodInfo> DeclaredPublicMethods(this Type t, MemberInstanceType InstanceType)
            => InstanceType.IsStaticType() 
            ? t.GetMethods(BF_DeclaredPublicStatic) 
            : t.GetMethods(BF_DeclaredPublicInstance);

        /// <summary>
        /// Gets the public methods inherited or declared by a type
        /// </summary>
        /// <param name="t">The type to examine</param>
        /// <param name="InstanceType">The instance type classification</param>
        public static IEnumerable<MethodInfo> PublicMethods(this Type t, MemberInstanceType InstanceType)
            => t.InheritedPublicMethods(InstanceType).Concat(t.DeclaredPublicMethods(InstanceType));
            
        /// <summary>
        /// Retrieves the public and not public methods declared by a type
        /// </summary>
        /// <param name="t">The type to examine</param>
        /// <param name="InstanceType">Whether to selct static or instance </param>
        public static IEnumerable<MethodInfo> DeclaredMethods(this Type t, MemberInstanceType InstanceType)
            => t.GetMethods(InstanceType.IsStaticType()  ? BF_DeclaredStatic : BF_DeclaredInstance);

        /// <summary>
        /// Retrieves the public and non-public static methods declared by a type
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static IEnumerable<MethodInfo> DeclaredStaticMethods(this Type t)
            => t.GetMethods(BF_DeclaredStatic);

        /// <summary>
        /// Retrieves the public and non-public static methods declared by a type that have a specific name
        /// </summary>
        /// <param name="t">The type to examine</param>
        /// <param name="InstanceType">Whether to selct static or instance </param>
        /// <returns></returns>
        public static IEnumerable<MethodInfo> DeclaredStaticMethods(this Type t, string name)
            => t.GetMethods(BF_DeclaredStatic).Where(m => m.Name == name);

        /// <summary>
        /// Retrieves the public and non-public instance methods declared by a type
        /// </summary>
        /// <param name="t">The type to examine</param>
        /// <param name="InstanceType">Whether to selct static or instance </param>
        /// <returns></returns>
        public static IEnumerable<MethodInfo> DeclaredInstanceMethods(this Type t)
            => t.GetMethods(BF_DeclaredInstance);

        /// <summary>
        /// Retrieves all public properties exposed by a type and appropriately handles interface inheritance
        /// </summary>
        /// <param name="type">The type to examine</param>
        /// <remarks>
        /// Taken from: http://stackoverflow.com/questions/358835/getproperties-to-return-all-properties-for-an-interface-inheritance-hierarchy
        /// </remarks>   
        public static PropertyInfo[] PublicInstanceProperties(this Type type)
        {
            if (type.IsInterface)
            {
                var propertyInfos = new List<PropertyInfo>();

                var considered = new List<Type>();
                var queue = new Queue<Type>();
                considered.Add(type);
                queue.Enqueue(type);
                while (queue.Count > 0)
                {
                    var subType = queue.Dequeue();
                    foreach (var subInterface in subType.Interfaces())
                    {
                        if (considered.Contains(subInterface)) continue;

                        considered.Add(subInterface);
                        queue.Enqueue(subInterface);
                    }

                    var typeProperties = subType.GetProperties(
                        BindingFlags.FlattenHierarchy
                        | BindingFlags.Public
                        | BindingFlags.Instance);

                    var newPropertyInfos = typeProperties
                        .Where(x => !propertyInfos.Contains(x));

                    propertyInfos.InsertRange(0, newPropertyInfos);
                }

                return propertyInfos.ToArray();
            }

            return type.GetProperties(BindingFlags.FlattenHierarchy
                | BindingFlags.Public | BindingFlags.Instance);
        }

        /// <summary>
        /// Gets the static methods defined on a specified type
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static IEnumerable<MethodInfo> StaticMethods(this Type t)
            => t.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static);

        /// <summary>
        /// Gets the static methods defined on a specified type
        /// </summary>
        /// <param name="this">The type to examine</param>
        /// <returns></returns>
        public static IEnumerable<PropertyInfo> StaticProperties(this Type @this)
            => @this.GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static);

        /// <summary>
        /// Retrieves a static method by name, irrespective of its visibility
        /// </summary>
        /// <param name="t">The declaring type</param>
        /// <param name="name">The name of the method</param>
        public static Option<MethodInfo> StaticMethod(this Type t, string name) 
            => t.GetMethod(name, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static);

        /// <summary>
        /// Discovers a type's automatic properties
        /// </summary>
        /// <param name="t"></param>
        static IReadOnlyList<ValueMember> AutoProps(this Type t)
        {
            var afquery = from f in t.RestrictedImmutableFields()
                        where f.IsCompilerGenerated() && f.Name.EndsWith("__BackingField")
                        select f;
            var backingFields = afquery.ToList();// .ToReadOnlySet();

            var propertyidx = t.PublicPropertySearch(true, false).ToDictionary(x => x.Name);
            var candidates = propertyidx.Keys.Select(x =>
                    (prop: propertyidx[x], Name:  $"\u003C{x}\u003Ek__BackingField"));
            var autoprops = new List<ValueMember>();
            foreach (var candidate in candidates)
            {
                backingFields.TryFind(f => f.Name == candidate.Name)
                            .OnSome(f => autoprops.Add(new ValueMember(candidate.prop, f)));
            }
            return autoprops;       
        }

        /// <summary>
        /// Gets the members of a type that can contain/represent data (properties and fields)
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static IReadOnlyList<ValueMember> ValueMembers(this Type src)
            => ValueMemberCache.GetOrAdd(src, t =>
            {
                var members = new List<ValueMember>();        
                members.AddRange(src.AutoProps());
                var fieldMembers = t.PublicImmutableFields(MemberInstanceType.Instance).Select(x => new ValueMember(x));
                members.AddRange(fieldMembers);
                var propMembers = t.PublicPropertySearch(false, true).Where(x => x.CanRead && x.CanWrite).Select(x => new ValueMember(x));
                members.AddRange(propMembers);
                return members;
            });

        /// <summary>
        /// If non-nullable, returns the supplied type. If nullable, returns the underlying type
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static Type GetNonNullableType(this Type t)
            => nonNullable(t);

        /// <summary>
        /// Retrieves the values of a type's public instance properties
        /// </summary>
        /// <param name="t">The type to examine</param>
        /// <param name="o">The type instance</param>
        public static IReadOnlyDictionary<string, object> PropertyValues(this Type t, object o)
            => map(props(o), p => (p.Name, p.GetValue(o))).ToReadOnlyDictionary();

        /// <summary>
        /// Recursively close an IEnumerable generic type
        /// </summary>
        /// <param name="stype">The sequence type</param>
        /// <remarks>
        /// Adapted from https://blogs.msdn.microsoft.com/mattwar/2007/07/30/linq-building-an-iqueryable-provider-part-i/
        /// </remarks>
        public static Option<Type> CloseEnumerableType(this Type stype)
        {
            if (stype == typeof(string))
                return null;

            if (stype.IsArray)
                return typeof(IEnumerable<>).MakeGenericType(stype.GetElementType());

            if (stype.IsGenericType)
            {
                foreach (var arg in stype.GetGenericArguments())
                {
                    var enumerable = typeof(IEnumerable<>).MakeGenericType(arg);
                    if (enumerable.IsAssignableFrom(stype))
                        return enumerable;
                }
            }

            var interfaces = stype.Interfaces().ToList();
            if (interfaces.Count > 0)
            {
                foreach (var i in interfaces)
                {
                    var ienum = CloseEnumerableType(i);
                    if (ienum.Exists)
                        return ienum;
                }
            }

            if (stype.BaseType != null && stype.BaseType != typeof(object))
                return CloseEnumerableType(stype.BaseType);
            return null;
        }

        /// <summary>
        /// Creates an instance of a type and casts the instance value as specified by a type parameter
        /// </summary>
        /// <typeparam name="T">The cast instance type</typeparam>
        /// <param name="t">The type for which an instance will be created</param>
        /// <param name="args">Arguments matched with/passed to an instance constructor defined by the type</param>
        [MethodImpl(Inline)]
        public static T CreateInstance<T>(this Type t, params object[] args)
            => (T)Activator.CreateInstance(t, args);
 
        /// <summary>
        /// Specifies the set of all primal numeric types
        /// </summary>
        static readonly HashSet<Type> _PrimalNumericCache = 
            new HashSet<Type>(new Type[]{
                typeof(byte), typeof(ushort), typeof(uint), typeof(ulong),
                typeof(sbyte), typeof(short), typeof(int), typeof(long),
                typeof(float),typeof(double)
                });

        [MethodImpl(Inline)]
        public static bool IsPrimalNumeric(this Type src)
            => _PrimalNumericCache.Contains(src.EffectiveType()) || _PrimalNumericCache.Contains(src.EffectiveType().GetUnderlyingType());
    }
}