//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static Root;

    public struct PathVars
    {
        public static PathVars create()
            => new PathVars();

        public FS.FolderPath SrcDir;

        public FS.FileName SrcFile;

        public FS.FolderPath DstDir;

        public CmdVars ToCmdVars()
            => Cmd.vars(
            (nameof(SrcDir), SrcDir.IsNonEmpty ? SrcDir.Format(PathSeparator.BS) : EmptyString),
            (nameof(SrcFile), SrcFile.IsNonEmpty ? SrcFile.Format() : EmptyString),
            (nameof(DstDir), DstDir.IsNonEmpty ? DstDir.Format(PathSeparator.BS) : EmptyString)
            );
    }
}