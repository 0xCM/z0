//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Xml;

    using Z0.Asm;

    partial class XTend
    {
        public static IntelIntrinsics IntelIntrinsics(this IWfShell wf)
            => Z0.Asm.IntelIntrinsics.create(wf);

        public static AsmSigs AsmSigServices(this IWfShell wf)
            => Z0.Asm.AsmSigs.create(wf);
    }
}