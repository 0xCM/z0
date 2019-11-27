//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static As;

    partial class BitRef
    {
        public static BitMatrix8 bmm(BitMatrix8 lhs, BitMatrix8 rhs)
        {
            const uint n = BitMatrix8.N;

            var dst = BitMatrix.alloc(n8);
            rhs = rhs.Transpose();
            for(var i=0; i< n; i++)
            {
                var row = lhs[i];
                for(var j =0; j< n; j++)
                {
                    var col = rhs[j];
                    dst[i,j] = BitVector.modprod(row,col);
                }
            }
            return dst;
        }

        public static BitMatrix16 bmm(BitMatrix16 lhs, BitMatrix16 rhs)
        {
            const uint n = BitMatrix16.N;
            
            var dst = BitMatrix16.Alloc();            
            rhs = rhs.Transpose();
            for(var i=0; i< n; i++)
            {
                var row = lhs[i];
                for(var j =0; j< n; j++)
                {
                    var col = rhs[j];
                    dst[i,j] = BitVector.modprod(row,col);
                }
            }
            return dst;
        }

        public static BitMatrix32 bmm(BitMatrix32 lhs, BitMatrix32 rhs)
        {
            const uint n = BitMatrix32.N;
            
            var dst = BitMatrix.alloc(n32);
            rhs = rhs.Transpose();
            for(var i=0; i< n; i++)
            {
                var row = lhs[i];
                for(var j =0; j< n; j++)
                {
                    var col = rhs[j];
                    dst[i,j] = BitVector.modprod(row,col);
                }
            }
            return dst;
        }

        public static BitMatrix64 bmm(BitMatrix64 lhs, BitMatrix64 rhs)
        {
            const uint n = BitMatrix64.N;

            var dst = BitMatrix.alloc(n64);
            rhs = rhs.Transpose();
            for(var i=0; i< n; i++)
            {
                var row = lhs[i];
                for(var j =0; j< n; j++)
                {
                    var col = rhs[j];
                    dst[i,j] = BitVector.modprod(row,col);
                }
            }
            return dst;
        }
    }
}