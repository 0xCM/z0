//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;

    using static System.Runtime.CompilerServices.Unsafe;

    partial struct As
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Vector128<sbyte> vcast<T>(in Vector128<T> src, NK<sbyte> dst)
            where T : unmanaged        
                => ref As<Vector128<T>,Vector128<sbyte>>(ref edit(in src));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Vector128<byte> vcast<T>(in Vector128<T> src, NK<byte> dst)
            where T : unmanaged        
                => ref As<Vector128<T>,Vector128<byte>>(ref edit(in src));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Vector128<short> vcast<T>(in Vector128<T> src, NK<short> dst)
            where T : unmanaged        
                => ref As<Vector128<T>,Vector128<short>>(ref edit(in src));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Vector128<ushort> vcast<T>(in Vector128<T> src, NK<ushort> dst)
            where T : unmanaged        
                => ref As<Vector128<T>,Vector128<ushort>>(ref edit(in src));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref  Vector128<int> vcast<T>(in Vector128<T> src, NK<int> dst)
            where T : unmanaged        
                => ref As<Vector128<T>,Vector128<int>>(ref edit(in src));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Vector128<uint> vcast<T>(in Vector128<T> src, NK<uint> dst)
            where T : unmanaged        
                => ref As<Vector128<T>,Vector128<uint>>(ref edit(in src));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Vector128<long> vcast<T>(in Vector128<T> src, NK<long> dst)
            where T : unmanaged        
                => ref As<Vector128<T>,Vector128<long>>(ref edit(in src));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Vector128<ulong> vcast<T>(in Vector128<T> src, NK<ulong> dst)
            where T : unmanaged        
                => ref As<Vector128<T>,Vector128<ulong>>(ref edit(in src));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Vector128<double> vcast<T>(in Vector128<T> src, NK<double> dst)
            where T : unmanaged        
                => ref As<Vector128<T>,Vector128<double>>(ref edit(in src));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Vector128<float> vcast<T>(in Vector128<T> src, NK<float> dst)
            where T : unmanaged        
                => ref As<Vector128<T>,Vector128<float>>(ref edit(in src));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Vector256<sbyte> vcast<T>(in Vector256<T> src, NK<sbyte> dst)
            where T : unmanaged        
                => ref As<Vector256<T>,Vector256<sbyte>>(ref edit(in src));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Vector256<byte> vcast<T>(in Vector256<T> src, NK<byte> dst)
            where T : unmanaged        
                => ref As<Vector256<T>,Vector256<byte>>(ref edit(in src));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Vector256<short> vcast<T>(in Vector256<T> src, NK<short> dst)
            where T : unmanaged        
                => ref As<Vector256<T>,Vector256<short>>(ref edit(in src));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Vector256<ushort> vcast<T>(in Vector256<T> src, NK<ushort> dst)
            where T : unmanaged        
                => ref As<Vector256<T>,Vector256<ushort>>(ref edit(in src));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref  Vector256<int> vcast<T>(in Vector256<T> src, NK<int> dst)
            where T : unmanaged        
                => ref As<Vector256<T>,Vector256<int>>(ref edit(in src));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Vector256<uint> vcast<T>(in Vector256<T> src, NK<uint> dst)
            where T : unmanaged        
                => ref As<Vector256<T>,Vector256<uint>>(ref edit(in src));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Vector256<long> vcast<T>(in Vector256<T> src, NK<long> dst)
            where T : unmanaged        
                => ref As<Vector256<T>,Vector256<long>>(ref edit(in src));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Vector256<ulong> vcast<T>(in Vector256<T> src, NK<ulong> dst)
            where T : unmanaged        
                => ref As<Vector256<T>,Vector256<ulong>>(ref edit(in src));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Vector256<float> vcast<T>(in Vector256<T> src, NK<float> dst)
            where T : unmanaged        
                => ref As<Vector256<T>,Vector256<float>>(ref edit(in src));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Vector256<double> vcast<T>(in Vector256<T> src, NK<double> dst)
            where T : unmanaged        
                => ref As<Vector256<T>,Vector256<double>>(ref edit(in src));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Vector512<sbyte> vcast<T>(in Vector512<T> src, NK<sbyte> dst)
            where T : unmanaged        
                => ref As<Vector512<T>,Vector512<sbyte>>(ref edit(in src));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Vector512<byte> vcast<T>(in Vector512<T> src, NK<byte> dst)
            where T : unmanaged        
                => ref As<Vector512<T>,Vector512<byte>>(ref edit(in src));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Vector512<short> vcast<T>(in Vector512<T> src, NK<short> dst)
            where T : unmanaged        
                => ref As<Vector512<T>,Vector512<short>>(ref edit(in src));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Vector512<ushort> vcast<T>(in Vector512<T> src, NK<ushort> dst)
            where T : unmanaged        
                => ref As<Vector512<T>,Vector512<ushort>>(ref edit(in src));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref  Vector512<int> vcast<T>(in Vector512<T> src, NK<int> dst)
            where T : unmanaged        
                => ref As<Vector512<T>,Vector512<int>>(ref edit(in src));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Vector512<uint> vcast<T>(in Vector512<T> src, NK<uint> dst)
            where T : unmanaged        
                => ref As<Vector512<T>,Vector512<uint>>(ref edit(in src));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Vector512<long> vcast<T>(in Vector512<T> src, NK<long> dst)
            where T : unmanaged        
                => ref As<Vector512<T>,Vector512<long>>(ref edit(in src));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Vector512<ulong> vcast<T>(in Vector512<T> src, NK<ulong> dst)
            where T : unmanaged        
                => ref As<Vector512<T>,Vector512<ulong>>(ref edit(in src));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Vector512<float> vcast<T>(in Vector512<T> src, NK<float> dst)
            where T : unmanaged        
                => ref As<Vector512<T>,Vector512<float>>(ref edit(in src));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Vector512<double> vcast<T>(in Vector512<T> src, NK<double> dst)
            where T : unmanaged        
                => ref As<Vector512<T>,Vector512<double>>(ref edit(in src));
    }
}