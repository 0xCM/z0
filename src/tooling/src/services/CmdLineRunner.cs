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

    public class CmdLineRunner : AppService<CmdLineRunner>
    {
        public void RunScript(FS.FilePath path, string args)
        {
            var cmd = new CmdLine($"cmd /c {path.Format(PathSeparator.BS)} {args}");
            var process = ScriptProcess.run(cmd);
            var output = process.Output;
            Wf.Status(output);
        }

        public void RunScripts(CmdScripts archive, ReadOnlySpan<ScriptId> scripts, FS.FilePath log)
        {
            try
            {
                var count = scripts.Length;
                for(var i=0; i<count; i++)
                {
                    ref readonly var id = ref skip(scripts,i);
                    var path = archive.Script(id);
                    if(path.Exists)
                    {
                        var output = RunScript(path, log);
                        var processor = CmdResultProcessor.create(path, sys.empty<IToolResultHandler>());
                        Row("Response");
                        iter(output, x => processor.Process(x));
                    }
                    else
                    {
                        Error($"The script {path.ToUri()} does not exist");
                    }
                }
            }
            catch(Exception e)
            {
                Error(e);
            }
        }

        public void RunScripts(CmdScripts archive, ReadOnlySpan<ScriptId> scripts)
            => RunScripts(archive, scripts, Db.AppLog("cmdline"));

        public ReadOnlySpan<TextLine> Run(CmdLine cmd, FS.FilePath log)
        {
            using var writer = log.AsciWriter();
            try
            {
                var process = ScriptProcess.run(cmd, OnStatusEvent, OnErrorEvent).Wait();
                var lines =  Lines.read(process.Output);
                iter(lines, line => writer.WriteLine(line));
                return lines;
            }
            catch(Exception e)
            {
                Error(e);
                writer.WriteLine(e.ToString());
                return default;
            }
        }

        public ReadOnlySpan<TextLine> Run(CmdLine cmd)
        {
            var log = Db.AppLog("cmdline");
            using var writer = log.AsciWriter();
            try
            {
                var process = ScriptProcess.run(cmd, OnStatusEvent, OnErrorEvent).Wait();
                var lines =  Lines.read(process.Output);
                core.iter(lines, line => writer.WriteLine(line));
                return lines;
            }
            catch(Exception e)
            {
                Error(e);
                writer.WriteLine(e.ToString());
                return default;
            }
        }

        public ReadOnlySpan<TextLine> RunScript(FS.FilePath src, FS.FilePath log)
            => Run(WinCmd.script(src), log);

        void OnErrorEvent(in string src)
            => Error(src);

        void OnStatusEvent(in string src)
            => Row(src);
    }
}