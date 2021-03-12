//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct SymbolStores
    {
        /// <summary>
        /// Creates a symbol from an unmanaged value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="S">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Symbol<S> symbol<S>(S src)
            where S : unmanaged
                => new Symbol<S>(src);

        /// <summary>
        /// Creates a symbol from an unmanaged value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The storage type</typeparam>
        [MethodImpl(Inline)]
        public static Symbol<S,T> symbol<S,T>(S src)
            where S : unmanaged
            where T : unmanaged
                => new Symbol<S,T>(src);

        /// <summary>
        /// Defines an <typeparamref name='S'/>-valued symbol of representation bit-width <typeparamref name='N'/>  covered by a <see cref='T'/> storage cell
        /// </summary>
        /// <param name="value">The symbol value</param>
        /// <typeparam name="S">The symbol type</typeparam>
        /// <typeparam name="T">The storage type</typeparam>
        /// <typeparam name="N">The symbol representation bit-width</typeparam>
        [MethodImpl(Inline)]
        public static Symbol<S,T,N> symbol<S,T,N>(S value)
            where S : unmanaged
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => new Symbol<S,T,N>(value);
    }
}