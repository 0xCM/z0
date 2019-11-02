// 2019-11-02 09:11:43:964
UInt128 clmul(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.UInt128 Z0.Cl::clmul(System.UInt64,System.UInt64)
    IL_0007: ret

}
ref UInt128 clmul(ulong x, ulong y, ref UInt128 dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call Z0.UInt128& Z0.Cl::clmul(System.UInt64,System.UInt64,Z0.UInt128&)
    IL_0008: ret

}
ulong clmulr8u(ulong a, ulong b, ulong poly)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.UInt64 Z0.Cl::clmulr8u(System.UInt64,System.UInt64,System.UInt64)
    IL_0008: ret

}
