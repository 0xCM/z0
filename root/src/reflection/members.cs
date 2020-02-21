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

    using static Root;
    
    partial class RootReflections
    {
        /// <summary>
        /// Gets the value of a specified field or property
        /// </summary>
        /// <param name="m">The field or property</param>
        /// <param name="o">The object on which the member is defined</param>
        [MethodImpl(Inline)]
        public static object MemberValue(this MemberInfo m, object o)
        {
            if (m is FieldInfo)
                return (m as FieldInfo).GetValue(o);
            else if (m is PropertyInfo)
                return (m as PropertyInfo).GetValue(o);
            else
                throw new NotSupportedException();
        }

        /// <summary>
        /// Gets the value of the identified member field or property
        /// </summary>
        /// <typeparam name="T">The value type</typeparam>
        /// <param name="m">The member</param>
        /// <param name="o">The instance from which to access the member</param>
        [MethodImpl(Inline)]
        public static T MemberValue<T>(this MemberInfo m, object o)
            => (T)m.MemberValue(o);

        /// <summary>
        /// Selects the members with a particular name
        /// </summary>
        /// <param name="src">The members to examine</param>
        /// <param name="name">The name to match</param>
        public static IEnumerable<T> WithName<T>(this IEnumerable<T> src, string name)
            where T : MemberInfo
                => src.Where(x => x.Name == name); 

        /// <summary>
        /// Determines whether an attribute is applied to a subject
        /// </summary>
        /// <param name="m">The subject to examine</param>
        /// <typeparam name="T">The type of attribute for which to check</typeparam>
        public static bool Attributed<T>(this MemberInfo m) 
            where T : Attribute
                => System.Attribute.IsDefined(m, typeof(T));

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
        public static bool Attributed(this MemberInfo m, Type t)
            => System.Attribute.IsDefined(m, t);


        /// Selects the members with a particular name
        /// </summary>
        /// <param name="src">The members to examine</param>
        /// <param name="name">The name to match</param>
        public static IEnumerable<T> Attributed<T>(this IEnumerable<T> src, Type attrib)
            where T : MemberInfo
                => src.Where(m => m.Attributed(attrib));

        /// <summary>
        /// Selects the members with a name that exists within a supplied set
        /// </summary>
        /// <param name="src">The members to examine</param>
        /// <param name="name">The name to match</param>
        public static IEnumerable<T> WithName<T>(this IEnumerable<T> src, HashSet<string> names)
            where T : MemberInfo
                => src.Where(x => names.Contains(x.Name));

        /// <summary>
        /// Selects the members with names that contain the supplied search field
        /// </summary>
        /// <param name="src">The members to examine</param>
        /// <param name="search">The name to match</param>
        public static IEnumerable<T> WithNameLike<T>(this IEnumerable<T> src, string search)
            where T : MemberInfo
                => src.Where(x => x.Name.Contains(search)); 

        /// <summary>
        /// Selects the members with names that contain the supplied search field
        /// </summary>
        /// <param name="src">The members to examine</param>
        /// <param name="search">The name to match</param>
        public static IEnumerable<T> WithNameLike<T>(this IEnumerable<T> src, params string[] search)
            where T : MemberInfo
            => from m in src
                where search.Any(match => m.Name.Contains(match))
                select m;

        /// <summary>
        /// Selects the members with names that contain the supplied search field
        /// </summary>
        /// <param name="src">The members to examine</param>
        /// <param name="search">The name to match</param>
        public static IEnumerable<T> WithNameStartingWith<T>(this IEnumerable<T> src, params string[] search)
            where T : MemberInfo
            => from m in src
                where search.Any(match => m.Name.StartsWith(match))
                select m;    

    }
}