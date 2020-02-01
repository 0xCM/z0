// System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.ExperimentalScenarios::InvokeBinaryImmediate_1(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
// Vector128<uint> InvokeBinaryImmediate_1(Vector128<uint> x, Vector128<uint> y)
// IL
Vector128<uint> InvokeBinaryImmediate_1(Vector128<uint> x, Vector128<uint> y)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.2
    IL_0002: ldc.i4.4
    IL_0003: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.dinx::vblend2x64(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Byte)
    IL_0008: ret
}

------------------------------------------------------------------------------------------------------------------------
// System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.ExperimentalScenarios::InvokeBinaryImmediate_2()
// Vector128<uint> InvokeBinaryImmediate_2()
// IL
Vector128<uint> InvokeBinaryImmediate_2()
{
    IL_0000: call Z0.N128 zfunc::get_n128()
    IL_0005: ldc.i4.1
    IL_0006: ldc.i4.2
    IL_0007: ldc.i4.3
    IL_0008: ldc.i4.4
    IL_0009: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.CpuVector::vparts(Z0.N128,System.UInt32,System.UInt32,System.UInt32,System.UInt32)
    IL_000E: stloc.0
    IL_000F: call Z0.N128 zfunc::get_n128()
    IL_0014: ldc.i4.1
    IL_0015: ldc.i4.2
    IL_0016: ldc.i4.3
    IL_0017: ldc.i4.4
    IL_0018: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.CpuVector::vparts(Z0.N128,System.UInt32,System.UInt32,System.UInt32,System.UInt32)
    IL_001D: stloc.1
    IL_001E: ldloc.0
    IL_001F: ldloc.1
    IL_0020: ldc.i4.4
    IL_0021: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.dinx::vblend2x64(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Byte)
    IL_0026: ret
}

------------------------------------------------------------------------------------------------------------------------
// System.UInt32 Z0.ExperimentalScenarios::xor_u32(System.UInt32,System.UInt32)
// uint xor_u32(uint a, uint b)
// IL
uint xor_u32(uint a, uint b)
{
    IL_0000: call Z0.Classifiers/Xor Z0.Classifiers::get_fXor()
    IL_0005: ldarg.0
    IL_0006: ldarg.1
    IL_0007: call System.UInt32 Z0.GX::eval<System.UInt32,Z0.Classifiers/Xor>(Z0.Classifiers/Xor,System.UInt32,System.UInt32)
    IL_000C: ret
}

------------------------------------------------------------------------------------------------------------------------
// System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.ExperimentalScenarios::vbsrl_128x32u_0(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
// Vector128<uint> vbsrl_128x32u_0(Vector128<uint> x)
// IL
Vector128<uint> vbsrl_128x32u_0(Vector128<uint> x)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.dinx::vbsrl(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Byte)
    IL_0007: ret
}

------------------------------------------------------------------------------------------------------------------------
// System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.ExperimentalScenarios::vbsrl_128x32u_2(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
// Vector128<uint> vbsrl_128x32u_2(Vector128<uint> x)
// IL
Vector128<uint> vbsrl_128x32u_2(Vector128<uint> x)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.2
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.dinx::vbsrl(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Byte)
    IL_0007: ret
}

------------------------------------------------------------------------------------------------------------------------
// System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.ExperimentalScenarios::vbsrl_128x32u_3(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
// Vector128<uint> vbsrl_128x32u_3(Vector128<uint> x)
// IL
Vector128<uint> vbsrl_128x32u_3(Vector128<uint> x)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.3
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.dinx::vbsrl(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Byte)
    IL_0007: ret
}

------------------------------------------------------------------------------------------------------------------------
// System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.ExperimentalScenarios::vbsrl_128x32u_7(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
// Vector128<uint> vbsrl_128x32u_7(Vector128<uint> x)
// IL
Vector128<uint> vbsrl_128x32u_7(Vector128<uint> x)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.7
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.dinx::vbsrl(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Byte)
    IL_0007: ret
}

------------------------------------------------------------------------------------------------------------------------
// System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.ExperimentalScenarios::vbsrl_128x32u_9(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
// Vector128<uint> vbsrl_128x32u_9(Vector128<uint> x)
// IL
Vector128<uint> vbsrl_128x32u_9(Vector128<uint> x)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.s 9
    IL_0003: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.dinx::vbsrl(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Byte)
    IL_0008: ret
}

------------------------------------------------------------------------------------------------------------------------
// System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.ExperimentalScenarios::vbsrl_128x32u_23(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
// Vector128<uint> vbsrl_128x32u_23(Vector128<uint> x)
// IL
Vector128<uint> vbsrl_128x32u_23(Vector128<uint> x)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.s 23
    IL_0003: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.dinx::vbsrl(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Byte)
    IL_0008: ret
}

------------------------------------------------------------------------------------------------------------------------
// System.UInt32 Z0.ExperimentalScenarios::opA_32u(System.UInt32,System.UInt32,System.UInt32,System.UInt32)
// uint opA_32u(uint edx, uint r8d, uint r9d, uint rsp28)
// IL
uint opA_32u(uint edx, uint r8d, uint r9d, uint rsp28)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.2
    IL_0002: mul
    IL_0003: stloc.0
    IL_0004: ldloc.0
    IL_0005: ldarg.3
    IL_0006: xor
    IL_0007: stloc.1
    IL_0008: ldloc.1
    IL_0009: ldarg.s rsp28
    IL_000B: or
    IL_000C: stloc.2
    IL_000D: ldloc.2
    IL_000E: ret
}

------------------------------------------------------------------------------------------------------------------------
// System.Byte Z0.ExperimentalScenarios::opB_8u(System.Byte,System.Byte,System.Byte,System.Byte,System.Byte)
// byte opB_8u(byte dl, byte r8b, byte r9b, byte rsp28, byte rsp30)
// IL
byte opB_8u(byte dl, byte r8b, byte r9b, byte rsp28, byte rsp30)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.2
    IL_0002: mul
    IL_0003: conv.u1
    IL_0004: stloc.0
    IL_0005: ldloc.0
    IL_0006: ldarg.3
    IL_0007: xor
    IL_0008: conv.u1
    IL_0009: stloc.0
    IL_000A: ldloc.0
    IL_000B: ldarg.s rsp28
    IL_000D: or
    IL_000E: conv.u1
    IL_000F: stloc.1
    IL_0010: ldloc.1
    IL_0011: ldarg.s rsp30
    IL_0013: and
    IL_0014: conv.u1
    IL_0015: stloc.2
    IL_0016: ldloc.2
    IL_0017: ret
}

------------------------------------------------------------------------------------------------------------------------
// System.Byte Z0.ExperimentalScenarios::opC_8u(System.Byte,System.Byte,System.Byte,System.Byte,System.Byte,System.Byte)
// byte opC_8u(byte dl, byte r8b, byte r9b, byte rsp28, byte rsp30, byte rsp38)
// IL
byte opC_8u(byte dl, byte r8b, byte r9b, byte rsp28, byte rsp30, byte rsp38)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.2
    IL_0002: mul
    IL_0003: conv.u1
    IL_0004: stloc.0
    IL_0005: ldloc.0
    IL_0006: ldarg.3
    IL_0007: xor
    IL_0008: conv.u1
    IL_0009: stloc.0
    IL_000A: ldloc.0
    IL_000B: ldarg.s rsp28
    IL_000D: or
    IL_000E: conv.u1
    IL_000F: stloc.1
    IL_0010: ldloc.1
    IL_0011: ldarg.s rsp30
    IL_0013: and
    IL_0014: conv.u1
    IL_0015: stloc.2
    IL_0016: ldloc.2
    IL_0017: ldarg.s rsp38
    IL_0019: xor
    IL_001A: conv.u1
    IL_001B: stloc.3
    IL_001C: ldloc.3
    IL_001D: ret
}

------------------------------------------------------------------------------------------------------------------------
// System.Void Z0.ExperimentalScenarios::opE_64u(System.UInt64,System.UInt64&,System.UInt64&)
// void opE_64u(ulong rdx, out ulong r8, out ulong r9)
// IL
void opE_64u(ulong rdx, out ulong r8, out ulong r9)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.1
    IL_0002: ldc.i4.5
    IL_0003: conv.i8
    IL_0004: xor
    IL_0005: stind.i8
    IL_0006: ldarg.3
    IL_0007: ldarg.1
    IL_0008: ldc.i4.7
    IL_0009: conv.i8
    IL_000A: or
    IL_000B: stind.i8
    IL_000C: ret
}

------------------------------------------------------------------------------------------------------------------------
