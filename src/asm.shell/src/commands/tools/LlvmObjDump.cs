//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        Outcome LlvmObjDump(FS.FilePath src, FS.FolderPath dst)
        {
            var tool = Toolspace.llvm_objdump;
            var cmd = Cmd.cmdline(ToolWs().Script(tool, "run").Format(PathSeparator.BS));
            var vars = WsVars.create();
            vars.DstDir = dst;
            vars.SrcDir = src.FolderPath;
            vars.SrcFile = src.FileName;
            var result = Run(cmd, vars.ToCmdVars(), out var response);
            if(result)
                ParseCmdResponse(response);
            return result;
        }
    }
}