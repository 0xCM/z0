// 2019-11-21 19:28:33:460
void set_bit(ref uint src, byte pos, bit state)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.UInt32& Z0.gbits::set<System.UInt32>(System.UInt32&,System.Byte,Z0.bit)
    IL_0008: pop
    IL_0009: ret

}
void set_bit_on(ref uint src, byte pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.bit::get_On()
    IL_0007: call System.UInt32& Z0.gbits::set<System.UInt32>(System.UInt32&,System.Byte,Z0.bit)
    IL_000C: pop
    IL_000D: ret

}
void set_bit_off(ref uint src, byte pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.bit::get_Off()
    IL_0007: call System.UInt32& Z0.gbits::set<System.UInt32>(System.UInt32&,System.Byte,Z0.bit)
    IL_000C: pop
    IL_000D: ret

}
void store_bitstring(BitString src, in BitGrid<N8,N32,ulong> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldloca.s V_0
    IL_0004: initobj Z0.N8
    IL_000A: ldloc.0
    IL_000B: ldloca.s V_1
    IL_000D: initobj Z0.N32
    IL_0013: ldloc.1
    IL_0014: call Z0.BitGrid`3<Z0.N8,Z0.N32,System.UInt64> Z0.bgoc::StoreTo<Z0.N8,Z0.N32,System.UInt64>(Z0.BitString,Z0.BitGrid`3<Z0.N8,Z0.N32,System.UInt64>&,Z0.N8,Z0.N32)
    IL_0019: pop
    IL_001A: ret

}
bit read_bit_from_vector(in BitVector<N23,byte> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Byte& Z0.BitVector`2<Z0.N23,System.Byte>::get_Head()
    IL_0006: ldc.i4.3
    IL_0007: call Z0.bit Z0.BitGrid::readbit<System.Byte>(System.Byte&,System.Int32)
    IL_000C: ret

}
bit read_bit_from_vector_2(in BitVector<N23,byte> src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.3
    IL_0002: call Z0.bit Z0.BitVector`2<Z0.N23,System.Byte>::get_Item(System.Int32)
    IL_0007: ret

}
void set_bit_in_vector(in BitVector<N23,byte> src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.s 9
    IL_0003: call Z0.bit Z0.bit::get_On()
    IL_0008: call System.Void Z0.BitVector`2<Z0.N23,System.Byte>::set_Item(System.Int32,Z0.bit)
    IL_000D: ret

}
void set_bits_in_grid(BitGrid<N23,N11,byte> src)
{
    IL_0000: ldarga.s src
    IL_0002: ldc.i4.3
    IL_0003: call Z0.bit Z0.bit::get_On()
    IL_0008: call System.Void Z0.BitGrid`3<Z0.N23,Z0.N11,System.Byte>::set_Item(System.Int32,Z0.bit)
    IL_000D: ldarga.s src
    IL_000F: ldc.i4.5
    IL_0010: call Z0.bit Z0.bit::get_On()
    IL_0015: call System.Void Z0.BitGrid`3<Z0.N23,Z0.N11,System.Byte>::set_Item(System.Int32,Z0.bit)
    IL_001A: ldarga.s src
    IL_001C: ldc.i4.s 18
    IL_001E: call Z0.bit Z0.bit::get_On()
    IL_0023: call System.Void Z0.BitGrid`3<Z0.N23,Z0.N11,System.Byte>::set_Item(System.Int32,Z0.bit)
    IL_0028: ret

}
void set_bits_in_grid_2(BitGrid<N23,N11,byte> src, int i, int j)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: call Z0.bit Z0.bit::get_On()
    IL_0008: call System.Void Z0.BitGrid`3<Z0.N23,Z0.N11,System.Byte>::set_Item(System.Int32,Z0.bit)
    IL_000D: ldarga.s src
    IL_000F: ldarg.2
    IL_0010: call Z0.bit Z0.bit::get_On()
    IL_0015: call System.Void Z0.BitGrid`3<Z0.N23,Z0.N11,System.Byte>::set_Item(System.Int32,Z0.bit)
    IL_001A: ret

}
bit read_bit_from_grid(in BitGrid<N23,N5,byte> src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.3
    IL_0002: call Z0.bit Z0.BitGrid`3<Z0.N23,Z0.N5,System.Byte>::get_Item(System.Int32)
    IL_0007: ret

}
int segments()
{
    IL_0000: call System.Int32 Z0.BitVector`2<Z0.N23,System.Byte>::get_SegCount()
    IL_0005: ret

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
    IL_0013: call System.Int32 Z0.BitGrid::segcount<Z0.N20,Z0.N30,System.UInt32>(Z0.N20,Z0.N30,System.UInt32)
    IL_0018: ret

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
