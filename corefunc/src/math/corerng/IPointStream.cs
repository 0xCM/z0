//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace System
{
    using System.Collections.Generic;
    using Z0;

    public interface IPointStream<T> : IPointSource<T>
        where T : struct
    {
        IEnumerable<T> Stream {get;}
    }
}