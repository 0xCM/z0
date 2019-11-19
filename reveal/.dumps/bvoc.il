// 2019-11-18 23:19:06:754
ulong clear_64(ulong src, int p0, int p1)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.UInt64 Z0.Bits::clear(System.UInt64,System.Int32,System.Int32)
    IL_0008: ret

}
ulong inject_64(ulong src, ulong dst, byte index, byte length)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: ldarg.3
    IL_0004: call System.UInt64 Z0.Bits::inject(System.UInt64,System.UInt64,System.Byte,System.Byte)
    IL_0009: ret

}
ref byte bitmap_d8u_to_8u(in byte src, byte srcOffset, byte len, byte dstOffset, ref byte dst)
{
    IL_0000: ldarg.0
    IL_0001: ldind.u1
    IL_0002: ldarg.1
    IL_0003: ldarg.2
    IL_0004: ldarg.3
    IL_0005: ldarg.s dst
    IL_0007: call System.Byte& Z0.Bits::bitmap(System.Byte,System.Byte,System.Byte,System.Byte,System.Byte&)
    IL_000C: ret

}
ref byte bitmap_g8u_to_8u(in byte src, byte srcOffset, byte len, byte dstOffset, ref byte dst)
{
    IL_0000: ldarg.0
    IL_0001: ldind.u1
    IL_0002: ldarg.1
    IL_0003: ldarg.2
    IL_0004: ldarg.3
    IL_0005: ldarg.s dst
    IL_0007: call System.Byte& Z0.gbits::bitmap<System.Byte>(System.Byte,System.Byte,System.Byte,System.Byte,System.Byte&)
    IL_000C: ret

}
ref ushort bitmapd_16u_to_16u(in ushort src, byte srcOffset, byte len, byte dstOffset, ref ushort dst)
{
    IL_0000: ldarg.0
    IL_0001: ldind.u2
    IL_0002: ldarg.1
    IL_0003: ldarg.2
    IL_0004: ldarg.3
    IL_0005: ldarg.s dst
    IL_0007: call System.UInt16& Z0.Bits::bitmap(System.UInt16,System.Byte,System.Byte,System.Byte,System.UInt16&)
    IL_000C: ret

}
ref ushort bitmap_g16u_to_16u(in ushort src, byte srcOffset, byte len, byte dstOffset, ref ushort dst)
{
    IL_0000: ldarg.0
    IL_0001: ldind.u2
    IL_0002: ldarg.1
    IL_0003: ldarg.2
    IL_0004: ldarg.3
    IL_0005: ldarg.s dst
    IL_0007: call System.UInt16& Z0.gbits::bitmap<System.UInt16>(System.UInt16,System.Byte,System.Byte,System.Byte,System.UInt16&)
    IL_000C: ret

}
ref uint bitmap_d32u_to_32u(in uint src, byte srcOffset, byte len, byte dstOffset, ref uint dst)
{
    IL_0000: ldarg.0
    IL_0001: ldind.u4
    IL_0002: ldarg.1
    IL_0003: ldarg.2
    IL_0004: ldarg.3
    IL_0005: ldarg.s dst
    IL_0007: call System.UInt32& Z0.Bits::bitmap(System.UInt32,System.Byte,System.Byte,System.Byte,System.UInt32&)
    IL_000C: ret

}
ref uint bitmap_g32u_to_32u(in uint src, byte srcOffset, byte len, byte dstOffset, ref uint dst)
{
    IL_0000: ldarg.0
    IL_0001: ldind.u4
    IL_0002: ldarg.1
    IL_0003: ldarg.2
    IL_0004: ldarg.3
    IL_0005: ldarg.s dst
    IL_0007: call System.UInt32& Z0.gbits::bitmap<System.UInt32>(System.UInt32,System.Byte,System.Byte,System.Byte,System.UInt32&)
    IL_000C: ret

}
ref ulong bitmap_d64u_to_64u(in ulong src, byte srcOffset, byte len, byte dstOffset, ref ulong dst)
{
    IL_0000: ldarg.0
    IL_0001: ldind.i8
    IL_0002: ldarg.1
    IL_0003: ldarg.2
    IL_0004: ldarg.3
    IL_0005: ldarg.s dst
    IL_0007: call System.UInt64& Z0.Bits::bitmap(System.UInt64,System.Byte,System.Byte,System.Byte,System.UInt64&)
    IL_000C: ret

}
ref ulong bitmap_g64u_to_64u(in ulong src, byte srcOffset, byte len, byte dstOffset, ref ulong dst)
{
    IL_0000: ldarg.0
    IL_0001: ldind.i8
    IL_0002: ldarg.1
    IL_0003: ldarg.2
    IL_0004: ldarg.3
    IL_0005: ldarg.s dst
    IL_0007: call System.UInt64& Z0.gbits::bitmap<System.UInt64>(System.UInt64,System.Byte,System.Byte,System.Byte,System.UInt64&)
    IL_000C: ret

}
void bs_and(in Span256<uint> x, in Span256<uint> y, Span256<uint> z)
{
    IL_0000: call Z0.N256 zfunc::get_n256()
    IL_0005: ldarg.0
    IL_0006: ldobj Z0.Span256`1<System.UInt32>
    IL_000B: stloc.0
    IL_000C: ldloca.s V_0
    IL_000E: call System.Int32 Z0.Span256`1<System.UInt32>::get_BlockCount()
    IL_0013: ldc.i4.8
    IL_0014: ldarg.0
    IL_0015: ldobj Z0.Span256`1<System.UInt32>
    IL_001A: stloc.0
    IL_001B: ldloca.s V_0
    IL_001D: call System.UInt32& Z0.Span256`1<System.UInt32>::get_Head()
    IL_0022: ldarg.1
    IL_0023: ldobj Z0.Span256`1<System.UInt32>
    IL_0028: stloc.0
    IL_0029: ldloca.s V_0
    IL_002B: call System.UInt32& Z0.Span256`1<System.UInt32>::get_Head()
    IL_0030: ldarga.s z
    IL_0032: call System.UInt32& Z0.Span256`1<System.UInt32>::get_Head()
    IL_0037: call System.Void Z0.vblock::and<System.UInt32>(Z0.N256,System.Int32,System.Int32,System.UInt32&,System.UInt32&,System.UInt32&)
    IL_003C: ret

}
void s_and(Span<uint> x, Span<uint> y, Span<uint> z)
{
    IL_0000: call Z0.N256 zfunc::get_n256()
    IL_0005: ldarga.s x
    IL_0007: call System.Int32 System.Span`1<System.UInt32>::get_Length()
    IL_000C: ldc.i4.8
    IL_000D: div
    IL_000E: call System.Int32 Z0.Span256`1<System.UInt32>::get_BlockLength()
    IL_0013: ldarg.0
    IL_0014: call System.UInt32& zfunc::head<System.UInt32>(System.Span`1<System.UInt32>)
    IL_0019: ldarg.1
    IL_001A: call System.UInt32& zfunc::head<System.UInt32>(System.Span`1<System.UInt32>)
    IL_001F: ldarg.2
    IL_0020: call System.UInt32& zfunc::head<System.UInt32>(System.Span`1<System.UInt32>)
    IL_0025: call System.Void Z0.vblock::and<System.UInt32>(Z0.N256,System.Int32,System.Int32,System.UInt32&,System.UInt32&,System.UInt32&)
    IL_002A: ret

}
BitVector128 and_128(BitVector128 x, BitVector128 y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.BitVector128 Z0.BitVector128::op_BitwiseAnd(Z0.BitVector128&,Z0.BitVector128&)
    IL_0009: ret

}
BitVector128 xnor_128(BitVector128 x, BitVector128 y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.BitVector128 Z0.BitVector::xnor(Z0.BitVector128&,Z0.BitVector128&)
    IL_0009: ret

}
void partition(BitVector128 x, Span<BitVector32> dst)
{
    IL_0000: ldarga.s x
    IL_0002: ldarg.1
    IL_0003: call System.Span`1<Z0.BitVector32> Z0.BitVector::partition(Z0.BitVector128&,System.Span`1<Z0.BitVector32>)
    IL_0008: pop
    IL_0009: ret

}
bit dot_64(BitVector64 x, BitVector64 y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.bit Z0.BitVector64::op_Modulus(Z0.BitVector64&,Z0.BitVector64&)
    IL_0009: ret

}
bit dot_128(BitVector128 x, BitVector128 y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.bit Z0.BitVector::dot(Z0.BitVector128&,Z0.BitVector128&)
    IL_0009: ret

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
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.BitVector32 Z0.BitVector32::op_BitwiseAnd(Z0.BitVector32&,Z0.BitVector32&)
    IL_0009: ret

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
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.BitVector32 Z0.BitVector32::op_BitwiseOr(Z0.BitVector32&,Z0.BitVector32&)
    IL_0009: ret

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
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.BitVector32 Z0.BitVector32::op_ExclusiveOr(Z0.BitVector32&,Z0.BitVector32&)
    IL_0009: ret

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
ref ulong bitset_3(ref ulong src, byte pos, bit state)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.UInt64& Z0.BitMask::set(System.UInt64&,System.Byte,Z0.bit)
    IL_0008: ret

}
ref ulong bitmask_set(ref ulong src, byte pos, bit state)
{
    IL_0000: ldarg.2
    IL_0001: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_0006: brfalse.s IL_0012
    IL_0008: ldarg.0
    IL_0009: ldarg.1
    IL_000A: call System.UInt64& Z0.BitMask::enable(System.UInt64&,System.Int32)
    IL_000F: pop
    IL_0010: br.s IL_001A
    IL_0012: ldarg.0
    IL_0013: ldarg.1
    IL_0014: call System.UInt64& Z0.BitMask::disable(System.UInt64&,System.Int32)
    IL_0019: pop
    IL_001A: ldarg.0
    IL_001B: ret

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
byte gather_d8u(byte src, byte mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Byte Z0.Bits::gather(System.Byte,System.Byte)
    IL_0007: ret

}
byte gather_g8u(byte src, byte mask)
{
    IL_0000: ldarga.s src
    IL_0002: ldarga.s mask
    IL_0004: call System.Byte Z0.gbits::gather<System.Byte>(System.Byte&,System.Byte&)
    IL_0009: ret

}
ushort gather_d16u(ushort src, ushort mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt16 Z0.Bits::gather(System.UInt16,System.UInt16)
    IL_0007: ret

}
ushort gather_g16u(ushort src, ushort mask)
{
    IL_0000: ldarga.s src
    IL_0002: ldarga.s mask
    IL_0004: call System.UInt16 Z0.gbits::gather<System.UInt16>(System.UInt16&,System.UInt16&)
    IL_0009: ret

}
uint gather_d32u(uint src, uint mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::gather(System.UInt32,System.UInt32)
    IL_0007: ret

}
uint gather_g32u(uint src, uint mask)
{
    IL_0000: ldarga.s src
    IL_0002: ldarga.s mask
    IL_0004: call System.UInt32 Z0.gbits::gather<System.UInt32>(System.UInt32&,System.UInt32&)
    IL_0009: ret

}
ulong gather_d64u(ulong src, ulong mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.Bits::gather(System.UInt64,System.UInt64)
    IL_0007: ret

}
ulong gather_g64u(ulong src, ulong mask)
{
    IL_0000: ldarga.s src
    IL_0002: ldarga.s mask
    IL_0004: call System.UInt64 Z0.gbits::gather<System.UInt64>(System.UInt64&,System.UInt64&)
    IL_0009: ret

}
BitVector32 bitrange_32_a(BitVector32 src, int i, int j)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: ldarg.2
    IL_0004: call Z0.BitVector32 Z0.BitVector32::get_Item(System.Int32,System.Int32)
    IL_0009: ret

}
ulong mask_1x64u(ulong dst, int exp0)
{
    IL_0000: ldarga.s dst
    IL_0002: ldarg.1
    IL_0003: call System.UInt64& Z0.Bits::mask(System.UInt64&,System.Int32)
    IL_0008: ldind.i8
    IL_0009: ret

}
ulong mask_2x64u(ulong dst, int exp0, int exp1)
{
    IL_0000: ldarga.s dst
    IL_0002: ldarg.1
    IL_0003: ldarg.2
    IL_0004: call System.UInt64& Z0.Bits::mask(System.UInt64&,System.Int32,System.Int32)
    IL_0009: ldind.i8
    IL_000A: ret

}
ulong mask_3x64u(ulong dst, int exp0, int exp1, int exp2)
{
    IL_0000: ldarga.s dst
    IL_0002: ldarg.1
    IL_0003: ldarg.2
    IL_0004: ldarg.3
    IL_0005: call System.UInt64& Z0.Bits::mask(System.UInt64&,System.Int32,System.Int32,System.Int32)
    IL_000A: ldind.i8
    IL_000B: ret

}
ulong mask_4x64u(ulong dst, int exp0, int exp1, int exp2, int exp3)
{
    IL_0000: ldarga.s dst
    IL_0002: ldarg.1
    IL_0003: ldarg.2
    IL_0004: ldarg.3
    IL_0005: ldarg.s exp3
    IL_0007: call System.UInt64& Z0.Bits::mask(System.UInt64&,System.Int32,System.Int32,System.Int32,System.Int32)
    IL_000C: ldind.i8
    IL_000D: ret

}
ulong mask_5x64u(ref ulong dst, int exp0, int exp1, int exp2, int exp3, int exp4)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: ldarg.3
    IL_0004: ldarg.s exp3
    IL_0006: ldarg.s exp4
    IL_0008: call System.UInt64& Z0.Bits::mask(System.UInt64&,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32)
    IL_000D: ldind.i8
    IL_000E: ret

}
ulong mask_6x64u(ref ulong dst, int exp0, int exp1, int exp2, int exp3, int exp4, int exp5)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: ldarg.3
    IL_0004: ldarg.s exp3
    IL_0006: ldarg.s exp4
    IL_0008: ldarg.s exp5
    IL_000A: call System.UInt64& Z0.Bits::mask(System.UInt64&,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32)
    IL_000F: ldind.i8
    IL_0010: ret

}
ulong mask_7x64u(ref ulong dst, int exp0, int exp1, int exp2, int exp3, int exp4, int exp5, int exp6)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: ldarg.3
    IL_0004: ldarg.s exp3
    IL_0006: ldarg.s exp4
    IL_0008: ldarg.s exp5
    IL_000A: ldarg.s exp6
    IL_000C: call System.UInt64& Z0.Bits::mask(System.UInt64&,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32)
    IL_0011: ldind.i8
    IL_0012: ret

}
ulong mask_8x64u(ref ulong dst, int exp0, int exp1, int exp2, int exp3, int exp4, int exp5, int exp6, int exp7)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: ldarg.3
    IL_0004: ldarg.s exp3
    IL_0006: ldarg.s exp4
    IL_0008: ldarg.s exp5
    IL_000A: ldarg.s exp6
    IL_000C: ldarg.s exp7
    IL_000E: call System.UInt64& Z0.Bits::mask(System.UInt64&,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32)
    IL_0013: ldind.i8
    IL_0014: ret

}
int pop_bitstore(ulong src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int32 Z0.Bits::popbs(System.UInt64)
    IL_0006: ret

}
void part64x1_byte(ulong src, Span<byte> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Void Z0.BitParts::part64x1(System.UInt64,System.Span`1<System.Byte>)
    IL_0007: ret

}
void part64x1_bit(ulong src, Span<bit> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Void Z0.BitParts::part64x1(System.UInt64,System.Span`1<Z0.bit>)
    IL_0007: ret

}
uint pop3x256(Vector256<ulong> x, Vector256<ulong> y, Vector256<ulong> z)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.UInt32 Z0.Bits::pop(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0008: ret

}
uint pop3x128(Vector128<ulong> x, Vector128<ulong> y, Vector128<ulong> z)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.UInt32 Z0.Bits::pop(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0008: ret

}
uint pop3x64(ulong x, ulong y, ulong z)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.UInt32 Z0.Bits::pop(System.UInt64,System.UInt64,System.UInt64)
    IL_0008: ret

}
