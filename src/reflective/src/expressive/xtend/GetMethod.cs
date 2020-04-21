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
        /// <summary>
        /// Extracts the method info for the function referenced by an expression delegate
        /// </summary>
        /// <typeparam name="T">The function return type</typeparam>
        /// <param name="selector">The call expression</param>
        public static MethodInfo GetMethod<T>(this Expression<Func<T>> selector)
            => XQuery.method(selector);

        /// <summary>
        /// Extracts the method info for the function referenced by an expression delegate
        /// </summary>
        /// <typeparam name="T1">The first function argument</typeparam>
        /// <typeparam name="T2">The function return type</typeparam>
        /// <param name="selector">The call expression</param>
        public static MethodInfo GetMethod<T1,T2>(this Expression<Func<T1,T2>> selector)
            => XQuery.method(selector);

        /// <summary>
        /// Extracts the method info for the function referenced by an expression delegate
        /// </summary>
        /// <typeparam name="T1">The first function argument</typeparam>
        /// <typeparam name="T2">The second function argument</typeparam>
        /// <typeparam name="R">The function return type</typeparam>
        /// <param name="selector">The call expression</param>
        public static MethodInfo GetMethod<T1,T2,R>(this Expression<Func<T1,T2,R>> selector)
            => XQuery.method(selector);

        /// <summary>
        /// Extracts the method info for the function referenced by an expression delegate
        /// </summary>
        /// <typeparam name="T1">The first function argument</typeparam>
        /// <typeparam name="T2">The second function argument</typeparam>
        /// <typeparam name="T3">The third function argument</typeparam>
        /// <typeparam name="R">The function return type</typeparam>
        /// <param name="selector">Specifies the call expression</param>
        public static MethodInfo GetMethod<T1,T2,T3,R>(this Expression<Func<T1,T2,T3,R>> selector)
            => XQuery.method(selector);

        /// <summary>
        /// Extracts the method for the action referenced by an an expression delegate
        /// </summary>
        /// <typeparam name="T">The action argument</typeparam>
        /// <param name="selector">Specifies the call expression</param>
        public static MethodInfo GetMethod<T>(this Expression<Action<T>> selector)
            => XQuery.method(selector);

        /// <summary>
        /// Extracts the method info for the action referenced by an expression delegate
        /// </summary>
        /// <typeparam name="T1">The first action argument</typeparam>
        /// <typeparam name="T2">The second action argument</typeparam>
        /// <param name="selector">Specifies the call expression</param>
        public static MethodInfo GetMethod<T1,T2>(this Expression<Action<T1,T2>> selector)
            => XQuery.method(selector);

        /// <summary>
        /// Extracts the method info for the action referenced by an expression delegate
        /// </summary>
        /// <typeparam name="T1">The first action argument</typeparam>
        /// <typeparam name="T2">The second action argument</typeparam>
        /// <typeparam name="T3">The third action argument</typeparam>
        /// <param name="selector">Specifies the call expression</param>
        public static MethodInfo GetMethod<T1,T2,T3>(this Expression<Action<T1,T2,T3>> selector)
            => XQuery.method(selector);

        /// <summary>
        /// Extracts the method info for the action referenced by an expression delegate
        /// </summary>
        /// <typeparam name="T1">The first action argument</typeparam>
        /// <typeparam name="T2">The second action argument</typeparam>
        /// <typeparam name="T3">The third action argument</typeparam>
        /// <typeparam name="T4">The fourth action argument</typeparam>
        /// <param name="selector">The call expression</param>
        public static MethodInfo GetMethod<T1,T2,T3,T4>(this Expression<Action<T1,T2,T3,T4>> selector)
            => XQuery.method(selector);
    }
}