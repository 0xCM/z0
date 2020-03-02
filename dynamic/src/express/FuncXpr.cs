//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Linq.Expressions;
    
    /// <summary>
    /// Encapsulates a delegate that implicitly converts into a LINQ expression
    /// </summary>
    /// <typeparam name="X">The function return type</typeparam>
    public readonly struct FuncXpr<X>
    {
        /// <summary>
        /// Implicitly converts a func expression to linq expression
        /// </summary>
        /// <param name="fx">The source func expression</param>
        public static implicit operator Expression<Func<X>>(FuncXpr<X> fx)
            => fx.Fx;

        /// <summary>
        /// Implicitly constructs a func expression from a func
        /// </summary>
        /// <param name="f">The source function</param>
        public static implicit operator FuncXpr<X>(Func<X> f)
            => new FuncXpr<X>(f);

        public FuncXpr(Func<X> f)
            => this.Fx = () => f();

        /// <summary>
        /// The expression derived from the source function
        /// </summary>
        public Expression<Func<X>> Fx { get; }
    }

    /// <summary>
    /// Encapsulates a delegate that implicitly converts into a LINQ expression
    /// </summary>
    /// <typeparam name="X">The function argument type</typeparam>
    /// <typeparam name="Y">The function return type</typeparam>
    public readonly struct FuncXpr<X, Y>
    {
        /// <summary>
        /// Implicitly converts a func expression to linq expression
        /// </summary>
        /// <param name="fx">The source func expression</param>
        public static implicit operator Expression<Func<X, Y>>(FuncXpr<X, Y> fx)
            => fx.Fx;

        /// <summary>
        /// Implicitly constructs a func expression from a func
        /// </summary>
        /// <param name="f">The source function</param>
        public static implicit operator FuncXpr<X, Y>(Func<X, Y> f)
            => new FuncXpr<X, Y>(f);

        public FuncXpr(Func<X, Y> f)
            => this.Fx = x => f(x);

        /// <summary>
        /// The expression derived from the source function
        /// </summary>
        public Expression<Func<X, Y>> Fx { get; }

    }

    /// <summary>
    /// Encapsulates a delegate that implicitly converts into a LINQ expression
    /// </summary>
    /// <typeparam name="X1">The type of the first argument</typeparam>
    /// <typeparam name="X2">The type of the second argument</typeparam>
    /// <typeparam name="Y">The function return type</typeparam>
    public readonly struct FuncXpr<X1, X2, Y>
    {
        /// <summary>
        /// Implicitly converts a func expression to linq expression
        /// </summary>
        /// <param name="fx">The source func expression</param>
        public static implicit operator Expression<Func<X1, X2, Y>>(FuncXpr<X1, X2, Y> fx)
            => fx.Fx;

        /// <summary>
        /// Implicitly constructs a func expression from a func
        /// </summary>
        /// <param name="f">The source function</param>
        public static implicit operator FuncXpr<X1, X2, Y>(Func<X1, X2, Y> f)
            => new FuncXpr<X1, X2, Y>(f);

        public FuncXpr(Func<X1, X2, Y> f)
            => this.Fx = (x1, x2) => f(x1,x2);

        /// <summary>
        /// The expression derived from the source function
        /// </summary>
        public Expression<Func<X1, X2, Y>> Fx { get; }

    }

    /// <summary>
    /// Encapsulates a delegate that implicitly converts into a LINQ expression
    /// </summary>
    /// <typeparam name="X1">The type of the first argument</typeparam>
    /// <typeparam name="X2">The type of the second argument</typeparam>
    /// <typeparam name="X3">The type of the third argument</typeparam>
    /// <typeparam name="Y">The function return type</typeparam>
    public readonly struct FuncXpr<X1, X2, X3, Y>
    {
        /// <summary>
        /// Implicitly converts a func expression to linq expression
        /// </summary>
        /// <param name="fx">The source func expression</param>
        public static implicit operator Expression<Func<X1, X2, X3, Y>>(FuncXpr<X1, X2, X3, Y> fx)
            => fx.Fx;

        /// <summary>
        /// Implicitly constructs a func expression from a func
        /// </summary>
        /// <param name="f">The source function</param>
        public static implicit operator FuncXpr<X1, X2, X3, Y>(Func<X1, X2, X3, Y> f)
            => new FuncXpr<X1, X2, X3, Y>(f);

        public FuncXpr(Func<X1, X2, X3, Y> f)
            => this.Fx = (x1, x2, x3) => f(x1, x2, x3);

        /// <summary>
        /// The expression derived from the source function
        /// </summary>
        public Expression<Func<X1, X2, X3, Y>> Fx {get;}
    }
}