//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using System.Linq.Expressions;
    
    using static Konst;

    /// <summary>
    /// Wraps a delegate that implicitly converts into a LINQ expression
    /// </summary>
    /// <typeparam name="X1">The type of the first argument</typeparam>
    /// <typeparam name="X2">The type of the second argument</typeparam>
    /// <typeparam name="X3">The type of the third argument</typeparam>
    /// <typeparam name="Y">The function return type</typeparam>
    public readonly struct XFunc<X1,X2,X3,R>
    {
        /// <summary>
        /// Implicitly converts a func expression to linq expression
        /// </summary>
        /// <param name="fx">The source func expression</param>
        [MethodImpl(Inline)]
        public static implicit operator Expression<Func<X1,X2,X3,R>>(XFunc<X1,X2,X3,R> fx)
            => fx.Fx;

        /// <summary>
        /// Implicitly constructs a func expression from a func
        /// </summary>
        /// <param name="f">The source function</param>
        [MethodImpl(Inline)]
        public static implicit operator XFunc<X1,X2,X3,R>(Func<X1,X2,X3,R> f)
            => new XFunc<X1,X2,X3,R>(f);

        [MethodImpl(Inline)]
        public XFunc(Func<X1,X2,X3,R> f)
            => this.Fx = (x1, x2, x3) => f(x1, x2, x3);

        /// <summary>
        /// The expression derived from the source function
        /// </summary>
        public Expression<Func<X1,X2,X3,R>> Fx {get;}
    }
}