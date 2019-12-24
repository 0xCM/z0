//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    using static zfunc;

    /// <summary>
    /// Defines the signature of an operator that accepts a primal value and 
    /// partitions the value, or portion thereof, into segments of common length 
    /// </summary>
    /// <param name="src">The source value</param>
    /// <param name="dst">The target span of sufficent length to receive the partition segments</param>
    /// <typeparam name="S">The primal source type</typeparam>
    /// <typeparam name="T">The primal target type</typeparam>
    public delegate void Partitioner<S,T>(S src, Span<T> dst)
        where T : unmanaged;

    public abstract class t_bitpart<X> : t_bits<X>
        where X : t_bitpart<X>, new()
    {        
        protected void bitpart_check<A,B>(Partitioner<A,B> part, int count, int width)
            where A : unmanaged
            where B : unmanaged
        {
            Span<B> dst = stackalloc B[count];

            for(var sample = 0; sample < SampleCount; sample++)
            {
                var x = Random.Next<A>();
                
                part(x, dst);
                var y = BitString.scalar(x).Partition(width).Map(bs => bs.ToBitVector(n8));
                for(var i=0; i<count; i++)  
                    Claim.eq(y[i], BitString.scalar(dst[i]).ToBitVector(n8));
            }
        }

        // The algorithms for the functions below were taken from https://github.com/lemire/SIMDCompressionAndIntersection/blob/master/src/bitpacking.cpp
        protected unsafe void part32x4_ref(uint src, Span<byte> dst)
        {
            for(int i = 0, j=0; i < 32; i +=4, j++)
                dst[j] = (byte)(((src) >> i) % (1u << 4));
        }

        protected unsafe void unpack32x4(uint* pSrc, uint* pDst)
        {
            for(var inner = 0; inner < 32; inner +=4)
                *(pDst++) = ((*pSrc) >> inner) % (1u << 4);
        }
        
        protected unsafe void fastunpack4(uint* pSrc, uint* pDst)
        {
           for(var outer = 0; outer < 4; ++outer) 
                unpack32x4(pSrc++,pDst);
        }
    }
}