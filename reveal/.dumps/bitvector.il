// 2019-10-28 07:21:24:634
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
BitVector32 or(BitVector32 x, BitVector32 y)
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
int ord(BitVector8 x)
{
    IL_0000: ldarga.s x
    IL_0002: call Z0.BitVector8 Z0.BitVector8::Replicate()
    IL_0007: stloc.0
    IL_0008: ldc.i4.2
    IL_0009: stloc.1
    IL_000A: br.s IL_0027
    IL_000C: ldloc.0
    IL_000D: ldarg.0
    IL_000E: call Z0.BitVector8 Z0.BitVector8::op_Multiply(Z0.BitVector8,Z0.BitVector8)
    IL_0013: stloc.0
    IL_0014: ldloc.0
    IL_0015: ldsfld Z0.BitVector8 Z0.BitVector8::One
    IL_001A: call System.Boolean Z0.BitVector8::op_Equality(Z0.BitVector8,Z0.BitVector8)
    IL_001F: brfalse.s IL_0023
    IL_0021: ldloc.1
    IL_0022: ret
    IL_0023: ldloc.1
    IL_0024: ldc.i4.1
    IL_0025: add
    IL_0026: stloc.1
    IL_0027: ldloc.1
    IL_0028: ldc.i4 256
    IL_002D: blt.s IL_000C
    IL_002F: ldc.i4.0
    IL_0030: ret

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
ref BitVector16 perm(ref BitVector16 x, in Perm spec)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.BitVector16 Z0.BitVector16::Replicate()
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: stloc.1
    IL_0009: ldarg.0
    IL_000A: call System.Int32 Z0.BitVector16::get_Length()
    IL_000F: stloc.2
    IL_0010: ldc.i4.0
    IL_0011: stloc.3
    IL_0012: br.s IL_0041
    IL_0014: ldarg.1
    IL_0015: ldobj Z0.Perm
    IL_001A: stloc.s V_5
    IL_001C: ldloca.s V_5
    IL_001E: ldloc.3
    IL_001F: call System.Int32& Z0.Perm::get_Item(System.Int32)
    IL_0024: stloc.s V_4
    IL_0026: ldloc.s V_4
    IL_0028: ldind.i4
    IL_0029: ldloc.3
    IL_002A: beq.s IL_003D
    IL_002C: ldloc.1
    IL_002D: ldloc.3
    IL_002E: ldloca.s V_0
    IL_0030: ldloc.s V_4
    IL_0032: ldind.i4
    IL_0033: call Z0.bit Z0.BitVector16::get_Item(System.Int32)
    IL_0038: call System.Void Z0.BitVector16::set_Item(System.Int32,Z0.bit)
    IL_003D: ldloc.3
    IL_003E: ldc.i4.1
    IL_003F: add
    IL_0040: stloc.3
    IL_0041: ldloc.3
    IL_0042: ldloc.2
    IL_0043: blt.s IL_0014
    IL_0045: ldarg.0
    IL_0046: ret

}
BitVector16 perm(BitVector16 x, Perm spec)
{
    IL_0000: ldarga.s x
    IL_0002: call Z0.BitVector16 Z0.BitVector16::Replicate()
    IL_0007: stloc.0
    IL_0008: ldloca.s V_0
    IL_000A: ldarga.s spec
    IL_000C: call Z0.BitVector16& Z0.bitvector::perm(Z0.BitVector16&,Z0.Perm&)
    IL_0011: ldobj Z0.BitVector16
    IL_0016: ret

}
ref BitVector32 perm(ref BitVector32 x, in Perm spec)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.BitVector32 Z0.BitVector32::Replicate()
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: stloc.1
    IL_0009: ldarg.0
    IL_000A: call System.Int32 Z0.BitVector32::get_Length()
    IL_000F: stloc.2
    IL_0010: ldc.i4.0
    IL_0011: stloc.3
    IL_0012: br.s IL_0041
    IL_0014: ldarg.1
    IL_0015: ldobj Z0.Perm
    IL_001A: stloc.s V_5
    IL_001C: ldloca.s V_5
    IL_001E: ldloc.3
    IL_001F: call System.Int32& Z0.Perm::get_Item(System.Int32)
    IL_0024: stloc.s V_4
    IL_0026: ldloc.s V_4
    IL_0028: ldind.i4
    IL_0029: ldloc.3
    IL_002A: beq.s IL_003D
    IL_002C: ldloc.1
    IL_002D: ldloc.3
    IL_002E: ldloca.s V_0
    IL_0030: ldloc.s V_4
    IL_0032: ldind.i4
    IL_0033: call Z0.bit Z0.BitVector32::get_Item(System.Int32)
    IL_0038: call System.Void Z0.BitVector32::set_Item(System.Int32,Z0.bit)
    IL_003D: ldloc.3
    IL_003E: ldc.i4.1
    IL_003F: add
    IL_0040: stloc.3
    IL_0041: ldloc.3
    IL_0042: ldloc.2
    IL_0043: blt.s IL_0014
    IL_0045: ldarg.0
    IL_0046: ret

}
BitVector32 perm(BitVector32 x, Perm spec)
{
    IL_0000: ldarga.s x
    IL_0002: call Z0.BitVector32 Z0.BitVector32::Replicate()
    IL_0007: stloc.0
    IL_0008: ldloca.s V_0
    IL_000A: ldarga.s spec
    IL_000C: call Z0.BitVector32& Z0.bitvector::perm(Z0.BitVector32&,Z0.Perm&)
    IL_0011: ldobj Z0.BitVector32
    IL_0016: ret

}
ref BitVector64 perm(ref BitVector64 x, in Perm spec)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.BitVector64 Z0.BitVector64::Replicate()
    IL_0006: stloc.0
    IL_0007: ldarg.0
    IL_0008: stloc.1
    IL_0009: ldarg.0
    IL_000A: call System.Int32 Z0.BitVector64::get_Length()
    IL_000F: stloc.2
    IL_0010: ldc.i4.0
    IL_0011: stloc.3
    IL_0012: br.s IL_0041
    IL_0014: ldarg.1
    IL_0015: ldobj Z0.Perm
    IL_001A: stloc.s V_5
    IL_001C: ldloca.s V_5
    IL_001E: ldloc.3
    IL_001F: call System.Int32& Z0.Perm::get_Item(System.Int32)
    IL_0024: stloc.s V_4
    IL_0026: ldloc.s V_4
    IL_0028: ldind.i4
    IL_0029: ldloc.3
    IL_002A: beq.s IL_003D
    IL_002C: ldloc.1
    IL_002D: ldloc.3
    IL_002E: ldloca.s V_0
    IL_0030: ldloc.s V_4
    IL_0032: ldind.i4
    IL_0033: call Z0.bit Z0.BitVector64::get_Item(System.Int32)
    IL_0038: call System.Void Z0.BitVector64::set_Item(System.Int32,Z0.bit)
    IL_003D: ldloc.3
    IL_003E: ldc.i4.1
    IL_003F: add
    IL_0040: stloc.3
    IL_0041: ldloc.3
    IL_0042: ldloc.2
    IL_0043: blt.s IL_0014
    IL_0045: ldarg.0
    IL_0046: ret

}
BitVector64 perm(BitVector64 x, Perm spec)
{
    IL_0000: ldarga.s x
    IL_0002: call Z0.BitVector64 Z0.BitVector64::Replicate()
    IL_0007: stloc.0
    IL_0008: ldloca.s V_0
    IL_000A: ldarga.s spec
    IL_000C: call Z0.BitVector64& Z0.bitvector::perm(Z0.BitVector64&,Z0.Perm&)
    IL_0011: ldobj Z0.BitVector64
    IL_0016: ret

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
BitVector8 pow(BitVector8 x, int n)
{
    IL_0000: ldarg.1
    IL_0001: brtrue.s IL_0009
    IL_0003: ldsfld Z0.BitVector8 Z0.BitVector8::Zero
    IL_0008: ret
    IL_0009: ldarg.1
    IL_000A: ldc.i4.1
    IL_000B: bne.un.s IL_000F
    IL_000D: ldarg.0
    IL_000E: ret
    IL_000F: ldarga.s x
    IL_0011: call Z0.BitVector8 Z0.BitVector8::Replicate()
    IL_0016: stloc.0
    IL_0017: ldc.i4.2
    IL_0018: stloc.1
    IL_0019: br.s IL_0027
    IL_001B: ldloc.0
    IL_001C: ldarg.0
    IL_001D: call Z0.BitVector8 Z0.BitVector8::op_Multiply(Z0.BitVector8,Z0.BitVector8)
    IL_0022: stloc.0
    IL_0023: ldloc.1
    IL_0024: ldc.i4.1
    IL_0025: add
    IL_0026: stloc.1
    IL_0027: ldloc.1
    IL_0028: ldarg.1
    IL_0029: ble.s IL_001B
    IL_002B: ldloc.0
    IL_002C: ret

}
BitVector4 rev(BitVector4 x)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Byte Z0.BitVector4::data
    IL_0006: call System.Byte Z0.Bits::rev(System.Byte)
    IL_000B: stloc.0
    IL_000C: ldloca.s V_0
    IL_000E: call Z0.BitVector4 Z0.BitVector4::op_Implicit(System.Byte&)
    IL_0013: ret

}
BitVector8 rev(BitVector8 x)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Byte Z0.BitVector8::data
    IL_0006: call System.Byte Z0.Bits::rev(System.Byte)
    IL_000B: call Z0.BitVector8 Z0.BitVector8::op_Implicit(System.Byte)
    IL_0010: ret

}
BitVector16 rev(BitVector16 x)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.UInt16 Z0.BitVector16::data
    IL_0006: call System.UInt16 Z0.Bits::rev(System.UInt16)
    IL_000B: call Z0.BitVector16 Z0.BitVector16::op_Implicit(System.UInt16)
    IL_0010: ret

}
BitVector32 rev(BitVector32 x)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.UInt32 Z0.BitVector32::data
    IL_0006: call System.UInt32 Z0.Bits::rev(System.UInt32)
    IL_000B: call Z0.BitVector32 Z0.BitVector32::op_Implicit(System.UInt32)
    IL_0010: ret

}
BitVector8 rotl(BitVector8 x, int offset)
{
    IL_0000: ldarga.s x
    IL_0002: call System.Byte Z0.BitVector8::get_Scalar()
    IL_0007: ldarg.1
    IL_0008: call System.Byte Z0.Bits::rotl(System.Byte,System.Int32)
    IL_000D: call Z0.BitVector8 Z0.BitVector8::op_Implicit(System.Byte)
    IL_0012: ret

}
BitVector16 rotl(BitVector16 x, int offset)
{
    IL_0000: ldarga.s x
    IL_0002: call System.UInt16 Z0.BitVector16::get_Scalar()
    IL_0007: ldarg.1
    IL_0008: call System.UInt16 Z0.Bits::rotl(System.UInt16,System.Int32)
    IL_000D: call Z0.BitVector16 Z0.BitVector16::op_Implicit(System.UInt16)
    IL_0012: ret

}
BitVector32 rotl(BitVector32 x, int offset)
{
    IL_0000: ldarga.s x
    IL_0002: call System.UInt32 Z0.BitVector32::get_Scalar()
    IL_0007: ldarg.1
    IL_0008: call System.UInt32 Z0.Bits::rotl(System.UInt32,System.Int32)
    IL_000D: call Z0.BitVector32 Z0.BitVector32::op_Implicit(System.UInt32)
    IL_0012: ret

}
BitVector64 rotl(BitVector64 x, int offset)
{
    IL_0000: ldarga.s x
    IL_0002: call System.UInt64 Z0.BitVector64::get_Scalar()
    IL_0007: ldarg.1
    IL_0008: call System.UInt64 Z0.Bits::rotl(System.UInt64,System.Int32)
    IL_000D: call Z0.BitVector64 Z0.BitVector64::op_Implicit(System.UInt64)
    IL_0012: ret

}
BitVector4 rotr(BitVector4 x, int offset)
{
    IL_0000: ldarga.s x
    IL_0002: call System.Byte Z0.BitVector4::get_Scalar()
    IL_0007: ldarg.1
    IL_0008: call System.Byte Z0.Bits::rotr(System.Byte,System.Int32)
    IL_000D: stloc.0
    IL_000E: ldloca.s V_0
    IL_0010: call Z0.BitVector4 Z0.BitVector4::op_Implicit(System.Byte&)
    IL_0015: ret

}
BitVector8 rotr(BitVector8 x, int offset)
{
    IL_0000: ldarga.s x
    IL_0002: call System.Byte Z0.BitVector8::get_Scalar()
    IL_0007: ldarg.1
    IL_0008: call System.Byte Z0.Bits::rotr(System.Byte,System.Int32)
    IL_000D: call Z0.BitVector8 Z0.BitVector8::op_Implicit(System.Byte)
    IL_0012: ret

}
BitVector16 rotr(BitVector16 x, int offset)
{
    IL_0000: ldarga.s x
    IL_0002: call System.UInt16 Z0.BitVector16::get_Scalar()
    IL_0007: ldarg.1
    IL_0008: call System.UInt16 Z0.Bits::rotr(System.UInt16,System.Int32)
    IL_000D: call Z0.BitVector16 Z0.BitVector16::op_Implicit(System.UInt16)
    IL_0012: ret

}
BitVector32 rotr(BitVector32 x, int offset)
{
    IL_0000: ldarga.s x
    IL_0002: call System.UInt32 Z0.BitVector32::get_Scalar()
    IL_0007: ldarg.1
    IL_0008: call System.UInt32 Z0.Bits::rotr(System.UInt32,System.Int32)
    IL_000D: call Z0.BitVector32 Z0.BitVector32::op_Implicit(System.UInt32)
    IL_0012: ret

}
BitVector64 rotr(BitVector64 x, int offset)
{
    IL_0000: ldarga.s x
    IL_0002: call System.UInt64 Z0.BitVector64::get_Scalar()
    IL_0007: ldarg.1
    IL_0008: call System.UInt64 Z0.Bits::rotr(System.UInt64,System.Int32)
    IL_000D: call Z0.BitVector64 Z0.BitVector64::op_Implicit(System.UInt64)
    IL_0012: ret

}
BitVector4 select(BitVector4 x, BitVector4 y, BitVector4 z)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Byte Z0.BitVector4::data
    IL_0006: ldarg.1
    IL_0007: ldfld System.Byte Z0.BitVector4::data
    IL_000C: ldarg.2
    IL_000D: ldfld System.Byte Z0.BitVector4::data
    IL_0012: call System.Byte Z0.gmath::select<System.Byte>(System.Byte,System.Byte,System.Byte)
    IL_0017: stloc.0
    IL_0018: ldloca.s V_0
    IL_001A: call Z0.BitVector4 Z0.BitVector4::op_Implicit(System.Byte&)
    IL_001F: ret

}
BitVector8 select(BitVector8 x, BitVector8 y, BitVector8 z)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Byte Z0.BitVector8::data
    IL_0006: ldarg.1
    IL_0007: ldfld System.Byte Z0.BitVector8::data
    IL_000C: ldarg.2
    IL_000D: ldfld System.Byte Z0.BitVector8::data
    IL_0012: call System.Byte Z0.gmath::select<System.Byte>(System.Byte,System.Byte,System.Byte)
    IL_0017: call Z0.BitVector8 Z0.BitVector8::op_Implicit(System.Byte)
    IL_001C: ret

}
BitVector16 select(BitVector16 x, BitVector16 y, BitVector16 z)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.UInt16 Z0.BitVector16::data
    IL_0006: ldarg.1
    IL_0007: ldfld System.UInt16 Z0.BitVector16::data
    IL_000C: ldarg.2
    IL_000D: ldfld System.UInt16 Z0.BitVector16::data
    IL_0012: call System.UInt16 Z0.gmath::select<System.UInt16>(System.UInt16,System.UInt16,System.UInt16)
    IL_0017: call Z0.BitVector16 Z0.BitVector16::op_Implicit(System.UInt16)
    IL_001C: ret

}
BitVector32 select(BitVector32 x, BitVector32 y, BitVector32 z)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.UInt32 Z0.BitVector32::data
    IL_0006: ldarg.1
    IL_0007: ldfld System.UInt32 Z0.BitVector32::data
    IL_000C: ldarg.2
    IL_000D: ldfld System.UInt32 Z0.BitVector32::data
    IL_0012: call System.UInt32 Z0.gmath::select<System.UInt32>(System.UInt32,System.UInt32,System.UInt32)
    IL_0017: call Z0.BitVector32 Z0.BitVector32::op_Implicit(System.UInt32)
    IL_001C: ret

}
BitVector64 select(BitVector64 x, BitVector64 y, BitVector64 z)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.UInt64 Z0.BitVector64::data
    IL_0006: ldarg.1
    IL_0007: ldfld System.UInt64 Z0.BitVector64::data
    IL_000C: ldarg.2
    IL_000D: ldfld System.UInt64 Z0.BitVector64::data
    IL_0012: call System.UInt64 Z0.gmath::select<System.UInt64>(System.UInt64,System.UInt64,System.UInt64)
    IL_0017: call Z0.BitVector64 Z0.BitVector64::op_Implicit(System.UInt64)
    IL_001C: ret

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
BitVector4 sub(BitVector4 x, BitVector4 y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Byte Z0.BitVector4::data
    IL_0006: ldarg.1
    IL_0007: ldfld System.Byte Z0.BitVector4::data
    IL_000C: call System.UInt32 Z0.math::sub(System.UInt32,System.UInt32)
    IL_0011: call System.UInt32 Z0.Mod16::mod(System.UInt32)
    IL_0016: conv.u1
    IL_0017: stloc.0
    IL_0018: ldloca.s V_0
    IL_001A: call Z0.BitVector4 Z0.BitVector4::op_Implicit(System.Byte&)
    IL_001F: ret

}
BitVector8 sub(BitVector8 x, BitVector8 y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Byte Z0.BitVector8::data
    IL_0006: ldarg.1
    IL_0007: ldfld System.Byte Z0.BitVector8::data
    IL_000C: call System.Byte Z0.math::sub(System.Byte,System.Byte)
    IL_0011: call Z0.BitVector8 Z0.BitVector8::op_Implicit(System.Byte)
    IL_0016: ret

}
BitVector16 sub(BitVector16 x, BitVector16 y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.UInt16 Z0.BitVector16::data
    IL_0006: ldarg.1
    IL_0007: ldfld System.UInt16 Z0.BitVector16::data
    IL_000C: call System.UInt16 Z0.math::sub(System.UInt16,System.UInt16)
    IL_0011: call Z0.BitVector16 Z0.BitVector16::op_Implicit(System.UInt16)
    IL_0016: ret

}
BitVector32 sub(BitVector32 x, BitVector32 y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.UInt32 Z0.BitVector32::data
    IL_0006: ldarg.1
    IL_0007: ldfld System.UInt32 Z0.BitVector32::data
    IL_000C: call System.UInt32 Z0.math::sub(System.UInt32,System.UInt32)
    IL_0011: call Z0.BitVector32 Z0.BitVector32::op_Implicit(System.UInt32)
    IL_0016: ret

}
BitVector64 sub(BitVector64 x, BitVector64 y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.UInt64 Z0.BitVector64::data
    IL_0006: ldarg.1
    IL_0007: ldfld System.UInt64 Z0.BitVector64::data
    IL_000C: call System.UInt64 Z0.math::sub(System.UInt64,System.UInt64)
    IL_0011: call Z0.BitVector64 Z0.BitVector64::op_Implicit(System.UInt64)
    IL_0016: ret

}
BitVector4 xnor(BitVector4 x, BitVector4 y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Byte Z0.BitVector4::data
    IL_0006: ldarg.1
    IL_0007: ldfld System.Byte Z0.BitVector4::data
    IL_000C: call System.Byte Z0.math::xnor(System.Byte,System.Byte)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.BitVector4 Z0.BitVector4::op_Implicit(System.Byte&)
    IL_0019: ret

}
BitVector8 xnor(BitVector8 x, BitVector8 y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Byte Z0.BitVector8::data
    IL_0006: ldarg.1
    IL_0007: ldfld System.Byte Z0.BitVector8::data
    IL_000C: call System.Byte Z0.math::xnor(System.Byte,System.Byte)
    IL_0011: call Z0.BitVector8 Z0.BitVector8::op_Implicit(System.Byte)
    IL_0016: ret

}
BitVector16 xnor(BitVector16 x, BitVector16 y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.UInt16 Z0.BitVector16::data
    IL_0006: ldarg.1
    IL_0007: ldfld System.UInt16 Z0.BitVector16::data
    IL_000C: call System.UInt16 Z0.math::xnor(System.UInt16,System.UInt16)
    IL_0011: call Z0.BitVector16 Z0.BitVector16::op_Implicit(System.UInt16)
    IL_0016: ret

}
BitVector32 xnor(BitVector32 x, BitVector32 y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.UInt32 Z0.BitVector32::data
    IL_0006: ldarg.1
    IL_0007: ldfld System.UInt32 Z0.BitVector32::data
    IL_000C: call System.UInt32 Z0.math::xnor(System.UInt32,System.UInt32)
    IL_0011: call Z0.BitVector32 Z0.BitVector32::op_Implicit(System.UInt32)
    IL_0016: ret

}
BitVector64 xnor(BitVector64 x, BitVector64 y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.UInt64 Z0.BitVector64::data
    IL_0006: ldarg.1
    IL_0007: ldfld System.UInt64 Z0.BitVector64::data
    IL_000C: call System.UInt64 Z0.math::xnor(System.UInt64,System.UInt64)
    IL_0011: call Z0.BitVector64 Z0.BitVector64::op_Implicit(System.UInt64)
    IL_0016: ret

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
BitVector32 xor(BitVector32 x, BitVector32 y)
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
BitVector4 add(BitVector4 x, BitVector4 y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Byte Z0.BitVector4::data
    IL_0006: ldarg.1
    IL_0007: ldfld System.Byte Z0.BitVector4::data
    IL_000C: call System.Byte Z0.math::add(System.Byte,System.Byte)
    IL_0011: call System.UInt32 Z0.Mod16::mod(System.UInt32)
    IL_0016: conv.u1
    IL_0017: newobj System.Void Z0.BitVector4::.ctor(System.Byte)
    IL_001C: ret

}
BitVector8 add(BitVector8 x, BitVector8 y)
{
    IL_0000: ldarga.s x
    IL_0002: call System.Byte Z0.BitVector8::get_Scalar()
    IL_0007: ldarga.s y
    IL_0009: call System.Byte Z0.BitVector8::get_Scalar()
    IL_000E: call System.Byte Z0.math::add(System.Byte,System.Byte)
    IL_0013: call Z0.BitVector8 Z0.BitVector8::op_Implicit(System.Byte)
    IL_0018: ret

}
BitVector16 add(BitVector16 x, BitVector16 y)
{
    IL_0000: ldarga.s x
    IL_0002: call System.UInt16 Z0.BitVector16::get_Scalar()
    IL_0007: ldarga.s y
    IL_0009: call System.UInt16 Z0.BitVector16::get_Scalar()
    IL_000E: call System.UInt16 Z0.math::add(System.UInt16,System.UInt16)
    IL_0013: call Z0.BitVector16 Z0.BitVector16::op_Implicit(System.UInt16)
    IL_0018: ret

}
BitVector32 add(BitVector32 x, BitVector32 y)
{
    IL_0000: ldarga.s x
    IL_0002: call System.UInt32 Z0.BitVector32::get_Scalar()
    IL_0007: ldarga.s y
    IL_0009: call System.UInt32 Z0.BitVector32::get_Scalar()
    IL_000E: call System.UInt32 Z0.math::add(System.UInt32,System.UInt32)
    IL_0013: call Z0.BitVector32 Z0.BitVector32::op_Implicit(System.UInt32)
    IL_0018: ret

}
BitVector64 add(BitVector64 x, BitVector64 y)
{
    IL_0000: ldarga.s x
    IL_0002: call System.UInt64 Z0.BitVector64::get_Scalar()
    IL_0007: ldarga.s y
    IL_0009: call System.UInt64 Z0.BitVector64::get_Scalar()
    IL_000E: call System.UInt64 Z0.math::add(System.UInt64,System.UInt64)
    IL_0013: call Z0.BitVector64 Z0.BitVector64::op_Implicit(System.UInt64)
    IL_0018: ret

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
BitVector4 andnot(BitVector4 x, BitVector4 y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Byte Z0.BitVector4::data
    IL_0006: ldarg.1
    IL_0007: ldfld System.Byte Z0.BitVector4::data
    IL_000C: call System.Byte Z0.math::andnot(System.Byte,System.Byte)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.BitVector4 Z0.BitVector4::op_Implicit(System.Byte&)
    IL_0019: ret

}
BitVector8 andnot(BitVector8 x, BitVector8 y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Byte Z0.BitVector8::data
    IL_0006: ldarg.1
    IL_0007: ldfld System.Byte Z0.BitVector8::data
    IL_000C: call System.Byte Z0.math::andnot(System.Byte,System.Byte)
    IL_0011: call Z0.BitVector8 Z0.BitVector8::op_Implicit(System.Byte)
    IL_0016: ret

}
BitVector16 andnot(BitVector16 x, BitVector16 y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.UInt16 Z0.BitVector16::data
    IL_0006: ldarg.1
    IL_0007: ldfld System.UInt16 Z0.BitVector16::data
    IL_000C: call System.UInt16 Z0.math::andnot(System.UInt16,System.UInt16)
    IL_0011: call Z0.BitVector16 Z0.BitVector16::op_Implicit(System.UInt16)
    IL_0016: ret

}
BitVector32 andnot(BitVector32 x, BitVector32 y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.UInt32 Z0.BitVector32::data
    IL_0006: ldarg.1
    IL_0007: ldfld System.UInt32 Z0.BitVector32::data
    IL_000C: call System.UInt32 Z0.math::andnot(System.UInt32,System.UInt32)
    IL_0011: call Z0.BitVector32 Z0.BitVector32::op_Implicit(System.UInt32)
    IL_0016: ret

}
BitVector64 andnot(BitVector64 x, BitVector64 y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.UInt64 Z0.BitVector64::data
    IL_0006: ldarg.1
    IL_0007: ldfld System.UInt64 Z0.BitVector64::data
    IL_000C: call System.UInt64 Z0.math::andnot(System.UInt64,System.UInt64)
    IL_0011: call Z0.BitVector64 Z0.BitVector64::op_Implicit(System.UInt64)
    IL_0016: ret

}
BitVector4 between(BitVector4 x, int first, int last)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Byte Z0.BitVector4::data
    IL_0006: ldarg.1
    IL_0007: conv.u1
    IL_0008: ldarg.2
    IL_0009: conv.u1
    IL_000A: call System.Byte Z0.Bits::between(System.Byte,System.Byte,System.Byte)
    IL_000F: stloc.0
    IL_0010: ldloca.s V_0
    IL_0012: call Z0.BitVector4 Z0.BitVector4::op_Implicit(System.Byte&)
    IL_0017: ret

}
BitVector8 between(BitVector8 x, int first, int last)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Byte Z0.BitVector8::data
    IL_0006: ldarg.1
    IL_0007: conv.u1
    IL_0008: ldarg.2
    IL_0009: conv.u1
    IL_000A: call System.Byte Z0.Bits::between(System.Byte,System.Byte,System.Byte)
    IL_000F: call Z0.BitVector8 Z0.BitVector8::op_Implicit(System.Byte)
    IL_0014: ret

}
BitVector16 between(BitVector16 x, int first, int last)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.UInt16 Z0.BitVector16::data
    IL_0006: ldarg.1
    IL_0007: conv.u1
    IL_0008: ldarg.2
    IL_0009: conv.u1
    IL_000A: call System.UInt16 Z0.Bits::between(System.UInt16,System.Byte,System.Byte)
    IL_000F: call Z0.BitVector16 Z0.BitVector16::op_Implicit(System.UInt16)
    IL_0014: ret

}
BitVector32 between(BitVector32 x, int first, int last)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.UInt32 Z0.BitVector32::data
    IL_0006: ldarg.1
    IL_0007: conv.u1
    IL_0008: ldarg.2
    IL_0009: conv.u1
    IL_000A: call System.UInt32 Z0.Bits::between(System.UInt32,System.Byte,System.Byte)
    IL_000F: call Z0.BitVector32 Z0.BitVector32::op_Implicit(System.UInt32)
    IL_0014: ret

}
BitVector64 between(BitVector64 x, int first, int last)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.UInt64 Z0.BitVector64::data
    IL_0006: ldarg.1
    IL_0007: conv.u1
    IL_0008: ldarg.2
    IL_0009: conv.u1
    IL_000A: call System.UInt64 Z0.Bits::between(System.UInt64,System.Byte,System.Byte)
    IL_000F: call Z0.BitVector64 Z0.BitVector64::op_Implicit(System.UInt64)
    IL_0014: ret

}
BitVector4 dec(BitVector4 x)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Byte Z0.BitVector4::data
    IL_0006: ldc.i4.0
    IL_0007: ble.s IL_0020
    IL_0009: ldarga.s x
    IL_000B: ldflda System.Byte Z0.BitVector4::data
    IL_0010: dup
    IL_0011: ldind.u1
    IL_0012: stloc.0
    IL_0013: ldloc.0
    IL_0014: ldc.i4.1
    IL_0015: sub
    IL_0016: conv.u1
    IL_0017: stind.i1
    IL_0018: ldloca.s V_0
    IL_001A: call Z0.BitVector4 Z0.BitVector4::op_Implicit(System.Byte&)
    IL_001F: ret
    IL_0020: ldc.i4.s 15
    IL_0022: stloc.0
    IL_0023: ldloca.s V_0
    IL_0025: call Z0.BitVector4 Z0.BitVector4::op_Implicit(System.Byte&)
    IL_002A: ret

}
BitVector8 dec(BitVector8 x)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Byte Z0.BitVector8::data
    IL_0006: call System.Byte Z0.math::dec(System.Byte)
    IL_000B: call Z0.BitVector8 Z0.BitVector8::op_Implicit(System.Byte)
    IL_0010: ret

}
BitVector16 dec(BitVector16 x)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.UInt16 Z0.BitVector16::data
    IL_0006: call System.UInt16 Z0.math::dec(System.UInt16)
    IL_000B: call Z0.BitVector16 Z0.BitVector16::op_Implicit(System.UInt16)
    IL_0010: ret

}
BitVector32 dec(BitVector32 x)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.UInt32 Z0.BitVector32::data
    IL_0006: call System.UInt32 Z0.math::dec(System.UInt32)
    IL_000B: call Z0.BitVector32 Z0.BitVector32::op_Implicit(System.UInt32)
    IL_0010: ret

}
BitVector64 dec(BitVector64 x)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.UInt64 Z0.BitVector64::data
    IL_0006: call System.UInt64 Z0.math::dec(System.UInt64)
    IL_000B: call Z0.BitVector64 Z0.BitVector64::op_Implicit(System.UInt64)
    IL_0010: ret

}
uint dist(BitVector4 x, BitVector4 y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Byte Z0.BitVector4::data
    IL_0006: ldarg.1
    IL_0007: ldfld System.Byte Z0.BitVector4::data
    IL_000C: call System.Byte Z0.math::xor(System.Byte,System.Byte)
    IL_0011: call System.UInt32 Z0.Bits::pop(System.Byte)
    IL_0016: ret

}
uint dist(BitVector8 x, BitVector8 y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Byte Z0.BitVector8::data
    IL_0006: ldarg.1
    IL_0007: ldfld System.Byte Z0.BitVector8::data
    IL_000C: call System.Byte Z0.math::xor(System.Byte,System.Byte)
    IL_0011: call System.UInt32 Z0.Bits::pop(System.Byte)
    IL_0016: ret

}
uint dist(BitVector16 x, BitVector16 y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.UInt16 Z0.BitVector16::data
    IL_0006: ldarg.1
    IL_0007: ldfld System.UInt16 Z0.BitVector16::data
    IL_000C: call System.UInt16 Z0.math::xor(System.UInt16,System.UInt16)
    IL_0011: call System.UInt32 Z0.Bits::pop(System.UInt16)
    IL_0016: ret

}
uint dist(BitVector32 x, BitVector32 y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.UInt32 Z0.BitVector32::data
    IL_0006: ldarg.1
    IL_0007: ldfld System.UInt32 Z0.BitVector32::data
    IL_000C: call System.UInt32 Z0.math::xor(System.UInt32,System.UInt32)
    IL_0011: call System.UInt32 Z0.Bits::pop(System.UInt32)
    IL_0016: ret

}
uint dist(BitVector64 x, BitVector64 y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.UInt64 Z0.BitVector64::data
    IL_0006: ldarg.1
    IL_0007: ldfld System.UInt64 Z0.BitVector64::data
    IL_000C: call System.UInt64 Z0.math::xor(System.UInt64,System.UInt64)
    IL_0011: call System.UInt32 Z0.Bits::pop(System.UInt64)
    IL_0016: ret

}
bit dot(BitVector4 x, BitVector4 y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Byte Z0.BitVector4::data
    IL_0006: ldarg.1
    IL_0007: ldfld System.Byte Z0.BitVector4::data
    IL_000C: and
    IL_000D: call System.UInt32 Z0.Bits::pop(System.Int32)
    IL_0012: call System.Boolean zfunc::odd(System.UInt32)
    IL_0017: call Z0.bit Z0.bit::op_Implicit(System.Boolean)
    IL_001C: ret

}
bit dot(BitVector8 x, BitVector8 y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Byte Z0.BitVector8::data
    IL_0006: ldarg.1
    IL_0007: ldfld System.Byte Z0.BitVector8::data
    IL_000C: and
    IL_000D: call System.UInt32 Z0.Bits::pop(System.Int32)
    IL_0012: call System.Boolean zfunc::odd(System.UInt32)
    IL_0017: call Z0.bit Z0.bit::op_Implicit(System.Boolean)
    IL_001C: ret

}
bit dot(BitVector16 x, BitVector16 y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.UInt16 Z0.BitVector16::data
    IL_0006: ldarg.1
    IL_0007: ldfld System.UInt16 Z0.BitVector16::data
    IL_000C: and
    IL_000D: call System.UInt32 Z0.Bits::pop(System.Int32)
    IL_0012: call System.Boolean zfunc::odd(System.UInt32)
    IL_0017: call Z0.bit Z0.bit::op_Implicit(System.Boolean)
    IL_001C: ret

}
bit dot(BitVector32 x, BitVector32 y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.UInt32 Z0.BitVector32::data
    IL_0006: ldarg.1
    IL_0007: ldfld System.UInt32 Z0.BitVector32::data
    IL_000C: and
    IL_000D: call System.UInt32 Z0.Bits::pop(System.UInt32)
    IL_0012: call System.Boolean zfunc::odd(System.UInt32)
    IL_0017: call Z0.bit Z0.bit::op_Implicit(System.Boolean)
    IL_001C: ret

}
bit dot(BitVector64 x, BitVector64 y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.UInt64 Z0.BitVector64::data
    IL_0006: ldarg.1
    IL_0007: ldfld System.UInt64 Z0.BitVector64::data
    IL_000C: and
    IL_000D: call System.UInt32 Z0.Bits::pop(System.UInt64)
    IL_0012: call System.Boolean zfunc::odd(System.UInt32)
    IL_0017: call Z0.bit Z0.bit::op_Implicit(System.Boolean)
    IL_001C: ret

}
BitVector8 Gather(BitVector8 src, BitVector8 spec)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Byte Z0.BitVector8::data
    IL_0006: ldarg.1
    IL_0007: ldfld System.Byte Z0.BitVector8::data
    IL_000C: call System.Byte Z0.Bits::gather(System.Byte,System.Byte)
    IL_0011: call Z0.BitVector8 Z0.BitVector8::op_Implicit(System.Byte)
    IL_0016: ret

}
BitVector16 Gather(BitVector16 src, BitVector16 spec)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.UInt16 Z0.BitVector16::data
    IL_0006: ldarg.1
    IL_0007: ldfld System.UInt16 Z0.BitVector16::data
    IL_000C: call System.UInt16 Z0.Bits::gather(System.UInt16,System.UInt16)
    IL_0011: call Z0.BitVector16 Z0.BitVector16::op_Implicit(System.UInt16)
    IL_0016: ret

}
BitVector32 Gather(BitVector32 src, BitVector32 spec)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.UInt32 Z0.BitVector32::data
    IL_0006: ldarg.1
    IL_0007: ldfld System.UInt32 Z0.BitVector32::data
    IL_000C: call System.UInt32 Z0.Bits::gather(System.UInt32,System.UInt32)
    IL_0011: call Z0.BitVector32 Z0.BitVector32::op_Implicit(System.UInt32)
    IL_0016: ret

}
BitVector64 Gather(BitVector64 src, BitVector64 spec)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.UInt64 Z0.BitVector64::data
    IL_0006: ldarg.1
    IL_0007: ldfld System.UInt64 Z0.BitVector64::data
    IL_000C: call System.UInt64 Z0.Bits::gather(System.UInt64,System.UInt64)
    IL_0011: call Z0.BitVector64 Z0.BitVector64::op_Implicit(System.UInt64)
    IL_0016: ret

}
BitVector8 gfmul(BitVector8 x, BitVector8 y)
{
    IL_0000: ldarg.0
    IL_0001: call System.Byte Z0.BitVector8::op_Implicit(Z0.BitVector8)
    IL_0006: ldarg.1
    IL_0007: call System.Byte Z0.BitVector8::op_Implicit(Z0.BitVector8)
    IL_000C: call System.Byte Z0.Gf256::clmul(System.Byte,System.Byte)
    IL_0011: call Z0.BitVector8 Z0.BitVector8::op_Implicit(System.Byte)
    IL_0016: ret

}
ref BitVector8 gfmul(ref BitVector8 x, BitVector8 y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.BitVector8
    IL_0007: ldarg.1
    IL_0008: call Z0.BitVector8 Z0.bitvector::gfmul(Z0.BitVector8,Z0.BitVector8)
    IL_000D: stobj Z0.BitVector8
    IL_0012: ldarg.0
    IL_0013: ret

}
BitVector4 inc(BitVector4 x)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Byte Z0.BitVector4::data
    IL_0006: ldc.i4.s 15
    IL_0008: bge.s IL_0021
    IL_000A: ldarga.s x
    IL_000C: ldflda System.Byte Z0.BitVector4::data
    IL_0011: dup
    IL_0012: ldind.u1
    IL_0013: stloc.0
    IL_0014: ldloc.0
    IL_0015: ldc.i4.1
    IL_0016: add
    IL_0017: conv.u1
    IL_0018: stind.i1
    IL_0019: ldloca.s V_0
    IL_001B: call Z0.BitVector4 Z0.BitVector4::op_Implicit(System.Byte&)
    IL_0020: ret
    IL_0021: call Z0.BitVector4 Z0.BitVector4::get_Zero()
    IL_0026: ret

}
BitVector8 inc(BitVector8 x)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Byte Z0.BitVector8::data
    IL_0006: call System.Byte Z0.math::inc(System.Byte)
    IL_000B: call Z0.BitVector8 Z0.BitVector8::op_Implicit(System.Byte)
    IL_0010: ret

}
BitVector16 inc(BitVector16 x)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.UInt16 Z0.BitVector16::data
    IL_0006: call System.UInt16 Z0.math::inc(System.UInt16)
    IL_000B: call Z0.BitVector16 Z0.BitVector16::op_Implicit(System.UInt16)
    IL_0010: ret

}
BitVector32 inc(BitVector32 x)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.UInt32 Z0.BitVector32::data
    IL_0006: call System.UInt32 Z0.math::inc(System.UInt32)
    IL_000B: call Z0.BitVector32 Z0.BitVector32::op_Implicit(System.UInt32)
    IL_0010: ret

}
BitVector64 inc(BitVector64 x)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.UInt64 Z0.BitVector64::data
    IL_0006: call System.UInt64 Z0.math::inc(System.UInt64)
    IL_000B: call Z0.BitVector64 Z0.BitVector64::op_Implicit(System.UInt64)
    IL_0010: ret

}
BitVector4 lsb(BitVector4 x, int n)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: ldarg.1
    IL_0003: ldc.i4.1
    IL_0004: sub
    IL_0005: call Z0.BitVector4 Z0.bitvector::between(Z0.BitVector4,System.Int32,System.Int32)
    IL_000A: ret

}
BitVector8 lsb(BitVector8 x, int n)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: ldarg.1
    IL_0003: ldc.i4.1
    IL_0004: sub
    IL_0005: call Z0.BitVector8 Z0.bitvector::between(Z0.BitVector8,System.Int32,System.Int32)
    IL_000A: ret

}
BitVector16 lsb(BitVector16 x, int n)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.UInt16 Z0.BitVector16::data
    IL_0006: call Z0.BitVector16 Z0.BitVector16::op_Implicit(System.UInt16)
    IL_000B: ldc.i4.0
    IL_000C: ldarg.1
    IL_000D: ldc.i4.1
    IL_000E: sub
    IL_000F: call Z0.BitVector16 Z0.bitvector::between(Z0.BitVector16,System.Int32,System.Int32)
    IL_0014: ret

}
BitVector32 lsb(BitVector32 x, int n)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.UInt32 Z0.BitVector32::data
    IL_0006: call Z0.BitVector32 Z0.BitVector32::op_Implicit(System.UInt32)
    IL_000B: ldc.i4.0
    IL_000C: ldarg.1
    IL_000D: ldc.i4.1
    IL_000E: sub
    IL_000F: call Z0.BitVector32 Z0.bitvector::between(Z0.BitVector32,System.Int32,System.Int32)
    IL_0014: ret

}
BitVector64 lsb(BitVector64 x, int n)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.UInt64 Z0.BitVector64::data
    IL_0006: call Z0.BitVector64 Z0.BitVector64::op_Implicit(System.UInt64)
    IL_000B: ldc.i4.0
    IL_000C: ldarg.1
    IL_000D: ldc.i4.1
    IL_000E: sub
    IL_000F: call Z0.BitVector64 Z0.bitvector::between(Z0.BitVector64,System.Int32,System.Int32)
    IL_0014: ret

}
BitVector4 msb(BitVector4 x, int n)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.4
    IL_0002: ldarg.1
    IL_0003: sub
    IL_0004: ldc.i4.3
    IL_0005: call Z0.BitVector4 Z0.bitvector::between(Z0.BitVector4,System.Int32,System.Int32)
    IL_000A: ret

}
BitVector8 msb(BitVector8 x, int n)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.8
    IL_0002: ldarg.1
    IL_0003: sub
    IL_0004: ldc.i4.7
    IL_0005: call Z0.BitVector8 Z0.bitvector::between(Z0.BitVector8,System.Int32,System.Int32)
    IL_000A: ret

}
BitVector16 msb(BitVector16 x, int n)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.UInt16 Z0.BitVector16::data
    IL_0006: call Z0.BitVector16 Z0.BitVector16::op_Implicit(System.UInt16)
    IL_000B: ldc.i4.s 16
    IL_000D: ldarg.1
    IL_000E: sub
    IL_000F: ldc.i4.s 15
    IL_0011: call Z0.BitVector16 Z0.bitvector::between(Z0.BitVector16,System.Int32,System.Int32)
    IL_0016: ret

}
BitVector32 msb(BitVector32 x, int n)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.UInt32 Z0.BitVector32::data
    IL_0006: call Z0.BitVector32 Z0.BitVector32::op_Implicit(System.UInt32)
    IL_000B: ldc.i4.s 32
    IL_000D: ldarg.1
    IL_000E: sub
    IL_000F: ldc.i4.s 31
    IL_0011: call Z0.BitVector32 Z0.bitvector::between(Z0.BitVector32,System.Int32,System.Int32)
    IL_0016: ret

}
BitVector64 msb(BitVector64 x, int n)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.UInt64 Z0.BitVector64::data
    IL_0006: call Z0.BitVector64 Z0.BitVector64::op_Implicit(System.UInt64)
    IL_000B: ldc.i4.s 64
    IL_000D: ldarg.1
    IL_000E: sub
    IL_000F: ldc.i4.s 63
    IL_0011: call Z0.BitVector64 Z0.bitvector::between(Z0.BitVector64,System.Int32,System.Int32)
    IL_0016: ret

}
BitVector4 nand(BitVector4 x, BitVector4 y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Byte Z0.BitVector4::data
    IL_0006: ldarg.1
    IL_0007: ldfld System.Byte Z0.BitVector4::data
    IL_000C: call System.Byte Z0.math::nand(System.Byte,System.Byte)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.BitVector4 Z0.BitVector4::op_Implicit(System.Byte&)
    IL_0019: ret

}
BitVector8 nand(BitVector8 x, BitVector8 y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Byte Z0.BitVector8::data
    IL_0006: ldarg.1
    IL_0007: ldfld System.Byte Z0.BitVector8::data
    IL_000C: call System.Byte Z0.math::nand(System.Byte,System.Byte)
    IL_0011: call Z0.BitVector8 Z0.BitVector8::op_Implicit(System.Byte)
    IL_0016: ret

}
BitVector16 nand(BitVector16 x, BitVector16 y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.UInt16 Z0.BitVector16::data
    IL_0006: ldarg.1
    IL_0007: ldfld System.UInt16 Z0.BitVector16::data
    IL_000C: call System.UInt16 Z0.math::nand(System.UInt16,System.UInt16)
    IL_0011: call Z0.BitVector16 Z0.BitVector16::op_Implicit(System.UInt16)
    IL_0016: ret

}
BitVector32 nand(BitVector32 x, BitVector32 y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.UInt32 Z0.BitVector32::data
    IL_0006: ldarg.1
    IL_0007: ldfld System.UInt32 Z0.BitVector32::data
    IL_000C: call System.UInt32 Z0.math::nand(System.UInt32,System.UInt32)
    IL_0011: call Z0.BitVector32 Z0.BitVector32::op_Implicit(System.UInt32)
    IL_0016: ret

}
BitVector64 nand(BitVector64 x, BitVector64 y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.UInt64 Z0.BitVector64::data
    IL_0006: ldarg.1
    IL_0007: ldfld System.UInt64 Z0.BitVector64::data
    IL_000C: call System.UInt64 Z0.math::nand(System.UInt64,System.UInt64)
    IL_0011: call Z0.BitVector64 Z0.BitVector64::op_Implicit(System.UInt64)
    IL_0016: ret

}
BitVector4 negate(BitVector4 x)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Byte Z0.BitVector4::data
    IL_0006: call System.Byte Z0.math::negate(System.Byte)
    IL_000B: call Z0.BitVector4 Z0.BitVector4::FromLo(System.Byte)
    IL_0010: ret

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
ref BitVector4 negate(ref BitVector4 x)
{
    IL_0000: ldarg.0
    IL_0001: ldflda System.Byte Z0.BitVector4::data
    IL_0006: call System.Byte& Z0.math::negate(System.Byte&)
    IL_000B: pop
    IL_000C: ldarg.0
    IL_000D: ldflda System.Byte Z0.BitVector4::data
    IL_0012: dup
    IL_0013: ldind.u1
    IL_0014: ldc.i4.s 15
    IL_0016: and
    IL_0017: conv.u1
    IL_0018: stind.i1
    IL_0019: ldarg.0
    IL_001A: ret

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
uint nlz(BitVector8 x)
{
    IL_0000: ldarga.s x
    IL_0002: ldflda System.Byte Z0.BitVector8::data
    IL_0007: call System.UInt32 Z0.Bits::nlz(System.Byte&)
    IL_000C: ret

}
uint nlz(BitVector16 x)
{
    IL_0000: ldarga.s x
    IL_0002: ldflda System.UInt16 Z0.BitVector16::data
    IL_0007: call System.UInt32 Z0.Bits::nlz(System.UInt16&)
    IL_000C: ret

}
uint ntz(BitVector8 x)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Byte Z0.BitVector8::data
    IL_0006: call System.UInt32 Z0.Bits::ntz(System.Byte)
    IL_000B: ret

}
uint nlz(BitVector64 x)
{
    IL_0000: ldarga.s x
    IL_0002: ldflda System.UInt64 Z0.BitVector64::data
    IL_0007: call System.UInt32 Z0.Bits::nlz(System.UInt64&)
    IL_000C: ret

}
BitVector4 nor(BitVector4 x, BitVector4 y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Byte Z0.BitVector4::data
    IL_0006: ldarg.1
    IL_0007: ldfld System.Byte Z0.BitVector4::data
    IL_000C: call System.Byte Z0.math::nor(System.Byte,System.Byte)
    IL_0011: stloc.0
    IL_0012: ldloca.s V_0
    IL_0014: call Z0.BitVector4 Z0.BitVector4::op_Implicit(System.Byte&)
    IL_0019: ret

}
BitVector8 nor(BitVector8 x, BitVector8 y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Byte Z0.BitVector8::data
    IL_0006: ldarg.1
    IL_0007: ldfld System.Byte Z0.BitVector8::data
    IL_000C: call System.Byte Z0.math::nor(System.Byte,System.Byte)
    IL_0011: call Z0.BitVector8 Z0.BitVector8::op_Implicit(System.Byte)
    IL_0016: ret

}
BitVector16 nor(BitVector16 x, BitVector16 y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.UInt16 Z0.BitVector16::data
    IL_0006: ldarg.1
    IL_0007: ldfld System.UInt16 Z0.BitVector16::data
    IL_000C: call System.UInt16 Z0.math::nor(System.UInt16,System.UInt16)
    IL_0011: call Z0.BitVector16 Z0.BitVector16::op_Implicit(System.UInt16)
    IL_0016: ret

}
BitVector32 nor(BitVector32 x, BitVector32 y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.UInt32 Z0.BitVector32::data
    IL_0006: ldarg.1
    IL_0007: ldfld System.UInt32 Z0.BitVector32::data
    IL_000C: call System.UInt32 Z0.math::nor(System.UInt32,System.UInt32)
    IL_0011: call Z0.BitVector32 Z0.BitVector32::op_Implicit(System.UInt32)
    IL_0016: ret

}
BitVector64 nor(BitVector64 x, BitVector64 y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.UInt64 Z0.BitVector64::data
    IL_0006: ldarg.1
    IL_0007: ldfld System.UInt64 Z0.BitVector64::data
    IL_000C: call System.UInt64 Z0.math::nor(System.UInt64,System.UInt64)
    IL_0011: call Z0.BitVector64 Z0.BitVector64::op_Implicit(System.UInt64)
    IL_0016: ret

}
BitVector4 not(BitVector4 src)
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
BitVector8 not(BitVector8 x)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Byte Z0.BitVector8::data
    IL_0006: call System.Byte Z0.math::not(System.Byte)
    IL_000B: call Z0.BitVector8 Z0.BitVector8::op_Implicit(System.Byte)
    IL_0010: ret

}
BitVector16 not(BitVector16 x)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.UInt16 Z0.BitVector16::data
    IL_0006: call System.UInt16 Z0.math::not(System.UInt16)
    IL_000B: call Z0.BitVector16 Z0.BitVector16::op_Implicit(System.UInt16)
    IL_0010: ret

}
BitVector32 not(BitVector32 x)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.UInt32 Z0.BitVector32::data
    IL_0006: call System.UInt32 Z0.math::not(System.UInt32)
    IL_000B: call Z0.BitVector32 Z0.BitVector32::op_Implicit(System.UInt32)
    IL_0010: ret

}
BitVector64 not(BitVector64 x)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.UInt64 Z0.BitVector64::data
    IL_0006: call System.UInt64 Z0.math::not(System.UInt64)
    IL_000B: call Z0.BitVector64 Z0.BitVector64::op_Implicit(System.UInt64)
    IL_0010: ret

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
uint ntz(BitVector16 x)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.UInt16 Z0.BitVector16::data
    IL_0006: call System.UInt32 Z0.Bits::ntz(System.UInt16)
    IL_000B: ret

}
uint nlz(BitVector32 x)
{
    IL_0000: ldarga.s x
    IL_0002: ldflda System.UInt32 Z0.BitVector32::data
    IL_0007: call System.UInt32 Z0.Bits::nlz(System.UInt32&)
    IL_000C: ret

}
uint ntz(BitVector32 x)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.UInt32 Z0.BitVector32::data
    IL_0006: call System.UInt32 Z0.Bits::ntz(System.UInt32)
    IL_000B: ret

}
uint ntz(BitVector64 x)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.UInt64 Z0.BitVector64::data
    IL_0006: call System.UInt32 Z0.Bits::ntz(System.UInt64)
    IL_000B: ret

}
