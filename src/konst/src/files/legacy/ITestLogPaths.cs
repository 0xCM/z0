//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface ITestLogPaths : IPartFolderPaths, IPartFileExtensions
    {
        FolderPath TestRootPath(FolderPath root)
            => root + TestFolder;

        FilePath TestMessages(FolderPath root,  PartId id)
            => TestRootPath(root) + FileName.define(id.Format(), StatusLog);

        FilePath TestErrors(FolderPath root,  PartId id)
            => TestRootPath(root) + FileName.define(id.Format(), ErrorLog);
    }
}