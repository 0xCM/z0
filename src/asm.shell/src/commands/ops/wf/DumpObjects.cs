//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static core;

    partial class AsmCmdService
    {
        Outcome DumpObjects()
        {
            var result = Outcome.Success;
            var src = Files(FS.Obj, FS.Exe, FS.Lib, FS.Dll).View;
            var count = src.Length;
            var tool = Toolspace.llvm_objdump;
            var outdir = ToolOutDir(tool);
            var svc = Wf.LlvmObjDump();
            return svc.DumpObjects(src,outdir, response => Write(response));
        }

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

        Outcome LlvmMcDisasm(FS.FilePath src, FS.FolderPath dst)
        {
            var script = LlvmMc.Scripts.Disasm(src.FolderPath, src.FileName, dst);
            var result = Run(script, out var response);
            if(result)
                ParseCmdResponse(response);
            return result;
        }

        Outcome LlvmMcAssemble(FS.FilePath src, FS.FolderPath dst)
        {
            var script = LlvmMc.Scripts.Assemble(src.FolderPath, src.FileName, dst);
            var result = Run(script, out var response);
            if(result)
                ParseCmdResponse(response);
            return result;
        }

        Outcome DumpObjects(FS.FilePath src, FS.FolderPath dst)
        {
            var script = DumpBin.Scripts.DumpObj(src.FolderPath, src.FileName, dst);
            var result = Run(script, out var response);
            if(result)
                ParseCmdResponse(response);
            return result;
        }
    }
}