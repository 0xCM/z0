//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct Symbolic
    {
        [MethodImpl(Inline)]
        public static Symbol<S> symbol<S>(S value)
            where S : unmanaged
                => new Symbol<S>(value);

        [MethodImpl(Inline)]
        public static Symbol<S,T> symbol<S,T>(S value, T t = default)
            where S : unmanaged
            where T : unmanaged
                => new Symbol<S,T>(value);

        /// <summary>
        /// Defines an <typeparamref name='S'/>-valued symbol of representation bit-width <typeparamref name='N'/>  covered by a <see cref='T'/> storage cell
        /// </summary>
        /// <param name="value">The symbol value</param>
        /// <param name="t">A storage cell represetnative</param>
        /// <param name="n">A bitwith value representative</param>
        /// <typeparam name="S">The symbol type</typeparam>
        /// <typeparam name="T">The storage type</typeparam>
        /// <typeparam name="N">The symbol representation bit-width</typeparam>
        [MethodImpl(Inline)]
        public static Symbol<S,T,N> symbol<S,T,N>(S value, T t = default, N n = default)
            where S : unmanaged
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => new Symbol<S,T,N>(value);
    }
}