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

        void Render(ReadOnlySpan<CmdTypeInfo> src, ITextBuffer dst)
        {
            var count = src.Length;
            for(var i=0; i<count; i++)
                dst.AppendLine(skip(src,i).Format());
        }

        public Outcome<TextLines> RunControlScript(FS.FileName script)
        {
            var result = RunScript(Db.ControlScript(script));
            if(result)
            {
                using var writer = Db.CmdLog(script.Name).Writer();
                root.iter(result.Data, line => writer.WriteLine(line));
            }
            return result;
        }

        public Outcome<TextLines> Run(CmdLine cmd)
        {
            try
            {
                var process = ToolCmd.run(cmd).Wait();
                var output = process.Output;
                return Parse.lines(output);
            }
            catch(Exception e)
            {
                term.error(e);
                return e;
            }
        }

        public FS.FilePath ScriptFile(ToolId tool, Name script, ToolScriptKind shell)
        {
            var x = shell switch{
                ToolScriptKind.Cmd => FS.Extensions.Cmd,
                ToolScriptKind.Ps => FS.Extensions.Ps1,
                _ => FS.FileExt.Empty
            };
            return Db.ToolScriptFile(tool, script, x);
        }

        public FS.FilePath ScriptFile<K>(K kind, Name script, ToolScriptKind shell)
        {
            var x = shell switch{
                ToolScriptKind.Cmd => FS.Extensions.Cmd,
                ToolScriptKind.Ps => FS.Extensions.Ps1,
                _ => FS.FileExt.Empty
            };
            return Db.ToolScriptFile(kind, script, x);
        }

        public CmdLine CmdLine(FS.FilePath script, ToolScriptKind shell)
        {
            return shell switch{
                ToolScriptKind.Cmd => WinCmd.script(script),
                ToolScriptKind.Ps => Pwsh.script(script),
                _ => Z0.CmdLine.Empty
            };
        }

        public Outcome<TextLines> RunScript(FS.FilePath src)
        {
            var kind = src.FileName.FileExt.Equals(FS.Extensions.Ps1) ? ToolScriptKind.Ps : ToolScriptKind.Cmd;
            var command = new CmdLine(src.Format(PathSeparator.BS));
            return Run(command);
        }

        public Outcome<TextLines> RunScript(ToolId tool, Name name, ToolScriptKind shell)
        {
            var file = ScriptFile(tool,name, shell);
            var command = CmdLine(file,shell);
            return Run(command);
        }

        public Outcome<TextLines> RunScript<K>(K kind, Name name, ToolScriptKind shell)
        {
            var file = ScriptFile(kind,name, shell);
            var command = CmdLine(file,shell);
            return Run(command);
        }

        public Outcome<TextLines> RunCmdScript<K>(K kind, Name name)
            => RunScript(kind, name, ToolScriptKind.Cmd);

        public Outcome<TextLines> RunPsScript<K>(K kind, Name name)
            => RunScript(kind, name, ToolScriptKind.Ps);
    }
}