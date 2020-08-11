//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;

    using static FileSystem;

    public interface IFileSystemObject
    {
        PathPart Name {get;}    
    }

    public interface IFileSystemObject<F> : IFileSystemObject
        where F : struct, IFileSystemObject<F>
    {
        
    }

}