// 2019-11-03 08:18:57:140
uint select(uint src, Part12x6:uint part)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::gather(System.UInt32,System.UInt32)
    IL_0007: ret

}
uint project(uint src, Part12x6:uint part)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::scatter(System.UInt32,System.UInt32)
    IL_0007: ret

}
void part16x8(uint src, ref byte dst)
{
    IL_0000: ldarg.1
    IL_0001: ldc.i4.0
    IL_0002: call System.Byte& zfunc::seek<System.Byte>(System.Byte&,System.Int32)
    IL_0007: ldarg.0
    IL_0008: ldc.i4 255
    IL_000D: and
    IL_000E: conv.u1
    IL_000F: stind.i1
    IL_0010: ldarg.1
    IL_0011: ldc.i4.1
    IL_0012: call System.Byte& zfunc::seek<System.Byte>(System.Byte&,System.Int32)
    IL_0017: ldarg.0
    IL_0018: ldc.i4.8
    IL_0019: shr.un
    IL_001A: ldc.i4 255
    IL_001F: and
    IL_0020: conv.u1
    IL_0021: stind.i1
    IL_0022: ret

}
void part16x8(uint src, Span<byte> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Byte& zfunc::head<System.Byte>(System.Span`1<System.Byte>)
    IL_0007: call System.Void Z0.BitParts::part16x8(System.UInt32,System.Byte&)
    IL_000C: ret

}
uint project(uint src, Part16x8:uint part)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::scatter(System.UInt32,System.UInt32)
    IL_0007: ret

}
uint select(uint src, Part16x8:uint part)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::gather(System.UInt32,System.UInt32)
    IL_0007: ret

}
uint select(uint src, Part24x8:uint part)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::gather(System.UInt32,System.UInt32)
    IL_0007: ret

}
void part32x8(uint src, ref byte dst)
{
    IL_0000: ldarg.1
    IL_0001: ldc.i4.0
    IL_0002: call System.Byte& zfunc::seek<System.Byte>(System.Byte&,System.Int32)
    IL_0007: ldarg.0
    IL_0008: ldc.i4 255
    IL_000D: and
    IL_000E: conv.u1
    IL_000F: stind.i1
    IL_0010: ldarg.1
    IL_0011: ldc.i4.1
    IL_0012: call System.Byte& zfunc::seek<System.Byte>(System.Byte&,System.Int32)
    IL_0017: ldarg.0
    IL_0018: ldc.i4.8
    IL_0019: shr.un
    IL_001A: ldc.i4 255
    IL_001F: and
    IL_0020: conv.u1
    IL_0021: stind.i1
    IL_0022: ldarg.1
    IL_0023: ldc.i4.2
    IL_0024: call System.Byte& zfunc::seek<System.Byte>(System.Byte&,System.Int32)
    IL_0029: ldarg.0
    IL_002A: ldc.i4.s 16
    IL_002C: shr.un
    IL_002D: ldc.i4 255
    IL_0032: and
    IL_0033: conv.u1
    IL_0034: stind.i1
    IL_0035: ldarg.1
    IL_0036: ldc.i4.3
    IL_0037: call System.Byte& zfunc::seek<System.Byte>(System.Byte&,System.Int32)
    IL_003C: ldarg.0
    IL_003D: ldc.i4.s 24
    IL_003F: shr.un
    IL_0040: ldc.i4 255
    IL_0045: and
    IL_0046: conv.u1
    IL_0047: stind.i1
    IL_0048: ret

}
void part32x8(uint src, Span<byte> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Byte& zfunc::head<System.Byte>(System.Span`1<System.Byte>)
    IL_0007: call System.Void Z0.BitParts::part32x8(System.UInt32,System.Byte&)
    IL_000C: ret

}
uint project(uint src, Part32x8:uint part)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::scatter(System.UInt32,System.UInt32)
    IL_0007: ret

}
byte select(uint src, Part32x8:uint part)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::gather(System.UInt32,System.UInt32)
    IL_0007: conv.u1
    IL_0008: ret

}
ulong project(ulong src, Part64x8:ulong part)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.Bits::scatter(System.UInt64,System.UInt64)
    IL_0007: ret

}
byte select(ulong src, Part64x8:ulong part)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.Bits::gather(System.UInt64,System.UInt64)
    IL_0007: conv.u1
    IL_0008: ret

}
uint select(uint src, Part64x8:ulong part)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: conv.u4
    IL_0003: call System.UInt32 Z0.Bits::gather(System.UInt32,System.UInt32)
    IL_0008: ret

}
void unpack8x1(uint src, Span<byte> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64& zfunc::head64(System.Span`1<System.Byte>)
    IL_0007: call System.Void Z0.Part64::unpack8x1(System.UInt32,System.UInt64&)
    IL_000C: ret

}
void pack16x1(ReadOnlySpan<byte> src, Span<byte> dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Byte& modreq(System.Runtime.InteropServices.InAttribute) zfunc::head<System.Byte>(System.ReadOnlySpan`1<System.Byte>)
    IL_0006: ldarg.1
    IL_0007: call System.UInt64& zfunc::head64(System.Span`1<System.Byte>)
    IL_000C: call System.Void Z0.Part64::pack16x1(System.Byte&,System.UInt64&)
    IL_0011: ret

}
void unpack16x1(uint src, Span<byte> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64& zfunc::head64(System.Span`1<System.Byte>)
    IL_0007: call System.Void Z0.Part64::unpack16x1(System.UInt32,System.UInt64&)
    IL_000C: ret

}
void pack32x1(ReadOnlySpan<byte> src, Span<byte> dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Byte& modreq(System.Runtime.InteropServices.InAttribute) zfunc::head<System.Byte>(System.ReadOnlySpan`1<System.Byte>)
    IL_0006: ldarg.1
    IL_0007: call System.UInt64& zfunc::head64(System.Span`1<System.Byte>)
    IL_000C: call System.Void Z0.Part64::pack32x1(System.Byte&,System.UInt64&)
    IL_0011: ret

}
void unpack32x1(uint src, Span<byte> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64& zfunc::head64(System.Span`1<System.Byte>)
    IL_0007: call System.Void Z0.Part64::unpack32x1(System.UInt32,System.UInt64&)
    IL_000C: ret

}
void pack64x1(ReadOnlySpan<byte> src, Span<byte> dst)
{
    IL_0000: ldarg.0
    IL_0001: call System.Byte& modreq(System.Runtime.InteropServices.InAttribute) zfunc::head<System.Byte>(System.ReadOnlySpan`1<System.Byte>)
    IL_0006: ldarg.1
    IL_0007: call System.UInt64& zfunc::head64(System.Span`1<System.Byte>)
    IL_000C: call System.Void Z0.Part64::pack64x1(System.Byte&,System.UInt64&)
    IL_0011: ret

}
void unpack64x1(ulong src, Span<byte> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64& zfunc::head64(System.Span`1<System.Byte>)
    IL_0007: call System.Void Z0.Part64::unpack64x1(System.UInt64,System.UInt64&)
    IL_000C: ret

}
ulong project(ulong src, ulong mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.Bits::scatter(System.UInt64,System.UInt64)
    IL_0007: ret

}
byte select(byte src, BitMask8:byte spec)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Byte Z0.Bits::gather(System.Byte,System.Byte)
    IL_0007: ret

}
ushort select(ushort src, BitMask16:ushort spec)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt16 Z0.Bits::gather(System.UInt16,System.UInt16)
    IL_0007: ret

}
uint select(uint src, BitMask32:uint spec)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::gather(System.UInt32,System.UInt32)
    IL_0007: ret

}
ulong select(ulong src, BitMask64:ulong spec)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.Bits::gather(System.UInt64,System.UInt64)
    IL_0007: ret

}
void part32x16(uint src, Span<ushort> dst)
{
    IL_0000: ldarga.s dst
    IL_0002: ldc.i4.0
    IL_0003: call System.UInt16& System.Span`1<System.UInt16>::get_Item(System.Int32)
    IL_0008: ldarg.0
    IL_0009: conv.u2
    IL_000A: stind.i2
    IL_000B: ldarga.s dst
    IL_000D: ldc.i4.1
    IL_000E: call System.UInt16& System.Span`1<System.UInt16>::get_Item(System.Int32)
    IL_0013: ldarg.0
    IL_0014: ldc.i4.s 16
    IL_0016: shr.un
    IL_0017: conv.u2
    IL_0018: stind.i2
    IL_0019: ret

}
void part32x16(uint src, out ushort x0, out ushort x1)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: conv.u2
    IL_0003: stind.i2
    IL_0004: ldarg.2
    IL_0005: ldarg.0
    IL_0006: ldc.i4.s 16
    IL_0008: shr.un
    IL_0009: conv.u2
    IL_000A: stind.i2
    IL_000B: ret

}
uint project(uint src, Part32x16:uint part)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::scatter(System.UInt32,System.UInt32)
    IL_0007: ret

}
uint select(uint src, Part32x16:uint part)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::gather(System.UInt32,System.UInt32)
    IL_0007: ret

}
uint project(uint src, Part1x1:uint part)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::scatter(System.UInt32,System.UInt32)
    IL_0007: ret

}
byte select(uint src, Part1x1:uint part)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::gather(System.UInt32,System.UInt32)
    IL_0007: conv.u1
    IL_0008: ret

}
uint project(uint src, Part2x1:uint part)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::scatter(System.UInt32,System.UInt32)
    IL_0007: ret

}
byte select(uint src, Part2x1:uint part)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::gather(System.UInt32,System.UInt32)
    IL_0007: conv.u1
    IL_0008: ret

}
uint project(uint src, Part3x1:uint part)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::scatter(System.UInt32,System.UInt32)
    IL_0007: ret

}
byte select(uint src, Part3x1:uint part)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::gather(System.UInt32,System.UInt32)
    IL_0007: conv.u1
    IL_0008: ret

}
void part4x1(uint src, ref byte dst)
{
    IL_0000: ldarg.1
    IL_0001: ldc.i4.0
    IL_0002: call System.Byte& zfunc::seek<System.Byte>(System.Byte&,System.Int32)
    IL_0007: ldarg.0
    IL_0008: ldc.i4.1
    IL_0009: and
    IL_000A: conv.u1
    IL_000B: stind.i1
    IL_000C: ldarg.1
    IL_000D: ldc.i4.1
    IL_000E: call System.Byte& zfunc::seek<System.Byte>(System.Byte&,System.Int32)
    IL_0013: ldarg.0
    IL_0014: ldc.i4.1
    IL_0015: shr.un
    IL_0016: ldc.i4.1
    IL_0017: and
    IL_0018: conv.u1
    IL_0019: stind.i1
    IL_001A: ldarg.1
    IL_001B: ldc.i4.2
    IL_001C: call System.Byte& zfunc::seek<System.Byte>(System.Byte&,System.Int32)
    IL_0021: ldarg.0
    IL_0022: ldc.i4.2
    IL_0023: shr.un
    IL_0024: ldc.i4.1
    IL_0025: and
    IL_0026: conv.u1
    IL_0027: stind.i1
    IL_0028: ldarg.1
    IL_0029: ldc.i4.3
    IL_002A: call System.Byte& zfunc::seek<System.Byte>(System.Byte&,System.Int32)
    IL_002F: ldarg.0
    IL_0030: ldc.i4.3
    IL_0031: shr.un
    IL_0032: ldc.i4.1
    IL_0033: and
    IL_0034: conv.u1
    IL_0035: stind.i1
    IL_0036: ret

}
uint project(uint src, Part4x1:uint part)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::scatter(System.UInt32,System.UInt32)
    IL_0007: ret

}
byte select(uint src, Part4x1:uint part)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::gather(System.UInt32,System.UInt32)
    IL_0007: conv.u1
    IL_0008: ret

}
void part5x1(uint src, ref byte dst)
{
    IL_0000: ldarg.1
    IL_0001: ldc.i4.0
    IL_0002: call System.Byte& zfunc::seek<System.Byte>(System.Byte&,System.Int32)
    IL_0007: ldarg.0
    IL_0008: ldc.i4.1
    IL_0009: and
    IL_000A: conv.u1
    IL_000B: stind.i1
    IL_000C: ldarg.1
    IL_000D: ldc.i4.1
    IL_000E: call System.Byte& zfunc::seek<System.Byte>(System.Byte&,System.Int32)
    IL_0013: ldarg.0
    IL_0014: ldc.i4.1
    IL_0015: shr.un
    IL_0016: ldc.i4.1
    IL_0017: and
    IL_0018: conv.u1
    IL_0019: stind.i1
    IL_001A: ldarg.1
    IL_001B: ldc.i4.2
    IL_001C: call System.Byte& zfunc::seek<System.Byte>(System.Byte&,System.Int32)
    IL_0021: ldarg.0
    IL_0022: ldc.i4.2
    IL_0023: shr.un
    IL_0024: ldc.i4.1
    IL_0025: and
    IL_0026: conv.u1
    IL_0027: stind.i1
    IL_0028: ldarg.1
    IL_0029: ldc.i4.3
    IL_002A: call System.Byte& zfunc::seek<System.Byte>(System.Byte&,System.Int32)
    IL_002F: ldarg.0
    IL_0030: ldc.i4.3
    IL_0031: shr.un
    IL_0032: ldc.i4.1
    IL_0033: and
    IL_0034: conv.u1
    IL_0035: stind.i1
    IL_0036: ldarg.1
    IL_0037: ldc.i4.4
    IL_0038: call System.Byte& zfunc::seek<System.Byte>(System.Byte&,System.Int32)
    IL_003D: ldarg.0
    IL_003E: ldc.i4.4
    IL_003F: shr.un
    IL_0040: ldc.i4.1
    IL_0041: and
    IL_0042: conv.u1
    IL_0043: stind.i1
    IL_0044: ret

}
uint project(uint src, Part5x1:uint part)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::scatter(System.UInt32,System.UInt32)
    IL_0007: ret

}
byte select(uint src, Part5x1:uint part)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::gather(System.UInt32,System.UInt32)
    IL_0007: conv.u1
    IL_0008: ret

}
void part6x1(uint src, ref byte dst)
{
    IL_0000: ldarg.1
    IL_0001: ldc.i4.0
    IL_0002: call System.Byte& zfunc::seek<System.Byte>(System.Byte&,System.Int32)
    IL_0007: ldarg.0
    IL_0008: ldc.i4.1
    IL_0009: and
    IL_000A: conv.u1
    IL_000B: stind.i1
    IL_000C: ldarg.1
    IL_000D: ldc.i4.1
    IL_000E: call System.Byte& zfunc::seek<System.Byte>(System.Byte&,System.Int32)
    IL_0013: ldarg.0
    IL_0014: ldc.i4.1
    IL_0015: shr.un
    IL_0016: ldc.i4.1
    IL_0017: and
    IL_0018: conv.u1
    IL_0019: stind.i1
    IL_001A: ldarg.1
    IL_001B: ldc.i4.2
    IL_001C: call System.Byte& zfunc::seek<System.Byte>(System.Byte&,System.Int32)
    IL_0021: ldarg.0
    IL_0022: ldc.i4.2
    IL_0023: shr.un
    IL_0024: ldc.i4.1
    IL_0025: and
    IL_0026: conv.u1
    IL_0027: stind.i1
    IL_0028: ldarg.1
    IL_0029: ldc.i4.3
    IL_002A: call System.Byte& zfunc::seek<System.Byte>(System.Byte&,System.Int32)
    IL_002F: ldarg.0
    IL_0030: ldc.i4.3
    IL_0031: shr.un
    IL_0032: ldc.i4.1
    IL_0033: and
    IL_0034: conv.u1
    IL_0035: stind.i1
    IL_0036: ldarg.1
    IL_0037: ldc.i4.4
    IL_0038: call System.Byte& zfunc::seek<System.Byte>(System.Byte&,System.Int32)
    IL_003D: ldarg.0
    IL_003E: ldc.i4.4
    IL_003F: shr.un
    IL_0040: ldc.i4.1
    IL_0041: and
    IL_0042: conv.u1
    IL_0043: stind.i1
    IL_0044: ldarg.1
    IL_0045: ldc.i4.5
    IL_0046: call System.Byte& zfunc::seek<System.Byte>(System.Byte&,System.Int32)
    IL_004B: ldarg.0
    IL_004C: ldc.i4.5
    IL_004D: shr.un
    IL_004E: ldc.i4.1
    IL_004F: and
    IL_0050: conv.u1
    IL_0051: stind.i1
    IL_0052: ret

}
uint project(uint src, Part6x1:uint part)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::scatter(System.UInt32,System.UInt32)
    IL_0007: ret

}
byte select(uint src, Part6x1:uint part)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::gather(System.UInt32,System.UInt32)
    IL_0007: conv.u1
    IL_0008: ret

}
void part7x1(uint src, ref byte dst)
{
    IL_0000: ldarg.1
    IL_0001: ldc.i4.0
    IL_0002: call System.Byte& zfunc::seek<System.Byte>(System.Byte&,System.Int32)
    IL_0007: ldarg.0
    IL_0008: ldc.i4.1
    IL_0009: and
    IL_000A: conv.u1
    IL_000B: stind.i1
    IL_000C: ldarg.1
    IL_000D: ldc.i4.1
    IL_000E: call System.Byte& zfunc::seek<System.Byte>(System.Byte&,System.Int32)
    IL_0013: ldarg.0
    IL_0014: ldc.i4.1
    IL_0015: shr.un
    IL_0016: ldc.i4.1
    IL_0017: and
    IL_0018: conv.u1
    IL_0019: stind.i1
    IL_001A: ldarg.1
    IL_001B: ldc.i4.2
    IL_001C: call System.Byte& zfunc::seek<System.Byte>(System.Byte&,System.Int32)
    IL_0021: ldarg.0
    IL_0022: ldc.i4.2
    IL_0023: shr.un
    IL_0024: ldc.i4.1
    IL_0025: and
    IL_0026: conv.u1
    IL_0027: stind.i1
    IL_0028: ldarg.1
    IL_0029: ldc.i4.3
    IL_002A: call System.Byte& zfunc::seek<System.Byte>(System.Byte&,System.Int32)
    IL_002F: ldarg.0
    IL_0030: ldc.i4.3
    IL_0031: shr.un
    IL_0032: ldc.i4.1
    IL_0033: and
    IL_0034: conv.u1
    IL_0035: stind.i1
    IL_0036: ldarg.1
    IL_0037: ldc.i4.4
    IL_0038: call System.Byte& zfunc::seek<System.Byte>(System.Byte&,System.Int32)
    IL_003D: ldarg.0
    IL_003E: ldc.i4.4
    IL_003F: shr.un
    IL_0040: ldc.i4.1
    IL_0041: and
    IL_0042: conv.u1
    IL_0043: stind.i1
    IL_0044: ldarg.1
    IL_0045: ldc.i4.5
    IL_0046: call System.Byte& zfunc::seek<System.Byte>(System.Byte&,System.Int32)
    IL_004B: ldarg.0
    IL_004C: ldc.i4.5
    IL_004D: shr.un
    IL_004E: ldc.i4.1
    IL_004F: and
    IL_0050: conv.u1
    IL_0051: stind.i1
    IL_0052: ldarg.1
    IL_0053: ldc.i4.6
    IL_0054: call System.Byte& zfunc::seek<System.Byte>(System.Byte&,System.Int32)
    IL_0059: ldarg.0
    IL_005A: ldc.i4.6
    IL_005B: shr.un
    IL_005C: ldc.i4.1
    IL_005D: and
    IL_005E: conv.u1
    IL_005F: stind.i1
    IL_0060: ret

}
uint project(uint src, Part7x1:uint part)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::scatter(System.UInt32,System.UInt32)
    IL_0007: ret

}
uint select(uint src, Part7x1:uint part)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::gather(System.UInt32,System.UInt32)
    IL_0007: ret

}
void part8x1(uint src, ref byte dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Void Z0.BitParts::part4x1(System.UInt32,System.Byte&)
    IL_0007: ldarg.0
    IL_0008: ldc.i4.4
    IL_0009: shr.un
    IL_000A: ldarg.1
    IL_000B: ldc.i4.4
    IL_000C: call System.Byte& zfunc::seek<System.Byte>(System.Byte&,System.Int32)
    IL_0011: call System.Void Z0.BitParts::part4x1(System.UInt32,System.Byte&)
    IL_0016: ret

}
uint project(uint src, Part8x1:uint part)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::scatter(System.UInt32,System.UInt32)
    IL_0007: ret

}
uint select(uint src, Part8x1:uint part)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::gather(System.UInt32,System.UInt32)
    IL_0007: ret

}
void part9x1(uint src, ref byte dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Void Z0.BitParts::part8x1(System.UInt32,System.Byte&)
    IL_0007: ldarg.1
    IL_0008: ldc.i4.8
    IL_0009: call System.Byte& zfunc::seek<System.Byte>(System.Byte&,System.Int32)
    IL_000E: ldarg.0
    IL_000F: ldc.i4.8
    IL_0010: shr.un
    IL_0011: ldc.i4.1
    IL_0012: and
    IL_0013: conv.u1
    IL_0014: stind.i1
    IL_0015: ret

}
uint project(uint src, Part9x1:uint part)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::scatter(System.UInt32,System.UInt32)
    IL_0007: ret

}
uint select(uint src, Part9x1:uint part)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::gather(System.UInt32,System.UInt32)
    IL_0007: ret

}
void part10x1(uint src, ref byte dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Void Z0.BitParts::part9x1(System.UInt32,System.Byte&)
    IL_0007: ldarg.1
    IL_0008: ldc.i4.s 9
    IL_000A: call System.Byte& zfunc::seek<System.Byte>(System.Byte&,System.Int32)
    IL_000F: ldarg.0
    IL_0010: ldc.i4.s 9
    IL_0012: shr.un
    IL_0013: ldc.i4.1
    IL_0014: and
    IL_0015: conv.u1
    IL_0016: stind.i1
    IL_0017: ret

}
void part10x1(uint src, Span<byte> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Byte& zfunc::head<System.Byte>(System.Span`1<System.Byte>)
    IL_0007: call System.Void Z0.BitParts::part10x1(System.UInt32,System.Byte&)
    IL_000C: ret

}
uint project(uint src, Part10x1:uint part)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::scatter(System.UInt32,System.UInt32)
    IL_0007: ret

}
uint select(uint src, Part10x1:uint part)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::gather(System.UInt32,System.UInt32)
    IL_0007: ret

}
uint project(uint src, Part11x1:uint part)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::scatter(System.UInt32,System.UInt32)
    IL_0007: ret

}
uint select(uint src, Part11x1:uint part)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::gather(System.UInt32,System.UInt32)
    IL_0007: ret

}
uint project(uint src, Part12x1:uint part)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::scatter(System.UInt32,System.UInt32)
    IL_0007: ret

}
uint select(uint src, Part12x1:uint part)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::gather(System.UInt32,System.UInt32)
    IL_0007: ret

}
uint project(uint src, Part13x1:uint part)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::scatter(System.UInt32,System.UInt32)
    IL_0007: ret

}
uint select(uint src, Part13x1:uint part)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::gather(System.UInt32,System.UInt32)
    IL_0007: ret

}
uint project(uint src, Part16x1:uint part)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::scatter(System.UInt32,System.UInt32)
    IL_0007: ret

}
uint select(uint src, Part16x1:uint part)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::gather(System.UInt32,System.UInt32)
    IL_0007: ret

}
void part32x1(uint src, Span<byte> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64& zfunc::head64(System.Span`1<System.Byte>)
    IL_0007: call System.Void Z0.BitParts::part32x1(System.UInt32,System.UInt64&)
    IL_000C: ret

}
uint project(uint src, Part32x1:uint part)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::scatter(System.UInt32,System.UInt32)
    IL_0007: ret

}
uint select(uint src, Part32x1:uint part)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::gather(System.UInt32,System.UInt32)
    IL_0007: ret

}
void part64x1(ulong src, Span<byte> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64& zfunc::head64(System.Span`1<System.Byte>)
    IL_0007: call System.Void Z0.BitParts::part64x1(System.UInt64,System.UInt64&)
    IL_000C: ret

}
ulong project(ulong src, Part64x1:ulong part)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.Bits::scatter(System.UInt64,System.UInt64)
    IL_0007: ret

}
ulong select(ulong src, Part64x1:ulong part)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.Bits::gather(System.UInt64,System.UInt64)
    IL_0007: ret

}
void part32x1(uint src, ref ulong dst)
{
    IL_0000: ldarg.1
    IL_0001: ldc.i4.0
    IL_0002: call System.UInt64& zfunc::seek<System.UInt64>(System.UInt64&,System.Int32)
    IL_0007: ldarg.0
    IL_0008: ldc.i4 255
    IL_000D: call System.Byte Z0.BitParts::select(System.UInt32,Z0.BitParts/Part32x8)
    IL_0012: conv.u8
    IL_0013: ldc.i8 72340172838076673
    IL_001C: call System.UInt64 Z0.BitParts::project(System.UInt64,System.UInt64)
    IL_0021: stind.i8
    IL_0022: ldarg.1
    IL_0023: ldc.i4.1
    IL_0024: call System.UInt64& zfunc::seek<System.UInt64>(System.UInt64&,System.Int32)
    IL_0029: ldarg.0
    IL_002A: ldc.i4 65280
    IL_002F: call System.Byte Z0.BitParts::select(System.UInt32,Z0.BitParts/Part32x8)
    IL_0034: conv.u8
    IL_0035: ldc.i8 72340172838076673
    IL_003E: call System.UInt64 Z0.BitParts::project(System.UInt64,System.UInt64)
    IL_0043: stind.i8
    IL_0044: ldarg.1
    IL_0045: ldc.i4.2
    IL_0046: call System.UInt64& zfunc::seek<System.UInt64>(System.UInt64&,System.Int32)
    IL_004B: ldarg.0
    IL_004C: ldc.i4 16711680
    IL_0051: call System.Byte Z0.BitParts::select(System.UInt32,Z0.BitParts/Part32x8)
    IL_0056: conv.u8
    IL_0057: ldc.i8 72340172838076673
    IL_0060: call System.UInt64 Z0.BitParts::project(System.UInt64,System.UInt64)
    IL_0065: stind.i8
    IL_0066: ldarg.1
    IL_0067: ldc.i4.3
    IL_0068: call System.UInt64& zfunc::seek<System.UInt64>(System.UInt64&,System.Int32)
    IL_006D: ldarg.0
    IL_006E: ldc.i4 -16777216
    IL_0073: call System.Byte Z0.BitParts::select(System.UInt32,Z0.BitParts/Part32x8)
    IL_0078: conv.u8
    IL_0079: ldc.i8 72340172838076673
    IL_0082: call System.UInt64 Z0.BitParts::project(System.UInt64,System.UInt64)
    IL_0087: stind.i8
    IL_0088: ret

}
void part64x1(ulong src, ref ulong dst)
{
    IL_0000: ldarg.1
    IL_0001: ldc.i4.0
    IL_0002: call System.UInt64& zfunc::seek<System.UInt64>(System.UInt64&,System.Int32)
    IL_0007: ldarg.0
    IL_0008: ldc.i4 255
    IL_000D: conv.i8
    IL_000E: call System.Byte Z0.BitParts::select(System.UInt64,Z0.BitParts/Part64x8)
    IL_0013: conv.u8
    IL_0014: ldc.i8 72340172838076673
    IL_001D: call System.UInt64 Z0.BitParts::project(System.UInt64,System.UInt64)
    IL_0022: stind.i8
    IL_0023: ldarg.1
    IL_0024: ldc.i4.1
    IL_0025: call System.UInt64& zfunc::seek<System.UInt64>(System.UInt64&,System.Int32)
    IL_002A: ldarg.0
    IL_002B: ldc.i4 65280
    IL_0030: conv.i8
    IL_0031: call System.Byte Z0.BitParts::select(System.UInt64,Z0.BitParts/Part64x8)
    IL_0036: conv.u8
    IL_0037: ldc.i8 72340172838076673
    IL_0040: call System.UInt64 Z0.BitParts::project(System.UInt64,System.UInt64)
    IL_0045: stind.i8
    IL_0046: ldarg.1
    IL_0047: ldc.i4.2
    IL_0048: call System.UInt64& zfunc::seek<System.UInt64>(System.UInt64&,System.Int32)
    IL_004D: ldarg.0
    IL_004E: ldc.i4 16711680
    IL_0053: conv.i8
    IL_0054: call System.Byte Z0.BitParts::select(System.UInt64,Z0.BitParts/Part64x8)
    IL_0059: conv.u8
    IL_005A: ldc.i8 72340172838076673
    IL_0063: call System.UInt64 Z0.BitParts::project(System.UInt64,System.UInt64)
    IL_0068: stind.i8
    IL_0069: ldarg.1
    IL_006A: ldc.i4.3
    IL_006B: call System.UInt64& zfunc::seek<System.UInt64>(System.UInt64&,System.Int32)
    IL_0070: ldarg.0
    IL_0071: ldc.i4 -16777216
    IL_0076: conv.u8
    IL_0077: call System.Byte Z0.BitParts::select(System.UInt64,Z0.BitParts/Part64x8)
    IL_007C: conv.u8
    IL_007D: ldc.i8 72340172838076673
    IL_0086: call System.UInt64 Z0.BitParts::project(System.UInt64,System.UInt64)
    IL_008B: stind.i8
    IL_008C: ldarg.1
    IL_008D: ldc.i4.4
    IL_008E: call System.UInt64& zfunc::seek<System.UInt64>(System.UInt64&,System.Int32)
    IL_0093: ldarg.0
    IL_0094: ldc.i8 1095216660480
    IL_009D: call System.Byte Z0.BitParts::select(System.UInt64,Z0.BitParts/Part64x8)
    IL_00A2: conv.u8
    IL_00A3: ldc.i8 72340172838076673
    IL_00AC: call System.UInt64 Z0.BitParts::project(System.UInt64,System.UInt64)
    IL_00B1: stind.i8
    IL_00B2: ldarg.1
    IL_00B3: ldc.i4.5
    IL_00B4: call System.UInt64& zfunc::seek<System.UInt64>(System.UInt64&,System.Int32)
    IL_00B9: ldarg.0
    IL_00BA: ldc.i8 280375465082880
    IL_00C3: call System.Byte Z0.BitParts::select(System.UInt64,Z0.BitParts/Part64x8)
    IL_00C8: conv.u8
    IL_00C9: ldc.i8 72340172838076673
    IL_00D2: call System.UInt64 Z0.BitParts::project(System.UInt64,System.UInt64)
    IL_00D7: stind.i8
    IL_00D8: ldarg.1
    IL_00D9: ldc.i4.6
    IL_00DA: call System.UInt64& zfunc::seek<System.UInt64>(System.UInt64&,System.Int32)
    IL_00DF: ldarg.0
    IL_00E0: ldc.i8 71776119061217280
    IL_00E9: call System.Byte Z0.BitParts::select(System.UInt64,Z0.BitParts/Part64x8)
    IL_00EE: conv.u8
    IL_00EF: ldc.i8 72340172838076673
    IL_00F8: call System.UInt64 Z0.BitParts::project(System.UInt64,System.UInt64)
    IL_00FD: stind.i8
    IL_00FE: ldarg.1
    IL_00FF: ldc.i4.7
    IL_0100: call System.UInt64& zfunc::seek<System.UInt64>(System.UInt64&,System.Int32)
    IL_0105: ldarg.0
    IL_0106: ldc.i8 -72057594037927936
    IL_010F: call System.Byte Z0.BitParts::select(System.UInt64,Z0.BitParts/Part64x8)
    IL_0114: conv.u8
    IL_0115: ldc.i8 72340172838076673
    IL_011E: call System.UInt64 Z0.BitParts::project(System.UInt64,System.UInt64)
    IL_0123: stind.i8
    IL_0124: ret

}
byte project(byte src, Part4x2:uint part)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: conv.u1
    IL_0003: call System.Byte Z0.Bits::scatter(System.Byte,System.Byte)
    IL_0008: ret

}
uint select(uint src, Part4x2:uint part)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::gather(System.UInt32,System.UInt32)
    IL_0007: ret

}
byte project(byte src, Part6x2:uint part)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: conv.u1
    IL_0003: call System.Byte Z0.Bits::scatter(System.Byte,System.Byte)
    IL_0008: ret

}
uint select(uint src, Part6x2:uint part)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::gather(System.UInt32,System.UInt32)
    IL_0007: ret

}
void part8x2(uint src, ref byte dst)
{
    IL_0000: ldarg.1
    IL_0001: ldc.i4.0
    IL_0002: call System.Byte& zfunc::seek<System.Byte>(System.Byte&,System.Int32)
    IL_0007: ldarg.0
    IL_0008: ldc.i4.3
    IL_0009: and
    IL_000A: conv.u1
    IL_000B: stind.i1
    IL_000C: ldarg.1
    IL_000D: ldc.i4.1
    IL_000E: call System.Byte& zfunc::seek<System.Byte>(System.Byte&,System.Int32)
    IL_0013: ldarg.0
    IL_0014: ldc.i4.2
    IL_0015: shr.un
    IL_0016: ldc.i4.3
    IL_0017: and
    IL_0018: conv.u1
    IL_0019: stind.i1
    IL_001A: ldarg.1
    IL_001B: ldc.i4.2
    IL_001C: call System.Byte& zfunc::seek<System.Byte>(System.Byte&,System.Int32)
    IL_0021: ldarg.0
    IL_0022: ldc.i4.4
    IL_0023: shr.un
    IL_0024: ldc.i4.3
    IL_0025: and
    IL_0026: conv.u1
    IL_0027: stind.i1
    IL_0028: ldarg.1
    IL_0029: ldc.i4.3
    IL_002A: call System.Byte& zfunc::seek<System.Byte>(System.Byte&,System.Int32)
    IL_002F: ldarg.0
    IL_0030: ldc.i4.6
    IL_0031: shr.un
    IL_0032: ldc.i4.3
    IL_0033: and
    IL_0034: conv.u1
    IL_0035: stind.i1
    IL_0036: ret

}
uint project(uint src, Part8x2:uint part)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::scatter(System.UInt32,System.UInt32)
    IL_0007: ret

}
uint select(uint src, Part8x2:uint part)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::gather(System.UInt32,System.UInt32)
    IL_0007: ret

}
uint project(uint src, Part10x2:uint part)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::scatter(System.UInt32,System.UInt32)
    IL_0007: ret

}
uint select(uint src, Part10x2:uint part)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::gather(System.UInt32,System.UInt32)
    IL_0007: ret

}
uint project(uint src, Part12x2:uint part)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::scatter(System.UInt32,System.UInt32)
    IL_0007: ret

}
uint select(uint src, Part12x2:uint part)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::gather(System.UInt32,System.UInt32)
    IL_0007: ret

}
void part16x2(uint src, ref byte dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Void Z0.BitParts::part8x2(System.UInt32,System.Byte&)
    IL_0007: ldarg.0
    IL_0008: ldc.i4.8
    IL_0009: shr.un
    IL_000A: ldarg.1
    IL_000B: ldc.i4.4
    IL_000C: call System.Byte& zfunc::seek<System.Byte>(System.Byte&,System.Int32)
    IL_0011: call System.Void Z0.BitParts::part8x2(System.UInt32,System.Byte&)
    IL_0016: ret

}
uint project(uint src, Part16x2:uint part)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::scatter(System.UInt32,System.UInt32)
    IL_0007: ret

}
uint select(uint src, Part16x2:uint part)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::gather(System.UInt32,System.UInt32)
    IL_0007: ret

}
void part32x2(uint src, ref byte dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Void Z0.BitParts::part16x2(System.UInt32,System.Byte&)
    IL_0007: ldarg.0
    IL_0008: ldc.i4.s 16
    IL_000A: shr.un
    IL_000B: ldarg.1
    IL_000C: ldc.i4.8
    IL_000D: call System.Byte& zfunc::seek<System.Byte>(System.Byte&,System.Int32)
    IL_0012: call System.Void Z0.BitParts::part16x2(System.UInt32,System.Byte&)
    IL_0017: ret

}
uint project(uint src, Part32x2:uint part)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::scatter(System.UInt32,System.UInt32)
    IL_0007: ret

}
uint select(uint src, Part32x2:uint part)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::gather(System.UInt32,System.UInt32)
    IL_0007: ret

}
void part6x3(uint src, ref byte dst)
{
    IL_0000: ldarg.1
    IL_0001: ldc.i4.0
    IL_0002: call System.Byte& zfunc::seek<System.Byte>(System.Byte&,System.Int32)
    IL_0007: ldarg.0
    IL_0008: ldc.i4.7
    IL_0009: and
    IL_000A: conv.u1
    IL_000B: stind.i1
    IL_000C: ldarg.1
    IL_000D: ldc.i4.1
    IL_000E: call System.Byte& zfunc::seek<System.Byte>(System.Byte&,System.Int32)
    IL_0013: ldarg.0
    IL_0014: ldc.i4.3
    IL_0015: shr.un
    IL_0016: ldc.i4.7
    IL_0017: and
    IL_0018: conv.u1
    IL_0019: stind.i1
    IL_001A: ret

}
uint project(uint src, Part6x3:uint part)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::scatter(System.UInt32,System.UInt32)
    IL_0007: ret

}
uint select(uint src, Part6x3:uint part)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::gather(System.UInt32,System.UInt32)
    IL_0007: ret

}
void part9x3(uint src, ref byte dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Void Z0.BitParts::part6x3(System.UInt32,System.Byte&)
    IL_0007: ldarg.1
    IL_0008: ldc.i4.2
    IL_0009: call System.Byte& zfunc::seek<System.Byte>(System.Byte&,System.Int32)
    IL_000E: ldarg.0
    IL_000F: ldc.i4.6
    IL_0010: shr.un
    IL_0011: ldc.i4.7
    IL_0012: and
    IL_0013: conv.u1
    IL_0014: stind.i1
    IL_0015: ret

}
uint project(uint src, Part9x3:uint part)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::scatter(System.UInt32,System.UInt32)
    IL_0007: ret

}
uint select(uint src, Part9x3:uint part)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::gather(System.UInt32,System.UInt32)
    IL_0007: ret

}
void part12x3(uint src, ref byte dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Void Z0.BitParts::part9x3(System.UInt32,System.Byte&)
    IL_0007: ldarg.1
    IL_0008: ldc.i4.3
    IL_0009: call System.Byte& zfunc::seek<System.Byte>(System.Byte&,System.Int32)
    IL_000E: ldarg.0
    IL_000F: ldc.i4.s 9
    IL_0011: shr.un
    IL_0012: ldc.i4.7
    IL_0013: and
    IL_0014: conv.u1
    IL_0015: stind.i1
    IL_0016: ret

}
void part12x3(uint src, Span<byte> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Byte& zfunc::head<System.Byte>(System.Span`1<System.Byte>)
    IL_0007: call System.Void Z0.BitParts::part12x3(System.UInt32,System.Byte&)
    IL_000C: ret

}
uint project(uint src, Part12x3:uint part)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::scatter(System.UInt32,System.UInt32)
    IL_0007: ret

}
uint select(uint src, Part12x3:uint part)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::gather(System.UInt32,System.UInt32)
    IL_0007: ret

}
void part15x3(uint src, ref byte dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Void Z0.BitParts::part12x3(System.UInt32,System.Byte&)
    IL_0007: ldarg.1
    IL_0008: ldc.i4.4
    IL_0009: call System.Byte& zfunc::seek<System.Byte>(System.Byte&,System.Int32)
    IL_000E: ldarg.0
    IL_000F: ldc.i4.s 12
    IL_0011: shr.un
    IL_0012: ldc.i4.7
    IL_0013: and
    IL_0014: conv.u1
    IL_0015: stind.i1
    IL_0016: ret

}
void part15x3(uint src, Span<byte> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Byte& zfunc::head<System.Byte>(System.Span`1<System.Byte>)
    IL_0007: call System.Void Z0.BitParts::part15x3(System.UInt32,System.Byte&)
    IL_000C: ret

}
uint project(uint src, Part15x3:uint part)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::scatter(System.UInt32,System.UInt32)
    IL_0007: ret

}
uint select(uint src, Part15x3:uint part)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::gather(System.UInt32,System.UInt32)
    IL_0007: ret

}
void part18x3(uint src, ref byte dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Void Z0.BitParts::part15x3(System.UInt32,System.Byte&)
    IL_0007: ldarg.1
    IL_0008: ldc.i4.5
    IL_0009: call System.Byte& zfunc::seek<System.Byte>(System.Byte&,System.Int32)
    IL_000E: ldarg.0
    IL_000F: ldc.i4.s 15
    IL_0011: shr.un
    IL_0012: ldc.i4.7
    IL_0013: and
    IL_0014: conv.u1
    IL_0015: stind.i1
    IL_0016: ret

}
void part18x3(uint src, Span<byte> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Byte& zfunc::head<System.Byte>(System.Span`1<System.Byte>)
    IL_0007: call System.Void Z0.BitParts::part18x3(System.UInt32,System.Byte&)
    IL_000C: ret

}
uint project(uint src, Part18x3:uint part)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::scatter(System.UInt32,System.UInt32)
    IL_0007: ret

}
uint select(uint src, Part18x3:uint part)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::gather(System.UInt32,System.UInt32)
    IL_0007: ret

}
void part21x3(uint src, ref byte dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Void Z0.BitParts::part18x3(System.UInt32,System.Byte&)
    IL_0007: ldarg.1
    IL_0008: ldc.i4.6
    IL_0009: call System.Byte& zfunc::seek<System.Byte>(System.Byte&,System.Int32)
    IL_000E: ldarg.0
    IL_000F: ldc.i4.s 18
    IL_0011: shr.un
    IL_0012: ldc.i4.7
    IL_0013: and
    IL_0014: conv.u1
    IL_0015: stind.i1
    IL_0016: ret

}
void part21x3(uint src, Span<byte> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Byte& zfunc::head<System.Byte>(System.Span`1<System.Byte>)
    IL_0007: call System.Void Z0.BitParts::part21x3(System.UInt32,System.Byte&)
    IL_000C: ret

}
uint project(uint src, Part21x3:uint part)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::scatter(System.UInt32,System.UInt32)
    IL_0007: ret

}
uint select(uint src, Part21x3:uint part)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::gather(System.UInt32,System.UInt32)
    IL_0007: ret

}
void part24x3(uint src, ref byte dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Void Z0.BitParts::part21x3(System.UInt32,System.Byte&)
    IL_0007: ldarg.1
    IL_0008: ldc.i4.7
    IL_0009: call System.Byte& zfunc::seek<System.Byte>(System.Byte&,System.Int32)
    IL_000E: ldarg.0
    IL_000F: ldc.i4.s 21
    IL_0011: shr.un
    IL_0012: ldc.i4.7
    IL_0013: and
    IL_0014: conv.u1
    IL_0015: stind.i1
    IL_0016: ret

}
void part24x3(uint src, Span<byte> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Byte& zfunc::head<System.Byte>(System.Span`1<System.Byte>)
    IL_0007: call System.Void Z0.BitParts::part24x3(System.UInt32,System.Byte&)
    IL_000C: ret

}
uint project(uint src, Part24x3:uint part)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::scatter(System.UInt32,System.UInt32)
    IL_0007: ret

}
uint select(uint src, Part24x3:uint part)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::gather(System.UInt32,System.UInt32)
    IL_0007: ret

}
void part27x3(uint src, ref byte dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Void Z0.BitParts::part24x3(System.UInt32,System.Byte&)
    IL_0007: ldarg.1
    IL_0008: ldc.i4.8
    IL_0009: call System.Byte& zfunc::seek<System.Byte>(System.Byte&,System.Int32)
    IL_000E: ldarg.0
    IL_000F: ldc.i4.s 24
    IL_0011: shr.un
    IL_0012: ldc.i4.7
    IL_0013: and
    IL_0014: conv.u1
    IL_0015: stind.i1
    IL_0016: ret

}
void part27x3(uint src, Span<byte> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Byte& zfunc::head<System.Byte>(System.Span`1<System.Byte>)
    IL_0007: call System.Void Z0.BitParts::part27x3(System.UInt32,System.Byte&)
    IL_000C: ret

}
uint project(uint src, Part27x3:uint part)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::scatter(System.UInt32,System.UInt32)
    IL_0007: ret

}
uint select(uint src, Part27x3:uint part)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::gather(System.UInt32,System.UInt32)
    IL_0007: ret

}
void part30x3(uint src, ref byte dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Void Z0.BitParts::part27x3(System.UInt32,System.Byte&)
    IL_0007: ldarg.1
    IL_0008: ldc.i4.s 9
    IL_000A: call System.Byte& zfunc::seek<System.Byte>(System.Byte&,System.Int32)
    IL_000F: ldarg.0
    IL_0010: ldc.i4.s 27
    IL_0012: shr.un
    IL_0013: ldc.i4.7
    IL_0014: and
    IL_0015: conv.u1
    IL_0016: stind.i1
    IL_0017: ret

}
void part30x3(uint src, Span<byte> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Byte& zfunc::head<System.Byte>(System.Span`1<System.Byte>)
    IL_0007: call System.Void Z0.BitParts::part30x3(System.UInt32,System.Byte&)
    IL_000C: ret

}
uint project(uint src, Part30x3:uint part)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::scatter(System.UInt32,System.UInt32)
    IL_0007: ret

}
uint select(uint src, Part30x3:uint part)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::gather(System.UInt32,System.UInt32)
    IL_0007: ret

}
void part8x4(uint src, ref byte dst)
{
    IL_0000: ldarg.1
    IL_0001: ldc.i4.0
    IL_0002: call System.Byte& zfunc::seek<System.Byte>(System.Byte&,System.Int32)
    IL_0007: ldarg.0
    IL_0008: ldc.i4.s 15
    IL_000A: and
    IL_000B: conv.u1
    IL_000C: stind.i1
    IL_000D: ldarg.1
    IL_000E: ldc.i4.1
    IL_000F: call System.Byte& zfunc::seek<System.Byte>(System.Byte&,System.Int32)
    IL_0014: ldarg.0
    IL_0015: ldc.i4.4
    IL_0016: shr.un
    IL_0017: ldc.i4.s 15
    IL_0019: and
    IL_001A: conv.u1
    IL_001B: stind.i1
    IL_001C: ret

}
void part8x4(uint src, Span<byte> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Byte& zfunc::head<System.Byte>(System.Span`1<System.Byte>)
    IL_0007: call System.Void Z0.BitParts::part8x4(System.UInt32,System.Byte&)
    IL_000C: ret

}
uint project(uint src, Part8x4:uint part)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::scatter(System.UInt32,System.UInt32)
    IL_0007: ret

}
uint select(uint src, Part8x4:uint part)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::gather(System.UInt32,System.UInt32)
    IL_0007: ret

}
void part12x4(uint src, ref byte dst)
{
    IL_0000: ldarg.1
    IL_0001: ldc.i4.0
    IL_0002: call System.Byte& zfunc::seek<System.Byte>(System.Byte&,System.Int32)
    IL_0007: ldarg.0
    IL_0008: ldc.i4.s 15
    IL_000A: and
    IL_000B: conv.u1
    IL_000C: stind.i1
    IL_000D: ldarg.1
    IL_000E: ldc.i4.1
    IL_000F: call System.Byte& zfunc::seek<System.Byte>(System.Byte&,System.Int32)
    IL_0014: ldarg.0
    IL_0015: ldc.i4.4
    IL_0016: shr.un
    IL_0017: ldc.i4.s 15
    IL_0019: and
    IL_001A: conv.u1
    IL_001B: stind.i1
    IL_001C: ldarg.1
    IL_001D: ldc.i4.2
    IL_001E: call System.Byte& zfunc::seek<System.Byte>(System.Byte&,System.Int32)
    IL_0023: ldarg.0
    IL_0024: ldc.i4.8
    IL_0025: shr.un
    IL_0026: ldc.i4.s 15
    IL_0028: and
    IL_0029: conv.u1
    IL_002A: stind.i1
    IL_002B: ret

}
void part12x4(uint src, Span<byte> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Byte& zfunc::head<System.Byte>(System.Span`1<System.Byte>)
    IL_0007: call System.Void Z0.BitParts::part12x4(System.UInt32,System.Byte&)
    IL_000C: ret

}
uint project(uint src, Part12x4:uint part)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::scatter(System.UInt32,System.UInt32)
    IL_0007: ret

}
uint select(uint src, Part12x4:uint part)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::gather(System.UInt32,System.UInt32)
    IL_0007: ret

}
void part16x4(uint src, ref byte dst)
{
    IL_0000: ldarg.1
    IL_0001: ldc.i4.0
    IL_0002: call System.Byte& zfunc::seek<System.Byte>(System.Byte&,System.Int32)
    IL_0007: ldarg.0
    IL_0008: ldc.i4.s 15
    IL_000A: and
    IL_000B: conv.u1
    IL_000C: stind.i1
    IL_000D: ldarg.1
    IL_000E: ldc.i4.1
    IL_000F: call System.Byte& zfunc::seek<System.Byte>(System.Byte&,System.Int32)
    IL_0014: ldarg.0
    IL_0015: ldc.i4.4
    IL_0016: shr.un
    IL_0017: ldc.i4.s 15
    IL_0019: and
    IL_001A: conv.u1
    IL_001B: stind.i1
    IL_001C: ldarg.1
    IL_001D: ldc.i4.2
    IL_001E: call System.Byte& zfunc::seek<System.Byte>(System.Byte&,System.Int32)
    IL_0023: ldarg.0
    IL_0024: ldc.i4.8
    IL_0025: shr.un
    IL_0026: ldc.i4.s 15
    IL_0028: and
    IL_0029: conv.u1
    IL_002A: stind.i1
    IL_002B: ldarg.1
    IL_002C: ldc.i4.3
    IL_002D: call System.Byte& zfunc::seek<System.Byte>(System.Byte&,System.Int32)
    IL_0032: ldarg.0
    IL_0033: ldc.i4.s 12
    IL_0035: shr.un
    IL_0036: ldc.i4.s 15
    IL_0038: and
    IL_0039: conv.u1
    IL_003A: stind.i1
    IL_003B: ret

}
void part16x4(uint src, Span<byte> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Byte& zfunc::head<System.Byte>(System.Span`1<System.Byte>)
    IL_0007: call System.Void Z0.BitParts::part16x4(System.UInt32,System.Byte&)
    IL_000C: ret

}
uint project(uint src, Part16x4:uint part)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::scatter(System.UInt32,System.UInt32)
    IL_0007: ret

}
uint select(uint src, Part16x4:uint part)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::gather(System.UInt32,System.UInt32)
    IL_0007: ret

}
uint select(uint src, Part20x4:uint part)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::gather(System.UInt32,System.UInt32)
    IL_0007: ret

}
uint select(uint src, Part24x4:uint part)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::gather(System.UInt32,System.UInt32)
    IL_0007: ret

}
void part32x4(uint src, ref byte dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Void Z0.BitParts::part16x4(System.UInt32,System.Byte&)
    IL_0007: ldarg.0
    IL_0008: ldc.i4.s 16
    IL_000A: shr.un
    IL_000B: ldarg.1
    IL_000C: ldc.i4.4
    IL_000D: call System.Byte& zfunc::seek<System.Byte>(System.Byte&,System.Int32)
    IL_0012: call System.Void Z0.BitParts::part16x4(System.UInt32,System.Byte&)
    IL_0017: ret

}
void part32x4(uint src, Span<byte> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Byte& zfunc::head<System.Byte>(System.Span`1<System.Byte>)
    IL_0007: call System.Void Z0.BitParts::part32x4(System.UInt32,System.Byte&)
    IL_000C: ret

}
uint project(uint src, Part32x4:uint part)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::scatter(System.UInt32,System.UInt32)
    IL_0007: ret

}
uint select(uint src, Part32x4:uint part)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::gather(System.UInt32,System.UInt32)
    IL_0007: ret

}
uint project(uint src, Part10x5:uint part)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::scatter(System.UInt32,System.UInt32)
    IL_0007: ret

}
uint project(uint src, Part15x5:uint part)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::scatter(System.UInt32,System.UInt32)
    IL_0007: ret

}
uint project(uint src, Part20x5:uint part)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::scatter(System.UInt32,System.UInt32)
    IL_0007: ret

}
uint project(uint src, Part25x5:uint part)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::scatter(System.UInt32,System.UInt32)
    IL_0007: ret

}
uint project(uint src, Part30x5:uint part)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::scatter(System.UInt32,System.UInt32)
    IL_0007: ret

}
byte select(uint src, Part30x5:uint part)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::gather(System.UInt32,System.UInt32)
    IL_0007: conv.u1
    IL_0008: ret

}
