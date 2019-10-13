// 2019-10-13 04:28:18:247
Vec128<ulong> xor1_v128x64u(Vec128<ulong> a)
{
    IL_0000: ldarga.s a
    IL_0002: call Z0.Vec128`1<System.UInt64> Z0.CpuLogic::xor1<System.UInt64>(Z0.Vec128`1<System.UInt64>&)
    IL_0007: ret

}
Vec128<ulong> select_v128x64u(Vec128<ulong> a, Vec128<ulong> b, Vec128<ulong> c)
{
    IL_0000: ldarga.s a
    IL_0002: ldarga.s b
    IL_0004: ldarga.s c
    IL_0006: call Z0.Vec128`1<System.UInt64> Z0.CpuLogic::select<System.UInt64>(Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&)
    IL_000B: ret

}
Vec128<ulong> f01_64u(Vec128<ulong> a, Vec128<ulong> b, Vec128<ulong> c)
{
    IL_0000: ldarga.s a
    IL_0002: ldarga.s b
    IL_0004: ldarga.s c
    IL_0006: call Z0.Vec128`1<System.UInt64> Z0.CpuLogic::f01<System.UInt64>(Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&)
    IL_000B: ret

}
Vec128<ulong> f02_64u(Vec128<ulong> a, Vec128<ulong> b, Vec128<ulong> c)
{
    IL_0000: ldarga.s a
    IL_0002: ldarga.s b
    IL_0004: ldarga.s c
    IL_0006: call Z0.Vec128`1<System.UInt64> Z0.CpuLogic::f02<System.UInt64>(Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&)
    IL_000B: ret

}
Vec128<ulong> f03_64u(Vec128<ulong> a, Vec128<ulong> b, Vec128<ulong> c)
{
    IL_0000: ldarga.s a
    IL_0002: ldarga.s b
    IL_0004: ldarga.s c
    IL_0006: call Z0.Vec128`1<System.UInt64> Z0.CpuLogic::f03<System.UInt64>(Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&)
    IL_000B: ret

}
ulong and_64u(ulong a, ulong b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.ScalarLogic::and<System.UInt64>(System.UInt64,System.UInt64)
    IL_0007: ret

}
ulong or_64u(ulong a, ulong b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.ScalarLogic::or<System.UInt64>(System.UInt64,System.UInt64)
    IL_0007: ret

}
ulong xor_64u(ulong a, ulong b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.ScalarLogic::xor<System.UInt64>(System.UInt64,System.UInt64)
    IL_0007: ret

}
ulong not_64u(ulong a)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt64 Z0.ScalarLogic::not<System.UInt64>(System.UInt64)
    IL_0006: ret

}
ulong nand_64u(ulong a, ulong b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.ScalarLogic::nand<System.UInt64>(System.UInt64,System.UInt64)
    IL_0007: ret

}
ulong nor_64u(ulong a, ulong b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.ScalarLogic::nor<System.UInt64>(System.UInt64,System.UInt64)
    IL_0007: ret

}
ulong xnor_64u(ulong a, ulong b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.ScalarLogic::xnor<System.UInt64>(System.UInt64,System.UInt64)
    IL_0007: ret

}
ulong xor1_64u(ulong a)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt64 Z0.ScalarLogic::xor1<System.UInt64>(System.UInt64)
    IL_0006: ret

}
ulong select_64u(ulong a, ulong b, ulong c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.UInt64 Z0.ScalarLogic::select<System.UInt64>(System.UInt64,System.UInt64,System.UInt64)
    IL_0008: ret

}
ulong f01_64u(ulong a, ulong b, ulong c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.UInt64 Z0.ScalarLogic::f01<System.UInt64>(System.UInt64,System.UInt64,System.UInt64)
    IL_0008: ret

}
ulong f02_64u(ulong a, ulong b, ulong c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.UInt64 Z0.ScalarLogic::f02<System.UInt64>(System.UInt64,System.UInt64,System.UInt64)
    IL_0008: ret

}
ulong f03_64u(ulong a, ulong b, ulong c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.UInt64 Z0.ScalarLogic::f03<System.UInt64>(System.UInt64,System.UInt64,System.UInt64)
    IL_0008: ret

}
ulong f04_64u(ulong a, ulong b, ulong c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.UInt64 Z0.ScalarLogic::f04<System.UInt64>(System.UInt64,System.UInt64,System.UInt64)
    IL_0008: ret

}
ulong f05_64u(ulong a, ulong b, ulong c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.UInt64 Z0.ScalarLogic::f05<System.UInt64>(System.UInt64,System.UInt64,System.UInt64)
    IL_0008: ret

}
ulong f06_64u(ulong a, ulong b, ulong c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.UInt64 Z0.ScalarLogic::f06<System.UInt64>(System.UInt64,System.UInt64,System.UInt64)
    IL_0008: ret

}
ulong f07_64u(ulong a, ulong b, ulong c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.UInt64 Z0.ScalarLogic::f07<System.UInt64>(System.UInt64,System.UInt64,System.UInt64)
    IL_0008: ret

}
ulong f08_64u(ulong a, ulong b, ulong c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.UInt64 Z0.ScalarLogic::f08<System.UInt64>(System.UInt64,System.UInt64,System.UInt64)
    IL_0008: ret

}
ulong f09_64u(ulong a, ulong b, ulong c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.UInt64 Z0.ScalarLogic::f09<System.UInt64>(System.UInt64,System.UInt64,System.UInt64)
    IL_0008: ret

}
ulong f0a_64u(ulong a, ulong b, ulong c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.UInt64 Z0.ScalarLogic::f0a<System.UInt64>(System.UInt64,System.UInt64,System.UInt64)
    IL_0008: ret

}
ulong f0b_64u(ulong a, ulong b, ulong c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.UInt64 Z0.ScalarLogic::f0b<System.UInt64>(System.UInt64,System.UInt64,System.UInt64)
    IL_0008: ret

}
ulong f0c_64u(ulong a, ulong b, ulong c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.UInt64 Z0.ScalarLogic::f0c<System.UInt64>(System.UInt64,System.UInt64,System.UInt64)
    IL_0008: ret

}
ulong f0d_64u(ulong a, ulong b, ulong c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.UInt64 Z0.ScalarLogic::f0d<System.UInt64>(System.UInt64,System.UInt64,System.UInt64)
    IL_0008: ret

}
ulong f0e_64u(ulong a, ulong b, ulong c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.UInt64 Z0.ScalarLogic::f0e<System.UInt64>(System.UInt64,System.UInt64,System.UInt64)
    IL_0008: ret

}
ulong f0f_64u(ulong a, ulong b, ulong c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.UInt64 Z0.ScalarLogic::f0f<System.UInt64>(System.UInt64,System.UInt64,System.UInt64)
    IL_0008: ret

}
ulong f10_64u(ulong a, ulong b, ulong c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.UInt64 Z0.ScalarLogic::f10<System.UInt64>(System.UInt64,System.UInt64,System.UInt64)
    IL_0008: ret

}
ulong f11_64u(ulong a, ulong b, ulong c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.UInt64 Z0.ScalarLogic::f11<System.UInt64>(System.UInt64,System.UInt64,System.UInt64)
    IL_0008: ret

}
ulong f12_64u(ulong a, ulong b, ulong c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.UInt64 Z0.ScalarLogic::f12<System.UInt64>(System.UInt64,System.UInt64,System.UInt64)
    IL_0008: ret

}
ulong f13_64u(ulong a, ulong b, ulong c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.UInt64 Z0.ScalarLogic::f13<System.UInt64>(System.UInt64,System.UInt64,System.UInt64)
    IL_0008: ret

}
ulong f14_64u(ulong a, ulong b, ulong c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.UInt64 Z0.ScalarLogic::f14<System.UInt64>(System.UInt64,System.UInt64,System.UInt64)
    IL_0008: ret

}
ulong f15_64u(ulong a, ulong b, ulong c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.UInt64 Z0.ScalarLogic::f15<System.UInt64>(System.UInt64,System.UInt64,System.UInt64)
    IL_0008: ret

}
ulong f16_64u(ulong a, ulong b, ulong c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.UInt64 Z0.ScalarLogic::f16<System.UInt64>(System.UInt64,System.UInt64,System.UInt64)
    IL_0008: ret

}
ulong f17_64u(ulong a, ulong b, ulong c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.UInt64 Z0.ScalarLogic::f17<System.UInt64>(System.UInt64,System.UInt64,System.UInt64)
    IL_0008: ret

}
ulong f18_64u(ulong a, ulong b, ulong c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.UInt64 Z0.ScalarLogic::f18<System.UInt64>(System.UInt64,System.UInt64,System.UInt64)
    IL_0008: ret

}
ulong f19_64u(ulong a, ulong b, ulong c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.UInt64 Z0.ScalarLogic::f19<System.UInt64>(System.UInt64,System.UInt64,System.UInt64)
    IL_0008: ret

}
ulong f1a_64u(ulong a, ulong b, ulong c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.UInt64 Z0.ScalarLogic::f1a<System.UInt64>(System.UInt64,System.UInt64,System.UInt64)
    IL_0008: ret

}
ulong f1b_64u(ulong a, ulong b, ulong c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.UInt64 Z0.ScalarLogic::f1b<System.UInt64>(System.UInt64,System.UInt64,System.UInt64)
    IL_0008: ret

}
ulong f97_64u(ulong a, ulong b, ulong c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.UInt64 Z0.ScalarLogic::f97<System.UInt64>(System.UInt64,System.UInt64,System.UInt64)
    IL_0008: ret

}
