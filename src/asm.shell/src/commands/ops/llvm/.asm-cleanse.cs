//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
     using static core;

    partial class AsmCmdService
    {
        [CmdOp(".asm-cleanse")]
        Outcome AsmCleanse(CmdArgs args)
            => CleanseAsm();

        Outcome CleanseAsm()
        {
            var result = Outcome.Success;
            var cmd = Cmd.cmdline(Ws.Tools().Script(LlvmToolNames.llvm_mc, "cleanse").Format(PathSeparator.BS));
            var src = State.Files(FS.S).View;
            var count = src.Length;
            var outdir = (Ws.Projects().OutDir(State.Project()) + FS.folder("cleansed")).Create();

            for(var i=0; i<count; i++)
            {
                ref readonly var path = ref skip(src,i);
                var vars = WsVars.create();
                vars.DstDir = outdir;
                vars.SrcDir = path.FolderPath;
                vars.SrcFile = path.FileName;
                vars.SrcId = path.FileName.WithoutExtension.Format();
                result = OmniScript.Run(cmd,vars.ToCmdVars(), out _);
                if(result.Fail)
                    break;
            }

            return result;
        }
    }
}