//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using System.Security;
    
    using static zfunc;

    partial class As
    {



        [MethodImpl(Inline)]
        public static ref Vector128<sbyte> int8<T>(in Vector128<T> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector128<T>,Vector128<sbyte>>(ref mutable(in src));

        [MethodImpl(Inline)]
        public static ref Vector128<byte> uint8<T>(in Vector128<T> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector128<T>,Vector128<byte>>(ref mutable(in src));

        [MethodImpl(Inline)]
        public static ref Vector128<short> int16<T>(in Vector128<T> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector128<T>,Vector128<short>>(ref mutable(in src));

        [MethodImpl(Inline)]
        public static ref Vector128<ushort> uint16<T>(in Vector128<T> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector128<T>,Vector128<ushort>>(ref mutable(in src));

        [MethodImpl(Inline)]
        public static ref  Vector128<int> int32<T>(in Vector128<T> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector128<T>,Vector128<int>>(ref mutable(in src));

        [MethodImpl(Inline)]
        public static ref Vector128<uint> uint32<T>(in Vector128<T> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector128<T>,Vector128<uint>>(ref mutable(in src));

        [MethodImpl(Inline)]
        public static ref Vector128<long> int64<T>(in Vector128<T> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector128<T>,Vector128<long>>(ref mutable(in src));

        [MethodImpl(Inline)]
        public static ref Vector128<ulong> uint64<T>(in Vector128<T> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector128<T>,Vector128<ulong>>(ref mutable(in src));


        [MethodImpl(Inline)]
        public static ref Vector128<double> float64<T>(in Vector128<T> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector128<T>,Vector128<double>>(ref mutable(in src));

        [MethodImpl(Inline)]
        public static ref Vector128<float> float32<T>(in Vector128<T> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector128<T>,Vector128<float>>(ref mutable(in src));



        [MethodImpl(Inline)]
        public static ref Vector128<T> generic<T>(in Vector128<sbyte> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector128<sbyte>,Vector128<T>>(ref mutable(in src));

        [MethodImpl(Inline)]
        public static ref Vector128<T> generic<T>(in Vector128<byte> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector128<byte>,Vector128<T>>(ref mutable(in src));

        [MethodImpl(Inline)]
        public static ref Vector128<T> generic<T>(in Vector128<short> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector128<short>,Vector128<T>>(ref mutable(in src));

        [MethodImpl(Inline)]
        public static ref Vector128<T> generic<T>(in Vector128<ushort> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector128<ushort>,Vector128<T>>(ref mutable(in src));

        [MethodImpl(Inline)]
        public static ref Vector128<T> generic<T>(in Vector128<int> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector128<int>,Vector128<T>>(ref mutable(in src));

        [MethodImpl(Inline)]
        public static ref Vector128<T> generic<T>(in Vector128<uint> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector128<uint>,Vector128<T>>(ref mutable(in src));

        [MethodImpl(Inline)]
        public static ref Vector128<T> generic<T>(in Vector128<long> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector128<long>,Vector128<T>>(ref mutable(in src));

        [MethodImpl(Inline)]
        public static ref Vector128<T> generic<T>(in Vector128<ulong> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector128<ulong>,Vector128<T>>(ref mutable(in src));

        [MethodImpl(Inline)]
        public static ref Vector128<T> generic<T>(in Vector128<float> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector128<float>,Vector128<T>>(ref mutable(in src));

        [MethodImpl(Inline)]
        public static ref Vector128<T> generic<T>(in Vector128<double> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector128<double>,Vector128<T>>(ref mutable(in src));



        [MethodImpl(Inline)]
        public static ref Vector256<sbyte> int8<T>(in Vector256<T> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector256<T>,Vector256<sbyte>>(ref mutable(in src));
                
        [MethodImpl(Inline)]
        public static ref Vector256<byte> uint8<T>(in Vector256<T> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector256<T>,Vector256<byte>>(ref mutable(in src));

        [MethodImpl(Inline)]
        public static ref Vector256<short> int16<T>(in Vector256<T> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector256<T>,Vector256<short>>(ref mutable(in src));

        [MethodImpl(Inline)]
        public static ref Vector256<ushort> uint16<T>(in Vector256<T> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector256<T>,Vector256<ushort>>(ref mutable(in src));

        [MethodImpl(Inline)]
        public static ref  Vector256<int> int32<T>(in Vector256<T> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector256<T>,Vector256<int>>(ref mutable(in src));

        [MethodImpl(Inline)]
        public static ref Vector256<uint> uint32<T>(in Vector256<T> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector256<T>,Vector256<uint>>(ref mutable(in src));

        [MethodImpl(Inline)]
        public static ref Vector256<long> int64<T>(in Vector256<T> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector256<T>,Vector256<long>>(ref mutable(in src));

        [MethodImpl(Inline)]
        public static ref Vector256<ulong> uint64<T>(in Vector256<T> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector256<T>,Vector256<ulong>>(ref mutable(in src));

        [MethodImpl(Inline)]
        public static ref Vector256<float> float32<T>(in Vector256<T> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector256<T>,Vector256<float>>(ref mutable(in src));

        [MethodImpl(Inline)]
        public static ref Vector256<double> float64<T>(in Vector256<T> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector256<T>,Vector256<double>>(ref mutable(in src));

        [MethodImpl(Inline)]
        public static ref Vector256<T> generic<T>(in Vector256<sbyte> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector256<sbyte>,Vector256<T>>(ref mutable(in src));

        [MethodImpl(Inline)]
        public static ref Vector256<T> generic<T>(in Vector256<byte> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector256<byte>,Vector256<T>>(ref mutable(in src));

        [MethodImpl(Inline)]
        public static ref Vector256<T> generic<T>(in Vector256<short> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector256<short>,Vector256<T>>(ref mutable(in src));

        [MethodImpl(Inline)]
        public static ref Vector256<T> generic<T>(in Vector256<ushort> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector256<ushort>,Vector256<T>>(ref mutable(in src));

        [MethodImpl(Inline)]
        public static ref Vector256<T> generic<T>(in Vector256<int> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector256<int>,Vector256<T>>(ref mutable(in src));

        [MethodImpl(Inline)]
        public static ref Vector256<T> generic<T>(in Vector256<uint> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector256<uint>,Vector256<T>>(ref mutable(in src));

        [MethodImpl(Inline)]
        public static ref Vector256<T> generic<T>(in Vector256<long> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector256<long>,Vector256<T>>(ref mutable(in src));

        [MethodImpl(Inline)]
        public static ref Vector256<T> generic<T>(in Vector256<ulong> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector256<ulong>,Vector256<T>>(ref mutable(in src));

        [MethodImpl(Inline)]
        public static ref Vector256<T> generic<T>(in Vector256<float> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector256<float>,Vector256<T>>(ref mutable(in src));

        [MethodImpl(Inline)]
        public static ref Vector256<T> generic<T>(in Vector256<double> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector256<double>,Vector256<T>>(ref mutable(in src));


        [MethodImpl(Inline)]
        public static Vector256<T> vgeneric<T>(Vector256<long> src)
            where T : unmanaged        
                => Unsafe.As<Vector256<long>,Vector256<T>>(ref src);

        [MethodImpl(Inline)]
        public static Vector256<T> vgeneric<T>(Vector256<ulong> src)
            where T : unmanaged        
                => Unsafe.As<Vector256<ulong>,Vector256<T>>(ref src);


        [MethodImpl(Inline)]
        public static Vector256<T> vgeneric<T>(Vector256<float> src)
            where T : unmanaged        
                => Unsafe.As<Vector256<float>,Vector256<T>>(ref src);

        [MethodImpl(Inline)]
        public static Vector256<T> vgeneric<T>(Vector256<double> src)
            where T : unmanaged        
                => Unsafe.As<Vector256<double>,Vector256<T>>(ref src);


        [MethodImpl(Inline)]
        public static Vector128<T> vgeneric<T>(Vector128<byte> src)
            where T : unmanaged        
                => Unsafe.As<Vector128<byte>,Vector128<T>>(ref src);

        [MethodImpl(Inline)]
        public static Vector128<T> vgeneric<T>(Vector128<sbyte> src)
            where T : unmanaged        
                => Unsafe.As<Vector128<sbyte>,Vector128<T>>(ref src);

        [MethodImpl(Inline)]
        public static Vector128<T> vgeneric<T>(Vector128<short> src)
            where T : unmanaged        
                => Unsafe.As<Vector128<short>,Vector128<T>>(ref src);

        [MethodImpl(Inline)]
        public static Vector128<T> vgeneric<T>(Vector128<ushort> src)
            where T : unmanaged        
                => Unsafe.As<Vector128<ushort>,Vector128<T>>(ref src);

        [MethodImpl(Inline)]
        public static Vector128<T> vgeneric<T>(Vector128<int> src)
            where T : unmanaged        
                => Unsafe.As<Vector128<int>,Vector128<T>>(ref src);


        [MethodImpl(Inline)]
        public static Vector128<T> vgeneric<T>(Vector128<uint> src)
            where T : unmanaged        
                => Unsafe.As<Vector128<uint>,Vector128<T>>(ref src);


        [MethodImpl(Inline)]
        public static Vector128<T> vgeneric<T>(Vector128<long> src)
            where T : unmanaged        
                => Unsafe.As<Vector128<long>,Vector128<T>>(ref src);

        [MethodImpl(Inline)]
        public static Vector128<T> vgeneric<T>(Vector128<ulong> src)
            where T : unmanaged        
                => Unsafe.As<Vector128<ulong>,Vector128<T>>(ref src);


        [MethodImpl(Inline)]
        public static Vector128<T> vgeneric<T>(Vector128<float> src)
            where T : unmanaged        
                => Unsafe.As<Vector128<float>,Vector128<T>>(ref src);

        [MethodImpl(Inline)]
        public static Vector128<T> vgeneric<T>(Vector128<double> src)
            where T : unmanaged        
                => Unsafe.As<Vector128<double>,Vector128<T>>(ref src);


        [MethodImpl(Inline)]
        public static ref Vec256<T> generic<T>(in Vec256<float> src)
            where T : unmanaged        
                => ref Unsafe.As<Vec256<float>,Vec256<T>>(ref mutable(in src));

        [MethodImpl(Inline)]
        public static ref Vec256<T> generic<T>(in Vec256<double> src)
            where T : unmanaged        
                => ref Unsafe.As<Vec256<double>,Vec256<T>>(ref mutable(in src));

        [MethodImpl(Inline)]
        public static ref Vec128<T> generic<T>(in Vec128<float> src)
            where T : unmanaged        
                => ref Unsafe.As<Vec128<float>,Vec128<T>>(ref mutable(in src));

        [MethodImpl(Inline)]
        public static ref Vec128<T> generic<T>(in Vec128<double> src)
            where T : unmanaged        
                => ref Unsafe.As<Vec128<double>,Vec128<T>>(ref mutable(in src));

    }

}