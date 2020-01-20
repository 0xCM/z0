// 2020-01-20 01:59:20:870
// Id := 100664420, Name := Z0.BitSpan Z0.OpCodes.bitspan::load_scalar_8(System.Byte)
// BitSpan load_scalar_8(byte src)
// IL
BitSpan load_scalar_8(byte src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.BitSpan Z0.BitSpan::create<System.Byte>(System.Byte)
    IL_0006: ret
}

// Id := 100664421, Name := Z0.BitSpan Z0.OpCodes.bitspan::load_scalar_8_fill(System.Byte,Z0.BitSpan&)
// BitSpan load_scalar_8_fill(byte src, in BitSpan dst)
// IL
BitSpan load_scalar_8_fill(byte src, in BitSpan dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.BitSpan& modreq(System.Runtime.InteropServices.InAttribute) Z0.BitSpan::fill<System.Byte>(System.Byte,Z0.BitSpan&)
    IL_0007: ldobj Z0.BitSpan
    IL_000C: ret
}

// Id := 100664422, Name := Z0.BitSpan Z0.OpCodes.bitspan::load_scalar_16(System.UInt16)
// BitSpan load_scalar_16(ushort src)
// IL
BitSpan load_scalar_16(ushort src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.BitSpan Z0.BitSpan::create<System.UInt16>(System.UInt16)
    IL_0006: ret
}

// Id := 100664423, Name := Z0.BitSpan Z0.OpCodes.bitspan::load_scalar_16_fill(System.UInt16,Z0.BitSpan&)
// BitSpan load_scalar_16_fill(ushort src, in BitSpan dst)
// IL
BitSpan load_scalar_16_fill(ushort src, in BitSpan dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.BitSpan& modreq(System.Runtime.InteropServices.InAttribute) Z0.BitSpan::fill<System.UInt16>(System.UInt16,Z0.BitSpan&)
    IL_0007: ldobj Z0.BitSpan
    IL_000C: ret
}

// Id := 100664424, Name := Z0.BitSpan Z0.OpCodes.bitspan::load_scalar_32(System.UInt32)
// BitSpan load_scalar_32(uint src)
// IL
BitSpan load_scalar_32(uint src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.BitSpan Z0.BitSpan::create<System.UInt32>(System.UInt32)
    IL_0006: ret
}

// Id := 100664425, Name := Z0.BitSpan Z0.OpCodes.bitspan::load_scalar_32_fill(System.UInt32,Z0.BitSpan&)
// BitSpan load_scalar_32_fill(uint src, in BitSpan dst)
// IL
BitSpan load_scalar_32_fill(uint src, in BitSpan dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.BitSpan& modreq(System.Runtime.InteropServices.InAttribute) Z0.BitSpan::fill<System.UInt32>(System.UInt32,Z0.BitSpan&)
    IL_0007: ldobj Z0.BitSpan
    IL_000C: ret
}

// Id := 100664426, Name := Z0.BitSpan Z0.OpCodes.bitspan::load_scalar_64(System.UInt64)
// BitSpan load_scalar_64(ulong src)
// IL
BitSpan load_scalar_64(ulong src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.BitSpan Z0.BitSpan::create<System.UInt64>(System.UInt64)
    IL_0006: ret
}

// Id := 100664427, Name := Z0.BitSpan Z0.OpCodes.bitspan::load_scalar_64_fill(System.UInt64,Z0.BitSpan&)
// BitSpan load_scalar_64_fill(ulong src, in BitSpan dst)
// IL
BitSpan load_scalar_64_fill(ulong src, in BitSpan dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.BitSpan& modreq(System.Runtime.InteropServices.InAttribute) Z0.BitSpan::fill<System.UInt64>(System.UInt64,Z0.BitSpan&)
    IL_0007: ldobj Z0.BitSpan
    IL_000C: ret
}

// Id := 100664428, Name := System.Byte Z0.OpCodes.bitspan::scalar_8(Z0.BitSpan)
// byte scalar_8(BitSpan src)
// IL
byte scalar_8(BitSpan src)
{
    IL_0000: ldarga.s src
    IL_0002: ldc.i4.0
    IL_0003: call System.Byte Z0.BitSpan::extract<System.Byte>(Z0.BitSpan&,System.Int32)
    IL_0008: ret
}

// Id := 100664429, Name := System.UInt16 Z0.OpCodes.bitspan::extract_16(Z0.BitSpan)
// ushort extract_16(BitSpan src)
// IL
ushort extract_16(BitSpan src)
{
    IL_0000: ldarga.s src
    IL_0002: ldc.i4.0
    IL_0003: call System.UInt16 Z0.BitSpan::extract<System.UInt16>(Z0.BitSpan&,System.Int32)
    IL_0008: ret
}

// Id := 100664430, Name := System.UInt32 Z0.OpCodes.bitspan::extract_32(Z0.BitSpan)
// uint extract_32(BitSpan src)
// IL
uint extract_32(BitSpan src)
{
    IL_0000: ldarga.s src
    IL_0002: ldc.i4.0
    IL_0003: call System.UInt32 Z0.BitSpan::extract<System.UInt32>(Z0.BitSpan&,System.Int32)
    IL_0008: ret
}

// Id := 100664431, Name := System.UInt64 Z0.OpCodes.bitspan::extract_64(Z0.BitSpan)
// ulong extract_64(BitSpan src)
// IL
ulong extract_64(BitSpan src)
{
    IL_0000: ldarga.s src
    IL_0002: ldc.i4.0
    IL_0003: call System.UInt64 Z0.BitSpan::extract<System.UInt64>(Z0.BitSpan&,System.Int32)
    IL_0008: ret
}

// Id := 100664432, Name := System.Byte Z0.OpCodes.bitspan::bitslice_8(Z0.BitSpan,System.Int32,System.Int32)
// byte bitslice_8(BitSpan src, int offset, int count)
// IL
byte bitslice_8(BitSpan src, int offset, int count)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: ldarg.2
    IL_0004: call System.Byte Z0.BitSpan::bitslice<System.Byte>(Z0.BitSpan&,System.Int32,System.Int32)
    IL_0009: ret
}

// Id := 100664433, Name := System.UInt16 Z0.OpCodes.bitspan::bitslice_16(Z0.BitSpan,System.Int32,System.Int32)
// ushort bitslice_16(BitSpan src, int offset, int count)
// IL
ushort bitslice_16(BitSpan src, int offset, int count)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: ldarg.2
    IL_0004: call System.UInt16 Z0.BitSpan::bitslice<System.UInt16>(Z0.BitSpan&,System.Int32,System.Int32)
    IL_0009: ret
}

// Id := 100664434, Name := System.UInt32 Z0.OpCodes.bitspan::bitslice_32(Z0.BitSpan,System.Int32,System.Int32)
// uint bitslice_32(BitSpan src, int offset, int count)
// IL
uint bitslice_32(BitSpan src, int offset, int count)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: ldarg.2
    IL_0004: call System.UInt32 Z0.BitSpan::bitslice<System.UInt32>(Z0.BitSpan&,System.Int32,System.Int32)
    IL_0009: ret
}

// Id := 100664435, Name := System.UInt64 Z0.OpCodes.bitspan::bitslice_64(Z0.BitSpan,System.Int32,System.Int32)
// ulong bitslice_64(BitSpan src, int offset, int count)
// IL
ulong bitslice_64(BitSpan src, int offset, int count)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: ldarg.2
    IL_0004: call System.UInt64 Z0.BitSpan::bitslice<System.UInt64>(Z0.BitSpan&,System.Int32,System.Int32)
    IL_0009: ret
}

// Id := 100664436, Name := Z0.BitSpan& modreq(System.Runtime.InteropServices.InAttribute) Z0.OpCodes.bitspan::and(Z0.BitSpan&,Z0.BitSpan&,Z0.BitSpan&)
// ref BitSpan and(in BitSpan x, in BitSpan y, in BitSpan z)
// IL
ref BitSpan and(in BitSpan x, in BitSpan y, in BitSpan z)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call Z0.BitSpan& modreq(System.Runtime.InteropServices.InAttribute) Z0.BitSpan::and(Z0.BitSpan&,Z0.BitSpan&,Z0.BitSpan&)
    IL_0008: ret
}

// Id := 100664437, Name := Z0.BitSpan& modreq(System.Runtime.InteropServices.InAttribute) Z0.OpCodes.bitspan::xor(Z0.BitSpan&,Z0.BitSpan&,Z0.BitSpan&)
// ref BitSpan xor(in BitSpan x, in BitSpan y, in BitSpan z)
// IL
ref BitSpan xor(in BitSpan x, in BitSpan y, in BitSpan z)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call Z0.BitSpan& modreq(System.Runtime.InteropServices.InAttribute) Z0.BitSpan::xor(Z0.BitSpan&,Z0.BitSpan&,Z0.BitSpan&)
    IL_0008: ret
}

