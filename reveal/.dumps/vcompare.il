// 2020-01-16 19:14:10:485
// Id := 100664716, Name := System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.OpCodes.vcompare::vlt_128x32i(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
// Vector128<int> vlt_128x32i(Vector128<int> x, Vector128<int> y)
// Managed
Vector128<int> vlt_128x32i(Vector128<int> x, Vector128<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.dinx::vlt(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0007: ret
}

// Id := 100664717, Name := System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.OpCodes.vcompare::vlt_g128x32i(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
// Vector128<int> vlt_g128x32i(Vector128<int> x, Vector128<int> y)
// Managed
Vector128<int> vlt_g128x32i(Vector128<int> x, Vector128<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.ginx::vlt<System.Int32>(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0007: ret
}

// Id := 100664718, Name := System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.OpCodes.vcompare::vlt_o128x32i(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
// Vector128<int> vlt_o128x32i(Vector128<int> x, Vector128<int> y)
// Managed
Vector128<int> vlt_o128x32i(Vector128<int> x, Vector128<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.N128 zfunc::get_n128()
    IL_0007: ldc.i4.0
    IL_0008: call Z0.VXTypes/Lt128`1<System.Int32> Z0.VX::vlt<System.Int32>(Z0.N128,System.Int32)
    IL_000D: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Pipes::apply<Z0.VXTypes/Lt128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>>(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>,Z0.VXTypes/Lt128`1<System.Int32>)
    IL_0012: ret
}

// Id := 100664719, Name := System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.OpCodes.vcompare::vlt_128x32u(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
// Vector128<uint> vlt_128x32u(Vector128<uint> x, Vector128<uint> y)
// Managed
Vector128<uint> vlt_128x32u(Vector128<uint> x, Vector128<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.dinx::vlt(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0007: ret
}

// Id := 100664720, Name := System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.OpCodes.vcompare::vlt_g128x32u(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
// Vector128<uint> vlt_g128x32u(Vector128<uint> x, Vector128<uint> y)
// Managed
Vector128<uint> vlt_g128x32u(Vector128<uint> x, Vector128<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.ginx::vlt<System.UInt32>(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0007: ret
}

// Id := 100664721, Name := System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.OpCodes.vcompare::vlt_o128x32u(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
// Vector128<uint> vlt_o128x32u(Vector128<uint> x, Vector128<uint> y)
// Managed
Vector128<uint> vlt_o128x32u(Vector128<uint> x, Vector128<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.N128 zfunc::get_n128()
    IL_0007: ldc.i4.0
    IL_0008: call Z0.VXTypes/Lt128`1<System.UInt32> Z0.VX::vlt<System.UInt32>(Z0.N128,System.UInt32)
    IL_000D: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Pipes::apply<Z0.VXTypes/Lt128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>>(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>,Z0.VXTypes/Lt128`1<System.UInt32>)
    IL_0012: ret
}

// Id := 100664722, Name := System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.OpCodes.vcompare::vlt_128x64i(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
// Vector128<long> vlt_128x64i(Vector128<long> x, Vector128<long> y)
// Managed
Vector128<long> vlt_128x64i(Vector128<long> x, Vector128<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.dinx::vlt(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0007: ret
}

// Id := 100664723, Name := System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.OpCodes.vcompare::vlt_g128x64i(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
// Vector128<long> vlt_g128x64i(Vector128<long> x, Vector128<long> y)
// Managed
Vector128<long> vlt_g128x64i(Vector128<long> x, Vector128<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.ginx::vlt<System.Int64>(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0007: ret
}

// Id := 100664724, Name := System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.OpCodes.vcompare::vlt_o128x64i(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
// Vector128<long> vlt_o128x64i(Vector128<long> x, Vector128<long> y)
// Managed
Vector128<long> vlt_o128x64i(Vector128<long> x, Vector128<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.N128 zfunc::get_n128()
    IL_0007: ldc.i4.0
    IL_0008: conv.i8
    IL_0009: call Z0.VXTypes/Lt128`1<System.Int64> Z0.VX::vlt<System.Int64>(Z0.N128,System.Int64)
    IL_000E: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Pipes::apply<Z0.VXTypes/Lt128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>>(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>,Z0.VXTypes/Lt128`1<System.Int64>)
    IL_0013: ret
}

// Id := 100664725, Name := System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.OpCodes.vcompare::vlt_256x8u(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
// Vector256<byte> vlt_256x8u(Vector256<byte> x, Vector256<byte> y)
// Managed
Vector256<byte> vlt_256x8u(Vector256<byte> x, Vector256<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.dinx::vlt(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0007: ret
}

// Id := 100664726, Name := System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.OpCodes.vcompare::vlt_g256x8u(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
// Vector256<byte> vlt_g256x8u(Vector256<byte> x, Vector256<byte> y)
// Managed
Vector256<byte> vlt_g256x8u(Vector256<byte> x, Vector256<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.ginx::vlt<System.Byte>(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0007: ret
}

// Id := 100664727, Name := System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.OpCodes.vcompare::vlt_o256x8u(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
// Vector256<byte> vlt_o256x8u(Vector256<byte> x, Vector256<byte> y)
// Managed
Vector256<byte> vlt_o256x8u(Vector256<byte> x, Vector256<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.N256 zfunc::get_n256()
    IL_0007: ldc.i4.0
    IL_0008: call Z0.VXTypes/Lt256`1<System.Byte> Z0.VX::vlt<System.Byte>(Z0.N256,System.Byte)
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Pipes::apply<Z0.VXTypes/Lt256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>>(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>,Z0.VXTypes/Lt256`1<System.Byte>)
    IL_0012: ret
}

// Id := 100664728, Name := System.Boolean Z0.OpCodes.vcompare::vtestz_d128x8i(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
// bool vtestz_d128x8i(Vector128<sbyte> src, Vector128<sbyte> mask)
// Managed
bool vtestz_d128x8i(Vector128<sbyte> src, Vector128<sbyte> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.dinx::vtestz(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret
}

// Id := 100664729, Name := System.Boolean Z0.OpCodes.vcompare::vtestz_g128x8i(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
// bool vtestz_g128x8i(Vector128<sbyte> src, Vector128<sbyte> mask)
// Managed
bool vtestz_g128x8i(Vector128<sbyte> src, Vector128<sbyte> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.ginx::vtestz<System.SByte>(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret
}

// Id := 100664730, Name := System.Boolean Z0.OpCodes.vcompare::vtestz_d128x8u(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
// bool vtestz_d128x8u(Vector128<byte> src, Vector128<byte> mask)
// Managed
bool vtestz_d128x8u(Vector128<byte> src, Vector128<byte> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.dinx::vtestz(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret
}

// Id := 100664731, Name := System.Boolean Z0.OpCodes.vcompare::vtestz_g128x8u(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
// bool vtestz_g128x8u(Vector128<byte> src, Vector128<byte> mask)
// Managed
bool vtestz_g128x8u(Vector128<byte> src, Vector128<byte> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.ginx::vtestz<System.Byte>(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret
}

// Id := 100664732, Name := System.Boolean Z0.OpCodes.vcompare::vtestz_d128x16i(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
// bool vtestz_d128x16i(Vector128<short> src, Vector128<short> mask)
// Managed
bool vtestz_d128x16i(Vector128<short> src, Vector128<short> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.dinx::vtestz(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret
}

// Id := 100664733, Name := System.Boolean Z0.OpCodes.vcompare::vtestz_g128x16i(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
// bool vtestz_g128x16i(Vector128<short> src, Vector128<short> mask)
// Managed
bool vtestz_g128x16i(Vector128<short> src, Vector128<short> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.ginx::vtestz<System.Int16>(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret
}

// Id := 100664734, Name := System.Boolean Z0.OpCodes.vcompare::vtestz_d128x16u(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
// bool vtestz_d128x16u(Vector128<ushort> src, Vector128<ushort> mask)
// Managed
bool vtestz_d128x16u(Vector128<ushort> src, Vector128<ushort> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.dinx::vtestz(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret
}

// Id := 100664735, Name := System.Boolean Z0.OpCodes.vcompare::vtestz_g128x16u(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
// bool vtestz_g128x16u(Vector128<ushort> src, Vector128<ushort> mask)
// Managed
bool vtestz_g128x16u(Vector128<ushort> src, Vector128<ushort> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.ginx::vtestz<System.UInt16>(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret
}

// Id := 100664736, Name := System.Boolean Z0.OpCodes.vcompare::vtestz_d128x32i(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
// bool vtestz_d128x32i(Vector128<int> src, Vector128<int> mask)
// Managed
bool vtestz_d128x32i(Vector128<int> src, Vector128<int> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.dinx::vtestz(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret
}

// Id := 100664737, Name := System.Boolean Z0.OpCodes.vcompare::vtestz_g128x32i(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
// bool vtestz_g128x32i(Vector128<int> src, Vector128<int> mask)
// Managed
bool vtestz_g128x32i(Vector128<int> src, Vector128<int> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.ginx::vtestz<System.Int32>(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret
}

// Id := 100664738, Name := System.Boolean Z0.OpCodes.vcompare::vtestz_d128x32u(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
// bool vtestz_d128x32u(Vector128<uint> src, Vector128<uint> mask)
// Managed
bool vtestz_d128x32u(Vector128<uint> src, Vector128<uint> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.dinx::vtestz(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret
}

// Id := 100664739, Name := System.Boolean Z0.OpCodes.vcompare::vtestz_g128x32u(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
// bool vtestz_g128x32u(Vector128<uint> src, Vector128<uint> mask)
// Managed
bool vtestz_g128x32u(Vector128<uint> src, Vector128<uint> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.ginx::vtestz<System.UInt32>(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret
}

// Id := 100664740, Name := System.Boolean Z0.OpCodes.vcompare::vtestz_d128x64i(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
// bool vtestz_d128x64i(Vector128<long> src, Vector128<long> mask)
// Managed
bool vtestz_d128x64i(Vector128<long> src, Vector128<long> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.dinx::vtestz(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret
}

// Id := 100664741, Name := System.Boolean Z0.OpCodes.vcompare::vtestz_g128x64i(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
// bool vtestz_g128x64i(Vector128<long> src, Vector128<long> mask)
// Managed
bool vtestz_g128x64i(Vector128<long> src, Vector128<long> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.ginx::vtestz<System.Int64>(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret
}

// Id := 100664742, Name := System.Boolean Z0.OpCodes.vcompare::vtestz_d128x64u(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
// bool vtestz_d128x64u(Vector128<ulong> src, Vector128<ulong> mask)
// Managed
bool vtestz_d128x64u(Vector128<ulong> src, Vector128<ulong> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.dinx::vtestz(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret
}

// Id := 100664743, Name := System.Boolean Z0.OpCodes.vcompare::vtestz_g128x64u(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
// bool vtestz_g128x64u(Vector128<ulong> src, Vector128<ulong> mask)
// Managed
bool vtestz_g128x64u(Vector128<ulong> src, Vector128<ulong> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.ginx::vtestz<System.UInt64>(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret
}

// Id := 100664744, Name := System.Boolean Z0.OpCodes.vcompare::vtestz_d256x8i(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
// bool vtestz_d256x8i(Vector256<sbyte> src, Vector256<sbyte> mask)
// Managed
bool vtestz_d256x8i(Vector256<sbyte> src, Vector256<sbyte> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.dinx::vtestz(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret
}

// Id := 100664745, Name := System.Boolean Z0.OpCodes.vcompare::vtestz_g256x8i(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
// bool vtestz_g256x8i(Vector256<sbyte> src, Vector256<sbyte> mask)
// Managed
bool vtestz_g256x8i(Vector256<sbyte> src, Vector256<sbyte> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.ginx::vtestz<System.SByte>(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret
}

// Id := 100664746, Name := System.Boolean Z0.OpCodes.vcompare::vtestz_d256x8u(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
// bool vtestz_d256x8u(Vector256<byte> src, Vector256<byte> mask)
// Managed
bool vtestz_d256x8u(Vector256<byte> src, Vector256<byte> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.dinx::vtestz(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret
}

// Id := 100664747, Name := System.Boolean Z0.OpCodes.vcompare::vtestz_g256x8u(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
// bool vtestz_g256x8u(Vector256<byte> src, Vector256<byte> mask)
// Managed
bool vtestz_g256x8u(Vector256<byte> src, Vector256<byte> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.ginx::vtestz<System.Byte>(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret
}

// Id := 100664748, Name := System.Boolean Z0.OpCodes.vcompare::vtestz_d256x16i(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
// bool vtestz_d256x16i(Vector256<short> src, Vector256<short> mask)
// Managed
bool vtestz_d256x16i(Vector256<short> src, Vector256<short> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.dinx::vtestz(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret
}

// Id := 100664749, Name := System.Boolean Z0.OpCodes.vcompare::vtestz_g256x16i(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
// bool vtestz_g256x16i(Vector256<short> src, Vector256<short> mask)
// Managed
bool vtestz_g256x16i(Vector256<short> src, Vector256<short> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.ginx::vtestz<System.Int16>(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret
}

// Id := 100664750, Name := System.Boolean Z0.OpCodes.vcompare::vtestz_d256x16u(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
// bool vtestz_d256x16u(Vector256<ushort> src, Vector256<ushort> mask)
// Managed
bool vtestz_d256x16u(Vector256<ushort> src, Vector256<ushort> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.dinx::vtestz(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret
}

// Id := 100664751, Name := System.Boolean Z0.OpCodes.vcompare::vtestz_g256x16u(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
// bool vtestz_g256x16u(Vector256<ushort> src, Vector256<ushort> mask)
// Managed
bool vtestz_g256x16u(Vector256<ushort> src, Vector256<ushort> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.ginx::vtestz<System.UInt16>(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret
}

// Id := 100664752, Name := System.Boolean Z0.OpCodes.vcompare::vtestz_d256x32i(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
// bool vtestz_d256x32i(Vector256<int> src, Vector256<int> mask)
// Managed
bool vtestz_d256x32i(Vector256<int> src, Vector256<int> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.dinx::vtestz(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret
}

// Id := 100664753, Name := System.Boolean Z0.OpCodes.vcompare::vtestz_g256x32i(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
// bool vtestz_g256x32i(Vector256<int> src, Vector256<int> mask)
// Managed
bool vtestz_g256x32i(Vector256<int> src, Vector256<int> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.ginx::vtestz<System.Int32>(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret
}

// Id := 100664754, Name := System.Boolean Z0.OpCodes.vcompare::vtestz_d256x32u(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
// bool vtestz_d256x32u(Vector256<uint> src, Vector256<uint> mask)
// Managed
bool vtestz_d256x32u(Vector256<uint> src, Vector256<uint> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.dinx::vtestz(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret
}

// Id := 100664755, Name := System.Boolean Z0.OpCodes.vcompare::vtestz_g256x32u(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
// bool vtestz_g256x32u(Vector256<uint> src, Vector256<uint> mask)
// Managed
bool vtestz_g256x32u(Vector256<uint> src, Vector256<uint> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.ginx::vtestz<System.UInt32>(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret
}

// Id := 100664756, Name := System.Boolean Z0.OpCodes.vcompare::vtestz_d256x64i(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
// bool vtestz_d256x64i(Vector256<long> src, Vector256<long> mask)
// Managed
bool vtestz_d256x64i(Vector256<long> src, Vector256<long> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.dinx::vtestz(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret
}

// Id := 100664757, Name := System.Boolean Z0.OpCodes.vcompare::vtestz_g256x64i(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
// bool vtestz_g256x64i(Vector256<long> src, Vector256<long> mask)
// Managed
bool vtestz_g256x64i(Vector256<long> src, Vector256<long> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.ginx::vtestz<System.Int64>(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret
}

// Id := 100664758, Name := System.Boolean Z0.OpCodes.vcompare::vtestz_d256x64u(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
// bool vtestz_d256x64u(Vector256<ulong> src, Vector256<ulong> mask)
// Managed
bool vtestz_d256x64u(Vector256<ulong> src, Vector256<ulong> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.dinx::vtestz(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret
}

// Id := 100664759, Name := System.Boolean Z0.OpCodes.vcompare::vtestz_g256x64u(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
// bool vtestz_g256x64u(Vector256<ulong> src, Vector256<ulong> mask)
// Managed
bool vtestz_g256x64u(Vector256<ulong> src, Vector256<ulong> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.ginx::vtestz<System.UInt64>(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret
}

