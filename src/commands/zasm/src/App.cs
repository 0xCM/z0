//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using Z0.Xed;
    using Z0.Asm;
    using Z0.Asm.Data;
    using Z0.Asm.Encoding;

    using static Seed;
    using static Memories;

    using P = Z0.Parts;
    
    public static partial class zasm
    {

    }

    class App : AppShell<App,IAppContext>
    {                        
        static IAppContext CreateAppContext()
        {
            var resolved = ApiComposition.Assemble(seq(P.GMath.Resolved));
            var random = Polyrand.Pcg64(PolySeed64.Seed05);                
            var settings = AppSettings.Load(AppPaths.AppConfigPath);
            var exchange = AppMsgExchange.Create();
            return AppContext.Create(resolved, random, settings, exchange);
        }
        
        public App()
            : base(CreateAppContext())
        {
        }

        void ParseRex()
        {
            var input = (byte)RexPrefixCode.Rex48;
            var r1 = Prefixes.ParseRex(input);
            insist(r1.Succeeded);
            var output = r1.Value.Encoded;
            insist(input,output);
            term.print(r1.Value.Format());

            var mrm = Prefixes.ParseModRM(0b110110);
            term.print(mrm.Format());
        }

        FilePath PublishOpCodeDetails(IAsmArchives archives)
        {
            archives.PublishOpCodeDetails(out var dst);
            term.print($"Published opcodes data set to {dst}");
            return dst;
        }

        FilePath PublishInstructionData(IAsmArchives archives)
        {
            var inxsdata = archives.InstructionsData();
            //Control.iter(inxsdata, i => term.print(i.Code.RawName));
            return default;
        }

        IEnumerable<DecoderTestCase> DecoderCases(int bitness, FilePath src)
            => DecoderTestParser.ReadFile(bitness,src);

        void ParseDecoderTests(IAsmArchives src)
        {
            var bits = Control.array(16,32,64);
            var count = 0;
            foreach(var file in src.IcedDecoderTests)
            {
                term.print($"Loading {file}");
                
                foreach(var b in bits)
                {
                    if(file.Contains(b.ToString()))
                    {
                        foreach(var test in DecoderCases(b,file))
                        {
                            count++;
                        }
                    }
                }
            }
            term.print($"Loaded {count} test cases");
        }

        public override void RunShell(params string[] args)
        {            
            var parts = PartParser.Service.ParseValid(args);  
            var archives = AsmArchives.Service;

            // var opcodes = PublishOpCodeDetails(archives);
            // var instructions = PublishInstructionData(archives);            

            ParseDecoderTests(archives);

                                    
        }

        public static void Main(params string[] args)
            => Launch(args);
    }
}