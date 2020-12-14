//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free =System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IDbPaths : IArchivePaths
    {
        /// <summary>
        /// The workflow's database root
        /// </summary>
        FS.FolderPath DbRoot
            => Root;
    }
}