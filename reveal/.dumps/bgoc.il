// 2019-12-07 18:40:01:767
bit read_bit_from_vector(in BitCells<N23,byte> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Byte& Z0.BitCells`2<Z0.N23,System.Byte>::get_Head()
    IL_0006: ldc.i4.3
    IL_0007: call Z0.bit Z0.BitGrid::readbit<System.Byte>(System.Byte&,System.Int32)
    IL_000C: ret

}
int segments()
{
    IL_0000: call System.Int32 Z0.BitCells`2<Z0.N23,System.Byte>::get_SegCount()
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
    IL_0013: call System.Int32 Z0.BitCalcs::cellcount<Z0.N20,Z0.N30,System.UInt32>(Z0.N20,Z0.N30,System.UInt32)
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
