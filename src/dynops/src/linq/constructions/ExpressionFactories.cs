//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Dynamics
{
    using System;
    using System.Collections;
    using System.Linq;
    using System.Linq.Expressions;

    using static Konst;
    using static Memories;

    using XPR = System.Linq.Expressions.Expression;

    public static class ExpressionFactories
    {
        /// <summary>
        /// Creates an expression that defines a function that returns true
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public static Expression<Func<T,bool>> True<T>()
            => f => true;

        /// <summary>
        /// Creates an expression that defines a function that returns false
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public static Expression<Func<T,bool>> False<T>()
            => f => false;

        /// <summary>
        /// Creates an expression that defines a logical OR function
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <typeparam name="T"></typeparam>
        public static Expression<Func<T,bool>> Or<T>(this Expression<Func<T,bool>> left, Expression<Func<T,bool>> right)
        {
            var invokedExpr = XPR.Invoke(right, left.Parameters.Cast<XPR>());
            return XPR.Lambda<Func<T, bool>>
                  (XPR.OrElse(left.Body, invokedExpr), left.Parameters);
        }
       
        /// <summary>
        /// Creates an expression that defines a logical AND function
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        /// <typeparam name="T"></typeparam>
        public static Expression<Func<T,bool>> And<T>(this Expression<Func<T,bool>> lhs, Expression<Func<T,bool>> rhs)
        {
            var invokedExpr = XPR.Invoke(rhs, lhs.Parameters.Cast<XPR>());
            return XPR.Lambda<Func<T, bool>>
                  (XPR.AndAlso(lhs.Body, invokedExpr), lhs.Parameters);
        }

        /// <summary>
        /// Creates an expression tha defines an equality comparison
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        /// <typeparam name="T"></typeparam>
        public static Expression<Func<bool>> Equal<T>(this Expression<Func<T>> lhs, Expression<Func<T>> rhs)
        {
            var lValue = XPR.Invoke(lhs);
            var rValue = XPR.Invoke(rhs);
            return XPR.Lambda<Func<bool>>(XPR.Equal(lValue, rValue));
        }
    }
}