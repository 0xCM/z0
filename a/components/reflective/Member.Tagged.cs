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
        /// Determines whether an attribute is applied to a subject
        /// </summary>
        /// <param name="m">The subject to examine</param>
        /// <typeparam name="T">The type of attribute for which to check</typeparam>
        public static bool Tagged<T>(this MemberInfo m) 
            where T : Attribute
                => System.Attribute.IsDefined(m, typeof(T));

        /// <summary>
        /// Determines whether an attribute of specified type is attached to a member
        /// </summary>
        /// <param name="m">The member to test</param>
        /// <param name="t">The target attribute type</param>
        public static bool Tagged(this MemberInfo m, Type t)
            => System.Attribute.IsDefined(m, t);

        /// <summary>
        /// Selects the members with a particular attribute
        /// </summary>
        /// <param name="src">The members to examine</param>
        /// <param name="name">The name to match</param>
        public static IEnumerable<T> Tagged<T>(this IEnumerable<T> src, Type attrib)
            where T : MemberInfo
                => src.Where(m => m.Tagged(attrib));
 
        /// <summary>
        /// Returns true if a parametrically-identified attribute is not applied to the subject
        /// </summary>
        /// <param name="m">The subject to examine</param>
        /// <typeparam name="T">The type of attribute for which to check</typeparam>
        public static bool Untagged<T>(this MemberInfo m) 
            where T : Attribute
                => !m.Tagged<T>();
    }
}