// 2020-01-16 19:14:10:544
// Id := 100664681, Name := System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.OpCodes.vmov::vmov_idx3_128x8u(System.Byte,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
// Vector128<byte> vmov_idx3_128x8u(byte src, Vector128<byte> dst)
// Managed
Vector128<byte> vmov_idx3_128x8u(byte src, Vector128<byte> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.3
    IL_0002: ldarg.1
    IL_0003: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.ginx::vputcell<System.Byte>(System.Byte,System.Int32,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0008: ret
}

// Id := 100664682, Name := System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.OpCodes.vmov::vmov_idx4_128x16u(System.UInt16,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
// Vector128<ushort> vmov_idx4_128x16u(ushort src, Vector128<ushort> dst)
// Managed
Vector128<ushort> vmov_idx4_128x16u(ushort src, Vector128<ushort> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.4
    IL_0002: ldarg.1
    IL_0003: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.ginx::vputcell<System.UInt16>(System.UInt16,System.Int32,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0008: ret
}

// Id := 100664683, Name := System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.OpCodes.vmov::vmov_idx2_128x32u(System.UInt32,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
// Vector128<uint> vmov_idx2_128x32u(uint src, Vector128<uint> dst)
// Managed
Vector128<uint> vmov_idx2_128x32u(uint src, Vector128<uint> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.2
    IL_0002: ldarg.1
    IL_0003: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.ginx::vputcell<System.UInt32>(System.UInt32,System.Int32,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0008: ret
}

// Id := 100664684, Name := System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.OpCodes.vmov::vmov_idx3_256x8u(System.Byte,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
// Vector256<byte> vmov_idx3_256x8u(byte src, Vector256<byte> dst)
// Managed
Vector256<byte> vmov_idx3_256x8u(byte src, Vector256<byte> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.3
    IL_0002: ldarg.1
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.ginx::vputcell<System.Byte>(System.Byte,System.Int32,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0008: ret
}

// Id := 100664685, Name := System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.OpCodes.vmov::vmov_idx4_256x16u(System.UInt16,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
// Vector256<ushort> vmov_idx4_256x16u(ushort src, Vector256<ushort> dst)
// Managed
Vector256<ushort> vmov_idx4_256x16u(ushort src, Vector256<ushort> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.4
    IL_0002: ldarg.1
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.ginx::vputcell<System.UInt16>(System.UInt16,System.Int32,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0008: ret
}

// Id := 100664686, Name := System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.OpCodes.vmov::vmov_idx2_256x32u(System.UInt32,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
// Vector256<uint> vmov_idx2_256x32u(uint src, Vector256<uint> dst)
// Managed
Vector256<uint> vmov_idx2_256x32u(uint src, Vector256<uint> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.2
    IL_0002: ldarg.1
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.ginx::vputcell<System.UInt32>(System.UInt32,System.Int32,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0008: ret
}

// Id := 100664687, Name := System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.OpCodes.vmov::vmov_idx4x2_256x32u(System.UInt32,System.UInt32,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
// Vector256<uint> vmov_idx4x2_256x32u(uint a, uint b, Vector256<uint> dst)
// Managed
Vector256<uint> vmov_idx4x2_256x32u(uint a, uint b, Vector256<uint> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldc.i4.4
    IL_0002: ldarg.0
    IL_0003: ldc.i4.2
    IL_0004: ldarg.2
    IL_0005: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.ginx::vputcell<System.UInt32>(System.UInt32,System.Int32,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_000A: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.ginx::vputcell<System.UInt32>(System.UInt32,System.Int32,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_000F: ret
}

// Id := 100664688, Name := System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.OpCodes.vmov::vmov128x8u(System.Byte)
// Vector128<byte> vmov128x8u(byte src)
// Managed
Vector128<byte> vmov128x8u(byte src)
{
    IL_0000: call Z0.N128 zfunc::get_n128()
    IL_0005: ldarg.0
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.CpuVector::vscalar<System.Byte>(Z0.N128,System.Byte)
    IL_000B: ret
}

// Id := 100664689, Name := System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.OpCodes.vmov::vmov128x16u(System.UInt16)
// Vector128<ushort> vmov128x16u(ushort src)
// Managed
Vector128<ushort> vmov128x16u(ushort src)
{
    IL_0000: call Z0.N128 zfunc::get_n128()
    IL_0005: ldarg.0
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.CpuVector::vscalar<System.UInt16>(Z0.N128,System.UInt16)
    IL_000B: ret
}

// Id := 100664690, Name := System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.OpCodes.vmov::vmov128x32u(System.UInt32)
// Vector128<uint> vmov128x32u(uint src)
// Managed
Vector128<uint> vmov128x32u(uint src)
{
    IL_0000: call Z0.N128 zfunc::get_n128()
    IL_0005: ldarg.0
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.CpuVector::vscalar<System.UInt32>(Z0.N128,System.UInt32)
    IL_000B: ret
}

// Id := 100664691, Name := System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.OpCodes.vmov::vmov128x64u(System.UInt64)
// Vector128<ulong> vmov128x64u(ulong src)
// Managed
Vector128<ulong> vmov128x64u(ulong src)
{
    IL_0000: call Z0.N128 zfunc::get_n128()
    IL_0005: ldarg.0
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.CpuVector::vscalar<System.UInt64>(Z0.N128,System.UInt64)
    IL_000B: ret
}

// Id := 100664692, Name := System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.OpCodes.vmov::vmov128x64u(System.Double)
// Vector128<double> vmov128x64u(double src)
// Managed
Vector128<double> vmov128x64u(double src)
{
    IL_0000: call Z0.N128 zfunc::get_n128()
    IL_0005: ldarg.0
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.CpuVector::vscalar<System.Double>(Z0.N128,System.Double)
    IL_000B: ret
}

// Id := 100664693, Name := System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.OpCodes.vmov::vmov256x8u(System.Byte)
// Vector256<byte> vmov256x8u(byte src)
// Managed
Vector256<byte> vmov256x8u(byte src)
{
    IL_0000: call Z0.N256 zfunc::get_n256()
    IL_0005: ldarg.0
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.CpuVector::vscalar<System.Byte>(Z0.N256,System.Byte)
    IL_000B: ret
}

// Id := 100664694, Name := System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.OpCodes.vmov::vmov256x16u(System.UInt16)
// Vector256<ushort> vmov256x16u(ushort src)
// Managed
Vector256<ushort> vmov256x16u(ushort src)
{
    IL_0000: call Z0.N256 zfunc::get_n256()
    IL_0005: ldarg.0
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.CpuVector::vscalar<System.UInt16>(Z0.N256,System.UInt16)
    IL_000B: ret
}

// Id := 100664695, Name := System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.OpCodes.vmov::vmov256x32u(System.UInt32)
// Vector256<uint> vmov256x32u(uint src)
// Managed
Vector256<uint> vmov256x32u(uint src)
{
    IL_0000: call Z0.N256 zfunc::get_n256()
    IL_0005: ldarg.0
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.CpuVector::vscalar<System.UInt32>(Z0.N256,System.UInt32)
    IL_000B: ret
}

// Id := 100664696, Name := System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.OpCodes.vmov::vmov256x64u(System.UInt64)
// Vector256<ulong> vmov256x64u(ulong src)
// Managed
Vector256<ulong> vmov256x64u(ulong src)
{
    IL_0000: call Z0.N256 zfunc::get_n256()
    IL_0005: ldarg.0
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.CpuVector::vscalar<System.UInt64>(Z0.N256,System.UInt64)
    IL_000B: ret
}

// Id := 100664697, Name := System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.OpCodes.vmov::vmov256x64u(System.Double)
// Vector256<double> vmov256x64u(double src)
// Managed
Vector256<double> vmov256x64u(double src)
{
    IL_0000: call Z0.N256 zfunc::get_n256()
    IL_0005: ldarg.0
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.CpuVector::vscalar<System.Double>(Z0.N256,System.Double)
    IL_000B: ret
}

