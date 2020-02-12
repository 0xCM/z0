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

    partial class RootReflections
    {
        /// <summary>
        /// If the source type is a type reference, returns the referenced type; otherwise, returns the original type
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static Type EffectiveType(this Type src)
            => src.UnderlyingSystemType.IsByRef ? src.GetElementType() : src;

        /// <summary>
        /// Returns the underlying system type if enclosed by a source type, otherwise returns the source type
        /// </summary>
        /// <param name="src">The source type</param>
        public static Type Unwrap(this Type src)
            => src.GetElementType() ?? src;

        /// <summary>
        /// Selects all instance/static and public/non-public fields declared or inherited by a type
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static IEnumerable<FieldInfo> Fields(this Type src)
            => src.GetFields(BF_All);

        /// <summary>
        /// Selects all instance/static and public/non-public fields declared by a type
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static IEnumerable<FieldInfo> DeclaredFields(this Type src)
            => src.GetFields(BF_Declared);

        /// <summary>
        /// Selects the fields accessible via a type but which the type itself does nto declare
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static IEnumerable<FieldInfo> UndeclaredFields(this Type src)
            => src.Fields().Except(src.DeclaredFields());

        /// <summary>
        /// Selects the literal fields defined by a type
        /// </summary>
        /// <param name="src">The source type</param>
        /// <param name="declared">Whether a literal is rquired to be declared by the type</param>
        public static IEnumerable<FieldInfo> LiteralFields(this Type src)
            => src.DeclaredFields().Literal();

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
        /// Retrieves the type's fields together with applied attributes
        /// </summary>
        /// <typeparam name="A">The attribute type</typeparam>
        /// <param name="src">The type to examine</param>
        public static IDictionary<FieldInfo, A> FieldAttributions<A>(this Type src) 
            where A : Attribute
        {
            var selection = from f in src.DeclaredFields()
                            where f.Attributed<A>()
                            let a = f.GetCustomAttribute<A>()
                            select (f,a);
            return selection.ToDictionary();
        }

        /// <summary>
        /// Returns all interfaces realized by the type, including those inherited from
        /// supertypes
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static IEnumerable<Type> Interfaces(this Type src)
            => src.GetInterfaces() ?? new Type[]{};

        /// <summary>
        /// Returns the methods from the source type per the binding flags, exluding those with special names
        /// </summary>
        /// <param name="src">The type to examine</param>
        /// <param name="flags">The reflection query flags</param>
        static IEnumerable<MethodInfo> NonSpecialMethods(this Type src, BindingFlags flags)
            => src.GetMethods(flags).Where(m => !m.IsSpecialName);

        /// <summary>
        /// Selects all methods declared by a type; however, property getters/setters and other 
        /// compiler-generated artifacts are excluded
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static IEnumerable<MethodInfo> DeclaredMethods(this Type src)
            => src.NonSpecialMethods(BF_Declared);

        /// <summary>
        /// Selects the methods available through the type, including those that were inherited; 
        /// however, property getters/setters and other compiler-generated artifacts are excluded
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static IEnumerable<MethodInfo> Methods(this Type src)
            => src.NonSpecialMethods(BF_All);

        /// <summary>
        /// Selects the methods available through the type that were not declared by the type
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static IEnumerable<MethodInfo> UndeclaredMethods(this Type src)
            => src.Methods().Except(src.DeclaredMethods());

        /// <summary>
        /// Selects the public/non-public static/instance methods declared by a type that have a specific name
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static IEnumerable<MethodInfo> DeclaredMethods(this Type src, string name)
            => src.DeclaredMethods().Where(m => m.Name == name);
 
        /// <summary>
        /// Selects the public/non-public static/instance methods declared by a stream of types
        /// </summary>
        /// <param name="src">The types to examine</param>
        public static IEnumerable<MethodInfo> DeclaredMethods(this IEnumerable<Type> src)
            => src.Select(x => x.DeclaredMethods()).SelectMany(x => x);

        /// <summary>
        /// Gets the static methods defined on a specified type
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static IEnumerable<MethodInfo> StaticMethods(this Type src)
            => src.Methods().Where(m => m.IsStatic);

        /// <summary>
        /// Retrieves the public and non-public static methods declared by a type
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static IEnumerable<MethodInfo> DeclaredStaticMethods(this Type t)
            => t.NonSpecialMethods(BF_DeclaredStatic);

        /// <summary>
        /// Retrieves the public and non-public static methods declared by a type that have a specific name
        /// </summary>
        /// <param name="t">The type to examine</param>
        /// <param name="InstanceType">Whether to selct static or instance </param>
        public static IEnumerable<MethodInfo> DeclaredStaticMethods(this Type t, string name)
            => t.DeclaredStaticMethods().Where(m => m.Name == name);

        /// <summary>
        /// Retrieves the public and non-public instance methods declared by a type
        /// </summary>
        /// <param name="t">The type to examine</param>
        /// <param name="InstanceType">Whether to selct static or instance </param>
        public static IEnumerable<MethodInfo> DeclaredInstanceMethods(this Type t)
            => t.NonSpecialMethods(BF_DeclaredInstance);

        /// <summary>
        /// Retrieves all properties declared by a by a type
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static IEnumerable<PropertyInfo> DeclaredProperties(this Type src)
            => src.GetProperties(BF_Declared);

        /// <summary>
        /// Retrieves all declared or inheraited by a type
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static IEnumerable<PropertyInfo> Properties(this Type src)
            => src.GetProperties(BF_All);

        /// <summary>
        /// Gets the static methods defined on a specified type
        /// </summary>
        /// <param name="this">The type to examine</param>
        public static IEnumerable<PropertyInfo> StaticProperties(this Type src)
            => src.GetProperties(BF_AllStatic);

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


    }
}