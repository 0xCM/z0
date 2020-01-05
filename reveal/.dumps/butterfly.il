// 2020-01-05 15:03:44:523
uint bfly_1x32(uint src)
{
    IL_0000: call Z0.N1 zfunc::get_n1()
    IL_0005: ldarg.0
    IL_0006: call System.UInt32 Z0.gbits::bfly<System.UInt32>(Z0.N1,System.UInt32)
    IL_000B: ret

}
uint bfly_1x32_op(uint src)
{
    IL_0000: call Z0.N1 zfunc::get_n1()
    IL_0005: ldc.i4.0
    IL_0006: call Z0.BCTypes/Bfly`2<Z0.N1,System.UInt32> Z0.BitCore::bfly<Z0.N1,System.UInt32>(Z0.N1,System.UInt32)
    IL_000B: stloc.0
    IL_000C: ldloca.s V_0
    IL_000E: ldarg.0
    IL_000F: call System.UInt32 Z0.BCTypes/Bfly`2<Z0.N1,System.UInt32>::Invoke(System.UInt32)
    IL_0014: ret

}
uint bfly_2x32(uint src)
{
    IL_0000: call Z0.N2 zfunc::get_n2()
    IL_0005: ldarg.0
    IL_0006: call System.UInt32 Z0.gbits::bfly<System.UInt32>(Z0.N2,System.UInt32)
    IL_000B: ret

}
uint bfly_2x32_op(uint src)
{
    IL_0000: call Z0.N2 zfunc::get_n2()
    IL_0005: ldc.i4.0
    IL_0006: call Z0.BCTypes/Bfly`2<Z0.N2,System.UInt32> Z0.BitCore::bfly<Z0.N2,System.UInt32>(Z0.N2,System.UInt32)
    IL_000B: stloc.0
    IL_000C: ldloca.s V_0
    IL_000E: ldarg.0
    IL_000F: call System.UInt32 Z0.BCTypes/Bfly`2<Z0.N2,System.UInt32>::Invoke(System.UInt32)
    IL_0014: ret

}
uint bfly_4x32(uint src)
{
    IL_0000: call Z0.N4 zfunc::get_n4()
    IL_0005: ldarg.0
    IL_0006: call System.UInt32 Z0.gbits::bfly<System.UInt32>(Z0.N4,System.UInt32)
    IL_000B: ret

}
uint bfly_4x32_op(uint src)
{
    IL_0000: call Z0.N4 zfunc::get_n4()
    IL_0005: ldc.i4.0
    IL_0006: call Z0.BCTypes/Bfly`2<Z0.N4,System.UInt32> Z0.BitCore::bfly<Z0.N4,System.UInt32>(Z0.N4,System.UInt32)
    IL_000B: stloc.0
    IL_000C: ldloca.s V_0
    IL_000E: ldarg.0
    IL_000F: call System.UInt32 Z0.BCTypes/Bfly`2<Z0.N4,System.UInt32>::Invoke(System.UInt32)
    IL_0014: ret

}
