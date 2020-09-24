//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;


    public class EmitAsmOpCodesHost : WfHost<EmitAsmOpCodesHost>
    {

        public FS.FolderPath Target {get;set;}

        protected override void Execute(IWfShell wf)
        {
            using var step = new EmitAsmOpCodes(wf,this,Target);
        }
    }
}