//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Accepts streams of arbitrary length
    /// </summary>
    /// <param name="src">The source content</param>
    /// <typeparam name="T">The stream element type</typeparam>
    public delegate void StreamReceiver<T>(IEnumerable<T> src);
}