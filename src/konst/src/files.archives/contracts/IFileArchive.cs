//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    /// <summary>
    /// Characterizes a file system repository
    /// </summary>
    [Free]
    public interface IFileArchive : IFileExtensions
    {
        FS.FolderPath Root {get;}

        ParseResult<TextDoc> Document(FS.FilePath src)
            => TextDocs.parse(src);

        Deferred<FS.FilePath> ArchiveFiles()
            => Root.EnumerateFiles(true);
    }
}