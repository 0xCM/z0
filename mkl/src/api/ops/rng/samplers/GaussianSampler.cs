//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    using System;

    using static Root;
    using static As;

    sealed class GaussianSampler<T> : Sampler<T, GaussianSpec<T>>
        where T : unmanaged
    {
        public GaussianSampler(MklRng src, GaussianSpec<T> distspec,  int? buferLen = null)
            : base(src, distspec, buferLen)
        {

        }

        public GaussianSampler(MklRng src, T mu, T sigma,  int? buferLen = null)
            : base(src, new GaussianSpec<T>(mu,sigma), buferLen)
        {

        }

        protected override int FillBuffer(Span<T> buffer)
        {
            if(typeof(T) == typeof(float))
                sample.gaussian(Source, float32(DistSpec.Mean), float32(DistSpec.StdDev), Spans.span32f(buffer));
            else if(typeof(T) == typeof(double))
                sample.gaussian(Source, float64(DistSpec.Mean), float64(DistSpec.StdDev), Spans.span64f(buffer));
            else 
                throw unsupported<T>();

            return buffer.Length;

        }
    }
}