//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static zfunc;    
    using static As;
    
    partial class dinx
    {

        [MethodImpl(Inline)]
        public static Vector128<byte> vzero(N128 v, N8 n)
            => default;

        [MethodImpl(Inline)]
        public static Vector128<ushort> vzero(N128 v, N16 n)
            => default;

        [MethodImpl(Inline)]
        public static Vector128<uint> vzero(N128 v, N32 n)
            => default;

        [MethodImpl(Inline)]
        public static Vector128<ulong> vzero(N128 v, N64 n)
            => default;

        [MethodImpl(Inline)]
        public static Vector128<sbyte> vzeroi(N128 v, N8 n)
            => default;

        [MethodImpl(Inline)]
        public static Vector128<short> vzeroi(N128 v, N16 n)
            => default;

        [MethodImpl(Inline)]
        public static Vector128<int> vzeroi(N128 v, N32 n)
            => default;

        [MethodImpl(Inline)]
        public static Vector128<long> vzeroi(N128 v, N64 n)
            => default;

        [MethodImpl(Inline)]
        public static Vector128<float> vzerof(N128 v, N32 n)
            => default;

        [MethodImpl(Inline)]
        public static Vector128<double> vzerof(N128 v, N64 n)
            => default;

         [MethodImpl(Inline)]
        public static Vector256<byte> vzero(N256 v, N8 n)
            => default;

        [MethodImpl(Inline)]
        public static Vector256<ushort> vzero(N256 v, N16 n)
            => default;

        [MethodImpl(Inline)]
        public static Vector256<uint> vzero(N256 v, N32 n)
            => default;

        [MethodImpl(Inline)]
        public static Vector256<ulong> vzero(N256 v, N64 n)
            => default;

        [MethodImpl(Inline)]
        public static Vector256<sbyte> vzeroi(N256 v, N8 n)
            => default;

        [MethodImpl(Inline)]
        public static Vector256<short> vzeroi(N256 v, N16 n)
            => default;

        [MethodImpl(Inline)]
        public static Vector256<int> vzeroi(N256 v, N32 n)
            => default;

        [MethodImpl(Inline)]
        public static Vector256<long> vzeroi(N256 v, N64 n)
            => default;

        [MethodImpl(Inline)]
        public static Vector256<float> vzerof(N256 v, N32 n)
            => default;

        [MethodImpl(Inline)]
        public static Vector256<double> vzerof(N256 v, N64 n)
            => default;


    }

}