// 2019-10-01 10:52:13:936
Vector128<uint> vor_n128x32u(Vector128<uint> x, Vector128<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::And(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0007: ret

}
Vec128<uint> vor_d128x32u(Vec128<uint> x, Vec128<uint> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec128`1<System.UInt32> Z0.dinx::vor(Z0.Vec128`1<System.UInt32>&,Z0.Vec128`1<System.UInt32>&)
    IL_0009: ret

}
Vec128<uint> vor_g128x32u(Vec128<uint> x, Vec128<uint> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec128`1<System.UInt32> Z0.ginx::vor<System.UInt32>(Z0.Vec128`1<System.UInt32>&,Z0.Vec128`1<System.UInt32>&)
    IL_0009: ret

}
Vector128<long> vor_n128x64i(Vector128<long> x, Vector128<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse2::And(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0007: ret

}
Vec128<long> vor_d128x64i(Vec128<long> x, Vec128<long> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec128`1<System.Int64> Z0.dinx::vor(Z0.Vec128`1<System.Int64>&,Z0.Vec128`1<System.Int64>&)
    IL_0009: ret

}
Vec128<long> vor_g128x64i(Vec128<long> x, Vec128<long> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec128`1<System.Int64> Z0.ginx::vor<System.Int64>(Z0.Vec128`1<System.Int64>&,Z0.Vec128`1<System.Int64>&)
    IL_0009: ret

}
Vector128<ulong> vor_n128x64u(Vector128<ulong> x, Vector128<ulong> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::And(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0007: ret

}
Vec128<ulong> vor_d128x64u(Vec128<ulong> x, Vec128<ulong> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec128`1<System.UInt64> Z0.dinx::vor(Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&)
    IL_0009: ret

}
Vec128<ulong> vor_g128x64u(Vec128<ulong> x, Vec128<ulong> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec128`1<System.UInt64> Z0.ginx::vor<System.UInt64>(Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&)
    IL_0009: ret

}
Vector256<sbyte> vor_n256x8i(Vector256<sbyte> x, Vector256<sbyte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::And(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0007: ret

}
Vec256<sbyte> vor_d256x8i(Vec256<sbyte> x, Vec256<sbyte> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec256`1<System.SByte> Z0.dinx::vor(Z0.Vec256`1<System.SByte>&,Z0.Vec256`1<System.SByte>&)
    IL_0009: ret

}
Vec256<sbyte> vor_g256x8i(Vec256<sbyte> x, Vec256<sbyte> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec256`1<System.SByte> Z0.ginx::vor<System.SByte>(Z0.Vec256`1<System.SByte>&,Z0.Vec256`1<System.SByte>&)
    IL_0009: ret

}
Vector256<byte> vor_n256x8u(Vector256<byte> x, Vector256<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::And(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0007: ret

}
Vec256<byte> vor_d256x8u(Vec256<byte> x, Vec256<byte> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec256`1<System.Byte> Z0.dinx::vor(Z0.Vec256`1<System.Byte>&,Z0.Vec256`1<System.Byte>&)
    IL_0009: ret

}
Vec256<byte> vor_g256x8u(Vec256<byte> x, Vec256<byte> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec256`1<System.Byte> Z0.ginx::vor<System.Byte>(Z0.Vec256`1<System.Byte>&,Z0.Vec256`1<System.Byte>&)
    IL_0009: ret

}
Vector256<short> vor_n256x16i(Vector256<short> x, Vector256<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::And(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0007: ret

}
Vec256<short> vor_d256x16i(Vec256<short> x, Vec256<short> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec256`1<System.Int16> Z0.dinx::vor(Z0.Vec256`1<System.Int16>&,Z0.Vec256`1<System.Int16>&)
    IL_0009: ret

}
Vec256<short> vor_g256x16i(Vec256<short> x, Vec256<short> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec256`1<System.Int16> Z0.ginx::vor<System.Int16>(Z0.Vec256`1<System.Int16>&,Z0.Vec256`1<System.Int16>&)
    IL_0009: ret

}
Vector256<ushort> vor_n256x16u(Vector256<ushort> x, Vector256<ushort> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::And(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0007: ret

}
Vec256<ushort> vor_d256x16u(Vec256<ushort> x, Vec256<ushort> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec256`1<System.UInt16> Z0.dinx::vor(Z0.Vec256`1<System.UInt16>&,Z0.Vec256`1<System.UInt16>&)
    IL_0009: ret

}
Vec256<ushort> vor_g256x16u(Vec256<ushort> x, Vec256<ushort> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec256`1<System.UInt16> Z0.ginx::vor<System.UInt16>(Z0.Vec256`1<System.UInt16>&,Z0.Vec256`1<System.UInt16>&)
    IL_0009: ret

}
Vector256<int> vor_n256x32i(Vector256<int> x, Vector256<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::And(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0007: ret

}
Vec256<int> vor_d256x32i(Vec256<int> x, Vec256<int> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec256`1<System.Int32> Z0.dinx::vor(Z0.Vec256`1<System.Int32>&,Z0.Vec256`1<System.Int32>&)
    IL_0009: ret

}
Vec256<int> vor_g256x32i(Vec256<int> x, Vec256<int> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec256`1<System.Int32> Z0.ginx::vor<System.Int32>(Z0.Vec256`1<System.Int32>&,Z0.Vec256`1<System.Int32>&)
    IL_0009: ret

}
Vector256<uint> vor_n256x32u(Vector256<uint> x, Vector256<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::And(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0007: ret

}
Vec256<uint> vor_d256x32u(Vec256<uint> x, Vec256<uint> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec256`1<System.UInt32> Z0.dinx::vor(Z0.Vec256`1<System.UInt32>&,Z0.Vec256`1<System.UInt32>&)
    IL_0009: ret

}
Vec256<uint> vor_g256x32u(Vec256<uint> x, Vec256<uint> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec256`1<System.UInt32> Z0.ginx::vor<System.UInt32>(Z0.Vec256`1<System.UInt32>&,Z0.Vec256`1<System.UInt32>&)
    IL_0009: ret

}
Vector256<long> vor_n256x64i(Vector256<long> x, Vector256<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::And(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0007: ret

}
Vec256<long> vor_d256x64i(Vec256<long> x, Vec256<long> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec256`1<System.Int64> Z0.dinx::vor(Z0.Vec256`1<System.Int64>&,Z0.Vec256`1<System.Int64>&)
    IL_0009: ret

}
Vec256<long> vor_g256x64i(Vec256<long> x, Vec256<long> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec256`1<System.Int64> Z0.ginx::vor<System.Int64>(Z0.Vec256`1<System.Int64>&,Z0.Vec256`1<System.Int64>&)
    IL_0009: ret

}
Vector256<ulong> vor_n256x64u(Vector256<ulong> x, Vector256<ulong> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::And(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0007: ret

}
Vec256<ulong> vor_d256x64u(Vec256<ulong> x, Vec256<ulong> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec256`1<System.UInt64> Z0.dinx::vor(Z0.Vec256`1<System.UInt64>&,Z0.Vec256`1<System.UInt64>&)
    IL_0009: ret

}
Vec256<ulong> vor_g256x64u(Vec256<ulong> x, Vec256<ulong> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec256`1<System.UInt64> Z0.ginx::vor<System.UInt64>(Z0.Vec256`1<System.UInt64>&,Z0.Vec256`1<System.UInt64>&)
    IL_0009: ret

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
Vec256<ulong> perm4x64(Vec256<ulong> src, uint x0, uint x1, uint x2, uint x3)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.2
    IL_0002: or
    IL_0003: ldarg.3
    IL_0004: or
    IL_0005: ldarg.s x3
    IL_0007: or
    IL_0008: conv.u1
    IL_0009: stloc.0
    IL_000A: ldarg.0
    IL_000B: ldloc.0
    IL_000C: call Z0.Vec256`1<System.UInt64> Z0.inxvoc::perm4x64(Z0.Vec256`1<System.UInt64>,Z0.Perm4)
    IL_0011: ret

}
Vec256<ulong> perm4x64(Vec256<ulong> src, Perm4:byte spec)
{
    IL_0000: ldarg.1
    IL_0001: ldc.i4 156
    IL_0006: bgt.un.s IL_0036
    IL_0008: ldarg.1
    IL_0009: ldc.i4.s 108
    IL_000B: bgt.un.s IL_001F
    IL_000D: ldarg.1
    IL_000E: ldc.i4.s 45
    IL_0010: beq IL_00A0
    IL_0015: ldarg.1
    IL_0016: ldc.i4.s 108
    IL_0018: beq.s IL_0084
    IL_001A: br IL_00AE
    IL_001F: ldarg.1
    IL_0020: ldc.i4.s 120
    IL_0022: beq.s IL_0076
    IL_0024: ldarg.1
    IL_0025: ldc.i4 141
    IL_002A: beq.s IL_00A7
    IL_002C: ldarg.1
    IL_002D: ldc.i4 156
    IL_0032: beq.s IL_007D
    IL_0034: br.s IL_00AE
    IL_0036: ldarg.1
    IL_0037: ldc.i4 201
    IL_003C: bgt.un.s IL_0050
    IL_003E: ldarg.1
    IL_003F: ldc.i4 177
    IL_0044: beq.s IL_0092
    IL_0046: ldarg.1
    IL_0047: ldc.i4 201
    IL_004C: beq.s IL_0099
    IL_004E: br.s IL_00AE
    IL_0050: ldarg.1
    IL_0051: ldc.i4 216
    IL_0056: beq.s IL_006F
    IL_0058: ldarg.1
    IL_0059: ldc.i4 225
    IL_005E: beq.s IL_008B
    IL_0060: ldarg.1
    IL_0061: ldc.i4 228
    IL_0066: bne.un.s IL_00AE
    IL_0068: ldarg.0
    IL_0069: call Z0.Vec256`1<System.UInt64> Z0.dinx::perm4x64_ABCD(Z0.Vec256`1<System.UInt64>)
    IL_006E: ret
    IL_006F: ldarg.0
    IL_0070: call Z0.Vec256`1<System.UInt64> Z0.dinx::perm4x64_ACBD(Z0.Vec256`1<System.UInt64>)
    IL_0075: ret
    IL_0076: ldarg.0
    IL_0077: call Z0.Vec256`1<System.UInt64> Z0.dinx::perm4x64_ACDB(Z0.Vec256`1<System.UInt64>)
    IL_007C: ret
    IL_007D: ldarg.0
    IL_007E: call Z0.Vec256`1<System.UInt64> Z0.dinx::perm4x64_ADBC(Z0.Vec256`1<System.UInt64>)
    IL_0083: ret
    IL_0084: ldarg.0
    IL_0085: call Z0.Vec256`1<System.UInt64> Z0.dinx::perm4x64_ADCB(Z0.Vec256`1<System.UInt64>)
    IL_008A: ret
    IL_008B: ldarg.0
    IL_008C: call Z0.Vec256`1<System.UInt64> Z0.dinx::perm4x64_BACD(Z0.Vec256`1<System.UInt64>)
    IL_0091: ret
    IL_0092: ldarg.0
    IL_0093: call Z0.Vec256`1<System.UInt64> Z0.dinx::perm4x64_BADC(Z0.Vec256`1<System.UInt64>)
    IL_0098: ret
    IL_0099: ldarg.0
    IL_009A: call Z0.Vec256`1<System.UInt64> Z0.dinx::perm4x64_BCAD(Z0.Vec256`1<System.UInt64>)
    IL_009F: ret
    IL_00A0: ldarg.0
    IL_00A1: call Z0.Vec256`1<System.UInt64> Z0.dinx::perm4x64_BDCA(Z0.Vec256`1<System.UInt64>)
    IL_00A6: ret
    IL_00A7: ldarg.0
    IL_00A8: call Z0.Vec256`1<System.UInt64> Z0.dinx::perm4x64_BDAC(Z0.Vec256`1<System.UInt64>)
    IL_00AD: ret
    IL_00AE: ldloca.s V_0
    IL_00B0: initobj Z0.Vec256`1<System.UInt64>
    IL_00B6: ldloc.0
    IL_00B7: ret

}
Vector128<sbyte> vand_n128x8i(Vector128<sbyte> x, Vector128<sbyte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::And(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0007: ret

}
Vec128<sbyte> vand_d128x8i(Vec128<sbyte> x, Vec128<sbyte> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec128`1<System.SByte> Z0.dinx::vand(Z0.Vec128`1<System.SByte>&,Z0.Vec128`1<System.SByte>&)
    IL_0009: ret

}
Vec128<sbyte> vand_g128x8i(Vec128<sbyte> x, Vec128<sbyte> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec128`1<System.SByte> Z0.ginx::vand<System.SByte>(Z0.Vec128`1<System.SByte>&,Z0.Vec128`1<System.SByte>&)
    IL_0009: ret

}
Vector128<byte> vand_n128x8u(Vector128<byte> x, Vector128<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::And(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0007: ret

}
Vec128<byte> vand_d128x8u(Vec128<byte> x, Vec128<byte> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec128`1<System.Byte> Z0.dinx::vand(Z0.Vec128`1<System.Byte>&,Z0.Vec128`1<System.Byte>&)
    IL_0009: ret

}
Vec128<byte> vand_g128x8u(Vec128<byte> x, Vec128<byte> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec128`1<System.Byte> Z0.ginx::vand<System.Byte>(Z0.Vec128`1<System.Byte>&,Z0.Vec128`1<System.Byte>&)
    IL_0009: ret

}
Vector128<short> vand_n128x16i(Vector128<short> x, Vector128<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::And(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0007: ret

}
Vec128<short> vand_d128x16i(Vec128<short> x, Vec128<short> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec128`1<System.Int16> Z0.dinx::vand(Z0.Vec128`1<System.Int16>&,Z0.Vec128`1<System.Int16>&)
    IL_0009: ret

}
Vec128<short> vand_g128x16i(Vec128<short> x, Vec128<short> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec128`1<System.Int16> Z0.ginx::vand<System.Int16>(Z0.Vec128`1<System.Int16>&,Z0.Vec128`1<System.Int16>&)
    IL_0009: ret

}
Vector128<ushort> vand_n128x16u(Vector128<ushort> x, Vector128<ushort> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::And(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0007: ret

}
Vec128<ushort> vand_d128x16u(Vec128<ushort> x, Vec128<ushort> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec128`1<System.UInt16> Z0.dinx::vand(Z0.Vec128`1<System.UInt16>&,Z0.Vec128`1<System.UInt16>&)
    IL_0009: ret

}
Vec128<ushort> vand_g128x16u(Vec128<ushort> x, Vec128<ushort> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec128`1<System.UInt16> Z0.ginx::vand<System.UInt16>(Z0.Vec128`1<System.UInt16>&,Z0.Vec128`1<System.UInt16>&)
    IL_0009: ret

}
Vector128<int> vand_n128x32i(Vector128<int> x, Vector128<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::And(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0007: ret

}
Vec128<int> vand_d128x32i(Vec128<int> x, Vec128<int> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec128`1<System.Int32> Z0.dinx::vand(Z0.Vec128`1<System.Int32>&,Z0.Vec128`1<System.Int32>&)
    IL_0009: ret

}
Vec128<int> vand_g128x32i(Vec128<int> x, Vec128<int> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec128`1<System.Int32> Z0.ginx::vand<System.Int32>(Z0.Vec128`1<System.Int32>&,Z0.Vec128`1<System.Int32>&)
    IL_0009: ret

}
Vector128<uint> vand_n128x32u(Vector128<uint> x, Vector128<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::And(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0007: ret

}
Vec128<uint> vand_d128x32u(Vec128<uint> x, Vec128<uint> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec128`1<System.UInt32> Z0.dinx::vand(Z0.Vec128`1<System.UInt32>&,Z0.Vec128`1<System.UInt32>&)
    IL_0009: ret

}
Vec128<uint> vand_g128x32u(Vec128<uint> x, Vec128<uint> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec128`1<System.UInt32> Z0.ginx::vand<System.UInt32>(Z0.Vec128`1<System.UInt32>&,Z0.Vec128`1<System.UInt32>&)
    IL_0009: ret

}
Vector128<long> vand_n128x64i(Vector128<long> x, Vector128<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse2::And(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0007: ret

}
Vec128<long> vand_d128x64i(Vec128<long> x, Vec128<long> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec128`1<System.Int64> Z0.dinx::vand(Z0.Vec128`1<System.Int64>&,Z0.Vec128`1<System.Int64>&)
    IL_0009: ret

}
Vec128<long> vand_g128x64i(Vec128<long> x, Vec128<long> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec128`1<System.Int64> Z0.ginx::vand<System.Int64>(Z0.Vec128`1<System.Int64>&,Z0.Vec128`1<System.Int64>&)
    IL_0009: ret

}
Vector128<ulong> vand_n128x64u(Vector128<ulong> x, Vector128<ulong> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::And(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0007: ret

}
Vec128<ulong> vand_d128x64u(Vec128<ulong> x, Vec128<ulong> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec128`1<System.UInt64> Z0.dinx::vand(Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&)
    IL_0009: ret

}
Vec128<ulong> vand_g128x64u(Vec128<ulong> x, Vec128<ulong> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec128`1<System.UInt64> Z0.ginx::vand<System.UInt64>(Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&)
    IL_0009: ret

}
Vector128<float> vand_n128x32f(Vector128<float> x, Vector128<float> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Sse::And(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0007: ret

}
Vector256<sbyte> vand_n256x8i(Vector256<sbyte> x, Vector256<sbyte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::And(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0007: ret

}
Vec256<sbyte> vand_d256x8i(Vec256<sbyte> x, Vec256<sbyte> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec256`1<System.SByte> Z0.dinx::vand(Z0.Vec256`1<System.SByte>&,Z0.Vec256`1<System.SByte>&)
    IL_0009: ret

}
Vec256<sbyte> vand_g256x8i(Vec256<sbyte> x, Vec256<sbyte> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec256`1<System.SByte> Z0.ginx::vand<System.SByte>(Z0.Vec256`1<System.SByte>&,Z0.Vec256`1<System.SByte>&)
    IL_0009: ret

}
Vector256<byte> vand_n256x8u(Vector256<byte> x, Vector256<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::And(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0007: ret

}
Vec256<byte> vand_d256x8u(Vec256<byte> x, Vec256<byte> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec256`1<System.Byte> Z0.dinx::vand(Z0.Vec256`1<System.Byte>&,Z0.Vec256`1<System.Byte>&)
    IL_0009: ret

}
Vec256<byte> vand_g256x8u(Vec256<byte> x, Vec256<byte> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec256`1<System.Byte> Z0.ginx::vand<System.Byte>(Z0.Vec256`1<System.Byte>&,Z0.Vec256`1<System.Byte>&)
    IL_0009: ret

}
Vector256<short> vand_n256x16i(Vector256<short> x, Vector256<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::And(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0007: ret

}
Vec256<short> vand_d256x16i(Vec256<short> x, Vec256<short> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec256`1<System.Int16> Z0.dinx::vand(Z0.Vec256`1<System.Int16>&,Z0.Vec256`1<System.Int16>&)
    IL_0009: ret

}
Vec256<short> vand_g256x16i(Vec256<short> x, Vec256<short> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec256`1<System.Int16> Z0.ginx::vand<System.Int16>(Z0.Vec256`1<System.Int16>&,Z0.Vec256`1<System.Int16>&)
    IL_0009: ret

}
Vector256<ushort> vand_n256x16u(Vector256<ushort> x, Vector256<ushort> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::And(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0007: ret

}
Vec256<ushort> vand_d256x16u(Vec256<ushort> x, Vec256<ushort> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec256`1<System.UInt16> Z0.dinx::vand(Z0.Vec256`1<System.UInt16>&,Z0.Vec256`1<System.UInt16>&)
    IL_0009: ret

}
Vec256<ushort> vand_g256x16u(Vec256<ushort> x, Vec256<ushort> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec256`1<System.UInt16> Z0.ginx::vand<System.UInt16>(Z0.Vec256`1<System.UInt16>&,Z0.Vec256`1<System.UInt16>&)
    IL_0009: ret

}
Vector256<int> vand_n256x32i(Vector256<int> x, Vector256<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::And(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0007: ret

}
Vec256<int> vand_d256x32i(Vec256<int> x, Vec256<int> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec256`1<System.Int32> Z0.dinx::vand(Z0.Vec256`1<System.Int32>&,Z0.Vec256`1<System.Int32>&)
    IL_0009: ret

}
Vec256<int> vand_g256x32i(Vec256<int> x, Vec256<int> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec256`1<System.Int32> Z0.ginx::vand<System.Int32>(Z0.Vec256`1<System.Int32>&,Z0.Vec256`1<System.Int32>&)
    IL_0009: ret

}
Vector256<uint> vand_n256x32u(Vector256<uint> x, Vector256<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::And(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0007: ret

}
Vec256<uint> vand_d256x32u(Vec256<uint> x, Vec256<uint> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec256`1<System.UInt32> Z0.dinx::vand(Z0.Vec256`1<System.UInt32>&,Z0.Vec256`1<System.UInt32>&)
    IL_0009: ret

}
Vec256<uint> vand_g256x32u(Vec256<uint> x, Vec256<uint> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec256`1<System.UInt32> Z0.ginx::vand<System.UInt32>(Z0.Vec256`1<System.UInt32>&,Z0.Vec256`1<System.UInt32>&)
    IL_0009: ret

}
Vector256<long> vand_n256x64i(Vector256<long> x, Vector256<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::And(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0007: ret

}
Vec256<long> vand_d256x64i(Vec256<long> x, Vec256<long> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec256`1<System.Int64> Z0.dinx::vand(Z0.Vec256`1<System.Int64>&,Z0.Vec256`1<System.Int64>&)
    IL_0009: ret

}
Vec256<long> vand_g256x64i(Vec256<long> x, Vec256<long> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec256`1<System.Int64> Z0.ginx::vand<System.Int64>(Z0.Vec256`1<System.Int64>&,Z0.Vec256`1<System.Int64>&)
    IL_0009: ret

}
Vector256<ulong> vand_n256x64u(Vector256<ulong> x, Vector256<ulong> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::And(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0007: ret

}
Vec256<ulong> vand_d256x64u(Vec256<ulong> x, Vec256<ulong> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec256`1<System.UInt64> Z0.dinx::vand(Z0.Vec256`1<System.UInt64>&,Z0.Vec256`1<System.UInt64>&)
    IL_0009: ret

}
Vec256<ulong> vand_g256x64u(Vec256<ulong> x, Vec256<ulong> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec256`1<System.UInt64> Z0.ginx::vand<System.UInt64>(Z0.Vec256`1<System.UInt64>&,Z0.Vec256`1<System.UInt64>&)
    IL_0009: ret

}
Vec128<sbyte> vflip_d128x8i(Vec128<sbyte> src)
{
    IL_0000: ldarga.s src
    IL_0002: call Z0.Vec128`1<System.SByte> Z0.dinx::vflip(Z0.Vec128`1<System.SByte>&)
    IL_0007: ret

}
Vec128<sbyte> vflip_g128x8i(Vec128<sbyte> src)
{
    IL_0000: ldarga.s src
    IL_0002: call Z0.Vec128`1<System.SByte> Z0.ginx::vflip<System.SByte>(Z0.Vec128`1<System.SByte>&)
    IL_0007: ret

}
Vec128<byte> vflip_d128x8u(Vec128<byte> src)
{
    IL_0000: ldarga.s src
    IL_0002: call Z0.Vec128`1<System.Byte> Z0.dinx::vflip(Z0.Vec128`1<System.Byte>&)
    IL_0007: ret

}
Vec128<byte> vflip_g128x8u(Vec128<byte> src)
{
    IL_0000: ldarga.s src
    IL_0002: call Z0.Vec128`1<System.Byte> Z0.ginx::vflip<System.Byte>(Z0.Vec128`1<System.Byte>&)
    IL_0007: ret

}
Vec128<short> vflip_d128x16i(Vec128<short> src)
{
    IL_0000: ldarga.s src
    IL_0002: call Z0.Vec128`1<System.Int16> Z0.dinx::vflip(Z0.Vec128`1<System.Int16>&)
    IL_0007: ret

}
Vec128<short> vflip_g128x16i(Vec128<short> src)
{
    IL_0000: ldarga.s src
    IL_0002: call Z0.Vec128`1<System.Int16> Z0.ginx::vflip<System.Int16>(Z0.Vec128`1<System.Int16>&)
    IL_0007: ret

}
Vec128<ushort> vflip_d128x16u(Vec128<ushort> src)
{
    IL_0000: ldarga.s src
    IL_0002: call Z0.Vec128`1<System.UInt16> Z0.dinx::vflip(Z0.Vec128`1<System.UInt16>&)
    IL_0007: ret

}
Vec128<ushort> vflip_g128x16u(Vec128<ushort> src)
{
    IL_0000: ldarga.s src
    IL_0002: call Z0.Vec128`1<System.UInt16> Z0.ginx::vflip<System.UInt16>(Z0.Vec128`1<System.UInt16>&)
    IL_0007: ret

}
Vec128<int> vflip_d128x32i(Vec128<int> src)
{
    IL_0000: ldarga.s src
    IL_0002: call Z0.Vec128`1<System.Int32> Z0.dinx::vflip(Z0.Vec128`1<System.Int32>&)
    IL_0007: ret

}
Vec128<int> vflip_g128x32i(Vec128<int> src)
{
    IL_0000: ldarga.s src
    IL_0002: call Z0.Vec128`1<System.Int32> Z0.ginx::vflip<System.Int32>(Z0.Vec128`1<System.Int32>&)
    IL_0007: ret

}
Vec128<uint> vflip_d128x32u(Vec128<uint> src)
{
    IL_0000: ldarga.s src
    IL_0002: call Z0.Vec128`1<System.UInt32> Z0.dinx::vflip(Z0.Vec128`1<System.UInt32>&)
    IL_0007: ret

}
Vec128<uint> vflip_g128x32u(Vec128<uint> src)
{
    IL_0000: ldarga.s src
    IL_0002: call Z0.Vec128`1<System.UInt32> Z0.ginx::vflip<System.UInt32>(Z0.Vec128`1<System.UInt32>&)
    IL_0007: ret

}
Vec128<long> vflip_d128x64i(Vec128<long> src)
{
    IL_0000: ldarga.s src
    IL_0002: call Z0.Vec128`1<System.Int64> Z0.dinx::vflip(Z0.Vec128`1<System.Int64>&)
    IL_0007: ret

}
Vec128<long> vflip_g128x64i(Vec128<long> src)
{
    IL_0000: ldarga.s src
    IL_0002: call Z0.Vec128`1<System.Int64> Z0.ginx::vflip<System.Int64>(Z0.Vec128`1<System.Int64>&)
    IL_0007: ret

}
Vec128<ulong> vflip_d128x64u(Vec128<ulong> src)
{
    IL_0000: ldarga.s src
    IL_0002: call Z0.Vec128`1<System.UInt64> Z0.dinx::vflip(Z0.Vec128`1<System.UInt64>&)
    IL_0007: ret

}
Vec128<ulong> vflip_g128x64u(Vec128<ulong> src)
{
    IL_0000: ldarga.s src
    IL_0002: call Z0.Vec128`1<System.UInt64> Z0.ginx::vflip<System.UInt64>(Z0.Vec128`1<System.UInt64>&)
    IL_0007: ret

}
Vec256<sbyte> vflip_d256x8i(Vec256<sbyte> src)
{
    IL_0000: ldarga.s src
    IL_0002: call Z0.Vec256`1<System.SByte> Z0.dinx::vflip(Z0.Vec256`1<System.SByte>&)
    IL_0007: ret

}
Vec256<sbyte> vflip_g256x8i(Vec256<sbyte> src)
{
    IL_0000: ldarga.s src
    IL_0002: call Z0.Vec256`1<System.SByte> Z0.ginx::vflip<System.SByte>(Z0.Vec256`1<System.SByte>&)
    IL_0007: ret

}
Vec256<byte> vflip_d256x8u(Vec256<byte> src)
{
    IL_0000: ldarga.s src
    IL_0002: call Z0.Vec256`1<System.Byte> Z0.dinx::vflip(Z0.Vec256`1<System.Byte>&)
    IL_0007: ret

}
Vec256<byte> vflip_g256x8u(Vec256<byte> src)
{
    IL_0000: ldarga.s src
    IL_0002: call Z0.Vec256`1<System.Byte> Z0.ginx::vflip<System.Byte>(Z0.Vec256`1<System.Byte>&)
    IL_0007: ret

}
Vec256<short> vflip_d256x16i(Vec256<short> src)
{
    IL_0000: ldarga.s src
    IL_0002: call Z0.Vec256`1<System.Int16> Z0.dinx::vflip(Z0.Vec256`1<System.Int16>&)
    IL_0007: ret

}
Vec256<short> vflip_g256x16i(Vec256<short> src)
{
    IL_0000: ldarga.s src
    IL_0002: call Z0.Vec256`1<System.Int16> Z0.ginx::vflip<System.Int16>(Z0.Vec256`1<System.Int16>&)
    IL_0007: ret

}
Vec256<ushort> vflip_d256x16u(Vec256<ushort> src)
{
    IL_0000: ldarga.s src
    IL_0002: call Z0.Vec256`1<System.UInt16> Z0.dinx::vflip(Z0.Vec256`1<System.UInt16>&)
    IL_0007: ret

}
Vec256<ushort> vflip_g256x16u(Vec256<ushort> src)
{
    IL_0000: ldarga.s src
    IL_0002: call Z0.Vec256`1<System.UInt16> Z0.ginx::vflip<System.UInt16>(Z0.Vec256`1<System.UInt16>&)
    IL_0007: ret

}
Vec256<int> vflip_d256x32i(Vec256<int> src)
{
    IL_0000: ldarga.s src
    IL_0002: call Z0.Vec256`1<System.Int32> Z0.dinx::vflip(Z0.Vec256`1<System.Int32>&)
    IL_0007: ret

}
Vec256<int> vflip_g256x32i(Vec256<int> src)
{
    IL_0000: ldarga.s src
    IL_0002: call Z0.Vec256`1<System.Int32> Z0.ginx::vflip<System.Int32>(Z0.Vec256`1<System.Int32>&)
    IL_0007: ret

}
Vec256<uint> vflip_d256x32u(Vec256<uint> src)
{
    IL_0000: ldarga.s src
    IL_0002: call Z0.Vec256`1<System.UInt32> Z0.dinx::vflip(Z0.Vec256`1<System.UInt32>&)
    IL_0007: ret

}
Vec256<uint> vflip_g256x32u(Vec256<uint> src)
{
    IL_0000: ldarga.s src
    IL_0002: call Z0.Vec256`1<System.UInt32> Z0.ginx::vflip<System.UInt32>(Z0.Vec256`1<System.UInt32>&)
    IL_0007: ret

}
Vec256<long> vflip_d256x64i(Vec256<long> src)
{
    IL_0000: ldarga.s src
    IL_0002: call Z0.Vec256`1<System.Int64> Z0.dinx::vflip(Z0.Vec256`1<System.Int64>&)
    IL_0007: ret

}
Vec256<long> vflip_g256x64i(Vec256<long> src)
{
    IL_0000: ldarga.s src
    IL_0002: call Z0.Vec256`1<System.Int64> Z0.ginx::vflip<System.Int64>(Z0.Vec256`1<System.Int64>&)
    IL_0007: ret

}
Vec256<ulong> vflip_d256x64u(Vec256<ulong> src)
{
    IL_0000: ldarga.s src
    IL_0002: call Z0.Vec256`1<System.UInt64> Z0.dinx::vflip(Z0.Vec256`1<System.UInt64>&)
    IL_0007: ret

}
Vec256<ulong> vflip_g256x64u(Vec256<ulong> src)
{
    IL_0000: ldarga.s src
    IL_0002: call Z0.Vec256`1<System.UInt64> Z0.ginx::vflip<System.UInt64>(Z0.Vec256`1<System.UInt64>&)
    IL_0007: ret

}
Vector128<sbyte> vor_n128x8i(Vector128<sbyte> x, Vector128<sbyte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::And(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0007: ret

}
Vec128<sbyte> vor_d128x8i(Vec128<sbyte> x, Vec128<sbyte> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec128`1<System.SByte> Z0.dinx::vor(Z0.Vec128`1<System.SByte>&,Z0.Vec128`1<System.SByte>&)
    IL_0009: ret

}
Vec128<sbyte> vor_g128x8i(Vec128<sbyte> x, Vec128<sbyte> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec128`1<System.SByte> Z0.ginx::vor<System.SByte>(Z0.Vec128`1<System.SByte>&,Z0.Vec128`1<System.SByte>&)
    IL_0009: ret

}
Vector128<byte> vor_n128x8u(Vector128<byte> x, Vector128<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::And(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0007: ret

}
Vec128<byte> vor_d128x8u(Vec128<byte> x, Vec128<byte> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec128`1<System.Byte> Z0.dinx::vor(Z0.Vec128`1<System.Byte>&,Z0.Vec128`1<System.Byte>&)
    IL_0009: ret

}
Vec128<byte> vor_g128x8u(Vec128<byte> x, Vec128<byte> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec128`1<System.Byte> Z0.ginx::vor<System.Byte>(Z0.Vec128`1<System.Byte>&,Z0.Vec128`1<System.Byte>&)
    IL_0009: ret

}
Vector128<short> vor_n128x16i(Vector128<short> x, Vector128<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::And(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0007: ret

}
Vec128<short> vor_d128x16i(Vec128<short> x, Vec128<short> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec128`1<System.Int16> Z0.dinx::vor(Z0.Vec128`1<System.Int16>&,Z0.Vec128`1<System.Int16>&)
    IL_0009: ret

}
Vec128<short> vor_g128x16i(Vec128<short> x, Vec128<short> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec128`1<System.Int16> Z0.ginx::vor<System.Int16>(Z0.Vec128`1<System.Int16>&,Z0.Vec128`1<System.Int16>&)
    IL_0009: ret

}
Vector128<ushort> vor_n128x16u(Vector128<ushort> x, Vector128<ushort> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::And(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0007: ret

}
Vec128<ushort> vor_d128x16u(Vec128<ushort> x, Vec128<ushort> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec128`1<System.UInt16> Z0.dinx::vor(Z0.Vec128`1<System.UInt16>&,Z0.Vec128`1<System.UInt16>&)
    IL_0009: ret

}
Vec128<ushort> vor_g128x16u(Vec128<ushort> x, Vec128<ushort> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec128`1<System.UInt16> Z0.ginx::vor<System.UInt16>(Z0.Vec128`1<System.UInt16>&,Z0.Vec128`1<System.UInt16>&)
    IL_0009: ret

}
Vector128<int> vor_n128x32i(Vector128<int> x, Vector128<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::And(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0007: ret

}
Vec128<int> vor_d128x32i(Vec128<int> x, Vec128<int> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec128`1<System.Int32> Z0.dinx::vor(Z0.Vec128`1<System.Int32>&,Z0.Vec128`1<System.Int32>&)
    IL_0009: ret

}
Vec128<int> vor_g128x32i(Vec128<int> x, Vec128<int> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.Vec128`1<System.Int32> Z0.ginx::vor<System.Int32>(Z0.Vec128`1<System.Int32>&,Z0.Vec128`1<System.Int32>&)
    IL_0009: ret

}
