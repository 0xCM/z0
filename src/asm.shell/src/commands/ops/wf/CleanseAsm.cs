//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
     using static core;

    partial class AsmCmdService
    {
        Outcome CleanseAsm()
        {
            var result = Outcome.Success;
            var tool = Toolspace.llvm_mc;
            var cmd = Cmd.cmdline(ToolWs().Script(tool, "cleanse").Format(PathSeparator.BS));
            var src = Files(FS.S).View;
            var count = src.Length;
            var outdir = ToolOutDir(tool);
            for(var i=0; i<count; i++)
            {
                ref readonly var path = ref skip(src,i);
                var vars = WsVars.create();
                vars.DstDir = outdir;
                vars.SrcDir = path.FolderPath;
                vars.SrcFile = path.FileName;
                vars.SrcId = path.FileName.WithoutExtension.Format();
                result = ScriptRunner.RunCmd(cmd, vars.ToCmdVars(), out _);
                if(result.Fail)
                    break;
            }

            return result;
        }
    }
}