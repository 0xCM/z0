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
        /// <summary>
        /// Defines a <see cref='NamedSymbol{S}'/> sequence
        /// </summary>
        /// <param name="src">The source symbols</param>
        /// <typeparam name="S">The symbol type</typeparam>
        [MethodImpl(Inline)]
        public static NamedSymbols<S> names<S>(params NamedSymbol<S>[] src)
            where S : unmanaged, ISymbol<S>
                => new NamedSymbols<S>(src);
    }
}