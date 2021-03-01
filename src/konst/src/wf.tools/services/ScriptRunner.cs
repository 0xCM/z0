//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static TextRules;
    using static memory;

    public sealed class ScriptRunner
    {
        [MethodImpl(Inline)]
        public static ScriptRunner create(Env env)
            => new ScriptRunner(DbPaths.create(env));

        [MethodImpl(Inline)]
        public static ScriptRunner create()
            => new ScriptRunner(DbPaths.create());

        readonly IDbPaths Db;

        [MethodImpl(Inline)]
        public ScriptRunner(IDbPaths db)
        {
            Db = db;
        }

        public Outcome<TextLines> RunControlScript(FS.FileName name)
            => RunScript(Db.ControlScript(name), new ScriptId(name.Name));

        public Outcome<TextLines> RunCmdScript(ToolId tool, ScriptId script)
            => RunScript(tool, script, ToolScriptKind.Cmd);

        public Outcome<TextLines> RunPsScript(ToolId tool, ScriptId script)
            => RunScript(tool, script, ToolScriptKind.Ps);

        public Outcome<TextLines> RunScript(ToolId tool, ScriptId script, ToolScriptKind kind)
            => Run(CmdLine(ScriptFile(tool, script, kind), kind), script);

        Outcome<TextLines> Run(CmdLine cmd, ScriptId script)
        {

            using var writer = Db.CmdLog(script).Writer();

            try
            {
                var process = ToolCmd.run(cmd).Wait();
                var lines =  Parse.lines(process.Output);
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
                ToolScriptKind.Cmd => FS.Extensions.Cmd,
                ToolScriptKind.Ps => FS.Extensions.Ps1,
                _ => FS.FileExt.Empty
            };
            return Db.ToolScript(tool, script, x);
        }

        CmdLine CmdLine(FS.FilePath path, ToolScriptKind kind)
        {
            return kind switch{
                ToolScriptKind.Cmd => WinCmd.script(path),
                ToolScriptKind.Ps => Pwsh.script(path),
                _ => Z0.CmdLine.Empty
            };
        }
    }
}