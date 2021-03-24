//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static Part;

    [Record(TableId)]
    public struct EmissionLogEntry : IRecord<EmissionLogEntry>
    {
        public const string TableId = "emissions";

        public WfExecToken Token;

        [RenderWidth(24)]
        public FS.FileExt TargetExt;

        public EmissionPhase Phase;

        [RenderWidth(10)]
        public ulong Metric;

        public FS.FileUri Target;
    }

    [RenderWidth(12)]
    public enum EmissionPhase : byte
    {
        None = 0,

        Emitting = 1,

        Emitted = 2
    }


    struct EmissonLogger : IEmissionLogger
    {
        readonly FileStream Emissions;

        internal EmissonLogger(FS.FilePath dst)
        {
            dst.EnsureParentExists().Delete();
            Emissions = dst.Stream();
        }

        public void Dispose()
        {
            Emissions?.Flush();
            Emissions?.Dispose();
        }

        const string FormatPattern = "{0,-24} | {1,-24} | {2,-12} | {3,-12} | {4}";

        public ref readonly WfFileFlow LogEmission(in WfFileFlow flow)
        {
            try
            {
                var count = flow.EmissionCount;
                var status = count == 0 ? "Emitting" : "Emitted";
                var format = string.Format(FormatPattern, flow.Token, flow.Target.Ext, status, count, flow.Target.ToUri());
                FS.write(format + Eol, Emissions);
            }
            catch(Exception error)
            {
                term.errlabel(error, "EventLogError");
            }

            return ref flow;
        }

        public ref readonly WfTableFlow<T> LogEmission<T>(in WfTableFlow<T> flow)
            where T : struct, IRecord<T>
        {
            try
            {
                var metric = flow.EmissionCount;
                var status = metric == 0 ? "Emitting" : "Emitted";
                var format = string.Format(FormatPattern, flow.Token, RecUtil.tableid<T>(), status, metric, flow.Target.ToUri());
                FS.write(format + Eol, Emissions);
            }
            catch(Exception error)
            {
                term.errlabel(error, "EventLogError");
            }
            return ref flow;
        }
    }
}