//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public sealed class ScriptRunner
    {
        [MethodImpl(Inline)]
        public static ScriptRunner create(IEnvPaths paths)
            => new ScriptRunner(paths);

        readonly IEnvPaths Paths;

        [MethodImpl(Inline)]
        ScriptRunner(IEnvPaths paths)
            => Paths = paths;

        public Outcome<TextLines> RunControlScript(FS.FileName name)
            => RunScript(Paths.ControlScript(name), new ScriptId(name.Name));

        public Outcome<TextLines> RunToolCmd(ToolId tool, ScriptId script)
            => RunToolScript(tool, script, ToolScriptKind.Cmd);

        public FS.FilePath ToolCmdPath(ToolId tool, ScriptId script)
            => ScriptFile(tool,script,ToolScriptKind.Cmd);

        public Outcome<TextLines> RunToolPs(ToolId tool, ScriptId script)
            => RunToolScript(tool, script, ToolScriptKind.Ps);

        public Outcome<TextLines> RunToolScript(ToolId tool, ScriptId script, ToolScriptKind kind)
            => Run(CmdLine(ScriptFile(tool, script, kind), kind), script);

        public Outcome<TextLines> RunScript(FS.FilePath src)
        {
            using var writer = Paths.CmdLog(src.FileName.Format()).Writer();

            try
            {
                var cmd = WinCmd.script(src);
                var process = ToolCmd.run(cmd).Wait();
                var lines =  text.lines(process.Output);
                root.iter(lines, line => writer.WriteLine(line));
                return lines;
            }
            catch(Exception e)
            {
                term.error(e);
                writer.WriteLine(e.ToString());
                return e;
            }

        }

        Outcome<TextLines> Run(CmdLine cmd, ScriptId script)
        {
            using var writer = Paths.CmdLog(script).Writer();

            try
            {
                var process = ToolCmd.run(cmd).Wait();
                var lines =  text.lines(process.Output);
                root.iter(lines, line => writer.WriteLine(line));

                return lines;
            }
            catch(Exception e)
            {
                term.error(e);
                writer.WriteLine(e.ToString());
                return e;
            }
        }

        Outcome<TextLines> RunScript(FS.FilePath src, ScriptId script)
            => Run(new CmdLine(src.Format(PathSeparator.BS)), script);

        FS.FilePath ScriptFile(ToolId tool, ScriptId script, ToolScriptKind kind)
        {
            var x = kind switch{
                ToolScriptKind.Cmd => FS.Cmd,
                ToolScriptKind.Ps => FS.Ps1,
                _ => FS.FileExt.Empty
            };
            return Paths.ToolScript(tool, script, x);
        }

        CmdLine CmdLine(FS.FilePath path, ToolScriptKind kind)
        {
            return kind switch{
                ToolScriptKind.Cmd => WinCmd.script(path),
                ToolScriptKind.Ps => PwshCmd.script(path),
                _ => Z0.CmdLine.Empty
            };
        }
    }
}