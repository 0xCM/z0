//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Asci
    {
        /// <summary>
        /// Defines a symbol spec
        /// </summary>
        /// <param name="symbols"></param>
        /// <typeparam name="S">The symbol data type</typeparam>
        /// <typeparam name="T">The symbol domain type</typeparam>
        /// <typeparam name="W">The symbol bit-width type</typeparam>
        [MethodImpl(Inline)]
        static SymbolSpec<S,T,W> spec<S,T,W>(params S[] symbols)
            where S : unmanaged
            where T : unmanaged
            where W : unmanaged, IDataWidth
                => new SymbolSpec<S,T,W>(symbols);
    }
}