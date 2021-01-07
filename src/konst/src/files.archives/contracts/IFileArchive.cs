//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    using static z;

    /// <summary>
    /// Characterizes a file system repository
    /// </summary>
    [Free]
    public interface IFileArchive : IFileExtensions
    {
        FS.FolderPath Root {get;}

        ParseResult<TextDoc> Document(FS.FilePath src)
            => TextDocParser.parse(src);

        FS.Files Clear(FS.FolderName id)
            => (Root + id).Clear(list<FS.FilePath>()).Array();

        Deferred<FS.FilePath> ArchiveFiles()
            => Root.EnumerateFiles(true);

        Deferred<FS.FilePath> ArchivFiles(FS.FileExt ext)
            => ArchiveFiles().Where(f => f.Is(ext));

        FS.Files Clear(string id)
            => Clear(FS.folder(id));

        Deferred<FS.FilePath> ArchiveFiles(FS.FileExt[] ext, bool recurse)
            => Root.EnumerateFiles(ext, recurse);

        Deferred<FS.FilePath> ArchiveFiles(string pattern, bool recurse)
            => Root.EnumerateFiles(pattern, recurse);

        ListedFiles List()
            => FS.list(ArchiveFiles().Array());
    }
}