//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Linq.Expressions;
    using System.Runtime.CompilerServices;

    using static Konst;

    public partial class XQuery
    { 
        /// <summary>
        /// Returns the method invoked by an expression, if any
        /// </summary>
        /// <param name="x">The expression to test</param>
        public static Option<MethodInfo> called(Expression x)
            => cast<MethodCallExpression>(x)?.Method;
    }
}