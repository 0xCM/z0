//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using Asm;

    using static Seed;
    using static Memories;
    using static MachineEvents;

    public class Machine : IMachine
    {
        public IMachineContext Context {get;}

        public IMachineBroker Broker {get;}

        public IAppMsgSink Sink {get;}

        IMachineFiles Files {get;}

        UriCodeIndex CodeIndex {get;}
            = UriCodeIndex.Empty;

        ICaptureArchive Archive => Context.Archive;

        IAsmFunctionDecoder Decoder => Context.Decoder;

        Machine(IMachineContext context)
        {
            Sink = context.AppMsgSink;
            Context = context;
            Broker = MachineBroker.New;
            Files = new MachineFiles(context);
            (this as IMachineClient).Connect();            
        }

        public void Run()
        {
            ParseReports();
        }

        void ParseReports()
        {
            Control.iter(Files.ParseFiles, ParseReport);
            Broker.Raise(IndexedCode.Create(CodeIndex));
        }
        void ParseReport(FilePath src)
        {
            ApiServices.ParseReportParser.Parse(src)
                    .OnFailure(fail => term.error(fail.Reason))
                    .OnSuccess(value => Broker.Raise(LoadedParseReport.Create(value, src)));
        }

        public void OnEvent(LoadedParseReport e)
        {
            Index(Sink.Deposit(e).Report);
        }
        
        public void OnEvent(IndexedCode e)
        {

            Decode(Sink.Deposit(e).Index.IndexedCode);            
        }

        void Decode(ICollection<UriCode> src)
        {
            var count = 0;

            foreach(var code in src)
                count += Decode(code);

            term.cyan($"Decoded {count} instructions");
        }

        int Decode(UriCode src)
        {
            var count = 0;
            void OnDecoded(Instruction inxs)
            {
                count++;
            }
            
            Decoder.Decode(src.Encoded, OnDecoded);

            return count;
        }

        void Index(MemberParseReport report)
        {
            Control.iter(report.Records, Index);            
        }

        void Index(MemberParseRecord record)
        {
            CodeIndex.Include(UriCode.Define(record.Uri, record.Data));
        }

        void Describe()
        {            
            Control.iter(Files.ParseFiles, term.print);
            Control.iter(Files.AsmFiles,term.print);
            Control.iter(Files.CodeFiles,term.print);
            Control.iter(Archive.ImmDirs(Context.Parts), term.print);
            Control.iter(Archive.ImmHostDirs(Context.Parts), term.print);
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