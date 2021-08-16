//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;
    using static WsAtoms;

    partial class AsmCmdService
    {
        Outcome DumpModules(CmdArgs args, FileModuleKind kind)
        {
            var result = Outcome.Success;
            var script = kind switch{
                FileModuleKind.Obj => "dump-obj",
                FileModuleKind.Exe => "dump-exe",
                FileModuleKind.Lib => "dump-lib",
                FileModuleKind.Dll => "dump-dll",
                _ => EmptyString
            };

            if(empty(script))
                return (false, string.Format("{0} not supported", kind));

            var tool = Toolspace.dumpbin;
            var project = State.Project();
            var rootdir = GetToolOut(args, tool);
            var outdir = GetProjectOut(dumps);
            var cmd = Cmd.cmdline(ToolWs().Script(tool, script).Format(PathSeparator.BS));
            var input = State.Files().View;
            var count = input.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var path = ref skip(input,i);

                var vars = WsVars.create();
                vars.DstDir = outdir;
                vars.SrcDir = path.FolderPath;
                vars.SrcFile = path.FileName;
                result = ScriptRunner.RunCmd(cmd, vars.ToCmdVars(), out _);
            }
            return result;
        }
    }
}