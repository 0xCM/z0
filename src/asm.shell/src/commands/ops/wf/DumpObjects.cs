//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static core;

    partial class AsmCmdService
    {
        Outcome DumpObjects()
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
                var vars = WsVars.create();
                vars.DstDir = outdir;
                vars.SrcDir = path.FolderPath;
                vars.SrcFile = path.FileName;
                result = Run(cmd, vars.ToCmdVars(), out var lines);
                if(result.Fail)
                    break;

                var len = lines.Length;
                for(var j=0; j<len; j++)
                {
                    if(CmdResponse.parse(skip(lines,j).Content, out var x))
                        Write(x);
                }
            }

            return result;
        }
    }
}