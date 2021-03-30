//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    using System;

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
                sample.poisson(Source,  ScalarCast.float64(DistSpec.Rate), memory.int32(buffer));
            else
                throw Unsupported.define<T>();

            return buffer.Length;
        }
    }
}