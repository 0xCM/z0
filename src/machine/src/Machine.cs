//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using static Seed;
    using static Memories;
    using static MachineEvents;

    public class Machine : IMachine
    {
        public IMachineContext Context {get;}

        public IMachineBroker Broker {get;}

        public IAppMsgSink Sink {get;}

        ICaptureArchive Archive => Context.Archive;

        Machine(IMachineContext context)
        {
            Sink = context.AppMsgSink;
            Context = context;
            Broker = MachineBroker.New;
            (this as IMachineClient).Connect();            
        }

        public void Run()
        {
            var parser = ApiServices.ParseReportParser;
            var files = Context.ParseFiles;
            foreach(var file in files)
            {
                var attempt = parser.Parse(file);
                if(!attempt.Succeeded)
                    term.error(attempt.Reason);
                
                var report = attempt.Value;
                Broker.Raise(new LoadedParseReport(report, file));                
            }    
        }

        public void OnEvent(LoadedParseReport e)
        {
            Sink.Deposit(e);
            Index(e.Report);
        }
        
        void Index(MemberParseReport report)
        {
            for(var i=0; i<report.RecordCount; i++)
            {
                var record = report[i];
                var code = new UriCode(record.Uri, record.Data);
            }
        }

        void DescribeImm()
        {
            term.print($"Imm | {Archive.ImmRootDir}");                        
            var immParts = Archive.ImmDirs(Context.CodeParts);
            Control.iter(immParts, term.print);

            var immHosts = Archive.ImmHostDirs(Context.CodeParts);
            Control.iter(immHosts, term.print);
        }

        void Describe()
        {            
            Control.iter(Context.ParseFiles, term.print);
            Control.iter(Context.AsmFiles,term.print);
            Control.iter(Context.CodeFiles,term.print);
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