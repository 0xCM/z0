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

    using static PartIdentity;

    /// <summary>
    /// Applies to an element to exclude it from metadata discovery processes
    /// </summary>
    public class IgnoreAttribute : Attribute
    {

    }

    partial class XTend
    {
        /// <summary>
        /// Returns true if the [Ignore] attributed is applied to the target 
        /// </summary>
        /// <param name="target">The target</param>
        [MethodImpl(Inline)]
        public static bool Ignored(this MemberInfo target)
            => Attribute.IsDefined(target, typeof(IgnoreAttribute));

        /// <summary>
        /// Returns true if the target is not attributed with the [Ignore] attribute
        /// </summary>
        /// <param name="target">The target</param>
        [MethodImpl(Inline)]
        public static bool NotIgnored(this MemberInfo target)
            => !Ignored(target);
    }
}