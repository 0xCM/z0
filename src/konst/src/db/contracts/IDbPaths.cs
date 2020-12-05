//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IDbPaths : IFileArchivePaths
    {
        /// <summary>
        /// The workflow's database root
        /// </summary>
        FS.FolderPath DbRoot
            => Root;
    }
}