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

    partial class XTend
    {
        [MethodImpl(Inline)]
        static T cast<T>(object src)
            => (T)src;

        public static NamedValue<T> Evaluate<T>(this Expression<Func<T>> fx)
            => XPress.evaluate(fx);

        /// <summary>
        /// Gets the expression that directly identifies the selected subject
        /// </summary>
        /// <typeparam name="M">The member type</typeparam>
        /// <param name="selector">The selecting expression that identifies the desired member</param>
        public static Expression SelectionSubject<M>(this Expression<Func<M>> selector)
            => XQuery.IsConversion(selector) ? (selector.Body as UnaryExpression).Operand : selector.Body;

        /// <summary>
        /// Gets the expression that directly identifies the selected subject
        /// </summary>
        /// <typeparam name="T">The declaring type</typeparam>
        /// <typeparam name="M">The member type</typeparam>
        /// <param name="selector">The selecting expression that identifies the desired member</param>
        internal static Expression SelectionSubject<T,M>(this Expression<Func<T,M>> selector)
            => XQuery.IsConversion(selector) ? (selector.Body as UnaryExpression).Operand : selector.Body;

        /// <summary>
        /// Determines the name of the property as identified by an expression delegate
        /// </summary>
        /// <typeparam name="T">The declaring type</typeparam>
        /// <typeparam name="P">The property type</typeparam>
        /// <param name="selector">The selecting expression that identifies the desired member</param>
        public static string SelectedPropertyName<T,P>(this Expression<Func<T,P>> selector)
            => selector.GetProperty().Name;

        public static Option<object> EvaluateFirst(this BinaryExpression x)
            => XPress.evaluate(x);

        public static Option<object> Evaluate(this Expression x)
            => XPress.evaluate(x);

        /// <summary>
        /// Returns the method invoked by an expression, if any
        /// </summary>
        /// <param name="x">The expression to test</param>
        public static Option<MethodInfo> CalledMethod(this Expression x)
            => XQuery.called(x);

        /// <summary>
        /// Returns the expression if it is a logical conjunction and None otherwise
        /// </summary>
        /// <param name="x">The expression to examine</param>
        public static Option<X> Conjunction<X>(this X x)
            where X : Expression
                => XQuery.conjunction(x);

        /// <summary>
        /// Returns the expression if it is a logical disjunction and None otherwise
        /// </summary>
        /// <param name="x">The expression to examine</param>
        public static Option<X> Disjunction<X>(this X x)
            where X : Expression
                => XQuery.disjunction(x);

        /// <summary>
        /// Extracts a value from a constant expression if possible
        /// </summary>
        /// <param name="x">The expression to examine</param>
        public static Option<object> Constant(this Expression x)
            => XQuery.constant(x);
    }
}