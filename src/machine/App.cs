//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    using Z0.Asm;

    using static z;

    using P = Z0.Parts;
    
    public readonly struct PartSelection : IContentedIndex<IPart>
    {
        public static PartSelection Selected => default(PartSelection);
        
        IPart[] IContented<IPart[]>.Content
            => new IPart[]{
                P.GMath.Resolved,  
               };
    }    
    
    class App : AppShell<App,IAppContext>
    {                
        static IAppContext CreateAppContext()
        {
            var resolved = ApiComposition.Assemble(stream(P.GMath.Resolved));
            var random = Polyrand.Pcg64(PolySeed64.Seed05);                
            var settings = AppSettings.Load(AppPaths.AppConfigPath);
            var exchange = AppMsgExchange.Create();
            return AppContext.Create(resolved, random, settings, exchange);
        }
        
        public App()
            : base(ContextFactory.CreateAppContext())
        {
        }
        
        void Prepare(params string[] args)
        {
            var known = KnownParts.Where(r => r.Id != 0).Array();
            var parts = PartIdParser.Service.ParseValid(args);              
            var root =  AsmContext.Create(Context);
            var context = MachineContext.Create(root, parts);
            var fileProcessor = new PartFileProcessor(context);
            var api = ApiComposition.Assemble(known);                        
            var files = new PartFiles(root);
        }

        void ReadRes()
        {
            var map = MemoryFile.resbytes();
            var @base = map.BaseAddress;
            var data = map.Read(@base, 16);
            var info = map.FileInfo;
            term.print(info.Length);

            term.print(@base);
            term.print(data.Length);
            term.print(new BinaryCode(data.ToArray()));
        }
        
        void RunWorkflows(params string[] args)
        {
            term.print($"Commencing machine worklfow sequence");
            using var workflows = Workflows.machine(Context);
            workflows.Run(args);
            term.print($"Completed machine worklfow sequence");

        }
        public override void RunShell(params string[] args)
        {            
            
            RunWorkflows();
        }

        public static void Main(params string[] args)
            => Launch(args);
    }

    public static partial class XTend
    {

    }
}