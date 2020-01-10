//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using System.Security;

    using static zfunc;

    using S = DelegateSurrogates;

    /// <summary>
    /// Defines api surface for creating surrogate operator (D)elegates
    /// </summary>
    public static class SurrogateD
    {
        /// <summary>
        /// Captures a delegate and presents it as a unary operator
        /// </summary>
        /// <param name="f">The delegate to capture</param>
        /// <param name="name">The operator name</param>
        /// <param name="t">A point representative</param>
        /// <typeparam name="T">The delegate domain/codomain type</typeparam>
        [MethodImpl(Inline)]
        public static S.UnaryOpSurrogate<T> unary<T>(Func<T,T> f, string name, T t = default)
            => new S.UnaryOpSurrogate<T>(f, name);

        /// <summary>
        /// Captures a delegate and presents it as a binary operator
        /// </summary>
        /// <param name="f">The delegate to capture</param>
        /// <param name="name">The operator name</param>
        /// <param name="t">A point representative</param>
        /// <typeparam name="T">The delegate domain/codomain type</typeparam>
        [MethodImpl(Inline)]
        public static S.BinaryOpSurrogate<T> binary<T>(Func<T,T,T> f, string name, T t = default)
            => new S.BinaryOpSurrogate<T>(f,name);

        /// <summary>
        /// Captures a delegate and presents it as a ternary operator
        /// </summary>
        /// <param name="f">The delegate to capture</param>
        /// <param name="name">The operator name</param>
        /// <param name="t">A point representative</param>
        /// <typeparam name="T">The delegate domain/codomain type</typeparam>
        [MethodImpl(Inline)]
        public static S.TernaryOpSurrogate<T> ternary<T>(Func<T,T,T,T> f, string name, T t = default)
            => new S.TernaryOpSurrogate<T>(f, name);

        /// <summary>
        /// Captures a delegate and presents it as a unary predicate
        /// </summary>
        /// <param name="f">The delegate to capture</param>
        /// <param name="name">The operator name</param>
        /// <param name="t">A point representative</param>
        /// <typeparam name="T">The delegate domain type</typeparam>
        [MethodImpl(Inline)]
        public static S.UnaryPredSurrogate<T> predicate<T>(Func<T,bit> f, string name, T t = default)
            => new S.UnaryPredSurrogate<T>(f,name);
            
        /// <summary>
        /// Captures a delegate and presents it as a binary predicate
        /// </summary>
        /// <param name="f">The delegate to capture</param>
        /// <param name="name">The operator name</param>
        /// <param name="t">A point representative</param>
        /// <typeparam name="T">The delegate domain type</typeparam>
        [MethodImpl(Inline)]
        public static S.BinaryPredSurrogate<T> predicate<T>(Func<T,T,bit> f, string name, T t = default)
            => new S.BinaryPredSurrogate<T>(f,name);
        
        /// <summary>
        /// Captures a delegate and presents it as a binary predicate
        /// </summary>
        /// <param name="f">The delegate to capture</param>
        /// <param name="name">The operator name</param>
        /// <param name="t">A point representative</param>
        /// <typeparam name="T">The delegate domain type</typeparam>
        [MethodImpl(Inline)]
        public static S.EmitterSurrogate<T> emitter<T>(Func<T> f, string name, T t = default)
            => new S.EmitterSurrogate<T>(f,name);        
    }

    public static partial class DelegateSurrogates
    {


    }
}