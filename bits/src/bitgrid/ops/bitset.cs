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

        /// <summary>
        /// Sets the state of an a coordinate-identified grid bit
        /// </summary>
        /// <param name="src">A reference to the grid storage</param>
        /// <param name="M">The number of rows in the grid</param>
        /// <param name="N">The number of columns in the grid</param>
        /// <param name="row">The row of interest</param>
        /// <param name="col">The column of interest</param>
        /// <param name="state">The source state</param>
        /// <typeparam name="T">The grid storage segment type</typeparam>
        [MethodImpl(Inline)]
        public static void setbit<T>(ref T src, int M, int N, int row, int col, bit state)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                setbit(ref uint8(ref src), M, N, row, col, state);
            else if(typeof(T) == typeof(ushort))
                setbit(ref uint16(ref src), M, N, row, col, state);
            else if(typeof(T) == typeof(uint))
                setbit(ref uint32(ref src), M, N, row, col, state);
            else if(typeof(T) == typeof(ulong))
                setbit(ref uint64(ref src), M, N, row, col, state);
            else            
                throw unsupported<T>();
        }           
        
        [MethodImpl(Inline)]
        static void setbit(ref byte src, int M, int N, int row, int col, bit state)    
        {
            const int segwidth = 8;
            const int segorder = 3;

            var pos = N*row + col;
            var seg = pos >> segorder;
            var offset = pos % segwidth;           
            BitMask.set(ref seek(ref src, seg), (byte)offset, state); 
        }

        [MethodImpl(Inline)]
        static void setbit(ref ushort src, int M, int N, int row, int col, bit state)    
        {
            const int segwidth = 16;
            const int segorder = 4;

            var pos = N*row + col;
            var seg = pos >> segorder;
            var offset = pos % segwidth;
            BitMask.set(ref seek(ref src, seg), (byte)offset, state); 
        }

        [MethodImpl(Inline)]
        static void setbit(ref uint src, int M, int N, int row, int col, bit state)    
        {
            const int segwidth = 32;
            const int segorder = 5;

            var pos = N*row + col;
            var seg = pos >> segorder;
            var offset = pos % segwidth;
            BitMask.set(ref seek(ref src, seg), (byte)offset, state); 
        }

        [MethodImpl(Inline)]
        static void setbit(ref ulong src, int M, int N, int row, int col, bit state)    
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