//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using api = Archives;

    public interface IDatabaseArchive : IFileArchive
    {
        FS.FolderPath TableRoot
            => api.TableRoot(Root);

        FS.FolderPath IndexRoot
            => api.IndexRoot(Root);

        FS.FilePath Table(string schema, string name, FS.FileExt? ext = null)
            => api.table(Root, schema, name, ext);

        FS.FilePath Table(FS.FileName file)
            => api.table(Root, file);

    }

    public interface IDatbaseArchive<H> : IDatabaseArchive, IFileArchive<H>
        where H : IDatbaseArchive<H>
    {

    }
}