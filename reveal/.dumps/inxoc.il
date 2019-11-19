// 2019-11-18 23:19:05:617
bool vtestz_g128x64i(Vector128<long> src, Vector128<long> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.ginx::vtestz<System.Int64>(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret

}
bool vtestz_d128x64u(Vector128<ulong> src, Vector128<ulong> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.dinx::vtestz(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret

}
bool vtestz_g128x64u(Vector128<ulong> src, Vector128<ulong> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.ginx::vtestz<System.UInt64>(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret

}
bool vtestz_d256x8i(Vector256<sbyte> src, Vector256<sbyte> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.dinx::vtestz(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret

}
bool vtestz_g256x8i(Vector256<sbyte> src, Vector256<sbyte> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.ginx::vtestz<System.SByte>(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret

}
bool vtestz_d256x8u(Vector256<byte> src, Vector256<byte> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.dinx::vtestz(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret

}
bool vtestz_g256x8u(Vector256<byte> src, Vector256<byte> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.ginx::vtestz<System.Byte>(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret

}
bool vtestz_d256x16i(Vector256<short> src, Vector256<short> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.dinx::vtestz(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret

}
bool vtestz_g256x16i(Vector256<short> src, Vector256<short> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.ginx::vtestz<System.Int16>(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret

}
bool vtestz_d256x16u(Vector256<ushort> src, Vector256<ushort> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.dinx::vtestz(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret

}
bool vtestz_g256x16u(Vector256<ushort> src, Vector256<ushort> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.ginx::vtestz<System.UInt16>(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret

}
bool vtestz_d256x32i(Vector256<int> src, Vector256<int> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.dinx::vtestz(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret

}
bool vtestz_g256x32i(Vector256<int> src, Vector256<int> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.ginx::vtestz<System.Int32>(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret

}
bool vtestz_d256x32u(Vector256<uint> src, Vector256<uint> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.dinx::vtestz(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret

}
bool vtestz_g256x32u(Vector256<uint> src, Vector256<uint> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.ginx::vtestz<System.UInt32>(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret

}
bool vtestz_d256x64i(Vector256<long> src, Vector256<long> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.dinx::vtestz(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret

}
bool vtestz_g256x64i(Vector256<long> src, Vector256<long> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.ginx::vtestz<System.Int64>(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret

}
bool vtestz_d256x64u(Vector256<ulong> src, Vector256<ulong> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.dinx::vtestz(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret

}
bool vtestz_g256x64u(Vector256<ulong> src, Vector256<ulong> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.ginx::vtestz<System.UInt64>(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret

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
Vector128<sbyte> vadd_d128x8i(Vector128<sbyte> lhs, Vector128<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.dinx::vadd(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0007: ret

}
Vector128<sbyte> vadd_g128x8i(Vector128<sbyte> lhs, Vector128<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.ginx::vadd<System.SByte>(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0007: ret

}
Vector128<byte> vadd_g128x8u(Vector128<byte> lhs, Vector128<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.ginx::vadd<System.Byte>(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0007: ret

}
Vector128<short> vadd_g128x16i(Vector128<short> lhs, Vector128<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.ginx::vadd<System.Int16>(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0007: ret

}
Vector128<ushort> vadd_g128x16u(Vector128<ushort> lhs, Vector128<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.ginx::vadd<System.UInt16>(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0007: ret

}
Vector128<int> vadd_g128x32i(Vector128<int> lhs, Vector128<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.ginx::vadd<System.Int32>(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0007: ret

}
Vector128<uint> vadd_g128x32u(Vector128<uint> lhs, Vector128<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.ginx::vadd<System.UInt32>(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0007: ret

}
Vector128<long> vadd_g128x64i(Vector128<long> lhs, Vector128<long> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.ginx::vadd<System.Int64>(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0007: ret

}
Vector128<ulong> vadd_g128x64u(Vector128<ulong> lhs, Vector128<ulong> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.ginx::vadd<System.UInt64>(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0007: ret

}
Vector128<float> vadd_g128x32f(Vector128<float> lhs, Vector128<float> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.ginx::vadd<System.Single>(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0007: ret

}
Vector128<double> vadd_g128x64f(Vector128<double> lhs, Vector128<double> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.ginx::vadd<System.Double>(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0007: ret

}
Vector128<ulong> vreverse_128x64u(Vector128<ulong> x)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.dinx::vreverse(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0006: ret

}
Vector128<byte> vreverse_128x8u(Vector128<byte> x)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.dinx::vreverse(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0006: ret

}
Vector256<byte> vreverse_256x8u(Vector256<byte> x)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.dinx::vreverse(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0006: ret

}
Vector128<byte> vrotlx_n8(Vector128<byte> x)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.N8 zfunc::get_n8()
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.dinx::vrotlx(System.Runtime.Intrinsics.Vector128`1<System.Byte>,Z0.N8)
    IL_000B: ret

}
Vector128<ulong> vrotlx_8(Vector128<ulong> x)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.dinx::vrotlx(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Byte)
    IL_0007: ret

}
Vector128<short> vblend_128x16u_LLLLLLLL(Vector128<short> x, Vector128<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.0
    IL_0003: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.dinx::vblend8x16(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>,Z0.Blend8x16)
    IL_0008: ret

}
Vector128<short> vblend_128x16u_RRRRRRRR(Vector128<short> x, Vector128<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4 255
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.dinx::vblend8x16(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>,Z0.Blend8x16)
    IL_000C: ret

}
Vector128<short> vblend_128x16u_LLLLRRRR(Vector128<short> x, Vector128<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4 240
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.dinx::vblend8x16(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>,Z0.Blend8x16)
    IL_000C: ret

}
Vector128<short> vblend_128x16u_RRRRLLLL(Vector128<short> x, Vector128<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 15
    IL_0004: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.dinx::vblend8x16(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>,Z0.Blend8x16)
    IL_0009: ret

}
Vector128<short> vblend_128x16u_LRLRLRLR(Vector128<short> x, Vector128<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4 170
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.dinx::vblend8x16(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>,Z0.Blend8x16)
    IL_000C: ret

}
Vector128<short> vblend_128x16u_RLRLRLRL(Vector128<short> x, Vector128<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 85
    IL_0004: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.dinx::vblend8x16(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>,Z0.Blend8x16)
    IL_0009: ret

}
Vector128<int> vcmplt_128x32i(Vector128<int> x, Vector128<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.dinx::vlt(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0007: ret

}
Vector128<int> vcmplt_g128x32i(Vector128<int> x, Vector128<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.ginx::vlt<System.Int32>(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0007: ret

}
Vector128<uint> vcmplt_128x32u(Vector128<uint> x, Vector128<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.dinx::vlt(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0007: ret

}
Vector128<uint> vcmplt_g128x32u(Vector128<uint> x, Vector128<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.ginx::vlt<System.UInt32>(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0007: ret

}
Vector128<long> vcmplt_128x64i(Vector128<long> x, Vector128<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.dinx::vlt(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0007: ret

}
Vector128<long> vcmplt_g128x64i(Vector128<long> x, Vector128<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.ginx::vlt<System.Int64>(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0007: ret

}
Vector128<ulong> vcmplt_128x64u(Vector128<ulong> x, Vector128<ulong> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.dinx::vlt(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0007: ret

}
Vector128<ulong> vcmplt_g128x64u(Vector128<ulong> x, Vector128<ulong> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.ginx::vlt<System.UInt64>(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0007: ret

}
Vector256<byte> vcmplt_256x8u(Vector256<byte> x, Vector256<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.dinx::vlt(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0007: ret

}
Vector256<byte> vcmplt_g256x8u(Vector256<byte> x, Vector256<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.ginx::vlt<System.Byte>(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0007: ret

}
Vector256<long> vcmplt_256x64i(Vector256<long> x, Vector256<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.dinx::vlt(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0007: ret

}
Vector256<long> vcmplt_g256x64i(Vector256<long> x, Vector256<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.ginx::vlt<System.Int64>(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0007: ret

}
Vector256<ulong> vcmplt_256x64u(Vector256<ulong> x, Vector256<ulong> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::vlt(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0007: ret

}
Vector256<ulong> vcmplt_g256x64u(Vector256<ulong> x, Vector256<ulong> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.ginx::vlt<System.UInt64>(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0007: ret

}
Vector256<byte> valignr256x4n(Vector256<byte> x, Vector256<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.N4 zfunc::get_n4()
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.dinx::valignr<Z0.N4>(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>,Z0.N4)
    IL_000C: ret

}
Vector256<byte> valignr256x4(Vector256<byte> x, Vector256<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.4
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.dinx::valignr(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>,Z0.VAlignR)
    IL_0008: ret

}
Vector128<byte> valignr128x4n(Vector128<byte> x, Vector128<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.N4 zfunc::get_n4()
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.dinx::valignr<Z0.N4>(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>,Z0.N4)
    IL_000C: ret

}
Vector128<byte> valignr128x4(Vector128<byte> x, Vector128<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.4
    IL_0003: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.dinx::valignr(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>,Z0.VAlignR)
    IL_0008: ret

}
Vector128<byte> packus(Vector128<ushort> x, Vector128<ushort> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.dinx::vpackus(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0007: ret

}
Vector256<byte> packus(Vector256<ushort> x, Vector256<ushort> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.dinx::vpackus(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0007: ret

}
uint item_get_128x32u_1(Vector128<uint> x)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0002: call System.UInt32 Z0.CpuVec128::item<System.UInt32>(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Int32)
    IL_0007: ret

}
uint item_get_128x32u_2(Vector128<uint> x)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.2
    IL_0002: call System.UInt32 Z0.CpuVec128::item<System.UInt32>(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Int32)
    IL_0007: ret

}
Vector128<uint> item_set_128x32u_2(Vector128<uint> x, uint value)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.2
    IL_0002: ldarg.1
    IL_0003: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.CpuVec128::item<System.UInt32>(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Int32,System.UInt32)
    IL_0008: ret

}
Vector256<uint> avxpack1(Span<N8,uint> src, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.AvxBitpack::pack(Z0.Span`2<Z0.N8,System.UInt32>,System.Int32)
    IL_0007: ret

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
Vector128<byte> swap_hl(Vector128<byte> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.ginx::vswaphl<System.Byte>(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0006: ret

}
Vector128<ulong> hi_128x64u(Vector128<ulong> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.ginx::vhi<System.UInt64>(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0006: ret

}
Vector128<byte> hi_128x8u(Vector128<byte> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.ginx::vhi<System.Byte>(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0006: ret

}
Vector128<ulong> lo_128x64u(Vector128<ulong> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.ginx::vlo<System.UInt64>(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0006: ret

}
Vector128<byte> lo_128x8u(Vector128<byte> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.ginx::vlo<System.Byte>(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0006: ret

}
byte vextract_128x8u_0(Vector128<byte> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.N0 zfunc::get_n0()
    IL_0006: call System.Byte Z0.ginx::vxscalar<System.Byte>(System.Runtime.Intrinsics.Vector128`1<System.Byte>,Z0.N0)
    IL_000B: ret

}
ulong vextract_128x64u_0(Vector128<ulong> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.N0 zfunc::get_n0()
    IL_0006: call System.UInt64 Z0.ginx::vxscalar<System.UInt64>(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,Z0.N0)
    IL_000B: ret

}
ulong vextract_128x64u_1(Vector128<ulong> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.N1 zfunc::get_n1()
    IL_0006: call System.UInt64 Z0.ginx::vxscalar<System.UInt64>(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,Z0.N1)
    IL_000B: ret

}
void vextract_128x64u_all(Vector128<ulong> src, out ulong x0, out ulong x1)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call Z0.N0 zfunc::get_n0()
    IL_0007: call System.UInt64 Z0.ginx::vxscalar<System.UInt64>(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,Z0.N0)
    IL_000C: stind.i8
    IL_000D: ldarg.2
    IL_000E: ldarg.0
    IL_000F: call Z0.N1 zfunc::get_n1()
    IL_0014: call System.UInt64 Z0.ginx::vxscalar<System.UInt64>(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,Z0.N1)
    IL_0019: stind.i8
    IL_001A: ret

}
void vextract_128x64u_all_2(Vector128<ulong> src, ref ulong dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call Z0.N0 zfunc::get_n0()
    IL_0007: call System.UInt64 Z0.ginx::vxscalar<System.UInt64>(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,Z0.N0)
    IL_000C: stind.i8
    IL_000D: ldarg.1
    IL_000E: ldc.i4.1
    IL_000F: call System.UInt64& System.Runtime.CompilerServices.Unsafe::Add<System.UInt64>(System.UInt64&,System.Int32)
    IL_0014: ldarg.0
    IL_0015: call Z0.N1 zfunc::get_n1()
    IL_001A: call System.UInt64 Z0.ginx::vxscalar<System.UInt64>(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,Z0.N1)
    IL_001F: stind.i8
    IL_0020: ret

}
void vextract_128x64u_all_3(Vector128<ulong> src, out ulong x0, out ulong x1)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldc.i4.0
    IL_0003: call System.UInt64 Z0.ginx::vxscalar<System.UInt64>(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Byte)
    IL_0008: stind.i8
    IL_0009: ldarg.2
    IL_000A: ldarg.0
    IL_000B: ldc.i4.1
    IL_000C: call System.UInt64 Z0.ginx::vxscalar<System.UInt64>(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Byte)
    IL_0011: stind.i8
    IL_0012: ret

}
void vextract_128x64u_all_4(Vector128<ulong> src, ref ulong dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Void Z0.ginx::vstore<System.UInt64>(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.UInt64&)
    IL_0007: ret

}
byte vextract_256x8u_0(Vector256<byte> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.N0 zfunc::get_n0()
    IL_0006: call System.Byte Z0.ginx::vxscalar<System.Byte>(System.Runtime.Intrinsics.Vector256`1<System.Byte>,Z0.N0)
    IL_000B: ret

}
byte vextract_256x8u_1(Vector256<byte> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.N1 zfunc::get_n1()
    IL_0006: call System.Byte Z0.ginx::vxscalar<System.Byte>(System.Runtime.Intrinsics.Vector256`1<System.Byte>,Z0.N1)
    IL_000B: ret

}
byte vextract_256x8u_2(Vector256<byte> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.N2 zfunc::get_n2()
    IL_0006: call System.Byte Z0.ginx::vxscalar<System.Byte>(System.Runtime.Intrinsics.Vector256`1<System.Byte>,Z0.N2)
    IL_000B: ret

}
uint vextract_256x32u_0(Vector256<uint> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.N0 zfunc::get_n0()
    IL_0006: call System.UInt32 Z0.ginx::vxscalar<System.UInt32>(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,Z0.N0)
    IL_000B: ret

}
uint vextract_256x32u_1(Vector256<uint> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.N1 zfunc::get_n1()
    IL_0006: call System.UInt32 Z0.ginx::vxscalar<System.UInt32>(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,Z0.N1)
    IL_000B: ret

}
ulong vextract_256x32u_2(Vector256<uint> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.N2 zfunc::get_n2()
    IL_0006: call System.UInt32 Z0.ginx::vxscalar<System.UInt32>(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,Z0.N2)
    IL_000B: conv.u8
    IL_000C: ret

}
uint vextract_256x32u_3(Vector256<uint> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.N3 zfunc::get_n3()
    IL_0006: call System.UInt32 Z0.ginx::vxscalar<System.UInt32>(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,Z0.N3)
    IL_000B: ret

}
void vlo_256x8u_out(Vector256<byte> src, out ulong x0, out ulong x1)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.Void Z0.dinx::vlo(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.UInt64&,System.UInt64&)
    IL_0008: ret

}
ref Pair<ulong> vlo_256x8u_pair(Vector256<byte> src, ref Pair<ulong> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Pair`1<System.UInt64>& Z0.ginx::vlo<System.Byte>(System.Runtime.Intrinsics.Vector256`1<System.Byte>,Z0.Pair`1<System.UInt64>&)
    IL_0007: ret

}
void vlo_256x64u_out(Vector256<ulong> src, out ulong x0, out ulong x1)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.Void Z0.dinx::vlo(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.UInt64&,System.UInt64&)
    IL_0008: ret

}
ref Pair<ulong> vlo_256x64u_pair(Vector256<ulong> src, ref Pair<ulong> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Pair`1<System.UInt64>& Z0.ginx::vlo<System.UInt64>(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,Z0.Pair`1<System.UInt64>&)
    IL_0007: ret

}
void vhi_256x64u_out(Vector256<ulong> src, out ulong x0, out ulong x1)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.Void Z0.ginx::vhi<System.UInt64>(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.UInt64&,System.UInt64&)
    IL_0008: ret

}
ref Pair<ulong> vhi_256x64u_pair(Vector256<ulong> src, ref Pair<ulong> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Pair`1<System.UInt64>& Z0.ginx::vhi<System.UInt64>(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,Z0.Pair`1<System.UInt64>&)
    IL_0007: ret

}
ulong vextract_256x64u_0(Vector256<ulong> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.N0 zfunc::get_n0()
    IL_0006: call System.UInt64 Z0.ginx::vxscalar<System.UInt64>(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,Z0.N0)
    IL_000B: ret

}
ulong vextract_256x64u_1(Vector256<ulong> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.N1 zfunc::get_n1()
    IL_0006: call System.UInt64 Z0.ginx::vxscalar<System.UInt64>(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,Z0.N1)
    IL_000B: ret

}
ulong vextract_256x64u_2(Vector256<ulong> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.N2 zfunc::get_n2()
    IL_0006: call System.UInt64 Z0.ginx::vxscalar<System.UInt64>(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,Z0.N2)
    IL_000B: ret

}
ulong vextract_256x64u_3(Vector256<ulong> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.N3 zfunc::get_n3()
    IL_0006: call System.UInt64 Z0.ginx::vxscalar<System.UInt64>(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,Z0.N3)
    IL_000B: ret

}
Vector128<byte> vshuffle_128x8u(Vector128<byte> src, Vector128<byte> spec)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.dinx::vshuf16x8(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0007: ret

}
Vector128<sbyte> vshuffle_128x8i(Vector128<sbyte> src, Vector128<sbyte> spec)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.dinx::vshuf16x8(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0007: ret

}
Vector256<byte> vshuffle_256x8u(Vector256<byte> src, Vector256<byte> spec)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.dinx::vshuf16x8(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0007: ret

}
Vector256<sbyte> vshuffle_256x8i(Vector256<sbyte> src, Vector256<sbyte> spec)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.dinx::vshuf16x8(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0007: ret

}
void gparts_xor_8u(int partcount, int partwidth, in byte a, in byte b, ref byte z)
{
    IL_0000: call Z0.N256 zfunc::get_n256()
    IL_0005: ldarg.0
    IL_0006: ldarg.1
    IL_0007: ldarg.2
    IL_0008: ldarg.3
    IL_0009: ldarg.s z
    IL_000B: call System.Void Z0.vblock::xor<System.Byte>(Z0.N256,System.Int32,System.Int32,System.Byte&,System.Byte&,System.Byte&)
    IL_0010: ret

}
void gparts_xor_16u(int partcount, int partwidth, in ushort a, in ushort b, ref ushort z)
{
    IL_0000: call Z0.N256 zfunc::get_n256()
    IL_0005: ldarg.0
    IL_0006: ldarg.1
    IL_0007: ldarg.2
    IL_0008: ldarg.3
    IL_0009: ldarg.s z
    IL_000B: call System.Void Z0.vblock::xor<System.UInt16>(Z0.N256,System.Int32,System.Int32,System.UInt16&,System.UInt16&,System.UInt16&)
    IL_0010: ret

}
void gparts_xor_32u(int partcount, int partwidth, in uint a, in uint b, ref uint z)
{
    IL_0000: call Z0.N256 zfunc::get_n256()
    IL_0005: ldarg.0
    IL_0006: ldarg.1
    IL_0007: ldarg.2
    IL_0008: ldarg.3
    IL_0009: ldarg.s z
    IL_000B: call System.Void Z0.vblock::xor<System.UInt32>(Z0.N256,System.Int32,System.Int32,System.UInt32&,System.UInt32&,System.UInt32&)
    IL_0010: ret

}
void gparts_xor_64u(int partcount, int partwidth, in ulong a, in ulong b, ref ulong z)
{
    IL_0000: call Z0.N256 zfunc::get_n256()
    IL_0005: ldarg.0
    IL_0006: ldarg.1
    IL_0007: ldarg.2
    IL_0008: ldarg.3
    IL_0009: ldarg.s z
    IL_000B: call System.Void Z0.vblock::xor<System.UInt64>(Z0.N256,System.Int32,System.Int32,System.UInt64&,System.UInt64&,System.UInt64&)
    IL_0010: ret

}
Vector128<byte> ones_128x8u()
{
    IL_0000: call Z0.N128 zfunc::get_n128()
    IL_0005: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.ginx::vones<System.Byte>(Z0.N128)
    IL_000A: ret

}
Vector128<ulong> ones_128x64u()
{
    IL_0000: call Z0.N128 zfunc::get_n128()
    IL_0005: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.ginx::vones<System.UInt64>(Z0.N128)
    IL_000A: ret

}
Vector256<byte> ones_256x8u()
{
    IL_0000: call Z0.N256 zfunc::get_n256()
    IL_0005: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.ginx::vones<System.Byte>(Z0.N256)
    IL_000A: ret

}
Vector256<ulong> ones_256x64u()
{
    IL_0000: call Z0.N256 zfunc::get_n256()
    IL_0005: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.ginx::vones<System.UInt64>(Z0.N256)
    IL_000A: ret

}
Vector256<double> ones_256x64f()
{
    IL_0000: call Z0.N256 zfunc::get_n256()
    IL_0005: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.ginx::vones<System.Double>(Z0.N256)
    IL_000A: ret

}
Vector256<byte> pattern_lanemerge_256x8u()
{
    IL_0000: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.ginx::vlanemerge<System.Byte>()
    IL_0005: ret

}
Vector256<ushort> pattern_lanemerge_256x16u()
{
    IL_0000: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.ginx::vlanemerge<System.UInt16>()
    IL_0005: ret

}
Vector128<ushort> vbswap_128x16u(Vector128<ushort> x)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.dinx::vbswap(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0006: ret

}
Vector256<sbyte> vperm4x64(Vector256<sbyte> x)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4 228
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.dinx::vperm4x64(System.Runtime.Intrinsics.Vector256`1<System.SByte>,Z0.Perm4)
    IL_000B: ret

}
Vector256<int> vpermvar8x32_256x32i(Vector256<int> src, Vector256<uint> spec)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.dinx::vperm8x32i(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0007: ret

}
Vector256<uint> vpermvar8x32_256x32u(Vector256<uint> src, Vector256<uint> spec)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.dinx::vperm8x32(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0007: ret

}
Vector256<byte> vpermvar32x8_256x8u(Vector256<byte> a, Vector256<byte> spec)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.dinx::vshuf32x8(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0007: ret

}
Vector128<byte> rotl_128x16_pattern()
{
    IL_0000: call Z0.N128 zfunc::get_n128()
    IL_0005: call Z0.N16 zfunc::get_n16()
    IL_000A: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.DataPatterns::rotl(Z0.N128,Z0.N16)
    IL_000F: ret

}
Vector128<byte> rotl_128x32_pattern()
{
    IL_0000: call Z0.N128 zfunc::get_n128()
    IL_0005: call Z0.N32 zfunc::get_n32()
    IL_000A: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.DataPatterns::rotl(Z0.N128,Z0.N32)
    IL_000F: ret

}
Vector128<byte> rotl_g128x8u(Vector128<byte> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.ginx::vrotl<System.Byte>(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Byte)
    IL_0007: ret

}
Vector128<ushort> rotl_g128x16u(Vector128<ushort> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.ginx::vrotl<System.UInt16>(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Byte)
    IL_0007: ret

}
Vector128<uint> rotl_g128x32u(Vector128<uint> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.ginx::vrotl<System.UInt32>(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Byte)
    IL_0007: ret

}
Vector128<ulong> rotl_g128x64u(Vector128<ulong> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.ginx::vrotl<System.UInt64>(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Byte)
    IL_0007: ret

}
Vector256<byte> rotl_g256x8u(Vector256<byte> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.ginx::vrotl<System.Byte>(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Byte)
    IL_0007: ret

}
Vector256<ushort> rotl_g256x16u(Vector256<ushort> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.ginx::vrotl<System.UInt16>(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Byte)
    IL_0007: ret

}
Vector256<uint> rotl_g256x32u(Vector256<uint> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.ginx::vrotl<System.UInt32>(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Byte)
    IL_0007: ret

}
Vector256<ulong> rotl_g256x64u(Vector256<ulong> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.ginx::vrotl<System.UInt64>(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Byte)
    IL_0007: ret

}
bool vtestz_d128x8i(Vector128<sbyte> src, Vector128<sbyte> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.dinx::vtestz(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret

}
bool vtestz_g128x8i(Vector128<sbyte> src, Vector128<sbyte> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.ginx::vtestz<System.SByte>(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret

}
bool vtestz_d128x8u(Vector128<byte> src, Vector128<byte> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.dinx::vtestz(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret

}
bool vtestz_g128x8u(Vector128<byte> src, Vector128<byte> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.ginx::vtestz<System.Byte>(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret

}
bool vtestz_d128x16i(Vector128<short> src, Vector128<short> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.dinx::vtestz(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret

}
bool vtestz_g128x16i(Vector128<short> src, Vector128<short> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.ginx::vtestz<System.Int16>(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret

}
bool vtestz_d128x16u(Vector128<ushort> src, Vector128<ushort> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.dinx::vtestz(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret

}
bool vtestz_g128x16u(Vector128<ushort> src, Vector128<ushort> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.ginx::vtestz<System.UInt16>(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret

}
bool vtestz_d128x32i(Vector128<int> src, Vector128<int> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.dinx::vtestz(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret

}
bool vtestz_g128x32i(Vector128<int> src, Vector128<int> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.ginx::vtestz<System.Int32>(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret

}
bool vtestz_d128x32u(Vector128<uint> src, Vector128<uint> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.dinx::vtestz(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret

}
bool vtestz_g128x32u(Vector128<uint> src, Vector128<uint> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.ginx::vtestz<System.UInt32>(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret

}
bool vtestz_d128x64i(Vector128<long> src, Vector128<long> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.dinx::vtestz(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret

}
