//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using static Root;

    partial class vfuncs
    {
        [MethodImpl(Inline)]
        public static ref Vector128<sbyte> vcast8i<T>(in Vector128<T> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector128<T>,Vector128<sbyte>>(ref mutable(in src));

        [MethodImpl(Inline)]
        public static ref Vector128<byte> vcast8u<T>(in Vector128<T> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector128<T>,Vector128<byte>>(ref mutable(in src));

        [MethodImpl(Inline)]
        public static ref Vector128<short> vcast16i<T>(in Vector128<T> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector128<T>,Vector128<short>>(ref mutable(in src));

        [MethodImpl(Inline)]
        public static ref Vector128<ushort> vcast16u<T>(in Vector128<T> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector128<T>,Vector128<ushort>>(ref mutable(in src));

        [MethodImpl(Inline)]
        public static ref  Vector128<int> vcast32i<T>(in Vector128<T> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector128<T>,Vector128<int>>(ref mutable(in src));

        [MethodImpl(Inline)]
        public static ref Vector128<uint> vcast32u<T>(in Vector128<T> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector128<T>,Vector128<uint>>(ref mutable(in src));

        [MethodImpl(Inline)]
        public static ref Vector128<long> vcast64i<T>(in Vector128<T> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector128<T>,Vector128<long>>(ref mutable(in src));

        [MethodImpl(Inline)]
        public static ref Vector128<ulong> vcast64u<T>(in Vector128<T> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector128<T>,Vector128<ulong>>(ref mutable(in src));

        [MethodImpl(Inline)]
        public static ref Vector128<double> vcast64f<T>(in Vector128<T> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector128<T>,Vector128<double>>(ref mutable(in src));

        [MethodImpl(Inline)]
        public static ref Vector128<float> vcast32f<T>(in Vector128<T> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector128<T>,Vector128<float>>(ref mutable(in src));

        [MethodImpl(Inline)]
        public static ref Vector256<sbyte> vcast8i<T>(in Vector256<T> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector256<T>,Vector256<sbyte>>(ref mutable(in src));

        [MethodImpl(Inline)]
        public static ref Vector256<byte> vcast8u<T>(in Vector256<T> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector256<T>,Vector256<byte>>(ref mutable(in src));

        [MethodImpl(Inline)]
        public static ref Vector256<short> vcast16i<T>(in Vector256<T> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector256<T>,Vector256<short>>(ref mutable(in src));

        [MethodImpl(Inline)]
        public static ref Vector256<ushort> vcast16u<T>(in Vector256<T> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector256<T>,Vector256<ushort>>(ref mutable(in src));

        [MethodImpl(Inline)]
        public static ref  Vector256<int> vcast32i<T>(in Vector256<T> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector256<T>,Vector256<int>>(ref mutable(in src));

        [MethodImpl(Inline)]
        public static ref Vector256<uint> vcast32u<T>(in Vector256<T> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector256<T>,Vector256<uint>>(ref mutable(in src));

        [MethodImpl(Inline)]
        public static ref Vector256<long> vcast64i<T>(in Vector256<T> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector256<T>,Vector256<long>>(ref mutable(in src));

        [MethodImpl(Inline)]
        public static ref Vector256<ulong> vcast64u<T>(in Vector256<T> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector256<T>,Vector256<ulong>>(ref mutable(in src));

        [MethodImpl(Inline)]
        public static ref Vector256<float> vcast32f<T>(in Vector256<T> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector256<T>,Vector256<float>>(ref mutable(in src));

        [MethodImpl(Inline)]
        public static ref Vector256<double> vcast64f<T>(in Vector256<T> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector256<T>,Vector256<double>>(ref mutable(in src));

        [MethodImpl(Inline)]
        public static ref Vector512<sbyte> vcast8i<T>(in Vector512<T> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector512<T>,Vector512<sbyte>>(ref mutable(in src));

        [MethodImpl(Inline)]
        public static ref Vector512<byte> vcast8u<T>(in Vector512<T> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector512<T>,Vector512<byte>>(ref mutable(in src));

        [MethodImpl(Inline)]
        public static ref Vector512<short> vcast16i<T>(in Vector512<T> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector512<T>,Vector512<short>>(ref mutable(in src));

        [MethodImpl(Inline)]
        public static ref Vector512<ushort> vcast16u<T>(in Vector512<T> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector512<T>,Vector512<ushort>>(ref mutable(in src));

        [MethodImpl(Inline)]
        public static ref  Vector512<int> vcast32i<T>(in Vector512<T> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector512<T>,Vector512<int>>(ref mutable(in src));

        [MethodImpl(Inline)]
        public static ref Vector512<uint> vcast32u<T>(in Vector512<T> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector512<T>,Vector512<uint>>(ref mutable(in src));

        [MethodImpl(Inline)]
        public static ref Vector512<long> vcast64i<T>(in Vector512<T> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector512<T>,Vector512<long>>(ref mutable(in src));

        [MethodImpl(Inline)]
        public static ref Vector512<ulong> vcast64u<T>(in Vector512<T> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector512<T>,Vector512<ulong>>(ref mutable(in src));

        [MethodImpl(Inline)]
        public static ref Vector512<float> vcast32f<T>(in Vector512<T> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector512<T>,Vector512<float>>(ref mutable(in src));

        [MethodImpl(Inline)]
        public static ref Vector512<double> vcast64f<T>(in Vector512<T> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector512<T>,Vector512<double>>(ref mutable(in src));
    }
}