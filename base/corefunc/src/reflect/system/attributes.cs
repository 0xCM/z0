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
    
    using static zfunc;
    using static ReflectionFlags;

    partial class Reflections
    {        
        /// <summary>
        /// Gets the value of a member attribute if it exists 
        /// </summary>
        /// <typeparam name="A">The attribute type</typeparam>
        /// <param name="m">The member</param>
        public static Option<A> CustomAttribute<A>(this MemberInfo m) where A : Attribute
            => m.GetCustomAttribute<A>();

        /// <summary>
        /// Determines whether an attribute is applied to a subject
        /// </summary>
        /// <param name="m">The subject to examine</param>
        /// <typeparam name="T">The type of attribute for which to check</typeparam>
        public static bool Attributed<T>(this MemberInfo m) 
            where T : Attribute
                => System.Attribute.IsDefined(m, typeof(T));

        /// <summary>
        /// Retrieves the value of an attached attribute paired with the subject
        /// </summary>
        /// <param name="m">The member to query</param>
        /// <typeparam name="A">The attribute type</typeparam>
        public static Pair<MemberInfo,A> Attribution<A>(this MemberInfo m)
            where A : Attribute
                => (m,(A)m.GetCustomAttribute(typeof(A)));

        /// <summary>
        /// Returns true if a parametrically-identified attribute is not applied to the subject
        /// </summary>
        /// <param name="m">The subject to examine</param>
        /// <typeparam name="T">The type of attribute for which to check</typeparam>
        public static bool Unattributed<T>(this MemberInfo m) 
            where T : Attribute
                => !m.Attributed<T>();

        /// <summary>
        /// Determines whether an attribute of specified type is attached to a member
        /// </summary>
        /// <param name="m">The member to test</param>
        /// <param name="t">The target attribute type</param>
        [MethodImpl(Inline)]
        public static bool Attributed(this MemberInfo m, Type t)
            => Attribute.IsDefined(m,t);

        /// <summary>
        /// Determines whether a parameter has a parametrically-identified attribute
        /// </summary>
        /// <param name="p">The parameter to examine</param>
        /// <typeparam name="A">The attribute type to check</typeparam>
        public static bool Attributed<A>(this ParameterInfo p)
            where A : Attribute
                => Attribute.IsDefined(p,typeof(A));

        /// <summary>
        /// Retrieves type attribution values from a stream of types
        /// </summary>
        /// <typeparam name="A"></typeparam>
        /// <param name="types"></param>
        public static IReadOnlyDictionary<Type, Option<A>> TypeAttributions<A>(this IEnumerable<Type> types)
            where A : Attribute
            => (from type in types
                let attrib = type.GetCustomAttribute<A>(true)
                select (type, attrib != null
                        ? some(attrib)
                        : none<A>())).ToReadOnlyDictionary();

        /// <summary>
        /// Retrieves the type's properties together with applied attributes
        /// </summary>
        /// <typeparam name="A">The attribute type</typeparam>
        /// <param name="t">The type to examine</param>
        public static Pairs<PropertyInfo, A> PropertyAttributions<A>(this Type t) 
            where A : Attribute
                => Pairs.Define(
                    from p in t.DeclaredProperties()
                    where p.Attributed<A>() 
                    let attrib = p.GetCustomAttribute<A>()
                    select (p,attrib)
                    );

        /// <summary>
        /// Retrieves the type's fields together with applied attributes
        /// </summary>
        /// <typeparam name="A">The attribute type</typeparam>
        /// <param name="t">The type to examine</param>
        public static Pairs<FieldInfo, A> FieldAttributions<A>(this Type t) 
            where A : Attribute
                => Pairs.Define(
                    from p in t.DeclaredFields()
                    where p.Attributed<A>() 
                    let attrib = p.GetCustomAttribute<A>()
                    select (p,attrib)
                    );

        /// <summary>
        /// Retrieves the attribution index for the identified methods declared by the type
        /// </summary>
        /// <typeparam name="A">The attribute type</typeparam>
        /// <param name="t">The type to examine</param>
        /// <param name="InstanceType">The member instance type</param>
        public static Pairs<MethodInfo, A> MethodAttributions<A>(this Type t)
            where A : Attribute
                => Pairs.Define(
                    from p in t.DeclaredMethods()
                    where p.Attributed<A>() 
                    let attrib = p.GetCustomAttribute<A>()
                    select (p,attrib)
                    );

        /// <summary>
        /// Gets the type attributions for the specified assembly
        /// </summary>
        /// <param name="a">The source assembly</param>
        /// <typeparam name="A">The attribute type</typeparam>
        public static IDictionary<Type, A> TypeAttributions<A>(this Assembly a, Func<Type,bool> pred = null)
            where A : Attribute
        {
            var f = pred ?? (t => true);
            var q = from t in a.GetTypes()
                    where Attribute.IsDefined(t, typeof(A)) && f(t)
                    let attrib = t.GetCustomAttribute<A>()
                    select new
                    {
                        Type = t,
                        Attribute = attrib
                    };
            return q.ToDictionary(x => x.Type, x => x.Attribute);
        }

        /// <summary>
        /// Gets the type attributions for the specified assembly
        /// </summary>
        /// <param name="a">The source assembly</param>
        /// <param name="fullAttributeTypeName">The full type name of the attribute</param>
        public static IDictionary<Type, dynamic> TypeAttributions(this Assembly a, string fullAttributeTypeName)
        {
            var attributions = new Dictionary<Type, dynamic>();
            foreach (var t in a.GetTypes())
            {
                foreach (var attrib in t.GetCustomAttributes())
                {
                    if (attrib.GetType().FullName == fullAttributeTypeName)
                    {
                        attributions[t] = attrib;
                        continue;
                    }
                }
            }
            return attributions;
        }

    }

}