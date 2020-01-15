// 2020-01-15 03:58:00:489
void part63x3(ulong src, NatSpan<N21,byte> dst)
{
//  Id := 100663345, Name := System.Void Z0.bitgrid::part63x3(System.UInt64,Z0.NatSpan`2<Z0.N21,System.Byte>)
//  void part63x3(ulong src, NatSpan<N21,byte> dst)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarga.s dst
  IL_0003: call System.Void Z0.Bits::part63x3(System.UInt64,Z0.NatSpan`2<Z0.N21,System.Byte>&)
  IL_0008: ret
}

}
Vector256<byte> bitgrid_vector256(BitGrid<byte> src, int block)
{
//  Id := 100663346, Name := System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.bitgrid::bitgrid_vector256(Z0.BitGrid`1<System.Byte>,System.Int32)
//  Vector256<byte> bitgrid_vector256(BitGrid<byte> src, int block)
//  Managed
{
  IL_0000: ldarga.s src
  IL_0002: ldarg.1
  IL_0003: call Z0.N256 zfunc::get_n256()
  IL_0008: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.BitGrid::vector<System.Byte>(Z0.BitGrid`1<System.Byte>&,System.Int32,Z0.N256)
  IL_000D: ret
}

}
BitGrid256<N16,N16,ushort> transpose(BitGrid256<N16,N16,ushort> g)
{
//  Id := 100663347, Name := Z0.BitGrid256`3<Z0.N16,Z0.N16,System.UInt16> Z0.bitgrid::transpose(Z0.BitGrid256`3<Z0.N16,Z0.N16,System.UInt16>)
//  BitGrid256<N16,N16,ushort> transpose(BitGrid256<N16,N16,ushort> g)
//  Managed
{
  IL_0000: ldarga.s g
  IL_0002: call Z0.BitGrid256`3<Z0.N16,Z0.N16,System.UInt16> Z0.BitGrid::transpose(Z0.BitGrid256`3<Z0.N16,Z0.N16,System.UInt16>&)
  IL_0007: ret
}

}
bit read_bit_from_vector(in BitBlock<N23,byte> src)
{
//  Id := 100663348, Name := Z0.bit Z0.bitgrid::read_bit_from_vector(Z0.BitBlock`2<Z0.N23,System.Byte>&)
//  bit read_bit_from_vector(in BitBlock<N23,byte> src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.Byte& Z0.BitBlock`2<Z0.N23,System.Byte>::get_Head()
  IL_0006: ldc.i4.3
  IL_0007: call Z0.bit Z0.BitGrid::readbit<System.Byte>(System.Byte&,System.Int32)
  IL_000C: ret
}

}
int segments()
{
//  Id := 100663349, Name := System.Int32 Z0.bitgrid::segments()
//  int segments()
//  Managed
{
  IL_0000: call System.Int32 Z0.BitBlock`2<Z0.N23,System.Byte>::get_CellCount()
  IL_0005: ret
}

}
int count_segs()
{
//  Id := 100663350, Name := System.Int32 Z0.bitgrid::count_segs()
//  int count_segs()
//  Managed
{
  IL_0000: ldloca.s V_0
  IL_0002: initobj Z0.N20
  IL_0008: ldloc.0
  IL_0009: ldloca.s V_1
  IL_000B: initobj Z0.N30
  IL_0011: ldloc.1
  IL_0012: ldc.i4.0
  IL_0013: call System.Int32 Z0.BitCalcs::tablecells<Z0.N20,Z0.N30,System.UInt32>(Z0.N20,Z0.N30,System.UInt32)
  IL_0018: ret
}

}
bit readbit_row_col_2(int n, ulong src, int row, int col)
{
//  Id := 100663351, Name := Z0.bit Z0.bitgrid::readbit_row_col_2(System.Int32,System.UInt64,System.Int32,System.Int32)
//  bit readbit_row_col_2(int n, ulong src, int row, int col)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarga.s src
  IL_0003: ldarg.2
  IL_0004: ldarg.3
  IL_0005: call Z0.bit Z0.BitGrid::readbit<System.UInt64>(System.Int32,System.UInt64&,System.Int32,System.Int32)
  IL_000A: ret
}

}
bit readbit_g_position(in ulong src, int pos)
{
//  Id := 100663352, Name := Z0.bit Z0.bitgrid::readbit_g_position(System.UInt64&,System.Int32)
//  bit readbit_g_position(in ulong src, int pos)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call Z0.bit Z0.BitGrid::readbit<System.UInt64>(System.UInt64&,System.Int32)
  IL_0007: ret
}

}
