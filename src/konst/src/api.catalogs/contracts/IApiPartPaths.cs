//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IApiPartPaths : IPartFilePaths
    {
        FS.FolderPath HexDir()
            => HexDir(Root);

        FS.FilePath HexPath(FS.FileName name)
            => HexFilePath(Root, name);

        FS.FilePath HexPath(ApiHostUri host)
            => HexFilePath(Root, host);

        FS.FilePath AsmPath(FS.FileName name)
            => FS.path(AsmFilePath(Root, name).Name);
    }
}