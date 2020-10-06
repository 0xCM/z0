//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    partial class Delegates
    {
        /// <summary>
        /// Creates an untyped delegate
        /// </summary>
        /// <param name="src">The target method</param>
        /// <param name="tDelegate">The delegate type</param>
        /// <param name="host">The host instance if not static</param>
        [MethodImpl(Inline), Op]
        public static Delegate from(MethodInfo src, Type tDelegate, object host)
            => Delegate.CreateDelegate(tDelegate, host, src);

        /// <summary>
        /// Creates an untyped delegate
        /// </summary>
        /// <param name="src">The target method</param>
        /// <param name="tDelegate">The delegate type</param>
        /// <param name="host">The host instance if not static</param>
        [MethodImpl(Inline), Op]
        public static Delegate from(MethodInfo src, Type tDelegate)
            => Delegate.CreateDelegate(tDelegate, null, src);

        /// <summary>
        /// Creates a generic delegate
        /// </summary>
        /// <param name="src">The target method</param>
        /// <typeparam name="D">The delegate type</typeparam>
        [MethodImpl(Inline)]
        public static D from<D>(MethodInfo src, object host)
            where D : Delegate
                => (D)Delegate.CreateDelegate(typeof(D), host, src);

        /// <summary>
        /// Creates a generic delegate
        /// </summary>
        /// <param name="src">The target method</param>
        /// <typeparam name="D">The delegate type</typeparam>
        [MethodImpl(Inline)]
        public static D from<D>(MethodInfo src)
            where D : Delegate
                => (D)Delegate.CreateDelegate(typeof(D), null, src);
    }
}