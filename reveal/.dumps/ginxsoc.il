// 2019-12-08 17:58:49:594
ulong sbroadcast_8x64(byte pattern)
{
    IL_0000: ldarg.0
    IL_0001: ldloca.s V_0
    IL_0003: call System.UInt64& Z0.ginxs::sbroadcast<System.Byte,System.UInt64>(System.Byte,System.UInt64&)
    IL_0008: ldind.i8
    IL_0009: ret

}
ulong sbroadcast_8x64_const()
{
    IL_0000: ldc.i4 204
    IL_0005: ldloca.s V_0
    IL_0007: call System.UInt64& Z0.ginxs::sbroadcast<System.Byte,System.UInt64>(System.Byte,System.UInt64&)
    IL_000C: ldind.i8
    IL_000D: ret

}
