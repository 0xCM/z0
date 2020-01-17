// 2020-01-16 19:14:09:573
// Id := 100664146, Name := System.Int32 Z0.ExperimentalScenarios::devirt1()
// int devirt1()
// Managed
int devirt1()
{
    IL_0000: call System.Int32 Z0.Devirt1::Test()
    IL_0005: ret
}

// Id := 100664147, Name := System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.ExperimentalScenarios::vbsrl_128x32u_0(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
// Vector128<uint> vbsrl_128x32u_0(Vector128<uint> x)
// Managed
Vector128<uint> vbsrl_128x32u_0(Vector128<uint> x)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.dinx::vbsrl(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Byte)
    IL_0007: ret
}

// Id := 100664156, Name := System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.ExperimentalScenarios::vbsrl_128x32u_9(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
// Vector128<uint> vbsrl_128x32u_9(Vector128<uint> x)
// Managed
Vector128<uint> vbsrl_128x32u_9(Vector128<uint> x)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.s 9
    IL_0003: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.dinx::vbsrl(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Byte)
    IL_0008: ret
}

// Id := 100664169, Name := System.Void Z0.ExperimentalScenarios::opF_64u(System.UInt64,System.UInt64&,System.UInt64&,System.UInt64&)
// void opF_64u(ulong rdx, out ulong r8, out ulong r9, out ulong rax)
// Managed
void opF_64u(ulong rdx, out ulong r8, out ulong r9, out ulong rax)
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
    IL_000C: ldarg.s rax
    IL_000E: ldarg.1
    IL_000F: ldc.i4.s 13
    IL_0011: conv.i8
    IL_0012: and
    IL_0013: stind.i8
    IL_0014: ret
}

