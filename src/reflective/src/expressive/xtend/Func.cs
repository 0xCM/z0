//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Control;

    partial class XTend
    {
        /// <summary>
        /// Creates a delegate for an emitter
        /// </summary>
        /// <param name="host">The declaring type instance, if applicable</param>
        /// <typeparam name="X">The result type</typeparam>
        public static Func<X> Func<X>(this MethodInfo method, object host = null)
            => XPress.func<X>(method, host).Require();

        /// <summary>
        /// Creates a delegate for a function f:X->Y realized by a specified method
        /// </summary>
        /// <typeparam name="X1">The type of the first parameter</typeparam>
        /// <typeparam name="X2">The type of the second parameter</typeparam>
        /// <typeparam name="Y">The result type</typeparam>
        /// <param name="member">The source method</param>
        /// <param name="host">An instance of the declaring type, if applicable</param>
        public static Func<X,Y> Func<X,Y>(this MethodInfo method, object host = null)
            => XPress.func<X,Y>(method, host).Require();

        /// <summary>
        /// Creates a delegate for a function f:X1->X2->Y realized by a specified method
        /// </summary>
        /// <typeparam name="X1">The type of the first parameter</typeparam>
        /// <typeparam name="X2">The type of the second parameter</typeparam>
        /// <typeparam name="Y">The result type</typeparam>
        /// <param name="member">The source method</param>
        /// <param name="host">An instance of the declaring type, if applicable</param>
        public static Func<X1,X2,Y> Func<X1,X2,Y>(this MethodInfo method, object host = null)
            => XPress.func<X1,X2,Y>(method, host).Require();

        /// <summary>
        /// Creates a delegate for a binary operator f:X->X->X realized by a specified method
        /// </summary>
        /// <param name="member">The source method</param>
        /// <param name="host">An instance of the declaring type, if applicable</param>
        /// <typeparam name="X">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BinaryOp<X> BinaryOp<X>(this MethodInfo method, object host = null)
            => method.Func<X,X,X>(host).ToBinaryOp();

        /// <summary>
        /// Creates a delegate for a function f:X1->X2->X3->Y realized by a specified method
        /// </summary>
        /// <typeparam name="X1">The type of the first parameter</typeparam>
        /// <typeparam name="X2">The type of the second parameter</typeparam>
        /// <typeparam name="X3">Tye type of the third parameter</typeparam>
        /// <typeparam name="Y">The result type</typeparam>
        /// <param name="member">The source method</param>
        /// <param name="host">An instance of the declaring type, if applicable</param>
        public static Func<X1,X2,X3,Y> Func<X1,X2,X3,Y>(this MethodInfo method, object host = null)
            => XPress.func<X1,X2,X3,Y>(method, host);

        /// <summary>
        /// Creates a delegate for a function f:X1->X2->X3->X4->Y realized by a specified method
        /// </summary>
        /// <typeparam name="X1">The type of the first parameter</typeparam>
        /// <typeparam name="X2">The type of the second parameter</typeparam>
        /// <typeparam name="X3">Tye type of the third parameter</typeparam>
        /// <typeparam name="X4">Tye type of the fourth parameter</typeparam>
        /// <typeparam name="Y">The result type</typeparam>
        /// <param name="member">The source method</param>
        /// <param name="host">An instance of the declaring type, if applicable</param>
        public static Func<X1,X2,X3,X4,Y> Func<X1,X2,X3,X4,Y>(this MethodInfo method, object host = null)
            => XPress.func<X1,X2,X3,X4,Y>(method, host);
    }
}