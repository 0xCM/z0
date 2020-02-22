//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;
	using static zfunc;

    sealed class UniformBitsSampler<T> : Sampler<T, UniformBitsSpec<T>>
        where T : unmanaged
    {
        [MethodImpl(Inline)]
        public UniformBitsSampler(MklRng src, int? buferLen = null)
            : base(src, default, buferLen)
        {
            
        }

        protected override int FillBuffer(Span<T> buffer)
        {
            if(typeof(T) == typeof(uint))
                sample.bits(Source,  SpanOps.span32u(buffer));
            else if(typeof(T) == typeof(ulong))
                sample.bits(Source,  SpanOps.span64u(buffer));
            else 
                throw unsupported<T>();
            
            return buffer.Length;
        }
    }
}