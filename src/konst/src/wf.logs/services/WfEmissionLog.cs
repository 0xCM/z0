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

    struct WfEmissionLog : IWfEmissionLog
    {
        readonly FileStream Emissions;

        internal WfEmissionLog(FS.FilePath dst)
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
                var count = flow.EmissionCount;
                var status = count == 0 ? "Emitting" : "Emitted";
                var format = string.Format(FormatPattern, flow.Token, Records.tableid<T>(), status, count, flow.Target.ToUri());
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