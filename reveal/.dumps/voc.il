// 2019-10-01 04:44:12:421
Vector128<float> vadd_scalar128_n32f(Vector128<float> x, Vector128<float> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Sse::AddScalar(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0007: ret

}
Scalar128<float> vadd_scalar128_d32f(in Scalar128<float> x, in Scalar128<float> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.inxs::add(Z0.Scalar128`1<System.Single>&,Z0.Scalar128`1<System.Single>&)
    IL_0007: call Z0.Scalar128`1<System.Single> Z0.Scalar128`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_000C: ret

}
Scalar128<float> vadd_scalar128_g32f(in Scalar128<float> x, in Scalar128<float> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.ginxs::add<System.Single>(Z0.Scalar128`1<System.Single>&,Z0.Scalar128`1<System.Single>&)
    IL_0007: call Z0.Scalar128`1<System.Single> Z0.Scalar128`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_000C: ret

}
Vector128<float> load_scalar128_n32f(float src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Single& Z0.As::asRef<System.Single>(System.Single&)
    IL_0007: call System.Single* Z0.As::refptr(System.Single&)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Sse::LoadScalarVector128(System.Single*)
    IL_0011: ret

}
Scalar128<float> load_scalar128_d32f(float src)
{
    IL_0000: ldarga.s src
    IL_0002: call Z0.Scalar128`1<System.Single> Z0.inxs::load(System.Single&)
    IL_0007: ret

}
Scalar128<float> load_scalar128_g32f(float src)
{
    IL_0000: ldarga.s src
    IL_0002: call Z0.Scalar128`1<System.Single> Z0.ginxs::load<System.Single>(System.Single&)
    IL_0007: ret

}
Vector128<double> load_scalar128_n64f(double src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Double& Z0.As::asRef<System.Double>(System.Double&)
    IL_0007: call System.Double* Z0.As::refptr(System.Double&)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Double> System.Runtime.Intrinsics.X86.Sse2::LoadScalarVector128(System.Double*)
    IL_0011: ret

}
Scalar128<double> load_scalar128_d64f(double src)
{
    IL_0000: ldarga.s src
    IL_0002: call Z0.Scalar128`1<System.Double> Z0.inxs::load(System.Double&)
    IL_0007: ret

}
Scalar128<double> load_scalar128_g64f(double src)
{
    IL_0000: ldarga.s src
    IL_0002: call Z0.Scalar128`1<System.Double> Z0.ginxs::load<System.Double>(System.Double&)
    IL_0007: ret

}
float to32f(int src)
{
    IL_0000: ldloca.s V_0
    IL_0002: initobj System.Runtime.Intrinsics.Vector128`1<System.Single>
    IL_0008: ldloc.0
    IL_0009: ldarg.0
    IL_000A: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Sse::ConvertScalarToVector128Single(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Int32)
    IL_000F: ldc.i4.0
    IL_0010: call System.Single System.Runtime.Intrinsics.Vector128::GetElement<System.Single>(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Int32)
    IL_0015: ret

}
int to32i(float src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Single* Z0.As::refptr(System.Single&)
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Sse::LoadScalarVector128(System.Single*)
    IL_000C: call System.Int32 System.Runtime.Intrinsics.X86.Sse::ConvertToInt32WithTruncation(System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0011: ret

}
int to32i(double src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Double* Z0.As::refptr(System.Double&)
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Double> System.Runtime.Intrinsics.X86.Sse2::LoadScalarVector128(System.Double*)
    IL_000C: call System.Int32 System.Runtime.Intrinsics.X86.Sse2::ConvertToInt32WithTruncation(System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0011: ret

}
float to32f(long src)
{
    IL_0000: ldloca.s V_0
    IL_0002: initobj System.Runtime.Intrinsics.Vector128`1<System.Single>
    IL_0008: ldloc.0
    IL_0009: ldarg.0
    IL_000A: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Sse/X64::ConvertScalarToVector128Single(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Int64)
    IL_000F: ldc.i4.0
    IL_0010: call System.Single System.Runtime.Intrinsics.Vector128::GetElement<System.Single>(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Int32)
    IL_0015: ret

}
long to64i(float src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Single* Z0.As::refptr(System.Single&)
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Sse::LoadScalarVector128(System.Single*)
    IL_000C: call System.Int64 System.Runtime.Intrinsics.X86.Sse/X64::ConvertToInt64WithTruncation(System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0011: ret

}
