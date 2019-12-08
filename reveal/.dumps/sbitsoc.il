// 2019-12-07 18:40:03:040
uint pack32x1(ConstBlock256<byte> src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.UInt32 Z0.Bits::pack8x1(Z0.ConstBlock256`1<System.Byte>&)
    IL_0007: ret

}
void split_g64(ulong src, int index, out ulong x0, out ulong x1)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: ldarg.3
    IL_0004: call System.Void Z0.gbits::split<System.UInt64>(System.UInt64,System.Int32,System.UInt64&,System.UInt64&)
    IL_0009: ret

}
void split_64(ulong src, int index, out ulong x0, out ulong x1)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: ldarg.3
    IL_0004: call System.Void Z0.Bits::split(System.UInt64,System.Int32,System.UInt64&,System.UInt64&)
    IL_0009: ret

}
void split_exact(ulong src, out uint x0, out uint x1)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.Void Z0.Bits::split(System.UInt64,System.UInt32&,System.UInt32&)
    IL_0008: ret

}
