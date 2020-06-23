//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct asci
    {
        /// <summary>
        /// Defines a symbol spec
        /// </summary>
        /// <param name="symbols"></param>
        /// <typeparam name="S">The symbol data type</typeparam>
        /// <typeparam name="T">The symbol domain type</typeparam>
        /// <typeparam name="N">The symbol bit-width type</typeparam>
        [MethodImpl(Inline)]
        static SymbolSpec<S,T,N> spec<S,T,N>(params S[] symbols)
            where S : unmanaged
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => new SymbolSpec<S,T,N>(symbols);
    }
}