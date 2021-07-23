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
        [CmdOp(".dump-obj")]
        Outcome DumpObj(CmdArgs args)
        {
            return DumpModules(args, FileModuleKind.Obj);
        }

        [CmdOp(".dump-exe")]
        Outcome DumpExe(CmdArgs args)
        {
            return DumpModules(args, FileModuleKind.Exe);
        }

        [CmdOp(".dump-dll")]
        Outcome DumpDll(CmdArgs args)
        {
            return DumpModules(args, FileModuleKind.Dll);
        }

        [CmdOp(".dump-lib")]
        Outcome DumpLib(CmdArgs args)
        {
            return DumpModules(args, FileModuleKind.Lib);
        }

        Outcome DumpModules(CmdArgs args, FileModuleKind kind)
        {
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
            var outdir = ToolOutDir(args, tool);
            var cmd = Cmd.cmdline(State.ToolBase().Script(tool, script).Format(PathSeparator.BS));
            var input = State.Files().View;
            var count = input.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var path = ref skip(input,i);
                var vars = Cmd.vars(
                    ("SrcDir", path.FolderPath.Format(PathSeparator.BS)),
                    ("SrcFile", path.FileName.Format()),
                    ("DstDir", outdir.Format(PathSeparator.BS))
                    );

                var response = ScriptRunner.RunCmd(cmd, vars);
            }
            return true;
        }
    }
}