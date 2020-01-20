// 2020-01-20 01:59:20:797
// Id := 100664415, Name := System.Byte Z0.OpCodes.bitpack::pack_8x8(System.Span`1<System.UInt32>)
// byte pack_8x8(Span<uint> src)
// IL
byte pack_8x8(Span<uint> src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: ldc.i4.0
    IL_0003: call System.Byte Z0.BitPack::pack8<System.UInt32,System.Byte>(System.Span`1<System.UInt32>,System.Int32,System.Byte)
    IL_0008: ret
}

// Id := 100664416, Name := System.UInt16 Z0.OpCodes.bitpack::pack_16x8(System.Span`1<System.UInt32>)
// ushort pack_16x8(Span<uint> src)
// IL
ushort pack_16x8(Span<uint> src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: ldc.i4.0
    IL_0003: call System.UInt16 Z0.BitPack::pack8<System.UInt32,System.UInt16>(System.Span`1<System.UInt32>,System.Int32,System.UInt16)
    IL_0008: ret
}

// Id := 100664417, Name := System.UInt32 Z0.OpCodes.bitpack::pack_32x8(System.Span`1<System.UInt32>)
// uint pack_32x8(Span<uint> src)
// IL
uint pack_32x8(Span<uint> src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: ldc.i4.0
    IL_0003: call System.UInt32 Z0.BitPack::pack8<System.UInt32,System.UInt32>(System.Span`1<System.UInt32>,System.Int32,System.UInt32)
    IL_0008: ret
}

// Id := 100664418, Name := System.UInt64 Z0.OpCodes.bitpack::pack_64x8(System.Span`1<System.UInt32>)
// ulong pack_64x8(Span<uint> src)
// IL
ulong pack_64x8(Span<uint> src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: ldc.i4.0
    IL_0003: conv.i8
    IL_0004: call System.UInt64 Z0.BitPack::pack8<System.UInt32,System.UInt64>(System.Span`1<System.UInt32>,System.Int32,System.UInt64)
    IL_0009: ret
}

// Id := 100664419, Name := System.Void Z0.OpCodes.bitpack::unpack_64x32(System.UInt64,System.Span`1<System.UInt32>)
// void unpack_64x32(ulong src, Span<uint> dst)
// IL
void unpack_64x32(ulong src, Span<uint> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Void Z0.BitPack::unpack32<System.UInt64>(System.UInt64,System.Span`1<System.UInt32>)
    IL_0007: ret
}

