//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct DataEmitters
    {
        public static void emitted<F,D>(F wf, D dk, PartId part, int count)
            where F : IEmissionWorkflow
            where D : unmanaged, Enum
                => wf.Deposit(AppEvents.create($"{dk}_ran", $"Emitted {count} {dk} {part.Format()} records", wf.EndFlair));
    }

}