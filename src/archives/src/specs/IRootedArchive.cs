//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Characterizes an archive rooted at a specified path
    /// </summary>
    public interface IRootedArchive : IService
    {
        /// <summary>
        /// The path to which path calculations are relative
        /// </summary>
        FolderPath ArchiveRoot {get;}
    }
}