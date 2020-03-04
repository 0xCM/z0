//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Characterizes a function that receives/emits an object without modification
    /// </summary>
    /// <param name="src">The source object</param>
    /// <typeparam name="T">The object type</typeparam>
    public delegate ref readonly T ObjectRelay<T>(in T src)
        where T : class;

}