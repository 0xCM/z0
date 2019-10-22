// 2019-10-21 17:21:44:766
float inxs_add_32f(float x, float y)
{
    IL_0000: ldarga.s x
    IL_0002: call System.Single* Z0.As::constptr(System.Single&)
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Sse::LoadScalarVector128(System.Single*)
    IL_000C: ldarga.s y
    IL_000E: call System.Single* Z0.As::constptr(System.Single&)
    IL_0013: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Sse::LoadScalarVector128(System.Single*)
    IL_0018: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Sse::AddScalar(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_001D: ldc.i4.0
    IL_001E: call System.Single System.Runtime.Intrinsics.Vector128::GetElement<System.Single>(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Int32)
    IL_0023: ret

}
double inxs_add64f(double x, double y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call System.Double Z0.inxs::add(System.Double&,System.Double&)
    IL_0009: ret

}
float inxs_sub32f(float x, float y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Single Z0.inxs::sub(System.Single,System.Single)
    IL_0007: ret

}
double inxs_sub64f(double x, double y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Double Z0.inxs::sub(System.Double,System.Double)
    IL_0007: ret

}
float inxs_mul32f(float x, float y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Single Z0.inxs::mul(System.Single,System.Single)
    IL_0007: ret

}
double inxs_mul64f(double x, double y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Double Z0.inxs::mul(System.Double,System.Double)
    IL_0007: ret

}
float inxs_div32f(float x, float y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Single Z0.inxs::div(System.Single,System.Single)
    IL_0007: ret

}
double inxs_div64f(double x, double y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Double Z0.inxs::div(System.Double,System.Double)
    IL_0007: ret

}
float inxs_max32f(float x, float y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Single Z0.inxs::max(System.Single,System.Single)
    IL_0007: ret

}
double inxs_max64f(double x, double y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Double Z0.inxs::max(System.Double,System.Double)
    IL_0007: ret

}
float inxs_min32f(float x, float y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Single Z0.inxs::min(System.Single,System.Single)
    IL_0007: ret

}
double inxs_min64f(double x, double y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Double Z0.inxs::min(System.Double,System.Double)
    IL_0007: ret

}
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
