//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public sealed class ScriptRunner
    {
        [MethodImpl(Inline)]
        public static ScriptRunner create(IEnvPaths paths)
            => new ScriptRunner(paths);

        readonly IEnvPaths Paths;

        [MethodImpl(Inline)]
        ScriptRunner(IEnvPaths paths)
            => Paths = paths;

        public ReadOnlySpan<TextLine> RunControlScript(FS.FileName name, CmdVars? vars = null)
            => RunScript(Paths.ControlScript(name), new ScriptId(name.Name), vars);

        public ReadOnlySpan<TextLine> RunToolCmd(ToolId tool, ScriptId script, CmdVars? vars = null)
            => RunToolScript(tool, script, ToolScriptKind.Cmd, vars);

        public ReadOnlySpan<TextLine> RunToolPs(ToolId tool, ScriptId script, CmdVars? vars = null)
            => RunToolScript(tool, script, ToolScriptKind.Ps, vars);

        ReadOnlySpan<TextLine> RunToolScript(ToolId tool, ScriptId script, ToolScriptKind kind, CmdVars? vars)
            => Run(CmdLine(ScriptFile(tool, script, kind), kind), script, vars);

        ReadOnlySpan<TextLine> RunScript(FS.FilePath src, ScriptId script, CmdVars? vars)
            => Run(new CmdLine(src.Format(PathSeparator.BS)), script, vars);

        public ReadOnlySpan<TextLine> RunCmd(CmdLine cmd, CmdVars? vars = null)
        {
            try
            {
                var process = vars != null ? ScriptProcess.run(cmd, vars.Value) : ScriptProcess.run(cmd);
                process.Wait();
                return Lines.read(process.Output);
            }
            catch(Exception e)
            {
                term.error(e);
                return default;
            }
        }

        ReadOnlySpan<TextLine> Run(CmdLine cmd, ScriptId script, CmdVars? vars)
        {
            using var writer = Paths.CmdLog(script).Writer();
            try
            {
                var process = vars != null ? ScriptProcess.run(cmd, vars.Value) : ScriptProcess.run(cmd);
                process.Wait();
                var lines =  Lines.read(process.Output);
                iter(lines, line => writer.WriteLine(line));
                return lines;
            }
            catch(Exception e)
            {
                term.error(e);
                writer.WriteLine(e.ToString());
                return default;
            }
        }

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