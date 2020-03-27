//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

	using static Root;
    using static As;

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
                sample.uniform(Source, int32(DistSpec.Min), int32(DistSpec.Max), Spans.s32i(buffer));
            else if(typeof(T) == typeof(float))
                sample.uniform(Source, float32(DistSpec.Min), float32(DistSpec.Max), Spans.s32f(buffer));
            else if(typeof(T) == typeof(double))
                sample.uniform(Source, float64(DistSpec.Min), float64(DistSpec.Max), Spans.s64f(buffer));
            else 
                throw Unsupported.define<T>();

            return buffer.Length;
        }
    }
}