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
    using static Control;

    public partial class XQuery
    { 
        /// <summary>
        /// Extracts a value from a constant expression if possible
        /// </summary>
        /// <param name="x">The expression to examine</param>
        [MethodImpl(Inline)]
        public static Option<object> constant(Expression x)
            => TryCast<ConstantExpression>(x).TryMap(c => c.Value);
    }
}