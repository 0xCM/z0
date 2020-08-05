//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using static Flow;

    class App : AppShell<App,IAppContext>
    {               
        public const PartId Part = PartId.Control;
        
        public const string PartName = nameof(PartId.Control);

        public const string ActorName = PartName + "/" + nameof(App);

        public CorrelationToken Ct {get;}         
                        
        public App()
            : base(ContextFactory.app())
        {
            Ct = CorrelationToken.define((byte)Part);   
            Raise(Events.status(ActorName, "Application created"));                     
        }
        
        public override void RunShell(params string[] args)
        {              
            Raise(Events.status(ActorName, text.format(PSx2,"Running shell", args.FormatList())));            
            try
            {
                using var control = new Control(Context, Ct, args);
                control.Run();
            }
            catch(Exception e)
            {
                Raise(Events.error(ActorName, e));                
            }
            
            Raise(Events.status(ActorName, "Shell run complete"));
        }

        public static void Main(params string[] args)
            => Launch(args);
    }

    public static partial class XTend { }
}