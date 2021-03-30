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

    sealed class ChiSquareSampler<T> : Sampler<T, ChiSquareSpec<int>>
        where T : unmanaged
    {
        public ChiSquareSampler(MklRng src, int freedom, int? buferLen = null)
            : base(src, freedom, buferLen)
        {

        }

        protected override int FillBuffer(Span<T> buffer)
        {
            if(typeof(T) == typeof(float))
                sample.chi2(Source, DistSpec, float32(buffer));
            else if (typeof(T) == typeof(double))
                sample.chi2(Source, DistSpec, float64(buffer));
            else
                throw no<T>();
            return buffer.Length;
        }
    }
}