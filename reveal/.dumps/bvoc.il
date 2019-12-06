// 2019-12-05 18:50:57:576
Vector128<uint> vcompact(Vector128<ulong> x0, Vector128<ulong> x1, out Vector128<uint> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.dinx::vcompact(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>&)
    IL_0008: ret

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
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Byte Z0.gbits::gather<System.Byte>(System.Byte,System.Byte)
    IL_0007: ret

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
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt16 Z0.gbits::gather<System.UInt16>(System.UInt16,System.UInt16)
    IL_0007: ret

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
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.gbits::gather<System.UInt32>(System.UInt32,System.UInt32)
    IL_0007: ret

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
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.gbits::gather<System.UInt64>(System.UInt64,System.UInt64)
    IL_0007: ret

}
uint max_val_nbv_4()
{
    IL_0000: call System.UInt32 Z0.BitVector`2<Z0.N4,System.UInt32>::get_MaxValue()
    IL_0005: ret

}
uint max_val_nbv_8()
{
    IL_0000: call System.UInt32 Z0.BitVector`2<Z0.N8,System.UInt32>::get_MaxValue()
    IL_0005: ret

}
BitVector<N8,uint> add(BitVector<N8,uint> x, BitVector<N8,uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.BitVector`2<Z0.N8,System.UInt32> Z0.BitVector`2<Z0.N8,System.UInt32>::op_Addition(Z0.BitVector`2<Z0.N8,System.UInt32>,Z0.BitVector`2<Z0.N8,System.UInt32>)
    IL_0007: ret

}
BitVector<N8,uint> inc(BitVector<N8,uint> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.BitVector`2<Z0.N8,System.UInt32> Z0.BitVector`2<Z0.N8,System.UInt32>::op_Increment(Z0.BitVector`2<Z0.N8,System.UInt32>)
    IL_0006: dup
    IL_0007: starg.s src
    IL_0009: ret

}
BitVector<N8,uint> dec(BitVector<N8,uint> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.BitVector`2<Z0.N8,System.UInt32> Z0.BitVector`2<Z0.N8,System.UInt32>::op_Decrement(Z0.BitVector`2<Z0.N8,System.UInt32>)
    IL_0006: dup
    IL_0007: starg.s src
    IL_0009: ret

}
bit mod_prod_nbv(BitVector<N23,uint> x, BitVector<N23,uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.BitVector::modprod<Z0.N23,System.UInt32>(Z0.BitVector`2<Z0.N23,System.UInt32>,Z0.BitVector`2<Z0.N23,System.UInt32>)
    IL_0007: ret

}
byte inject_8u(byte src, byte dst, int start, int len)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: ldarg.3
    IL_0004: call System.Byte Z0.gbits::inject<System.Byte>(System.Byte,System.Byte,System.Int32,System.Int32)
    IL_0009: ret

}
ushort inject_16u(ushort src, ushort dst, int start, int len)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: ldarg.3
    IL_0004: call System.UInt16 Z0.gbits::inject<System.UInt16>(System.UInt16,System.UInt16,System.Int32,System.Int32)
    IL_0009: ret

}
uint inject_32u(uint src, uint dst, int start, int len)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: ldarg.3
    IL_0004: call System.UInt32 Z0.gbits::inject<System.UInt32>(System.UInt32,System.UInt32,System.Int32,System.Int32)
    IL_0009: ret

}
ulong inject_64u(ulong src, ulong dst, int start, int len)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: ldarg.3
    IL_0004: call System.UInt64 Z0.gbits::inject<System.UInt64>(System.UInt64,System.UInt64,System.Int32,System.Int32)
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
    IL_0004: call System.UInt64 Z0.Bits::inject(System.UInt64,System.UInt64,System.Int32,System.Int32)
    IL_0009: ret

}
int pop_bitstore_8(byte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int32 Z0.BitStore::pop<System.Byte>(System.Byte)
    IL_0006: ret

}
int pop_bitstore_32(uint src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int32 Z0.BitStore::pop<System.UInt32>(System.UInt32)
    IL_0006: ret

}
int pop_bitstore_64(ulong src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int32 Z0.BitStore::pop<System.UInt64>(System.UInt64)
    IL_0006: ret

}
uint pop_3x64(ulong x, ulong y, ulong z)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.UInt32 Z0.Bits::pop(System.UInt64,System.UInt64,System.UInt64)
    IL_0008: ret

}
uint pop_3x128(Vector128<ulong> x, Vector128<ulong> y, Vector128<ulong> z)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.UInt32 Z0.CpuBits::vpop(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0008: ret

}
uint pop_3x256(Vector256<ulong> x, Vector256<ulong> y, Vector256<ulong> z)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.UInt32 Z0.CpuBits::vpop(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0008: ret

}
void part64x1_byte(ulong src, Span<byte> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Void Z0.Bits::part64x1(System.UInt64,System.Span`1<System.Byte>)
    IL_0007: ret

}
void part64x1_bit(ulong src, Span<bit> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Void Z0.Bits::part64x1(System.UInt64,System.Span`1<Z0.bit>)
    IL_0007: ret

}
ulong pow2_20()
{
    IL_0000: call Z0.N20 zfunc::get_n20()
    IL_0005: call System.UInt64 Z0.NatMath::pow2<Z0.N20>(Z0.N20)
    IL_000A: ret

}
ulong pow2m1_20()
{
    IL_0000: call Z0.N20 zfunc::get_n20()
    IL_0005: call System.UInt64 Z0.NatMath::pow2m1<Z0.N20>(Z0.N20)
    IL_000A: ret

}
ulong pow2_33()
{
    IL_0000: call Z0.N33 zfunc::get_n33()
    IL_0005: call System.UInt64 Z0.NatMath::pow2<Z0.N33>(Z0.N33)
    IL_000A: ret

}
ulong pow2m1_33()
{
    IL_0000: call Z0.N33 zfunc::get_n33()
    IL_0005: call System.UInt64 Z0.NatMath::pow2m1<Z0.N33>(Z0.N33)
    IL_000A: ret

}
ulong pow2_1()
{
    IL_0000: call Z0.N1 zfunc::get_n1()
    IL_0005: call System.UInt64 Z0.NatMath::pow2<Z0.N1>(Z0.N1)
    IL_000A: ret

}
ulong pow2m1_1()
{
    IL_0000: call Z0.N1 zfunc::get_n1()
    IL_0005: call System.UInt64 Z0.NatMath::pow2m1<Z0.N1>(Z0.N1)
    IL_000A: ret

}
ulong pow2_2()
{
    IL_0000: call Z0.N2 zfunc::get_n2()
    IL_0005: call System.UInt64 Z0.NatMath::pow2<Z0.N2>(Z0.N2)
    IL_000A: ret

}
ulong pow2m1_2()
{
    IL_0000: call Z0.N2 zfunc::get_n2()
    IL_0005: call System.UInt64 Z0.NatMath::pow2m1<Z0.N2>(Z0.N2)
    IL_000A: ret

}
ulong pow2_3()
{
    IL_0000: call Z0.N3 zfunc::get_n3()
    IL_0005: call System.UInt64 Z0.NatMath::pow2<Z0.N3>(Z0.N3)
    IL_000A: ret

}
ulong pow2m1_3()
{
    IL_0000: call Z0.N3 zfunc::get_n3()
    IL_0005: call System.UInt64 Z0.NatMath::pow2m1<Z0.N3>(Z0.N3)
    IL_000A: ret

}
ulong pow2_4()
{
    IL_0000: call Z0.N4 zfunc::get_n4()
    IL_0005: call System.UInt64 Z0.NatMath::pow2<Z0.N4>(Z0.N4)
    IL_000A: ret

}
ulong pow2m1_4()
{
    IL_0000: call Z0.N4 zfunc::get_n4()
    IL_0005: call System.UInt64 Z0.NatMath::pow2m1<Z0.N4>(Z0.N4)
    IL_000A: ret

}
ulong pow2_5()
{
    IL_0000: call Z0.N5 zfunc::get_n5()
    IL_0005: call System.UInt64 Z0.NatMath::pow2<Z0.N5>(Z0.N5)
    IL_000A: ret

}
ulong pow2m1_5()
{
    IL_0000: call Z0.N5 zfunc::get_n5()
    IL_0005: call System.UInt64 Z0.NatMath::pow2m1<Z0.N5>(Z0.N5)
    IL_000A: ret

}
ulong pow2_6()
{
    IL_0000: call Z0.N6 zfunc::get_n6()
    IL_0005: call System.UInt64 Z0.NatMath::pow2<Z0.N6>(Z0.N6)
    IL_000A: ret

}
ulong pow2m1_6()
{
    IL_0000: call Z0.N6 zfunc::get_n6()
    IL_0005: call System.UInt64 Z0.NatMath::pow2m1<Z0.N6>(Z0.N6)
    IL_000A: ret

}
ulong pow2_7()
{
    IL_0000: call Z0.N7 zfunc::get_n7()
    IL_0005: call System.UInt64 Z0.NatMath::pow2<Z0.N7>(Z0.N7)
    IL_000A: ret

}
ulong pow2m1_7()
{
    IL_0000: call Z0.N7 zfunc::get_n7()
    IL_0005: call System.UInt64 Z0.NatMath::pow2m1<Z0.N7>(Z0.N7)
    IL_000A: ret

}
ulong pow2_8()
{
    IL_0000: call Z0.N8 zfunc::get_n8()
    IL_0005: call System.UInt64 Z0.NatMath::pow2<Z0.N8>(Z0.N8)
    IL_000A: ret

}
ulong pow2m1_8()
{
    IL_0000: call Z0.N8 zfunc::get_n8()
    IL_0005: call System.UInt64 Z0.NatMath::pow2m1<Z0.N8>(Z0.N8)
    IL_000A: ret

}
