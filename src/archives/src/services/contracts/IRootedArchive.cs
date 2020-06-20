//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
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