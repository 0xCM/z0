//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Sources
    {
        [MethodImpl(Inline)]
        public static CellEmitter<F> cells<F>(ISource src)
            where F : struct, IDataCell
                => new CellEmitter<F>(src);

        [MethodImpl(Inline), Op]
        public static CellEmitters cells(ISource src)
            => new CellEmitters(src);
    }
}