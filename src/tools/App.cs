//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using static Konst;
    using static Flow;
    using static z;

    class App : AppShell<App,IAppContext>
    {        
        public const PartId Part = PartId.Tools;
        
        public const string PartName = nameof(PartId.Tools);

        public const string ActorName = PartName + "/" + nameof(App);

        public CorrelationToken Ct {get;}         
                
        public App()
            : base(Flow.app())
        {
            Ct = CorrelationToken.from(Part);   
        }

        public override void RunShell(params string[] args)
        {                        
            try
            {
                var config = Flow.configure(Context,args, Ct);            
                using var log = Flow.log(config);                
                using var wf = Flow.context(Context, config, log, Ct);                                
                Flow.status(wf, ActorName, new {Message ="Running shell", Args = text.bracket(args.FormatList())},Ct);

                Flow.status(wf, ActorName, "Shell run complete", Ct);
            }
            catch(Exception e)
            {
                Raise(Flow.error(ActorName, e, Ct));                
            }

        }

        public static void Main(params string[] args)
            => Launch(args);

        protected override void OnDispose()
        {
            
        }
    }

    public static partial class XTend
    {

    }
}