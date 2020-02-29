//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Linq;

    public interface ISpanSource<T> : IDataSource
    {
        new Span<T> Data {get;}   

        IEnumerable<object> IDataSource.Data
            => Data.ToArray().Cast<object>();
    }
}