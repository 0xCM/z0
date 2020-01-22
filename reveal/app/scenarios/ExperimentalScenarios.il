// 2020-01-22 01:43:38:950
// Id := 100664107, Name := System.UInt32 Z0.ExperimentalScenarios::xor_u32(System.UInt32,System.UInt32)
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

// Id := 100664110, Name := System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.ExperimentalScenarios::vbsrl_128x32u_3(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
// Vector128<uint> vbsrl_128x32u_3(Vector128<uint> x)
// IL
Vector128<uint> vbsrl_128x32u_3(Vector128<uint> x)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.3
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.dinx::vbsrl(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Byte)
    IL_0007: ret
}

// Id := 100664119, Name := System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.ExperimentalScenarios::vbsrl_128x32u_200(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
// Vector128<uint> vbsrl_128x32u_200(Vector128<uint> x)
// IL
Vector128<uint> vbsrl_128x32u_200(Vector128<uint> x)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4 200
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.dinx::vbsrl(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Byte)
    IL_000B: ret
}

// Id := 100664120, Name := System.Byte Z0.ExperimentalScenarios::opA_8u(System.Byte,System.Byte,System.Byte,System.Byte)
// byte opA_8u(byte dl, byte r8b, byte r9b, byte rsp28)
// IL
byte opA_8u(byte dl, byte r8b, byte r9b, byte rsp28)
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
    IL_0011: ret
}

// Id := 100664123, Name := System.UInt64 Z0.ExperimentalScenarios::opA_64u(System.UInt64,System.UInt64,System.UInt64,System.UInt64)
// ulong opA_64u(ulong rdx, ulong r8, ulong r9, ulong rsp28)
// IL
ulong opA_64u(ulong rdx, ulong r8, ulong r9, ulong rsp28)
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

// Id := 100664127, Name := System.Void Z0.ExperimentalScenarios::opD_64u(System.UInt64,System.UInt64,System.UInt64&,System.UInt64&)
// void opD_64u(ulong rdx, ulong r8, out ulong r9, out ulong rax)
// IL
void opD_64u(ulong rdx, ulong r8, out ulong r9, out ulong rax)
{
    IL_0000: ldarg.3
    IL_0001: ldarg.1
    IL_0002: ldc.i4.5
    IL_0003: conv.i8
    IL_0004: xor
    IL_0005: stind.i8
    IL_0006: ldarg.s rax
    IL_0008: ldarg.2
    IL_0009: ldc.i4.7
    IL_000A: conv.i8
    IL_000B: or
    IL_000C: stind.i8
    IL_000D: ret
}

