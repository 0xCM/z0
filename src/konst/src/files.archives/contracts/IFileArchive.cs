//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Collections.Generic;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    /// <summary>
    /// Characterizes a file system repository
    /// </summary>
    [Free]
    public interface IFileArchive : IFileArchivePaths
    {
        IEnumerable<FS.FilePath> Files(bool recurse, params FS.FileExt[] ext)
            => Root.EnumerateFiles(recurse, ext);

        IEnumerable<FS.FilePath> Files(string pattern, bool recurse)
            => Root.EnumerateFiles(pattern, recurse);

        ListedFiles List()
            => FS.list(Files().Array());

        IEnumerable<FS.FilePath> Files()
            => Root.EnumerateFiles(true);
    }

    /// <summary>
    /// Characterizes a kinded archive
    /// </summary>
    /// <typeparam name="K">The archive's classifying type</typeparam>
    [Free]
    public interface IFileArchive<K> : IFileArchive
        where K : unmanaged
    {
        /// <summary>
        /// Specifies the archive classifier
        /// </summary>
        K ArchiveKind {get;}
    }
}