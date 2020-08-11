//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;

    using static FileSystem;

    public interface IFso
    {
        PathPart Name {get;}    
    }

    public interface IFso<F> : IFso
        where F : struct, IFso<F>
    {
        
    }
}