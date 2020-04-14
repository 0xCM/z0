//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    using System;

    using static Seed;
    using static Memories;

    sealed class PoissonSampler<T> : Sampler<T, PoissonSpec<T>>
        where T : unmanaged
    {
        public PoissonSampler(MklRng src, PoissonSpec<T> spec, int? buferLen = null)
            : base(src, spec, buferLen)
        {

        }

        protected override int FillBuffer(Span<T> buffer)
        {
            
            if(typeof(T) == typeof(int))
                sample.poisson(Source,  float64(DistSpec.Rate), Spans.s32i(buffer));
            else 
                throw Unsupported.define<T>();
            
            return buffer.Length;
        }
    }
}