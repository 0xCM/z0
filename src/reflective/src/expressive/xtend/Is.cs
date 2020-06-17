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
        /// Tests whether an expression is a conversion
        /// </summary>
        /// <param name="x">The expression to examine</param>
        public static bool IsConversion(this Expression x)
            => XQuery.IsConversion(x);

        /// <summary>
        /// Tests whether a member is wrapped in a conversion
        /// </summary>
        /// <typeparam name="T">The declaring type</typeparam>
        /// <typeparam name="R">The member type</typeparam>
        /// <param name="selector">Expression that identifies the member</param>
        public static bool IsConversion<T,R>(this Expression<Func<T,R>> selector)
            => XQuery.IsConversion(selector);

        /// <summary>
        /// Tests whether the test expression is a member access expression
        /// </summary>
        /// <param name="x">The expression to examine</param>
        public static bool IsMemberAccess(this Expression x)
            => XQuery.IsAccess(x);

        /// <summary>
        /// Tests whether the test expression is a function call
        /// </summary>
        /// <param name="x">The expression to examine</param>
        public static bool IsCall(this Expression x)
            => XQuery.IsCall(x);

        /// <summary>
        /// Tests whether an expression is an application of the LINQ select operator
        /// </summary>
        /// <param name="x">The expression to test</param>
        public static bool IsSelect(this Expression x)
            => XQuery.IsSelect(x);

        /// <summary>
        /// Tests whether an expression is a logical operator
        /// </summary>
        /// <param name="x">The expression to examine</param>
        public static bool IsLogical(this Expression x)
            => XQuery.IsLogical(x);

        /// <summary>
        /// Tests whether an expression is a lambda expression
        /// </summary>
        /// <param name="x">The expression to examine</param>
        public static bool IsLambda(this Expression x)
            => XQuery.IsLambda(x);

        /// <summary>
        /// Tests whether an expression is a logical disjunction
        /// </summary>
        /// <param name="x">The expression to examine</param>
        public static bool IsDisjunction<X>(this X x)
            where X : Expression
                => XQuery.disjunction(x).Exists;

        /// <summary>
        /// Tests whether an expression is a logical conjunction
        /// </summary>
        /// <param name="x">The expression to examine</param>
        public static bool IsConjunction<X>(this X x)
            where X : Expression
                => XQuery.conjunction(x).Exists;

        /// <summary>
        /// Deterines whether the test expression is either a logical conjuntion or disjunction
        /// </summary>
        /// <param name="X">The expression to examine</param>
        public static bool IsJunction(this Expression x)
            => XQuery.junction(x).Exists;

        /// <summary>
        /// Performs a type-test on an expression
        /// </summary>
        /// <typeparam name="X1">The first candidate type</typeparam>
        /// <typeparam name="X2">The second candidate type</typeparam>
        /// <param name="x">The expression to test</param>
        public static bool IsOneOf<X1,X2>(this Expression x)
            where X1 : Expression
            where X2 : Expression
                => XQuery.test<X1,X2>(x);

        /// <summary>
        /// Performs a type-test on an expression
        /// </summary>
        /// <typeparam name="X1">The first candidate type</typeparam>
        /// <typeparam name="X2">The second candidate type</typeparam>
        /// <typeparam name="X3">The third candidate type</typeparam>
        /// <param name="x">The expression to test</param>
        public static bool IsOneOf<X1,X2,X3>(this Expression x)
            where X1 : Expression
            where X2 : Expression
            where X3 : Expression
                => XQuery.test<X1,X2,X3>(x);

        /// <summary>
        /// Performs a type-test on an expression
        /// </summary>
        /// <typeparam name="X1">The first candidate type</typeparam>
        /// <typeparam name="X2">The second candidate type</typeparam>
        /// <typeparam name="X3">The third candidate type</typeparam>
        /// <typeparam name="X4">The fourth candidate type</typeparam>
        /// <param name="x">The expression to test</param>
        public static bool IsOneOf<X1,X2,X3,X4>(this Expression x)
            where X1 : Expression
            where X2 : Expression
            where X3 : Expression
            where X4 : Expression
                => XQuery.test<X1,X2,X3,X4>(x);
    }
}