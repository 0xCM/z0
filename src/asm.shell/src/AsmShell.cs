//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Collections.Generic;

    using Z0.Asm;

    using static Root;
    using static core;

    using K = AsmCmdKind;
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
        {
            var input = term.prompt("cmd> ");
            var i = input.IndexOf(Chars.Space);
            var args = CmdArgs.Empty;
            var name = input;
            if(i != NotFound)
            {
                name = TextTools.left(input,i);
                var right = TextTools.right(input,i);
                if(nonempty(right))
                    args = Cmd.args(right.Split(Chars.Space));
            }
            return Cmd.spec(name,args);
        }

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