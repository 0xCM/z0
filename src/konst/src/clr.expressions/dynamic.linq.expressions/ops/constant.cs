//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq.Expressions;
    using System.Runtime.CompilerServices;

    using static Part;

    using XPR = System.Linq.Expressions.Expression;

    partial class LinqXPress
    {
        /// <summary>
        /// Creates a constant expression
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static ConstantExpression constant(object src)
            => XPR.Constant(src);
    }
}