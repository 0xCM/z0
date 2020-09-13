//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static GlobalFolderNames;
    using FN = GlobalFolderNames;

    public interface IPartResPaths : IShellPaths
    {
        /// <summary>
        /// The path to the root application resource directory
        /// </summary>
        FolderPath ResRoot
            => LogRoot + FolderName.Define(RespackContent);

        FolderPath ResTables
            => ResRoot + FolderName.Define(TableFolder);

        FolderPath ResIndex
            => ResRoot + FolderName.Define(IndexFolder);

        FolderPath AsmResTables
            => ResTables + FolderName.Define(FN.AsmFolder);
    }
}