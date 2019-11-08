// 2019-11-08 02:45:47:577
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
bit readbit_row_col(in GridMoniker moniker, in ulong src, int row, int col)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: ldarg.3
    IL_0004: call Z0.bit Z0.BitGrid::readbit<System.UInt64>(Z0.GridMoniker&,System.UInt64&,System.Int32,System.Int32)
    IL_0009: ret

}
bit readbit_g_position(in GridMoniker moniker, in ulong src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call Z0.bit Z0.BitGrid::readbit<System.UInt64>(Z0.GridMoniker&,System.UInt64&,System.Int32)
    IL_0008: ret

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
