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
    
    using static zfunc;
    using static ReflectionFlags;

    partial class Reflections
    {        
        /// <summary>
        /// Retrieves the value of an attached attribute paired with the subject
        /// </summary>
        /// <param name="m">The member to query</param>
        /// <typeparam name="A">The attribute type</typeparam>
        public static Pair<MemberInfo,A> Attribution<A>(this MemberInfo m)
            where A : Attribute
                => (m,(A)m.GetCustomAttribute(typeof(A)));

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