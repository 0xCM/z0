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

    public partial class XPress
    {
        /// <summary>
        /// Defines a conversion from a source expression to a target type
        /// </summary>
        /// <param name="e">The source expression</param>
        /// <param name="dstType">The target type</param>
        [MethodImpl(Inline), Op]
        public static UnaryExpression convert(XPR e, Type dstType)
            => XPR.Convert(e, dstType);

        /// <summary>
        /// Defines a conversion from a source expression to a target type
        /// </summary>
        /// <typeparam name="T">The target type</typeparam>
        /// <param name="e">The source expression</param>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static UnaryExpression convert<T>(XPR e)
            => convert(e, typeof(T));
    }
}