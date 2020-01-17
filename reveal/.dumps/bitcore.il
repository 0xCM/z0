// 2020-01-16 19:14:10:276
// Id := 100664265, Name := Z0.BitPos`1<System.UInt32> Z0.OpCodes.bitcore::bitpos_u32(System.Int32)
// BitPos<uint> bitpos_u32(int index)
// Managed
BitPos<uint> bitpos_u32(int index)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.PrimalKind`1<System.UInt32> Z0.Classifiers::get_u32()
    IL_0006: call Z0.BitPos`1<System.UInt32> Z0.gbits::bitpos<System.UInt32>(System.Int32,Z0.PrimalKind`1<System.UInt32>)
    IL_000B: ret
}

// Id := 100664266, Name := Z0.BitPos`1<System.UInt32> Z0.OpCodes.bitcore::bitpos_u32_x(System.Int32)
// BitPos<uint> bitpos_u32_x(int index)
// Managed
BitPos<uint> bitpos_u32_x(int index)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.BitPos`1<System.UInt32> Z0.gbits::bitpos<System.UInt32>(System.Int32)
    IL_0006: ret
}

// Id := 100664267, Name := Z0.bit Z0.OpCodes.bitcore::bitmatch_32_32(System.UInt32,System.Byte,System.UInt32,System.Byte)
// bit bitmatch_32_32(uint a, byte i, uint b, byte j)
// Managed
bit bitmatch_32_32(uint a, byte i, uint b, byte j)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: ldarg.3
    IL_0004: call Z0.bit Z0.gbits::bitmatch<System.UInt32,System.UInt32>(System.UInt32,System.Byte,System.UInt32,System.Byte)
    IL_0009: ret
}

// Id := 100664268, Name := System.Void Z0.OpCodes.bitcore::bitseg_u32(System.Span`1<System.UInt32>,System.Int32,System.Int32)
// void bitseg_u32(Span<uint> src, int firstidx, int lastidx)
// Managed
void bitseg_u32(Span<uint> src, int firstidx, int lastidx)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.UInt32 Z0.gbits::bitseg<System.UInt32>(System.Span`1<System.UInt32>,System.Int32,System.Int32)
    IL_0008: pop
    IL_0009: ret
}

