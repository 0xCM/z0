// 2020-01-13 21:43:22:469
Vector128<byte> vmov_idx3_128x8u(byte src, Vector128<byte> dst)
{
//  Id := 100664700, Name := System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.OpCodes.vmov::vmov_idx3_128x8u(System.Byte,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
//  Vector128<byte> vmov_idx3_128x8u(byte src, Vector128<byte> dst)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldc.i4.3
  IL_0002: ldarg.1
  IL_0003: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.ginx::vputcell<System.Byte>(System.Byte,System.Int32,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
  IL_0008: ret
}

}
Vector128<ushort> vmov_idx4_128x16u(ushort src, Vector128<ushort> dst)
{
//  Id := 100664701, Name := System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.OpCodes.vmov::vmov_idx4_128x16u(System.UInt16,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
//  Vector128<ushort> vmov_idx4_128x16u(ushort src, Vector128<ushort> dst)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldc.i4.4
  IL_0002: ldarg.1
  IL_0003: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.ginx::vputcell<System.UInt16>(System.UInt16,System.Int32,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
  IL_0008: ret
}

}
Vector128<uint> vmov_idx2_128x32u(uint src, Vector128<uint> dst)
{
//  Id := 100664702, Name := System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.OpCodes.vmov::vmov_idx2_128x32u(System.UInt32,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
//  Vector128<uint> vmov_idx2_128x32u(uint src, Vector128<uint> dst)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldc.i4.2
  IL_0002: ldarg.1
  IL_0003: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.ginx::vputcell<System.UInt32>(System.UInt32,System.Int32,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
  IL_0008: ret
}

}
Vector256<byte> vmov_idx3_256x8u(byte src, Vector256<byte> dst)
{
//  Id := 100664703, Name := System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.OpCodes.vmov::vmov_idx3_256x8u(System.Byte,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
//  Vector256<byte> vmov_idx3_256x8u(byte src, Vector256<byte> dst)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldc.i4.3
  IL_0002: ldarg.1
  IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.ginx::vputcell<System.Byte>(System.Byte,System.Int32,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
  IL_0008: ret
}

}
Vector256<ushort> vmov_idx4_256x16u(ushort src, Vector256<ushort> dst)
{
//  Id := 100664704, Name := System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.OpCodes.vmov::vmov_idx4_256x16u(System.UInt16,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
//  Vector256<ushort> vmov_idx4_256x16u(ushort src, Vector256<ushort> dst)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldc.i4.4
  IL_0002: ldarg.1
  IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.ginx::vputcell<System.UInt16>(System.UInt16,System.Int32,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
  IL_0008: ret
}

}
Vector256<uint> vmov_idx2_256x32u(uint src, Vector256<uint> dst)
{
//  Id := 100664705, Name := System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.OpCodes.vmov::vmov_idx2_256x32u(System.UInt32,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
//  Vector256<uint> vmov_idx2_256x32u(uint src, Vector256<uint> dst)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldc.i4.2
  IL_0002: ldarg.1
  IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.ginx::vputcell<System.UInt32>(System.UInt32,System.Int32,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
  IL_0008: ret
}

}
Vector256<uint> vmov_idx4x2_256x32u(uint a, uint b, Vector256<uint> dst)
{
//  Id := 100664706, Name := System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.OpCodes.vmov::vmov_idx4x2_256x32u(System.UInt32,System.UInt32,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
//  Vector256<uint> vmov_idx4x2_256x32u(uint a, uint b, Vector256<uint> dst)
//  Managed
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

}
Vector128<byte> vmov128x8u(byte src)
{
//  Id := 100664707, Name := System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.OpCodes.vmov::vmov128x8u(System.Byte)
//  Vector128<byte> vmov128x8u(byte src)
//  Managed
{
  IL_0000: call Z0.N128 zfunc::get_n128()
  IL_0005: ldarg.0
  IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.CpuVector::vscalar<System.Byte>(Z0.N128,System.Byte)
  IL_000B: ret
}

}
Vector128<ushort> vmov128x16u(ushort src)
{
//  Id := 100664708, Name := System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.OpCodes.vmov::vmov128x16u(System.UInt16)
//  Vector128<ushort> vmov128x16u(ushort src)
//  Managed
{
  IL_0000: call Z0.N128 zfunc::get_n128()
  IL_0005: ldarg.0
  IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.CpuVector::vscalar<System.UInt16>(Z0.N128,System.UInt16)
  IL_000B: ret
}

}
Vector128<uint> vmov128x32u(uint src)
{
//  Id := 100664709, Name := System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.OpCodes.vmov::vmov128x32u(System.UInt32)
//  Vector128<uint> vmov128x32u(uint src)
//  Managed
{
  IL_0000: call Z0.N128 zfunc::get_n128()
  IL_0005: ldarg.0
  IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.CpuVector::vscalar<System.UInt32>(Z0.N128,System.UInt32)
  IL_000B: ret
}

}
Vector128<ulong> vmov128x64u(ulong src)
{
//  Id := 100664710, Name := System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.OpCodes.vmov::vmov128x64u(System.UInt64)
//  Vector128<ulong> vmov128x64u(ulong src)
//  Managed
{
  IL_0000: call Z0.N128 zfunc::get_n128()
  IL_0005: ldarg.0
  IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.CpuVector::vscalar<System.UInt64>(Z0.N128,System.UInt64)
  IL_000B: ret
}

}
Vector128<double> vmov128x64u(double src)
{
//  Id := 100664711, Name := System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.OpCodes.vmov::vmov128x64u(System.Double)
//  Vector128<double> vmov128x64u(double src)
//  Managed
{
  IL_0000: call Z0.N128 zfunc::get_n128()
  IL_0005: ldarg.0
  IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.CpuVector::vscalar<System.Double>(Z0.N128,System.Double)
  IL_000B: ret
}

}
Vector256<byte> vmov256x8u(byte src)
{
//  Id := 100664712, Name := System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.OpCodes.vmov::vmov256x8u(System.Byte)
//  Vector256<byte> vmov256x8u(byte src)
//  Managed
{
  IL_0000: call Z0.N256 zfunc::get_n256()
  IL_0005: ldarg.0
  IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.CpuVector::vscalar<System.Byte>(Z0.N256,System.Byte)
  IL_000B: ret
}

}
Vector256<ushort> vmov256x16u(ushort src)
{
//  Id := 100664713, Name := System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.OpCodes.vmov::vmov256x16u(System.UInt16)
//  Vector256<ushort> vmov256x16u(ushort src)
//  Managed
{
  IL_0000: call Z0.N256 zfunc::get_n256()
  IL_0005: ldarg.0
  IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.CpuVector::vscalar<System.UInt16>(Z0.N256,System.UInt16)
  IL_000B: ret
}

}
Vector256<uint> vmov256x32u(uint src)
{
//  Id := 100664714, Name := System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.OpCodes.vmov::vmov256x32u(System.UInt32)
//  Vector256<uint> vmov256x32u(uint src)
//  Managed
{
  IL_0000: call Z0.N256 zfunc::get_n256()
  IL_0005: ldarg.0
  IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.CpuVector::vscalar<System.UInt32>(Z0.N256,System.UInt32)
  IL_000B: ret
}

}
Vector256<ulong> vmov256x64u(ulong src)
{
//  Id := 100664715, Name := System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.OpCodes.vmov::vmov256x64u(System.UInt64)
//  Vector256<ulong> vmov256x64u(ulong src)
//  Managed
{
  IL_0000: call Z0.N256 zfunc::get_n256()
  IL_0005: ldarg.0
  IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.CpuVector::vscalar<System.UInt64>(Z0.N256,System.UInt64)
  IL_000B: ret
}

}
Vector256<double> vmov256x64u(double src)
{
//  Id := 100664716, Name := System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.OpCodes.vmov::vmov256x64u(System.Double)
//  Vector256<double> vmov256x64u(double src)
//  Managed
{
  IL_0000: call Z0.N256 zfunc::get_n256()
  IL_0005: ldarg.0
  IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.CpuVector::vscalar<System.Double>(Z0.N256,System.Double)
  IL_000B: ret
}

}
