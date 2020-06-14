//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    partial class XTend
    {
        /// <summary>
        /// Returns true if the [Ignore] attributed is applied to the target 
        /// </summary>
        /// <param name="target">The target</param>
        public static bool Ignored(this MemberInfo target)
            => Attribute.IsDefined(target, typeof(IgnoreAttribute));

        /// <summary>
        /// Returns true if the target is not attributed with the [Ignore] attribute
        /// </summary>
        /// <param name="target">The target</param>
        public static bool NotIgnored(this MemberInfo target)
            => !Ignored(target);

        /// <summary>
        /// Excludes members with ignored metadata
        /// </summary>
        /// <param name="src">The members to filter</param>
        public static T[] Ignore<T>(this T[] src)
            where T : MemberInfo
                => src.Where(NotIgnored);

        /// <summary>
        /// Excludes members with ignored metadata
        /// </summary>
        /// <param name="src">The members to filter</param>
        public static IEnumerable<T> Ignore<T>(this IEnumerable<T> src)
            where T : MemberInfo
                => src.Where(NotIgnored);
    }
}