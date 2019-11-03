// 2019-11-03 08:18:55:259
void avxpack(ref uint src, ref uint dst)
{
    IL_0000: call Z0.N1 zfunc::get_n1()
    IL_0005: ldarg.0
    IL_0006: ldarg.1
    IL_0007: call System.Void Z0.AvxBitpack::pack(Z0.N1,System.UInt32&,System.UInt32&)
    IL_000C: ret

}
ulong sum_256x64u(Vector256<ulong> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt64 Z0.dinx::vsum(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0006: ret

}
ulong sum_256x64u(Vector128<ulong> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt64 Z0.dinx::vsum(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0006: ret

}
Vector256<ulong> avxpop(Vector256<ulong> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.AvxPops::genpop<System.UInt64>(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0006: ret

}
ulong avxpop_csa(in ulong src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt64 Z0.AvxPops::popcsa_1(System.UInt64&)
    IL_0006: ret

}
ulong pop64_scalar(ulong a, ulong b, ulong c, ulong d)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: ldarg.3
    IL_0004: call System.UInt64 Z0.AvxPops::pop64(System.UInt64,System.UInt64,System.UInt64,System.UInt64)
    IL_0009: ret

}
ulong pop64_vector(Vector256<ulong> x)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt64 Z0.AvxPops::pop64<System.UInt64>(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0006: ret

}
void vcsa_256x64u(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c, out Vector256<ulong> lo, out Vector256<ulong> hi)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: ldarg.3
    IL_0004: ldarg.s hi
    IL_0006: call System.Void Z0.AvxPops::vcsa<System.UInt64>(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>&,System.Runtime.Intrinsics.Vector256`1<System.UInt64>&)
    IL_000B: ret

}
void csa_64u(ulong a, ulong b, ulong c, out ulong lo, out ulong hi)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: ldarg.3
    IL_0004: ldarg.s hi
    IL_0006: call System.Void Z0.AvxPops::csa<System.UInt64>(System.UInt64,System.UInt64,System.UInt64,System.UInt64&,System.UInt64&)
    IL_000B: ret

}
void vtranspose(ref Vector128<uint> row0, ref Vector128<uint> row1, ref Vector128<uint> row2, ref Vector128<uint> row3)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: ldarg.3
    IL_0004: call System.Void Z0.dinx::vtranspose(System.Runtime.Intrinsics.Vector128`1<System.UInt32>&,System.Runtime.Intrinsics.Vector128`1<System.UInt32>&,System.Runtime.Intrinsics.Vector128`1<System.UInt32>&,System.Runtime.Intrinsics.Vector128`1<System.UInt32>&)
    IL_0009: ret

}
void vtranspose(ref Vector128<float> row0, ref Vector128<float> row1, ref Vector128<float> row2, ref Vector128<float> row3)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: ldarg.3
    IL_0004: call System.Void Z0.dinx::vtranspose(System.Runtime.Intrinsics.Vector128`1<System.Single>&,System.Runtime.Intrinsics.Vector128`1<System.Single>&,System.Runtime.Intrinsics.Vector128`1<System.Single>&,System.Runtime.Intrinsics.Vector128`1<System.Single>&)
    IL_0009: ret

}
