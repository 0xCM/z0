//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    using System;

    using static Root;
    using static As;
    using static Spans;

    sealed class LaplaceSampler<T> : Sampler<T, LaplaceSpec<T>>
        where T : unmanaged
    {
        public LaplaceSampler(MklRng src, LaplaceSpec<T> spec, int? buferLen = null)
            : base(src, spec, buferLen)
        {

        }

        public LaplaceSampler(MklRng src, T a, T b, int? buferLen = null)
            : base(src, (a,b), buferLen)
        {

        }


        protected override int FillBuffer(Span<T> buffer)
        {            
            if(typeof(T) == typeof(float))
                sample.laplace(Source, float32(DistSpec.Location), float32(DistSpec.Scale),  s32f(buffer));
            else if (typeof(T) == typeof(double))
                sample.laplace(Source, float64(DistSpec.Location), float64(DistSpec.Scale), s64f(buffer));
            else 
                throw unsupported<T>();            
            return buffer.Length;
        }
    }
}