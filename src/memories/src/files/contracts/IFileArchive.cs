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
    public interface IFileArchive
    {
        /// <summary>
        /// The directory to which path calculations are relative
        /// </summary>
        FolderPath ArchiveRoot {get;}

        /// <summary>
        /// Enumerates the archived files
        /// </summary>
        IEnumerable<FilePath> Files();

        /// <summary>
        /// Enumerates the archived files owned by a specified part
        /// </summary>
        IEnumerable<FilePath> Files(PartId part);
    }
}