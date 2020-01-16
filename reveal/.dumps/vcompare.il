// 2020-01-15 19:20:39:396
Vector128<int> vlt_128x32i(Vector128<int> x, Vector128<int> y)
{
//  Id := 100664737, Name := System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.OpCodes.vcompare::vlt_128x32i(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
//  Vector128<int> vlt_128x32i(Vector128<int> x, Vector128<int> y)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.dinx::vlt(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
  IL_0007: ret
}

}
Vector128<int> vlt_g128x32i(Vector128<int> x, Vector128<int> y)
{
//  Id := 100664738, Name := System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.OpCodes.vcompare::vlt_g128x32i(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
//  Vector128<int> vlt_g128x32i(Vector128<int> x, Vector128<int> y)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.ginx::vlt<System.Int32>(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
  IL_0007: ret
}

}
Vector128<int> vlt_o128x32i(Vector128<int> x, Vector128<int> y)
{
//  Id := 100664739, Name := System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.OpCodes.vcompare::vlt_o128x32i(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
//  Vector128<int> vlt_o128x32i(Vector128<int> x, Vector128<int> y)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call Z0.N128 zfunc::get_n128()
  IL_0007: ldc.i4.0
  IL_0008: call Z0.VXTypes/Lt128`1<System.Int32> Z0.VX::vlt<System.Int32>(Z0.N128,System.Int32)
  IL_000D: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Pipes::apply<Z0.VXTypes/Lt128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>>(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>,Z0.VXTypes/Lt128`1<System.Int32>)
  IL_0012: ret
}

}
Vector128<uint> vlt_128x32u(Vector128<uint> x, Vector128<uint> y)
{
//  Id := 100664740, Name := System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.OpCodes.vcompare::vlt_128x32u(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
//  Vector128<uint> vlt_128x32u(Vector128<uint> x, Vector128<uint> y)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.dinx::vlt(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
  IL_0007: ret
}

}
Vector128<uint> vlt_g128x32u(Vector128<uint> x, Vector128<uint> y)
{
//  Id := 100664741, Name := System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.OpCodes.vcompare::vlt_g128x32u(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
//  Vector128<uint> vlt_g128x32u(Vector128<uint> x, Vector128<uint> y)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.ginx::vlt<System.UInt32>(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
  IL_0007: ret
}

}
Vector128<uint> vlt_o128x32u(Vector128<uint> x, Vector128<uint> y)
{
//  Id := 100664742, Name := System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.OpCodes.vcompare::vlt_o128x32u(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
//  Vector128<uint> vlt_o128x32u(Vector128<uint> x, Vector128<uint> y)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call Z0.N128 zfunc::get_n128()
  IL_0007: ldc.i4.0
  IL_0008: call Z0.VXTypes/Lt128`1<System.UInt32> Z0.VX::vlt<System.UInt32>(Z0.N128,System.UInt32)
  IL_000D: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Pipes::apply<Z0.VXTypes/Lt128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>>(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>,Z0.VXTypes/Lt128`1<System.UInt32>)
  IL_0012: ret
}

}
Vector128<long> vlt_128x64i(Vector128<long> x, Vector128<long> y)
{
//  Id := 100664743, Name := System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.OpCodes.vcompare::vlt_128x64i(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
//  Vector128<long> vlt_128x64i(Vector128<long> x, Vector128<long> y)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.dinx::vlt(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
  IL_0007: ret
}

}
Vector128<long> vlt_g128x64i(Vector128<long> x, Vector128<long> y)
{
//  Id := 100664744, Name := System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.OpCodes.vcompare::vlt_g128x64i(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
//  Vector128<long> vlt_g128x64i(Vector128<long> x, Vector128<long> y)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.ginx::vlt<System.Int64>(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
  IL_0007: ret
}

}
Vector128<long> vlt_o128x64i(Vector128<long> x, Vector128<long> y)
{
//  Id := 100664745, Name := System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.OpCodes.vcompare::vlt_o128x64i(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
//  Vector128<long> vlt_o128x64i(Vector128<long> x, Vector128<long> y)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call Z0.N128 zfunc::get_n128()
  IL_0007: ldc.i4.0
  IL_0008: conv.i8
  IL_0009: call Z0.VXTypes/Lt128`1<System.Int64> Z0.VX::vlt<System.Int64>(Z0.N128,System.Int64)
  IL_000E: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Pipes::apply<Z0.VXTypes/Lt128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>>(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>,Z0.VXTypes/Lt128`1<System.Int64>)
  IL_0013: ret
}

}
Vector256<byte> vlt_256x8u(Vector256<byte> x, Vector256<byte> y)
{
//  Id := 100664746, Name := System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.OpCodes.vcompare::vlt_256x8u(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
//  Vector256<byte> vlt_256x8u(Vector256<byte> x, Vector256<byte> y)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.dinx::vlt(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
  IL_0007: ret
}

}
Vector256<byte> vlt_g256x8u(Vector256<byte> x, Vector256<byte> y)
{
//  Id := 100664747, Name := System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.OpCodes.vcompare::vlt_g256x8u(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
//  Vector256<byte> vlt_g256x8u(Vector256<byte> x, Vector256<byte> y)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.ginx::vlt<System.Byte>(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
  IL_0007: ret
}

}
Vector256<byte> vlt_o256x8u(Vector256<byte> x, Vector256<byte> y)
{
//  Id := 100664748, Name := System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.OpCodes.vcompare::vlt_o256x8u(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
//  Vector256<byte> vlt_o256x8u(Vector256<byte> x, Vector256<byte> y)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call Z0.N256 zfunc::get_n256()
  IL_0007: ldc.i4.0
  IL_0008: call Z0.VXTypes/Lt256`1<System.Byte> Z0.VX::vlt<System.Byte>(Z0.N256,System.Byte)
  IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Pipes::apply<Z0.VXTypes/Lt256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>>(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>,Z0.VXTypes/Lt256`1<System.Byte>)
  IL_0012: ret
}

}
bool vtestz_d128x8i(Vector128<sbyte> src, Vector128<sbyte> mask)
{
//  Id := 100664749, Name := System.Boolean Z0.OpCodes.vcompare::vtestz_d128x8i(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
//  bool vtestz_d128x8i(Vector128<sbyte> src, Vector128<sbyte> mask)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call Z0.bit Z0.dinx::vtestz(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
  IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
  IL_000C: ret
}

}
bool vtestz_g128x8i(Vector128<sbyte> src, Vector128<sbyte> mask)
{
//  Id := 100664750, Name := System.Boolean Z0.OpCodes.vcompare::vtestz_g128x8i(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
//  bool vtestz_g128x8i(Vector128<sbyte> src, Vector128<sbyte> mask)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call Z0.bit Z0.ginx::vtestz<System.SByte>(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
  IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
  IL_000C: ret
}

}
bool vtestz_d128x8u(Vector128<byte> src, Vector128<byte> mask)
{
//  Id := 100664751, Name := System.Boolean Z0.OpCodes.vcompare::vtestz_d128x8u(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
//  bool vtestz_d128x8u(Vector128<byte> src, Vector128<byte> mask)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call Z0.bit Z0.dinx::vtestz(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
  IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
  IL_000C: ret
}

}
bool vtestz_g128x8u(Vector128<byte> src, Vector128<byte> mask)
{
//  Id := 100664752, Name := System.Boolean Z0.OpCodes.vcompare::vtestz_g128x8u(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
//  bool vtestz_g128x8u(Vector128<byte> src, Vector128<byte> mask)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call Z0.bit Z0.ginx::vtestz<System.Byte>(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
  IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
  IL_000C: ret
}

}
bool vtestz_d128x16i(Vector128<short> src, Vector128<short> mask)
{
//  Id := 100664753, Name := System.Boolean Z0.OpCodes.vcompare::vtestz_d128x16i(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
//  bool vtestz_d128x16i(Vector128<short> src, Vector128<short> mask)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call Z0.bit Z0.dinx::vtestz(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
  IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
  IL_000C: ret
}

}
bool vtestz_g128x16i(Vector128<short> src, Vector128<short> mask)
{
//  Id := 100664754, Name := System.Boolean Z0.OpCodes.vcompare::vtestz_g128x16i(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
//  bool vtestz_g128x16i(Vector128<short> src, Vector128<short> mask)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call Z0.bit Z0.ginx::vtestz<System.Int16>(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
  IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
  IL_000C: ret
}

}
bool vtestz_d128x16u(Vector128<ushort> src, Vector128<ushort> mask)
{
//  Id := 100664755, Name := System.Boolean Z0.OpCodes.vcompare::vtestz_d128x16u(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
//  bool vtestz_d128x16u(Vector128<ushort> src, Vector128<ushort> mask)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call Z0.bit Z0.dinx::vtestz(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
  IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
  IL_000C: ret
}

}
bool vtestz_g128x16u(Vector128<ushort> src, Vector128<ushort> mask)
{
//  Id := 100664756, Name := System.Boolean Z0.OpCodes.vcompare::vtestz_g128x16u(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
//  bool vtestz_g128x16u(Vector128<ushort> src, Vector128<ushort> mask)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call Z0.bit Z0.ginx::vtestz<System.UInt16>(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
  IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
  IL_000C: ret
}

}
bool vtestz_d128x32i(Vector128<int> src, Vector128<int> mask)
{
//  Id := 100664757, Name := System.Boolean Z0.OpCodes.vcompare::vtestz_d128x32i(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
//  bool vtestz_d128x32i(Vector128<int> src, Vector128<int> mask)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call Z0.bit Z0.dinx::vtestz(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
  IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
  IL_000C: ret
}

}
bool vtestz_g128x32i(Vector128<int> src, Vector128<int> mask)
{
//  Id := 100664758, Name := System.Boolean Z0.OpCodes.vcompare::vtestz_g128x32i(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
//  bool vtestz_g128x32i(Vector128<int> src, Vector128<int> mask)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call Z0.bit Z0.ginx::vtestz<System.Int32>(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
  IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
  IL_000C: ret
}

}
bool vtestz_d128x32u(Vector128<uint> src, Vector128<uint> mask)
{
//  Id := 100664759, Name := System.Boolean Z0.OpCodes.vcompare::vtestz_d128x32u(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
//  bool vtestz_d128x32u(Vector128<uint> src, Vector128<uint> mask)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call Z0.bit Z0.dinx::vtestz(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
  IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
  IL_000C: ret
}

}
bool vtestz_g128x32u(Vector128<uint> src, Vector128<uint> mask)
{
//  Id := 100664760, Name := System.Boolean Z0.OpCodes.vcompare::vtestz_g128x32u(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
//  bool vtestz_g128x32u(Vector128<uint> src, Vector128<uint> mask)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call Z0.bit Z0.ginx::vtestz<System.UInt32>(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
  IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
  IL_000C: ret
}

}
bool vtestz_d128x64i(Vector128<long> src, Vector128<long> mask)
{
//  Id := 100664761, Name := System.Boolean Z0.OpCodes.vcompare::vtestz_d128x64i(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
//  bool vtestz_d128x64i(Vector128<long> src, Vector128<long> mask)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call Z0.bit Z0.dinx::vtestz(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
  IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
  IL_000C: ret
}

}
bool vtestz_g128x64i(Vector128<long> src, Vector128<long> mask)
{
//  Id := 100664762, Name := System.Boolean Z0.OpCodes.vcompare::vtestz_g128x64i(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
//  bool vtestz_g128x64i(Vector128<long> src, Vector128<long> mask)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call Z0.bit Z0.ginx::vtestz<System.Int64>(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
  IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
  IL_000C: ret
}

}
bool vtestz_d128x64u(Vector128<ulong> src, Vector128<ulong> mask)
{
//  Id := 100664763, Name := System.Boolean Z0.OpCodes.vcompare::vtestz_d128x64u(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
//  bool vtestz_d128x64u(Vector128<ulong> src, Vector128<ulong> mask)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call Z0.bit Z0.dinx::vtestz(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
  IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
  IL_000C: ret
}

}
bool vtestz_g128x64u(Vector128<ulong> src, Vector128<ulong> mask)
{
//  Id := 100664764, Name := System.Boolean Z0.OpCodes.vcompare::vtestz_g128x64u(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
//  bool vtestz_g128x64u(Vector128<ulong> src, Vector128<ulong> mask)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call Z0.bit Z0.ginx::vtestz<System.UInt64>(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
  IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
  IL_000C: ret
}

}
bool vtestz_d256x8i(Vector256<sbyte> src, Vector256<sbyte> mask)
{
//  Id := 100664765, Name := System.Boolean Z0.OpCodes.vcompare::vtestz_d256x8i(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
//  bool vtestz_d256x8i(Vector256<sbyte> src, Vector256<sbyte> mask)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call Z0.bit Z0.dinx::vtestz(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
  IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
  IL_000C: ret
}

}
bool vtestz_g256x8i(Vector256<sbyte> src, Vector256<sbyte> mask)
{
//  Id := 100664766, Name := System.Boolean Z0.OpCodes.vcompare::vtestz_g256x8i(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
//  bool vtestz_g256x8i(Vector256<sbyte> src, Vector256<sbyte> mask)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call Z0.bit Z0.ginx::vtestz<System.SByte>(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
  IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
  IL_000C: ret
}

}
bool vtestz_d256x8u(Vector256<byte> src, Vector256<byte> mask)
{
//  Id := 100664767, Name := System.Boolean Z0.OpCodes.vcompare::vtestz_d256x8u(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
//  bool vtestz_d256x8u(Vector256<byte> src, Vector256<byte> mask)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call Z0.bit Z0.dinx::vtestz(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
  IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
  IL_000C: ret
}

}
bool vtestz_g256x8u(Vector256<byte> src, Vector256<byte> mask)
{
//  Id := 100664768, Name := System.Boolean Z0.OpCodes.vcompare::vtestz_g256x8u(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
//  bool vtestz_g256x8u(Vector256<byte> src, Vector256<byte> mask)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call Z0.bit Z0.ginx::vtestz<System.Byte>(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
  IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
  IL_000C: ret
}

}
bool vtestz_d256x16i(Vector256<short> src, Vector256<short> mask)
{
//  Id := 100664769, Name := System.Boolean Z0.OpCodes.vcompare::vtestz_d256x16i(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
//  bool vtestz_d256x16i(Vector256<short> src, Vector256<short> mask)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call Z0.bit Z0.dinx::vtestz(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
  IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
  IL_000C: ret
}

}
bool vtestz_g256x16i(Vector256<short> src, Vector256<short> mask)
{
//  Id := 100664770, Name := System.Boolean Z0.OpCodes.vcompare::vtestz_g256x16i(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
//  bool vtestz_g256x16i(Vector256<short> src, Vector256<short> mask)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call Z0.bit Z0.ginx::vtestz<System.Int16>(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
  IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
  IL_000C: ret
}

}
bool vtestz_d256x16u(Vector256<ushort> src, Vector256<ushort> mask)
{
//  Id := 100664771, Name := System.Boolean Z0.OpCodes.vcompare::vtestz_d256x16u(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
//  bool vtestz_d256x16u(Vector256<ushort> src, Vector256<ushort> mask)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call Z0.bit Z0.dinx::vtestz(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
  IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
  IL_000C: ret
}

}
bool vtestz_g256x16u(Vector256<ushort> src, Vector256<ushort> mask)
{
//  Id := 100664772, Name := System.Boolean Z0.OpCodes.vcompare::vtestz_g256x16u(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
//  bool vtestz_g256x16u(Vector256<ushort> src, Vector256<ushort> mask)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call Z0.bit Z0.ginx::vtestz<System.UInt16>(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
  IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
  IL_000C: ret
}

}
bool vtestz_d256x32i(Vector256<int> src, Vector256<int> mask)
{
//  Id := 100664773, Name := System.Boolean Z0.OpCodes.vcompare::vtestz_d256x32i(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
//  bool vtestz_d256x32i(Vector256<int> src, Vector256<int> mask)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call Z0.bit Z0.dinx::vtestz(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
  IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
  IL_000C: ret
}

}
bool vtestz_g256x32i(Vector256<int> src, Vector256<int> mask)
{
//  Id := 100664774, Name := System.Boolean Z0.OpCodes.vcompare::vtestz_g256x32i(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
//  bool vtestz_g256x32i(Vector256<int> src, Vector256<int> mask)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call Z0.bit Z0.ginx::vtestz<System.Int32>(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
  IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
  IL_000C: ret
}

}
bool vtestz_d256x32u(Vector256<uint> src, Vector256<uint> mask)
{
//  Id := 100664775, Name := System.Boolean Z0.OpCodes.vcompare::vtestz_d256x32u(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
//  bool vtestz_d256x32u(Vector256<uint> src, Vector256<uint> mask)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call Z0.bit Z0.dinx::vtestz(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
  IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
  IL_000C: ret
}

}
bool vtestz_g256x32u(Vector256<uint> src, Vector256<uint> mask)
{
//  Id := 100664776, Name := System.Boolean Z0.OpCodes.vcompare::vtestz_g256x32u(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
//  bool vtestz_g256x32u(Vector256<uint> src, Vector256<uint> mask)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call Z0.bit Z0.ginx::vtestz<System.UInt32>(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
  IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
  IL_000C: ret
}

}
bool vtestz_d256x64i(Vector256<long> src, Vector256<long> mask)
{
//  Id := 100664777, Name := System.Boolean Z0.OpCodes.vcompare::vtestz_d256x64i(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
//  bool vtestz_d256x64i(Vector256<long> src, Vector256<long> mask)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call Z0.bit Z0.dinx::vtestz(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
  IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
  IL_000C: ret
}

}
bool vtestz_g256x64i(Vector256<long> src, Vector256<long> mask)
{
//  Id := 100664778, Name := System.Boolean Z0.OpCodes.vcompare::vtestz_g256x64i(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
//  bool vtestz_g256x64i(Vector256<long> src, Vector256<long> mask)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call Z0.bit Z0.ginx::vtestz<System.Int64>(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
  IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
  IL_000C: ret
}

}
bool vtestz_d256x64u(Vector256<ulong> src, Vector256<ulong> mask)
{
//  Id := 100664779, Name := System.Boolean Z0.OpCodes.vcompare::vtestz_d256x64u(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
//  bool vtestz_d256x64u(Vector256<ulong> src, Vector256<ulong> mask)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call Z0.bit Z0.dinx::vtestz(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
  IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
  IL_000C: ret
}

}
bool vtestz_g256x64u(Vector256<ulong> src, Vector256<ulong> mask)
{
//  Id := 100664780, Name := System.Boolean Z0.OpCodes.vcompare::vtestz_g256x64u(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
//  bool vtestz_g256x64u(Vector256<ulong> src, Vector256<ulong> mask)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call Z0.bit Z0.ginx::vtestz<System.UInt64>(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
  IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
  IL_000C: ret
}

}
