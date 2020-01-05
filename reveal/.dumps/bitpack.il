// 2020-01-05 02:30:50:876
byte pack_8x8(Span<uint> src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: ldc.i4.0
    IL_0003: call System.Byte Z0.BitPack::pack8<System.UInt32,System.Byte>(System.Span`1<System.UInt32>,System.Int32,System.Byte)
    IL_0008: ret

}
ushort pack_16x8(Span<uint> src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: ldc.i4.0
    IL_0003: call System.UInt16 Z0.BitPack::pack8<System.UInt32,System.UInt16>(System.Span`1<System.UInt32>,System.Int32,System.UInt16)
    IL_0008: ret

}
uint pack_32x8(Span<uint> src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: ldc.i4.0
    IL_0003: call System.UInt32 Z0.BitPack::pack8<System.UInt32,System.UInt32>(System.Span`1<System.UInt32>,System.Int32,System.UInt32)
    IL_0008: ret

}
ulong pack_64x8(Span<uint> src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: ldc.i4.0
    IL_0003: conv.i8
    IL_0004: call System.UInt64 Z0.BitPack::pack8<System.UInt32,System.UInt64>(System.Span`1<System.UInt32>,System.Int32,System.UInt64)
    IL_0009: ret

}
void unpack_64x32(ulong src, Span<uint> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Void Z0.BitPack::unpack32<System.UInt64>(System.UInt64,System.Span`1<System.UInt32>)
    IL_0007: ret

}
