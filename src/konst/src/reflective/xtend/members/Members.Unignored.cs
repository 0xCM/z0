//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    
    partial class XTend
    {
        /// <summary>
        /// Selects source members that are not tagged with <see cref='IgnoreAttribute'/>
        /// </summary>
        /// <param name="src">The members to examine</param>
        /// <param name="name">The name to match</param>
        public static T[] Unignored<T>(this T[] src)
            where T : MemberInfo
                => src.Where(m => !m.Tagged(typeof(IgnoreAttribute))); 
    }
}