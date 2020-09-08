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
        /// Assigns a name to a symbol
        /// </summary>
        /// <param name="symbol">The target symbol</param>
        /// <param name="name">The name to assign</param>
        /// <typeparam name="S">The symbol type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static NamedSymbol<S> name<S>(S symbol, string name)
            where S : unmanaged
                => new NamedSymbol<S>(symbol, name);
    }
}