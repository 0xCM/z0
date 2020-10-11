//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IDbPaths
    {
        FS.FolderPath DbRoot {get;}

        FS.FolderPath TableRoot();

        FS.FolderPath DocRoot();

        FS.FolderPath StageRoot();

        FS.FolderPath SourceRoot();

        FS.FilePath Doc(string name, FS.FileExt ext);
    }
}