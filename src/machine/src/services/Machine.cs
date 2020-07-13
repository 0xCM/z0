//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    using Z0.Asm;

    using static Konst;
    using static z;


    public class TheMachine : IMachine
    {
        public IMachineContext Context {get;}

        public IEventBroker Broker {get;}

        public IAppMsgSink Sink {get;}

        PartFiles Files {get;}

        EncodedIndexBuilder IndexBuilder {get;}            

        TheMachine(IMachineContext context)
        {
            Sink = context.AppMsgSink;
            Context = context;
            Broker = new EventBroker(context.AsmContext.AppPaths.AppStandardOutPath);
            Files = PartFiles.create(context.AsmContext);            
            IndexBuilder = Encoded.indexer();
            (this as IMachineEventClient).Connect();            
        }

        public void OnEvent(LoadedParseReport e)
        {
            Index(Sink.Deposit(e).Report);
        }
        
        public void OnEvent(IndexedEncoded e)
        {
            Sink.Deposit(e);

            DecodeParts(e.Index);
        }

        static string Delimit(string[] src, char delimiter)
        {
            var dst = text.build();
            var last = src.Length - 1;
            for(var i=0; i<src.Length; i++)
            {
                if(i != 0)
                {
                    dst.Append(Chars.Space);
                    dst.Append(delimiter);
                    dst.Append(Chars.Space);
                }
                
                if(i != last)
                    dst.Append(src[i].PadRight(16));
                else
                    dst.Append(src[i]);

            }
            return dst.ToString();
        }

        void AnalyzeCalls(LocatedInstructions index)
        {
            var sep = Chars.Pipe;
            var filename = FileName.Define("Calls", FileExtensions.Csv);
            var path = Context.TargetRoot + filename;
            using var writer = path.Writer();

            var data = index.CallData.ToArray();
            var delimited = data.Select(x => Delimit(x.Rows, sep));

            var names = Delimit(CallInfo.AspectNames, sep);            

            writer.WriteLine(names);
            Root.iter(delimited, writer.WriteLine);

        }

        public void OnEvent(DecodedMachine e)
        {
            Sink.Deposit(e);

            var index = LocatedInstructions.create(e.Instructions.ToArray());
            AnalyzeCalls(index);
        }

        public bool SemanticFormatEnabled {get;}
            = false;

        public void OnEvent(DecodedPart e)
        {
            Sink.Deposit(e);

            var workflow = MachineWorkflow.Create(Context);
            workflow.Process(e.Instructions);
            if(SemanticFormatEnabled)
                workflow.Render(e.Instructions);
        }


        

        void DecodeParts(EncodedIndex src)
        {
            var dst = Root.list<PartInstructions>();
            var parts = src.Parts;
            
            for(var k=0; k<parts.Length; k++)
            {
                var part = parts[k];
                var pcs = src.CodeSet(part);
                dst.Add(DecodePart(pcs));
            }

            Broker.Raise(new DecodedMachine(src, dst.Array()));
        }

        PartInstructions DecodePart(PartCodeIndex pcs)
        {
            var dst = list<HostInstructions>();
            var hcSets = pcs.Data;
            for(var i=0; i<hcSets.Length; i++)
            {
                var hcs = hcSets[i];
                var decoded = Decode(hcs);
                dst.Add(decoded);
                Broker.Raise(new DecodedHost(decoded));
            }  

            var inxs = PartInstructions.Create(pcs.Part, dst.Array());
            Broker.Raise(new DecodedPart(inxs));
            return inxs;                        
        }

        HostInstructions Decode(MemberCodeIndex hcs)
        {
            var inxs = Root.list<MemberInstructions>();    
            
            var dst = Root.list<Instruction>();
            void OnDecoded(Instruction inxs)
                => dst.Add(inxs);
            
            var hostaddr = MemoryAddress.Empty;
            var decoder = Context.Decoder;        

            for(var i=0; i<hcs.Length; i++)
            {
                dst.Clear();
                ref readonly var uriCode = ref hcs[i];
                decoder.Decode(uriCode, OnDecoded);
                
                if(i == 0)
                    hostaddr = dst[0].IP;

                var member = MemberInstructions.Create(hostaddr, uriCode, dst.ToArray());
                inxs.Add(member);
            }

            return HostInstructions.Create(hcs.Host, inxs.ToArray());
        }

        void Index(MemberParseReport report)
        {
            Root.iter(report.Records, Index);            
        }

        void Index(MemberParseRecord src)
        {
            if(src.Address.IsEmpty)
                Broker.Raise(new Unaddressed(src.Uri, src.Data));
            else
                IndexBuilder.Include(MemberCode.Define(src.Uri, src.Data));
        }


        void ParseReport(FilePath src)
        {
            var report = ParseReportParser.Service.Parse(src);

            report
                    .OnFailure(fail => term.error(fail.Reason))
                    .OnSuccess(value => Broker.Raise(new LoadedParseReport(value, src)));
        }

        void ParseReports()
        {
            Root.iter(Files.ParseFiles, ParseReport);
            Broker.Raise(new IndexedEncoded(IndexBuilder.Freeze()));
        }

        public void Run()
        {
            ParseReports();
        }

        public static void Run(IMachineContext context)
        {
            try
            {            
                using var machine = new TheMachine(context); 
                machine.Run();   
            }
            catch(Exception e)
            {
                term.error(e);
            }
        }

        public void Dispose()
        {
 
        }

    }
}