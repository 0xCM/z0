// 2020-01-08 22:53:59:948
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
ushort opA_16u(ushort dx, ushort r8w, ushort r9w, ushort rsp28)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.2
    IL_0002: mul
    IL_0003: conv.u2
    IL_0004: stloc.0
    IL_0005: ldloc.0
    IL_0006: ldarg.3
    IL_0007: xor
    IL_0008: conv.u2
    IL_0009: stloc.1
    IL_000A: ldloc.1
    IL_000B: ldarg.s rsp28
    IL_000D: or
    IL_000E: conv.u2
    IL_000F: stloc.2
    IL_0010: ldloc.2
    IL_0011: ret

}
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
