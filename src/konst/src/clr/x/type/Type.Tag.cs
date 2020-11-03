//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    partial class XClrQuery
    {
        /// <summary>
        /// Gets the value of a member attribute if it exists
        /// </summary>
        /// <typeparam name="A">The attribute type</typeparam>
        /// <param name="m">The member</param>
        public static Option<A> Tag<A>(this Type t, bool effective = true)
            where A : Attribute
                => effective ? t.EffectiveType().GetCustomAttribute<A>() : t.GetCustomAttribute<A>();
    }
}