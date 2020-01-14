// 2020-01-13 21:43:22:537
VectorKind:uint vkind_128x32u()
{
//  Id := 100664784, Name := Z0.VectorKind Z0.OpCodes.vpattern::vkind_128x32u()
//  VectorKind:uint vkind_128x32u()
//  Managed
{
  IL_0000: ldloca.s V_0
  IL_0002: initobj Z0.N128
  IL_0008: ldloc.0
  IL_0009: ldc.i4.0
  IL_000A: call Z0.VectorKind`2<Z0.N128,System.UInt32> Z0.Classifiers::vector<Z0.N128,System.UInt32>(Z0.N128,System.UInt32)
  IL_000F: call Z0.VectorKind Z0.VectorKind`2<Z0.N128,System.UInt32>::op_Implicit(Z0.VectorKind`2<Z0.N128,System.UInt32>)
  IL_0014: ret
}

}
VectorKind:uint vkind_256x32u()
{
//  Id := 100664785, Name := Z0.VectorKind Z0.OpCodes.vpattern::vkind_256x32u()
//  VectorKind:uint vkind_256x32u()
//  Managed
{
  IL_0000: ldloca.s V_0
  IL_0002: initobj Z0.N256
  IL_0008: ldloc.0
  IL_0009: ldc.i4.0
  IL_000A: call Z0.VectorKind`2<Z0.N256,System.UInt32> Z0.Classifiers::vector<Z0.N256,System.UInt32>(Z0.N256,System.UInt32)
  IL_000F: call Z0.VectorKind Z0.VectorKind`2<Z0.N256,System.UInt32>::op_Implicit(Z0.VectorKind`2<Z0.N256,System.UInt32>)
  IL_0014: ret
}

}
BlockKind:uint bkind_256x32u()
{
//  Id := 100664786, Name := Z0.BlockKind Z0.OpCodes.vpattern::bkind_256x32u()
//  BlockKind:uint bkind_256x32u()
//  Managed
{
  IL_0000: ldloca.s V_0
  IL_0002: initobj Z0.N256
  IL_0008: ldloc.0
  IL_0009: ldc.i4.0
  IL_000A: call Z0.BlockKind`2<Z0.N256,System.UInt32> Z0.Classifiers::block<Z0.N256,System.UInt32>(Z0.N256,System.UInt32)
  IL_000F: call Z0.BlockKind Z0.BlockKind`2<Z0.N256,System.UInt32>::op_Implicit(Z0.BlockKind`2<Z0.N256,System.UInt32>)
  IL_0014: ret
}

}
PrimalKind:uint pkind_8u()
{
//  Id := 100664787, Name := Z0.PrimalKind Z0.OpCodes.vpattern::pkind_8u()
//  PrimalKind:uint pkind_8u()
//  Managed
{
  IL_0000: ldc.i4.0
  IL_0001: call Z0.PrimalKind`1<System.Byte> Z0.Classifiers::primal<System.Byte>(System.Byte)
  IL_0006: call Z0.PrimalKind Z0.PrimalKind`1<System.Byte>::op_Implicit(Z0.PrimalKind`1<System.Byte>)
  IL_000B: ret
}

}
PrimalKind:uint pkind_32u()
{
//  Id := 100664788, Name := Z0.PrimalKind Z0.OpCodes.vpattern::pkind_32u()
//  PrimalKind:uint pkind_32u()
//  Managed
{
  IL_0000: ldc.i4.0
  IL_0001: call Z0.PrimalKind`1<System.UInt32> Z0.Classifiers::primal<System.UInt32>(System.UInt32)
  IL_0006: call Z0.PrimalKind Z0.PrimalKind`1<System.UInt32>::op_Implicit(Z0.PrimalKind`1<System.UInt32>)
  IL_000B: ret
}

}
PrimalKind:uint pkind_32i()
{
//  Id := 100664789, Name := Z0.PrimalKind Z0.OpCodes.vpattern::pkind_32i()
//  PrimalKind:uint pkind_32i()
//  Managed
{
  IL_0000: ldc.i4.0
  IL_0001: call Z0.PrimalKind`1<System.Int32> Z0.Classifiers::primal<System.Int32>(System.Int32)
  IL_0006: call Z0.PrimalKind Z0.PrimalKind`1<System.Int32>::op_Implicit(Z0.PrimalKind`1<System.Int32>)
  IL_000B: ret
}

}
Vector128<byte> ones_128x8u()
{
//  Id := 100664790, Name := System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.OpCodes.vpattern::ones_128x8u()
//  Vector128<byte> ones_128x8u()
//  Managed
{
  IL_0000: call Z0.N128 zfunc::get_n128()
  IL_0005: ldc.i4.0
  IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.VPattern::vones<System.Byte>(Z0.N128,System.Byte)
  IL_000B: ret
}

}
Vector128<ulong> ones_128x64u()
{
//  Id := 100664791, Name := System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.OpCodes.vpattern::ones_128x64u()
//  Vector128<ulong> ones_128x64u()
//  Managed
{
  IL_0000: call Z0.N128 zfunc::get_n128()
  IL_0005: ldc.i4.0
  IL_0006: conv.i8
  IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.VPattern::vones<System.UInt64>(Z0.N128,System.UInt64)
  IL_000C: ret
}

}
Vector256<byte> ones_256x8u()
{
//  Id := 100664792, Name := System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.OpCodes.vpattern::ones_256x8u()
//  Vector256<byte> ones_256x8u()
//  Managed
{
  IL_0000: call Z0.N256 zfunc::get_n256()
  IL_0005: ldc.i4.0
  IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.VPattern::vones<System.Byte>(Z0.N256,System.Byte)
  IL_000B: ret
}

}
Vector256<ulong> ones_256x64u()
{
//  Id := 100664793, Name := System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.OpCodes.vpattern::ones_256x64u()
//  Vector256<ulong> ones_256x64u()
//  Managed
{
  IL_0000: call Z0.N256 zfunc::get_n256()
  IL_0005: ldc.i4.0
  IL_0006: conv.i8
  IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.VPattern::vones<System.UInt64>(Z0.N256,System.UInt64)
  IL_000C: ret
}

}
Vector256<double> ones_256x64f()
{
//  Id := 100664794, Name := System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.OpCodes.vpattern::ones_256x64f()
//  Vector256<double> ones_256x64f()
//  Managed
{
  IL_0000: call Z0.N256 zfunc::get_n256()
  IL_0005: ldc.r8 0
  IL_000E: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.VPattern::vones<System.Double>(Z0.N256,System.Double)
  IL_0013: ret
}

}
Vector256<byte> pattern_lanemerge_256x8u()
{
//  Id := 100664795, Name := System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.OpCodes.vpattern::pattern_lanemerge_256x8u()
//  Vector256<byte> pattern_lanemerge_256x8u()
//  Managed
{
  IL_0000: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.CpuVector::vlanemerge<System.Byte>()
  IL_0005: ret
}

}
Vector256<ushort> pattern_lanemerge_256x16u()
{
//  Id := 100664796, Name := System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.OpCodes.vpattern::pattern_lanemerge_256x16u()
//  Vector256<ushort> pattern_lanemerge_256x16u()
//  Managed
{
  IL_0000: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.CpuVector::vlanemerge<System.UInt16>()
  IL_0005: ret
}

}
Vector128<byte> makemask_d128x8u(ushort src)
{
//  Id := 100664797, Name := System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.OpCodes.vpattern::makemask_d128x8u(System.UInt16)
//  Vector128<byte> makemask_d128x8u(ushort src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.dinx::vmakemask(System.UInt16)
  IL_0006: ret
}

}
Vector256<byte> makemask_d256x8u(uint src)
{
//  Id := 100664798, Name := System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.OpCodes.vpattern::makemask_d256x8u(System.UInt32)
//  Vector256<byte> makemask_d256x8u(uint src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.dinx::vmakemask(System.UInt32)
  IL_0006: ret
}

}
Vector128<byte> maskmask_d128x8u_index4(ushort src)
{
//  Id := 100664799, Name := System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.OpCodes.vpattern::maskmask_d128x8u_index4(System.UInt16)
//  Vector128<byte> maskmask_d128x8u_index4(ushort src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldc.i4.4
  IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.dinx::vmakemask(System.UInt16,System.Byte)
  IL_0007: ret
}

}
Vector256<byte> maskmask_d256x8u_index3(uint src)
{
//  Id := 100664800, Name := System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.OpCodes.vpattern::maskmask_d256x8u_index3(System.UInt32)
//  Vector256<byte> maskmask_d256x8u_index3(uint src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldc.i4.3
  IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.dinx::vmakemask(System.UInt32,System.Byte)
  IL_0007: ret
}

}
Vector128<byte> makemask_d128x8u_FCFC()
{
//  Id := 100664801, Name := System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.OpCodes.vpattern::makemask_d128x8u_FCFC()
//  Vector128<byte> makemask_d128x8u_FCFC()
//  Managed
{
  IL_0000: ldc.i4 64764
  IL_0005: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.dinx::vmakemask(System.UInt16)
  IL_000A: ret
}

}
Vector256<byte> makemask_d256x8u_FAFAFAFA()
{
//  Id := 100664802, Name := System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.OpCodes.vpattern::makemask_d256x8u_FAFAFAFA()
//  Vector256<byte> makemask_d256x8u_FAFAFAFA()
//  Managed
{
  IL_0000: ldc.i4 -84215046
  IL_0005: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.dinx::vmakemask(System.UInt32)
  IL_000A: ret
}

}
