// 2020-01-08 22:54:01:575
Vector128<byte> ones_128x8u()
{
    IL_0000: call Z0.N128 zfunc::get_n128()
    IL_0005: ldc.i4.0
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.VPattern::vones<System.Byte>(Z0.N128,System.Byte)
    IL_000B: ret

}
Vector128<ulong> ones_128x64u()
{
    IL_0000: call Z0.N128 zfunc::get_n128()
    IL_0005: ldc.i4.0
    IL_0006: conv.i8
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.VPattern::vones<System.UInt64>(Z0.N128,System.UInt64)
    IL_000C: ret

}
Vector256<byte> ones_256x8u()
{
    IL_0000: call Z0.N256 zfunc::get_n256()
    IL_0005: ldc.i4.0
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.VPattern::vones<System.Byte>(Z0.N256,System.Byte)
    IL_000B: ret

}
Vector256<ulong> ones_256x64u()
{
    IL_0000: call Z0.N256 zfunc::get_n256()
    IL_0005: ldc.i4.0
    IL_0006: conv.i8
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.VPattern::vones<System.UInt64>(Z0.N256,System.UInt64)
    IL_000C: ret

}
Vector256<double> ones_256x64f()
{
    IL_0000: call Z0.N256 zfunc::get_n256()
    IL_0005: ldc.r8 0
    IL_000E: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.VPattern::vones<System.Double>(Z0.N256,System.Double)
    IL_0013: ret

}
Vector256<byte> pattern_lanemerge_256x8u()
{
    IL_0000: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.CpuVector::vlanemerge<System.Byte>()
    IL_0005: ret

}
Vector256<ushort> pattern_lanemerge_256x16u()
{
    IL_0000: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.CpuVector::vlanemerge<System.UInt16>()
    IL_0005: ret

}
Vector128<byte> makemask_d128x8u(ushort src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.dinx::vmakemask(System.UInt16)
    IL_0006: ret

}
Vector256<byte> makemask_d256x8u(uint src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.dinx::vmakemask(System.UInt32)
    IL_0006: ret

}
Vector128<byte> maskmask_d128x8u_index4(ushort src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.4
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.dinx::vmakemask(System.UInt16,System.Byte)
    IL_0007: ret

}
Vector256<byte> maskmask_d256x8u_index3(uint src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.3
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.dinx::vmakemask(System.UInt32,System.Byte)
    IL_0007: ret

}
Vector128<byte> makemask_d128x8u_FCFC()
{
    IL_0000: ldc.i4 64764
    IL_0005: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.dinx::vmakemask(System.UInt16)
    IL_000A: ret

}
Vector256<byte> makemask_d256x8u_FAFAFAFA()
{
    IL_0000: ldc.i4 -84215046
    IL_0005: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.dinx::vmakemask(System.UInt32)
    IL_000A: ret

}
