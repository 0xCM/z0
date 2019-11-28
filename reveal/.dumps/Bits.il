// 2019-11-27 21:54:10:729
ref uint pack(N16 n, in bit src, ref uint dst)
{
    IL_0000: call Z0.N8 zfunc::get_n8()
    IL_0005: ldarg.1
    IL_0006: ldarg.2
    IL_0007: call System.UInt32& Z0.Bits::pack(Z0.N8,Z0.bit&,System.UInt32&)
    IL_000C: pop
    IL_000D: call Z0.N8 zfunc::get_n8()
    IL_0012: ldarg.1
    IL_0013: ldc.i4.8
    IL_0014: call Z0.bit& modreq(System.Runtime.InteropServices.InAttribute) zfunc::skip<Z0.bit>(Z0.bit&,System.Int32)
    IL_0019: ldarg.2
    IL_001A: ldc.i4.8
    IL_001B: call System.UInt32& zfunc::seek<System.UInt32>(System.UInt32&,System.Int32)
    IL_0020: call System.UInt32& Z0.Bits::pack(Z0.N8,Z0.bit&,System.UInt32&)
    IL_0025: pop
    IL_0026: ldarg.2
    IL_0027: ret

}
ref uint pack(N32 n, in bit src, ref uint dst)
{
    IL_0000: call Z0.N16 zfunc::get_n16()
    IL_0005: ldarg.1
    IL_0006: ldarg.2
    IL_0007: call System.UInt32& Z0.Bits::pack(Z0.N16,Z0.bit&,System.UInt32&)
    IL_000C: pop
    IL_000D: call Z0.N16 zfunc::get_n16()
    IL_0012: ldarg.1
    IL_0013: ldc.i4.s 16
    IL_0015: call Z0.bit& modreq(System.Runtime.InteropServices.InAttribute) zfunc::skip<Z0.bit>(Z0.bit&,System.Int32)
    IL_001A: ldarg.2
    IL_001B: ldc.i4.s 16
    IL_001D: call System.UInt32& zfunc::seek<System.UInt32>(System.UInt32&,System.Int32)
    IL_0022: call System.UInt32& Z0.Bits::pack(Z0.N16,Z0.bit&,System.UInt32&)
    IL_0027: pop
    IL_0028: ldarg.2
    IL_0029: ret

}
ushort pack(byte x0, byte x1)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.8
    IL_0003: shl
    IL_0004: or
    IL_0005: conv.u2
    IL_0006: ret

}
uint pack(ushort x0, ushort x1)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 16
    IL_0004: shl
    IL_0005: or
    IL_0006: ret

}
ulong pack(in uint x0, in uint x1)
{
    IL_0000: ldarg.0
    IL_0001: ldind.u4
    IL_0002: conv.u8
    IL_0003: ldarg.1
    IL_0004: ldind.u4
    IL_0005: conv.u8
    IL_0006: ldc.i4.s 32
    IL_0008: shl
    IL_0009: or
    IL_000A: ret

}
uint pack(byte x0, byte x1, byte x2, byte x3)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.8
    IL_0003: shl
    IL_0004: or
    IL_0005: ldarg.2
    IL_0006: ldc.i4.s 16
    IL_0008: shl
    IL_0009: or
    IL_000A: ldarg.3
    IL_000B: ldc.i4.s 24
    IL_000D: shl
    IL_000E: or
    IL_000F: ret

}
ulong pack(ushort x0, ushort x1, ushort x2, ushort x3)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 16
    IL_0004: shl
    IL_0005: or
    IL_0006: ldarg.2
    IL_0007: or
    IL_0008: ldarg.3
    IL_0009: ldc.i4.s 16
    IL_000B: shl
    IL_000C: or
    IL_000D: conv.u8
    IL_000E: ret

}
ulong pack(byte x0, byte x1, byte x2, byte x3, byte x4, byte x5, byte x6, byte x7)
{
    IL_0000: ldarg.0
    IL_0001: conv.u8
    IL_0002: ldarg.1
    IL_0003: conv.u8
    IL_0004: ldc.i4.8
    IL_0005: shl
    IL_0006: or
    IL_0007: ldarg.2
    IL_0008: conv.u8
    IL_0009: ldc.i4.s 16
    IL_000B: shl
    IL_000C: or
    IL_000D: ldarg.3
    IL_000E: conv.u8
    IL_000F: ldc.i4.s 24
    IL_0011: shl
    IL_0012: or
    IL_0013: ldarg.s x4
    IL_0015: conv.u8
    IL_0016: ldc.i4.s 32
    IL_0018: shl
    IL_0019: or
    IL_001A: ldarg.s x5
    IL_001C: conv.u8
    IL_001D: ldc.i4.s 40
    IL_001F: shl
    IL_0020: or
    IL_0021: ldarg.s x6
    IL_0023: conv.u8
    IL_0024: ldc.i4.s 48
    IL_0026: shl
    IL_0027: or
    IL_0028: ldarg.s x7
    IL_002A: conv.u8
    IL_002B: ldc.i4.s 56
    IL_002D: shl
    IL_002E: or
    IL_002F: ret

}
ref byte packseq(ReadOnlySpan<byte> src, out byte dst)
{
    IL_0000: ldarg.1
    IL_0001: ldc.i4.0
    IL_0002: stind.i1
    IL_0003: ldc.i4.8
    IL_0004: ldarga.s src
    IL_0006: call System.Int32 System.ReadOnlySpan`1<System.Byte>::get_Length()
    IL_000B: call System.Int32 Z0.math::min(System.Int32,System.Int32)
    IL_0010: stloc.0
    IL_0011: ldc.i4.0
    IL_0012: stloc.1
    IL_0013: br.s IL_0032
    IL_0015: ldarga.s src
    IL_0017: ldloc.1
    IL_0018: call System.Byte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Byte>::get_Item(System.Int32)
    IL_001D: ldind.u1
    IL_001E: ldc.i4.1
    IL_001F: bne.un.s IL_002E
    IL_0021: ldarg.1
    IL_0022: ldarg.1
    IL_0023: ldind.u1
    IL_0024: ldc.i4.1
    IL_0025: ldloc.1
    IL_0026: ldc.i4.s 31
    IL_0028: and
    IL_0029: shl
    IL_002A: conv.u1
    IL_002B: or
    IL_002C: conv.u1
    IL_002D: stind.i1
    IL_002E: ldloc.1
    IL_002F: ldc.i4.1
    IL_0030: add
    IL_0031: stloc.1
    IL_0032: ldloc.1
    IL_0033: ldloc.0
    IL_0034: blt.s IL_0015
    IL_0036: ldarg.1
    IL_0037: ret

}
ref ushort packseq(ReadOnlySpan<byte> src, out ushort dst)
{
    IL_0000: ldarg.1
    IL_0001: ldc.i4.0
    IL_0002: stind.i2
    IL_0003: ldc.i4.s 16
    IL_0005: ldarga.s src
    IL_0007: call System.Int32 System.ReadOnlySpan`1<System.Byte>::get_Length()
    IL_000C: call System.Int32 Z0.math::min(System.Int32,System.Int32)
    IL_0011: stloc.0
    IL_0012: ldc.i4.0
    IL_0013: stloc.1
    IL_0014: br.s IL_0033
    IL_0016: ldarga.s src
    IL_0018: ldloc.1
    IL_0019: call System.Byte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Byte>::get_Item(System.Int32)
    IL_001E: ldind.u1
    IL_001F: ldc.i4.1
    IL_0020: bne.un.s IL_002F
    IL_0022: ldarg.1
    IL_0023: ldarg.1
    IL_0024: ldind.u2
    IL_0025: ldc.i4.1
    IL_0026: ldloc.1
    IL_0027: ldc.i4.s 31
    IL_0029: and
    IL_002A: shl
    IL_002B: conv.u2
    IL_002C: or
    IL_002D: conv.u2
    IL_002E: stind.i2
    IL_002F: ldloc.1
    IL_0030: ldc.i4.1
    IL_0031: add
    IL_0032: stloc.1
    IL_0033: ldloc.1
    IL_0034: ldloc.0
    IL_0035: blt.s IL_0016
    IL_0037: ldarg.1
    IL_0038: ret

}
ref uint packseq(ReadOnlySpan<byte> src, out uint dst)
{
    IL_0000: ldarg.1
    IL_0001: ldc.i4.0
    IL_0002: stind.i4
    IL_0003: ldc.i4.s 32
    IL_0005: ldarga.s src
    IL_0007: call System.Int32 System.ReadOnlySpan`1<System.Byte>::get_Length()
    IL_000C: call System.Int32 Z0.math::min(System.Int32,System.Int32)
    IL_0011: stloc.0
    IL_0012: ldc.i4.0
    IL_0013: stloc.1
    IL_0014: br.s IL_0031
    IL_0016: ldarga.s src
    IL_0018: ldloc.1
    IL_0019: call System.Byte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Byte>::get_Item(System.Int32)
    IL_001E: ldind.u1
    IL_001F: ldc.i4.1
    IL_0020: bne.un.s IL_002D
    IL_0022: ldarg.1
    IL_0023: ldarg.1
    IL_0024: ldind.u4
    IL_0025: ldc.i4.1
    IL_0026: ldloc.1
    IL_0027: ldc.i4.s 31
    IL_0029: and
    IL_002A: shl
    IL_002B: or
    IL_002C: stind.i4
    IL_002D: ldloc.1
    IL_002E: ldc.i4.1
    IL_002F: add
    IL_0030: stloc.1
    IL_0031: ldloc.1
    IL_0032: ldloc.0
    IL_0033: blt.s IL_0016
    IL_0035: ldarg.1
    IL_0036: ret

}
ref ulong packseq(ReadOnlySpan<byte> src, out ulong dst)
{
    IL_0000: ldarg.1
    IL_0001: ldc.i4.0
    IL_0002: conv.i8
    IL_0003: stind.i8
    IL_0004: ldc.i4.s 64
    IL_0006: ldarga.s src
    IL_0008: call System.Int32 System.ReadOnlySpan`1<System.Byte>::get_Length()
    IL_000D: call System.Int32 Z0.math::min(System.Int32,System.Int32)
    IL_0012: stloc.0
    IL_0013: ldc.i4.0
    IL_0014: stloc.1
    IL_0015: br.s IL_0033
    IL_0017: ldarga.s src
    IL_0019: ldloc.1
    IL_001A: call System.Byte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Byte>::get_Item(System.Int32)
    IL_001F: ldind.u1
    IL_0020: ldc.i4.1
    IL_0021: bne.un.s IL_002F
    IL_0023: ldarg.1
    IL_0024: ldarg.1
    IL_0025: ldind.i8
    IL_0026: ldc.i4.1
    IL_0027: conv.i8
    IL_0028: ldloc.1
    IL_0029: ldc.i4.s 63
    IL_002B: and
    IL_002C: shl
    IL_002D: or
    IL_002E: stind.i8
    IL_002F: ldloc.1
    IL_0030: ldc.i4.1
    IL_0031: add
    IL_0032: stloc.1
    IL_0033: ldloc.1
    IL_0034: ldloc.0
    IL_0035: blt.s IL_0017
    IL_0037: ldarg.1
    IL_0038: ret

}
uint pop(sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 System.Runtime.Intrinsics.X86.Popcnt::PopCount(System.UInt32)
    IL_0006: ret

}
uint pop(byte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 System.Runtime.Intrinsics.X86.Popcnt::PopCount(System.UInt32)
    IL_0006: ret

}
uint pop(short src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 System.Runtime.Intrinsics.X86.Popcnt::PopCount(System.UInt32)
    IL_0006: ret

}
uint pop(ushort src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 System.Runtime.Intrinsics.X86.Popcnt::PopCount(System.UInt32)
    IL_0006: ret

}
uint pop(int src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 System.Runtime.Intrinsics.X86.Popcnt::PopCount(System.UInt32)
    IL_0006: ret

}
uint pop(uint src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 System.Runtime.Intrinsics.X86.Popcnt::PopCount(System.UInt32)
    IL_0006: ret

}
uint pop(long src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt64 System.Runtime.Intrinsics.X86.Popcnt/X64::PopCount(System.UInt64)
    IL_0006: conv.u4
    IL_0007: ret

}
uint pop(ulong src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt64 System.Runtime.Intrinsics.X86.Popcnt/X64::PopCount(System.UInt64)
    IL_0006: conv.u4
    IL_0007: ret

}
uint pop(ulong x0, ulong x1)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt64 System.Runtime.Intrinsics.X86.Popcnt/X64::PopCount(System.UInt64)
    IL_0006: ldarg.1
    IL_0007: call System.UInt64 System.Runtime.Intrinsics.X86.Popcnt/X64::PopCount(System.UInt64)
    IL_000C: add
    IL_000D: conv.u4
    IL_000E: ret

}
uint pop(ulong x, ulong y, ulong z)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: xor
    IL_0003: ldarg.2
    IL_0004: and
    IL_0005: ldarg.0
    IL_0006: ldarg.1
    IL_0007: and
    IL_0008: or
    IL_0009: stloc.0
    IL_000A: ldarg.0
    IL_000B: ldarg.1
    IL_000C: xor
    IL_000D: ldarg.2
    IL_000E: xor
    IL_000F: stloc.1
    IL_0010: ldloc.0
    IL_0011: ldloc.0
    IL_0012: ldc.i4.1
    IL_0013: shr.un
    IL_0014: ldc.i8 6148914691236517205
    IL_001D: and
    IL_001E: sub
    IL_001F: stloc.0
    IL_0020: ldloc.1
    IL_0021: ldloc.1
    IL_0022: ldc.i4.1
    IL_0023: shr.un
    IL_0024: ldc.i8 6148914691236517205
    IL_002D: and
    IL_002E: sub
    IL_002F: stloc.1
    IL_0030: ldloc.0
    IL_0031: ldc.i8 3689348814741910323
    IL_003A: and
    IL_003B: ldloc.0
    IL_003C: ldc.i4.2
    IL_003D: shr.un
    IL_003E: ldc.i8 3689348814741910323
    IL_0047: and
    IL_0048: add
    IL_0049: stloc.0
    IL_004A: ldloc.1
    IL_004B: ldc.i8 3689348814741910323
    IL_0054: and
    IL_0055: ldloc.1
    IL_0056: ldc.i4.2
    IL_0057: shr.un
    IL_0058: ldc.i8 3689348814741910323
    IL_0061: and
    IL_0062: add
    IL_0063: stloc.1
    IL_0064: ldloc.0
    IL_0065: ldloc.0
    IL_0066: ldc.i4.4
    IL_0067: shr.un
    IL_0068: add
    IL_0069: ldc.i8 1085102592571150095
    IL_0072: and
    IL_0073: stloc.0
    IL_0074: ldloc.1
    IL_0075: ldloc.1
    IL_0076: ldc.i4.4
    IL_0077: shr.un
    IL_0078: add
    IL_0079: ldc.i8 1085102592571150095
    IL_0082: and
    IL_0083: stloc.1
    IL_0084: ldloc.0
    IL_0085: ldloc.0
    IL_0086: add
    IL_0087: ldloc.1
    IL_0088: add
    IL_0089: ldc.i8 72340172838076673
    IL_0092: mul
    IL_0093: ldc.i4.s 56
    IL_0095: shr.un
    IL_0096: stloc.1
    IL_0097: ldloc.1
    IL_0098: conv.u4
    IL_0099: ret

}
uint pop(ulong x0, ulong x1, ulong x2, ulong x3)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt64 System.Runtime.Intrinsics.X86.Popcnt/X64::PopCount(System.UInt64)
    IL_0006: ldarg.1
    IL_0007: call System.UInt64 System.Runtime.Intrinsics.X86.Popcnt/X64::PopCount(System.UInt64)
    IL_000C: add
    IL_000D: ldarg.2
    IL_000E: call System.UInt64 System.Runtime.Intrinsics.X86.Popcnt/X64::PopCount(System.UInt64)
    IL_0013: add
    IL_0014: ldarg.3
    IL_0015: call System.UInt64 System.Runtime.Intrinsics.X86.Popcnt/X64::PopCount(System.UInt64)
    IL_001A: add
    IL_001B: conv.u4
    IL_001C: ret

}
uint pop(ulong x0, ulong x1, ulong x2, ulong x3, ulong x4, ulong x5, ulong x6, ulong x7)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: ldarg.3
    IL_0004: call System.UInt32 Z0.Bits::pop(System.UInt64,System.UInt64,System.UInt64,System.UInt64)
    IL_0009: ldarg.s x4
    IL_000B: ldarg.s x5
    IL_000D: ldarg.s x6
    IL_000F: ldarg.s x7
    IL_0011: call System.UInt32 Z0.Bits::pop(System.UInt64,System.UInt64,System.UInt64,System.UInt64)
    IL_0016: add
    IL_0017: ret

}
uint pop(ulong x0, ulong x1, ulong x2, ulong x3, ulong x4, ulong x5)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.UInt32 Z0.Bits::pop(System.UInt64,System.UInt64,System.UInt64)
    IL_0008: ldarg.3
    IL_0009: ldarg.s x4
    IL_000B: ldarg.s x5
    IL_000D: call System.UInt32 Z0.Bits::pop(System.UInt64,System.UInt64,System.UInt64)
    IL_0012: add
    IL_0013: ret

}
uint pop(in ulong src, int len)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: ldc.i4.0
    IL_0003: stloc.1
    IL_0004: ldloc.0
    IL_0005: ldarg.0
    IL_0006: ldloc.1
    IL_0007: call System.UInt64& modreq(System.Runtime.InteropServices.InAttribute) zfunc::skip<System.UInt64>(System.UInt64&,System.Int32)
    IL_000C: ldind.i8
    IL_000D: call System.UInt32 Z0.Bits::pop(System.UInt64)
    IL_0012: add
    IL_0013: stloc.0
    IL_0014: ldloc.1
    IL_0015: ldc.i4.1
    IL_0016: add
    IL_0017: dup
    IL_0018: stloc.1
    IL_0019: ldarg.1
    IL_001A: blt.s IL_0004
    IL_001C: ldloc.0
    IL_001D: ret

}
byte range(byte a, uint min, uint max)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.UInt32 Z0.Bits::range(System.UInt32,System.UInt32,System.UInt32)
    IL_0008: conv.u1
    IL_0009: ret

}
ushort range(ushort a, uint min, uint max)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.UInt32 Z0.Bits::range(System.UInt32,System.UInt32,System.UInt32)
    IL_0008: conv.u2
    IL_0009: ret

}
uint range(uint a, uint min, uint max)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: conv.u1
    IL_0003: ldarg.2
    IL_0004: ldarg.1
    IL_0005: sub
    IL_0006: ldc.i4.1
    IL_0007: add
    IL_0008: conv.u1
    IL_0009: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi1::BitFieldExtract(System.UInt32,System.Byte,System.Byte)
    IL_000E: ret

}
ulong range(ulong a, uint min, uint max)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: conv.u1
    IL_0003: ldarg.2
    IL_0004: ldarg.1
    IL_0005: sub
    IL_0006: ldc.i4.1
    IL_0007: add
    IL_0008: conv.u1
    IL_0009: call System.UInt64 System.Runtime.Intrinsics.X86.Bmi1/X64::BitFieldExtract(System.UInt64,System.Byte,System.Byte)
    IL_000E: ret

}
uint rank(byte src, uint pos)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: ldarg.1
    IL_0003: call System.Byte Z0.Bits::range(System.Byte,System.UInt32,System.UInt32)
    IL_0008: call System.UInt32 Z0.Bits::pop(System.Byte)
    IL_000D: ret

}
uint rank(ushort src, uint pos)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: ldarg.1
    IL_0003: call System.UInt16 Z0.Bits::range(System.UInt16,System.UInt32,System.UInt32)
    IL_0008: call System.UInt32 Z0.Bits::pop(System.UInt16)
    IL_000D: ret

}
uint rank(uint src, uint pos)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: ldarg.1
    IL_0003: call System.UInt32 Z0.Bits::range(System.UInt32,System.UInt32,System.UInt32)
    IL_0008: call System.UInt32 Z0.Bits::pop(System.UInt32)
    IL_000D: ret

}
uint rank(ulong src, uint pos)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: ldarg.1
    IL_0003: call System.UInt64 Z0.Bits::range(System.UInt64,System.UInt32,System.UInt32)
    IL_0008: call System.UInt32 Z0.Bits::pop(System.UInt64)
    IL_000D: ret

}
byte rev(byte src)
{
    IL_0000: ldarg.0
    IL_0001: conv.u8
    IL_0002: ldc.i4 -2145384446
    IL_0007: conv.u8
    IL_0008: mul
    IL_0009: ldc.i8 36578664720
    IL_0012: and
    IL_0013: ldc.i8 4311810305
    IL_001C: mul
    IL_001D: ldc.i4.s 32
    IL_001F: shr.un
    IL_0020: conv.u1
    IL_0021: ret

}
ushort rev(ushort src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Byte Z0.Bits::hi(System.UInt16)
    IL_0006: call System.Byte Z0.Bits::rev(System.Byte)
    IL_000B: ldarg.0
    IL_000C: call System.Byte Z0.Bits::lo(System.UInt16)
    IL_0011: call System.Byte Z0.Bits::rev(System.Byte)
    IL_0016: call System.UInt16 Z0.Bits::pack(System.Byte,System.Byte)
    IL_001B: ret

}
uint rev(uint x)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4 -1431655766
    IL_0006: and
    IL_0007: ldc.i4.1
    IL_0008: shr.un
    IL_0009: ldarg.0
    IL_000A: ldc.i4 1431655765
    IL_000F: and
    IL_0010: ldc.i4.1
    IL_0011: shl
    IL_0012: or
    IL_0013: starg.s x
    IL_0015: ldarg.0
    IL_0016: ldc.i4 -858993460
    IL_001B: and
    IL_001C: ldc.i4.2
    IL_001D: shr.un
    IL_001E: ldarg.0
    IL_001F: ldc.i4 858993459
    IL_0024: and
    IL_0025: ldc.i4.2
    IL_0026: shl
    IL_0027: or
    IL_0028: starg.s x
    IL_002A: ldarg.0
    IL_002B: ldc.i4 -252645136
    IL_0030: and
    IL_0031: ldc.i4.4
    IL_0032: shr.un
    IL_0033: ldarg.0
    IL_0034: ldc.i4 252645135
    IL_0039: and
    IL_003A: ldc.i4.4
    IL_003B: shl
    IL_003C: or
    IL_003D: starg.s x
    IL_003F: ldarg.0
    IL_0040: ldc.i4 -16711936
    IL_0045: and
    IL_0046: ldc.i4.8
    IL_0047: shr.un
    IL_0048: ldarg.0
    IL_0049: ldc.i4 16711935
    IL_004E: and
    IL_004F: ldc.i4.8
    IL_0050: shl
    IL_0051: or
    IL_0052: starg.s x
    IL_0054: ldarg.0
    IL_0055: ldc.i4.s 16
    IL_0057: shr.un
    IL_0058: ldarg.0
    IL_0059: ldc.i4.s 16
    IL_005B: shl
    IL_005C: or
    IL_005D: ret

}
ulong rev(ulong src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 Z0.Bits::hi(System.UInt64)
    IL_0006: call System.UInt32 Z0.Bits::rev(System.UInt32)
    IL_000B: stloc.0
    IL_000C: ldloca.s V_0
    IL_000E: ldarg.0
    IL_000F: call System.UInt32 Z0.Bits::lo(System.UInt64)
    IL_0014: call System.UInt32 Z0.Bits::rev(System.UInt32)
    IL_0019: stloc.1
    IL_001A: ldloca.s V_1
    IL_001C: call System.UInt64 Z0.Bits::pack(System.UInt32&,System.UInt32&)
    IL_0021: ret

}
byte rotl(byte src, int shift)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 31
    IL_0004: and
    IL_0005: shl
    IL_0006: ldarg.0
    IL_0007: ldc.i4.8
    IL_0008: ldarg.1
    IL_0009: sub
    IL_000A: ldc.i4.s 31
    IL_000C: and
    IL_000D: shr
    IL_000E: or
    IL_000F: conv.u1
    IL_0010: ret

}
ushort rotl(ushort src, int shift)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 31
    IL_0004: and
    IL_0005: shl
    IL_0006: ldarg.0
    IL_0007: ldc.i4.s 16
    IL_0009: ldarg.1
    IL_000A: sub
    IL_000B: ldc.i4.s 31
    IL_000D: and
    IL_000E: shr
    IL_000F: or
    IL_0010: conv.u2
    IL_0011: ret

}
uint rotl(uint src, int shift)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 31
    IL_0004: and
    IL_0005: shl
    IL_0006: ldarg.0
    IL_0007: ldc.i4.s 32
    IL_0009: ldarg.1
    IL_000A: sub
    IL_000B: ldc.i4.s 31
    IL_000D: and
    IL_000E: shr.un
    IL_000F: or
    IL_0010: ret

}
ulong rotl(ulong src, int shift)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 63
    IL_0004: and
    IL_0005: shl
    IL_0006: ldarg.0
    IL_0007: ldc.i4.s 64
    IL_0009: ldarg.1
    IL_000A: sub
    IL_000B: ldc.i4.s 63
    IL_000D: and
    IL_000E: shr.un
    IL_000F: or
    IL_0010: ret

}
byte rotl(byte src, int shift, int width)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 31
    IL_0004: and
    IL_0005: shl
    IL_0006: ldarg.0
    IL_0007: ldarg.2
    IL_0008: ldarg.1
    IL_0009: sub
    IL_000A: ldc.i4.s 31
    IL_000C: and
    IL_000D: shr
    IL_000E: or
    IL_000F: conv.u1
    IL_0010: ret

}
ushort rotl(ushort src, int shift, int width)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 31
    IL_0004: and
    IL_0005: shl
    IL_0006: ldarg.0
    IL_0007: ldarg.2
    IL_0008: ldarg.1
    IL_0009: sub
    IL_000A: ldc.i4.s 31
    IL_000C: and
    IL_000D: shr
    IL_000E: or
    IL_000F: conv.u2
    IL_0010: ret

}
uint rotl(uint src, int shift, int width)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 31
    IL_0004: and
    IL_0005: shl
    IL_0006: ldarg.0
    IL_0007: ldarg.2
    IL_0008: ldarg.1
    IL_0009: sub
    IL_000A: ldc.i4.s 31
    IL_000C: and
    IL_000D: shr.un
    IL_000E: or
    IL_000F: ret

}
ulong rotl(ulong src, int shift, int width)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 63
    IL_0004: and
    IL_0005: shl
    IL_0006: ldarg.0
    IL_0007: ldarg.2
    IL_0008: ldarg.1
    IL_0009: sub
    IL_000A: ldc.i4.s 63
    IL_000C: and
    IL_000D: shr.un
    IL_000E: or
    IL_000F: ret

}
byte rotr(byte src, int shift)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 31
    IL_0004: and
    IL_0005: shr
    IL_0006: ldarg.0
    IL_0007: ldc.i4.8
    IL_0008: ldarg.1
    IL_0009: sub
    IL_000A: ldc.i4.s 31
    IL_000C: and
    IL_000D: shl
    IL_000E: or
    IL_000F: conv.u1
    IL_0010: ret

}
ushort rotr(ushort src, int shift)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 31
    IL_0004: and
    IL_0005: shr
    IL_0006: ldarg.0
    IL_0007: ldc.i4.s 16
    IL_0009: ldarg.1
    IL_000A: sub
    IL_000B: ldc.i4.s 31
    IL_000D: and
    IL_000E: shl
    IL_000F: or
    IL_0010: conv.u2
    IL_0011: ret

}
uint rotr(uint src, int shift)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 31
    IL_0004: and
    IL_0005: shr.un
    IL_0006: ldarg.0
    IL_0007: ldc.i4.s 32
    IL_0009: ldarg.1
    IL_000A: sub
    IL_000B: ldc.i4.s 31
    IL_000D: and
    IL_000E: shl
    IL_000F: or
    IL_0010: ret

}
ulong rotr(ulong src, int shift)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 63
    IL_0004: and
    IL_0005: shr.un
    IL_0006: ldarg.0
    IL_0007: ldc.i4.s 64
    IL_0009: ldarg.1
    IL_000A: sub
    IL_000B: ldc.i4.s 63
    IL_000D: and
    IL_000E: shl
    IL_000F: or
    IL_0010: ret

}
byte rotr(byte src, int shift, int width)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 31
    IL_0004: and
    IL_0005: shr
    IL_0006: ldarg.0
    IL_0007: ldarg.2
    IL_0008: ldarg.1
    IL_0009: sub
    IL_000A: ldc.i4.s 31
    IL_000C: and
    IL_000D: shl
    IL_000E: or
    IL_000F: conv.u1
    IL_0010: ret

}
ushort rotr(ushort src, int shift, int width)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 31
    IL_0004: and
    IL_0005: shr
    IL_0006: ldarg.0
    IL_0007: ldarg.2
    IL_0008: ldarg.1
    IL_0009: sub
    IL_000A: ldc.i4.s 31
    IL_000C: and
    IL_000D: shl
    IL_000E: or
    IL_000F: conv.u2
    IL_0010: ret

}
uint rotr(uint src, int shift, int width)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 31
    IL_0004: and
    IL_0005: shr.un
    IL_0006: ldarg.0
    IL_0007: ldarg.2
    IL_0008: ldarg.1
    IL_0009: sub
    IL_000A: ldc.i4.s 31
    IL_000C: and
    IL_000D: shl
    IL_000E: or
    IL_000F: ret

}
ulong rotr(ulong src, int shift, int width)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 63
    IL_0004: and
    IL_0005: shr.un
    IL_0006: ldarg.0
    IL_0007: ldarg.2
    IL_0008: ldarg.1
    IL_0009: sub
    IL_000A: ldc.i4.s 63
    IL_000C: and
    IL_000D: shl
    IL_000E: or
    IL_000F: ret

}
sbyte scatter(sbyte src, sbyte mask)
{
    IL_0000: ldarg.0
    IL_0001: conv.u1
    IL_0002: ldarg.1
    IL_0003: conv.u1
    IL_0004: call System.Byte Z0.Bits::scatter(System.Byte,System.Byte)
    IL_0009: conv.i1
    IL_000A: ret

}
byte scatter(byte src, byte mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi2::ParallelBitDeposit(System.UInt32,System.UInt32)
    IL_0007: conv.u1
    IL_0008: ret

}
short scatter(short src, short mask)
{
    IL_0000: ldarg.0
    IL_0001: conv.u2
    IL_0002: ldarg.1
    IL_0003: conv.u2
    IL_0004: call System.UInt16 Z0.Bits::scatter(System.UInt16,System.UInt16)
    IL_0009: conv.i2
    IL_000A: ret

}
ushort scatter(ushort src, ushort mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi2::ParallelBitDeposit(System.UInt32,System.UInt32)
    IL_0007: conv.u2
    IL_0008: ret

}
int scatter(int src, int mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::scatter(System.UInt32,System.UInt32)
    IL_0007: ret

}
uint scatter(uint src, uint mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi2::ParallelBitDeposit(System.UInt32,System.UInt32)
    IL_0007: ret

}
long scatter(long src, long mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.Bits::scatter(System.UInt64,System.UInt64)
    IL_0007: ret

}
ulong scatter(ulong src, ulong mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 System.Runtime.Intrinsics.X86.Bmi2/X64::ParallelBitDeposit(System.UInt64,System.UInt64)
    IL_0007: ret

}
void split(byte src, out byte x0, out byte x1)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldc.i4.s 15
    IL_0004: and
    IL_0005: conv.u1
    IL_0006: stind.i1
    IL_0007: ldarg.2
    IL_0008: ldarg.0
    IL_0009: ldc.i4.4
    IL_000A: shr
    IL_000B: conv.u1
    IL_000C: stind.i1
    IL_000D: ret

}
void split(ushort src, out byte x0, out byte x1)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: conv.u1
    IL_0003: stind.i1
    IL_0004: ldarg.2
    IL_0005: ldarg.0
    IL_0006: ldc.i4.8
    IL_0007: shr
    IL_0008: conv.u1
    IL_0009: stind.i1
    IL_000A: ret

}
void split(uint src, out ushort x0, out ushort x1)
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
void split(ulong src, out uint x0, out uint x1)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: conv.u4
    IL_0003: stind.i4
    IL_0004: ldarg.2
    IL_0005: ldarg.0
    IL_0006: ldc.i4.s 32
    IL_0008: shr.un
    IL_0009: conv.u4
    IL_000A: stind.i4
    IL_000B: ret

}
void split(ulong src, out ushort x0, out ushort x1, out ushort x2, out ushort x3)
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
    IL_000B: ldarg.3
    IL_000C: ldarg.0
    IL_000D: ldc.i4.s 32
    IL_000F: shr.un
    IL_0010: conv.u2
    IL_0011: stind.i2
    IL_0012: ldarg.s x3
    IL_0014: ldarg.0
    IL_0015: ldc.i4.s 48
    IL_0017: shr.un
    IL_0018: conv.u2
    IL_0019: stind.i2
    IL_001A: ret

}
void split(uint src, out byte x0, out byte x1, out byte x2, out byte x3)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: conv.u1
    IL_0003: stind.i1
    IL_0004: ldarg.2
    IL_0005: ldarg.0
    IL_0006: ldc.i4.8
    IL_0007: shr.un
    IL_0008: conv.u1
    IL_0009: stind.i1
    IL_000A: ldarg.3
    IL_000B: ldarg.0
    IL_000C: ldc.i4.s 16
    IL_000E: shr.un
    IL_000F: conv.u1
    IL_0010: stind.i1
    IL_0011: ldarg.s x3
    IL_0013: ldarg.0
    IL_0014: ldc.i4.s 24
    IL_0016: shr.un
    IL_0017: conv.u1
    IL_0018: stind.i1
    IL_0019: ret

}
void split(ulong src, out byte x0, out byte x1, out byte x2, out byte x3, out byte x4, out byte x5, out byte x6, out byte x7)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: conv.u1
    IL_0003: stind.i1
    IL_0004: ldarg.2
    IL_0005: ldarg.0
    IL_0006: ldc.i4.8
    IL_0007: shr.un
    IL_0008: conv.u1
    IL_0009: stind.i1
    IL_000A: ldarg.3
    IL_000B: ldarg.0
    IL_000C: ldc.i4.s 16
    IL_000E: shr.un
    IL_000F: conv.u1
    IL_0010: stind.i1
    IL_0011: ldarg.s x3
    IL_0013: ldarg.0
    IL_0014: ldc.i4.s 24
    IL_0016: shr.un
    IL_0017: conv.u1
    IL_0018: stind.i1
    IL_0019: ldarg.s x4
    IL_001B: ldarg.0
    IL_001C: ldc.i4.s 32
    IL_001E: shr.un
    IL_001F: conv.u1
    IL_0020: stind.i1
    IL_0021: ldarg.s x5
    IL_0023: ldarg.0
    IL_0024: ldc.i4.s 40
    IL_0026: shr.un
    IL_0027: conv.u1
    IL_0028: stind.i1
    IL_0029: ldarg.s x6
    IL_002B: ldarg.0
    IL_002C: ldc.i4.s 48
    IL_002E: shr.un
    IL_002F: conv.u1
    IL_0030: stind.i1
    IL_0031: ldarg.s x7
    IL_0033: ldarg.0
    IL_0034: ldc.i4.s 56
    IL_0036: shr.un
    IL_0037: conv.u1
    IL_0038: stind.i1
    IL_0039: ret

}
bit test(sbyte src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.BitMask::test(System.SByte,System.Int32)
    IL_0007: ret

}
bit test(byte src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.BitMask::test(System.Byte,System.Int32)
    IL_0007: ret

}
bit test(short src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.BitMask::test(System.Int16,System.Int32)
    IL_0007: ret

}
bit test(ushort src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.BitMask::test(System.UInt16,System.Int32)
    IL_0007: ret

}
bit test(int src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.BitMask::test(System.Int32,System.Int32)
    IL_0007: ret

}
bit test(uint src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.BitMask::test(System.UInt32,System.Int32)
    IL_0007: ret

}
bit test(long src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.BitMask::test(System.Int64,System.Int32)
    IL_0007: call Z0.bit Z0.bit::op_Implicit(System.Boolean)
    IL_000C: ret

}
bit test(ulong src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.BitMask::test(System.UInt64,System.Int32)
    IL_0007: ret

}
bit test(float src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.BitMask::test(System.Single,System.Int32)
    IL_0007: ret

}
bit test(double src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.BitMask::test(System.Double,System.Int32)
    IL_0007: ret

}
bit testz(ulong a, ulong b)
{
    IL_0000: call Z0.N128 zfunc::get_n128()
    IL_0005: ldarg.0
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.dinx::vbroadcast(Z0.N128,System.UInt64)
    IL_000B: call Z0.N128 zfunc::get_n128()
    IL_0010: ldarg.1
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.dinx::vbroadcast(Z0.N128,System.UInt64)
    IL_0016: call Z0.bit Z0.dinx::vtestz(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_001B: ret

}
bit testc(ulong a, ulong b)
{
    IL_0000: call Z0.N128 zfunc::get_n128()
    IL_0005: ldarg.0
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.dinx::vbroadcast(Z0.N128,System.UInt64)
    IL_000B: call Z0.N128 zfunc::get_n128()
    IL_0010: ldarg.1
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.dinx::vbroadcast(Z0.N128,System.UInt64)
    IL_0016: call Z0.bit Z0.dinx::vtestc(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_001B: ret

}
bit testc(ulong a)
{
    IL_0000: call Z0.N128 zfunc::get_n128()
    IL_0005: ldarg.0
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.dinx::vbroadcast(Z0.N128,System.UInt64)
    IL_000B: call Z0.bit Z0.dinx::vtestc(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0010: ret

}
sbyte toggle(sbyte src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0002: ldarg.1
    IL_0003: ldc.i4.s 31
    IL_0005: and
    IL_0006: shl
    IL_0007: conv.i1
    IL_0008: xor
    IL_0009: conv.i1
    IL_000A: dup
    IL_000B: starg.s src
    IL_000D: ret

}
byte toggle(byte src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0002: ldarg.1
    IL_0003: ldc.i4.s 31
    IL_0005: and
    IL_0006: shl
    IL_0007: conv.u1
    IL_0008: xor
    IL_0009: conv.u1
    IL_000A: dup
    IL_000B: starg.s src
    IL_000D: ret

}
short toggle(short src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0002: ldarg.1
    IL_0003: ldc.i4.s 31
    IL_0005: and
    IL_0006: shl
    IL_0007: conv.i2
    IL_0008: xor
    IL_0009: conv.i2
    IL_000A: dup
    IL_000B: starg.s src
    IL_000D: ret

}
ushort toggle(ushort src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0002: ldarg.1
    IL_0003: ldc.i4.s 31
    IL_0005: and
    IL_0006: shl
    IL_0007: conv.u2
    IL_0008: xor
    IL_0009: conv.u2
    IL_000A: dup
    IL_000B: starg.s src
    IL_000D: ret

}
int toggle(int src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0002: ldarg.1
    IL_0003: ldc.i4.s 31
    IL_0005: and
    IL_0006: shl
    IL_0007: xor
    IL_0008: dup
    IL_0009: starg.s src
    IL_000B: ret

}
uint toggle(uint src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0002: ldarg.1
    IL_0003: ldc.i4.s 31
    IL_0005: and
    IL_0006: shl
    IL_0007: xor
    IL_0008: dup
    IL_0009: starg.s src
    IL_000B: ret

}
long toggle(long src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0002: conv.i8
    IL_0003: ldarg.1
    IL_0004: ldc.i4.s 63
    IL_0006: and
    IL_0007: shl
    IL_0008: xor
    IL_0009: dup
    IL_000A: starg.s src
    IL_000C: ret

}
ulong toggle(ulong src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0002: conv.i8
    IL_0003: ldarg.1
    IL_0004: ldc.i4.s 63
    IL_0006: and
    IL_0007: shl
    IL_0008: xor
    IL_0009: dup
    IL_000A: starg.s src
    IL_000C: ret

}
float toggle(float src, int pos)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Int32& System.Runtime.CompilerServices.Unsafe::As<System.Single,System.Int32>(System.Single&)
    IL_0007: stloc.0
    IL_0008: ldloc.0
    IL_0009: ldloc.0
    IL_000A: ldind.i4
    IL_000B: ldc.i4.1
    IL_000C: ldarg.1
    IL_000D: ldc.i4.s 31
    IL_000F: and
    IL_0010: shl
    IL_0011: xor
    IL_0012: stind.i4
    IL_0013: ldarg.0
    IL_0014: ret

}
double toggle(double src, int pos)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Int64& System.Runtime.CompilerServices.Unsafe::As<System.Double,System.Int64>(System.Double&)
    IL_0007: stloc.0
    IL_0008: ldloc.0
    IL_0009: ldloc.0
    IL_000A: ldind.i8
    IL_000B: ldc.i4.1
    IL_000C: conv.i8
    IL_000D: ldarg.1
    IL_000E: ldc.i4.s 63
    IL_0010: and
    IL_0011: shl
    IL_0012: xor
    IL_0013: stind.i8
    IL_0014: ldarg.0
    IL_0015: ret

}
ref sbyte toggle(ref sbyte src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i1
    IL_0003: ldc.i4.1
    IL_0004: ldarg.1
    IL_0005: ldc.i4.s 31
    IL_0007: and
    IL_0008: shl
    IL_0009: conv.i1
    IL_000A: xor
    IL_000B: conv.i1
    IL_000C: stind.i1
    IL_000D: ldarg.0
    IL_000E: ret

}
ref byte toggle(ref byte src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u1
    IL_0003: ldc.i4.1
    IL_0004: ldarg.1
    IL_0005: ldc.i4.s 31
    IL_0007: and
    IL_0008: shl
    IL_0009: conv.u1
    IL_000A: xor
    IL_000B: conv.u1
    IL_000C: stind.i1
    IL_000D: ldarg.0
    IL_000E: ret

}
ref short toggle(ref short src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i2
    IL_0003: ldc.i4.1
    IL_0004: ldarg.1
    IL_0005: ldc.i4.s 31
    IL_0007: and
    IL_0008: shl
    IL_0009: conv.i2
    IL_000A: xor
    IL_000B: conv.i2
    IL_000C: stind.i2
    IL_000D: ldarg.0
    IL_000E: ret

}
ref ushort toggle(ref ushort src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u2
    IL_0003: ldc.i4.1
    IL_0004: ldarg.1
    IL_0005: ldc.i4.s 31
    IL_0007: and
    IL_0008: shl
    IL_0009: conv.u2
    IL_000A: xor
    IL_000B: conv.u2
    IL_000C: stind.i2
    IL_000D: ldarg.0
    IL_000E: ret

}
ref int toggle(ref int src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i4
    IL_0003: ldc.i4.1
    IL_0004: ldarg.1
    IL_0005: ldc.i4.s 31
    IL_0007: and
    IL_0008: shl
    IL_0009: xor
    IL_000A: stind.i4
    IL_000B: ldarg.0
    IL_000C: ret

}
ref uint toggle(ref uint src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u4
    IL_0003: ldc.i4.1
    IL_0004: ldarg.1
    IL_0005: ldc.i4.s 31
    IL_0007: and
    IL_0008: shl
    IL_0009: xor
    IL_000A: stind.i4
    IL_000B: ldarg.0
    IL_000C: ret

}
ref long toggle(ref long src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldc.i4.1
    IL_0004: conv.i8
    IL_0005: ldarg.1
    IL_0006: ldc.i4.s 63
    IL_0008: and
    IL_0009: shl
    IL_000A: xor
    IL_000B: stind.i8
    IL_000C: ldarg.0
    IL_000D: ret

}
ref ulong toggle(ref ulong src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldc.i4.1
    IL_0004: conv.i8
    IL_0005: ldarg.1
    IL_0006: ldc.i4.s 63
    IL_0008: and
    IL_0009: shl
    IL_000A: xor
    IL_000B: stind.i8
    IL_000C: ldarg.0
    IL_000D: ret

}
ref float toggle(ref float src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int32& System.Runtime.CompilerServices.Unsafe::As<System.Single,System.Int32>(System.Single&)
    IL_0006: stloc.0
    IL_0007: ldloc.0
    IL_0008: ldloc.0
    IL_0009: ldind.i4
    IL_000A: ldc.i4.1
    IL_000B: ldarg.1
    IL_000C: ldc.i4.s 31
    IL_000E: and
    IL_000F: shl
    IL_0010: xor
    IL_0011: stind.i4
    IL_0012: ldarg.0
    IL_0013: ret

}
ref double toggle(ref double src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int64& System.Runtime.CompilerServices.Unsafe::As<System.Double,System.Int64>(System.Double&)
    IL_0006: stloc.0
    IL_0007: ldloc.0
    IL_0008: ldloc.0
    IL_0009: ldind.i8
    IL_000A: ldc.i4.1
    IL_000B: conv.i8
    IL_000C: ldarg.1
    IL_000D: ldc.i4.s 63
    IL_000F: and
    IL_0010: shl
    IL_0011: xor
    IL_0012: stind.i8
    IL_0013: ldarg.0
    IL_0014: ret

}
byte zerohi(byte src, int index)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi2::ZeroHighBits(System.UInt32,System.UInt32)
    IL_0007: conv.u1
    IL_0008: ret

}
ushort zerohi(ushort src, int index)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi2::ZeroHighBits(System.UInt32,System.UInt32)
    IL_0007: conv.u2
    IL_0008: ret

}
uint zerohi(uint src, int index)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi2::ZeroHighBits(System.UInt32,System.UInt32)
    IL_0007: ret

}
ulong zerohi(ulong src, int index)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: conv.u8
    IL_0003: call System.UInt64 System.Runtime.Intrinsics.X86.Bmi2/X64::ZeroHighBits(System.UInt64,System.UInt64)
    IL_0008: ret

}
uint butterfly(N8 n, uint x)
{
    IL_0000: ldarg.1
    IL_0001: ldc.i4 16776960
    IL_0006: ldc.i4.8
    IL_0007: call System.UInt32 Z0.Bits::butterfly<System.UInt32>(System.UInt32,System.UInt32,System.Int32)
    IL_000C: ret

}
ulong butterfly(N8 n, ulong x)
{
    IL_0000: ldarg.1
    IL_0001: ldc.i8 72056494543077120
    IL_000A: ldc.i4.8
    IL_000B: call System.UInt64 Z0.Bits::butterfly<System.UInt64>(System.UInt64,System.UInt64,System.Int32)
    IL_0010: ret

}
ulong butterfly(N16 n, ulong x)
{
    IL_0000: ldarg.1
    IL_0001: ldc.i8 281474976645120
    IL_000A: ldc.i4.s 16
    IL_000C: call System.UInt64 Z0.Bits::butterfly<System.UInt64>(System.UInt64,System.UInt64,System.Int32)
    IL_0011: ret

}
byte clear(byte src, int first, int last)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: ldarg.1
    IL_0003: call System.Byte Z0.Bits::extract(System.Byte,System.Int32,System.Int32)
    IL_0008: stloc.0
    IL_0009: ldarg.0
    IL_000A: ldarg.2
    IL_000B: ldc.i4.1
    IL_000C: add
    IL_000D: ldc.i4.8
    IL_000E: ldarg.2
    IL_000F: sub
    IL_0010: call System.Byte Z0.Bits::extract(System.Byte,System.Int32,System.Int32)
    IL_0015: stloc.1
    IL_0016: ldloc.1
    IL_0017: ldarg.2
    IL_0018: ldarg.1
    IL_0019: sub
    IL_001A: ldc.i4.s 31
    IL_001C: and
    IL_001D: shl
    IL_001E: ldarg.1
    IL_001F: ldc.i4.1
    IL_0020: add
    IL_0021: ldc.i4.s 31
    IL_0023: and
    IL_0024: shl
    IL_0025: ldloc.0
    IL_0026: or
    IL_0027: conv.u1
    IL_0028: stloc.2
    IL_0029: ldloc.2
    IL_002A: ret

}
ushort clear(ushort src, int first, int last)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: ldarg.1
    IL_0003: call System.UInt16 Z0.Bits::extract(System.UInt16,System.Int32,System.Int32)
    IL_0008: stloc.0
    IL_0009: ldarg.0
    IL_000A: ldarg.2
    IL_000B: ldc.i4.1
    IL_000C: add
    IL_000D: ldc.i4.s 16
    IL_000F: ldarg.2
    IL_0010: sub
    IL_0011: call System.UInt16 Z0.Bits::extract(System.UInt16,System.Int32,System.Int32)
    IL_0016: stloc.1
    IL_0017: ldloc.1
    IL_0018: ldarg.2
    IL_0019: ldarg.1
    IL_001A: sub
    IL_001B: ldc.i4.s 31
    IL_001D: and
    IL_001E: shl
    IL_001F: ldarg.1
    IL_0020: ldc.i4.1
    IL_0021: add
    IL_0022: ldc.i4.s 31
    IL_0024: and
    IL_0025: shl
    IL_0026: ldloc.0
    IL_0027: or
    IL_0028: conv.u2
    IL_0029: stloc.2
    IL_002A: ldloc.2
    IL_002B: ret

}
uint clear(uint src, int first, int last)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: ldarg.1
    IL_0003: call System.UInt32 Z0.Bits::extract(System.UInt32,System.Int32,System.Int32)
    IL_0008: stloc.0
    IL_0009: ldarg.0
    IL_000A: ldarg.2
    IL_000B: ldc.i4.1
    IL_000C: add
    IL_000D: ldc.i4.s 32
    IL_000F: ldarg.2
    IL_0010: sub
    IL_0011: call System.UInt32 Z0.Bits::extract(System.UInt32,System.Int32,System.Int32)
    IL_0016: stloc.1
    IL_0017: ldloc.1
    IL_0018: ldarg.2
    IL_0019: ldarg.1
    IL_001A: sub
    IL_001B: ldc.i4.s 31
    IL_001D: and
    IL_001E: shl
    IL_001F: ldarg.1
    IL_0020: ldc.i4.1
    IL_0021: add
    IL_0022: ldc.i4.s 31
    IL_0024: and
    IL_0025: shl
    IL_0026: ldloc.0
    IL_0027: or
    IL_0028: stloc.2
    IL_0029: ldloc.2
    IL_002A: ret

}
ulong clear(ulong src, int first, int last)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: ldarg.1
    IL_0003: call System.UInt64 Z0.Bits::extract(System.UInt64,System.Int32,System.Int32)
    IL_0008: stloc.0
    IL_0009: ldarg.0
    IL_000A: ldarg.2
    IL_000B: ldc.i4.1
    IL_000C: add
    IL_000D: ldc.i4.s 64
    IL_000F: ldarg.2
    IL_0010: sub
    IL_0011: call System.UInt64 Z0.Bits::extract(System.UInt64,System.Int32,System.Int32)
    IL_0016: stloc.1
    IL_0017: ldloc.1
    IL_0018: ldarg.2
    IL_0019: ldarg.1
    IL_001A: sub
    IL_001B: ldc.i4.s 63
    IL_001D: and
    IL_001E: shl
    IL_001F: ldarg.1
    IL_0020: ldc.i4.1
    IL_0021: add
    IL_0022: ldc.i4.s 63
    IL_0024: and
    IL_0025: shl
    IL_0026: ldloc.0
    IL_0027: or
    IL_0028: stloc.2
    IL_0029: ldloc.2
    IL_002A: ret

}
int effwidth(in byte src)
{
    IL_0000: ldc.i4.8
    IL_0001: ldarg.0
    IL_0002: ldind.u1
    IL_0003: call System.Int32 Z0.Bits::nlz(System.Byte)
    IL_0008: sub
    IL_0009: ret

}
int effwidth(in ushort src)
{
    IL_0000: ldc.i4.s 16
    IL_0002: ldarg.0
    IL_0003: ldind.u2
    IL_0004: call System.Int32 Z0.Bits::nlz(System.UInt16)
    IL_0009: sub
    IL_000A: ret

}
int effwidth(uint src)
{
    IL_0000: ldc.i4.s 32
    IL_0002: ldarg.0
    IL_0003: call System.Int32 Z0.Bits::nlz(System.UInt32)
    IL_0008: sub
    IL_0009: ret

}
int effwidth(ulong src)
{
    IL_0000: ldc.i4.s 64
    IL_0002: ldarg.0
    IL_0003: call System.Int32 Z0.Bits::nlz(System.UInt64)
    IL_0008: sub
    IL_0009: ret

}
sbyte extract(sbyte src, byte start, byte length)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi1::BitFieldExtract(System.UInt32,System.Byte,System.Byte)
    IL_0008: conv.i1
    IL_0009: ret

}
sbyte extract(sbyte src, int start, int length)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: conv.u1
    IL_0003: ldarg.2
    IL_0004: conv.u1
    IL_0005: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi1::BitFieldExtract(System.UInt32,System.Byte,System.Byte)
    IL_000A: conv.i1
    IL_000B: ret

}
byte extract(byte src, byte start, byte length)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi1::BitFieldExtract(System.UInt32,System.Byte,System.Byte)
    IL_0008: conv.u1
    IL_0009: ret

}
byte extract(byte src, int start, int length)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: conv.u1
    IL_0003: ldarg.2
    IL_0004: conv.u1
    IL_0005: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi1::BitFieldExtract(System.UInt32,System.Byte,System.Byte)
    IL_000A: conv.u1
    IL_000B: ret

}
short extract(short src, byte start, byte length)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi1::BitFieldExtract(System.UInt32,System.Byte,System.Byte)
    IL_0008: conv.i2
    IL_0009: ret

}
short extract(short src, int start, int length)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: conv.u1
    IL_0003: ldarg.2
    IL_0004: conv.u1
    IL_0005: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi1::BitFieldExtract(System.UInt32,System.Byte,System.Byte)
    IL_000A: conv.i2
    IL_000B: ret

}
ushort extract(ushort src, byte start, byte length)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi1::BitFieldExtract(System.UInt32,System.Byte,System.Byte)
    IL_0008: conv.u2
    IL_0009: ret

}
ushort extract(ushort src, int start, int length)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: conv.u1
    IL_0003: ldarg.2
    IL_0004: conv.u1
    IL_0005: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi1::BitFieldExtract(System.UInt32,System.Byte,System.Byte)
    IL_000A: conv.u2
    IL_000B: ret

}
uint extract(uint src, byte start, byte length)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi1::BitFieldExtract(System.UInt32,System.Byte,System.Byte)
    IL_0008: ret

}
uint extract(uint src, int start, int length)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: conv.u1
    IL_0003: ldarg.2
    IL_0004: conv.u1
    IL_0005: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi1::BitFieldExtract(System.UInt32,System.Byte,System.Byte)
    IL_000A: ret

}
int extract(int src, byte start, byte length)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi1::BitFieldExtract(System.UInt32,System.Byte,System.Byte)
    IL_0008: ret

}
int extract(int src, int start, int length)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: conv.u1
    IL_0003: ldarg.2
    IL_0004: conv.u1
    IL_0005: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi1::BitFieldExtract(System.UInt32,System.Byte,System.Byte)
    IL_000A: ret

}
long extract(long src, byte start, byte length)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.UInt64 System.Runtime.Intrinsics.X86.Bmi1/X64::BitFieldExtract(System.UInt64,System.Byte,System.Byte)
    IL_0008: ret

}
long extract(long src, int start, int length)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: conv.u1
    IL_0003: ldarg.2
    IL_0004: conv.u1
    IL_0005: call System.UInt64 System.Runtime.Intrinsics.X86.Bmi1/X64::BitFieldExtract(System.UInt64,System.Byte,System.Byte)
    IL_000A: ret

}
ulong extract(ulong src, byte start, byte length)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.UInt64 System.Runtime.Intrinsics.X86.Bmi1/X64::BitFieldExtract(System.UInt64,System.Byte,System.Byte)
    IL_0008: ret

}
ulong extract(ulong src, int start, int length)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: conv.u1
    IL_0003: ldarg.2
    IL_0004: conv.u1
    IL_0005: call System.UInt64 System.Runtime.Intrinsics.X86.Bmi1/X64::BitFieldExtract(System.UInt64,System.Byte,System.Byte)
    IL_000A: ret

}
uint extract(float src, byte start, byte length)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int32 Z0.MathX::ToBits(System.Single)
    IL_0006: ldarg.1
    IL_0007: ldarg.2
    IL_0008: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi1::BitFieldExtract(System.UInt32,System.Byte,System.Byte)
    IL_000D: ret

}
uint extract(float src, int start, int length)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int32 Z0.MathX::ToBits(System.Single)
    IL_0006: ldarg.1
    IL_0007: conv.u1
    IL_0008: ldarg.2
    IL_0009: conv.u1
    IL_000A: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi1::BitFieldExtract(System.UInt32,System.Byte,System.Byte)
    IL_000F: ret

}
ulong extract(double src, byte start, byte length)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int64 Z0.MathX::ToBits(System.Double)
    IL_0006: ldarg.1
    IL_0007: ldarg.2
    IL_0008: call System.UInt64 System.Runtime.Intrinsics.X86.Bmi1/X64::BitFieldExtract(System.UInt64,System.Byte,System.Byte)
    IL_000D: ret

}
ulong extract(double src, int start, int length)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int64 Z0.MathX::ToBits(System.Double)
    IL_0006: ldarg.1
    IL_0007: conv.u1
    IL_0008: ldarg.2
    IL_0009: conv.u1
    IL_000A: call System.UInt64 System.Runtime.Intrinsics.X86.Bmi1/X64::BitFieldExtract(System.UInt64,System.Byte,System.Byte)
    IL_000F: ret

}
byte gather(byte src, byte mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi2::ParallelBitExtract(System.UInt32,System.UInt32)
    IL_0007: conv.u1
    IL_0008: ret

}
sbyte gather(sbyte src, sbyte mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi2::ParallelBitExtract(System.UInt32,System.UInt32)
    IL_0007: conv.i1
    IL_0008: ret

}
short gather(short src, short mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi2::ParallelBitExtract(System.UInt32,System.UInt32)
    IL_0007: conv.i2
    IL_0008: ret

}
ushort gather(ushort src, ushort mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi2::ParallelBitExtract(System.UInt32,System.UInt32)
    IL_0007: conv.u2
    IL_0008: ret

}
int gather(int src, int mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi2::ParallelBitExtract(System.UInt32,System.UInt32)
    IL_0007: ret

}
uint gather(uint src, uint mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi2::ParallelBitExtract(System.UInt32,System.UInt32)
    IL_0007: ret

}
long gather(long src, long mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 System.Runtime.Intrinsics.X86.Bmi2/X64::ParallelBitExtract(System.UInt64,System.UInt64)
    IL_0007: ret

}
ulong gather(ulong src, ulong mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 System.Runtime.Intrinsics.X86.Bmi2/X64::ParallelBitExtract(System.UInt64,System.UInt64)
    IL_0007: ret

}
uint gather(float src, uint mask)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int32 Z0.MathX::ToBits(System.Single)
    IL_0006: ldarg.1
    IL_0007: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi2::ParallelBitExtract(System.UInt32,System.UInt32)
    IL_000C: ret

}
ulong gather(double src, ulong mask)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int64 Z0.MathX::ToBits(System.Double)
    IL_0006: ldarg.1
    IL_0007: call System.UInt64 System.Runtime.Intrinsics.X86.Bmi2/X64::ParallelBitExtract(System.UInt64,System.UInt64)
    IL_000C: ret

}
ref byte gather(byte src, byte mask, ref byte dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: call System.Byte Z0.Bits::gather(System.Byte,System.Byte)
    IL_0008: stind.i1
    IL_0009: ldarg.2
    IL_000A: ret

}
ref sbyte gather(sbyte src, sbyte mask, ref sbyte dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: call System.SByte Z0.Bits::gather(System.SByte,System.SByte)
    IL_0008: stind.i1
    IL_0009: ldarg.2
    IL_000A: ret

}
ref short gather(short src, short mask, ref short dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: call System.Int16 Z0.Bits::gather(System.Int16,System.Int16)
    IL_0008: stind.i2
    IL_0009: ldarg.2
    IL_000A: ret

}
ref ushort gather(ushort src, ushort mask, ref ushort dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: call System.UInt16 Z0.Bits::gather(System.UInt16,System.UInt16)
    IL_0008: stind.i2
    IL_0009: ldarg.2
    IL_000A: ret

}
ref int gather(int src, int mask, ref int dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: call System.Int32 Z0.Bits::gather(System.Int32,System.Int32)
    IL_0008: stind.i4
    IL_0009: ldarg.2
    IL_000A: ret

}
ref uint gather(uint src, uint mask, ref uint dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: call System.UInt32 Z0.Bits::gather(System.UInt32,System.UInt32)
    IL_0008: stind.i4
    IL_0009: ldarg.2
    IL_000A: ret

}
ref long gather(long src, long mask, ref long dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: call System.Int64 Z0.Bits::gather(System.Int64,System.Int64)
    IL_0008: stind.i8
    IL_0009: ldarg.2
    IL_000A: ret

}
ref ulong gather(ulong src, ulong mask, ref ulong dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: call System.UInt64 Z0.Bits::gather(System.UInt64,System.UInt64)
    IL_0008: stind.i8
    IL_0009: ldarg.2
    IL_000A: ret

}
sbyte hi(sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.4
    IL_0002: shr
    IL_0003: conv.i1
    IL_0004: ret

}
byte hi(byte src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.4
    IL_0002: shr
    IL_0003: conv.u1
    IL_0004: ret

}
sbyte hi(short src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.8
    IL_0002: shr
    IL_0003: conv.i1
    IL_0004: ret

}
byte hi(ushort src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.8
    IL_0002: shr
    IL_0003: conv.u1
    IL_0004: ret

}
short hi(int src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.s 16
    IL_0003: shr
    IL_0004: conv.i2
    IL_0005: ret

}
ushort hi(uint src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.s 16
    IL_0003: shr.un
    IL_0004: conv.u2
    IL_0005: ret

}
int hi(long src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.s 32
    IL_0003: shr
    IL_0004: conv.i4
    IL_0005: ret

}
uint hi(ulong src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.s 32
    IL_0003: shr.un
    IL_0004: conv.u4
    IL_0005: ret

}
byte inject(byte src, byte dst, int first, int count)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.3
    IL_0002: add
    IL_0003: stloc.0
    IL_0004: ldarg.1
    IL_0005: ldarg.2
    IL_0006: call System.Byte Z0.Bits::zerohi(System.Byte,System.Int32)
    IL_000B: stloc.1
    IL_000C: ldarg.0
    IL_000D: ldarg.2
    IL_000E: ldc.i4.s 31
    IL_0010: and
    IL_0011: shl
    IL_0012: conv.u1
    IL_0013: stloc.2
    IL_0014: ldarg.1
    IL_0015: ldloc.0
    IL_0016: ldc.i4.8
    IL_0017: ldloc.0
    IL_0018: sub
    IL_0019: call System.Byte Z0.Bits::extract(System.Byte,System.Int32,System.Int32)
    IL_001E: ldloc.0
    IL_001F: ldc.i4.s 31
    IL_0021: and
    IL_0022: shl
    IL_0023: conv.u1
    IL_0024: stloc.3
    IL_0025: ldloc.1
    IL_0026: ldloc.2
    IL_0027: or
    IL_0028: ldloc.3
    IL_0029: or
    IL_002A: conv.u1
    IL_002B: ret

}
ushort inject(ushort src, ushort dst, int first, int count)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.3
    IL_0002: add
    IL_0003: stloc.0
    IL_0004: ldarg.1
    IL_0005: ldarg.2
    IL_0006: call System.UInt16 Z0.Bits::zerohi(System.UInt16,System.Int32)
    IL_000B: stloc.1
    IL_000C: ldarg.0
    IL_000D: ldarg.2
    IL_000E: call System.UInt16 Z0.math::sll(System.UInt16,System.Int32)
    IL_0013: stloc.2
    IL_0014: ldarg.1
    IL_0015: ldloc.0
    IL_0016: ldc.i4.s 16
    IL_0018: ldloc.0
    IL_0019: sub
    IL_001A: call System.UInt16 Z0.Bits::extract(System.UInt16,System.Int32,System.Int32)
    IL_001F: ldloc.0
    IL_0020: call System.UInt16 Z0.math::sll(System.UInt16,System.Int32)
    IL_0025: stloc.3
    IL_0026: ldloc.1
    IL_0027: ldloc.2
    IL_0028: ldloc.3
    IL_0029: call System.UInt16 Z0.math::or(System.UInt16,System.UInt16,System.UInt16)
    IL_002E: ret

}
uint inject(uint src, uint dst, int first, int count)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.3
    IL_0002: add
    IL_0003: stloc.0
    IL_0004: ldarg.1
    IL_0005: ldarg.2
    IL_0006: call System.UInt32 Z0.Bits::zerohi(System.UInt32,System.Int32)
    IL_000B: stloc.1
    IL_000C: ldarg.0
    IL_000D: ldarg.2
    IL_000E: ldc.i4.s 31
    IL_0010: and
    IL_0011: shl
    IL_0012: stloc.2
    IL_0013: ldarg.1
    IL_0014: ldloc.0
    IL_0015: ldc.i4.s 32
    IL_0017: ldloc.0
    IL_0018: sub
    IL_0019: call System.UInt32 Z0.Bits::extract(System.UInt32,System.Int32,System.Int32)
    IL_001E: ldloc.0
    IL_001F: ldc.i4.s 31
    IL_0021: and
    IL_0022: shl
    IL_0023: stloc.3
    IL_0024: ldloc.1
    IL_0025: ldloc.2
    IL_0026: or
    IL_0027: ldloc.3
    IL_0028: or
    IL_0029: ret

}
ulong inject(ulong src, ulong dst, int first, int count)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.3
    IL_0002: add
    IL_0003: stloc.0
    IL_0004: ldarg.1
    IL_0005: ldarg.2
    IL_0006: call System.UInt64 Z0.Bits::zerohi(System.UInt64,System.Int32)
    IL_000B: stloc.1
    IL_000C: ldarg.0
    IL_000D: ldarg.2
    IL_000E: ldc.i4.s 63
    IL_0010: and
    IL_0011: shl
    IL_0012: stloc.2
    IL_0013: ldarg.1
    IL_0014: ldloc.0
    IL_0015: ldc.i4.s 64
    IL_0017: ldloc.0
    IL_0018: sub
    IL_0019: call System.UInt64 Z0.Bits::extract(System.UInt64,System.Int32,System.Int32)
    IL_001E: ldloc.0
    IL_001F: ldc.i4.s 63
    IL_0021: and
    IL_0022: shl
    IL_0023: stloc.3
    IL_0024: ldloc.1
    IL_0025: ldloc.2
    IL_0026: or
    IL_0027: ldloc.3
    IL_0028: or
    IL_0029: ret

}
sbyte lo(sbyte src)
{
    IL_0000: ldc.i4.s 15
    IL_0002: ldarg.0
    IL_0003: and
    IL_0004: conv.i1
    IL_0005: ret

}
byte lo(byte src)
{
    IL_0000: ldc.i4.s 15
    IL_0002: ldarg.0
    IL_0003: and
    IL_0004: conv.u1
    IL_0005: ret

}
sbyte lo(short src)
{
    IL_0000: ldarg.0
    IL_0001: conv.i1
    IL_0002: ret

}
byte lo(ushort src)
{
    IL_0000: ldarg.0
    IL_0001: conv.u1
    IL_0002: ret

}
short lo(int src)
{
    IL_0000: ldarg.0
    IL_0001: conv.i2
    IL_0002: ret

}
ushort lo(uint src)
{
    IL_0000: ldarg.0
    IL_0001: conv.u2
    IL_0002: ret

}
int lo(long src)
{
    IL_0000: ldarg.0
    IL_0001: conv.i4
    IL_0002: ret

}
uint lo(ulong src)
{
    IL_0000: ldarg.0
    IL_0001: conv.u4
    IL_0002: ret

}
byte loff(byte src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldc.i4.1
    IL_0003: sub
    IL_0004: and
    IL_0005: conv.u1
    IL_0006: ret

}
ushort loff(ushort src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldc.i4.1
    IL_0003: sub
    IL_0004: and
    IL_0005: conv.u2
    IL_0006: ret

}
uint loff(uint src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldc.i4.1
    IL_0003: sub
    IL_0004: and
    IL_0005: ret

}
ulong loff(ulong src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldc.i4.1
    IL_0003: conv.i8
    IL_0004: sub
    IL_0005: and
    IL_0006: ret

}
uint log2(byte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int32 System.Numerics.BitOperations::Log2(System.UInt32)
    IL_0006: ret

}
uint log2(ushort src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int32 System.Numerics.BitOperations::Log2(System.UInt32)
    IL_0006: ret

}
uint log2(uint src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int32 System.Numerics.BitOperations::Log2(System.UInt32)
    IL_0006: ret

}
uint log2(ulong src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int32 System.Numerics.BitOperations::Log2(System.UInt64)
    IL_0006: ret

}
int lsbpos(byte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int32 Z0.Bits::ntz(System.Byte)
    IL_0006: ret

}
int lsbpos(ushort src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int32 Z0.Bits::ntz(System.UInt16)
    IL_0006: ret

}
int lsbpos(uint src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int32 Z0.Bits::ntz(System.UInt32)
    IL_0006: ret

}
int lsbpos(ulong src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int32 Z0.Bits::ntz(System.UInt64)
    IL_0006: ret

}
ref ulong mask(ref ulong dst, int exp0)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldc.i4.1
    IL_0004: conv.i8
    IL_0005: ldarg.1
    IL_0006: ldc.i4.s 63
    IL_0008: and
    IL_0009: shl
    IL_000A: or
    IL_000B: stind.i8
    IL_000C: ldarg.0
    IL_000D: ret

}
ref ulong mask(ref ulong dst, int exp0, int exp1)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64& Z0.Bits::mask(System.UInt64&,System.Int32)
    IL_0007: pop
    IL_0008: ldarg.0
    IL_0009: ldarg.2
    IL_000A: call System.UInt64& Z0.Bits::mask(System.UInt64&,System.Int32)
    IL_000F: pop
    IL_0010: ldarg.0
    IL_0011: ret

}
ref ulong mask(ref ulong dst, int exp0, int exp1, int exp2)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.UInt64& Z0.Bits::mask(System.UInt64&,System.Int32,System.Int32)
    IL_0008: pop
    IL_0009: ldarg.0
    IL_000A: ldarg.3
    IL_000B: call System.UInt64& Z0.Bits::mask(System.UInt64&,System.Int32)
    IL_0010: pop
    IL_0011: ldarg.0
    IL_0012: ret

}
ref ulong mask(ref ulong dst, int exp0, int exp1, int exp2, int exp3)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.UInt64& Z0.Bits::mask(System.UInt64&,System.Int32,System.Int32)
    IL_0008: pop
    IL_0009: ldarg.0
    IL_000A: ldarg.3
    IL_000B: ldarg.s exp3
    IL_000D: call System.UInt64& Z0.Bits::mask(System.UInt64&,System.Int32,System.Int32)
    IL_0012: pop
    IL_0013: ldarg.0
    IL_0014: ret

}
ref ulong mask(ref ulong dst, int exp0, int exp1, int exp2, int exp3, int exp4)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: ldarg.3
    IL_0004: ldarg.s exp3
    IL_0006: call System.UInt64& Z0.Bits::mask(System.UInt64&,System.Int32,System.Int32,System.Int32,System.Int32)
    IL_000B: pop
    IL_000C: ldarg.0
    IL_000D: ldarg.s exp4
    IL_000F: call System.UInt64& Z0.Bits::mask(System.UInt64&,System.Int32)
    IL_0014: pop
    IL_0015: ldarg.0
    IL_0016: ret

}
ref ulong mask(ref ulong dst, int exp0, int exp1, int exp2, int exp3, int exp4, int exp5)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: ldarg.3
    IL_0004: ldarg.s exp3
    IL_0006: call System.UInt64& Z0.Bits::mask(System.UInt64&,System.Int32,System.Int32,System.Int32,System.Int32)
    IL_000B: pop
    IL_000C: ldarg.0
    IL_000D: ldarg.s exp4
    IL_000F: ldarg.s exp5
    IL_0011: call System.UInt64& Z0.Bits::mask(System.UInt64&,System.Int32,System.Int32)
    IL_0016: pop
    IL_0017: ldarg.0
    IL_0018: ret

}
ref ulong mask(ref ulong dst, int exp0, int exp1, int exp2, int exp3, int exp4, int exp5, int exp6)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: ldarg.3
    IL_0004: ldarg.s exp3
    IL_0006: call System.UInt64& Z0.Bits::mask(System.UInt64&,System.Int32,System.Int32,System.Int32,System.Int32)
    IL_000B: pop
    IL_000C: ldarg.0
    IL_000D: ldarg.s exp4
    IL_000F: ldarg.s exp5
    IL_0011: ldarg.s exp6
    IL_0013: call System.UInt64& Z0.Bits::mask(System.UInt64&,System.Int32,System.Int32,System.Int32)
    IL_0018: pop
    IL_0019: ldarg.0
    IL_001A: ret

}
ref ulong mask(ref ulong dst, int exp0, int exp1, int exp2, int exp3, int exp4, int exp5, int exp6, int exp7)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldc.i4.1
    IL_0004: conv.i8
    IL_0005: ldarg.1
    IL_0006: ldc.i4.s 63
    IL_0008: and
    IL_0009: shl
    IL_000A: ldc.i4.1
    IL_000B: conv.i8
    IL_000C: ldarg.2
    IL_000D: ldc.i4.s 63
    IL_000F: and
    IL_0010: shl
    IL_0011: or
    IL_0012: ldc.i4.1
    IL_0013: conv.i8
    IL_0014: ldarg.3
    IL_0015: ldc.i4.s 63
    IL_0017: and
    IL_0018: shl
    IL_0019: or
    IL_001A: ldc.i4.1
    IL_001B: conv.i8
    IL_001C: ldarg.s exp3
    IL_001E: ldc.i4.s 63
    IL_0020: and
    IL_0021: shl
    IL_0022: or
    IL_0023: ldc.i4.1
    IL_0024: conv.i8
    IL_0025: ldarg.s exp4
    IL_0027: ldc.i4.s 63
    IL_0029: and
    IL_002A: shl
    IL_002B: or
    IL_002C: ldc.i4.1
    IL_002D: conv.i8
    IL_002E: ldarg.s exp6
    IL_0030: ldc.i4.s 63
    IL_0032: and
    IL_0033: shl
    IL_0034: or
    IL_0035: ldc.i4.1
    IL_0036: conv.i8
    IL_0037: ldarg.s exp6
    IL_0039: ldc.i4.s 63
    IL_003B: and
    IL_003C: shl
    IL_003D: or
    IL_003E: ldc.i4.1
    IL_003F: conv.i8
    IL_0040: ldarg.s exp7
    IL_0042: ldc.i4.s 63
    IL_0044: and
    IL_0045: shl
    IL_0046: or
    IL_0047: or
    IL_0048: stind.i8
    IL_0049: ldarg.0
    IL_004A: ret

}
byte mix(N0 parity, byte x, byte y)
{
    IL_0000: ldc.i4.s 85
    IL_0002: stloc.0
    IL_0003: ldarg.1
    IL_0004: ldloc.0
    IL_0005: call System.UInt32 Z0.BitParts::select(System.UInt32,Z0.BitParts/Even8)
    IL_000A: ldc.i4.s 85
    IL_000C: call System.UInt32 Z0.BitParts::project(System.UInt32,Z0.BitParts/Even8)
    IL_0011: stloc.1
    IL_0012: ldarg.2
    IL_0013: ldloc.0
    IL_0014: call System.UInt32 Z0.BitParts::select(System.UInt32,Z0.BitParts/Even8)
    IL_0019: ldc.i4 170
    IL_001E: call System.UInt32 Z0.BitParts::project(System.UInt32,Z0.BitParts/Odd8)
    IL_0023: stloc.2
    IL_0024: ldloc.1
    IL_0025: ldloc.2
    IL_0026: or
    IL_0027: stloc.3
    IL_0028: ldloc.3
    IL_0029: conv.u1
    IL_002A: ret

}
byte mix(N1 parity, byte x, byte y)
{
    IL_0000: ldc.i4 170
    IL_0005: stloc.0
    IL_0006: ldarg.1
    IL_0007: ldloc.0
    IL_0008: call System.Byte Z0.BitParts::select(System.Byte,Z0.BitParts/Odd8)
    IL_000D: ldc.i4.s 85
    IL_000F: call System.UInt32 Z0.BitParts::project(System.UInt32,Z0.BitParts/Even8)
    IL_0014: stloc.1
    IL_0015: ldarg.2
    IL_0016: ldloc.0
    IL_0017: call System.Byte Z0.BitParts::select(System.Byte,Z0.BitParts/Odd8)
    IL_001C: ldc.i4 170
    IL_0021: call System.UInt32 Z0.BitParts::project(System.UInt32,Z0.BitParts/Odd8)
    IL_0026: stloc.2
    IL_0027: ldloc.1
    IL_0028: ldloc.2
    IL_0029: or
    IL_002A: stloc.3
    IL_002B: ldloc.3
    IL_002C: conv.u1
    IL_002D: ret

}
ushort mix(N0 parity, ushort x, ushort y)
{
    IL_0000: ldc.i4 21845
    IL_0005: stloc.0
    IL_0006: ldarg.1
    IL_0007: ldloc.0
    IL_0008: call System.UInt32 Z0.BitParts::select(System.UInt32,Z0.BitParts/Even16)
    IL_000D: ldc.i4 21845
    IL_0012: call System.UInt32 Z0.BitParts::project(System.UInt32,Z0.BitParts/Even16)
    IL_0017: stloc.1
    IL_0018: ldarg.2
    IL_0019: ldloc.0
    IL_001A: call System.UInt32 Z0.BitParts::select(System.UInt32,Z0.BitParts/Even16)
    IL_001F: ldc.i4 43690
    IL_0024: call System.UInt32 Z0.BitParts::project(System.UInt32,Z0.BitParts/Odd16)
    IL_0029: stloc.2
    IL_002A: ldloc.1
    IL_002B: ldloc.2
    IL_002C: or
    IL_002D: stloc.3
    IL_002E: ldloc.3
    IL_002F: conv.u2
    IL_0030: ret

}
ushort mix(N1 parity, ushort x, ushort y)
{
    IL_0000: ldc.i4 43690
    IL_0005: stloc.0
    IL_0006: ldarg.1
    IL_0007: ldloc.0
    IL_0008: call System.UInt16 Z0.BitParts::select(System.UInt16,Z0.BitParts/Odd16)
    IL_000D: ldc.i4 21845
    IL_0012: call System.UInt32 Z0.BitParts::project(System.UInt32,Z0.BitParts/Even16)
    IL_0017: stloc.1
    IL_0018: ldarg.2
    IL_0019: ldloc.0
    IL_001A: call System.UInt16 Z0.BitParts::select(System.UInt16,Z0.BitParts/Odd16)
    IL_001F: ldc.i4 43690
    IL_0024: call System.UInt32 Z0.BitParts::project(System.UInt32,Z0.BitParts/Odd16)
    IL_0029: stloc.2
    IL_002A: ldloc.1
    IL_002B: ldloc.2
    IL_002C: or
    IL_002D: stloc.3
    IL_002E: ldloc.3
    IL_002F: conv.u2
    IL_0030: ret

}
uint mix(N0 parity, uint x, uint y)
{
    IL_0000: ldc.i4 1431655765
    IL_0005: stloc.0
    IL_0006: ldarg.1
    IL_0007: ldloc.0
    IL_0008: call System.UInt32 Z0.BitParts::select(System.UInt32,Z0.BitParts/Even32)
    IL_000D: ldc.i4 1431655765
    IL_0012: call System.UInt32 Z0.BitParts::project(System.UInt32,Z0.BitParts/Even32)
    IL_0017: stloc.1
    IL_0018: ldarg.2
    IL_0019: ldloc.0
    IL_001A: call System.UInt32 Z0.BitParts::select(System.UInt32,Z0.BitParts/Even32)
    IL_001F: ldc.i4 -1431655766
    IL_0024: call System.UInt32 Z0.BitParts::project(System.UInt32,Z0.BitParts/Odd32)
    IL_0029: stloc.2
    IL_002A: ldloc.1
    IL_002B: ldloc.2
    IL_002C: or
    IL_002D: stloc.3
    IL_002E: ldloc.3
    IL_002F: ret

}
uint mix(N1 parity, uint x, uint y)
{
    IL_0000: ldc.i4 -1431655766
    IL_0005: stloc.0
    IL_0006: ldarg.1
    IL_0007: ldloc.0
    IL_0008: call System.UInt32 Z0.BitParts::select(System.UInt32,Z0.BitParts/Odd32)
    IL_000D: ldc.i4 1431655765
    IL_0012: call System.UInt32 Z0.BitParts::project(System.UInt32,Z0.BitParts/Even32)
    IL_0017: stloc.1
    IL_0018: ldarg.2
    IL_0019: ldloc.0
    IL_001A: call System.UInt32 Z0.BitParts::select(System.UInt32,Z0.BitParts/Odd32)
    IL_001F: ldc.i4 -1431655766
    IL_0024: call System.UInt32 Z0.BitParts::project(System.UInt32,Z0.BitParts/Odd32)
    IL_0029: stloc.2
    IL_002A: ldloc.1
    IL_002B: ldloc.2
    IL_002C: or
    IL_002D: stloc.3
    IL_002E: ldloc.3
    IL_002F: ret

}
ulong mix(N0 parity, ulong x, ulong y)
{
    IL_0000: ldc.i8 6148914691236517205
    IL_0009: stloc.0
    IL_000A: ldarg.1
    IL_000B: ldloc.0
    IL_000C: call System.UInt64 Z0.BitParts::select(System.UInt64,Z0.BitParts/Even64)
    IL_0011: ldc.i8 6148914691236517205
    IL_001A: call System.UInt64 Z0.BitParts::project(System.UInt64,Z0.BitParts/Even64)
    IL_001F: stloc.1
    IL_0020: ldarg.2
    IL_0021: ldloc.0
    IL_0022: call System.UInt64 Z0.BitParts::select(System.UInt64,Z0.BitParts/Even64)
    IL_0027: ldc.i8 -6148914691236517206
    IL_0030: call System.UInt64 Z0.BitParts::project(System.UInt64,Z0.BitParts/Odd64)
    IL_0035: stloc.2
    IL_0036: ldloc.1
    IL_0037: ldloc.2
    IL_0038: or
    IL_0039: stloc.3
    IL_003A: ldloc.3
    IL_003B: ret

}
ulong mix(N1 parity, ulong x, ulong y)
{
    IL_0000: ldc.i8 -6148914691236517206
    IL_0009: stloc.0
    IL_000A: ldarg.1
    IL_000B: ldloc.0
    IL_000C: call System.UInt64 Z0.BitParts::select(System.UInt64,Z0.BitParts/Odd64)
    IL_0011: ldc.i8 6148914691236517205
    IL_001A: call System.UInt64 Z0.BitParts::project(System.UInt64,Z0.BitParts/Even64)
    IL_001F: stloc.1
    IL_0020: ldarg.2
    IL_0021: ldloc.0
    IL_0022: call System.UInt64 Z0.BitParts::select(System.UInt64,Z0.BitParts/Odd64)
    IL_0027: ldc.i8 -6148914691236517206
    IL_0030: call System.UInt64 Z0.BitParts::project(System.UInt64,Z0.BitParts/Odd64)
    IL_0035: stloc.2
    IL_0036: ldloc.1
    IL_0037: ldloc.2
    IL_0038: or
    IL_0039: stloc.3
    IL_003A: ldloc.3
    IL_003B: ret

}
int msbpos(byte src)
{
    IL_0000: call Z0.BitSize zfunc::bitsize<System.Byte>()
    IL_0005: ldc.i4.1
    IL_0006: call Z0.BitSize Z0.BitSize::op_Implicit(System.Int32)
    IL_000B: call Z0.BitSize Z0.BitSize::op_Subtraction(Z0.BitSize,Z0.BitSize)
    IL_0010: ldarg.0
    IL_0011: call System.Int32 Z0.Bits::nlz(System.Byte)
    IL_0016: call Z0.BitSize Z0.BitSize::op_Implicit(System.Int32)
    IL_001B: call Z0.BitSize Z0.BitSize::op_Subtraction(Z0.BitSize,Z0.BitSize)
    IL_0020: call System.Int32 Z0.BitSize::op_Implicit(Z0.BitSize)
    IL_0025: ret

}
int msbpos(ushort src)
{
    IL_0000: call Z0.BitSize zfunc::bitsize<System.UInt16>()
    IL_0005: ldc.i4.1
    IL_0006: call Z0.BitSize Z0.BitSize::op_Implicit(System.Int32)
    IL_000B: call Z0.BitSize Z0.BitSize::op_Subtraction(Z0.BitSize,Z0.BitSize)
    IL_0010: ldarg.0
    IL_0011: call System.Int32 Z0.Bits::nlz(System.UInt16)
    IL_0016: call Z0.BitSize Z0.BitSize::op_Implicit(System.Int32)
    IL_001B: call Z0.BitSize Z0.BitSize::op_Subtraction(Z0.BitSize,Z0.BitSize)
    IL_0020: call System.Int32 Z0.BitSize::op_Implicit(Z0.BitSize)
    IL_0025: ret

}
int msbpos(uint src)
{
    IL_0000: call Z0.BitSize zfunc::bitsize<System.UInt32>()
    IL_0005: ldc.i4.1
    IL_0006: call Z0.BitSize Z0.BitSize::op_Implicit(System.Int32)
    IL_000B: call Z0.BitSize Z0.BitSize::op_Subtraction(Z0.BitSize,Z0.BitSize)
    IL_0010: ldarg.0
    IL_0011: call System.Int32 Z0.Bits::nlz(System.UInt32)
    IL_0016: call Z0.BitSize Z0.BitSize::op_Implicit(System.Int32)
    IL_001B: call Z0.BitSize Z0.BitSize::op_Subtraction(Z0.BitSize,Z0.BitSize)
    IL_0020: call System.Int32 Z0.BitSize::op_Implicit(Z0.BitSize)
    IL_0025: ret

}
int msbpos(ulong src)
{
    IL_0000: call Z0.BitSize zfunc::bitsize<System.UInt64>()
    IL_0005: ldc.i4.1
    IL_0006: call Z0.BitSize Z0.BitSize::op_Implicit(System.Int32)
    IL_000B: call Z0.BitSize Z0.BitSize::op_Subtraction(Z0.BitSize,Z0.BitSize)
    IL_0010: ldarg.0
    IL_0011: call System.Int32 Z0.Bits::nlz(System.UInt64)
    IL_0016: call Z0.BitSize Z0.BitSize::op_Implicit(System.Int32)
    IL_001B: call Z0.BitSize Z0.BitSize::op_Subtraction(Z0.BitSize,Z0.BitSize)
    IL_0020: call System.Int32 Z0.BitSize::op_Implicit(Z0.BitSize)
    IL_0025: ret

}
int nlz(byte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 System.Runtime.Intrinsics.X86.Lzcnt::LeadingZeroCount(System.UInt32)
    IL_0006: ldc.i4.s 24
    IL_0008: sub
    IL_0009: ret

}
int nlz(ushort src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 System.Runtime.Intrinsics.X86.Lzcnt::LeadingZeroCount(System.UInt32)
    IL_0006: ldc.i4.s 16
    IL_0008: sub
    IL_0009: ret

}
int nlz(uint src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 System.Runtime.Intrinsics.X86.Lzcnt::LeadingZeroCount(System.UInt32)
    IL_0006: ret

}
int nlz(ulong src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt64 System.Runtime.Intrinsics.X86.Lzcnt/X64::LeadingZeroCount(System.UInt64)
    IL_0006: conv.i4
    IL_0007: ret

}
int ntz(sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi1::TrailingZeroCount(System.UInt32)
    IL_0006: ret

}
int ntz(byte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi1::TrailingZeroCount(System.UInt32)
    IL_0006: ret

}
int ntz(short src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi1::TrailingZeroCount(System.UInt32)
    IL_0006: ret

}
int ntz(ushort src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi1::TrailingZeroCount(System.UInt32)
    IL_0006: ret

}
int ntz(int src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi1::TrailingZeroCount(System.UInt32)
    IL_0006: ret

}
int ntz(uint src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi1::TrailingZeroCount(System.UInt32)
    IL_0006: ret

}
int ntz(long src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt64 System.Runtime.Intrinsics.X86.Bmi1/X64::TrailingZeroCount(System.UInt64)
    IL_0006: conv.i4
    IL_0007: ret

}
int ntz(ulong src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt64 System.Runtime.Intrinsics.X86.Bmi1/X64::TrailingZeroCount(System.UInt64)
    IL_0006: conv.i4
    IL_0007: ret

}
uint pack(bit b0, bit b1)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 Z0.bit::op_Explicit(Z0.bit)
    IL_0006: stloc.0
    IL_0007: ldloc.0
    IL_0008: ldarg.1
    IL_0009: call System.UInt32 Z0.bit::op_Explicit(Z0.bit)
    IL_000E: ldc.i4.1
    IL_000F: shl
    IL_0010: or
    IL_0011: stloc.0
    IL_0012: ldloc.0
    IL_0013: ret

}
uint pack(bit b0, bit b1, bit b2)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 Z0.bit::op_Explicit(Z0.bit)
    IL_0006: stloc.0
    IL_0007: ldloc.0
    IL_0008: ldarg.1
    IL_0009: call System.UInt32 Z0.bit::op_Explicit(Z0.bit)
    IL_000E: ldc.i4.1
    IL_000F: shl
    IL_0010: or
    IL_0011: stloc.0
    IL_0012: ldloc.0
    IL_0013: ldarg.2
    IL_0014: call System.UInt32 Z0.bit::op_Explicit(Z0.bit)
    IL_0019: ldc.i4.2
    IL_001A: shl
    IL_001B: or
    IL_001C: stloc.0
    IL_001D: ldloc.0
    IL_001E: ret

}
uint pack(bit b0, bit b1, bit b2, bit b3)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 Z0.bit::op_Explicit(Z0.bit)
    IL_0006: stloc.0
    IL_0007: ldloc.0
    IL_0008: ldarg.1
    IL_0009: call System.UInt32 Z0.bit::op_Explicit(Z0.bit)
    IL_000E: ldc.i4.1
    IL_000F: shl
    IL_0010: or
    IL_0011: stloc.0
    IL_0012: ldloc.0
    IL_0013: ldarg.2
    IL_0014: call System.UInt32 Z0.bit::op_Explicit(Z0.bit)
    IL_0019: ldc.i4.2
    IL_001A: shl
    IL_001B: or
    IL_001C: stloc.0
    IL_001D: ldloc.0
    IL_001E: ldarg.3
    IL_001F: call System.UInt32 Z0.bit::op_Explicit(Z0.bit)
    IL_0024: ldc.i4.3
    IL_0025: shl
    IL_0026: or
    IL_0027: stloc.0
    IL_0028: ldloc.0
    IL_0029: ret

}
uint pack(bit b0, bit b1, bit b2, bit b3, bit b4)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 Z0.bit::op_Explicit(Z0.bit)
    IL_0006: stloc.0
    IL_0007: ldloc.0
    IL_0008: ldarg.1
    IL_0009: call System.UInt32 Z0.bit::op_Explicit(Z0.bit)
    IL_000E: ldc.i4.1
    IL_000F: shl
    IL_0010: or
    IL_0011: stloc.0
    IL_0012: ldloc.0
    IL_0013: ldarg.2
    IL_0014: call System.UInt32 Z0.bit::op_Explicit(Z0.bit)
    IL_0019: ldc.i4.2
    IL_001A: shl
    IL_001B: or
    IL_001C: stloc.0
    IL_001D: ldloc.0
    IL_001E: ldarg.3
    IL_001F: call System.UInt32 Z0.bit::op_Explicit(Z0.bit)
    IL_0024: ldc.i4.3
    IL_0025: shl
    IL_0026: or
    IL_0027: stloc.0
    IL_0028: ldloc.0
    IL_0029: ldarg.s b4
    IL_002B: call System.UInt32 Z0.bit::op_Explicit(Z0.bit)
    IL_0030: ldc.i4.4
    IL_0031: shl
    IL_0032: or
    IL_0033: stloc.0
    IL_0034: ldloc.0
    IL_0035: ret

}
uint pack(bit b0, bit b1, bit b2, bit b3, bit b4, bit b5, bit b6, bit b7)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: ldarg.3
    IL_0004: call System.UInt32 Z0.Bits::pack(Z0.bit,Z0.bit,Z0.bit,Z0.bit)
    IL_0009: stloc.0
    IL_000A: ldloc.0
    IL_000B: ldarg.s b4
    IL_000D: ldarg.s b5
    IL_000F: ldarg.s b6
    IL_0011: ldarg.s b7
    IL_0013: call System.UInt32 Z0.Bits::pack(Z0.bit,Z0.bit,Z0.bit,Z0.bit)
    IL_0018: ldc.i4.4
    IL_0019: shl
    IL_001A: or
    IL_001B: stloc.0
    IL_001C: ldloc.0
    IL_001D: ret

}
ref uint pack(ReadOnlySpan<bit> src, ref uint dst)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Int32 System.ReadOnlySpan`1<Z0.bit>::get_Length()
    IL_0007: ldc.i4.s 32
    IL_0009: call System.Int32 Z0.math::min(System.Int32,System.Int32)
    IL_000E: stloc.0
    IL_000F: ldarg.0
    IL_0010: call Z0.bit& modreq(System.Runtime.InteropServices.InAttribute) zfunc::head<Z0.bit>(System.ReadOnlySpan`1<Z0.bit>)
    IL_0015: stloc.1
    IL_0016: ldc.i4.0
    IL_0017: stloc.2
    IL_0018: br.s IL_0039
    IL_001A: ldarg.1
    IL_001B: ldarg.1
    IL_001C: ldind.u4
    IL_001D: ldloc.1
    IL_001E: ldloc.2
    IL_001F: call Z0.bit& modreq(System.Runtime.InteropServices.InAttribute) zfunc::skip<Z0.bit>(Z0.bit&,System.Int32)
    IL_0024: ldobj Z0.bit
    IL_0029: call System.UInt32 Z0.bit::op_Explicit(Z0.bit)
    IL_002E: ldloc.2
    IL_002F: ldc.i4.s 31
    IL_0031: and
    IL_0032: shl
    IL_0033: or
    IL_0034: stind.i4
    IL_0035: ldloc.2
    IL_0036: ldc.i4.1
    IL_0037: add
    IL_0038: stloc.2
    IL_0039: ldloc.2
    IL_003A: ldloc.0
    IL_003B: blt.s IL_001A
    IL_003D: ldarg.1
    IL_003E: ret

}
ref uint pack(N1 n, in bit src, ref uint dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.2
    IL_0002: ldind.u4
    IL_0003: ldarg.1
    IL_0004: ldobj Z0.bit
    IL_0009: call System.UInt32 Z0.bit::op_Explicit(Z0.bit)
    IL_000E: or
    IL_000F: stind.i4
    IL_0010: ldarg.2
    IL_0011: ret

}
ref uint pack(N2 n, in bit src, ref uint dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.2
    IL_0002: ldind.u4
    IL_0003: ldarg.1
    IL_0004: ldc.i4.0
    IL_0005: call Z0.bit& modreq(System.Runtime.InteropServices.InAttribute) zfunc::skip<Z0.bit>(Z0.bit&,System.Int32)
    IL_000A: ldobj Z0.bit
    IL_000F: call System.UInt32 Z0.bit::op_Explicit(Z0.bit)
    IL_0014: or
    IL_0015: stind.i4
    IL_0016: ldarg.2
    IL_0017: ldarg.2
    IL_0018: ldind.u4
    IL_0019: ldarg.1
    IL_001A: ldc.i4.1
    IL_001B: call Z0.bit& modreq(System.Runtime.InteropServices.InAttribute) zfunc::skip<Z0.bit>(Z0.bit&,System.Int32)
    IL_0020: ldobj Z0.bit
    IL_0025: call System.UInt32 Z0.bit::op_Explicit(Z0.bit)
    IL_002A: ldc.i4.1
    IL_002B: shl
    IL_002C: or
    IL_002D: stind.i4
    IL_002E: ldarg.2
    IL_002F: ret

}
ref uint pack(N3 n, in bit src, ref uint dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.2
    IL_0002: ldind.u4
    IL_0003: ldarg.1
    IL_0004: ldc.i4.0
    IL_0005: call Z0.bit& modreq(System.Runtime.InteropServices.InAttribute) zfunc::skip<Z0.bit>(Z0.bit&,System.Int32)
    IL_000A: ldobj Z0.bit
    IL_000F: call System.UInt32 Z0.bit::op_Explicit(Z0.bit)
    IL_0014: or
    IL_0015: stind.i4
    IL_0016: ldarg.2
    IL_0017: ldarg.2
    IL_0018: ldind.u4
    IL_0019: ldarg.1
    IL_001A: ldc.i4.1
    IL_001B: call Z0.bit& modreq(System.Runtime.InteropServices.InAttribute) zfunc::skip<Z0.bit>(Z0.bit&,System.Int32)
    IL_0020: ldobj Z0.bit
    IL_0025: call System.UInt32 Z0.bit::op_Explicit(Z0.bit)
    IL_002A: ldc.i4.1
    IL_002B: shl
    IL_002C: or
    IL_002D: stind.i4
    IL_002E: ldarg.2
    IL_002F: ldarg.2
    IL_0030: ldind.u4
    IL_0031: ldarg.1
    IL_0032: ldc.i4.2
    IL_0033: call Z0.bit& modreq(System.Runtime.InteropServices.InAttribute) zfunc::skip<Z0.bit>(Z0.bit&,System.Int32)
    IL_0038: ldobj Z0.bit
    IL_003D: call System.UInt32 Z0.bit::op_Explicit(Z0.bit)
    IL_0042: ldc.i4.2
    IL_0043: shl
    IL_0044: or
    IL_0045: stind.i4
    IL_0046: ldarg.2
    IL_0047: ret

}
ref uint pack(N4 n, in bit src, ref uint dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.2
    IL_0002: ldind.u4
    IL_0003: ldarg.1
    IL_0004: ldc.i4.0
    IL_0005: call Z0.bit& modreq(System.Runtime.InteropServices.InAttribute) zfunc::skip<Z0.bit>(Z0.bit&,System.Int32)
    IL_000A: ldobj Z0.bit
    IL_000F: call System.UInt32 Z0.bit::op_Explicit(Z0.bit)
    IL_0014: or
    IL_0015: stind.i4
    IL_0016: ldarg.2
    IL_0017: ldarg.2
    IL_0018: ldind.u4
    IL_0019: ldarg.1
    IL_001A: ldc.i4.1
    IL_001B: call Z0.bit& modreq(System.Runtime.InteropServices.InAttribute) zfunc::skip<Z0.bit>(Z0.bit&,System.Int32)
    IL_0020: ldobj Z0.bit
    IL_0025: call System.UInt32 Z0.bit::op_Explicit(Z0.bit)
    IL_002A: ldc.i4.1
    IL_002B: shl
    IL_002C: or
    IL_002D: stind.i4
    IL_002E: ldarg.2
    IL_002F: ldarg.2
    IL_0030: ldind.u4
    IL_0031: ldarg.1
    IL_0032: ldc.i4.2
    IL_0033: call Z0.bit& modreq(System.Runtime.InteropServices.InAttribute) zfunc::skip<Z0.bit>(Z0.bit&,System.Int32)
    IL_0038: ldobj Z0.bit
    IL_003D: call System.UInt32 Z0.bit::op_Explicit(Z0.bit)
    IL_0042: ldc.i4.2
    IL_0043: shl
    IL_0044: or
    IL_0045: stind.i4
    IL_0046: ldarg.2
    IL_0047: ldarg.2
    IL_0048: ldind.u4
    IL_0049: ldarg.1
    IL_004A: ldc.i4.3
    IL_004B: call Z0.bit& modreq(System.Runtime.InteropServices.InAttribute) zfunc::skip<Z0.bit>(Z0.bit&,System.Int32)
    IL_0050: ldobj Z0.bit
    IL_0055: call System.UInt32 Z0.bit::op_Explicit(Z0.bit)
    IL_005A: ldc.i4.3
    IL_005B: shl
    IL_005C: or
    IL_005D: stind.i4
    IL_005E: ldarg.2
    IL_005F: ret

}
ref uint pack(N8 n, in bit src, ref uint dst)
{
    IL_0000: call Z0.N4 zfunc::get_n4()
    IL_0005: ldarg.1
    IL_0006: ldarg.2
    IL_0007: call System.UInt32& Z0.Bits::pack(Z0.N4,Z0.bit&,System.UInt32&)
    IL_000C: pop
    IL_000D: call Z0.N4 zfunc::get_n4()
    IL_0012: ldarg.1
    IL_0013: ldc.i4.4
    IL_0014: call Z0.bit& modreq(System.Runtime.InteropServices.InAttribute) zfunc::skip<Z0.bit>(Z0.bit&,System.Int32)
    IL_0019: ldarg.2
    IL_001A: ldc.i4.4
    IL_001B: call System.UInt32& zfunc::seek<System.UInt32>(System.UInt32&,System.Int32)
    IL_0020: call System.UInt32& Z0.Bits::pack(Z0.N4,Z0.bit&,System.UInt32&)
    IL_0025: pop
    IL_0026: ldarg.2
    IL_0027: ret

}
Vector128<byte> vbutterfly(N1 n, Vector128<byte> x)
{
    IL_0000: ldarg.1
    IL_0001: call Z0.N128 zfunc::get_n128()
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Bits::v66(Z0.N128)
    IL_000B: ldc.i4.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Bits::vbutterfly<System.Byte>(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Byte)
    IL_0011: ret

}
Vector128<ushort> vbutterfly(N1 n, Vector128<ushort> x)
{
    IL_0000: ldarg.1
    IL_0001: call Z0.N128 zfunc::get_n128()
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Bits::v6666(Z0.N128)
    IL_000B: ldc.i4.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Bits::vbutterfly<System.UInt16>(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Byte)
    IL_0011: ret

}
Vector128<uint> vbutterfly(N1 n, Vector128<uint> x)
{
    IL_0000: ldarg.1
    IL_0001: call Z0.N128 zfunc::get_n128()
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Bits::v66666666(Z0.N128)
    IL_000B: ldc.i4.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Bits::vbutterfly<System.UInt32>(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Byte)
    IL_0011: ret

}
Vector128<ulong> vbutterfly(N1 n, Vector128<ulong> x)
{
    IL_0000: ldarg.1
    IL_0001: call Z0.N128 zfunc::get_n128()
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Bits::v6666666666666666(Z0.N128)
    IL_000B: ldc.i4.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Bits::vbutterfly<System.UInt64>(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Byte)
    IL_0011: ret

}
Vector128<byte> vbutterfly(N2 n, Vector128<byte> x)
{
    IL_0000: ldarg.1
    IL_0001: call Z0.N128 zfunc::get_n128()
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Bits::v3C(Z0.N128)
    IL_000B: ldc.i4.2
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Bits::vbutterfly<System.Byte>(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Byte)
    IL_0011: ret

}
Vector128<ushort> vbutterfly(N2 n, Vector128<ushort> x)
{
    IL_0000: ldarg.1
    IL_0001: call Z0.N128 zfunc::get_n128()
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Bits::v3C3C(Z0.N128)
    IL_000B: ldc.i4.2
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Bits::vbutterfly<System.UInt16>(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Byte)
    IL_0011: ret

}
Vector128<uint> vbutterfly(N2 n, Vector128<uint> x)
{
    IL_0000: ldarg.1
    IL_0001: call Z0.N128 zfunc::get_n128()
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Bits::v3C3C3C3C(Z0.N128)
    IL_000B: ldc.i4.2
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Bits::vbutterfly<System.UInt32>(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Byte)
    IL_0011: ret

}
Vector128<ulong> vbutterfly(N2 n, Vector128<ulong> x)
{
    IL_0000: ldarg.1
    IL_0001: call Z0.N128 zfunc::get_n128()
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Bits::v3C3C3C3C3C3C3C3C(Z0.N128)
    IL_000B: ldc.i4.2
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Bits::vbutterfly<System.UInt64>(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Byte)
    IL_0011: ret

}
Vector128<ushort> vbutterfly(N4 n, Vector128<ushort> x)
{
    IL_0000: ldarg.1
    IL_0001: call Z0.N128 zfunc::get_n128()
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Bits::v0FF0(Z0.N128)
    IL_000B: ldc.i4.4
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Bits::vbutterfly<System.UInt16>(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Byte)
    IL_0011: ret

}
Vector128<uint> vbutterfly(N4 n, Vector128<uint> x)
{
    IL_0000: ldarg.1
    IL_0001: call Z0.N128 zfunc::get_n128()
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Bits::v0FF00FF0(Z0.N128)
    IL_000B: ldc.i4.4
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Bits::vbutterfly<System.UInt32>(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Byte)
    IL_0011: ret

}
Vector128<ulong> vbutterfly(N4 n, Vector128<ulong> x)
{
    IL_0000: ldarg.1
    IL_0001: call Z0.N128 zfunc::get_n128()
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Bits::v0FF00FF00FF00FF0(Z0.N128)
    IL_000B: ldc.i4.4
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Bits::vbutterfly<System.UInt64>(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Byte)
    IL_0011: ret

}
Vector128<uint> vbutterfly(N8 n, Vector128<uint> x)
{
    IL_0000: ldarg.1
    IL_0001: call Z0.N128 zfunc::get_n128()
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Bits::v00FFFF00(Z0.N128)
    IL_000B: ldc.i4.8
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Bits::vbutterfly<System.UInt32>(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Byte)
    IL_0011: ret

}
Vector128<ulong> vbutterfly(N8 n, Vector128<ulong> x)
{
    IL_0000: ldarg.1
    IL_0001: call Z0.N128 zfunc::get_n128()
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Bits::v00FFFF0000FFFF00(Z0.N128)
    IL_000B: ldc.i4.8
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Bits::vbutterfly<System.UInt64>(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Byte)
    IL_0011: ret

}
Vector128<ulong> vbutterfly(N16 n, Vector128<ulong> x)
{
    IL_0000: ldarg.1
    IL_0001: call Z0.N128 zfunc::get_n128()
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Bits::v0000FFFFFFFF0000(Z0.N128)
    IL_000B: ldc.i4.s 16
    IL_000D: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Bits::vbutterfly<System.UInt64>(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Byte)
    IL_0012: ret

}
Vector256<byte> vbutterfly(N1 n, Vector256<byte> x)
{
    IL_0000: ldarg.1
    IL_0001: call Z0.N256 zfunc::get_n256()
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Bits::v66(Z0.N256)
    IL_000B: ldc.i4.1
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Bits::vbutterfly<System.Byte>(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Byte)
    IL_0011: ret

}
Vector256<ushort> vbutterfly(N1 n, Vector256<ushort> x)
{
    IL_0000: ldarg.1
    IL_0001: call Z0.N256 zfunc::get_n256()
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Bits::v6666(Z0.N256)
    IL_000B: ldc.i4.1
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Bits::vbutterfly<System.UInt16>(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Byte)
    IL_0011: ret

}
Vector256<uint> vbutterfly(N1 n, Vector256<uint> x)
{
    IL_0000: ldarg.1
    IL_0001: call Z0.N256 zfunc::get_n256()
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Bits::v66666666(Z0.N256)
    IL_000B: ldc.i4.1
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Bits::vbutterfly<System.UInt32>(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Byte)
    IL_0011: ret

}
Vector256<ulong> vbutterfly(N1 n, Vector256<ulong> x)
{
    IL_0000: ldarg.1
    IL_0001: call Z0.N256 zfunc::get_n256()
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Bits::v6666666666666666(Z0.N256)
    IL_000B: ldc.i4.1
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Bits::vbutterfly<System.UInt64>(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Byte)
    IL_0011: ret

}
Vector256<byte> vbutterfly(N2 n, Vector256<byte> x)
{
    IL_0000: ldarg.1
    IL_0001: call Z0.N256 zfunc::get_n256()
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Bits::v3C(Z0.N256)
    IL_000B: ldc.i4.2
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Bits::vbutterfly<System.Byte>(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Byte)
    IL_0011: ret

}
Vector256<ushort> vbutterfly(N2 n, Vector256<ushort> x)
{
    IL_0000: ldarg.1
    IL_0001: call Z0.N256 zfunc::get_n256()
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Bits::v3C3C(Z0.N256)
    IL_000B: ldc.i4.2
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Bits::vbutterfly<System.UInt16>(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Byte)
    IL_0011: ret

}
Vector256<uint> vbutterfly(N2 n, Vector256<uint> x)
{
    IL_0000: ldarg.1
    IL_0001: call Z0.N256 zfunc::get_n256()
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Bits::v3C3C3C3C(Z0.N256)
    IL_000B: ldc.i4.2
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Bits::vbutterfly<System.UInt32>(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Byte)
    IL_0011: ret

}
Vector256<ulong> vbutterfly(N2 n, Vector256<ulong> x)
{
    IL_0000: ldarg.1
    IL_0001: call Z0.N256 zfunc::get_n256()
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Bits::v3C3C3C3C3C3C3C3C(Z0.N256)
    IL_000B: ldc.i4.2
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Bits::vbutterfly<System.UInt64>(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Byte)
    IL_0011: ret

}
Vector256<ushort> vbutterfly(N4 n, Vector256<ushort> x)
{
    IL_0000: ldarg.1
    IL_0001: call Z0.N256 zfunc::get_n256()
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Bits::v0FF0(Z0.N256)
    IL_000B: ldc.i4.4
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Bits::vbutterfly<System.UInt16>(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Byte)
    IL_0011: ret

}
Vector256<uint> vbutterfly(N4 n, Vector256<uint> x)
{
    IL_0000: ldarg.1
    IL_0001: call Z0.N256 zfunc::get_n256()
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Bits::v0FF00FF0(Z0.N256)
    IL_000B: ldc.i4.4
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Bits::vbutterfly<System.UInt32>(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Byte)
    IL_0011: ret

}
Vector256<ulong> vbutterfly(N4 n, Vector256<ulong> x)
{
    IL_0000: ldarg.1
    IL_0001: call Z0.N256 zfunc::get_n256()
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Bits::v0FF00FF00FF00FF0(Z0.N256)
    IL_000B: ldc.i4.4
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Bits::vbutterfly<System.UInt64>(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Byte)
    IL_0011: ret

}
Vector256<uint> vbutterfly(N8 n, Vector256<uint> x)
{
    IL_0000: ldarg.1
    IL_0001: call Z0.N256 zfunc::get_n256()
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Bits::v00FFFF00(Z0.N256)
    IL_000B: ldc.i4.8
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Bits::vbutterfly<System.UInt32>(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Byte)
    IL_0011: ret

}
Vector256<ulong> vbutterfly(N8 n, Vector256<ulong> x)
{
    IL_0000: ldarg.1
    IL_0001: call Z0.N256 zfunc::get_n256()
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Bits::v00FFFF0000FFFF00(Z0.N256)
    IL_000B: ldc.i4.8
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Bits::vbutterfly<System.UInt64>(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Byte)
    IL_0011: ret

}
Vector256<ulong> vbutterfly(N16 n, Vector256<ulong> x)
{
    IL_0000: ldarg.1
    IL_0001: call Z0.N256 zfunc::get_n256()
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Bits::v0000FFFFFFFF0000(Z0.N256)
    IL_000B: ldc.i4.s 16
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Bits::vbutterfly<System.UInt64>(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Byte)
    IL_0012: ret

}
Vector128<byte> v66(N128 n)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.s 102
    IL_0003: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.dinx::vbroadcast(Z0.N128,System.Byte)
    IL_0008: ret

}
Vector128<ushort> v6666(N128 n)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4 26214
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.dinx::vbroadcast(Z0.N128,System.UInt16)
    IL_000B: ret

}
Vector128<uint> v66666666(N128 n)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4 1717986918
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.dinx::vbroadcast(Z0.N128,System.UInt32)
    IL_000B: ret

}
Vector128<ulong> v6666666666666666(N128 n)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i8 7378697629483820646
    IL_000A: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.dinx::vbroadcast(Z0.N128,System.UInt64)
    IL_000F: ret

}
Vector128<byte> v3C(N128 n)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.s 60
    IL_0003: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.dinx::vbroadcast(Z0.N128,System.Byte)
    IL_0008: ret

}
Vector128<ushort> v3C3C(N128 n)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4 15420
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.dinx::vbroadcast(Z0.N128,System.UInt16)
    IL_000B: ret

}
Vector128<uint> v3C3C3C3C(N128 n)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4 1010580540
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.dinx::vbroadcast(Z0.N128,System.UInt32)
    IL_000B: ret

}
Vector128<ulong> v3C3C3C3C3C3C3C3C(N128 n)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i8 4340410370284600380
    IL_000A: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.dinx::vbroadcast(Z0.N128,System.UInt64)
    IL_000F: ret

}
Vector128<ushort> v0FF0(N128 n)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4 4080
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.dinx::vbroadcast(Z0.N128,System.UInt16)
    IL_000B: ret

}
Vector128<uint> v0FF00FF0(N128 n)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4 267390960
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.dinx::vbroadcast(Z0.N128,System.UInt32)
    IL_000B: ret

}
Vector128<ulong> v0FF00FF00FF00FF0(N128 n)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i8 1148435428713435120
    IL_000A: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.dinx::vbroadcast(Z0.N128,System.UInt64)
    IL_000F: ret

}
Vector128<uint> v00FFFF00(N128 n)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4 16776960
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.dinx::vbroadcast(Z0.N128,System.UInt32)
    IL_000B: ret

}
Vector128<ulong> v00FFFF0000FFFF00(N128 n)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i8 72056494543077120
    IL_000A: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.dinx::vbroadcast(Z0.N128,System.UInt64)
    IL_000F: ret

}
Vector128<ulong> v0000FFFFFFFF0000(N128 n)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i8 281474976645120
    IL_000A: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.dinx::vbroadcast(Z0.N128,System.UInt64)
    IL_000F: ret

}
Vector256<byte> v66(N256 n)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.s 102
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.dinx::vbroadcast(Z0.N256,System.Byte)
    IL_0008: ret

}
Vector256<ushort> v6666(N256 n)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4 26214
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.dinx::vbroadcast(Z0.N256,System.UInt16)
    IL_000B: ret

}
Vector256<uint> v66666666(N256 n)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4 1717986918
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.dinx::vbroadcast(Z0.N256,System.UInt32)
    IL_000B: ret

}
Vector256<ulong> v6666666666666666(N256 n)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i8 7378697629483820646
    IL_000A: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::vbroadcast(Z0.N256,System.UInt64)
    IL_000F: ret

}
Vector256<byte> v3C(N256 n)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.s 60
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.dinx::vbroadcast(Z0.N256,System.Byte)
    IL_0008: ret

}
Vector256<ushort> v3C3C(N256 n)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4 15420
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.dinx::vbroadcast(Z0.N256,System.UInt16)
    IL_000B: ret

}
Vector256<uint> v3C3C3C3C(N256 n)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4 1010580540
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.dinx::vbroadcast(Z0.N256,System.UInt32)
    IL_000B: ret

}
Vector256<ulong> v3C3C3C3C3C3C3C3C(N256 n)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i8 4340410370284600380
    IL_000A: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::vbroadcast(Z0.N256,System.UInt64)
    IL_000F: ret

}
Vector256<ushort> v0FF0(N256 n)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4 4080
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.dinx::vbroadcast(Z0.N256,System.UInt16)
    IL_000B: ret

}
Vector256<uint> v0FF00FF0(N256 n)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4 267390960
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.dinx::vbroadcast(Z0.N256,System.UInt32)
    IL_000B: ret

}
Vector256<ulong> v0FF00FF00FF00FF0(N256 n)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i8 1148435428713435120
    IL_000A: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::vbroadcast(Z0.N256,System.UInt64)
    IL_000F: ret

}
Vector256<uint> v00FFFF00(N256 n)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4 16776960
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.dinx::vbroadcast(Z0.N256,System.UInt32)
    IL_000B: ret

}
Vector256<ulong> v00FFFF0000FFFF00(N256 n)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i8 72056494543077120
    IL_000A: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::vbroadcast(Z0.N256,System.UInt64)
    IL_000F: ret

}
Vector256<ulong> v0000FFFFFFFF0000(N256 n)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i8 281474976645120
    IL_000A: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::vbroadcast(Z0.N256,System.UInt64)
    IL_000F: ret

}
sbyte between(sbyte src, byte i0, byte i1)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.SByte Z0.BitMask::between(System.SByte,System.Byte,System.Byte)
    IL_0008: ret

}
byte between(byte src, byte i0, byte i1)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.Byte Z0.BitMask::between(System.Byte,System.Byte,System.Byte)
    IL_0008: ret

}
short between(short src, byte i0, byte i1)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.Int16 Z0.BitMask::between(System.Int16,System.Byte,System.Byte)
    IL_0008: ret

}
ushort between(ushort src, byte i0, byte i1)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.UInt16 Z0.BitMask::between(System.UInt16,System.Byte,System.Byte)
    IL_0008: ret

}
uint between(uint src, byte i0, byte i1)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.UInt32 Z0.BitMask::between(System.UInt32,System.Byte,System.Byte)
    IL_0008: ret

}
int between(int src, byte i0, byte i1)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.Int32 Z0.BitMask::between(System.Int32,System.Byte,System.Byte)
    IL_0008: ret

}
ulong between(ulong src, byte i0, byte i1)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.UInt64 Z0.BitMask::between(System.UInt64,System.Byte,System.Byte)
    IL_0008: ret

}
long between(long src, byte i0, byte i1)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.Int64 Z0.BitMask::between(System.Int64,System.Byte,System.Byte)
    IL_0008: ret

}
float between(float src, byte i0, byte i1)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.Single Z0.BitMask::between(System.Single,System.Byte,System.Byte)
    IL_0008: ret

}
double between(double src, byte i0, byte i1)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.Double Z0.BitMask::between(System.Double,System.Byte,System.Byte)
    IL_0008: ret

}
ref sbyte bitmap(sbyte src, byte srcOffset, byte len, byte dstOffset, ref sbyte dst)
{
    IL_0000: ldarg.s dst
    IL_0002: ldarg.s dst
    IL_0004: ldind.i1
    IL_0005: ldarg.3
    IL_0006: ldc.i4.s 31
    IL_0008: and
    IL_0009: shl
    IL_000A: conv.i1
    IL_000B: stind.i1
    IL_000C: ldarg.s dst
    IL_000E: ldarg.s dst
    IL_0010: ldind.i1
    IL_0011: ldarg.0
    IL_0012: ldarg.1
    IL_0013: ldarg.2
    IL_0014: call System.SByte Z0.Bits::extract(System.SByte,System.Byte,System.Byte)
    IL_0019: or
    IL_001A: conv.i1
    IL_001B: stind.i1
    IL_001C: ldarg.s dst
    IL_001E: ret

}
ref byte bitmap(byte src, byte srcOffset, byte len, byte dstOffset, ref byte dst)
{
    IL_0000: ldarg.s dst
    IL_0002: ldarg.s dst
    IL_0004: ldind.u1
    IL_0005: ldarg.3
    IL_0006: ldc.i4.s 31
    IL_0008: and
    IL_0009: shl
    IL_000A: conv.u1
    IL_000B: stind.i1
    IL_000C: ldarg.s dst
    IL_000E: ldarg.s dst
    IL_0010: ldind.u1
    IL_0011: ldarg.0
    IL_0012: ldarg.1
    IL_0013: ldarg.2
    IL_0014: call System.Byte Z0.Bits::extract(System.Byte,System.Byte,System.Byte)
    IL_0019: or
    IL_001A: conv.u1
    IL_001B: stind.i1
    IL_001C: ldarg.s dst
    IL_001E: ret

}
ref short bitmap(byte src, byte srcOffset, byte len, byte dstOffset, ref short dst)
{
    IL_0000: ldarg.s dst
    IL_0002: ldarg.s dst
    IL_0004: ldind.i2
    IL_0005: ldarg.3
    IL_0006: ldc.i4.s 31
    IL_0008: and
    IL_0009: shl
    IL_000A: conv.i2
    IL_000B: stind.i2
    IL_000C: ldarg.s dst
    IL_000E: ldarg.s dst
    IL_0010: ldind.i2
    IL_0011: ldarg.0
    IL_0012: ldarg.1
    IL_0013: ldarg.2
    IL_0014: call System.Byte Z0.Bits::extract(System.Byte,System.Byte,System.Byte)
    IL_0019: or
    IL_001A: conv.i2
    IL_001B: stind.i2
    IL_001C: ldarg.s dst
    IL_001E: ret

}
ref ushort bitmap(byte src, byte srcOffset, byte len, byte dstOffset, ref ushort dst)
{
    IL_0000: ldarg.s dst
    IL_0002: ldarg.s dst
    IL_0004: ldind.u2
    IL_0005: ldarg.3
    IL_0006: ldc.i4.s 31
    IL_0008: and
    IL_0009: shl
    IL_000A: conv.u2
    IL_000B: stind.i2
    IL_000C: ldarg.s dst
    IL_000E: ldarg.s dst
    IL_0010: ldind.u2
    IL_0011: ldarg.0
    IL_0012: ldarg.1
    IL_0013: ldarg.2
    IL_0014: call System.Byte Z0.Bits::extract(System.Byte,System.Byte,System.Byte)
    IL_0019: or
    IL_001A: conv.u2
    IL_001B: stind.i2
    IL_001C: ldarg.s dst
    IL_001E: ret

}
ref int bitmap(byte src, byte srcOffset, byte len, byte dstOffset, ref int dst)
{
    IL_0000: ldarg.s dst
    IL_0002: ldarg.s dst
    IL_0004: ldind.i4
    IL_0005: ldarg.3
    IL_0006: ldc.i4.s 31
    IL_0008: and
    IL_0009: shl
    IL_000A: stind.i4
    IL_000B: ldarg.s dst
    IL_000D: ldarg.s dst
    IL_000F: ldind.i4
    IL_0010: ldarg.0
    IL_0011: ldarg.1
    IL_0012: ldarg.2
    IL_0013: call System.Byte Z0.Bits::extract(System.Byte,System.Byte,System.Byte)
    IL_0018: or
    IL_0019: stind.i4
    IL_001A: ldarg.s dst
    IL_001C: ret

}
ref uint bitmap(byte src, byte srcOffset, byte len, byte dstOffset, ref uint dst)
{
    IL_0000: ldarg.s dst
    IL_0002: ldarg.s dst
    IL_0004: ldind.u4
    IL_0005: ldarg.3
    IL_0006: ldc.i4.s 31
    IL_0008: and
    IL_0009: shl
    IL_000A: stind.i4
    IL_000B: ldarg.s dst
    IL_000D: ldarg.s dst
    IL_000F: ldind.u4
    IL_0010: ldarg.0
    IL_0011: ldarg.1
    IL_0012: ldarg.2
    IL_0013: call System.Byte Z0.Bits::extract(System.Byte,System.Byte,System.Byte)
    IL_0018: or
    IL_0019: stind.i4
    IL_001A: ldarg.s dst
    IL_001C: ret

}
ref long bitmap(byte src, byte srcOffset, byte len, byte dstOffset, ref long dst)
{
    IL_0000: ldarg.s dst
    IL_0002: ldarg.s dst
    IL_0004: ldind.i8
    IL_0005: ldarg.3
    IL_0006: ldc.i4.s 63
    IL_0008: and
    IL_0009: shl
    IL_000A: stind.i8
    IL_000B: ldarg.s dst
    IL_000D: ldarg.s dst
    IL_000F: ldind.i8
    IL_0010: ldarg.0
    IL_0011: ldarg.1
    IL_0012: ldarg.2
    IL_0013: call System.Byte Z0.Bits::extract(System.Byte,System.Byte,System.Byte)
    IL_0018: conv.u8
    IL_0019: or
    IL_001A: stind.i8
    IL_001B: ldarg.s dst
    IL_001D: ret

}
ref ulong bitmap(byte src, byte srcOffset, byte len, byte dstOffset, ref ulong dst)
{
    IL_0000: ldarg.s dst
    IL_0002: ldarg.s dst
    IL_0004: ldind.i8
    IL_0005: ldarg.3
    IL_0006: ldc.i4.s 63
    IL_0008: and
    IL_0009: shl
    IL_000A: stind.i8
    IL_000B: ldarg.s dst
    IL_000D: ldarg.s dst
    IL_000F: ldind.i8
    IL_0010: ldarg.0
    IL_0011: ldarg.1
    IL_0012: ldarg.2
    IL_0013: call System.Byte Z0.Bits::extract(System.Byte,System.Byte,System.Byte)
    IL_0018: conv.u8
    IL_0019: or
    IL_001A: stind.i8
    IL_001B: ldarg.s dst
    IL_001D: ret

}
ref sbyte bitmap(short src, byte srcOffset, byte len, byte dstOffset, ref sbyte dst)
{
    IL_0000: ldarg.s dst
    IL_0002: ldarg.s dst
    IL_0004: ldind.i1
    IL_0005: ldarg.3
    IL_0006: ldc.i4.s 31
    IL_0008: and
    IL_0009: shl
    IL_000A: conv.i1
    IL_000B: stind.i1
    IL_000C: ldarg.s dst
    IL_000E: ldarg.s dst
    IL_0010: ldind.i1
    IL_0011: ldarg.0
    IL_0012: ldarg.1
    IL_0013: ldarg.2
    IL_0014: call System.Int16 Z0.Bits::extract(System.Int16,System.Byte,System.Byte)
    IL_0019: conv.i1
    IL_001A: or
    IL_001B: conv.i1
    IL_001C: stind.i1
    IL_001D: ldarg.s dst
    IL_001F: ret

}
ref byte bitmap(short src, byte srcOffset, byte len, byte dstOffset, ref byte dst)
{
    IL_0000: ldarg.s dst
    IL_0002: ldarg.s dst
    IL_0004: ldind.u1
    IL_0005: ldarg.3
    IL_0006: ldc.i4.s 31
    IL_0008: and
    IL_0009: shl
    IL_000A: conv.u1
    IL_000B: stind.i1
    IL_000C: ldarg.s dst
    IL_000E: ldarg.s dst
    IL_0010: ldind.u1
    IL_0011: ldarg.0
    IL_0012: ldarg.1
    IL_0013: ldarg.2
    IL_0014: call System.Int16 Z0.Bits::extract(System.Int16,System.Byte,System.Byte)
    IL_0019: conv.u1
    IL_001A: or
    IL_001B: conv.u1
    IL_001C: stind.i1
    IL_001D: ldarg.s dst
    IL_001F: ret

}
ref short bitmap(short src, byte srcOffset, byte len, byte dstOffset, ref short dst)
{
    IL_0000: ldarg.s dst
    IL_0002: ldarg.s dst
    IL_0004: ldind.i2
    IL_0005: ldarg.3
    IL_0006: ldc.i4.s 31
    IL_0008: and
    IL_0009: shl
    IL_000A: conv.i2
    IL_000B: stind.i2
    IL_000C: ldarg.s dst
    IL_000E: ldarg.s dst
    IL_0010: ldind.i2
    IL_0011: ldarg.0
    IL_0012: ldarg.1
    IL_0013: ldarg.2
    IL_0014: call System.Int16 Z0.Bits::extract(System.Int16,System.Byte,System.Byte)
    IL_0019: or
    IL_001A: conv.i2
    IL_001B: stind.i2
    IL_001C: ldarg.s dst
    IL_001E: ret

}
ref ushort bitmap(short src, byte srcOffset, byte len, byte dstOffset, ref ushort dst)
{
    IL_0000: ldarg.s dst
    IL_0002: ldarg.s dst
    IL_0004: ldind.u2
    IL_0005: ldarg.3
    IL_0006: ldc.i4.s 31
    IL_0008: and
    IL_0009: shl
    IL_000A: conv.u2
    IL_000B: stind.i2
    IL_000C: ldarg.s dst
    IL_000E: ldarg.s dst
    IL_0010: ldind.u2
    IL_0011: ldarg.0
    IL_0012: ldarg.1
    IL_0013: ldarg.2
    IL_0014: call System.Int16 Z0.Bits::extract(System.Int16,System.Byte,System.Byte)
    IL_0019: conv.u2
    IL_001A: or
    IL_001B: conv.u2
    IL_001C: stind.i2
    IL_001D: ldarg.s dst
    IL_001F: ret

}
ref ushort bitmap(ushort src, byte srcOffset, byte len, byte dstOffset, ref ushort dst)
{
    IL_0000: ldarg.s dst
    IL_0002: ldarg.s dst
    IL_0004: ldind.u2
    IL_0005: ldarg.3
    IL_0006: ldc.i4.s 31
    IL_0008: and
    IL_0009: shl
    IL_000A: conv.u2
    IL_000B: stind.i2
    IL_000C: ldarg.s dst
    IL_000E: ldarg.s dst
    IL_0010: ldind.u2
    IL_0011: ldarg.0
    IL_0012: ldarg.1
    IL_0013: ldarg.2
    IL_0014: call System.UInt16 Z0.Bits::extract(System.UInt16,System.Byte,System.Byte)
    IL_0019: or
    IL_001A: conv.u2
    IL_001B: stind.i2
    IL_001C: ldarg.s dst
    IL_001E: ret

}
ref uint bitmap(ushort src, byte srcOffset, byte len, byte dstOffset, ref uint dst)
{
    IL_0000: ldarg.s dst
    IL_0002: ldarg.s dst
    IL_0004: ldind.u4
    IL_0005: ldarg.3
    IL_0006: ldc.i4.s 31
    IL_0008: and
    IL_0009: shl
    IL_000A: stind.i4
    IL_000B: ldarg.s dst
    IL_000D: ldarg.s dst
    IL_000F: ldind.u4
    IL_0010: ldarg.0
    IL_0011: ldarg.1
    IL_0012: ldarg.2
    IL_0013: call System.UInt16 Z0.Bits::extract(System.UInt16,System.Byte,System.Byte)
    IL_0018: or
    IL_0019: stind.i4
    IL_001A: ldarg.s dst
    IL_001C: ret

}
ref ulong bitmap(ushort src, byte srcOffset, byte len, byte dstOffset, ref ulong dst)
{
    IL_0000: ldarg.s dst
    IL_0002: ldarg.s dst
    IL_0004: ldind.i8
    IL_0005: ldarg.3
    IL_0006: ldc.i4.s 63
    IL_0008: and
    IL_0009: shl
    IL_000A: stind.i8
    IL_000B: ldarg.s dst
    IL_000D: ldarg.s dst
    IL_000F: ldind.i8
    IL_0010: ldarg.0
    IL_0011: ldarg.1
    IL_0012: ldarg.2
    IL_0013: call System.UInt16 Z0.Bits::extract(System.UInt16,System.Byte,System.Byte)
    IL_0018: conv.u8
    IL_0019: or
    IL_001A: stind.i8
    IL_001B: ldarg.s dst
    IL_001D: ret

}
ref int bitmap(int src, byte srcOffset, byte len, byte dstOffset, ref int dst)
{
    IL_0000: ldarg.s dst
    IL_0002: ldarg.s dst
    IL_0004: ldind.i4
    IL_0005: ldarg.3
    IL_0006: ldc.i4.s 31
    IL_0008: and
    IL_0009: shl
    IL_000A: stind.i4
    IL_000B: ldarg.s dst
    IL_000D: ldarg.s dst
    IL_000F: ldind.i4
    IL_0010: ldarg.0
    IL_0011: ldarg.1
    IL_0012: ldarg.2
    IL_0013: call System.Int32 Z0.Bits::extract(System.Int32,System.Byte,System.Byte)
    IL_0018: or
    IL_0019: stind.i4
    IL_001A: ldarg.s dst
    IL_001C: ret

}
ref long bitmap(int src, byte srcOffset, byte len, byte dstOffset, ref long dst)
{
    IL_0000: ldarg.s dst
    IL_0002: ldarg.s dst
    IL_0004: ldind.i8
    IL_0005: ldarg.3
    IL_0006: ldc.i4.s 63
    IL_0008: and
    IL_0009: shl
    IL_000A: stind.i8
    IL_000B: ldarg.s dst
    IL_000D: ldarg.s dst
    IL_000F: ldind.i8
    IL_0010: ldarg.0
    IL_0011: ldarg.1
    IL_0012: ldarg.2
    IL_0013: call System.Int32 Z0.Bits::extract(System.Int32,System.Byte,System.Byte)
    IL_0018: conv.i8
    IL_0019: or
    IL_001A: stind.i8
    IL_001B: ldarg.s dst
    IL_001D: ret

}
ref ulong bitmap(int src, byte srcOffset, byte len, byte dstOffset, ref ulong dst)
{
    IL_0000: ldarg.s dst
    IL_0002: ldarg.s dst
    IL_0004: ldind.i8
    IL_0005: ldarg.3
    IL_0006: ldc.i4.s 63
    IL_0008: and
    IL_0009: shl
    IL_000A: stind.i8
    IL_000B: ldarg.s dst
    IL_000D: ldarg.s dst
    IL_000F: ldind.i8
    IL_0010: ldarg.0
    IL_0011: ldarg.1
    IL_0012: ldarg.2
    IL_0013: call System.Int32 Z0.Bits::extract(System.Int32,System.Byte,System.Byte)
    IL_0018: conv.u8
    IL_0019: or
    IL_001A: stind.i8
    IL_001B: ldarg.s dst
    IL_001D: ret

}
ref uint bitmap(uint src, byte srcOffset, byte len, byte dstOffset, ref uint dst)
{
    IL_0000: ldarg.s dst
    IL_0002: ldarg.s dst
    IL_0004: ldind.u4
    IL_0005: ldarg.3
    IL_0006: ldc.i4.s 31
    IL_0008: and
    IL_0009: shl
    IL_000A: stind.i4
    IL_000B: ldarg.s dst
    IL_000D: ldarg.s dst
    IL_000F: ldind.u4
    IL_0010: ldarg.0
    IL_0011: ldarg.1
    IL_0012: ldarg.2
    IL_0013: call System.UInt32 Z0.Bits::extract(System.UInt32,System.Byte,System.Byte)
    IL_0018: or
    IL_0019: stind.i4
    IL_001A: ldarg.s dst
    IL_001C: ret

}
ref ulong bitmap(uint src, byte srcOffset, byte len, byte dstOffset, ref ulong dst)
{
    IL_0000: ldarg.s dst
    IL_0002: ldarg.s dst
    IL_0004: ldind.i8
    IL_0005: ldarg.3
    IL_0006: ldc.i4.s 63
    IL_0008: and
    IL_0009: shl
    IL_000A: stind.i8
    IL_000B: ldarg.s dst
    IL_000D: ldarg.s dst
    IL_000F: ldind.i8
    IL_0010: ldarg.0
    IL_0011: ldarg.1
    IL_0012: ldarg.2
    IL_0013: call System.UInt32 Z0.Bits::extract(System.UInt32,System.Byte,System.Byte)
    IL_0018: conv.u8
    IL_0019: or
    IL_001A: stind.i8
    IL_001B: ldarg.s dst
    IL_001D: ret

}
ref long bitmap(long src, byte srcOffset, byte len, byte dstOffset, ref long dst)
{
    IL_0000: ldarg.s dst
    IL_0002: ldarg.s dst
    IL_0004: ldind.i8
    IL_0005: ldarg.3
    IL_0006: ldc.i4.s 63
    IL_0008: and
    IL_0009: shl
    IL_000A: stind.i8
    IL_000B: ldarg.s dst
    IL_000D: ldarg.s dst
    IL_000F: ldind.i8
    IL_0010: ldarg.0
    IL_0011: ldarg.1
    IL_0012: ldarg.2
    IL_0013: call System.Int64 Z0.Bits::extract(System.Int64,System.Byte,System.Byte)
    IL_0018: or
    IL_0019: stind.i8
    IL_001A: ldarg.s dst
    IL_001C: ret

}
ref sbyte bitmap(ulong src, byte srcOffset, byte len, byte dstOffset, ref sbyte dst)
{
    IL_0000: ldarg.s dst
    IL_0002: ldarg.s dst
    IL_0004: ldind.i1
    IL_0005: ldarg.3
    IL_0006: ldc.i4.s 31
    IL_0008: and
    IL_0009: shl
    IL_000A: conv.i1
    IL_000B: stind.i1
    IL_000C: ldarg.s dst
    IL_000E: ldarg.s dst
    IL_0010: ldind.i1
    IL_0011: ldarg.0
    IL_0012: ldarg.1
    IL_0013: ldarg.2
    IL_0014: call System.UInt64 Z0.Bits::extract(System.UInt64,System.Byte,System.Byte)
    IL_0019: conv.i1
    IL_001A: or
    IL_001B: conv.i1
    IL_001C: stind.i1
    IL_001D: ldarg.s dst
    IL_001F: ret

}
ref byte bitmap(ulong src, byte srcOffset, byte len, byte dstOffset, ref byte dst)
{
    IL_0000: ldarg.s dst
    IL_0002: ldarg.s dst
    IL_0004: ldind.u1
    IL_0005: ldarg.3
    IL_0006: ldc.i4.s 31
    IL_0008: and
    IL_0009: shl
    IL_000A: conv.u1
    IL_000B: stind.i1
    IL_000C: ldarg.s dst
    IL_000E: ldarg.s dst
    IL_0010: ldind.u1
    IL_0011: ldarg.0
    IL_0012: ldarg.1
    IL_0013: ldarg.2
    IL_0014: call System.UInt64 Z0.Bits::extract(System.UInt64,System.Byte,System.Byte)
    IL_0019: conv.u1
    IL_001A: or
    IL_001B: conv.u1
    IL_001C: stind.i1
    IL_001D: ldarg.s dst
    IL_001F: ret

}
ref short bitmap(ulong src, byte srcOffset, byte len, byte dstOffset, ref short dst)
{
    IL_0000: ldarg.s dst
    IL_0002: ldarg.s dst
    IL_0004: ldind.i2
    IL_0005: ldarg.3
    IL_0006: ldc.i4.s 31
    IL_0008: and
    IL_0009: shl
    IL_000A: conv.i2
    IL_000B: stind.i2
    IL_000C: ldarg.s dst
    IL_000E: ldarg.s dst
    IL_0010: ldind.i2
    IL_0011: ldarg.0
    IL_0012: ldarg.1
    IL_0013: ldarg.2
    IL_0014: call System.UInt64 Z0.Bits::extract(System.UInt64,System.Byte,System.Byte)
    IL_0019: conv.i2
    IL_001A: or
    IL_001B: conv.i2
    IL_001C: stind.i2
    IL_001D: ldarg.s dst
    IL_001F: ret

}
ref ushort bitmap(ulong src, byte srcOffset, byte len, byte dstOffset, ref ushort dst)
{
    IL_0000: ldarg.s dst
    IL_0002: ldarg.s dst
    IL_0004: ldind.u2
    IL_0005: ldarg.3
    IL_0006: ldc.i4.s 31
    IL_0008: and
    IL_0009: shl
    IL_000A: conv.u2
    IL_000B: stind.i2
    IL_000C: ldarg.s dst
    IL_000E: ldarg.s dst
    IL_0010: ldind.u2
    IL_0011: ldarg.0
    IL_0012: ldarg.1
    IL_0013: ldarg.2
    IL_0014: call System.UInt64 Z0.Bits::extract(System.UInt64,System.Byte,System.Byte)
    IL_0019: conv.u2
    IL_001A: or
    IL_001B: conv.u2
    IL_001C: stind.i2
    IL_001D: ldarg.s dst
    IL_001F: ret

}
ref int bitmap(ulong src, byte srcOffset, byte len, byte dstOffset, ref int dst)
{
    IL_0000: ldarg.s dst
    IL_0002: ldarg.s dst
    IL_0004: ldind.i4
    IL_0005: ldarg.3
    IL_0006: ldc.i4.s 31
    IL_0008: and
    IL_0009: shl
    IL_000A: stind.i4
    IL_000B: ldarg.s dst
    IL_000D: ldarg.s dst
    IL_000F: ldind.i4
    IL_0010: ldarg.0
    IL_0011: ldarg.1
    IL_0012: ldarg.2
    IL_0013: call System.UInt64 Z0.Bits::extract(System.UInt64,System.Byte,System.Byte)
    IL_0018: conv.i4
    IL_0019: or
    IL_001A: stind.i4
    IL_001B: ldarg.s dst
    IL_001D: ret

}
ref uint bitmap(ulong src, byte srcOffset, byte len, byte dstOffset, ref uint dst)
{
    IL_0000: ldarg.s dst
    IL_0002: ldarg.s dst
    IL_0004: ldind.u4
    IL_0005: ldarg.3
    IL_0006: ldc.i4.s 31
    IL_0008: and
    IL_0009: shl
    IL_000A: stind.i4
    IL_000B: ldarg.s dst
    IL_000D: ldarg.s dst
    IL_000F: ldind.u4
    IL_0010: ldarg.0
    IL_0011: ldarg.1
    IL_0012: ldarg.2
    IL_0013: call System.UInt64 Z0.Bits::extract(System.UInt64,System.Byte,System.Byte)
    IL_0018: conv.u4
    IL_0019: or
    IL_001A: stind.i4
    IL_001B: ldarg.s dst
    IL_001D: ret

}
ref long bitmap(ulong src, byte srcOffset, byte len, byte dstOffset, ref long dst)
{
    IL_0000: ldarg.s dst
    IL_0002: ldarg.s dst
    IL_0004: ldind.i8
    IL_0005: ldarg.3
    IL_0006: ldc.i4.s 63
    IL_0008: and
    IL_0009: shl
    IL_000A: stind.i8
    IL_000B: ldarg.s dst
    IL_000D: ldarg.s dst
    IL_000F: ldind.i8
    IL_0010: ldarg.0
    IL_0011: ldarg.1
    IL_0012: ldarg.2
    IL_0013: call System.UInt64 Z0.Bits::extract(System.UInt64,System.Byte,System.Byte)
    IL_0018: or
    IL_0019: stind.i8
    IL_001A: ldarg.s dst
    IL_001C: ret

}
ref ulong bitmap(ulong src, byte srcOffset, byte len, byte dstOffset, ref ulong dst)
{
    IL_0000: ldarg.s dst
    IL_0002: ldarg.s dst
    IL_0004: ldind.i8
    IL_0005: ldarg.3
    IL_0006: ldc.i4.s 63
    IL_0008: and
    IL_0009: shl
    IL_000A: stind.i8
    IL_000B: ldarg.s dst
    IL_000D: ldarg.s dst
    IL_000F: ldind.i8
    IL_0010: ldarg.0
    IL_0011: ldarg.1
    IL_0012: ldarg.2
    IL_0013: call System.UInt64 Z0.Bits::extract(System.UInt64,System.Byte,System.Byte)
    IL_0018: or
    IL_0019: stind.i8
    IL_001A: ldarg.s dst
    IL_001C: ret

}
ref float bitmap(float src, byte srcOffset, byte len, byte dstOffset, ref float dst)
{
    IL_0000: ldarg.s dst
    IL_0002: ldarg.0
    IL_0003: call System.Int32 Z0.MathX::ToBits(System.Single)
    IL_0008: ldarg.1
    IL_0009: ldarg.2
    IL_000A: call System.Int32 Z0.Bits::extract(System.Int32,System.Byte,System.Byte)
    IL_000F: ldarg.3
    IL_0010: ldc.i4.s 31
    IL_0012: and
    IL_0013: shl
    IL_0014: conv.r4
    IL_0015: call System.Single& Z0.math::or(System.Single&,System.Single)
    IL_001A: pop
    IL_001B: ldarg.s dst
    IL_001D: ret

}
ref double bitmap(double src, byte srcOffset, byte len, byte dstOffset, ref double dst)
{
    IL_0000: ldarg.s dst
    IL_0002: ldarg.0
    IL_0003: call System.Int64 Z0.MathX::ToBits(System.Double)
    IL_0008: ldarg.1
    IL_0009: ldarg.2
    IL_000A: call System.Int64 Z0.Bits::extract(System.Int64,System.Byte,System.Byte)
    IL_000F: ldarg.3
    IL_0010: ldc.i4.s 63
    IL_0012: and
    IL_0013: shl
    IL_0014: conv.r8
    IL_0015: call System.Double& Z0.math::or(System.Double&,System.Double)
    IL_001A: pop
    IL_001B: ldarg.s dst
    IL_001D: ret

}
byte blsi(byte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi1::ExtractLowestSetBit(System.UInt32)
    IL_0006: conv.u1
    IL_0007: ret

}
ushort blsi(ushort src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi1::ExtractLowestSetBit(System.UInt32)
    IL_0006: conv.u2
    IL_0007: ret

}
uint blsi(uint src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi1::ExtractLowestSetBit(System.UInt32)
    IL_0006: ret

}
ulong blsi(ulong src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt64 System.Runtime.Intrinsics.X86.Bmi1/X64::ExtractLowestSetBit(System.UInt64)
    IL_0006: ret

}
byte blsic(byte src)
{
    IL_0000: ldarg.0
    IL_0001: not
    IL_0002: ldarg.0
    IL_0003: ldc.i4.1
    IL_0004: sub
    IL_0005: or
    IL_0006: conv.u1
    IL_0007: ret

}
ushort blsic(ushort src)
{
    IL_0000: ldarg.0
    IL_0001: not
    IL_0002: ldarg.0
    IL_0003: ldc.i4.1
    IL_0004: sub
    IL_0005: or
    IL_0006: conv.u2
    IL_0007: ret

}
uint blsic(uint src)
{
    IL_0000: ldarg.0
    IL_0001: not
    IL_0002: ldarg.0
    IL_0003: ldc.i4.1
    IL_0004: sub
    IL_0005: or
    IL_0006: ret

}
ulong blsic(ulong src)
{
    IL_0000: ldarg.0
    IL_0001: not
    IL_0002: ldarg.0
    IL_0003: ldc.i4.1
    IL_0004: conv.i8
    IL_0005: sub
    IL_0006: or
    IL_0007: ret

}
byte blsmsk(byte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi1::GetMaskUpToLowestSetBit(System.UInt32)
    IL_0006: conv.u1
    IL_0007: ret

}
ushort blsmsk(ushort src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi1::GetMaskUpToLowestSetBit(System.UInt32)
    IL_0006: conv.u2
    IL_0007: ret

}
uint blsmsk(uint src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi1::GetMaskUpToLowestSetBit(System.UInt32)
    IL_0006: ret

}
ulong blsmsk(ulong src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt64 System.Runtime.Intrinsics.X86.Bmi1/X64::GetMaskUpToLowestSetBit(System.UInt64)
    IL_0006: ret

}
byte blsr(byte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi1::ResetLowestSetBit(System.UInt32)
    IL_0006: conv.u1
    IL_0007: ret

}
ushort blsr(ushort src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi1::ResetLowestSetBit(System.UInt32)
    IL_0006: conv.u2
    IL_0007: ret

}
uint blsr(uint src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi1::ResetLowestSetBit(System.UInt32)
    IL_0006: ret

}
ulong blsr(ulong src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt64 System.Runtime.Intrinsics.X86.Bmi1/X64::ResetLowestSetBit(System.UInt64)
    IL_0006: ret

}
byte butterfly(N1 n, byte x)
{
    IL_0000: ldarg.1
    IL_0001: ldc.i4.s 102
    IL_0003: ldc.i4.1
    IL_0004: call System.Byte Z0.Bits::butterfly<System.Byte>(System.Byte,System.Byte,System.Int32)
    IL_0009: ret

}
ushort butterfly(N1 n, ushort x)
{
    IL_0000: ldarg.1
    IL_0001: ldc.i4 26214
    IL_0006: ldc.i4.1
    IL_0007: call System.UInt16 Z0.Bits::butterfly<System.UInt16>(System.UInt16,System.UInt16,System.Int32)
    IL_000C: ret

}
uint butterfly(N1 n, uint x)
{
    IL_0000: ldarg.1
    IL_0001: ldc.i4 1717986918
    IL_0006: ldc.i4.1
    IL_0007: call System.UInt32 Z0.Bits::butterfly<System.UInt32>(System.UInt32,System.UInt32,System.Int32)
    IL_000C: ret

}
ulong butterfly(N1 n, ulong x)
{
    IL_0000: ldarg.1
    IL_0001: ldc.i8 7378697629483820646
    IL_000A: ldc.i4.1
    IL_000B: call System.UInt64 Z0.Bits::butterfly<System.UInt64>(System.UInt64,System.UInt64,System.Int32)
    IL_0010: ret

}
byte butterfly(N2 n, byte x)
{
    IL_0000: ldarg.1
    IL_0001: ldc.i4.s 60
    IL_0003: ldc.i4.2
    IL_0004: call System.Byte Z0.Bits::butterfly<System.Byte>(System.Byte,System.Byte,System.Int32)
    IL_0009: ret

}
ushort butterfly(N2 n, ushort x)
{
    IL_0000: ldarg.1
    IL_0001: ldc.i4 15420
    IL_0006: ldc.i4.2
    IL_0007: call System.UInt16 Z0.Bits::butterfly<System.UInt16>(System.UInt16,System.UInt16,System.Int32)
    IL_000C: ret

}
uint butterfly(N2 n, uint x)
{
    IL_0000: ldarg.1
    IL_0001: ldc.i4 1010580540
    IL_0006: ldc.i4.2
    IL_0007: call System.UInt32 Z0.Bits::butterfly<System.UInt32>(System.UInt32,System.UInt32,System.Int32)
    IL_000C: ret

}
ulong butterfly(N2 n, ulong x)
{
    IL_0000: ldarg.1
    IL_0001: ldc.i8 4340410370284600380
    IL_000A: ldc.i4.2
    IL_000B: call System.UInt64 Z0.Bits::butterfly<System.UInt64>(System.UInt64,System.UInt64,System.Int32)
    IL_0010: ret

}
ushort butterfly(N4 n, ushort x)
{
    IL_0000: ldarg.1
    IL_0001: ldc.i4 4080
    IL_0006: ldc.i4.4
    IL_0007: call System.UInt16 Z0.Bits::butterfly<System.UInt16>(System.UInt16,System.UInt16,System.Int32)
    IL_000C: ret

}
uint butterfly(N4 n, uint x)
{
    IL_0000: ldarg.1
    IL_0001: ldc.i4 267390960
    IL_0006: ldc.i4.4
    IL_0007: call System.UInt32 Z0.Bits::butterfly<System.UInt32>(System.UInt32,System.UInt32,System.Int32)
    IL_000C: ret

}
ulong butterfly(N4 n, ulong x)
{
    IL_0000: ldarg.1
    IL_0001: ldc.i8 1148435428713435120
    IL_000A: ldc.i4.4
    IL_000B: call System.UInt64 Z0.Bits::butterfly<System.UInt64>(System.UInt64,System.UInt64,System.Int32)
    IL_0010: ret

}
