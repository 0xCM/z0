//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    public interface IStreamProvider<T>
    {
        /// <summary>
        /// In infinite T-stream
        /// </summary>
        IEnumerable<T> Stream {get;}   
    }
}