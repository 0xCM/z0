//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;
    using Z0;
 
    using static zfunc;
    using static BitMasks;
    using static As;

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

    /// <summary>
    /// Defines bitwise partition structures and functions
    /// </summary>
    public static partial class BitParts
    {        
        

        [MethodImpl(Inline)]
        public static ref ushort pack16x1(ReadOnlySpan<byte> src, ref ushort dst)
        {
            dst |= src[0];
            dst |= (ushort)(src[1] << 1);
            dst |= (ushort)(src[2] << 2);
            dst |= (ushort)(src[3] << 3);
            dst |= (ushort)(src[4] << 4);
            dst |= (ushort)(src[5] << 5);
            dst |= (ushort)(src[6] << 6);
            dst |= (ushort)(src[7] << 7);
            dst |= (ushort)(src[8] << 8);
            dst |= (ushort)(src[9] << 9);
            dst |= (ushort)(src[10] << 10);
            dst |= (ushort)(src[11] << 11);
            dst |= (ushort)(src[12] << 12);
            dst |= (ushort)(src[13] << 13);
            dst |= (ushort)(src[14] << 14);
            dst |= (ushort)(src[15] << 15);
            return ref dst;
        }

    
    }


}