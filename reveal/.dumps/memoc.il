// 2019-11-28 20:16:38:437
N64 get_n64()
{
    IL_0000: ldloca.s V_0
    IL_0002: initobj Z0.N64
    IL_0008: ldloc.0
    IL_0009: ret

}
int blockalign_64x8u_var(int cellcount)
{
    IL_0000: call Z0.N64 Z0.memoc::get_n64()
    IL_0005: ldarg.0
    IL_0006: call System.Int32 Z0.DataBlocks::blockalign<System.Byte>(Z0.N64,System.Int32)
    IL_000B: ret

}
int blockalign_64x8u_16()
{
    IL_0000: call Z0.N64 Z0.memoc::get_n64()
    IL_0005: ldc.i4.s 16
    IL_0007: call System.Int32 Z0.DataBlocks::blockalign<System.Byte>(Z0.N64,System.Int32)
    IL_000C: ret

}
int blockalign_64x8u_17()
{
    IL_0000: call Z0.N64 Z0.memoc::get_n64()
    IL_0005: ldc.i4.s 17
    IL_0007: call System.Int32 Z0.DataBlocks::blockalign<System.Byte>(Z0.N64,System.Int32)
    IL_000C: ret

}
