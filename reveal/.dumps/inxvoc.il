// 2019-10-12 06:44:39:341
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
bool vtestz_n128x8u(Vec128<byte> src, Vec128<byte> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::xmm
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestZ(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0011: ret

}
bool vtestz_d128x8i(Vec128<sbyte> src, Vec128<sbyte> mask)
{
    IL_0000: ldarga.s src
    IL_0002: ldarga.s mask
    IL_0004: call System.Boolean Z0.dinx::testz(Z0.Vec128`1<System.SByte>&,Z0.Vec128`1<System.SByte>&)
    IL_0009: ret

}
bool vtestz_g128x8i(Vec128<sbyte> src, Vec128<sbyte> mask)
{
    IL_0000: ldarga.s src
    IL_0002: ldarga.s mask
    IL_0004: call System.Boolean Z0.ginx::testz<System.SByte>(Z0.Vec128`1<System.SByte>&,Z0.Vec128`1<System.SByte>&)
    IL_0009: ret

}
bool vtestz_d128x8u(Vec128<byte> src, Vec128<byte> mask)
{
    IL_0000: ldarga.s src
    IL_0002: ldarga.s mask
    IL_0004: call System.Boolean Z0.dinx::testz(Z0.Vec128`1<System.Byte>&,Z0.Vec128`1<System.Byte>&)
    IL_0009: ret

}
bool vtestz_g128x8u(Vec128<byte> src, Vec128<byte> mask)
{
    IL_0000: ldarga.s src
    IL_0002: ldarga.s mask
    IL_0004: call System.Boolean Z0.ginx::testz<System.Byte>(Z0.Vec128`1<System.Byte>&,Z0.Vec128`1<System.Byte>&)
    IL_0009: ret

}
bool vtestz_d128x16i(Vec128<short> src, Vec128<short> mask)
{
    IL_0000: ldarga.s src
    IL_0002: ldarga.s mask
    IL_0004: call System.Boolean Z0.dinx::testz(Z0.Vec128`1<System.Int16>&,Z0.Vec128`1<System.Int16>&)
    IL_0009: ret

}
bool vtestz_g128x16i(Vec128<short> src, Vec128<short> mask)
{
    IL_0000: ldarga.s src
    IL_0002: ldarga.s mask
    IL_0004: call System.Boolean Z0.ginx::testz<System.Int16>(Z0.Vec128`1<System.Int16>&,Z0.Vec128`1<System.Int16>&)
    IL_0009: ret

}
bool vtestz_d128x16u(Vec128<ushort> src, Vec128<ushort> mask)
{
    IL_0000: ldarga.s src
    IL_0002: ldarga.s mask
    IL_0004: call System.Boolean Z0.dinx::testz(Z0.Vec128`1<System.UInt16>&,Z0.Vec128`1<System.UInt16>&)
    IL_0009: ret

}
bool vtestz_g128x16u(Vec128<ushort> src, Vec128<ushort> mask)
{
    IL_0000: ldarga.s src
    IL_0002: ldarga.s mask
    IL_0004: call System.Boolean Z0.ginx::testz<System.UInt16>(Z0.Vec128`1<System.UInt16>&,Z0.Vec128`1<System.UInt16>&)
    IL_0009: ret

}
bool vtestz_d128x32i(Vec128<int> src, Vec128<int> mask)
{
    IL_0000: ldarga.s src
    IL_0002: ldarga.s mask
    IL_0004: call System.Boolean Z0.dinx::testz(Z0.Vec128`1<System.Int32>&,Z0.Vec128`1<System.Int32>&)
    IL_0009: ret

}
bool vtestz_g128x32i(Vec128<int> src, Vec128<int> mask)
{
    IL_0000: ldarga.s src
    IL_0002: ldarga.s mask
    IL_0004: call System.Boolean Z0.ginx::testz<System.Int32>(Z0.Vec128`1<System.Int32>&,Z0.Vec128`1<System.Int32>&)
    IL_0009: ret

}
bool vtestz_d128x32u(Vec128<uint> src, Vec128<uint> mask)
{
    IL_0000: ldarga.s src
    IL_0002: ldarga.s mask
    IL_0004: call System.Boolean Z0.dinx::testz(Z0.Vec128`1<System.UInt32>&,Z0.Vec128`1<System.UInt32>&)
    IL_0009: ret

}
bool vtestz_g128x32u(Vec128<uint> src, Vec128<uint> mask)
{
    IL_0000: ldarga.s src
    IL_0002: ldarga.s mask
    IL_0004: call System.Boolean Z0.ginx::testz<System.UInt32>(Z0.Vec128`1<System.UInt32>&,Z0.Vec128`1<System.UInt32>&)
    IL_0009: ret

}
bool vtestz_d128x64i(Vec128<long> src, Vec128<long> mask)
{
    IL_0000: ldarga.s src
    IL_0002: ldarga.s mask
    IL_0004: call System.Boolean Z0.dinx::testz(Z0.Vec128`1<System.Int64>&,Z0.Vec128`1<System.Int64>&)
    IL_0009: ret

}
bool vtestz_g128x64i(Vec128<long> src, Vec128<long> mask)
{
    IL_0000: ldarga.s src
    IL_0002: ldarga.s mask
    IL_0004: call System.Boolean Z0.ginx::testz<System.Int64>(Z0.Vec128`1<System.Int64>&,Z0.Vec128`1<System.Int64>&)
    IL_0009: ret

}
bool vtestz_d128x64u(Vec128<ulong> src, Vec128<ulong> mask)
{
    IL_0000: ldarga.s src
    IL_0002: ldarga.s mask
    IL_0004: call System.Boolean Z0.dinx::testz(Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&)
    IL_0009: ret

}
bool vtestz_g128x64u(Vec128<ulong> src, Vec128<ulong> mask)
{
    IL_0000: ldarga.s src
    IL_0002: ldarga.s mask
    IL_0004: call System.Boolean Z0.ginx::testz<System.UInt64>(Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&)
    IL_0009: ret

}
bool vtestz_d256x8i(Vec256<sbyte> src, Vec256<sbyte> mask)
{
    IL_0000: ldarga.s src
    IL_0002: ldarga.s mask
    IL_0004: call System.Boolean Z0.dinx::testz(Z0.Vec256`1<System.SByte>&,Z0.Vec256`1<System.SByte>&)
    IL_0009: ret

}
bool vtestz_g256x8i(Vec256<sbyte> src, Vec256<sbyte> mask)
{
    IL_0000: ldarga.s src
    IL_0002: ldarga.s mask
    IL_0004: call System.Boolean Z0.ginx::testz<System.SByte>(Z0.Vec256`1<System.SByte>&,Z0.Vec256`1<System.SByte>&)
    IL_0009: ret

}
bool vtestz_d256x8u(Vec256<byte> src, Vec256<byte> mask)
{
    IL_0000: ldarga.s src
    IL_0002: ldarga.s mask
    IL_0004: call System.Boolean Z0.dinx::testz(Z0.Vec256`1<System.Byte>&,Z0.Vec256`1<System.Byte>&)
    IL_0009: ret

}
bool vtestz_g256x8u(Vec256<byte> src, Vec256<byte> mask)
{
    IL_0000: ldarga.s src
    IL_0002: ldarga.s mask
    IL_0004: call System.Boolean Z0.ginx::testz<System.Byte>(Z0.Vec256`1<System.Byte>&,Z0.Vec256`1<System.Byte>&)
    IL_0009: ret

}
bool vtestz_d256x16i(Vec256<short> src, Vec256<short> mask)
{
    IL_0000: ldarga.s src
    IL_0002: ldarga.s mask
    IL_0004: call System.Boolean Z0.dinx::testz(Z0.Vec256`1<System.Int16>&,Z0.Vec256`1<System.Int16>&)
    IL_0009: ret

}
bool vtestz_g256x16i(Vec256<short> src, Vec256<short> mask)
{
    IL_0000: ldarga.s src
    IL_0002: ldarga.s mask
    IL_0004: call System.Boolean Z0.ginx::testz<System.Int16>(Z0.Vec256`1<System.Int16>&,Z0.Vec256`1<System.Int16>&)
    IL_0009: ret

}
bool vtestz_d256x16u(Vec256<ushort> src, Vec256<ushort> mask)
{
    IL_0000: ldarga.s src
    IL_0002: ldarga.s mask
    IL_0004: call System.Boolean Z0.dinx::testz(Z0.Vec256`1<System.UInt16>&,Z0.Vec256`1<System.UInt16>&)
    IL_0009: ret

}
bool vtestz_g256x16u(Vec256<ushort> src, Vec256<ushort> mask)
{
    IL_0000: ldarga.s src
    IL_0002: ldarga.s mask
    IL_0004: call System.Boolean Z0.ginx::testz<System.UInt16>(Z0.Vec256`1<System.UInt16>&,Z0.Vec256`1<System.UInt16>&)
    IL_0009: ret

}
bool vtestz_d256x32i(Vec256<int> src, Vec256<int> mask)
{
    IL_0000: ldarga.s src
    IL_0002: ldarga.s mask
    IL_0004: call System.Boolean Z0.dinx::testz(Z0.Vec256`1<System.Int32>&,Z0.Vec256`1<System.Int32>&)
    IL_0009: ret

}
bool vtestz_g256x32i(Vec256<int> src, Vec256<int> mask)
{
    IL_0000: ldarga.s src
    IL_0002: ldarga.s mask
    IL_0004: call System.Boolean Z0.ginx::testz<System.Int32>(Z0.Vec256`1<System.Int32>&,Z0.Vec256`1<System.Int32>&)
    IL_0009: ret

}
bool vtestz_d256x32u(Vec256<uint> src, Vec256<uint> mask)
{
    IL_0000: ldarga.s src
    IL_0002: ldarga.s mask
    IL_0004: call System.Boolean Z0.dinx::testz(Z0.Vec256`1<System.UInt32>&,Z0.Vec256`1<System.UInt32>&)
    IL_0009: ret

}
bool vtestz_g256x32u(Vec256<uint> src, Vec256<uint> mask)
{
    IL_0000: ldarga.s src
    IL_0002: ldarga.s mask
    IL_0004: call System.Boolean Z0.ginx::testz<System.UInt32>(Z0.Vec256`1<System.UInt32>&,Z0.Vec256`1<System.UInt32>&)
    IL_0009: ret

}
bool vtestz_d256x64i(Vec256<long> src, Vec256<long> mask)
{
    IL_0000: ldarga.s src
    IL_0002: ldarga.s mask
    IL_0004: call System.Boolean Z0.dinx::testz(Z0.Vec256`1<System.Int64>&,Z0.Vec256`1<System.Int64>&)
    IL_0009: ret

}
bool vtestz_g256x64i(Vec256<long> src, Vec256<long> mask)
{
    IL_0000: ldarga.s src
    IL_0002: ldarga.s mask
    IL_0004: call System.Boolean Z0.ginx::testz<System.Int64>(Z0.Vec256`1<System.Int64>&,Z0.Vec256`1<System.Int64>&)
    IL_0009: ret

}
bool vtestz_d256x64u(Vec256<ulong> src, Vec256<ulong> mask)
{
    IL_0000: ldarga.s src
    IL_0002: ldarga.s mask
    IL_0004: call System.Boolean Z0.dinx::testz(Z0.Vec256`1<System.UInt64>&,Z0.Vec256`1<System.UInt64>&)
    IL_0009: ret

}
bool vtestz_g256x64u(Vec256<ulong> src, Vec256<ulong> mask)
{
    IL_0000: ldarga.s src
    IL_0002: ldarga.s mask
    IL_0004: call System.Boolean Z0.ginx::testz<System.UInt64>(Z0.Vec256`1<System.UInt64>&,Z0.Vec256`1<System.UInt64>&)
    IL_0009: ret

}
Vec256<byte> pattern_lanemerge_8u()
{
    IL_0000: call Z0.Vec256`1<System.Byte> Z0.Vec256Pattern::LaneMerge<System.Byte>()
    IL_0005: ret

}
Vec256<ushort> pattern_lanemerge_16u()
{
    IL_0000: call Z0.Vec256`1<System.UInt16> Z0.Vec256Pattern::LaneMerge<System.UInt16>()
    IL_0005: ret

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
Vec128<byte> vsll(in Vec128<byte> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.Byte> Z0.dinx::vsll(Z0.Vec128`1<System.Byte>&,System.Byte)
    IL_0007: ret

}
Vec128<byte> rotl_128x8u(in Vec128<byte> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.Byte> Z0.ginx::vrotl<System.Byte>(Z0.Vec128`1<System.Byte>&,System.Byte)
    IL_0007: ret

}
Vec128<ushort> rotl_128x16u(in Vec128<ushort> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.UInt16> Z0.ginx::vrotl<System.UInt16>(Z0.Vec128`1<System.UInt16>&,System.Byte)
    IL_0007: ret

}
Vec128<uint> rotl_128x32u(in Vec128<uint> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.UInt32> Z0.ginx::vrotl<System.UInt32>(Z0.Vec128`1<System.UInt32>&,System.Byte)
    IL_0007: ret

}
Vec128<ulong> rotl_128x64u(in Vec128<ulong> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.UInt64> Z0.ginx::vrotl<System.UInt64>(Z0.Vec128`1<System.UInt64>&,System.Byte)
    IL_0007: ret

}
Vec256<byte> rotl_256x8u(in Vec256<byte> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.Byte> Z0.ginx::vrotl<System.Byte>(Z0.Vec256`1<System.Byte>&,System.Byte)
    IL_0007: ret

}
Vec256<ushort> rotl_256x16u(in Vec256<ushort> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.UInt16> Z0.ginx::vrotl<System.UInt16>(Z0.Vec256`1<System.UInt16>&,System.Byte)
    IL_0007: ret

}
Vec256<uint> rotl_256x32u(in Vec256<uint> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.UInt32> Z0.ginx::vrotl<System.UInt32>(Z0.Vec256`1<System.UInt32>&,System.Byte)
    IL_0007: ret

}
Vec256<ulong> rotl_256x64u(in Vec256<ulong> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.UInt64> Z0.ginx::vrotl<System.UInt64>(Z0.Vec256`1<System.UInt64>&,System.Byte)
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
Vec256<uint> loadu_g256x32u(in uint src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec256`1<System.UInt32> Z0.ginx::loadu256<System.UInt32>(System.UInt32&)
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
    IL_0001: call Z0.Vec256`1<System.Int64> Z0.ginx::loadu256<System.Int64>(System.Int64&)
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
    IL_0001: call Z0.Vec256`1<System.UInt64> Z0.ginx::loadu256<System.UInt64>(System.UInt64&)
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
Vec256<int> vpermvar8x32_256x32i(in Vec256<int> src, in Vec256<int> spec)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.Int32> Z0.dinx::vpermvar8x32(Z0.Vec256`1<System.Int32>&,Z0.Vec256`1<System.Int32>&)
    IL_0007: ret

}
Vec256<uint> vpermvar8x32_256x32u(in Vec256<uint> src, in Vec256<uint> spec)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.UInt32> Z0.dinx::vpermvar8x32(Z0.Vec256`1<System.UInt32>&,Z0.Vec256`1<System.UInt32>&)
    IL_0007: ret

}
Vec256<float> vpermvar8x32_256x32f(in Vec256<float> src, in Vec256<int> spec)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.Single> Z0.dinx::vpermvar8x32(Z0.Vec256`1<System.Single>&,Z0.Vec256`1<System.Int32>&)
    IL_0007: ret

}
Vec256<byte> vpermvar32x8_256x8u(in Vec256<byte> a, in Vec256<byte> spec)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.Byte> Z0.dinx::vpermvar32x8(Z0.Vec256`1<System.Byte>&,Z0.Vec256`1<System.Byte>&)
    IL_0007: ret

}
Vec256<sbyte> vset_256x8i(in Vec128<sbyte> lo, in Vec128<sbyte> hi)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.SByte> Z0.ginx::vset<System.SByte>(Z0.Vec128`1<System.SByte>&,Z0.Vec128`1<System.SByte>&)
    IL_0007: ret

}
Vec256<byte> vset_256x8u(in Vec128<byte> lo, in Vec128<byte> hi)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.Byte> Z0.ginx::vset<System.Byte>(Z0.Vec128`1<System.Byte>&,Z0.Vec128`1<System.Byte>&)
    IL_0007: ret

}
Vec256<short> vset_256x16i(in Vec128<short> lo, in Vec128<short> hi)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.Int16> Z0.ginx::vset<System.Int16>(Z0.Vec128`1<System.Int16>&,Z0.Vec128`1<System.Int16>&)
    IL_0007: ret

}
Vec256<ushort> vset_256x16u(in Vec128<ushort> lo, in Vec128<ushort> hi)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.UInt16> Z0.ginx::vset<System.UInt16>(Z0.Vec128`1<System.UInt16>&,Z0.Vec128`1<System.UInt16>&)
    IL_0007: ret

}
Vec256<int> vset_256x32i(in Vec128<int> lo, in Vec128<int> hi)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.Int32> Z0.ginx::vset<System.Int32>(Z0.Vec128`1<System.Int32>&,Z0.Vec128`1<System.Int32>&)
    IL_0007: ret

}
Vec256<uint> vset_256x32i(in Vec128<uint> lo, in Vec128<uint> hi)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.UInt32> Z0.ginx::vset<System.UInt32>(Z0.Vec128`1<System.UInt32>&,Z0.Vec128`1<System.UInt32>&)
    IL_0007: ret

}
Vec256<long> vset_256x64i(in Vec128<long> lo, in Vec128<long> hi)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.Int64> Z0.ginx::vset<System.Int64>(Z0.Vec128`1<System.Int64>&,Z0.Vec128`1<System.Int64>&)
    IL_0007: ret

}
Vec256<ulong> vset_256x64u(in Vec128<ulong> lo, in Vec128<ulong> hi)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.UInt64> Z0.ginx::vset<System.UInt64>(Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&)
    IL_0007: ret

}
Vec256<float> vset_256x64f(in Vec128<float> lo, in Vec128<float> hi)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.Single> Z0.ginx::vset<System.Single>(Z0.Vec128`1<System.Single>&,Z0.Vec128`1<System.Single>&)
    IL_0007: ret

}
Vec256<double> vset_256x64f(in Vec128<double> lo, in Vec128<double> hi)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.Double> Z0.ginx::vset<System.Double>(Z0.Vec128`1<System.Double>&,Z0.Vec128`1<System.Double>&)
    IL_0007: ret

}
Vec128<byte> vshuffle_128x8u(in Vec128<byte> src, in Vec128<byte> spec)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.Byte> Z0.dinx::vshuffle(Z0.Vec128`1<System.Byte>&,Z0.Vec128`1<System.Byte>&)
    IL_0007: ret

}
Vec128<sbyte> vshuffle_128x8i(in Vec128<sbyte> src, in Vec128<sbyte> spec)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.SByte> Z0.dinx::vshuffle(Z0.Vec128`1<System.SByte>&,Z0.Vec128`1<System.SByte>&)
    IL_0007: ret

}
Vec256<byte> vshuffle_256x8u(in Vec256<byte> src, in Vec256<byte> spec)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.Byte> Z0.dinx::vshuffle(Z0.Vec256`1<System.Byte>&,Z0.Vec256`1<System.Byte>&)
    IL_0007: ret

}
Vec256<sbyte> vshuffle_256x8i(in Vec256<sbyte> src, in Vec256<sbyte> spec)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.SByte> Z0.dinx::vshuffle(Z0.Vec256`1<System.SByte>&,Z0.Vec256`1<System.SByte>&)
    IL_0007: ret

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
Vec128<byte> vbroadcast_d128x8u(byte src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.Byte> Z0.dinx::vbroadcast128(System.Byte)
    IL_0006: ret

}
Vec128<byte> vbroadcast_g128x8u(byte src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.Byte> Z0.ginx::vbroadcast128<System.Byte>(System.Byte)
    IL_0006: ret

}
Vec256<byte> vbroadcast_d256x8u(byte src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec256`1<System.Byte> Z0.dinx::vbroadcast256(System.Byte)
    IL_0006: ret

}
Vec256<byte> vbroadcast_g256x8u(byte src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec256`1<System.Byte> Z0.ginx::vbroadcast256<System.Byte>(System.Byte)
    IL_0006: ret

}
Vec256<ulong> vbroadcast_d256x64u(ulong src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec256`1<System.UInt64> Z0.dinx::vbroadcast256(System.UInt64)
    IL_0006: ret

}
Vec256<ulong> vbroadcast_g256x64u(ulong src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec256`1<System.UInt64> Z0.ginx::vbroadcast256<System.UInt64>(System.UInt64)
    IL_0006: ret

}
ref Vec128<short> vconvert_128x8u_to_128x16i(in Vec128<byte> src, out Vec128<short> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.Int16>& Z0.dinx::vconvert(Z0.Vec128`1<System.Byte>&,Z0.Vec128`1<System.Int16>&)
    IL_0007: ret

}
ref Vec128<ushort> vconvert_128x8u_to_128x16u(in Vec128<byte> src, out Vec128<ushort> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.UInt16>& Z0.dinx::vconvert(Z0.Vec128`1<System.Byte>&,Z0.Vec128`1<System.UInt16>&)
    IL_0007: ret

}
ref Vec128<int> vconvert_128x8u_to_128x32i(in Vec128<byte> src, out Vec128<int> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.Int32>& Z0.dinx::vconvert(Z0.Vec128`1<System.Byte>&,Z0.Vec128`1<System.Int32>&)
    IL_0007: ret

}
ref Vec128<uint> vconvert_128x8u_to_128x32u(in Vec128<byte> src, out Vec128<uint> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.UInt32>& Z0.dinx::vconvert(Z0.Vec128`1<System.Byte>&,Z0.Vec128`1<System.UInt32>&)
    IL_0007: ret

}
ref Vec128<long> vconvert_128x8u_to_128x64i(in Vec128<byte> src, out Vec128<long> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.Int64>& Z0.dinx::vconvert(Z0.Vec128`1<System.Byte>&,Z0.Vec128`1<System.Int64>&)
    IL_0007: ret

}
ref Vec128<ulong> vconvert_128x8u_to_128x64u(in Vec128<byte> src, out Vec128<ulong> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.UInt64>& Z0.dinx::vconvert(Z0.Vec128`1<System.Byte>&,Z0.Vec128`1<System.UInt64>&)
    IL_0007: ret

}
ref Vec128<int> vconvert_128x16i_to_128x32i(in Vec128<short> src, out Vec128<int> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.Int32>& Z0.dinx::vconvert(Z0.Vec128`1<System.Int16>&,Z0.Vec128`1<System.Int32>&)
    IL_0007: ret

}
ref Vec128<long> vconvert_128x16i_to_128x64i(in Vec128<short> src, out Vec128<long> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.Int64>& Z0.dinx::vconvert(Z0.Vec128`1<System.Int16>&,Z0.Vec128`1<System.Int64>&)
    IL_0007: ret

}
ref Vec128<int> vconvert_128x16u_to_128x32i(in Vec128<ushort> src, out Vec128<int> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.Int32>& Z0.dinx::vconvert(Z0.Vec128`1<System.UInt16>&,Z0.Vec128`1<System.Int32>&)
    IL_0007: ret

}
ref Vec128<uint> vconvert_128x16u_to_128x32u(in Vec128<ushort> src, out Vec128<uint> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.UInt32>& Z0.dinx::vconvert(Z0.Vec128`1<System.UInt16>&,Z0.Vec128`1<System.UInt32>&)
    IL_0007: ret

}
ref Vec128<long> vconvert_128x16u_to_128x64i(in Vec128<ushort> src, out Vec128<long> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.Int64>& Z0.dinx::vconvert(Z0.Vec128`1<System.UInt16>&,Z0.Vec128`1<System.Int64>&)
    IL_0007: ret

}
ref Vec128<ulong> vconvert_128x16u_to_128x64u(in Vec128<ushort> src, out Vec128<ulong> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.UInt64>& Z0.dinx::vconvert(Z0.Vec128`1<System.UInt16>&,Z0.Vec128`1<System.UInt64>&)
    IL_0007: ret

}
ref Vec128<long> vconvert_128x32i_to_128x64i(in Vec128<int> src, out Vec128<long> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.Int64>& Z0.dinx::vconvert(Z0.Vec128`1<System.Int32>&,Z0.Vec128`1<System.Int64>&)
    IL_0007: ret

}
ref Vec128<long> vconvert_128x32u_to_128x64i(in Vec128<uint> src, out Vec128<long> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.Int64>& Z0.dinx::vconvert(Z0.Vec128`1<System.UInt32>&,Z0.Vec128`1<System.Int64>&)
    IL_0007: ret

}
ref Vec128<ulong> vconvert_128x32u_to_128x64u(in Vec128<uint> src, out Vec128<ulong> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.UInt64>& Z0.dinx::vconvert(Z0.Vec128`1<System.UInt32>&,Z0.Vec128`1<System.UInt64>&)
    IL_0007: ret

}
ref Vec256<short> vconvert_128x8i_to_256x16i(in Vec128<sbyte> src, out Vec256<short> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.Int16>& Z0.dinx::vconvert(Z0.Vec128`1<System.SByte>&,Z0.Vec256`1<System.Int16>&)
    IL_0007: ret

}
ref Vec256<int> vconvert_128x8i_to_256x32i(in Vec128<sbyte> src, out Vec256<int> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.Int32>& Z0.dinx::vconvert(Z0.Vec128`1<System.SByte>&,Z0.Vec256`1<System.Int32>&)
    IL_0007: ret

}
ref Vec256<long> vconvert_128x8i_to_256x64i(in Vec128<sbyte> src, out Vec256<long> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.Int64>& Z0.dinx::vconvert(Z0.Vec128`1<System.SByte>&,Z0.Vec256`1<System.Int64>&)
    IL_0007: ret

}
ref Vec256<short> vconvert_128x8u_to_256x16i(in Vec128<byte> src, out Vec256<short> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.Int16>& Z0.dinx::vconvert(Z0.Vec128`1<System.Byte>&,Z0.Vec256`1<System.Int16>&)
    IL_0007: ret

}
ref Vec256<ushort> vconvert_128x8u_to_256x16u(in Vec128<byte> src, out Vec256<ushort> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.UInt16>& Z0.dinx::vconvert(Z0.Vec128`1<System.Byte>&,Z0.Vec256`1<System.UInt16>&)
    IL_0007: ret

}
ref Vec256<int> vconvert_128x8u_to_256x32i(in Vec128<byte> src, out Vec256<int> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.Int32>& Z0.dinx::vconvert(Z0.Vec128`1<System.Byte>&,Z0.Vec256`1<System.Int32>&)
    IL_0007: ret

}
ref Vec256<uint> vconvert_128x8u_to_256x32u(in Vec128<byte> src, out Vec256<uint> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.UInt32>& Z0.dinx::vconvert(Z0.Vec128`1<System.Byte>&,Z0.Vec256`1<System.UInt32>&)
    IL_0007: ret

}
ref Vec256<long> vconvert_128x8u_to_256x64i(in Vec128<byte> src, out Vec256<long> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.Int64>& Z0.dinx::vconvert(Z0.Vec128`1<System.Byte>&,Z0.Vec256`1<System.Int64>&)
    IL_0007: ret

}
ref Vec256<ulong> vconvert_128x8u_to_256x64u(in Vec128<byte> src, out Vec256<ulong> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.UInt64>& Z0.dinx::vconvert(Z0.Vec128`1<System.Byte>&,Z0.Vec256`1<System.UInt64>&)
    IL_0007: ret

}
ref Vec256<int> vconvert_128x16i_to_256x32i(in Vec128<short> src, out Vec256<int> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.Int32>& Z0.dinx::vconvert(Z0.Vec128`1<System.Int16>&,Z0.Vec256`1<System.Int32>&)
    IL_0007: ret

}
ref Vec256<long> vconvert_128x16i_to_256x64i(in Vec128<short> src, out Vec256<long> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.Int64>& Z0.dinx::vconvert(Z0.Vec128`1<System.Int16>&,Z0.Vec256`1<System.Int64>&)
    IL_0007: ret

}
ref Vec256<int> vconvert_128x16u_to_256x32i(in Vec128<ushort> src, out Vec256<int> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.Int32>& Z0.dinx::vconvert(Z0.Vec128`1<System.UInt16>&,Z0.Vec256`1<System.Int32>&)
    IL_0007: ret

}
ref Vec256<uint> vconvert_128x16u_to_256x32u(in Vec128<ushort> src, out Vec256<uint> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.UInt32>& Z0.dinx::vconvert(Z0.Vec128`1<System.UInt16>&,Z0.Vec256`1<System.UInt32>&)
    IL_0007: ret

}
ref Vec256<long> vconvert_128x16u_to_256x64i(in Vec128<ushort> src, out Vec256<long> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.Int64>& Z0.dinx::vconvert(Z0.Vec128`1<System.UInt16>&,Z0.Vec256`1<System.Int64>&)
    IL_0007: ret

}
ref Vec256<ulong> vconvert_128x16u_to_256x64u(in Vec128<ushort> src, out Vec256<ulong> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.UInt64>& Z0.dinx::vconvert(Z0.Vec128`1<System.UInt16>&,Z0.Vec256`1<System.UInt64>&)
    IL_0007: ret

}
ref Vec256<long> vconvert_128x32i_to_256x64i(in Vec128<int> src, out Vec256<long> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.Int64>& Z0.dinx::vconvert(Z0.Vec128`1<System.Int32>&,Z0.Vec256`1<System.Int64>&)
    IL_0007: ret

}
ref Vec256<long> vconvert_128x32u_to_256x64i(in Vec128<uint> src, out Vec256<long> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.Int64>& Z0.dinx::vconvert(Z0.Vec128`1<System.UInt32>&,Z0.Vec256`1<System.Int64>&)
    IL_0007: ret

}
ref Vec256<ulong> vconvert_128x32u_to_256x64u(in Vec128<uint> src, out Vec256<ulong> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.UInt64>& Z0.dinx::vconvert(Z0.Vec128`1<System.UInt32>&,Z0.Vec256`1<System.UInt64>&)
    IL_0007: ret

}
Vec128<sbyte> vhi_128x8i(in Vec256<sbyte> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.SByte> Z0.ginx::vhi<System.SByte>(Z0.Vec256`1<System.SByte>&)
    IL_0006: ret

}
Vec128<byte> vhi_128x8u(in Vec256<byte> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.Byte> Z0.ginx::vhi<System.Byte>(Z0.Vec256`1<System.Byte>&)
    IL_0006: ret

}
Vec128<short> vhi_128x16i(in Vec256<short> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.Int16> Z0.ginx::vhi<System.Int16>(Z0.Vec256`1<System.Int16>&)
    IL_0006: ret

}
Vec128<ushort> vhi_128x16u(in Vec256<ushort> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.UInt16> Z0.ginx::vhi<System.UInt16>(Z0.Vec256`1<System.UInt16>&)
    IL_0006: ret

}
Vec128<int> vhi_128x32i(in Vec256<int> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.Int32> Z0.ginx::vhi<System.Int32>(Z0.Vec256`1<System.Int32>&)
    IL_0006: ret

}
Vec128<uint> vhi_128x32u(in Vec256<uint> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.UInt32> Z0.ginx::vhi<System.UInt32>(Z0.Vec256`1<System.UInt32>&)
    IL_0006: ret

}
Vec128<long> vhi_128x64i(in Vec256<long> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.Int64> Z0.ginx::vhi<System.Int64>(Z0.Vec256`1<System.Int64>&)
    IL_0006: ret

}
Vec128<ulong> vhi_128x64u(in Vec256<ulong> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.UInt64> Z0.ginx::vhi<System.UInt64>(Z0.Vec256`1<System.UInt64>&)
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
    IL_0001: call Z0.Vec128`1<System.SByte> Z0.ginx::loadu128<System.SByte>(System.SByte&)
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
    IL_0001: call Z0.Vec128`1<System.Byte> Z0.ginx::loadu128<System.Byte>(System.Byte&)
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
    IL_0001: call Z0.Vec128`1<System.Int16> Z0.ginx::loadu128<System.Int16>(System.Int16&)
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
    IL_0001: call Z0.Vec128`1<System.UInt16> Z0.ginx::loadu128<System.UInt16>(System.UInt16&)
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
    IL_0001: call Z0.Vec128`1<System.Int32> Z0.ginx::loadu128<System.Int32>(System.Int32&)
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
    IL_0001: call Z0.Vec128`1<System.UInt32> Z0.ginx::loadu128<System.UInt32>(System.UInt32&)
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
    IL_0001: call Z0.Vec128`1<System.Int64> Z0.ginx::loadu128<System.Int64>(System.Int64&)
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
    IL_0001: call Z0.Vec128`1<System.UInt64> Z0.ginx::loadu128<System.UInt64>(System.UInt64&)
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
    IL_0001: call Z0.Vec256`1<System.SByte> Z0.ginx::loadu256<System.SByte>(System.SByte&)
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
    IL_0001: call Z0.Vec256`1<System.Byte> Z0.ginx::loadu256<System.Byte>(System.Byte&)
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
    IL_0001: call Z0.Vec256`1<System.Int16> Z0.ginx::loadu256<System.Int16>(System.Int16&)
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
    IL_0001: call Z0.Vec256`1<System.UInt16> Z0.ginx::loadu256<System.UInt16>(System.UInt16&)
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
    IL_0001: call Z0.Vec256`1<System.Int32> Z0.ginx::loadu256<System.Int32>(System.Int32&)
    IL_0006: ret

}
Vec256<uint> loadu_d256x32u(in uint src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec256`1<System.UInt32> Z0.dinx::vloadu256(System.UInt32&)
    IL_0006: ret

}
