//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;

    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Ssse3;
    using static System.Runtime.Intrinsics.X86.Avx2;
    
    using static Konst; 
    using static Memories;

    partial class dvec
    {
        [MethodImpl(Inline), Op]
        public static Vector128<sbyte> vshuf2x64(Vector128<sbyte> src, [Imm] byte spec)            
            => v8i(Shuffle(v32u(src), (byte)spec));

        [MethodImpl(Inline), Op]
        public static Vector128<byte> vshuf2x64(Vector128<byte> src, [Imm] byte spec)            
            => v8u(Shuffle(v32u(src), (byte)spec));

        [MethodImpl(Inline), Op]
        public static Vector128<short> vshuf2x64(Vector128<short> src, [Imm] byte spec)            
            => v16i(Shuffle(v32u(src), (byte)spec));

        [MethodImpl(Inline), Op]
        public static Vector128<ushort> vshuf2x64(Vector128<ushort> src, [Imm] byte spec)            
            => v16u(Shuffle(v32u(src), (byte)spec));

        [MethodImpl(Inline), Op]
        public static Vector128<int> vshuf2x64(Vector128<int> src, [Imm] byte spec)            
            => Shuffle(src, (byte)spec);

        [MethodImpl(Inline), Op]
        public static Vector128<uint> vshuf2x64(Vector128<uint> src, [Imm] byte spec)            
            => Shuffle(src, (byte)spec);

        [MethodImpl(Inline), Op]
        public static Vector128<ulong> vshuf2x64(Vector128<ulong> src, [Imm] byte spec)            
            => v64u(Shuffle(v32u(src), (byte)spec));

        [MethodImpl(Inline), Op]
        public static Vector128<long> vshuf2x64(Vector128<long> src, [Imm] byte spec)            
            => v64i(Shuffle(v32i(src), (byte)spec));

        [MethodImpl(Inline), Op]
        public static Vector128<double> vshuf2x64(Vector128<double> src, [Imm] byte spec)            
            => v64f(Shuffle(v32u(src), (byte)spec));

        [MethodImpl(Inline), Op]
        public static Vector128<sbyte> vshuf2x64(Vector128<sbyte> src, [Imm] Arrange2L spec)            
            => vshuf2x64(src,(byte)spec);

        [MethodImpl(Inline), Op]
        public static Vector128<byte> vshuf2x64(Vector128<byte> src, [Imm] Arrange2L spec)            
            => vshuf2x64(src,(byte)spec);

        [MethodImpl(Inline), Op]
        public static Vector128<short> vshuf2x64(Vector128<short> src, [Imm] Arrange2L spec)            
            => vshuf2x64(src,(byte)spec);

        [MethodImpl(Inline), Op]
        public static Vector128<ushort> vshuf2x64(Vector128<ushort> src, [Imm] Arrange2L spec)            
            => vshuf2x64(src,(byte)spec);

        [MethodImpl(Inline), Op]
        public static Vector128<int> vshuf2x64(Vector128<int> src, [Imm] Arrange2L spec)            
            => vshuf2x64(src,(byte)spec);

        [MethodImpl(Inline), Op]
        public static Vector128<uint> vshuf2x64(Vector128<uint> src, [Imm] Arrange2L spec)            
            => vshuf2x64(src,(byte)spec);

        [MethodImpl(Inline), Op]
        public static Vector128<ulong> vshuf2x64(Vector128<ulong> src, [Imm] Arrange2L spec)            
            => vshuf2x64(src,(byte)spec);

        [MethodImpl(Inline), Op]
        public static Vector128<long> vshuf2x64(Vector128<long> src, [Imm] Arrange2L spec)            
            => vshuf2x64(src,(byte)spec);

        [MethodImpl(Inline), Op]
        public static Vector128<double> vshuf2x64(Vector128<double> src, [Imm] Arrange2L spec)            
            => vshuf2x64(src,(byte)spec);
    }
}