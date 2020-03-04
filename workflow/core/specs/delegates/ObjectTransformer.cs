//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Characterizes a function that produces T-objects from S-objects
    /// </summary>
    /// <param name="src">The source object</param>
    /// <typeparam name="S">The source type</typeparam>
    /// <typeparam name="T">The target type</typeparam>
    public delegate T ObjectTransformer<S,T>(in S src)
        where S : class        
        where T : class;

}