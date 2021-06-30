//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Z0.Asm;

    using static Root;
    using static core;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public unsafe sealed class AsmShell : WfApp<AsmShell>
    {
        AsmCmdService AsmCmd;

        protected override void Initialized()
        {
            AsmCmd = Wf.AsmCmd();
        }

        Outcome Dispatch(CmdSpec cmd)
            => AsmCmd.Dispatch(cmd);

        CmdSpec Next()
            => Cmd.spec(term.prompt("cmd> "));

        protected override void Run()
        {
            var input = Next();
            while(input.Name != ".exit")
            {
                if(input.IsNonEmpty)
                    Dispatch(input);

                input = Next();
            }
        }

        protected override void Disposing()
        {
            AsmCmd.Dispose();
        }

        public static void Main(params string[] args)
        {
            using var wf = WfAppLoader.load();
            using var shell = create(wf);
            shell.Run();
        }
    }
}