// 2020-01-22 01:43:39:002
// Id := 100664257, Name := System.UInt32 Z0.OpCodes.butterfly::bfly_1x32(System.UInt32)
// uint bfly_1x32(uint src)
// IL
uint bfly_1x32(uint src)
{
    IL_0000: call Z0.N1 zfunc::get_n1()
    IL_0005: ldarg.0
    IL_0006: call System.UInt32 Z0.gbits::bfly<System.UInt32>(Z0.N1,System.UInt32)
    IL_000B: ret
}

// Id := 100664258, Name := System.UInt32 Z0.OpCodes.butterfly::bfly_1x32_op(System.UInt32)
// uint bfly_1x32_op(uint src)
// IL
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

// Id := 100664259, Name := System.UInt32 Z0.OpCodes.butterfly::bfly_2x32(System.UInt32)
// uint bfly_2x32(uint src)
// IL
uint bfly_2x32(uint src)
{
    IL_0000: call Z0.N2 zfunc::get_n2()
    IL_0005: ldarg.0
    IL_0006: call System.UInt32 Z0.gbits::bfly<System.UInt32>(Z0.N2,System.UInt32)
    IL_000B: ret
}

// Id := 100664260, Name := System.UInt32 Z0.OpCodes.butterfly::bfly_2x32_op(System.UInt32)
// uint bfly_2x32_op(uint src)
// IL
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

// Id := 100664261, Name := System.UInt32 Z0.OpCodes.butterfly::bfly_4x32(System.UInt32)
// uint bfly_4x32(uint src)
// IL
uint bfly_4x32(uint src)
{
    IL_0000: call Z0.N4 zfunc::get_n4()
    IL_0005: ldarg.0
    IL_0006: call System.UInt32 Z0.gbits::bfly<System.UInt32>(Z0.N4,System.UInt32)
    IL_000B: ret
}

// Id := 100664262, Name := System.UInt32 Z0.OpCodes.butterfly::bfly_4x32_op(System.UInt32)
// uint bfly_4x32_op(uint src)
// IL
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

