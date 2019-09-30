// 2019-09-30 03:52:21:323
double to64f(sbyte src)
{
    IL_0000: ldloca.s V_0
    IL_0002: initobj System.Runtime.Intrinsics.Vector128`1<System.Double>
    IL_0008: ldloc.0
    IL_0009: ldarg.0
    IL_000A: call System.Runtime.Intrinsics.Vector128`1<System.Double> System.Runtime.Intrinsics.X86.Sse2::ConvertScalarToVector128Double(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Int32)
    IL_000F: ldc.i4.0
    IL_0010: call System.Double System.Runtime.Intrinsics.Vector128::GetElement<System.Double>(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Int32)
    IL_0015: ret

}
double to64f(byte src)
{
    IL_0000: ldloca.s V_0
    IL_0002: initobj System.Runtime.Intrinsics.Vector128`1<System.Double>
    IL_0008: ldloc.0
    IL_0009: ldarg.0
    IL_000A: call System.Runtime.Intrinsics.Vector128`1<System.Double> System.Runtime.Intrinsics.X86.Sse2::ConvertScalarToVector128Double(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Int32)
    IL_000F: ldc.i4.0
    IL_0010: call System.Double System.Runtime.Intrinsics.Vector128::GetElement<System.Double>(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Int32)
    IL_0015: ret

}
double to64f(short src)
{
    IL_0000: ldloca.s V_0
    IL_0002: initobj System.Runtime.Intrinsics.Vector128`1<System.Double>
    IL_0008: ldloc.0
    IL_0009: ldarg.0
    IL_000A: call System.Runtime.Intrinsics.Vector128`1<System.Double> System.Runtime.Intrinsics.X86.Sse2::ConvertScalarToVector128Double(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Int32)
    IL_000F: ldc.i4.0
    IL_0010: call System.Double System.Runtime.Intrinsics.Vector128::GetElement<System.Double>(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Int32)
    IL_0015: ret

}
double to64f(ushort src)
{
    IL_0000: ldloca.s V_0
    IL_0002: initobj System.Runtime.Intrinsics.Vector128`1<System.Double>
    IL_0008: ldloc.0
    IL_0009: ldarg.0
    IL_000A: call System.Runtime.Intrinsics.Vector128`1<System.Double> System.Runtime.Intrinsics.X86.Sse2::ConvertScalarToVector128Double(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Int32)
    IL_000F: ldc.i4.0
    IL_0010: call System.Double System.Runtime.Intrinsics.Vector128::GetElement<System.Double>(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Int32)
    IL_0015: ret

}
double to64f(int src)
{
    IL_0000: ldloca.s V_0
    IL_0002: initobj System.Runtime.Intrinsics.Vector128`1<System.Double>
    IL_0008: ldloc.0
    IL_0009: ldarg.0
    IL_000A: call System.Runtime.Intrinsics.Vector128`1<System.Double> System.Runtime.Intrinsics.X86.Sse2::ConvertScalarToVector128Double(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Int32)
    IL_000F: ldc.i4.0
    IL_0010: call System.Double System.Runtime.Intrinsics.Vector128::GetElement<System.Double>(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Int32)
    IL_0015: ret

}
double to64f(uint src)
{
    IL_0000: ldarg.0
    IL_0001: conv.u8
    IL_0002: conv.r8
    IL_0003: ret

}
double to64f(long src)
{
    IL_0000: ldarg.0
    IL_0001: conv.r8
    IL_0002: ret

}
double to64f(ulong src)
{
    IL_0000: ldarg.0
    IL_0001: conv.r8
    IL_0002: ret

}
double to64f(float src)
{
    IL_0000: ldarg.0
    IL_0001: conv.r8
    IL_0002: ret

}
sbyte to8i(double src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int32 Z0.Float64Convert::to32i(System.Double)
    IL_0006: conv.i1
    IL_0007: ret

}
byte to8u(double src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 Z0.Float64Convert::to32u(System.Double)
    IL_0006: conv.u1
    IL_0007: ret

}
short to16i(double src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int32 Z0.Float64Convert::to32i(System.Double)
    IL_0006: conv.i1
    IL_0007: ret

}
ushort to16u(double src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 Z0.Float64Convert::to32u(System.Double)
    IL_0006: conv.u2
    IL_0007: ret

}
int to32i(double src)
{
    IL_0000: ldarg.0
    IL_0001: conv.i4
    IL_0002: ret

}
uint to32u(double src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int64 Z0.Float64Convert::to64i(System.Double)
    IL_0006: conv.u4
    IL_0007: ret

}
long to64i(double src)
{
    IL_0000: ldarg.0
    IL_0001: conv.i8
    IL_0002: ret

}
ulong to64u(double src)
{
    IL_0000: ldarg.0
    IL_0001: conv.i8
    IL_0002: ret

}
