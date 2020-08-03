//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Flow;
    
    using F = ContentLibField;

    public readonly ref struct EmitContentCatalog
    {
        readonly WfContext Wf;

        readonly FilePath Target;
        
        readonly uint[] Count;

        public readonly CorrelationToken Ct;
        
        [MethodImpl(Inline)]
        public EmitContentCatalog(WfContext wf, CorrelationToken? ct = null)
        {
            Wf = wf;
            Ct = correlate(ct);
            Target =  Wf.IndexRoot + FileName.Define("catalog", FileExtensions.Csv);
            Count = new uint[1]{0};
            Wf.Running(nameof(EmitContentCatalog), Ct);
        }

        public void Run()
        {
            var entries = z.span(zdat.Catalog.Array());
            var f = formatter<ContentLibField>();
            for(var i=0u; i<entries.Length; i++)
            {
                ref readonly var entry = ref z.skip(entries, i);
                f.Append(F.Kind, entry.Kind);
                f.Delimit(F.Structure, entry.Structure);
                f.Delimit(F.Size, entry.Size);
                f.Delimit(F.Name, entry.Name);
                f.EmitEol();
            }
            
            using var dst = Target.Writer();
            dst.Write(f.Format());
            // for(var i=0; i<entries.Length; i++)
            //     dst.Write(entries[i].Format());
            Count[0] = (uint)entries.Length;
        }

        public void Dispose()        
        {
            Wf.Ran(nameof(EmitContentCatalog), $"Wrote {Count[0]} entries to {Target}", Ct);
        }
    }
}
