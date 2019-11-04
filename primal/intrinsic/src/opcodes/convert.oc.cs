//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;    

    partial class inxvoc
    {
        //vpmovsxbw
        public static ref Vector128<short> vconvert_128x8i_to_128x16i(Vector128<sbyte> src, out Vector128<short> dst)        
            => ref dinx.vconvert(src, out dst);

        //vpmovsxbd
        public static ref Vector128<int> vconvert_128x8i_to_128x32i(Vector128<sbyte> src, out Vector128<int> dst)        
            => ref dinx.vconvert(src, out dst);

        //vpmovsxbq
        public static ref Vector128<long> vconvert_128x8i_to_128x64i(Vector128<sbyte> src, out Vector128<long> dst)        
            => ref dinx.vconvert(src, out dst);

        //vpmovzxbw
        public static ref Vector128<short> vconvert_128x8u_to_128x16i(Vector128<byte> src, out Vector128<short> dst)
            => ref dinx.vconvert(src,out dst);

        //vpmovzxbw
        public static ref Vector128<ushort> vconvert_128x8u_to_128x16u(Vector128<byte> src, out Vector128<ushort> dst)
            => ref dinx.vconvert(src,out dst);
        
        public static ref Vector128<int> vconvert_128x8u_to_128x32i(Vector128<byte> src, out Vector128<int> dst)
            => ref dinx.vconvert(src, out dst);

        public static ref Vector128<uint> vconvert_128x8u_to_128x32u(Vector128<byte> src, out Vector128<uint> dst)
            => ref dinx.vconvert(src, out dst);

        public static ref Vector128<long> vconvert_128x8u_to_128x64i(Vector128<byte> src, out Vector128<long> dst)
            => ref dinx.vconvert(src, out dst);

        //vpmovzxbq
        public static ref Vector128<ulong> vconvert_128x8u_to_128x64u(Vector128<byte> src, out Vector128<ulong> dst)
            => ref dinx.vconvert(src, out dst);

        //vpmovsxwd 
        public static ref Vector128<int> vconvert_128x16i_to_128x32i(Vector128<short> src, out Vector128<int> dst)
            => ref dinx.vconvert(src, out dst);

        public static ref Vector128<long> vconvert_128x16i_to_128x64i(Vector128<short> src, out Vector128<long> dst)
            => ref dinx.vconvert(src, out dst);

        public static ref Vector128<int> vconvert_128x16u_to_128x32i(Vector128<ushort> src, out Vector128<int> dst)
            => ref dinx.vconvert(src, out dst);

        public static ref Vector128<uint> vconvert_128x16u_to_128x32u(Vector128<ushort> src, out Vector128<uint> dst)
            => ref dinx.vconvert(src, out dst);

        public static ref Vector128<long> vconvert_128x16u_to_128x64i(Vector128<ushort> src, out Vector128<long> dst)
            => ref dinx.vconvert(src, out dst);
            
        public static ref Vector128<ulong> vconvert_128x16u_to_128x64u(Vector128<ushort> src, out Vector128<ulong> dst)
            => ref dinx.vconvert(src, out dst);

        public static ref Vector128<long> vconvert_128x32i_to_128x64i(Vector128<int> src, out Vector128<long> dst)
            => ref dinx.vconvert(src, out dst);

        public static ref Vector128<long> vconvert_128x32u_to_128x64i(Vector128<uint> src, out Vector128<long> dst)
            => ref dinx.vconvert(src, out dst);

        public static ref Vector128<ulong> vconvert_128x32u_to_128x64u(Vector128<uint> src, out Vector128<ulong> dst)
            => ref dinx.vconvert(src, out dst);

        public static ref Vector256<short> vconvert_128x8i_to_256x16i(Vector128<sbyte> src, out Vector256<short> dst)
            => ref dinx.vconvert(src, out dst);

        public static ref Vector256<int> vconvert_128x8i_to_256x32i(Vector128<sbyte> src, out Vector256<int> dst)
            => ref dinx.vconvert(src, out dst);

        public static ref Vector256<long> vconvert_128x8i_to_256x64i(Vector128<sbyte> src, out Vector256<long> dst)
            => ref dinx.vconvert(src, out dst);

        public static ref Vector256<short> vconvert_128x8u_to_256x16i(Vector128<byte> src, out Vector256<short> dst)
            => ref dinx.vconvert(src, out dst);

        public static ref Vector256<ushort> vconvert_128x8u_to_256x16u(Vector128<byte> src, out Vector256<ushort> dst)
            => ref dinx.vconvert(src, out dst);
        
        public static ref Vector256<int> vconvert_128x8u_to_256x32i(Vector128<byte> src, out Vector256<int> dst)            
            => ref dinx.vconvert(src, out dst);

        //vpmovzxbd
        public static ref Vector256<uint> vconvert_128x8u_to_256x32u(Vector128<byte> src, out Vector256<uint> dst)            
            => ref dinx.vconvert(src, out dst);

        public static ref Vector256<long> vconvert_128x8u_to_256x64i(Vector128<byte> src, out Vector256<long> dst)
            => ref dinx.vconvert(src, out dst);
        
        public static ref Vector256<ulong> vconvert_128x8u_to_256x64u(Vector128<byte> src, out Vector256<ulong> dst)
            => ref dinx.vconvert(src, out dst);
        public static ref Vector256<int> vconvert_128x16i_to_256x32i(Vector128<short> src, out Vector256<int> dst)
            => ref dinx.vconvert(src, out dst);

        public static ref Vector256<long> vconvert_128x16i_to_256x64i(Vector128<short> src, out Vector256<long> dst)
            => ref dinx.vconvert(src, out dst);

        public static ref Vector256<int> vconvert_128x16u_to_256x32i(Vector128<ushort> src, out Vector256<int> dst)
            => ref dinx.vconvert(src, out dst);

        public static ref Vector256<uint> vconvert_128x16u_to_256x32u(Vector128<ushort> src, out Vector256<uint> dst)
            => ref dinx.vconvert(src, out dst);

        public static ref Vector256<long> vconvert_128x16u_to_256x64i(Vector128<ushort> src, out Vector256<long> dst)
            => ref dinx.vconvert(src, out dst);

        public static ref Vector256<ulong> vconvert_128x16u_to_256x64u(Vector128<ushort> src, out Vector256<ulong> dst)
            => ref dinx.vconvert(src, out dst);
        
        public static ref Vector256<long> vconvert_128x32i_to_256x64i(Vector128<int> src, out Vector256<long> dst)
            => ref dinx.vconvert(src, out dst);

        public static ref Vector256<long> vconvert_128x32u_to_256x64i(Vector128<uint> src, out Vector256<long> dst)
            => ref dinx.vconvert(src, out dst);

        public static ref Vector256<ulong> vconvert_128x32u_to_256x64u(Vector128<uint> src, out Vector256<ulong> dst)
            => ref dinx.vconvert(src, out dst);

    }
}