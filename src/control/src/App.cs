//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using Z0.Asm;

    using static Flow;

    class App : AppShell<App,IAppContext>
    {               
        public const PartId Part = PartId.Control;
        
        public const string PartName = nameof(PartId.Control);

        public const string ActorName = PartName + "/" + nameof(App);

        public CorrelationToken Ct {get;}         
                        
        public App()
            : base(WfBuilder.app())
        {
            Ct = CorrelationToken.define(Part);   
            Raise(Flow.created(Ct, ActorName));
        }
        
        public override void RunShell(params string[] args)
        {         
            try
            {
                using var control = CaptureController.create(Context, Flow.configure(Context, args, Ct), Ct);
                control.Run();
            }
            catch(Exception e)
            {
                Raise(Flow.error(ActorName, e, Ct));
            }
            
        }

        public static void Main(params string[] args)
            => Launch(args);
    }

    public static partial class XTend { }
}