//-------------------------------------------------------------------------------------------
// MetaCore
// Author: Chris Moore, 0xCM@gmail.com
// License: MIT
//-------------------------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Collections.Concurrent;
    using System.Reflection;

    using static Monadic;
    using static Option;
    using static ReflectionFlags;

    public static partial class OptionOps
    {
        /// <summary>
        /// Gets the value of a member attribute if it exists 
        /// </summary>
        /// <typeparam name="A">The attribute type</typeparam>
        /// <param name="m">The member</param>
        public static Option<A> Tag<A>(this Type t) 
            where A : Attribute
                => t.GetCustomAttribute<A>();

        /// <summary>
        /// Gets the value of a member attribute if it exists 
        /// </summary>
        /// <typeparam name="A">The attribute type</typeparam>
        /// <param name="m">The member</param>
        public static Option<A> Tag<A>(this MethodInfo t) 
            where A : Attribute
                => t.GetCustomAttribute<A>();
        /// <summary>
        /// Gets the value of a member attribute if it exists 
        /// </summary>
        /// <typeparam name="A">The attribute type</typeparam>
        /// <param name="m">The member</param>
        public static Option<A> Tag<A>(this MemberInfo m) 
            where A : Attribute
                => m.GetCustomAttribute<A>();

        /// <summary>
        /// Selects source types from the stream to wich a parametrically-identified attribute is applied
        /// </summary>
        /// <param name="src">The source stypes</param>
        /// <typeparam name="A">The attribute type</typeparam>
        public static IEnumerable<Type> Tagged<A>(this IEnumerable<Type> src)
            where A : Attribute
                => src.Where(t => System.Attribute.IsDefined(t, typeof(A)));

        /// <summary>
        /// Returns the source method's kind identifier if it exists
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static OpKindId? KindId(this MethodInfo m)
            => m.Tag<OpKindAttribute>().MapValueOrNull(a => a.KindId);

        /// <summary>
        /// Attempts to retrieve the value of an instance or static field
        /// </summary>
        /// <param name="field">The field</param>
        /// <param name="instance">The object instance, if applicable</param>
        public static Option<object> Value(this FieldInfo field, object instance = null)
            => Option.Try(() => field.GetValue(instance));

        /// <summary>
        /// Attempts to retrieve a name-identified field from a type
        /// </summary>
        /// <param name="src">The type to examine</param>
        /// <param name="name">The name of the field</param>
        /// <param name="declared">Whether the field is required to be declared by the source type</param>
        public static Option<FieldInfo> Field(this Type src, string name)        
            => src.GetFields(BF_All).FirstOrDefault(f => f.Name == name);

        public static Option<PropertyInfo> Property(this Type src, string name)
            => src.GetProperties(BF_Declared).Where(p => p.Name == name).FirstOrDefault();

        /// <summary>
        /// Attempts to retrieve the value of an instance or static property
        /// </summary>
        /// <param name="p">The property</param>
        /// <param name="instance">The object instance, if applicable</param>
        public static Option<object> TryGetValue(this PropertyInfo p, object instance = null)
            => Option.Try(() => p.GetValue(instance));

        public static Option<object> Read(this PropertyInfo p, object src)
            => Option.Try(() => p.GetValue(src));
        
        public static Option<T> Read<T>(this PropertyInfo p, object src)
            => Option.Try(() => (T)p.GetValue(src));

        public static Option<object> Write(this PropertyInfo p, object src, object dst)
        {
            try
            {
                p.SetValue(dst,src);
                return dst;
            }
            catch(Exception e)
            {
                Console.Error.Write(e);
                return default;
            }
        }

        /// <summary>
        /// If the source type is a type reference, returns the referenced type; otherwise, returns the original type
        /// </summary>
        /// <param name="src">The type to examine</param>
        static Type EffectiveType(this Type src)
            => src.UnderlyingSystemType.IsByRef ? src.GetElementType() : src;

        /// <summary>
        /// For a generic type or reference to a generic type, retrieves the generic type definition; otherwise, returns none
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


        /// <summary>
        /// Searches a type for any method that matches the supplied signature
        /// </summary>
        /// <param name="declarer">The type to search</param>
        /// <param name="name">The name of the method</param>
        /// <param name="paramTypes">The method parameter types in ordinal position</param>
        public static Option<MethodInfo> MatchMethod(this Type declarer, string name, params Type[] paramTypes)
            => paramTypes.Length != 0
                ? declarer.GetMethod(name, bindingAttr: AnyVisibilityOrInstanceType, binder: null, types: paramTypes, modifiers: null)
                : declarer.GetMethod(name, AnyVisibilityOrInstanceType);
    }
}