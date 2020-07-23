//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Text;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly partial struct Dataset
    {
        [MethodImpl(Inline)]
        public static IDatasetFormatter<F> formatter<F>(char delimiter = FieldDelimiter)
            where F : unmanaged, Enum
                => new DatasetFormatter<F>(text.build(), delimiter);

        [MethodImpl(Inline)]
        public static IDatasetFormatter<F> formatter<F>(StringBuilder state, char delimiter = FieldDelimiter)
            where F : unmanaged, Enum
                => new DatasetFormatter<F>(state,delimiter);
    }
}