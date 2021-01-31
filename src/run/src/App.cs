//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Part;
    using static z;
    using static TextRules;

    class Runner
    {
        readonly WfHost Host;

        readonly IWfShell Wf;

        readonly CmdBuilder Builder;

        readonly IWfDb Db;

        Runner(IWfShell wf)
        {
            Host = WfShell.host(typeof(Runner));
            Wf = wf.WithHost(Host);
            Builder = wf.CmdBuilder();
            Db = wf.Db();
        }

        public static void Main(params string[] args)
        {
            try
            {
                using var wf = WfShell.create(WfShell.parts(Index<PartId>.Empty), args).WithRandom(Rng.@default());
                var app = new Runner(wf);
                if(args.Length == 0)
                {
                    wf.Status("usage: run <command> [options]");
                    var settings = wf.Settings;
                    wf.Row(settings.Format());
                }
                else
                {
                    if(args.Length == 1 && (args[0] == "tests" || args[0] == "test"))
                        app.RunTests();
                    else
                    {
                        wf.Status("Dispatching");
                        Reactor.init(wf).Dispatch(args);
                    }
                }

            }
            catch(Exception e)
            {
                term.error(e);
            }
        }


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

        void SummarizeDataTypes()
        {
            var types = DataTypes.search(Wf.Components);
            var count = types.Count;
            for(var i=0; i<count; i++)
            {
                ref readonly var current = ref types[i];
                var content = current.ContentType;
                var container = current.ContainerType;
                var width = current.StorageWidth;
                var description = string.Format("{0,-24} | {1}", container.Name, width);
                Wf.Row(description);
            }
        }

        void SummarizeDump()
        {
            var src = Db.DumpFilePath("capture");
            if(src.Exists)
            {
                var formatter = Records.formatter<Minidump.FileHeader>();
                using var md = Minidump.open(Wf, src);
                var header = formatter.Format(md.Header, RecordFormatKind.KeyValuePairs);
                Wf.Row(header);

                // using var file = MemoryFiles.map(src);
                // Wf.Status($"Mapped file {file.Path} to process memory based at {file.BaseAddress}");
                // ref readonly var header = ref file.One<W.MINIDUMP_HEADER>(0);
                // asci4 sig = header.Signature;
                // Wf.Row(string.Format("Sig:{0}, Version:{1}, NumerOfStreams:{2}, Flags:{3}",
                //     sig, header.Version & ushort.MaxValue, header.NumberOfStreams, header.Flags));
            }
            else
                Wf.Error($"The file {src} does not exist");
        }

        public void LoadDocs()
        {
            // const string TestCase = @"J:\lang\lisp\acl2\books\projects\x86isa\machine\linear-memory.lisp";
            // var doc = LispDocs.load(FS.path(TestCase));
            // Wf.Row(doc.Format());
        }


        static Address32 displacement(BinaryCode instruction)
        {
            var opcode = instruction[0];
            root.require(opcode == 0xe8, () => $"Expected an opcode of e8h, but instead there is {opcode.FormatAsmHex()}");
            var len = instruction.Length - 1;
            var bytes = slice(instruction.View, 1);
            return Numeric.take32u(bytes);

        }

        void CalcAddress()
        {
            // ; BaseAddress = 7ffc56862280h
            // 0025h call 7ffc52e94420h                      ; CALL rel32                       | E8 cd                            | 5   | e8 76 21 63 fc
            // Expected: 7ffc56862310h
            const ulong FunctionBase = 0x7ffc56862280;
            const ulong CallOffset = 0x25;
            const ulong CallInstructionSize = 0x5;
            const ulong CallDisplacement = 0xfc632176;
            var instruction = array<byte>(0xe8, 0x76, 0x21, 0x63, 0xfc);
            var dx = displacement(instruction);

            MemoryAddress Expected = 0x7ffc56862310;
            MemoryAddress Encoded =  0x7ffc52e94420;

            MemoryAddress next = FunctionBase + CallOffset + CallInstructionSize;
            MemoryAddress target = next + CallDisplacement;
            MemoryAddress encoded = 0x7ffc52e94420;


            Wf.Status($"Computed:{target} | Expected:{Expected} | Encoded:{encoded} | Computed2:{dx}");


        }

        void EmitBitMasks()
        {
            var service = BitMaskServices.create(Wf);
            var masks = service.Emit();
            Wf.Status($"Emitted {masks.Count} masks");
        }

        public void RunTests()
        {
            // const ushort Assign = '←';
            // const char Test = (char)127;
            // Wf.Row(Assign.ToString());
            CalcAddress();
            //EmitBitMasks();
        }
    }
}