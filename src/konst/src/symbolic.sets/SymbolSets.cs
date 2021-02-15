//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [ApiHost]
    public readonly partial struct SymbolSets
    {
        [MethodImpl(Inline), Op]
        public static SymbolSet<AsciCharCode,byte,W8> define(params AsciCharCode[] src)
            => define<AsciCharCode,byte,W8>(src);

        /// <summary>
        /// Defines a symbol set
        /// </summary>
        /// <param name="symbols"></param>
        /// <typeparam name="S">The symbol data type</typeparam>
        /// <typeparam name="T">The symbol domain type</typeparam>
        /// <typeparam name="W">The symbol bit-width type</typeparam>
        [MethodImpl(Inline)]
        public static SymbolSet<S,T,W> define<S,T,W>(params S[] symbols)
            where S : unmanaged
            where T : unmanaged
            where W : unmanaged, IDataWidth
                => new SymbolSet<S,T,W>(symbols);
    }
}