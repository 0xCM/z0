//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    using System;

    using static Part;
    using static memory;

    sealed class UniformSampler<T> : Sampler<T, UniformSpec<T>>
        where T : unmanaged
    {
        public UniformSampler(MklRng src, UniformSpec<T> distspec,  int? buferLen = null)
            : base(src, distspec, buferLen)
        {

        }

        protected override int FillBuffer(Span<T> buffer)
        {
            if(typeof(T) == typeof(int))
                sample.uniform(Source, int32(DistSpec.Min), int32(DistSpec.Max), int32(buffer));
            else if(typeof(T) == typeof(float))
                sample.uniform(Source, float32(DistSpec.Min), float32(DistSpec.Max), float32(buffer));
            else if(typeof(T) == typeof(double))
                sample.uniform(Source, float64(DistSpec.Min), float64(DistSpec.Max), float64(buffer));
            else
                throw no<T>();

            return buffer.Length;
        }
    }
}