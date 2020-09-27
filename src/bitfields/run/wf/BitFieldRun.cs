//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public sealed class BitFieldRun : WfHost<BitFieldRun>
    {
        protected override void Execute(IWfShell wf)
        {

            var bf32 = BitFields.create(w32);
        }
    }
}