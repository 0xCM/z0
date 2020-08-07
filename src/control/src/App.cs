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
            Ct = CorrelationToken.define((byte)Part);   
            Raise(Flow.created(ActorName, Ct));
        }
        
        public override void RunShell(params string[] args)
        {         
            var arglist = args.FormatList();
            var msg = text.format(PSx2, Part.Format(), arglist);
            Raise(Flow.running(ActorName, msg, Ct));

            try
            {
                using var control = CaptureController.create(Context, Ct, args);
                control.Run();
            }
            catch(Exception e)
            {
                Raise(Flow.error(ActorName, e, Ct));
            }
            
            Raise(Flow.ran(ActorName, msg, Ct));
        }

        public static void Main(params string[] args)
            => Launch(args);
    }

    public static partial class XTend { }
}