//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static As;

    partial class BitMatrix
    {
        public static BitVector8 diagonal(in BitMatrix8 A)
        {
            const uint N = 8;            
            var dst = (byte)0;
            for(byte i=0; i < N; i++)
                if(A[i,i])
                    BitMask.enable(ref dst, i);
            return dst;                    
        }

        public static BitVector16 diagonal(in BitMatrix16 A)
        {
            const uint N = 16;            
            var dst = (ushort)0;
            for(byte i=0; i < N; i++)
                if(A[i,i])
                    BitMask.enable(ref dst, i);
            return dst;                    
        }

        public static BitVector32 diagonal(in BitMatrix32 A)
        {
            const uint N = 32;            
            var dst = 0u;
            for(byte i=0; i < N; i++)
                if(A[i,i])
                    BitMask.enable(ref dst, i);
            return dst;                    
        }

        public static BitVector64 diagonal(in BitMatrix64 A)
        {
            const uint N = 64;            
            var dst = 0ul;
            for(byte i=0; i < N; i++)
                if(A[i,i])
                    BitMask.enable(ref dst, i);
            return dst;                    
        }

    }

}