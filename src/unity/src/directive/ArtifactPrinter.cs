//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static z;

    using static ClrArtifacts;

    public readonly struct ArtifactPrinter
    {
        readonly IWfShell Wf;

        [MethodImpl(Inline)]
        public ArtifactPrinter(IWfShell wf)
            => Wf = wf;

        [MethodImpl(Inline)]
        public void Print<A>(Artifacts<A> src)
            where A : struct, IClrArtifact<A>
        {
            if(src.IsNonEmpty)
            {
                var count = src.Length;
                ref readonly var lead = ref src.First;
                for(var i=0u; i<count; i++)
                    Print(skip(lead, i));
            }
        }

        [MethodImpl(Inline)]
        public void Print<A>(in A src)
            where A : struct, IClrArtifact<A>
                => Wf.DataRow(src);
    }
}