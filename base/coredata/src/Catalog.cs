//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using static zfunc;

    class Catalog : OpCatalog<Catalog>
    {
        public Catalog(AssemblyId id)
            : base(id)
        {

        }        

        public override IEnumerable<ApiHost> DirectApiHosts
            => from t in (new Type[]{typeof(DataBlocks)})
                select ApiHost.Define(AssemblyId,t);

        public override IEnumerable<ApiHost> GenericApiHosts
            => from t in (new Type[]{typeof(DataBlocks), typeof(Symbolic)})
                select ApiHost.Define(AssemblyId, t);
    }

    static class Symbolic
    {

        [Op, NumericClosures(NumericKind.All)]
        static void SpanFill<T>(T src, Span<T> dst)
            => dst.Fill(src);

        [Op, NumericClosures(NumericKind.All)]
        static void SpanClear<T>(Span<T> dst)
            => dst.Clear();

        [Op, NumericClosures(NumericKind.All)]
        static Span<T> SpanSlice<T>(Span<T> src, int start)
            => src.Slice(start);

        [Op, NumericClosures(NumericKind.All)]
        static Span<T> SpanSlice<T>(Span<T> src, int start, int length)
            => src.Slice(start,length);

    }
}