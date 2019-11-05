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

        [MethodImpl(Inline)]
        public static bit bitread<T>(in T src, int M, int N, int row, int col)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return bitread(in uint8(in src), M, N, row, col);
            else if(typeof(T) == typeof(ushort))
                return bitread(in uint16(in src), M, N, row, col);
            else if(typeof(T) == typeof(uint))
                return bitread(in uint32(in src), M, N, row, col);
            else if(typeof(T) == typeof(ulong))
                return bitread(in uint64(in src), M, N, row, col);
            else            
                throw unsupported<T>();
        }           
        
        [MethodImpl(Inline)]
        static bit bitread(in byte src, int M, int N, int row, int col)    
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
        static bit bitread(in ushort src, int M, int N, int row, int col)    
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
        static bit bitread(in uint src, int M, int N, int row, int col)    
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
        static bit bitread(in ulong src, int M, int N, int row, int col)    
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