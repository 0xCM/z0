// 2019-10-29 02:32:28:479
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
Vector128<short> vblend_128x16u_LLLLLLLL(Vector128<short> x, Vector128<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.0
    IL_0003: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.dinx::vblend(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>,Z0.Blend16x8)
    IL_0008: ret

}
Vector128<short> vblend_128x16u_RRRRRRRR(Vector128<short> x, Vector128<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4 255
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.dinx::vblend(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>,Z0.Blend16x8)
    IL_000C: ret

}
Vector128<short> vblend_128x16u_LLLLRRRR(Vector128<short> x, Vector128<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4 240
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.dinx::vblend(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>,Z0.Blend16x8)
    IL_000C: ret

}
Vector128<short> vblend_128x16u_RRRRLLLL(Vector128<short> x, Vector128<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 15
    IL_0004: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.dinx::vblend(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>,Z0.Blend16x8)
    IL_0009: ret

}
Vector128<short> vblend_128x16u_LRLRLRLR(Vector128<short> x, Vector128<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4 170
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.dinx::vblend(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>,Z0.Blend16x8)
    IL_000C: ret

}
Vector128<short> vblend_128x16u_RLRLRLRL(Vector128<short> x, Vector128<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 85
    IL_0004: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.dinx::vblend(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>,Z0.Blend16x8)
    IL_0009: ret

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
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.dinx::vshuffle(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0007: ret

}
Vector128<sbyte> vshuffle_128x8i(Vector128<sbyte> src, Vector128<sbyte> spec)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.dinx::vshuffle(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0007: ret

}
Vector256<byte> vshuffle_256x8u(Vector256<byte> src, Vector256<byte> spec)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.dinx::vshuffle(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0007: ret

}
Vector256<sbyte> vshuffle_256x8i(Vector256<sbyte> src, Vector256<sbyte> spec)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.dinx::vshuffle(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0007: ret

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
bool vtestz_d128x8i(Vector128<sbyte> src, Vector128<sbyte> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.dinx::vtestz(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0007: ret

}
bool vtestz_g128x8i(Vector128<sbyte> src, Vector128<sbyte> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.ginx::vtestz<System.SByte>(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0007: ret

}
bool vtestz_d128x8u(Vector128<byte> src, Vector128<byte> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.dinx::vtestz(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0007: ret

}
bool vtestz_g128x8u(Vector128<byte> src, Vector128<byte> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.ginx::vtestz<System.Byte>(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0007: ret

}
bool vtestz_d128x16i(Vector128<short> src, Vector128<short> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.dinx::vtestz(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0007: ret

}
bool vtestz_g128x16i(Vector128<short> src, Vector128<short> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.ginx::vtestz<System.Int16>(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0007: ret

}
bool vtestz_d128x16u(Vector128<ushort> src, Vector128<ushort> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.dinx::vtestz(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0007: ret

}
bool vtestz_g128x16u(Vector128<ushort> src, Vector128<ushort> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.ginx::vtestz<System.UInt16>(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0007: ret

}
bool vtestz_d128x32i(Vector128<int> src, Vector128<int> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.dinx::vtestz(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0007: ret

}
bool vtestz_g128x32i(Vector128<int> src, Vector128<int> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.ginx::vtestz<System.Int32>(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0007: ret

}
bool vtestz_d128x32u(Vector128<uint> src, Vector128<uint> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.dinx::vtestz(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0007: ret

}
bool vtestz_g128x32u(Vector128<uint> src, Vector128<uint> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.ginx::vtestz<System.UInt32>(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0007: ret

}
bool vtestz_d128x64i(Vector128<long> src, Vector128<long> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.dinx::vtestz(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0007: ret

}
bool vtestz_g128x64i(Vector128<long> src, Vector128<long> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.ginx::vtestz<System.Int64>(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0007: ret

}
bool vtestz_d128x64u(Vector128<ulong> src, Vector128<ulong> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.dinx::vtestz(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0007: ret

}
bool vtestz_g128x64u(Vector128<ulong> src, Vector128<ulong> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.ginx::vtestz<System.UInt64>(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0007: ret

}
bool vtestz_d256x8i(Vector256<sbyte> src, Vector256<sbyte> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.dinx::vtestz(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0007: ret

}
bool vtestz_g256x8i(Vector256<sbyte> src, Vector256<sbyte> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.ginx::vtestz<System.SByte>(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0007: ret

}
bool vtestz_d256x8u(Vector256<byte> src, Vector256<byte> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.dinx::vtestz(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0007: ret

}
bool vtestz_g256x8u(Vector256<byte> src, Vector256<byte> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.ginx::vtestz<System.Byte>(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0007: ret

}
bool vtestz_d256x16i(Vector256<short> src, Vector256<short> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.dinx::vtestz(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0007: ret

}
bool vtestz_g256x16i(Vector256<short> src, Vector256<short> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.ginx::vtestz<System.Int16>(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0007: ret

}
bool vtestz_d256x16u(Vector256<ushort> src, Vector256<ushort> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.dinx::vtestz(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0007: ret

}
bool vtestz_g256x16u(Vector256<ushort> src, Vector256<ushort> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.ginx::vtestz<System.UInt16>(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0007: ret

}
bool vtestz_d256x32i(Vector256<int> src, Vector256<int> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.dinx::vtestz(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0007: ret

}
bool vtestz_g256x32i(Vector256<int> src, Vector256<int> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.ginx::vtestz<System.Int32>(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0007: ret

}
bool vtestz_d256x32u(Vector256<uint> src, Vector256<uint> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.dinx::vtestz(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0007: ret

}
bool vtestz_g256x32u(Vector256<uint> src, Vector256<uint> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.ginx::vtestz<System.UInt32>(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0007: ret

}
bool vtestz_d256x64i(Vector256<long> src, Vector256<long> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.dinx::vtestz(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0007: ret

}
bool vtestz_g256x64i(Vector256<long> src, Vector256<long> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.ginx::vtestz<System.Int64>(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0007: ret

}
bool vtestz_d256x64u(Vector256<ulong> src, Vector256<ulong> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.dinx::vtestz(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0007: ret

}
bool vtestz_g256x64u(Vector256<ulong> src, Vector256<ulong> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.ginx::vtestz<System.UInt64>(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0007: ret

}
Vector128<byte> ones_128x8u()
{
    IL_0000: call Z0.N128 zfunc::get_n128()
    IL_0005: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.ginx::vpOnes<System.Byte>(Z0.N128)
    IL_000A: ret

}
Vector128<ulong> ones_128x64u()
{
    IL_0000: call Z0.N128 zfunc::get_n128()
    IL_0005: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.ginx::vpOnes<System.UInt64>(Z0.N128)
    IL_000A: ret

}
Vector256<byte> ones_256x8u()
{
    IL_0000: call Z0.N256 zfunc::get_n256()
    IL_0005: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.ginx::vpOnes<System.Byte>(Z0.N256)
    IL_000A: ret

}
Vector256<ulong> ones_256x64u()
{
    IL_0000: call Z0.N256 zfunc::get_n256()
    IL_0005: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.ginx::vpOnes<System.UInt64>(Z0.N256)
    IL_000A: ret

}
Vector256<double> ones_256x64f()
{
    IL_0000: call Z0.N256 zfunc::get_n256()
    IL_0005: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.ginx::vpOnes<System.Double>(Z0.N256)
    IL_000A: ret

}
Vector256<byte> pattern_lanemerge_256x8u()
{
    IL_0000: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.ginx::vpLaneMerge<System.Byte>()
    IL_0005: ret

}
Vector256<ushort> pattern_lanemerge_256x16u()
{
    IL_0000: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.ginx::vpLaneMerge<System.UInt16>()
    IL_0005: ret

}
