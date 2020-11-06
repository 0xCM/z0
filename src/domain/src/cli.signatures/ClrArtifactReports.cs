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

    using api = ClrArtifacts;

    public readonly struct ClrArtifactReports
    {
        [MethodImpl(Inline)]
        void Emit<A>(ClrArtifactSet<A> src, FS.FilePath dst)
            where A : struct, IClrArtifact<A>
        {
            if(src.IsNonEmpty)
            {
                using var writer = dst.Writer();
                var count = src.Length;
                ref readonly var lead = ref src.First;
                for(var i=0u; i<count; i++)
                    writer.WriteLine(skip(lead, i));
            }
        }

        public static void types(IWfShell wf, Assembly src, FS.FilePath dst)
        {
            var types = api.sTypes(src);
            var count = types.Length;
            if(count != 0)
            {
                using var writer = dst.Writer();
                ref readonly var lead = ref types.First;
                for(var i=0; i<count; i++)
                {
                    ref readonly var type = ref skip(lead,i);
                    writer.WriteLine(string.Format("{0,-16} | {1}", type.Key, type.Name));
                }
            }
        }
    }
}