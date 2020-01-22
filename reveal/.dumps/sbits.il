// 2020-01-22 01:43:39:245
// Id := 100664282, Name := System.Void Z0.OpCodes.sbits::split_g64(System.UInt64,System.Int32,System.UInt64&,System.UInt64&)
// void split_g64(ulong src, int index, out ulong x0, out ulong x1)
// IL
void split_g64(ulong src, int index, out ulong x0, out ulong x1)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: ldarg.3
    IL_0004: call System.Void Z0.gbits::split<System.UInt64>(System.UInt64,System.Int32,System.UInt64&,System.UInt64&)
    IL_0009: ret
}

// Id := 100664283, Name := System.Void Z0.OpCodes.sbits::split_64(System.UInt64,System.Int32,System.UInt64&,System.UInt64&)
// void split_64(ulong src, int index, out ulong x0, out ulong x1)
// IL
void split_64(ulong src, int index, out ulong x0, out ulong x1)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: ldarg.3
    IL_0004: call System.Void Z0.Bits::split(System.UInt64,System.Int32,System.UInt64&,System.UInt64&)
    IL_0009: ret
}

// Id := 100664284, Name := System.Void Z0.OpCodes.sbits::split_exact(System.UInt64,System.UInt32&,System.UInt32&)
// void split_exact(ulong src, out uint x0, out uint x1)
// IL
void split_exact(ulong src, out uint x0, out uint x1)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.Void Z0.Bits::split(System.UInt64,System.UInt32&,System.UInt32&)
    IL_0008: ret
}

// Id := 100664285, Name := System.UInt64 Z0.OpCodes.sbits::pow2_20()
// ulong pow2_20()
// IL
ulong pow2_20()
{
    IL_0000: call Z0.N20 zfunc::get_n20()
    IL_0005: call System.UInt64 Z0.NatMath::pow2<Z0.N20>(Z0.N20)
    IL_000A: ret
}

// Id := 100664286, Name := System.UInt64 Z0.OpCodes.sbits::pow2m1_20()
// ulong pow2m1_20()
// IL
ulong pow2m1_20()
{
    IL_0000: call Z0.N20 zfunc::get_n20()
    IL_0005: call System.UInt64 Z0.NatMath::pow2m1<Z0.N20>(Z0.N20)
    IL_000A: ret
}

// Id := 100664287, Name := System.UInt64 Z0.OpCodes.sbits::pow2_33()
// ulong pow2_33()
// IL
ulong pow2_33()
{
    IL_0000: call Z0.N33 zfunc::get_n33()
    IL_0005: call System.UInt64 Z0.NatMath::pow2<Z0.N33>(Z0.N33)
    IL_000A: ret
}

// Id := 100664288, Name := System.UInt64 Z0.OpCodes.sbits::pow2m1_33()
// ulong pow2m1_33()
// IL
ulong pow2m1_33()
{
    IL_0000: call Z0.N33 zfunc::get_n33()
    IL_0005: call System.UInt64 Z0.NatMath::pow2m1<Z0.N33>(Z0.N33)
    IL_000A: ret
}

// Id := 100664289, Name := System.UInt64 Z0.OpCodes.sbits::pow2_1()
// ulong pow2_1()
// IL
ulong pow2_1()
{
    IL_0000: call Z0.N1 zfunc::get_n1()
    IL_0005: call System.UInt64 Z0.NatMath::pow2<Z0.N1>(Z0.N1)
    IL_000A: ret
}

// Id := 100664290, Name := System.UInt64 Z0.OpCodes.sbits::pow2m1_1()
// ulong pow2m1_1()
// IL
ulong pow2m1_1()
{
    IL_0000: call Z0.N1 zfunc::get_n1()
    IL_0005: call System.UInt64 Z0.NatMath::pow2m1<Z0.N1>(Z0.N1)
    IL_000A: ret
}

// Id := 100664291, Name := System.UInt64 Z0.OpCodes.sbits::pow2_2()
// ulong pow2_2()
// IL
ulong pow2_2()
{
    IL_0000: call Z0.N2 zfunc::get_n2()
    IL_0005: call System.UInt64 Z0.NatMath::pow2<Z0.N2>(Z0.N2)
    IL_000A: ret
}

// Id := 100664292, Name := System.UInt64 Z0.OpCodes.sbits::pow2m1_2()
// ulong pow2m1_2()
// IL
ulong pow2m1_2()
{
    IL_0000: call Z0.N2 zfunc::get_n2()
    IL_0005: call System.UInt64 Z0.NatMath::pow2m1<Z0.N2>(Z0.N2)
    IL_000A: ret
}

// Id := 100664293, Name := System.UInt64 Z0.OpCodes.sbits::pow2_3()
// ulong pow2_3()
// IL
ulong pow2_3()
{
    IL_0000: call Z0.N3 zfunc::get_n3()
    IL_0005: call System.UInt64 Z0.NatMath::pow2<Z0.N3>(Z0.N3)
    IL_000A: ret
}

// Id := 100664294, Name := System.UInt64 Z0.OpCodes.sbits::pow2m1_3()
// ulong pow2m1_3()
// IL
ulong pow2m1_3()
{
    IL_0000: call Z0.N3 zfunc::get_n3()
    IL_0005: call System.UInt64 Z0.NatMath::pow2m1<Z0.N3>(Z0.N3)
    IL_000A: ret
}

// Id := 100664295, Name := System.UInt64 Z0.OpCodes.sbits::pow2_4()
// ulong pow2_4()
// IL
ulong pow2_4()
{
    IL_0000: call Z0.N4 zfunc::get_n4()
    IL_0005: call System.UInt64 Z0.NatMath::pow2<Z0.N4>(Z0.N4)
    IL_000A: ret
}

// Id := 100664296, Name := System.UInt64 Z0.OpCodes.sbits::pow2m1_4()
// ulong pow2m1_4()
// IL
ulong pow2m1_4()
{
    IL_0000: call Z0.N4 zfunc::get_n4()
    IL_0005: call System.UInt64 Z0.NatMath::pow2m1<Z0.N4>(Z0.N4)
    IL_000A: ret
}

// Id := 100664297, Name := System.UInt64 Z0.OpCodes.sbits::pow2_5()
// ulong pow2_5()
// IL
ulong pow2_5()
{
    IL_0000: call Z0.N5 zfunc::get_n5()
    IL_0005: call System.UInt64 Z0.NatMath::pow2<Z0.N5>(Z0.N5)
    IL_000A: ret
}

// Id := 100664298, Name := System.UInt64 Z0.OpCodes.sbits::pow2m1_5()
// ulong pow2m1_5()
// IL
ulong pow2m1_5()
{
    IL_0000: call Z0.N5 zfunc::get_n5()
    IL_0005: call System.UInt64 Z0.NatMath::pow2m1<Z0.N5>(Z0.N5)
    IL_000A: ret
}

// Id := 100664299, Name := System.UInt64 Z0.OpCodes.sbits::pow2_6()
// ulong pow2_6()
// IL
ulong pow2_6()
{
    IL_0000: call Z0.N6 zfunc::get_n6()
    IL_0005: call System.UInt64 Z0.NatMath::pow2<Z0.N6>(Z0.N6)
    IL_000A: ret
}

// Id := 100664300, Name := System.UInt64 Z0.OpCodes.sbits::pow2m1_6()
// ulong pow2m1_6()
// IL
ulong pow2m1_6()
{
    IL_0000: call Z0.N6 zfunc::get_n6()
    IL_0005: call System.UInt64 Z0.NatMath::pow2m1<Z0.N6>(Z0.N6)
    IL_000A: ret
}

// Id := 100664301, Name := System.UInt64 Z0.OpCodes.sbits::pow2_7()
// ulong pow2_7()
// IL
ulong pow2_7()
{
    IL_0000: call Z0.N7 zfunc::get_n7()
    IL_0005: call System.UInt64 Z0.NatMath::pow2<Z0.N7>(Z0.N7)
    IL_000A: ret
}

// Id := 100664302, Name := System.UInt64 Z0.OpCodes.sbits::pow2m1_7()
// ulong pow2m1_7()
// IL
ulong pow2m1_7()
{
    IL_0000: call Z0.N7 zfunc::get_n7()
    IL_0005: call System.UInt64 Z0.NatMath::pow2m1<Z0.N7>(Z0.N7)
    IL_000A: ret
}

// Id := 100664303, Name := System.UInt64 Z0.OpCodes.sbits::pow2_8()
// ulong pow2_8()
// IL
ulong pow2_8()
{
    IL_0000: call Z0.N8 zfunc::get_n8()
    IL_0005: call System.UInt64 Z0.NatMath::pow2<Z0.N8>(Z0.N8)
    IL_000A: ret
}

// Id := 100664304, Name := System.UInt64 Z0.OpCodes.sbits::pow2m1_8()
// ulong pow2m1_8()
// IL
ulong pow2m1_8()
{
    IL_0000: call Z0.N8 zfunc::get_n8()
    IL_0005: call System.UInt64 Z0.NatMath::pow2m1<Z0.N8>(Z0.N8)
    IL_000A: ret
}

// Id := 100664305, Name := System.UInt32 Z0.OpCodes.sbits::set_bit(System.UInt32,System.Byte,Z0.bit)
// uint set_bit(uint src, byte pos, bit state)
// IL
uint set_bit(uint src, byte pos, bit state)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.UInt32 Z0.gbits::set<System.UInt32>(System.UInt32,System.Int32,Z0.bit)
    IL_0008: ret
}

// Id := 100664306, Name := System.UInt32 Z0.OpCodes.sbits::set_bit_nb(System.UInt32,System.Byte,Z0.bit)
// uint set_bit_nb(uint src, byte pos, bit state)
// IL
uint set_bit_nb(uint src, byte pos, bit state)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.UInt32 Z0.gbits::setnb<System.UInt32>(System.UInt32,System.Byte,Z0.bit)
    IL_0008: ret
}

// Id := 100664307, Name := System.UInt32 Z0.OpCodes.sbits::set_bit_on(System.UInt32,System.Byte)
// uint set_bit_on(uint src, byte pos)
// IL
uint set_bit_on(uint src, byte pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.bit::get_On()
    IL_0007: call System.UInt32 Z0.gbits::set<System.UInt32>(System.UInt32,System.Int32,Z0.bit)
    IL_000C: ret
}

// Id := 100664308, Name := System.UInt32 Z0.OpCodes.sbits::set_bit_off(System.UInt32,System.Byte)
// uint set_bit_off(uint src, byte pos)
// IL
uint set_bit_off(uint src, byte pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.bit::get_Off()
    IL_0007: call System.UInt32 Z0.gbits::set<System.UInt32>(System.UInt32,System.Int32,Z0.bit)
    IL_000C: ret
}

