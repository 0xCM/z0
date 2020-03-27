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

    partial class XTend
    {
        /// <summary>
        /// Selects the members with a particular name
        /// </summary>
        /// <param name="src">The members to examine</param>
        /// <param name="name">The name to match</param>
        public static IEnumerable<T> WithName<T>(this IEnumerable<T> src, string name)
            where T : MemberInfo
                => src.Where(x => x.Name == name); 

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