// 2020-01-16 19:14:11:201
// Id := 100663309, Name := System.Void Z0.bitgrid::part63x3(System.UInt64,Z0.NatSpan`2<Z0.N21,System.Byte>)
// void part63x3(ulong src, NatSpan<N21,byte> dst)
// Managed
void part63x3(ulong src, NatSpan<N21,byte> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarga.s dst
    IL_0003: call System.Void Z0.Bits::part63x3(System.UInt64,Z0.NatSpan`2<Z0.N21,System.Byte>&)
    IL_0008: ret
}

// Id := 100663310, Name := System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.bitgrid::bitgrid_vector256(Z0.BitGrid`1<System.Byte>,System.Int32)
// Vector256<byte> bitgrid_vector256(BitGrid<byte> src, int block)
// Managed
Vector256<byte> bitgrid_vector256(BitGrid<byte> src, int block)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: call Z0.N256 zfunc::get_n256()
    IL_0008: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.BitGrid::vector<System.Byte>(Z0.BitGrid`1<System.Byte>&,System.Int32,Z0.N256)
    IL_000D: ret
}

// Id := 100663311, Name := Z0.BitGrid256`3<Z0.N16,Z0.N16,System.UInt16> Z0.bitgrid::transpose(Z0.BitGrid256`3<Z0.N16,Z0.N16,System.UInt16>)
// BitGrid256<N16,N16,ushort> transpose(BitGrid256<N16,N16,ushort> g)
// Managed
BitGrid256<N16,N16,ushort> transpose(BitGrid256<N16,N16,ushort> g)
{
    IL_0000: ldarga.s g
    IL_0002: call Z0.BitGrid256`3<Z0.N16,Z0.N16,System.UInt16> Z0.BitGrid::transpose(Z0.BitGrid256`3<Z0.N16,Z0.N16,System.UInt16>&)
    IL_0007: ret
}

// Id := 100663312, Name := Z0.bit Z0.bitgrid::read_bit_from_vector(Z0.BitBlock`2<Z0.N23,System.Byte>&)
// bit read_bit_from_vector(in BitBlock<N23,byte> src)
// Managed
bit read_bit_from_vector(in BitBlock<N23,byte> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Byte& Z0.BitBlock`2<Z0.N23,System.Byte>::get_Head()
    IL_0006: ldc.i4.3
    IL_0007: call Z0.bit Z0.BitGrid::readbit<System.Byte>(System.Byte&,System.Int32)
    IL_000C: ret
}

// Id := 100663313, Name := System.Int32 Z0.bitgrid::segments()
// int segments()
// Managed
int segments()
{
    IL_0000: call System.Int32 Z0.BitBlock`2<Z0.N23,System.Byte>::get_CellCount()
    IL_0005: ret
}

// Id := 100663314, Name := System.Int32 Z0.bitgrid::count_segs()
// int count_segs()
// Managed
int count_segs()
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

// Id := 100663315, Name := Z0.bit Z0.bitgrid::readbit_row_col_2(System.Int32,System.UInt64,System.Int32,System.Int32)
// bit readbit_row_col_2(int n, ulong src, int row, int col)
// Managed
bit readbit_row_col_2(int n, ulong src, int row, int col)
{
    IL_0000: ldarg.0
    IL_0001: ldarga.s src
    IL_0003: ldarg.2
    IL_0004: ldarg.3
    IL_0005: call Z0.bit Z0.BitGrid::readbit<System.UInt64>(System.Int32,System.UInt64&,System.Int32,System.Int32)
    IL_000A: ret
}

// Id := 100663316, Name := Z0.bit Z0.bitgrid::readbit_g_position(System.UInt64&,System.Int32)
// bit readbit_g_position(in ulong src, int pos)
// Managed
bit readbit_g_position(in ulong src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.BitGrid::readbit<System.UInt64>(System.UInt64&,System.Int32)
    IL_0007: ret
}

