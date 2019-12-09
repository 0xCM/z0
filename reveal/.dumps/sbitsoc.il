// 2019-12-08 17:58:49:822
uint pack32x1(ConstBlock256<byte> src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.UInt32 Z0.Bits::pack8x1(Z0.ConstBlock256`1<System.Byte>&)
    IL_0007: ret

}
void split_g64(ulong src, int index, out ulong x0, out ulong x1)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: ldarg.3
    IL_0004: call System.Void Z0.gbits::split<System.UInt64>(System.UInt64,System.Int32,System.UInt64&,System.UInt64&)
    IL_0009: ret

}
void split_64(ulong src, int index, out ulong x0, out ulong x1)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: ldarg.3
    IL_0004: call System.Void Z0.Bits::split(System.UInt64,System.Int32,System.UInt64&,System.UInt64&)
    IL_0009: ret

}
void split_exact(ulong src, out uint x0, out uint x1)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.Void Z0.Bits::split(System.UInt64,System.UInt32&,System.UInt32&)
    IL_0008: ret

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
ulong gather_d64u(ulong src, ulong mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.dinx::gather(System.UInt64,System.UInt64)
    IL_0007: ret

}
ulong gather_g64u(ulong src, ulong mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.ginx::gather<System.UInt64>(System.UInt64,System.UInt64)
    IL_0007: ret

}
ulong lsb_64x8x3(ulong src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt64 Z0.BitMasks::lsb8x3<System.UInt64>(System.UInt64)
    IL_0006: ret

}
uint lsb_32x8x3(uint src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 Z0.BitMasks::lsb8x3<System.UInt32>(System.UInt32)
    IL_0006: ret

}
ushort lsb_16x8x3(ushort src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt16 Z0.BitMasks::lsb8x3<System.UInt16>(System.UInt16)
    IL_0006: ret

}
byte lsb_8x3(byte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Byte Z0.BitMasks::lsb8x3<System.Byte>(System.Byte)
    IL_0006: ret

}
ulong mask_1x64u(int exp0)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt64 Z0.Bits::mask(System.Int32)
    IL_0006: ret

}
ulong mask_2x64u(int exp0, int exp1)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.Bits::mask(System.Int32,System.Int32)
    IL_0007: ret

}
ulong mask_3x64u(int exp0, int exp1, int exp2)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.UInt64 Z0.Bits::mask(System.Int32,System.Int32,System.Int32)
    IL_0008: ret

}
ulong mask_5x64u(int exp0, int exp1, int exp2, int exp3, int exp4)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: ldarg.3
    IL_0004: ldarg.s exp4
    IL_0006: call System.UInt64 Z0.Bits::mask(System.Int32,System.Int32,System.Int32,System.Int32,System.Int32)
    IL_000B: ret

}
ulong mask_6x64u(int exp0, int exp1, int exp2, int exp3, int exp4, int exp5)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: ldarg.3
    IL_0004: ldarg.s exp4
    IL_0006: ldarg.s exp5
    IL_0008: call System.UInt64 Z0.Bits::mask(System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32)
    IL_000D: ret

}
ulong mask_7x64u(int exp0, int exp1, int exp2, int exp3, int exp4, int exp5, int exp6)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: ldarg.3
    IL_0004: ldarg.s exp4
    IL_0006: ldarg.s exp5
    IL_0008: ldarg.s exp6
    IL_000A: call System.UInt64 Z0.Bits::mask(System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32)
    IL_000F: ret

}
uint set_bit(uint src, byte pos, bit state)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.UInt32 Z0.gbits::set<System.UInt32>(System.UInt32,System.Int32,Z0.bit)
    IL_0008: ret

}
uint set_bit_nb(uint src, byte pos, bit state)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.UInt32 Z0.gbits::setnb<System.UInt32>(System.UInt32,System.Int32,Z0.bit)
    IL_0008: ret

}
uint set_bit_on(uint src, byte pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.bit::get_On()
    IL_0007: call System.UInt32 Z0.gbits::set<System.UInt32>(System.UInt32,System.Int32,Z0.bit)
    IL_000C: ret

}
uint set_bit_off(uint src, byte pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.bit::get_Off()
    IL_0007: call System.UInt32 Z0.gbits::set<System.UInt32>(System.UInt32,System.Int32,Z0.bit)
    IL_000C: ret

}
