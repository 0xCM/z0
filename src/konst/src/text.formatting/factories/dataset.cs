//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Formatters
    {
        [MethodImpl(Inline)]
        public static DatasetFormatter<F> dataset<F>(char delimiter)
            where F : unmanaged, Enum
                => new DatasetFormatter<F>(text.build(), delimiter);
    }
}