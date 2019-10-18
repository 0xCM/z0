// 2019-10-18 00:25:26:048
uint pow(uint b, uint exp)
{
    IL_0000: ldarg.1
    IL_0001: brtrue.s IL_0005
    IL_0003: ldc.i4.1
    IL_0004: ret
    IL_0005: ldc.i4.1
    IL_0006: stloc.0
    IL_0007: ldarg.1
    IL_0008: ldc.i4.1
    IL_0009: and
    IL_000A: brfalse.s IL_0010
    IL_000C: ldloc.0
    IL_000D: ldarg.0
    IL_000E: mul
    IL_000F: stloc.0
    IL_0010: ldarg.1
    IL_0011: ldc.i4.1
    IL_0012: shr.un
    IL_0013: starg.s exp
    IL_0015: ldarg.1
    IL_0016: brfalse.s IL_001F
    IL_0018: ldarg.0
    IL_0019: ldarg.0
    IL_001A: mul
    IL_001B: starg.s b
    IL_001D: br.s IL_0007
    IL_001F: ldloc.0
    IL_0020: ret

}
long pow(long b, uint exp)
{
    IL_0000: ldarg.1
    IL_0001: brtrue.s IL_0006
    IL_0003: ldc.i4.1
    IL_0004: conv.i8
    IL_0005: ret
    IL_0006: ldc.i4.1
    IL_0007: conv.i8
    IL_0008: stloc.0
    IL_0009: ldarg.1
    IL_000A: ldc.i4.1
    IL_000B: and
    IL_000C: brfalse.s IL_0012
    IL_000E: ldloc.0
    IL_000F: ldarg.0
    IL_0010: mul
    IL_0011: stloc.0
    IL_0012: ldarg.1
    IL_0013: ldc.i4.1
    IL_0014: shr.un
    IL_0015: starg.s exp
    IL_0017: ldarg.1
    IL_0018: brfalse.s IL_0021
    IL_001A: ldarg.0
    IL_001B: ldarg.0
    IL_001C: mul
    IL_001D: starg.s b
    IL_001F: br.s IL_0009
    IL_0021: ldloc.0
    IL_0022: ret

}
ulong pow(ulong b, uint exp)
{
    IL_0000: ldarg.1
    IL_0001: brtrue.s IL_0006
    IL_0003: ldc.i4.1
    IL_0004: conv.i8
    IL_0005: ret
    IL_0006: ldc.i4.1
    IL_0007: conv.i8
    IL_0008: stloc.0
    IL_0009: ldarg.1
    IL_000A: ldc.i4.1
    IL_000B: and
    IL_000C: brfalse.s IL_0012
    IL_000E: ldloc.0
    IL_000F: ldarg.0
    IL_0010: mul
    IL_0011: stloc.0
    IL_0012: ldarg.1
    IL_0013: ldc.i4.1
    IL_0014: shr.un
    IL_0015: starg.s exp
    IL_0017: ldarg.1
    IL_0018: brfalse.s IL_0021
    IL_001A: ldarg.0
    IL_001B: ldarg.0
    IL_001C: mul
    IL_001D: starg.s b
    IL_001F: br.s IL_0009
    IL_0021: ldloc.0
    IL_0022: ret

}
ref sbyte pow(ref sbyte src, uint exp)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i1
    IL_0003: ldarg.1
    IL_0004: call System.SByte Z0.math::pow(System.SByte,System.UInt32)
    IL_0009: stind.i1
    IL_000A: ldarg.0
    IL_000B: ret

}
ref byte pow(ref byte src, uint exp)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u1
    IL_0003: ldarg.1
    IL_0004: call System.Byte Z0.math::pow(System.Byte,System.UInt32)
    IL_0009: stind.i1
    IL_000A: ldarg.0
    IL_000B: ret

}
ref short pow(ref short src, uint exp)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i2
    IL_0003: ldarg.1
    IL_0004: call System.Int16 Z0.math::pow(System.Int16,System.UInt32)
    IL_0009: stind.i2
    IL_000A: ldarg.0
    IL_000B: ret

}
ref ushort pow(ref ushort src, uint exp)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u2
    IL_0003: ldarg.1
    IL_0004: call System.UInt16 Z0.math::pow(System.UInt16,System.UInt32)
    IL_0009: stind.i2
    IL_000A: ldarg.0
    IL_000B: ret

}
ref int pow(ref int src, uint exp)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i4
    IL_0003: ldarg.1
    IL_0004: call System.Int32 Z0.math::pow(System.Int32,System.UInt32)
    IL_0009: stind.i4
    IL_000A: ldarg.0
    IL_000B: ret

}
ref uint pow(ref uint src, uint exp)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u4
    IL_0003: ldarg.1
    IL_0004: call System.UInt32 Z0.math::pow(System.UInt32,System.UInt32)
    IL_0009: stind.i4
    IL_000A: ldarg.0
    IL_000B: ret

}
ref long pow(ref long src, uint exp)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldarg.1
    IL_0004: call System.Int64 Z0.math::pow(System.Int64,System.UInt32)
    IL_0009: stind.i8
    IL_000A: ldarg.0
    IL_000B: ret

}
ref ulong pow(ref ulong src, uint exp)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldarg.1
    IL_0004: call System.UInt64 Z0.math::pow(System.UInt64,System.UInt32)
    IL_0009: stind.i8
    IL_000A: ldarg.0
    IL_000B: ret

}
Sign:int signum(sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Sign Z0.math::signum(System.Int32)
    IL_0006: ret

}
Sign:int signum(byte src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Sign Z0.math::signum(System.UInt32)
    IL_0006: ret

}
Sign:int signum(short src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Sign Z0.math::signum(System.Int32)
    IL_0006: ret

}
Sign:int signum(ushort src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Sign Z0.math::signum(System.UInt32)
    IL_0006: ret

}
Sign:int signum(int src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.s 31
    IL_0003: shr
    IL_0004: ldarg.0
    IL_0005: call System.UInt32 Z0.math::negate(System.UInt32)
    IL_000A: ldc.i4.s 31
    IL_000C: shr.un
    IL_000D: or
    IL_000E: ret

}
Sign:int signum(uint src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Boolean Z0.math::nonzero(System.UInt32)
    IL_0006: call System.Byte Z0.xfunc::ToByte(System.Boolean)
    IL_000B: ret

}
Sign:int signum(long src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.s 63
    IL_0003: shr
    IL_0004: ldarg.0
    IL_0005: call System.UInt64 Z0.math::negate(System.UInt64)
    IL_000A: ldc.i4.s 63
    IL_000C: shr.un
    IL_000D: or
    IL_000E: conv.i4
    IL_000F: ret

}
Sign:int signum(ulong src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Boolean Z0.math::nonzero(System.UInt64)
    IL_0006: call System.Byte Z0.xfunc::ToByte(System.Boolean)
    IL_000B: ret

}
sbyte square(sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: call System.SByte Z0.math::mul(System.SByte,System.SByte)
    IL_0007: ret

}
byte square(byte src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: call System.Byte Z0.math::mul(System.Byte,System.Byte)
    IL_0007: ret

}
short square(short src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: call System.Int16 Z0.math::mul(System.Int16,System.Int16)
    IL_0007: ret

}
ushort square(ushort src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: call System.UInt16 Z0.math::mul(System.UInt16,System.UInt16)
    IL_0007: ret

}
int square(int src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: call System.Int32 Z0.math::mul(System.Int32,System.Int32)
    IL_0007: ret

}
uint square(uint src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: call System.UInt32 Z0.math::mul(System.UInt32,System.UInt32)
    IL_0007: ret

}
long square(long src)
{
    IL_0000: ldarg.0
    IL_0001: conv.r8
    IL_0002: call System.Double System.Math::Sqrt(System.Double)
    IL_0007: conv.i8
    IL_0008: ret

}
ulong square(ulong src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: call System.UInt64 Z0.math::mul(System.UInt64,System.UInt64)
    IL_0007: ret

}
ref sbyte square(ref sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i1
    IL_0003: ldarg.0
    IL_0004: ldind.i1
    IL_0005: mul
    IL_0006: conv.i1
    IL_0007: stind.i1
    IL_0008: ldarg.0
    IL_0009: ret

}
ref byte square(ref byte src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u1
    IL_0003: ldarg.0
    IL_0004: ldind.u1
    IL_0005: mul
    IL_0006: conv.u1
    IL_0007: stind.i1
    IL_0008: ldarg.0
    IL_0009: ret

}
ref short square(ref short src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i2
    IL_0003: ldarg.0
    IL_0004: ldind.i2
    IL_0005: mul
    IL_0006: conv.i2
    IL_0007: stind.i2
    IL_0008: ldarg.0
    IL_0009: ret

}
ref ushort square(ref ushort src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u2
    IL_0003: ldarg.0
    IL_0004: ldind.u2
    IL_0005: mul
    IL_0006: conv.u2
    IL_0007: stind.i2
    IL_0008: ldarg.0
    IL_0009: ret

}
ref int square(ref int src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i4
    IL_0003: ldarg.0
    IL_0004: ldind.i4
    IL_0005: mul
    IL_0006: stind.i4
    IL_0007: ldarg.0
    IL_0008: ret

}
ref uint square(ref uint src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u4
    IL_0003: ldarg.0
    IL_0004: ldind.u4
    IL_0005: mul
    IL_0006: stind.i4
    IL_0007: ldarg.0
    IL_0008: ret

}
ref long square(ref long src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldarg.0
    IL_0004: ldind.i8
    IL_0005: mul
    IL_0006: stind.i8
    IL_0007: ldarg.0
    IL_0008: ret

}
ref ulong square(ref ulong src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldarg.0
    IL_0004: ldind.i8
    IL_0005: mul
    IL_0006: stind.i8
    IL_0007: ldarg.0
    IL_0008: ret

}
sbyte sub(sbyte lhs, sbyte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: sub
    IL_0003: conv.i1
    IL_0004: ret

}
byte sub(byte lhs, byte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: sub
    IL_0003: conv.u1
    IL_0004: ret

}
short sub(short lhs, short rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: sub
    IL_0003: conv.i2
    IL_0004: ret

}
ushort sub(ushort lhs, ushort rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: sub
    IL_0003: conv.u2
    IL_0004: ret

}
int sub(int lhs, int rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: sub
    IL_0003: ret

}
uint sub(uint lhs, uint rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: sub
    IL_0003: ret

}
long sub(long lhs, long rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: sub
    IL_0003: ret

}
ulong sub(ulong lhs, ulong rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: sub
    IL_0003: ret

}
ref sbyte sub(ref sbyte lhs, sbyte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i1
    IL_0003: ldarg.1
    IL_0004: sub
    IL_0005: conv.i1
    IL_0006: stind.i1
    IL_0007: ldarg.0
    IL_0008: ret

}
ref byte sub(ref byte lhs, byte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u1
    IL_0003: ldarg.1
    IL_0004: sub
    IL_0005: conv.u1
    IL_0006: stind.i1
    IL_0007: ldarg.0
    IL_0008: ret

}
ref short sub(ref short lhs, short rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i2
    IL_0003: ldarg.1
    IL_0004: sub
    IL_0005: conv.i2
    IL_0006: stind.i2
    IL_0007: ldarg.0
    IL_0008: ret

}
ref ushort sub(ref ushort lhs, ushort rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u2
    IL_0003: ldarg.1
    IL_0004: sub
    IL_0005: conv.u2
    IL_0006: stind.i2
    IL_0007: ldarg.0
    IL_0008: ret

}
ref int sub(ref int lhs, int rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i4
    IL_0003: ldarg.1
    IL_0004: sub
    IL_0005: stind.i4
    IL_0006: ldarg.0
    IL_0007: ret

}
ref uint sub(ref uint lhs, uint rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u4
    IL_0003: ldarg.1
    IL_0004: sub
    IL_0005: stind.i4
    IL_0006: ldarg.0
    IL_0007: ret

}
ref long sub(ref long lhs, long rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldarg.1
    IL_0004: sub
    IL_0005: stind.i8
    IL_0006: ldarg.0
    IL_0007: ret

}
ref ulong sub(ref ulong lhs, ulong rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldarg.1
    IL_0004: sub
    IL_0005: stind.i8
    IL_0006: ldarg.0
    IL_0007: ret

}
bool within(byte lhs, byte rhs, byte epsilon)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: bgt.s IL_000E
    IL_0004: ldarg.1
    IL_0005: ldarg.0
    IL_0006: sub
    IL_0007: ldarg.2
    IL_0008: cgt
    IL_000A: ldc.i4.0
    IL_000B: ceq
    IL_000D: ret
    IL_000E: ldarg.0
    IL_000F: ldarg.1
    IL_0010: sub
    IL_0011: ldarg.2
    IL_0012: cgt
    IL_0014: ldc.i4.0
    IL_0015: ceq
    IL_0017: ret

}
bool within(sbyte lhs, sbyte rhs, sbyte epsilon)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: bgt.s IL_000E
    IL_0004: ldarg.1
    IL_0005: ldarg.0
    IL_0006: sub
    IL_0007: ldarg.2
    IL_0008: cgt
    IL_000A: ldc.i4.0
    IL_000B: ceq
    IL_000D: ret
    IL_000E: ldarg.0
    IL_000F: ldarg.1
    IL_0010: sub
    IL_0011: ldarg.2
    IL_0012: cgt
    IL_0014: ldc.i4.0
    IL_0015: ceq
    IL_0017: ret

}
bool within(short lhs, short rhs, short epsilon)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: bgt.s IL_000E
    IL_0004: ldarg.1
    IL_0005: ldarg.0
    IL_0006: sub
    IL_0007: ldarg.2
    IL_0008: cgt
    IL_000A: ldc.i4.0
    IL_000B: ceq
    IL_000D: ret
    IL_000E: ldarg.0
    IL_000F: ldarg.1
    IL_0010: sub
    IL_0011: ldarg.2
    IL_0012: cgt
    IL_0014: ldc.i4.0
    IL_0015: ceq
    IL_0017: ret

}
bool within(ushort lhs, ushort rhs, ushort epsilon)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: bgt.s IL_000E
    IL_0004: ldarg.1
    IL_0005: ldarg.0
    IL_0006: sub
    IL_0007: ldarg.2
    IL_0008: cgt
    IL_000A: ldc.i4.0
    IL_000B: ceq
    IL_000D: ret
    IL_000E: ldarg.0
    IL_000F: ldarg.1
    IL_0010: sub
    IL_0011: ldarg.2
    IL_0012: cgt
    IL_0014: ldc.i4.0
    IL_0015: ceq
    IL_0017: ret

}
bool within(int lhs, int rhs, int epsilon)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: bgt.s IL_000E
    IL_0004: ldarg.1
    IL_0005: ldarg.0
    IL_0006: sub
    IL_0007: ldarg.2
    IL_0008: cgt
    IL_000A: ldc.i4.0
    IL_000B: ceq
    IL_000D: ret
    IL_000E: ldarg.0
    IL_000F: ldarg.1
    IL_0010: sub
    IL_0011: ldarg.2
    IL_0012: cgt
    IL_0014: ldc.i4.0
    IL_0015: ceq
    IL_0017: ret

}
bool within(uint lhs, uint rhs, uint epsilon)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: bgt.un.s IL_000E
    IL_0004: ldarg.1
    IL_0005: ldarg.0
    IL_0006: sub
    IL_0007: ldarg.2
    IL_0008: cgt.un
    IL_000A: ldc.i4.0
    IL_000B: ceq
    IL_000D: ret
    IL_000E: ldarg.0
    IL_000F: ldarg.1
    IL_0010: sub
    IL_0011: ldarg.2
    IL_0012: cgt.un
    IL_0014: ldc.i4.0
    IL_0015: ceq
    IL_0017: ret

}
bool within(long lhs, long rhs, long epsilon)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: bgt.s IL_000E
    IL_0004: ldarg.1
    IL_0005: ldarg.0
    IL_0006: sub
    IL_0007: ldarg.2
    IL_0008: cgt
    IL_000A: ldc.i4.0
    IL_000B: ceq
    IL_000D: ret
    IL_000E: ldarg.0
    IL_000F: ldarg.1
    IL_0010: sub
    IL_0011: ldarg.2
    IL_0012: cgt
    IL_0014: ldc.i4.0
    IL_0015: ceq
    IL_0017: ret

}
bool within(ulong lhs, ulong rhs, ulong epsilon)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: bgt.un.s IL_000E
    IL_0004: ldarg.1
    IL_0005: ldarg.0
    IL_0006: sub
    IL_0007: ldarg.2
    IL_0008: cgt.un
    IL_000A: ldc.i4.0
    IL_000B: ceq
    IL_000D: ret
    IL_000E: ldarg.0
    IL_000F: ldarg.1
    IL_0010: sub
    IL_0011: ldarg.2
    IL_0012: cgt.un
    IL_0014: ldc.i4.0
    IL_0015: ceq
    IL_0017: ret

}
ulong max(ulong lhs, ulong rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: bgt.un.s IL_0006
    IL_0004: ldarg.1
    IL_0005: ret
    IL_0006: ldarg.0
    IL_0007: ret

}
ref sbyte max(ref sbyte lhs, sbyte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i1
    IL_0003: ldarg.1
    IL_0004: bgt.s IL_0009
    IL_0006: ldarg.1
    IL_0007: br.s IL_000B
    IL_0009: ldarg.0
    IL_000A: ldind.i1
    IL_000B: stind.i1
    IL_000C: ldarg.0
    IL_000D: ret

}
ref byte max(ref byte lhs, byte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u1
    IL_0003: ldarg.1
    IL_0004: bgt.s IL_0009
    IL_0006: ldarg.1
    IL_0007: br.s IL_000B
    IL_0009: ldarg.0
    IL_000A: ldind.u1
    IL_000B: stind.i1
    IL_000C: ldarg.0
    IL_000D: ret

}
ref short max(ref short lhs, short rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i2
    IL_0003: ldarg.1
    IL_0004: bgt.s IL_0009
    IL_0006: ldarg.1
    IL_0007: br.s IL_000B
    IL_0009: ldarg.0
    IL_000A: ldind.i2
    IL_000B: stind.i2
    IL_000C: ldarg.0
    IL_000D: ret

}
ref ushort max(ref ushort lhs, ushort rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u2
    IL_0003: ldarg.1
    IL_0004: bgt.s IL_0009
    IL_0006: ldarg.1
    IL_0007: br.s IL_000B
    IL_0009: ldarg.0
    IL_000A: ldind.u2
    IL_000B: stind.i2
    IL_000C: ldarg.0
    IL_000D: ret

}
ref int max(ref int lhs, int rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i4
    IL_0003: ldarg.1
    IL_0004: bgt.s IL_0009
    IL_0006: ldarg.1
    IL_0007: br.s IL_000B
    IL_0009: ldarg.0
    IL_000A: ldind.i4
    IL_000B: stind.i4
    IL_000C: ldarg.0
    IL_000D: ret

}
ref uint max(ref uint lhs, uint rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u4
    IL_0003: ldarg.1
    IL_0004: bgt.un.s IL_0009
    IL_0006: ldarg.1
    IL_0007: br.s IL_000B
    IL_0009: ldarg.0
    IL_000A: ldind.u4
    IL_000B: stind.i4
    IL_000C: ldarg.0
    IL_000D: ret

}
ref long max(ref long lhs, long rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldarg.1
    IL_0004: bgt.s IL_0009
    IL_0006: ldarg.1
    IL_0007: br.s IL_000B
    IL_0009: ldarg.0
    IL_000A: ldind.i8
    IL_000B: stind.i8
    IL_000C: ldarg.0
    IL_000D: ret

}
ref ulong max(ref ulong lhs, ulong rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldarg.1
    IL_0004: bgt.un.s IL_0009
    IL_0006: ldarg.1
    IL_0007: br.s IL_000B
    IL_0009: ldarg.0
    IL_000A: ldind.i8
    IL_000B: stind.i8
    IL_000C: ldarg.0
    IL_000D: ret

}
sbyte min(sbyte lhs, sbyte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: blt.s IL_0006
    IL_0004: ldarg.1
    IL_0005: ret
    IL_0006: ldarg.0
    IL_0007: ret

}
byte min(byte lhs, byte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: blt.s IL_0006
    IL_0004: ldarg.1
    IL_0005: ret
    IL_0006: ldarg.0
    IL_0007: ret

}
short min(short lhs, short rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: blt.s IL_0006
    IL_0004: ldarg.1
    IL_0005: ret
    IL_0006: ldarg.0
    IL_0007: ret

}
ushort min(ushort lhs, ushort rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: blt.s IL_0006
    IL_0004: ldarg.1
    IL_0005: ret
    IL_0006: ldarg.0
    IL_0007: ret

}
int min(int lhs, int rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: blt.s IL_0006
    IL_0004: ldarg.1
    IL_0005: ret
    IL_0006: ldarg.0
    IL_0007: ret

}
uint min(uint lhs, uint rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: blt.un.s IL_0006
    IL_0004: ldarg.1
    IL_0005: ret
    IL_0006: ldarg.0
    IL_0007: ret

}
long min(long lhs, long rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: blt.s IL_0006
    IL_0004: ldarg.1
    IL_0005: ret
    IL_0006: ldarg.0
    IL_0007: ret

}
ulong min(ulong lhs, ulong rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: blt.un.s IL_0006
    IL_0004: ldarg.1
    IL_0005: ret
    IL_0006: ldarg.0
    IL_0007: ret

}
ref sbyte min(ref sbyte lhs, sbyte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i1
    IL_0003: ldarg.1
    IL_0004: blt.s IL_0009
    IL_0006: ldarg.1
    IL_0007: br.s IL_000B
    IL_0009: ldarg.0
    IL_000A: ldind.i1
    IL_000B: stind.i1
    IL_000C: ldarg.0
    IL_000D: ret

}
ref byte min(ref byte lhs, byte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u1
    IL_0003: ldarg.1
    IL_0004: blt.s IL_0009
    IL_0006: ldarg.1
    IL_0007: br.s IL_000B
    IL_0009: ldarg.0
    IL_000A: ldind.u1
    IL_000B: stind.i1
    IL_000C: ldarg.0
    IL_000D: ret

}
ref short min(ref short lhs, short rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i2
    IL_0003: ldarg.1
    IL_0004: blt.s IL_0009
    IL_0006: ldarg.1
    IL_0007: br.s IL_000B
    IL_0009: ldarg.0
    IL_000A: ldind.i2
    IL_000B: stind.i2
    IL_000C: ldarg.0
    IL_000D: ret

}
ref ushort min(ref ushort lhs, ushort rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u2
    IL_0003: ldarg.1
    IL_0004: blt.s IL_0009
    IL_0006: ldarg.1
    IL_0007: br.s IL_000B
    IL_0009: ldarg.0
    IL_000A: ldind.u2
    IL_000B: stind.i2
    IL_000C: ldarg.0
    IL_000D: ret

}
ref int min(ref int lhs, int rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i4
    IL_0003: ldarg.1
    IL_0004: blt.s IL_0009
    IL_0006: ldarg.1
    IL_0007: br.s IL_000B
    IL_0009: ldarg.0
    IL_000A: ldind.i4
    IL_000B: stind.i4
    IL_000C: ldarg.0
    IL_000D: ret

}
ref uint min(ref uint lhs, uint rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u4
    IL_0003: ldarg.1
    IL_0004: blt.un.s IL_0009
    IL_0006: ldarg.1
    IL_0007: br.s IL_000B
    IL_0009: ldarg.0
    IL_000A: ldind.u4
    IL_000B: stind.i4
    IL_000C: ldarg.0
    IL_000D: ret

}
ref long min(ref long lhs, long rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldarg.1
    IL_0004: blt.s IL_0009
    IL_0006: ldarg.1
    IL_0007: br.s IL_000B
    IL_0009: ldarg.0
    IL_000A: ldind.i8
    IL_000B: stind.i8
    IL_000C: ldarg.0
    IL_000D: ret

}
ref ulong min(ref ulong lhs, ulong rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldarg.1
    IL_0004: blt.un.s IL_0009
    IL_0006: ldarg.1
    IL_0007: br.s IL_000B
    IL_0009: ldarg.0
    IL_000A: ldind.i8
    IL_000B: stind.i8
    IL_000C: ldarg.0
    IL_000D: ret

}
sbyte mod(sbyte lhs, sbyte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: rem
    IL_0003: conv.i1
    IL_0004: ret

}
byte mod(byte lhs, byte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: rem
    IL_0003: conv.u1
    IL_0004: ret

}
short mod(short lhs, short rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: rem
    IL_0003: conv.i2
    IL_0004: ret

}
ushort mod(ushort lhs, ushort rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: rem
    IL_0003: conv.u2
    IL_0004: ret

}
int mod(int lhs, int rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: rem
    IL_0003: ret

}
uint mod(uint lhs, uint rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: rem.un
    IL_0003: ret

}
long mod(long lhs, long rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: rem
    IL_0003: ret

}
ulong mod(ulong lhs, ulong rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: rem.un
    IL_0003: ret

}
ref sbyte mod(ref sbyte lhs, in sbyte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i1
    IL_0003: ldarg.1
    IL_0004: ldind.i1
    IL_0005: rem
    IL_0006: conv.i1
    IL_0007: stind.i1
    IL_0008: ldarg.0
    IL_0009: ret

}
ref byte mod(ref byte lhs, in byte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u1
    IL_0003: ldarg.1
    IL_0004: ldind.u1
    IL_0005: rem
    IL_0006: conv.u1
    IL_0007: stind.i1
    IL_0008: ldarg.0
    IL_0009: ret

}
ref short mod(ref short lhs, in short rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i2
    IL_0003: ldarg.1
    IL_0004: ldind.i2
    IL_0005: rem
    IL_0006: conv.i2
    IL_0007: stind.i2
    IL_0008: ldarg.0
    IL_0009: ret

}
ref ushort mod(ref ushort lhs, in ushort rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u2
    IL_0003: ldarg.1
    IL_0004: ldind.u2
    IL_0005: rem
    IL_0006: conv.u2
    IL_0007: stind.i2
    IL_0008: ldarg.0
    IL_0009: ret

}
ref int mod(ref int lhs, in int rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i4
    IL_0003: ldarg.1
    IL_0004: ldind.i4
    IL_0005: rem
    IL_0006: stind.i4
    IL_0007: ldarg.0
    IL_0008: ret

}
ref uint mod(ref uint lhs, in uint rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u4
    IL_0003: ldarg.1
    IL_0004: ldind.u4
    IL_0005: rem.un
    IL_0006: stind.i4
    IL_0007: ldarg.0
    IL_0008: ret

}
ref long mod(ref long lhs, in long rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldarg.1
    IL_0004: ldind.i8
    IL_0005: rem
    IL_0006: stind.i8
    IL_0007: ldarg.0
    IL_0008: ret

}
ref ulong mod(ref ulong lhs, in ulong rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldarg.1
    IL_0004: ldind.i8
    IL_0005: rem.un
    IL_0006: stind.i8
    IL_0007: ldarg.0
    IL_0008: ret

}
sbyte mul(sbyte lhs, sbyte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: mul
    IL_0003: conv.i1
    IL_0004: ret

}
byte mul(byte lhs, byte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: mul
    IL_0003: conv.u1
    IL_0004: ret

}
short mul(short lhs, short rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: mul
    IL_0003: conv.i2
    IL_0004: ret

}
ushort mul(ushort lhs, ushort rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: mul
    IL_0003: conv.u2
    IL_0004: ret

}
int mul(int lhs, int rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: mul
    IL_0003: ret

}
uint mul(uint lhs, uint rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: mul
    IL_0003: ret

}
long mul(long lhs, long rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: mul
    IL_0003: ret

}
ulong mul(ulong lhs, ulong rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: mul
    IL_0003: ret

}
ref sbyte mul(ref sbyte lhs, sbyte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i1
    IL_0003: ldarg.1
    IL_0004: mul
    IL_0005: conv.i1
    IL_0006: stind.i1
    IL_0007: ldarg.0
    IL_0008: ret

}
ref byte mul(ref byte lhs, byte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u1
    IL_0003: ldarg.1
    IL_0004: mul
    IL_0005: conv.u1
    IL_0006: stind.i1
    IL_0007: ldarg.0
    IL_0008: ret

}
ref short mul(ref short lhs, short rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i2
    IL_0003: ldarg.1
    IL_0004: mul
    IL_0005: conv.i2
    IL_0006: stind.i2
    IL_0007: ldarg.0
    IL_0008: ret

}
ref ushort mul(ref ushort lhs, ushort rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u2
    IL_0003: ldarg.1
    IL_0004: mul
    IL_0005: conv.u2
    IL_0006: stind.i2
    IL_0007: ldarg.0
    IL_0008: ret

}
ref int mul(ref int lhs, int rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i4
    IL_0003: ldarg.1
    IL_0004: mul
    IL_0005: stind.i4
    IL_0006: ldarg.0
    IL_0007: ret

}
ref uint mul(ref uint lhs, uint rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u4
    IL_0003: ldarg.1
    IL_0004: mul
    IL_0005: stind.i4
    IL_0006: ldarg.0
    IL_0007: ret

}
ref long mul(ref long lhs, long rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldarg.1
    IL_0004: mul
    IL_0005: stind.i8
    IL_0006: ldarg.0
    IL_0007: ret

}
ref ulong mul(ref ulong lhs, ulong rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldarg.1
    IL_0004: mul
    IL_0005: stind.i8
    IL_0006: ldarg.0
    IL_0007: ret

}
sbyte negate(sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: neg
    IL_0002: conv.i1
    IL_0003: ret

}
byte negate(byte src)
{
    IL_0000: ldarg.0
    IL_0001: not
    IL_0002: ldc.i4.1
    IL_0003: add
    IL_0004: conv.u1
    IL_0005: ret

}
short negate(short src)
{
    IL_0000: ldarg.0
    IL_0001: neg
    IL_0002: conv.i2
    IL_0003: ret

}
ushort negate(ushort src)
{
    IL_0000: ldarg.0
    IL_0001: not
    IL_0002: ldc.i4.1
    IL_0003: add
    IL_0004: conv.u2
    IL_0005: ret

}
int negate(int src)
{
    IL_0000: ldarg.0
    IL_0001: neg
    IL_0002: ret

}
uint negate(uint src)
{
    IL_0000: ldarg.0
    IL_0001: not
    IL_0002: ldc.i4.1
    IL_0003: add
    IL_0004: ret

}
long negate(long src)
{
    IL_0000: ldarg.0
    IL_0001: neg
    IL_0002: ret

}
ulong negate(ulong src)
{
    IL_0000: ldarg.0
    IL_0001: not
    IL_0002: ldc.i4.1
    IL_0003: conv.i8
    IL_0004: add
    IL_0005: ret

}
float negate(float src)
{
    IL_0000: ldarg.0
    IL_0001: neg
    IL_0002: ret

}
double negate(double src)
{
    IL_0000: ldarg.0
    IL_0001: neg
    IL_0002: ret

}
ref sbyte negate(ref sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i1
    IL_0003: neg
    IL_0004: conv.i1
    IL_0005: stind.i1
    IL_0006: ldarg.0
    IL_0007: ret

}
ref byte negate(ref byte src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u1
    IL_0003: call System.Byte Z0.math::negate(System.Byte)
    IL_0008: stind.i1
    IL_0009: ldarg.0
    IL_000A: ret

}
ref short negate(ref short src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i2
    IL_0003: neg
    IL_0004: conv.i2
    IL_0005: stind.i2
    IL_0006: ldarg.0
    IL_0007: ret

}
ref ushort negate(ref ushort src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u2
    IL_0003: call System.UInt16 Z0.math::negate(System.UInt16)
    IL_0008: stind.i2
    IL_0009: ldarg.0
    IL_000A: ret

}
ref int negate(ref int src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i4
    IL_0003: neg
    IL_0004: stind.i4
    IL_0005: ldarg.0
    IL_0006: ret

}
ref uint negate(ref uint src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u4
    IL_0003: call System.UInt32 Z0.math::negate(System.UInt32)
    IL_0008: stind.i4
    IL_0009: ldarg.0
    IL_000A: ret

}
ref long negate(ref long src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: neg
    IL_0004: stind.i8
    IL_0005: ldarg.0
    IL_0006: ret

}
ref ulong negate(ref ulong src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: call System.UInt64 Z0.math::negate(System.UInt64)
    IL_0008: stind.i8
    IL_0009: ldarg.0
    IL_000A: ret

}
ref float negate(ref float src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.r4
    IL_0003: neg
    IL_0004: stind.r4
    IL_0005: ldarg.0
    IL_0006: ret

}
ref double negate(ref double src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.r8
    IL_0003: neg
    IL_0004: stind.r8
    IL_0005: ldarg.0
    IL_0006: ret

}
ref sbyte negate(sbyte src, ref sbyte dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: neg
    IL_0003: conv.i1
    IL_0004: stind.i1
    IL_0005: ldarg.1
    IL_0006: ret

}
ref byte negate(byte src, ref byte dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Byte Z0.math::negate(System.Byte)
    IL_0007: stind.i1
    IL_0008: ldarg.1
    IL_0009: ret

}
ref short negate(short src, ref short dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: neg
    IL_0003: conv.i2
    IL_0004: stind.i2
    IL_0005: ldarg.1
    IL_0006: ret

}
ref ushort negate(ushort src, ref ushort dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.UInt16 Z0.math::negate(System.UInt16)
    IL_0007: stind.i2
    IL_0008: ldarg.1
    IL_0009: ret

}
ref int negate(int src, ref int dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: neg
    IL_0003: stind.i4
    IL_0004: ldarg.1
    IL_0005: ret

}
ref uint negate(uint src, ref uint dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.UInt32 Z0.math::negate(System.UInt32)
    IL_0007: stind.i4
    IL_0008: ldarg.1
    IL_0009: ret

}
ref long negate(long src, ref long dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: neg
    IL_0003: stind.i8
    IL_0004: ldarg.1
    IL_0005: ret

}
ref ulong negate(ulong src, ref ulong dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.UInt64 Z0.math::negate(System.UInt64)
    IL_0007: stind.i8
    IL_0008: ldarg.1
    IL_0009: ret

}
ref float negate(float src, ref float dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: neg
    IL_0003: stind.r4
    IL_0004: ldarg.1
    IL_0005: ret

}
ref double negate(double src, ref double dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: neg
    IL_0003: stind.r8
    IL_0004: ldarg.1
    IL_0005: ret

}
bool negative(sbyte x)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: clt
    IL_0004: ret

}
bool negative(short x)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: clt
    IL_0004: ret

}
bool negative(int x)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: clt
    IL_0004: ret

}
bool negative(long x)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: conv.i8
    IL_0003: clt
    IL_0005: ret

}
bool negative(float x)
{
    IL_0000: ldarg.0
    IL_0001: ldc.r4 0
    IL_0006: clt
    IL_0008: ret

}
bool negative(double x)
{
    IL_0000: ldarg.0
    IL_0001: ldc.r8 0
    IL_000A: clt
    IL_000C: ret

}
bool nonzero(sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: cgt.un
    IL_0004: ret

}
bool nonzero(byte src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: cgt.un
    IL_0004: ret

}
bool nonzero(short src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: cgt.un
    IL_0004: ret

}
bool nonzero(ushort src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: cgt.un
    IL_0004: ret

}
bool nonzero(int src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: cgt.un
    IL_0004: ret

}
bool nonzero(uint src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: cgt.un
    IL_0004: ret

}
bool nonzero(long src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: conv.i8
    IL_0003: cgt.un
    IL_0005: ret

}
bool nonzero(ulong src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: conv.i8
    IL_0003: cgt.un
    IL_0005: ret

}
bool nonzero(float src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.r4 0
    IL_0006: ceq
    IL_0008: ldc.i4.0
    IL_0009: ceq
    IL_000B: ret

}
bool nonzero(double src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.r8 0
    IL_000A: ceq
    IL_000C: ldc.i4.0
    IL_000D: ceq
    IL_000F: ret

}
sbyte parse(string src, out sbyte dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.SByte System.SByte::Parse(System.String)
    IL_0007: dup
    IL_0008: stloc.0
    IL_0009: stind.i1
    IL_000A: ldloc.0
    IL_000B: ret

}
byte parse(string src, out byte dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Byte System.Byte::Parse(System.String)
    IL_0007: dup
    IL_0008: stloc.0
    IL_0009: stind.i1
    IL_000A: ldloc.0
    IL_000B: ret

}
short parse(string src, out short dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Int16 System.Int16::Parse(System.String)
    IL_0007: dup
    IL_0008: stloc.0
    IL_0009: stind.i2
    IL_000A: ldloc.0
    IL_000B: ret

}
ushort parse(string src, out ushort dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.UInt16 System.UInt16::Parse(System.String)
    IL_0007: dup
    IL_0008: stloc.0
    IL_0009: stind.i2
    IL_000A: ldloc.0
    IL_000B: ret

}
int parse(string src, out int dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Int32 System.Int32::Parse(System.String)
    IL_0007: dup
    IL_0008: stloc.0
    IL_0009: stind.i4
    IL_000A: ldloc.0
    IL_000B: ret

}
uint parse(string src, out uint dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.UInt32 System.UInt32::Parse(System.String)
    IL_0007: dup
    IL_0008: stloc.0
    IL_0009: stind.i4
    IL_000A: ldloc.0
    IL_000B: ret

}
long parse(string src, out long dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Int64 System.Int64::Parse(System.String)
    IL_0007: dup
    IL_0008: stloc.0
    IL_0009: stind.i8
    IL_000A: ldloc.0
    IL_000B: ret

}
ulong parse(string src, out ulong dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.UInt64 System.UInt64::Parse(System.String)
    IL_0007: dup
    IL_0008: stloc.0
    IL_0009: stind.i8
    IL_000A: ldloc.0
    IL_000B: ret

}
float parse(string src, out float dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Single System.Single::Parse(System.String)
    IL_0007: dup
    IL_0008: stloc.0
    IL_0009: stind.r4
    IL_000A: ldloc.0
    IL_000B: ret

}
double parse(string src, out double dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Double System.Double::Parse(System.String)
    IL_0007: dup
    IL_0008: stloc.0
    IL_0009: stind.r8
    IL_000A: ldloc.0
    IL_000B: ret

}
bool positive(sbyte x)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: cgt
    IL_0004: ret

}
bool positive(byte x)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: cgt
    IL_0004: ret

}
bool positive(short x)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: cgt
    IL_0004: ret

}
bool positive(ushort x)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: cgt
    IL_0004: ret

}
bool positive(int x)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: cgt
    IL_0004: ret

}
bool positive(uint x)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: cgt.un
    IL_0004: ret

}
bool positive(long x)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: conv.i8
    IL_0003: cgt
    IL_0005: ret

}
bool positive(ulong x)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: conv.i8
    IL_0003: cgt.un
    IL_0005: ret

}
bool positive(float x)
{
    IL_0000: ldarg.0
    IL_0001: ldc.r4 0
    IL_0006: cgt
    IL_0008: ret

}
bool positive(double x)
{
    IL_0000: ldarg.0
    IL_0001: ldc.r8 0
    IL_000A: cgt
    IL_000C: ret

}
sbyte pow(sbyte b, uint exp)
{
    IL_0000: ldarg.1
    IL_0001: brtrue.s IL_0005
    IL_0003: ldc.i4.1
    IL_0004: ret
    IL_0005: ldc.i4.1
    IL_0006: stloc.0
    IL_0007: ldarg.1
    IL_0008: ldc.i4.1
    IL_0009: and
    IL_000A: brfalse.s IL_0011
    IL_000C: ldloc.0
    IL_000D: ldarg.0
    IL_000E: mul
    IL_000F: conv.i1
    IL_0010: stloc.0
    IL_0011: ldarg.1
    IL_0012: ldc.i4.1
    IL_0013: shr.un
    IL_0014: starg.s exp
    IL_0016: ldarg.1
    IL_0017: brfalse.s IL_0021
    IL_0019: ldarg.0
    IL_001A: ldarg.0
    IL_001B: mul
    IL_001C: conv.i1
    IL_001D: starg.s b
    IL_001F: br.s IL_0007
    IL_0021: ldloc.0
    IL_0022: ret

}
byte pow(byte b, uint exp)
{
    IL_0000: ldarg.1
    IL_0001: brtrue.s IL_0005
    IL_0003: ldc.i4.1
    IL_0004: ret
    IL_0005: ldc.i4.1
    IL_0006: stloc.0
    IL_0007: ldarg.1
    IL_0008: ldc.i4.1
    IL_0009: and
    IL_000A: brfalse.s IL_0011
    IL_000C: ldloc.0
    IL_000D: ldarg.0
    IL_000E: mul
    IL_000F: conv.u1
    IL_0010: stloc.0
    IL_0011: ldarg.1
    IL_0012: ldc.i4.1
    IL_0013: shr.un
    IL_0014: starg.s exp
    IL_0016: ldarg.1
    IL_0017: brfalse.s IL_0021
    IL_0019: ldarg.0
    IL_001A: ldarg.0
    IL_001B: mul
    IL_001C: conv.u1
    IL_001D: starg.s b
    IL_001F: br.s IL_0007
    IL_0021: ldloc.0
    IL_0022: ret

}
short pow(short b, uint exp)
{
    IL_0000: ldarg.1
    IL_0001: brtrue.s IL_0005
    IL_0003: ldc.i4.1
    IL_0004: ret
    IL_0005: ldc.i4.1
    IL_0006: stloc.0
    IL_0007: ldarg.1
    IL_0008: ldc.i4.1
    IL_0009: and
    IL_000A: brfalse.s IL_0011
    IL_000C: ldloc.0
    IL_000D: ldarg.0
    IL_000E: mul
    IL_000F: conv.i2
    IL_0010: stloc.0
    IL_0011: ldarg.1
    IL_0012: ldc.i4.1
    IL_0013: shr.un
    IL_0014: starg.s exp
    IL_0016: ldarg.1
    IL_0017: brfalse.s IL_0021
    IL_0019: ldarg.0
    IL_001A: ldarg.0
    IL_001B: mul
    IL_001C: conv.i2
    IL_001D: starg.s b
    IL_001F: br.s IL_0007
    IL_0021: ldloc.0
    IL_0022: ret

}
ushort pow(ushort b, uint exp)
{
    IL_0000: ldarg.1
    IL_0001: brtrue.s IL_0005
    IL_0003: ldc.i4.1
    IL_0004: ret
    IL_0005: ldc.i4.1
    IL_0006: stloc.0
    IL_0007: ldarg.1
    IL_0008: ldc.i4.1
    IL_0009: and
    IL_000A: brfalse.s IL_0011
    IL_000C: ldloc.0
    IL_000D: ldarg.0
    IL_000E: mul
    IL_000F: conv.u2
    IL_0010: stloc.0
    IL_0011: ldarg.1
    IL_0012: ldc.i4.1
    IL_0013: shr.un
    IL_0014: starg.s exp
    IL_0016: ldarg.1
    IL_0017: brfalse.s IL_0021
    IL_0019: ldarg.0
    IL_001A: ldarg.0
    IL_001B: mul
    IL_001C: conv.u2
    IL_001D: starg.s b
    IL_001F: br.s IL_0007
    IL_0021: ldloc.0
    IL_0022: ret

}
int pow(int b, uint exp)
{
    IL_0000: ldarg.1
    IL_0001: brtrue.s IL_0005
    IL_0003: ldc.i4.1
    IL_0004: ret
    IL_0005: ldc.i4.1
    IL_0006: stloc.0
    IL_0007: ldarg.1
    IL_0008: ldc.i4.1
    IL_0009: and
    IL_000A: brfalse.s IL_0010
    IL_000C: ldloc.0
    IL_000D: ldarg.0
    IL_000E: mul
    IL_000F: stloc.0
    IL_0010: ldarg.1
    IL_0011: ldc.i4.1
    IL_0012: shr.un
    IL_0013: starg.s exp
    IL_0015: ldarg.1
    IL_0016: brfalse.s IL_001F
    IL_0018: ldarg.0
    IL_0019: ldarg.0
    IL_001A: mul
    IL_001B: starg.s b
    IL_001D: br.s IL_0007
    IL_001F: ldloc.0
    IL_0020: ret

}
ulong dist(sbyte a, sbyte b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: bge.s IL_0009
    IL_0004: ldarg.1
    IL_0005: ldarg.0
    IL_0006: sub
    IL_0007: conv.i8
    IL_0008: ret
    IL_0009: ldarg.0
    IL_000A: ldarg.1
    IL_000B: sub
    IL_000C: conv.i8
    IL_000D: ret

}
ulong dist(short a, short b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: bge.s IL_0009
    IL_0004: ldarg.1
    IL_0005: ldarg.0
    IL_0006: sub
    IL_0007: conv.i8
    IL_0008: ret
    IL_0009: ldarg.0
    IL_000A: ldarg.1
    IL_000B: sub
    IL_000C: conv.i8
    IL_000D: ret

}
ulong dist(ushort a, ushort b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: bge.s IL_0009
    IL_0004: ldarg.1
    IL_0005: ldarg.0
    IL_0006: sub
    IL_0007: conv.i8
    IL_0008: ret
    IL_0009: ldarg.0
    IL_000A: ldarg.1
    IL_000B: sub
    IL_000C: conv.i8
    IL_000D: ret

}
ulong dist(int a, int b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: bge.s IL_0009
    IL_0004: ldarg.1
    IL_0005: ldarg.0
    IL_0006: sub
    IL_0007: conv.i8
    IL_0008: ret
    IL_0009: ldarg.0
    IL_000A: ldarg.1
    IL_000B: sub
    IL_000C: conv.i8
    IL_000D: ret

}
ulong dist(uint a, uint b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: bge.un.s IL_0009
    IL_0004: ldarg.1
    IL_0005: ldarg.0
    IL_0006: sub
    IL_0007: conv.u8
    IL_0008: ret
    IL_0009: ldarg.0
    IL_000A: ldarg.1
    IL_000B: sub
    IL_000C: conv.u8
    IL_000D: ret

}
ulong dist(long a, long b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: bge.s IL_0008
    IL_0004: ldarg.1
    IL_0005: ldarg.0
    IL_0006: sub
    IL_0007: ret
    IL_0008: ldarg.0
    IL_0009: ldarg.1
    IL_000A: sub
    IL_000B: ret

}
ulong dist(ulong a, ulong b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: bge.un.s IL_0008
    IL_0004: ldarg.1
    IL_0005: ldarg.0
    IL_0006: sub
    IL_0007: ret
    IL_0008: ldarg.0
    IL_0009: ldarg.1
    IL_000A: sub
    IL_000B: ret

}
sbyte div(sbyte lhs, sbyte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: div
    IL_0003: conv.i1
    IL_0004: ret

}
byte div(byte lhs, byte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: div
    IL_0003: conv.u1
    IL_0004: ret

}
short div(short lhs, short rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: div
    IL_0003: conv.i2
    IL_0004: ret

}
ushort div(ushort lhs, ushort rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: div
    IL_0003: conv.u2
    IL_0004: ret

}
int div(int lhs, int rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: div
    IL_0003: ret

}
uint div(uint lhs, uint rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: div.un
    IL_0003: ret

}
long div(long lhs, long rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: div
    IL_0003: ret

}
ulong div(ulong lhs, ulong rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: div.un
    IL_0003: ret

}
ref sbyte div(ref sbyte lhs, in sbyte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i1
    IL_0003: ldarg.1
    IL_0004: ldind.i1
    IL_0005: div
    IL_0006: conv.i1
    IL_0007: stind.i1
    IL_0008: ldarg.0
    IL_0009: ret

}
ref byte div(ref byte lhs, in byte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u1
    IL_0003: ldarg.1
    IL_0004: ldind.u1
    IL_0005: div
    IL_0006: conv.u1
    IL_0007: stind.i1
    IL_0008: ldarg.0
    IL_0009: ret

}
ref short div(ref short lhs, in short rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i2
    IL_0003: ldarg.1
    IL_0004: ldind.i2
    IL_0005: div
    IL_0006: conv.i2
    IL_0007: stind.i2
    IL_0008: ldarg.0
    IL_0009: ret

}
ref ushort div(ref ushort lhs, in ushort rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u2
    IL_0003: ldarg.1
    IL_0004: ldind.u2
    IL_0005: div
    IL_0006: conv.u2
    IL_0007: stind.i2
    IL_0008: ldarg.0
    IL_0009: ret

}
ref int div(ref int lhs, in int rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i4
    IL_0003: ldarg.1
    IL_0004: ldind.i4
    IL_0005: div
    IL_0006: stind.i4
    IL_0007: ldarg.0
    IL_0008: ret

}
ref uint div(ref uint lhs, in uint rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u4
    IL_0003: ldarg.1
    IL_0004: ldind.u4
    IL_0005: div.un
    IL_0006: stind.i4
    IL_0007: ldarg.0
    IL_0008: ret

}
ref long div(ref long lhs, in long rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldarg.1
    IL_0004: ldind.i8
    IL_0005: div
    IL_0006: stind.i8
    IL_0007: ldarg.0
    IL_0008: ret

}
ref ulong div(ref ulong lhs, in ulong rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldarg.1
    IL_0004: ldind.i8
    IL_0005: div.un
    IL_0006: stind.i8
    IL_0007: ldarg.0
    IL_0008: ret

}
bool eq(sbyte lhs, sbyte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ceq
    IL_0004: ret

}
bool eq(byte lhs, byte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ceq
    IL_0004: ret

}
bool eq(short lhs, short rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ceq
    IL_0004: ret

}
bool eq(ushort lhs, ushort rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ceq
    IL_0004: ret

}
bool eq(int lhs, int rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ceq
    IL_0004: ret

}
bool eq(uint lhs, uint rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ceq
    IL_0004: ret

}
bool eq(long lhs, long rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ceq
    IL_0004: ret

}
bool eq(ulong lhs, ulong rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ceq
    IL_0004: ret

}
bool neq(sbyte lhs, sbyte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ceq
    IL_0004: ldc.i4.0
    IL_0005: ceq
    IL_0007: ret

}
bool neq(byte lhs, byte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ceq
    IL_0004: ldc.i4.0
    IL_0005: ceq
    IL_0007: ret

}
bool neq(short lhs, short rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ceq
    IL_0004: ldc.i4.0
    IL_0005: ceq
    IL_0007: ret

}
bool neq(ushort lhs, ushort rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ceq
    IL_0004: ldc.i4.0
    IL_0005: ceq
    IL_0007: ret

}
bool neq(int lhs, int rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ceq
    IL_0004: ldc.i4.0
    IL_0005: ceq
    IL_0007: ret

}
bool neq(uint lhs, uint rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ceq
    IL_0004: ldc.i4.0
    IL_0005: ceq
    IL_0007: ret

}
bool neq(long lhs, long rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ceq
    IL_0004: ldc.i4.0
    IL_0005: ceq
    IL_0007: ret

}
bool neq(ulong lhs, ulong rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ceq
    IL_0004: ldc.i4.0
    IL_0005: ceq
    IL_0007: ret

}
sbyte fma(sbyte x, sbyte y, sbyte z)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: mul
    IL_0003: ldarg.2
    IL_0004: add
    IL_0005: conv.i1
    IL_0006: ret

}
byte fma(byte x, byte y, byte z)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: mul
    IL_0003: ldarg.2
    IL_0004: add
    IL_0005: conv.u1
    IL_0006: ret

}
short fma(short x, short y, short z)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: mul
    IL_0003: ldarg.2
    IL_0004: add
    IL_0005: conv.i2
    IL_0006: ret

}
ushort fma(ushort x, ushort y, ushort z)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: mul
    IL_0003: ldarg.2
    IL_0004: add
    IL_0005: conv.u2
    IL_0006: ret

}
int fma(int x, int y, int z)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: mul
    IL_0003: ldarg.2
    IL_0004: add
    IL_0005: ret

}
uint fma(uint x, uint y, uint z)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: mul
    IL_0003: ldarg.2
    IL_0004: add
    IL_0005: ret

}
long fma(long x, long y, long z)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: mul
    IL_0003: ldarg.2
    IL_0004: add
    IL_0005: ret

}
ulong fma(ulong x, ulong y, ulong z)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: mul
    IL_0003: ldarg.2
    IL_0004: add
    IL_0005: ret

}
sbyte gcd(sbyte lhs, sbyte rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.SByte Z0.math::abs(System.SByte)
    IL_0006: stloc.0
    IL_0007: ldarg.1
    IL_0008: call System.SByte Z0.math::abs(System.SByte)
    IL_000D: stloc.1
    IL_000E: br.s IL_0019
    IL_0010: ldloc.0
    IL_0011: ldloc.1
    IL_0012: rem
    IL_0013: conv.i1
    IL_0014: stloc.2
    IL_0015: ldloc.1
    IL_0016: stloc.0
    IL_0017: ldloc.2
    IL_0018: stloc.1
    IL_0019: ldloc.1
    IL_001A: brtrue.s IL_0010
    IL_001C: ldloc.0
    IL_001D: ret

}
byte gcd(byte lhs, byte rhs)
{
    IL_0000: br.s IL_0010
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: call System.Byte Z0.math::mod(System.Byte,System.Byte)
    IL_0009: stloc.0
    IL_000A: ldarg.1
    IL_000B: starg.s lhs
    IL_000D: ldloc.0
    IL_000E: starg.s rhs
    IL_0010: ldarg.1
    IL_0011: brtrue.s IL_0002
    IL_0013: ldarg.0
    IL_0014: ret

}
short gcd(short lhs, short rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int16 Z0.math::abs(System.Int16)
    IL_0006: stloc.0
    IL_0007: ldarg.1
    IL_0008: call System.Int16 Z0.math::abs(System.Int16)
    IL_000D: stloc.1
    IL_000E: br.s IL_0019
    IL_0010: ldloc.0
    IL_0011: ldloc.1
    IL_0012: rem
    IL_0013: conv.i2
    IL_0014: stloc.2
    IL_0015: ldloc.1
    IL_0016: stloc.0
    IL_0017: ldloc.2
    IL_0018: stloc.1
    IL_0019: ldloc.1
    IL_001A: brtrue.s IL_0010
    IL_001C: ldloc.0
    IL_001D: ret

}
ushort gcd(ushort lhs, ushort rhs)
{
    IL_0000: br.s IL_0010
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: call System.UInt16 Z0.math::mod(System.UInt16,System.UInt16)
    IL_0009: stloc.0
    IL_000A: ldarg.1
    IL_000B: starg.s lhs
    IL_000D: ldloc.0
    IL_000E: starg.s rhs
    IL_0010: ldarg.1
    IL_0011: brtrue.s IL_0002
    IL_0013: ldarg.0
    IL_0014: ret

}
int gcd(int lhs, int rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int32 Z0.math::abs(System.Int32)
    IL_0006: stloc.0
    IL_0007: ldarg.1
    IL_0008: call System.Int32 Z0.math::abs(System.Int32)
    IL_000D: stloc.1
    IL_000E: br.s IL_0018
    IL_0010: ldloc.0
    IL_0011: ldloc.1
    IL_0012: rem
    IL_0013: stloc.2
    IL_0014: ldloc.1
    IL_0015: stloc.0
    IL_0016: ldloc.2
    IL_0017: stloc.1
    IL_0018: ldloc.1
    IL_0019: brtrue.s IL_0010
    IL_001B: ldloc.0
    IL_001C: ret

}
uint gcd(uint lhs, uint rhs)
{
    IL_0000: br.s IL_000C
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: rem.un
    IL_0005: stloc.0
    IL_0006: ldarg.1
    IL_0007: starg.s lhs
    IL_0009: ldloc.0
    IL_000A: starg.s rhs
    IL_000C: ldarg.1
    IL_000D: brtrue.s IL_0002
    IL_000F: ldarg.0
    IL_0010: ret

}
long gcd(long lhs, long rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int64 Z0.math::abs(System.Int64)
    IL_0006: stloc.0
    IL_0007: ldarg.1
    IL_0008: call System.Int64 Z0.math::abs(System.Int64)
    IL_000D: stloc.1
    IL_000E: br.s IL_0018
    IL_0010: ldloc.0
    IL_0011: ldloc.1
    IL_0012: rem
    IL_0013: stloc.2
    IL_0014: ldloc.1
    IL_0015: stloc.0
    IL_0016: ldloc.2
    IL_0017: stloc.1
    IL_0018: ldloc.1
    IL_0019: brtrue.s IL_0010
    IL_001B: ldloc.0
    IL_001C: ret

}
ulong gcd(ulong lhs, ulong rhs)
{
    IL_0000: br.s IL_000C
    IL_0002: ldarg.0
    IL_0003: ldarg.1
    IL_0004: rem.un
    IL_0005: stloc.0
    IL_0006: ldarg.1
    IL_0007: starg.s lhs
    IL_0009: ldloc.0
    IL_000A: starg.s rhs
    IL_000C: ldarg.1
    IL_000D: brtrue.s IL_0002
    IL_000F: ldarg.0
    IL_0010: ret

}
uint gcdbin(uint u, uint v)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: bne.un.s IL_0006
    IL_0004: ldarg.0
    IL_0005: ret
    IL_0006: ldarg.0
    IL_0007: brtrue.s IL_000B
    IL_0009: ldarg.1
    IL_000A: ret
    IL_000B: ldarg.1
    IL_000C: brtrue.s IL_0010
    IL_000E: ldarg.0
    IL_000F: ret
    IL_0010: ldarg.0
    IL_0011: not
    IL_0012: ldc.i4.1
    IL_0013: and
    IL_0014: brfalse.s IL_0033
    IL_0016: ldarg.1
    IL_0017: ldc.i4.1
    IL_0018: and
    IL_0019: brfalse.s IL_0025
    IL_001B: ldarg.0
    IL_001C: ldc.i4.1
    IL_001D: shr.un
    IL_001E: ldarg.1
    IL_001F: call System.UInt32 Z0.math::gcdbin(System.UInt32,System.UInt32)
    IL_0024: ret
    IL_0025: ldarg.0
    IL_0026: ldc.i4.1
    IL_0027: shr.un
    IL_0028: ldarg.1
    IL_0029: ldc.i4.1
    IL_002A: shr.un
    IL_002B: call System.UInt32 Z0.math::gcdbin(System.UInt32,System.UInt32)
    IL_0030: ldc.i4.1
    IL_0031: shl
    IL_0032: ret
    IL_0033: ldarg.1
    IL_0034: not
    IL_0035: ldc.i4.1
    IL_0036: and
    IL_0037: brfalse.s IL_0043
    IL_0039: ldarg.0
    IL_003A: ldarg.1
    IL_003B: ldc.i4.1
    IL_003C: shr.un
    IL_003D: call System.UInt32 Z0.math::gcdbin(System.UInt32,System.UInt32)
    IL_0042: ret
    IL_0043: ldarg.0
    IL_0044: ldarg.1
    IL_0045: ble.un.s IL_0053
    IL_0047: ldarg.0
    IL_0048: ldarg.1
    IL_0049: sub
    IL_004A: ldc.i4.1
    IL_004B: shr.un
    IL_004C: ldarg.1
    IL_004D: call System.UInt32 Z0.math::gcdbin(System.UInt32,System.UInt32)
    IL_0052: ret
    IL_0053: ldarg.1
    IL_0054: ldarg.0
    IL_0055: sub
    IL_0056: ldc.i4.1
    IL_0057: shr.un
    IL_0058: ldarg.0
    IL_0059: call System.UInt32 Z0.math::gcdbin(System.UInt32,System.UInt32)
    IL_005E: ret

}
ulong gcdbin(ulong u, ulong v)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: bne.un.s IL_0006
    IL_0004: ldarg.0
    IL_0005: ret
    IL_0006: ldarg.0
    IL_0007: brtrue.s IL_000B
    IL_0009: ldarg.1
    IL_000A: ret
    IL_000B: ldarg.1
    IL_000C: brtrue.s IL_0010
    IL_000E: ldarg.0
    IL_000F: ret
    IL_0010: ldarg.0
    IL_0011: not
    IL_0012: ldc.i4.1
    IL_0013: conv.i8
    IL_0014: and
    IL_0015: brfalse.s IL_0035
    IL_0017: ldarg.1
    IL_0018: ldc.i4.1
    IL_0019: conv.i8
    IL_001A: and
    IL_001B: brfalse.s IL_0027
    IL_001D: ldarg.0
    IL_001E: ldc.i4.1
    IL_001F: shr.un
    IL_0020: ldarg.1
    IL_0021: call System.UInt64 Z0.math::gcdbin(System.UInt64,System.UInt64)
    IL_0026: ret
    IL_0027: ldarg.0
    IL_0028: ldc.i4.1
    IL_0029: shr.un
    IL_002A: ldarg.1
    IL_002B: ldc.i4.1
    IL_002C: shr.un
    IL_002D: call System.UInt64 Z0.math::gcdbin(System.UInt64,System.UInt64)
    IL_0032: ldc.i4.1
    IL_0033: shl
    IL_0034: ret
    IL_0035: ldarg.1
    IL_0036: not
    IL_0037: ldc.i4.1
    IL_0038: conv.i8
    IL_0039: and
    IL_003A: brfalse.s IL_0046
    IL_003C: ldarg.0
    IL_003D: ldarg.1
    IL_003E: ldc.i4.1
    IL_003F: shr.un
    IL_0040: call System.UInt64 Z0.math::gcdbin(System.UInt64,System.UInt64)
    IL_0045: ret
    IL_0046: ldarg.0
    IL_0047: ldarg.1
    IL_0048: ble.un.s IL_0056
    IL_004A: ldarg.0
    IL_004B: ldarg.1
    IL_004C: sub
    IL_004D: ldc.i4.1
    IL_004E: shr.un
    IL_004F: ldarg.1
    IL_0050: call System.UInt64 Z0.math::gcdbin(System.UInt64,System.UInt64)
    IL_0055: ret
    IL_0056: ldarg.1
    IL_0057: ldarg.0
    IL_0058: sub
    IL_0059: ldc.i4.1
    IL_005A: shr.un
    IL_005B: ldarg.0
    IL_005C: call System.UInt64 Z0.math::gcdbin(System.UInt64,System.UInt64)
    IL_0061: ret

}
byte gcdbin(byte u, byte v)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.math::gcdbin(System.UInt32,System.UInt32)
    IL_0007: conv.u1
    IL_0008: ret

}
ushort gcdbin(ushort u, ushort v)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.math::gcdbin(System.UInt32,System.UInt32)
    IL_0007: conv.u2
    IL_0008: ret

}
bool gt(sbyte lhs, sbyte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: cgt
    IL_0004: ret

}
bool gt(byte lhs, byte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: cgt
    IL_0004: ret

}
bool gt(short lhs, short rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: cgt
    IL_0004: ret

}
bool gt(ushort lhs, ushort rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: cgt
    IL_0004: ret

}
bool gt(int lhs, int rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: cgt
    IL_0004: ret

}
bool gt(uint lhs, uint rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: cgt.un
    IL_0004: ret

}
bool gt(long lhs, long rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: cgt
    IL_0004: ret

}
bool gt(ulong lhs, ulong rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: cgt.un
    IL_0004: ret

}
bool gteq(sbyte lhs, sbyte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: clt
    IL_0004: ldc.i4.0
    IL_0005: ceq
    IL_0007: ret

}
bool gteq(byte lhs, byte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: clt
    IL_0004: ldc.i4.0
    IL_0005: ceq
    IL_0007: ret

}
bool gteq(short lhs, short rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: clt
    IL_0004: ldc.i4.0
    IL_0005: ceq
    IL_0007: ret

}
bool gteq(ushort lhs, ushort rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: clt
    IL_0004: ldc.i4.0
    IL_0005: ceq
    IL_0007: ret

}
bool gteq(int lhs, int rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: clt
    IL_0004: ldc.i4.0
    IL_0005: ceq
    IL_0007: ret

}
bool gteq(uint lhs, uint rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: clt.un
    IL_0004: ldc.i4.0
    IL_0005: ceq
    IL_0007: ret

}
bool gteq(long lhs, long rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: clt
    IL_0004: ldc.i4.0
    IL_0005: ceq
    IL_0007: ret

}
bool gteq(ulong lhs, ulong rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: clt.un
    IL_0004: ldc.i4.0
    IL_0005: ceq
    IL_0007: ret

}
sbyte inc(sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0002: add
    IL_0003: conv.i1
    IL_0004: dup
    IL_0005: starg.s src
    IL_0007: ret

}
byte inc(byte src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0002: add
    IL_0003: conv.u1
    IL_0004: dup
    IL_0005: starg.s src
    IL_0007: ret

}
short inc(short src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0002: add
    IL_0003: conv.i2
    IL_0004: dup
    IL_0005: starg.s src
    IL_0007: ret

}
ushort inc(ushort src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0002: add
    IL_0003: conv.u2
    IL_0004: dup
    IL_0005: starg.s src
    IL_0007: ret

}
int inc(int src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0002: add
    IL_0003: dup
    IL_0004: starg.s src
    IL_0006: ret

}
uint inc(uint src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0002: add
    IL_0003: dup
    IL_0004: starg.s src
    IL_0006: ret

}
long inc(long src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0002: conv.i8
    IL_0003: add
    IL_0004: dup
    IL_0005: starg.s src
    IL_0007: ret

}
ulong inc(ulong src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0002: conv.i8
    IL_0003: add
    IL_0004: dup
    IL_0005: starg.s src
    IL_0007: ret

}
ref sbyte inc(ref sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i1
    IL_0003: ldc.i4.1
    IL_0004: add
    IL_0005: conv.i1
    IL_0006: stind.i1
    IL_0007: ldarg.0
    IL_0008: ret

}
ref byte inc(ref byte src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u1
    IL_0003: ldc.i4.1
    IL_0004: add
    IL_0005: conv.u1
    IL_0006: stind.i1
    IL_0007: ldarg.0
    IL_0008: ret

}
ref short inc(ref short src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i2
    IL_0003: ldc.i4.1
    IL_0004: add
    IL_0005: conv.i2
    IL_0006: stind.i2
    IL_0007: ldarg.0
    IL_0008: ret

}
ref ushort inc(ref ushort src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u2
    IL_0003: ldc.i4.1
    IL_0004: add
    IL_0005: conv.u2
    IL_0006: stind.i2
    IL_0007: ldarg.0
    IL_0008: ret

}
ref int inc(ref int src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i4
    IL_0003: ldc.i4.1
    IL_0004: add
    IL_0005: stind.i4
    IL_0006: ldarg.0
    IL_0007: ret

}
ref uint inc(ref uint src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u4
    IL_0003: ldc.i4.1
    IL_0004: add
    IL_0005: stind.i4
    IL_0006: ldarg.0
    IL_0007: ret

}
ref long inc(ref long src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldc.i4.1
    IL_0004: conv.i8
    IL_0005: add
    IL_0006: stind.i8
    IL_0007: ldarg.0
    IL_0008: ret

}
ref ulong inc(ref ulong src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldc.i4.1
    IL_0004: conv.i8
    IL_0005: add
    IL_0006: stind.i8
    IL_0007: ldarg.0
    IL_0008: ret

}
bool isPow2(sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldc.i4.1
    IL_0003: sub
    IL_0004: and
    IL_0005: ldc.i4.0
    IL_0006: ceq
    IL_0008: ret

}
bool isPow2(byte src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldc.i4.1
    IL_0003: sub
    IL_0004: and
    IL_0005: ldc.i4.0
    IL_0006: ceq
    IL_0008: ret

}
bool isPow2(short src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldc.i4.1
    IL_0003: sub
    IL_0004: and
    IL_0005: ldc.i4.0
    IL_0006: ceq
    IL_0008: ret

}
bool isPow2(ushort src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldc.i4.1
    IL_0003: sub
    IL_0004: and
    IL_0005: ldc.i4.0
    IL_0006: ceq
    IL_0008: ret

}
bool isPow2(int src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldc.i4.1
    IL_0003: sub
    IL_0004: and
    IL_0005: ldc.i4.0
    IL_0006: ceq
    IL_0008: ret

}
bool isPow2(uint src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldc.i4.1
    IL_0003: sub
    IL_0004: and
    IL_0005: ldc.i4.0
    IL_0006: ceq
    IL_0008: ret

}
bool isPow2(long src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldc.i4.1
    IL_0003: conv.i8
    IL_0004: sub
    IL_0005: and
    IL_0006: ldc.i4.0
    IL_0007: conv.i8
    IL_0008: ceq
    IL_000A: ret

}
bool isPow2(ulong src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldc.i4.1
    IL_0003: conv.i8
    IL_0004: sub
    IL_0005: and
    IL_0006: ldc.i4.0
    IL_0007: conv.i8
    IL_0008: ceq
    IL_000A: ret

}
ref ulong log2(ref ulong dst, ref ulong x, ulong power)
{
    IL_0000: ldarg.1
    IL_0001: ldind.i8
    IL_0002: ldc.i4.1
    IL_0003: conv.i8
    IL_0004: ldarg.2
    IL_0005: conv.i4
    IL_0006: ldc.i4.s 63
    IL_0008: and
    IL_0009: shl
    IL_000A: blt.un.s IL_001C
    IL_000C: ldarg.1
    IL_000D: ldarg.1
    IL_000E: ldind.i8
    IL_000F: ldarg.2
    IL_0010: conv.i4
    IL_0011: ldc.i4.s 63
    IL_0013: and
    IL_0014: shr.un
    IL_0015: stind.i8
    IL_0016: ldarg.0
    IL_0017: ldarg.0
    IL_0018: ldind.i8
    IL_0019: ldarg.2
    IL_001A: or
    IL_001B: stind.i8
    IL_001C: ldarg.0
    IL_001D: ret

}
ulong log2(ulong src)
{
    IL_0000: ldc.i4.0
    IL_0001: conv.i8
    IL_0002: stloc.0
    IL_0003: ldarg.0
    IL_0004: stloc.1
    IL_0005: ldloca.s V_0
    IL_0007: ldloca.s V_1
    IL_0009: ldc.i4.s 32
    IL_000B: conv.i8
    IL_000C: call System.UInt64& Z0.math::log2(System.UInt64&,System.UInt64&,System.UInt64)
    IL_0011: pop
    IL_0012: ldloca.s V_0
    IL_0014: ldloca.s V_1
    IL_0016: ldc.i4.s 16
    IL_0018: conv.i8
    IL_0019: call System.UInt64& Z0.math::log2(System.UInt64&,System.UInt64&,System.UInt64)
    IL_001E: pop
    IL_001F: ldloca.s V_0
    IL_0021: ldloca.s V_1
    IL_0023: ldc.i4.8
    IL_0024: conv.i8
    IL_0025: call System.UInt64& Z0.math::log2(System.UInt64&,System.UInt64&,System.UInt64)
    IL_002A: pop
    IL_002B: ldloca.s V_0
    IL_002D: ldloca.s V_1
    IL_002F: ldc.i4.4
    IL_0030: conv.i8
    IL_0031: call System.UInt64& Z0.math::log2(System.UInt64&,System.UInt64&,System.UInt64)
    IL_0036: pop
    IL_0037: ldloca.s V_0
    IL_0039: ldloca.s V_1
    IL_003B: ldc.i4.2
    IL_003C: conv.i8
    IL_003D: call System.UInt64& Z0.math::log2(System.UInt64&,System.UInt64&,System.UInt64)
    IL_0042: pop
    IL_0043: ldloc.1
    IL_0044: ldc.i4.2
    IL_0045: conv.i8
    IL_0046: blt.un.s IL_004D
    IL_0048: ldloc.0
    IL_0049: ldc.i4.1
    IL_004A: conv.i8
    IL_004B: or
    IL_004C: stloc.0
    IL_004D: ldloc.0
    IL_004E: ret

}
ulong log2(int src)
{
    IL_0000: ldarg.0
    IL_0001: conv.i8
    IL_0002: call System.UInt64 Z0.math::log2(System.UInt64)
    IL_0007: ret

}
uint log2(uint src)
{
    IL_0000: ldarg.0
    IL_0001: conv.u8
    IL_0002: call System.UInt64 Z0.math::log2(System.UInt64)
    IL_0007: conv.u4
    IL_0008: ret

}
byte log2(byte src)
{
    IL_0000: ldarg.0
    IL_0001: conv.u8
    IL_0002: call System.UInt64 Z0.math::log2(System.UInt64)
    IL_0007: conv.u1
    IL_0008: ret

}
ushort log2(ushort src)
{
    IL_0000: ldarg.0
    IL_0001: conv.u8
    IL_0002: call System.UInt64 Z0.math::log2(System.UInt64)
    IL_0007: conv.u2
    IL_0008: ret

}
bool lt(sbyte lhs, sbyte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: clt
    IL_0004: ret

}
bool lt(byte lhs, byte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: clt
    IL_0004: ret

}
bool lt(short lhs, short rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: clt
    IL_0004: ret

}
bool lt(ushort lhs, ushort rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: clt
    IL_0004: ret

}
bool lt(int lhs, int rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: clt
    IL_0004: ret

}
bool lt(uint lhs, uint rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: clt.un
    IL_0004: ret

}
bool lt(long lhs, long rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: clt
    IL_0004: ret

}
bool lt(ulong lhs, ulong rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: clt.un
    IL_0004: ret

}
bool lteq(sbyte lhs, sbyte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: cgt
    IL_0004: ldc.i4.0
    IL_0005: ceq
    IL_0007: ret

}
bool lteq(byte lhs, byte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: cgt
    IL_0004: ldc.i4.0
    IL_0005: ceq
    IL_0007: ret

}
bool lteq(short lhs, short rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: cgt
    IL_0004: ldc.i4.0
    IL_0005: ceq
    IL_0007: ret

}
bool lteq(ushort lhs, ushort rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: cgt
    IL_0004: ldc.i4.0
    IL_0005: ceq
    IL_0007: ret

}
bool lteq(int lhs, int rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: cgt
    IL_0004: ldc.i4.0
    IL_0005: ceq
    IL_0007: ret

}
bool lteq(uint lhs, uint rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: cgt.un
    IL_0004: ldc.i4.0
    IL_0005: ceq
    IL_0007: ret

}
bool lteq(long lhs, long rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: cgt
    IL_0004: ldc.i4.0
    IL_0005: ceq
    IL_0007: ret

}
bool lteq(ulong lhs, ulong rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: cgt.un
    IL_0004: ldc.i4.0
    IL_0005: ceq
    IL_0007: ret

}
sbyte max(sbyte lhs, sbyte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: bgt.s IL_0006
    IL_0004: ldarg.1
    IL_0005: ret
    IL_0006: ldarg.0
    IL_0007: ret

}
byte max(byte lhs, byte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: bgt.s IL_0006
    IL_0004: ldarg.1
    IL_0005: ret
    IL_0006: ldarg.0
    IL_0007: ret

}
short max(short lhs, short rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: bgt.s IL_0006
    IL_0004: ldarg.1
    IL_0005: ret
    IL_0006: ldarg.0
    IL_0007: ret

}
ushort max(ushort lhs, ushort rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: bgt.s IL_0006
    IL_0004: ldarg.1
    IL_0005: ret
    IL_0006: ldarg.0
    IL_0007: ret

}
int max(int lhs, int rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: bgt.s IL_0006
    IL_0004: ldarg.1
    IL_0005: ret
    IL_0006: ldarg.0
    IL_0007: ret

}
uint max(uint lhs, uint rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: bgt.un.s IL_0006
    IL_0004: ldarg.1
    IL_0005: ret
    IL_0006: ldarg.0
    IL_0007: ret

}
long max(long lhs, long rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: bgt.s IL_0006
    IL_0004: ldarg.1
    IL_0005: ret
    IL_0006: ldarg.0
    IL_0007: ret

}
short srl(short src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Int32 Z0.math::srl32i(System.Int32,System.Int32)
    IL_0007: conv.i2
    IL_0008: ret

}
ushort srl(ushort src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.math::srl32u(System.UInt32,System.Int32)
    IL_0007: conv.u2
    IL_0008: ret

}
int srl(int src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Int32 Z0.math::srl32i(System.Int32,System.Int32)
    IL_0007: ret

}
uint srl(uint src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.math::srl32u(System.UInt32,System.Int32)
    IL_0007: ret

}
long srl(long src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Int64 Z0.math::srl64i(System.Int64,System.Int32)
    IL_0007: ret

}
ulong srl(ulong src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.math::srl64u(System.UInt64,System.Int32)
    IL_0007: ret

}
ref sbyte srl(ref sbyte src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i1
    IL_0003: ldarg.1
    IL_0004: call System.SByte Z0.math::srl(System.SByte,System.Int32)
    IL_0009: stind.i1
    IL_000A: ldarg.0
    IL_000B: ret

}
ref byte srl(ref byte src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u1
    IL_0003: ldarg.1
    IL_0004: call System.Byte Z0.math::srl(System.Byte,System.Int32)
    IL_0009: stind.i1
    IL_000A: ldarg.0
    IL_000B: ret

}
ref short srl(ref short src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i2
    IL_0003: ldarg.1
    IL_0004: call System.Int16 Z0.math::srl(System.Int16,System.Int32)
    IL_0009: stind.i2
    IL_000A: ldarg.0
    IL_000B: ret

}
ref ushort srl(ref ushort src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u2
    IL_0003: ldarg.1
    IL_0004: call System.UInt16 Z0.math::srl(System.UInt16,System.Int32)
    IL_0009: stind.i2
    IL_000A: ldarg.0
    IL_000B: ret

}
ref int srl(ref int src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i4
    IL_0003: ldarg.1
    IL_0004: call System.Int32 Z0.math::srl(System.Int32,System.Int32)
    IL_0009: stind.i4
    IL_000A: ldarg.0
    IL_000B: ret

}
ref uint srl(ref uint src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u4
    IL_0003: ldarg.1
    IL_0004: call System.UInt32 Z0.math::srl(System.UInt32,System.Int32)
    IL_0009: stind.i4
    IL_000A: ldarg.0
    IL_000B: ret

}
ref long srl(ref long src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldarg.1
    IL_0004: call System.Int64 Z0.math::srl(System.Int64,System.Int32)
    IL_0009: stind.i8
    IL_000A: ldarg.0
    IL_000B: ret

}
ref ulong srl(ref ulong src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldarg.1
    IL_0004: call System.UInt64 Z0.math::srl(System.UInt64,System.Int32)
    IL_0009: stind.i8
    IL_000A: ldarg.0
    IL_000B: ret

}
int srl32i(int src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 31
    IL_0004: and
    IL_0005: shr.un
    IL_0006: ret

}
uint srl32u(uint src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 31
    IL_0004: and
    IL_0005: shr.un
    IL_0006: ret

}
long srl64i(long src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 63
    IL_0004: and
    IL_0005: shr.un
    IL_0006: ret

}
ulong srl64u(ulong src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 63
    IL_0004: and
    IL_0005: shr.un
    IL_0006: ret

}
uint xnor(uint a, uint b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: xor
    IL_0003: not
    IL_0004: ret

}
ulong xnor(ulong a, ulong b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: xor
    IL_0003: not
    IL_0004: ret

}
byte xnor(byte a, byte b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.math::xnor(System.UInt32,System.UInt32)
    IL_0007: conv.u1
    IL_0008: ret

}
ushort xnor(ushort a, ushort b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.math::xnor(System.UInt32,System.UInt32)
    IL_0007: conv.u2
    IL_0008: ret

}
sbyte xor(sbyte lhs, sbyte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: xor
    IL_0003: conv.i1
    IL_0004: ret

}
byte xor(byte lhs, byte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: xor
    IL_0003: conv.u1
    IL_0004: ret

}
short xor(short lhs, short rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: xor
    IL_0003: conv.i2
    IL_0004: ret

}
ushort xor(ushort lhs, ushort rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: xor
    IL_0003: conv.u2
    IL_0004: ret

}
int xor(int lhs, int rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: xor
    IL_0003: ret

}
uint xor(uint lhs, uint rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: xor
    IL_0003: ret

}
long xor(long lhs, long rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: xor
    IL_0003: ret

}
ulong xor(ulong lhs, ulong rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: xor
    IL_0003: ret

}
ref sbyte xor(ref sbyte lhs, sbyte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i1
    IL_0003: ldarg.1
    IL_0004: xor
    IL_0005: conv.i1
    IL_0006: stind.i1
    IL_0007: ldarg.0
    IL_0008: ret

}
ref byte xor(ref byte lhs, byte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u1
    IL_0003: ldarg.1
    IL_0004: xor
    IL_0005: conv.u1
    IL_0006: stind.i1
    IL_0007: ldarg.0
    IL_0008: ret

}
ref short xor(ref short lhs, short rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i2
    IL_0003: ldarg.1
    IL_0004: xor
    IL_0005: conv.i2
    IL_0006: stind.i2
    IL_0007: ldarg.0
    IL_0008: ret

}
ref ushort xor(ref ushort lhs, ushort rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u2
    IL_0003: ldarg.1
    IL_0004: xor
    IL_0005: conv.u2
    IL_0006: stind.i2
    IL_0007: ldarg.0
    IL_0008: ret

}
ref int xor(ref int lhs, int rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i4
    IL_0003: ldarg.1
    IL_0004: xor
    IL_0005: stind.i4
    IL_0006: ldarg.0
    IL_0007: ret

}
ref uint xor(ref uint lhs, uint rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u4
    IL_0003: ldarg.1
    IL_0004: xor
    IL_0005: stind.i4
    IL_0006: ldarg.0
    IL_0007: ret

}
ref long xor(ref long lhs, long rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldarg.1
    IL_0004: xor
    IL_0005: stind.i8
    IL_0006: ldarg.0
    IL_0007: ret

}
ref ulong xor(ref ulong lhs, ulong rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldarg.1
    IL_0004: xor
    IL_0005: stind.i8
    IL_0006: ldarg.0
    IL_0007: ret

}
ref sbyte xor(in sbyte lhs, in sbyte rhs, ref sbyte dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: ldind.i1
    IL_0003: ldarg.1
    IL_0004: ldind.i1
    IL_0005: xor
    IL_0006: conv.i1
    IL_0007: stind.i1
    IL_0008: ldarg.2
    IL_0009: ret

}
ref byte xor(in byte lhs, in byte rhs, ref byte dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: ldind.u1
    IL_0003: ldarg.1
    IL_0004: ldind.u1
    IL_0005: xor
    IL_0006: conv.u1
    IL_0007: stind.i1
    IL_0008: ldarg.2
    IL_0009: ret

}
ref short xor(in short lhs, in short rhs, ref short dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: ldind.i2
    IL_0003: ldarg.1
    IL_0004: ldind.i2
    IL_0005: xor
    IL_0006: conv.i2
    IL_0007: stind.i2
    IL_0008: ldarg.2
    IL_0009: ret

}
ref ushort xor(in ushort lhs, in ushort rhs, ref ushort dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: ldind.u2
    IL_0003: ldarg.1
    IL_0004: ldind.u2
    IL_0005: xor
    IL_0006: conv.u2
    IL_0007: stind.i2
    IL_0008: ldarg.2
    IL_0009: ret

}
ref int xor(in int lhs, in int rhs, ref int dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: ldind.i4
    IL_0003: ldarg.1
    IL_0004: ldind.i4
    IL_0005: xor
    IL_0006: stind.i4
    IL_0007: ldarg.2
    IL_0008: ret

}
ref uint xor(in uint lhs, in uint rhs, ref uint dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: ldind.u4
    IL_0003: ldarg.1
    IL_0004: ldind.u4
    IL_0005: xor
    IL_0006: stind.i4
    IL_0007: ldarg.2
    IL_0008: ret

}
ref long xor(in long lhs, in long rhs, ref long dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldarg.1
    IL_0004: ldind.i8
    IL_0005: xor
    IL_0006: stind.i8
    IL_0007: ldarg.2
    IL_0008: ret

}
ref ulong xor(in ulong lhs, in ulong rhs, ref ulong dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldarg.1
    IL_0004: ldind.i8
    IL_0005: xor
    IL_0006: stind.i8
    IL_0007: ldarg.2
    IL_0008: ret

}
ref float xor(in float lhs, in float rhs, ref float dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: ldind.r4
    IL_0003: call System.Int32 Z0.MathX::ToBits(System.Single)
    IL_0008: ldarg.1
    IL_0009: ldind.r4
    IL_000A: call System.Int32 Z0.MathX::ToBits(System.Single)
    IL_000F: xor
    IL_0010: call System.Single System.BitConverter::Int32BitsToSingle(System.Int32)
    IL_0015: stind.r4
    IL_0016: ldarg.2
    IL_0017: ret

}
ref double xor(in double lhs, in double rhs, ref double dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: ldind.r8
    IL_0003: call System.Int64 Z0.MathX::ToBits(System.Double)
    IL_0008: ldarg.1
    IL_0009: ldind.r8
    IL_000A: call System.Int64 Z0.MathX::ToBits(System.Double)
    IL_000F: xor
    IL_0010: call System.Double System.BitConverter::Int64BitsToDouble(System.Int64)
    IL_0015: stind.r8
    IL_0016: ldarg.2
    IL_0017: ret

}
sbyte xor1(sbyte a)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4 255
    IL_0006: xor
    IL_0007: conv.i1
    IL_0008: ret

}
byte xor1(byte a)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4 255
    IL_0006: xor
    IL_0007: conv.u1
    IL_0008: ret

}
short xor1(short a)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4 65535
    IL_0006: xor
    IL_0007: conv.i2
    IL_0008: ret

}
ushort xor1(ushort a)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4 65535
    IL_0006: xor
    IL_0007: conv.u2
    IL_0008: ret

}
int xor1(int a)
{
    IL_0000: ldarg.0
    IL_0001: conv.i8
    IL_0002: ldc.i4.m1
    IL_0003: conv.u8
    IL_0004: xor
    IL_0005: conv.i4
    IL_0006: ret

}
uint xor1(uint a)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0002: xor
    IL_0003: ret

}
long xor1(long a)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0002: conv.i8
    IL_0003: xor
    IL_0004: ret

}
ulong xor1(ulong a)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.m1
    IL_0002: conv.i8
    IL_0003: xor
    IL_0004: ret

}
bool divides(sbyte lhs, sbyte rhs)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: rem
    IL_0003: ldc.i4.0
    IL_0004: ceq
    IL_0006: ret

}
bool divides(byte lhs, byte rhs)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: rem
    IL_0003: ldc.i4.0
    IL_0004: ceq
    IL_0006: ret

}
bool divides(short lhs, short rhs)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: rem
    IL_0003: ldc.i4.0
    IL_0004: ceq
    IL_0006: ret

}
bool divides(ushort lhs, ushort rhs)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: rem
    IL_0003: ldc.i4.0
    IL_0004: ceq
    IL_0006: ret

}
bool divides(int lhs, int rhs)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: rem
    IL_0003: ldc.i4.0
    IL_0004: ceq
    IL_0006: ret

}
bool divides(uint lhs, uint rhs)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: rem.un
    IL_0003: ldc.i4.0
    IL_0004: ceq
    IL_0006: ret

}
bool divides(long lhs, long rhs)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: rem
    IL_0003: ldc.i4.0
    IL_0004: conv.i8
    IL_0005: ceq
    IL_0007: ret

}
bool divides(ulong lhs, ulong rhs)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: rem.un
    IL_0003: ldc.i4.0
    IL_0004: conv.i8
    IL_0005: ceq
    IL_0007: ret

}
sbyte abs(sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldc.i4.7
    IL_0003: shr
    IL_0004: add
    IL_0005: ldarg.0
    IL_0006: ldc.i4.7
    IL_0007: shr
    IL_0008: xor
    IL_0009: conv.i1
    IL_000A: ret

}
short abs(short src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldc.i4.s 15
    IL_0004: shr
    IL_0005: add
    IL_0006: ldarg.0
    IL_0007: ldc.i4.s 15
    IL_0009: shr
    IL_000A: xor
    IL_000B: conv.i2
    IL_000C: ret

}
int abs(int src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldc.i4.s 31
    IL_0004: shr
    IL_0005: add
    IL_0006: ldarg.0
    IL_0007: ldc.i4.s 31
    IL_0009: shr
    IL_000A: xor
    IL_000B: ret

}
long abs(long src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldc.i4.s 63
    IL_0004: shr
    IL_0005: add
    IL_0006: ldarg.0
    IL_0007: ldc.i4.s 63
    IL_0009: shr
    IL_000A: xor
    IL_000B: ret

}
float abs(float src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Single System.MathF::Abs(System.Single)
    IL_0006: ret

}
double abs(double src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Double System.Math::Abs(System.Double)
    IL_0006: ret

}
ref sbyte abs(ref sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i1
    IL_0003: call System.SByte Z0.math::abs(System.SByte)
    IL_0008: stind.i1
    IL_0009: ldarg.0
    IL_000A: ret

}
ref short abs(ref short src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i2
    IL_0003: call System.Int16 Z0.math::abs(System.Int16)
    IL_0008: stind.i2
    IL_0009: ldarg.0
    IL_000A: ret

}
ref int abs(ref int src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i4
    IL_0003: call System.Int32 Z0.math::abs(System.Int32)
    IL_0008: stind.i4
    IL_0009: ldarg.0
    IL_000A: ret

}
ref long abs(ref long src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: call System.Int64 Z0.math::abs(System.Int64)
    IL_0008: stind.i8
    IL_0009: ldarg.0
    IL_000A: ret

}
sbyte add(sbyte lhs, sbyte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: add
    IL_0003: conv.i1
    IL_0004: ret

}
byte add(byte lhs, byte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: add
    IL_0003: conv.u1
    IL_0004: ret

}
UInt8 add(UInt8 lhs, UInt8 rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.UInt8 Z0.UInt8::op_Addition(Z0.UInt8,Z0.UInt8)
    IL_0007: ret

}
short add(short lhs, short rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: add
    IL_0003: conv.i2
    IL_0004: ret

}
ushort add(ushort lhs, ushort rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: add
    IL_0003: conv.u2
    IL_0004: ret

}
int add(int lhs, int rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: add
    IL_0003: ret

}
uint add(uint lhs, uint rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: add
    IL_0003: ret

}
long add(long lhs, long rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: add
    IL_0003: ret

}
ulong add(ulong lhs, ulong rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: add
    IL_0003: ret

}
ref sbyte add(ref sbyte lhs, sbyte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i1
    IL_0003: ldarg.1
    IL_0004: add
    IL_0005: conv.i1
    IL_0006: stind.i1
    IL_0007: ldarg.0
    IL_0008: ret

}
ref byte add(ref byte lhs, byte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u1
    IL_0003: ldarg.1
    IL_0004: add
    IL_0005: conv.u1
    IL_0006: stind.i1
    IL_0007: ldarg.0
    IL_0008: ret

}
ref short add(ref short lhs, short rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i2
    IL_0003: ldarg.1
    IL_0004: add
    IL_0005: conv.i2
    IL_0006: stind.i2
    IL_0007: ldarg.0
    IL_0008: ret

}
ref ushort add(ref ushort lhs, ushort rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u2
    IL_0003: ldarg.1
    IL_0004: add
    IL_0005: conv.u2
    IL_0006: stind.i2
    IL_0007: ldarg.0
    IL_0008: ret

}
ref int add(ref int lhs, int rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i4
    IL_0003: ldarg.1
    IL_0004: add
    IL_0005: stind.i4
    IL_0006: ldarg.0
    IL_0007: ret

}
ref uint add(ref uint lhs, uint rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u4
    IL_0003: ldarg.1
    IL_0004: add
    IL_0005: stind.i4
    IL_0006: ldarg.0
    IL_0007: ret

}
ref long add(ref long lhs, long rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldarg.1
    IL_0004: add
    IL_0005: stind.i8
    IL_0006: ldarg.0
    IL_0007: ret

}
ref ulong add(ref ulong lhs, ulong rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldarg.1
    IL_0004: add
    IL_0005: stind.i8
    IL_0006: ldarg.0
    IL_0007: ret

}
byte avgz(byte lhs, byte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: and
    IL_0003: ldarg.0
    IL_0004: ldarg.1
    IL_0005: xor
    IL_0006: ldc.i4.1
    IL_0007: shr
    IL_0008: add
    IL_0009: conv.u1
    IL_000A: ret

}
ushort avgz(ushort lhs, ushort rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: and
    IL_0003: ldarg.0
    IL_0004: ldarg.1
    IL_0005: xor
    IL_0006: ldc.i4.1
    IL_0007: shr
    IL_0008: add
    IL_0009: conv.u2
    IL_000A: ret

}
uint avgz(uint lhs, uint rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: and
    IL_0003: ldarg.0
    IL_0004: ldarg.1
    IL_0005: xor
    IL_0006: ldc.i4.1
    IL_0007: shr.un
    IL_0008: add
    IL_0009: ret

}
ulong avgz(ulong lhs, ulong rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: and
    IL_0003: ldarg.0
    IL_0004: ldarg.1
    IL_0005: xor
    IL_0006: ldc.i4.1
    IL_0007: shr.un
    IL_0008: add
    IL_0009: ret

}
ref byte avgz(ref byte lhs, in byte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u1
    IL_0003: ldarg.1
    IL_0004: ldind.u1
    IL_0005: call System.Byte Z0.math::avgz(System.Byte,System.Byte)
    IL_000A: stind.i1
    IL_000B: ldarg.0
    IL_000C: ret

}
ref ushort avgz(ref ushort lhs, in ushort rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u2
    IL_0003: ldarg.1
    IL_0004: ldind.u2
    IL_0005: call System.UInt16 Z0.math::avgz(System.UInt16,System.UInt16)
    IL_000A: stind.i2
    IL_000B: ldarg.0
    IL_000C: ret

}
ref uint avgz(ref uint lhs, in uint rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u4
    IL_0003: ldarg.1
    IL_0004: ldind.u4
    IL_0005: call System.UInt32 Z0.math::avgz(System.UInt32,System.UInt32)
    IL_000A: stind.i4
    IL_000B: ldarg.0
    IL_000C: ret

}
ref ulong avgz(ref ulong lhs, in ulong rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldarg.1
    IL_0004: ldind.i8
    IL_0005: call System.UInt64 Z0.math::avgz(System.UInt64,System.UInt64)
    IL_000A: stind.i8
    IL_000B: ldarg.0
    IL_000C: ret

}
byte avgi(byte lhs, byte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: or
    IL_0003: ldarg.0
    IL_0004: ldarg.1
    IL_0005: xor
    IL_0006: ldc.i4.1
    IL_0007: shr
    IL_0008: sub
    IL_0009: conv.u1
    IL_000A: ret

}
ushort avgi(ushort lhs, ushort rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: or
    IL_0003: ldarg.0
    IL_0004: ldarg.1
    IL_0005: xor
    IL_0006: ldc.i4.1
    IL_0007: shr
    IL_0008: sub
    IL_0009: conv.u2
    IL_000A: ret

}
uint avgi(uint lhs, uint rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: or
    IL_0003: ldarg.0
    IL_0004: ldarg.1
    IL_0005: xor
    IL_0006: ldc.i4.1
    IL_0007: shr.un
    IL_0008: sub
    IL_0009: ret

}
ulong avgi(ulong lhs, ulong rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: or
    IL_0003: ldarg.0
    IL_0004: ldarg.1
    IL_0005: xor
    IL_0006: ldc.i4.1
    IL_0007: shr.un
    IL_0008: sub
    IL_0009: ret

}
bool between(byte x, byte a, byte b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: blt.s IL_000C
    IL_0004: ldarg.0
    IL_0005: ldarg.2
    IL_0006: cgt
    IL_0008: ldc.i4.0
    IL_0009: ceq
    IL_000B: ret
    IL_000C: ldc.i4.0
    IL_000D: ret

}
bool between(sbyte x, sbyte a, sbyte b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: blt.s IL_000C
    IL_0004: ldarg.0
    IL_0005: ldarg.2
    IL_0006: cgt
    IL_0008: ldc.i4.0
    IL_0009: ceq
    IL_000B: ret
    IL_000C: ldc.i4.0
    IL_000D: ret

}
bool between(short x, short a, short b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: blt.s IL_000C
    IL_0004: ldarg.0
    IL_0005: ldarg.2
    IL_0006: cgt
    IL_0008: ldc.i4.0
    IL_0009: ceq
    IL_000B: ret
    IL_000C: ldc.i4.0
    IL_000D: ret

}
bool between(ushort x, ushort a, ushort b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: blt.s IL_000C
    IL_0004: ldarg.0
    IL_0005: ldarg.2
    IL_0006: cgt
    IL_0008: ldc.i4.0
    IL_0009: ceq
    IL_000B: ret
    IL_000C: ldc.i4.0
    IL_000D: ret

}
bool between(int x, int a, int b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: blt.s IL_000C
    IL_0004: ldarg.0
    IL_0005: ldarg.2
    IL_0006: cgt
    IL_0008: ldc.i4.0
    IL_0009: ceq
    IL_000B: ret
    IL_000C: ldc.i4.0
    IL_000D: ret

}
bool between(uint x, uint a, uint b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: blt.un.s IL_000C
    IL_0004: ldarg.0
    IL_0005: ldarg.2
    IL_0006: cgt.un
    IL_0008: ldc.i4.0
    IL_0009: ceq
    IL_000B: ret
    IL_000C: ldc.i4.0
    IL_000D: ret

}
bool between(long x, long a, long b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: blt.s IL_000C
    IL_0004: ldarg.0
    IL_0005: ldarg.2
    IL_0006: cgt
    IL_0008: ldc.i4.0
    IL_0009: ceq
    IL_000B: ret
    IL_000C: ldc.i4.0
    IL_000D: ret

}
bool between(ulong x, ulong a, ulong b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: blt.un.s IL_000C
    IL_0004: ldarg.0
    IL_0005: ldarg.2
    IL_0006: cgt.un
    IL_0008: ldc.i4.0
    IL_0009: ceq
    IL_000B: ret
    IL_000C: ldc.i4.0
    IL_000D: ret

}
sbyte dec(sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0002: sub
    IL_0003: conv.i1
    IL_0004: dup
    IL_0005: starg.s src
    IL_0007: ret

}
byte dec(byte src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0002: sub
    IL_0003: conv.u1
    IL_0004: dup
    IL_0005: starg.s src
    IL_0007: ret

}
short dec(short src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0002: sub
    IL_0003: conv.i2
    IL_0004: dup
    IL_0005: starg.s src
    IL_0007: ret

}
ushort dec(ushort src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0002: sub
    IL_0003: conv.u2
    IL_0004: dup
    IL_0005: starg.s src
    IL_0007: ret

}
int dec(int src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0002: sub
    IL_0003: dup
    IL_0004: starg.s src
    IL_0006: ret

}
uint dec(uint src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0002: sub
    IL_0003: dup
    IL_0004: starg.s src
    IL_0006: ret

}
long dec(long src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0002: conv.i8
    IL_0003: sub
    IL_0004: dup
    IL_0005: starg.s src
    IL_0007: ret

}
ulong dec(ulong src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0002: conv.i8
    IL_0003: sub
    IL_0004: dup
    IL_0005: starg.s src
    IL_0007: ret

}
ref sbyte dec(ref sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i1
    IL_0003: ldc.i4.1
    IL_0004: sub
    IL_0005: conv.i1
    IL_0006: stind.i1
    IL_0007: ldarg.0
    IL_0008: ret

}
ref byte dec(ref byte src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u1
    IL_0003: ldc.i4.1
    IL_0004: sub
    IL_0005: conv.u1
    IL_0006: stind.i1
    IL_0007: ldarg.0
    IL_0008: ret

}
ref short dec(ref short src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i2
    IL_0003: ldc.i4.1
    IL_0004: sub
    IL_0005: conv.i2
    IL_0006: stind.i2
    IL_0007: ldarg.0
    IL_0008: ret

}
ref ushort dec(ref ushort src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u2
    IL_0003: ldc.i4.1
    IL_0004: sub
    IL_0005: conv.u2
    IL_0006: stind.i2
    IL_0007: ldarg.0
    IL_0008: ret

}
ref int dec(ref int src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i4
    IL_0003: ldc.i4.1
    IL_0004: sub
    IL_0005: stind.i4
    IL_0006: ldarg.0
    IL_0007: ret

}
ref uint dec(ref uint src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u4
    IL_0003: ldc.i4.1
    IL_0004: sub
    IL_0005: stind.i4
    IL_0006: ldarg.0
    IL_0007: ret

}
ref long dec(ref long src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldc.i4.1
    IL_0004: conv.i8
    IL_0005: sub
    IL_0006: stind.i8
    IL_0007: ldarg.0
    IL_0008: ret

}
ref ulong dec(ref ulong src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldc.i4.1
    IL_0004: conv.i8
    IL_0005: sub
    IL_0006: stind.i8
    IL_0007: ldarg.0
    IL_0008: ret

}
ulong dist(byte a, byte b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: bge.s IL_0009
    IL_0004: ldarg.1
    IL_0005: ldarg.0
    IL_0006: sub
    IL_0007: conv.i8
    IL_0008: ret
    IL_0009: ldarg.0
    IL_000A: ldarg.1
    IL_000B: sub
    IL_000C: conv.i8
    IL_000D: ret

}
sbyte and(sbyte lhs, sbyte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: and
    IL_0003: conv.i1
    IL_0004: ret

}
byte and(byte lhs, byte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: and
    IL_0003: conv.u1
    IL_0004: ret

}
short and(short lhs, short rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: and
    IL_0003: conv.i2
    IL_0004: ret

}
ushort and(ushort lhs, ushort rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: and
    IL_0003: conv.u2
    IL_0004: ret

}
int and(int lhs, int rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: and
    IL_0003: ret

}
uint and(uint lhs, uint rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: and
    IL_0003: ret

}
long and(long lhs, long rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: and
    IL_0003: ret

}
ulong and(ulong lhs, ulong rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: and
    IL_0003: ret

}
float and(float lhs, float rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int32 Z0.MathX::ToBits(System.Single)
    IL_0006: ldarg.1
    IL_0007: call System.Int32 Z0.MathX::ToBits(System.Single)
    IL_000C: and
    IL_000D: call System.Single System.BitConverter::Int32BitsToSingle(System.Int32)
    IL_0012: ret

}
double and(double lhs, double rhs)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int64 Z0.MathX::ToBits(System.Double)
    IL_0006: ldarg.1
    IL_0007: call System.Int64 Z0.MathX::ToBits(System.Double)
    IL_000C: and
    IL_000D: call System.Double System.BitConverter::Int64BitsToDouble(System.Int64)
    IL_0012: ret

}
ref sbyte and(in sbyte lhs, in sbyte rhs, ref sbyte dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: ldind.i1
    IL_0003: ldarg.1
    IL_0004: ldind.i1
    IL_0005: and
    IL_0006: conv.i1
    IL_0007: stind.i1
    IL_0008: ldarg.2
    IL_0009: ret

}
ref byte and(in byte lhs, in byte rhs, ref byte dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: ldind.u1
    IL_0003: ldarg.1
    IL_0004: ldind.u1
    IL_0005: and
    IL_0006: conv.u1
    IL_0007: stind.i1
    IL_0008: ldarg.2
    IL_0009: ret

}
ref short and(in short lhs, in short rhs, ref short dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: ldind.i2
    IL_0003: ldarg.1
    IL_0004: ldind.i2
    IL_0005: and
    IL_0006: conv.i2
    IL_0007: stind.i2
    IL_0008: ldarg.2
    IL_0009: ret

}
ref ushort and(in ushort lhs, in ushort rhs, ref ushort dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: ldind.u2
    IL_0003: ldarg.1
    IL_0004: ldind.u2
    IL_0005: and
    IL_0006: conv.u2
    IL_0007: stind.i2
    IL_0008: ldarg.2
    IL_0009: ret

}
ref int and(in int lhs, in int rhs, ref int dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: ldind.i4
    IL_0003: ldarg.1
    IL_0004: ldind.i4
    IL_0005: and
    IL_0006: stind.i4
    IL_0007: ldarg.2
    IL_0008: ret

}
ref uint and(in uint lhs, in uint rhs, ref uint dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: ldind.u4
    IL_0003: ldarg.1
    IL_0004: ldind.u4
    IL_0005: and
    IL_0006: stind.i4
    IL_0007: ldarg.2
    IL_0008: ret

}
ref long and(in long lhs, in long rhs, ref long dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldarg.1
    IL_0004: ldind.i8
    IL_0005: and
    IL_0006: stind.i8
    IL_0007: ldarg.2
    IL_0008: ret

}
ref ulong and(in ulong lhs, in ulong rhs, ref ulong dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldarg.1
    IL_0004: ldind.i8
    IL_0005: and
    IL_0006: stind.i8
    IL_0007: ldarg.2
    IL_0008: ret

}
ref float and(in float lhs, in float rhs, ref float dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: ldind.r4
    IL_0003: call System.Int32 Z0.MathX::ToBits(System.Single)
    IL_0008: ldarg.1
    IL_0009: ldind.r4
    IL_000A: call System.Int32 Z0.MathX::ToBits(System.Single)
    IL_000F: and
    IL_0010: call System.Single System.BitConverter::Int32BitsToSingle(System.Int32)
    IL_0015: stind.r4
    IL_0016: ldarg.2
    IL_0017: ret

}
ref double and(in double lhs, in double rhs, ref double dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: ldind.r8
    IL_0003: call System.Int64 Z0.MathX::ToBits(System.Double)
    IL_0008: ldarg.1
    IL_0009: ldind.r8
    IL_000A: call System.Int64 Z0.MathX::ToBits(System.Double)
    IL_000F: and
    IL_0010: call System.Double System.BitConverter::Int64BitsToDouble(System.Int64)
    IL_0015: stind.r8
    IL_0016: ldarg.2
    IL_0017: ret

}
ref sbyte and(ref sbyte lhs, sbyte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i1
    IL_0003: ldarg.1
    IL_0004: and
    IL_0005: conv.i1
    IL_0006: stind.i1
    IL_0007: ldarg.0
    IL_0008: ret

}
ref byte and(ref byte lhs, byte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u1
    IL_0003: ldarg.1
    IL_0004: and
    IL_0005: conv.u1
    IL_0006: stind.i1
    IL_0007: ldarg.0
    IL_0008: ret

}
ref short and(ref short lhs, short rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i2
    IL_0003: ldarg.1
    IL_0004: and
    IL_0005: conv.i2
    IL_0006: stind.i2
    IL_0007: ldarg.0
    IL_0008: ret

}
ref ushort and(ref ushort lhs, ushort rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u2
    IL_0003: ldarg.1
    IL_0004: and
    IL_0005: conv.u2
    IL_0006: stind.i2
    IL_0007: ldarg.0
    IL_0008: ret

}
ref int and(ref int lhs, int rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i4
    IL_0003: ldarg.1
    IL_0004: and
    IL_0005: stind.i4
    IL_0006: ldarg.0
    IL_0007: ret

}
ref uint and(ref uint lhs, uint rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u4
    IL_0003: ldarg.1
    IL_0004: and
    IL_0005: stind.i4
    IL_0006: ldarg.0
    IL_0007: ret

}
ref long and(ref long lhs, long rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldarg.1
    IL_0004: and
    IL_0005: stind.i8
    IL_0006: ldarg.0
    IL_0007: ret

}
ref ulong and(ref ulong lhs, ulong rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldarg.1
    IL_0004: and
    IL_0005: stind.i8
    IL_0006: ldarg.0
    IL_0007: ret

}
ref float and(ref float lhs, float rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.r4
    IL_0003: ldarg.1
    IL_0004: call System.Single Z0.math::and(System.Single,System.Single)
    IL_0009: stind.r4
    IL_000A: ldarg.0
    IL_000B: ret

}
ref double and(ref double lhs, double rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.r8
    IL_0003: ldarg.1
    IL_0004: call System.Double Z0.math::and(System.Double,System.Double)
    IL_0009: stind.r8
    IL_000A: ldarg.0
    IL_000B: ret

}
sbyte flip(sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: not
    IL_0002: conv.i1
    IL_0003: ret

}
byte not(byte src)
{
    IL_0000: ldarg.0
    IL_0001: not
    IL_0002: conv.u1
    IL_0003: ret

}
short flip(short src)
{
    IL_0000: ldarg.0
    IL_0001: not
    IL_0002: conv.i2
    IL_0003: ret

}
ushort flip(ushort src)
{
    IL_0000: ldarg.0
    IL_0001: not
    IL_0002: conv.u2
    IL_0003: ret

}
int flip(int src)
{
    IL_0000: ldarg.0
    IL_0001: not
    IL_0002: ret

}
uint flip(uint src)
{
    IL_0000: ldarg.0
    IL_0001: not
    IL_0002: ret

}
long flip(long src)
{
    IL_0000: ldarg.0
    IL_0001: not
    IL_0002: ret

}
ulong flip(ulong src)
{
    IL_0000: ldarg.0
    IL_0001: not
    IL_0002: ret

}
ref sbyte flip(ref sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i1
    IL_0003: not
    IL_0004: conv.i1
    IL_0005: stind.i1
    IL_0006: ldarg.0
    IL_0007: ret

}
ref byte flip(ref byte src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u1
    IL_0003: not
    IL_0004: conv.u1
    IL_0005: stind.i1
    IL_0006: ldarg.0
    IL_0007: ret

}
ref short flip(ref short src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i2
    IL_0003: not
    IL_0004: conv.i2
    IL_0005: stind.i2
    IL_0006: ldarg.0
    IL_0007: ret

}
ref ushort flip(ref ushort src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u2
    IL_0003: not
    IL_0004: conv.u2
    IL_0005: stind.i2
    IL_0006: ldarg.0
    IL_0007: ret

}
ref int flip(ref int src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i4
    IL_0003: not
    IL_0004: stind.i4
    IL_0005: ldarg.0
    IL_0006: ret

}
ref uint flip(ref uint src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u4
    IL_0003: not
    IL_0004: stind.i4
    IL_0005: ldarg.0
    IL_0006: ret

}
ref long flip(ref long src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: not
    IL_0004: stind.i8
    IL_0005: ldarg.0
    IL_0006: ret

}
ref ulong flip(ref ulong src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: not
    IL_0004: stind.i8
    IL_0005: ldarg.0
    IL_0006: ret

}
uint nand(uint a, uint b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: and
    IL_0003: not
    IL_0004: ret

}
ulong nand(ulong a, ulong b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: and
    IL_0003: not
    IL_0004: ret

}
byte nand(byte a, byte b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.math::nand(System.UInt32,System.UInt32)
    IL_0007: conv.u1
    IL_0008: ret

}
ushort nand(ushort a, ushort b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.math::nand(System.UInt32,System.UInt32)
    IL_0007: conv.u2
    IL_0008: ret

}
uint nor(uint a, uint b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: or
    IL_0003: not
    IL_0004: ret

}
ulong nor(ulong a, ulong b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: or
    IL_0003: not
    IL_0004: ret

}
byte nor(byte a, byte b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.math::nor(System.UInt32,System.UInt32)
    IL_0007: conv.u1
    IL_0008: ret

}
ushort nor(ushort a, ushort b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.math::nor(System.UInt32,System.UInt32)
    IL_0007: conv.u2
    IL_0008: ret

}
sbyte or(sbyte a, sbyte b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: or
    IL_0003: conv.i1
    IL_0004: ret

}
byte or(byte a, byte b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: or
    IL_0003: conv.u1
    IL_0004: ret

}
short or(short a, short b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: or
    IL_0003: conv.i2
    IL_0004: ret

}
ushort or(ushort a, ushort b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: or
    IL_0003: conv.u2
    IL_0004: ret

}
int or(int a, int b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: or
    IL_0003: ret

}
uint or(uint a, uint b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: or
    IL_0003: ret

}
long or(long a, long b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: or
    IL_0003: ret

}
ulong or(ulong a, ulong b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: or
    IL_0003: ret

}
float or(float a, float b)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int32 Z0.MathX::ToBits(System.Single)
    IL_0006: ldarg.1
    IL_0007: call System.Int32 Z0.MathX::ToBits(System.Single)
    IL_000C: or
    IL_000D: call System.Single System.BitConverter::Int32BitsToSingle(System.Int32)
    IL_0012: ret

}
double or(double a, double b)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int64 Z0.MathX::ToBits(System.Double)
    IL_0006: ldarg.1
    IL_0007: call System.Int64 Z0.MathX::ToBits(System.Double)
    IL_000C: or
    IL_000D: call System.Double System.BitConverter::Int64BitsToDouble(System.Int64)
    IL_0012: ret

}
ref sbyte or(ref sbyte a, sbyte b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i1
    IL_0003: ldarg.1
    IL_0004: or
    IL_0005: conv.i1
    IL_0006: stind.i1
    IL_0007: ldarg.0
    IL_0008: ret

}
ref byte or(ref byte a, byte b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u1
    IL_0003: ldarg.1
    IL_0004: or
    IL_0005: conv.u1
    IL_0006: stind.i1
    IL_0007: ldarg.0
    IL_0008: ret

}
ref short or(ref short a, short b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i2
    IL_0003: ldarg.1
    IL_0004: or
    IL_0005: conv.i2
    IL_0006: stind.i2
    IL_0007: ldarg.0
    IL_0008: ret

}
ref ushort or(ref ushort a, ushort b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u2
    IL_0003: ldarg.1
    IL_0004: or
    IL_0005: conv.u2
    IL_0006: stind.i2
    IL_0007: ldarg.0
    IL_0008: ret

}
ref int or(ref int a, int b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i4
    IL_0003: ldarg.1
    IL_0004: or
    IL_0005: stind.i4
    IL_0006: ldarg.0
    IL_0007: ret

}
ref uint or(ref uint a, uint b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u4
    IL_0003: ldarg.1
    IL_0004: or
    IL_0005: stind.i4
    IL_0006: ldarg.0
    IL_0007: ret

}
ref long or(ref long a, long b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldarg.1
    IL_0004: or
    IL_0005: stind.i8
    IL_0006: ldarg.0
    IL_0007: ret

}
ref ulong or(ref ulong a, ulong b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldarg.1
    IL_0004: or
    IL_0005: stind.i8
    IL_0006: ldarg.0
    IL_0007: ret

}
ref float or(ref float a, float b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.r4
    IL_0003: ldarg.1
    IL_0004: call System.Single Z0.math::or(System.Single,System.Single)
    IL_0009: stind.r4
    IL_000A: ldarg.0
    IL_000B: ret

}
ref double or(ref double a, double b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.r8
    IL_0003: ldarg.1
    IL_0004: call System.Double Z0.math::or(System.Double,System.Double)
    IL_0009: stind.r8
    IL_000A: ldarg.0
    IL_000B: ret

}
sbyte sal(sbyte src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 31
    IL_0004: and
    IL_0005: shl
    IL_0006: conv.i1
    IL_0007: ret

}
byte sal(byte src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 31
    IL_0004: and
    IL_0005: shl
    IL_0006: conv.u1
    IL_0007: ret

}
short sal(short src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 31
    IL_0004: and
    IL_0005: shl
    IL_0006: conv.i2
    IL_0007: ret

}
ushort sal(ushort src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 31
    IL_0004: and
    IL_0005: shl
    IL_0006: conv.u2
    IL_0007: ret

}
int sal(int src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 31
    IL_0004: and
    IL_0005: shl
    IL_0006: ret

}
uint sal(uint src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 31
    IL_0004: and
    IL_0005: shl
    IL_0006: ret

}
long sal(long src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 63
    IL_0004: and
    IL_0005: shl
    IL_0006: ret

}
ulong sal(ulong src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 63
    IL_0004: and
    IL_0005: shl
    IL_0006: ret

}
ref sbyte sal(ref sbyte src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i1
    IL_0003: ldarg.1
    IL_0004: ldc.i4.s 31
    IL_0006: and
    IL_0007: shl
    IL_0008: conv.i1
    IL_0009: stind.i1
    IL_000A: ldarg.0
    IL_000B: ret

}
ref byte sal(ref byte src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u1
    IL_0003: ldarg.1
    IL_0004: ldc.i4.s 31
    IL_0006: and
    IL_0007: shl
    IL_0008: conv.u1
    IL_0009: stind.i1
    IL_000A: ldarg.0
    IL_000B: ret

}
ref short sal(ref short src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i2
    IL_0003: ldarg.1
    IL_0004: ldc.i4.s 31
    IL_0006: and
    IL_0007: shl
    IL_0008: conv.i2
    IL_0009: stind.i2
    IL_000A: ldarg.0
    IL_000B: ret

}
ref ushort sal(ref ushort src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u2
    IL_0003: ldarg.1
    IL_0004: ldc.i4.s 31
    IL_0006: and
    IL_0007: shl
    IL_0008: conv.u2
    IL_0009: stind.i2
    IL_000A: ldarg.0
    IL_000B: ret

}
ref int sal(ref int src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i4
    IL_0003: ldarg.1
    IL_0004: ldc.i4.s 31
    IL_0006: and
    IL_0007: shl
    IL_0008: stind.i4
    IL_0009: ldarg.0
    IL_000A: ret

}
ref uint sal(ref uint src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u4
    IL_0003: ldarg.1
    IL_0004: ldc.i4.s 31
    IL_0006: and
    IL_0007: shl
    IL_0008: stind.i4
    IL_0009: ldarg.0
    IL_000A: ret

}
ref long sal(ref long src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldarg.1
    IL_0004: ldc.i4.s 63
    IL_0006: and
    IL_0007: shl
    IL_0008: stind.i8
    IL_0009: ldarg.0
    IL_000A: ret

}
ref ulong sal(ref ulong src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldarg.1
    IL_0004: ldc.i4.s 63
    IL_0006: and
    IL_0007: shl
    IL_0008: stind.i8
    IL_0009: ldarg.0
    IL_000A: ret

}
sbyte sar(sbyte src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 31
    IL_0004: and
    IL_0005: shr
    IL_0006: conv.i1
    IL_0007: ret

}
byte sar(byte src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 31
    IL_0004: and
    IL_0005: shr
    IL_0006: conv.u1
    IL_0007: ret

}
short sar(short src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 31
    IL_0004: and
    IL_0005: shr
    IL_0006: conv.i2
    IL_0007: ret

}
ushort sar(ushort src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 31
    IL_0004: and
    IL_0005: shr
    IL_0006: conv.u2
    IL_0007: ret

}
int sar(int src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 31
    IL_0004: and
    IL_0005: shr
    IL_0006: ret

}
uint sar(uint src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 31
    IL_0004: and
    IL_0005: shr.un
    IL_0006: ret

}
long sar(long src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 63
    IL_0004: and
    IL_0005: shr
    IL_0006: ret

}
ulong sar(ulong src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 63
    IL_0004: and
    IL_0005: shr.un
    IL_0006: ret

}
ref sbyte sar(ref sbyte src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i1
    IL_0003: ldarg.1
    IL_0004: ldc.i4.s 31
    IL_0006: and
    IL_0007: shr
    IL_0008: conv.i1
    IL_0009: stind.i1
    IL_000A: ldarg.0
    IL_000B: ret

}
ref byte sar(ref byte src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u1
    IL_0003: ldarg.1
    IL_0004: ldc.i4.s 31
    IL_0006: and
    IL_0007: shr
    IL_0008: conv.u1
    IL_0009: stind.i1
    IL_000A: ldarg.0
    IL_000B: ret

}
ref short sar(ref short src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i2
    IL_0003: ldarg.1
    IL_0004: ldc.i4.s 31
    IL_0006: and
    IL_0007: shr
    IL_0008: conv.i2
    IL_0009: stind.i2
    IL_000A: ldarg.0
    IL_000B: ret

}
ref ushort sar(ref ushort src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u2
    IL_0003: ldarg.1
    IL_0004: ldc.i4.s 31
    IL_0006: and
    IL_0007: shr
    IL_0008: conv.u2
    IL_0009: stind.i2
    IL_000A: ldarg.0
    IL_000B: ret

}
ref int sar(ref int src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i4
    IL_0003: ldarg.1
    IL_0004: ldc.i4.s 31
    IL_0006: and
    IL_0007: shr
    IL_0008: stind.i4
    IL_0009: ldarg.0
    IL_000A: ret

}
ref uint sar(ref uint src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u4
    IL_0003: ldarg.1
    IL_0004: ldc.i4.s 31
    IL_0006: and
    IL_0007: shr.un
    IL_0008: stind.i4
    IL_0009: ldarg.0
    IL_000A: ret

}
ref long sar(ref long src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldarg.1
    IL_0004: ldc.i4.s 63
    IL_0006: and
    IL_0007: shr
    IL_0008: stind.i8
    IL_0009: ldarg.0
    IL_000A: ret

}
ref ulong sar(ref ulong src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldarg.1
    IL_0004: ldc.i4.s 63
    IL_0006: and
    IL_0007: shr.un
    IL_0008: stind.i8
    IL_0009: ldarg.0
    IL_000A: ret

}
uint select(uint a, uint b, uint c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.math::and(System.UInt32,System.UInt32)
    IL_0007: ldarg.0
    IL_0008: call System.UInt32 Z0.math::flip(System.UInt32)
    IL_000D: ldarg.2
    IL_000E: call System.UInt32 Z0.math::and(System.UInt32,System.UInt32)
    IL_0013: call System.UInt32 Z0.math::or(System.UInt32,System.UInt32)
    IL_0018: ret

}
ulong select(ulong a, ulong b, ulong c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.math::and(System.UInt64,System.UInt64)
    IL_0007: ldarg.0
    IL_0008: call System.UInt64 Z0.math::flip(System.UInt64)
    IL_000D: ldarg.2
    IL_000E: call System.UInt64 Z0.math::and(System.UInt64,System.UInt64)
    IL_0013: call System.UInt64 Z0.math::or(System.UInt64,System.UInt64)
    IL_0018: ret

}
byte select(byte a, byte b, byte c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.UInt32 Z0.math::select(System.UInt32,System.UInt32,System.UInt32)
    IL_0008: conv.u1
    IL_0009: ret

}
ushort select(ushort a, ushort b, ushort c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.UInt32 Z0.math::select(System.UInt32,System.UInt32,System.UInt32)
    IL_0008: conv.u2
    IL_0009: ret

}
sbyte sll(sbyte src, int offset)
{
    IL_0000: ldarga.s src
    IL_0002: call System.SByte& Z0.math::abs(System.SByte&)
    IL_0007: ldind.i1
    IL_0008: ldarg.1
    IL_0009: ldc.i4.s 31
    IL_000B: and
    IL_000C: shl
    IL_000D: conv.i1
    IL_000E: ret

}
byte sll(byte src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 31
    IL_0004: and
    IL_0005: shl
    IL_0006: conv.u1
    IL_0007: ret

}
short sll(short src, int offset)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Int16& Z0.math::abs(System.Int16&)
    IL_0007: ldind.i2
    IL_0008: ldarg.1
    IL_0009: ldc.i4.s 31
    IL_000B: and
    IL_000C: shl
    IL_000D: conv.i2
    IL_000E: ret

}
ushort sll(ushort src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 31
    IL_0004: and
    IL_0005: shl
    IL_0006: conv.u2
    IL_0007: ret

}
int sll(int src, int offset)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Int32& Z0.math::abs(System.Int32&)
    IL_0007: ldind.i4
    IL_0008: ldarg.1
    IL_0009: ldc.i4.s 31
    IL_000B: and
    IL_000C: shl
    IL_000D: ret

}
uint sll(uint src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 31
    IL_0004: and
    IL_0005: shl
    IL_0006: ret

}
long sll(long src, int offset)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Int64& Z0.math::abs(System.Int64&)
    IL_0007: ldind.i8
    IL_0008: ldarg.1
    IL_0009: ldc.i4.s 63
    IL_000B: and
    IL_000C: shl
    IL_000D: ret

}
ulong sll(ulong src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 63
    IL_0004: and
    IL_0005: shl
    IL_0006: ret

}
ref sbyte sll(ref sbyte src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: call System.SByte& Z0.math::abs(System.SByte&)
    IL_0006: dup
    IL_0007: ldind.i1
    IL_0008: ldarg.1
    IL_0009: ldc.i4.s 31
    IL_000B: and
    IL_000C: shl
    IL_000D: conv.i1
    IL_000E: stind.i1
    IL_000F: ldarg.0
    IL_0010: ret

}
ref byte sll(ref byte src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u1
    IL_0003: ldarg.1
    IL_0004: ldc.i4.s 31
    IL_0006: and
    IL_0007: shl
    IL_0008: conv.u1
    IL_0009: stind.i1
    IL_000A: ldarg.0
    IL_000B: ret

}
ref short sll(ref short src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int16& Z0.math::abs(System.Int16&)
    IL_0006: dup
    IL_0007: ldind.i2
    IL_0008: ldarg.1
    IL_0009: ldc.i4.s 31
    IL_000B: and
    IL_000C: shl
    IL_000D: conv.i2
    IL_000E: stind.i2
    IL_000F: ldarg.0
    IL_0010: ret

}
ref ushort sll(ref ushort src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u2
    IL_0003: ldarg.1
    IL_0004: ldc.i4.s 31
    IL_0006: and
    IL_0007: shl
    IL_0008: conv.u2
    IL_0009: stind.i2
    IL_000A: ldarg.0
    IL_000B: ret

}
ref int sll(ref int src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int32& Z0.math::abs(System.Int32&)
    IL_0006: dup
    IL_0007: ldind.i4
    IL_0008: ldarg.1
    IL_0009: ldc.i4.s 31
    IL_000B: and
    IL_000C: shl
    IL_000D: stind.i4
    IL_000E: ldarg.0
    IL_000F: ret

}
ref uint sll(ref uint src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.u4
    IL_0003: ldarg.1
    IL_0004: ldc.i4.s 31
    IL_0006: and
    IL_0007: shl
    IL_0008: stind.i4
    IL_0009: ldarg.0
    IL_000A: ret

}
ref long sll(ref long src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int64& Z0.math::abs(System.Int64&)
    IL_0006: dup
    IL_0007: ldind.i8
    IL_0008: ldarg.1
    IL_0009: ldc.i4.s 63
    IL_000B: and
    IL_000C: shl
    IL_000D: stind.i8
    IL_000E: ldarg.0
    IL_000F: ret

}
ref ulong sll(ref ulong src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.i8
    IL_0003: ldarg.1
    IL_0004: ldc.i4.s 63
    IL_0006: and
    IL_0007: shl
    IL_0008: stind.i8
    IL_0009: ldarg.0
    IL_000A: ret

}
sbyte srl(sbyte src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Int32 Z0.math::srl32i(System.Int32,System.Int32)
    IL_0007: conv.i1
    IL_0008: ret

}
byte srl(byte src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.math::srl32u(System.UInt32,System.Int32)
    IL_0007: conv.u1
    IL_0008: ret

}
