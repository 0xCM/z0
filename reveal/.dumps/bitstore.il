// 2020-01-11 03:38:48:947
ReadOnlySpan<byte> bitseq(byte value)
{
//  Id := 100664369, Name := System.ReadOnlySpan`1<System.Byte> Z0.OpCodes.bitstore::bitseq(System.Byte)
//  ReadOnlySpan<byte> bitseq(byte value)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.ReadOnlySpan`1<System.Byte> Z0.BitStore::select(System.Byte)
  IL_0006: ret
}

}
void bitseq_8u(byte value, Span<byte> dst)
{
//  Id := 100664370, Name := System.Void Z0.OpCodes.bitstore::bitseq_8u(System.Byte,System.Span`1<System.Byte>)
//  void bitseq_8u(byte value, Span<byte> dst)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: ldc.i4.0
  IL_0003: call System.Void Z0.BitStore::bitseq<System.Byte>(System.Byte,System.Span`1<System.Byte>,System.Int32)
  IL_0008: ret
}

}
void bitseq_16u(ushort value, Span<byte> dst)
{
//  Id := 100664371, Name := System.Void Z0.OpCodes.bitstore::bitseq_16u(System.UInt16,System.Span`1<System.Byte>)
//  void bitseq_16u(ushort value, Span<byte> dst)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: ldc.i4.0
  IL_0003: call System.Void Z0.BitStore::bitseq<System.UInt16>(System.UInt16,System.Span`1<System.Byte>,System.Int32)
  IL_0008: ret
}

}
void bitseq_32u(uint value, Span<byte> dst)
{
//  Id := 100664372, Name := System.Void Z0.OpCodes.bitstore::bitseq_32u(System.UInt32,System.Span`1<System.Byte>)
//  void bitseq_32u(uint value, Span<byte> dst)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: ldc.i4.0
  IL_0003: call System.Void Z0.BitStore::bitseq<System.UInt32>(System.UInt32,System.Span`1<System.Byte>,System.Int32)
  IL_0008: ret
}

}
void bitseq_64u(ulong value, Span<byte> dst)
{
//  Id := 100664373, Name := System.Void Z0.OpCodes.bitstore::bitseq_64u(System.UInt64,System.Span`1<System.Byte>)
//  void bitseq_64u(ulong value, Span<byte> dst)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: ldc.i4.0
  IL_0003: call System.Void Z0.BitStore::bitseq<System.UInt64>(System.UInt64,System.Span`1<System.Byte>,System.Int32)
  IL_0008: ret
}

}
ReadOnlySpan<byte> bitseq(int offset, int count)
{
//  Id := 100664374, Name := System.ReadOnlySpan`1<System.Byte> Z0.OpCodes.bitstore::bitseq(System.Int32,System.Int32)
//  ReadOnlySpan<byte> bitseq(int offset, int count)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call System.ReadOnlySpan`1<System.Byte> Z0.BitStore::select(System.Int32,System.Int32)
  IL_0007: ret
}

}
ReadOnlySpan<byte> bitseq8u(byte src)
{
//  Id := 100664375, Name := System.ReadOnlySpan`1<System.Byte> Z0.OpCodes.bitstore::bitseq8u(System.Byte)
//  ReadOnlySpan<byte> bitseq8u(byte src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.ReadOnlySpan`1<System.Byte> Z0.BitStore::bitseq<System.Byte>(System.Byte)
  IL_0006: ret
}

}
ReadOnlySpan<Char> bitchars_8u(byte value)
{
//  Id := 100664376, Name := System.ReadOnlySpan`1<System.Char> Z0.OpCodes.bitstore::bitchars_8u(System.Byte)
//  ReadOnlySpan<Char> bitchars_8u(byte value)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.ReadOnlySpan`1<System.Char> Z0.BitStore::bitchars(System.Byte)
  IL_0006: ret
}

}
void bitchars_8u(byte value, Span<Char> dst)
{
//  Id := 100664377, Name := System.Void Z0.OpCodes.bitstore::bitchars_8u(System.Byte,System.Span`1<System.Char>)
//  void bitchars_8u(byte value, Span<Char> dst)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: ldc.i4.0
  IL_0003: call System.Void Z0.BitStore::bitchars<System.Byte>(System.Byte,System.Span`1<System.Char>,System.Int32)
  IL_0008: ret
}

}
void bitchars_16u(ushort value, Span<Char> dst)
{
//  Id := 100664378, Name := System.Void Z0.OpCodes.bitstore::bitchars_16u(System.UInt16,System.Span`1<System.Char>)
//  void bitchars_16u(ushort value, Span<Char> dst)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: ldc.i4.0
  IL_0003: call System.Void Z0.BitStore::bitchars<System.UInt16>(System.UInt16,System.Span`1<System.Char>,System.Int32)
  IL_0008: ret
}

}
void bitchars_32u(uint value, Span<Char> dst)
{
//  Id := 100664379, Name := System.Void Z0.OpCodes.bitstore::bitchars_32u(System.UInt32,System.Span`1<System.Char>)
//  void bitchars_32u(uint value, Span<Char> dst)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: ldc.i4.0
  IL_0003: call System.Void Z0.BitStore::bitchars<System.UInt32>(System.UInt32,System.Span`1<System.Char>,System.Int32)
  IL_0008: ret
}

}
void bitchars_64u(ulong value, Span<Char> dst)
{
//  Id := 100664380, Name := System.Void Z0.OpCodes.bitstore::bitchars_64u(System.UInt64,System.Span`1<System.Char>)
//  void bitchars_64u(ulong value, Span<Char> dst)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: ldc.i4.0
  IL_0003: call System.Void Z0.BitStore::bitchars<System.UInt64>(System.UInt64,System.Span`1<System.Char>,System.Int32)
  IL_0008: ret
}

}
