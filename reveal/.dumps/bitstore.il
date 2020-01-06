// 2020-01-05 20:14:01:769
ReadOnlySpan<byte> bitseq(byte value)
{
    IL_0000: ldarg.0
    IL_0001: call System.ReadOnlySpan`1<System.Byte> Z0.BitStore::select(System.Byte)
    IL_0006: ret

}
void bitseq_8u(byte value, Span<byte> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.0
    IL_0003: call System.Void Z0.BitStore::bitseq<System.Byte>(System.Byte,System.Span`1<System.Byte>,System.Int32)
    IL_0008: ret

}
void bitseq_16u(ushort value, Span<byte> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.0
    IL_0003: call System.Void Z0.BitStore::bitseq<System.UInt16>(System.UInt16,System.Span`1<System.Byte>,System.Int32)
    IL_0008: ret

}
void bitseq_32u(uint value, Span<byte> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.0
    IL_0003: call System.Void Z0.BitStore::bitseq<System.UInt32>(System.UInt32,System.Span`1<System.Byte>,System.Int32)
    IL_0008: ret

}
void bitseq_64u(ulong value, Span<byte> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.0
    IL_0003: call System.Void Z0.BitStore::bitseq<System.UInt64>(System.UInt64,System.Span`1<System.Byte>,System.Int32)
    IL_0008: ret

}
ReadOnlySpan<byte> bitseq(int offset, int count)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.ReadOnlySpan`1<System.Byte> Z0.BitStore::select(System.Int32,System.Int32)
    IL_0007: ret

}
ReadOnlySpan<byte> bitseq8u(byte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.ReadOnlySpan`1<System.Byte> Z0.BitStore::bitseq<System.Byte>(System.Byte)
    IL_0006: ret

}
ReadOnlySpan<Char> bitchars_8u(byte value)
{
    IL_0000: ldarg.0
    IL_0001: call System.ReadOnlySpan`1<System.Char> Z0.BitStore::bitchars(System.Byte)
    IL_0006: ret

}
void bitchars_8u(byte value, Span<Char> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.0
    IL_0003: call System.Void Z0.BitStore::bitchars<System.Byte>(System.Byte,System.Span`1<System.Char>,System.Int32)
    IL_0008: ret

}
void bitchars_16u(ushort value, Span<Char> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.0
    IL_0003: call System.Void Z0.BitStore::bitchars<System.UInt16>(System.UInt16,System.Span`1<System.Char>,System.Int32)
    IL_0008: ret

}
void bitchars_32u(uint value, Span<Char> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.0
    IL_0003: call System.Void Z0.BitStore::bitchars<System.UInt32>(System.UInt32,System.Span`1<System.Char>,System.Int32)
    IL_0008: ret

}
void bitchars_64u(ulong value, Span<Char> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.0
    IL_0003: call System.Void Z0.BitStore::bitchars<System.UInt64>(System.UInt64,System.Span`1<System.Char>,System.Int32)
    IL_0008: ret

}
