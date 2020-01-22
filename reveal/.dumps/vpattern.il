// 2020-01-22 01:43:39:614
// Id := 100664544, Name := Z0.VectorKind Z0.OpCodes.vpattern::vkind_128x32u()
// VectorKind:uint vkind_128x32u()
// IL
VectorKind:uint vkind_128x32u()
{
    IL_0000: ldloca.s V_0
    IL_0002: initobj Z0.N128
    IL_0008: ldloc.0
    IL_0009: ldc.i4.0
    IL_000A: call Z0.VectorKind`2<Z0.N128,System.UInt32> Z0.Classifiers::vector<Z0.N128,System.UInt32>(Z0.N128,System.UInt32)
    IL_000F: call Z0.VectorKind Z0.VectorKind`2<Z0.N128,System.UInt32>::op_Implicit(Z0.VectorKind`2<Z0.N128,System.UInt32>)
    IL_0014: ret
}

// Id := 100664545, Name := Z0.VectorKind Z0.OpCodes.vpattern::vkind_256x32u()
// VectorKind:uint vkind_256x32u()
// IL
VectorKind:uint vkind_256x32u()
{
    IL_0000: ldloca.s V_0
    IL_0002: initobj Z0.N256
    IL_0008: ldloc.0
    IL_0009: ldc.i4.0
    IL_000A: call Z0.VectorKind`2<Z0.N256,System.UInt32> Z0.Classifiers::vector<Z0.N256,System.UInt32>(Z0.N256,System.UInt32)
    IL_000F: call Z0.VectorKind Z0.VectorKind`2<Z0.N256,System.UInt32>::op_Implicit(Z0.VectorKind`2<Z0.N256,System.UInt32>)
    IL_0014: ret
}

// Id := 100664546, Name := Z0.BlockKind Z0.OpCodes.vpattern::bkind_256x32u()
// BlockKind:uint bkind_256x32u()
// IL
BlockKind:uint bkind_256x32u()
{
    IL_0000: ldloca.s V_0
    IL_0002: initobj Z0.N256
    IL_0008: ldloc.0
    IL_0009: ldc.i4.0
    IL_000A: call Z0.BlockKind`2<Z0.N256,System.UInt32> Z0.Classifiers::block<Z0.N256,System.UInt32>(Z0.N256,System.UInt32)
    IL_000F: call Z0.BlockKind Z0.BlockKind`2<Z0.N256,System.UInt32>::op_Implicit(Z0.BlockKind`2<Z0.N256,System.UInt32>)
    IL_0014: ret
}

// Id := 100664547, Name := Z0.PrimalKind Z0.OpCodes.vpattern::pkind_8u()
// PrimalKind:uint pkind_8u()
// IL
PrimalKind:uint pkind_8u()
{
    IL_0000: ldc.i4.0
    IL_0001: call Z0.PrimalKind`1<System.Byte> Z0.Classifiers::primal<System.Byte>(System.Byte)
    IL_0006: call Z0.PrimalKind Z0.PrimalKind`1<System.Byte>::op_Implicit(Z0.PrimalKind`1<System.Byte>)
    IL_000B: ret
}

// Id := 100664548, Name := Z0.PrimalKind Z0.OpCodes.vpattern::pkind_32u()
// PrimalKind:uint pkind_32u()
// IL
PrimalKind:uint pkind_32u()
{
    IL_0000: ldc.i4.0
    IL_0001: call Z0.PrimalKind`1<System.UInt32> Z0.Classifiers::primal<System.UInt32>(System.UInt32)
    IL_0006: call Z0.PrimalKind Z0.PrimalKind`1<System.UInt32>::op_Implicit(Z0.PrimalKind`1<System.UInt32>)
    IL_000B: ret
}

// Id := 100664549, Name := Z0.PrimalKind Z0.OpCodes.vpattern::pkind_32i()
// PrimalKind:uint pkind_32i()
// IL
PrimalKind:uint pkind_32i()
{
    IL_0000: ldc.i4.0
    IL_0001: call Z0.PrimalKind`1<System.Int32> Z0.Classifiers::primal<System.Int32>(System.Int32)
    IL_0006: call Z0.PrimalKind Z0.PrimalKind`1<System.Int32>::op_Implicit(Z0.PrimalKind`1<System.Int32>)
    IL_000B: ret
}

// Id := 100664550, Name := System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.OpCodes.vpattern::ones_128x8u()
// Vector128<byte> ones_128x8u()
// IL
Vector128<byte> ones_128x8u()
{
    IL_0000: call Z0.N128 zfunc::get_n128()
    IL_0005: ldc.i4.0
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.VPattern::vones<System.Byte>(Z0.N128,System.Byte)
    IL_000B: ret
}

// Id := 100664551, Name := System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.OpCodes.vpattern::ones_128x64u()
// Vector128<ulong> ones_128x64u()
// IL
Vector128<ulong> ones_128x64u()
{
    IL_0000: call Z0.N128 zfunc::get_n128()
    IL_0005: ldc.i4.0
    IL_0006: conv.i8
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.VPattern::vones<System.UInt64>(Z0.N128,System.UInt64)
    IL_000C: ret
}

// Id := 100664552, Name := System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.OpCodes.vpattern::ones_256x8u()
// Vector256<byte> ones_256x8u()
// IL
Vector256<byte> ones_256x8u()
{
    IL_0000: call Z0.N256 zfunc::get_n256()
    IL_0005: ldc.i4.0
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.VPattern::vones<System.Byte>(Z0.N256,System.Byte)
    IL_000B: ret
}

// Id := 100664553, Name := System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.OpCodes.vpattern::ones_256x64u()
// Vector256<ulong> ones_256x64u()
// IL
Vector256<ulong> ones_256x64u()
{
    IL_0000: call Z0.N256 zfunc::get_n256()
    IL_0005: ldc.i4.0
    IL_0006: conv.i8
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.VPattern::vones<System.UInt64>(Z0.N256,System.UInt64)
    IL_000C: ret
}

// Id := 100664554, Name := System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.OpCodes.vpattern::ones_256x64f()
// Vector256<double> ones_256x64f()
// IL
Vector256<double> ones_256x64f()
{
    IL_0000: call Z0.N256 zfunc::get_n256()
    IL_0005: ldc.r8 0
    IL_000E: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.VPattern::vones<System.Double>(Z0.N256,System.Double)
    IL_0013: ret
}

// Id := 100664555, Name := System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.OpCodes.vpattern::pattern_lanemerge_256x8u()
// Vector256<byte> pattern_lanemerge_256x8u()
// IL
Vector256<byte> pattern_lanemerge_256x8u()
{
    IL_0000: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.CpuVector::vlanemerge<System.Byte>()
    IL_0005: ret
}

// Id := 100664556, Name := System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.OpCodes.vpattern::pattern_lanemerge_256x16u()
// Vector256<ushort> pattern_lanemerge_256x16u()
// IL
Vector256<ushort> pattern_lanemerge_256x16u()
{
    IL_0000: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.CpuVector::vlanemerge<System.UInt16>()
    IL_0005: ret
}

// Id := 100664557, Name := System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.OpCodes.vpattern::makemask_d128x8u(System.UInt16)
// Vector128<byte> makemask_d128x8u(ushort src)
// IL
Vector128<byte> makemask_d128x8u(ushort src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.dinx::vmakemask(System.UInt16)
    IL_0006: ret
}

// Id := 100664558, Name := System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.OpCodes.vpattern::makemask_d256x8u(System.UInt32)
// Vector256<byte> makemask_d256x8u(uint src)
// IL
Vector256<byte> makemask_d256x8u(uint src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.dinx::vmakemask(System.UInt32)
    IL_0006: ret
}

// Id := 100664559, Name := System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.OpCodes.vpattern::maskmask_d128x8u_index4(System.UInt16)
// Vector128<byte> maskmask_d128x8u_index4(ushort src)
// IL
Vector128<byte> maskmask_d128x8u_index4(ushort src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.4
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.dinx::vmakemask(System.UInt16,System.Byte)
    IL_0007: ret
}

// Id := 100664560, Name := System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.OpCodes.vpattern::maskmask_d256x8u_index3(System.UInt32)
// Vector256<byte> maskmask_d256x8u_index3(uint src)
// IL
Vector256<byte> maskmask_d256x8u_index3(uint src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.3
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.dinx::vmakemask(System.UInt32,System.Byte)
    IL_0007: ret
}

// Id := 100664561, Name := System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.OpCodes.vpattern::makemask_d128x8u_FCFC()
// Vector128<byte> makemask_d128x8u_FCFC()
// IL
Vector128<byte> makemask_d128x8u_FCFC()
{
    IL_0000: ldc.i4 64764
    IL_0005: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.dinx::vmakemask(System.UInt16)
    IL_000A: ret
}

// Id := 100664562, Name := System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.OpCodes.vpattern::makemask_d256x8u_FAFAFAFA()
// Vector256<byte> makemask_d256x8u_FAFAFAFA()
// IL
Vector256<byte> makemask_d256x8u_FAFAFAFA()
{
    IL_0000: ldc.i4 -84215046
    IL_0005: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.dinx::vmakemask(System.UInt32)
    IL_000A: ret
}

