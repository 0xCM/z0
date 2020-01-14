// 2020-01-13 21:43:21:725
ref BitMatrix<ulong> or_and_xor_bm(in BitMatrix<ulong> a, in BitMatrix<ulong> b, ref BitMatrix<ulong> C)
{
//  Id := 100664861, Name := Z0.BitMatrix`1<System.UInt64>& Z0.OpCodes.logixmat::or_and_xor_bm(Z0.BitMatrix`1<System.UInt64>&,Z0.BitMatrix`1<System.UInt64>&,Z0.BitMatrix`1<System.UInt64>&)
//  ref BitMatrix<ulong> or_and_xor_bm(in BitMatrix<ulong> a, in BitMatrix<ulong> b, ref BitMatrix<ulong> C)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: ldarg.2
  IL_0003: call Z0.BitMatrix`1<System.UInt64>& Z0.Logix.BitMatrixOps::and<System.UInt64>(Z0.BitMatrix`1<System.UInt64>&,Z0.BitMatrix`1<System.UInt64>&,Z0.BitMatrix`1<System.UInt64>&)
  IL_0008: ldarg.0
  IL_0009: ldarg.1
  IL_000A: ldarg.2
  IL_000B: call Z0.BitMatrix`1<System.UInt64>& Z0.Logix.BitMatrixOps::xor<System.UInt64>(Z0.BitMatrix`1<System.UInt64>&,Z0.BitMatrix`1<System.UInt64>&,Z0.BitMatrix`1<System.UInt64>&)
  IL_0010: ldarg.2
  IL_0011: call Z0.BitMatrix`1<System.UInt64>& Z0.Logix.BitMatrixOps::or<System.UInt64>(Z0.BitMatrix`1<System.UInt64>&,Z0.BitMatrix`1<System.UInt64>&,Z0.BitMatrix`1<System.UInt64>&)
  IL_0016: ret
}

}
ref BitMatrix<ulong> nand_or_and_xor_bm(in BitMatrix<ulong> A, in BitMatrix<ulong> B, ref BitMatrix<ulong> C)
{
//  Id := 100664862, Name := Z0.BitMatrix`1<System.UInt64>& Z0.OpCodes.logixmat::nand_or_and_xor_bm(Z0.BitMatrix`1<System.UInt64>&,Z0.BitMatrix`1<System.UInt64>&,Z0.BitMatrix`1<System.UInt64>&)
//  ref BitMatrix<ulong> nand_or_and_xor_bm(in BitMatrix<ulong> A, in BitMatrix<ulong> B, ref BitMatrix<ulong> C)
//  Managed
{
  IL_0000: ldarg.1
  IL_0001: ldarg.0
  IL_0002: ldarg.1
  IL_0003: ldarg.2
  IL_0004: call Z0.BitMatrix`1<System.UInt64>& Z0.Logix.BitMatrixOps::and<System.UInt64>(Z0.BitMatrix`1<System.UInt64>&,Z0.BitMatrix`1<System.UInt64>&,Z0.BitMatrix`1<System.UInt64>&)
  IL_0009: ldarg.0
  IL_000A: ldarg.1
  IL_000B: ldarg.2
  IL_000C: call Z0.BitMatrix`1<System.UInt64>& Z0.Logix.BitMatrixOps::xor<System.UInt64>(Z0.BitMatrix`1<System.UInt64>&,Z0.BitMatrix`1<System.UInt64>&,Z0.BitMatrix`1<System.UInt64>&)
  IL_0011: ldarg.2
  IL_0012: call Z0.BitMatrix`1<System.UInt64>& Z0.Logix.BitMatrixOps::or<System.UInt64>(Z0.BitMatrix`1<System.UInt64>&,Z0.BitMatrix`1<System.UInt64>&,Z0.BitMatrix`1<System.UInt64>&)
  IL_0017: ldarg.2
  IL_0018: call Z0.BitMatrix`1<System.UInt64>& Z0.Logix.BitMatrixOps::nand<System.UInt64>(Z0.BitMatrix`1<System.UInt64>&,Z0.BitMatrix`1<System.UInt64>&,Z0.BitMatrix`1<System.UInt64>&)
  IL_001D: ret
}

}
bit comp1_logic(bit a, bit b)
{
//  Id := 100664863, Name := Z0.bit Z0.OpCodes.logixmat::comp1_logic(Z0.bit,Z0.bit)
//  bit comp1_logic(bit a, bit b)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call Z0.bit Z0.Logix.LogicOps::and(Z0.bit,Z0.bit)
  IL_0007: ldarg.0
  IL_0008: ldarg.1
  IL_0009: call Z0.bit Z0.Logix.LogicOps::xor(Z0.bit,Z0.bit)
  IL_000E: call Z0.bit Z0.Logix.LogicOps::or(Z0.bit,Z0.bit)
  IL_0013: ret
}

}
ulong comp1_scalar(ulong a, ulong b)
{
//  Id := 100664864, Name := System.UInt64 Z0.OpCodes.logixmat::comp1_scalar(System.UInt64,System.UInt64)
//  ulong comp1_scalar(ulong a, ulong b)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call System.UInt64 Z0.Logix.ScalarOps::and<System.UInt64>(System.UInt64,System.UInt64)
  IL_0007: ldarg.0
  IL_0008: ldarg.1
  IL_0009: call System.UInt64 Z0.Logix.ScalarOps::xor<System.UInt64>(System.UInt64,System.UInt64)
  IL_000E: call System.UInt64 Z0.Logix.ScalarOps::or<System.UInt64>(System.UInt64,System.UInt64)
  IL_0013: ret
}

}
Vector128<ulong> comp1_v128(Vector128<ulong> a, Vector128<ulong> b)
{
//  Id := 100664865, Name := System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.OpCodes.logixmat::comp1_v128(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
//  Vector128<ulong> comp1_v128(Vector128<ulong> a, Vector128<ulong> b)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Logix.CpuOps::and<System.UInt64>(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
  IL_0007: ldarg.0
  IL_0008: ldarg.1
  IL_0009: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Logix.CpuOps::xor<System.UInt64>(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
  IL_000E: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Logix.CpuOps::or<System.UInt64>(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
  IL_0013: ret
}

}
Vector256<ulong> comp1_v256(Vector256<ulong> a, Vector256<ulong> b)
{
//  Id := 100664866, Name := System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.OpCodes.logixmat::comp1_v256(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
//  Vector256<ulong> comp1_v256(Vector256<ulong> a, Vector256<ulong> b)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Logix.CpuOps::and<System.UInt64>(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
  IL_0007: ldarg.0
  IL_0008: ldarg.1
  IL_0009: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Logix.CpuOps::xor<System.UInt64>(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
  IL_000E: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Logix.CpuOps::or<System.UInt64>(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
  IL_0013: ret
}

}
bit comp2_logic(bit a, bit b)
{
//  Id := 100664867, Name := Z0.bit Z0.OpCodes.logixmat::comp2_logic(Z0.bit,Z0.bit)
//  bit comp2_logic(bit a, bit b)
//  Managed
{
  IL_0000: ldarg.1
  IL_0001: ldarg.0
  IL_0002: ldarg.1
  IL_0003: call Z0.bit Z0.Logix.LogicOps::and(Z0.bit,Z0.bit)
  IL_0008: ldarg.0
  IL_0009: ldarg.1
  IL_000A: call Z0.bit Z0.Logix.LogicOps::xor(Z0.bit,Z0.bit)
  IL_000F: call Z0.bit Z0.Logix.LogicOps::or(Z0.bit,Z0.bit)
  IL_0014: call Z0.bit Z0.Logix.LogicOps::nand(Z0.bit,Z0.bit)
  IL_0019: ret
}

}
ulong comp2_scalar(ulong a, ulong b)
{
//  Id := 100664868, Name := System.UInt64 Z0.OpCodes.logixmat::comp2_scalar(System.UInt64,System.UInt64)
//  ulong comp2_scalar(ulong a, ulong b)
//  Managed
{
  IL_0000: ldarg.1
  IL_0001: ldarg.0
  IL_0002: ldarg.1
  IL_0003: call System.UInt64 Z0.Logix.ScalarOps::and<System.UInt64>(System.UInt64,System.UInt64)
  IL_0008: ldarg.0
  IL_0009: ldarg.1
  IL_000A: call System.UInt64 Z0.Logix.ScalarOps::xor<System.UInt64>(System.UInt64,System.UInt64)
  IL_000F: call System.UInt64 Z0.Logix.ScalarOps::or<System.UInt64>(System.UInt64,System.UInt64)
  IL_0014: call System.UInt64 Z0.Logix.ScalarOps::nand<System.UInt64>(System.UInt64,System.UInt64)
  IL_0019: ret
}

}
Vector128<ulong> comp2_v128(Vector128<ulong> a, Vector128<ulong> b)
{
//  Id := 100664869, Name := System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.OpCodes.logixmat::comp2_v128(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
//  Vector128<ulong> comp2_v128(Vector128<ulong> a, Vector128<ulong> b)
//  Managed
{
  IL_0000: ldarg.1
  IL_0001: ldarg.0
  IL_0002: ldarg.1
  IL_0003: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Logix.CpuOps::and<System.UInt64>(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
  IL_0008: ldarg.0
  IL_0009: ldarg.1
  IL_000A: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Logix.CpuOps::xor<System.UInt64>(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
  IL_000F: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Logix.CpuOps::or<System.UInt64>(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
  IL_0014: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Logix.CpuOps::nand<System.UInt64>(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
  IL_0019: ret
}

}
Vector256<ulong> comp2_v256(Vector256<ulong> a, Vector256<ulong> b)
{
//  Id := 100664870, Name := System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.OpCodes.logixmat::comp2_v256(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
//  Vector256<ulong> comp2_v256(Vector256<ulong> a, Vector256<ulong> b)
//  Managed
{
  IL_0000: ldarg.1
  IL_0001: ldarg.0
  IL_0002: ldarg.1
  IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Logix.CpuOps::and<System.UInt64>(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
  IL_0008: ldarg.0
  IL_0009: ldarg.1
  IL_000A: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Logix.CpuOps::xor<System.UInt64>(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
  IL_000F: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Logix.CpuOps::or<System.UInt64>(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
  IL_0014: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Logix.CpuOps::nand<System.UInt64>(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
  IL_0019: ret
}

}
bit comp3_logic(bit a, bit b)
{
//  Id := 100664871, Name := Z0.bit Z0.OpCodes.logixmat::comp3_logic(Z0.bit,Z0.bit)
//  bit comp3_logic(bit a, bit b)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: ldarg.0
  IL_0003: ldarg.1
  IL_0004: call Z0.bit Z0.Logix.LogicOps::and(Z0.bit,Z0.bit)
  IL_0009: ldarg.0
  IL_000A: ldarg.1
  IL_000B: call Z0.bit Z0.Logix.LogicOps::xor(Z0.bit,Z0.bit)
  IL_0010: call Z0.bit Z0.Logix.LogicOps::or(Z0.bit,Z0.bit)
  IL_0015: call Z0.bit Z0.Logix.LogicOps::nand(Z0.bit,Z0.bit)
  IL_001A: ldarg.0
  IL_001B: ldarg.1
  IL_001C: call Z0.bit Z0.Logix.LogicOps::nor(Z0.bit,Z0.bit)
  IL_0021: ldarg.1
  IL_0022: ldarg.0
  IL_0023: call Z0.bit Z0.Logix.LogicOps::xor(Z0.bit,Z0.bit)
  IL_0028: call Z0.bit Z0.Logix.LogicOps::cnonimpl(Z0.bit,Z0.bit)
  IL_002D: call Z0.bit Z0.Logix.LogicOps::select(Z0.bit,Z0.bit,Z0.bit)
  IL_0032: ret
}

}
ulong comp3_scalar(ulong a, ulong b)
{
//  Id := 100664872, Name := System.UInt64 Z0.OpCodes.logixmat::comp3_scalar(System.UInt64,System.UInt64)
//  ulong comp3_scalar(ulong a, ulong b)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: ldarg.0
  IL_0003: ldarg.1
  IL_0004: call System.UInt64 Z0.Logix.ScalarOps::and<System.UInt64>(System.UInt64,System.UInt64)
  IL_0009: ldarg.0
  IL_000A: ldarg.1
  IL_000B: call System.UInt64 Z0.Logix.ScalarOps::xor<System.UInt64>(System.UInt64,System.UInt64)
  IL_0010: call System.UInt64 Z0.Logix.ScalarOps::or<System.UInt64>(System.UInt64,System.UInt64)
  IL_0015: call System.UInt64 Z0.Logix.ScalarOps::nand<System.UInt64>(System.UInt64,System.UInt64)
  IL_001A: ldarg.0
  IL_001B: ldarg.1
  IL_001C: call System.UInt64 Z0.Logix.ScalarOps::nor<System.UInt64>(System.UInt64,System.UInt64)
  IL_0021: ldarg.1
  IL_0022: ldarg.0
  IL_0023: call System.UInt64 Z0.Logix.ScalarOps::xor<System.UInt64>(System.UInt64,System.UInt64)
  IL_0028: call System.UInt64 Z0.Logix.ScalarOps::cnonimpl<System.UInt64>(System.UInt64,System.UInt64)
  IL_002D: call System.UInt64 Z0.Logix.ScalarOps::select<System.UInt64>(System.UInt64,System.UInt64,System.UInt64)
  IL_0032: ret
}

}
Vector128<ulong> comp3_v128(Vector128<ulong> a, Vector128<ulong> b)
{
//  Id := 100664873, Name := System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.OpCodes.logixmat::comp3_v128(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
//  Vector128<ulong> comp3_v128(Vector128<ulong> a, Vector128<ulong> b)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: ldarg.0
  IL_0003: ldarg.1
  IL_0004: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Logix.CpuOps::and<System.UInt64>(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
  IL_0009: ldarg.0
  IL_000A: ldarg.1
  IL_000B: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Logix.CpuOps::xor<System.UInt64>(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
  IL_0010: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Logix.CpuOps::or<System.UInt64>(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
  IL_0015: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Logix.CpuOps::nand<System.UInt64>(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
  IL_001A: ldarg.0
  IL_001B: ldarg.1
  IL_001C: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Logix.CpuOps::nor<System.UInt64>(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
  IL_0021: ldarg.1
  IL_0022: ldarg.0
  IL_0023: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Logix.CpuOps::xor<System.UInt64>(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
  IL_0028: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Logix.CpuOps::cnonimpl<System.UInt64>(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
  IL_002D: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Logix.CpuOps::select<System.UInt64>(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
  IL_0032: ret
}

}
Vector256<ulong> comp3_v256(Vector256<ulong> a, Vector256<ulong> b)
{
//  Id := 100664874, Name := System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.OpCodes.logixmat::comp3_v256(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
//  Vector256<ulong> comp3_v256(Vector256<ulong> a, Vector256<ulong> b)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: ldarg.0
  IL_0003: ldarg.1
  IL_0004: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Logix.CpuOps::and<System.UInt64>(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
  IL_0009: ldarg.0
  IL_000A: ldarg.1
  IL_000B: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Logix.CpuOps::xor<System.UInt64>(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
  IL_0010: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Logix.CpuOps::or<System.UInt64>(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
  IL_0015: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Logix.CpuOps::nand<System.UInt64>(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
  IL_001A: ldarg.0
  IL_001B: ldarg.1
  IL_001C: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Logix.CpuOps::nor<System.UInt64>(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
  IL_0021: ldarg.1
  IL_0022: ldarg.0
  IL_0023: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Logix.CpuOps::xor<System.UInt64>(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
  IL_0028: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Logix.CpuOps::cnonimpl<System.UInt64>(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
  IL_002D: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Logix.CpuOps::select<System.UInt64>(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
  IL_0032: ret
}

}
