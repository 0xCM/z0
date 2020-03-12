//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Security;

    using static Root;
    
    /// <summary>
    /// Defines api surface for creating surrogate operator delegates
    /// </summary>
    public static class FunctionSurrogates
    {
        /// <summary>
        /// Captures a delegate and presents it as a unary operator
        /// </summary>
        /// <param name="f">The delegate to capture</param>
        /// <param name="name">The operator name</param>
        /// <param name="t">A point representative</param>
        /// <typeparam name="T">The delegate domain/codomain type</typeparam>
        [MethodImpl(Inline)]
        public static UnaryOpSurrogate<T> unary<T>(Func<T,T> f, string name, T t = default)
            => new UnaryOpSurrogate<T>(f, name);

        /// <summary>
        /// Captures a delegate and presents it as a binary operator
        /// </summary>
        /// <param name="f">The delegate to capture</param>
        /// <param name="name">The operator name</param>
        /// <param name="t">A point representative</param>
        /// <typeparam name="T">The delegate domain/codomain type</typeparam>
        [MethodImpl(Inline)]
        public static BinaryOpSurrogate<T> binary<T>(Func<T,T,T> f, string name, T t = default)
            => new BinaryOpSurrogate<T>(f,name);

        /// <summary>
        /// Captures a delegate and presents it as a ternary operator
        /// </summary>
        /// <param name="f">The delegate to capture</param>
        /// <param name="name">The operator name</param>
        /// <param name="t">A point representative</param>
        /// <typeparam name="T">The delegate domain/codomain type</typeparam>
        [MethodImpl(Inline)]
        public static TernaryOpSurrogate<T> ternary<T>(Func<T,T,T,T> f, string name, T t = default)
            => new TernaryOpSurrogate<T>(f, name);
            
        /// <summary>
        /// Captures a delegate and presents it as a binary predicate
        /// </summary>
        /// <param name="f">The delegate to capture</param>
        /// <param name="name">The operator name</param>
        /// <param name="t">A point representative</param>
        /// <typeparam name="T">The delegate domain type</typeparam>
        [MethodImpl(Inline)]
        public static BinaryPredSurrogate<T> predicate<T>(Func<T,T,bit> f, string name, T t = default)
            => new BinaryPredSurrogate<T>(f,name);

        /// <summary>
        /// Captures a delegate and presents it as a binary operator
        /// </summary>
        /// <param name="f">The delegate to capture</param>
        /// <param name="name">The operator name</param>
        /// <param name="t">A point representative</param>
        /// <typeparam name="T">The delegate domain/codomain type</typeparam>
        [MethodImpl(Inline)]
        public static BinaryOpSurrogate2<T> binary2<T>(BinaryOp<T> f, string name, T t = default)
            => new BinaryOpSurrogate2<T>(f,name);

        /// <summary>
        /// Captures a delegate and presents it as a unary predicate
        /// </summary>
        /// <param name="f">The delegate to capture</param>
        /// <param name="name">The operator name</param>
        /// <param name="t">A point representative</param>
        /// <typeparam name="T">The delegate domain type</typeparam>
        [MethodImpl(Inline)]
        public static UnaryPredicateSurrogate<T> predicate<T>(UnaryPredicate<T> f, string name, T t = default)
            => new UnaryPredicateSurrogate<T>(f,name);

        /// <summary>
        /// Captures a delegate and presents it as a binary predicate
        /// </summary>
        /// <param name="f">The delegate to capture</param>
        /// <param name="name">The operator name</param>
        /// <param name="t">A point representative</param>
        /// <typeparam name="T">The delegate domain type</typeparam>
        [MethodImpl(Inline)]
        public static EmitterSurrogate<T> emitter<T>(Emitter<T> f, string name, T t = default)
            => new EmitterSurrogate<T>(f,name);    
    }
}