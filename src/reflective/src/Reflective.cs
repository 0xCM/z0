//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Linq;
    using System.Collections.Generic;
    using static ReflectionFlags;

    using static Konst;    
    
    [ApiHost]
    public static partial class Reflective
    {
        /// <summary>
        /// Attempts to retrieves the value of a static or instance property
        /// </summary>
        /// <typeparam name="V">The value type</typeparam>
        /// <param name="member">The property</param>
        /// <param name="instance">The object instance, if applicable</param>
        public static Option<V> value<V>(PropertyInfo member, object instance = null)
            => from o in member.Read(instance)
                from v in Option.TryCast<V>(o)
                select v;

        /// <summary>
        /// Attempts to retrieves the value of a field
        /// </summary>
        /// <typeparam name="V">The value type</typeparam>
        /// <param name="member">The field</param>
        /// <param name="instance">The object instance, if applicable</param>
        public static Option<V> value<V>(FieldInfo member, object instance = null)
            => from o in member.Value(instance)
            from v in Option.TryCast<V>(o)
            select v;

        /// <summary>
        /// Retrieves the identified <see cref="PropertyInfo"/>
        /// </summary>
        /// <param name="o">The object on which the property is defined</param>
        /// <param name="propname"></param>
        static PropertyInfo GetProperty(object o, string propname)
            => o.GetType().GetProperty(propname, BF_Instance);

        /// <summary>
        /// Retrieves the public properties declared on an object's type
        /// </summary>
        /// <param name="o">The object</param>
        [MethodImpl(Inline)]
        public static PropertyInfo[] props(object o)
            => o == null
            ? new PropertyInfo[]{}
            : o.GetType().GetProperties(BF_AllPublicInstance);

        /// <summary>
        /// Retrieves the public properties declared on a type
        /// </summary>
        [MethodImpl(Inline)]
        public static PropertyInfo[] props(Type type)
            => type.GetProperties(BF_AllPublicInstance);

        /// <summary>
        /// Attempts the retrieve a named property declared on a type
        /// </summary>
        /// <param name="t">The type to examine</param>
        /// <param name="name">The name of the property</param>
        public static Option<PropertyInfo> prop(Type t, string name)
            => props(t).FirstOrDefault(p => p.Name == name);

        /// <summary>
        /// Gets the value of the identified property
        /// </summary>
        /// <param name="o">The object on which the property is defined</param>
        /// <param name="propname">The name of the property</param>
        [MethodImpl(Inline)]
        public static object propval(object o, string propname)
            => GetProperty(o,propname)?.GetValue(o);

        /// <summary>
        /// Gets the value of a name-identified property on an object instance
        /// </summary>
        /// <typeparam name="T">The property value type</typeparam>
        /// <param name="o">The object on which the property is defined</param>
        /// <param name="propname">The name of the property</param>
        [MethodImpl(Inline)]
        public static T propval<T>(object o, string propname)
            => (T)propval(o, propname);

        /// <summary>
        /// Returns true if the source type is non-null and non-void; otherwise, returns false
        /// </summary>
        /// <param name="src">The type to examine</param>
        [MethodImpl(Inline), Op]
        public static bool IsSome(this Type src)
            => src != null && src != typeof(void); 

        /// <summary>
        /// Encloses text between less than and greater than characters
        /// </summary>
        /// <param name="content">The content to enclose</param>
        [MethodImpl(Inline)]
        internal static string angled(string content)
            => String.IsNullOrWhiteSpace(content) ? string.Empty : $"<{content}>";
    }

    public static partial class XTend
    {

    }

}