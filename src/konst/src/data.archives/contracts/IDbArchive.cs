//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using api = Archives;

    public interface IDbArchive : IFileArchive
    {
        FS.FolderPath DbRoot
            => api.dbRoot(Root);

        FS.FilePath[] Clear(FS.FolderName id)
            => (DbRoot + id).Clear(z.list<FS.FilePath>()).ToArray();

        FS.FilePath[] Clear(string id)
            => (DbRoot + FS.folder(id)).Clear(z.list<FS.FilePath>()).ToArray();

        FS.FolderPath IndexRoot
            => api.IndexRoot(Root);

        FS.FolderPath TableRoot(string id)
            => DbRoot + FS.folder(id);

        FS.FilePath Table(string id, string name, string type = null)
            => api.table(Root, id, name, type);

        FS.FilePath Table(string id, PartId part, string type = null)
            => api.table(Root, id, part, type);

        FS.FilePath Table(FS.FileName file)
            => api.table(Root, file);
    }

    public interface IDbArchive<H> : IDbArchive, IFileArchive<H>
        where H : IDbArchive<H>
    {

    }
}