// 2020-01-15 19:20:39:034
BitPos<uint> bitpos_u32(int index)
{
//  Id := 100664286, Name := Z0.BitPos`1<System.UInt32> Z0.OpCodes.bitcore::bitpos_u32(System.Int32)
//  BitPos<uint> bitpos_u32(int index)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call Z0.PrimalKind`1<System.UInt32> Z0.Classifiers::get_u32()
  IL_0006: call Z0.BitPos`1<System.UInt32> Z0.gbits::bitpos<System.UInt32>(System.Int32,Z0.PrimalKind`1<System.UInt32>)
  IL_000B: ret
}

}
BitPos<uint> bitpos_u32_x(int index)
{
//  Id := 100664287, Name := Z0.BitPos`1<System.UInt32> Z0.OpCodes.bitcore::bitpos_u32_x(System.Int32)
//  BitPos<uint> bitpos_u32_x(int index)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call Z0.BitPos`1<System.UInt32> Z0.gbits::bitpos<System.UInt32>(System.Int32)
  IL_0006: ret
}

}
bit bitmatch_32_32(uint a, byte i, uint b, byte j)
{
//  Id := 100664288, Name := Z0.bit Z0.OpCodes.bitcore::bitmatch_32_32(System.UInt32,System.Byte,System.UInt32,System.Byte)
//  bit bitmatch_32_32(uint a, byte i, uint b, byte j)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: ldarg.2
  IL_0003: ldarg.3
  IL_0004: call Z0.bit Z0.gbits::bitmatch<System.UInt32,System.UInt32>(System.UInt32,System.Byte,System.UInt32,System.Byte)
  IL_0009: ret
}

}
void bitseg_u32(Span<uint> src, int firstidx, int lastidx)
{
//  Id := 100664289, Name := System.Void Z0.OpCodes.bitcore::bitseg_u32(System.Span`1<System.UInt32>,System.Int32,System.Int32)
//  void bitseg_u32(Span<uint> src, int firstidx, int lastidx)
//  Managed
{
  IL_0000: ldarga.s src
  IL_0002: ldarg.1
  IL_0003: ldarg.2
  IL_0004: call System.UInt32 Z0.gbits::bitseg<System.UInt32>(System.Span`1<System.UInt32>&,System.Int32,System.Int32)
  IL_0009: pop
  IL_000A: ret
}

}
