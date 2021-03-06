//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Reflection;
    using System.Collections.Generic;

    using static Part;
    using static WorkflowCommands;
    using static AsmWfCmdKind;
    using static memory;


    public enum AsmWfCmdKind : byte
    {
        None = 0,

        ShowRexBits,

        DistillAsmStatements,

        ExportStokeImports
    }

    readonly struct AsmWfCmdSpecs
    {
        public static void RegisterCommands(IWfShell wf, App host, WfCmdIndex index)
        {
            index.Include(assign(ShowRexBits, host.ShowRexBits));
            index.Include(assign(DistillAsmStatements, host.DistillAsmStatements));
            index.Include(assign(ExportStokeImports, host.ExportStokeImports));
        }

        public static WfCmdIndex RegisterCommands(IWfShell wf, App host)
        {
            var dst = new WfCmdIndex();
            RegisterCommands(wf,host, dst);
            return dst;
        }

    }
}