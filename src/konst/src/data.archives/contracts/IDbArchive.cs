//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using api = Archives;

    public interface IDbArchive : IFileArchive
    {
        FS.FolderPath TableRoot
            => api.TableRoot(Root);

        FS.FilePath[] Clear(FS.FolderName schema)
            => (TableRoot + schema).Clear(z.list<FS.FilePath>()).ToArray();

        FS.FolderPath IndexRoot
            => api.IndexRoot(Root);

        FS.FilePath Table(string id, string name, string type = null)
            => api.table(Root, id, name, type);

        FS.FilePath Table(FS.FileName file)
            => api.table(Root, file);
    }

    public interface IDbArchive<H> : IDbArchive, IFileArchive<H>
        where H : IDbArchive<H>
    {

    }
}