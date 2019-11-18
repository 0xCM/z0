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

    public static partial class As
    {
        
        [MethodImpl(Inline)]
        public static unsafe sbyte* refptr(ref sbyte src)
            => (sbyte*)pvoid(ref src);

        [MethodImpl(Inline)]
        public static unsafe byte* refptr(ref byte src)
            => (byte*)pvoid(ref src);

        [MethodImpl(Inline)]
        public static unsafe short* refptr(ref short src)
            => (short*)pvoid(ref src);

        [MethodImpl(Inline)]
        public static unsafe ushort* refptr(ref ushort src)
            => (ushort*)pvoid(ref src);

        [MethodImpl(Inline)]
        public static unsafe int* refptr(ref int src)
            => (int*)pvoid(ref src);

        [MethodImpl(Inline)]
        public static unsafe uint* refptr(ref uint src)
            => (uint*)pvoid(ref src);

        [MethodImpl(Inline)]
        public static unsafe long* refptr(ref long src)
            => (long*)pvoid(ref src);

        [MethodImpl(Inline)]
        public static unsafe ulong* refptr(ref ulong src)
            => (ulong*)pvoid(ref src);

        [MethodImpl(Inline)]
        public static unsafe float* refptr(ref float src)
            => (float*)pvoid(ref src);

        [MethodImpl(Inline)]
        public static unsafe double* refptr(ref double src)
            => (double*)pvoid(ref src);

        [MethodImpl(Inline)]
        public static unsafe sbyte* refptr(ref sbyte src, int offset)
            => (sbyte*)pvoid(ref seek(ref src, offset));

        [MethodImpl(Inline)]
        public static unsafe byte* refptr(ref byte src, int offset)
            => (byte*)pvoid(ref seek(ref src, offset));

        [MethodImpl(Inline)]
        public static unsafe short* refptr(ref short src, int offset)
            => (short*)pvoid(ref seek(ref src, offset));

        [MethodImpl(Inline)]
        public static unsafe ushort* refptr(ref ushort src, int offset)
            => (ushort*)pvoid(ref seek(ref src, offset));

        [MethodImpl(Inline)]
        public static unsafe int* refptr(ref int src, int offset)
            => (int*)pvoid(ref seek(ref src, offset));

        [MethodImpl(Inline)]
        public static unsafe uint* refptr(ref uint src, int offset)
            => (uint*)pvoid(ref seek(ref src, offset));

        [MethodImpl(Inline)]
        public static unsafe long* refptr(ref long src, int offset)
            => (long*)pvoid(ref seek(ref src, offset));

        [MethodImpl(Inline)]
        public static unsafe ulong* refptr(ref ulong src, int offset)
            => (ulong*)pvoid(ref seek(ref src, offset));

        [MethodImpl(Inline)]
        public static unsafe float* refptr(ref float src, int offset)
            => (float*)pvoid(ref seek(ref src, offset));

        [MethodImpl(Inline)]
        public static unsafe double* refptr(ref double src, int offset)
            => (double*)pvoid(ref seek(ref src, offset));

        [MethodImpl(Inline)]
        public static unsafe sbyte* constptr(in sbyte src)
            => refptr(ref mutable(in src));

        [MethodImpl(Inline)]
        public static unsafe byte* constptr(in byte src)
            => refptr(ref mutable(in src));

        [MethodImpl(Inline)]
        public static unsafe short* constptr(in short src)
            => refptr(ref mutable(in src));

        [MethodImpl(Inline)]
        public static unsafe ushort* constptr(in ushort src)
            => refptr(ref mutable(in src));

        [MethodImpl(Inline)]
        public static unsafe int* constptr(in int src)
            => refptr(ref mutable(in src));

        [MethodImpl(Inline)]
        public static unsafe uint* constptr(in uint src)
            => refptr(ref mutable(in src));

        [MethodImpl(Inline)]
        public static unsafe long* constptr(in long src)
            => refptr(ref mutable(in src));

        [MethodImpl(Inline)]
        public static unsafe ulong* constptr(in ulong src)
            => refptr(ref mutable(in src));

        [MethodImpl(Inline)]
        public static unsafe float* constptr(in float src)
            => refptr(ref mutable(in src));

        [MethodImpl(Inline)]
        public static unsafe double* constptr(in double src)
            => refptr(ref mutable(in src));

        [MethodImpl(Inline)]
        public static unsafe sbyte* constptr(in sbyte src, int offset)
            => refptr(ref seek(ref mutable(in src), offset));

        [MethodImpl(Inline)]
        public static unsafe byte* constptr(in byte src, int offset)
            => refptr(ref seek(ref mutable(in src), offset));

        [MethodImpl(Inline)]
        public static unsafe short* constptr(in short src, int offset)
            => refptr(ref seek(ref mutable(in src), offset));

        [MethodImpl(Inline)]
        public static unsafe ushort* constptr(in ushort src, int offset)
            => refptr(ref seek(ref mutable(in src), offset));

        [MethodImpl(Inline)]
        public static unsafe int* constptr(in int src, int offset)
            => refptr(ref seek(ref mutable(in src), offset));

        [MethodImpl(Inline)]
        public static unsafe uint* constptr(in uint src, int offset)
            => refptr(ref seek(ref mutable(in src), offset));

        [MethodImpl(Inline)]
        public static unsafe long* constptr(in long src, int offset)
            => refptr(ref seek(ref mutable(in src), offset));

        [MethodImpl(Inline)]
        public static unsafe ulong* constptr(in ulong src, int offset)
            => refptr(ref seek(ref mutable(in src), offset));

        [MethodImpl(Inline)]
        public static unsafe float* constptr(in float src, int offset)
            => refptr(ref seek(ref mutable(in src), offset));

        [MethodImpl(Inline)]
        public static unsafe double* constptr(in double src, int offset)
            => refptr(ref seek(ref mutable(in src), offset));


    }

}