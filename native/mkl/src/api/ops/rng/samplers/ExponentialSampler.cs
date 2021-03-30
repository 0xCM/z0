//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    sealed class ExponentialSampler<T> : Sampler<T, ExponentialSpec<T>>
        where T : unmanaged
    {
        public ExponentialSampler(MklRng src, ExponentialSpec<T> spec, int? buferLen = null)
            : base(src, spec, buferLen)
        {

        }

        public ExponentialSampler(MklRng src, T a, T b, int? buferLen = null)
            : base(src, ExponentialSpec<T>.Define(a, b), buferLen)
        {

        }

        protected override int FillBuffer(Span<T> buffer)
        {
            if(typeof(T) == typeof(float))
                sample.exp(Source, float32(DistSpec.a), float32(DistSpec.b), float32(buffer));
            else if(typeof(T) == typeof(double))
                sample.exp(Source, float64(DistSpec.a), float64(DistSpec.b), float64(buffer));
            else
                throw no<T>();

            return buffer.Length;
        }
    }
}