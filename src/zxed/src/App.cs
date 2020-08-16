//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using static Konst;
    using static z;
     
    class App : AppShell<App,IAppContext>
    {                
        public readonly PartId Part = PartId.ZXed;
        
        public CorrelationToken Ct {get;}
        
        public App()
            : base(Flow.app())
        {
            Ct = CorrelationToken.define(Part);
        }

        void Parse(FilePath src)
        {
            var data = XedSourceParser.Service.LoadSource(src);
            if(data.IsNonEmpty)
                term.print($"Parsed {data.Rows.Length} rows from {src}");
            else
                term.warn($"No content was parsed from {src}");
        }

        public override void RunShell(params string[] args)
        {            
            var sink = Flow.termsink(Ct);
            var s = Flow.settings(Context, Ct);
            var config = new XedEtlConfig(Context, s);
            using var context = Flow.context(Context, Flow.configure(Context, args, Ct),  Ct);
            using var wf = new XedEtl(context, config);
            wf.Run();                                        
        }

        public static void Main(params string[] args)
            => Launch(args);
    }
}