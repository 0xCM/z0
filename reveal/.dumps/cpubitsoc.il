// 2019-12-10 01:42:50:766
Vector128<uint> vcompact(Vector128<ulong> x0, Vector128<ulong> x1, out Vector128<uint> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.dinx::vcompact(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>&)
    IL_0008: ret

}
byte butterfly_8x1(byte x)
{
    IL_0000: call Z0.N1 zfunc::get_n1()
    IL_0005: ldarg.0
    IL_0006: call System.Byte Z0.gbits::butterfly<System.Byte>(Z0.N1,System.Byte)
    IL_000B: ret

}
Vector128<byte> vbutterfly_128x8x1(Vector128<byte> x)
{
    IL_0000: call Z0.N1 zfunc::get_n1()
    IL_0005: ldarg.0
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.gbits::vbutterfly<System.Byte>(Z0.N1,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_000B: ret

}
Vector256<byte> vbutterfly_256x8x1(Vector256<byte> x)
{
    IL_0000: call Z0.N1 zfunc::get_n1()
    IL_0005: ldarg.0
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.gbits::vbutterfly<System.Byte>(Z0.N1,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_000B: ret

}
ushort butterfly_16x1(ushort x)
{
    IL_0000: call Z0.N1 zfunc::get_n1()
    IL_0005: ldarg.0
    IL_0006: call System.UInt16 Z0.gbits::butterfly<System.UInt16>(Z0.N1,System.UInt16)
    IL_000B: ret

}
Vector128<ushort> vbutterfly_128x16x1(Vector128<ushort> x)
{
    IL_0000: call Z0.N1 zfunc::get_n1()
    IL_0005: ldarg.0
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.gbits::vbutterfly<System.UInt16>(Z0.N1,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_000B: ret

}
Vector256<ushort> vbutterfly_256x16x1(Vector256<ushort> x)
{
    IL_0000: call Z0.N1 zfunc::get_n1()
    IL_0005: ldarg.0
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.gbits::vbutterfly<System.UInt16>(Z0.N1,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_000B: ret

}
uint butterfly_32x1(uint x)
{
    IL_0000: call Z0.N1 zfunc::get_n1()
    IL_0005: ldarg.0
    IL_0006: call System.UInt32 Z0.gbits::butterfly<System.UInt32>(Z0.N1,System.UInt32)
    IL_000B: ret

}
Vector128<uint> vbutterfly_128x32x1(Vector128<uint> x)
{
    IL_0000: call Z0.N1 zfunc::get_n1()
    IL_0005: ldarg.0
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.gbits::vbutterfly<System.UInt32>(Z0.N1,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_000B: ret

}
Vector256<uint> vbutterfly_256x32x1(Vector256<uint> x)
{
    IL_0000: call Z0.N1 zfunc::get_n1()
    IL_0005: ldarg.0
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.gbits::vbutterfly<System.UInt32>(Z0.N1,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_000B: ret

}
ulong butterfly_64x1(ulong x)
{
    IL_0000: call Z0.N1 zfunc::get_n1()
    IL_0005: ldarg.0
    IL_0006: call System.UInt64 Z0.gbits::butterfly<System.UInt64>(Z0.N1,System.UInt64)
    IL_000B: ret

}
Vector128<ulong> vbutterfly_128x64x1(Vector128<ulong> x)
{
    IL_0000: call Z0.N1 zfunc::get_n1()
    IL_0005: ldarg.0
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.gbits::vbutterfly<System.UInt64>(Z0.N1,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_000B: ret

}
Vector256<ulong> vbutterfly_256x64x1(Vector256<ulong> x)
{
    IL_0000: call Z0.N1 zfunc::get_n1()
    IL_0005: ldarg.0
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.gbits::vbutterfly<System.UInt64>(Z0.N1,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_000B: ret

}
byte butterfly_8x2(byte x)
{
    IL_0000: call Z0.N2 zfunc::get_n2()
    IL_0005: ldarg.0
    IL_0006: call System.Byte Z0.gbits::butterfly<System.Byte>(Z0.N2,System.Byte)
    IL_000B: ret

}
Vector128<byte> vbutterfly_128x8x2(Vector128<byte> x)
{
    IL_0000: call Z0.N2 zfunc::get_n2()
    IL_0005: ldarg.0
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.gbits::vbutterfly<System.Byte>(Z0.N2,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_000B: ret

}
Vector256<byte> vbutterfly_256x8x2(Vector256<byte> x)
{
    IL_0000: call Z0.N2 zfunc::get_n2()
    IL_0005: ldarg.0
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.gbits::vbutterfly<System.Byte>(Z0.N2,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_000B: ret

}
ushort butterfly_16x2(ushort x)
{
    IL_0000: call Z0.N2 zfunc::get_n2()
    IL_0005: ldarg.0
    IL_0006: call System.UInt16 Z0.gbits::butterfly<System.UInt16>(Z0.N2,System.UInt16)
    IL_000B: ret

}
Vector128<ushort> vbutterfly_128x16x2(Vector128<ushort> x)
{
    IL_0000: call Z0.N2 zfunc::get_n2()
    IL_0005: ldarg.0
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.gbits::vbutterfly<System.UInt16>(Z0.N2,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_000B: ret

}
Vector256<ushort> vbutterfly_256x16x2(Vector256<ushort> x)
{
    IL_0000: call Z0.N2 zfunc::get_n2()
    IL_0005: ldarg.0
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.gbits::vbutterfly<System.UInt16>(Z0.N2,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_000B: ret

}
uint butterfly_32x2(uint x)
{
    IL_0000: call Z0.N2 zfunc::get_n2()
    IL_0005: ldarg.0
    IL_0006: call System.UInt32 Z0.Bits::butterfly(Z0.N2,System.UInt32)
    IL_000B: ret

}
Vector128<uint> vbutterfly_128x32x2(Vector128<uint> x)
{
    IL_0000: call Z0.N2 zfunc::get_n2()
    IL_0005: ldarg.0
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.gbits::vbutterfly<System.UInt32>(Z0.N2,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_000B: ret

}
Vector256<uint> vbutterfly_256x32x2(Vector256<uint> x)
{
    IL_0000: call Z0.N2 zfunc::get_n2()
    IL_0005: ldarg.0
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.gbits::vbutterfly<System.UInt32>(Z0.N2,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_000B: ret

}
ulong butterfly_64x2(ulong x)
{
    IL_0000: call Z0.N2 zfunc::get_n2()
    IL_0005: ldarg.0
    IL_0006: call System.UInt64 Z0.gbits::butterfly<System.UInt64>(Z0.N2,System.UInt64)
    IL_000B: ret

}
Vector128<ulong> vbutterfly_128x64x2(Vector128<ulong> x)
{
    IL_0000: call Z0.N2 zfunc::get_n2()
    IL_0005: ldarg.0
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.gbits::vbutterfly<System.UInt64>(Z0.N2,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_000B: ret

}
Vector256<ulong> vbutterfly_256x64x2(Vector256<ulong> x)
{
    IL_0000: call Z0.N2 zfunc::get_n2()
    IL_0005: ldarg.0
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.gbits::vbutterfly<System.UInt64>(Z0.N2,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_000B: ret

}
ushort butterfly_16x4(ushort x)
{
    IL_0000: call Z0.N4 zfunc::get_n4()
    IL_0005: ldarg.0
    IL_0006: call System.UInt16 Z0.Bits::butterfly(Z0.N4,System.UInt16)
    IL_000B: ret

}
Vector128<ushort> vbutterfly_128x16x4(Vector128<ushort> x)
{
    IL_0000: call Z0.N4 zfunc::get_n4()
    IL_0005: ldarg.0
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.gbits::vbutterfly<System.UInt16>(Z0.N4,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_000B: ret

}
Vector256<ushort> vbutterfly_256x16x4(Vector256<ushort> x)
{
    IL_0000: call Z0.N4 zfunc::get_n4()
    IL_0005: ldarg.0
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.gbits::vbutterfly<System.UInt16>(Z0.N4,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_000B: ret

}
ulong butterfly_32x4(uint x)
{
    IL_0000: call Z0.N4 zfunc::get_n4()
    IL_0005: ldarg.0
    IL_0006: call System.UInt32 Z0.Bits::butterfly(Z0.N4,System.UInt32)
    IL_000B: conv.u8
    IL_000C: ret

}
Vector128<uint> vbutterfly_128x32x4(Vector128<uint> x)
{
    IL_0000: call Z0.N4 zfunc::get_n4()
    IL_0005: ldarg.0
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.gbits::vbutterfly<System.UInt32>(Z0.N4,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_000B: ret

}
Vector256<uint> vbutterfly_256x32x4(Vector256<uint> x)
{
    IL_0000: call Z0.N4 zfunc::get_n4()
    IL_0005: ldarg.0
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.gbits::vbutterfly<System.UInt32>(Z0.N4,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_000B: ret

}
ulong butterfly_64x4(ulong x)
{
    IL_0000: call Z0.N4 zfunc::get_n4()
    IL_0005: ldarg.0
    IL_0006: call System.UInt64 Z0.Bits::butterfly(Z0.N4,System.UInt64)
    IL_000B: ret

}
Vector128<ulong> vbutterfly_128x64x4(Vector128<ulong> x)
{
    IL_0000: call Z0.N4 zfunc::get_n4()
    IL_0005: ldarg.0
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.gbits::vbutterfly<System.UInt64>(Z0.N4,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_000B: ret

}
Vector256<ulong> vbutterfly_256x64x4(Vector256<ulong> x)
{
    IL_0000: call Z0.N4 zfunc::get_n4()
    IL_0005: ldarg.0
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.gbits::vbutterfly<System.UInt64>(Z0.N4,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_000B: ret

}
ulong butterfly_32x8(uint x)
{
    IL_0000: call Z0.N8 zfunc::get_n8()
    IL_0005: ldarg.0
    IL_0006: call System.UInt32 Z0.gbits::butterfly<System.UInt32>(Z0.N8,System.UInt32)
    IL_000B: conv.u8
    IL_000C: ret

}
Vector128<uint> vbutterfly_128x32x8(Vector128<uint> x)
{
    IL_0000: call Z0.N8 zfunc::get_n8()
    IL_0005: ldarg.0
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.gbits::vbutterfly<System.UInt32>(Z0.N8,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_000B: ret

}
Vector256<uint> vbutterfly_256x32x8(Vector256<uint> x)
{
    IL_0000: call Z0.N8 zfunc::get_n8()
    IL_0005: ldarg.0
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.gbits::vbutterfly<System.UInt32>(Z0.N8,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_000B: ret

}
ulong butterfly_64x8(ulong x)
{
    IL_0000: call Z0.N8 zfunc::get_n8()
    IL_0005: ldarg.0
    IL_0006: call System.UInt64 Z0.gbits::butterfly<System.UInt64>(Z0.N8,System.UInt64)
    IL_000B: ret

}
Vector128<ulong> vbutterfly_128x64x8(Vector128<ulong> x)
{
    IL_0000: call Z0.N8 zfunc::get_n8()
    IL_0005: ldarg.0
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.gbits::vbutterfly<System.UInt64>(Z0.N8,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_000B: ret

}
Vector256<ulong> vbutterfly_256x64x8(Vector256<ulong> x)
{
    IL_0000: call Z0.N8 zfunc::get_n8()
    IL_0005: ldarg.0
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.gbits::vbutterfly<System.UInt64>(Z0.N8,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_000B: ret

}
ulong butterfly_64x16(ulong x)
{
    IL_0000: call Z0.N16 zfunc::get_n16()
    IL_0005: ldarg.0
    IL_0006: call System.UInt64 Z0.gbits::butterfly<System.UInt64>(Z0.N16,System.UInt64)
    IL_000B: ret

}
Vector128<ulong> vbutterfly_128x64x16(Vector128<ulong> x)
{
    IL_0000: call Z0.N16 zfunc::get_n16()
    IL_0005: ldarg.0
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.gbits::vbutterfly<System.UInt64>(Z0.N16,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_000B: ret

}
Vector256<ulong> vbutterfly_256x64x16(Vector256<ulong> x)
{
    IL_0000: call Z0.N16 zfunc::get_n16()
    IL_0005: ldarg.0
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.gbits::vbutterfly<System.UInt64>(Z0.N16,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_000B: ret

}
BitVector32 alt_32()
{
    IL_0000: call Z0.N32 zfunc::get_n32()
    IL_0005: call Z0.bit zfunc::get_off()
    IL_000A: call Z0.BitVector32 Z0.BitVector::alt(Z0.N32,Z0.bit)
    IL_000F: ret

}
BitVector<uint> alt_32g()
{
    IL_0000: call Z0.bit zfunc::get_off()
    IL_0005: call Z0.BitVector`1<System.UInt32> Z0.BitVector::alt<System.UInt32>(Z0.bit)
    IL_000A: ret

}
bit dot_32g(BitVector<uint> x, BitVector<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.BitVector::dot<System.UInt32>(Z0.BitVector`1<System.UInt32>,Z0.BitVector`1<System.UInt32>)
    IL_0007: ret

}
BitMatrix<uint> oprod_1(BitVector32 x, BitVector32 y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.BitMatrix`1<System.UInt32> Z0.BitVector::oprod(Z0.BitVector32,Z0.BitVector32)
    IL_0007: ret

}
BitMatrix<uint> oprod_2(BitVector<uint> x, BitVector<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.BitMatrix`1<System.UInt32> Z0.BitVector::oprod<System.UInt32>(Z0.BitVector`1<System.UInt32>,Z0.BitVector`1<System.UInt32>)
    IL_0007: ret

}
ref BitMatrix<uint> oprod_3(BitVector<uint> x, BitVector<uint> y, ref BitMatrix<uint> z)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call Z0.BitMatrix`1<System.UInt32>& Z0.BitVector::oprod<System.UInt32>(Z0.BitVector`1<System.UInt32>,Z0.BitVector`1<System.UInt32>,Z0.BitMatrix`1<System.UInt32>&)
    IL_0008: ret

}
ref BitMatrix<ulong> oprod_4(BitVector<ulong> x, BitVector<ulong> y, ref BitMatrix<ulong> z)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call Z0.BitMatrix`1<System.UInt64>& Z0.BitVector::oprod<System.UInt64>(Z0.BitVector`1<System.UInt64>,Z0.BitVector`1<System.UInt64>,Z0.BitMatrix`1<System.UInt64>&)
    IL_0008: ret

}
ReadOnlySpan<Char> bitchars_8u(byte value)
{
    IL_0000: ldarg.0
    IL_0001: call System.ReadOnlySpan`1<System.Char> Z0.BitStore::bitchars(System.Byte)
    IL_0006: ret

}
void bitchars_8u(byte value, Span<Char> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.0
    IL_0003: call System.Void Z0.BitStore::bitchars<System.Byte>(System.Byte,System.Span`1<System.Char>,System.Int32)
    IL_0008: ret

}
void bitchars_16u(ushort value, Span<Char> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.0
    IL_0003: call System.Void Z0.BitStore::bitchars<System.UInt16>(System.UInt16,System.Span`1<System.Char>,System.Int32)
    IL_0008: ret

}
void bitchars_32u(uint value, Span<Char> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.0
    IL_0003: call System.Void Z0.BitStore::bitchars<System.UInt32>(System.UInt32,System.Span`1<System.Char>,System.Int32)
    IL_0008: ret

}
void bitchars_64u(ulong value, Span<Char> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.0
    IL_0003: call System.Void Z0.BitStore::bitchars<System.UInt64>(System.UInt64,System.Span`1<System.Char>,System.Int32)
    IL_0008: ret

}
BitVector32 and_bv_32u(BitVector32 x, BitVector32 y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.BitVector32 Z0.BitVector::and(Z0.BitVector32,Z0.BitVector32)
    IL_0007: ret

}
BitVector32 and_bv_o32u(BitVector32 x, BitVector32 y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.BitVector32 Z0.BitVector32::op_BitwiseAnd(Z0.BitVector32,Z0.BitVector32)
    IL_0007: ret

}
BitVector32 or_bv_32u(BitVector32 x, BitVector32 y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.BitVector32 Z0.BitVector::or(Z0.BitVector32,Z0.BitVector32)
    IL_0007: ret

}
BitVector32 or_bv_o32u(BitVector32 x, BitVector32 y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.BitVector32 Z0.BitVector32::op_BitwiseOr(Z0.BitVector32,Z0.BitVector32)
    IL_0007: ret

}
BitVector32 xor_bv_32u(BitVector32 x, BitVector32 y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.BitVector32 Z0.BitVector::xor(Z0.BitVector32,Z0.BitVector32)
    IL_0007: ret

}
BitVector32 xor_bv_o32u(BitVector32 x, BitVector32 y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.BitVector32 Z0.BitVector32::op_ExclusiveOr(Z0.BitVector32,Z0.BitVector32)
    IL_0007: ret

}
BitVector32 sll_bv_32u(BitVector32 x, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.BitVector32 Z0.BitVector::sll(Z0.BitVector32,System.Int32)
    IL_0007: ret

}
BitVector32 sll_bv_o32u(BitVector32 x, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.BitVector32 Z0.BitVector32::op_LeftShift(Z0.BitVector32,System.Int32)
    IL_0007: ret

}
BitVector32 srl_bv_32u(BitVector32 x, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.BitVector32 Z0.BitVector::srl(Z0.BitVector32,System.Int32)
    IL_0007: ret

}
BitVector32 srl_bv_o32u(BitVector32 x, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.BitVector32 Z0.BitVector32::op_RightShift(Z0.BitVector32,System.Int32)
    IL_0007: ret

}
BitVector32 flip_bv_32u(BitVector32 x)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.BitVector32 Z0.BitVector::not(Z0.BitVector32)
    IL_0006: ret

}
BitVector32 flip_bv_o32u(BitVector32 x)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.BitVector32 Z0.BitVector32::op_OnesComplement(Z0.BitVector32)
    IL_0006: ret

}
BitVector32 negate_bv_32u(BitVector32 x)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.BitVector32 Z0.BitVector::negate(Z0.BitVector32)
    IL_0006: ret

}
BitVector32 negate_bv_o32u(BitVector32 x)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.BitVector32 Z0.BitVector32::op_UnaryNegation(Z0.BitVector32)
    IL_0006: ret

}
BitVector32 inc_bv_32u(BitVector32 x)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.BitVector32 Z0.BitVector::inc(Z0.BitVector32)
    IL_0006: ret

}
BitVector32 inc_bv_o32u(BitVector32 x)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.BitVector32 Z0.BitVector32::op_Increment(Z0.BitVector32)
    IL_0006: dup
    IL_0007: starg.s x
    IL_0009: ret

}
BitVector32 dec_bv_32u(BitVector32 x)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.BitVector32 Z0.BitVector::dec(Z0.BitVector32)
    IL_0006: ret

}
BitVector32 dec_bv_o32u(BitVector32 x)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.BitVector32 Z0.BitVector32::op_Decrement(Z0.BitVector32)
    IL_0006: dup
    IL_0007: starg.s x
    IL_0009: ret

}
BitVector32 rotl_bv_32u(BitVector32 x, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.BitVector32 Z0.BitVector::rotl(Z0.BitVector32,System.Int32)
    IL_0007: ret

}
BitVector32 rotr_bv_32u(BitVector32 x, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.BitVector32 Z0.BitVector::rotr(Z0.BitVector32,System.Int32)
    IL_0007: ret

}
ref ulong bitset_2(ref ulong src, int pos, bit state)
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
    IL_000A: not
    IL_000B: and
    IL_000C: ldarg.2
    IL_000D: call System.UInt64 Z0.bit::op_Explicit(Z0.bit)
    IL_0012: ldarg.1
    IL_0013: ldc.i4.s 63
    IL_0015: and
    IL_0016: shl
    IL_0017: or
    IL_0018: stind.i8
    IL_0019: ldarg.0
    IL_001A: ret

}
ref ulong bitmask_set(ref ulong src, byte pos, bit state)
{
    IL_0000: ldarg.2
    IL_0001: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_0006: brfalse.s IL_0014
    IL_0008: ldarg.0
    IL_0009: ldarg.0
    IL_000A: ldind.i8
    IL_000B: ldarg.1
    IL_000C: call System.UInt64 Z0.BitMask::enable(System.UInt64,System.Int32)
    IL_0011: stind.i8
    IL_0012: br.s IL_001E
    IL_0014: ldarg.0
    IL_0015: ldarg.0
    IL_0016: ldind.i8
    IL_0017: ldarg.1
    IL_0018: call System.UInt64 Z0.BitMask::disable(System.UInt64,System.Int32)
    IL_001D: stind.i8
    IL_001E: ldarg.0
    IL_001F: ret

}
byte blsmsk_d8u(byte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Byte Z0.Bits::blsmsk(System.Byte)
    IL_0006: ret

}
byte blsmsk_g8u(byte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Byte Z0.gbits::blsmsk<System.Byte>(System.Byte)
    IL_0006: ret

}
uint blsmsk_d32u(uint src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 Z0.Bits::blsmsk(System.UInt32)
    IL_0006: ret

}
uint blsmsk_g32u(uint src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 Z0.gbits::blsmsk<System.UInt32>(System.UInt32)
    IL_0006: ret

}
