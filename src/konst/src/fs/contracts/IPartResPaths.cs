//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static FS.FolderNames;
    using FN = FS.FolderNames;

    public interface IPartResPaths : IShellPaths
    {
        /// <summary>
        /// The path to the root application resource directory
        /// </summary>
        FolderPath ResRoot
            => LogRoot + FolderName.Define(RespackContent);

        FolderPath ResTables
            => ResRoot + FolderName.Define(Tables);

        FolderPath ResIndex
            => ResRoot + FolderName.Define(Index);

        FolderPath AsmResTables
            => ResTables + FolderName.Define(FN.Asm);
    }
}