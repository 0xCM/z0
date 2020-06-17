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

    using static Konst;
    using static Control;

    using XPR = System.Linq.Expressions.Expression;

    partial class XTend
    {
        /// <summary>
        /// Extracts the name of the value member referenced by an expression delegate
        /// </summary>
        /// <typeparam name="T">The member selector</typeparam>
        /// <typeparam name="M">The member type</typeparam>
        /// <param name="selector">The selecting expression that identifies the desired member</param>
        public static string GetValueMemberName<T,M>(this Expression<Func<T,M>> selector)
            => selector.GetValueMember().Name;

        /// <summary>
        /// Extracts property info from a member expression, if possbile, and otherwise returns null
        /// </summary>
        /// <param name="x">The expression to examine</param>
        public static PropertyInfo GetAccessedProperty(this Expression x)
            => cast<PropertyInfo>(cast<MemberExpression>(x)?.Member);

        /// <summary>
        /// Extracts member info from an expression, if possbile; otherwise returns none
        /// </summary>
        /// <param name="x">The expression to examine</param>
        public static Option<MemberInfo> AccessedMember(this Expression X)
        {
            var M = TryCast<MemberExpression>(X).ValueOrDefault();
            if (M != null)
                return M.Member;
            else
                return TryCast<LambdaExpression>(X).Select(y => y.Body.AccessedMember().ValueOrDefault());
        }

        public static Option<MemberInfo> AccessedMember(this BinaryExpression X)
            => X.Left.AccessedMember().ValueOrElse(() => X.Right.AccessedMember().ValueOrDefault());


        /// <summary>
        /// Extracts property info from an expression, if possbile; otherwise returns none
        /// </summary>
        /// <param name="x">The expression to examine</param>
        public static Option<PropertyInfo> AccesedProperty(this Expression x)
        {
            var candiate = TryCast<MemberExpression>(x).Select(GetAccessedProperty);
            if (candiate)
                return candiate;
            else
                return TryCast<LambdaExpression>(x).Select(y => y.Body.AccesedProperty().ValueOrDefault());
        }
    }
}