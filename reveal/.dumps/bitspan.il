// 2020-01-11 17:55:30:131
BitSpan load_scalar_8(byte src)
{
//  Id := 100664628, Name := Z0.BitSpan Z0.OpCodes.bitspan::load_scalar_8(System.Byte)
//  BitSpan load_scalar_8(byte src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call Z0.BitSpan Z0.BitSpan::create<System.Byte>(System.Byte)
  IL_0006: ret
}

}
BitSpan load_scalar_8_fill(byte src, in BitSpan dst)
{
//  Id := 100664629, Name := Z0.BitSpan Z0.OpCodes.bitspan::load_scalar_8_fill(System.Byte,Z0.BitSpan&)
//  BitSpan load_scalar_8_fill(byte src, in BitSpan dst)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call Z0.BitSpan& modreq(System.Runtime.InteropServices.InAttribute) Z0.BitSpan::fill<System.Byte>(System.Byte,Z0.BitSpan&)
  IL_0007: ldobj Z0.BitSpan
  IL_000C: ret
}

}
BitSpan load_scalar_16(ushort src)
{
//  Id := 100664630, Name := Z0.BitSpan Z0.OpCodes.bitspan::load_scalar_16(System.UInt16)
//  BitSpan load_scalar_16(ushort src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call Z0.BitSpan Z0.BitSpan::create<System.UInt16>(System.UInt16)
  IL_0006: ret
}

}
BitSpan load_scalar_16_fill(ushort src, in BitSpan dst)
{
//  Id := 100664631, Name := Z0.BitSpan Z0.OpCodes.bitspan::load_scalar_16_fill(System.UInt16,Z0.BitSpan&)
//  BitSpan load_scalar_16_fill(ushort src, in BitSpan dst)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call Z0.BitSpan& modreq(System.Runtime.InteropServices.InAttribute) Z0.BitSpan::fill<System.UInt16>(System.UInt16,Z0.BitSpan&)
  IL_0007: ldobj Z0.BitSpan
  IL_000C: ret
}

}
BitSpan load_scalar_32(uint src)
{
//  Id := 100664632, Name := Z0.BitSpan Z0.OpCodes.bitspan::load_scalar_32(System.UInt32)
//  BitSpan load_scalar_32(uint src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call Z0.BitSpan Z0.BitSpan::create<System.UInt32>(System.UInt32)
  IL_0006: ret
}

}
BitSpan load_scalar_32_fill(uint src, in BitSpan dst)
{
//  Id := 100664633, Name := Z0.BitSpan Z0.OpCodes.bitspan::load_scalar_32_fill(System.UInt32,Z0.BitSpan&)
//  BitSpan load_scalar_32_fill(uint src, in BitSpan dst)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call Z0.BitSpan& modreq(System.Runtime.InteropServices.InAttribute) Z0.BitSpan::fill<System.UInt32>(System.UInt32,Z0.BitSpan&)
  IL_0007: ldobj Z0.BitSpan
  IL_000C: ret
}

}
BitSpan load_scalar_64(ulong src)
{
//  Id := 100664634, Name := Z0.BitSpan Z0.OpCodes.bitspan::load_scalar_64(System.UInt64)
//  BitSpan load_scalar_64(ulong src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call Z0.BitSpan Z0.BitSpan::create<System.UInt64>(System.UInt64)
  IL_0006: ret
}

}
BitSpan load_scalar_64_fill(ulong src, in BitSpan dst)
{
//  Id := 100664635, Name := Z0.BitSpan Z0.OpCodes.bitspan::load_scalar_64_fill(System.UInt64,Z0.BitSpan&)
//  BitSpan load_scalar_64_fill(ulong src, in BitSpan dst)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call Z0.BitSpan& modreq(System.Runtime.InteropServices.InAttribute) Z0.BitSpan::fill<System.UInt64>(System.UInt64,Z0.BitSpan&)
  IL_0007: ldobj Z0.BitSpan
  IL_000C: ret
}

}
byte scalar_8(BitSpan src)
{
//  Id := 100664636, Name := System.Byte Z0.OpCodes.bitspan::scalar_8(Z0.BitSpan)
//  byte scalar_8(BitSpan src)
//  Managed
{
  IL_0000: ldarga.s src
  IL_0002: ldc.i4.0
  IL_0003: call System.Byte Z0.BitSpan::extract<System.Byte>(Z0.BitSpan&,System.Int32)
  IL_0008: ret
}

}
ushort extract_16(BitSpan src)
{
//  Id := 100664637, Name := System.UInt16 Z0.OpCodes.bitspan::extract_16(Z0.BitSpan)
//  ushort extract_16(BitSpan src)
//  Managed
{
  IL_0000: ldarga.s src
  IL_0002: ldc.i4.0
  IL_0003: call System.UInt16 Z0.BitSpan::extract<System.UInt16>(Z0.BitSpan&,System.Int32)
  IL_0008: ret
}

}
uint extract_32(BitSpan src)
{
//  Id := 100664638, Name := System.UInt32 Z0.OpCodes.bitspan::extract_32(Z0.BitSpan)
//  uint extract_32(BitSpan src)
//  Managed
{
  IL_0000: ldarga.s src
  IL_0002: ldc.i4.0
  IL_0003: call System.UInt32 Z0.BitSpan::extract<System.UInt32>(Z0.BitSpan&,System.Int32)
  IL_0008: ret
}

}
ulong extract_64(BitSpan src)
{
//  Id := 100664639, Name := System.UInt64 Z0.OpCodes.bitspan::extract_64(Z0.BitSpan)
//  ulong extract_64(BitSpan src)
//  Managed
{
  IL_0000: ldarga.s src
  IL_0002: ldc.i4.0
  IL_0003: call System.UInt64 Z0.BitSpan::extract<System.UInt64>(Z0.BitSpan&,System.Int32)
  IL_0008: ret
}

}
byte bitslice_8(BitSpan src, int offset, int count)
{
//  Id := 100664640, Name := System.Byte Z0.OpCodes.bitspan::bitslice_8(Z0.BitSpan,System.Int32,System.Int32)
//  byte bitslice_8(BitSpan src, int offset, int count)
//  Managed
{
  IL_0000: ldarga.s src
  IL_0002: ldarg.1
  IL_0003: ldarg.2
  IL_0004: call System.Byte Z0.BitSpan::bitslice<System.Byte>(Z0.BitSpan&,System.Int32,System.Int32)
  IL_0009: ret
}

}
ushort bitslice_16(BitSpan src, int offset, int count)
{
//  Id := 100664641, Name := System.UInt16 Z0.OpCodes.bitspan::bitslice_16(Z0.BitSpan,System.Int32,System.Int32)
//  ushort bitslice_16(BitSpan src, int offset, int count)
//  Managed
{
  IL_0000: ldarga.s src
  IL_0002: ldarg.1
  IL_0003: ldarg.2
  IL_0004: call System.UInt16 Z0.BitSpan::bitslice<System.UInt16>(Z0.BitSpan&,System.Int32,System.Int32)
  IL_0009: ret
}

}
uint bitslice_32(BitSpan src, int offset, int count)
{
//  Id := 100664642, Name := System.UInt32 Z0.OpCodes.bitspan::bitslice_32(Z0.BitSpan,System.Int32,System.Int32)
//  uint bitslice_32(BitSpan src, int offset, int count)
//  Managed
{
  IL_0000: ldarga.s src
  IL_0002: ldarg.1
  IL_0003: ldarg.2
  IL_0004: call System.UInt32 Z0.BitSpan::bitslice<System.UInt32>(Z0.BitSpan&,System.Int32,System.Int32)
  IL_0009: ret
}

}
ulong bitslice_64(BitSpan src, int offset, int count)
{
//  Id := 100664643, Name := System.UInt64 Z0.OpCodes.bitspan::bitslice_64(Z0.BitSpan,System.Int32,System.Int32)
//  ulong bitslice_64(BitSpan src, int offset, int count)
//  Managed
{
  IL_0000: ldarga.s src
  IL_0002: ldarg.1
  IL_0003: ldarg.2
  IL_0004: call System.UInt64 Z0.BitSpan::bitslice<System.UInt64>(Z0.BitSpan&,System.Int32,System.Int32)
  IL_0009: ret
}

}
ref BitSpan and(in BitSpan x, in BitSpan y, in BitSpan z)
{
//  Id := 100664644, Name := Z0.BitSpan& modreq(System.Runtime.InteropServices.InAttribute) Z0.OpCodes.bitspan::and(Z0.BitSpan&,Z0.BitSpan&,Z0.BitSpan&)
//  ref BitSpan and(in BitSpan x, in BitSpan y, in BitSpan z)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: ldarg.2
  IL_0003: call Z0.BitSpan& modreq(System.Runtime.InteropServices.InAttribute) Z0.BitSpan::and(Z0.BitSpan&,Z0.BitSpan&,Z0.BitSpan&)
  IL_0008: ret
}

}
ref BitSpan xor(in BitSpan x, in BitSpan y, in BitSpan z)
{
//  Id := 100664645, Name := Z0.BitSpan& modreq(System.Runtime.InteropServices.InAttribute) Z0.OpCodes.bitspan::xor(Z0.BitSpan&,Z0.BitSpan&,Z0.BitSpan&)
//  ref BitSpan xor(in BitSpan x, in BitSpan y, in BitSpan z)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: ldarg.2
  IL_0003: call Z0.BitSpan& modreq(System.Runtime.InteropServices.InAttribute) Z0.BitSpan::xor(Z0.BitSpan&,Z0.BitSpan&,Z0.BitSpan&)
  IL_0008: ret
}

}
