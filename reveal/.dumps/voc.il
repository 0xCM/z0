// 2019-09-29 06:23:34:054
Vector128<sbyte> vadd_n128x8i(Vector128<sbyte> lhs, Vector128<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::Add(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0007: ret

}
Vec128<sbyte> vadd_d128x8i(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.SByte> Z0.dinx::vadd(Z0.Vec128`1<System.SByte>&,Z0.Vec128`1<System.SByte>&)
    IL_0007: ret

}
Vec128<sbyte> vadd_g128x8i(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.SByte> Z0.ginx::vadd<System.SByte>(Z0.Vec128`1<System.SByte>&,Z0.Vec128`1<System.SByte>&)
    IL_0007: ret

}
Vector128<byte> vadd_n128x8u(Vector128<byte> lhs, Vector128<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::Add(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0007: ret

}
Vec128<byte> vadd_d128x8u(in Vec128<byte> lhs, in Vec128<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.Byte> Z0.dinx::vadd(Z0.Vec128`1<System.Byte>&,Z0.Vec128`1<System.Byte>&)
    IL_0007: ret

}
Vec128<byte> vadd_g128x8u(in Vec128<byte> lhs, in Vec128<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.Byte> Z0.ginx::vadd<System.Byte>(Z0.Vec128`1<System.Byte>&,Z0.Vec128`1<System.Byte>&)
    IL_0007: ret

}
Vector128<short> vadd_n128x16i(Vector128<short> lhs, Vector128<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::Add(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0007: ret

}
Vec128<short> vadd_d128x16i(in Vec128<short> lhs, in Vec128<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.Int16> Z0.dinx::vadd(Z0.Vec128`1<System.Int16>&,Z0.Vec128`1<System.Int16>&)
    IL_0007: ret

}
Vec128<short> vadd_g128x16i(in Vec128<short> lhs, in Vec128<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.Int16> Z0.ginx::vadd<System.Int16>(Z0.Vec128`1<System.Int16>&,Z0.Vec128`1<System.Int16>&)
    IL_0007: ret

}
Vector128<ushort> vadd_n128x16u(Vector128<ushort> lhs, Vector128<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::Add(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0007: ret

}
Vec128<ushort> vadd_d128x16u(in Vec128<ushort> lhs, in Vec128<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.UInt16> Z0.dinx::vadd(Z0.Vec128`1<System.UInt16>&,Z0.Vec128`1<System.UInt16>&)
    IL_0007: ret

}
Vec128<ushort> vadd_g128x16u(in Vec128<ushort> lhs, in Vec128<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.UInt16> Z0.ginx::vadd<System.UInt16>(Z0.Vec128`1<System.UInt16>&,Z0.Vec128`1<System.UInt16>&)
    IL_0007: ret

}
Vector128<int> vadd_n128x32i(Vector128<int> lhs, Vector128<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::Add(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0007: ret

}
Vec128<int> vadd_d128x32i(in Vec128<int> lhs, in Vec128<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.Int32> Z0.dinx::vadd(Z0.Vec128`1<System.Int32>&,Z0.Vec128`1<System.Int32>&)
    IL_0007: ret

}
Vec128<int> vadd_g128x32i(in Vec128<int> lhs, in Vec128<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.Int32> Z0.ginx::vadd<System.Int32>(Z0.Vec128`1<System.Int32>&,Z0.Vec128`1<System.Int32>&)
    IL_0007: ret

}
Vector128<uint> vadd_n128x32u(Vector128<uint> lhs, Vector128<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::Add(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0007: ret

}
Vec128<uint> vadd_d128x32u(in Vec128<uint> lhs, in Vec128<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.UInt32> Z0.dinx::vadd(Z0.Vec128`1<System.UInt32>&,Z0.Vec128`1<System.UInt32>&)
    IL_0007: ret

}
Vec128<uint> vadd_g128x32u(in Vec128<uint> lhs, in Vec128<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.UInt32> Z0.ginx::vadd<System.UInt32>(Z0.Vec128`1<System.UInt32>&,Z0.Vec128`1<System.UInt32>&)
    IL_0007: ret

}
Vector128<long> vadd_n128x64i(Vector128<long> lhs, Vector128<long> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse2::Add(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0007: ret

}
Vec128<long> vadd_d128x64i(in Vec128<long> lhs, in Vec128<long> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.Int64> Z0.dinx::vadd(Z0.Vec128`1<System.Int64>&,Z0.Vec128`1<System.Int64>&)
    IL_0007: ret

}
Vec128<long> vadd_g128x64i(in Vec128<long> lhs, in Vec128<long> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.Int64> Z0.ginx::vadd<System.Int64>(Z0.Vec128`1<System.Int64>&,Z0.Vec128`1<System.Int64>&)
    IL_0007: ret

}
Vector128<ulong> vadd_n128x64u(Vector128<ulong> lhs, Vector128<ulong> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::Add(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0007: ret

}
Vec128<ulong> vadd_d128x64u(in Vec128<ulong> lhs, in Vec128<ulong> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.UInt64> Z0.dinx::vadd(Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&)
    IL_0007: ret

}
Vec128<ulong> vadd_g128x64u(in Vec128<ulong> lhs, in Vec128<ulong> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.UInt64> Z0.ginx::vadd<System.UInt64>(Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&)
    IL_0007: ret

}
Vector128<float> vadd_n128x32f(Vector128<float> lhs, Vector128<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Sse::Add(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0007: ret

}
Vec128<float> vadd_d128x32f(in Vec128<float> lhs, in Vec128<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: call Z0.Vec128`1<System.Single> Z0.dfp::vadd(Z0.Vec128`1<System.Single>&,Z0.Vec128`1<System.Single>&)
    IL_0007: ret

}
Vec128<float> vadd_g128x32f(in Vec128<float> lhs, in Vec128<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: call Z0.Vec128`1<System.Single> Z0.ginx::vadd<System.Single>(Z0.Vec128`1<System.Single>&,Z0.Vec128`1<System.Single>&)
    IL_0007: ret

}
Vector128<double> vadd_n128x64f(Vector128<double> lhs, Vector128<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Double> System.Runtime.Intrinsics.X86.Sse2::Add(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0007: ret

}
Vec128<double> vadd_d128x64f(in Vec128<double> lhs, in Vec128<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: call Z0.Vec128`1<System.Double> Z0.dfp::vadd(Z0.Vec128`1<System.Double>&,Z0.Vec128`1<System.Double>&)
    IL_0007: ret

}
Vec128<double> vadd_g128x64f(in Vec128<double> lhs, in Vec128<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: call Z0.Vec128`1<System.Double> Z0.ginx::vadd<System.Double>(Z0.Vec128`1<System.Double>&,Z0.Vec128`1<System.Double>&)
    IL_0007: ret

}
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
