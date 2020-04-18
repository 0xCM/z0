//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    using System;

    sealed class GeometricSampler<T> : Sampler<T, GeometricSpec<T>>
        where T : unmanaged
    {
        public GeometricSampler(MklRng src, GeometricSpec<T> distspec, int? buferLen = null)
            : base(src, distspec, buferLen)
        {

        }

        protected override int FillBuffer(Span<T> buffer)
        {            
            if(typeof(T) == typeof(int))
                sample.geometric(Source,  DistSpec, Spans.s32i(buffer));
            else 
                throw Unsupported.define<T>();
            
            return buffer.Length;
        }
    }

}