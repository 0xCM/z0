// 2019-12-10 01:42:50:378
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
Vector256<ushort> vmerge16(Vector128<ushort> x, Vector128<ushort> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4 204
    IL_0007: ldc.i4.s 51
    IL_0009: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.dinx::vmerge(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>,Z0.Blend8x16,Z0.Blend8x16)
    IL_000E: ret

}
Vector256<uint> vmerge32(Vector128<uint> x, Vector128<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 12
    IL_0004: ldc.i4.s 12
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.dinx::vmerge(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>,Z0.Blend4x32,Z0.Blend4x32)
    IL_000B: ret

}
Vector256<ulong> vmerge64(Vector128<ulong> x, Vector128<ulong> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.2
    IL_0003: ldc.i4.1
    IL_0004: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::vmerge(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>,Z0.Blend2x64,Z0.Blend2x64)
    IL_0009: ret

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
Vector128<short> vblend_128x16u_LLLLLLLL(Vector128<short> x, Vector128<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.0
    IL_0003: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.dinx::vblend(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>,Z0.Blend8x16)
    IL_0008: ret

}
Vector128<short> vblend_128x16u_RRRRRRRR(Vector128<short> x, Vector128<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4 255
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.dinx::vblend(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>,Z0.Blend8x16)
    IL_000C: ret

}
Vector128<short> vblend_128x16u_LLLLRRRR(Vector128<short> x, Vector128<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4 240
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.dinx::vblend(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>,Z0.Blend8x16)
    IL_000C: ret

}
Vector128<short> vblend_128x16u_RRRRLLLL(Vector128<short> x, Vector128<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 15
    IL_0004: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.dinx::vblend(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>,Z0.Blend8x16)
    IL_0009: ret

}
Vector128<short> vblend_128x16u_LRLRLRLR(Vector128<short> x, Vector128<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4 170
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.dinx::vblend(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>,Z0.Blend8x16)
    IL_000C: ret

}
Vector128<short> vblend_128x16u_RLRLRLRL(Vector128<short> x, Vector128<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 85
    IL_0004: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.dinx::vblend(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>,Z0.Blend8x16)
    IL_0009: ret

}
void xor_block256(ConstBlock256<uint> xs, ConstBlock256<uint> ys, Block256<uint> zs)
{
    IL_0000: ldarga.s xs
    IL_0002: ldarga.s ys
    IL_0004: ldarga.s zs
    IL_0006: call System.Void Z0.vblock::xor<System.UInt32>(Z0.ConstBlock256`1<System.UInt32>&,Z0.ConstBlock256`1<System.UInt32>&,Z0.Block256`1<System.UInt32>&)
    IL_000B: ret

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
Vector128<byte> vsll8_128(Vector128<byte> src, byte shift)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.dinx::vsll8(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Byte)
    IL_0007: ret

}
Vector256<byte> vsll8_256(Vector256<byte> src, byte shift)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.dinx::vsll8(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Byte)
    IL_0007: ret

}
Vector128<byte> msb_mask_v128()
{
    IL_0000: call Z0.N128 zfunc::get_n128()
    IL_0005: call Z0.N8 zfunc::get_n8()
    IL_000A: ldc.i4.4
    IL_000B: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.vmask::msb<System.Byte>(Z0.N128,Z0.N8,System.Byte)
    IL_0010: ret

}
Vector128<byte> msb_mask_v128_2(int n)
{
    IL_0000: call Z0.N128 zfunc::get_n128()
    IL_0005: ldc.i4 255
    IL_000A: conv.i8
    IL_000B: ldarg.0
    IL_000C: call System.UInt64 Z0.Bits::lomask(System.Int32)
    IL_0011: xor
    IL_0012: conv.u1
    IL_0013: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.ginx::vbroadcast<System.Byte>(Z0.N128,System.Byte)
    IL_0018: ret

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
ulong vcell_0_256x64u(Vector256<ulong> src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: call System.UInt64 zfunc::vcell<System.UInt64>(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Int32)
    IL_0007: ret

}
ulong vcell_1_256x64u(Vector256<ulong> src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0002: call System.UInt64 zfunc::vcell<System.UInt64>(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Int32)
    IL_0007: ret

}
ulong vcell_1_128x8u(Vector128<byte> src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0002: call System.Byte zfunc::vcell<System.Byte>(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Int32)
    IL_0007: conv.u8
    IL_0008: ret

}
ulong vcell_2_256x64u(Vector256<ulong> src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.2
    IL_0002: call System.UInt64 zfunc::vcell<System.UInt64>(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Int32)
    IL_0007: ret

}
byte vcell_3_256x64u(Vector256<byte> src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.3
    IL_0002: call System.Byte zfunc::vcell<System.Byte>(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Int32)
    IL_0007: ret

}
uint vcell_256x32u_1(Vector256<uint> src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0002: call System.UInt32 zfunc::vcell<System.UInt32>(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Int32)
    IL_0007: ret

}
uint vcell_256x32u_2(Vector256<uint> src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.2
    IL_0002: call System.UInt32 zfunc::vcell<System.UInt32>(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Int32)
    IL_0007: ret

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
Vector128<byte> vmov_idx3_128x8u(byte src, Vector128<byte> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.3
    IL_0002: ldarg.1
    IL_0003: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.ginx::vinsertcell<System.Byte>(System.Byte,System.Int32,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0008: ret

}
Vector128<ushort> vmov_idx4_128x16u(ushort src, Vector128<ushort> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.4
    IL_0002: ldarg.1
    IL_0003: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.ginx::vinsertcell<System.UInt16>(System.UInt16,System.Int32,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0008: ret

}
Vector128<uint> vmov_idx2_128x32u(uint src, Vector128<uint> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.2
    IL_0002: ldarg.1
    IL_0003: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.ginx::vinsertcell<System.UInt32>(System.UInt32,System.Int32,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0008: ret

}
Vector256<byte> vmov_idx3_256x8u(byte src, Vector256<byte> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.3
    IL_0002: ldarg.1
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.ginx::vinsertcell<System.Byte>(System.Byte,System.Int32,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0008: ret

}
Vector256<ushort> vmov_idx4_256x16u(ushort src, Vector256<ushort> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.4
    IL_0002: ldarg.1
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.ginx::vinsertcell<System.UInt16>(System.UInt16,System.Int32,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0008: ret

}
Vector256<uint> vmov_idx2_256x32u(uint src, Vector256<uint> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.2
    IL_0002: ldarg.1
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.ginx::vinsertcell<System.UInt32>(System.UInt32,System.Int32,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0008: ret

}
Vector256<uint> vmov_idx4x2_256x32u(uint a, uint b, Vector256<uint> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldc.i4.4
    IL_0002: ldarg.0
    IL_0003: ldc.i4.2
    IL_0004: ldarg.2
    IL_0005: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.ginx::vinsertcell<System.UInt32>(System.UInt32,System.Int32,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_000A: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.ginx::vinsertcell<System.UInt32>(System.UInt32,System.Int32,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_000F: ret

}
Vector128<byte> vmov128x8u(byte src)
{
    IL_0000: call Z0.N128 zfunc::get_n128()
    IL_0005: ldarg.0
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.ginx::vscalar<System.Byte>(Z0.N128,System.Byte)
    IL_000B: ret

}
Vector128<ushort> vmov128x16u(ushort src)
{
    IL_0000: call Z0.N128 zfunc::get_n128()
    IL_0005: ldarg.0
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.ginx::vscalar<System.UInt16>(Z0.N128,System.UInt16)
    IL_000B: ret

}
Vector128<uint> vmov128x32u(uint src)
{
    IL_0000: call Z0.N128 zfunc::get_n128()
    IL_0005: ldarg.0
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.ginx::vscalar<System.UInt32>(Z0.N128,System.UInt32)
    IL_000B: ret

}
Vector128<ulong> vmov128x64u(ulong src)
{
    IL_0000: call Z0.N128 zfunc::get_n128()
    IL_0005: ldarg.0
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.ginx::vscalar<System.UInt64>(Z0.N128,System.UInt64)
    IL_000B: ret

}
Vector128<double> vmov128x64u(double src)
{
    IL_0000: call Z0.N128 zfunc::get_n128()
    IL_0005: ldarg.0
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.ginx::vscalar<System.Double>(Z0.N128,System.Double)
    IL_000B: ret

}
Vector256<byte> vmov256x8u(byte src)
{
    IL_0000: call Z0.N256 zfunc::get_n256()
    IL_0005: ldarg.0
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.ginx::vscalar<System.Byte>(Z0.N256,System.Byte)
    IL_000B: ret

}
Vector256<ushort> vmov256x16u(ushort src)
{
    IL_0000: call Z0.N256 zfunc::get_n256()
    IL_0005: ldarg.0
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.ginx::vscalar<System.UInt16>(Z0.N256,System.UInt16)
    IL_000B: ret

}
Vector256<uint> vmov256x32u(uint src)
{
    IL_0000: call Z0.N256 zfunc::get_n256()
    IL_0005: ldarg.0
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.ginx::vscalar<System.UInt32>(Z0.N256,System.UInt32)
    IL_000B: ret

}
Vector256<ulong> vmov256x64u(ulong src)
{
    IL_0000: call Z0.N256 zfunc::get_n256()
    IL_0005: ldarg.0
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.ginx::vscalar<System.UInt64>(Z0.N256,System.UInt64)
    IL_000B: ret

}
Vector256<double> vmov256x64u(double src)
{
    IL_0000: call Z0.N256 zfunc::get_n256()
    IL_0005: ldarg.0
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.ginx::vscalar<System.Double>(Z0.N256,System.Double)
    IL_000B: ret

}
void vconvert_v256x16u_v2x256x64u(Vector256<ushort> src, out Vector256<ulong> lo, out Vector256<ulong> hi)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.Void Z0.dinx::vconvert(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>&,System.Runtime.Intrinsics.Vector256`1<System.UInt64>&)
    IL_0008: ret

}
Vector256<ulong> vconvert_xspan32u_v256x64u(Block128<uint> src, out Vector256<ulong> dst)
{
    IL_0000: ldarga.s src
    IL_0002: call Z0.ConstBlock128`1<System.UInt32> Z0.Block128`1<System.UInt32>::op_Implicit(Z0.Block128`1<System.UInt32>&)
    IL_0007: stloc.0
    IL_0008: ldloca.s V_0
    IL_000A: ldarg.1
    IL_000B: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::vloadblock(Z0.ConstBlock128`1<System.UInt32>&,System.Runtime.Intrinsics.Vector256`1<System.UInt64>&)
    IL_0010: ret

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
    IL_0000: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.ginx::vplanemerge<System.Byte>()
    IL_0005: ret

}
Vector256<ushort> pattern_lanemerge_256x16u()
{
    IL_0000: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.ginx::vplanemerge<System.UInt16>()
    IL_0005: ret

}
Vector128<ushort> vbswap_128x16u(Vector128<ushort> x)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.dinx::vbyteswap(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0006: ret

}
Vector256<int> vpermvar8x32_256x32i(Vector256<int> src, Vector256<uint> spec)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.dinx::vperm8x32(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
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
Vector128<byte> vsllx_128x8u(Vector128<byte> x)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.s 15
    IL_0003: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.ginx::vsllx<System.Byte>(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Byte)
    IL_0008: ret

}
Vector128<ushort> vsllx_128x16u(Vector128<ushort> x)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.s 15
    IL_0003: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.ginx::vsllx<System.UInt16>(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Byte)
    IL_0008: ret

}
Vector128<uint> vsllx_128x32u(Vector128<uint> x)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.s 15
    IL_0003: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.ginx::vsllx<System.UInt32>(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Byte)
    IL_0008: ret

}
Vector128<ulong> vsllx_128x64u(Vector128<ulong> x)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.8
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.ginx::vsllx<System.UInt64>(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Byte)
    IL_0007: ret

}
Vector256<byte> vsllx_256x8u(Vector256<byte> x)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.s 13
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.ginx::vsllx<System.Byte>(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Byte)
    IL_0008: ret

}
Vector256<ulong> vsllx_256x64u(Vector256<ulong> x)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.s 13
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.ginx::vsllx<System.UInt64>(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Byte)
    IL_0008: ret

}
Vector128<byte> vsrlx_128x8u(Vector128<byte> x)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.8
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.dinx::vsrlx(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Byte)
    IL_0007: ret

}
Vector128<ulong> vsrlx_128x64u(Vector128<ulong> x)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.8
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.ginx::vsrlx<System.UInt64>(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Byte)
    IL_0007: ret

}
Vector256<ulong> vsrlx_256(Vector256<ulong> x)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.s 13
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.ginx::vsrlx<System.UInt64>(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Byte)
    IL_0008: ret

}
Vector128<ulong> vrotlx_128x64u(Vector128<ulong> x)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.s 14
    IL_0003: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.ginx::vrotlx<System.UInt64>(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Byte)
    IL_0008: ret

}
Vector256<ulong> vrotlx_256x64u(Vector256<ulong> x)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.s 14
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.ginx::vrotlx<System.UInt64>(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Byte)
    IL_0008: ret

}
Vector128<byte> rotl_g128x8u(Vector128<byte> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.ginx::vrotl<System.Byte>(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Byte)
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
bool vtestz_g128x64i(Vector128<long> src, Vector128<long> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.ginx::vtestz<System.Int64>(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret

}
