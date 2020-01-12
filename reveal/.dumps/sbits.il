// 2020-01-11 17:55:30:614
void split_g64(ulong src, int index, out ulong x0, out ulong x1)
{
//  Id := 100664336, Name := System.Void Z0.OpCodes.sbits::split_g64(System.UInt64,System.Int32,System.UInt64&,System.UInt64&)
//  void split_g64(ulong src, int index, out ulong x0, out ulong x1)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: ldarg.2
  IL_0003: ldarg.3
  IL_0004: call System.Void Z0.gbits::split<System.UInt64>(System.UInt64,System.Int32,System.UInt64&,System.UInt64&)
  IL_0009: ret
}

}
void split_64(ulong src, int index, out ulong x0, out ulong x1)
{
//  Id := 100664337, Name := System.Void Z0.OpCodes.sbits::split_64(System.UInt64,System.Int32,System.UInt64&,System.UInt64&)
//  void split_64(ulong src, int index, out ulong x0, out ulong x1)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: ldarg.2
  IL_0003: ldarg.3
  IL_0004: call System.Void Z0.Bits::split(System.UInt64,System.Int32,System.UInt64&,System.UInt64&)
  IL_0009: ret
}

}
void split_exact(ulong src, out uint x0, out uint x1)
{
//  Id := 100664338, Name := System.Void Z0.OpCodes.sbits::split_exact(System.UInt64,System.UInt32&,System.UInt32&)
//  void split_exact(ulong src, out uint x0, out uint x1)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: ldarg.2
  IL_0003: call System.Void Z0.Bits::split(System.UInt64,System.UInt32&,System.UInt32&)
  IL_0008: ret
}

}
ulong pow2_20()
{
//  Id := 100664339, Name := System.UInt64 Z0.OpCodes.sbits::pow2_20()
//  ulong pow2_20()
//  Managed
{
  IL_0000: call Z0.N20 zfunc::get_n20()
  IL_0005: call System.UInt64 Z0.NatMath::pow2<Z0.N20>(Z0.N20)
  IL_000A: ret
}

}
ulong pow2m1_20()
{
//  Id := 100664340, Name := System.UInt64 Z0.OpCodes.sbits::pow2m1_20()
//  ulong pow2m1_20()
//  Managed
{
  IL_0000: call Z0.N20 zfunc::get_n20()
  IL_0005: call System.UInt64 Z0.NatMath::pow2m1<Z0.N20>(Z0.N20)
  IL_000A: ret
}

}
ulong pow2_33()
{
//  Id := 100664341, Name := System.UInt64 Z0.OpCodes.sbits::pow2_33()
//  ulong pow2_33()
//  Managed
{
  IL_0000: call Z0.N33 zfunc::get_n33()
  IL_0005: call System.UInt64 Z0.NatMath::pow2<Z0.N33>(Z0.N33)
  IL_000A: ret
}

}
ulong pow2m1_33()
{
//  Id := 100664342, Name := System.UInt64 Z0.OpCodes.sbits::pow2m1_33()
//  ulong pow2m1_33()
//  Managed
{
  IL_0000: call Z0.N33 zfunc::get_n33()
  IL_0005: call System.UInt64 Z0.NatMath::pow2m1<Z0.N33>(Z0.N33)
  IL_000A: ret
}

}
ulong pow2_1()
{
//  Id := 100664343, Name := System.UInt64 Z0.OpCodes.sbits::pow2_1()
//  ulong pow2_1()
//  Managed
{
  IL_0000: call Z0.N1 zfunc::get_n1()
  IL_0005: call System.UInt64 Z0.NatMath::pow2<Z0.N1>(Z0.N1)
  IL_000A: ret
}

}
ulong pow2m1_1()
{
//  Id := 100664344, Name := System.UInt64 Z0.OpCodes.sbits::pow2m1_1()
//  ulong pow2m1_1()
//  Managed
{
  IL_0000: call Z0.N1 zfunc::get_n1()
  IL_0005: call System.UInt64 Z0.NatMath::pow2m1<Z0.N1>(Z0.N1)
  IL_000A: ret
}

}
ulong pow2_2()
{
//  Id := 100664345, Name := System.UInt64 Z0.OpCodes.sbits::pow2_2()
//  ulong pow2_2()
//  Managed
{
  IL_0000: call Z0.N2 zfunc::get_n2()
  IL_0005: call System.UInt64 Z0.NatMath::pow2<Z0.N2>(Z0.N2)
  IL_000A: ret
}

}
ulong pow2m1_2()
{
//  Id := 100664346, Name := System.UInt64 Z0.OpCodes.sbits::pow2m1_2()
//  ulong pow2m1_2()
//  Managed
{
  IL_0000: call Z0.N2 zfunc::get_n2()
  IL_0005: call System.UInt64 Z0.NatMath::pow2m1<Z0.N2>(Z0.N2)
  IL_000A: ret
}

}
ulong pow2_3()
{
//  Id := 100664347, Name := System.UInt64 Z0.OpCodes.sbits::pow2_3()
//  ulong pow2_3()
//  Managed
{
  IL_0000: call Z0.N3 zfunc::get_n3()
  IL_0005: call System.UInt64 Z0.NatMath::pow2<Z0.N3>(Z0.N3)
  IL_000A: ret
}

}
ulong pow2m1_3()
{
//  Id := 100664348, Name := System.UInt64 Z0.OpCodes.sbits::pow2m1_3()
//  ulong pow2m1_3()
//  Managed
{
  IL_0000: call Z0.N3 zfunc::get_n3()
  IL_0005: call System.UInt64 Z0.NatMath::pow2m1<Z0.N3>(Z0.N3)
  IL_000A: ret
}

}
ulong pow2_4()
{
//  Id := 100664349, Name := System.UInt64 Z0.OpCodes.sbits::pow2_4()
//  ulong pow2_4()
//  Managed
{
  IL_0000: call Z0.N4 zfunc::get_n4()
  IL_0005: call System.UInt64 Z0.NatMath::pow2<Z0.N4>(Z0.N4)
  IL_000A: ret
}

}
ulong pow2m1_4()
{
//  Id := 100664350, Name := System.UInt64 Z0.OpCodes.sbits::pow2m1_4()
//  ulong pow2m1_4()
//  Managed
{
  IL_0000: call Z0.N4 zfunc::get_n4()
  IL_0005: call System.UInt64 Z0.NatMath::pow2m1<Z0.N4>(Z0.N4)
  IL_000A: ret
}

}
ulong pow2_5()
{
//  Id := 100664351, Name := System.UInt64 Z0.OpCodes.sbits::pow2_5()
//  ulong pow2_5()
//  Managed
{
  IL_0000: call Z0.N5 zfunc::get_n5()
  IL_0005: call System.UInt64 Z0.NatMath::pow2<Z0.N5>(Z0.N5)
  IL_000A: ret
}

}
ulong pow2m1_5()
{
//  Id := 100664352, Name := System.UInt64 Z0.OpCodes.sbits::pow2m1_5()
//  ulong pow2m1_5()
//  Managed
{
  IL_0000: call Z0.N5 zfunc::get_n5()
  IL_0005: call System.UInt64 Z0.NatMath::pow2m1<Z0.N5>(Z0.N5)
  IL_000A: ret
}

}
ulong pow2_6()
{
//  Id := 100664353, Name := System.UInt64 Z0.OpCodes.sbits::pow2_6()
//  ulong pow2_6()
//  Managed
{
  IL_0000: call Z0.N6 zfunc::get_n6()
  IL_0005: call System.UInt64 Z0.NatMath::pow2<Z0.N6>(Z0.N6)
  IL_000A: ret
}

}
ulong pow2m1_6()
{
//  Id := 100664354, Name := System.UInt64 Z0.OpCodes.sbits::pow2m1_6()
//  ulong pow2m1_6()
//  Managed
{
  IL_0000: call Z0.N6 zfunc::get_n6()
  IL_0005: call System.UInt64 Z0.NatMath::pow2m1<Z0.N6>(Z0.N6)
  IL_000A: ret
}

}
ulong pow2_7()
{
//  Id := 100664355, Name := System.UInt64 Z0.OpCodes.sbits::pow2_7()
//  ulong pow2_7()
//  Managed
{
  IL_0000: call Z0.N7 zfunc::get_n7()
  IL_0005: call System.UInt64 Z0.NatMath::pow2<Z0.N7>(Z0.N7)
  IL_000A: ret
}

}
ulong pow2m1_7()
{
//  Id := 100664356, Name := System.UInt64 Z0.OpCodes.sbits::pow2m1_7()
//  ulong pow2m1_7()
//  Managed
{
  IL_0000: call Z0.N7 zfunc::get_n7()
  IL_0005: call System.UInt64 Z0.NatMath::pow2m1<Z0.N7>(Z0.N7)
  IL_000A: ret
}

}
ulong pow2_8()
{
//  Id := 100664357, Name := System.UInt64 Z0.OpCodes.sbits::pow2_8()
//  ulong pow2_8()
//  Managed
{
  IL_0000: call Z0.N8 zfunc::get_n8()
  IL_0005: call System.UInt64 Z0.NatMath::pow2<Z0.N8>(Z0.N8)
  IL_000A: ret
}

}
ulong pow2m1_8()
{
//  Id := 100664358, Name := System.UInt64 Z0.OpCodes.sbits::pow2m1_8()
//  ulong pow2m1_8()
//  Managed
{
  IL_0000: call Z0.N8 zfunc::get_n8()
  IL_0005: call System.UInt64 Z0.NatMath::pow2m1<Z0.N8>(Z0.N8)
  IL_000A: ret
}

}
uint set_bit(uint src, byte pos, bit state)
{
//  Id := 100664359, Name := System.UInt32 Z0.OpCodes.sbits::set_bit(System.UInt32,System.Byte,Z0.bit)
//  uint set_bit(uint src, byte pos, bit state)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: ldarg.2
  IL_0003: call System.UInt32 Z0.gbits::set<System.UInt32>(System.UInt32,System.Int32,Z0.bit)
  IL_0008: ret
}

}
uint set_bit_nb(uint src, byte pos, bit state)
{
//  Id := 100664360, Name := System.UInt32 Z0.OpCodes.sbits::set_bit_nb(System.UInt32,System.Byte,Z0.bit)
//  uint set_bit_nb(uint src, byte pos, bit state)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: ldarg.2
  IL_0003: call System.UInt32 Z0.gbits::setnb<System.UInt32>(System.UInt32,System.Byte,Z0.bit)
  IL_0008: ret
}

}
uint set_bit_on(uint src, byte pos)
{
//  Id := 100664361, Name := System.UInt32 Z0.OpCodes.sbits::set_bit_on(System.UInt32,System.Byte)
//  uint set_bit_on(uint src, byte pos)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call Z0.bit Z0.bit::get_On()
  IL_0007: call System.UInt32 Z0.gbits::set<System.UInt32>(System.UInt32,System.Int32,Z0.bit)
  IL_000C: ret
}

}
uint set_bit_off(uint src, byte pos)
{
//  Id := 100664362, Name := System.UInt32 Z0.OpCodes.sbits::set_bit_off(System.UInt32,System.Byte)
//  uint set_bit_off(uint src, byte pos)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call Z0.bit Z0.bit::get_Off()
  IL_0007: call System.UInt32 Z0.gbits::set<System.UInt32>(System.UInt32,System.Int32,Z0.bit)
  IL_000C: ret
}

}
