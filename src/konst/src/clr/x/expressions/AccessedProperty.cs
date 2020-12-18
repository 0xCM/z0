//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Linq.Expressions;

    using static Option;

    partial class XClrQuery
    {
        /// <summary>
        /// Extracts property info from a member expression, if possbile, and otherwise returns null
        /// </summary>
        /// <param name="src">The expression to examine</param>
        [Op]
        public static PropertyInfo GetAccessedProperty(this Expression src)
            => memory.cast<PropertyInfo>(memory.cast<MemberExpression>(src)?.Member);

        /// <summary>
        /// Extracts property info from an expression, if possbile; otherwise returns none
        /// </summary>
        /// <param name="src">The expression to examine</param>
        [Op]
        public static Option<PropertyInfo> AccessedProperty(this Expression src)
        {
            var candidate = TryCast<MemberExpression>(src).Select(GetAccessedProperty);
            if (candidate)
                return candidate;
            else
                return TryCast<LambdaExpression>(src).Select(y => y.Body.AccessedProperty().ValueOrDefault());
        }
    }
}