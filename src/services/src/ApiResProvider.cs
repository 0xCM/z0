//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static core;
    using static Msg;

    public sealed class ApiResProvider : AppService<ApiResProvider>
    {
        public FS.FilePath ResPackPath()
            => Db.ApiPackages().ResPackLib();

        public MemoryFile MapResPack()
            => MemoryFiles.map(ResPackPath());

        public ReadOnlySpan<SpanResAccessor> SpanAccessors(FS.FilePath src)
        {
            var flow = Wf.Running(LoadingSpanAccessors.Format(src));
            if(!src.Exists)
                Throw.sourced(FS.Msg.DoesNotExist.Format(src));
            var assembly = Assembly.LoadFrom(src.Name);
            var loaded = SpanRes.accessors(assembly);
            Wf.Ran(flow, LoadedSpanAccessors.Format(loaded.Count, src));
            return loaded;
        }

        public ReadOnlySpan<SpanResAccessor> ResPackAccessors()
            => SpanAccessors(ResPackPath());

        public ReadOnlySpan<SpanResAccessor> ResPackAccessors(FS.FilePath src)
            => SpanAccessors(src);

    }
}