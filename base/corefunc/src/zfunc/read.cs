using System;
using System.Runtime.CompilerServices;

using Z0;

partial class zfunc
{

    [MethodImpl(Inline)]
    public static unsafe byte read8(in byte src)
        => *(byte*)constptr(in src);

    [MethodImpl(Inline)]
    public static unsafe void store8(byte src, ref byte dst)
        => *((byte*)ptr(ref dst)) = src;

    [MethodImpl(Inline)]
    public static unsafe ushort read16(in byte src)
        => *(ushort*)constptr(in src);

    [MethodImpl(Inline)]
    public static unsafe void store16(ushort src, ref byte dst)
        => *((ushort*)ptr(ref dst)) = src;

    [MethodImpl(Inline)]
    public static unsafe uint read32(in byte src)
        => *(uint*)constptr(in src);

    [MethodImpl(Inline)]
    public static unsafe void store32(uint src, ref byte dst)
        => *((uint*)ptr(ref dst)) = src;

    [MethodImpl(Inline)]
    public static unsafe ulong read64(in byte src)
        => *(ulong*)constptr(in src);

    [MethodImpl(Inline)]
    public static unsafe void store64(ulong src, ref byte dst)
        => *((ulong*)ptr(ref dst)) = src;

}