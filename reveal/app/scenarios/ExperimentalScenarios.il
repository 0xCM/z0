// 2020-01-20 01:59:20:627
// Id := 100664106, Name := System.UInt32 Z0.ExperimentalScenarios::xor_u32(System.UInt32,System.UInt32)
// uint xor_u32(uint a, uint b)
// IL
uint xor_u32(uint a, uint b)
{
    IL_0000: call Z0.OpKinds/Xor Z0.OpKinds::get_fXor()
    IL_0005: ldarg.0
    IL_0006: ldarg.1
    IL_0007: call System.UInt32 Z0.GX::eval<System.UInt32,Z0.OpKinds/Xor>(Z0.OpKinds/Xor,System.UInt32,System.UInt32)
    IL_000C: ret
}

// Id := 100664107, Name := System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.ExperimentalScenarios::vbsrl_128x32u_0(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
// Vector128<uint> vbsrl_128x32u_0(Vector128<uint> x)
// IL
Vector128<uint> vbsrl_128x32u_0(Vector128<uint> x)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.dinx::vbsrl(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Byte)
    IL_0007: ret
}

// Id := 100664108, Name := System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.ExperimentalScenarios::vbsrl_128x32u_2(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
// Vector128<uint> vbsrl_128x32u_2(Vector128<uint> x)
// IL
Vector128<uint> vbsrl_128x32u_2(Vector128<uint> x)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.2
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.dinx::vbsrl(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Byte)
    IL_0007: ret
}

// Id := 100664111, Name := System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.ExperimentalScenarios::vbsrl_128x32u_5(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
// Vector128<uint> vbsrl_128x32u_5(Vector128<uint> x)
// IL
Vector128<uint> vbsrl_128x32u_5(Vector128<uint> x)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.5
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.dinx::vbsrl(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Byte)
    IL_0007: ret
}

// Id := 100664112, Name := System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.ExperimentalScenarios::vbsrl_128x32u_6(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
// Vector128<uint> vbsrl_128x32u_6(Vector128<uint> x)
// IL
Vector128<uint> vbsrl_128x32u_6(Vector128<uint> x)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.6
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.dinx::vbsrl(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Byte)
    IL_0007: ret
}

// Id := 100664113, Name := System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.ExperimentalScenarios::vbsrl_128x32u_7(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
// Vector128<uint> vbsrl_128x32u_7(Vector128<uint> x)
// IL
Vector128<uint> vbsrl_128x32u_7(Vector128<uint> x)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.7
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.dinx::vbsrl(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Byte)
    IL_0007: ret
}

// Id := 100664116, Name := System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.ExperimentalScenarios::vbsrl_128x32u_11(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
// Vector128<uint> vbsrl_128x32u_11(Vector128<uint> x)
// IL
Vector128<uint> vbsrl_128x32u_11(Vector128<uint> x)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.s 11
    IL_0003: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.dinx::vbsrl(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Byte)
    IL_0008: ret
}

// Id := 100664118, Name := System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.ExperimentalScenarios::vbsrl_128x32u_200(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
// Vector128<uint> vbsrl_128x32u_200(Vector128<uint> x)
// IL
Vector128<uint> vbsrl_128x32u_200(Vector128<uint> x)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4 200
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.dinx::vbsrl(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Byte)
    IL_000B: ret
}

// Id := 100664121, Name := System.UInt32 Z0.ExperimentalScenarios::opA_32u(System.UInt32,System.UInt32,System.UInt32,System.UInt32)
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

// Id := 100664124, Name := System.Byte Z0.ExperimentalScenarios::opC_8u(System.Byte,System.Byte,System.Byte,System.Byte,System.Byte,System.Byte)
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

// Id := 100664125, Name := System.Void Z0.ExperimentalScenarios::opD_8u(System.Byte,System.Byte,System.Byte&,System.Byte&)
// void opD_8u(byte dl, byte r8b, out byte r9, out byte rdx)
// IL
void opD_8u(byte dl, byte r8b, out byte r9, out byte rdx)
{
    IL_0000: ldarg.3
    IL_0001: ldarg.1
    IL_0002: ldc.i4.5
    IL_0003: xor
    IL_0004: conv.u1
    IL_0005: stind.i1
    IL_0006: ldarg.s rdx
    IL_0008: ldarg.2
    IL_0009: ldc.i4.7
    IL_000A: or
    IL_000B: conv.u1
    IL_000C: stind.i1
    IL_000D: ret
}

// Id := 100664127, Name := System.Void Z0.ExperimentalScenarios::opE_64u(System.UInt64,System.UInt64&,System.UInt64&)
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

