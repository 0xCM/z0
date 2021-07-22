//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static core;

    partial class AsmCmdService
    {
        [CmdOp(".outdir-list")]
        Outcome DstDirList(CmdArgs args)
        {
            List(State.OutDir());
            return true;
        }

        void List(FS.FolderPath src)
        {
            var files = FileArchives.list(src);
            iter(files.View, file => Write(file.Path));

            var dst = State.OutDir() + FS.file(string.Format("{0}.list", src.FolderName), FS.Csv);
            Z0.Tables.emit(files.View, dst);
        }
    }
}