// 2019-11-11 14:42:21:592
bit read_bit_from_vector(BitVector<N23,byte> src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Byte& Z0.BitVector`2<Z0.N23,System.Byte>::get_Head()
    IL_0007: ldc.i4.3
    IL_0008: call Z0.bit Z0.BitGrid::readbit<System.Byte>(System.Byte&,System.Int32)
    IL_000D: ret

}
bit read_bit_from_vector_2(BitVector<N23,byte> src)
{
    IL_0000: ldarga.s src
    IL_0002: ldc.i4.3
    IL_0003: call Z0.BitPos Z0.BitPos::op_Implicit(System.Int32)
    IL_0008: call Z0.bit Z0.BitVector`2<Z0.N23,System.Byte>::get_Item(Z0.BitPos)
    IL_000D: ret

}
void set_bit_in_vector(BitVector<N23,byte> src)
{
    IL_0000: ldarga.s src
    IL_0002: ldc.i4.3
    IL_0003: call Z0.BitPos Z0.BitPos::op_Implicit(System.Int32)
    IL_0008: call Z0.bit Z0.bit::get_On()
    IL_000D: call System.Void Z0.BitVector`2<Z0.N23,System.Byte>::set_Item(Z0.BitPos,Z0.bit)
    IL_0012: ret

}
void set_bit_in_grid(BitGrid<N23,N1,byte> src)
{
    IL_0000: ldarga.s src
    IL_0002: ldc.i4.3
    IL_0003: call Z0.bit Z0.bit::get_On()
    IL_0008: call System.Void Z0.BitGrid`3<Z0.N23,Z0.N1,System.Byte>::set_Item(System.Int32,Z0.bit)
    IL_000D: ret

}
int segments()
{
    IL_0000: call System.Int32 Z0.BitVector`2<Z0.N23,System.Byte>::get_SegCount()
    IL_0005: ret

}
GridSpec calc_spec_1()
{
    IL_0000: ldloca.s V_0
    IL_0002: initobj Z0.N20
    IL_0008: ldloc.0
    IL_0009: ldloca.s V_1
    IL_000B: initobj Z0.N30
    IL_0011: ldloc.1
    IL_0012: ldc.i4.0
    IL_0013: call Z0.GridSpec Z0.BitGrid::specify<Z0.N20,Z0.N30,System.UInt32>(Z0.N20,Z0.N30,System.UInt32)
    IL_0018: ret

}
GridSpec calc_spec_3()
{
    IL_0000: call Z0.N20 zfunc::get_n20()
    IL_0005: call Z0.N30 zfunc::get_n30()
    IL_000A: ldc.i4.0
    IL_000B: call Z0.GridSpec Z0.BitGrid::specify<Z0.N20,Z0.N30,System.UInt32>(Z0.N20,Z0.N30,System.UInt32)
    IL_0010: ret

}
GridSpec calc_spec_2()
{
    IL_0000: ldloca.s V_0
    IL_0002: initobj Z0.N20
    IL_0008: ldloc.0
    IL_0009: ldloca.s V_1
    IL_000B: initobj Z0.N30
    IL_0011: ldloc.1
    IL_0012: ldc.i4.0
    IL_0013: call Z0.GridSpec Z0.BitGrid::specify<Z0.N20,Z0.N30,System.UInt32>(Z0.N20,Z0.N30,System.UInt32)
    IL_0018: ret

}
int count_segs()
{
    IL_0000: ldloca.s V_0
    IL_0002: initobj Z0.N20
    IL_0008: ldloc.0
    IL_0009: ldloca.s V_1
    IL_000B: initobj Z0.N30
    IL_0011: ldloc.1
    IL_0012: ldc.i4.0
    IL_0013: call System.Int32 Z0.BitGrid::segments<Z0.N20,Z0.N30,System.UInt32>(Z0.N20,Z0.N30,System.UInt32)
    IL_0018: ret

}
bit readbit_row_col_many(in GridMoniker moniker, in ulong src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.1
    IL_0003: ldc.i4.2
    IL_0004: call Z0.bit Z0.BitGrid::readbit<System.UInt64>(Z0.GridMoniker&,System.UInt64&,System.Int32,System.Int32)
    IL_0009: stloc.0
    IL_000A: ldloc.0
    IL_000B: ldarg.0
    IL_000C: ldarg.1
    IL_000D: ldc.i4.1
    IL_000E: ldc.i4.3
    IL_000F: call Z0.bit Z0.BitGrid::readbit<System.UInt64>(Z0.GridMoniker&,System.UInt64&,System.Int32,System.Int32)
    IL_0014: call Z0.bit Z0.bit::op_BitwiseAnd(Z0.bit,Z0.bit)
    IL_0019: stloc.0
    IL_001A: ldloc.0
    IL_001B: ldarg.0
    IL_001C: ldarg.1
    IL_001D: ldc.i4.4
    IL_001E: ldc.i4.5
    IL_001F: call Z0.bit Z0.BitGrid::readbit<System.UInt64>(Z0.GridMoniker&,System.UInt64&,System.Int32,System.Int32)
    IL_0024: call Z0.bit Z0.bit::op_BitwiseAnd(Z0.bit,Z0.bit)
    IL_0029: stloc.0
    IL_002A: ldloc.0
    IL_002B: ret

}
bit readbit_row_col(in GridMoniker moniker, in ulong src, int row, int col)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: ldarg.3
    IL_0004: call Z0.bit Z0.BitGrid::readbit<System.UInt64>(Z0.GridMoniker&,System.UInt64&,System.Int32,System.Int32)
    IL_0009: ret

}
bit readbit_row_col_2(int n, ulong src, int row, int col)
{
    IL_0000: ldarg.0
    IL_0001: ldarga.s src
    IL_0003: ldarg.2
    IL_0004: ldarg.3
    IL_0005: call Z0.bit Z0.BitGrid::readbit<System.UInt64>(System.Int32,System.UInt64&,System.Int32,System.Int32)
    IL_000A: ret

}
bit readbit_g_position(in ulong src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.BitGrid::readbit<System.UInt64>(System.UInt64&,System.Int32)
    IL_0007: ret

}
void setbit(in GridMoniker moniker, int row, int col, bit state, ref ulong dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: ldarg.3
    IL_0004: ldarg.s dst
    IL_0006: call System.Void Z0.BitGrid::setbit<System.UInt64>(Z0.GridMoniker&,System.Int32,System.Int32,Z0.bit,System.UInt64&)
    IL_000B: ret

}
BitGrid<uint> bg_load_32x32x32(Span<uint> src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.s 32
    IL_0003: ldc.i4.s 32
    IL_0005: call Z0.BitGrid`1<System.UInt32> Z0.BitGrid::load<System.UInt32>(System.Span`1<System.UInt32>,System.UInt16,System.UInt16)
    IL_000A: ret

}
GridSpec bg_specify(ushort rows, ushort cols, ushort segwidth)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call Z0.GridSpec Z0.BitGrid::specify(System.UInt16,System.UInt16,System.UInt16)
    IL_0008: ret

}
