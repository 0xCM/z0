// 2019-11-05 06:49:43:875
bit bitread(in ulong src, int M, int N, int row, int col)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: ldarg.3
    IL_0004: ldarg.s col
    IL_0006: call Z0.bit Z0.BitGrid::bitread<System.UInt64>(System.UInt64&,System.Int32,System.Int32,System.Int32,System.Int32)
    IL_000B: ret

}
void bitset(ref ulong src, int M, int N, int row, int col, bit state)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: ldarg.3
    IL_0004: ldarg.s col
    IL_0006: ldarg.s state
    IL_0008: call System.Void Z0.BitGrid::bitset<System.UInt64>(System.UInt64&,System.Int32,System.Int32,System.Int32,System.Int32,Z0.bit)
    IL_000D: ret

}
bit bitread(in byte src, int M, int N, int row, int col)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: ldarg.3
    IL_0004: ldarg.s col
    IL_0006: call Z0.bit Z0.BitGrid::bitread<System.Byte>(System.Byte&,System.Int32,System.Int32,System.Int32,System.Int32)
    IL_000B: ret

}
BitGrid<uint> bg_load_32x32x32(Span<uint> src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.s 32
    IL_0003: ldc.i4.s 32
    IL_0005: call Z0.BitGrid`1<System.UInt32> Z0.BitGrid::load<System.UInt32>(System.Span`1<System.UInt32>,System.Int32,System.Int32)
    IL_000A: ret

}
GridSpec bg_specify(int rows, int cols, int segwidth)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call Z0.GridSpec Z0.GridLayout::specify(System.Int32,System.Int32,System.Int32)
    IL_0008: ret

}
