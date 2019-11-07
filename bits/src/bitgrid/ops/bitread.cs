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
    using static AsIn;

    partial class BitGrid
    {
        /// <summary>
        /// Reads a single bit from a grid given a (row,col) coordinate
        /// </summary>
        /// <param name="src">A reference to the grid source data</param>
        /// <param name="N">The width f the grid</param>
        /// <param name="row">The grid row</param>
        /// <param name="col">The grid col</param>
        /// <typeparam name="T">The segment storage type</typeparam>
        [MethodImpl(Inline)]
        public static bit readbit<T>(in T src, int N, int row, int col)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return readbit(in uint8(in src), N, row, col);
            else if(typeof(T) == typeof(ushort))
                return readbit(in uint16(in src), N, row, col);
            else if(typeof(T) == typeof(uint))
                return readbit(in uint32(in src), N, row, col);
            else if(typeof(T) == typeof(ulong))
                return readbit(in uint64(in src), N, row, col);
            else            
                throw unsupported<T>();
        }           
        
        [MethodImpl(Inline)]
        static bit readbit(in byte src, int N, int row, int col)    
        {
            const int segwidth = 8;
            const int segorder = 3;
            const byte one = 1;

            var pos = N*row + col;
            var seg = pos >> segorder;
            var offset = pos % segwidth;
            return (skip(in src, seg) & (one << pos)) != 0;        
        }

        [MethodImpl(Inline)]
        static bit readbit(in ushort src, int N, int row, int col)    
        {
            const int segwidth = 16;
            const int segorder = 4;
            const ushort one = 1;

            var pos = N*row + col;
            var seg = pos >> segorder;
            var offset = pos % segwidth;
            return (skip(in src, seg) & (one << pos)) != 0;        
        }

        [MethodImpl(Inline)]
        static bit readbit(in uint src, int N, int row, int col)    
        {
            const int segwidth = 32;
            const int segorder = 5;
            const uint one = 1;

            var pos = N*row + col;
            var seg = pos >> segorder;
            var offset = pos % segwidth;
            return (skip(in src, seg) & (one << pos)) != 0;        
        }

        [MethodImpl(Inline)]
        static bit readbit(in ulong src, int N, int row, int col)    
        {
            const int segwidth = 64;
            const int segorder = 6;
            const ulong one = 1;

            var pos = N*row + col;
            var seg = pos >> segorder;
            var offset = pos % segwidth;
            return (skip(in src, seg) & (one << pos)) != 0;        
        }

    }

}