//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machine
{
    using System;
    using System.Linq;

    using Z0.Asm;

    using static Konst;
    using static Memories;
    using static MachineEvents;

    public class Machine : IMachine
    {
        public IMachineContext Context {get;}

        public IEventBroker Broker {get;}

        public IAppMsgSink Sink {get;}

        IMachineFiles Files {get;}

        IMachineIndexBuilder IndexBuilder {get;}            

        ICaptureArchive Archive 
            => Context.Archive;

        Machine(IMachineContext context)
        {
            Sink = context.AppMsgSink;
            Context = context;
            Broker = new EventBroker();
            Files = MachineFiles.Service(context);            
            IndexBuilder = MachineIndex.Builder;
            (this as IMachineEventClient).Connect();            
        }

        public void OnEvent(LoadedParseReport e)
        {
            Index(Sink.Deposit(e).Report);
        }
        
        public void OnEvent(IndexedCode e)
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

        void AnalyzeCalls(InstructionIndex index)
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

            var index = InstructionIndex.Create(e.Instructions.ToArray());
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

        public void Run()
        {
            ParseReports();
        }

        void ParseReports()
        {
            Root.iter(Files.ParseFiles, ParseReport);
            Broker.Raise(IndexedCode.Create(IndexBuilder.Freeze()));
        }
        
        void ParseReport(FilePath src)
        {
            ApiServices.ParseReportParser.Parse(src)
                    .OnFailure(fail => term.error(fail.Reason))
                    .OnSuccess(value => Broker.Raise(LoadedParseReport.Create(value, src)));
        }

        void DecodeParts(MachineIndex src)
        {
            var dst = Root.list<PartInstructions>();
            var parts = src.Parts;
            
            for(var k=0; k<parts.Length; k++)
            {
                var part = parts[k];
                var pcs = src.CodeSet(part);
                dst.Add(DecodePart(pcs));
            }

            Broker.Raise(DecodedMachine.Create(src, dst.ToArray()));
        }

        PartInstructions DecodePart(PartCode pcs)
        {
            var dst = list<HostInstructions>();
            var hcSets = pcs.Code;
            for(var i=0; i<hcSets.Length; i++)
            {
                var hcs = hcSets[i];
                var decoded = Decode(hcs);
                dst.Add(decoded);
                Broker.Raise(DecodedHost.Create(decoded));
            }  

            var inxs = PartInstructions.Create(pcs.Part, dst.ToArray());
            Broker.Raise(DecodedPart.Create(inxs));
            return inxs;                        
        }

        HostInstructions Decode(HostCode hcs)
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
                var uriCode = hcs[i];
                decoder.Decode(uriCode, OnDecoded);
                
                if(i == 0)
                    hostaddr = dst[0].IP;

                var member = MemberInstructions.Create(hostaddr, uriCode, dst.ToArray());
                inxs.Add(member);
            }

            return HostInstructions.Create(hcs.Id, inxs.ToArray());
        }

        void Index(MemberParseReport report)
        {
            Root.iter(report.Records, Index);            
        }

        void Index(MemberParseRecord record)
        {
            IndexBuilder.Include(UriCode.Define(record.Uri, record.Data));
        }

        public void Dispose()
        {

        }

        public static void Run(IMachineContext context)
        {
            try
            {            
                using var machine = new Machine(context); 
                machine.Run();   
            }
            catch(Exception e)
            {
                term.error(e);
            }
        }
    }
}