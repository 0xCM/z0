// 2020-01-08 01:52:28:847
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
    IL_0003: call System.UInt32 Z0.gbits::setnb<System.UInt32>(System.UInt32,System.Byte,Z0.bit)
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
