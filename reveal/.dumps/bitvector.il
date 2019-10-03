// 2019-10-03 01:55:31:171
UInt4 and(UInt4 x, UInt4 y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.UInt4 Z0.UInt4::op_BitwiseAnd(Z0.UInt4,Z0.UInt4)
    IL_0007: ret

}
BitVector4 and(BitVector4 x, BitVector4 y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Byte Z0.BitVector4::data
    IL_0006: ldarg.1
    IL_0007: ldfld System.Byte Z0.BitVector4::data
    IL_000C: call System.Byte Z0.math::and(System.Byte,System.Byte)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.BitVector4 Z0.BitVector4::op_Implicit(System.Byte&)
    IL_0019: ret

}
BitVector8 and(BitVector8 x, BitVector8 y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Byte Z0.BitVector8::data
    IL_0006: ldarg.1
    IL_0007: ldfld System.Byte Z0.BitVector8::data
    IL_000C: call System.Byte Z0.math::and(System.Byte,System.Byte)
    IL_0011: call Z0.BitVector8 Z0.BitVector8::op_Implicit(System.Byte)
    IL_0016: ret

}
BitVector16 and(BitVector16 x, BitVector16 y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.UInt16 Z0.BitVector16::data
    IL_0006: ldarg.1
    IL_0007: ldfld System.UInt16 Z0.BitVector16::data
    IL_000C: call System.UInt16 Z0.math::and(System.UInt16,System.UInt16)
    IL_0011: call Z0.BitVector16 Z0.BitVector16::op_Implicit(System.UInt16)
    IL_0016: ret

}
BitVector32 and(in BitVector32 x, in BitVector32 y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.UInt32 Z0.BitVector32::data
    IL_0006: ldarg.1
    IL_0007: ldfld System.UInt32 Z0.BitVector32::data
    IL_000C: call System.UInt32 Z0.math::and(System.UInt32,System.UInt32)
    IL_0011: call Z0.BitVector32 Z0.BitVector32::op_Implicit(System.UInt32)
    IL_0016: ret

}
BitVector64 and(BitVector64 x, BitVector64 y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.UInt64 Z0.BitVector64::data
    IL_0006: ldarg.1
    IL_0007: ldfld System.UInt64 Z0.BitVector64::data
    IL_000C: call System.UInt64 Z0.math::and(System.UInt64,System.UInt64)
    IL_0011: call Z0.BitVector64 Z0.BitVector64::op_Implicit(System.UInt64)
    IL_0016: ret

}
ref BitVector4 and(ref BitVector4 x, BitVector4 y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldfld System.Byte Z0.BitVector4::data
    IL_0007: ldarg.1
    IL_0008: ldfld System.Byte Z0.BitVector4::data
    IL_000D: call System.Byte Z0.math::and(System.Byte,System.Byte)
    IL_0012: stloc.0
    IL_0013: ldloca.s V_0
    IL_0015: call Z0.BitVector4 Z0.BitVector4::op_Implicit(System.Byte&)
    IL_001A: stobj Z0.BitVector4
    IL_001F: ldarg.0
    IL_0020: ret

}
ref BitVector8 and(ref BitVector8 x, BitVector8 y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldfld System.Byte Z0.BitVector8::data
    IL_0007: ldarg.1
    IL_0008: ldfld System.Byte Z0.BitVector8::data
    IL_000D: call System.Byte Z0.math::and(System.Byte,System.Byte)
    IL_0012: call Z0.BitVector8 Z0.BitVector8::op_Implicit(System.Byte)
    IL_0017: stobj Z0.BitVector8
    IL_001C: ldarg.0
    IL_001D: ret

}
ref BitVector16 and(ref BitVector16 x, BitVector16 y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldfld System.UInt16 Z0.BitVector16::data
    IL_0007: ldarg.1
    IL_0008: ldfld System.UInt16 Z0.BitVector16::data
    IL_000D: call System.UInt16 Z0.math::and(System.UInt16,System.UInt16)
    IL_0012: call Z0.BitVector16 Z0.BitVector16::op_Implicit(System.UInt16)
    IL_0017: stobj Z0.BitVector16
    IL_001C: ldarg.0
    IL_001D: ret

}
ref BitVector32 and(ref BitVector32 x, BitVector32 y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldfld System.UInt32 Z0.BitVector32::data
    IL_0007: ldarg.1
    IL_0008: ldfld System.UInt32 Z0.BitVector32::data
    IL_000D: call System.UInt32 Z0.math::and(System.UInt32,System.UInt32)
    IL_0012: call Z0.BitVector32 Z0.BitVector32::op_Implicit(System.UInt32)
    IL_0017: stobj Z0.BitVector32
    IL_001C: ldarg.0
    IL_001D: ret

}
ref BitVector64 and(ref BitVector64 x, BitVector64 y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldfld System.UInt64 Z0.BitVector64::data
    IL_0007: ldarg.1
    IL_0008: ldfld System.UInt64 Z0.BitVector64::data
    IL_000D: call System.UInt64 Z0.math::and(System.UInt64,System.UInt64)
    IL_0012: call Z0.BitVector64 Z0.BitVector64::op_Implicit(System.UInt64)
    IL_0017: stobj Z0.BitVector64
    IL_001C: ldarg.0
    IL_001D: ret

}
BitVector4 andn(BitVector4 x, BitVector4 y)
{
    IL_0000: ldarga.s x
    IL_0002: ldflda System.Byte Z0.BitVector4::data
    IL_0007: ldarga.s y
    IL_0009: ldflda System.Byte Z0.BitVector4::data
    IL_000E: call System.Byte Z0.gbits::andn<System.Byte>(System.Byte&,System.Byte&)
    IL_0013: stloc.0
    IL_0014: ldloca.s V_0
    IL_0016: call Z0.BitVector4 Z0.BitVector4::op_Implicit(System.Byte&)
    IL_001B: ret

}
BitVector8 andn(BitVector8 x, BitVector8 y)
{
    IL_0000: ldarga.s x
    IL_0002: ldflda System.Byte Z0.BitVector8::data
    IL_0007: ldarga.s y
    IL_0009: ldflda System.Byte Z0.BitVector8::data
    IL_000E: call System.Byte Z0.gbits::andn<System.Byte>(System.Byte&,System.Byte&)
    IL_0013: call Z0.BitVector8 Z0.BitVector8::op_Implicit(System.Byte)
    IL_0018: ret

}
BitVector16 andn(BitVector16 x, BitVector16 y)
{
    IL_0000: ldarga.s x
    IL_0002: ldflda System.UInt16 Z0.BitVector16::data
    IL_0007: ldarga.s y
    IL_0009: ldflda System.UInt16 Z0.BitVector16::data
    IL_000E: call System.UInt16 Z0.gbits::andn<System.UInt16>(System.UInt16&,System.UInt16&)
    IL_0013: call Z0.BitVector16 Z0.BitVector16::op_Implicit(System.UInt16)
    IL_0018: ret

}
BitVector32 andn(BitVector32 x, BitVector32 y)
{
    IL_0000: ldarga.s x
    IL_0002: ldflda System.UInt32 Z0.BitVector32::data
    IL_0007: ldarga.s y
    IL_0009: ldflda System.UInt32 Z0.BitVector32::data
    IL_000E: call System.UInt32 Z0.gbits::andn<System.UInt32>(System.UInt32&,System.UInt32&)
    IL_0013: call Z0.BitVector32 Z0.BitVector32::op_Implicit(System.UInt32)
    IL_0018: ret

}
BitVector64 andn(BitVector64 x, BitVector64 y)
{
    IL_0000: ldarga.s x
    IL_0002: ldflda System.UInt64 Z0.BitVector64::data
    IL_0007: ldarga.s y
    IL_0009: ldflda System.UInt64 Z0.BitVector64::data
    IL_000E: call System.UInt64 Z0.gbits::andn<System.UInt64>(System.UInt64&,System.UInt64&)
    IL_0013: call Z0.BitVector64 Z0.BitVector64::op_Implicit(System.UInt64)
    IL_0018: ret

}
Bit dot(BitVector4 lhs, BitVector4 rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Byte Z0.BitVector4::data
    IL_0006: ldarg.1
    IL_0007: ldfld System.Byte Z0.BitVector4::data
    IL_000C: and
    IL_000D: call System.UInt32 Z0.Bits::pop(System.Int32)
    IL_0012: call System.UInt32 Z0.Mod`1<Z0.N2>::mod(System.UInt32)
    IL_0017: call Z0.Bit Z0.Bit::op_Implicit(System.UInt32)
    IL_001C: ret

}
Bit dot(BitVector8 lhs, BitVector8 rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Byte Z0.BitVector8::data
    IL_0006: ldarg.1
    IL_0007: ldfld System.Byte Z0.BitVector8::data
    IL_000C: and
    IL_000D: call System.UInt32 Z0.Bits::pop(System.Int32)
    IL_0012: ldloca.s V_0
    IL_0014: initobj Z0.N2
    IL_001A: ldloc.0
    IL_001B: call System.UInt32 zfunc::mod<Z0.N2>(System.UInt32,Z0.N2)
    IL_0020: call Z0.Bit Z0.Bit::op_Implicit(System.UInt32)
    IL_0025: ret

}
Bit dot(BitVector16 lhs, BitVector16 rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.UInt16 Z0.BitVector16::data
    IL_0006: ldarg.1
    IL_0007: ldfld System.UInt16 Z0.BitVector16::data
    IL_000C: and
    IL_000D: call System.UInt32 Z0.Bits::pop(System.Int32)
    IL_0012: ldloca.s V_0
    IL_0014: initobj Z0.N2
    IL_001A: ldloc.0
    IL_001B: call System.UInt32 zfunc::mod<Z0.N2>(System.UInt32,Z0.N2)
    IL_0020: call Z0.Bit Z0.Bit::op_Implicit(System.UInt32)
    IL_0025: ret

}
Bit dot(BitVector32 lhs, BitVector32 rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.UInt32 Z0.BitVector32::data
    IL_0006: ldarg.1
    IL_0007: ldfld System.UInt32 Z0.BitVector32::data
    IL_000C: and
    IL_000D: call System.UInt32 Z0.Bits::pop(System.UInt32)
    IL_0012: ldloca.s V_0
    IL_0014: initobj Z0.N2
    IL_001A: ldloc.0
    IL_001B: call System.UInt32 zfunc::mod<Z0.N2>(System.UInt32,Z0.N2)
    IL_0020: call Z0.Bit Z0.Bit::op_Implicit(System.UInt32)
    IL_0025: ret

}
Bit dot(BitVector64 lhs, BitVector64 rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.UInt64 Z0.BitVector64::data
    IL_0006: ldarg.1
    IL_0007: ldfld System.UInt64 Z0.BitVector64::data
    IL_000C: and
    IL_000D: call System.UInt32 Z0.Bits::pop(System.UInt64)
    IL_0012: ldloca.s V_0
    IL_0014: initobj Z0.N2
    IL_001A: ldloc.0
    IL_001B: call System.UInt32 zfunc::mod<Z0.N2>(System.UInt32,Z0.N2)
    IL_0020: call Z0.Bit Z0.Bit::op_Implicit(System.UInt32)
    IL_0025: ret

}
BitVector4 flip(BitVector4 src)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Byte Z0.BitVector4::data
    IL_0006: not
    IL_0007: conv.u1
    IL_0008: ldc.i4.4
    IL_0009: shl
    IL_000A: conv.u1
    IL_000B: call System.Byte Z0.bitvector::TakeHi(System.Byte)
    IL_0010: stloc.0
    IL_0011: ldloca.s V_0
    IL_0013: call Z0.BitVector4 Z0.BitVector4::op_Implicit(System.Byte&)
    IL_0018: ret

}
byte TakeHi(byte src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.4
    IL_0002: shr
    IL_0003: ldc.i4.s 15
    IL_0005: and
    IL_0006: conv.u1
    IL_0007: ret

}
BitVector8 flip(BitVector8 x)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Byte Z0.BitVector8::data
    IL_0006: call System.Byte Z0.math::flip(System.Byte)
    IL_000B: call Z0.BitVector8 Z0.BitVector8::op_Implicit(System.Byte)
    IL_0010: ret

}
BitVector16 flip(BitVector16 x)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.UInt16 Z0.BitVector16::data
    IL_0006: call System.UInt16 Z0.math::flip(System.UInt16)
    IL_000B: call Z0.BitVector16 Z0.BitVector16::op_Implicit(System.UInt16)
    IL_0010: ret

}
BitVector32 flip(BitVector32 x)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.UInt32 Z0.BitVector32::data
    IL_0006: call System.UInt32 Z0.math::flip(System.UInt32)
    IL_000B: call Z0.BitVector32 Z0.BitVector32::op_Implicit(System.UInt32)
    IL_0010: ret

}
BitVector64 flip(BitVector64 x)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.UInt64 Z0.BitVector64::data
    IL_0006: call System.UInt64 Z0.math::flip(System.UInt64)
    IL_000B: call Z0.BitVector64 Z0.BitVector64::op_Implicit(System.UInt64)
    IL_0010: ret

}
ref BitVector8 flip(BitVector8 x, ref BitVector8 z)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldfld System.Byte Z0.BitVector8::data
    IL_0007: call System.Byte Z0.math::flip(System.Byte)
    IL_000C: stfld System.Byte Z0.BitVector8::data
    IL_0011: ldarg.1
    IL_0012: ret

}
ref BitVector16 flip(BitVector16 x, ref BitVector16 z)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldfld System.UInt16 Z0.BitVector16::data
    IL_0007: call System.UInt16 Z0.math::flip(System.UInt16)
    IL_000C: stfld System.UInt16 Z0.BitVector16::data
    IL_0011: ldarg.1
    IL_0012: ret

}
ref BitVector32 flip(BitVector32 x, ref BitVector32 z)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldfld System.UInt32 Z0.BitVector32::data
    IL_0007: call System.UInt32 Z0.math::flip(System.UInt32)
    IL_000C: stfld System.UInt32 Z0.BitVector32::data
    IL_0011: ldarg.1
    IL_0012: ret

}
ref BitVector64 flip(BitVector64 x, ref BitVector64 z)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldfld System.UInt64 Z0.BitVector64::data
    IL_0007: call System.UInt64 Z0.math::flip(System.UInt64)
    IL_000C: stfld System.UInt64 Z0.BitVector64::data
    IL_0011: ldarg.1
    IL_0012: ret

}
ref BitVector8 flip(ref BitVector8 x)
{
    IL_0000: ldarg.0
    IL_0001: ldflda System.Byte Z0.BitVector8::data
    IL_0006: call System.Byte& Z0.math::flip(System.Byte&)
    IL_000B: pop
    IL_000C: ldarg.0
    IL_000D: ret

}
ref BitVector16 flip(ref BitVector16 x)
{
    IL_0000: ldarg.0
    IL_0001: ldflda System.UInt16 Z0.BitVector16::data
    IL_0006: call System.UInt16& Z0.math::flip(System.UInt16&)
    IL_000B: pop
    IL_000C: ldarg.0
    IL_000D: ret

}
ref BitVector32 flip(ref BitVector32 x)
{
    IL_0000: ldarg.0
    IL_0001: ldflda System.UInt32 Z0.BitVector32::data
    IL_0006: call System.UInt32& Z0.math::flip(System.UInt32&)
    IL_000B: pop
    IL_000C: ldarg.0
    IL_000D: ret

}
ref BitVector64 flip(ref BitVector64 x)
{
    IL_0000: ldarg.0
    IL_0001: ldflda System.UInt64 Z0.BitVector64::data
    IL_0006: call System.UInt64& Z0.math::flip(System.UInt64&)
    IL_000B: pop
    IL_000C: ldarg.0
    IL_000D: ret

}
BitVector8 from(sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: conv.u1
    IL_0002: call Z0.BitVector8 Z0.BitVector8::op_Implicit(System.Byte)
    IL_0007: ret

}
BitVector8 from(byte src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.BitVector8 Z0.BitVector8::op_Implicit(System.Byte)
    IL_0006: ret

}
BitVector16 from(short src)
{
    IL_0000: ldarg.0
    IL_0001: conv.u2
    IL_0002: call Z0.BitVector16 Z0.BitVector16::op_Implicit(System.UInt16)
    IL_0007: ret

}
BitVector16 from(ushort src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.BitVector16 Z0.BitVector16::op_Implicit(System.UInt16)
    IL_0006: ret

}
BitVector32 from(int src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.BitVector32 Z0.BitVector32::op_Implicit(System.UInt32)
    IL_0006: ret

}
BitVector32 from(uint src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.BitVector32 Z0.BitVector32::op_Implicit(System.UInt32)
    IL_0006: ret

}
BitVector64 from(long src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.BitVector64 Z0.BitVector64::op_Implicit(System.UInt64)
    IL_0006: ret

}
BitVector64 from(ulong src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.BitVector64 Z0.BitVector64::op_Implicit(System.UInt64)
    IL_0006: ret

}
BitVector32 from(float src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int32 Z0.MathX::ToBits(System.Single)
    IL_0006: call Z0.BitVector32 Z0.BitVector32::op_Implicit(System.UInt32)
    IL_000B: ret

}
BitVector64 from(double src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int64 Z0.MathX::ToBits(System.Double)
    IL_0006: call Z0.BitVector64 Z0.BitVector64::op_Implicit(System.UInt64)
    IL_000B: ret

}
ref BitVector8 mask(Perm spec, out BitVector8 mask)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call Z0.BitVector8 Z0.BitVector8::Mask(Z0.Perm)
    IL_0007: stobj Z0.BitVector8
    IL_000C: ldarg.1
    IL_000D: ret

}
ref BitVector16 mask(Perm spec, out BitVector16 mask)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call Z0.BitVector16 Z0.BitVector16::Mask(Z0.Perm)
    IL_0007: stobj Z0.BitVector16
    IL_000C: ldarg.1
    IL_000D: ret

}
ref BitVector32 mask(Perm spec, out BitVector32 mask)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call Z0.BitVector32 Z0.BitVector32::Mask(Z0.Perm)
    IL_0007: stobj Z0.BitVector32
    IL_000C: ldarg.1
    IL_000D: ret

}
ref BitVector64 mask(Perm spec, out BitVector64 mask)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call Z0.BitVector64 Z0.BitVector64::Mask(Z0.Perm)
    IL_0007: stobj Z0.BitVector64
    IL_000C: ldarg.1
    IL_000D: ret

}
BitVector4 negate(BitVector4 x)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Byte Z0.BitVector4::data
    IL_0006: call System.Byte Z0.math::negate(System.Byte)
    IL_000B: stloc.0
    IL_000C: ldloca.s V_0
    IL_000E: call Z0.BitVector4 Z0.BitVector4::op_Implicit(System.Byte&)
    IL_0013: ret

}
BitVector8 negate(BitVector8 x)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Byte Z0.BitVector8::data
    IL_0006: call System.Byte Z0.math::negate(System.Byte)
    IL_000B: call Z0.BitVector8 Z0.BitVector8::op_Implicit(System.Byte)
    IL_0010: ret

}
BitVector16 negate(BitVector16 x)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.UInt16 Z0.BitVector16::data
    IL_0006: call System.UInt16 Z0.math::negate(System.UInt16)
    IL_000B: call Z0.BitVector16 Z0.BitVector16::op_Implicit(System.UInt16)
    IL_0010: ret

}
BitVector32 negate(BitVector32 x)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.UInt32 Z0.BitVector32::data
    IL_0006: call System.UInt32 Z0.math::negate(System.UInt32)
    IL_000B: call Z0.BitVector32 Z0.BitVector32::op_Implicit(System.UInt32)
    IL_0010: ret

}
BitVector64 negate(BitVector64 x)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.UInt64 Z0.BitVector64::data
    IL_0006: call System.UInt64 Z0.math::negate(System.UInt64)
    IL_000B: call Z0.BitVector64 Z0.BitVector64::op_Implicit(System.UInt64)
    IL_0010: ret

}
ref BitVector8 negate(ref BitVector8 x)
{
    IL_0000: ldarg.0
    IL_0001: ldflda System.Byte Z0.BitVector8::data
    IL_0006: call System.Byte& Z0.math::negate(System.Byte&)
    IL_000B: pop
    IL_000C: ldarg.0
    IL_000D: ret

}
ref BitVector16 negate(ref BitVector16 x)
{
    IL_0000: ldarg.0
    IL_0001: ldflda System.UInt16 Z0.BitVector16::data
    IL_0006: call System.UInt16& Z0.math::negate(System.UInt16&)
    IL_000B: pop
    IL_000C: ldarg.0
    IL_000D: ret

}
ref BitVector32 negate(ref BitVector32 x)
{
    IL_0000: ldarg.0
    IL_0001: ldflda System.UInt32 Z0.BitVector32::data
    IL_0006: call System.UInt32& Z0.math::negate(System.UInt32&)
    IL_000B: pop
    IL_000C: ldarg.0
    IL_000D: ret

}
ref BitVector64 negate(ref BitVector64 x)
{
    IL_0000: ldarg.0
    IL_0001: ldflda System.UInt64 Z0.BitVector64::data
    IL_0006: call System.UInt64& Z0.math::negate(System.UInt64&)
    IL_000B: pop
    IL_000C: ldarg.0
    IL_000D: ret

}
BitVector4 or(BitVector4 x, BitVector4 y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Byte Z0.BitVector4::data
    IL_0006: ldarg.1
    IL_0007: ldfld System.Byte Z0.BitVector4::data
    IL_000C: call System.Byte Z0.math::or(System.Byte,System.Byte)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.BitVector4 Z0.BitVector4::op_Implicit(System.Byte&)
    IL_0019: ret

}
BitVector8 or(BitVector8 x, BitVector8 y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Byte Z0.BitVector8::data
    IL_0006: ldarg.1
    IL_0007: ldfld System.Byte Z0.BitVector8::data
    IL_000C: call System.Byte Z0.math::or(System.Byte,System.Byte)
    IL_0011: call Z0.BitVector8 Z0.BitVector8::op_Implicit(System.Byte)
    IL_0016: ret

}
BitVector16 or(BitVector16 x, BitVector16 y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.UInt16 Z0.BitVector16::data
    IL_0006: ldarg.1
    IL_0007: ldfld System.UInt16 Z0.BitVector16::data
    IL_000C: call System.UInt16 Z0.math::or(System.UInt16,System.UInt16)
    IL_0011: call Z0.BitVector16 Z0.BitVector16::op_Implicit(System.UInt16)
    IL_0016: ret

}
BitVector32 or(in BitVector32 x, in BitVector32 y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.UInt32 Z0.BitVector32::data
    IL_0006: ldarg.1
    IL_0007: ldfld System.UInt32 Z0.BitVector32::data
    IL_000C: call System.UInt32 Z0.math::or(System.UInt32,System.UInt32)
    IL_0011: call Z0.BitVector32 Z0.BitVector32::op_Implicit(System.UInt32)
    IL_0016: ret

}
BitVector64 or(BitVector64 x, BitVector64 y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.UInt64 Z0.BitVector64::data
    IL_0006: ldarg.1
    IL_0007: ldfld System.UInt64 Z0.BitVector64::data
    IL_000C: call System.UInt64 Z0.math::or(System.UInt64,System.UInt64)
    IL_0011: call Z0.BitVector64 Z0.BitVector64::op_Implicit(System.UInt64)
    IL_0016: ret

}
Bit parity(BitVector4 src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 Z0.bitvector::pop(Z0.BitVector4)
    IL_0006: call System.Boolean zfunc::odd(System.UInt32)
    IL_000B: call Z0.Bit Z0.Bit::op_Implicit(System.Boolean)
    IL_0010: ret

}
Bit parity(BitVector8 src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 Z0.bitvector::pop(Z0.BitVector8)
    IL_0006: call System.Boolean zfunc::odd(System.UInt32)
    IL_000B: call Z0.Bit Z0.Bit::op_Implicit(System.Boolean)
    IL_0010: ret

}
Bit parity(BitVector16 src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 Z0.bitvector::pop(Z0.BitVector16)
    IL_0006: call System.Boolean zfunc::odd(System.UInt32)
    IL_000B: call Z0.Bit Z0.Bit::op_Implicit(System.Boolean)
    IL_0010: ret

}
Bit parity(BitVector32 src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 Z0.bitvector::pop(Z0.BitVector32)
    IL_0006: call System.Boolean zfunc::odd(System.UInt32)
    IL_000B: call Z0.Bit Z0.Bit::op_Implicit(System.Boolean)
    IL_0010: ret

}
Bit parity(BitVector64 src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 Z0.bitvector::pop(Z0.BitVector64)
    IL_0006: call System.Boolean zfunc::odd(System.UInt32)
    IL_000B: call Z0.Bit Z0.Bit::op_Implicit(System.Boolean)
    IL_0010: ret

}
Span<BitVector4> partition(BitVector16 src, Span<BitVector4> dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.Span`1<System.Byte> Z0.SpanExtensions::AsBytes<Z0.BitVector4>(System.Span`1<Z0.BitVector4>)
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: call System.UInt16 Z0.BitVector16::op_Implicit(Z0.BitVector16)
    IL_000D: ldloc.0
    IL_000E: call System.Void Z0.BitParts::part16x4(System.UInt32,System.Span`1<System.Byte>)
    IL_0013: ldarg.1
    IL_0014: ret

}
Span<BitVector8> partition(BitVector16 src, Span<BitVector8> dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.Span`1<System.Byte> Z0.SpanExtensions::AsBytes<Z0.BitVector8>(System.Span`1<Z0.BitVector8>)
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: call System.UInt16 Z0.BitVector16::op_Implicit(Z0.BitVector16)
    IL_000D: ldloc.0
    IL_000E: call System.Void Z0.BitParts::part16x8(System.UInt32,System.Span`1<System.Byte>)
    IL_0013: ldarg.1
    IL_0014: ret

}
Span<BitVector4> partition(BitVector32 src, Span<BitVector4> dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.Span`1<System.Byte> Z0.SpanExtensions::AsBytes<Z0.BitVector4>(System.Span`1<Z0.BitVector4>)
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: call System.UInt32 Z0.BitVector32::op_Implicit(Z0.BitVector32)
    IL_000D: ldloc.0
    IL_000E: call System.Void Z0.BitParts::part32x4(System.UInt32,System.Span`1<System.Byte>)
    IL_0013: ldarg.1
    IL_0014: ret

}
Span<BitVector8> partition(BitVector32 src, Span<BitVector8> dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.Span`1<System.Byte> Z0.SpanExtensions::AsBytes<Z0.BitVector8>(System.Span`1<Z0.BitVector8>)
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: call System.UInt32 Z0.BitVector32::op_Implicit(Z0.BitVector32)
    IL_000D: ldloc.0
    IL_000E: call System.Void Z0.BitParts::part32x8(System.UInt32,System.Span`1<System.Byte>)
    IL_0013: ldarg.1
    IL_0014: ret

}
Span<BitVector16> partition(BitVector32 src, Span<BitVector16> dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.Span`1<System.UInt16> Z0.SpanExtensions::AsUInt16<Z0.BitVector16>(System.Span`1<Z0.BitVector16>)
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: call System.UInt32 Z0.BitVector32::op_Implicit(Z0.BitVector32)
    IL_000D: ldloc.0
    IL_000E: call System.Void Z0.BitParts::part32x16(System.UInt32,System.Span`1<System.UInt16>)
    IL_0013: ldarg.1
    IL_0014: ret

}
uint pop(BitVector4 x)
{
    IL_0000: ldarga.s x
    IL_0002: call System.Byte Z0.BitVector4::get_Scalar()
    IL_0007: call System.UInt32 Z0.Bits::pop(System.Byte)
    IL_000C: ret

}
uint pop(BitVector8 x)
{
    IL_0000: ldarga.s x
    IL_0002: call System.Byte Z0.BitVector8::get_Scalar()
    IL_0007: call System.UInt32 Z0.Bits::pop(System.Byte)
    IL_000C: ret

}
uint pop(BitVector16 x)
{
    IL_0000: ldarga.s x
    IL_0002: call System.UInt16 Z0.BitVector16::get_Scalar()
    IL_0007: call System.UInt32 Z0.Bits::pop(System.UInt16)
    IL_000C: ret

}
uint pop(BitVector32 x)
{
    IL_0000: ldarga.s x
    IL_0002: call System.UInt32 Z0.BitVector32::get_Scalar()
    IL_0007: call System.UInt32 Z0.Bits::pop(System.UInt32)
    IL_000C: ret

}
uint pop(BitVector64 x)
{
    IL_0000: ldarga.s x
    IL_0002: call System.UInt64 Z0.BitVector64::get_Scalar()
    IL_0007: call System.UInt32 Z0.Bits::pop(System.UInt64)
    IL_000C: ret

}
BitVector4 sll(BitVector4 x, int offset)
{
    IL_0000: ldarga.s x
    IL_0002: call System.Byte Z0.BitVector4::get_Scalar()
    IL_0007: ldarg.1
    IL_0008: call System.Byte Z0.math::sll(System.Byte,System.Int32)
    IL_000D: stloc.0
    IL_000E: ldloca.s V_0
    IL_0010: call Z0.BitVector4 Z0.BitVector4::op_Implicit(System.Byte&)
    IL_0015: ret

}
BitVector8 sll(BitVector8 x, int offset)
{
    IL_0000: ldarga.s x
    IL_0002: call System.Byte Z0.BitVector8::get_Scalar()
    IL_0007: ldarg.1
    IL_0008: call System.Byte Z0.math::sll(System.Byte,System.Int32)
    IL_000D: call Z0.BitVector8 Z0.BitVector8::op_Implicit(System.Byte)
    IL_0012: ret

}
BitVector16 sll(BitVector16 x, int offset)
{
    IL_0000: ldarga.s x
    IL_0002: call System.UInt16 Z0.BitVector16::get_Scalar()
    IL_0007: ldarg.1
    IL_0008: call System.UInt16 Z0.math::sll(System.UInt16,System.Int32)
    IL_000D: call Z0.BitVector16 Z0.BitVector16::op_Implicit(System.UInt16)
    IL_0012: ret

}
BitVector32 sll(BitVector32 x, int offset)
{
    IL_0000: ldarga.s x
    IL_0002: call System.UInt32 Z0.BitVector32::get_Scalar()
    IL_0007: ldarg.1
    IL_0008: call System.UInt32 Z0.math::sll(System.UInt32,System.Int32)
    IL_000D: call Z0.BitVector32 Z0.BitVector32::op_Implicit(System.UInt32)
    IL_0012: ret

}
BitVector64 sll(BitVector64 x, int offset)
{
    IL_0000: ldarga.s x
    IL_0002: call System.UInt64 Z0.BitVector64::get_Scalar()
    IL_0007: ldarg.1
    IL_0008: call System.UInt64 Z0.math::sll(System.UInt64,System.Int32)
    IL_000D: call Z0.BitVector64 Z0.BitVector64::op_Implicit(System.UInt64)
    IL_0012: ret

}
ref BitVector8 sll(ref BitVector8 x, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: call System.Byte Z0.BitVector8::get_Scalar()
    IL_0007: ldarg.1
    IL_0008: call System.Byte Z0.math::sll(System.Byte,System.Int32)
    IL_000D: call System.Void Z0.BitVector8::assign(System.Byte)
    IL_0012: ldarg.0
    IL_0013: ret

}
ref BitVector16 sll(ref BitVector16 x, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: call System.UInt16 Z0.BitVector16::get_Scalar()
    IL_0007: ldarg.1
    IL_0008: call System.UInt16 Z0.math::sll(System.UInt16,System.Int32)
    IL_000D: call System.Void Z0.BitVector16::assign(System.UInt16)
    IL_0012: ldarg.0
    IL_0013: ret

}
ref BitVector32 sll(ref BitVector32 x, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: call System.UInt32 Z0.BitVector32::get_Scalar()
    IL_0007: ldarg.1
    IL_0008: call System.UInt32 Z0.math::sll(System.UInt32,System.Int32)
    IL_000D: call System.Void Z0.BitVector32::assign(System.UInt32)
    IL_0012: ldarg.0
    IL_0013: ret

}
ref BitVector64 sll(ref BitVector64 x, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: call System.UInt64 Z0.BitVector64::get_Scalar()
    IL_0007: ldarg.1
    IL_0008: call System.UInt64 Z0.math::sll(System.UInt64,System.Int32)
    IL_000D: call System.Void Z0.BitVector64::assign(System.UInt64)
    IL_0012: ldarg.0
    IL_0013: ret

}
BitVector4 srl(BitVector4 x, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Byte Z0.BitVector4::data
    IL_0006: ldarg.1
    IL_0007: call System.Byte Z0.math::srl(System.Byte,System.Int32)
    IL_000C: stloc.0
    IL_000D: ldloca.s V_0
    IL_000F: call Z0.BitVector4 Z0.BitVector4::op_Implicit(System.Byte&)
    IL_0014: ret

}
BitVector8 srl(BitVector8 x, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Byte Z0.BitVector8::data
    IL_0006: ldarg.1
    IL_0007: call System.Byte Z0.math::srl(System.Byte,System.Int32)
    IL_000C: call Z0.BitVector8 Z0.BitVector8::op_Implicit(System.Byte)
    IL_0011: ret

}
BitVector16 srl(BitVector16 x, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.UInt16 Z0.BitVector16::data
    IL_0006: ldarg.1
    IL_0007: call System.UInt16 Z0.math::srl(System.UInt16,System.Int32)
    IL_000C: call Z0.BitVector16 Z0.BitVector16::op_Implicit(System.UInt16)
    IL_0011: ret

}
BitVector32 srl(BitVector32 x, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.UInt32 Z0.BitVector32::data
    IL_0006: ldarg.1
    IL_0007: call System.UInt32 Z0.math::srl(System.UInt32,System.Int32)
    IL_000C: call Z0.BitVector32 Z0.BitVector32::op_Implicit(System.UInt32)
    IL_0011: ret

}
BitVector64 srl(BitVector64 x, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.UInt64 Z0.BitVector64::data
    IL_0006: ldarg.1
    IL_0007: call System.UInt64 Z0.math::srl(System.UInt64,System.Int32)
    IL_000C: call Z0.BitVector64 Z0.BitVector64::op_Implicit(System.UInt64)
    IL_0011: ret

}
ref BitVector8 srl(ref BitVector8 x, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldflda System.Byte Z0.BitVector8::data
    IL_0006: ldarg.1
    IL_0007: call System.Byte& Z0.math::srl(System.Byte&,System.Int32)
    IL_000C: pop
    IL_000D: ldarg.0
    IL_000E: ret

}
ref BitVector16 srl(ref BitVector16 x, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldflda System.UInt16 Z0.BitVector16::data
    IL_0006: ldarg.1
    IL_0007: call System.UInt16& Z0.math::srl(System.UInt16&,System.Int32)
    IL_000C: pop
    IL_000D: ldarg.0
    IL_000E: ret

}
ref BitVector32 srl(ref BitVector32 x, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldflda System.UInt32 Z0.BitVector32::data
    IL_0006: ldarg.1
    IL_0007: call System.UInt32& Z0.math::srl(System.UInt32&,System.Int32)
    IL_000C: pop
    IL_000D: ldarg.0
    IL_000E: ret

}
ref BitVector64 srl(ref BitVector64 x, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldflda System.UInt64 Z0.BitVector64::data
    IL_0006: ldarg.1
    IL_0007: call System.UInt64& Z0.math::srl(System.UInt64&,System.Int32)
    IL_000C: pop
    IL_000D: ldarg.0
    IL_000E: ret

}
BitVector4 sub(BitVector4 x, BitVector4 y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.BitVector4 Z0.BitVector4::op_UnaryNegation(Z0.BitVector4&)
    IL_0009: stloc.0
    IL_000A: ldloca.s V_0
    IL_000C: call Z0.BitVector4 Z0.BitVector4::op_Addition(Z0.BitVector4&,Z0.BitVector4&)
    IL_0011: ret

}
BitVector8 sub(BitVector8 x, BitVector8 y)
{
    IL_0000: ldarg.0
    IL_0001: ldarga.s y
    IL_0003: call Z0.BitVector8 Z0.BitVector8::op_UnaryNegation(Z0.BitVector8&)
    IL_0008: call Z0.BitVector8 Z0.BitVector8::op_Addition(Z0.BitVector8,Z0.BitVector8)
    IL_000D: ret

}
BitVector16 sub(BitVector16 x, BitVector16 y)
{
    IL_0000: ldarg.0
    IL_0001: ldarga.s y
    IL_0003: call Z0.BitVector16 Z0.BitVector16::op_UnaryNegation(Z0.BitVector16&)
    IL_0008: call Z0.BitVector16 Z0.BitVector16::op_Addition(Z0.BitVector16,Z0.BitVector16)
    IL_000D: ret

}
BitVector32 sub(BitVector32 x, BitVector32 y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.BitVector32 Z0.BitVector32::op_UnaryNegation(Z0.BitVector32)
    IL_0007: call Z0.BitVector32 Z0.BitVector32::op_Addition(Z0.BitVector32,Z0.BitVector32)
    IL_000C: ret

}
BitVector64 sub(BitVector64 x, BitVector64 y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.BitVector64 Z0.BitVector64::op_UnaryNegation(Z0.BitVector64)
    IL_0007: call Z0.BitVector64 Z0.BitVector64::op_Addition(Z0.BitVector64,Z0.BitVector64)
    IL_000C: ret

}
BitVector4 xor(BitVector4 x, BitVector4 y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Byte Z0.BitVector4::data
    IL_0006: ldarg.1
    IL_0007: ldfld System.Byte Z0.BitVector4::data
    IL_000C: call System.Byte Z0.math::xor(System.Byte,System.Byte)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.BitVector4 Z0.BitVector4::op_Implicit(System.Byte&)
    IL_0019: ret

}
BitVector8 xor(BitVector8 x, BitVector8 y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Byte Z0.BitVector8::data
    IL_0006: ldarg.1
    IL_0007: ldfld System.Byte Z0.BitVector8::data
    IL_000C: call System.Byte Z0.math::xor(System.Byte,System.Byte)
    IL_0011: call Z0.BitVector8 Z0.BitVector8::op_Implicit(System.Byte)
    IL_0016: ret

}
BitVector16 xor(BitVector16 x, BitVector16 y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.UInt16 Z0.BitVector16::data
    IL_0006: ldarg.1
    IL_0007: ldfld System.UInt16 Z0.BitVector16::data
    IL_000C: call System.UInt16 Z0.math::xor(System.UInt16,System.UInt16)
    IL_0011: call Z0.BitVector16 Z0.BitVector16::op_Implicit(System.UInt16)
    IL_0016: ret

}
BitVector32 xor(in BitVector32 x, in BitVector32 y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.UInt32 Z0.BitVector32::data
    IL_0006: ldarg.1
    IL_0007: ldfld System.UInt32 Z0.BitVector32::data
    IL_000C: call System.UInt32 Z0.math::xor(System.UInt32,System.UInt32)
    IL_0011: call Z0.BitVector32 Z0.BitVector32::op_Implicit(System.UInt32)
    IL_0016: ret

}
BitVector64 xor(BitVector64 x, BitVector64 y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.UInt64 Z0.BitVector64::data
    IL_0006: ldarg.1
    IL_0007: ldfld System.UInt64 Z0.BitVector64::data
    IL_000C: call System.UInt64 Z0.math::xor(System.UInt64,System.UInt64)
    IL_0011: call Z0.BitVector64 Z0.BitVector64::op_Implicit(System.UInt64)
    IL_0016: ret

}
