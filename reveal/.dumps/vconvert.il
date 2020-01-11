// 2020-01-11 03:38:50:198
Vector128<uint> convert(Vector256<ulong> src, N128 w, uint t)
{
//  Id := 100664654, Name := System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.OpCodes.vconvert::convert(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,Z0.N128,System.UInt32)
//  Vector128<uint> convert(Vector256<ulong> src, N128 w, uint t)
//  AggressiveInlining
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: ldarg.2
  IL_0003: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.dinx::convert(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,Z0.N128,System.UInt32)
  IL_0008: ret
}

}
sbyte vmovelo_8i(Vector128<sbyte> src, N8 w)
{
//  Id := 100664655, Name := System.SByte Z0.OpCodes.vconvert::vmovelo_8i(System.Runtime.Intrinsics.Vector128`1<System.SByte>,Z0.N8)
//  sbyte vmovelo_8i(Vector128<sbyte> src, N8 w)
//  AggressiveInlining
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call System.SByte Z0.dinx::vmovelo(System.Runtime.Intrinsics.Vector128`1<System.SByte>,Z0.N8)
  IL_0007: ret
}

}
byte vmovelo_8u(Vector128<byte> src, N8 w)
{
//  Id := 100664656, Name := System.Byte Z0.OpCodes.vconvert::vmovelo_8u(System.Runtime.Intrinsics.Vector128`1<System.Byte>,Z0.N8)
//  byte vmovelo_8u(Vector128<byte> src, N8 w)
//  AggressiveInlining
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call System.Byte Z0.dinx::vmovelo(System.Runtime.Intrinsics.Vector128`1<System.Byte>,Z0.N8)
  IL_0007: ret
}

}
short vmovelo_16i(Vector128<short> src, N16 w)
{
//  Id := 100664657, Name := System.Int16 Z0.OpCodes.vconvert::vmovelo_16i(System.Runtime.Intrinsics.Vector128`1<System.Int16>,Z0.N16)
//  short vmovelo_16i(Vector128<short> src, N16 w)
//  AggressiveInlining
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call System.Int16 Z0.dinx::vmovelo(System.Runtime.Intrinsics.Vector128`1<System.Int16>,Z0.N16)
  IL_0007: ret
}

}
ushort vmovelo_16u(Vector128<ushort> src, N16 w)
{
//  Id := 100664658, Name := System.UInt16 Z0.OpCodes.vconvert::vmovelo_16u(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,Z0.N16)
//  ushort vmovelo_16u(Vector128<ushort> src, N16 w)
//  AggressiveInlining
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call System.UInt16 Z0.dinx::vmovelo(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,Z0.N16)
  IL_0007: ret
}

}
int vmovelo_32i(Vector128<int> src, N32 w)
{
//  Id := 100664659, Name := System.Int32 Z0.OpCodes.vconvert::vmovelo_32i(System.Runtime.Intrinsics.Vector128`1<System.Int32>,Z0.N32)
//  int vmovelo_32i(Vector128<int> src, N32 w)
//  AggressiveInlining
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call System.Int32 Z0.dinx::vmovelo(System.Runtime.Intrinsics.Vector128`1<System.Int32>,Z0.N32)
  IL_0007: ret
}

}
uint vmovelo_32u(Vector128<uint> src, N32 w)
{
//  Id := 100664660, Name := System.UInt32 Z0.OpCodes.vconvert::vmovelo_32u(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,Z0.N32)
//  uint vmovelo_32u(Vector128<uint> src, N32 w)
//  AggressiveInlining
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call System.UInt32 Z0.dinx::vmovelo(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,Z0.N32)
  IL_0007: ret
}

}
long vmovelo_64i(Vector128<long> src, N64 w)
{
//  Id := 100664661, Name := System.Int64 Z0.OpCodes.vconvert::vmovelo_64i(System.Runtime.Intrinsics.Vector128`1<System.Int64>,Z0.N64)
//  long vmovelo_64i(Vector128<long> src, N64 w)
//  AggressiveInlining
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call System.Int64 Z0.dinx::vmovelo(System.Runtime.Intrinsics.Vector128`1<System.Int64>,Z0.N64)
  IL_0007: ret
}

}
ulong vmovelo_64u(Vector128<ulong> src, N64 w)
{
//  Id := 100664662, Name := System.UInt64 Z0.OpCodes.vconvert::vmovelo_64u(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,Z0.N64)
//  ulong vmovelo_64u(Vector128<ulong> src, N64 w)
//  AggressiveInlining
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call System.UInt64 Z0.dinx::vmovelo(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,Z0.N64)
  IL_0007: ret
}

}
Vector128<float> vmovelo_32x128x32(int src, Vector128<float> dst)
{
//  Id := 100664663, Name := System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.OpCodes.vconvert::vmovelo_32x128x32(System.Int32,System.Runtime.Intrinsics.Vector128`1<System.Single>)
//  Vector128<float> vmovelo_32x128x32(int src, Vector128<float> dst)
//  AggressiveInlining
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.dinx::vmovelo(System.Int32,System.Runtime.Intrinsics.Vector128`1<System.Single>)
  IL_0007: ret
}

}
Vector128<double> movelo_32x128x64(int src, Vector128<double> dst)
{
//  Id := 100664664, Name := System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.OpCodes.vconvert::movelo_32x128x64(System.Int32,System.Runtime.Intrinsics.Vector128`1<System.Double>)
//  Vector128<double> movelo_32x128x64(int src, Vector128<double> dst)
//  AggressiveInlining
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.dinx::vmovelo(System.Int32,System.Runtime.Intrinsics.Vector128`1<System.Double>)
  IL_0007: ret
}

}
Vector128<double> movelo_64x128x64(long src, Vector128<double> dst)
{
//  Id := 100664665, Name := System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.OpCodes.vconvert::movelo_64x128x64(System.Int64,System.Runtime.Intrinsics.Vector128`1<System.Double>)
//  Vector128<double> movelo_64x128x64(long src, Vector128<double> dst)
//  AggressiveInlining
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.dinx::vmovelo(System.Int64,System.Runtime.Intrinsics.Vector128`1<System.Double>)
  IL_0007: ret
}

}
Vector128<ulong> vmovelo_32x128x64u(Vector128<uint> src, Vector128<ulong> dst)
{
//  Id := 100664666, Name := System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.OpCodes.vconvert::vmovelo_32x128x64u(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
//  Vector128<ulong> vmovelo_32x128x64u(Vector128<uint> src, Vector128<ulong> dst)
//  AggressiveInlining
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.dinx::vmovelo(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
  IL_0007: ret
}

}
Vector128<long> vmovelo_32x128x64i(Vector128<int> src, Vector128<long> dst)
{
//  Id := 100664667, Name := System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.OpCodes.vconvert::vmovelo_32x128x64i(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
//  Vector128<long> vmovelo_32x128x64i(Vector128<int> src, Vector128<long> dst)
//  AggressiveInlining
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.dinx::vmovelo(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
  IL_0007: ret
}

}
Vector128<double> vmovelo_32x128x64f(Vector128<float> src, Vector128<double> dst)
{
//  Id := 100664668, Name := System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.OpCodes.vconvert::vmovelo_32x128x64f(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Double>)
//  Vector128<double> vmovelo_32x128x64f(Vector128<float> src, Vector128<double> dst)
//  AggressiveInlining
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.dinx::vmovelo(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Double>)
  IL_0007: ret
}

}
