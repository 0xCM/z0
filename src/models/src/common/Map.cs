//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;

    partial class XTend
    {
        /// <summary>
        /// Creates a delegate for a binary operator f:X->X->X realized by a specified method
        /// </summary>
        /// <param name="member">The source method</param>
        /// <param name="host">An instance of the declaring type, if applicable</param>
        /// <typeparam name="X">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BinaryOp<X> BinaryOp<X>(this MethodInfo method, object host = null)
            => method.Func<X,X,X>(host).ToBinaryOp();


        [MethodImpl(Inline)]    
        public static T Map<S,T>(this S src, Func<S,T> f, T @default = default)
            where S : INullaryKnown
            where T : new()
                => src.IsNonEmpty ? f(src) : @default ?? new T();        
        
        [MethodImpl(Inline)]    
        public static T Map<S,T>(this S src, Func<S,T> f)
            where S : INullaryKnown
            where T : INullary<T>, new()
                => src.IsNonEmpty ? f(src) : new T().Zero;
    }
}