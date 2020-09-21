//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq.Expressions;
    using System.Runtime.CompilerServices;

    using static Konst;

    using XPR = System.Linq.Expressions.Expression;

    partial class XPress
    {
        /// <summary>
        /// Creates a constant expression
        /// </summary>
        /// <param name="src">The source value</param>
        [Op]
        public static ConstantExpression constant(object src)
            => XPR.Constant(src);
    }
}