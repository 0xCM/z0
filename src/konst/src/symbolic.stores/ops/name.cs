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
        public static Identifier name<S>(ISymbol<S> src)
            where S : unmanaged
                => src.Value is Enum e ? e.ToString("g") : src.Value.ToString();

        /// <summary>
        /// Looks-up the name of an index-identified symbol
        /// </summary>
        /// <param name="src">The symbol's container</param>
        /// <param name="index">The symbol index</param>
        /// <typeparam name="S">The symbol type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static SymbolName<S> name<S>(ISymbolSet<S> src, ushort index)
            where S : unmanaged
                => new SymbolName<S>(src,index);

        /// <summary>
        /// Looks-up the name of an index-identified symbol
        /// </summary>
        /// <param name="src">The symbol's container</param>
        /// <param name="index">The symbol index</param>
        [MethodImpl(Inline), Op]
        public static SymbolName name(ISymbolSet src, ushort index)
            => new SymbolName(src,index);
    }
}