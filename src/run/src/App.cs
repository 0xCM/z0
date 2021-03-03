//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Part;
    using static memory;
    using static Toolsets;


    public interface IScriptResultHandlder
    {
        ToolId Tool => default;

        bool CanHandle(TextLine src);

        bool Handle(TextLine src);

    }

    class DefaultResultHandler : IScriptResultHandlder
    {
        readonly IDbPaths Paths;

        public ToolId Tool => msbuild;

        void Status(TextLine src)
            => term.babble(src);

        public DefaultResultHandler(IDbPaths paths)
        {
            Paths = paths;
        }

        public bool Handle(TextLine src)
        {
            Status(src);
            return true;
        }

        public bool CanHandle(TextLine src)
            => true;

    }

    class MsBuildResultHandler : IScriptResultHandlder
    {
        readonly IDbPaths Paths;

        public ToolId Tool => msbuild;

        void Status(TextLine src)
            => term.babble(src);

        void Found(string marker)
            => term.inform(marker);

        public MsBuildResultHandler(IDbPaths paths)
        {
            Paths = paths;
        }

        public bool Handle(TextLine src)
        {
            var content = src.Content;
            var @continue = true;

            if(content.Contains(BuildSucceededMarker))
            {
                Found(nameof(BuildSucceededMarker));
                Status(src);
                @continue = false;
            }
            else
            {
                Status(src);
            }

            return @continue;

        }

        public bool CanHandle(TextLine src)
            => src.Content.Contains(Logo);

        const string BuildSucceededMarker = "Build Succeeded";

        const string Logo = "Microsoft (R) Build Engine";

    }

    public class RobocopyResultHandler : IScriptResultHandlder
    {
        readonly IDbPaths Paths;

        public ToolId Tool => robocopy;

        void Status(TextLine src)
            => term.babble(src);

        void Found(string marker)
            => term.inform(marker);

        public RobocopyResultHandler(IDbPaths paths)
        {
            Paths = paths;
        }

        public bool Handle(TextLine src)
        {
            var @continue = true;
            var content = src.Content;
            if(content.Contains(CopySummaryMarker))
            {
                Found(nameof(CopySummaryMarker));
                Status(src);
            }
            else if(content.Contains(CopyFinishedMarker))
            {
                Found(nameof(CopyFinishedMarker));
                Status(src);

                @continue = false;
            }
            else
                Status(src);


            return @continue;
        }

        public bool CanHandle(TextLine src)
            => src.Content.Contains(Logo);

        const string Logo = "Robust File Copy for Windows";

        const string CopySummaryMarker = "Total    Copied   Skipped  Mismatch    FAILED    Extras";

        const string CopyFinishedMarker = "Ended :";

    }

    class ResultProcessor
    {
        readonly IDbPaths Paths;

        public FS.FilePath ScriptPath {get;}

        IScriptResultHandlder CurrentHandler;

        IScriptResultHandlder DefaultHandler;

        Index<IScriptResultHandlder> KnownHandlers;

        public ResultProcessor(IDbPaths paths, FS.FilePath script)
        {
            Paths = paths;
            ScriptPath = script;
            DefaultHandler = new DefaultResultHandler(Paths);
            CurrentHandler = DefaultHandler;
            KnownHandlers = sys.alloc<IScriptResultHandlder>(2);
            KnownHandlers[0] = new MsBuildResultHandler(Paths);
            KnownHandlers[1] = new RobocopyResultHandler(Paths);
        }

        void Switch(IScriptResultHandlder handler)
        {
            CurrentHandler = handler;
            term.inform($"Beginning {CurrentHandler.Tool} result processing");
        }

        void Revert()
        {
            CurrentHandler = DefaultHandler;
        }

        bool Handle(TextLine src)
            => CurrentHandler.Handle(src);

        public TextLine Process(TextLine src)
        {
            if(!Handle(src))
            {
                Revert();
            }

            foreach(var handler in KnownHandlers)
            {
                if(handler.CanHandle(src))
                {
                    Switch(handler);
                    break;
                }
            }

            return src;
        }

    }

    class Runner
    {
        public static void Main(params string[] args)
        {
            var count = args.Length;
            if(count != 0)
                term.inform(string.Format("Command-line: {0}", args.Delimit()));

            if(count != 0 && args[0] == "--control")
            {
                var paths = DbPaths.create();
                for(var i=1; i<count; i++)
                {
                    var name = FS.file(args[i]);
                    term.inform(name);

                    if(!name.HasExtension)
                        name = name.WithExtension(FS.Extensions.Cmd);

                    var script = paths.ControlScript(name);
                    if(script.Exists)
                    {
                        var runner = ScriptRunner.create();
                        var outcome = runner.RunControlScript(name);
                        if(outcome)
                        {
                            var processor = new ResultProcessor(paths,script);
                            term.inform("Response");
                            root.iter(outcome.Data, x => processor.Process(x));
                        }
                    }
                    else
                    {
                        term.error($"The script {script.ToUri()} does not exist");
                    }
                }
            }
            else
                Apps.react(args);
        }

        readonly IWfShell Wf;


        void CheckFlags()
        {
            var flags = Clr.@enum<Windows.MinidumpType>();
            var summary = flags.Summary();
            var count = summary.FieldCount;
            var details = summary.LiteralDetails;

            if(count == 0)
                Wf.Error("No flags");

            for(var i=0; i<count; i++)
            {
                ref readonly var detail = ref skip(details,i);
                var description = string.Format("{0,-12} | {1,-48} | {2}", detail.Position, detail.Name, detail.ScalarValue.FormatHex());
                Wf.Row(description);
            }
        }


        void CalcAddress()
        {
            // ; BaseAddress = 7ffc56862280h
            // 0025h call 7ffc52e94420h                      ; CALL rel32                       | E8 cd                            | 5   | e8 76 21 63 fc
            // Expected: 7ffc56862310h
            const ulong FunctionBase = 0x7ffc56862280;
            const ulong InstructionOffset = 0x25;
            const ulong InstructionSize = 0x5;
            const ulong Displacement = 0xfc632176;
            var instruction = array<byte>(0xe8, 0x76, 0x21, 0x63, 0xfc);
            MemoryAddress Encoded =  0x7ffc52e94420;
            MemoryAddress nextIp = FunctionBase + InstructionOffset + InstructionSize;
            MemoryAddress target = nextIp + Displacement;
        }
    }
}