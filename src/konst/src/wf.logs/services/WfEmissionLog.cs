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

    public interface IWfEmissionLog : IDisposable
    {
        ref readonly WfTableFlow<T> LogEmission<T>(in WfTableFlow<T> flow)
            where T : struct, IRecord<T>;
    }

    struct WfEmissionLog : IWfEmissionLog
    {
        readonly FS.FilePath LogPath;

        readonly FileStream Emissions;

        internal WfEmissionLog(FS.FolderPath root)
        {
            LogPath = (root + FS.file("emissions", FileExtensions.Csv)).EnsureParentExists().Delete();
            Emissions = LogPath.Stream();
        }

        public void Dispose()
        {
            Emissions?.Flush();
            Emissions?.Dispose();
        }

        public ref readonly WfTableFlow<T> LogEmission<T>(in WfTableFlow<T> flow)
            where T : struct, IRecord<T>
        {
            const string FormatPattern = "{0,-24} | {1,-24} | {2,-12} | {3,-12} | {4}";
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