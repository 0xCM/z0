//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public readonly struct DataEmitters
    {
        public static void emitted<F,D>(F wf, D dk, PartId part, int count)
            where F : IWorkflow
            where D : unmanaged, Enum
                => wf.Deposit(Events.create($"{dk}_ran", $"Emitted {count} {dk} {part.Format()} records", AppMsgColor.Cyan));
    }
}