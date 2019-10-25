// 2019-10-25 06:35:13:800
Vector256<ulong> vxor_n256x64u(Vector256<ulong> x, Vector256<ulong> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0007: ret

}
Vec256<ulong> vxor_d256x64u(Vec256<ulong> x, Vec256<ulong> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec256`1<System.UInt64> Z0.dinx::vxor(Z0.Vec256`1<System.UInt64>&,Z0.Vec256`1<System.UInt64>&)
    IL_0009: ret

}
Vec256<ulong> vxor_g256x64u(Vec256<ulong> x, Vec256<ulong> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec256`1<System.UInt64> Z0.ginx::vxor<System.UInt64>(Z0.Vec256`1<System.UInt64>&,Z0.Vec256`1<System.UInt64>&)
    IL_0009: ret

}
Vector128<int> vcmplt_128x32i(Vector128<int> x, Vector128<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.dinx::vcmplt(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0007: ret

}
Vector128<int> vcmplt_g128x32i(Vector128<int> x, Vector128<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.ginx::vcmplt<System.Int32>(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0007: ret

}
Vector128<uint> vcmplt_128x32u(Vector128<uint> x, Vector128<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.dinx::vcmplt(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0007: ret

}
Vector128<uint> vcmplt_g128x32u(Vector128<uint> x, Vector128<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.ginx::vcmplt<System.UInt32>(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0007: ret

}
Vector128<long> vcmplt_128x64i(Vector128<long> x, Vector128<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.dinx::vcmplt(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0007: ret

}
Vector128<long> vcmplt_g128x64i(Vector128<long> x, Vector128<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.ginx::vcmplt<System.Int64>(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0007: ret

}
Vector128<ulong> vcmplt_128x64u(Vector128<ulong> x, Vector128<ulong> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.dinx::vcmplt(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0007: ret

}
Vector128<ulong> vcmplt_g128x64u(Vector128<ulong> x, Vector128<ulong> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.ginx::vcmplt<System.UInt64>(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0007: ret

}
Vector256<byte> vcmplt_256x8u(Vector256<byte> x, Vector256<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.dinx::vcmplt(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0007: ret

}
Vector256<byte> vcmplt_g256x8u(Vector256<byte> x, Vector256<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.ginx::vcmplt<System.Byte>(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0007: ret

}
Vector256<long> vcmplt_256x64i(Vector256<long> x, Vector256<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.dinx::vcmplt(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0007: ret

}
Vector256<long> vcmplt_g256x64i(Vector256<long> x, Vector256<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.ginx::vcmplt<System.Int64>(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0007: ret

}
Vector256<ulong> vcmplt_256x64u(Vector256<ulong> x, Vector256<ulong> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::vcmplt(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0007: ret

}
Vector256<ulong> vcmplt_g256x64u(Vector256<ulong> x, Vector256<ulong> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.ginx::vcmplt<System.UInt64>(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0007: ret

}
bool vtestz_d128x8i(Vector128<sbyte> src, Vector128<sbyte> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.dinx::testz(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0007: ret

}
bool vtestz_g128x8i(Vector128<sbyte> src, Vector128<sbyte> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.ginx::testz<System.SByte>(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0007: ret

}
bool vtestz_d128x8u(Vector128<byte> src, Vector128<byte> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.dinx::testz(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0007: ret

}
bool vtestz_g128x8u(Vector128<byte> src, Vector128<byte> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.ginx::testz<System.Byte>(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0007: ret

}
bool vtestz_d128x16i(Vector128<short> src, Vector128<short> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.dinx::testz(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0007: ret

}
bool vtestz_g128x16i(Vector128<short> src, Vector128<short> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.ginx::testz<System.Int16>(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0007: ret

}
bool vtestz_d128x16u(Vector128<ushort> src, Vector128<ushort> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.dinx::testz(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0007: ret

}
bool vtestz_g128x16u(Vector128<ushort> src, Vector128<ushort> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.ginx::testz<System.UInt16>(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0007: ret

}
bool vtestz_d128x32i(Vector128<int> src, Vector128<int> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.dinx::testz(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0007: ret

}
bool vtestz_g128x32i(Vector128<int> src, Vector128<int> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.ginx::testz<System.Int32>(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0007: ret

}
bool vtestz_d128x32u(Vector128<uint> src, Vector128<uint> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.dinx::testz(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0007: ret

}
bool vtestz_g128x32u(Vector128<uint> src, Vector128<uint> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.ginx::testz<System.UInt32>(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0007: ret

}
bool vtestz_d128x64i(Vector128<long> src, Vector128<long> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.dinx::testz(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0007: ret

}
bool vtestz_g128x64i(Vector128<long> src, Vector128<long> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.ginx::testz<System.Int64>(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0007: ret

}
bool vtestz_d128x64u(Vector128<ulong> src, Vector128<ulong> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.dinx::testz(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0007: ret

}
bool vtestz_g128x64u(Vector128<ulong> src, Vector128<ulong> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.ginx::testz<System.UInt64>(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0007: ret

}
bool vtestz_d256x8i(Vector256<sbyte> src, Vector256<sbyte> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.dinx::testz(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0007: ret

}
bool vtestz_g256x8i(Vector256<sbyte> src, Vector256<sbyte> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.ginx::testz<System.SByte>(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0007: ret

}
bool vtestz_d256x8u(Vector256<byte> src, Vector256<byte> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.dinx::testz(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0007: ret

}
bool vtestz_g256x8u(Vector256<byte> src, Vector256<byte> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.ginx::testz<System.Byte>(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0007: ret

}
bool vtestz_d256x16i(Vector256<short> src, Vector256<short> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.dinx::testz(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0007: ret

}
bool vtestz_g256x16i(Vector256<short> src, Vector256<short> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.ginx::testz<System.Int16>(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0007: ret

}
bool vtestz_d256x16u(Vector256<ushort> src, Vector256<ushort> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.dinx::testz(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0007: ret

}
bool vtestz_g256x16u(Vector256<ushort> src, Vector256<ushort> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.ginx::testz<System.UInt16>(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0007: ret

}
bool vtestz_d256x32i(Vector256<int> src, Vector256<int> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.dinx::testz(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0007: ret

}
bool vtestz_g256x32i(Vector256<int> src, Vector256<int> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.ginx::testz<System.Int32>(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0007: ret

}
bool vtestz_d256x32u(Vector256<uint> src, Vector256<uint> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.dinx::testz(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0007: ret

}
bool vtestz_g256x32u(Vector256<uint> src, Vector256<uint> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.ginx::testz<System.UInt32>(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0007: ret

}
bool vtestz_d256x64i(Vector256<long> src, Vector256<long> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.dinx::testz(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0007: ret

}
bool vtestz_g256x64i(Vector256<long> src, Vector256<long> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.ginx::testz<System.Int64>(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0007: ret

}
bool vtestz_d256x64u(Vector256<ulong> src, Vector256<ulong> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.dinx::testz(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0007: ret

}
bool vtestz_g256x64u(Vector256<ulong> src, Vector256<ulong> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.ginx::testz<System.UInt64>(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0007: ret

}
Vector128<byte> ones_128x8u()
{
    IL_0000: ldsfld Z0.N128 zfunc::n128
    IL_0005: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.ginx::vones<System.Byte>(Z0.N128)
    IL_000A: ret

}
Vector128<ulong> ones_128x64u()
{
    IL_0000: ldsfld Z0.N128 zfunc::n128
    IL_0005: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.ginx::vones<System.UInt64>(Z0.N128)
    IL_000A: ret

}
Vector256<byte> ones_256x8u()
{
    IL_0000: ldsfld Z0.N256 zfunc::n256
    IL_0005: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.ginx::vones<System.Byte>(Z0.N256)
    IL_000A: ret

}
Vector256<ulong> ones_256x64u()
{
    IL_0000: ldsfld Z0.N256 zfunc::n256
    IL_0005: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.ginx::vones<System.UInt64>(Z0.N256)
    IL_000A: ret

}
Vector256<double> ones_256x64f()
{
    IL_0000: ldsfld Z0.N256 zfunc::n256
    IL_0005: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.ginx::vones<System.Double>(Z0.N256)
    IL_000A: ret

}
Vector256<byte> pattern_lanemerge_256x8u()
{
    IL_0000: call Z0.Vec256`1<System.Byte> Z0.ginx::LaneMerge<System.Byte>()
    IL_0005: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_000A: ret

}
Vector256<ushort> pattern_lanemerge_256x16u()
{
    IL_0000: call Z0.Vec256`1<System.UInt16> Z0.ginx::LaneMerge<System.UInt16>()
    IL_0005: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>)
    IL_000A: ret

}
Vec256<long> vperm2x128_d256x64u_BC(in Vec256<long> x, in Vec256<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 18
    IL_0004: call Z0.Vec256`1<System.Int64> Z0.dinx::vperm2x128(Z0.Vec256`1<System.Int64>&,Z0.Vec256`1<System.Int64>&,Z0.Perm2x128)
    IL_0009: ret

}
Vec256<long> vperm2x128_g256x64u_BC(in Vec256<long> x, in Vec256<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 18
    IL_0004: call Z0.Vec256`1<System.Int64> Z0.ginx::vperm2x128<System.Int64>(Z0.Vec256`1<System.Int64>&,Z0.Vec256`1<System.Int64>&,Z0.Perm2x128)
    IL_0009: ret

}
Vec256<long> vperm2x128_d256x64u_BD(in Vec256<long> x, in Vec256<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 19
    IL_0004: call Z0.Vec256`1<System.Int64> Z0.dinx::vperm2x128(Z0.Vec256`1<System.Int64>&,Z0.Vec256`1<System.Int64>&,Z0.Perm2x128)
    IL_0009: ret

}
Vec256<long> vperm2x128_g256x64u_BD(in Vec256<long> x, in Vec256<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 19
    IL_0004: call Z0.Vec256`1<System.Int64> Z0.ginx::vperm2x128<System.Int64>(Z0.Vec256`1<System.Int64>&,Z0.Vec256`1<System.Int64>&,Z0.Perm2x128)
    IL_0009: ret

}
Vec256<long> vperm2x128_d256x64u_CA(in Vec256<long> x, in Vec256<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 32
    IL_0004: call Z0.Vec256`1<System.Int64> Z0.dinx::vperm2x128(Z0.Vec256`1<System.Int64>&,Z0.Vec256`1<System.Int64>&,Z0.Perm2x128)
    IL_0009: ret

}
Vec256<long> vperm2x128_g256x64u_CA(in Vec256<long> x, in Vec256<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 32
    IL_0004: call Z0.Vec256`1<System.Int64> Z0.ginx::vperm2x128<System.Int64>(Z0.Vec256`1<System.Int64>&,Z0.Vec256`1<System.Int64>&,Z0.Perm2x128)
    IL_0009: ret

}
Vec256<long> vperm2x128_d256x64u_CB(in Vec256<long> x, in Vec256<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 33
    IL_0004: call Z0.Vec256`1<System.Int64> Z0.dinx::vperm2x128(Z0.Vec256`1<System.Int64>&,Z0.Vec256`1<System.Int64>&,Z0.Perm2x128)
    IL_0009: ret

}
Vec256<long> vperm2x128_g256x64u_CB(in Vec256<long> x, in Vec256<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 33
    IL_0004: call Z0.Vec256`1<System.Int64> Z0.ginx::vperm2x128<System.Int64>(Z0.Vec256`1<System.Int64>&,Z0.Vec256`1<System.Int64>&,Z0.Perm2x128)
    IL_0009: ret

}
Vec256<long> vperm2x128_d256x64u_DA(in Vec256<long> x, in Vec256<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 48
    IL_0004: call Z0.Vec256`1<System.Int64> Z0.dinx::vperm2x128(Z0.Vec256`1<System.Int64>&,Z0.Vec256`1<System.Int64>&,Z0.Perm2x128)
    IL_0009: ret

}
Vec256<long> vperm2x128_g256x64u_DA(in Vec256<long> x, in Vec256<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 48
    IL_0004: call Z0.Vec256`1<System.Int64> Z0.ginx::vperm2x128<System.Int64>(Z0.Vec256`1<System.Int64>&,Z0.Vec256`1<System.Int64>&,Z0.Perm2x128)
    IL_0009: ret

}
Vec256<long> vperm2x128_d256x64u_DB(in Vec256<long> x, in Vec256<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 49
    IL_0004: call Z0.Vec256`1<System.Int64> Z0.dinx::vperm2x128(Z0.Vec256`1<System.Int64>&,Z0.Vec256`1<System.Int64>&,Z0.Perm2x128)
    IL_0009: ret

}
Vec256<long> vperm2x128_g256x64u_DB(in Vec256<long> x, in Vec256<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 49
    IL_0004: call Z0.Vec256`1<System.Int64> Z0.ginx::vperm2x128<System.Int64>(Z0.Vec256`1<System.Int64>&,Z0.Vec256`1<System.Int64>&,Z0.Perm2x128)
    IL_0009: ret

}
Vec256<long> vperm4x64_256x64i_DCBA(in Vec256<long> x)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.s 27
    IL_0003: call Z0.Vec256`1<System.Int64> Z0.dinx::vperm4x64(Z0.Vec256`1<System.Int64>&,Z0.Perm4)
    IL_0008: ret

}
Vec256<long> vperm4x64_256x64i_BADC(in Vec256<long> x)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.s 27
    IL_0003: call Z0.Vec256`1<System.Int64> Z0.dinx::vperm4x64(Z0.Vec256`1<System.Int64>&,Z0.Perm4)
    IL_0008: ret

}
Vec256<ulong> vperm4x64_256x64u_DCBA(in Vec256<ulong> x)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.s 27
    IL_0003: call Z0.Vec256`1<System.UInt64> Z0.dinx::vperm4x64(Z0.Vec256`1<System.UInt64>&,Z0.Perm4)
    IL_0008: ret

}
Vec256<ulong> vperm4x64_256x64i_BADC(in Vec256<ulong> x)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.s 27
    IL_0003: call Z0.Vec256`1<System.UInt64> Z0.dinx::vperm4x64(Z0.Vec256`1<System.UInt64>&,Z0.Perm4)
    IL_0008: ret

}
Vec256<double> vperm4x64_256x64f_DCBA(in Vec256<double> x)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.s 27
    IL_0003: call Z0.Vec256`1<System.Double> Z0.dinx::vperm4x64(Z0.Vec256`1<System.Double>&,Z0.Perm4)
    IL_0008: ret

}
Vec256<double> vperm4x64_256x64i_BADC(in Vec256<double> x)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.s 27
    IL_0003: call Z0.Vec256`1<System.Double> Z0.dinx::vperm4x64(Z0.Vec256`1<System.Double>&,Z0.Perm4)
    IL_0008: ret

}
Vector256<int> vpermvar8x32_256x32i(Vector256<int> src, Vector256<int> spec)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.dinx::vpermvar8x32(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0007: ret

}
Vector256<uint> vpermvar8x32_256x32u(Vector256<uint> src, Vector256<uint> spec)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.dinx::vpermvar8x32(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0007: ret

}
Vector256<float> vpermvar8x32_256x32f(Vector256<float> src, Vector256<int> spec)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.dinx::vpermvar8x32(System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0007: ret

}
Vector256<byte> vpermvar32x8_256x8u(Vector256<byte> a, Vector256<byte> spec)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.dinx::vpermvar32x8(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0007: ret

}
Vector128<byte> vshuffle_128x8u(Vector128<byte> src, Vector128<byte> spec)
{
    IL_0000: ldarg.0
    IL_0001: ldarga.s spec
    IL_0003: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.dinx::vshuffle(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>&)
    IL_0008: ret

}
Vector128<sbyte> vshuffle_128x8i(Vector128<sbyte> src, Vector128<sbyte> spec)
{
    IL_0000: ldarg.0
    IL_0001: ldarga.s spec
    IL_0003: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.dinx::vshuffle(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>&)
    IL_0008: ret

}
Vector256<byte> vshuffle_256x8u(Vector256<byte> src, Vector256<byte> spec)
{
    IL_0000: ldarg.0
    IL_0001: ldarga.s spec
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.dinx::vshuffle(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>&)
    IL_0008: ret

}
Vector256<sbyte> vshuffle_256x8i(Vector256<sbyte> src, Vector256<sbyte> spec)
{
    IL_0000: ldarg.0
    IL_0001: ldarga.s spec
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.dinx::vshuffle(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>&)
    IL_0008: ret

}
Vec128<sbyte> vunpackhi_128x8i(in Vec128<sbyte> x, in Vec128<sbyte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.SByte> Z0.ginx::vunpackhi<System.SByte>(Z0.Vec128`1<System.SByte>&,Z0.Vec128`1<System.SByte>&)
    IL_0007: ret

}
Vec128<byte> vunpackhi_128x8u(in Vec128<byte> x, in Vec128<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.Byte> Z0.ginx::vunpackhi<System.Byte>(Z0.Vec128`1<System.Byte>&,Z0.Vec128`1<System.Byte>&)
    IL_0007: ret

}
Vec128<short> vunpackhi_128x16i(in Vec128<short> x, in Vec128<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.Int16> Z0.ginx::vunpackhi<System.Int16>(Z0.Vec128`1<System.Int16>&,Z0.Vec128`1<System.Int16>&)
    IL_0007: ret

}
Vec128<ushort> vunpackhi_128x16u(in Vec128<ushort> x, in Vec128<ushort> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.UInt16> Z0.ginx::vunpackhi<System.UInt16>(Z0.Vec128`1<System.UInt16>&,Z0.Vec128`1<System.UInt16>&)
    IL_0007: ret

}
Vec128<int> vunpackhi_128x32i(in Vec128<int> x, in Vec128<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.Int32> Z0.ginx::vunpackhi<System.Int32>(Z0.Vec128`1<System.Int32>&,Z0.Vec128`1<System.Int32>&)
    IL_0007: ret

}
Vec128<uint> vunpackhi_128x32u(in Vec128<uint> x, in Vec128<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.UInt32> Z0.ginx::vunpackhi<System.UInt32>(Z0.Vec128`1<System.UInt32>&,Z0.Vec128`1<System.UInt32>&)
    IL_0007: ret

}
Vec128<long> vunpackhi_128x64i(in Vec128<long> x, in Vec128<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.Int64> Z0.ginx::vunpackhi<System.Int64>(Z0.Vec128`1<System.Int64>&,Z0.Vec128`1<System.Int64>&)
    IL_0007: ret

}
Vec128<ulong> vunpackhi_128x64u(in Vec128<ulong> x, in Vec128<ulong> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.UInt64> Z0.ginx::vunpackhi<System.UInt64>(Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&)
    IL_0007: ret

}
Vec256<sbyte> vunpackhi_256x8i(in Vec256<sbyte> x, in Vec256<sbyte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.SByte> Z0.ginx::vunpackhi<System.SByte>(Z0.Vec256`1<System.SByte>&,Z0.Vec256`1<System.SByte>&)
    IL_0007: ret

}
Vec256<byte> vunpackhi_256x8u(in Vec256<byte> x, in Vec256<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.Byte> Z0.ginx::vunpackhi<System.Byte>(Z0.Vec256`1<System.Byte>&,Z0.Vec256`1<System.Byte>&)
    IL_0007: ret

}
Vec256<short> vunpackhi_256x16i(in Vec256<short> x, in Vec256<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.Int16> Z0.ginx::vunpackhi<System.Int16>(Z0.Vec256`1<System.Int16>&,Z0.Vec256`1<System.Int16>&)
    IL_0007: ret

}
Vec256<ushort> vunpackhi_256x16u(in Vec256<ushort> x, in Vec256<ushort> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.UInt16> Z0.ginx::vunpackhi<System.UInt16>(Z0.Vec256`1<System.UInt16>&,Z0.Vec256`1<System.UInt16>&)
    IL_0007: ret

}
Vec256<int> vunpackhi_256x32i(in Vec256<int> x, in Vec256<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.Int32> Z0.ginx::vunpackhi<System.Int32>(Z0.Vec256`1<System.Int32>&,Z0.Vec256`1<System.Int32>&)
    IL_0007: ret

}
Vec256<uint> vunpackhi_256x32u(in Vec256<uint> x, in Vec256<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.UInt32> Z0.ginx::vunpackhi<System.UInt32>(Z0.Vec256`1<System.UInt32>&,Z0.Vec256`1<System.UInt32>&)
    IL_0007: ret

}
Vec256<long> vunpackhi_256x64i(in Vec256<long> x, in Vec256<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.Int64> Z0.ginx::vunpackhi<System.Int64>(Z0.Vec256`1<System.Int64>&,Z0.Vec256`1<System.Int64>&)
    IL_0007: ret

}
Vec256<ulong> vunpackhi_256x64u(in Vec256<ulong> x, in Vec256<ulong> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.UInt64> Z0.ginx::vunpackhi<System.UInt64>(Z0.Vec256`1<System.UInt64>&,Z0.Vec256`1<System.UInt64>&)
    IL_0007: ret

}
Vec128<sbyte> vunpacklo_128x8i(in Vec128<sbyte> x, in Vec128<sbyte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.SByte> Z0.ginx::vunpacklo<System.SByte>(Z0.Vec128`1<System.SByte>&,Z0.Vec128`1<System.SByte>&)
    IL_0007: ret

}
Vec128<byte> vunpacklo_128x8u(in Vec128<byte> x, in Vec128<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.Byte> Z0.ginx::vunpacklo<System.Byte>(Z0.Vec128`1<System.Byte>&,Z0.Vec128`1<System.Byte>&)
    IL_0007: ret

}
Vec128<short> vunpacklo_128x16i(in Vec128<short> x, in Vec128<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.Int16> Z0.ginx::vunpacklo<System.Int16>(Z0.Vec128`1<System.Int16>&,Z0.Vec128`1<System.Int16>&)
    IL_0007: ret

}
Vec128<ushort> vunpacklo_128x16u(in Vec128<ushort> x, in Vec128<ushort> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.UInt16> Z0.ginx::vunpacklo<System.UInt16>(Z0.Vec128`1<System.UInt16>&,Z0.Vec128`1<System.UInt16>&)
    IL_0007: ret

}
Vec128<int> vunpacklo_128x32i(in Vec128<int> x, in Vec128<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.Int32> Z0.ginx::vunpacklo<System.Int32>(Z0.Vec128`1<System.Int32>&,Z0.Vec128`1<System.Int32>&)
    IL_0007: ret

}
Vec128<uint> vunpacklo_128x32u(in Vec128<uint> x, in Vec128<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.UInt32> Z0.ginx::vunpacklo<System.UInt32>(Z0.Vec128`1<System.UInt32>&,Z0.Vec128`1<System.UInt32>&)
    IL_0007: ret

}
Vec128<long> vunpacklo_128x64i(in Vec128<long> x, in Vec128<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.Int64> Z0.ginx::vunpacklo<System.Int64>(Z0.Vec128`1<System.Int64>&,Z0.Vec128`1<System.Int64>&)
    IL_0007: ret

}
Vec128<ulong> vunpacklo_128x64u(in Vec128<ulong> x, in Vec128<ulong> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.UInt64> Z0.ginx::vunpacklo<System.UInt64>(Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&)
    IL_0007: ret

}
Vec256<sbyte> vunpacklo_256x8i(in Vec256<sbyte> x, in Vec256<sbyte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.SByte> Z0.ginx::vunpacklo<System.SByte>(Z0.Vec256`1<System.SByte>&,Z0.Vec256`1<System.SByte>&)
    IL_0007: ret

}
Vec256<byte> vunpacklo_256x8u(in Vec256<byte> x, in Vec256<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.Byte> Z0.ginx::vunpacklo<System.Byte>(Z0.Vec256`1<System.Byte>&,Z0.Vec256`1<System.Byte>&)
    IL_0007: ret

}
Vec256<short> vunpacklo_256x16i(in Vec256<short> x, in Vec256<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.Int16> Z0.ginx::vunpacklo<System.Int16>(Z0.Vec256`1<System.Int16>&,Z0.Vec256`1<System.Int16>&)
    IL_0007: ret

}
Vec256<ushort> vunpacklo_256x16u(in Vec256<ushort> x, in Vec256<ushort> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.UInt16> Z0.ginx::vunpacklo<System.UInt16>(Z0.Vec256`1<System.UInt16>&,Z0.Vec256`1<System.UInt16>&)
    IL_0007: ret

}
Vec256<int> vunpacklo_256x32i(in Vec256<int> x, in Vec256<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.Int32> Z0.ginx::vunpacklo<System.Int32>(Z0.Vec256`1<System.Int32>&,Z0.Vec256`1<System.Int32>&)
    IL_0007: ret

}
Vec256<uint> vunpacklo_256x32u(in Vec256<uint> x, in Vec256<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.UInt32> Z0.ginx::vunpacklo<System.UInt32>(Z0.Vec256`1<System.UInt32>&,Z0.Vec256`1<System.UInt32>&)
    IL_0007: ret

}
Vec256<long> vunpacklo_256x64i(in Vec256<long> x, in Vec256<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.Int64> Z0.ginx::vunpacklo<System.Int64>(Z0.Vec256`1<System.Int64>&,Z0.Vec256`1<System.Int64>&)
    IL_0007: ret

}
Vec256<ulong> vunpacklo_256x64u(in Vec256<ulong> x, in Vec256<ulong> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.UInt64> Z0.ginx::vunpacklo<System.UInt64>(Z0.Vec256`1<System.UInt64>&,Z0.Vec256`1<System.UInt64>&)
    IL_0007: ret

}
Vector128<byte> vsll(Vector128<byte> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: ldarg.1
    IL_000A: call Z0.Vec128`1<System.Byte> Z0.dinx::vsll(Z0.Vec128`1<System.Byte>&,System.Byte)
    IL_000F: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_0014: ret

}
Vector128<byte> rotl_128x8u(Vector128<byte> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.ginx::vrotl<System.Byte>(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Byte)
    IL_0007: ret

}
Vector128<ushort> rotl_128x16u(Vector128<ushort> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.ginx::vrotl<System.UInt16>(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Byte)
    IL_0007: ret

}
Vector128<uint> rotl_128x32u(Vector128<uint> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.ginx::vrotl<System.UInt32>(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Byte)
    IL_0007: ret

}
Vector128<ulong> rotl_128x64u(Vector128<ulong> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.ginx::vrotl<System.UInt64>(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Byte)
    IL_0007: ret

}
Vector256<byte> rotl_256x8u(Vector256<byte> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.ginx::vrotl<System.Byte>(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Byte)
    IL_0007: ret

}
Vector256<ushort> rotl_256x16u(Vector256<ushort> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.ginx::vrotl<System.UInt16>(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Byte)
    IL_0007: ret

}
Vector256<uint> rotl_256x32u(Vector256<uint> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.ginx::vrotl<System.UInt32>(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Byte)
    IL_0007: ret

}
Vector256<ulong> rotl_256x64u(Vector256<ulong> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.ginx::vrotl<System.UInt64>(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Byte)
    IL_0007: ret

}
Vec128<int> vsllv_d128x32i(Vec128<int> src, Vec128<uint> offset)
{
    IL_0000: ldarga.s src
    IL_0002: ldarga.s offset
    IL_0004: call Z0.Vec128`1<System.Int32> Z0.dinx::vsllv(Z0.Vec128`1<System.Int32>&,Z0.Vec128`1<System.UInt32>&)
    IL_0009: ret

}
Vec128<int> vsllv_g128x32i(Vec128<int> src, Vec128<uint> offset)
{
    IL_0000: ldarga.s src
    IL_0002: ldarga.s offset
    IL_0004: call Z0.Vec128`1<System.Int32> Z0.ginx::vsllv<System.Int32,System.UInt32>(Z0.Vec128`1<System.Int32>&,Z0.Vec128`1<System.UInt32>&)
    IL_0009: ret

}
Vec128<uint> vsllv_d128x32u(Vec128<uint> src, Vec128<uint> offset)
{
    IL_0000: ldarga.s src
    IL_0002: ldarga.s offset
    IL_0004: call Z0.Vec128`1<System.UInt32> Z0.dinx::vsllv(Z0.Vec128`1<System.UInt32>&,Z0.Vec128`1<System.UInt32>&)
    IL_0009: ret

}
Vec128<uint> vsllv_g128x32u(Vec128<uint> src, Vec128<uint> offset)
{
    IL_0000: ldarga.s src
    IL_0002: ldarga.s offset
    IL_0004: call Z0.Vec128`1<System.UInt32> Z0.ginx::vsllv<System.UInt32,System.UInt32>(Z0.Vec128`1<System.UInt32>&,Z0.Vec128`1<System.UInt32>&)
    IL_0009: ret

}
Vec128<long> vsllv_d128x64i(Vec128<long> src, Vec128<ulong> offset)
{
    IL_0000: ldarga.s src
    IL_0002: ldarga.s offset
    IL_0004: call Z0.Vec128`1<System.Int64> Z0.dinx::vsllv(Z0.Vec128`1<System.Int64>&,Z0.Vec128`1<System.UInt64>&)
    IL_0009: ret

}
Vec128<long> vsllv_g128x64i(Vec128<long> src, Vec128<ulong> offset)
{
    IL_0000: ldarga.s src
    IL_0002: ldarga.s offset
    IL_0004: call Z0.Vec128`1<System.Int64> Z0.ginx::vsllv<System.Int64,System.UInt64>(Z0.Vec128`1<System.Int64>&,Z0.Vec128`1<System.UInt64>&)
    IL_0009: ret

}
Vec128<ulong> vsllv_d128x64u(Vec128<ulong> src, Vec128<ulong> offset)
{
    IL_0000: ldarga.s src
    IL_0002: ldarga.s offset
    IL_0004: call Z0.Vec128`1<System.UInt64> Z0.dinx::vsllv(Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&)
    IL_0009: ret

}
Vec128<ulong> vsllv_g128x64u(Vec128<ulong> src, Vec128<ulong> offset)
{
    IL_0000: ldarga.s src
    IL_0002: ldarga.s offset
    IL_0004: call Z0.Vec128`1<System.UInt64> Z0.ginx::vsllv<System.UInt64,System.UInt64>(Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&)
    IL_0009: ret

}
Vec256<int> vsllv_d256x32u(Vec256<int> src, Vec256<uint> offset)
{
    IL_0000: ldarga.s src
    IL_0002: ldarga.s offset
    IL_0004: call Z0.Vec256`1<System.Int32> Z0.dinx::vsllv(Z0.Vec256`1<System.Int32>&,Z0.Vec256`1<System.UInt32>&)
    IL_0009: ret

}
Vec256<int> vsllv_g256x32u(Vec256<int> src, Vec256<uint> offset)
{
    IL_0000: ldarga.s src
    IL_0002: ldarga.s offset
    IL_0004: call Z0.Vec256`1<System.Int32> Z0.ginx::vsllv<System.Int32,System.UInt32>(Z0.Vec256`1<System.Int32>&,Z0.Vec256`1<System.UInt32>&)
    IL_0009: ret

}
Vec256<uint> vsllv_d256x64i(Vec256<uint> src, Vec256<uint> offset)
{
    IL_0000: ldarga.s src
    IL_0002: ldarga.s offset
    IL_0004: call Z0.Vec256`1<System.UInt32> Z0.dinx::vsllv(Z0.Vec256`1<System.UInt32>&,Z0.Vec256`1<System.UInt32>&)
    IL_0009: ret

}
Vec256<uint> vsllv_g256x64i(Vec256<uint> src, Vec256<uint> offset)
{
    IL_0000: ldarga.s src
    IL_0002: ldarga.s offset
    IL_0004: call Z0.Vec256`1<System.UInt32> Z0.ginx::vsllv<System.UInt32,System.UInt32>(Z0.Vec256`1<System.UInt32>&,Z0.Vec256`1<System.UInt32>&)
    IL_0009: ret

}
Vec256<long> vsllv_d256x64i(Vec256<long> src, Vec256<ulong> offset)
{
    IL_0000: ldarga.s src
    IL_0002: ldarga.s offset
    IL_0004: call Z0.Vec256`1<System.Int64> Z0.dinx::vsllv(Z0.Vec256`1<System.Int64>&,Z0.Vec256`1<System.UInt64>&)
    IL_0009: ret

}
Vec256<long> vsllv_g256x64i(Vec256<long> src, Vec256<ulong> offset)
{
    IL_0000: ldarga.s src
    IL_0002: ldarga.s offset
    IL_0004: call Z0.Vec256`1<System.Int64> Z0.ginx::vsllv<System.Int64,System.UInt64>(Z0.Vec256`1<System.Int64>&,Z0.Vec256`1<System.UInt64>&)
    IL_0009: ret

}
Vec256<ulong> vsllv_d256x64u(Vec256<ulong> src, Vec256<ulong> offset)
{
    IL_0000: ldarga.s src
    IL_0002: ldarga.s offset
    IL_0004: call Z0.Vec256`1<System.UInt64> Z0.dinx::vsllv(Z0.Vec256`1<System.UInt64>&,Z0.Vec256`1<System.UInt64>&)
    IL_0009: ret

}
Vec256<ulong> vsllv_g256x64u(Vec256<ulong> src, Vec256<ulong> offset)
{
    IL_0000: ldarga.s src
    IL_0002: ldarga.s offset
    IL_0004: call Z0.Vec256`1<System.UInt64> Z0.ginx::vsllv<System.UInt64,System.UInt64>(Z0.Vec256`1<System.UInt64>&,Z0.Vec256`1<System.UInt64>&)
    IL_0009: ret

}
Vector128<sbyte> vxor_n128x8i(Vector128<sbyte> x, Vector128<sbyte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0007: ret

}
Vec128<sbyte> vxor_d128x8i(Vec128<sbyte> x, Vec128<sbyte> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec128`1<System.SByte> Z0.dinx::vxor(Z0.Vec128`1<System.SByte>&,Z0.Vec128`1<System.SByte>&)
    IL_0009: ret

}
Vec128<sbyte> vxor_g128x8i(Vec128<sbyte> x, Vec128<sbyte> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec128`1<System.SByte> Z0.ginx::vxor<System.SByte>(Z0.Vec128`1<System.SByte>&,Z0.Vec128`1<System.SByte>&)
    IL_0009: ret

}
Vector128<byte> vxor_n128x8u(Vector128<byte> x, Vector128<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0007: ret

}
Vec128<byte> vxor_d128x8u(Vec128<byte> x, Vec128<byte> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec128`1<System.Byte> Z0.dinx::vxor(Z0.Vec128`1<System.Byte>&,Z0.Vec128`1<System.Byte>&)
    IL_0009: ret

}
Vec128<byte> vxor_g128x8u(Vec128<byte> x, Vec128<byte> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec128`1<System.Byte> Z0.ginx::vxor<System.Byte>(Z0.Vec128`1<System.Byte>&,Z0.Vec128`1<System.Byte>&)
    IL_0009: ret

}
Vector128<short> vxor_n128x16i(Vector128<short> x, Vector128<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0007: ret

}
Vec128<short> vxor_d128x16i(Vec128<short> x, Vec128<short> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec128`1<System.Int16> Z0.dinx::vxor(Z0.Vec128`1<System.Int16>&,Z0.Vec128`1<System.Int16>&)
    IL_0009: ret

}
Vec128<short> vxor_g128x16i(Vec128<short> x, Vec128<short> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec128`1<System.Int16> Z0.ginx::vxor<System.Int16>(Z0.Vec128`1<System.Int16>&,Z0.Vec128`1<System.Int16>&)
    IL_0009: ret

}
Vector128<ushort> vxor_n128x16u(Vector128<ushort> x, Vector128<ushort> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0007: ret

}
Vec128<ushort> vxor_d128x16u(Vec128<ushort> x, Vec128<ushort> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec128`1<System.UInt16> Z0.dinx::vxor(Z0.Vec128`1<System.UInt16>&,Z0.Vec128`1<System.UInt16>&)
    IL_0009: ret

}
Vec128<ushort> vxor_g128x16u(Vec128<ushort> x, Vec128<ushort> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec128`1<System.UInt16> Z0.ginx::vxor<System.UInt16>(Z0.Vec128`1<System.UInt16>&,Z0.Vec128`1<System.UInt16>&)
    IL_0009: ret

}
Vector128<int> vxor_n128x32i(Vector128<int> x, Vector128<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0007: ret

}
Vec128<int> vxor_d128x32i(Vec128<int> x, Vec128<int> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec128`1<System.Int32> Z0.dinx::vxor(Z0.Vec128`1<System.Int32>&,Z0.Vec128`1<System.Int32>&)
    IL_0009: ret

}
Vec128<int> vxor_g128x32i(Vec128<int> x, Vec128<int> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec128`1<System.Int32> Z0.ginx::vxor<System.Int32>(Z0.Vec128`1<System.Int32>&,Z0.Vec128`1<System.Int32>&)
    IL_0009: ret

}
Vector128<uint> vxor_n128x32u(Vector128<uint> x, Vector128<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0007: ret

}
Vec128<uint> vxor_d128x32u(Vec128<uint> x, Vec128<uint> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec128`1<System.UInt32> Z0.dinx::vxor(Z0.Vec128`1<System.UInt32>&,Z0.Vec128`1<System.UInt32>&)
    IL_0009: ret

}
Vec128<uint> vxor_g128x32u(Vec128<uint> x, Vec128<uint> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec128`1<System.UInt32> Z0.ginx::vxor<System.UInt32>(Z0.Vec128`1<System.UInt32>&,Z0.Vec128`1<System.UInt32>&)
    IL_0009: ret

}
Vector128<long> vxor_n128x64i(Vector128<long> x, Vector128<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0007: ret

}
Vec128<long> vxor_d128x64i(Vec128<long> x, Vec128<long> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec128`1<System.Int64> Z0.dinx::vxor(Z0.Vec128`1<System.Int64>&,Z0.Vec128`1<System.Int64>&)
    IL_0009: ret

}
Vec128<long> vxor_g128x64i(Vec128<long> x, Vec128<long> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec128`1<System.Int64> Z0.ginx::vxor<System.Int64>(Z0.Vec128`1<System.Int64>&,Z0.Vec128`1<System.Int64>&)
    IL_0009: ret

}
Vector128<ulong> vxor_n128x64u(Vector128<ulong> x, Vector128<ulong> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0007: ret

}
Vec128<ulong> vxor_d128x64u(Vec128<ulong> x, Vec128<ulong> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec128`1<System.UInt64> Z0.dinx::vxor(Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&)
    IL_0009: ret

}
Vec128<ulong> vxor_g128x64u(Vec128<ulong> x, Vec128<ulong> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec128`1<System.UInt64> Z0.ginx::vxor<System.UInt64>(Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&)
    IL_0009: ret

}
Vector256<sbyte> vxor_n256x8i(Vector256<sbyte> x, Vector256<sbyte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0007: ret

}
Vec256<sbyte> vxor_d256x8i(Vec256<sbyte> x, Vec256<sbyte> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec256`1<System.SByte> Z0.dinx::vxor(Z0.Vec256`1<System.SByte>&,Z0.Vec256`1<System.SByte>&)
    IL_0009: ret

}
Vec256<sbyte> vxor_g256x8i(Vec256<sbyte> x, Vec256<sbyte> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec256`1<System.SByte> Z0.ginx::vxor<System.SByte>(Z0.Vec256`1<System.SByte>&,Z0.Vec256`1<System.SByte>&)
    IL_0009: ret

}
Vector256<byte> vxor_n256x8u(Vector256<byte> x, Vector256<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0007: ret

}
Vec256<byte> vxor_d256x8u(Vec256<byte> x, Vec256<byte> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec256`1<System.Byte> Z0.dinx::vxor(Z0.Vec256`1<System.Byte>&,Z0.Vec256`1<System.Byte>&)
    IL_0009: ret

}
Vec256<byte> vxor_g256x8u(Vec256<byte> x, Vec256<byte> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec256`1<System.Byte> Z0.ginx::vxor<System.Byte>(Z0.Vec256`1<System.Byte>&,Z0.Vec256`1<System.Byte>&)
    IL_0009: ret

}
Vector256<short> vxor_n256x16i(Vector256<short> x, Vector256<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0007: ret

}
Vec256<short> vxor_d256x16i(Vec256<short> x, Vec256<short> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec256`1<System.Int16> Z0.dinx::vxor(Z0.Vec256`1<System.Int16>&,Z0.Vec256`1<System.Int16>&)
    IL_0009: ret

}
Vec256<short> vxor_g256x16i(Vec256<short> x, Vec256<short> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec256`1<System.Int16> Z0.ginx::vxor<System.Int16>(Z0.Vec256`1<System.Int16>&,Z0.Vec256`1<System.Int16>&)
    IL_0009: ret

}
Vector256<ushort> vxor_n256x16u(Vector256<ushort> x, Vector256<ushort> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0007: ret

}
Vec256<ushort> vxor_d256x16u(Vec256<ushort> x, Vec256<ushort> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec256`1<System.UInt16> Z0.dinx::vxor(Z0.Vec256`1<System.UInt16>&,Z0.Vec256`1<System.UInt16>&)
    IL_0009: ret

}
Vec256<ushort> vxor_g256x16u(Vec256<ushort> x, Vec256<ushort> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec256`1<System.UInt16> Z0.ginx::vxor<System.UInt16>(Z0.Vec256`1<System.UInt16>&,Z0.Vec256`1<System.UInt16>&)
    IL_0009: ret

}
Vector256<int> vxor_n256x32i(Vector256<int> x, Vector256<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0007: ret

}
Vec256<int> vxor_d256x32i(Vec256<int> x, Vec256<int> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec256`1<System.Int32> Z0.dinx::vxor(Z0.Vec256`1<System.Int32>&,Z0.Vec256`1<System.Int32>&)
    IL_0009: ret

}
Vec256<int> vxor_g256x32i(Vec256<int> x, Vec256<int> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec256`1<System.Int32> Z0.ginx::vxor<System.Int32>(Z0.Vec256`1<System.Int32>&,Z0.Vec256`1<System.Int32>&)
    IL_0009: ret

}
Vector256<uint> vxor_n256x32u(Vector256<uint> x, Vector256<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0007: ret

}
Vec256<uint> vxor_d256x32u(Vec256<uint> x, Vec256<uint> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec256`1<System.UInt32> Z0.dinx::vxor(Z0.Vec256`1<System.UInt32>&,Z0.Vec256`1<System.UInt32>&)
    IL_0009: ret

}
Vec256<uint> vxor_g256x32u(Vec256<uint> x, Vec256<uint> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec256`1<System.UInt32> Z0.ginx::vxor<System.UInt32>(Z0.Vec256`1<System.UInt32>&,Z0.Vec256`1<System.UInt32>&)
    IL_0009: ret

}
Vector256<long> vxor_n256x64i(Vector256<long> x, Vector256<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0007: ret

}
Vec256<long> vxor_d256x64i(Vec256<long> x, Vec256<long> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec256`1<System.Int64> Z0.dinx::vxor(Z0.Vec256`1<System.Int64>&,Z0.Vec256`1<System.Int64>&)
    IL_0009: ret

}
Vec256<long> vxor_g256x64i(Vec256<long> x, Vec256<long> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec256`1<System.Int64> Z0.ginx::vxor<System.Int64>(Z0.Vec256`1<System.Int64>&,Z0.Vec256`1<System.Int64>&)
    IL_0009: ret

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
Vec128<short> vblend_128x16u_LLLLLLLL(in Vec128<short> x, in Vec128<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.0
    IL_0003: call Z0.Vec128`1<System.Int16> Z0.dinx::vblend(Z0.Vec128`1<System.Int16>&,Z0.Vec128`1<System.Int16>&,Z0.Blend16x8)
    IL_0008: ret

}
Vec128<short> vblend_128x16u_RRRRRRRR(in Vec128<short> x, in Vec128<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4 255
    IL_0007: call Z0.Vec128`1<System.Int16> Z0.dinx::vblend(Z0.Vec128`1<System.Int16>&,Z0.Vec128`1<System.Int16>&,Z0.Blend16x8)
    IL_000C: ret

}
Vec128<short> vblend_128x16u_LLLLRRRR(in Vec128<short> x, in Vec128<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4 240
    IL_0007: call Z0.Vec128`1<System.Int16> Z0.dinx::vblend(Z0.Vec128`1<System.Int16>&,Z0.Vec128`1<System.Int16>&,Z0.Blend16x8)
    IL_000C: ret

}
Vec128<short> vblend_128x16u_RRRRLLLL(in Vec128<short> x, in Vec128<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 15
    IL_0004: call Z0.Vec128`1<System.Int16> Z0.dinx::vblend(Z0.Vec128`1<System.Int16>&,Z0.Vec128`1<System.Int16>&,Z0.Blend16x8)
    IL_0009: ret

}
Vec128<short> vblend_128x16u_LRLRLRLR(in Vec128<short> x, in Vec128<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4 170
    IL_0007: call Z0.Vec128`1<System.Int16> Z0.dinx::vblend(Z0.Vec128`1<System.Int16>&,Z0.Vec128`1<System.Int16>&,Z0.Blend16x8)
    IL_000C: ret

}
Vec128<short> vblend_128x16u_RLRLRLRL(in Vec128<short> x, in Vec128<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 85
    IL_0004: call Z0.Vec128`1<System.Int16> Z0.dinx::vblend(Z0.Vec128`1<System.Int16>&,Z0.Vec128`1<System.Int16>&,Z0.Blend16x8)
    IL_0009: ret

}
Vec128<uint> vblend_128x32u_LLLL(in Vec128<uint> x, in Vec128<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.0
    IL_0003: call Z0.Vec128`1<System.UInt32> Z0.dinx::vblend(Z0.Vec128`1<System.UInt32>&,Z0.Vec128`1<System.UInt32>&,Z0.Blend32x4)
    IL_0008: ret

}
Vec128<uint> vblend_128x32u_RRRR(in Vec128<uint> x, in Vec128<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 15
    IL_0004: call Z0.Vec128`1<System.UInt32> Z0.dinx::vblend(Z0.Vec128`1<System.UInt32>&,Z0.Vec128`1<System.UInt32>&,Z0.Blend32x4)
    IL_0009: ret

}
Vec128<uint> vblend_128x32u_RRLL(in Vec128<uint> x, in Vec128<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 12
    IL_0004: call Z0.Vec128`1<System.UInt32> Z0.dinx::vblend(Z0.Vec128`1<System.UInt32>&,Z0.Vec128`1<System.UInt32>&,Z0.Blend32x4)
    IL_0009: ret

}
Vec128<uint> vblend_128x32u_LLRR(in Vec128<uint> x, in Vec128<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 12
    IL_0004: call Z0.Vec128`1<System.UInt32> Z0.dinx::vblend(Z0.Vec128`1<System.UInt32>&,Z0.Vec128`1<System.UInt32>&,Z0.Blend32x4)
    IL_0009: ret

}
Vec128<uint> vblend_128x32u_LRLR(in Vec128<uint> x, in Vec128<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 10
    IL_0004: call Z0.Vec128`1<System.UInt32> Z0.dinx::vblend(Z0.Vec128`1<System.UInt32>&,Z0.Vec128`1<System.UInt32>&,Z0.Blend32x4)
    IL_0009: ret

}
Vec128<uint> vblend_128x32u_RLRL(in Vec128<uint> x, in Vec128<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.5
    IL_0003: call Z0.Vec128`1<System.UInt32> Z0.dinx::vblend(Z0.Vec128`1<System.UInt32>&,Z0.Vec128`1<System.UInt32>&,Z0.Blend32x4)
    IL_0008: ret

}
Vec256<ushort> vblend_256x16u_LLLLRRRR(in Vec256<ushort> x, in Vec256<ushort> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4 240
    IL_0007: call Z0.Vec256`1<System.UInt16> Z0.dinx::vblend(Z0.Vec256`1<System.UInt16>&,Z0.Vec256`1<System.UInt16>&,Z0.Blend16x8)
    IL_000C: ret

}
ref Vector128<short> vconvert_128x8i_to_128x16i(Vector128<sbyte> src, out Vector128<short> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int16>& Z0.dinx::vconvert(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.Int16>&)
    IL_0007: ret

}
ref Vector128<int> vconvert_128x8i_to_128x32i(Vector128<sbyte> src, out Vector128<int> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int32>& Z0.dinx::vconvert(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.Int32>&)
    IL_0007: ret

}
ref Vector128<long> vconvert_128x8i_to_128x64i(Vector128<sbyte> src, out Vector128<long> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int64>& Z0.dinx::vconvert(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.Int64>&)
    IL_0007: ret

}
ref Vector128<short> vconvert_128x8u_to_128x16i(Vector128<byte> src, out Vector128<short> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int16>& Z0.dinx::vconvert(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Int16>&)
    IL_0007: ret

}
ref Vector128<ushort> vconvert_128x8u_to_128x16u(Vector128<byte> src, out Vector128<ushort> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt16>& Z0.dinx::vconvert(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>&)
    IL_0007: ret

}
ref Vector128<int> vconvert_128x8u_to_128x32i(Vector128<byte> src, out Vector128<int> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int32>& Z0.dinx::vconvert(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Int32>&)
    IL_0007: ret

}
ref Vector128<uint> vconvert_128x8u_to_128x32u(Vector128<byte> src, out Vector128<uint> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt32>& Z0.dinx::vconvert(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>&)
    IL_0007: ret

}
ref Vector128<long> vconvert_128x8u_to_128x64i(Vector128<byte> src, out Vector128<long> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int64>& Z0.dinx::vconvert(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Int64>&)
    IL_0007: ret

}
ref Vector128<ulong> vconvert_128x8u_to_128x64u(Vector128<byte> src, out Vector128<ulong> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt64>& Z0.dinx::vconvert(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>&)
    IL_0007: ret

}
ref Vector128<int> vconvert_128x16i_to_128x32i(Vector128<short> src, out Vector128<int> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int32>& Z0.dinx::vconvert(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int32>&)
    IL_0007: ret

}
ref Vector128<long> vconvert_128x16i_to_128x64i(Vector128<short> src, out Vector128<long> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int64>& Z0.dinx::vconvert(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int64>&)
    IL_0007: ret

}
ref Vector128<int> vconvert_128x16u_to_128x32i(Vector128<ushort> src, out Vector128<int> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int32>& Z0.dinx::vconvert(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.Int32>&)
    IL_0007: ret

}
ref Vector128<uint> vconvert_128x16u_to_128x32u(Vector128<ushort> src, out Vector128<uint> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt32>& Z0.dinx::vconvert(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>&)
    IL_0007: ret

}
ref Vector128<long> vconvert_128x16u_to_128x64i(Vector128<ushort> src, out Vector128<long> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int64>& Z0.dinx::vconvert(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.Int64>&)
    IL_0007: ret

}
ref Vector128<ulong> vconvert_128x16u_to_128x64u(Vector128<ushort> src, out Vector128<ulong> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt64>& Z0.dinx::vconvert(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>&)
    IL_0007: ret

}
ref Vector128<long> vconvert_128x32i_to_128x64i(Vector128<int> src, out Vector128<long> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int64>& Z0.dinx::vconvert(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int64>&)
    IL_0007: ret

}
ref Vector128<long> vconvert_128x32u_to_128x64i(Vector128<uint> src, out Vector128<long> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int64>& Z0.dinx::vconvert(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.Int64>&)
    IL_0007: ret

}
ref Vector128<ulong> vconvert_128x32u_to_128x64u(Vector128<uint> src, out Vector128<ulong> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt64>& Z0.dinx::vconvert(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>&)
    IL_0007: ret

}
ref Vector256<short> vconvert_128x8i_to_256x16i(Vector128<sbyte> src, out Vector256<short> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int16>& Z0.dinx::vconvert(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.Int16>&)
    IL_0007: ret

}
ref Vector256<int> vconvert_128x8i_to_256x32i(Vector128<sbyte> src, out Vector256<int> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int32>& Z0.dinx::vconvert(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.Int32>&)
    IL_0007: ret

}
ref Vector256<long> vconvert_128x8i_to_256x64i(Vector128<sbyte> src, out Vector256<long> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int64>& Z0.dinx::vconvert(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.Int64>&)
    IL_0007: ret

}
ref Vector256<short> vconvert_128x8u_to_256x16i(Vector128<byte> src, out Vector256<short> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int16>& Z0.dinx::vconvert(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Int16>&)
    IL_0007: ret

}
ref Vector256<ushort> vconvert_128x8u_to_256x16u(Vector128<byte> src, out Vector256<ushort> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt16>& Z0.dinx::vconvert(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>&)
    IL_0007: ret

}
ref Vector256<int> vconvert_128x8u_to_256x32i(Vector128<byte> src, out Vector256<int> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int32>& Z0.dinx::vconvert(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Int32>&)
    IL_0007: ret

}
ref Vector256<uint> vconvert_128x8u_to_256x32u(Vector128<byte> src, out Vector256<uint> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt32>& Z0.dinx::vconvert(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>&)
    IL_0007: ret

}
ref Vector256<long> vconvert_128x8u_to_256x64i(Vector128<byte> src, out Vector256<long> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int64>& Z0.dinx::vconvert(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Int64>&)
    IL_0007: ret

}
ref Vector256<ulong> vconvert_128x8u_to_256x64u(Vector128<byte> src, out Vector256<ulong> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt64>& Z0.dinx::vconvert(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>&)
    IL_0007: ret

}
ref Vector256<int> vconvert_128x16i_to_256x32i(Vector128<short> src, out Vector256<int> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int32>& Z0.dinx::vconvert(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int32>&)
    IL_0007: ret

}
ref Vector256<long> vconvert_128x16i_to_256x64i(Vector128<short> src, out Vector256<long> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int64>& Z0.dinx::vconvert(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int64>&)
    IL_0007: ret

}
ref Vector256<int> vconvert_128x16u_to_256x32i(Vector128<ushort> src, out Vector256<int> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int32>& Z0.dinx::vconvert(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.Int32>&)
    IL_0007: ret

}
ref Vector256<uint> vconvert_128x16u_to_256x32u(Vector128<ushort> src, out Vector256<uint> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt32>& Z0.dinx::vconvert(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>&)
    IL_0007: ret

}
ref Vector256<long> vconvert_128x16u_to_256x64i(Vector128<ushort> src, out Vector256<long> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int64>& Z0.dinx::vconvert(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.Int64>&)
    IL_0007: ret

}
ref Vector256<ulong> vconvert_128x16u_to_256x64u(Vector128<ushort> src, out Vector256<ulong> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt64>& Z0.dinx::vconvert(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>&)
    IL_0007: ret

}
ref Vector256<long> vconvert_128x32i_to_256x64i(Vector128<int> src, out Vector256<long> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int64>& Z0.dinx::vconvert(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int64>&)
    IL_0007: ret

}
ref Vector256<long> vconvert_128x32u_to_256x64i(Vector128<uint> src, out Vector256<long> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int64>& Z0.dinx::vconvert(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.Int64>&)
    IL_0007: ret

}
ref Vector256<ulong> vconvert_128x32u_to_256x64u(Vector128<uint> src, out Vector256<ulong> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt64>& Z0.dinx::vconvert(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>&)
    IL_0007: ret

}
Vector128<sbyte> vhi_128x8i(Vector256<sbyte> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.ginx::vhi<System.SByte>(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0006: ret

}
Vector128<byte> vhi_128x8u(Vector256<byte> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.ginx::vhi<System.Byte>(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0006: ret

}
Vector128<short> vhi_128x16i(Vector256<short> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.ginx::vhi<System.Int16>(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0006: ret

}
Vector128<ushort> vhi_128x16u(Vector256<ushort> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.ginx::vhi<System.UInt16>(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0006: ret

}
Vector128<int> vhi_128x32i(Vector256<int> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.ginx::vhi<System.Int32>(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0006: ret

}
Vector128<uint> vhi_128x32u(Vector256<uint> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.ginx::vhi<System.UInt32>(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0006: ret

}
Vector128<long> vhi_128x64i(Vector256<long> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.ginx::vhi<System.Int64>(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0006: ret

}
Vector128<ulong> vhi_128x64u(Vector256<ulong> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.ginx::vhi<System.UInt64>(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0006: ret

}
Vec128<sbyte> vlo_128x8i(in Vec256<sbyte> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.SByte> Z0.ginx::vlo<System.SByte>(Z0.Vec256`1<System.SByte>&)
    IL_0006: ret

}
Vec128<byte> vlo_128x8u(in Vec256<byte> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.Byte> Z0.ginx::vlo<System.Byte>(Z0.Vec256`1<System.Byte>&)
    IL_0006: ret

}
Vec128<short> vlo_128x16i(in Vec256<short> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.Int16> Z0.ginx::vlo<System.Int16>(Z0.Vec256`1<System.Int16>&)
    IL_0006: ret

}
Vec128<ushort> vlo_128x16u(in Vec256<ushort> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.UInt16> Z0.ginx::vlo<System.UInt16>(Z0.Vec256`1<System.UInt16>&)
    IL_0006: ret

}
Vec128<int> vlo_128x32i(in Vec256<int> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.Int32> Z0.ginx::vlo<System.Int32>(Z0.Vec256`1<System.Int32>&)
    IL_0006: ret

}
Vec128<uint> vlo_128x32u(in Vec256<uint> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.UInt32> Z0.ginx::vlo<System.UInt32>(Z0.Vec256`1<System.UInt32>&)
    IL_0006: ret

}
Vec128<long> vlo_128x64i(in Vec256<long> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.Int64> Z0.ginx::vlo<System.Int64>(Z0.Vec256`1<System.Int64>&)
    IL_0006: ret

}
Vec128<ulong> vlo_128x64u(in Vec256<ulong> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.UInt64> Z0.ginx::vlo<System.UInt64>(Z0.Vec256`1<System.UInt64>&)
    IL_0006: ret

}
Vec128<sbyte> loadu_d128x8i(in sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.SByte> Z0.dinx::vloadu128(System.SByte&)
    IL_0006: ret

}
Vec128<sbyte> loadu_g128x8i(in sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.SByte> Z0.ginx::vloadu128<System.SByte>(System.SByte&)
    IL_0006: ret

}
Vec128<byte> loadu_d128x8u(in byte src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.Byte> Z0.dinx::vloadu128(System.Byte&)
    IL_0006: ret

}
Vec128<byte> loadu_g128(in byte src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.Byte> Z0.ginx::vloadu128<System.Byte>(System.Byte&)
    IL_0006: ret

}
Vec128<short> loadu_d128x16i(in short src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.Int16> Z0.dinx::vloadu128(System.Int16&)
    IL_0006: ret

}
Vec128<short> loadu_g128x16i(in short src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.Int16> Z0.ginx::vloadu128<System.Int16>(System.Int16&)
    IL_0006: ret

}
Vec128<ushort> loadu_d128x16u(in ushort src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.UInt16> Z0.dinx::vloadu128(System.UInt16&)
    IL_0006: ret

}
Vec128<ushort> loadu_g128x16u(in ushort src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.UInt16> Z0.ginx::vloadu128<System.UInt16>(System.UInt16&)
    IL_0006: ret

}
Vec128<int> loadu_d128x32i(in int src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.Int32> Z0.dinx::vloadu128(System.Int32&)
    IL_0006: ret

}
Vec128<int> loadu_g128x32i(in int src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.Int32> Z0.ginx::vloadu128<System.Int32>(System.Int32&)
    IL_0006: ret

}
Vec128<uint> loadu_d128x32u(in uint src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.UInt32> Z0.dinx::vloadu128(System.UInt32&)
    IL_0006: ret

}
Vec128<uint> loadu_g128x32u(in uint src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.UInt32> Z0.ginx::vloadu128<System.UInt32>(System.UInt32&)
    IL_0006: ret

}
Vec128<long> loadu_d128x64i(in long src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.Int64> Z0.dinx::vloadu128(System.Int64&)
    IL_0006: ret

}
Vec128<long> loadu_g128x64i(in long src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.Int64> Z0.ginx::vloadu128<System.Int64>(System.Int64&)
    IL_0006: ret

}
Vec128<ulong> loadu_d128x64u(in ulong src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.UInt64> Z0.dinx::vloadu128(System.UInt64&)
    IL_0006: ret

}
Vec128<ulong> loadu_g128x64u(in ulong src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.UInt64> Z0.ginx::vloadu128<System.UInt64>(System.UInt64&)
    IL_0006: ret

}
Vec256<sbyte> loadu_d256x8i(in sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec256`1<System.SByte> Z0.dinx::vloadu256(System.SByte&)
    IL_0006: ret

}
Vec256<sbyte> loadu_g256x8i(in sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec256`1<System.SByte> Z0.ginx::vloadu256<System.SByte>(System.SByte&)
    IL_0006: ret

}
Vec256<byte> loadu_d256x8u(in byte src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec256`1<System.Byte> Z0.dinx::vloadu256(System.Byte&)
    IL_0006: ret

}
Vec256<byte> loadu_g256x8u(in byte src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec256`1<System.Byte> Z0.ginx::vloadu256<System.Byte>(System.Byte&)
    IL_0006: ret

}
Vec256<short> loadu_d256x16i(in short src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec256`1<System.Int16> Z0.dinx::vloadu256(System.Int16&)
    IL_0006: ret

}
Vec256<short> loadu_g256x16i(in short src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec256`1<System.Int16> Z0.ginx::vloadu256<System.Int16>(System.Int16&)
    IL_0006: ret

}
Vec256<ushort> loadu_d256x16u(in ushort src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec256`1<System.UInt16> Z0.dinx::vloadu256(System.UInt16&)
    IL_0006: ret

}
Vec256<ushort> loadu_g256x16u(in ushort src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec256`1<System.UInt16> Z0.ginx::vloadu256<System.UInt16>(System.UInt16&)
    IL_0006: ret

}
Vec256<int> loadu_d256x32i(in int src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec256`1<System.Int32> Z0.dinx::vloadu256(System.Int32&)
    IL_0006: ret

}
Vec256<int> loadu_g256x32i(in int src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec256`1<System.Int32> Z0.ginx::vloadu256<System.Int32>(System.Int32&)
    IL_0006: ret

}
Vec256<uint> loadu_d256x32u(in uint src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec256`1<System.UInt32> Z0.dinx::vloadu256(System.UInt32&)
    IL_0006: ret

}
Vec256<uint> loadu_g256x32u(in uint src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec256`1<System.UInt32> Z0.ginx::vloadu256<System.UInt32>(System.UInt32&)
    IL_0006: ret

}
Vec256<long> loadu_d256x64i(in long src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec256`1<System.Int64> Z0.dinx::vloadu256(System.Int64&)
    IL_0006: ret

}
Vec256<long> loadu_g256x64i(in long src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec256`1<System.Int64> Z0.ginx::vloadu256<System.Int64>(System.Int64&)
    IL_0006: ret

}
Vec256<ulong> loadu_d256x64u(in ulong src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec256`1<System.UInt64> Z0.dinx::vloadu256(System.UInt64&)
    IL_0006: ret

}
Vec256<ulong> loadu_g256x64u(in ulong src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec256`1<System.UInt64> Z0.ginx::vloadu256<System.UInt64>(System.UInt64&)
    IL_0006: ret

}
Vec256<byte> vperm2x128_d256x64u_AC(in Vec256<byte> x, in Vec256<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.2
    IL_0003: call Z0.Vec256`1<System.Byte> Z0.dinx::vperm2x128(Z0.Vec256`1<System.Byte>&,Z0.Vec256`1<System.Byte>&,Z0.Perm2x128)
    IL_0008: ret

}
Vec256<byte> vperm2x128_g256x64u_AC(in Vec256<byte> x, in Vec256<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.2
    IL_0003: call Z0.Vec256`1<System.Byte> Z0.ginx::vperm2x128<System.Byte>(Z0.Vec256`1<System.Byte>&,Z0.Vec256`1<System.Byte>&,Z0.Perm2x128)
    IL_0008: ret

}
Vec256<byte> vperm2x128_d256x64u_AD(in Vec256<byte> x, in Vec256<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.3
    IL_0003: call Z0.Vec256`1<System.Byte> Z0.dinx::vperm2x128(Z0.Vec256`1<System.Byte>&,Z0.Vec256`1<System.Byte>&,Z0.Perm2x128)
    IL_0008: ret

}
Vec256<byte> vperm2x128_g256x64u_AD(in Vec256<byte> x, in Vec256<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.3
    IL_0003: call Z0.Vec256`1<System.Byte> Z0.ginx::vperm2x128<System.Byte>(Z0.Vec256`1<System.Byte>&,Z0.Vec256`1<System.Byte>&,Z0.Perm2x128)
    IL_0008: ret

}
Vec256<byte> vperm2x128_d256x64u_BC(in Vec256<byte> x, in Vec256<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 18
    IL_0004: call Z0.Vec256`1<System.Byte> Z0.dinx::vperm2x128(Z0.Vec256`1<System.Byte>&,Z0.Vec256`1<System.Byte>&,Z0.Perm2x128)
    IL_0009: ret

}
Vec256<byte> vperm2x128_g256x64u_BC(in Vec256<byte> x, in Vec256<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 18
    IL_0004: call Z0.Vec256`1<System.Byte> Z0.ginx::vperm2x128<System.Byte>(Z0.Vec256`1<System.Byte>&,Z0.Vec256`1<System.Byte>&,Z0.Perm2x128)
    IL_0009: ret

}
Vec256<byte> vperm2x128_d256x64u_BD(in Vec256<byte> x, in Vec256<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 19
    IL_0004: call Z0.Vec256`1<System.Byte> Z0.dinx::vperm2x128(Z0.Vec256`1<System.Byte>&,Z0.Vec256`1<System.Byte>&,Z0.Perm2x128)
    IL_0009: ret

}
Vec256<byte> vperm2x128_g256x64u_BD(in Vec256<byte> x, in Vec256<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 19
    IL_0004: call Z0.Vec256`1<System.Byte> Z0.ginx::vperm2x128<System.Byte>(Z0.Vec256`1<System.Byte>&,Z0.Vec256`1<System.Byte>&,Z0.Perm2x128)
    IL_0009: ret

}
Vec256<byte> vperm2x128_d256x64u_CA(in Vec256<byte> x, in Vec256<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 32
    IL_0004: call Z0.Vec256`1<System.Byte> Z0.dinx::vperm2x128(Z0.Vec256`1<System.Byte>&,Z0.Vec256`1<System.Byte>&,Z0.Perm2x128)
    IL_0009: ret

}
Vec256<byte> vperm2x128_g256x64u_CA(in Vec256<byte> x, in Vec256<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 32
    IL_0004: call Z0.Vec256`1<System.Byte> Z0.ginx::vperm2x128<System.Byte>(Z0.Vec256`1<System.Byte>&,Z0.Vec256`1<System.Byte>&,Z0.Perm2x128)
    IL_0009: ret

}
Vec256<byte> vperm2x128_d256x64u_CB(in Vec256<byte> x, in Vec256<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 33
    IL_0004: call Z0.Vec256`1<System.Byte> Z0.dinx::vperm2x128(Z0.Vec256`1<System.Byte>&,Z0.Vec256`1<System.Byte>&,Z0.Perm2x128)
    IL_0009: ret

}
Vec256<byte> vperm2x128_g256x64u_CB(in Vec256<byte> x, in Vec256<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 33
    IL_0004: call Z0.Vec256`1<System.Byte> Z0.ginx::vperm2x128<System.Byte>(Z0.Vec256`1<System.Byte>&,Z0.Vec256`1<System.Byte>&,Z0.Perm2x128)
    IL_0009: ret

}
Vec256<byte> vperm2x128_d256x64u_DA(in Vec256<byte> x, in Vec256<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 48
    IL_0004: call Z0.Vec256`1<System.Byte> Z0.dinx::vperm2x128(Z0.Vec256`1<System.Byte>&,Z0.Vec256`1<System.Byte>&,Z0.Perm2x128)
    IL_0009: ret

}
Vec256<byte> vperm2x128_g256x64u_DA(in Vec256<byte> x, in Vec256<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 48
    IL_0004: call Z0.Vec256`1<System.Byte> Z0.ginx::vperm2x128<System.Byte>(Z0.Vec256`1<System.Byte>&,Z0.Vec256`1<System.Byte>&,Z0.Perm2x128)
    IL_0009: ret

}
Vec256<byte> vperm2x128_d256x64u_DB(in Vec256<byte> x, in Vec256<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 49
    IL_0004: call Z0.Vec256`1<System.Byte> Z0.dinx::vperm2x128(Z0.Vec256`1<System.Byte>&,Z0.Vec256`1<System.Byte>&,Z0.Perm2x128)
    IL_0009: ret

}
Vec256<byte> vperm2x128_g256x64u_DB(in Vec256<byte> x, in Vec256<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 49
    IL_0004: call Z0.Vec256`1<System.Byte> Z0.ginx::vperm2x128<System.Byte>(Z0.Vec256`1<System.Byte>&,Z0.Vec256`1<System.Byte>&,Z0.Perm2x128)
    IL_0009: ret

}
Vec256<long> vperm2x128_d256x64u_AC(in Vec256<long> x, in Vec256<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.2
    IL_0003: call Z0.Vec256`1<System.Int64> Z0.dinx::vperm2x128(Z0.Vec256`1<System.Int64>&,Z0.Vec256`1<System.Int64>&,Z0.Perm2x128)
    IL_0008: ret

}
Vec256<long> vperm2x128_g256x64u_AC(in Vec256<long> x, in Vec256<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.2
    IL_0003: call Z0.Vec256`1<System.Int64> Z0.ginx::vperm2x128<System.Int64>(Z0.Vec256`1<System.Int64>&,Z0.Vec256`1<System.Int64>&,Z0.Perm2x128)
    IL_0008: ret

}
Vec256<long> vperm2x128_d256x64u_AD(in Vec256<long> x, in Vec256<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.3
    IL_0003: call Z0.Vec256`1<System.Int64> Z0.dinx::vperm2x128(Z0.Vec256`1<System.Int64>&,Z0.Vec256`1<System.Int64>&,Z0.Perm2x128)
    IL_0008: ret

}
Vec256<long> vperm2x128_g256x64u_AD(in Vec256<long> x, in Vec256<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.3
    IL_0003: call Z0.Vec256`1<System.Int64> Z0.ginx::vperm2x128<System.Int64>(Z0.Vec256`1<System.Int64>&,Z0.Vec256`1<System.Int64>&,Z0.Perm2x128)
    IL_0008: ret

}
