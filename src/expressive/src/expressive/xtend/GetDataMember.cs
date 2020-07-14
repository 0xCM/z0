//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Linq.Expressions;

    using static Konst;

    partial class XTend
    {
        /// <summary>
        /// Extracts the member info for the member referenced by an expression delegate
        /// </summary>
        /// <typeparam name="T">The first selector parameter</typeparam>
        /// <typeparam name="M">The member type</typeparam>
        /// <param name="selector">The selecting expression that identifies the desired member</param>
        public static MemberInfo GetMember<T,M>(this Expression<Func<T,M>> selector)
            => XQuery.member(selector);

        /// <summary>
        /// Extracts the <see cref="DataMember"/> for the member referenced by a an expression delegate
        /// </summary>
        /// <typeparam name="T">The member selector</typeparam>
        /// <typeparam name="M">The member type</typeparam>
        /// <param name="selector">The selecting expression that identifies the desired member</param>
        public static DataMember GetDataMember<T,M>(this Expression<Func<T,M>> selector)
        {
            var property = selector.GetProperty();
            if (property != null)
                return property;

            var field = selector.GetField();
            if (field != null)
                return field;

            var member = selector.AccessedMember();
            if (member)
                throw new ArgumentException($"Members of type {(member.ValueOrDefault()).MemberType} are not considered value memembers");
            else
                throw new ArgumentException($"Could not determine any member from {selector}");
        }
    }
}