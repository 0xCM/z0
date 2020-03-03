//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    using System;
    using System.Runtime.CompilerServices;

	using static Root;

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
                sample.chi2(Source, DistSpec, Spans.span32f(buffer));
            else if (typeof(T) == typeof(double))
                sample.chi2(Source, DistSpec, Spans.span64f(buffer));
            else 
                throw unsupported<T>();            
            return buffer.Length;
        }
    }
}