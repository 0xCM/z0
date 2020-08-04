//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    class App : AppShell<App,IAppContext>
    {                
        public App()
            : base(ContextFactory.app())
        {
        }
        
        public override void RunShell(params string[] args)
        {              
            var ct = CorrelationToken.define(1);          
            using var control = new Controller(Context, ct, args);
            control.Run();
        }

        public static void Main(params string[] args)
            => Launch(args);
    }

    public static partial class XTend { }
}