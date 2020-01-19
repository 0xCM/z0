// 2020-01-18 18:18:33:462
// Id := 100664146, Name := System.UInt32 Z0.ExperimentalScenarios::xor_u32(System.UInt32,System.UInt32)
// uint xor_u32(uint a, uint b)
// Managed
uint xor_u32(uint a, uint b)
{
    IL_0000: call Z0.OpKinds/Xor Z0.OpKinds::get_fXor()
    IL_0005: ldarg.0
    IL_0006: ldarg.1
    IL_0007: call System.UInt32 Z0.GX::eval<System.UInt32,Z0.OpKinds/Xor>(Z0.OpKinds/Xor,System.UInt32,System.UInt32)
    IL_000C: ret
}

// Id := 100664163, Name := System.Byte Z0.ExperimentalScenarios::opB_8u(System.Byte,System.Byte,System.Byte,System.Byte,System.Byte)
// byte opB_8u(byte dl, byte r8b, byte r9b, byte rsp28, byte rsp30)
// Managed
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

