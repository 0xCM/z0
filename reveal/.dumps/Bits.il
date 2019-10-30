// 2019-10-30 14:10:41:078
bool test(ushort src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.BitMask::test(System.UInt16,System.Int32)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret

}
bool test(int src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.BitMask::test(System.Int32,System.Int32)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret

}
bool test(uint src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.BitMask::test(System.UInt32,System.Int32)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret

}
bool test(long src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.BitMask::test(System.Int64,System.Int32)
    IL_0007: ret

}
bool test(ulong src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.BitMask::test(System.UInt64,System.Int32)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret

}
bool test(float src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.BitMask::test(System.Single,System.Int32)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret

}
bool test(double src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.BitMask::test(System.Double,System.Int32)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret

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
BitSize width(in byte src)
{
    IL_0000: ldc.i4.8
    IL_0001: ldarg.0
    IL_0002: call System.UInt32 Z0.Bits::nlz(System.Byte&)
    IL_0007: sub
    IL_0008: call Z0.BitSize Z0.BitSize::op_Implicit(System.UInt32)
    IL_000D: ret

}
BitSize width(in ushort src)
{
    IL_0000: ldc.i4.s 16
    IL_0002: ldarg.0
    IL_0003: call System.UInt32 Z0.Bits::nlz(System.UInt16&)
    IL_0008: sub
    IL_0009: call Z0.BitSize Z0.BitSize::op_Implicit(System.UInt32)
    IL_000E: ret

}
BitSize width(in uint src)
{
    IL_0000: ldc.i4.s 32
    IL_0002: ldarg.0
    IL_0003: call System.UInt32 Z0.Bits::nlz(System.UInt32&)
    IL_0008: sub
    IL_0009: call Z0.BitSize Z0.BitSize::op_Implicit(System.UInt32)
    IL_000E: ret

}
BitSize width(in ulong src)
{
    IL_0000: ldc.i4.s 64
    IL_0002: ldarg.0
    IL_0003: call System.UInt32 Z0.Bits::nlz(System.UInt64&)
    IL_0008: sub
    IL_0009: call Z0.BitSize Z0.BitSize::op_Implicit(System.UInt32)
    IL_000E: ret

}
sbyte xorsl(sbyte src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: ldc.i4.s 31
    IL_0005: and
    IL_0006: shl
    IL_0007: conv.i1
    IL_0008: xor
    IL_0009: conv.i1
    IL_000A: ret

}
byte xorsl(byte src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: ldc.i4.s 31
    IL_0005: and
    IL_0006: shl
    IL_0007: conv.u1
    IL_0008: xor
    IL_0009: conv.u1
    IL_000A: ret

}
short xorsl(short src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: ldc.i4.s 31
    IL_0005: and
    IL_0006: shl
    IL_0007: conv.i2
    IL_0008: xor
    IL_0009: conv.i2
    IL_000A: ret

}
ushort xorsl(ushort src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: ldc.i4.s 31
    IL_0005: and
    IL_0006: shl
    IL_0007: conv.u2
    IL_0008: xor
    IL_0009: conv.u2
    IL_000A: ret

}
int xorsl(int src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: ldc.i4.s 31
    IL_0005: and
    IL_0006: shl
    IL_0007: xor
    IL_0008: ret

}
uint xorsl(uint src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: ldc.i4.s 31
    IL_0005: and
    IL_0006: shl
    IL_0007: xor
    IL_0008: ret

}
long xorsl(long src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: ldc.i4.s 63
    IL_0005: and
    IL_0006: shl
    IL_0007: xor
    IL_0008: ret

}
ulong xorsl(ulong src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: ldc.i4.s 63
    IL_0005: and
    IL_0006: shl
    IL_0007: xor
    IL_0008: ret

}
ref sbyte xorsl(ref sbyte src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i1
    IL_0003: ldarg.0
    IL_0004: ldind.i1
    IL_0005: ldarg.1
    IL_0006: ldc.i4.s 31
    IL_0008: and
    IL_0009: shl
    IL_000A: conv.i1
    IL_000B: xor
    IL_000C: conv.i1
    IL_000D: stind.i1
    IL_000E: ldarg.0
    IL_000F: ret

}
ref byte xorsl(ref byte src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u1
    IL_0003: ldarg.0
    IL_0004: ldind.u1
    IL_0005: ldarg.1
    IL_0006: ldc.i4.s 31
    IL_0008: and
    IL_0009: shl
    IL_000A: conv.u1
    IL_000B: xor
    IL_000C: conv.u1
    IL_000D: stind.i1
    IL_000E: ldarg.0
    IL_000F: ret

}
ref short xorsl(ref short src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i2
    IL_0003: ldarg.0
    IL_0004: ldind.i2
    IL_0005: ldarg.1
    IL_0006: ldc.i4.s 31
    IL_0008: and
    IL_0009: shl
    IL_000A: conv.i2
    IL_000B: xor
    IL_000C: conv.i2
    IL_000D: stind.i2
    IL_000E: ldarg.0
    IL_000F: ret

}
ref ushort xorsl(ref ushort src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u2
    IL_0003: ldarg.0
    IL_0004: ldind.u2
    IL_0005: ldarg.1
    IL_0006: ldc.i4.s 31
    IL_0008: and
    IL_0009: shl
    IL_000A: conv.u2
    IL_000B: xor
    IL_000C: conv.u2
    IL_000D: stind.i2
    IL_000E: ldarg.0
    IL_000F: ret

}
ref int xorsl(ref int src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i4
    IL_0003: ldarg.0
    IL_0004: ldind.i4
    IL_0005: ldarg.1
    IL_0006: ldc.i4.s 31
    IL_0008: and
    IL_0009: shl
    IL_000A: xor
    IL_000B: stind.i4
    IL_000C: ldarg.0
    IL_000D: ret

}
ref uint xorsl(ref uint src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u4
    IL_0003: ldarg.0
    IL_0004: ldind.u4
    IL_0005: ldarg.1
    IL_0006: ldc.i4.s 31
    IL_0008: and
    IL_0009: shl
    IL_000A: xor
    IL_000B: stind.i4
    IL_000C: ldarg.0
    IL_000D: ret

}
ref long xorsl(ref long src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldarg.0
    IL_0004: ldind.i8
    IL_0005: ldarg.1
    IL_0006: ldc.i4.s 63
    IL_0008: and
    IL_0009: shl
    IL_000A: xor
    IL_000B: stind.i8
    IL_000C: ldarg.0
    IL_000D: ret

}
ref ulong xorsl(ref ulong src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldarg.0
    IL_0004: ldind.i8
    IL_0005: ldarg.1
    IL_0006: ldc.i4.s 63
    IL_0008: and
    IL_0009: shl
    IL_000A: xor
    IL_000B: stind.i8
    IL_000C: ldarg.0
    IL_000D: ret

}
sbyte xorsr(sbyte src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: ldc.i4.s 31
    IL_0005: and
    IL_0006: shr
    IL_0007: conv.i1
    IL_0008: xor
    IL_0009: conv.i1
    IL_000A: ret

}
byte xorsr(byte src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: ldc.i4.s 31
    IL_0005: and
    IL_0006: shr
    IL_0007: conv.u1
    IL_0008: xor
    IL_0009: conv.u1
    IL_000A: ret

}
short xorsr(short src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: ldc.i4.s 31
    IL_0005: and
    IL_0006: shr
    IL_0007: conv.i2
    IL_0008: xor
    IL_0009: conv.i2
    IL_000A: ret

}
ushort xorsr(ushort src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: ldc.i4.s 31
    IL_0005: and
    IL_0006: shr
    IL_0007: conv.u2
    IL_0008: xor
    IL_0009: conv.u2
    IL_000A: ret

}
int xorsr(int src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: ldc.i4.s 31
    IL_0005: and
    IL_0006: shr
    IL_0007: xor
    IL_0008: ret

}
uint xorsr(uint src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: ldc.i4.s 31
    IL_0005: and
    IL_0006: shr.un
    IL_0007: xor
    IL_0008: ret

}
long xorsr(long src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: ldc.i4.s 63
    IL_0005: and
    IL_0006: shr
    IL_0007: xor
    IL_0008: ret

}
ulong xorsr(ulong src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: ldc.i4.s 63
    IL_0005: and
    IL_0006: shr.un
    IL_0007: xor
    IL_0008: ret

}
ref sbyte xorsr(ref sbyte src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i1
    IL_0003: ldarg.0
    IL_0004: ldind.i1
    IL_0005: ldarg.1
    IL_0006: ldc.i4.s 31
    IL_0008: and
    IL_0009: shr
    IL_000A: conv.i1
    IL_000B: xor
    IL_000C: conv.i1
    IL_000D: stind.i1
    IL_000E: ldarg.0
    IL_000F: ret

}
ref byte xorsr(ref byte src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u1
    IL_0003: ldarg.0
    IL_0004: ldind.u1
    IL_0005: ldarg.1
    IL_0006: ldc.i4.s 31
    IL_0008: and
    IL_0009: shr
    IL_000A: conv.u1
    IL_000B: xor
    IL_000C: conv.u1
    IL_000D: stind.i1
    IL_000E: ldarg.0
    IL_000F: ret

}
ref short xorsr(ref short src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i2
    IL_0003: ldarg.0
    IL_0004: ldind.i2
    IL_0005: ldarg.1
    IL_0006: ldc.i4.s 31
    IL_0008: and
    IL_0009: shr
    IL_000A: conv.i2
    IL_000B: xor
    IL_000C: conv.i2
    IL_000D: stind.i2
    IL_000E: ldarg.0
    IL_000F: ret

}
ref ushort xorsr(ref ushort src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u2
    IL_0003: ldarg.0
    IL_0004: ldind.u2
    IL_0005: ldarg.1
    IL_0006: ldc.i4.s 31
    IL_0008: and
    IL_0009: shr
    IL_000A: conv.u2
    IL_000B: xor
    IL_000C: conv.u2
    IL_000D: stind.i2
    IL_000E: ldarg.0
    IL_000F: ret

}
ref int xorsr(ref int src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i4
    IL_0003: ldarg.0
    IL_0004: ldind.i4
    IL_0005: ldarg.1
    IL_0006: ldc.i4.s 31
    IL_0008: and
    IL_0009: shr
    IL_000A: xor
    IL_000B: stind.i4
    IL_000C: ldarg.0
    IL_000D: ret

}
ref uint xorsr(ref uint src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u4
    IL_0003: ldarg.0
    IL_0004: ldind.u4
    IL_0005: ldarg.1
    IL_0006: ldc.i4.s 31
    IL_0008: and
    IL_0009: shr.un
    IL_000A: xor
    IL_000B: stind.i4
    IL_000C: ldarg.0
    IL_000D: ret

}
ref long xorsr(ref long src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldarg.0
    IL_0004: ldind.i8
    IL_0005: ldarg.1
    IL_0006: ldc.i4.s 63
    IL_0008: and
    IL_0009: shr
    IL_000A: xor
    IL_000B: stind.i8
    IL_000C: ldarg.0
    IL_000D: ret

}
ref ulong xorsr(ref ulong src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldarg.0
    IL_0004: ldind.i8
    IL_0005: ldarg.1
    IL_0006: ldc.i4.s 63
    IL_0008: and
    IL_0009: shr.un
    IL_000A: xor
    IL_000B: stind.i8
    IL_000C: ldarg.0
    IL_000D: ret

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
ref sbyte loff(ref sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i1
    IL_0003: ldarg.0
    IL_0004: ldind.i1
    IL_0005: ldc.i4.1
    IL_0006: sub
    IL_0007: conv.i1
    IL_0008: and
    IL_0009: conv.i1
    IL_000A: stind.i1
    IL_000B: ldarg.0
    IL_000C: ret

}
ref byte loff(ref byte src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u1
    IL_0003: ldarg.0
    IL_0004: ldind.u1
    IL_0005: ldc.i4.1
    IL_0006: sub
    IL_0007: conv.u1
    IL_0008: and
    IL_0009: conv.u1
    IL_000A: stind.i1
    IL_000B: ldarg.0
    IL_000C: ret

}
ref short loff(ref short src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i2
    IL_0003: ldarg.0
    IL_0004: ldind.i2
    IL_0005: ldc.i4.1
    IL_0006: sub
    IL_0007: conv.i2
    IL_0008: and
    IL_0009: conv.i2
    IL_000A: stind.i2
    IL_000B: ldarg.0
    IL_000C: ret

}
ref ushort loff(ref ushort src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u2
    IL_0003: ldarg.0
    IL_0004: ldind.u2
    IL_0005: ldc.i4.1
    IL_0006: sub
    IL_0007: conv.u2
    IL_0008: and
    IL_0009: conv.u2
    IL_000A: stind.i2
    IL_000B: ldarg.0
    IL_000C: ret

}
ref int loff(ref int src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i4
    IL_0003: ldarg.0
    IL_0004: ldind.i4
    IL_0005: ldc.i4.1
    IL_0006: sub
    IL_0007: and
    IL_0008: stind.i4
    IL_0009: ldarg.0
    IL_000A: ret

}
ref uint loff(ref uint src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u4
    IL_0003: ldarg.0
    IL_0004: ldind.u4
    IL_0005: ldc.i4.1
    IL_0006: sub
    IL_0007: and
    IL_0008: stind.i4
    IL_0009: ldarg.0
    IL_000A: ret

}
ref long loff(ref long src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldarg.0
    IL_0004: ldind.i8
    IL_0005: ldc.i4.1
    IL_0006: conv.i8
    IL_0007: sub
    IL_0008: and
    IL_0009: stind.i8
    IL_000A: ldarg.0
    IL_000B: ret

}
ref ulong loff(ref ulong src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldarg.0
    IL_0004: ldind.i8
    IL_0005: ldc.i4.1
    IL_0006: conv.i8
    IL_0007: sub
    IL_0008: and
    IL_0009: stind.i8
    IL_000A: ldarg.0
    IL_000B: ret

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
uint nlz(in byte src)
{
    IL_0000: ldarg.0
    IL_0001: ldind.u1
    IL_0002: call System.UInt32 System.Runtime.Intrinsics.X86.Lzcnt::LeadingZeroCount(System.UInt32)
    IL_0007: ldc.i4.s 24
    IL_0009: sub
    IL_000A: ret

}
uint nlz(in ushort src)
{
    IL_0000: ldarg.0
    IL_0001: ldind.u2
    IL_0002: call System.UInt32 System.Runtime.Intrinsics.X86.Lzcnt::LeadingZeroCount(System.UInt32)
    IL_0007: ldc.i4.s 16
    IL_0009: sub
    IL_000A: ret

}
uint nlz(in uint src)
{
    IL_0000: ldarg.0
    IL_0001: ldind.u4
    IL_0002: call System.UInt32 System.Runtime.Intrinsics.X86.Lzcnt::LeadingZeroCount(System.UInt32)
    IL_0007: ret

}
uint nlz(in ulong src)
{
    IL_0000: ldarg.0
    IL_0001: ldind.i8
    IL_0002: call System.UInt64 System.Runtime.Intrinsics.X86.Lzcnt/X64::LeadingZeroCount(System.UInt64)
    IL_0007: conv.u4
    IL_0008: ret

}
uint ntz(sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi1::TrailingZeroCount(System.UInt32)
    IL_0006: ret

}
uint ntz(byte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi1::TrailingZeroCount(System.UInt32)
    IL_0006: ret

}
uint ntz(short src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi1::TrailingZeroCount(System.UInt32)
    IL_0006: ret

}
uint ntz(ushort src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi1::TrailingZeroCount(System.UInt32)
    IL_0006: ret

}
uint ntz(int src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi1::TrailingZeroCount(System.UInt32)
    IL_0006: ret

}
uint ntz(uint src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi1::TrailingZeroCount(System.UInt32)
    IL_0006: ret

}
uint ntz(long src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt64 System.Runtime.Intrinsics.X86.Bmi1/X64::TrailingZeroCount(System.UInt64)
    IL_0006: conv.u4
    IL_0007: ret

}
uint ntz(ulong src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt64 System.Runtime.Intrinsics.X86.Bmi1/X64::TrailingZeroCount(System.UInt64)
    IL_0006: conv.u4
    IL_0007: ret

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
    IL_0001: conv.u8
    IL_0002: ldarg.1
    IL_0003: conv.u8
    IL_0004: ldc.i4.s 16
    IL_0006: shl
    IL_0007: or
    IL_0008: ldarg.1
    IL_0009: conv.u8
    IL_000A: ldc.i4.s 32
    IL_000C: shl
    IL_000D: or
    IL_000E: ldarg.1
    IL_000F: conv.u8
    IL_0010: ldc.i4.s 48
    IL_0012: shl
    IL_0013: or
    IL_0014: ret

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
ref byte pack(byte x0, byte x1, byte x2, byte x3, byte x4, byte x5, byte x6, byte x7, byte pos, ref byte dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.s pos
    IL_0003: call Z0.bit Z0.BitMask::test(System.Byte,System.Byte)
    IL_0008: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000D: brfalse.s IL_0018
    IL_000F: ldarg.s dst
    IL_0011: ldc.i4.0
    IL_0012: call System.Byte& Z0.BitMask::enable(System.Byte&,System.Int32)
    IL_0017: pop
    IL_0018: ldarg.1
    IL_0019: ldarg.s pos
    IL_001B: call Z0.bit Z0.BitMask::test(System.Byte,System.Byte)
    IL_0020: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_0025: brfalse.s IL_0030
    IL_0027: ldarg.s dst
    IL_0029: ldc.i4.1
    IL_002A: call System.Byte& Z0.BitMask::enable(System.Byte&,System.Int32)
    IL_002F: pop
    IL_0030: ldarg.2
    IL_0031: ldarg.s pos
    IL_0033: call Z0.bit Z0.BitMask::test(System.Byte,System.Byte)
    IL_0038: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_003D: brfalse.s IL_0048
    IL_003F: ldarg.s dst
    IL_0041: ldc.i4.2
    IL_0042: call System.Byte& Z0.BitMask::enable(System.Byte&,System.Int32)
    IL_0047: pop
    IL_0048: ldarg.3
    IL_0049: ldarg.s pos
    IL_004B: call Z0.bit Z0.BitMask::test(System.Byte,System.Byte)
    IL_0050: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_0055: brfalse.s IL_0060
    IL_0057: ldarg.s dst
    IL_0059: ldc.i4.3
    IL_005A: call System.Byte& Z0.BitMask::enable(System.Byte&,System.Int32)
    IL_005F: pop
    IL_0060: ldarg.s x4
    IL_0062: ldarg.s pos
    IL_0064: call Z0.bit Z0.BitMask::test(System.Byte,System.Byte)
    IL_0069: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_006E: brfalse.s IL_0079
    IL_0070: ldarg.s dst
    IL_0072: ldc.i4.4
    IL_0073: call System.Byte& Z0.BitMask::enable(System.Byte&,System.Int32)
    IL_0078: pop
    IL_0079: ldarg.s x5
    IL_007B: ldarg.s pos
    IL_007D: call Z0.bit Z0.BitMask::test(System.Byte,System.Byte)
    IL_0082: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_0087: brfalse.s IL_0092
    IL_0089: ldarg.s dst
    IL_008B: ldc.i4.5
    IL_008C: call System.Byte& Z0.BitMask::enable(System.Byte&,System.Int32)
    IL_0091: pop
    IL_0092: ldarg.s x6
    IL_0094: ldarg.s pos
    IL_0096: call Z0.bit Z0.BitMask::test(System.Byte,System.Byte)
    IL_009B: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_00A0: brfalse.s IL_00AB
    IL_00A2: ldarg.s dst
    IL_00A4: ldc.i4.6
    IL_00A5: call System.Byte& Z0.BitMask::enable(System.Byte&,System.Int32)
    IL_00AA: pop
    IL_00AB: ldarg.s x7
    IL_00AD: ldarg.s pos
    IL_00AF: call Z0.bit Z0.BitMask::test(System.Byte,System.Byte)
    IL_00B4: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_00B9: brfalse.s IL_00C4
    IL_00BB: ldarg.s dst
    IL_00BD: ldc.i4.7
    IL_00BE: call System.Byte& Z0.BitMask::enable(System.Byte&,System.Int32)
    IL_00C3: pop
    IL_00C4: ldarg.s dst
    IL_00C6: ret

}
byte pack2(bool b0, bool b1)
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: ldarg.0
    IL_0003: brfalse.s IL_000E
    IL_0005: ldloca.s V_0
    IL_0007: ldc.i4.0
    IL_0008: call System.Byte& Z0.BitMask::enable(System.Byte&,System.Int32)
    IL_000D: pop
    IL_000E: ldarg.1
    IL_000F: brfalse.s IL_001A
    IL_0011: ldloca.s V_0
    IL_0013: ldc.i4.1
    IL_0014: call System.Byte& Z0.BitMask::enable(System.Byte&,System.Int32)
    IL_0019: pop
    IL_001A: ldloc.0
    IL_001B: ret

}
byte pack3(bool b0, bool b1, bool b2)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Byte Z0.Bits::pack2(System.Boolean,System.Boolean)
    IL_0007: stloc.0
    IL_0008: ldarg.2
    IL_0009: brfalse.s IL_0014
    IL_000B: ldloca.s V_0
    IL_000D: ldc.i4.2
    IL_000E: call System.Byte& Z0.BitMask::enable(System.Byte&,System.Int32)
    IL_0013: pop
    IL_0014: ldloc.0
    IL_0015: ret

}
byte pack4(bool b0, bool b1, bool b2, bool b3)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.Byte Z0.Bits::pack3(System.Boolean,System.Boolean,System.Boolean)
    IL_0008: stloc.0
    IL_0009: ldarg.3
    IL_000A: brfalse.s IL_0015
    IL_000C: ldloca.s V_0
    IL_000E: ldc.i4.3
    IL_000F: call System.Byte& Z0.BitMask::enable(System.Byte&,System.Int32)
    IL_0014: pop
    IL_0015: ldloc.0
    IL_0016: ret

}
byte pack5(bool b0, bool b1, bool b2, bool b3, bool b4)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: ldarg.3
    IL_0004: call System.Byte Z0.Bits::pack4(System.Boolean,System.Boolean,System.Boolean,System.Boolean)
    IL_0009: stloc.0
    IL_000A: ldarg.s b4
    IL_000C: brfalse.s IL_0017
    IL_000E: ldloca.s V_0
    IL_0010: ldc.i4.4
    IL_0011: call System.Byte& Z0.BitMask::enable(System.Byte&,System.Int32)
    IL_0016: pop
    IL_0017: ldloc.0
    IL_0018: ret

}
byte pack6(bool b0, bool b1, bool b2, bool b3, bool b4, bool b5)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: ldarg.3
    IL_0004: ldarg.s b4
    IL_0006: call System.Byte Z0.Bits::pack5(System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean)
    IL_000B: stloc.0
    IL_000C: ldarg.s b5
    IL_000E: brfalse.s IL_0019
    IL_0010: ldloca.s V_0
    IL_0012: ldc.i4.5
    IL_0013: call System.Byte& Z0.BitMask::enable(System.Byte&,System.Int32)
    IL_0018: pop
    IL_0019: ldloc.0
    IL_001A: ret

}
byte pack7(bool b0, bool b1, bool b2, bool b3, bool b4, bool b5, bool b6)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldarg.2
    IL_0003: ldarg.3
    IL_0004: ldarg.s b4
    IL_0006: ldarg.s b5
    IL_0008: call System.Byte Z0.Bits::pack6(System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean)
    IL_000D: stloc.0
    IL_000E: ldarg.s b6
    IL_0010: brfalse.s IL_001B
    IL_0012: ldloca.s V_0
    IL_0014: ldc.i4.6
    IL_0015: call System.Byte& Z0.BitMask::enable(System.Byte&,System.Int32)
    IL_001A: pop
    IL_001B: ldloc.0
    IL_001C: ret

}
byte pack8(bool b0, bool b1, bool b2, bool b3, bool b4, bool b5, bool b6, bool b7)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldarg.2
    IL_0003: ldarg.3
    IL_0004: ldarg.s b4
    IL_0006: ldarg.s b5
    IL_0008: ldarg.s b6
    IL_000A: call System.Byte Z0.Bits::pack7(System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean)
    IL_000F: stloc.0
    IL_0010: ldarg.s b7
    IL_0012: brfalse.s IL_001D
    IL_0014: ldloca.s V_0
    IL_0016: ldc.i4.7
    IL_0017: call System.Byte& Z0.BitMask::enable(System.Byte&,System.Int32)
    IL_001C: pop
    IL_001D: ldloc.0
    IL_001E: ret

}
Span<byte> pack(ReadOnlySpan<bit> src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Int32 System.ReadOnlySpan`1<Z0.bit>::get_Length()
    IL_0007: stloc.0
    IL_0008: ldloc.0
    IL_0009: ldc.i4.3
    IL_000A: shr
    IL_000B: stloc.1
    IL_000C: ldloc.0
    IL_000D: ldc.i4.7
    IL_000E: and
    IL_000F: brfalse.s IL_0015
    IL_0011: ldloc.1
    IL_0012: ldc.i4.1
    IL_0013: add
    IL_0014: stloc.1
    IL_0015: ldarg.0
    IL_0016: ldloc.1
    IL_0017: newarr System.Byte
    IL_001C: call System.Span`1<System.Byte> System.Span`1<System.Byte>::op_Implicit(System.Byte[])
    IL_0021: call System.Span`1<System.Byte> Z0.Bits::pack(System.ReadOnlySpan`1<Z0.bit>,System.Span`1<System.Byte>)
    IL_0026: ret

}
Span<byte> pack(bit[] src)
{
    IL_0000: ldarg.0
    IL_0001: ldlen
    IL_0002: conv.i4
    IL_0003: stloc.0
    IL_0004: ldloc.0
    IL_0005: call System.UInt32 Z0.Mod8::div(System.UInt32)
    IL_000A: stloc.1
    IL_000B: ldloc.0
    IL_000C: call System.UInt32 Z0.Mod8::mod(System.UInt32)
    IL_0011: stloc.2
    IL_0012: ldloc.1
    IL_0013: conv.u8
    IL_0014: ldloc.2
    IL_0015: brtrue.s IL_001A
    IL_0017: ldc.i4.0
    IL_0018: br.s IL_001B
    IL_001A: ldc.i4.1
    IL_001B: conv.i8
    IL_001C: add
    IL_001D: stloc.3
    IL_001E: ldloc.3
    IL_001F: conv.ovf.i
    IL_0020: newarr System.Byte
    IL_0025: call System.Span`1<System.Byte> System.Span`1<System.Byte>::op_Implicit(System.Byte[])
    IL_002A: stloc.s V_4
    IL_002C: ldc.i4.0
    IL_002D: stloc.s V_5
    IL_002F: br.s IL_0069
    IL_0031: ldc.i4.0
    IL_0032: stloc.s V_6
    IL_0034: br.s IL_005E
    IL_0036: ldloca.s V_4
    IL_0038: ldloc.s V_6
    IL_003A: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_003F: dup
    IL_0040: ldind.u1
    IL_0041: ldarg.0
    IL_0042: ldloc.s V_5
    IL_0044: ldelem Z0.bit
    IL_0049: call System.UInt32 Z0.bit::op_Explicit(Z0.bit)
    IL_004E: ldloc.s V_6
    IL_0050: ldc.i4.s 31
    IL_0052: and
    IL_0053: shl
    IL_0054: conv.u1
    IL_0055: or
    IL_0056: conv.u1
    IL_0057: stind.i1
    IL_0058: ldloc.s V_6
    IL_005A: ldc.i4.1
    IL_005B: add
    IL_005C: stloc.s V_6
    IL_005E: ldloc.s V_6
    IL_0060: ldc.i4.8
    IL_0061: blt.s IL_0036
    IL_0063: ldloc.s V_5
    IL_0065: ldc.i4.1
    IL_0066: add
    IL_0067: stloc.s V_5
    IL_0069: ldloc.s V_5
    IL_006B: conv.i8
    IL_006C: ldloc.0
    IL_006D: conv.u8
    IL_006E: blt.s IL_0031
    IL_0070: ldloc.s V_4
    IL_0072: ret

}
ulong pack(N8 n, Span<bit> src)
{
    IL_0000: ldarga.s src
    IL_0002: ldc.i4.0
    IL_0003: call Z0.bit& System.Span`1<Z0.bit>::get_Item(System.Int32)
    IL_0008: ldobj Z0.bit
    IL_000D: call System.UInt32 Z0.bit::op_Explicit(Z0.bit)
    IL_0012: stloc.0
    IL_0013: ldloc.0
    IL_0014: ldarga.s src
    IL_0016: ldc.i4.1
    IL_0017: call Z0.bit& System.Span`1<Z0.bit>::get_Item(System.Int32)
    IL_001C: ldobj Z0.bit
    IL_0021: call System.UInt32 Z0.bit::op_Explicit(Z0.bit)
    IL_0026: ldc.i4.1
    IL_0027: shl
    IL_0028: or
    IL_0029: stloc.0
    IL_002A: ldloc.0
    IL_002B: ldarga.s src
    IL_002D: ldc.i4.2
    IL_002E: call Z0.bit& System.Span`1<Z0.bit>::get_Item(System.Int32)
    IL_0033: ldobj Z0.bit
    IL_0038: call System.UInt32 Z0.bit::op_Explicit(Z0.bit)
    IL_003D: ldc.i4.2
    IL_003E: shl
    IL_003F: or
    IL_0040: stloc.0
    IL_0041: ldloc.0
    IL_0042: ldarga.s src
    IL_0044: ldc.i4.3
    IL_0045: call Z0.bit& System.Span`1<Z0.bit>::get_Item(System.Int32)
    IL_004A: ldobj Z0.bit
    IL_004F: call System.UInt32 Z0.bit::op_Explicit(Z0.bit)
    IL_0054: ldc.i4.3
    IL_0055: shl
    IL_0056: or
    IL_0057: stloc.0
    IL_0058: ldloc.0
    IL_0059: ldarga.s src
    IL_005B: ldc.i4.4
    IL_005C: call Z0.bit& System.Span`1<Z0.bit>::get_Item(System.Int32)
    IL_0061: ldobj Z0.bit
    IL_0066: call System.UInt32 Z0.bit::op_Explicit(Z0.bit)
    IL_006B: ldc.i4.4
    IL_006C: shl
    IL_006D: or
    IL_006E: stloc.0
    IL_006F: ldloc.0
    IL_0070: ldarga.s src
    IL_0072: ldc.i4.5
    IL_0073: call Z0.bit& System.Span`1<Z0.bit>::get_Item(System.Int32)
    IL_0078: ldobj Z0.bit
    IL_007D: call System.UInt32 Z0.bit::op_Explicit(Z0.bit)
    IL_0082: ldc.i4.5
    IL_0083: shl
    IL_0084: or
    IL_0085: stloc.0
    IL_0086: ldloc.0
    IL_0087: ldarga.s src
    IL_0089: ldc.i4.6
    IL_008A: call Z0.bit& System.Span`1<Z0.bit>::get_Item(System.Int32)
    IL_008F: ldobj Z0.bit
    IL_0094: call System.UInt32 Z0.bit::op_Explicit(Z0.bit)
    IL_0099: ldc.i4.6
    IL_009A: shl
    IL_009B: or
    IL_009C: stloc.0
    IL_009D: ldloc.0
    IL_009E: ldarga.s src
    IL_00A0: ldc.i4.7
    IL_00A1: call Z0.bit& System.Span`1<Z0.bit>::get_Item(System.Int32)
    IL_00A6: ldobj Z0.bit
    IL_00AB: call System.UInt32 Z0.bit::op_Explicit(Z0.bit)
    IL_00B0: ldc.i4.7
    IL_00B1: shl
    IL_00B2: or
    IL_00B3: stloc.0
    IL_00B4: ldloc.0
    IL_00B5: conv.u8
    IL_00B6: ret

}
ulong pack(N16 n, Span<bit> src)
{
    IL_0000: call Z0.N8 zfunc::get_n8()
    IL_0005: ldarg.1
    IL_0006: call System.UInt64 Z0.Bits::pack(Z0.N8,System.Span`1<Z0.bit>)
    IL_000B: stloc.0
    IL_000C: ldloc.0
    IL_000D: call Z0.N8 zfunc::get_n8()
    IL_0012: ldarga.s src
    IL_0014: ldc.i4.8
    IL_0015: call System.Span`1<Z0.bit> System.Span`1<Z0.bit>::Slice(System.Int32)
    IL_001A: call System.UInt64 Z0.Bits::pack(Z0.N8,System.Span`1<Z0.bit>)
    IL_001F: ldc.i4.8
    IL_0020: shl
    IL_0021: or
    IL_0022: stloc.0
    IL_0023: ldloc.0
    IL_0024: ret

}
ulong pack(N32 n, Span<bit> src)
{
    IL_0000: call Z0.N16 zfunc::get_n16()
    IL_0005: ldarg.1
    IL_0006: call System.UInt64 Z0.Bits::pack(Z0.N16,System.Span`1<Z0.bit>)
    IL_000B: stloc.0
    IL_000C: ldloc.0
    IL_000D: call Z0.N16 zfunc::get_n16()
    IL_0012: ldarga.s src
    IL_0014: ldc.i4.s 16
    IL_0016: call System.Span`1<Z0.bit> System.Span`1<Z0.bit>::Slice(System.Int32)
    IL_001B: call System.UInt64 Z0.Bits::pack(Z0.N16,System.Span`1<Z0.bit>)
    IL_0020: ldc.i4.s 16
    IL_0022: shl
    IL_0023: or
    IL_0024: stloc.0
    IL_0025: ldloc.0
    IL_0026: ret

}
ulong pack(N64 n, Span<bit> src)
{
    IL_0000: call Z0.N32 zfunc::get_n32()
    IL_0005: ldarg.1
    IL_0006: call System.UInt64 Z0.Bits::pack(Z0.N32,System.Span`1<Z0.bit>)
    IL_000B: stloc.0
    IL_000C: ldloc.0
    IL_000D: call Z0.N32 zfunc::get_n32()
    IL_0012: ldarga.s src
    IL_0014: ldc.i4.s 32
    IL_0016: call System.Span`1<Z0.bit> System.Span`1<Z0.bit>::Slice(System.Int32)
    IL_001B: call System.UInt64 Z0.Bits::pack(Z0.N32,System.Span`1<Z0.bit>)
    IL_0020: ldc.i4.s 32
    IL_0022: shl
    IL_0023: or
    IL_0024: stloc.0
    IL_0025: ldloc.0
    IL_0026: ret

}
void pack(Span<bit> src, out ulong lo, out ulong hi)
{
    IL_0000: ldarg.1
    IL_0001: call Z0.N64 zfunc::get_n64()
    IL_0006: ldarg.0
    IL_0007: call System.UInt64 Z0.Bits::pack(Z0.N64,System.Span`1<Z0.bit>)
    IL_000C: stind.i8
    IL_000D: ldarg.2
    IL_000E: call Z0.N64 zfunc::get_n64()
    IL_0013: ldarga.s src
    IL_0015: ldc.i4.s 64
    IL_0017: call System.Span`1<Z0.bit> System.Span`1<Z0.bit>::Slice(System.Int32)
    IL_001C: call System.UInt64 Z0.Bits::pack(Z0.N64,System.Span`1<Z0.bit>)
    IL_0021: stind.i8
    IL_0022: ret

}
Span<byte> pack(ReadOnlySpan<bit> src, Span<byte> dst)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Int32 System.ReadOnlySpan`1<Z0.bit>::get_Length()
    IL_0007: stloc.0
    IL_0008: ldc.i4.0
    IL_0009: stloc.1
    IL_000A: br.s IL_003C
    IL_000C: ldarga.s src
    IL_000E: ldloc.1
    IL_000F: call Z0.bit& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<Z0.bit>::get_Item(System.Int32)
    IL_0014: ldobj Z0.bit
    IL_0019: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_001E: brfalse.s IL_0038
    IL_0020: ldarga.s dst
    IL_0022: ldloc.1
    IL_0023: ldc.i4.3
    IL_0024: shr
    IL_0025: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_002A: dup
    IL_002B: ldind.u1
    IL_002C: ldc.i4.1
    IL_002D: ldloc.1
    IL_002E: ldc.i4.7
    IL_002F: and
    IL_0030: ldc.i4.s 31
    IL_0032: and
    IL_0033: shl
    IL_0034: conv.u1
    IL_0035: or
    IL_0036: conv.u1
    IL_0037: stind.i1
    IL_0038: ldloc.1
    IL_0039: ldc.i4.1
    IL_003A: add
    IL_003B: stloc.1
    IL_003C: ldloc.1
    IL_003D: ldloc.0
    IL_003E: blt.s IL_000C
    IL_0040: ldarg.1
    IL_0041: ret

}
Span<byte> pack(ReadOnlySpan<byte> src, Span<byte> dst)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Int32 System.ReadOnlySpan`1<System.Byte>::get_Length()
    IL_0007: stloc.0
    IL_0008: ldc.i4.0
    IL_0009: stloc.1
    IL_000A: br.s IL_0034
    IL_000C: ldarga.s src
    IL_000E: ldloc.1
    IL_000F: call System.Byte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Byte>::get_Item(System.Int32)
    IL_0014: ldind.u1
    IL_0015: ldc.i4.1
    IL_0016: bne.un.s IL_0030
    IL_0018: ldarga.s dst
    IL_001A: ldloc.1
    IL_001B: ldc.i4.3
    IL_001C: shr
    IL_001D: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0022: dup
    IL_0023: ldind.u1
    IL_0024: ldc.i4.1
    IL_0025: ldloc.1
    IL_0026: ldc.i4.7
    IL_0027: and
    IL_0028: ldc.i4.s 31
    IL_002A: and
    IL_002B: shl
    IL_002C: conv.u1
    IL_002D: or
    IL_002E: conv.u1
    IL_002F: stind.i1
    IL_0030: ldloc.1
    IL_0031: ldc.i4.1
    IL_0032: add
    IL_0033: stloc.1
    IL_0034: ldloc.1
    IL_0035: ldloc.0
    IL_0036: blt.s IL_000C
    IL_0038: ldarg.1
    IL_0039: ret

}
Span<byte> pack(Boolean[] src)
{
    IL_0000: ldarg.0
    IL_0001: ldlen
    IL_0002: conv.i4
    IL_0003: stloc.0
    IL_0004: ldloc.0
    IL_0005: ldc.i4.3
    IL_0006: shr
    IL_0007: stloc.1
    IL_0008: ldloc.0
    IL_0009: ldc.i4.7
    IL_000A: and
    IL_000B: brfalse.s IL_0011
    IL_000D: ldloc.1
    IL_000E: ldc.i4.1
    IL_000F: add
    IL_0010: stloc.1
    IL_0011: ldloc.1
    IL_0012: newarr System.Byte
    IL_0017: call System.Span`1<System.Byte> System.Span`1<System.Byte>::op_Implicit(System.Byte[])
    IL_001C: stloc.2
    IL_001D: ldc.i4.0
    IL_001E: stloc.3
    IL_001F: br.s IL_0042
    IL_0021: ldarg.0
    IL_0022: ldloc.3
    IL_0023: ldelem.u1
    IL_0024: brfalse.s IL_003E
    IL_0026: ldloca.s V_2
    IL_0028: ldloc.3
    IL_0029: ldc.i4.3
    IL_002A: shr
    IL_002B: call System.Byte& System.Span`1<System.Byte>::get_Item(System.Int32)
    IL_0030: dup
    IL_0031: ldind.u1
    IL_0032: ldc.i4.1
    IL_0033: ldloc.3
    IL_0034: ldc.i4.7
    IL_0035: and
    IL_0036: ldc.i4.s 31
    IL_0038: and
    IL_0039: shl
    IL_003A: conv.u1
    IL_003B: or
    IL_003C: conv.u1
    IL_003D: stind.i1
    IL_003E: ldloc.3
    IL_003F: ldc.i4.1
    IL_0040: add
    IL_0041: stloc.3
    IL_0042: ldloc.3
    IL_0043: ldloc.0
    IL_0044: blt.s IL_0021
    IL_0046: ldloc.2
    IL_0047: ret

}
ref byte packseq(ReadOnlySpan<byte> src, out byte dst)
{
    IL_0000: ldarg.1
    IL_0001: ldc.i4.0
    IL_0002: stind.i1
    IL_0003: ldc.i4.8
    IL_0004: ldarga.s src
    IL_0006: call System.Int32 System.ReadOnlySpan`1<System.Byte>::get_Length()
    IL_000B: call System.Int32 System.Math::Min(System.Int32,System.Int32)
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
ref byte packseq(out byte dst, Byte[] src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: stind.i1
    IL_0003: ldc.i4.8
    IL_0004: ldarg.1
    IL_0005: ldlen
    IL_0006: conv.i4
    IL_0007: call System.Int32 System.Math::Min(System.Int32,System.Int32)
    IL_000C: stloc.0
    IL_000D: ldc.i4.0
    IL_000E: stloc.1
    IL_000F: br.s IL_0028
    IL_0011: ldarg.1
    IL_0012: ldloc.1
    IL_0013: ldelem.u1
    IL_0014: ldc.i4.1
    IL_0015: bne.un.s IL_0024
    IL_0017: ldarg.0
    IL_0018: ldarg.0
    IL_0019: ldind.u1
    IL_001A: ldc.i4.1
    IL_001B: ldloc.1
    IL_001C: ldc.i4.s 31
    IL_001E: and
    IL_001F: shl
    IL_0020: conv.u1
    IL_0021: or
    IL_0022: conv.u1
    IL_0023: stind.i1
    IL_0024: ldloc.1
    IL_0025: ldc.i4.1
    IL_0026: add
    IL_0027: stloc.1
    IL_0028: ldloc.1
    IL_0029: ldloc.0
    IL_002A: blt.s IL_0011
    IL_002C: ldarg.0
    IL_002D: ret

}
ref uint packseq(out uint dst, Byte[] src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: stind.i4
    IL_0003: ldc.i4.s 32
    IL_0005: ldarg.1
    IL_0006: ldlen
    IL_0007: conv.i4
    IL_0008: call System.Int32 System.Math::Min(System.Int32,System.Int32)
    IL_000D: stloc.0
    IL_000E: ldc.i4.0
    IL_000F: stloc.1
    IL_0010: br.s IL_0028
    IL_0012: ldarg.1
    IL_0013: ldloc.1
    IL_0014: ldelem.u1
    IL_0015: ldc.i4.1
    IL_0016: bne.un.s IL_0024
    IL_0018: ldarg.0
    IL_0019: ldarg.0
    IL_001A: ldind.u4
    IL_001B: ldc.i4.1
    IL_001C: ldloc.1
    IL_001D: ldc.i4.s 31
    IL_001F: and
    IL_0020: shl
    IL_0021: conv.u1
    IL_0022: or
    IL_0023: stind.i4
    IL_0024: ldloc.1
    IL_0025: ldc.i4.1
    IL_0026: add
    IL_0027: stloc.1
    IL_0028: ldloc.1
    IL_0029: ldloc.0
    IL_002A: blt.s IL_0012
    IL_002C: ldarg.0
    IL_002D: ret

}
ref ushort packseq(ReadOnlySpan<byte> src, out ushort dst)
{
    IL_0000: ldarg.1
    IL_0001: ldc.i4.0
    IL_0002: stind.i2
    IL_0003: ldc.i4.s 16
    IL_0005: ldarga.s src
    IL_0007: call System.Int32 System.ReadOnlySpan`1<System.Byte>::get_Length()
    IL_000C: call System.Int32 System.Math::Min(System.Int32,System.Int32)
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
    IL_000C: call System.Int32 System.Math::Min(System.Int32,System.Int32)
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
    IL_000D: call System.Int32 System.Math::Min(System.Int32,System.Int32)
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
uint posl(byte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Byte Z0.Bits::blsi(System.Byte)
    IL_0006: call System.UInt32 Z0.Bits::log2(System.Byte)
    IL_000B: ret

}
uint posl(ushort src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt16 Z0.Bits::blsi(System.UInt16)
    IL_0006: call System.UInt32 Z0.Bits::log2(System.UInt16)
    IL_000B: ret

}
uint posl(uint src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 Z0.Bits::blsi(System.UInt32)
    IL_0006: call System.UInt32 Z0.Bits::log2(System.UInt32)
    IL_000B: ret

}
uint posl(ulong src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt64 Z0.Bits::blsi(System.UInt64)
    IL_0006: call System.UInt32 Z0.Bits::log2(System.UInt64)
    IL_000B: ret

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
uint rev(uint src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt16 Z0.Bits::hi(System.UInt32)
    IL_0006: call System.UInt16 Z0.Bits::rev(System.UInt16)
    IL_000B: ldarg.0
    IL_000C: call System.UInt16 Z0.Bits::lo(System.UInt32)
    IL_0011: call System.UInt16 Z0.Bits::rev(System.UInt16)
    IL_0016: call System.UInt32 Z0.Bits::pack(System.UInt16,System.UInt16)
    IL_001B: ret

}
uint rev2(uint x)
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
byte rotl(byte src, byte offset)
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
ushort rotl(ushort src, ushort offset)
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
uint rotl(uint src, uint offset)
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
ulong rotl(ulong src, ulong offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: conv.i4
    IL_0003: ldc.i4.s 63
    IL_0005: and
    IL_0006: shl
    IL_0007: ldarg.0
    IL_0008: ldc.i4.s 64
    IL_000A: ldarg.1
    IL_000B: conv.i4
    IL_000C: sub
    IL_000D: ldc.i4.s 63
    IL_000F: and
    IL_0010: shr.un
    IL_0011: or
    IL_0012: ret

}
byte rotl(byte src, int offset)
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
ushort rotl(ushort src, int offset)
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
uint rotl(uint src, int offset)
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
ulong rotl(ulong src, int offset)
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
byte rotr(byte src, byte offset)
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
byte rotr(byte src, int offset)
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
ushort rotr(ushort src, ushort offset)
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
ushort rotr(ushort src, int offset)
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
uint rotr(uint src, uint offset)
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
uint rotr(uint src, int offset)
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
ulong rotr(ulong src, ulong offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: conv.i4
    IL_0003: ldc.i4.s 63
    IL_0005: and
    IL_0006: shr.un
    IL_0007: ldarg.0
    IL_0008: ldc.i4.s 64
    IL_000A: ldarg.1
    IL_000B: conv.i4
    IL_000C: sub
    IL_000D: ldc.i4.s 63
    IL_000F: and
    IL_0010: shl
    IL_0011: or
    IL_0012: ret

}
ulong rotr(ulong src, int offset)
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
ValueTuple<sbyte,sbyte> split(short src, N2 parts)
{
    IL_0000: ldarg.0
    IL_0001: call System.SByte Z0.Bits::lo(System.Int16)
    IL_0006: ldarg.0
    IL_0007: call System.SByte Z0.Bits::hi(System.Int16)
    IL_000C: newobj System.Void System.ValueTuple`2<System.SByte,System.SByte>::.ctor(System.SByte,System.SByte)
    IL_0011: ret

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
ValueTuple<short,short> split(int src, N2 parts)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int16 Z0.Bits::lo(System.Int32)
    IL_0006: ldarg.0
    IL_0007: call System.Int16 Z0.Bits::hi(System.Int32)
    IL_000C: newobj System.Void System.ValueTuple`2<System.Int16,System.Int16>::.ctor(System.Int16,System.Int16)
    IL_0011: ret

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
void split(long src, out int x0, out int x1)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Int32 Z0.Bits::lo(System.Int64)
    IL_0007: stind.i4
    IL_0008: ldarg.2
    IL_0009: ldarg.0
    IL_000A: call System.Int32 Z0.Bits::hi(System.Int64)
    IL_000F: stind.i4
    IL_0010: ret

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
bool test(sbyte src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.BitMask::test(System.SByte,System.Int32)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret

}
bool test(byte src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.BitMask::test(System.Byte,System.Int32)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret

}
bool test(short src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.BitMask::test(System.Int16,System.Int32)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret

}
BitVector128 clmul_ref(BitVector64 x, BitVector64 y)
{
    IL_0000: ldarg.0
    IL_0001: stloc.0
    IL_0002: ldarg.1
    IL_0003: stloc.1
    IL_0004: call Z0.BitVector128 Z0.BitVector128::get_Zero()
    IL_0009: stloc.2
    IL_000A: call Z0.BitVector128 Z0.BitVector128::get_Zero()
    IL_000F: stloc.3
    IL_0010: ldc.i4.0
    IL_0011: stloc.s V_4
    IL_0013: br.s IL_008E
    IL_0015: ldloca.s V_3
    IL_0017: ldloc.s V_4
    IL_0019: ldloca.s V_0
    IL_001B: ldc.i4.0
    IL_001C: call Z0.bit Z0.BitVector64::get_Item(System.Int32)
    IL_0021: ldloca.s V_1
    IL_0023: ldloc.s V_4
    IL_0025: call Z0.bit Z0.BitVector64::get_Item(System.Int32)
    IL_002A: call Z0.bit Z0.bit::op_BitwiseAnd(Z0.bit,Z0.bit)
    IL_002F: call System.Void Z0.BitVector128::set_Item(System.Int32,Z0.bit)
    IL_0034: ldc.i4.1
    IL_0035: stloc.s V_5
    IL_0037: br.s IL_0070
    IL_0039: ldloca.s V_3
    IL_003B: ldloc.s V_4
    IL_003D: ldloca.s V_3
    IL_003F: ldloc.s V_4
    IL_0041: call Z0.bit Z0.BitVector128::get_Item(System.Int32)
    IL_0046: ldloca.s V_0
    IL_0048: ldloc.s V_5
    IL_004A: call Z0.bit Z0.BitVector64::get_Item(System.Int32)
    IL_004F: ldloca.s V_1
    IL_0051: ldloc.s V_4
    IL_0053: ldloc.s V_5
    IL_0055: sub
    IL_0056: call Z0.bit Z0.BitVector64::get_Item(System.Int32)
    IL_005B: call Z0.bit Z0.bit::op_BitwiseAnd(Z0.bit,Z0.bit)
    IL_0060: call Z0.bit Z0.bit::op_ExclusiveOr(Z0.bit,Z0.bit)
    IL_0065: call System.Void Z0.BitVector128::set_Item(System.Int32,Z0.bit)
    IL_006A: ldloc.s V_5
    IL_006C: ldc.i4.1
    IL_006D: add
    IL_006E: stloc.s V_5
    IL_0070: ldloc.s V_5
    IL_0072: ldloc.s V_4
    IL_0074: ble.s IL_0039
    IL_0076: ldloca.s V_2
    IL_0078: ldloc.s V_4
    IL_007A: ldloca.s V_3
    IL_007C: ldloc.s V_4
    IL_007E: call Z0.bit Z0.BitVector128::get_Item(System.Int32)
    IL_0083: call System.Void Z0.BitVector128::set_Item(System.Int32,Z0.bit)
    IL_0088: ldloc.s V_4
    IL_008A: ldc.i4.1
    IL_008B: add
    IL_008C: stloc.s V_4
    IL_008E: ldloc.s V_4
    IL_0090: ldc.i4.s 64
    IL_0092: blt.s IL_0015
    IL_0094: ldc.i4.s 64
    IL_0096: stloc.s V_6
    IL_0098: br.s IL_0107
    IL_009A: ldloca.s V_3
    IL_009C: ldloc.s V_6
    IL_009E: ldc.i4.0
    IL_009F: call Z0.bit Z0.bit::op_Implicit(System.Boolean)
    IL_00A4: call System.Void Z0.BitVector128::set_Item(System.Int32,Z0.bit)
    IL_00A9: ldloc.s V_6
    IL_00AB: ldc.i4.s 63
    IL_00AD: sub
    IL_00AE: stloc.s V_7
    IL_00B0: br.s IL_00E9
    IL_00B2: ldloca.s V_3
    IL_00B4: ldloc.s V_6
    IL_00B6: ldloca.s V_3
    IL_00B8: ldloc.s V_6
    IL_00BA: call Z0.bit Z0.BitVector128::get_Item(System.Int32)
    IL_00BF: ldloca.s V_0
    IL_00C1: ldloc.s V_7
    IL_00C3: call Z0.bit Z0.BitVector64::get_Item(System.Int32)
    IL_00C8: ldloca.s V_1
    IL_00CA: ldloc.s V_6
    IL_00CC: ldloc.s V_7
    IL_00CE: sub
    IL_00CF: call Z0.bit Z0.BitVector64::get_Item(System.Int32)
    IL_00D4: call Z0.bit Z0.bit::op_BitwiseAnd(Z0.bit,Z0.bit)
    IL_00D9: call Z0.bit Z0.bit::op_ExclusiveOr(Z0.bit,Z0.bit)
    IL_00DE: call System.Void Z0.BitVector128::set_Item(System.Int32,Z0.bit)
    IL_00E3: ldloc.s V_7
    IL_00E5: ldc.i4.1
    IL_00E6: add
    IL_00E7: stloc.s V_7
    IL_00E9: ldloc.s V_7
    IL_00EB: ldc.i4.s 64
    IL_00ED: blt.s IL_00B2
    IL_00EF: ldloca.s V_2
    IL_00F1: ldloc.s V_6
    IL_00F3: ldloca.s V_3
    IL_00F5: ldloc.s V_6
    IL_00F7: call Z0.bit Z0.BitVector128::get_Item(System.Int32)
    IL_00FC: call System.Void Z0.BitVector128::set_Item(System.Int32,Z0.bit)
    IL_0101: ldloc.s V_6
    IL_0103: ldc.i4.1
    IL_0104: add
    IL_0105: stloc.s V_6
    IL_0107: ldloc.s V_6
    IL_0109: ldc.i4 128
    IL_010E: blt.s IL_009A
    IL_0110: ldloca.s V_2
    IL_0112: ldc.i4.s 127
    IL_0114: ldc.i4.0
    IL_0115: call Z0.bit Z0.bit::op_Implicit(System.Boolean)
    IL_011A: call System.Void Z0.BitVector128::set_Item(System.Int32,Z0.bit)
    IL_011F: ldloc.2
    IL_0120: ret

}
Vec128<sbyte> vpackss(in Vec128<short> lhs, in Vec128<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int16>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::PackSignedSaturate(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_001B: call Z0.Vec128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0020: ret

}
Vec128<byte> vpackus(in Vec128<short> lhs, in Vec128<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int16>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::PackUnsignedSaturate(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_001B: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0020: ret

}
Vec128<short> vpackss(in Vec128<int> lhs, in Vec128<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int32>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::PackSignedSaturate(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_001B: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0020: ret

}
Vec256<sbyte> vpackss(in Vec256<short> lhs, in Vec256<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Int16>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::PackSignedSaturate(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_001B: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0020: ret

}
Vec256<short> vpackss(in Vec256<int> lhs, in Vec256<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Int32>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::PackSignedSaturate(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_001B: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0020: ret

}
Vec256<ushort> vpackus(in Vec256<int> lhs, in Vec256<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Int32>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::PackUnsignedSaturate(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_001B: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0020: ret

}
UInt128 and(in UInt128 lhs, in UInt128 rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.UInt128
    IL_0006: call Z0.Vec128`1<System.UInt64> Z0.UInt128X::ToVector128(Z0.UInt128)
    IL_000B: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_0010: ldarg.1
    IL_0011: ldobj Z0.UInt128
    IL_0016: call Z0.Vec128`1<System.UInt64> Z0.UInt128X::ToVector128(Z0.UInt128)
    IL_001B: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_0020: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::And(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0025: stloc.0
    IL_0026: ldloca.s V_0
    IL_0028: call Z0.UInt128 Z0.UInt128X::ToUInt128(System.Runtime.Intrinsics.Vector128`1<System.UInt64>&)
    IL_002D: ret

}
ref UInt128 and(in UInt128 lhs, in UInt128 rhs, out UInt128 dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.UInt128
    IL_0007: call Z0.Vec128`1<System.UInt64> Z0.UInt128X::ToVector128(Z0.UInt128)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_0011: ldarg.1
    IL_0012: ldobj Z0.UInt128
    IL_0017: call Z0.Vec128`1<System.UInt64> Z0.UInt128X::ToVector128(Z0.UInt128)
    IL_001C: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_0021: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::And(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0026: stloc.0
    IL_0027: ldloca.s V_0
    IL_0029: call Z0.UInt128 Z0.UInt128X::ToUInt128(System.Runtime.Intrinsics.Vector128`1<System.UInt64>&)
    IL_002E: stobj Z0.UInt128
    IL_0033: ldarg.2
    IL_0034: ret

}
UInt128 or(in UInt128 lhs, in UInt128 rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.UInt128
    IL_0006: call Z0.Vec128`1<System.UInt64> Z0.UInt128X::ToVec128(Z0.UInt128)
    IL_000B: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_0010: ldarg.1
    IL_0011: ldobj Z0.UInt128
    IL_0016: call Z0.Vec128`1<System.UInt64> Z0.UInt128X::ToVec128(Z0.UInt128)
    IL_001B: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_0020: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::Or(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0025: stloc.0
    IL_0026: ldloca.s V_0
    IL_0028: call Z0.UInt128 Z0.UInt128X::ToUInt128(System.Runtime.Intrinsics.Vector128`1<System.UInt64>&)
    IL_002D: ret

}
ref UInt128 or(in UInt128 lhs, in UInt128 rhs, out UInt128 dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.UInt128
    IL_0007: call Z0.Vec128`1<System.UInt64> Z0.UInt128X::ToVec128(Z0.UInt128)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_0011: ldarg.1
    IL_0012: ldobj Z0.UInt128
    IL_0017: call Z0.Vec128`1<System.UInt64> Z0.UInt128X::ToVec128(Z0.UInt128)
    IL_001C: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_0021: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::Or(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0026: stloc.0
    IL_0027: ldloca.s V_0
    IL_0029: call Z0.UInt128 Z0.UInt128X::ToUInt128(System.Runtime.Intrinsics.Vector128`1<System.UInt64>&)
    IL_002E: stobj Z0.UInt128
    IL_0033: ldarg.2
    IL_0034: ret

}
UInt128 xor(in UInt128 lhs, in UInt128 rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.UInt128
    IL_0006: call Z0.Vec128`1<System.UInt64> Z0.UInt128X::ToVec128(Z0.UInt128)
    IL_000B: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_0010: ldarg.1
    IL_0011: ldobj Z0.UInt128
    IL_0016: call Z0.Vec128`1<System.UInt64> Z0.UInt128X::ToVec128(Z0.UInt128)
    IL_001B: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_0020: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0025: stloc.0
    IL_0026: ldloca.s V_0
    IL_0028: call Z0.UInt128 Z0.UInt128X::ToUInt128(System.Runtime.Intrinsics.Vector128`1<System.UInt64>&)
    IL_002D: ret

}
ref UInt128 xor(in UInt128 lhs, in UInt128 rhs, out UInt128 dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.UInt128
    IL_0007: call Z0.Vec128`1<System.UInt64> Z0.UInt128X::ToVec128(Z0.UInt128)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_0011: ldarg.1
    IL_0012: ldobj Z0.UInt128
    IL_0017: call Z0.Vec128`1<System.UInt64> Z0.UInt128X::ToVec128(Z0.UInt128)
    IL_001C: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_0021: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0026: stloc.0
    IL_0027: ldloca.s V_0
    IL_0029: call Z0.UInt128 Z0.UInt128X::ToUInt128(System.Runtime.Intrinsics.Vector128`1<System.UInt64>&)
    IL_002E: stobj Z0.UInt128
    IL_0033: ldarg.2
    IL_0034: ret

}
UInt128 bslli(UInt128 src, byte bytes)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.UInt128::op_Implicit(Z0.UInt128&)
    IL_0007: ldarg.1
    IL_0008: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::ShiftLeftLogical128BitLane(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Byte)
    IL_000D: stloc.0
    IL_000E: ldloca.s V_0
    IL_0010: call Z0.UInt128 Z0.UInt128X::ToUInt128(System.Runtime.Intrinsics.Vector128`1<System.UInt64>&)
    IL_0015: ret

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
ref sbyte bitmap(in sbyte src, byte srcOffset, byte len, byte dstOffset, ref sbyte dst)
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
    IL_0012: ldind.i1
    IL_0013: ldarg.1
    IL_0014: ldarg.2
    IL_0015: call System.SByte Z0.Bits::extract(System.SByte,System.Byte,System.Byte)
    IL_001A: or
    IL_001B: conv.i1
    IL_001C: stind.i1
    IL_001D: ldarg.s dst
    IL_001F: ret

}
ref byte bitmap(in byte src, byte srcOffset, byte len, byte dstOffset, ref byte dst)
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
    IL_0012: ldind.u1
    IL_0013: ldarg.1
    IL_0014: ldarg.2
    IL_0015: call System.Byte Z0.Bits::extract(System.Byte,System.Byte,System.Byte)
    IL_001A: or
    IL_001B: conv.u1
    IL_001C: stind.i1
    IL_001D: ldarg.s dst
    IL_001F: ret

}
ref short bitmap(in byte src, byte srcOffset, byte len, byte dstOffset, ref short dst)
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
    IL_0012: ldind.u1
    IL_0013: ldarg.1
    IL_0014: ldarg.2
    IL_0015: call System.Byte Z0.Bits::extract(System.Byte,System.Byte,System.Byte)
    IL_001A: or
    IL_001B: conv.i2
    IL_001C: stind.i2
    IL_001D: ldarg.s dst
    IL_001F: ret

}
ref ushort bitmap(in byte src, byte srcOffset, byte len, byte dstOffset, ref ushort dst)
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
    IL_0012: ldind.u1
    IL_0013: ldarg.1
    IL_0014: ldarg.2
    IL_0015: call System.Byte Z0.Bits::extract(System.Byte,System.Byte,System.Byte)
    IL_001A: or
    IL_001B: conv.u2
    IL_001C: stind.i2
    IL_001D: ldarg.s dst
    IL_001F: ret

}
ref int bitmap(in byte src, byte srcOffset, byte len, byte dstOffset, ref int dst)
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
    IL_0011: ldind.u1
    IL_0012: ldarg.1
    IL_0013: ldarg.2
    IL_0014: call System.Byte Z0.Bits::extract(System.Byte,System.Byte,System.Byte)
    IL_0019: or
    IL_001A: stind.i4
    IL_001B: ldarg.s dst
    IL_001D: ret

}
ref uint bitmap(in byte src, byte srcOffset, byte len, byte dstOffset, ref uint dst)
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
    IL_0011: ldind.u1
    IL_0012: ldarg.1
    IL_0013: ldarg.2
    IL_0014: call System.Byte Z0.Bits::extract(System.Byte,System.Byte,System.Byte)
    IL_0019: or
    IL_001A: stind.i4
    IL_001B: ldarg.s dst
    IL_001D: ret

}
ref long bitmap(in byte src, byte srcOffset, byte len, byte dstOffset, ref long dst)
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
    IL_0011: ldind.u1
    IL_0012: ldarg.1
    IL_0013: ldarg.2
    IL_0014: call System.Byte Z0.Bits::extract(System.Byte,System.Byte,System.Byte)
    IL_0019: conv.u8
    IL_001A: or
    IL_001B: stind.i8
    IL_001C: ldarg.s dst
    IL_001E: ret

}
ref ulong bitmap(in byte src, byte srcOffset, byte len, byte dstOffset, ref ulong dst)
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
    IL_0011: ldind.u1
    IL_0012: ldarg.1
    IL_0013: ldarg.2
    IL_0014: call System.Byte Z0.Bits::extract(System.Byte,System.Byte,System.Byte)
    IL_0019: conv.u8
    IL_001A: or
    IL_001B: stind.i8
    IL_001C: ldarg.s dst
    IL_001E: ret

}
ref sbyte bitmap(in short src, byte srcOffset, byte len, byte dstOffset, ref sbyte dst)
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
    IL_0012: ldind.i2
    IL_0013: ldarg.1
    IL_0014: ldarg.2
    IL_0015: call System.Int16 Z0.Bits::extract(System.Int16,System.Byte,System.Byte)
    IL_001A: conv.i1
    IL_001B: or
    IL_001C: conv.i1
    IL_001D: stind.i1
    IL_001E: ldarg.s dst
    IL_0020: ret

}
ref byte bitmap(in short src, byte srcOffset, byte len, byte dstOffset, ref byte dst)
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
    IL_0012: ldind.i2
    IL_0013: ldarg.1
    IL_0014: ldarg.2
    IL_0015: call System.Int16 Z0.Bits::extract(System.Int16,System.Byte,System.Byte)
    IL_001A: conv.u1
    IL_001B: or
    IL_001C: conv.u1
    IL_001D: stind.i1
    IL_001E: ldarg.s dst
    IL_0020: ret

}
ref short bitmap(in short src, byte srcOffset, byte len, byte dstOffset, ref short dst)
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
    IL_0012: ldind.i2
    IL_0013: ldarg.1
    IL_0014: ldarg.2
    IL_0015: call System.Int16 Z0.Bits::extract(System.Int16,System.Byte,System.Byte)
    IL_001A: or
    IL_001B: conv.i2
    IL_001C: stind.i2
    IL_001D: ldarg.s dst
    IL_001F: ret

}
ref ushort bitmap(in short src, byte srcOffset, byte len, byte dstOffset, ref ushort dst)
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
    IL_0012: ldind.i2
    IL_0013: ldarg.1
    IL_0014: ldarg.2
    IL_0015: call System.Int16 Z0.Bits::extract(System.Int16,System.Byte,System.Byte)
    IL_001A: conv.u2
    IL_001B: or
    IL_001C: conv.u2
    IL_001D: stind.i2
    IL_001E: ldarg.s dst
    IL_0020: ret

}
ref ushort bitmap(in ushort src, byte srcOffset, byte len, byte dstOffset, ref ushort dst)
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
    IL_0012: ldind.u2
    IL_0013: ldarg.1
    IL_0014: ldarg.2
    IL_0015: call System.UInt16 Z0.Bits::extract(System.UInt16,System.Byte,System.Byte)
    IL_001A: or
    IL_001B: conv.u2
    IL_001C: stind.i2
    IL_001D: ldarg.s dst
    IL_001F: ret

}
ref uint bitmap(in ushort src, byte srcOffset, byte len, byte dstOffset, ref uint dst)
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
    IL_0011: ldind.u2
    IL_0012: ldarg.1
    IL_0013: ldarg.2
    IL_0014: call System.UInt16 Z0.Bits::extract(System.UInt16,System.Byte,System.Byte)
    IL_0019: or
    IL_001A: stind.i4
    IL_001B: ldarg.s dst
    IL_001D: ret

}
ref ulong bitmap(in ushort src, byte srcOffset, byte len, byte dstOffset, ref ulong dst)
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
    IL_0011: ldind.u2
    IL_0012: ldarg.1
    IL_0013: ldarg.2
    IL_0014: call System.UInt16 Z0.Bits::extract(System.UInt16,System.Byte,System.Byte)
    IL_0019: conv.u8
    IL_001A: or
    IL_001B: stind.i8
    IL_001C: ldarg.s dst
    IL_001E: ret

}
ref int bitmap(in int src, byte srcOffset, byte len, byte dstOffset, ref int dst)
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
    IL_0011: ldind.i4
    IL_0012: ldarg.1
    IL_0013: ldarg.2
    IL_0014: call System.Int32 Z0.Bits::extract(System.Int32,System.Byte,System.Byte)
    IL_0019: or
    IL_001A: stind.i4
    IL_001B: ldarg.s dst
    IL_001D: ret

}
ref long bitmap(in int src, byte srcOffset, byte len, byte dstOffset, ref long dst)
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
    IL_0011: ldind.i4
    IL_0012: ldarg.1
    IL_0013: ldarg.2
    IL_0014: call System.Int32 Z0.Bits::extract(System.Int32,System.Byte,System.Byte)
    IL_0019: conv.i8
    IL_001A: or
    IL_001B: stind.i8
    IL_001C: ldarg.s dst
    IL_001E: ret

}
ref ulong bitmap(in int src, byte srcOffset, byte len, byte dstOffset, ref ulong dst)
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
    IL_0011: ldind.i4
    IL_0012: ldarg.1
    IL_0013: ldarg.2
    IL_0014: call System.Int32 Z0.Bits::extract(System.Int32,System.Byte,System.Byte)
    IL_0019: conv.u8
    IL_001A: or
    IL_001B: stind.i8
    IL_001C: ldarg.s dst
    IL_001E: ret

}
ref uint bitmap(in uint src, byte srcOffset, byte len, byte dstOffset, ref uint dst)
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
    IL_0011: ldind.u4
    IL_0012: ldarg.1
    IL_0013: ldarg.2
    IL_0014: call System.UInt32 Z0.Bits::extract(System.UInt32,System.Byte,System.Byte)
    IL_0019: or
    IL_001A: stind.i4
    IL_001B: ldarg.s dst
    IL_001D: ret

}
ref ulong bitmap(in uint src, byte srcOffset, byte len, byte dstOffset, ref ulong dst)
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
    IL_0011: ldind.u4
    IL_0012: ldarg.1
    IL_0013: ldarg.2
    IL_0014: call System.UInt32 Z0.Bits::extract(System.UInt32,System.Byte,System.Byte)
    IL_0019: conv.u8
    IL_001A: or
    IL_001B: stind.i8
    IL_001C: ldarg.s dst
    IL_001E: ret

}
ref long bitmap(in long src, byte srcOffset, byte len, byte dstOffset, ref long dst)
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
    IL_0011: ldind.i8
    IL_0012: ldarg.1
    IL_0013: ldarg.2
    IL_0014: call System.Int64 Z0.Bits::extract(System.Int64,System.Byte,System.Byte)
    IL_0019: or
    IL_001A: stind.i8
    IL_001B: ldarg.s dst
    IL_001D: ret

}
ref sbyte bitmap(in ulong src, byte srcOffset, byte len, byte dstOffset, ref sbyte dst)
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
    IL_0012: ldind.i8
    IL_0013: ldarg.1
    IL_0014: ldarg.2
    IL_0015: call System.UInt64 Z0.Bits::extract(System.UInt64,System.Byte,System.Byte)
    IL_001A: conv.i1
    IL_001B: or
    IL_001C: conv.i1
    IL_001D: stind.i1
    IL_001E: ldarg.s dst
    IL_0020: ret

}
ref byte bitmap(in ulong src, byte srcOffset, byte len, byte dstOffset, ref byte dst)
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
    IL_0012: ldind.i8
    IL_0013: ldarg.1
    IL_0014: ldarg.2
    IL_0015: call System.UInt64 Z0.Bits::extract(System.UInt64,System.Byte,System.Byte)
    IL_001A: conv.u1
    IL_001B: or
    IL_001C: conv.u1
    IL_001D: stind.i1
    IL_001E: ldarg.s dst
    IL_0020: ret

}
ref short bitmap(in ulong src, byte srcOffset, byte len, byte dstOffset, ref short dst)
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
    IL_0012: ldind.i8
    IL_0013: ldarg.1
    IL_0014: ldarg.2
    IL_0015: call System.UInt64 Z0.Bits::extract(System.UInt64,System.Byte,System.Byte)
    IL_001A: conv.i2
    IL_001B: or
    IL_001C: conv.i2
    IL_001D: stind.i2
    IL_001E: ldarg.s dst
    IL_0020: ret

}
ref ushort bitmap(in ulong src, byte srcOffset, byte len, byte dstOffset, ref ushort dst)
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
    IL_0012: ldind.i8
    IL_0013: ldarg.1
    IL_0014: ldarg.2
    IL_0015: call System.UInt64 Z0.Bits::extract(System.UInt64,System.Byte,System.Byte)
    IL_001A: conv.u2
    IL_001B: or
    IL_001C: conv.u2
    IL_001D: stind.i2
    IL_001E: ldarg.s dst
    IL_0020: ret

}
ref int bitmap(in ulong src, byte srcOffset, byte len, byte dstOffset, ref int dst)
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
    IL_0011: ldind.i8
    IL_0012: ldarg.1
    IL_0013: ldarg.2
    IL_0014: call System.UInt64 Z0.Bits::extract(System.UInt64,System.Byte,System.Byte)
    IL_0019: conv.i4
    IL_001A: or
    IL_001B: stind.i4
    IL_001C: ldarg.s dst
    IL_001E: ret

}
ref uint bitmap(in ulong src, byte srcOffset, byte len, byte dstOffset, ref uint dst)
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
    IL_0011: ldind.i8
    IL_0012: ldarg.1
    IL_0013: ldarg.2
    IL_0014: call System.UInt64 Z0.Bits::extract(System.UInt64,System.Byte,System.Byte)
    IL_0019: conv.u4
    IL_001A: or
    IL_001B: stind.i4
    IL_001C: ldarg.s dst
    IL_001E: ret

}
ref long bitmap(in ulong src, byte srcOffset, byte len, byte dstOffset, ref long dst)
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
    IL_0011: ldind.i8
    IL_0012: ldarg.1
    IL_0013: ldarg.2
    IL_0014: call System.UInt64 Z0.Bits::extract(System.UInt64,System.Byte,System.Byte)
    IL_0019: or
    IL_001A: stind.i8
    IL_001B: ldarg.s dst
    IL_001D: ret

}
ref ulong bitmap(in ulong src, byte srcOffset, byte len, byte dstOffset, ref ulong dst)
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
    IL_0011: ldind.i8
    IL_0012: ldarg.1
    IL_0013: ldarg.2
    IL_0014: call System.UInt64 Z0.Bits::extract(System.UInt64,System.Byte,System.Byte)
    IL_0019: or
    IL_001A: stind.i8
    IL_001B: ldarg.s dst
    IL_001D: ret

}
ref float bitmap(in float src, byte srcOffset, byte len, byte dstOffset, ref float dst)
{
    IL_0000: ldarg.s dst
    IL_0002: ldarg.0
    IL_0003: ldind.r4
    IL_0004: call System.Int32 Z0.MathX::ToBits(System.Single)
    IL_0009: ldarg.1
    IL_000A: ldarg.2
    IL_000B: call System.Int32 Z0.Bits::extract(System.Int32,System.Byte,System.Byte)
    IL_0010: ldarg.3
    IL_0011: ldc.i4.s 31
    IL_0013: and
    IL_0014: shl
    IL_0015: conv.r4
    IL_0016: call System.Single& Z0.math::or(System.Single&,System.Single)
    IL_001B: pop
    IL_001C: ldarg.s dst
    IL_001E: ret

}
ref double bitmap(in double src, byte srcOffset, byte len, byte dstOffset, ref double dst)
{
    IL_0000: ldarg.s dst
    IL_0002: ldarg.0
    IL_0003: ldind.r8
    IL_0004: call System.Int64 Z0.MathX::ToBits(System.Double)
    IL_0009: ldarg.1
    IL_000A: ldarg.2
    IL_000B: call System.Int64 Z0.Bits::extract(System.Int64,System.Byte,System.Byte)
    IL_0010: ldarg.3
    IL_0011: ldc.i4.s 63
    IL_0013: and
    IL_0014: shl
    IL_0015: conv.r8
    IL_0016: call System.Double& Z0.math::or(System.Double&,System.Double)
    IL_001B: pop
    IL_001C: ldarg.s dst
    IL_001E: ret

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
byte bzhi(byte src, uint index)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi2::ZeroHighBits(System.UInt32,System.UInt32)
    IL_0007: conv.u1
    IL_0008: ret

}
ushort bzhi(ushort src, uint index)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi2::ZeroHighBits(System.UInt32,System.UInt32)
    IL_0007: conv.u2
    IL_0008: ret

}
uint bzhi(uint src, uint index)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi2::ZeroHighBits(System.UInt32,System.UInt32)
    IL_0007: ret

}
ulong bzhi(ulong src, uint index)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: conv.u8
    IL_0003: call System.UInt64 System.Runtime.Intrinsics.X86.Bmi2/X64::ZeroHighBits(System.UInt64,System.UInt64)
    IL_0008: ret

}
ref byte bzhi(ref byte src, uint index)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u1
    IL_0003: ldarg.1
    IL_0004: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi2::ZeroHighBits(System.UInt32,System.UInt32)
    IL_0009: conv.u1
    IL_000A: stind.i1
    IL_000B: ldarg.0
    IL_000C: ret

}
ref ushort bzhi(ref ushort src, uint index)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u2
    IL_0003: ldarg.1
    IL_0004: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi2::ZeroHighBits(System.UInt32,System.UInt32)
    IL_0009: conv.u2
    IL_000A: stind.i2
    IL_000B: ldarg.0
    IL_000C: ret

}
ref uint bzhi(ref uint src, uint index)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u4
    IL_0003: ldarg.1
    IL_0004: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi2::ZeroHighBits(System.UInt32,System.UInt32)
    IL_0009: stind.i4
    IL_000A: ldarg.0
    IL_000B: ret

}
ref ulong bzhi(ref ulong src, uint index)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldarg.1
    IL_0004: conv.u8
    IL_0005: call System.UInt64 System.Runtime.Intrinsics.X86.Bmi2/X64::ZeroHighBits(System.UInt64,System.UInt64)
    IL_000A: stind.i8
    IL_000B: ldarg.0
    IL_000C: ret

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
byte extract(byte src, byte start, byte length)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi1::BitFieldExtract(System.UInt32,System.Byte,System.Byte)
    IL_0008: conv.u1
    IL_0009: ret

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
ushort extract(ushort src, byte start, byte length)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi1::BitFieldExtract(System.UInt32,System.Byte,System.Byte)
    IL_0008: conv.u2
    IL_0009: ret

}
uint extract(uint src, byte start, byte length)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi1::BitFieldExtract(System.UInt32,System.Byte,System.Byte)
    IL_0008: ret

}
int extract(int src, byte start, byte length)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.UInt32 System.Runtime.Intrinsics.X86.Bmi1::BitFieldExtract(System.UInt32,System.Byte,System.Byte)
    IL_0008: ret

}
long extract(long src, byte start, byte length)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.UInt64 System.Runtime.Intrinsics.X86.Bmi1/X64::BitFieldExtract(System.UInt64,System.Byte,System.Byte)
    IL_0008: ret

}
ulong extract(ulong src, byte start, byte length)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.UInt64 System.Runtime.Intrinsics.X86.Bmi1/X64::BitFieldExtract(System.UInt64,System.Byte,System.Byte)
    IL_0008: ret

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
ulong extract(double src, byte start, byte length)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int64 Z0.MathX::ToBits(System.Double)
    IL_0006: ldarg.1
    IL_0007: ldarg.2
    IL_0008: call System.UInt64 System.Runtime.Intrinsics.X86.Bmi1/X64::BitFieldExtract(System.UInt64,System.Byte,System.Byte)
    IL_000D: ret

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
byte gather(byte src, BitMask8:byte mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Byte Z0.Bits::gather(System.Byte,System.Byte)
    IL_0007: ret

}
ushort gather(ushort src, BitMask16:ushort mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt16 Z0.Bits::gather(System.UInt16,System.UInt16)
    IL_0007: ret

}
uint gather(uint src, BitMask32:uint mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::gather(System.UInt32,System.UInt32)
    IL_0007: ret

}
ulong gather(ulong src, BitMask64:ulong mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.Bits::gather(System.UInt64,System.UInt64)
    IL_0007: ret

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
ref ushort puthi(byte src, ref ushort dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.1
    IL_0002: ldc.i4.8
    IL_0003: call System.UInt16& Z0.Bits::bzhi(System.UInt16&,System.UInt32)
    IL_0008: ldind.u2
    IL_0009: ldarg.0
    IL_000A: ldc.i4.8
    IL_000B: shl
    IL_000C: or
    IL_000D: conv.u2
    IL_000E: stind.i2
    IL_000F: ldarg.1
    IL_0010: ret

}
ref uint puthi(ushort src, ref uint dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 16
    IL_0004: call System.UInt32& Z0.Bits::bzhi(System.UInt32&,System.UInt32)
    IL_0009: ldind.u4
    IL_000A: ldarg.0
    IL_000B: ldc.i4.s 16
    IL_000D: shl
    IL_000E: or
    IL_000F: stind.i4
    IL_0010: ldarg.1
    IL_0011: ret

}
ref ulong puthi(uint src, ref ulong dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 32
    IL_0004: call System.UInt64& Z0.Bits::bzhi(System.UInt64&,System.UInt32)
    IL_0009: ldind.i8
    IL_000A: ldarg.0
    IL_000B: conv.u8
    IL_000C: ldc.i4.s 32
    IL_000E: shl
    IL_000F: or
    IL_0010: stind.i8
    IL_0011: ldarg.1
    IL_0012: ret

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
