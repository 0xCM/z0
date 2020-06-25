//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public interface TFieldRender<F>
        where F : unmanaged, Enum
    {
        IDatasetFormatter<F> Formatter 
            => Dataset.formatter<F>();

        DatasetHeader<F> Header
                => Dataset.header<F>();
    }
}