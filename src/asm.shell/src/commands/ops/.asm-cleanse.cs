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
        {
            var result = Outcome.Success;
            var tool = Toolspace.llc;
            var cmd = Cmd.cmdline(ToolWs().Script(tool, "cleanse").Format(PathSeparator.BS));
            var src = Files(FS.S).View;
            var count = src.Length;
            var outdir = ToolOutDir(tool);
            for(var i=0; i<count; i++)
            {
                ref readonly var path = ref skip(src,i);
                var vars = PathVars.create();
                vars.DstDir = outdir;
                vars.SrcDir = path.FolderPath;
                vars.SrcFile = path.FileName;
                result = ScriptRunner.RunCmd(cmd, vars.ToCmdVars(), out _);
                if(result.Fail)
                    break;
            }

            return result;
        }

        // J:\source\llvm\llvm-project\llvm\test\MC\X86
    }
}