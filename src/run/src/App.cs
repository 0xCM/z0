//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Part;
    using static memory;

    class Runner
    {
        public static void Main(params string[] args)
        {
            var count = args.Length;
            if(count != 0)
                term.inform(string.Format("Command-line: {0}", args.Delimit()));

            if(count >=2 && args[0] == "--control")
            {
                var paths = DbPaths.create();
                var _args = slice(span(args),1).ToArray();

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
                            var processor = Tools.processor(paths, script);
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
            {
                try
                {
                    var parts = WfShell.parts(Index<PartId>.Empty);
                    term.inform(AppMsg.status(text.prop("PartCount", parts.PartComponents.Length)));
                    var rng = Rng.@default();
                    using var wf = WfShell.create(parts, args).WithRandom(rng);
                    if(args.Length == 0)
                    {
                        wf.Status("usage: run <command> [options]");
                        var settings = wf.Settings;
                        wf.Row(settings.Format());
                    }
                    else
                    {
                        wf.Status("Dispatching");
                        Reactor.init(wf).Dispatch(args);
                    }

                }
                catch(Exception e)
                {
                    term.error(e);
                }
            }
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