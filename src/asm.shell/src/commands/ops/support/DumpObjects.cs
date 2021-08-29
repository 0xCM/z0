//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".dump-objects")]
        Outcome DumpObjects(CmdArgs args)
        {
            var result = Outcome.Success;
            var src = State.Files(FS.Obj, FS.Exe, FS.Lib, FS.Dll).View;
            var count = src.Length;
            var tool = Toolspace.llvm_objdump;
            var outdir = GetToolOut(tool);
            var svc = Wf.LlvmObjDump();
            return svc.DumpObjects(src,outdir, response => Write(response));
        }

        Outcome LlvmObjDump(FS.FilePath src, FS.FolderPath dst)
        {
            var tool = Toolspace.llvm_objdump;
            var cmd = Cmd.cmdline(Ws.Tools().Script(tool, "run").Format(PathSeparator.BS));
            var vars = WsVars.create();
            vars.DstDir = dst;
            vars.SrcDir = src.FolderPath;
            vars.SrcFile = src.FileName;
            var result = OmniScript.Run(cmd, vars.ToCmdVars(), out var response);
            if(result)
                ParseCmdResponse(response);
            return result;
        }
    }
}