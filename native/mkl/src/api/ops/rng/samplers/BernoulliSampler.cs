//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    using System;
    using System.Runtime.CompilerServices;

    sealed class BernoulliSampler<T> : Sampler<T, BernoulliSpec<double>>
        where T : unmanaged
    {
        public BernoulliSampler(MklRng src, BernoulliSpec<double> spec, int? buferLen = null)
            : base(src, spec, buferLen)
        {

        }
        protected override int FillBuffer(Span<T> buffer)
        {            
            if(typeof(T) == typeof(int))
                sample.bernoulli(Source,  DistSpec, Spans.s32i(buffer));
            else 
                throw Unsupported.define<T>();
            
            return buffer.Length;
        }
    }
}