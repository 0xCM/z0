// 2020-01-15 19:20:39:187
Vector512<uint> add_512x32u(Vector512<uint> x, Vector512<uint> y)
{
//  Id := 100664731, Name := Z0.Vector512`1<System.UInt32> Z0.OpCodes.v512::add_512x32u(Z0.Vector512`1<System.UInt32>,Z0.Vector512`1<System.UInt32>)
//  Vector512<uint> add_512x32u(Vector512<uint> x, Vector512<uint> y)
//  Managed
{
  IL_0000: ldarga.s x
  IL_0002: ldarga.s y
  IL_0004: call Z0.Vector512`1<System.UInt32> Z0.dinx::vadd(Z0.Vector512`1<System.UInt32>&,Z0.Vector512`1<System.UInt32>&)
  IL_0009: ret
}

}
void add_2x256x32u(Vector256<uint> x0, Vector256<uint> y0, Vector256<uint> x1, Vector256<uint> y1, out Vector256<uint> z0, out Vector256<uint> z1)
{
//  Id := 100664732, Name := System.Void Z0.OpCodes.v512::add_2x256x32u(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>&,System.Runtime.Intrinsics.Vector256`1<System.UInt32>&)
//  void add_2x256x32u(Vector256<uint> x0, Vector256<uint> y0, Vector256<uint> x1, Vector256<uint> y1, out Vector256<uint> z0, out Vector256<uint> z1)
//  AggressiveInlining
{
  IL_0000: ldarg.s z0
  IL_0002: ldarg.0
  IL_0003: ldarg.1
  IL_0004: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::Add(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
  IL_0009: stobj System.Runtime.Intrinsics.Vector256`1<System.UInt32>
  IL_000E: ldarg.s z1
  IL_0010: ldarg.2
  IL_0011: ldarg.3
  IL_0012: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::Add(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
  IL_0017: stobj System.Runtime.Intrinsics.Vector256`1<System.UInt32>
  IL_001C: ret
}

}
