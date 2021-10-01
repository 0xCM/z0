//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Z0.Asm;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    sealed class App : WfApp<App>
    {

        protected override void Initialized()
        {

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
            shell.Run();
        }
    }
}