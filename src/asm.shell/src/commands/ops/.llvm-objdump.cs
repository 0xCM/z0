//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static Root;
    using static core;

    partial class AsmCmdService
    {
        [CmdOp(".llvm-objdump")]
        Outcome LlvmObjDump(CmdArgs args)
        {
            var result = Outcome.Success;
            var src = Files(FS.Obj).View;
            var count = src.Length;
            var tool = Toolspace.llvm_objdump;
            var outdir = ToolOutDir(tool);
            var cmd = Cmd.cmdline(ToolWs().Script(tool, "run").Format(PathSeparator.BS));

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
    }
}