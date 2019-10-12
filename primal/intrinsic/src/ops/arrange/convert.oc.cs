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

    partial class inxvoc
    {
        //vpmovsxbw
        public static ref Vec128<short> vconvert_128x8i_to_128x16i(in Vec128<sbyte> src, out Vec128<short> dst)        
            => ref dinx.vconvert(src, out dst);

        //vpmovsxbd
        public static ref Vec128<int> vconvert_128x8i_to_128x32i(in Vec128<sbyte> src, out Vec128<int> dst)        
            => ref dinx.vconvert(src, out dst);

        //vpmovsxbq
        public static ref Vec128<long> vconvert_128x8i_to_128x64i(in Vec128<sbyte> src, out Vec128<long> dst)        
            => ref dinx.vconvert(src, out dst);

        //vpmovzxbw
        public static ref Vec128<short> vconvert_128x8u_to_128x16i(in Vec128<byte> src, out Vec128<short> dst)
            => ref dinx.vconvert(src,out dst);

        //vpmovzxbw
        public static ref Vec128<ushort> vconvert_128x8u_to_128x16u(in Vec128<byte> src, out Vec128<ushort> dst)
            => ref dinx.vconvert(src,out dst);
        
        public static ref Vec128<int> vconvert_128x8u_to_128x32i(in Vec128<byte> src, out Vec128<int> dst)
            => ref dinx.vconvert(src, out dst);

        public static ref Vec128<uint> vconvert_128x8u_to_128x32u(in Vec128<byte> src, out Vec128<uint> dst)
            => ref dinx.vconvert(src, out dst);

        public static ref Vec128<long> vconvert_128x8u_to_128x64i(in Vec128<byte> src, out Vec128<long> dst)
            => ref dinx.vconvert(src, out dst);

        //vpmovzxbq
        public static ref Vec128<ulong> vconvert_128x8u_to_128x64u(in Vec128<byte> src, out Vec128<ulong> dst)
            => ref dinx.vconvert(src, out dst);

        //vpmovsxwd 
        public static ref Vec128<int> vconvert_128x16i_to_128x32i(in Vec128<short> src, out Vec128<int> dst)
            => ref dinx.vconvert(src, out dst);

        public static ref Vec128<long> vconvert_128x16i_to_128x64i(in Vec128<short> src, out Vec128<long> dst)
            => ref dinx.vconvert(src, out dst);

        public static ref Vec128<int> vconvert_128x16u_to_128x32i(in Vec128<ushort> src, out Vec128<int> dst)
            => ref dinx.vconvert(src, out dst);

        public static ref Vec128<uint> vconvert_128x16u_to_128x32u(in Vec128<ushort> src, out Vec128<uint> dst)
            => ref dinx.vconvert(src, out dst);

        public static ref Vec128<long> vconvert_128x16u_to_128x64i(in Vec128<ushort> src, out Vec128<long> dst)
            => ref dinx.vconvert(src, out dst);
            
        public static ref Vec128<ulong> vconvert_128x16u_to_128x64u(in Vec128<ushort> src, out Vec128<ulong> dst)
            => ref dinx.vconvert(src, out dst);

        public static ref Vec128<long> vconvert_128x32i_to_128x64i(in Vec128<int> src, out Vec128<long> dst)
            => ref dinx.vconvert(src, out dst);

        public static ref Vec128<long> vconvert_128x32u_to_128x64i(in Vec128<uint> src, out Vec128<long> dst)
            => ref dinx.vconvert(src, out dst);

        public static ref Vec128<ulong> vconvert_128x32u_to_128x64u(in Vec128<uint> src, out Vec128<ulong> dst)
            => ref dinx.vconvert(src, out dst);

        public static ref Vec256<short> vconvert_128x8i_to_256x16i(in Vec128<sbyte> src, out Vec256<short> dst)
            => ref dinx.vconvert(src, out dst);

        public static ref Vec256<int> vconvert_128x8i_to_256x32i(in Vec128<sbyte> src, out Vec256<int> dst)
            => ref dinx.vconvert(src, out dst);

        public static ref Vec256<long> vconvert_128x8i_to_256x64i(in Vec128<sbyte> src, out Vec256<long> dst)
            => ref dinx.vconvert(src, out dst);

        public static ref Vec256<short> vconvert_128x8u_to_256x16i(in Vec128<byte> src, out Vec256<short> dst)
            => ref dinx.vconvert(src, out dst);

        public static ref Vec256<ushort> vconvert_128x8u_to_256x16u(in Vec128<byte> src, out Vec256<ushort> dst)
            => ref dinx.vconvert(src, out dst);
        
        public static ref Vec256<int> vconvert_128x8u_to_256x32i(in Vec128<byte> src, out Vec256<int> dst)            
            => ref dinx.vconvert(src, out dst);

        //vpmovzxbd
        public static ref Vec256<uint> vconvert_128x8u_to_256x32u(in Vec128<byte> src, out Vec256<uint> dst)            
            => ref dinx.vconvert(src, out dst);

        public static ref Vec256<long> vconvert_128x8u_to_256x64i(in Vec128<byte> src, out Vec256<long> dst)
            => ref dinx.vconvert(src, out dst);
        
        public static ref Vec256<ulong> vconvert_128x8u_to_256x64u(in Vec128<byte> src, out Vec256<ulong> dst)
            => ref dinx.vconvert(src, out dst);
        public static ref Vec256<int> vconvert_128x16i_to_256x32i(in Vec128<short> src, out Vec256<int> dst)
            => ref dinx.vconvert(src, out dst);

        public static ref Vec256<long> vconvert_128x16i_to_256x64i(in Vec128<short> src, out Vec256<long> dst)
            => ref dinx.vconvert(src, out dst);

        public static ref Vec256<int> vconvert_128x16u_to_256x32i(in Vec128<ushort> src, out Vec256<int> dst)
            => ref dinx.vconvert(src, out dst);

        public static ref Vec256<uint> vconvert_128x16u_to_256x32u(in Vec128<ushort> src, out Vec256<uint> dst)
            => ref dinx.vconvert(src, out dst);

        public static ref Vec256<long> vconvert_128x16u_to_256x64i(in Vec128<ushort> src, out Vec256<long> dst)
            => ref dinx.vconvert(src, out dst);

        public static ref Vec256<ulong> vconvert_128x16u_to_256x64u(in Vec128<ushort> src, out Vec256<ulong> dst)
            => ref dinx.vconvert(src, out dst);
        
        public static ref Vec256<long> vconvert_128x32i_to_256x64i(in Vec128<int> src, out Vec256<long> dst)
            => ref dinx.vconvert(src, out dst);

        public static ref Vec256<long> vconvert_128x32u_to_256x64i(in Vec128<uint> src, out Vec256<long> dst)
            => ref dinx.vconvert(src, out dst);

        public static ref Vec256<ulong> vconvert_128x32u_to_256x64u(in Vec128<uint> src, out Vec256<ulong> dst)
            => ref dinx.vconvert(src, out dst);

    }
}