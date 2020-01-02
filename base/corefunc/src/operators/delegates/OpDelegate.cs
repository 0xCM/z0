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
    using static OpDelegates;

    /// <summary>
    /// Defines operations that present delegates as operators
    /// </summary>
    public static class OpDelegate
    {
        /// <summary>
        /// Captures a delegate and presents it as a unary operator
        /// </summary>
        /// <param name="f">The delegate to capture</param>
        /// <param name="name">The operator name</param>
        /// <param name="t">A point representative</param>
        /// <typeparam name="T">The delegate domain/codomain type</typeparam>
        [MethodImpl(Inline)]
        public static UnaryDelegate<T> unary<T>(Func<T,T> f, string name, T t = default)
            => new UnaryDelegate<T>(f,name);

        /// <summary>
        /// Captures a delegate and presents it as a binary operator
        /// </summary>
        /// <param name="f">The delegate to capture</param>
        /// <param name="name">The operator name</param>
        /// <param name="t">A point representative</param>
        /// <typeparam name="T">The delegate domain/codomain type</typeparam>
        [MethodImpl(Inline)]
        public static BinaryDelegate<T> binary<T>(Func<T,T,T> f, string name, T t = default)
            => new BinaryDelegate<T>(f,name);

        /// <summary>
        /// Captures a delegate and presents it as a ternary operator
        /// </summary>
        /// <param name="f">The delegate to capture</param>
        /// <param name="name">The operator name</param>
        /// <param name="t">A point representative</param>
        /// <typeparam name="T">The delegate domain/codomain type</typeparam>
        [MethodImpl(Inline)]
        public static TernaryDelegate<T> ternary<T>(Func<T,T,T,T> f, string name, T t = default)
            => new TernaryDelegate<T>(f,name);

        /// <summary>
        /// Captures a delegate and presents it as a unary predicate
        /// </summary>
        /// <param name="f">The delegate to capture</param>
        /// <param name="name">The operator name</param>
        /// <param name="t">A point representative</param>
        /// <typeparam name="T">The delegate domain type</typeparam>
        [MethodImpl(Inline)]
        public static UnaryPred<T> predicate<T>(Func<T,bit> f, string name, T t = default)
            => new UnaryPred<T>(f,name);
            
        /// <summary>
        /// Captures a delegate and presents it as a binary predicate
        /// </summary>
        /// <param name="f">The delegate to capture</param>
        /// <param name="name">The operator name</param>
        /// <param name="t">A point representative</param>
        /// <typeparam name="T">The delegate domain type</typeparam>
        [MethodImpl(Inline)]
        public static BinaryPred<T> predicate<T>(Func<T,T,bit> f, string name, T t = default)
            => new BinaryPred<T>(f,name);
    }

    /// <summary>
    /// Defines the canonical shape of a unary operator over an unmanaged type
    /// </summary>
    /// <param name="a">The operand</param>
    /// <typeparam name="T">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public delegate T UnaryOp<T>(T a)
        where T : unmanaged;

    /// <summary>
    /// Defines the canonical shape of a binary operator over an unmanaged type
    /// </summary>
    /// <param name="a">The left operand</param>
    /// <param name="b">The right operand</param>
    /// <typeparam name="T">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public delegate T BinaryOp<T>(T a, T b)
        where T : unmanaged;

    /// <summary>
    /// Defines the canonical shape of a tenary operator over an unmanaged type
    /// </summary>
    /// <param name="a">The first operand</param>
    /// <param name="b">The second operand</param>
    /// <param name="c">The third operand</param>
    /// <typeparam name="T">The operand type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public delegate T TernaryOp<T>(T a, T b, T c)
        where T : unmanaged;

    public static partial class OpDelegates
    {


    }
}