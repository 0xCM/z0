//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static MetadataEmissionStep;


    public enum MetadataEmissionStep : byte
    {
        None = 0,

        RunningWorkflow,

        RanWorkflow
    }

    partial class XTend
    {
        public static void Running(this MetadataEmissionStep step, IAppEventSink dst)
        {
            var @this = MethodBase.GetCurrentMethod();
            var info = step switch{
                RunningWorkflow => $"Metadata emission workflow: ${@this.Name}",
                _ => $"Executing an unkinded step"
            };

            dst.Deposit(AppEvents.create($"{step}", info, StartFlair));
        }
    }
}