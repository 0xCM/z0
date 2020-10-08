//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Konst;
    using static z;
    using static ClrCommands;

    public readonly partial struct ClrCommands
    {
        public static void decode(in ClrCmdSpec src, ref EmitAssemblyReferences dst)
        {
            dst = default;
        }
    }


    public sealed class ClrCmdExec : CmdExec<ClrCmdExec, ClrCmdSpec, ClrCmdResult>
    {

        void Execute(in EmitAssemblyReferences cmd)
        {

        }

        protected override ClrCmdResult Execute(IWfShell wf, ClrCmdSpec spec)
        {
            switch(spec.CmdId)
            {
                case ClrCmdKey.EmitAssemblyReferences:
                break;
            }
            return ClrCmdResult.Empty;
        }
    }
}
