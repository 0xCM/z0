//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IDbPaths
    {
        FS.FolderPath DbRoot
            => FS.dir(@"j:\database");

        FS.FolderPath TableRoot()
            => DbRoot + FS.folder("tables");

        FS.FolderPath DocRoot()
            => DbRoot + FS.folder("docs");

        FS.FolderPath StageRoot()
            => DbRoot + FS.folder("stage");

        FS.FolderPath SourceRoot()
            => DbRoot + FS.folder("sources");

        FS.FilePath Doc(string name, FS.FileExt ext)
            => DocRoot() + FS.file(name, ext);
    }
}