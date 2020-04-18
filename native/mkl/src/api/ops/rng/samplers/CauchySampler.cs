//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    sealed class CauchySampler<T> : Sampler<T, CauchySpec<T>>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public CauchySampler(MklRng src, CauchySpec<T> spec, int? buferLen = null)
            : base(src, spec, buferLen)
        {

        }

        [MethodImpl(Inline)]
        public CauchySampler(MklRng src, T a, T b, int? buferLen = null)
            : base(src, (a,b), buferLen)
        {

        }

        protected override int FillBuffer(Span<T> buffer)
        {            
            if(typeof(T) == typeof(float))
                sample.cauchy(Source, float32(DistSpec.Location), float32(DistSpec.Scale), Spans.s32f(buffer));
            else if (typeof(T) == typeof(double))
                sample.cauchy(Source, float64(DistSpec.Location), float64(DistSpec.Scale), Spans.s64f(buffer));
            else 
                throw Unsupported.define<T>();            
            return buffer.Length;
        }
    }

}