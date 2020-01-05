// 2020-01-05 15:03:44:831
BitSpan load_scalar_8(byte src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.BitSpan Z0.BitSpan::create<System.Byte>(System.Byte)
    IL_0006: ret

}
BitSpan load_scalar_8_fill(byte src, in BitSpan dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.BitSpan& modreq(System.Runtime.InteropServices.InAttribute) Z0.BitSpan::fill<System.Byte>(System.Byte,Z0.BitSpan&)
    IL_0007: ldobj Z0.BitSpan
    IL_000C: ret

}
BitSpan load_scalar_16(ushort src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.BitSpan Z0.BitSpan::create<System.UInt16>(System.UInt16)
    IL_0006: ret

}
BitSpan load_scalar_16_fill(ushort src, in BitSpan dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.BitSpan& modreq(System.Runtime.InteropServices.InAttribute) Z0.BitSpan::fill<System.UInt16>(System.UInt16,Z0.BitSpan&)
    IL_0007: ldobj Z0.BitSpan
    IL_000C: ret

}
BitSpan load_scalar_32(uint src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.BitSpan Z0.BitSpan::create<System.UInt32>(System.UInt32)
    IL_0006: ret

}
BitSpan load_scalar_32_fill(uint src, in BitSpan dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.BitSpan& modreq(System.Runtime.InteropServices.InAttribute) Z0.BitSpan::fill<System.UInt32>(System.UInt32,Z0.BitSpan&)
    IL_0007: ldobj Z0.BitSpan
    IL_000C: ret

}
BitSpan load_scalar_64(ulong src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.BitSpan Z0.BitSpan::create<System.UInt64>(System.UInt64)
    IL_0006: ret

}
BitSpan load_scalar_64_fill(ulong src, in BitSpan dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.BitSpan& modreq(System.Runtime.InteropServices.InAttribute) Z0.BitSpan::fill<System.UInt64>(System.UInt64,Z0.BitSpan&)
    IL_0007: ldobj Z0.BitSpan
    IL_000C: ret

}
byte scalar_8(BitSpan src)
{
    IL_0000: ldarga.s src
    IL_0002: ldc.i4.0
    IL_0003: call System.Byte Z0.BitSpan::extract<System.Byte>(Z0.BitSpan&,System.Int32)
    IL_0008: ret

}
ushort extract_16(BitSpan src)
{
    IL_0000: ldarga.s src
    IL_0002: ldc.i4.0
    IL_0003: call System.UInt16 Z0.BitSpan::extract<System.UInt16>(Z0.BitSpan&,System.Int32)
    IL_0008: ret

}
uint extract_32(BitSpan src)
{
    IL_0000: ldarga.s src
    IL_0002: ldc.i4.0
    IL_0003: call System.UInt32 Z0.BitSpan::extract<System.UInt32>(Z0.BitSpan&,System.Int32)
    IL_0008: ret

}
ulong extract_64(BitSpan src)
{
    IL_0000: ldarga.s src
    IL_0002: ldc.i4.0
    IL_0003: call System.UInt64 Z0.BitSpan::extract<System.UInt64>(Z0.BitSpan&,System.Int32)
    IL_0008: ret

}
byte bitslice_8(BitSpan src, int offset, int count)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: ldarg.2
    IL_0004: call System.Byte Z0.BitSpan::bitslice<System.Byte>(Z0.BitSpan&,System.Int32,System.Int32)
    IL_0009: ret

}
ushort bitslice_16(BitSpan src, int offset, int count)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: ldarg.2
    IL_0004: call System.UInt16 Z0.BitSpan::bitslice<System.UInt16>(Z0.BitSpan&,System.Int32,System.Int32)
    IL_0009: ret

}
uint bitslice_32(BitSpan src, int offset, int count)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: ldarg.2
    IL_0004: call System.UInt32 Z0.BitSpan::bitslice<System.UInt32>(Z0.BitSpan&,System.Int32,System.Int32)
    IL_0009: ret

}
ulong bitslice_64(BitSpan src, int offset, int count)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: ldarg.2
    IL_0004: call System.UInt64 Z0.BitSpan::bitslice<System.UInt64>(Z0.BitSpan&,System.Int32,System.Int32)
    IL_0009: ret

}
ref BitSpan and(in BitSpan x, in BitSpan y, in BitSpan z)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call Z0.BitSpan& modreq(System.Runtime.InteropServices.InAttribute) Z0.BitSpan::and(Z0.BitSpan&,Z0.BitSpan&,Z0.BitSpan&)
    IL_0008: ret

}
ref BitSpan xor(in BitSpan x, in BitSpan y, in BitSpan z)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call Z0.BitSpan& modreq(System.Runtime.InteropServices.InAttribute) Z0.BitSpan::xor(Z0.BitSpan&,Z0.BitSpan&,Z0.BitSpan&)
    IL_0008: ret

}
