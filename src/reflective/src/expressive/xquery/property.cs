//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Control;

    partial class XQuery
    { 
        /// <summary>
        /// Extracts the property info for the property referenced by an expression delegate
        /// </summary>
        /// <typeparam name="P">The property type</typeparam>
        /// <param name="selector">The selecting expression that identifies the desired member</param>
        public static PropertyInfo property<P>(Expression<Func<P>> selector)
            => cast<PropertyInfo>(cast<MemberExpression>(selector.SelectionSubject()).Member);

        /// <summary>
        /// Extracts the property info for the property referenced by an expression delegate
        /// </summary>
        /// <typeparam name="T">The declaring type</typeparam>
        /// <typeparam name="P">The property type</typeparam>
        /// <param name="selector">The selecting expression that identifies the desired member</param>
        public static PropertyInfo property<T,P>(Expression<Func<T,P>> selector)
            => cast<PropertyInfo>(cast<MemberExpression>(selector.SelectionSubject()).Member);
    }
}