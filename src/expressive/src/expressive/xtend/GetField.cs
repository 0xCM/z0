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
        /// Extracts the field info for the field referenced by an expression delegate
        /// </summary>
        /// <typeparam name="F">The field type</typeparam>
        /// <param name="selector">The selecting expression that identifies the desired member</param>
        public static FieldInfo GetField<F>(this Expression<Func<F>> selector)
            => XQuery.field(selector);

        /// <summary>
        /// Extracts the field info for the field referenced by an expression delegate
        /// </summary>
        /// <typeparam name="T">The declaring type</typeparam>
        /// <typeparam name="P">The property type</typeparam>
        /// <param name="selector">The selecting expression that identifies the desired member</param>
        public static FieldInfo GetField<T,P>(this Expression<Func<T,P>> selector)
            => XQuery.field(selector);
    }
}