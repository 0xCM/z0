//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Z0.Asm;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    unsafe sealed class Shell : WfApp<Shell>
    {
        Engine CmdService;

        protected override void Initialized()
        {
            CmdService = Engine.create(Wf);
        }

        protected override void Disposing()
            => CmdService.Dispose();

        protected override void Run()
            => CmdService.Run();

        public static void Main(params string[] args)
        {
            using var wf = WfAppLoader.load();
            using var shell = create(wf);
            shell.Run();
        }
    }
}