//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;


    public ref struct EmitAsmOpCodes
    {

        readonly IWfShell Wf;

        readonly WfHost Host;

        readonly FS.FolderPath Target;

        public readonly ReadOnlySpan<TokenInfo> Tokens;

        readonly AsmTokenIndex TokenIndex;

        public EmitAsmOpCodes(IWfShell wf, WfHost host, FS.FolderPath dst)
        {
            Wf = wf;
            Host = host;
            Target = dst;
            TokenIndex = AsmTokenIndex.create();
            Tokens = TokenIndex.Model;
        }

        public void Run()
        {

        }

        public void Dispose()
        {

        }
    }
}