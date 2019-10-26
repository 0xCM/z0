// 2019-10-25 21:50:49:106
bool vtestznc(Vector128<ulong> x, Vector128<ulong> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestNotZAndNotC(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0007: ret

}
bool vtestznc(Vector128<float> x, Vector128<float> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestNotZAndNotC(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0007: ret

}
bool vtestznc(Vector128<double> x, Vector128<double> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestNotZAndNotC(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0007: ret

}
bool vtestznc(Vector256<sbyte> x, Vector256<sbyte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestNotZAndNotC(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0007: ret

}
bool vtestznc(Vector256<byte> x, Vector256<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestNotZAndNotC(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0007: ret

}
bool vtestznc(Vector256<short> x, Vector256<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestNotZAndNotC(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0007: ret

}
bool vtestznc(Vector256<ushort> x, Vector256<ushort> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestNotZAndNotC(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0007: ret

}
bool vtestznc(Vector256<int> x, Vector256<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestNotZAndNotC(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0007: ret

}
bool vtestznc(Vector256<uint> x, Vector256<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestNotZAndNotC(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0007: ret

}
bool vtestznc(Vector256<long> x, Vector256<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestNotZAndNotC(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0007: ret

}
bool vtestznc(Vector256<ulong> x, Vector256<ulong> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestNotZAndNotC(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0007: ret

}
bool vtestznc(Vector256<float> x, Vector256<float> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestNotZAndNotC(System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_0007: ret

}
bool vtestznc(Vector256<double> x, Vector256<double> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestNotZAndNotC(System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_0007: ret

}
Vector256<byte> vpermvar32x8(Vector256<byte> a, Vector256<byte> spec)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.dinx::get_K0V()
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.dinx::vadd(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_000C: stloc.2
    IL_000D: ldloca.s V_2
    IL_000F: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.dinx::vshuffle(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>&)
    IL_0014: stloc.0
    IL_0015: ldarg.0
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.dinx::vswaphl(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_001B: ldarg.1
    IL_001C: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.dinx::get_K1V()
    IL_0021: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.dinx::vadd(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0026: stloc.2
    IL_0027: ldloca.s V_2
    IL_0029: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.dinx::vshuffle(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>&)
    IL_002E: stloc.1
    IL_002F: ldloc.0
    IL_0030: ldloc.1
    IL_0031: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.dinx::vor(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0036: ret

}
Vector256<byte> get_K0V()
{
    IL_0000: call System.ReadOnlySpan`1<System.Byte> Z0.dinx::get_K0Bytes()
    IL_0005: call System.Byte& modreq(System.Runtime.InteropServices.InAttribute) zfunc::head<System.Byte>(System.ReadOnlySpan`1<System.Byte>)
    IL_000A: ldloca.s V_0
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.dinx::vloadu(System.Byte&,System.Runtime.Intrinsics.Vector256`1<System.Byte>&)
    IL_0011: ret

}
Vector256<byte> get_K1V()
{
    IL_0000: call System.ReadOnlySpan`1<System.Byte> Z0.dinx::get_K1Bytes()
    IL_0005: call System.Byte& modreq(System.Runtime.InteropServices.InAttribute) zfunc::head<System.Byte>(System.ReadOnlySpan`1<System.Byte>)
    IL_000A: ldloca.s V_0
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.dinx::vloadu(System.Byte&,System.Runtime.Intrinsics.Vector256`1<System.Byte>&)
    IL_0011: ret

}
ReadOnlySpan<byte> get_K0Bytes()
{
    IL_0000: ldsflda <PrivateImplementationDetails>/__StaticArrayInitTypeSize=32 <PrivateImplementationDetails>::4A299332C06147F0009A9D8E29D782BB553EA2F4
    IL_0005: ldc.i4.s 32
    IL_0007: newobj System.Void System.ReadOnlySpan`1<System.Byte>::.ctor(System.Void*,System.Int32)
    IL_000C: ret

}
ReadOnlySpan<byte> get_K1Bytes()
{
    IL_0000: ldsflda <PrivateImplementationDetails>/__StaticArrayInitTypeSize=32 <PrivateImplementationDetails>::B1EF5D80A615BADD252B8C90AE9907B7F19690B8
    IL_0005: ldc.i4.s 32
    IL_0007: newobj System.Void System.ReadOnlySpan`1<System.Byte>::.ctor(System.Void*,System.Int32)
    IL_000C: ret

}
Vector128<byte> vrotl(Vector128<byte> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.dinx::vsll(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Byte)
    IL_0007: ldarg.0
    IL_0008: ldc.i4.8
    IL_0009: ldarg.1
    IL_000A: sub
    IL_000B: conv.u1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.dinx::vsrl(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Byte)
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.dinx::vor(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0016: ret

}
Vector128<ushort> vrotl(Vector128<ushort> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.dinx::vsll(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Byte)
    IL_0007: ldarg.0
    IL_0008: ldc.i4.s 16
    IL_000A: ldarg.1
    IL_000B: sub
    IL_000C: conv.u1
    IL_000D: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.dinx::vsrl(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Byte)
    IL_0012: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.dinx::vor(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0017: ret

}
Vector128<uint> vrotl(Vector128<uint> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.dinx::vsll(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Byte)
    IL_0007: stloc.0
    IL_0008: ldarg.0
    IL_0009: ldc.i4.s 32
    IL_000B: ldarg.1
    IL_000C: sub
    IL_000D: conv.u1
    IL_000E: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.dinx::vsrl(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Byte)
    IL_0013: stloc.1
    IL_0014: ldloc.0
    IL_0015: ldloc.1
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.dinx::vor(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_001B: ret

}
Vector128<ulong> vrotl(Vector128<ulong> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.dinx::vsll(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Byte)
    IL_0007: stloc.0
    IL_0008: ldarg.0
    IL_0009: ldc.i4.s 64
    IL_000B: ldarg.1
    IL_000C: sub
    IL_000D: conv.u1
    IL_000E: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.dinx::vsrl(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Byte)
    IL_0013: stloc.1
    IL_0014: ldloc.0
    IL_0015: ldloc.1
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.dinx::vor(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_001B: ret

}
Vector256<byte> vrotl(Vector256<byte> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.dinx::vsll(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Byte)
    IL_0007: stloc.0
    IL_0008: ldarg.0
    IL_0009: ldc.i4.8
    IL_000A: ldarg.1
    IL_000B: sub
    IL_000C: conv.u1
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.dinx::vsrl(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Byte)
    IL_0012: stloc.1
    IL_0013: ldloc.0
    IL_0014: ldloc.1
    IL_0015: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.dinx::vor(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_001A: ret

}
Vector256<ushort> vrotl(Vector256<ushort> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.dinx::vsll(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Byte)
    IL_0007: stloc.0
    IL_0008: ldarg.0
    IL_0009: ldc.i4.s 16
    IL_000B: ldarg.1
    IL_000C: sub
    IL_000D: conv.u1
    IL_000E: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.dinx::vsrl(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Byte)
    IL_0013: stloc.1
    IL_0014: ldloc.0
    IL_0015: ldloc.1
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.dinx::vor(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_001B: ret

}
Vector256<uint> vrotl(Vector256<uint> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.dinx::vsll(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Byte)
    IL_0007: stloc.0
    IL_0008: ldarg.0
    IL_0009: ldc.i4.s 32
    IL_000B: ldarg.1
    IL_000C: sub
    IL_000D: conv.u1
    IL_000E: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.dinx::vsrl(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Byte)
    IL_0013: stloc.1
    IL_0014: ldloc.0
    IL_0015: ldloc.1
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.dinx::vor(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_001B: ret

}
Vector256<ulong> vrotl(Vector256<ulong> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::vsll(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Byte)
    IL_0007: stloc.0
    IL_0008: ldarg.0
    IL_0009: ldc.i4.s 64
    IL_000B: ldarg.1
    IL_000C: sub
    IL_000D: conv.u1
    IL_000E: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::vsrl(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Byte)
    IL_0013: stloc.1
    IL_0014: ldloc.0
    IL_0015: ldloc.1
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::vor(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_001B: ret

}
Vector128<ulong> vrotl(Vector128<ulong> src, Vector128<ulong> offsets)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.dinx::vsllv(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0007: stloc.0
    IL_0008: ldarg.0
    IL_0009: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.dinx::get_Vector128u64()
    IL_000E: ldarg.1
    IL_000F: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.dinx::vsub(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0014: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.dinx::vsrlv(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0019: stloc.1
    IL_001A: ldloc.0
    IL_001B: ldloc.1
    IL_001C: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.dinx::vor(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0021: ret

}
Vector128<uint> vrotl(Vector128<uint> src, Vector128<uint> offsets)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.dinx::vsllv(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0007: stloc.0
    IL_0008: ldarg.0
    IL_0009: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.dinx::get_Vector128u32()
    IL_000E: ldarg.1
    IL_000F: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.dinx::vsub(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0014: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.dinx::vsrlv(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0019: stloc.1
    IL_001A: ldloc.0
    IL_001B: ldloc.1
    IL_001C: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.dinx::vor(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0021: ret

}
Vector256<ulong> vrotl(Vector256<ulong> src, Vector256<ulong> offsets)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::vsllv(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0007: stloc.0
    IL_0008: ldarg.0
    IL_0009: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::get_Vector256u64()
    IL_000E: ldarg.1
    IL_000F: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::vsub(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0014: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::vsrlv(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0019: stloc.1
    IL_001A: ldloc.0
    IL_001B: ldloc.1
    IL_001C: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::vor(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0021: ret

}
Vector256<uint> vrotl(Vector256<uint> src, Vector256<uint> offsets)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.dinx::vsllv(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0007: stloc.0
    IL_0008: ldarg.0
    IL_0009: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.dinx::get_Vector256u32()
    IL_000E: ldarg.1
    IL_000F: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.dinx::vsub(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0014: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.dinx::vsrlv(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0019: stloc.1
    IL_001A: ldloc.0
    IL_001B: ldloc.1
    IL_001C: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.dinx::vor(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0021: ret

}
Vector256<ulong> get_Vector256u64()
{
    IL_0000: call Z0.N256 zfunc::get_n256()
    IL_0005: ldc.i4.s 64
    IL_0007: conv.i8
    IL_0008: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::vbroadcast(Z0.N256,System.UInt64)
    IL_000D: ret

}
Vector256<uint> get_Vector256u32()
{
    IL_0000: call Z0.N256 zfunc::get_n256()
    IL_0005: ldc.i4.s 32
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.dinx::vbroadcast(Z0.N256,System.UInt32)
    IL_000C: ret

}
Vector128<ulong> get_Vector128u64()
{
    IL_0000: call Z0.N128 zfunc::get_n128()
    IL_0005: ldc.i4.s 64
    IL_0007: conv.i8
    IL_0008: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.dinx::vbroadcast(Z0.N128,System.UInt64)
    IL_000D: ret

}
Vector128<uint> get_Vector128u32()
{
    IL_0000: call Z0.N128 zfunc::get_n128()
    IL_0005: ldc.i4.s 32
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.dinx::vbroadcast(Z0.N128,System.UInt32)
    IL_000C: ret

}
Vector128<byte> vrotr(Vector128<byte> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.dinx::vsrl(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Byte)
    IL_0007: stloc.0
    IL_0008: ldarg.0
    IL_0009: ldc.i4.8
    IL_000A: ldarg.1
    IL_000B: sub
    IL_000C: conv.u1
    IL_000D: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.dinx::vsll(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Byte)
    IL_0012: stloc.1
    IL_0013: ldloc.0
    IL_0014: ldloc.1
    IL_0015: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.dinx::vor(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_001A: ret

}
Vector128<ushort> vrotr(Vector128<ushort> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.dinx::vsrl(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Byte)
    IL_0007: stloc.0
    IL_0008: ldarg.0
    IL_0009: ldc.i4.s 16
    IL_000B: ldarg.1
    IL_000C: sub
    IL_000D: conv.u1
    IL_000E: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.dinx::vsll(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Byte)
    IL_0013: stloc.1
    IL_0014: ldloc.0
    IL_0015: ldloc.1
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.dinx::vor(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_001B: ret

}
Vector128<uint> vrotr(Vector128<uint> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.dinx::vsrl(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Byte)
    IL_0007: stloc.0
    IL_0008: ldarg.0
    IL_0009: ldc.i4.s 32
    IL_000B: ldarg.1
    IL_000C: sub
    IL_000D: conv.u1
    IL_000E: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.dinx::vsll(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Byte)
    IL_0013: stloc.1
    IL_0014: ldloc.0
    IL_0015: ldloc.1
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.dinx::vor(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_001B: ret

}
Vector128<ulong> vrotr(Vector128<ulong> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.dinx::vsrl(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Byte)
    IL_0007: stloc.0
    IL_0008: ldarg.0
    IL_0009: ldc.i4.s 64
    IL_000B: ldarg.1
    IL_000C: sub
    IL_000D: conv.u1
    IL_000E: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.dinx::vsll(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Byte)
    IL_0013: stloc.1
    IL_0014: ldloc.0
    IL_0015: ldloc.1
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.dinx::vor(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_001B: ret

}
Vector256<byte> vrotr(Vector256<byte> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.dinx::vsrl(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Byte)
    IL_0007: stloc.0
    IL_0008: ldarg.0
    IL_0009: ldc.i4.8
    IL_000A: ldarg.1
    IL_000B: sub
    IL_000C: conv.u1
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.dinx::vsll(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Byte)
    IL_0012: stloc.1
    IL_0013: ldloc.0
    IL_0014: ldloc.1
    IL_0015: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.dinx::vor(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_001A: ret

}
Vector256<ushort> vrotr(Vector256<ushort> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.dinx::vsrl(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Byte)
    IL_0007: stloc.0
    IL_0008: ldarg.0
    IL_0009: ldc.i4.s 16
    IL_000B: ldarg.1
    IL_000C: sub
    IL_000D: conv.u1
    IL_000E: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.dinx::vsll(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Byte)
    IL_0013: stloc.1
    IL_0014: ldloc.0
    IL_0015: ldloc.1
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.dinx::vor(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_001B: ret

}
Vector256<uint> vrotr(Vector256<uint> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.dinx::vsrl(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Byte)
    IL_0007: stloc.0
    IL_0008: ldarg.0
    IL_0009: ldc.i4.s 32
    IL_000B: ldarg.1
    IL_000C: sub
    IL_000D: conv.u1
    IL_000E: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.dinx::vsll(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Byte)
    IL_0013: stloc.1
    IL_0014: ldloc.0
    IL_0015: ldloc.1
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.dinx::vor(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_001B: ret

}
Vector256<ulong> vrotr(Vector256<ulong> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::vsrl(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Byte)
    IL_0007: stloc.0
    IL_0008: ldarg.0
    IL_0009: ldc.i4.s 64
    IL_000B: ldarg.1
    IL_000C: sub
    IL_000D: conv.u1
    IL_000E: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::vsll(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Byte)
    IL_0013: stloc.1
    IL_0014: ldloc.0
    IL_0015: ldloc.1
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::vor(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_001B: ret

}
Vector128<uint> rotr(Vector128<uint> src, Vector128<uint> offsets)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.dinx::vsrlv(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0007: stloc.0
    IL_0008: ldarg.0
    IL_0009: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.dinx::get_Vector128u32()
    IL_000E: ldarg.1
    IL_000F: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.dinx::vsub(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0014: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.dinx::vsllv(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0019: stloc.1
    IL_001A: ldloc.0
    IL_001B: ldloc.1
    IL_001C: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.dinx::vor(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0021: ret

}
Vector128<ulong> rotr(Vector128<ulong> src, Vector128<ulong> offsets)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.dinx::vsrlv(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0007: stloc.0
    IL_0008: ldarg.0
    IL_0009: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.dinx::get_Vector128u64()
    IL_000E: ldarg.1
    IL_000F: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.dinx::vsub(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0014: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.dinx::vsllv(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0019: stloc.1
    IL_001A: ldloc.0
    IL_001B: ldloc.1
    IL_001C: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.dinx::vor(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0021: ret

}
Vector256<uint> rotr(Vector256<uint> src, Vector256<uint> offsets)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.dinx::vsrlv(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0007: stloc.0
    IL_0008: ldarg.0
    IL_0009: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.dinx::get_Vector256u32()
    IL_000E: ldarg.1
    IL_000F: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.dinx::vsub(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0014: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.dinx::vsllv(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0019: stloc.1
    IL_001A: ldloc.0
    IL_001B: ldloc.1
    IL_001C: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.dinx::vor(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0021: ret

}
Vector256<ulong> rotr(Vector256<ulong> src, Vector256<ulong> offsets)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::vsrlv(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0007: stloc.0
    IL_0008: ldarg.0
    IL_0009: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::get_Vector256u64()
    IL_000E: ldarg.1
    IL_000F: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::vsub(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0014: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::vsllv(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0019: stloc.1
    IL_001A: ldloc.0
    IL_001B: ldloc.1
    IL_001C: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::vor(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0021: ret

}
int movemask(in Vec128<float> src)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::xmm
    IL_0006: call System.Int32 System.Runtime.Intrinsics.X86.Sse::MoveMask(System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_000B: ret

}
int movemask(in Vec128<double> src)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::xmm
    IL_0006: call System.Int32 System.Runtime.Intrinsics.X86.Sse2::MoveMask(System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_000B: ret

}
int movemask(in Vec256<float> src)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::ymm
    IL_0006: call System.Int32 System.Runtime.Intrinsics.X86.Avx::MoveMask(System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_000B: ret

}
int movemask(in Vec256<double> src)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::ymm
    IL_0006: call System.Int32 System.Runtime.Intrinsics.X86.Avx::MoveMask(System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_000B: ret

}
Vector128<byte> vones_128x8u()
{
    IL_0000: ldloca.s V_0
    IL_0002: initobj System.Runtime.Intrinsics.Vector128`1<System.Byte>
    IL_0008: ldloc.0
    IL_0009: ldloca.s V_0
    IL_000B: initobj System.Runtime.Intrinsics.Vector128`1<System.Byte>
    IL_0011: ldloc.0
    IL_0012: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0017: ret

}
Vector128<sbyte> vones_128x8i()
{
    IL_0000: ldloca.s V_0
    IL_0002: initobj System.Runtime.Intrinsics.Vector128`1<System.SByte>
    IL_0008: ldloc.0
    IL_0009: ldloca.s V_0
    IL_000B: initobj System.Runtime.Intrinsics.Vector128`1<System.SByte>
    IL_0011: ldloc.0
    IL_0012: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0017: ret

}
Vector128<short> vones_128x16i()
{
    IL_0000: ldloca.s V_0
    IL_0002: initobj System.Runtime.Intrinsics.Vector128`1<System.Int16>
    IL_0008: ldloc.0
    IL_0009: ldloca.s V_0
    IL_000B: initobj System.Runtime.Intrinsics.Vector128`1<System.Int16>
    IL_0011: ldloc.0
    IL_0012: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0017: ret

}
Vector128<ushort> vones_128x16u()
{
    IL_0000: ldloca.s V_0
    IL_0002: initobj System.Runtime.Intrinsics.Vector128`1<System.UInt16>
    IL_0008: ldloc.0
    IL_0009: ldloca.s V_0
    IL_000B: initobj System.Runtime.Intrinsics.Vector128`1<System.UInt16>
    IL_0011: ldloc.0
    IL_0012: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0017: ret

}
Vector128<int> vones_128x32i()
{
    IL_0000: ldloca.s V_0
    IL_0002: initobj System.Runtime.Intrinsics.Vector128`1<System.Int32>
    IL_0008: ldloc.0
    IL_0009: ldloca.s V_0
    IL_000B: initobj System.Runtime.Intrinsics.Vector128`1<System.Int32>
    IL_0011: ldloc.0
    IL_0012: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0017: ret

}
Vector128<uint> vones_128x32u()
{
    IL_0000: ldloca.s V_0
    IL_0002: initobj System.Runtime.Intrinsics.Vector128`1<System.UInt32>
    IL_0008: ldloc.0
    IL_0009: ldloca.s V_0
    IL_000B: initobj System.Runtime.Intrinsics.Vector128`1<System.UInt32>
    IL_0011: ldloc.0
    IL_0012: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0017: ret

}
Vector128<long> vones_128x64i()
{
    IL_0000: ldloca.s V_0
    IL_0002: initobj System.Runtime.Intrinsics.Vector128`1<System.Int64>
    IL_0008: ldloc.0
    IL_0009: ldloca.s V_0
    IL_000B: initobj System.Runtime.Intrinsics.Vector128`1<System.Int64>
    IL_0011: ldloc.0
    IL_0012: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse41::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0017: ret

}
Vector128<ulong> vones_128x64u()
{
    IL_0000: ldloca.s V_0
    IL_0002: initobj System.Runtime.Intrinsics.Vector128`1<System.UInt64>
    IL_0008: ldloc.0
    IL_0009: ldloca.s V_0
    IL_000B: initobj System.Runtime.Intrinsics.Vector128`1<System.UInt64>
    IL_0011: ldloc.0
    IL_0012: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse41::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0017: ret

}
Vector256<byte> vones_256x8u()
{
    IL_0000: ldloca.s V_0
    IL_0002: initobj System.Runtime.Intrinsics.Vector256`1<System.Byte>
    IL_0008: ldloc.0
    IL_0009: ldloca.s V_0
    IL_000B: initobj System.Runtime.Intrinsics.Vector256`1<System.Byte>
    IL_0011: ldloc.0
    IL_0012: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0017: ret

}
Vector256<sbyte> vones_256x8i()
{
    IL_0000: ldloca.s V_0
    IL_0002: initobj System.Runtime.Intrinsics.Vector256`1<System.SByte>
    IL_0008: ldloc.0
    IL_0009: ldloca.s V_0
    IL_000B: initobj System.Runtime.Intrinsics.Vector256`1<System.SByte>
    IL_0011: ldloc.0
    IL_0012: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0017: ret

}
Vector256<short> vones_256x16i()
{
    IL_0000: ldloca.s V_0
    IL_0002: initobj System.Runtime.Intrinsics.Vector256`1<System.Int16>
    IL_0008: ldloc.0
    IL_0009: ldloca.s V_0
    IL_000B: initobj System.Runtime.Intrinsics.Vector256`1<System.Int16>
    IL_0011: ldloc.0
    IL_0012: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0017: ret

}
Vector256<ushort> vones_256x16u()
{
    IL_0000: ldloca.s V_0
    IL_0002: initobj System.Runtime.Intrinsics.Vector256`1<System.UInt16>
    IL_0008: ldloc.0
    IL_0009: ldloca.s V_0
    IL_000B: initobj System.Runtime.Intrinsics.Vector256`1<System.UInt16>
    IL_0011: ldloc.0
    IL_0012: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0017: ret

}
Vector256<int> vones_256x32i()
{
    IL_0000: ldloca.s V_0
    IL_0002: initobj System.Runtime.Intrinsics.Vector256`1<System.Int32>
    IL_0008: ldloc.0
    IL_0009: ldloca.s V_0
    IL_000B: initobj System.Runtime.Intrinsics.Vector256`1<System.Int32>
    IL_0011: ldloc.0
    IL_0012: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0017: ret

}
Vector256<uint> vones_256x32u()
{
    IL_0000: ldloca.s V_0
    IL_0002: initobj System.Runtime.Intrinsics.Vector256`1<System.UInt32>
    IL_0008: ldloc.0
    IL_0009: ldloca.s V_0
    IL_000B: initobj System.Runtime.Intrinsics.Vector256`1<System.UInt32>
    IL_0011: ldloc.0
    IL_0012: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0017: ret

}
Vector256<long> vones_256x64i()
{
    IL_0000: ldloca.s V_0
    IL_0002: initobj System.Runtime.Intrinsics.Vector256`1<System.Int64>
    IL_0008: ldloc.0
    IL_0009: ldloca.s V_0
    IL_000B: initobj System.Runtime.Intrinsics.Vector256`1<System.Int64>
    IL_0011: ldloc.0
    IL_0012: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0017: ret

}
Vector256<ulong> vones_256x64u()
{
    IL_0000: ldloca.s V_0
    IL_0002: initobj System.Runtime.Intrinsics.Vector256`1<System.UInt64>
    IL_0008: ldloc.0
    IL_0009: ldloca.s V_0
    IL_000B: initobj System.Runtime.Intrinsics.Vector256`1<System.UInt64>
    IL_0011: ldloc.0
    IL_0012: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0017: ret

}
Vector256<ushort> vxor1(Vector256<ushort> x)
{
    IL_0000: ldarg.0
    IL_0001: ldloca.s V_0
    IL_0003: initobj System.Runtime.Intrinsics.Vector256`1<System.UInt16>
    IL_0009: ldloc.0
    IL_000A: ldloca.s V_0
    IL_000C: initobj System.Runtime.Intrinsics.Vector256`1<System.UInt16>
    IL_0012: ldloc.0
    IL_0013: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0018: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_001D: ret

}
Vector256<int> vxor1(Vector256<int> x)
{
    IL_0000: ldarg.0
    IL_0001: ldloca.s V_0
    IL_0003: initobj System.Runtime.Intrinsics.Vector256`1<System.Int32>
    IL_0009: ldloc.0
    IL_000A: ldloca.s V_0
    IL_000C: initobj System.Runtime.Intrinsics.Vector256`1<System.Int32>
    IL_0012: ldloc.0
    IL_0013: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0018: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_001D: ret

}
Vector256<uint> vxor1(Vector256<uint> x)
{
    IL_0000: ldarg.0
    IL_0001: ldloca.s V_0
    IL_0003: initobj System.Runtime.Intrinsics.Vector256`1<System.UInt32>
    IL_0009: ldloc.0
    IL_000A: ldloca.s V_0
    IL_000C: initobj System.Runtime.Intrinsics.Vector256`1<System.UInt32>
    IL_0012: ldloc.0
    IL_0013: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0018: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_001D: ret

}
Vector256<long> vxor1(Vector256<long> x)
{
    IL_0000: ldarg.0
    IL_0001: ldloca.s V_0
    IL_0003: initobj System.Runtime.Intrinsics.Vector256`1<System.Int64>
    IL_0009: ldloc.0
    IL_000A: ldloca.s V_0
    IL_000C: initobj System.Runtime.Intrinsics.Vector256`1<System.Int64>
    IL_0012: ldloc.0
    IL_0013: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0018: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_001D: ret

}
Vector256<ulong> vxor1(Vector256<ulong> x)
{
    IL_0000: ldarg.0
    IL_0001: ldloca.s V_0
    IL_0003: initobj System.Runtime.Intrinsics.Vector256`1<System.UInt64>
    IL_0009: ldloc.0
    IL_000A: ldloca.s V_0
    IL_000C: initobj System.Runtime.Intrinsics.Vector256`1<System.UInt64>
    IL_0012: ldloc.0
    IL_0013: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0018: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_001D: ret

}
Vector128<ushort> vxorsl(Vector128<ushort> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.dinx::vsll(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Byte)
    IL_0008: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.dinx::vxor(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_000D: ret

}
Vector128<uint> vxorsl(Vector128<uint> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.dinx::vsll(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Byte)
    IL_0008: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.dinx::vxor(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_000D: ret

}
Vector128<ulong> vxorsl(Vector128<ulong> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.dinx::vsll(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Byte)
    IL_0008: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.dinx::vxor(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_000D: ret

}
Vector256<ushort> vxorsl(Vector256<ushort> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.dinx::vsll(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Byte)
    IL_0008: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.dinx::vxor(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_000D: ret

}
Vector256<uint> vxorsl(Vector256<uint> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.dinx::vsll(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Byte)
    IL_0008: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.dinx::vxor(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_000D: ret

}
Vector256<ulong> vxorsl(Vector256<ulong> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::vsll(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Byte)
    IL_0008: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::vxor(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_000D: ret

}
Vector128<uint> vxorslv(Vector128<uint> src, Vector128<uint> offsets)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.dinx::vsllv(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0008: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.dinx::vxor(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_000D: ret

}
Vector128<ulong> vxorslv(Vector128<ulong> src, Vector128<ulong> offsets)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.dinx::vsllv(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0008: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.dinx::vxor(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_000D: ret

}
Vector256<uint> vxorslv(Vector256<uint> src, Vector256<uint> offsets)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.dinx::vsllv(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0008: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.dinx::vxor(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_000D: ret

}
Vector256<ulong> vxorslv(Vector256<ulong> src, Vector256<ulong> offsets)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::vsllv(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0008: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::vxor(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_000D: ret

}
Vector128<ushort> vxorsr(Vector128<ushort> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.dinx::vsrl(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Byte)
    IL_0008: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.dinx::vxor(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_000D: ret

}
Vector128<uint> vxorsr(Vector128<uint> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.dinx::vsrl(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Byte)
    IL_0008: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.dinx::vxor(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_000D: ret

}
Vector128<ulong> vxorsr(Vector128<ulong> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.dinx::vsrl(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Byte)
    IL_0008: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.dinx::vxor(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_000D: ret

}
Vector256<ushort> vxorsr(Vector256<ushort> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.dinx::vsrl(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Byte)
    IL_0008: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.dinx::vxor(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_000D: ret

}
Vector256<uint> vxorsr(Vector256<uint> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.dinx::vsrl(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Byte)
    IL_0008: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.dinx::vxor(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_000D: ret

}
Vector256<ulong> vxorsr(Vector256<ulong> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::vsrl(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Byte)
    IL_0008: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::vxor(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_000D: ret

}
Vector128<uint> vxorsrv(Vector128<uint> src, Vector128<uint> offsets)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.dinx::vsrlv(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0008: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.dinx::vxor(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_000D: ret

}
Vector128<ulong> vxorsrv(Vector128<ulong> src, Vector128<ulong> offsets)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.dinx::vsrlv(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0008: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.dinx::vxor(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_000D: ret

}
Vector256<uint> vxorsrv(Vector256<uint> src, Vector256<uint> offsets)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.dinx::vsrlv(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0008: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.dinx::vxor(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_000D: ret

}
Vector256<ulong> vxorsrv(Vector256<ulong> src, Vector256<ulong> offsets)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::vsrlv(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0008: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::vxor(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_000D: ret

}
Vector128<sbyte> vcmpeq(Vector128<sbyte> lhs, Vector128<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0007: ret

}
Vector128<byte> vcmpeq(Vector128<byte> lhs, Vector128<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0007: ret

}
Vector128<short> vcmpeq(Vector128<short> lhs, Vector128<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0007: ret

}
Vector128<ushort> vcmpeq(Vector128<ushort> lhs, Vector128<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0007: ret

}
Vector128<int> vcmpeq(Vector128<int> lhs, Vector128<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0007: ret

}
Vector128<uint> vcmpeq(Vector128<uint> lhs, Vector128<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0007: ret

}
Vector128<long> vcmpeq(Vector128<long> lhs, Vector128<long> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse41::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0007: ret

}
Vector128<ulong> vcmpeq(Vector128<ulong> lhs, Vector128<ulong> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse41::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0007: ret

}
Vector256<sbyte> vcmpeq(Vector256<sbyte> lhs, Vector256<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0007: ret

}
Vector256<byte> vcmpeq(Vector256<byte> lhs, Vector256<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0007: ret

}
Vector256<short> vcmpeq(Vector256<short> lhs, Vector256<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0007: ret

}
Vector256<ushort> vcmpeq(Vector256<ushort> lhs, Vector256<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0007: ret

}
Vector256<int> vcmpeq(Vector256<int> lhs, Vector256<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0007: ret

}
Vector256<uint> vcmpeq(Vector256<uint> lhs, Vector256<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0007: ret

}
Vector256<long> vcmpeq(Vector256<long> lhs, Vector256<long> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0007: ret

}
Vector256<ulong> vcmpeq(Vector256<ulong> lhs, Vector256<ulong> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0007: ret

}
Vector128<sbyte> vcmpgt(Vector128<sbyte> x, Vector128<sbyte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::CompareGreaterThan(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0007: ret

}
Vector128<byte> vcmpgt(Vector128<byte> x, Vector128<byte> y)
{
    IL_0000: call Z0.N128 zfunc::get_n128()
    IL_0005: ldc.i4 128
    IL_000A: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.dinx::vbroadcast(Z0.N128,System.Byte)
    IL_000F: stloc.0
    IL_0010: ldarg.0
    IL_0011: ldloc.0
    IL_0012: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.dinx::vxor(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0017: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.Vector128::AsSByte<System.Byte>(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_001C: stloc.1
    IL_001D: ldarg.1
    IL_001E: ldloc.0
    IL_001F: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.dinx::vxor(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0024: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.Vector128::AsSByte<System.Byte>(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0029: stloc.2
    IL_002A: ldloc.1
    IL_002B: ldloc.2
    IL_002C: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::CompareGreaterThan(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0031: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.Vector128::AsByte<System.SByte>(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0036: ret

}
Vector128<short> vcmpgt(Vector128<short> x, Vector128<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::CompareGreaterThan(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0007: ret

}
Vector128<ushort> vcmpgt(Vector128<ushort> x, Vector128<ushort> y)
{
    IL_0000: call Z0.N128 zfunc::get_n128()
    IL_0005: ldc.i4 32768
    IL_000A: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.dinx::vbroadcast(Z0.N128,System.UInt16)
    IL_000F: stloc.0
    IL_0010: ldarg.0
    IL_0011: ldloc.0
    IL_0012: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.dinx::vxor(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0017: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.Vector128::AsInt16<System.UInt16>(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_001C: stloc.1
    IL_001D: ldarg.1
    IL_001E: ldloc.0
    IL_001F: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.dinx::vxor(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0024: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.Vector128::AsInt16<System.UInt16>(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0029: stloc.2
    IL_002A: ldloc.1
    IL_002B: ldloc.2
    IL_002C: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::CompareGreaterThan(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0031: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.Vector128::AsUInt16<System.Int16>(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0036: ret

}
Vector128<int> vcmpgt(Vector128<int> x, Vector128<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::CompareGreaterThan(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0007: ret

}
Vector128<uint> vcmpgt(Vector128<uint> x, Vector128<uint> y)
{
    IL_0000: call Z0.N128 zfunc::get_n128()
    IL_0005: ldc.i4 -2147483648
    IL_000A: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.dinx::vbroadcast(Z0.N128,System.UInt32)
    IL_000F: stloc.0
    IL_0010: ldarg.0
    IL_0011: ldloc.0
    IL_0012: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.dinx::vxor(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0017: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.Vector128::AsInt32<System.UInt32>(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_001C: stloc.1
    IL_001D: ldarg.1
    IL_001E: ldloc.0
    IL_001F: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.dinx::vxor(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0024: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.Vector128::AsInt32<System.UInt32>(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0029: stloc.2
    IL_002A: ldloc.1
    IL_002B: ldloc.2
    IL_002C: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::CompareGreaterThan(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0031: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.Vector128::AsUInt32<System.Int32>(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0036: ret

}
Vector128<long> vcmpgt(Vector128<long> x, Vector128<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldloca.s V_2
    IL_0003: initobj System.Runtime.Intrinsics.Vector256`1<System.Int64>
    IL_0009: ldloc.2
    IL_000A: ldc.i4.0
    IL_000B: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.ginx::vinsert<System.Int64>(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Byte)
    IL_0010: stloc.0
    IL_0011: ldarg.1
    IL_0012: ldloca.s V_2
    IL_0014: initobj System.Runtime.Intrinsics.Vector256`1<System.Int64>
    IL_001A: ldloc.2
    IL_001B: ldc.i4.0
    IL_001C: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.ginx::vinsert<System.Int64>(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Byte)
    IL_0021: stloc.1
    IL_0022: ldloc.0
    IL_0023: ldloc.1
    IL_0024: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.dinx::vcmpgt(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0029: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.ginx::vlo<System.Int64>(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_002E: ret

}
Vector128<ulong> vcmpgt(Vector128<ulong> x, Vector128<ulong> y)
{
    IL_0000: ldarg.0
    IL_0001: ldloca.s V_2
    IL_0003: initobj System.Runtime.Intrinsics.Vector256`1<System.UInt64>
    IL_0009: ldloc.2
    IL_000A: ldc.i4.0
    IL_000B: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.ginx::vinsert<System.UInt64>(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Byte)
    IL_0010: stloc.0
    IL_0011: ldarg.1
    IL_0012: ldloca.s V_2
    IL_0014: initobj System.Runtime.Intrinsics.Vector256`1<System.UInt64>
    IL_001A: ldloc.2
    IL_001B: ldc.i4.0
    IL_001C: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.ginx::vinsert<System.UInt64>(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Byte)
    IL_0021: stloc.1
    IL_0022: ldloc.0
    IL_0023: ldloc.1
    IL_0024: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::vcmpgt(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0029: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.ginx::vlo<System.UInt64>(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_002E: ret

}
Vector256<sbyte> vcmpgt(Vector256<sbyte> x, Vector256<sbyte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::CompareGreaterThan(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0007: ret

}
Vector256<byte> vcmpgt(Vector256<byte> x, Vector256<byte> y)
{
    IL_0000: call Z0.N256 zfunc::get_n256()
    IL_0005: ldc.i4 128
    IL_000A: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.dinx::vbroadcast(Z0.N256,System.Byte)
    IL_000F: stloc.0
    IL_0010: ldarg.0
    IL_0011: ldloc.0
    IL_0012: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.dinx::vxor(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0017: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.Vector256::AsSByte<System.Byte>(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_001C: stloc.1
    IL_001D: ldarg.1
    IL_001E: ldloc.0
    IL_001F: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.dinx::vxor(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0024: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.Vector256::AsSByte<System.Byte>(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0029: stloc.2
    IL_002A: ldloc.1
    IL_002B: ldloc.2
    IL_002C: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::CompareGreaterThan(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0031: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.Vector256::AsByte<System.SByte>(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0036: ret

}
Vector256<short> vcmpgt(Vector256<short> x, Vector256<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::CompareGreaterThan(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0007: ret

}
Vector256<ushort> vcmpgt(Vector256<ushort> x, Vector256<ushort> y)
{
    IL_0000: call Z0.N256 zfunc::get_n256()
    IL_0005: ldc.i4 32768
    IL_000A: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.dinx::vbroadcast(Z0.N256,System.UInt16)
    IL_000F: stloc.0
    IL_0010: ldarg.0
    IL_0011: ldloc.0
    IL_0012: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.dinx::vxor(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0017: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.Vector256::AsInt16<System.UInt16>(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_001C: stloc.1
    IL_001D: ldarg.1
    IL_001E: ldloc.0
    IL_001F: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.dinx::vxor(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0024: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.Vector256::AsInt16<System.UInt16>(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0029: stloc.2
    IL_002A: ldloc.1
    IL_002B: ldloc.2
    IL_002C: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::CompareGreaterThan(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0031: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.Vector256::AsUInt16<System.Int16>(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0036: ret

}
Vector256<int> vcmpgt(Vector256<int> x, Vector256<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::CompareGreaterThan(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0007: ret

}
Vector256<uint> vcmpgt(Vector256<uint> x, Vector256<uint> y)
{
    IL_0000: call Z0.N256 zfunc::get_n256()
    IL_0005: ldc.i4 -2147483648
    IL_000A: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.dinx::vbroadcast(Z0.N256,System.UInt32)
    IL_000F: stloc.0
    IL_0010: ldarg.0
    IL_0011: ldloc.0
    IL_0012: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.dinx::vxor(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0017: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.Vector256::AsInt32<System.UInt32>(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_001C: stloc.1
    IL_001D: ldarg.1
    IL_001E: ldloc.0
    IL_001F: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.dinx::vxor(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0024: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.Vector256::AsInt32<System.UInt32>(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0029: stloc.2
    IL_002A: ldloc.1
    IL_002B: ldloc.2
    IL_002C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::CompareGreaterThan(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0031: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.Vector256::AsUInt32<System.Int32>(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0036: ret

}
Vector256<long> vcmpgt(Vector256<long> x, Vector256<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::CompareGreaterThan(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0007: ret

}
Vector256<ulong> vcmpgt(Vector256<ulong> x, Vector256<ulong> y)
{
    IL_0000: call Z0.N256 zfunc::get_n256()
    IL_0005: ldc.i8 -9223372036854775808
    IL_000E: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::vbroadcast(Z0.N256,System.UInt64)
    IL_0013: stloc.0
    IL_0014: ldarg.0
    IL_0015: ldloc.0
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::vxor(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_001B: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.Vector256::AsInt64<System.UInt64>(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0020: stloc.1
    IL_0021: ldarg.1
    IL_0022: ldloc.0
    IL_0023: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::vxor(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0028: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.Vector256::AsInt64<System.UInt64>(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_002D: stloc.2
    IL_002E: ldloc.1
    IL_002F: ldloc.2
    IL_0030: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::CompareGreaterThan(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0035: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.Vector256::AsUInt64<System.Int64>(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_003A: ret

}
Vector128<sbyte> vcmplt(Vector128<sbyte> x, Vector128<sbyte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::CompareLessThan(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0007: ret

}
Vector128<byte> vcmplt(Vector128<byte> x, Vector128<byte> y)
{
    IL_0000: call Z0.N128 zfunc::get_n128()
    IL_0005: ldc.i4 128
    IL_000A: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.dinx::vbroadcast(Z0.N128,System.Byte)
    IL_000F: stloc.0
    IL_0010: ldarg.0
    IL_0011: ldloc.0
    IL_0012: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.dinx::vxor(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0017: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.Vector128::AsSByte<System.Byte>(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_001C: stloc.1
    IL_001D: ldarg.1
    IL_001E: ldloc.0
    IL_001F: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.dinx::vxor(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0024: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.Vector128::AsSByte<System.Byte>(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0029: stloc.2
    IL_002A: ldloc.1
    IL_002B: ldloc.2
    IL_002C: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::CompareLessThan(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0031: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.Vector128::AsByte<System.SByte>(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0036: ret

}
Vector128<short> vcmplt(Vector128<short> x, Vector128<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::CompareLessThan(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0007: ret

}
Vector128<ushort> vcmplt(Vector128<ushort> x, Vector128<ushort> y)
{
    IL_0000: call Z0.N128 zfunc::get_n128()
    IL_0005: ldc.i4 32768
    IL_000A: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.dinx::vbroadcast(Z0.N128,System.UInt16)
    IL_000F: stloc.0
    IL_0010: ldarg.0
    IL_0011: ldloc.0
    IL_0012: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.dinx::vxor(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0017: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.Vector128::AsInt16<System.UInt16>(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_001C: stloc.1
    IL_001D: ldarg.1
    IL_001E: ldloc.0
    IL_001F: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.dinx::vxor(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0024: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.Vector128::AsInt16<System.UInt16>(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0029: stloc.2
    IL_002A: ldloc.1
    IL_002B: ldloc.2
    IL_002C: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::CompareLessThan(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0031: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.Vector128::AsUInt16<System.Int16>(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0036: ret

}
Vector128<int> vcmplt(Vector128<int> x, Vector128<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::CompareLessThan(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0007: ret

}
Vector128<uint> vcmplt(Vector128<uint> x, Vector128<uint> y)
{
    IL_0000: call Z0.N128 zfunc::get_n128()
    IL_0005: ldc.i4 -2147483648
    IL_000A: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.dinx::vbroadcast(Z0.N128,System.UInt32)
    IL_000F: stloc.0
    IL_0010: ldarg.0
    IL_0011: ldloc.0
    IL_0012: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.dinx::vxor(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0017: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.Vector128::AsInt32<System.UInt32>(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_001C: stloc.1
    IL_001D: ldarg.1
    IL_001E: ldloc.0
    IL_001F: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.dinx::vxor(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0024: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.Vector128::AsInt32<System.UInt32>(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0029: stloc.2
    IL_002A: ldloc.1
    IL_002B: ldloc.2
    IL_002C: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::CompareLessThan(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0031: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.Vector128::AsUInt32<System.Int32>(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0036: ret

}
Vector128<long> vcmplt(Vector128<long> x, Vector128<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldloca.s V_2
    IL_0003: initobj System.Runtime.Intrinsics.Vector256`1<System.Int64>
    IL_0009: ldloc.2
    IL_000A: ldc.i4.0
    IL_000B: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.ginx::vinsert<System.Int64>(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Byte)
    IL_0010: stloc.0
    IL_0011: ldarg.1
    IL_0012: ldloca.s V_2
    IL_0014: initobj System.Runtime.Intrinsics.Vector256`1<System.Int64>
    IL_001A: ldloc.2
    IL_001B: ldc.i4.0
    IL_001C: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.ginx::vinsert<System.Int64>(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Byte)
    IL_0021: stloc.1
    IL_0022: ldloc.0
    IL_0023: ldloc.1
    IL_0024: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.dinx::vcmplt(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0029: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.ginx::vlo<System.Int64>(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_002E: ret

}
Vector128<ulong> vcmplt(Vector128<ulong> x, Vector128<ulong> y)
{
    IL_0000: ldarg.0
    IL_0001: ldloca.s V_2
    IL_0003: initobj System.Runtime.Intrinsics.Vector256`1<System.UInt64>
    IL_0009: ldloc.2
    IL_000A: ldc.i4.0
    IL_000B: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.ginx::vinsert<System.UInt64>(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Byte)
    IL_0010: stloc.0
    IL_0011: ldarg.1
    IL_0012: ldloca.s V_2
    IL_0014: initobj System.Runtime.Intrinsics.Vector256`1<System.UInt64>
    IL_001A: ldloc.2
    IL_001B: ldc.i4.0
    IL_001C: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.ginx::vinsert<System.UInt64>(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Byte)
    IL_0021: stloc.1
    IL_0022: ldloc.0
    IL_0023: ldloc.1
    IL_0024: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::vcmplt(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0029: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.ginx::vlo<System.UInt64>(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_002E: ret

}
Vector256<sbyte> vcmplt(Vector256<sbyte> x, Vector256<sbyte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.X86Missing::CompareLessThan(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0007: ret

}
Vector256<byte> vcmplt(Vector256<byte> x, Vector256<byte> y)
{
    IL_0000: call Z0.N256 zfunc::get_n256()
    IL_0005: ldc.i4 128
    IL_000A: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.dinx::vbroadcast(Z0.N256,System.Byte)
    IL_000F: stloc.0
    IL_0010: ldarg.0
    IL_0011: ldloc.0
    IL_0012: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.dinx::vxor(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0017: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.Vector256::AsSByte<System.Byte>(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_001C: stloc.1
    IL_001D: ldarg.1
    IL_001E: ldloc.0
    IL_001F: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.dinx::vxor(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0024: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.Vector256::AsSByte<System.Byte>(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0029: stloc.2
    IL_002A: ldloc.1
    IL_002B: ldloc.2
    IL_002C: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.X86Missing::CompareLessThan(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0031: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.Vector256::AsByte<System.SByte>(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0036: ret

}
Vector256<short> vcmplt(Vector256<short> x, Vector256<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.X86Missing::CompareLessThan(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0007: ret

}
Vector256<ushort> vcmplt(Vector256<ushort> x, Vector256<ushort> y)
{
    IL_0000: call Z0.N256 zfunc::get_n256()
    IL_0005: ldc.i4 32768
    IL_000A: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.dinx::vbroadcast(Z0.N256,System.UInt16)
    IL_000F: stloc.0
    IL_0010: ldarg.0
    IL_0011: ldloc.0
    IL_0012: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.dinx::vxor(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0017: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.Vector256::AsInt16<System.UInt16>(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_001C: stloc.1
    IL_001D: ldarg.1
    IL_001E: ldloc.0
    IL_001F: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.dinx::vxor(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0024: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.Vector256::AsInt16<System.UInt16>(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0029: stloc.2
    IL_002A: ldloc.1
    IL_002B: ldloc.2
    IL_002C: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.X86Missing::CompareLessThan(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0031: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.Vector256::AsUInt16<System.Int16>(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0036: ret

}
Vector256<int> vcmplt(Vector256<int> x, Vector256<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.X86Missing::CompareLessThan(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0007: ret

}
Vector256<uint> vcmplt(Vector256<uint> x, Vector256<uint> y)
{
    IL_0000: call Z0.N256 zfunc::get_n256()
    IL_0005: ldc.i4 -2147483648
    IL_000A: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.dinx::vbroadcast(Z0.N256,System.UInt32)
    IL_000F: stloc.0
    IL_0010: ldarg.0
    IL_0011: ldloc.0
    IL_0012: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.dinx::vxor(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0017: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.Vector256::AsInt32<System.UInt32>(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_001C: stloc.1
    IL_001D: ldarg.1
    IL_001E: ldloc.0
    IL_001F: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.dinx::vxor(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0024: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.Vector256::AsInt32<System.UInt32>(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0029: stloc.2
    IL_002A: ldloc.1
    IL_002B: ldloc.2
    IL_002C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.X86Missing::CompareLessThan(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0031: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.Vector256::AsUInt32<System.Int32>(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0036: ret

}
Vector256<long> vcmplt(Vector256<long> x, Vector256<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.X86Missing::CompareLessThan(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0007: ret

}
Vector256<ulong> vcmplt(Vector256<ulong> x, Vector256<ulong> y)
{
    IL_0000: call Z0.N256 zfunc::get_n256()
    IL_0005: ldc.i8 -9223372036854775808
    IL_000E: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::vbroadcast(Z0.N256,System.UInt64)
    IL_0013: stloc.0
    IL_0014: ldarg.0
    IL_0015: ldloc.0
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::vxor(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_001B: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.Vector256::AsInt64<System.UInt64>(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0020: stloc.1
    IL_0021: ldarg.1
    IL_0022: ldloc.0
    IL_0023: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::vxor(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0028: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.Vector256::AsInt64<System.UInt64>(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_002D: stloc.2
    IL_002E: ldloc.1
    IL_002F: ldloc.2
    IL_0030: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.X86Missing::CompareLessThan(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0035: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.Vector256::AsUInt64<System.Int64>(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_003A: ret

}
bool vtestc(Vector128<sbyte> src, Vector128<sbyte> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestC(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0007: ret

}
bool vtestc(Vector128<byte> src, Vector128<byte> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestC(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0007: ret

}
bool vtestc(Vector128<short> src, Vector128<short> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestC(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0007: ret

}
bool vtestc(Vector128<ushort> src, Vector128<ushort> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestC(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0007: ret

}
bool vtestc(Vector128<int> src, Vector128<int> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestC(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0007: ret

}
bool vtestc(Vector128<uint> src, Vector128<uint> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestC(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0007: ret

}
bool vtestc(Vector128<long> src, Vector128<long> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestC(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0007: ret

}
bool vtestc(Vector128<ulong> src, Vector128<ulong> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestC(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0007: ret

}
bool vtestc(Vector256<sbyte> src, Vector256<sbyte> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestC(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0007: ret

}
bool vtestc(Vector256<byte> src, Vector256<byte> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestC(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0007: ret

}
bool vtestc(Vector256<short> src, Vector256<short> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestC(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0007: ret

}
bool vtestc(Vector256<ushort> src, Vector256<ushort> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestC(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0007: ret

}
bool vtestc(Vector256<int> src, Vector256<int> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestC(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0007: ret

}
bool vtestc(Vector256<uint> src, Vector256<uint> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestC(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0007: ret

}
bool vtestc(Vector256<long> src, Vector256<long> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestC(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0007: ret

}
bool vtestc(Vector256<ulong> src, Vector256<ulong> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestC(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0007: ret

}
bool testz(in Vec128<byte> src, in Vec128<byte> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::xmm
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestZ(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0011: ret

}
bool testz(in Vec128<sbyte> src, in Vec128<sbyte> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::xmm
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestZ(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0011: ret

}
bool testz(in Vec128<short> src, in Vec128<short> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::xmm
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestZ(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0011: ret

}
bool testz(in Vec128<ushort> src, in Vec128<ushort> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::xmm
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestZ(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0011: ret

}
bool testz(in Vec128<int> src, in Vec128<int> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::xmm
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestZ(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0011: ret

}
bool testz(in Vec128<uint> src, in Vec128<uint> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::xmm
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestZ(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0011: ret

}
bool testz(in Vec128<long> src, in Vec128<long> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::xmm
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestZ(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0011: ret

}
bool testz(in Vec128<ulong> src, in Vec128<ulong> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::xmm
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestZ(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0011: ret

}
bool testz(in Vec256<sbyte> src, in Vec256<sbyte> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::ymm
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestZ(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0011: ret

}
bool testz(in Vec256<byte> src, in Vec256<byte> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::ymm
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestZ(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0011: ret

}
bool testz(in Vec256<short> src, in Vec256<short> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::ymm
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestZ(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0011: ret

}
bool testz(in Vec256<ushort> src, in Vec256<ushort> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::ymm
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestZ(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0011: ret

}
bool testz(in Vec256<ulong> src, in Vec256<ulong> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::ymm
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestZ(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0011: ret

}
bool testz(Vector128<byte> src, Vector128<byte> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestZ(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0007: ret

}
bool testz(Vector128<sbyte> src, Vector128<sbyte> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestZ(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0007: ret

}
bool testz(Vector128<short> src, Vector128<short> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestZ(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0007: ret

}
bool testz(Vector128<ushort> src, Vector128<ushort> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestZ(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0007: ret

}
bool testz(Vector128<int> src, Vector128<int> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestZ(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0007: ret

}
bool testz(Vector128<uint> src, Vector128<uint> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestZ(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0007: ret

}
bool testz(Vector128<long> src, Vector128<long> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestZ(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0007: ret

}
bool testz(Vector128<ulong> src, Vector128<ulong> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestZ(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0007: ret

}
bool testz(Vector256<sbyte> src, Vector256<sbyte> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestZ(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0007: ret

}
bool testz(Vector256<byte> src, Vector256<byte> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestZ(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0007: ret

}
bool testz(Vector256<short> src, Vector256<short> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestZ(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0007: ret

}
bool testz(Vector256<ushort> src, Vector256<ushort> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestZ(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0007: ret

}
bool testz(Vector256<int> src, Vector256<int> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestZ(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0007: ret

}
bool testz(Vector256<uint> src, Vector256<uint> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestZ(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0007: ret

}
bool testz(Vector256<long> src, Vector256<long> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestZ(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0007: ret

}
bool testz(Vector256<ulong> src, Vector256<ulong> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestZ(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0007: ret

}
bool vtestznc(Vector128<sbyte> x, Vector128<sbyte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestNotZAndNotC(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0007: ret

}
bool vtestznc(Vector128<byte> x, Vector128<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestNotZAndNotC(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0007: ret

}
bool vtestznc(Vector128<short> x, Vector128<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestNotZAndNotC(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0007: ret

}
bool vtestznc(Vector128<ushort> x, Vector128<ushort> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestNotZAndNotC(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0007: ret

}
bool vtestznc(Vector128<int> x, Vector128<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestNotZAndNotC(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0007: ret

}
bool vtestznc(Vector128<uint> x, Vector128<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestNotZAndNotC(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0007: ret

}
bool vtestznc(Vector128<long> x, Vector128<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestNotZAndNotC(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0007: ret

}
Vector256<long> vnot(Vector256<long> src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldarg.0
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0008: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_000D: ret

}
Vector256<ulong> vnot(Vector256<ulong> src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldarg.0
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0008: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_000D: ret

}
Vec128<byte> vor(in Vec128<byte> x, in Vec128<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::Or(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0011: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0016: ret

}
Vec128<short> vor(in Vec128<short> x, in Vec128<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::Or(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0011: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0016: ret

}
Vec128<sbyte> vor(in Vec128<sbyte> x, in Vec128<sbyte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::Or(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0011: call Z0.Vec128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0016: ret

}
Vec128<ushort> vor(in Vec128<ushort> x, in Vec128<ushort> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::Or(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0011: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0016: ret

}
Vec128<int> vor(in Vec128<int> x, in Vec128<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::Or(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0011: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0016: ret

}
Vec128<uint> vor(in Vec128<uint> x, in Vec128<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::Or(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0011: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0016: ret

}
Vec128<long> vor(in Vec128<long> x, in Vec128<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse2::Or(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0011: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0016: ret

}
Vec128<ulong> vor(in Vec128<ulong> x, in Vec128<ulong> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::Or(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0011: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0016: ret

}
Vec256<byte> vor(in Vec256<byte> x, in Vec256<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::Or(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0011: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0016: ret

}
Vec256<short> vor(in Vec256<short> x, in Vec256<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::Or(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0011: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0016: ret

}
Vec256<sbyte> vor(in Vec256<sbyte> x, in Vec256<sbyte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::Or(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0011: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0016: ret

}
Vec256<ushort> vor(in Vec256<ushort> x, in Vec256<ushort> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::Or(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0011: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0016: ret

}
Vec256<int> vor(in Vec256<int> x, in Vec256<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::Or(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0016: ret

}
Vec256<uint> vor(in Vec256<uint> x, in Vec256<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::Or(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0011: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0016: ret

}
Vec256<long> vor(in Vec256<long> x, in Vec256<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::Or(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0011: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0016: ret

}
Vec256<ulong> vor(in Vec256<ulong> x, in Vec256<ulong> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::Or(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0011: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0016: ret

}
Vector128<byte> vor(Vector128<byte> x, Vector128<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::Or(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0007: ret

}
Vector128<short> vor(Vector128<short> x, Vector128<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::Or(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0007: ret

}
Vector128<sbyte> vor(Vector128<sbyte> x, Vector128<sbyte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::Or(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0007: ret

}
Vector128<ushort> vor(Vector128<ushort> x, Vector128<ushort> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::Or(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0007: ret

}
Vector128<int> vor(Vector128<int> x, Vector128<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::Or(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0007: ret

}
Vector128<uint> vor(Vector128<uint> x, Vector128<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::Or(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0007: ret

}
Vector128<long> vor(Vector128<long> x, Vector128<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse2::Or(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0007: ret

}
Vector128<ulong> vor(Vector128<ulong> x, Vector128<ulong> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::Or(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0007: ret

}
Vector256<byte> vor(Vector256<byte> x, Vector256<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::Or(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0007: ret

}
Vector256<short> vor(Vector256<short> x, Vector256<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::Or(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0007: ret

}
Vector256<sbyte> vor(Vector256<sbyte> x, Vector256<sbyte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::Or(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0007: ret

}
Vector256<ushort> vor(Vector256<ushort> x, Vector256<ushort> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::Or(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0007: ret

}
Vector256<int> vor(Vector256<int> x, Vector256<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::Or(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0007: ret

}
Vector256<uint> vor(Vector256<uint> x, Vector256<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::Or(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0007: ret

}
Vector256<long> vor(Vector256<long> x, Vector256<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::Or(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0007: ret

}
Vector256<ulong> vor(Vector256<ulong> x, Vector256<ulong> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::Or(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0007: ret

}
Vector128<byte> vsll(Vector128<byte> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.dinxc::vsll(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Byte)
    IL_0007: ret

}
Vector128<sbyte> vsll(Vector128<sbyte> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.Vector128::AsByte<System.SByte>(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.dinx::vsll(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Byte)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.Vector128::AsSByte<System.Byte>(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0011: ret

}
Vector256<sbyte> vsll(Vector256<sbyte> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.Vector256::AsByte<System.SByte>(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.dinx::vsll(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Byte)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.Vector256::AsSByte<System.Byte>(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0011: ret

}
Vector128<ushort> vsll(Vector128<ushort> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::ShiftLeftLogical(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Byte)
    IL_0007: ret

}
Vector128<int> vsll(Vector128<int> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::ShiftLeftLogical(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Byte)
    IL_0007: ret

}
Vector128<uint> vsll(Vector128<uint> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::ShiftLeftLogical(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Byte)
    IL_0007: ret

}
Vector128<long> vsll(Vector128<long> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse2::ShiftLeftLogical(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Byte)
    IL_0007: ret

}
Vector128<ulong> vsll(Vector128<ulong> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::ShiftLeftLogical(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Byte)
    IL_0007: ret

}
Vector256<byte> vsll(Vector256<byte> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.dinxc::vsll(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Byte)
    IL_0007: ret

}
Vector128<short> vsll(Vector128<short> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::ShiftLeftLogical(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Byte)
    IL_0007: ret

}
Vector256<short> vsll(Vector256<short> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::ShiftLeftLogical(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Byte)
    IL_0007: ret

}
Vector256<ushort> vsll(Vector256<ushort> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::ShiftLeftLogical(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Byte)
    IL_0007: ret

}
Vector256<int> vsll(Vector256<int> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::ShiftLeftLogical(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Byte)
    IL_0007: ret

}
Vector256<uint> vsll(Vector256<uint> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::ShiftLeftLogical(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Byte)
    IL_0007: ret

}
Vector256<long> vsll(Vector256<long> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::ShiftLeftLogical(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Byte)
    IL_0007: ret

}
Vector256<ulong> vsll(Vector256<ulong> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::ShiftLeftLogical(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Byte)
    IL_0007: ret

}
Vector128<int> vsllv(Vector128<int> src, Vector128<uint> offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::ShiftLeftLogicalVariable(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0007: ret

}
Vector128<uint> vsllv(Vector128<uint> src, Vector128<uint> offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::ShiftLeftLogicalVariable(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0007: ret

}
Vector128<long> vsllv(Vector128<long> src, Vector128<ulong> offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::ShiftLeftLogicalVariable(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0007: ret

}
Vector128<ulong> vsllv(Vector128<ulong> src, Vector128<ulong> offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::ShiftLeftLogicalVariable(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0007: ret

}
Vector256<int> vsllv(Vector256<int> src, Vector256<uint> offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::ShiftLeftLogicalVariable(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0007: ret

}
Vector256<uint> vsllv(Vector256<uint> src, Vector256<uint> offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::ShiftLeftLogicalVariable(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0007: ret

}
Vector256<long> vsllv(Vector256<long> src, Vector256<ulong> offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::ShiftLeftLogicalVariable(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0007: ret

}
Vector256<ulong> vsllv(Vector256<ulong> src, Vector256<ulong> offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::ShiftLeftLogicalVariable(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0007: ret

}
Vector256<short> vsra(Vector256<short> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::ShiftRightArithmetic(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Byte)
    IL_0007: ret

}
Vector256<int> vsra(Vector256<int> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::ShiftRightArithmetic(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Byte)
    IL_0007: ret

}
Vector128<int> vsrav(Vector128<int> src, Vector128<uint> control)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::ShiftRightArithmeticVariable(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0007: ret

}
Vector256<int> vsrav(Vector256<int> src, Vector256<uint> control)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::ShiftRightArithmeticVariable(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0007: ret

}
Vector128<byte> vsrl(Vector128<byte> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.dinxc::vsrl(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Byte)
    IL_0007: ret

}
Vector128<sbyte> vsrl(Vector128<sbyte> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.Vector128::AsByte<System.SByte>(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.dinx::vsrl(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Byte)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.Vector128::AsSByte<System.Byte>(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0011: ret

}
Vector128<short> vsrl(Vector128<short> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::ShiftRightLogical(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Byte)
    IL_0007: ret

}
Vector128<ushort> vsrl(Vector128<ushort> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::ShiftRightLogical(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Byte)
    IL_0007: ret

}
Vector128<int> vsrl(Vector128<int> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::ShiftRightLogical(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Byte)
    IL_0007: ret

}
Vector128<uint> vsrl(Vector128<uint> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::ShiftRightLogical(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Byte)
    IL_0007: ret

}
Vector128<long> vsrl(Vector128<long> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse2::ShiftRightLogical(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Byte)
    IL_0007: ret

}
Vector128<ulong> vsrl(Vector128<ulong> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::ShiftRightLogical(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Byte)
    IL_0007: ret

}
Vector256<byte> vsrl(Vector256<byte> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.dinxc::vsrl(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Byte)
    IL_0007: ret

}
Vector256<short> vsrl(Vector256<short> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::ShiftRightLogical(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Byte)
    IL_0007: ret

}
Vector256<ushort> vsrl(Vector256<ushort> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::ShiftRightLogical(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Byte)
    IL_0007: ret

}
Vector256<int> vsrl(Vector256<int> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::ShiftRightLogical(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Byte)
    IL_0007: ret

}
Vector256<uint> vsrl(Vector256<uint> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::ShiftRightLogical(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Byte)
    IL_0007: ret

}
Vector256<long> vsrl(Vector256<long> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::ShiftRightLogical(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Byte)
    IL_0007: ret

}
Vector256<ulong> vsrl(Vector256<ulong> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::ShiftRightLogical(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Byte)
    IL_0007: ret

}
Vector128<int> vsrlv(Vector128<int> src, Vector128<uint> control)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::ShiftRightLogicalVariable(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0007: ret

}
Vector128<uint> vsrlv(Vector128<uint> src, Vector128<uint> offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::ShiftRightLogicalVariable(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0007: ret

}
Vector128<long> vsrlv(Vector128<long> src, Vector128<ulong> offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::ShiftRightLogicalVariable(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0007: ret

}
Vector128<ulong> vsrlv(Vector128<ulong> src, Vector128<ulong> offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::ShiftRightLogicalVariable(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0007: ret

}
Vector256<int> vsrlv(Vector256<int> src, Vector256<uint> offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::ShiftRightLogicalVariable(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0007: ret

}
Vector256<uint> vsrlv(Vector256<uint> src, Vector256<uint> offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::ShiftRightLogicalVariable(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0007: ret

}
Vector256<long> vsrlv(Vector256<long> src, Vector256<ulong> offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::ShiftRightLogicalVariable(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0007: ret

}
Vector256<ulong> vsrlv(Vector256<ulong> src, Vector256<ulong> offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::ShiftRightLogicalVariable(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0007: ret

}
Vector128<sbyte> vxnor(Vector128<sbyte> x, Vector128<sbyte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_000C: ret

}
Vector128<byte> vxnor(Vector128<byte> x, Vector128<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_000C: ret

}
Vector128<short> vxnor(Vector128<short> x, Vector128<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_000C: ret

}
Vector128<ushort> vxnor(Vector128<ushort> x, Vector128<ushort> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_000C: ret

}
Vector128<int> vxnor(Vector128<int> x, Vector128<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_000C: ret

}
Vector128<uint> vxnor(Vector128<uint> x, Vector128<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_000C: ret

}
Vector128<long> vxnor(Vector128<long> x, Vector128<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_000C: ret

}
Vector128<ulong> vxnor(Vector128<ulong> x, Vector128<ulong> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_000C: ret

}
Vector256<byte> vxnor(Vector256<byte> x, Vector256<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_000C: ret

}
Vector256<short> vxnor(Vector256<short> x, Vector256<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_000C: ret

}
Vector256<sbyte> vxnor(Vector256<sbyte> x, Vector256<sbyte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_000C: ret

}
Vector256<ushort> vxnor(Vector256<ushort> x, Vector256<ushort> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_000C: ret

}
Vector256<int> vxnor(Vector256<int> x, Vector256<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_000C: ret

}
Vector256<uint> vxnor(Vector256<uint> x, Vector256<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_000C: ret

}
Vector256<long> vxnor(Vector256<long> x, Vector256<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_000C: ret

}
Vector256<ulong> vxnor(Vector256<ulong> x, Vector256<ulong> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_000C: ret

}
Vector128<sbyte> vxor(Vector128<sbyte> x, Vector128<sbyte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0007: ret

}
Vector128<byte> vxor(Vector128<byte> x, Vector128<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0007: ret

}
Vector128<short> vxor(Vector128<short> x, Vector128<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0007: ret

}
Vector128<ushort> vxor(Vector128<ushort> x, Vector128<ushort> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0007: ret

}
Vector128<int> vxor(Vector128<int> x, Vector128<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0007: ret

}
Vector128<uint> vxor(Vector128<uint> x, Vector128<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0007: ret

}
Vector128<long> vxor(Vector128<long> x, Vector128<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0007: ret

}
Vector128<ulong> vxor(Vector128<ulong> x, Vector128<ulong> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0007: ret

}
Vector256<byte> vxor(Vector256<byte> x, Vector256<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0007: ret

}
Vector256<short> vxor(Vector256<short> x, Vector256<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0007: ret

}
Vector256<sbyte> vxor(Vector256<sbyte> x, Vector256<sbyte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0007: ret

}
Vector256<ushort> vxor(Vector256<ushort> x, Vector256<ushort> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0007: ret

}
Vector256<int> vxor(Vector256<int> x, Vector256<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0007: ret

}
Vector256<uint> vxor(Vector256<uint> x, Vector256<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0007: ret

}
Vector256<long> vxor(Vector256<long> x, Vector256<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0007: ret

}
Vector256<ulong> vxor(Vector256<ulong> x, Vector256<ulong> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0007: ret

}
Vector128<sbyte> vxor1(Vector128<sbyte> x)
{
    IL_0000: ldarg.0
    IL_0001: ldloca.s V_0
    IL_0003: initobj System.Runtime.Intrinsics.Vector128`1<System.SByte>
    IL_0009: ldloc.0
    IL_000A: ldloca.s V_0
    IL_000C: initobj System.Runtime.Intrinsics.Vector128`1<System.SByte>
    IL_0012: ldloc.0
    IL_0013: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0018: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_001D: ret

}
Vector128<byte> vxor1(Vector128<byte> x)
{
    IL_0000: ldarg.0
    IL_0001: ldloca.s V_0
    IL_0003: initobj System.Runtime.Intrinsics.Vector128`1<System.Byte>
    IL_0009: ldloc.0
    IL_000A: ldloca.s V_0
    IL_000C: initobj System.Runtime.Intrinsics.Vector128`1<System.Byte>
    IL_0012: ldloc.0
    IL_0013: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0018: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_001D: ret

}
Vector128<short> vxor1(Vector128<short> x)
{
    IL_0000: ldarg.0
    IL_0001: ldloca.s V_0
    IL_0003: initobj System.Runtime.Intrinsics.Vector128`1<System.Int16>
    IL_0009: ldloc.0
    IL_000A: ldloca.s V_0
    IL_000C: initobj System.Runtime.Intrinsics.Vector128`1<System.Int16>
    IL_0012: ldloc.0
    IL_0013: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0018: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_001D: ret

}
Vector128<ushort> vxor1(Vector128<ushort> x)
{
    IL_0000: ldarg.0
    IL_0001: ldloca.s V_0
    IL_0003: initobj System.Runtime.Intrinsics.Vector128`1<System.UInt16>
    IL_0009: ldloc.0
    IL_000A: ldloca.s V_0
    IL_000C: initobj System.Runtime.Intrinsics.Vector128`1<System.UInt16>
    IL_0012: ldloc.0
    IL_0013: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0018: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_001D: ret

}
Vector128<int> vxor1(Vector128<int> x)
{
    IL_0000: ldarg.0
    IL_0001: ldloca.s V_0
    IL_0003: initobj System.Runtime.Intrinsics.Vector128`1<System.Int32>
    IL_0009: ldloc.0
    IL_000A: ldloca.s V_0
    IL_000C: initobj System.Runtime.Intrinsics.Vector128`1<System.Int32>
    IL_0012: ldloc.0
    IL_0013: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0018: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_001D: ret

}
Vector128<uint> vxor1(Vector128<uint> x)
{
    IL_0000: ldarg.0
    IL_0001: ldloca.s V_0
    IL_0003: initobj System.Runtime.Intrinsics.Vector128`1<System.UInt32>
    IL_0009: ldloc.0
    IL_000A: ldloca.s V_0
    IL_000C: initobj System.Runtime.Intrinsics.Vector128`1<System.UInt32>
    IL_0012: ldloc.0
    IL_0013: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0018: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_001D: ret

}
Vector128<long> vxor1(Vector128<long> x)
{
    IL_0000: ldarg.0
    IL_0001: ldloca.s V_0
    IL_0003: initobj System.Runtime.Intrinsics.Vector128`1<System.Int64>
    IL_0009: ldloc.0
    IL_000A: ldloca.s V_0
    IL_000C: initobj System.Runtime.Intrinsics.Vector128`1<System.Int64>
    IL_0012: ldloc.0
    IL_0013: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse41::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0018: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_001D: ret

}
Vector128<ulong> vxor1(Vector128<ulong> x)
{
    IL_0000: ldarg.0
    IL_0001: ldloca.s V_0
    IL_0003: initobj System.Runtime.Intrinsics.Vector128`1<System.UInt64>
    IL_0009: ldloc.0
    IL_000A: ldloca.s V_0
    IL_000C: initobj System.Runtime.Intrinsics.Vector128`1<System.UInt64>
    IL_0012: ldloc.0
    IL_0013: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse41::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0018: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_001D: ret

}
Vector256<sbyte> vxor1(Vector256<sbyte> x)
{
    IL_0000: ldarg.0
    IL_0001: ldloca.s V_0
    IL_0003: initobj System.Runtime.Intrinsics.Vector256`1<System.SByte>
    IL_0009: ldloc.0
    IL_000A: ldloca.s V_0
    IL_000C: initobj System.Runtime.Intrinsics.Vector256`1<System.SByte>
    IL_0012: ldloc.0
    IL_0013: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0018: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_001D: ret

}
Vector256<byte> vxor1(Vector256<byte> x)
{
    IL_0000: ldarg.0
    IL_0001: ldloca.s V_0
    IL_0003: initobj System.Runtime.Intrinsics.Vector256`1<System.Byte>
    IL_0009: ldloc.0
    IL_000A: ldloca.s V_0
    IL_000C: initobj System.Runtime.Intrinsics.Vector256`1<System.Byte>
    IL_0012: ldloc.0
    IL_0013: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0018: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_001D: ret

}
Vector256<short> vxor1(Vector256<short> x)
{
    IL_0000: ldarg.0
    IL_0001: ldloca.s V_0
    IL_0003: initobj System.Runtime.Intrinsics.Vector256`1<System.Int16>
    IL_0009: ldloc.0
    IL_000A: ldloca.s V_0
    IL_000C: initobj System.Runtime.Intrinsics.Vector256`1<System.Int16>
    IL_0012: ldloc.0
    IL_0013: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0018: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_001D: ret

}
Vector128<sbyte> vand(Vector128<sbyte> x, Vector128<sbyte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::And(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0007: ret

}
Vector128<ushort> vand(Vector128<ushort> x, Vector128<ushort> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::And(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0007: ret

}
Vector128<int> vand(Vector128<int> x, Vector128<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::And(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0007: ret

}
Vector128<uint> vand(Vector128<uint> x, Vector128<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::And(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0007: ret

}
Vector128<long> vand(Vector128<long> x, Vector128<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse2::And(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0007: ret

}
Vector128<ulong> vand(Vector128<ulong> x, Vector128<ulong> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::And(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0007: ret

}
Vector256<byte> vand(Vector256<byte> x, Vector256<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::And(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0007: ret

}
Vector256<short> vand(Vector256<short> x, Vector256<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::And(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0007: ret

}
Vector256<sbyte> vand(Vector256<sbyte> x, Vector256<sbyte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::And(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0007: ret

}
Vector256<ushort> vand(Vector256<ushort> x, Vector256<ushort> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::And(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0007: ret

}
Vector256<int> vand(Vector256<int> x, Vector256<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::And(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0007: ret

}
Vector256<uint> vand(Vector256<uint> x, Vector256<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::And(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0007: ret

}
Vector256<long> vand(Vector256<long> x, Vector256<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::And(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0007: ret

}
Vector256<ulong> vand(Vector256<ulong> x, Vector256<ulong> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::And(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0007: ret

}
Vector128<sbyte> vandnot(Vector128<sbyte> x, Vector128<sbyte> y)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::AndNot(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0007: ret

}
Vector128<byte> vandnot(Vector128<byte> x, Vector128<byte> y)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::AndNot(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0007: ret

}
Vector128<short> vandnot(Vector128<short> x, Vector128<short> y)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::AndNot(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0007: ret

}
Vector128<ushort> vandnot(Vector128<ushort> x, Vector128<ushort> y)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::AndNot(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0007: ret

}
Vector128<int> vandnot(Vector128<int> x, Vector128<int> y)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::AndNot(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0007: ret

}
Vector128<uint> vandnot(Vector128<uint> x, Vector128<uint> y)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::AndNot(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0007: ret

}
Vector128<long> vandnot(Vector128<long> x, Vector128<long> y)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse2::AndNot(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0007: ret

}
Vector128<ulong> vandnot(Vector128<ulong> x, Vector128<ulong> y)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::AndNot(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0007: ret

}
Vector256<sbyte> vandnot(Vector256<sbyte> x, Vector256<sbyte> y)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::AndNot(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0007: ret

}
Vector256<byte> vandnot(Vector256<byte> x, Vector256<byte> y)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::AndNot(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0007: ret

}
Vector256<short> vandnot(Vector256<short> x, Vector256<short> y)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::AndNot(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0007: ret

}
Vector256<ushort> vandnot(Vector256<ushort> x, Vector256<ushort> y)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::AndNot(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0007: ret

}
Vector256<int> vandnot(Vector256<int> x, Vector256<int> y)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::AndNot(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0007: ret

}
Vector256<uint> vandnot(Vector256<uint> x, Vector256<uint> y)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::AndNot(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0007: ret

}
Vector256<long> vandnot(Vector256<long> x, Vector256<long> y)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::AndNot(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0007: ret

}
Vector256<ulong> vandnot(Vector256<ulong> x, Vector256<ulong> y)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::AndNot(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0007: ret

}
Vector128<short> vbsll(Vector128<short> src, byte bytes)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::ShiftLeftLogical128BitLane(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Byte)
    IL_0007: ret

}
Vector128<ushort> vbsll(Vector128<ushort> src, byte bytes)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::ShiftLeftLogical128BitLane(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Byte)
    IL_0007: ret

}
Vector128<int> vbsll(Vector128<int> src, byte bytes)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::ShiftLeftLogical128BitLane(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Byte)
    IL_0007: ret

}
Vector128<uint> vbsll(Vector128<uint> src, byte bytes)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::ShiftLeftLogical128BitLane(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Byte)
    IL_0007: ret

}
Vector128<long> vbsll(Vector128<long> src, byte bytes)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse2::ShiftLeftLogical128BitLane(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Byte)
    IL_0007: ret

}
Vector128<ulong> vbsll(Vector128<ulong> src, byte bytes)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::ShiftLeftLogical128BitLane(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Byte)
    IL_0007: ret

}
Vector256<short> vbsll(Vector256<short> src, byte bytes)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::ShiftLeftLogical128BitLane(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Byte)
    IL_0007: ret

}
Vector256<ushort> vbsll(Vector256<ushort> src, byte bytes)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::ShiftLeftLogical128BitLane(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Byte)
    IL_0007: ret

}
Vector256<int> vbsll(Vector256<int> src, byte bytes)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::ShiftLeftLogical128BitLane(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Byte)
    IL_0007: ret

}
Vector256<uint> vbsll(Vector256<uint> src, byte bytes)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::ShiftLeftLogical128BitLane(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Byte)
    IL_0007: ret

}
Vector256<long> vbsll(Vector256<long> src, byte bytes)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::ShiftLeftLogical128BitLane(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Byte)
    IL_0007: ret

}
Vector256<ulong> vbsll(Vector256<ulong> src, byte bytes)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::ShiftLeftLogical128BitLane(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Byte)
    IL_0007: ret

}
Vector128<short> vbsrl(Vector128<short> src, byte bytes)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::ShiftRightLogical128BitLane(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Byte)
    IL_0007: ret

}
Vector128<ushort> vbsrl(Vector128<ushort> src, byte bytes)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::ShiftRightLogical128BitLane(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Byte)
    IL_0007: ret

}
Vector128<int> vbsrl(Vector128<int> src, byte bytes)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::ShiftRightLogical128BitLane(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Byte)
    IL_0007: ret

}
Vector128<uint> vbsrl(Vector128<uint> src, byte bytes)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::ShiftRightLogical128BitLane(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Byte)
    IL_0007: ret

}
Vector128<long> vbsrl(Vector128<long> src, byte bytes)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse2::ShiftRightLogical128BitLane(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Byte)
    IL_0007: ret

}
Vector128<ulong> vbsrl(Vector128<ulong> src, byte bytes)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::ShiftRightLogical128BitLane(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Byte)
    IL_0007: ret

}
Vector256<short> vbsrl(Vector256<short> src, byte bytes)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::ShiftRightLogical128BitLane(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Byte)
    IL_0007: ret

}
Vector256<ushort> vbsrl(Vector256<ushort> src, byte bytes)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::ShiftRightLogical128BitLane(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Byte)
    IL_0007: ret

}
Vector256<int> vbsrl(Vector256<int> src, byte bytes)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::ShiftRightLogical128BitLane(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Byte)
    IL_0007: ret

}
Vector256<uint> vbsrl(Vector256<uint> src, byte bytes)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::ShiftRightLogical128BitLane(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Byte)
    IL_0007: ret

}
Vector256<long> vbsrl(Vector256<long> src, byte bytes)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::ShiftRightLogical128BitLane(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Byte)
    IL_0007: ret

}
Vector256<ulong> vbsrl(Vector256<ulong> src, byte bytes)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::ShiftRightLogical128BitLane(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Byte)
    IL_0007: ret

}
Vector128<sbyte> vnand(Vector128<sbyte> x, Vector128<sbyte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::And(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_000C: ret

}
Vector128<byte> vnand(Vector128<byte> x, Vector128<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::And(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_000C: ret

}
Vector128<short> vnand(Vector128<short> x, Vector128<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::And(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_000C: ret

}
Vector128<ushort> vnand(Vector128<ushort> x, Vector128<ushort> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::And(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_000C: ret

}
Vector128<int> vnand(Vector128<int> x, Vector128<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::And(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_000C: ret

}
Vector128<uint> vnand(Vector128<uint> x, Vector128<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::And(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_000C: ret

}
Vector128<long> vnand(Vector128<long> x, Vector128<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse2::And(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_000C: ret

}
Vector128<ulong> vnand(Vector128<ulong> x, Vector128<ulong> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::And(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_000C: ret

}
Vector128<float> vnand(Vector128<float> x, Vector128<float> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Sse::And(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.dfp::vnot(System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_000C: ret

}
Vector128<double> vnand(Vector128<double> x, Vector128<double> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Double> System.Runtime.Intrinsics.X86.Sse2::And(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.dfp::vnot(System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_000C: ret

}
Vector256<byte> vnand(Vector256<byte> x, Vector256<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::And(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_000C: ret

}
Vector256<short> vnand(Vector256<short> x, Vector256<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::And(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_000C: ret

}
Vector256<sbyte> vnand(Vector256<sbyte> x, Vector256<sbyte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::And(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_000C: ret

}
Vector256<ushort> vnand(Vector256<ushort> x, Vector256<ushort> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::And(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_000C: ret

}
Vector256<int> vnand(Vector256<int> x, Vector256<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::And(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_000C: ret

}
Vector256<uint> vnand(Vector256<uint> x, Vector256<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::And(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_000C: ret

}
Vector256<long> vnand(Vector256<long> x, Vector256<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::And(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_000C: ret

}
Vector256<ulong> vnand(Vector256<ulong> x, Vector256<ulong> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::And(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_000C: ret

}
Vector256<float> vnand(Vector256<float> x, Vector256<float> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Single> System.Runtime.Intrinsics.X86.Avx::And(System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.dfp::vnot(System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_000C: ret

}
Vector256<double> vnand(Vector256<double> x, Vector256<double> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Double> System.Runtime.Intrinsics.X86.Avx::And(System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.dfp::vnot(System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_000C: ret

}
Vec128<sbyte> vnor(in Vec128<sbyte> x, in Vec128<sbyte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::Or(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0016: call Z0.Vec128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_001B: ret

}
Vec128<byte> vnor(in Vec128<byte> x, in Vec128<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::Or(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0016: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_001B: ret

}
Vec128<short> vnor(in Vec128<short> x, in Vec128<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::Or(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0016: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_001B: ret

}
Vec128<ushort> vnor(in Vec128<ushort> x, in Vec128<ushort> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::Or(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0016: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_001B: ret

}
Vec128<int> vnor(in Vec128<int> x, in Vec128<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::Or(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0016: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_001B: ret

}
Vec128<uint> vnor(in Vec128<uint> x, in Vec128<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::Or(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0016: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_001B: ret

}
Vec128<long> vnor(in Vec128<long> x, in Vec128<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse2::Or(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0016: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_001B: ret

}
Vec128<ulong> vnor(in Vec128<ulong> x, in Vec128<ulong> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::Or(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0016: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_001B: ret

}
Vec128<float> vnor(in Vec128<float> x, in Vec128<float> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Sse::Or(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.dfp::vnot(System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0016: call Z0.Vec128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_001B: ret

}
Vec128<double> vnor(in Vec128<double> x, in Vec128<double> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Double> System.Runtime.Intrinsics.X86.Sse2::Or(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.dfp::vnot(System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0016: call Z0.Vec128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_001B: ret

}
Vec256<byte> vnor(in Vec256<byte> x, in Vec256<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::Or(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0016: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_001B: ret

}
Vec256<short> vnor(in Vec256<short> x, in Vec256<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::Or(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0016: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_001B: ret

}
Vec256<sbyte> vnor(in Vec256<sbyte> x, in Vec256<sbyte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::Or(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0016: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_001B: ret

}
Vec256<ushort> vnor(in Vec256<ushort> x, in Vec256<ushort> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::Or(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0016: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_001B: ret

}
Vec256<int> vnor(in Vec256<int> x, in Vec256<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::Or(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0016: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_001B: ret

}
Vec256<uint> vnor(in Vec256<uint> x, in Vec256<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::Or(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0016: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_001B: ret

}
Vec256<long> vnor(in Vec256<long> x, in Vec256<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::Or(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0016: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_001B: ret

}
Vec256<ulong> vnor(in Vec256<ulong> x, in Vec256<ulong> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::Or(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0016: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_001B: ret

}
Vec256<float> vnor(in Vec256<float> x, in Vec256<float> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Single> System.Runtime.Intrinsics.X86.Avx::Or(System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.dfp::vnot(System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_0016: call Z0.Vec256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_001B: ret

}
Vec256<double> vnor(in Vec256<double> x, in Vec256<double> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Double> System.Runtime.Intrinsics.X86.Avx::Or(System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.dfp::vnot(System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_0016: call Z0.Vec256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_001B: ret

}
Vector128<sbyte> vnor(Vector128<sbyte> x, Vector128<sbyte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::Or(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_000C: ret

}
Vector128<byte> vnor(Vector128<byte> x, Vector128<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::Or(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_000C: ret

}
Vector128<short> vnor(Vector128<short> x, Vector128<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::Or(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_000C: ret

}
Vector128<ushort> vnor(Vector128<ushort> x, Vector128<ushort> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::Or(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_000C: ret

}
Vector128<int> vnor(Vector128<int> x, Vector128<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::Or(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_000C: ret

}
Vector128<uint> vnor(Vector128<uint> x, Vector128<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::Or(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_000C: ret

}
Vector128<long> vnor(Vector128<long> x, Vector128<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse2::Or(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_000C: ret

}
Vector128<ulong> vnor(Vector128<ulong> x, Vector128<ulong> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::Or(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_000C: ret

}
Vector128<float> vnor(Vector128<float> x, Vector128<float> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Sse::Or(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.dfp::vnot(System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_000C: ret

}
Vector128<double> vnor(Vector128<double> x, Vector128<double> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Double> System.Runtime.Intrinsics.X86.Sse2::Or(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.dfp::vnot(System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_000C: ret

}
Vector256<byte> vnor(Vector256<byte> x, Vector256<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::Or(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_000C: ret

}
Vector256<short> vnor(Vector256<short> x, Vector256<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::Or(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_000C: ret

}
Vector256<sbyte> vnor(Vector256<sbyte> x, Vector256<sbyte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::Or(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_000C: ret

}
Vector256<ushort> vnor(Vector256<ushort> x, Vector256<ushort> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::Or(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_000C: ret

}
Vector256<int> vnor(Vector256<int> x, Vector256<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::Or(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_000C: ret

}
Vector256<uint> vnor(Vector256<uint> x, Vector256<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::Or(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_000C: ret

}
Vector256<long> vnor(Vector256<long> x, Vector256<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::Or(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_000C: ret

}
Vector256<ulong> vnor(Vector256<ulong> x, Vector256<ulong> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::Or(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_000C: ret

}
Vector256<float> vnor(Vector256<float> x, Vector256<float> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Single> System.Runtime.Intrinsics.X86.Avx::Or(System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.dfp::vnot(System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_000C: ret

}
Vector256<double> vnor(Vector256<double> x, Vector256<double> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Double> System.Runtime.Intrinsics.X86.Avx::Or(System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.dfp::vnot(System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_000C: ret

}
Vector128<sbyte> vnot(Vector128<sbyte> src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldarg.0
    IL_0003: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0008: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_000D: ret

}
Vector128<byte> vnot(Vector128<byte> src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldarg.0
    IL_0003: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0008: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_000D: ret

}
Vector128<short> vnot(Vector128<short> src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldarg.0
    IL_0003: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0008: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_000D: ret

}
Vector128<ushort> vnot(Vector128<ushort> src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldarg.0
    IL_0003: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0008: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_000D: ret

}
Vector128<int> vnot(Vector128<int> src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldarg.0
    IL_0003: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0008: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_000D: ret

}
Vector128<uint> vnot(Vector128<uint> src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldarg.0
    IL_0003: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0008: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_000D: ret

}
Vector128<long> vnot(Vector128<long> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.Vector128::AsUInt32<System.Int64>(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_000B: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.Vector128::AsInt64<System.UInt32>(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0010: ret

}
Vector128<ulong> vnot(Vector128<ulong> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.Vector128::AsUInt32<System.UInt64>(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_000B: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.Vector128::AsUInt64<System.UInt32>(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0010: ret

}
Vector256<sbyte> vnot(Vector256<sbyte> src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldarg.0
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0008: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_000D: ret

}
Vector256<byte> vnot(Vector256<byte> src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldarg.0
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0008: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_000D: ret

}
Vector256<short> vnot(Vector256<short> src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldarg.0
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0008: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_000D: ret

}
Vector256<ushort> vnot(Vector256<ushort> src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldarg.0
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0008: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_000D: ret

}
Vector256<int> vnot(Vector256<int> src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldarg.0
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0008: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_000D: ret

}
Vector256<uint> vnot(Vector256<uint> src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldarg.0
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0008: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_000D: ret

}
Vector128<sbyte> reverse(Vector128<sbyte> src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.s 15
    IL_0003: call Z0.Swap[] System.Array::Empty<Z0.Swap>()
    IL_0008: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128Pattern::decrements<System.SByte>(System.SByte,Z0.Swap[])
    IL_000D: stloc.0
    IL_000E: ldloca.s V_0
    IL_0010: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.dinx::vshuffle(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>&)
    IL_0015: ret

}
Vector128<int> reverse(Vector128<int> src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.s 27
    IL_0003: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.dinx::vshuffle(System.Runtime.Intrinsics.Vector128`1<System.Int32>,Z0.Perm4)
    IL_0008: ret

}
Vector128<uint> reverse(Vector128<uint> src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.s 27
    IL_0003: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.dinx::vshuffle(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,Z0.Perm4)
    IL_0008: ret

}
Vector256<byte> reverse(Vector256<byte> src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.s 31
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256Pattern::Decrements<System.Byte>(System.Byte)
    IL_0008: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.dinx::vpermvar32x8(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_000D: ret

}
Vector256<int> reverse(Vector256<int> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.dinx::get_MRev256i32()
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.dinx::vpermvar8x32(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_000B: ret

}
Vector256<uint> reverse(Vector256<uint> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.dinx::get_MRev256u32()
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.dinx::vpermvar8x32(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_000B: ret

}
Vector256<float> reverse(Vector256<float> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.dinx::get_MRev256f32()
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.dinx::vpermvar8x32(System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_000B: ret

}
Vector256<int> get_MRev256i32()
{
    IL_0000: ldc.i4.7
    IL_0001: ldc.i4.5
    IL_0002: ldc.i4.6
    IL_0003: ldc.i4.4
    IL_0004: ldc.i4.3
    IL_0005: ldc.i4.2
    IL_0006: ldc.i4.1
    IL_0007: ldc.i4.0
    IL_0008: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.Vector256::Create(System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32)
    IL_000D: ret

}
Vector256<uint> get_MRev256u32()
{
    IL_0000: ldc.i4.7
    IL_0001: ldc.i4.6
    IL_0002: ldc.i4.5
    IL_0003: ldc.i4.4
    IL_0004: ldc.i4.3
    IL_0005: ldc.i4.2
    IL_0006: ldc.i4.1
    IL_0007: ldc.i4.0
    IL_0008: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.Vector256::Create(System.UInt32,System.UInt32,System.UInt32,System.UInt32,System.UInt32,System.UInt32,System.UInt32,System.UInt32)
    IL_000D: ret

}
Vector256<int> get_MRev256f32()
{
    IL_0000: ldc.i4.7
    IL_0001: ldc.i4.6
    IL_0002: ldc.i4.5
    IL_0003: ldc.i4.4
    IL_0004: ldc.i4.3
    IL_0005: ldc.i4.2
    IL_0006: ldc.i4.1
    IL_0007: ldc.i4.0
    IL_0008: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.Vector256::Create(System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32)
    IL_000D: ret

}
Vec128<short> vshufflehi(in Vec128<short> src, Perm4:byte control)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::xmm
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::ShuffleHigh(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Byte)
    IL_000C: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0011: ret

}
Vec128<ushort> vshufflehi(in Vec128<ushort> src, Perm4:byte spec)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::xmm
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::ShuffleHigh(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Byte)
    IL_000C: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0011: ret

}
Vec128<short> vshufflelo(in Vec128<short> src, Perm4:byte control)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::xmm
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::ShuffleLow(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Byte)
    IL_000C: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0011: ret

}
Vec128<ushort> vshufflelo(in Vec128<ushort> src, Perm4:byte control)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::xmm
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::ShuffleLow(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Byte)
    IL_000C: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0011: ret

}
Vec128<short> vshuffle(in Vec128<short> src, Perm4:byte lo, Perm4:byte hi)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.Int16> Z0.dinx::vshufflelo(Z0.Vec128`1<System.Int16>&,Z0.Perm4)
    IL_0007: stloc.0
    IL_0008: ldloca.s V_0
    IL_000A: ldarg.2
    IL_000B: call Z0.Vec128`1<System.Int16> Z0.dinx::vshufflehi(Z0.Vec128`1<System.Int16>&,Z0.Perm4)
    IL_0010: ret

}
Vec128<ushort> vshuffle(in Vec128<ushort> src, Perm4:byte lo, Perm4:byte hi)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.UInt16> Z0.dinx::vshufflelo(Z0.Vec128`1<System.UInt16>&,Z0.Perm4)
    IL_0007: stloc.0
    IL_0008: ldloca.s V_0
    IL_000A: ldarg.2
    IL_000B: call Z0.Vec128`1<System.UInt16> Z0.dinx::vshufflehi(Z0.Vec128`1<System.UInt16>&,Z0.Perm4)
    IL_0010: ret

}
Vec128<int> vshuffle(in Vec128<int> src, Perm4:byte spec)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::xmm
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::Shuffle(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Byte)
    IL_000C: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0011: ret

}
Vec128<uint> vshuffle(in Vec128<uint> src, Perm4:byte spec)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::xmm
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::Shuffle(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Byte)
    IL_000C: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0011: ret

}
Vec256<int> vshuffle(in Vec256<int> src, Perm4:byte spec)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::ymm
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::Shuffle(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Byte)
    IL_000C: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: ret

}
Vec256<uint> vshuffle(in Vec256<uint> src, Perm4:byte spec)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::ymm
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::Shuffle(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Byte)
    IL_000C: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0011: ret

}
Vec128<ushort> vshufflehi(in Vec128<ushort> src, byte control)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::xmm
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::ShuffleHigh(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Byte)
    IL_000C: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0011: ret

}
Vec128<ushort> vshufflelo(in Vec128<ushort> src, byte control)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::xmm
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::ShuffleLow(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Byte)
    IL_000C: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0011: ret

}
Vec128<byte> vshuffle(in Vec128<byte> src, in Vec128<byte> spec)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::xmm
    IL_0006: ldarg.1
    IL_0007: ldobj Z0.Vec128`1<System.Byte>
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Ssse3::Shuffle(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0016: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_001B: ret

}
Vec128<sbyte> vshuffle(in Vec128<sbyte> src, in Vec128<sbyte> spec)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::xmm
    IL_0006: ldarg.1
    IL_0007: ldobj Z0.Vec128`1<System.SByte>
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Ssse3::Shuffle(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0016: call Z0.Vec128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_001B: ret

}
Vec256<byte> vshuffle(in Vec256<byte> src, in Vec256<byte> spec)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::ymm
    IL_0006: ldarg.1
    IL_0007: ldobj Z0.Vec256`1<System.Byte>
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::Shuffle(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0016: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_001B: ret

}
Vec256<sbyte> vshuffle(in Vec256<sbyte> src, in Vec256<sbyte> spec)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::ymm
    IL_0006: ldarg.1
    IL_0007: ldobj Z0.Vec256`1<System.SByte>
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>)
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::Shuffle(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0016: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_001B: ret

}
Vector128<short> vshufflehi(Vector128<short> src, Arrange4:byte spec)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::ShuffleHigh(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Byte)
    IL_0007: ret

}
Vector128<ushort> vshufflehi(Vector128<ushort> src, Arrange4:byte spec)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::ShuffleHigh(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Byte)
    IL_0007: ret

}
Vector128<short> vshufflelo(Vector128<short> src, Arrange4:byte spec)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::ShuffleLow(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Byte)
    IL_0007: ret

}
Vector128<ushort> vshufflelo(Vector128<ushort> src, Arrange4:byte spec)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::ShuffleLow(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Byte)
    IL_0007: ret

}
Vector128<short> vshuffle(Vector128<short> src, Arrange4:byte lo, Arrange4:byte hi)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.dinx::vshufflelo(System.Runtime.Intrinsics.Vector128`1<System.Int16>,Z0.Arrange4)
    IL_0007: ldarg.2
    IL_0008: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.dinx::vshufflehi(System.Runtime.Intrinsics.Vector128`1<System.Int16>,Z0.Arrange4)
    IL_000D: ret

}
Vector128<ushort> vshuffle(Vector128<ushort> src, Arrange4:byte lo, Arrange4:byte hi)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.dinx::vshufflelo(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,Z0.Arrange4)
    IL_0007: ldarg.2
    IL_0008: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.dinx::vshufflehi(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,Z0.Arrange4)
    IL_000D: ret

}
Vector128<uint> vshuffle(Vector128<uint> src, Arrange4:byte spec)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::Shuffle(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Byte)
    IL_0007: ret

}
Vector256<int> vshuffle(Vector256<int> src, Arrange4:byte control)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::Shuffle(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Byte)
    IL_0007: ret

}
Vector256<uint> vshuffle(Vector256<uint> src, Arrange4:byte control)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::Shuffle(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Byte)
    IL_0007: ret

}
Vector128<short> vshufflehi(Vector128<short> src, Perm4:byte control)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::ShuffleHigh(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Byte)
    IL_0007: ret

}
Vector128<ushort> vshufflehi(Vector128<ushort> src, Perm4:byte spec)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::ShuffleHigh(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Byte)
    IL_0007: ret

}
Vector128<short> vshufflelo(Vector128<short> src, Perm4:byte control)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::ShuffleLow(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Byte)
    IL_0007: ret

}
Vector128<ushort> vshufflelo(Vector128<ushort> src, Perm4:byte control)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::ShuffleLow(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Byte)
    IL_0007: ret

}
Vector128<short> vshuffle(Vector128<short> src, Perm4:byte lo, Perm4:byte hi)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.dinx::vshufflelo(System.Runtime.Intrinsics.Vector128`1<System.Int16>,Z0.Perm4)
    IL_0007: ldarg.2
    IL_0008: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.dinx::vshufflehi(System.Runtime.Intrinsics.Vector128`1<System.Int16>,Z0.Perm4)
    IL_000D: ret

}
Vector128<ushort> vshuffle(Vector128<ushort> src, Perm4:byte lo, Perm4:byte hi)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.dinx::vshufflelo(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,Z0.Perm4)
    IL_0007: ldarg.2
    IL_0008: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.dinx::vshufflehi(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,Z0.Perm4)
    IL_000D: ret

}
Vector128<int> vshuffle(Vector128<int> src, Perm4:byte spec)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::Shuffle(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Byte)
    IL_0007: ret

}
Vector128<uint> vshuffle(Vector128<uint> src, Perm4:byte spec)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::Shuffle(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Byte)
    IL_0007: ret

}
Vector256<int> vshuffle(Vector256<int> src, Perm4:byte spec)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::Shuffle(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Byte)
    IL_0007: ret

}
Vector256<uint> vshuffle(Vector256<uint> src, Perm4:byte spec)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::Shuffle(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Byte)
    IL_0007: ret

}
Vector128<ushort> vshufflehi(Vector128<ushort> src, byte control)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::ShuffleHigh(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Byte)
    IL_0007: ret

}
Vector128<ushort> vshufflelo(Vector128<ushort> src, byte control)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::ShuffleLow(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Byte)
    IL_0007: ret

}
Vector128<byte> vshuffle(Vector128<byte> src, in Vector128<byte> spec)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldobj System.Runtime.Intrinsics.Vector128`1<System.Byte>
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Ssse3::Shuffle(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_000C: ret

}
Vector128<sbyte> vshuffle(Vector128<sbyte> src, in Vector128<sbyte> spec)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldobj System.Runtime.Intrinsics.Vector128`1<System.SByte>
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Ssse3::Shuffle(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_000C: ret

}
Vector256<byte> vshuffle(Vector256<byte> src, in Vector256<byte> spec)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldobj System.Runtime.Intrinsics.Vector256`1<System.Byte>
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::Shuffle(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_000C: ret

}
Vector256<sbyte> vshuffle(Vector256<sbyte> src, in Vector256<sbyte> spec)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldobj System.Runtime.Intrinsics.Vector256`1<System.SByte>
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::Shuffle(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_000C: ret

}
Vector128<byte> swap(Vector128<byte> src, Swap[] swaps)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.Byte> Z0.Vec128Pattern::Swap<System.Byte>(Z0.Swap[])
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000C: stloc.0
    IL_000D: ldloca.s V_0
    IL_000F: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.dinx::vshuffle(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>&)
    IL_0014: ret

}
Vec256<int> vswap(Vec256<int> src, byte i, byte j)
{
    IL_0000: ldsfld System.Int32 Z0.Vec256`1<System.Int32>::Length
    IL_0005: stloc.1
    IL_0006: ldloc.1
    IL_0007: conv.u
    IL_0008: ldc.i4.4
    IL_0009: mul.ovf.un
    IL_000A: localloc
    IL_000C: ldloc.1
    IL_000D: newobj System.Void System.Span`1<System.Int32>::.ctor(System.Void*,System.Int32)
    IL_0012: stloc.2
    IL_0013: ldloc.2
    IL_0014: stloc.0
    IL_0015: ldc.i4.0
    IL_0016: stloc.3
    IL_0017: br.s IL_0048
    IL_0019: ldloc.3
    IL_001A: ldarg.1
    IL_001B: bne.un.s IL_0029
    IL_001D: ldloca.s V_0
    IL_001F: ldloc.3
    IL_0020: call System.Int32& System.Span`1<System.Int32>::get_Item(System.Int32)
    IL_0025: ldarg.2
    IL_0026: stind.i4
    IL_0027: br.s IL_0043
    IL_0029: ldloc.3
    IL_002A: ldarg.2
    IL_002B: bne.un.s IL_0039
    IL_002D: ldloca.s V_0
    IL_002F: ldloc.3
    IL_0030: call System.Int32& System.Span`1<System.Int32>::get_Item(System.Int32)
    IL_0035: ldarg.1
    IL_0036: stind.i4
    IL_0037: br.s IL_0043
    IL_0039: ldloca.s V_0
    IL_003B: ldloc.3
    IL_003C: call System.Int32& System.Span`1<System.Int32>::get_Item(System.Int32)
    IL_0041: ldloc.3
    IL_0042: stind.i4
    IL_0043: ldloc.3
    IL_0044: ldc.i4.1
    IL_0045: add
    IL_0046: conv.u1
    IL_0047: stloc.3
    IL_0048: ldloc.3
    IL_0049: ldloca.s V_0
    IL_004B: call System.Int32 System.Span`1<System.Int32>::get_Length()
    IL_0050: blt.s IL_0019
    IL_0052: ldarga.s src
    IL_0054: ldloc.0
    IL_0055: call Z0.Vec256`1<System.Int32> Z0.Vec256::Load<System.Int32>(System.Span`1<System.Int32>)
    IL_005A: stloc.s V_4
    IL_005C: ldloca.s V_4
    IL_005E: call Z0.Vec256`1<System.Int32> Z0.dinx::vpermvar8x32(Z0.Vec256`1<System.Int32>&,Z0.Vec256`1<System.Int32>&)
    IL_0063: ret

}
Vec256<byte> vswaphl_ref(in Vec256<byte> x)
{
    IL_0000: ldloca.s V_0
    IL_0002: initobj Z0.Vec256`1<System.Byte>
    IL_0008: ldarg.0
    IL_0009: call Z0.Vec128`1<System.Byte> Z0.dinx::vhi(Z0.Vec256`1<System.Byte>&)
    IL_000E: stloc.1
    IL_000F: ldloca.s V_1
    IL_0011: ldloca.s V_0
    IL_0013: ldc.i4.0
    IL_0014: call Z0.Vec256`1<System.Byte> Z0.dinx::vinsert(Z0.Vec128`1<System.Byte>&,Z0.Vec256`1<System.Byte>&,System.Byte)
    IL_0019: stloc.0
    IL_001A: ldarg.0
    IL_001B: call Z0.Vec128`1<System.Byte> Z0.dinx::vlo(Z0.Vec256`1<System.Byte>&)
    IL_0020: stloc.1
    IL_0021: ldloca.s V_1
    IL_0023: ldloca.s V_0
    IL_0025: ldc.i4.1
    IL_0026: call Z0.Vec256`1<System.Byte> Z0.dinx::vinsert(Z0.Vec128`1<System.Byte>&,Z0.Vec256`1<System.Byte>&,System.Byte)
    IL_002B: stloc.0
    IL_002C: ldloc.0
    IL_002D: ret

}
Vec256<byte> vswaphl(in Vec256<byte> x)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldc.i4.3
    IL_0003: call Z0.Vec256`1<System.Byte> Z0.dinx::vperm2x128(Z0.Vec256`1<System.Byte>&,Z0.Vec256`1<System.Byte>&,Z0.Perm2x128)
    IL_0008: ret

}
Vector256<byte> vswaphl(Vector256<byte> x)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldc.i4.3
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.dinx::vperm2x128(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>,Z0.Perm2x128)
    IL_0008: ret

}
Vector256<sbyte> vswaphl(Vector256<sbyte> x)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldc.i4.3
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.dinx::vperm2x128(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>,Z0.Perm2x128)
    IL_0008: ret

}
Vector256<short> vswaphl(Vector256<short> x)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldc.i4.s 48
    IL_0004: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.dinx::vperm2x128(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>,Z0.Perm2x128)
    IL_0009: ret

}
Vector256<ushort> vswaphl(Vector256<ushort> x)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldc.i4.3
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.dinx::vperm2x128(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>,Z0.Perm2x128)
    IL_0008: ret

}
Vector256<long> vswaphl(Vector256<long> x)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldc.i4.3
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.dinx::vperm2x128(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>,Z0.Perm2x128)
    IL_0008: ret

}
Vector256<ulong> vswaphl(Vector256<ulong> x)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldc.i4.3
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::vperm2x128(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>,Z0.Perm2x128)
    IL_0008: ret

}
Vector256<double> vswaphl(Vector256<double> x)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldc.i4.3
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.dinx::vperm2x128(System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Runtime.Intrinsics.Vector256`1<System.Double>,Z0.Perm2x128)
    IL_0008: ret

}
Vec128<sbyte> vunpackhi(in Vec128<sbyte> x, in Vec128<sbyte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::UnpackHigh(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0011: call Z0.Vec128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0016: ret

}
Vec128<byte> vunpackhi(in Vec128<byte> x, in Vec128<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::UnpackHigh(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0011: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0016: ret

}
Vec128<short> vunpackhi(in Vec128<short> x, in Vec128<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::UnpackHigh(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0011: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0016: ret

}
Vec128<ushort> vunpackhi(in Vec128<ushort> x, in Vec128<ushort> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::UnpackHigh(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0011: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0016: ret

}
Vec128<int> vunpackhi(in Vec128<int> x, in Vec128<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::UnpackHigh(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0011: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0016: ret

}
Vec128<uint> vunpackhi(in Vec128<uint> x, in Vec128<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::UnpackHigh(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0011: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0016: ret

}
Vec128<long> vunpackhi(in Vec128<long> x, in Vec128<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse2::UnpackHigh(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0011: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0016: ret

}
Vec128<ulong> vunpackhi(in Vec128<ulong> x, in Vec128<ulong> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::UnpackHigh(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0011: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0016: ret

}
Vec256<sbyte> vunpackhi(in Vec256<sbyte> x, in Vec256<sbyte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::UnpackHigh(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0011: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0016: ret

}
Vec256<byte> vunpackhi(in Vec256<byte> x, in Vec256<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::UnpackHigh(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0011: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0016: ret

}
Vec256<short> vunpackhi(in Vec256<short> x, in Vec256<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::UnpackHigh(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0011: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0016: ret

}
Vec256<ushort> vunpackhi(in Vec256<ushort> x, in Vec256<ushort> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::UnpackHigh(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0011: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0016: ret

}
Vec256<int> vunpackhi(in Vec256<int> x, in Vec256<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::UnpackHigh(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0016: ret

}
Vec256<uint> vunpackhi(in Vec256<uint> x, in Vec256<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::UnpackHigh(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0011: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0016: ret

}
Vec256<long> vunpackhi(in Vec256<long> x, in Vec256<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::UnpackHigh(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0011: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0016: ret

}
Vec256<ulong> vunpackhi(in Vec256<ulong> x, in Vec256<ulong> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::UnpackHigh(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0011: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0016: ret

}
Vector128<sbyte> vunpackhi(Vector128<sbyte> x, Vector128<sbyte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::UnpackHigh(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0007: ret

}
Vector128<byte> vunpackhi(Vector128<byte> x, Vector128<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::UnpackHigh(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0007: ret

}
Vector128<short> vunpackhi(Vector128<short> x, Vector128<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::UnpackHigh(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0007: ret

}
Vector128<ushort> vunpackhi(Vector128<ushort> x, Vector128<ushort> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::UnpackHigh(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0007: ret

}
Vector128<int> vunpackhi(Vector128<int> x, Vector128<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::UnpackHigh(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0007: ret

}
Vector128<uint> vunpackhi(Vector128<uint> x, Vector128<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::UnpackHigh(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0007: ret

}
Vector128<long> vunpackhi(Vector128<long> x, Vector128<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse2::UnpackHigh(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0007: ret

}
Vector128<ulong> vunpackhi(Vector128<ulong> x, Vector128<ulong> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::UnpackHigh(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0007: ret

}
Vector256<sbyte> vunpackhi(Vector256<sbyte> x, Vector256<sbyte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::UnpackHigh(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0007: ret

}
Vector256<byte> vunpackhi(Vector256<byte> x, Vector256<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::UnpackHigh(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0007: ret

}
Vector256<short> vunpackhi(Vector256<short> x, Vector256<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::UnpackHigh(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0007: ret

}
Vector256<ushort> vunpackhi(Vector256<ushort> x, Vector256<ushort> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::UnpackHigh(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0007: ret

}
Vector256<int> vunpackhi(Vector256<int> x, Vector256<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::UnpackHigh(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0007: ret

}
Vector256<uint> vunpackhi(Vector256<uint> x, Vector256<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::UnpackHigh(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0007: ret

}
Vector256<long> vunpackhi(Vector256<long> x, Vector256<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::UnpackHigh(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0007: ret

}
Vector256<ulong> vunpackhi(Vector256<ulong> x, Vector256<ulong> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::UnpackHigh(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0007: ret

}
Vec128<sbyte> vunpacklo(in Vec128<sbyte> x, in Vec128<sbyte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::UnpackLow(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0011: call Z0.Vec128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0016: ret

}
Vec128<byte> vunpacklo(in Vec128<byte> x, in Vec128<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::UnpackLow(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0011: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0016: ret

}
Vec128<short> vunpacklo(in Vec128<short> x, in Vec128<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::UnpackLow(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0011: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0016: ret

}
Vec128<ushort> vunpacklo(in Vec128<ushort> x, in Vec128<ushort> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::UnpackLow(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0011: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0016: ret

}
Vec128<int> vunpacklo(in Vec128<int> x, in Vec128<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::UnpackLow(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0011: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0016: ret

}
Vec128<uint> vunpacklo(in Vec128<uint> x, in Vec128<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::UnpackLow(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0011: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0016: ret

}
Vec128<long> vunpacklo(in Vec128<long> x, in Vec128<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse2::UnpackLow(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0011: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0016: ret

}
Vec128<ulong> vunpacklo(in Vec128<ulong> x, in Vec128<ulong> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::UnpackLow(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0011: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0016: ret

}
Vec256<byte> vunpacklo(in Vec256<byte> x, in Vec256<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::UnpackLow(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0011: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0016: ret

}
Vec256<sbyte> vunpacklo(in Vec256<sbyte> x, in Vec256<sbyte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::UnpackLow(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0011: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0016: ret

}
Vec256<short> vunpacklo(in Vec256<short> x, in Vec256<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::UnpackLow(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0011: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0016: ret

}
Vec256<ushort> vunpacklo(in Vec256<ushort> x, in Vec256<ushort> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::UnpackLow(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0011: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0016: ret

}
Vec256<int> vunpacklo(in Vec256<int> x, in Vec256<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::UnpackLow(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0016: ret

}
Vec256<uint> vunpacklo(in Vec256<uint> x, in Vec256<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::UnpackLow(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0011: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0016: ret

}
Vec256<long> vunpacklo(in Vec256<long> x, in Vec256<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::UnpackLow(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0011: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0016: ret

}
Vec256<ulong> vunpacklo(in Vec256<ulong> x, in Vec256<ulong> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::UnpackLow(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0011: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0016: ret

}
Vector128<sbyte> vunpacklo(Vector128<sbyte> x, Vector128<sbyte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::UnpackLow(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0007: ret

}
Vector128<byte> vunpacklo(Vector128<byte> x, Vector128<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::UnpackLow(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0007: ret

}
Vector128<short> vunpacklo(Vector128<short> x, Vector128<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::UnpackLow(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0007: ret

}
Vector128<ushort> vunpacklo(Vector128<ushort> x, Vector128<ushort> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::UnpackLow(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0007: ret

}
Vector128<int> vunpacklo(Vector128<int> x, Vector128<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::UnpackLow(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0007: ret

}
Vector128<uint> vunpacklo(Vector128<uint> x, Vector128<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::UnpackLow(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0007: ret

}
Vector128<long> vunpacklo(Vector128<long> x, Vector128<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse2::UnpackLow(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0007: ret

}
Vector128<ulong> vunpacklo(Vector128<ulong> x, Vector128<ulong> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::UnpackLow(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0007: ret

}
Vector256<byte> vunpacklo(Vector256<byte> x, Vector256<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::UnpackLow(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0007: ret

}
Vector256<sbyte> vunpacklo(Vector256<sbyte> x, Vector256<sbyte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::UnpackLow(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0007: ret

}
Vector256<short> vunpacklo(Vector256<short> x, Vector256<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::UnpackLow(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0007: ret

}
Vector256<ushort> vunpacklo(Vector256<ushort> x, Vector256<ushort> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::UnpackLow(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0007: ret

}
Vector256<int> vunpacklo(Vector256<int> x, Vector256<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::UnpackLow(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0007: ret

}
Vector256<uint> vunpacklo(Vector256<uint> x, Vector256<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::UnpackLow(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0007: ret

}
Vector256<long> vunpacklo(Vector256<long> x, Vector256<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::UnpackLow(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0007: ret

}
Vector256<ulong> vunpacklo(Vector256<ulong> x, Vector256<ulong> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::UnpackLow(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0007: ret

}
Vector128<byte> vand(Vector128<byte> x, Vector128<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::And(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0007: ret

}
Vector128<short> vand(Vector128<short> x, Vector128<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::And(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0007: ret

}
Vector128<long> vlo(Vector256<long> src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Avx::ExtractVector128(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Byte)
    IL_0007: ret

}
Vector128<ulong> vlo(Vector256<ulong> src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx::ExtractVector128(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Byte)
    IL_0007: ret

}
Vec128<byte> vloada128(in byte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Byte* Z0.As::constptr(System.Byte&)
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::LoadAlignedVector128(System.Byte*)
    IL_000B: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0010: ret

}
Vec128<sbyte> vloada128(in sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.SByte* Z0.As::constptr(System.SByte&)
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::LoadAlignedVector128(System.SByte*)
    IL_000B: call Z0.Vec128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0010: ret

}
Vec128<short> vloada128(in short src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int16* Z0.As::constptr(System.Int16&)
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::LoadAlignedVector128(System.Int16*)
    IL_000B: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0010: ret

}
Vec128<ushort> vloada128(in ushort src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt16* Z0.As::constptr(System.UInt16&)
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::LoadAlignedVector128(System.UInt16*)
    IL_000B: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0010: ret

}
Vec128<int> vloada128(in int src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int32* Z0.As::constptr(System.Int32&)
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::LoadAlignedVector128(System.Int32*)
    IL_000B: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0010: ret

}
Vec128<uint> vloada128(in uint src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32* Z0.As::constptr(System.UInt32&)
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::LoadAlignedVector128(System.UInt32*)
    IL_000B: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0010: ret

}
Vec128<long> vloada128(in long src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int64* Z0.As::constptr(System.Int64&)
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse2::LoadAlignedVector128(System.Int64*)
    IL_000B: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0010: ret

}
Vec128<ulong> vloada128(in ulong src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt64* Z0.As::constptr(System.UInt64&)
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::LoadAlignedVector128(System.UInt64*)
    IL_000B: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0010: ret

}
Vec256<byte> vloada256(in byte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Byte* Z0.As::constptr(System.Byte&)
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx::LoadAlignedVector256(System.Byte*)
    IL_000B: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0010: ret

}
Vec256<sbyte> vloada256(in sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.SByte* Z0.As::constptr(System.SByte&)
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx::LoadAlignedVector256(System.SByte*)
    IL_000B: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0010: ret

}
Vec256<short> vloada256(in short src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int16* Z0.As::constptr(System.Int16&)
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx::LoadAlignedVector256(System.Int16*)
    IL_000B: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0010: ret

}
Vec256<ushort> vloada256(in ushort src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt16* Z0.As::constptr(System.UInt16&)
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx::LoadAlignedVector256(System.UInt16*)
    IL_000B: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0010: ret

}
Vec256<int> vloada256(in int src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int32* Z0.As::constptr(System.Int32&)
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx::LoadAlignedVector256(System.Int32*)
    IL_000B: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0010: ret

}
Vec256<uint> vloada256(in uint src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32* Z0.As::constptr(System.UInt32&)
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx::LoadAlignedVector256(System.UInt32*)
    IL_000B: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0010: ret

}
Vec256<long> vloada256(in long src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int64* Z0.As::constptr(System.Int64&)
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx::LoadAlignedVector256(System.Int64*)
    IL_000B: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0010: ret

}
Vec256<ulong> vloada256(in ulong src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt64* Z0.As::constptr(System.UInt64&)
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx::LoadAlignedVector256(System.UInt64*)
    IL_000B: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0010: ret

}
Vec128<byte> vloadu128(in byte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Byte* Z0.As::constptr(System.Byte&)
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse3::LoadDquVector128(System.Byte*)
    IL_000B: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0010: ret

}
Vec128<sbyte> vloadu128(in sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.SByte* Z0.As::constptr(System.SByte&)
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse3::LoadDquVector128(System.SByte*)
    IL_000B: call Z0.Vec128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0010: ret

}
Vec128<short> vloadu128(in short src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int16* Z0.As::constptr(System.Int16&)
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse3::LoadDquVector128(System.Int16*)
    IL_000B: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0010: ret

}
Vec128<ushort> vloadu128(in ushort src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt16* Z0.As::constptr(System.UInt16&)
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse3::LoadDquVector128(System.UInt16*)
    IL_000B: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0010: ret

}
Vec128<int> vloadu128(in int src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int32* Z0.As::constptr(System.Int32&)
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse3::LoadDquVector128(System.Int32*)
    IL_000B: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0010: ret

}
Vec128<uint> vloadu128(in uint src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32* Z0.As::constptr(System.UInt32&)
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse3::LoadDquVector128(System.UInt32*)
    IL_000B: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0010: ret

}
Vec128<long> vloadu128(in long src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int64* Z0.As::constptr(System.Int64&)
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse3::LoadDquVector128(System.Int64*)
    IL_000B: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0010: ret

}
Vec128<ulong> vloadu128(in ulong src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt64* Z0.As::constptr(System.UInt64&)
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse3::LoadDquVector128(System.UInt64*)
    IL_000B: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0010: ret

}
Vec256<byte> vloadu256(in byte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Byte* Z0.As::constptr(System.Byte&)
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx::LoadDquVector256(System.Byte*)
    IL_000B: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0010: ret

}
Vec256<sbyte> vloadu256(in sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.SByte* Z0.As::constptr(System.SByte&)
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx::LoadDquVector256(System.SByte*)
    IL_000B: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0010: ret

}
Vec256<short> vloadu256(in short src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int16* Z0.As::constptr(System.Int16&)
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx::LoadDquVector256(System.Int16*)
    IL_000B: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0010: ret

}
Vec256<ushort> vloadu256(in ushort src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt16* Z0.As::constptr(System.UInt16&)
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx::LoadDquVector256(System.UInt16*)
    IL_000B: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0010: ret

}
Vec256<int> vloadu256(in int src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int32* Z0.As::constptr(System.Int32&)
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx::LoadDquVector256(System.Int32*)
    IL_000B: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0010: ret

}
Vec256<uint> vloadu256(in uint src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32* Z0.As::constptr(System.UInt32&)
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx::LoadDquVector256(System.UInt32*)
    IL_000B: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0010: ret

}
Vec256<long> vloadu256(in long src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int64* Z0.As::constptr(System.Int64&)
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx::LoadDquVector256(System.Int64*)
    IL_000B: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0010: ret

}
Vec256<ulong> vloadu256(in ulong src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt64* Z0.As::constptr(System.UInt64&)
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx::LoadDquVector256(System.UInt64*)
    IL_000B: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0010: ret

}
Vector128<byte> vloadu(in byte src, out Vector128<byte> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Byte* Z0.As::constptr(System.Byte&)
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse3::LoadDquVector128(System.Byte*)
    IL_000C: dup
    IL_000D: stloc.0
    IL_000E: stobj System.Runtime.Intrinsics.Vector128`1<System.Byte>
    IL_0013: ldloc.0
    IL_0014: ret

}
Vector128<sbyte> vloadu(in sbyte src, out Vector128<sbyte> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.SByte* Z0.As::constptr(System.SByte&)
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse3::LoadDquVector128(System.SByte*)
    IL_000C: dup
    IL_000D: stloc.0
    IL_000E: stobj System.Runtime.Intrinsics.Vector128`1<System.SByte>
    IL_0013: ldloc.0
    IL_0014: ret

}
Vector128<short> vloadu(in short src, out Vector128<short> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Int16* Z0.As::constptr(System.Int16&)
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse3::LoadDquVector128(System.Int16*)
    IL_000C: dup
    IL_000D: stloc.0
    IL_000E: stobj System.Runtime.Intrinsics.Vector128`1<System.Int16>
    IL_0013: ldloc.0
    IL_0014: ret

}
Vector128<ushort> vloadu(in ushort src, out Vector128<ushort> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.UInt16* Z0.As::constptr(System.UInt16&)
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse3::LoadDquVector128(System.UInt16*)
    IL_000C: dup
    IL_000D: stloc.0
    IL_000E: stobj System.Runtime.Intrinsics.Vector128`1<System.UInt16>
    IL_0013: ldloc.0
    IL_0014: ret

}
Vector128<int> vloadu(in int src, out Vector128<int> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Int32* Z0.As::constptr(System.Int32&)
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse3::LoadDquVector128(System.Int32*)
    IL_000C: dup
    IL_000D: stloc.0
    IL_000E: stobj System.Runtime.Intrinsics.Vector128`1<System.Int32>
    IL_0013: ldloc.0
    IL_0014: ret

}
Vector128<uint> vloadu(in uint src, out Vector128<uint> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.UInt32* Z0.As::constptr(System.UInt32&)
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse3::LoadDquVector128(System.UInt32*)
    IL_000C: dup
    IL_000D: stloc.0
    IL_000E: stobj System.Runtime.Intrinsics.Vector128`1<System.UInt32>
    IL_0013: ldloc.0
    IL_0014: ret

}
Vector128<long> vloadu(in long src, out Vector128<long> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Int64* Z0.As::constptr(System.Int64&)
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse3::LoadDquVector128(System.Int64*)
    IL_000C: dup
    IL_000D: stloc.0
    IL_000E: stobj System.Runtime.Intrinsics.Vector128`1<System.Int64>
    IL_0013: ldloc.0
    IL_0014: ret

}
Vector128<ulong> vloadu(in ulong src, out Vector128<ulong> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.UInt64* Z0.As::constptr(System.UInt64&)
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse3::LoadDquVector128(System.UInt64*)
    IL_000C: dup
    IL_000D: stloc.0
    IL_000E: stobj System.Runtime.Intrinsics.Vector128`1<System.UInt64>
    IL_0013: ldloc.0
    IL_0014: ret

}
Vector256<byte> vloadu(in byte src, out Vector256<byte> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Byte* Z0.As::constptr(System.Byte&)
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx::LoadDquVector256(System.Byte*)
    IL_000C: dup
    IL_000D: stloc.0
    IL_000E: stobj System.Runtime.Intrinsics.Vector256`1<System.Byte>
    IL_0013: ldloc.0
    IL_0014: ret

}
Vector256<sbyte> vloadu(in sbyte src, out Vector256<sbyte> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.SByte* Z0.As::constptr(System.SByte&)
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx::LoadDquVector256(System.SByte*)
    IL_000C: dup
    IL_000D: stloc.0
    IL_000E: stobj System.Runtime.Intrinsics.Vector256`1<System.SByte>
    IL_0013: ldloc.0
    IL_0014: ret

}
Vector256<short> vloadu(in short src, out Vector256<short> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Int16* Z0.As::constptr(System.Int16&)
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx::LoadDquVector256(System.Int16*)
    IL_000C: dup
    IL_000D: stloc.0
    IL_000E: stobj System.Runtime.Intrinsics.Vector256`1<System.Int16>
    IL_0013: ldloc.0
    IL_0014: ret

}
Vector256<ushort> vloadu(in ushort src, out Vector256<ushort> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.UInt16* Z0.As::constptr(System.UInt16&)
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx::LoadDquVector256(System.UInt16*)
    IL_000C: dup
    IL_000D: stloc.0
    IL_000E: stobj System.Runtime.Intrinsics.Vector256`1<System.UInt16>
    IL_0013: ldloc.0
    IL_0014: ret

}
Vector256<int> vloadu(in int src, out Vector256<int> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Int32* Z0.As::constptr(System.Int32&)
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx::LoadDquVector256(System.Int32*)
    IL_000C: dup
    IL_000D: stloc.0
    IL_000E: stobj System.Runtime.Intrinsics.Vector256`1<System.Int32>
    IL_0013: ldloc.0
    IL_0014: ret

}
Vector256<uint> vloadu(in uint src, out Vector256<uint> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.UInt32* Z0.As::constptr(System.UInt32&)
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx::LoadDquVector256(System.UInt32*)
    IL_000C: dup
    IL_000D: stloc.0
    IL_000E: stobj System.Runtime.Intrinsics.Vector256`1<System.UInt32>
    IL_0013: ldloc.0
    IL_0014: ret

}
Vector256<long> vloadu(in long src, out Vector256<long> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Int64* Z0.As::constptr(System.Int64&)
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx::LoadDquVector256(System.Int64*)
    IL_000C: dup
    IL_000D: stloc.0
    IL_000E: stobj System.Runtime.Intrinsics.Vector256`1<System.Int64>
    IL_0013: ldloc.0
    IL_0014: ret

}
Vector256<ulong> vloadu(in ulong src, out Vector256<ulong> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.UInt64* Z0.As::constptr(System.UInt64&)
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx::LoadDquVector256(System.UInt64*)
    IL_000C: dup
    IL_000D: stloc.0
    IL_000E: stobj System.Runtime.Intrinsics.Vector256`1<System.UInt64>
    IL_0013: ldloc.0
    IL_0014: ret

}
void vmaskmove(Vector128<sbyte> src, Vector128<sbyte> mask, ref sbyte dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.SByte* Z0.As::refptr(System.SByte&)
    IL_0008: call System.Void System.Runtime.Intrinsics.X86.Sse2::MaskMove(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.SByte*)
    IL_000D: ret

}
void vmaskmove(Vector128<byte> src, Vector128<byte> mask, ref byte dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.Byte* Z0.As::refptr(System.Byte&)
    IL_0008: call System.Void System.Runtime.Intrinsics.X86.Sse2::MaskMove(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Byte*)
    IL_000D: ret

}
int vmovemask(Vector128<byte> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int32 System.Runtime.Intrinsics.X86.Sse2::MoveMask(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0006: ret

}
int vmovemask(Vector128<sbyte> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int32 System.Runtime.Intrinsics.X86.Sse2::MoveMask(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0006: ret

}
int vmovemask(Vector256<sbyte> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int32 System.Runtime.Intrinsics.X86.Avx2::MoveMask(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0006: ret

}
int vmovemask(Vector256<byte> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int32 System.Runtime.Intrinsics.X86.Avx2::MoveMask(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0006: ret

}
void vmaskstore(Vector128<int> src, Vector128<int> mask, ref int dst)
{
    IL_0000: ldarg.2
    IL_0001: call System.Int32* Z0.As::refptr(System.Int32&)
    IL_0006: ldarg.0
    IL_0007: ldarg.1
    IL_0008: call System.Void System.Runtime.Intrinsics.X86.Avx2::MaskStore(System.Int32*,System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_000D: ret

}
void vmaskstore(Vector256<int> src, Vector256<int> mask, ref int dst)
{
    IL_0000: ldarg.2
    IL_0001: call System.Int32* Z0.As::refptr(System.Int32&)
    IL_0006: ldarg.0
    IL_0007: ldarg.1
    IL_0008: call System.Void System.Runtime.Intrinsics.X86.Avx2::MaskStore(System.Int32*,System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_000D: ret

}
void vmaskstore(Vector256<uint> src, Vector256<uint> mask, ref uint dst)
{
    IL_0000: ldarg.2
    IL_0001: call System.UInt32* Z0.As::refptr(System.UInt32&)
    IL_0006: ldarg.0
    IL_0007: ldarg.1
    IL_0008: call System.Void System.Runtime.Intrinsics.X86.Avx2::MaskStore(System.UInt32*,System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_000D: ret

}
void vmaskstore(Vector256<long> src, Vector256<long> mask, ref long dst)
{
    IL_0000: ldarg.2
    IL_0001: call System.Int64* Z0.As::refptr(System.Int64&)
    IL_0006: ldarg.0
    IL_0007: ldarg.1
    IL_0008: call System.Void System.Runtime.Intrinsics.X86.Avx2::MaskStore(System.Int64*,System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_000D: ret

}
void vmaskstore(Vector256<ulong> src, Vector256<ulong> mask, ref ulong dst)
{
    IL_0000: ldarg.2
    IL_0001: call System.UInt64* Z0.As::refptr(System.UInt64&)
    IL_0006: ldarg.0
    IL_0007: ldarg.1
    IL_0008: call System.Void System.Runtime.Intrinsics.X86.Avx2::MaskStore(System.UInt64*,System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_000D: ret

}
Vector128<int> vmaskload(ref int src, Vector128<int> mask)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int32* Z0.As::refptr(System.Int32&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::MaskLoad(System.Int32*,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_000C: ret

}
Vector256<int> vmaskload(ref int src, Vector256<int> mask)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int32* Z0.As::refptr(System.Int32&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::MaskLoad(System.Int32*,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_000C: ret

}
Vector256<uint> vmaskload(ref uint src, Vector256<uint> mask)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32* Z0.As::refptr(System.UInt32&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::MaskLoad(System.UInt32*,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_000C: ret

}
Vector256<long> vmaskload(ref long src, Vector256<long> mask)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int64* Z0.As::refptr(System.Int64&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::MaskLoad(System.Int64*,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_000C: ret

}
Vector256<ulong> vmaskload(ref ulong src, Vector256<ulong> mask)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt64* Z0.As::refptr(System.UInt64&)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::MaskLoad(System.UInt64*,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_000C: ret

}
Vector128<byte> vmov128(in byte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Byte* Z0.As::constptr(System.Byte&)
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::LoadVector128(System.Byte*)
    IL_000B: ret

}
Vector128<sbyte> vmov128(in sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.SByte* Z0.As::constptr(System.SByte&)
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::LoadVector128(System.SByte*)
    IL_000B: ret

}
Vector128<short> vmov128(in short src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int16* Z0.As::constptr(System.Int16&)
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::LoadVector128(System.Int16*)
    IL_000B: ret

}
Vector128<ushort> vmov128(in ushort src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt16* Z0.As::constptr(System.UInt16&)
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::LoadVector128(System.UInt16*)
    IL_000B: ret

}
Vector128<int> vmov128(in int src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int32* Z0.As::constptr(System.Int32&)
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::LoadVector128(System.Int32*)
    IL_000B: ret

}
Vector128<uint> vmov128(in uint src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32* Z0.As::constptr(System.UInt32&)
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::LoadVector128(System.UInt32*)
    IL_000B: ret

}
Vector128<long> vmov128(in long src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int64* Z0.As::constptr(System.Int64&)
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse2::LoadVector128(System.Int64*)
    IL_000B: ret

}
Vector128<ulong> vmov128(in ulong src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt64* Z0.As::constptr(System.UInt64&)
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::LoadVector128(System.UInt64*)
    IL_000B: ret

}
Vector256<sbyte> vmov256(in sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.SByte* Z0.As::constptr(System.SByte&)
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx::LoadVector256(System.SByte*)
    IL_000B: ret

}
Vector256<byte> vmov256(in byte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Byte* Z0.As::constptr(System.Byte&)
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx::LoadVector256(System.Byte*)
    IL_000B: ret

}
Vector256<short> vmov256(in short src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int16* Z0.As::constptr(System.Int16&)
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx::LoadVector256(System.Int16*)
    IL_000B: ret

}
Vector256<ushort> vmov256(in ushort src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt16* Z0.As::constptr(System.UInt16&)
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx::LoadVector256(System.UInt16*)
    IL_000B: ret

}
Vector256<int> vmov256(in int src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int32* Z0.As::constptr(System.Int32&)
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx::LoadVector256(System.Int32*)
    IL_000B: ret

}
Vector256<uint> vmov256(in uint src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32* Z0.As::constptr(System.UInt32&)
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx::LoadVector256(System.UInt32*)
    IL_000B: ret

}
Vector256<long> vmov256(in long src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int64* Z0.As::constptr(System.Int64&)
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx::LoadVector256(System.Int64*)
    IL_000B: ret

}
Vector256<ulong> vmov256(in ulong src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt64* Z0.As::constptr(System.UInt64&)
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx::LoadVector256(System.UInt64*)
    IL_000B: ret

}
void movdqa(in Vector128<sbyte> src, ref sbyte dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.SByte* Z0.As::refptr(System.SByte&)
    IL_0006: ldarg.0
    IL_0007: ldobj System.Runtime.Intrinsics.Vector128`1<System.SByte>
    IL_000C: call System.Void System.Runtime.Intrinsics.X86.Sse2::StoreAligned(System.SByte*,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0011: ret

}
void movdqa(in Vector128<byte> src, ref byte dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.Byte* Z0.As::refptr(System.Byte&)
    IL_0006: ldarg.0
    IL_0007: ldobj System.Runtime.Intrinsics.Vector128`1<System.Byte>
    IL_000C: call System.Void System.Runtime.Intrinsics.X86.Sse2::StoreAligned(System.Byte*,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0011: ret

}
void movdqa(in Vector128<short> src, ref short dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.Int16* Z0.As::refptr(System.Int16&)
    IL_0006: ldarg.0
    IL_0007: ldobj System.Runtime.Intrinsics.Vector128`1<System.Int16>
    IL_000C: call System.Void System.Runtime.Intrinsics.X86.Sse2::StoreAligned(System.Int16*,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0011: ret

}
void movdqa(in Vector128<ushort> src, ref ushort dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.UInt16* Z0.As::refptr(System.UInt16&)
    IL_0006: ldarg.0
    IL_0007: ldobj System.Runtime.Intrinsics.Vector128`1<System.UInt16>
    IL_000C: call System.Void System.Runtime.Intrinsics.X86.Sse2::StoreAligned(System.UInt16*,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0011: ret

}
void movdqa(in Vector128<int> src, ref int dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.Int32* Z0.As::refptr(System.Int32&)
    IL_0006: ldarg.0
    IL_0007: ldobj System.Runtime.Intrinsics.Vector128`1<System.Int32>
    IL_000C: call System.Void System.Runtime.Intrinsics.X86.Sse2::StoreAligned(System.Int32*,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0011: ret

}
void movdqa(in Vector128<uint> src, ref uint dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.UInt32* Z0.As::refptr(System.UInt32&)
    IL_0006: ldarg.0
    IL_0007: ldobj System.Runtime.Intrinsics.Vector128`1<System.UInt32>
    IL_000C: call System.Void System.Runtime.Intrinsics.X86.Sse2::StoreAligned(System.UInt32*,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0011: ret

}
void movdqa(in Vector128<long> src, ref long dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.Int64* Z0.As::refptr(System.Int64&)
    IL_0006: ldarg.0
    IL_0007: ldobj System.Runtime.Intrinsics.Vector128`1<System.Int64>
    IL_000C: call System.Void System.Runtime.Intrinsics.X86.Sse2::StoreAligned(System.Int64*,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0011: ret

}
void movdqa(in Vector128<ulong> src, ref ulong dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.UInt64* Z0.As::refptr(System.UInt64&)
    IL_0006: ldarg.0
    IL_0007: ldobj System.Runtime.Intrinsics.Vector128`1<System.UInt64>
    IL_000C: call System.Void System.Runtime.Intrinsics.X86.Sse2::StoreAligned(System.UInt64*,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0011: ret

}
void movdqa(in Vector256<sbyte> src, ref sbyte dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.SByte* Z0.As::refptr(System.SByte&)
    IL_0006: ldarg.0
    IL_0007: ldobj System.Runtime.Intrinsics.Vector256`1<System.SByte>
    IL_000C: call System.Void System.Runtime.Intrinsics.X86.Avx::StoreAligned(System.SByte*,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0011: ret

}
void movdqa(in Vector256<byte> src, ref byte dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.Byte* Z0.As::refptr(System.Byte&)
    IL_0006: ldarg.0
    IL_0007: ldobj System.Runtime.Intrinsics.Vector256`1<System.Byte>
    IL_000C: call System.Void System.Runtime.Intrinsics.X86.Avx::StoreAligned(System.Byte*,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0011: ret

}
void movdqa(in Vector256<short> src, ref short dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.Int16* Z0.As::refptr(System.Int16&)
    IL_0006: ldarg.0
    IL_0007: ldobj System.Runtime.Intrinsics.Vector256`1<System.Int16>
    IL_000C: call System.Void System.Runtime.Intrinsics.X86.Avx::StoreAligned(System.Int16*,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0011: ret

}
void movdqa(in Vector256<ushort> src, ref ushort dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.UInt16* Z0.As::refptr(System.UInt16&)
    IL_0006: ldarg.0
    IL_0007: ldobj System.Runtime.Intrinsics.Vector256`1<System.UInt16>
    IL_000C: call System.Void System.Runtime.Intrinsics.X86.Avx::StoreAligned(System.UInt16*,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0011: ret

}
void movdqa(in Vector256<int> src, ref int dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.Int32* Z0.As::refptr(System.Int32&)
    IL_0006: ldarg.0
    IL_0007: ldobj System.Runtime.Intrinsics.Vector256`1<System.Int32>
    IL_000C: call System.Void System.Runtime.Intrinsics.X86.Avx::StoreAligned(System.Int32*,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: ret

}
void movdqa(in Vector256<uint> src, ref uint dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.UInt32* Z0.As::refptr(System.UInt32&)
    IL_0006: ldarg.0
    IL_0007: ldobj System.Runtime.Intrinsics.Vector256`1<System.UInt32>
    IL_000C: call System.Void System.Runtime.Intrinsics.X86.Avx::StoreAligned(System.UInt32*,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0011: ret

}
void movdqa(in Vector256<long> src, ref long dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.Int64* Z0.As::refptr(System.Int64&)
    IL_0006: ldarg.0
    IL_0007: ldobj System.Runtime.Intrinsics.Vector256`1<System.Int64>
    IL_000C: call System.Void System.Runtime.Intrinsics.X86.Avx::StoreAligned(System.Int64*,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0011: ret

}
void movdqa(in Vector256<ulong> src, ref ulong dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.UInt64* Z0.As::refptr(System.UInt64&)
    IL_0006: ldarg.0
    IL_0007: ldobj System.Runtime.Intrinsics.Vector256`1<System.UInt64>
    IL_000C: call System.Void System.Runtime.Intrinsics.X86.Avx::StoreAligned(System.UInt64*,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0011: ret

}
Vec256<sbyte> vperm2x128(in Vec256<sbyte> x, in Vec256<sbyte> y, Perm2x128:byte spec)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::ymm
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::Permute2x128(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Byte)
    IL_0012: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0017: ret

}
Vec256<byte> vperm2x128(in Vec256<byte> x, in Vec256<byte> y, Perm2x128:byte spec)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::ymm
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::Permute2x128(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Byte)
    IL_0012: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0017: ret

}
Vec256<short> vperm2x128(in Vec256<short> x, in Vec256<short> y, Perm2x128:byte spec)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::ymm
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::Permute2x128(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Byte)
    IL_0012: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0017: ret

}
Vec256<ushort> vperm2x128(in Vec256<ushort> x, in Vec256<ushort> y, Perm2x128:byte spec)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::ymm
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::Permute2x128(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Byte)
    IL_0012: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0017: ret

}
Vec256<int> vperm2x128(in Vec256<int> x, in Vec256<int> y, Perm2x128:byte spec)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::ymm
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::Permute2x128(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Byte)
    IL_0012: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0017: ret

}
Vec256<uint> vperm2x128(in Vec256<uint> x, in Vec256<uint> y, Perm2x128:byte spec)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt32>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.UInt32>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>)
    IL_0016: ldarg.2
    IL_0017: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::Permute2x128(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Byte)
    IL_001C: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0021: ret

}
Vec256<long> vperm2x128(in Vec256<long> x, in Vec256<long> y, Perm2x128:byte spec)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::ymm
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::Permute2x128(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Byte)
    IL_0012: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0017: ret

}
Vec256<ulong> vperm2x128(in Vec256<ulong> x, in Vec256<ulong> y, Perm2x128:byte spec)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::ymm
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::Permute2x128(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Byte)
    IL_0012: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0017: ret

}
Vec256<float> vperm2x128(in Vec256<float> x, in Vec256<float> y, Perm2x128:byte spec)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::ymm
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.Single> System.Runtime.Intrinsics.X86.Avx::Permute2x128(System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Byte)
    IL_0012: call Z0.Vec256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_0017: ret

}
Vec256<double> vperm2x128(in Vec256<double> x, in Vec256<double> y, Perm2x128:byte spec)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::ymm
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.Double> System.Runtime.Intrinsics.X86.Avx::Permute2x128(System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Byte)
    IL_0012: call Z0.Vec256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_0017: ret

}
Vector256<sbyte> vperm2x128(Vector256<sbyte> x, Vector256<sbyte> y, Perm2x128:byte spec)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::Permute2x128(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Byte)
    IL_0008: ret

}
Vector256<byte> vperm2x128(Vector256<byte> x, Vector256<byte> y, Perm2x128:byte spec)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::Permute2x128(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Byte)
    IL_0008: ret

}
Vector256<short> vperm2x128(Vector256<short> x, Vector256<short> y, Perm2x128:byte spec)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::Permute2x128(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Byte)
    IL_0008: ret

}
Vector256<ushort> vperm2x128(Vector256<ushort> x, Vector256<ushort> y, Perm2x128:byte spec)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::Permute2x128(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Byte)
    IL_0008: ret

}
Vector256<int> vperm2x128(Vector256<int> x, Vector256<int> y, Perm2x128:byte spec)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::Permute2x128(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Byte)
    IL_0008: ret

}
Vector256<uint> vperm2x128(Vector256<uint> x, Vector256<uint> y, Perm2x128:byte spec)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::Permute2x128(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Byte)
    IL_0008: ret

}
Vector256<long> vperm2x128(Vector256<long> x, Vector256<long> y, Perm2x128:byte spec)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::Permute2x128(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Byte)
    IL_0008: ret

}
Vector256<ulong> vperm2x128(Vector256<ulong> x, Vector256<ulong> y, Perm2x128:byte spec)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::Permute2x128(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Byte)
    IL_0008: ret

}
Vector256<float> vperm2x128(Vector256<float> x, Vector256<float> y, Perm2x128:byte spec)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.Single> System.Runtime.Intrinsics.X86.Avx::Permute2x128(System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Byte)
    IL_0008: ret

}
Vector256<double> vperm2x128(Vector256<double> x, Vector256<double> y, Perm2x128:byte spec)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.Double> System.Runtime.Intrinsics.X86.Avx::Permute2x128(System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Byte)
    IL_0008: ret

}
Vec256<long> vperm4x64(in Vec256<long> x, Perm4:byte spec)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::ymm
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::Permute4x64(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Byte)
    IL_000C: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0011: ret

}
Vec256<ulong> vperm4x64(in Vec256<ulong> x, Perm4:byte spec)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::ymm
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::Permute4x64(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Byte)
    IL_000C: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0011: ret

}
Vec256<double> vperm4x64(in Vec256<double> x, Perm4:byte spec)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::ymm
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Double> System.Runtime.Intrinsics.X86.Avx2::Permute4x64(System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Byte)
    IL_000C: call Z0.Vec256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_0011: ret

}
Vec256<int> vpermvar8x32(in Vec256<int> src, in Vec256<int> spec)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::PermuteVar8x32(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0016: ret

}
Vec256<uint> vpermvar8x32(in Vec256<uint> src, in Vec256<uint> spec)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::PermuteVar8x32(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0011: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0016: ret

}
Vec256<float> vpermvar8x32(in Vec256<float> src, in Vec256<int> spec)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Single> System.Runtime.Intrinsics.X86.Avx2::PermuteVar8x32(System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: call Z0.Vec256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_0016: ret

}
Vector256<int> vpermvar8x32(Vector256<int> src, Vector256<int> spec)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::PermuteVar8x32(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0007: ret

}
Vector256<uint> vpermvar8x32(Vector256<uint> src, Vector256<uint> spec)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::PermuteVar8x32(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0007: ret

}
Vector256<float> vpermvar8x32(Vector256<float> src, Vector256<int> spec)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Single> System.Runtime.Intrinsics.X86.Avx2::PermuteVar8x32(System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0007: ret

}
Vector128<byte> reverse(Vector128<byte> src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.s 15
    IL_0003: call Z0.Swap[] System.Array::Empty<Z0.Swap>()
    IL_0008: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128Pattern::decrements<System.Byte>(System.Byte,Z0.Swap[])
    IL_000D: stloc.0
    IL_000E: ldloca.s V_0
    IL_0010: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.dinx::vshuffle(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>&)
    IL_0015: ret

}
Vec256<int> vblendvar(in Vec256<int> x, in Vec256<int> y, in Vec256<int> spec)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::ymm
    IL_000C: ldarg.2
    IL_000D: ldobj Z0.Vec256`1<System.Int32>
    IL_0012: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_0017: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::BlendVariable(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_001C: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0021: ret

}
Vec256<uint> vblendvar(in Vec256<uint> x, in Vec256<uint> y, in Vec256<uint> spec)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::ymm
    IL_000C: ldarg.2
    IL_000D: ldobj Z0.Vec256`1<System.UInt32>
    IL_0012: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>)
    IL_0017: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::BlendVariable(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_001C: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0021: ret

}
Vec256<long> vblendvar(in Vec256<long> x, in Vec256<long> y, in Vec256<long> spec)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::ymm
    IL_000C: ldarg.2
    IL_000D: ldobj Z0.Vec256`1<System.Int64>
    IL_0012: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>)
    IL_0017: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::BlendVariable(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_001C: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0021: ret

}
Vec256<ulong> vblendvar(in Vec256<ulong> x, in Vec256<ulong> y, in Vec256<ulong> spec)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::ymm
    IL_000C: ldarg.2
    IL_000D: ldobj Z0.Vec256`1<System.UInt64>
    IL_0012: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>)
    IL_0017: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::BlendVariable(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_001C: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0021: ret

}
Vector128<sbyte> vbroadcast(N128 n, sbyte src)
{
    IL_0000: ldarga.s src
    IL_0002: conv.u
    IL_0003: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::BroadcastScalarToVector128(System.SByte*)
    IL_0008: ret

}
Vector128<byte> vbroadcast(N128 n, byte src)
{
    IL_0000: ldarga.s src
    IL_0002: conv.u
    IL_0003: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::BroadcastScalarToVector128(System.Byte*)
    IL_0008: ret

}
Vector128<short> vbroadcast(N128 n, short src)
{
    IL_0000: ldarga.s src
    IL_0002: conv.u
    IL_0003: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::BroadcastScalarToVector128(System.Int16*)
    IL_0008: ret

}
Vector128<ushort> vbroadcast(N128 n, ushort src)
{
    IL_0000: ldarga.s src
    IL_0002: conv.u
    IL_0003: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::BroadcastScalarToVector128(System.UInt16*)
    IL_0008: ret

}
Vector128<int> vbroadcast(N128 n, int src)
{
    IL_0000: ldarga.s src
    IL_0002: conv.u
    IL_0003: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::BroadcastScalarToVector128(System.Int32*)
    IL_0008: ret

}
Vector128<uint> vbroadcast(N128 n, uint src)
{
    IL_0000: ldarga.s src
    IL_0002: conv.u
    IL_0003: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::BroadcastScalarToVector128(System.UInt32*)
    IL_0008: ret

}
Vector128<long> vbroadcast(N128 n, long src)
{
    IL_0000: ldarga.s src
    IL_0002: conv.u
    IL_0003: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::BroadcastScalarToVector128(System.Int64*)
    IL_0008: ret

}
Vector128<ulong> vbroadcast(N128 n, ulong src)
{
    IL_0000: ldarga.s src
    IL_0002: conv.u
    IL_0003: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::BroadcastScalarToVector128(System.UInt64*)
    IL_0008: ret

}
Vector256<sbyte> vbroadcast(N256 n, sbyte src)
{
    IL_0000: ldarga.s src
    IL_0002: conv.u
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::BroadcastScalarToVector256(System.SByte*)
    IL_0008: ret

}
Vector256<byte> vbroadcast(N256 n, byte src)
{
    IL_0000: ldarga.s src
    IL_0002: conv.u
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::BroadcastScalarToVector256(System.Byte*)
    IL_0008: ret

}
Vector256<short> vbroadcast(N256 n, short src)
{
    IL_0000: ldarga.s src
    IL_0002: conv.u
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::BroadcastScalarToVector256(System.Int16*)
    IL_0008: ret

}
Vector256<ushort> vbroadcast(N256 n, ushort src)
{
    IL_0000: ldarga.s src
    IL_0002: conv.u
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::BroadcastScalarToVector256(System.UInt16*)
    IL_0008: ret

}
Vector256<int> vbroadcast(N256 n, int src)
{
    IL_0000: ldarga.s src
    IL_0002: conv.u
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::BroadcastScalarToVector256(System.Int32*)
    IL_0008: ret

}
Vector256<uint> vbroadcast(N256 n, uint src)
{
    IL_0000: ldarga.s src
    IL_0002: conv.u
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::BroadcastScalarToVector256(System.UInt32*)
    IL_0008: ret

}
Vector256<long> vbroadcast(N256 n, long src)
{
    IL_0000: ldarga.s src
    IL_0002: conv.u
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::BroadcastScalarToVector256(System.Int64*)
    IL_0008: ret

}
Vector256<ulong> vbroadcast(N256 n, ulong src)
{
    IL_0000: ldarga.s src
    IL_0002: conv.u
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::BroadcastScalarToVector256(System.UInt64*)
    IL_0008: ret

}
ref Vector128<short> vconvert(Vector128<sbyte> src, out Vector128<short> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse41::ConvertToVector128Int16(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0007: stobj System.Runtime.Intrinsics.Vector128`1<System.Int16>
    IL_000C: ldarg.1
    IL_000D: ret

}
ref Vector128<int> vconvert(Vector128<sbyte> src, out Vector128<int> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse41::ConvertToVector128Int32(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0007: stobj System.Runtime.Intrinsics.Vector128`1<System.Int32>
    IL_000C: ldarg.1
    IL_000D: ret

}
ref Vector128<long> vconvert(Vector128<sbyte> src, out Vector128<long> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse41::ConvertToVector128Int64(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0007: stobj System.Runtime.Intrinsics.Vector128`1<System.Int64>
    IL_000C: ldarg.1
    IL_000D: ret

}
ref Vector128<short> vconvert(Vector128<byte> src, out Vector128<short> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse41::ConvertToVector128Int16(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0007: stobj System.Runtime.Intrinsics.Vector128`1<System.Int16>
    IL_000C: ldarg.1
    IL_000D: ret

}
ref Vector128<ushort> vconvert(Vector128<byte> src, out Vector128<ushort> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse41::ConvertToVector128Int16(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.Vector128::AsUInt16<System.Int16>(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_000C: stobj System.Runtime.Intrinsics.Vector128`1<System.UInt16>
    IL_0011: ldarg.1
    IL_0012: ret

}
ref Vector128<int> vconvert(Vector128<byte> src, out Vector128<int> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse41::ConvertToVector128Int32(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0007: stobj System.Runtime.Intrinsics.Vector128`1<System.Int32>
    IL_000C: ldarg.1
    IL_000D: ret

}
ref Vector128<uint> vconvert(Vector128<byte> src, out Vector128<uint> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse41::ConvertToVector128Int32(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.Vector128::AsUInt32<System.Int32>(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_000C: stobj System.Runtime.Intrinsics.Vector128`1<System.UInt32>
    IL_0011: ldarg.1
    IL_0012: ret

}
ref Vector128<long> vconvert(Vector128<byte> src, out Vector128<long> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse41::ConvertToVector128Int64(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0007: stobj System.Runtime.Intrinsics.Vector128`1<System.Int64>
    IL_000C: ldarg.1
    IL_000D: ret

}
ref Vector128<ulong> vconvert(Vector128<byte> src, out Vector128<ulong> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse41::ConvertToVector128Int64(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.Vector128::AsUInt64<System.Int64>(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_000C: stobj System.Runtime.Intrinsics.Vector128`1<System.UInt64>
    IL_0011: ldarg.1
    IL_0012: ret

}
ref Vector128<int> vconvert(Vector128<short> src, out Vector128<int> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse41::ConvertToVector128Int32(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0007: stobj System.Runtime.Intrinsics.Vector128`1<System.Int32>
    IL_000C: ldarg.1
    IL_000D: ret

}
ref Vector128<long> vconvert(Vector128<short> src, out Vector128<long> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse41::ConvertToVector128Int64(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0007: stobj System.Runtime.Intrinsics.Vector128`1<System.Int64>
    IL_000C: ldarg.1
    IL_000D: ret

}
ref Vector128<int> vconvert(Vector128<ushort> src, out Vector128<int> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse41::ConvertToVector128Int32(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0007: stobj System.Runtime.Intrinsics.Vector128`1<System.Int32>
    IL_000C: ldarg.1
    IL_000D: ret

}
ref Vector128<uint> vconvert(Vector128<ushort> src, out Vector128<uint> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse41::ConvertToVector128Int32(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.Vector128::AsUInt32<System.Int32>(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_000C: stobj System.Runtime.Intrinsics.Vector128`1<System.UInt32>
    IL_0011: ldarg.1
    IL_0012: ret

}
ref Vector128<long> vconvert(Vector128<ushort> src, out Vector128<long> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse41::ConvertToVector128Int64(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0007: stobj System.Runtime.Intrinsics.Vector128`1<System.Int64>
    IL_000C: ldarg.1
    IL_000D: ret

}
ref Vector128<ulong> vconvert(Vector128<ushort> src, out Vector128<ulong> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse41::ConvertToVector128Int64(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.Vector128::AsUInt64<System.Int64>(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_000C: stobj System.Runtime.Intrinsics.Vector128`1<System.UInt64>
    IL_0011: ldarg.1
    IL_0012: ret

}
ref Vector128<long> vconvert(Vector128<int> src, out Vector128<long> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse41::ConvertToVector128Int64(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0007: stobj System.Runtime.Intrinsics.Vector128`1<System.Int64>
    IL_000C: ldarg.1
    IL_000D: ret

}
ref Vector128<long> vconvert(Vector128<uint> src, out Vector128<long> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse41::ConvertToVector128Int64(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0007: stobj System.Runtime.Intrinsics.Vector128`1<System.Int64>
    IL_000C: ldarg.1
    IL_000D: ret

}
ref Vector128<ulong> vconvert(Vector128<uint> src, out Vector128<ulong> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse41::ConvertToVector128Int64(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.Vector128::AsUInt64<System.Int64>(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_000C: stobj System.Runtime.Intrinsics.Vector128`1<System.UInt64>
    IL_0011: ldarg.1
    IL_0012: ret

}
ref Vector256<short> vconvert(Vector128<sbyte> src, out Vector256<short> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::ConvertToVector256Int16(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0007: stobj System.Runtime.Intrinsics.Vector256`1<System.Int16>
    IL_000C: ldarg.1
    IL_000D: ret

}
ref Vector256<int> vconvert(Vector128<sbyte> src, out Vector256<int> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::ConvertToVector256Int32(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0007: stobj System.Runtime.Intrinsics.Vector256`1<System.Int32>
    IL_000C: ldarg.1
    IL_000D: ret

}
ref Vector256<long> vconvert(Vector128<sbyte> src, out Vector256<long> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::ConvertToVector256Int64(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0007: stobj System.Runtime.Intrinsics.Vector256`1<System.Int64>
    IL_000C: ldarg.1
    IL_000D: ret

}
ref Vector256<short> vconvert(Vector128<byte> src, out Vector256<short> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::ConvertToVector256Int16(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0007: stobj System.Runtime.Intrinsics.Vector256`1<System.Int16>
    IL_000C: ldarg.1
    IL_000D: ret

}
ref Vector256<ushort> vconvert(Vector128<byte> src, out Vector256<ushort> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::ConvertToVector256Int16(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.Vector256::AsUInt16<System.Int16>(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_000C: stobj System.Runtime.Intrinsics.Vector256`1<System.UInt16>
    IL_0011: ldarg.1
    IL_0012: ret

}
ref Vector256<int> vconvert(Vector128<byte> src, out Vector256<int> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::ConvertToVector256Int32(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0007: stobj System.Runtime.Intrinsics.Vector256`1<System.Int32>
    IL_000C: ldarg.1
    IL_000D: ret

}
ref Vector256<uint> vconvert(Vector128<byte> src, out Vector256<uint> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::ConvertToVector256Int32(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.Vector256::AsUInt32<System.Int32>(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_000C: stobj System.Runtime.Intrinsics.Vector256`1<System.UInt32>
    IL_0011: ldarg.1
    IL_0012: ret

}
ref Vector256<long> vconvert(Vector128<byte> src, out Vector256<long> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::ConvertToVector256Int64(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0007: stobj System.Runtime.Intrinsics.Vector256`1<System.Int64>
    IL_000C: ldarg.1
    IL_000D: ret

}
ref Vector256<ulong> vconvert(Vector128<byte> src, out Vector256<ulong> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::ConvertToVector256Int64(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.Vector256::AsUInt64<System.Int64>(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_000C: stobj System.Runtime.Intrinsics.Vector256`1<System.UInt64>
    IL_0011: ldarg.1
    IL_0012: ret

}
ref Vector256<int> vconvert(Vector128<short> src, out Vector256<int> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::ConvertToVector256Int32(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0007: stobj System.Runtime.Intrinsics.Vector256`1<System.Int32>
    IL_000C: ldarg.1
    IL_000D: ret

}
ref Vector256<long> vconvert(Vector128<int> src, out Vector256<long> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::ConvertToVector256Int64(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0007: stobj System.Runtime.Intrinsics.Vector256`1<System.Int64>
    IL_000C: ldarg.1
    IL_000D: ret

}
ref Vector256<long> vconvert(Vector128<short> src, out Vector256<long> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::ConvertToVector256Int64(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0007: stobj System.Runtime.Intrinsics.Vector256`1<System.Int64>
    IL_000C: ldarg.1
    IL_000D: ret

}
ref Vector256<int> vconvert(Vector128<ushort> src, out Vector256<int> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::ConvertToVector256Int32(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0007: stobj System.Runtime.Intrinsics.Vector256`1<System.Int32>
    IL_000C: ldarg.1
    IL_000D: ret

}
ref Vector256<uint> vconvert(Vector128<ushort> src, out Vector256<uint> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::ConvertToVector256Int32(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.Vector256::AsUInt32<System.Int32>(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_000C: stobj System.Runtime.Intrinsics.Vector256`1<System.UInt32>
    IL_0011: ldarg.1
    IL_0012: ret

}
ref Vector256<long> vconvert(Vector128<ushort> src, out Vector256<long> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::ConvertToVector256Int64(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0007: stobj System.Runtime.Intrinsics.Vector256`1<System.Int64>
    IL_000C: ldarg.1
    IL_000D: ret

}
ref Vector256<ulong> vconvert(Vector128<ushort> src, out Vector256<ulong> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::ConvertToVector256Int64(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.Vector256::AsUInt64<System.Int64>(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_000C: stobj System.Runtime.Intrinsics.Vector256`1<System.UInt64>
    IL_0011: ldarg.1
    IL_0012: ret

}
ref Vector256<long> vconvert(Vector128<uint> src, out Vector256<long> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::ConvertToVector256Int64(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0007: stobj System.Runtime.Intrinsics.Vector256`1<System.Int64>
    IL_000C: ldarg.1
    IL_000D: ret

}
ref Vector256<ulong> vconvert(Vector128<uint> src, out Vector256<ulong> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::ConvertToVector256Int64(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.Vector256::AsUInt64<System.Int64>(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_000C: stobj System.Runtime.Intrinsics.Vector256`1<System.UInt64>
    IL_0011: ldarg.1
    IL_0012: ret

}
byte vextract(Vector128<byte> src, byte pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Byte System.Runtime.Intrinsics.X86.Sse41::Extract(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Byte)
    IL_0007: ret

}
sbyte vextract(Vector128<sbyte> src, byte pos)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.Vector128::AsByte<System.SByte>(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0006: ldarg.1
    IL_0007: call System.Byte System.Runtime.Intrinsics.X86.Sse41::Extract(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Byte)
    IL_000C: conv.i1
    IL_000D: ret

}
short vextract(Vector128<short> src, byte pos)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.Vector128::AsUInt16<System.Int16>(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0006: ldarg.1
    IL_0007: call System.UInt16 System.Runtime.Intrinsics.X86.Sse2::Extract(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Byte)
    IL_000C: conv.i2
    IL_000D: ret

}
ushort vextract(Vector128<ushort> src, byte pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt16 System.Runtime.Intrinsics.X86.Sse2::Extract(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Byte)
    IL_0007: ret

}
int vextract(Vector128<int> src, byte pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Int32 System.Runtime.Intrinsics.X86.Sse41::Extract(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Byte)
    IL_0007: ret

}
uint vextract(Vector128<uint> src, byte pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 System.Runtime.Intrinsics.X86.Sse41::Extract(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Byte)
    IL_0007: ret

}
long vextract(Vector128<long> src, byte pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Int64 System.Runtime.Intrinsics.X86.Sse41/X64::Extract(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Byte)
    IL_0007: ret

}
ulong vextract(Vector128<ulong> src, byte pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 System.Runtime.Intrinsics.X86.Sse41/X64::Extract(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Byte)
    IL_0007: ret

}
Vec128<sbyte> vhi(in Vec256<sbyte> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.SByte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>)
    IL_000B: ldc.i4.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Avx::ExtractVector128(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0016: ret

}
Vec128<byte> vhi(in Vec256<byte> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_000B: ldc.i4.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Avx::ExtractVector128(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0016: ret

}
Vec128<short> vhi(in Vec256<short> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>)
    IL_000B: ldc.i4.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Avx::ExtractVector128(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0016: ret

}
Vec128<ushort> vhi(in Vec256<ushort> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt16>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>)
    IL_000B: ldc.i4.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx::ExtractVector128(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0016: ret

}
Vec128<int> vhi(in Vec256<int> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_000B: ldc.i4.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Avx::ExtractVector128(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0016: ret

}
Vec128<uint> vhi(in Vec256<uint> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt32>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>)
    IL_000B: ldc.i4.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx::ExtractVector128(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0016: ret

}
Vec128<long> vhi(in Vec256<long> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int64>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>)
    IL_000B: ldc.i4.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Avx::ExtractVector128(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0016: ret

}
Vec128<ulong> vhi(in Vec256<ulong> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt64>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>)
    IL_000B: ldc.i4.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx::ExtractVector128(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0016: ret

}
Vector128<sbyte> vhi(Vector256<sbyte> src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Avx::ExtractVector128(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Byte)
    IL_0007: ret

}
Vector128<byte> vhi(Vector256<byte> src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Avx::ExtractVector128(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Byte)
    IL_0007: ret

}
Vector128<short> vhi(Vector256<short> src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Avx::ExtractVector128(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Byte)
    IL_0007: ret

}
Vector128<ushort> vhi(Vector256<ushort> src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx::ExtractVector128(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Byte)
    IL_0007: ret

}
Vector128<int> vhi(Vector256<int> src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Avx::ExtractVector128(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Byte)
    IL_0007: ret

}
Vector128<uint> vhi(Vector256<uint> src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx::ExtractVector128(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Byte)
    IL_0007: ret

}
Vector128<long> vhi(Vector256<long> src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Avx::ExtractVector128(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Byte)
    IL_0007: ret

}
Vector128<ulong> vhi(Vector256<ulong> src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx::ExtractVector128(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Byte)
    IL_0007: ret

}
Vec128<byte> vinsert(byte src, in Vec128<byte> dst, byte index)
{
    IL_0000: ldarg.1
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::xmm
    IL_0006: ldarg.0
    IL_0007: ldarg.2
    IL_0008: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse41::Insert(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Byte,System.Byte)
    IL_000D: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0012: ret

}
Vec128<sbyte> vinsert(sbyte src, in Vec128<sbyte> dst, byte index)
{
    IL_0000: ldarg.1
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::xmm
    IL_0006: ldarg.0
    IL_0007: ldarg.2
    IL_0008: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse41::Insert(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.SByte,System.Byte)
    IL_000D: call Z0.Vec128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0012: ret

}
Vec128<short> vinsert(short src, in Vec128<short> dst, byte index)
{
    IL_0000: ldarg.1
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::xmm
    IL_0006: ldarg.0
    IL_0007: ldarg.2
    IL_0008: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::Insert(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Int16,System.Byte)
    IL_000D: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0012: ret

}
Vec128<ushort> vinsert(ushort src, in Vec128<ushort> dst, byte index)
{
    IL_0000: ldarg.1
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::xmm
    IL_0006: ldarg.0
    IL_0007: ldarg.2
    IL_0008: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::Insert(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.UInt16,System.Byte)
    IL_000D: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0012: ret

}
Vec128<int> vinsert(int src, in Vec128<int> dst, byte index)
{
    IL_0000: ldarg.1
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::xmm
    IL_0006: ldarg.0
    IL_0007: ldarg.2
    IL_0008: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse41::Insert(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Int32,System.Byte)
    IL_000D: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0012: ret

}
Vec128<uint> vinsert(uint src, in Vec128<uint> dst, byte index)
{
    IL_0000: ldarg.1
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::xmm
    IL_0006: ldarg.0
    IL_0007: ldarg.2
    IL_0008: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse41::Insert(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.UInt32,System.Byte)
    IL_000D: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0012: ret

}
Vec128<long> vinsert(long src, in Vec128<long> dst, byte index)
{
    IL_0000: ldarg.1
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::xmm
    IL_0006: ldarg.0
    IL_0007: ldarg.2
    IL_0008: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse41/X64::Insert(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Int64,System.Byte)
    IL_000D: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0012: ret

}
Vec128<ulong> vinsert(ulong src, in Vec128<ulong> dst, byte index)
{
    IL_0000: ldarg.1
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::xmm
    IL_0006: ldarg.0
    IL_0007: ldarg.2
    IL_0008: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse41/X64::Insert(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.UInt64,System.Byte)
    IL_000D: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0012: ret

}
Vec256<sbyte> vinsert(in Vec128<sbyte> src, in Vec256<sbyte> dst, byte index)
{
    IL_0000: ldarg.1
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::ymm
    IL_0006: ldarg.0
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::xmm
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::InsertVector128(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Byte)
    IL_0012: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0017: ret

}
Vec256<byte> vinsert(in Vec128<byte> src, in Vec256<byte> dst, byte index)
{
    IL_0000: ldarg.1
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::ymm
    IL_0006: ldarg.0
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::xmm
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::InsertVector128(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Byte)
    IL_0012: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0017: ret

}
Vec256<short> vinsert(in Vec128<short> src, in Vec256<short> dst, byte index)
{
    IL_0000: ldarg.1
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::ymm
    IL_0006: ldarg.0
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::xmm
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::InsertVector128(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Byte)
    IL_0012: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0017: ret

}
Vec256<ushort> vinsert(in Vec128<ushort> src, in Vec256<ushort> dst, byte index)
{
    IL_0000: ldarg.1
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::ymm
    IL_0006: ldarg.0
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::xmm
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::InsertVector128(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Byte)
    IL_0012: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0017: ret

}
Vec256<int> vinsert(in Vec128<int> src, in Vec256<int> dst, byte index)
{
    IL_0000: ldarg.1
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::ymm
    IL_0006: ldarg.0
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::xmm
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::InsertVector128(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Byte)
    IL_0012: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0017: ret

}
Vec256<uint> insert(in Vec128<uint> src, in Vec256<uint> dst, byte index)
{
    IL_0000: ldarg.1
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::ymm
    IL_0006: ldarg.0
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::xmm
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::InsertVector128(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Byte)
    IL_0012: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0017: ret

}
Vec256<long> vinsert(in Vec128<long> src, in Vec256<long> dst, byte index)
{
    IL_0000: ldarg.1
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::ymm
    IL_0006: ldarg.0
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::xmm
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::InsertVector128(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Byte)
    IL_0012: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0017: ret

}
Vec256<ulong> vinsert(in Vec128<ulong> src, in Vec256<ulong> dst, byte index)
{
    IL_0000: ldarg.1
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::ymm
    IL_0006: ldarg.0
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::xmm
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::InsertVector128(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Byte)
    IL_0012: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0017: ret

}
ref Vec256<byte> insert(in Vec128<byte> lo, in Vec128<byte> hi, out Vec256<byte> dst)
{
    IL_0000: ldarg.2
    IL_0001: ldloca.s V_0
    IL_0003: initobj System.Runtime.Intrinsics.Vector256`1<System.Byte>
    IL_0009: ldloc.0
    IL_000A: ldarg.0
    IL_000B: ldfld System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::xmm
    IL_0010: ldc.i4.0
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::InsertVector128(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Byte)
    IL_0016: ldarg.1
    IL_0017: ldfld System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::xmm
    IL_001C: ldc.i4.1
    IL_001D: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::InsertVector128(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Byte)
    IL_0022: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0027: stobj Z0.Vec256`1<System.Byte>
    IL_002C: ldarg.2
    IL_002D: ret

}
Vector128<byte> vinsert(byte src, Vector128<byte> dst, byte index)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldarg.2
    IL_0003: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse41::Insert(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Byte,System.Byte)
    IL_0008: ret

}
Vector128<sbyte> vinsert(sbyte src, Vector128<sbyte> dst, byte index)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldarg.2
    IL_0003: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse41::Insert(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.SByte,System.Byte)
    IL_0008: ret

}
Vector128<short> vinsert(short src, Vector128<short> dst, byte index)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldarg.2
    IL_0003: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::Insert(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Int16,System.Byte)
    IL_0008: ret

}
Vector128<ushort> vinsert(ushort src, Vector128<ushort> dst, byte index)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldarg.2
    IL_0003: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::Insert(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.UInt16,System.Byte)
    IL_0008: ret

}
Vector128<int> vinsert(int src, Vector128<int> dst, byte index)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldarg.2
    IL_0003: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse41::Insert(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Int32,System.Byte)
    IL_0008: ret

}
Vector128<uint> vinsert(uint src, Vector128<uint> dst, byte index)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldarg.2
    IL_0003: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse41::Insert(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.UInt32,System.Byte)
    IL_0008: ret

}
Vector128<long> vinsert(long src, Vector128<long> dst, byte index)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldarg.2
    IL_0003: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse41/X64::Insert(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Int64,System.Byte)
    IL_0008: ret

}
Vector128<ulong> vinsert(ulong src, Vector128<ulong> dst, byte index)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldarg.2
    IL_0003: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse41/X64::Insert(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.UInt64,System.Byte)
    IL_0008: ret

}
Vector256<sbyte> vinsert(Vector128<sbyte> src, Vector256<sbyte> dst, byte index)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldarg.2
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::InsertVector128(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Byte)
    IL_0008: ret

}
Vector256<byte> vinsert(Vector128<byte> src, Vector256<byte> dst, byte index)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldarg.2
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::InsertVector128(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Byte)
    IL_0008: ret

}
Vector256<short> vinsert(Vector128<short> src, Vector256<short> dst, byte index)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldarg.2
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::InsertVector128(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Byte)
    IL_0008: ret

}
Vector256<ushort> vinsert(Vector128<ushort> src, Vector256<ushort> dst, byte index)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldarg.2
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::InsertVector128(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Byte)
    IL_0008: ret

}
Vector256<int> vinsert(Vector128<int> src, Vector256<int> dst, byte index)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldarg.2
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::InsertVector128(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Byte)
    IL_0008: ret

}
Vector256<uint> insert(Vector128<uint> src, Vector256<uint> dst, byte index)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldarg.2
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::InsertVector128(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Byte)
    IL_0008: ret

}
Vector256<long> vinsert(Vector128<long> src, Vector256<long> dst, byte index)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldarg.2
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::InsertVector128(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Byte)
    IL_0008: ret

}
Vector256<ulong> vinsert(Vector128<ulong> src, Vector256<ulong> dst, byte index)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldarg.2
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::InsertVector128(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Byte)
    IL_0008: ret

}
Vector256<byte> insert(Vector128<byte> lo, Vector128<byte> hi, out Vector256<byte> dst)
{
    IL_0000: ldarg.2
    IL_0001: ldloca.s V_0
    IL_0003: initobj System.Runtime.Intrinsics.Vector256`1<System.Byte>
    IL_0009: ldloc.0
    IL_000A: ldarg.0
    IL_000B: ldc.i4.0
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::InsertVector128(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Byte)
    IL_0011: ldarg.1
    IL_0012: ldc.i4.1
    IL_0013: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::InsertVector128(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Byte)
    IL_0018: dup
    IL_0019: stloc.0
    IL_001A: stobj System.Runtime.Intrinsics.Vector256`1<System.Byte>
    IL_001F: ldloc.0
    IL_0020: ret

}
Vec128<sbyte> vlo(in Vec256<sbyte> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.SByte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>)
    IL_000B: ldc.i4.0
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Avx::ExtractVector128(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0016: ret

}
Vec128<byte> vlo(in Vec256<byte> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_000B: ldc.i4.0
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Avx::ExtractVector128(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0016: ret

}
Vec128<short> vlo(in Vec256<short> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>)
    IL_000B: ldc.i4.0
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Avx::ExtractVector128(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0016: ret

}
Vec128<ushort> vlo(in Vec256<ushort> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt16>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>)
    IL_000B: ldc.i4.0
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx::ExtractVector128(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0016: ret

}
Vec128<int> vlo(in Vec256<int> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_000B: ldc.i4.0
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Avx::ExtractVector128(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0016: ret

}
Vec128<uint> vlo(in Vec256<uint> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt32>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>)
    IL_000B: ldc.i4.0
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx::ExtractVector128(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0016: ret

}
Vec128<long> vlo(in Vec256<long> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int64>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>)
    IL_000B: ldc.i4.0
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Avx::ExtractVector128(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0016: ret

}
Vec128<ulong> vlo(in Vec256<ulong> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt64>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>)
    IL_000B: ldc.i4.0
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx::ExtractVector128(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0016: ret

}
Vector128<sbyte> vlo(Vector256<sbyte> src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Avx::ExtractVector128(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Byte)
    IL_0007: ret

}
Vector128<byte> vlo(Vector256<byte> src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Avx::ExtractVector128(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Byte)
    IL_0007: ret

}
Vector128<short> vlo(Vector256<short> src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Avx::ExtractVector128(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Byte)
    IL_0007: ret

}
Vector128<ushort> vlo(Vector256<ushort> src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx::ExtractVector128(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Byte)
    IL_0007: ret

}
Vector128<int> vlo(Vector256<int> src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Avx::ExtractVector128(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Byte)
    IL_0007: ret

}
Vector128<uint> vlo(Vector256<uint> src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx::ExtractVector128(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Byte)
    IL_0007: ret

}
Vector128<long> vmul(Vector128<int> x, Vector128<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse41::Multiply(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0007: ret

}
Vector128<ulong> vmul(Vector128<uint> x, Vector128<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::Multiply(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0007: ret

}
Vector256<long> vmul(Vector256<int> x, Vector256<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::Multiply(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0007: ret

}
Vector256<ulong> vmul(Vector256<uint> x, Vector256<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::Multiply(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0007: ret

}
Vector256<ulong> vmul(Vector256<ulong> x, Vector256<ulong> y)
{
    IL_0000: call Z0.N256 zfunc::get_n256()
    IL_0005: ldc.i4.m1
    IL_0006: conv.u8
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.ginx::vbroadcast<System.UInt64>(Z0.N256,System.UInt64)
    IL_000C: stloc.0
    IL_000D: ldarg.0
    IL_000E: ldloc.0
    IL_000F: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::vand(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0014: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.Vector256::AsUInt32<System.UInt64>(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0019: stloc.1
    IL_001A: ldarg.0
    IL_001B: ldc.i4.s 32
    IL_001D: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::vsrl(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Byte)
    IL_0022: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.Vector256::AsUInt32<System.UInt64>(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0027: stloc.2
    IL_0028: ldarg.1
    IL_0029: ldloc.0
    IL_002A: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::vand(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_002F: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.Vector256::AsUInt32<System.UInt64>(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0034: stloc.3
    IL_0035: ldarg.1
    IL_0036: ldc.i4.s 32
    IL_0038: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::vsrl(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Byte)
    IL_003D: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.Vector256::AsUInt32<System.UInt64>(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0042: stloc.s V_4
    IL_0044: ldloc.2
    IL_0045: ldloc.3
    IL_0046: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::vmul(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_004B: stloc.s V_5
    IL_004D: ldloc.s V_5
    IL_004F: ldc.i4.s 32
    IL_0051: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::vsll(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Byte)
    IL_0056: stloc.s V_6
    IL_0058: ldloc.2
    IL_0059: ldloc.s V_4
    IL_005B: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::vmul(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0060: stloc.s V_7
    IL_0062: ldloc.s V_7
    IL_0064: ldc.i4.s 32
    IL_0066: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::vsll(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Byte)
    IL_006B: stloc.s V_8
    IL_006D: ldloc.1
    IL_006E: ldloc.3
    IL_006F: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::vmul(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0074: stloc.s V_9
    IL_0076: ldloc.s V_6
    IL_0078: ldloc.s V_8
    IL_007A: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::vadd(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_007F: stloc.s V_10
    IL_0081: ldloc.s V_9
    IL_0083: ldloc.s V_10
    IL_0085: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::vadd(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_008A: stloc.s V_11
    IL_008C: ldloc.s V_11
    IL_008E: ret

}
Vector128<sbyte> vnegate(Vector128<sbyte> src)
{
    IL_0000: ldloca.s V_0
    IL_0002: initobj System.Runtime.Intrinsics.Vector128`1<System.SByte>
    IL_0008: ldloc.0
    IL_0009: ldarg.0
    IL_000A: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.dinx::vsub(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_000F: ret

}
Vector128<byte> vnegate(Vector128<byte> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0006: call Z0.N128 zfunc::get_n128()
    IL_000B: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.ginx::vones<System.Byte>(Z0.N128)
    IL_0010: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.dinx::vsub(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0015: ret

}
Vector128<short> vnegate(Vector128<short> src)
{
    IL_0000: ldloca.s V_0
    IL_0002: initobj System.Runtime.Intrinsics.Vector128`1<System.Int16>
    IL_0008: ldloc.0
    IL_0009: ldarg.0
    IL_000A: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.dinx::vsub(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_000F: ret

}
Vector128<ushort> vnegate(Vector128<ushort> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0006: call Z0.N128 zfunc::get_n128()
    IL_000B: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.ginx::vones<System.UInt16>(Z0.N128)
    IL_0010: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.dinx::vsub(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0015: ret

}
Vector128<int> vnegate(Vector128<int> src)
{
    IL_0000: ldloca.s V_0
    IL_0002: initobj System.Runtime.Intrinsics.Vector128`1<System.Int32>
    IL_0008: ldloc.0
    IL_0009: ldarg.0
    IL_000A: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.dinx::vsub(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_000F: ret

}
Vector128<uint> vnegate(Vector128<uint> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0006: call Z0.N128 zfunc::get_n128()
    IL_000B: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.ginx::vones<System.UInt32>(Z0.N128)
    IL_0010: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.dinx::vsub(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0015: ret

}
Vector128<long> vnegate(Vector128<long> src)
{
    IL_0000: ldloca.s V_0
    IL_0002: initobj System.Runtime.Intrinsics.Vector128`1<System.Int64>
    IL_0008: ldloc.0
    IL_0009: ldarg.0
    IL_000A: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.dinx::vsub(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_000F: ret

}
Vector128<ulong> vnegate(Vector128<ulong> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0006: call Z0.N128 zfunc::get_n128()
    IL_000B: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.ginx::vones<System.UInt64>(Z0.N128)
    IL_0010: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.dinx::vsub(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0015: ret

}
Vector256<sbyte> vnegate(Vector256<sbyte> src)
{
    IL_0000: ldloca.s V_0
    IL_0002: initobj System.Runtime.Intrinsics.Vector256`1<System.SByte>
    IL_0008: ldloc.0
    IL_0009: ldarg.0
    IL_000A: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.dinx::vsub(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_000F: ret

}
Vector256<byte> vnegate(Vector256<byte> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0006: call Z0.N256 zfunc::get_n256()
    IL_000B: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.ginx::vones<System.Byte>(Z0.N256)
    IL_0010: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.dinx::vsub(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0015: ret

}
Vector256<short> vnegate(Vector256<short> src)
{
    IL_0000: ldloca.s V_0
    IL_0002: initobj System.Runtime.Intrinsics.Vector256`1<System.Int16>
    IL_0008: ldloc.0
    IL_0009: ldarg.0
    IL_000A: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.dinx::vsub(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_000F: ret

}
Vector256<ushort> vnegate(Vector256<ushort> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0006: call Z0.N256 zfunc::get_n256()
    IL_000B: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.ginx::vones<System.UInt16>(Z0.N256)
    IL_0010: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.dinx::vsub(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0015: ret

}
Vector256<int> vnegate(Vector256<int> src)
{
    IL_0000: ldloca.s V_0
    IL_0002: initobj System.Runtime.Intrinsics.Vector256`1<System.Int32>
    IL_0008: ldloc.0
    IL_0009: ldarg.0
    IL_000A: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.dinx::vsub(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_000F: ret

}
Vector256<uint> vnegate(Vector256<uint> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0006: call Z0.N256 zfunc::get_n256()
    IL_000B: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.ginx::vones<System.UInt32>(Z0.N256)
    IL_0010: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.dinx::vsub(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0015: ret

}
Vector256<long> vnegate(Vector256<long> src)
{
    IL_0000: ldloca.s V_0
    IL_0002: initobj System.Runtime.Intrinsics.Vector256`1<System.Int64>
    IL_0008: ldloc.0
    IL_0009: ldarg.0
    IL_000A: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.dinx::vsub(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_000F: ret

}
Vector256<ulong> vnegate(Vector256<ulong> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0006: call Z0.N256 zfunc::get_n256()
    IL_000B: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.ginx::vones<System.UInt64>(Z0.N256)
    IL_0010: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::vsub(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0015: ret

}
bool vnonz(in Vec128<byte> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000B: ldarg.0
    IL_000C: ldobj Z0.Vec128`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_0016: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestZ(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_001B: ldc.i4.0
    IL_001C: ceq
    IL_001E: ret

}
bool vnonz(in Vec128<sbyte> src)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::xmm
    IL_0006: ldarg.0
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::xmm
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestZ(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0011: ldc.i4.0
    IL_0012: ceq
    IL_0014: ret

}
bool vnonz(in Vec128<short> src)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::xmm
    IL_0006: ldarg.0
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::xmm
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestZ(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0011: ldc.i4.0
    IL_0012: ceq
    IL_0014: ret

}
bool vnonz(in Vec128<ushort> src)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::xmm
    IL_0006: ldarg.0
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::xmm
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestZ(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0011: ldc.i4.0
    IL_0012: ceq
    IL_0014: ret

}
bool vnonz(in Vec128<int> src)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::xmm
    IL_0006: ldarg.0
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::xmm
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestZ(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0011: ldc.i4.0
    IL_0012: ceq
    IL_0014: ret

}
bool vnonz(in Vec128<uint> src)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::xmm
    IL_0006: ldarg.0
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::xmm
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestZ(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0011: ldc.i4.0
    IL_0012: ceq
    IL_0014: ret

}
bool vnonz(in Vec128<long> src)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::xmm
    IL_0006: ldarg.0
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::xmm
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestZ(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0011: ldc.i4.0
    IL_0012: ceq
    IL_0014: ret

}
bool vnonz(in Vec128<ulong> src)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::xmm
    IL_0006: ldarg.0
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::xmm
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestZ(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0011: ldc.i4.0
    IL_0012: ceq
    IL_0014: ret

}
bool vnonz(in Vec128<float> src)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::xmm
    IL_0006: ldarg.0
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::xmm
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestZ(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0011: ldc.i4.0
    IL_0012: ceq
    IL_0014: ret

}
bool vnonz(in Vec128<double> src)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::xmm
    IL_0006: ldarg.0
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::xmm
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestZ(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0011: ldc.i4.0
    IL_0012: ceq
    IL_0014: ret

}
bool vnonz(in Vec256<byte> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_000B: ldarg.0
    IL_000C: ldobj Z0.Vec256`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_0016: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestZ(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_001B: ldc.i4.0
    IL_001C: ceq
    IL_001E: ret

}
bool vnonz(in Vec256<sbyte> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.SByte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>)
    IL_000B: ldarg.0
    IL_000C: ldobj Z0.Vec256`1<System.SByte>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>)
    IL_0016: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestZ(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_001B: ldc.i4.0
    IL_001C: ceq
    IL_001E: ret

}
bool vnonz(in Vec256<short> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>)
    IL_000B: ldarg.0
    IL_000C: ldobj Z0.Vec256`1<System.Int16>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>)
    IL_0016: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestZ(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_001B: ldc.i4.0
    IL_001C: ceq
    IL_001E: ret

}
bool vnonz(in Vec256<ushort> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt16>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>)
    IL_000B: ldarg.0
    IL_000C: ldobj Z0.Vec256`1<System.UInt16>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>)
    IL_0016: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestZ(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_001B: ldc.i4.0
    IL_001C: ceq
    IL_001E: ret

}
bool vnonz(in Vec256<int> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_000B: ldarg.0
    IL_000C: ldobj Z0.Vec256`1<System.Int32>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_0016: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestZ(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_001B: ldc.i4.0
    IL_001C: ceq
    IL_001E: ret

}
bool vnonz(in Vec256<uint> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt32>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>)
    IL_000B: ldarg.0
    IL_000C: ldobj Z0.Vec256`1<System.UInt32>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>)
    IL_0016: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestZ(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_001B: ldc.i4.0
    IL_001C: ceq
    IL_001E: ret

}
bool vnonz(in Vec256<long> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int64>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>)
    IL_000B: ldarg.0
    IL_000C: ldobj Z0.Vec256`1<System.Int64>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>)
    IL_0016: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestZ(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_001B: ldc.i4.0
    IL_001C: ceq
    IL_001E: ret

}
bool vnonz(in Vec256<ulong> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt64>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>)
    IL_000B: ldarg.0
    IL_000C: ldobj Z0.Vec256`1<System.UInt64>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>)
    IL_0016: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestZ(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_001B: ldc.i4.0
    IL_001C: ceq
    IL_001E: ret

}
bool vnonz(in Vec256<float> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Single>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>)
    IL_000B: ldarg.0
    IL_000C: ldobj Z0.Vec256`1<System.Single>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>)
    IL_0016: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestZ(System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_001B: ldc.i4.0
    IL_001C: ceq
    IL_001E: ret

}
bool vnonz(in Vec256<double> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Double>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>)
    IL_000B: ldarg.0
    IL_000C: ldobj Z0.Vec256`1<System.Double>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>)
    IL_0016: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestZ(System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_001B: ldc.i4.0
    IL_001C: ceq
    IL_001E: ret

}
Vec128<ushort> vsad(in Vec128<byte> lhs, in Vec128<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::SumAbsoluteDifferences(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0011: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0016: ret

}
Vec256<ushort> vsad(in Vec256<byte> lhs, in Vec256<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::SumAbsoluteDifferences(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0011: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0016: ret

}
Vector128<sbyte> vsign(Vector128<sbyte> lhs, Vector128<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Ssse3::Sign(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0007: ret

}
Vector128<short> vsign(Vector128<short> lhs, Vector128<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Ssse3::Sign(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0007: ret

}
Vector128<int> vsign(Vector128<int> lhs, Vector128<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Ssse3::Sign(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0007: ret

}
Vector256<sbyte> vsign(Vector256<sbyte> lhs, Vector256<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::Sign(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0007: ret

}
Vector256<short> vsign(Vector256<short> lhs, Vector256<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::Sign(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0007: ret

}
Vector256<int> vsign(Vector256<int> lhs, Vector256<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::Sign(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0007: ret

}
Vec128<byte> vsub(in Vec128<byte> x, in Vec128<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::Subtract(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_001B: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0020: ret

}
Vec128<sbyte> vsub(in Vec128<sbyte> x, in Vec128<sbyte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.SByte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.SByte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::Subtract(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_001B: call Z0.Vec128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0020: ret

}
Vec128<short> vsub(in Vec128<short> x, in Vec128<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int16>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::Subtract(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_001B: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0020: ret

}
Vec128<ushort> vsub(in Vec128<ushort> x, in Vec128<ushort> y)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt16>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::Subtract(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_001B: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0020: ret

}
Vec128<int> vsub(in Vec128<int> x, in Vec128<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int32>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::Subtract(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_001B: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0020: ret

}
Vec128<uint> vsub(in Vec128<uint> x, in Vec128<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt32>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::Subtract(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_001B: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0020: ret

}
Vec128<long> vsub(in Vec128<long> x, in Vec128<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int64>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(Z0.Vec128`1<System.Int64>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int64>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(Z0.Vec128`1<System.Int64>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse2::Subtract(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_001B: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0020: ret

}
Vec128<ulong> vsub(in Vec128<ulong> x, in Vec128<ulong> y)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt64>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt64>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::Subtract(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_001B: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0020: ret

}
Vec256<byte> vsub(in Vec256<byte> x, in Vec256<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::Subtract(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_001B: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0020: ret

}
Vec256<sbyte> vsub(in Vec256<sbyte> x, in Vec256<sbyte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.SByte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.SByte>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::Subtract(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_001B: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0020: ret

}
Vec256<short> vsub(in Vec256<short> x, in Vec256<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Int16>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::Subtract(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_001B: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0020: ret

}
Vec256<ushort> vsub(in Vec256<ushort> x, in Vec256<ushort> y)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt16>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.UInt16>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::Subtract(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_001B: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0020: ret

}
Vec256<int> vsub(in Vec256<int> x, in Vec256<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Int32>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::Subtract(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_001B: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0020: ret

}
Vec256<uint> vsub(in Vec256<uint> x, in Vec256<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt32>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.UInt32>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::Subtract(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_001B: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0020: ret

}
Vec256<long> vsub(in Vec256<long> x, in Vec256<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int64>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Int64>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::Subtract(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_001B: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0020: ret

}
Vec256<ulong> vsub(in Vec256<ulong> x, in Vec256<ulong> y)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt64>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.UInt64>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::Subtract(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_001B: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0020: ret

}
Vector128<byte> vsub(Vector128<byte> x, Vector128<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::Subtract(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0007: ret

}
Vector128<sbyte> vsub(Vector128<sbyte> x, Vector128<sbyte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::Subtract(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0007: ret

}
Vector128<short> vsub(Vector128<short> x, Vector128<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::Subtract(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0007: ret

}
Vector128<ushort> vsub(Vector128<ushort> x, Vector128<ushort> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::Subtract(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0007: ret

}
Vector128<int> vsub(Vector128<int> x, Vector128<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::Subtract(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0007: ret

}
Vector128<uint> vsub(Vector128<uint> x, Vector128<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::Subtract(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0007: ret

}
Vector128<long> vsub(Vector128<long> x, Vector128<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse2::Subtract(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0007: ret

}
Vector128<ulong> vsub(Vector128<ulong> x, Vector128<ulong> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::Subtract(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0007: ret

}
Vector256<byte> vsub(Vector256<byte> x, Vector256<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::Subtract(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0007: ret

}
Vector256<sbyte> vsub(Vector256<sbyte> x, Vector256<sbyte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::Subtract(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0007: ret

}
Vector256<short> vsub(Vector256<short> x, Vector256<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::Subtract(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0007: ret

}
Vector256<ushort> vsub(Vector256<ushort> x, Vector256<ushort> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::Subtract(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0007: ret

}
Vector256<int> vsub(Vector256<int> x, Vector256<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::Subtract(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0007: ret

}
Vector256<uint> vsub(Vector256<uint> x, Vector256<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::Subtract(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0007: ret

}
Vector256<long> vsub(Vector256<long> x, Vector256<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::Subtract(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0007: ret

}
Vector256<ulong> vsub(Vector256<ulong> x, Vector256<ulong> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::Subtract(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0007: ret

}
Vec128<short> vhsub(in Vec128<short> lhs, in Vec128<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Ssse3::HorizontalSubtract(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0011: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0016: ret

}
Vec128<int> vhsub(in Vec128<int> lhs, in Vec128<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Ssse3::HorizontalSubtract(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0011: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0016: ret

}
Vec256<short> vhsub(in Vec256<short> lhs, in Vec256<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::HorizontalSubtract(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0011: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0016: ret

}
Vec256<int> vhsub(in Vec256<int> lhs, in Vec256<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::HorizontalSubtract(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0016: ret

}
Vec128<byte> subs(in Vec128<byte> x, in Vec128<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::SubtractSaturate(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0011: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0016: ret

}
Vec128<sbyte> subs(in Vec128<sbyte> x, in Vec128<sbyte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::SubtractSaturate(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0011: call Z0.Vec128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0016: ret

}
Vec128<short> subs(in Vec128<short> x, in Vec128<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::SubtractSaturate(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0011: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0016: ret

}
Vec128<ushort> subs(in Vec128<ushort> x, in Vec128<ushort> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::SubtractSaturate(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0011: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0016: ret

}
Vec256<byte> subs(in Vec256<byte> x, in Vec256<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::SubtractSaturate(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0011: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0016: ret

}
Vec256<sbyte> subs(in Vec256<sbyte> x, in Vec256<sbyte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::SubtractSaturate(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0011: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0016: ret

}
Vec256<short> subs(in Vec256<short> x, in Vec256<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::SubtractSaturate(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0011: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0016: ret

}
Vec256<ushort> subs(in Vec256<ushort> x, in Vec256<ushort> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::SubtractSaturate(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0011: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0016: ret

}
Vec128<byte> valignr(in Vec128<byte> x, in Vec128<byte> y, N1 n)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_0016: ldc.i4.1
    IL_0017: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Ssse3::AlignRight(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Byte)
    IL_001C: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0021: ret

}
Vec128<byte> valignr(in Vec128<byte> x, in Vec128<byte> y, N2 n)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_0016: ldc.i4.2
    IL_0017: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Ssse3::AlignRight(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Byte)
    IL_001C: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0021: ret

}
Vec128<byte> valignr(in Vec128<byte> x, in Vec128<byte> y, N3 n)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_0016: ldc.i4.3
    IL_0017: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Ssse3::AlignRight(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Byte)
    IL_001C: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0021: ret

}
Vec128<byte> valignr(in Vec128<byte> x, in Vec128<byte> y, N4 n)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_0016: ldc.i4.4
    IL_0017: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Ssse3::AlignRight(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Byte)
    IL_001C: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0021: ret

}
Vec128<byte> valignr(in Vec128<byte> x, in Vec128<byte> y, N5 n)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_0016: ldc.i4.5
    IL_0017: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Ssse3::AlignRight(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Byte)
    IL_001C: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0021: ret

}
Vec128<byte> valignr(in Vec128<byte> x, in Vec128<byte> y, N6 n)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_0016: ldc.i4.6
    IL_0017: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Ssse3::AlignRight(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Byte)
    IL_001C: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0021: ret

}
Vec128<byte> valignr(in Vec128<byte> x, in Vec128<byte> y, N7 n)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_0016: ldc.i4.7
    IL_0017: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Ssse3::AlignRight(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Byte)
    IL_001C: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0021: ret

}
Vec128<byte> valignr(in Vec128<byte> x, in Vec128<byte> y, N8 n)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_0016: ldc.i4.8
    IL_0017: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Ssse3::AlignRight(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Byte)
    IL_001C: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0021: ret

}
Vec128<byte> valignr(in Vec128<byte> x, in Vec128<byte> y, N9 n)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_0016: ldc.i4.s 9
    IL_0018: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Ssse3::AlignRight(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Byte)
    IL_001D: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0022: ret

}
Vec128<byte> valignr(in Vec128<byte> x, in Vec128<byte> y, N10 n)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_0016: ldc.i4.s 10
    IL_0018: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Ssse3::AlignRight(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Byte)
    IL_001D: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0022: ret

}
Vec256<byte> valignr(in Vec256<byte> x, in Vec256<byte> y, N0 n)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_0016: ldc.i4.0
    IL_0017: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::AlignRight(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Byte)
    IL_001C: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0021: ret

}
Vec256<byte> valignr(in Vec256<byte> x, in Vec256<byte> y, N1 n)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_0016: ldc.i4.1
    IL_0017: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::AlignRight(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Byte)
    IL_001C: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0021: ret

}
Vec256<byte> valignr(in Vec256<byte> x, in Vec256<byte> y, N2 n)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_0016: ldc.i4.2
    IL_0017: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::AlignRight(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Byte)
    IL_001C: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0021: ret

}
Vec256<byte> valignr(in Vec256<byte> x, in Vec256<byte> y, N3 n)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_0016: ldc.i4.3
    IL_0017: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::AlignRight(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Byte)
    IL_001C: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0021: ret

}
Vec256<byte> valignr(in Vec256<byte> x, in Vec256<byte> y, N4 n)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_0016: ldc.i4.4
    IL_0017: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::AlignRight(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Byte)
    IL_001C: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0021: ret

}
Vec256<byte> valignr(in Vec256<byte> x, in Vec256<byte> y, N5 n)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_0016: ldc.i4.5
    IL_0017: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::AlignRight(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Byte)
    IL_001C: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0021: ret

}
Vec256<byte> valignr(in Vec256<byte> x, in Vec256<byte> y, N6 n)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_0016: ldc.i4.6
    IL_0017: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::AlignRight(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Byte)
    IL_001C: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0021: ret

}
Vec256<byte> valignr(in Vec256<byte> x, in Vec256<byte> y, N7 n)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_0016: ldc.i4.7
    IL_0017: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::AlignRight(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Byte)
    IL_001C: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0021: ret

}
Vec256<byte> valignr(in Vec256<byte> x, in Vec256<byte> y, N8 n)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_0016: ldc.i4.8
    IL_0017: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::AlignRight(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Byte)
    IL_001C: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0021: ret

}
Vec256<byte> valignr(in Vec256<byte> x, in Vec256<byte> y, N9 n)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_0016: ldc.i4.s 9
    IL_0018: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::AlignRight(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Byte)
    IL_001D: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0022: ret

}
Vec256<byte> valignr(in Vec256<byte> x, in Vec256<byte> y, N10 n)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_0016: ldc.i4.s 10
    IL_0018: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::AlignRight(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Byte)
    IL_001D: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0022: ret

}
Vec256<byte> valignr(in Vec256<byte> x, in Vec256<byte> y, N11 n)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_0016: ldc.i4.s 11
    IL_0018: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::AlignRight(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Byte)
    IL_001D: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0022: ret

}
Vec128<short> vblend(in Vec128<short> x, in Vec128<short> y, Blend16x8:byte spec)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::xmm
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse41::Blend(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Byte)
    IL_0012: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0017: ret

}
Vec128<ushort> vblend(in Vec128<ushort> x, in Vec128<ushort> y, Blend16x8:byte spec)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::xmm
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse41::Blend(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Byte)
    IL_0012: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0017: ret

}
Vec128<int> vblend(in Vec128<int> x, in Vec128<int> y, Blend32x4:byte spec)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::xmm
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::Blend(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Byte)
    IL_0012: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0017: ret

}
Vec128<uint> vblend(in Vec128<uint> x, in Vec128<uint> y, Blend32x4:byte spec)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::xmm
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::Blend(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Byte)
    IL_0012: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0017: ret

}
Vec256<short> vblend(in Vec256<short> x, in Vec256<short> y, Blend16x8:byte spec)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::ymm
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::Blend(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Byte)
    IL_0012: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0017: ret

}
Vec256<ushort> vblend(in Vec256<ushort> x, in Vec256<ushort> y, Blend16x8:byte spec)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::ymm
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::Blend(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Byte)
    IL_0012: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0017: ret

}
Vec256<int> vblend(in Vec256<int> x, in Vec256<int> y, Blend32x8:byte spec)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::ymm
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::Blend(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Byte)
    IL_0012: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0017: ret

}
Vec256<uint> vblend(in Vec256<uint> x, in Vec256<uint> y, Blend32x8:byte spec)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::ymm
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::Blend(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Byte)
    IL_0012: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0017: ret

}
Vec128<byte> vblendvar(in Vec128<byte> x, in Vec128<byte> y, in Vec128<byte> spec)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::xmm
    IL_000C: ldarg.2
    IL_000D: ldobj Z0.Vec128`1<System.Byte>
    IL_0012: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_0017: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse41::BlendVariable(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_001C: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0021: ret

}
Vec256<sbyte> vblendvar(in Vec256<sbyte> x, in Vec256<sbyte> y, in Vec256<sbyte> spec)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::ymm
    IL_000C: ldarg.2
    IL_000D: ldobj Z0.Vec256`1<System.SByte>
    IL_0012: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>)
    IL_0017: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::BlendVariable(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_001C: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0021: ret

}
Vec256<byte> vblendvar(in Vec256<byte> x, in Vec256<byte> y, in Vec256<byte> spec)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::ymm
    IL_000C: ldarg.2
    IL_000D: ldobj Z0.Vec256`1<System.Byte>
    IL_0012: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_0017: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::BlendVariable(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_001C: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0021: ret

}
Vec256<short> vblendvar(in Vec256<short> x, in Vec256<short> y, in Vec256<short> spec)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::ymm
    IL_000C: ldarg.2
    IL_000D: ldobj Z0.Vec256`1<System.Int16>
    IL_0012: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>)
    IL_0017: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::BlendVariable(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_001C: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0021: ret

}
Vec256<ushort> vblendvar(in Vec256<ushort> x, in Vec256<ushort> y, in Vec256<ushort> spec)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::ymm
    IL_000C: ldarg.2
    IL_000D: ldobj Z0.Vec256`1<System.UInt16>
    IL_0012: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>)
    IL_0017: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::BlendVariable(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_001C: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0021: ret

}
Vector128<byte> abs(Vector128<sbyte> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Ssse3::Abs(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0006: ret

}
Vector128<ushort> abs(Vector128<short> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Ssse3::Abs(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0006: ret

}
Vector128<uint> abs(Vector128<int> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Ssse3::Abs(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0006: ret

}
Vector128<long> abs(Vector128<long> src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.s 63
    IL_0003: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.dinx::vsrl(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Byte)
    IL_0008: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.dinx::vnegate(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_000D: stloc.0
    IL_000E: ldloc.0
    IL_000F: ldarg.0
    IL_0010: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.dinx::vxor(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0015: ldloc.0
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.dinx::vsub(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_001B: ret

}
Vector256<byte> abs(Vector256<sbyte> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::Abs(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0006: ret

}
Vector256<ushort> abs(Vector256<short> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::Abs(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0006: ret

}
Vector256<uint> abs(Vector256<int> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::Abs(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0006: ret

}
Vector256<long> abs(Vector256<long> src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.s 63
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.dinx::vsrl(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Byte)
    IL_0008: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.dinx::vnegate(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_000D: stloc.0
    IL_000E: ldloc.0
    IL_000F: ldarg.0
    IL_0010: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.dinx::vxor(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0015: ldloc.0
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.dinx::vsub(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_001B: ret

}
Vec128<byte> vadd(in Vec128<byte> lhs, in Vec128<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::Add(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0011: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0016: ret

}
Vec128<sbyte> vadd(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::Add(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0011: call Z0.Vec128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0016: ret

}
Vec128<short> vadd(in Vec128<short> lhs, in Vec128<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::Add(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0011: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0016: ret

}
Vec128<ushort> vadd(in Vec128<ushort> lhs, in Vec128<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::Add(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0011: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0016: ret

}
Vec128<int> vadd(in Vec128<int> lhs, in Vec128<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::Add(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0011: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0016: ret

}
Vec128<uint> vadd(in Vec128<uint> lhs, in Vec128<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::Add(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0011: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0016: ret

}
Vec128<long> vadd(in Vec128<long> lhs, in Vec128<long> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse2::Add(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0011: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0016: ret

}
Vec128<ulong> vadd(in Vec128<ulong> lhs, in Vec128<ulong> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::Add(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0011: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0016: ret

}
Vec256<byte> vadd(in Vec256<byte> lhs, in Vec256<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::Add(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0011: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0016: ret

}
Vec256<sbyte> vadd(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::Add(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0011: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0016: ret

}
Vec256<short> vadd(in Vec256<short> lhs, in Vec256<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::Add(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0011: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0016: ret

}
Vec256<ushort> vadd(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::Add(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0011: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0016: ret

}
Vec256<int> vadd(in Vec256<int> lhs, in Vec256<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::Add(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0016: ret

}
Vec256<uint> vadd(in Vec256<uint> lhs, in Vec256<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::Add(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0011: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0016: ret

}
Vec256<long> vadd(in Vec256<long> lhs, in Vec256<long> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::Add(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0011: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0016: ret

}
Vec256<ulong> vadd(in Vec256<ulong> lhs, in Vec256<ulong> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::Add(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0011: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0016: ret

}
Vector128<byte> vadd(Vector128<byte> x, Vector128<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::Add(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0007: ret

}
Vector128<sbyte> vadd(Vector128<sbyte> x, Vector128<sbyte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::Add(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0007: ret

}
Vector128<short> vadd(Vector128<short> x, Vector128<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::Add(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0007: ret

}
Vector128<ushort> vadd(Vector128<ushort> x, Vector128<ushort> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::Add(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0007: ret

}
Vector128<int> vadd(Vector128<int> x, Vector128<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::Add(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0007: ret

}
Vector128<uint> vadd(Vector128<uint> x, Vector128<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::Add(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0007: ret

}
Vector128<long> vadd(Vector128<long> x, Vector128<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse2::Add(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0007: ret

}
Vector128<ulong> vadd(Vector128<ulong> x, Vector128<ulong> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::Add(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0007: ret

}
Vector256<byte> vadd(Vector256<byte> x, Vector256<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::Add(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0007: ret

}
Vector256<sbyte> vadd(Vector256<sbyte> x, Vector256<sbyte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::Add(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0007: ret

}
Vector256<short> vadd(Vector256<short> x, Vector256<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::Add(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0007: ret

}
Vector256<ushort> vadd(Vector256<ushort> x, Vector256<ushort> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::Add(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0007: ret

}
Vector256<int> vadd(Vector256<int> x, Vector256<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::Add(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0007: ret

}
Vector256<uint> vadd(Vector256<uint> x, Vector256<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::Add(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0007: ret

}
Vector256<long> vadd(Vector256<long> x, Vector256<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::Add(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0007: ret

}
Vector256<ulong> vadd(Vector256<ulong> x, Vector256<ulong> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::Add(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0007: ret

}
Vector128<byte> vadds(Vector128<byte> x, Vector128<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::AddSaturate(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0007: ret

}
Vector128<sbyte> vadds(Vector128<sbyte> x, Vector128<sbyte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::AddSaturate(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0007: ret

}
Vector128<short> vadds(Vector128<short> x, Vector128<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::AddSaturate(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0007: ret

}
Vector128<ushort> vadds(Vector128<ushort> x, Vector128<ushort> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::AddSaturate(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0007: ret

}
Vector256<byte> vadds(Vector256<byte> x, Vector256<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::AddSaturate(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0007: ret

}
Vector256<sbyte> vadds(Vector256<sbyte> x, Vector256<sbyte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::AddSaturate(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0007: ret

}
Vector256<short> vadds(Vector256<short> x, Vector256<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::AddSaturate(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0007: ret

}
Vector256<ushort> vadds(Vector256<ushort> x, Vector256<ushort> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::AddSaturate(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0007: ret

}
Vec128<byte> vavg(in Vec128<byte> lhs, in Vec128<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::Average(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_001B: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0020: ret

}
Vec128<ushort> vavg(in Vec128<ushort> lhs, in Vec128<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt16>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::Average(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_001B: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0020: ret

}
Vec256<byte> vavg(in Vec256<byte> lhs, in Vec256<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::Average(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_001B: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0020: ret

}
Vec256<ushort> vavg(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt16>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.UInt16>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::Average(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_001B: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0020: ret

}
byte clmulr(byte a, byte b, ushort poly)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt16 Z0.dinx::clmul(System.Byte,System.Byte)
    IL_0007: stloc.0
    IL_0008: ldloc.0
    IL_0009: ldloc.0
    IL_000A: ldc.i4.8
    IL_000B: shr
    IL_000C: conv.u2
    IL_000D: ldarg.2
    IL_000E: call System.UInt32 Z0.dinx::clmul(System.UInt16,System.UInt16)
    IL_0013: conv.u2
    IL_0014: xor
    IL_0015: conv.u2
    IL_0016: stloc.0
    IL_0017: ldloc.0
    IL_0018: ldloc.0
    IL_0019: ldc.i4.8
    IL_001A: shr
    IL_001B: conv.u2
    IL_001C: ldarg.2
    IL_001D: call System.UInt32 Z0.dinx::clmul(System.UInt16,System.UInt16)
    IL_0022: conv.u2
    IL_0023: xor
    IL_0024: conv.u2
    IL_0025: stloc.0
    IL_0026: ldloc.0
    IL_0027: conv.u1
    IL_0028: ret

}
ushort clmulr(ushort a, ushort b, uint poly)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.dinx::clmul(System.UInt16,System.UInt16)
    IL_0007: stloc.0
    IL_0008: ldloc.0
    IL_0009: ldloc.0
    IL_000A: ldc.i4.s 16
    IL_000C: shr.un
    IL_000D: ldarg.2
    IL_000E: call System.UInt64 Z0.dinx::clmul(System.UInt32,System.UInt32)
    IL_0013: conv.u4
    IL_0014: xor
    IL_0015: stloc.0
    IL_0016: ldloc.0
    IL_0017: ldloc.0
    IL_0018: ldc.i4.s 16
    IL_001A: shr.un
    IL_001B: ldarg.2
    IL_001C: call System.UInt64 Z0.dinx::clmul(System.UInt32,System.UInt32)
    IL_0021: conv.u4
    IL_0022: xor
    IL_0023: stloc.0
    IL_0024: ldloc.0
    IL_0025: conv.u2
    IL_0026: ret

}
uint clmulr(uint a, uint b, ulong poly)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.dinx::clmul(System.UInt32,System.UInt32)
    IL_0007: stloc.0
    IL_0008: ldloc.0
    IL_0009: ldloc.0
    IL_000A: ldc.i4.s 32
    IL_000C: shr.un
    IL_000D: ldarg.2
    IL_000E: call Z0.UInt128 Z0.dinx::clmul(System.UInt64,System.UInt64)
    IL_0013: ldfld System.UInt64 Z0.UInt128::lo
    IL_0018: xor
    IL_0019: stloc.0
    IL_001A: ldloc.0
    IL_001B: ldloc.0
    IL_001C: ldc.i4.s 32
    IL_001E: shr.un
    IL_001F: ldarg.2
    IL_0020: call Z0.UInt128 Z0.dinx::clmul(System.UInt64,System.UInt64)
    IL_0025: ldfld System.UInt64 Z0.UInt128::lo
    IL_002A: xor
    IL_002B: stloc.0
    IL_002C: ldloc.0
    IL_002D: conv.u4
    IL_002E: ret

}
UInt128 clmul(ulong lhs, ulong rhs)
{
    IL_0000: ldarga.s lhs
    IL_0002: call Z0.Vec128`1<System.UInt64> Z0.Vec128::LoadScalar<System.UInt64>(System.UInt64&)
    IL_0007: stloc.0
    IL_0008: ldarga.s rhs
    IL_000A: call Z0.Vec128`1<System.UInt64> Z0.Vec128::LoadScalar<System.UInt64>(System.UInt64&)
    IL_000F: stloc.1
    IL_0010: ldloc.0
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_0016: ldloc.1
    IL_0017: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_001C: ldc.i4.0
    IL_001D: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Pclmulqdq::CarrylessMultiply(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Byte)
    IL_0022: stloc.2
    IL_0023: ldloca.s V_2
    IL_0025: call Z0.UInt128 Z0.UInt128::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>&)
    IL_002A: ret

}
Vec128<ulong> clmul(Scalar128<ulong> a, Scalar128<ulong> b)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Scalar128`1<System.UInt64>::op_Implicit(Z0.Scalar128`1<System.UInt64>)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Scalar128`1<System.UInt64>::op_Implicit(Z0.Scalar128`1<System.UInt64>)
    IL_000C: ldc.i4.0
    IL_000D: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Pclmulqdq::CarrylessMultiply(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Byte)
    IL_0012: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0017: ret

}
Vec128<ulong> clmul(in Vec128<ulong> lhs, in Vec128<ulong> rhs, ClMulMask:byte mask)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt64>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt64>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_0016: ldarg.2
    IL_0017: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Pclmulqdq::CarrylessMultiply(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Byte)
    IL_001C: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0021: ret

}
Vector128<ulong> clmul(Vector128<ulong> lhs, Vector128<ulong> rhs, ClMulMask:byte mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Pclmulqdq::CarrylessMultiply(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Byte)
    IL_0008: ret

}
ushort clmul(byte lhs, byte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.dinx::clmul(System.UInt32,System.UInt32)
    IL_0007: conv.u2
    IL_0008: ret

}
uint clmul(ushort lhs, ushort rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.dinx::clmul(System.UInt32,System.UInt32)
    IL_0007: conv.u4
    IL_0008: ret

}
ulong clmul(uint lhs, uint rhs)
{
    IL_0000: ldarg.0
    IL_0001: conv.u8
    IL_0002: ldarg.1
    IL_0003: conv.u8
    IL_0004: call Z0.UInt128 Z0.dinx::clmul(System.UInt64,System.UInt64)
    IL_0009: ldfld System.UInt64 Z0.UInt128::lo
    IL_000E: ret

}
Scalar128<ulong> clmulr(Scalar128<ulong> a, Scalar128<ulong> b, Vec128<ulong> poly)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.UInt64> Z0.dinx::clmul(Z0.Scalar128`1<System.UInt64>,Z0.Scalar128`1<System.UInt64>)
    IL_0007: stloc.0
    IL_0008: ldloc.0
    IL_0009: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_000E: ldloc.0
    IL_000F: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_0014: ldc.i4.s 64
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.dinx::vsrl(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Byte)
    IL_001B: ldarg.2
    IL_001C: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_0021: ldc.i4.0
    IL_0022: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.dinx::clmul(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>,Z0.ClMulMask)
    IL_0027: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.dinx::vxor(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_002C: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0031: stloc.0
    IL_0032: ldloc.0
    IL_0033: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_0038: ldloc.0
    IL_0039: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_003E: ldc.i4.s 64
    IL_0040: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.dinx::vsrl(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Byte)
    IL_0045: ldarg.2
    IL_0046: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_004B: ldc.i4.0
    IL_004C: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.dinx::clmul(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>,Z0.ClMulMask)
    IL_0051: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.dinx::vxor(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0056: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_005B: stloc.0
    IL_005C: ldloc.0
    IL_005D: call Z0.Scalar128`1<System.UInt64> Z0.Scalar128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_0062: ret

}
Vec128<sbyte> vdec(in Vec128<sbyte> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.SByte> Z0.Vec128Pattern::units<System.SByte>()
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: call Z0.Vec128`1<System.SByte> Z0.dinx::vsub(Z0.Vec128`1<System.SByte>&,Z0.Vec128`1<System.SByte>&)
    IL_000E: ret

}
Vec128<byte> vdec(in Vec128<byte> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.Byte> Z0.Vec128Pattern::units<System.Byte>()
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: call Z0.Vec128`1<System.Byte> Z0.dinx::vsub(Z0.Vec128`1<System.Byte>&,Z0.Vec128`1<System.Byte>&)
    IL_000E: ret

}
Vec128<short> vdec(in Vec128<short> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.Int16> Z0.Vec128Pattern::units<System.Int16>()
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: call Z0.Vec128`1<System.Int16> Z0.dinx::vsub(Z0.Vec128`1<System.Int16>&,Z0.Vec128`1<System.Int16>&)
    IL_000E: ret

}
Vec128<ushort> vdec(in Vec128<ushort> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.UInt16> Z0.Vec128Pattern::units<System.UInt16>()
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: call Z0.Vec128`1<System.UInt16> Z0.dinx::vsub(Z0.Vec128`1<System.UInt16>&,Z0.Vec128`1<System.UInt16>&)
    IL_000E: ret

}
Vec128<int> vdec(in Vec128<int> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.Int32> Z0.Vec128Pattern::units<System.Int32>()
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: call Z0.Vec128`1<System.Int32> Z0.dinx::vsub(Z0.Vec128`1<System.Int32>&,Z0.Vec128`1<System.Int32>&)
    IL_000E: ret

}
Vec128<uint> vdec(in Vec128<uint> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.UInt32> Z0.Vec128Pattern::units<System.UInt32>()
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: call Z0.Vec128`1<System.UInt32> Z0.dinx::vsub(Z0.Vec128`1<System.UInt32>&,Z0.Vec128`1<System.UInt32>&)
    IL_000E: ret

}
Vec128<long> vdec(in Vec128<long> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.Int64> Z0.Vec128Pattern::units<System.Int64>()
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: call Z0.Vec128`1<System.Int64> Z0.dinx::vsub(Z0.Vec128`1<System.Int64>&,Z0.Vec128`1<System.Int64>&)
    IL_000E: ret

}
Vec128<ulong> vdec(in Vec128<ulong> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.UInt64> Z0.Vec128Pattern::units<System.UInt64>()
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: call Z0.Vec128`1<System.UInt64> Z0.dinx::vsub(Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&)
    IL_000E: ret

}
Vec256<sbyte> vdec(in Vec256<sbyte> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec256`1<System.SByte> Z0.Vec256Pattern::Units<System.SByte>()
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: call Z0.Vec256`1<System.SByte> Z0.dinx::vsub(Z0.Vec256`1<System.SByte>&,Z0.Vec256`1<System.SByte>&)
    IL_000E: ret

}
Vec256<byte> vdec(in Vec256<byte> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec256`1<System.Byte> Z0.Vec256Pattern::Units<System.Byte>()
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: call Z0.Vec256`1<System.Byte> Z0.dinx::vsub(Z0.Vec256`1<System.Byte>&,Z0.Vec256`1<System.Byte>&)
    IL_000E: ret

}
Vec256<short> vdec(in Vec256<short> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec256`1<System.Int16> Z0.Vec256Pattern::Units<System.Int16>()
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: call Z0.Vec256`1<System.Int16> Z0.dinx::vsub(Z0.Vec256`1<System.Int16>&,Z0.Vec256`1<System.Int16>&)
    IL_000E: ret

}
Vec256<ushort> vdec(in Vec256<ushort> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec256`1<System.UInt16> Z0.Vec256Pattern::Units<System.UInt16>()
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: call Z0.Vec256`1<System.UInt16> Z0.dinx::vsub(Z0.Vec256`1<System.UInt16>&,Z0.Vec256`1<System.UInt16>&)
    IL_000E: ret

}
Vec256<int> vdec(in Vec256<int> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec256`1<System.Int32> Z0.Vec256Pattern::Units<System.Int32>()
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: call Z0.Vec256`1<System.Int32> Z0.dinx::vsub(Z0.Vec256`1<System.Int32>&,Z0.Vec256`1<System.Int32>&)
    IL_000E: ret

}
Vec256<uint> vdec(in Vec256<uint> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec256`1<System.UInt32> Z0.Vec256Pattern::Units<System.UInt32>()
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: call Z0.Vec256`1<System.UInt32> Z0.dinx::vsub(Z0.Vec256`1<System.UInt32>&,Z0.Vec256`1<System.UInt32>&)
    IL_000E: ret

}
Vec256<long> vdec(in Vec256<long> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec256`1<System.Int64> Z0.Vec256Pattern::Units<System.Int64>()
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: call Z0.Vec256`1<System.Int64> Z0.dinx::vsub(Z0.Vec256`1<System.Int64>&,Z0.Vec256`1<System.Int64>&)
    IL_000E: ret

}
Vec256<ulong> vdec(in Vec256<ulong> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec256`1<System.UInt64> Z0.Vec256Pattern::Units<System.UInt64>()
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: call Z0.Vec256`1<System.UInt64> Z0.dinx::vsub(Z0.Vec256`1<System.UInt64>&,Z0.Vec256`1<System.UInt64>&)
    IL_000E: ret

}
long vdot(Vector256<int> lhs, Vector256<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.dinx::vmul(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0007: stloc.0
    IL_0008: ldloc.0
    IL_0009: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.dinx::vlo(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_000E: ldloc.0
    IL_000F: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.dinx::vhi(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0014: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.dinx::vadd(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0019: stloc.1
    IL_001A: ldloc.1
    IL_001B: call Z0.Span128`1<System.Int64> Z0.VSpanX::ToBlockedSpan<System.Int64>(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0020: stloc.2
    IL_0021: ldloca.s V_2
    IL_0023: ldc.i4.0
    IL_0024: call System.Int64& Z0.Span128`1<System.Int64>::get_Item(System.Int32)
    IL_0029: ldind.i8
    IL_002A: ldloca.s V_2
    IL_002C: ldc.i4.1
    IL_002D: call System.Int64& Z0.Span128`1<System.Int64>::get_Item(System.Int32)
    IL_0032: ldind.i8
    IL_0033: add
    IL_0034: ret

}
ulong vdot(Vector256<uint> lhs, Vector256<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::vmul(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0007: stloc.0
    IL_0008: ldloc.0
    IL_0009: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.dinx::vlo(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_000E: ldloc.0
    IL_000F: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.dinx::vhi(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0014: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.dinx::vadd(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0019: stloc.1
    IL_001A: ldloc.1
    IL_001B: call Z0.Span128`1<System.UInt64> Z0.VSpanX::ToBlockedSpan<System.UInt64>(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0020: stloc.2
    IL_0021: ldloca.s V_2
    IL_0023: ldc.i4.0
    IL_0024: call System.UInt64& Z0.Span128`1<System.UInt64>::get_Item(System.Int32)
    IL_0029: ldind.i8
    IL_002A: ldloca.s V_2
    IL_002C: ldc.i4.1
    IL_002D: call System.UInt64& Z0.Span128`1<System.UInt64>::get_Item(System.Int32)
    IL_0032: ldind.i8
    IL_0033: add
    IL_0034: ret

}
Vec128<short> vhadd(in Vec128<short> x, in Vec128<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Ssse3::HorizontalAdd(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0011: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0016: ret

}
Vec128<int> vhadd(in Vec128<int> x, in Vec128<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Ssse3::HorizontalAdd(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0011: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0016: ret

}
Vec256<short> vhadd(in Vec256<short> x, in Vec256<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::HorizontalAdd(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0011: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0016: ret

}
Vec256<int> vhadd(in Vec256<int> x, in Vec256<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::HorizontalAdd(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0016: ret

}
Vec128<sbyte> vinc(in Vec128<sbyte> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.SByte> Z0.Vec128Pattern::units<System.SByte>()
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: call Z0.Vec128`1<System.SByte> Z0.dinx::vadd(Z0.Vec128`1<System.SByte>&,Z0.Vec128`1<System.SByte>&)
    IL_000E: ret

}
Vec128<byte> vinc(in Vec128<byte> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.Byte> Z0.Vec128Pattern::units<System.Byte>()
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: call Z0.Vec128`1<System.Byte> Z0.dinx::vadd(Z0.Vec128`1<System.Byte>&,Z0.Vec128`1<System.Byte>&)
    IL_000E: ret

}
Vec128<short> vinc(in Vec128<short> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.Int16> Z0.Vec128Pattern::units<System.Int16>()
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: call Z0.Vec128`1<System.Int16> Z0.dinx::vadd(Z0.Vec128`1<System.Int16>&,Z0.Vec128`1<System.Int16>&)
    IL_000E: ret

}
Vec128<ushort> vinc(in Vec128<ushort> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.UInt16> Z0.Vec128Pattern::units<System.UInt16>()
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: call Z0.Vec128`1<System.UInt16> Z0.dinx::vadd(Z0.Vec128`1<System.UInt16>&,Z0.Vec128`1<System.UInt16>&)
    IL_000E: ret

}
Vec128<int> vinc(in Vec128<int> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.Int32> Z0.Vec128Pattern::units<System.Int32>()
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: call Z0.Vec128`1<System.Int32> Z0.dinx::vadd(Z0.Vec128`1<System.Int32>&,Z0.Vec128`1<System.Int32>&)
    IL_000E: ret

}
Vec128<uint> vinc(in Vec128<uint> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.UInt32> Z0.Vec128Pattern::units<System.UInt32>()
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: call Z0.Vec128`1<System.UInt32> Z0.dinx::vadd(Z0.Vec128`1<System.UInt32>&,Z0.Vec128`1<System.UInt32>&)
    IL_000E: ret

}
Vec128<long> vinc(in Vec128<long> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.Int64> Z0.Vec128Pattern::units<System.Int64>()
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: call Z0.Vec128`1<System.Int64> Z0.dinx::vadd(Z0.Vec128`1<System.Int64>&,Z0.Vec128`1<System.Int64>&)
    IL_000E: ret

}
Vec128<ulong> vinc(in Vec128<ulong> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.UInt64> Z0.Vec128Pattern::units<System.UInt64>()
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: call Z0.Vec128`1<System.UInt64> Z0.dinx::vadd(Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&)
    IL_000E: ret

}
Vec256<sbyte> vinc(in Vec256<sbyte> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec256`1<System.SByte> Z0.Vec256Pattern::Units<System.SByte>()
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: call Z0.Vec256`1<System.SByte> Z0.dinx::vadd(Z0.Vec256`1<System.SByte>&,Z0.Vec256`1<System.SByte>&)
    IL_000E: ret

}
Vec256<byte> vinc(in Vec256<byte> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec256`1<System.Byte> Z0.Vec256Pattern::Units<System.Byte>()
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: call Z0.Vec256`1<System.Byte> Z0.dinx::vadd(Z0.Vec256`1<System.Byte>&,Z0.Vec256`1<System.Byte>&)
    IL_000E: ret

}
Vec256<short> vinc(in Vec256<short> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec256`1<System.Int16> Z0.Vec256Pattern::Units<System.Int16>()
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: call Z0.Vec256`1<System.Int16> Z0.dinx::vadd(Z0.Vec256`1<System.Int16>&,Z0.Vec256`1<System.Int16>&)
    IL_000E: ret

}
Vec256<ushort> vinc(in Vec256<ushort> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec256`1<System.UInt16> Z0.Vec256Pattern::Units<System.UInt16>()
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: call Z0.Vec256`1<System.UInt16> Z0.dinx::vadd(Z0.Vec256`1<System.UInt16>&,Z0.Vec256`1<System.UInt16>&)
    IL_000E: ret

}
Vec256<int> vinc(in Vec256<int> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec256`1<System.Int32> Z0.Vec256Pattern::Units<System.Int32>()
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: call Z0.Vec256`1<System.Int32> Z0.dinx::vadd(Z0.Vec256`1<System.Int32>&,Z0.Vec256`1<System.Int32>&)
    IL_000E: ret

}
Vec256<uint> vinc(in Vec256<uint> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec256`1<System.UInt32> Z0.Vec256Pattern::Units<System.UInt32>()
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: call Z0.Vec256`1<System.UInt32> Z0.dinx::vadd(Z0.Vec256`1<System.UInt32>&,Z0.Vec256`1<System.UInt32>&)
    IL_000E: ret

}
Vec256<long> vinc(in Vec256<long> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec256`1<System.Int64> Z0.Vec256Pattern::Units<System.Int64>()
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: call Z0.Vec256`1<System.Int64> Z0.dinx::vadd(Z0.Vec256`1<System.Int64>&,Z0.Vec256`1<System.Int64>&)
    IL_000E: ret

}
Vec256<ulong> vinc(in Vec256<ulong> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec256`1<System.UInt64> Z0.Vec256Pattern::Units<System.UInt64>()
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: call Z0.Vec256`1<System.UInt64> Z0.dinx::vadd(Z0.Vec256`1<System.UInt64>&,Z0.Vec256`1<System.UInt64>&)
    IL_000E: ret

}
Vec128<byte> vmax(in Vec128<byte> x, in Vec128<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::Max(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0011: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0016: ret

}
Vec128<sbyte> vmax(in Vec128<sbyte> x, in Vec128<sbyte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse41::Max(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0011: call Z0.Vec128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0016: ret

}
Vec128<short> vmax(in Vec128<short> x, in Vec128<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::Max(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0011: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0016: ret

}
Vec128<ushort> vmax(in Vec128<ushort> x, in Vec128<ushort> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse41::Max(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0011: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0016: ret

}
Vec128<int> vmax(in Vec128<int> x, in Vec128<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse41::Max(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0011: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0016: ret

}
Vec128<uint> vmax(in Vec128<uint> x, in Vec128<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse41::Max(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0011: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0016: ret

}
Vec256<byte> vmax(in Vec256<byte> x, in Vec256<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::Max(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0011: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0016: ret

}
Vec256<sbyte> vmax(in Vec256<sbyte> x, in Vec256<sbyte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::Max(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0011: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0016: ret

}
Vec256<short> vmax(in Vec256<short> x, in Vec256<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::Max(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0011: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0016: ret

}
Vec256<ushort> vmax(in Vec256<ushort> x, in Vec256<ushort> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::Max(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0011: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0016: ret

}
Vec256<int> vmax(in Vec256<int> x, in Vec256<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::Max(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0016: ret

}
Vec256<uint> vmax(in Vec256<uint> x, in Vec256<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::Max(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0011: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0016: ret

}
Vec128<byte> vmin(in Vec128<byte> x, in Vec128<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::Min(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0011: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0016: ret

}
Vec128<sbyte> vmin(in Vec128<sbyte> x, in Vec128<sbyte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse41::Min(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0011: call Z0.Vec128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0016: ret

}
Vec128<short> vmin(in Vec128<short> x, in Vec128<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::Min(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0011: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0016: ret

}
Vec128<ushort> vmin(in Vec128<ushort> x, in Vec128<ushort> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse41::Min(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0011: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0016: ret

}
Vec128<int> vmin(in Vec128<int> x, in Vec128<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse41::Min(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0011: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0016: ret

}
Vec128<uint> vmin(in Vec128<uint> x, in Vec128<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse41::Min(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0011: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0016: ret

}
Vec256<byte> vmin(in Vec256<byte> x, in Vec256<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::Min(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0011: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0016: ret

}
Vec256<sbyte> vmin(in Vec256<sbyte> x, in Vec256<sbyte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::Min(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0011: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0016: ret

}
Vec256<short> vmin(in Vec256<short> x, in Vec256<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::Min(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0011: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0016: ret

}
Vec256<ushort> vmin(in Vec256<ushort> x, in Vec256<ushort> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::Min(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0011: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0016: ret

}
Vec256<int> vmin(in Vec256<int> x, in Vec256<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::Min(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0016: ret

}
Vec256<uint> vmin(in Vec256<uint> x, in Vec256<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::Min(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0011: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0016: ret

}
Vector128<short> vmulhrs(Vector128<short> x, Vector128<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Ssse3::MultiplyHighRoundScale(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0007: ret

}
Vector256<short> vmulhrs(Vector256<short> x, Vector256<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::MultiplyHighRoundScale(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0007: ret

}
Vec128<long> vmul(in Vec128<int> x, in Vec128<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse41::Multiply(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0011: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0016: ret

}
