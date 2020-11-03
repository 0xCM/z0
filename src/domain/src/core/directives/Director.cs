//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Concurrent;

    using static Konst;
    using static z;

    [ApiHost]
    public ref struct Director
    {
        IWfShell Wf;

        WfStepId Id;

        readonly ConcurrentDictionary<ulong, object> StatelessActors;

        readonly ConcurrentDictionary<ulong, object> StatefulActors;

        public Director(IWfShell wf)
        {
            Wf = wf;
            Id = typeof(Director);
            StatelessActors = new ConcurrentDictionary<ulong, object>();
            StatefulActors = new ConcurrentDictionary<ulong, object>();
            Wf.Created(Id);
        }

        public void Dispose()
        {
            Wf.Disposed(Id);
        }

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        static ClrArtifactKey identify<T>()
            => typeof(T).MetadataToken;

        [MethodImpl(Inline), Op]
        static ClrArtifactKey identify(Type t)
            => t.MetadataToken;
    }
}