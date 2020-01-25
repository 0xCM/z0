; 2020-01-24 20:46:47:533
// Id := 100664103, Name := System.UInt32 Z0.ExperimentalScenarios::xor_u32(System.UInt32,System.UInt32)
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

// Id := 100664104, Name := System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.ExperimentalScenarios::vbsrl_128x32u_0(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
// Vector128<uint> vbsrl_128x32u_0(Vector128<uint> x)
// IL
Vector128<uint> vbsrl_128x32u_0(Vector128<uint> x)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.dinx::vbsrl(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Byte)
    IL_0007: ret
}

// Id := 100664105, Name := System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.ExperimentalScenarios::vbsrl_128x32u_2(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
// Vector128<uint> vbsrl_128x32u_2(Vector128<uint> x)
// IL
Vector128<uint> vbsrl_128x32u_2(Vector128<uint> x)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.2
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.dinx::vbsrl(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Byte)
    IL_0007: ret
}

// Id := 100664106, Name := System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.ExperimentalScenarios::vbsrl_128x32u_3(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
// Vector128<uint> vbsrl_128x32u_3(Vector128<uint> x)
// IL
Vector128<uint> vbsrl_128x32u_3(Vector128<uint> x)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.3
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.dinx::vbsrl(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Byte)
    IL_0007: ret
}

// Id := 100664107, Name := System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.ExperimentalScenarios::vbsrl_128x32u_4(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
// Vector128<uint> vbsrl_128x32u_4(Vector128<uint> x)
// IL
Vector128<uint> vbsrl_128x32u_4(Vector128<uint> x)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.4
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.dinx::vbsrl(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Byte)
    IL_0007: ret
}

