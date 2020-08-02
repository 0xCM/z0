//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    public readonly ref struct EmitContentCatalog
    {
        readonly WfContext Wf;

        readonly FilePath Target;
        
        readonly uint[] Count;

        public readonly CorrelationToken Correlation;
        
        [MethodImpl(Inline)]
        public EmitContentCatalog(WfContext wf, CorrelationToken? ct = null)
        {
            Wf = wf;
            Correlation = ct ?? CorrelationToken.create();
            Target =  Wf.AppPaths.ResIndexDir + FileName.Define("catalog", FileExtensions.Csv);
            Count = new uint[1]{0};
            Wf.Running(nameof(EmitContentCatalog), Correlation);
        }

        public void Run()
        {
            using var dst = Target.Writer();
            var entries = zdat.Catalog.Array();
            for(var i=0; i<entries.Length; i++)
                dst.Write(entries[i].Format());
            Count[0] = (uint)entries.Length;
        }

        public void Dispose()        
        {
            Wf.Ran(nameof(EmitContentCatalog), $"Wrote {Count[0]} entries to {Target}", Correlation);
        }
    }
}
