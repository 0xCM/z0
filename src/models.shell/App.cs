//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Expr
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    sealed class App : WfApp<App>
    {
        Controller controller;

        string[] Args;

        protected override void Initialized()
        {
            controller = Controller.create(Wf);
        }

        protected override void Disposing()
        {
        }

        protected override void Run()
        {

        }

        public static void Main(params string[] args)
        {
            using var wf = WfAppLoader.load();
            using var shell = create(wf);
            shell.Args = args;
            shell.Run();
        }
    }
}