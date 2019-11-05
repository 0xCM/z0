//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;
    using static As;

    partial class BitGrid
    {

        [MethodImpl(Inline)]
        public static void bitset<T>(ref T src, int M, int N, int row, int col, bit state)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                bitset(ref uint8(ref src), M, N, row, col, state);
            else if(typeof(T) == typeof(ushort))
                bitset(ref uint16(ref src), M, N, row, col, state);
            else if(typeof(T) == typeof(uint))
                bitset(ref uint32(ref src), M, N, row, col, state);
            else if(typeof(T) == typeof(ulong))
                bitset(ref uint64(ref src), M, N, row, col, state);
            else            
                throw unsupported<T>();
        }           
        
        [MethodImpl(Inline)]
        static void bitset(ref byte src, int M, int N, int row, int col, bit state)    
        {
            const int segwidth = 8;
            const int segorder = 3;

            var pos = N*row + col;
            var seg = pos >> segorder;
            var offset = pos % segwidth;           
            BitMask.set(ref seek(ref src, seg), (byte)offset, state); 
        }

        [MethodImpl(Inline)]
        static void bitset(ref ushort src, int M, int N, int row, int col, bit state)    
        {
            const int segwidth = 16;
            const int segorder = 4;

            var pos = N*row + col;
            var seg = pos >> segorder;
            var offset = pos % segwidth;
            BitMask.set(ref seek(ref src, seg), (byte)offset, state); 
        }

        [MethodImpl(Inline)]
        static void bitset(ref uint src, int M, int N, int row, int col, bit state)    
        {
            const int segwidth = 32;
            const int segorder = 5;

            var pos = N*row + col;
            var seg = pos >> segorder;
            var offset = pos % segwidth;
            BitMask.set(ref seek(ref src, seg), (byte)offset, state); 
        }

        [MethodImpl(Inline)]
        static void bitset(ref ulong src, int M, int N, int row, int col, bit state)    
        {
            const int segwidth = 64;
            const int segorder = 6;

            var pos = N*row + col;
            var seg = pos >> segorder;
            var offset = pos % segwidth;
            BitMask.set(ref seek(ref src, seg), (byte)offset, state); 
        }

    }

}