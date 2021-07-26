//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static WsNames;

    partial class AsmCmdService
    {
        [CmdOp(".outfiles", "Output Files -> State")]
        public Outcome OutFiles(CmdArgs args)
        {
            var project = State.Project();
            var dir = project.IsEmpty ? OutWs().Root : OutWs().Subdir(projects) + FS.folder(project.Format());
            Write(string.Format("Searching {0}", dir.Format()));
            if(args.Length == 0)
                Files(dir.Files(true));
            else
                Files(dir.Files(arg(args,0).Value,true));
            return true;
        }
    }
}