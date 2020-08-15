//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    
    using static Konst;
    using static WfCore;
    using static z;

    class App : AppShell<App,IAppContext>
    {        
        public const PartId Part = PartId.Tools;
        
        public const string PartName = nameof(PartId.Tools);

        public const string ActorName = PartName + "/" + nameof(App);

        public CorrelationToken Ct {get;}         

        public IWfContext Wf {get; private set;}
        
        public App()
            : base(Flow.app())
        {
            Ct = CorrelationToken.define(Part);   
            Raise(status(ActorName, "Application created", Ct));        
        }

        public override void RunShell(params string[] args)
        {                        
            Raise(status(ActorName, new {Message ="Running shell", Args = text.bracket(args.FormatList())},Ct));            
        
            try
            {
                var config = Flow.configure(Context, args, Ct);            
                Wf = Flow.context(Context, config, Ct);                
            }
            catch(Exception e)
            {
                Raise(WfCore.error(ActorName, e, Ct));                
            }

            Raise(status(ActorName, "Shell run complete", Ct));
        }

        public static void Main(params string[] args)
            => Launch(args);

        protected override void OnDispose()
        {
            Wf.Dispose();
            Raise(status(ActorName, "Shell finished", Ct));
        }
    }

    public static partial class XTend
    {

    }
}