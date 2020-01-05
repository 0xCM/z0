// 2020-01-05 15:03:45:548
Vector256<short> add_d256x16i(Vector256<short> x, Vector256<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.dinx::vadd(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0007: ret

}
Vector256<short> add_g256x16i(Vector256<short> x, Vector256<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.ginx::vadd<System.Int16>(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0007: ret

}
Vector256<short> add_o256x16i(Vector256<short> x, Vector256<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.N256 zfunc::get_n256()
    IL_0007: ldc.i4.0
    IL_0008: call Z0.VXTypes/Add256`1<System.Int16> Z0.VX::vadd<System.Int16>(Z0.N256,System.Int16)
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Pipes::apply<Z0.VXTypes/Add256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>>(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>,Z0.VXTypes/Add256`1<System.Int16>)
    IL_0012: ret

}
Vector256<short> abs_d256x16i(Vector256<short> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.dinx::vabs(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0006: ret

}
Vector256<short> abs_g256x16i(Vector256<short> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.ginx::vabs<System.Int16>(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0006: ret

}
Vector256<short> abs_o256x16i(Vector256<short> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.N256 zfunc::get_n256()
    IL_0006: ldc.i4.0
    IL_0007: call Z0.VXTypes/Abs256`1<System.Int16> Z0.VX::vabs<System.Int16>(Z0.N256,System.Int16)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Pipes::apply<Z0.VXTypes/Abs256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>>(System.Runtime.Intrinsics.Vector256`1<System.Int16>,Z0.VXTypes/Abs256`1<System.Int16>)
    IL_0011: ret

}
Vector256<short> sub_d256x16i(Vector256<short> x, Vector256<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.dinx::vsub(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0007: ret

}
Vector256<short> sub_g256x16i(Vector256<short> x, Vector256<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.ginx::vsub<System.Int16>(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0007: ret

}
Vector256<short> sub_o256x16i(Vector256<short> x, Vector256<short> y)
{
    IL_0000: call Z0.N256 zfunc::get_n256()
    IL_0005: call Z0.N256 zfunc::get_n256()
    IL_000A: ldc.i4.0
    IL_000B: call Z0.VXTypes/Sub256`1<System.Int16> Z0.VX::vsub<System.Int16>(Z0.N256,System.Int16)
    IL_0010: ldc.i4.0
    IL_0011: call Z0.OpCaptures/BinaryRep`2<Z0.VXTypes/Sub256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>> Z0.OpCapture::vbinary<Z0.VXTypes/Sub256`1<System.Int16>,System.Int16>(Z0.N256,Z0.VXTypes/Sub256`1<System.Int16>,System.Int16)
    IL_0016: stloc.0
    IL_0017: ldloca.s V_0
    IL_0019: ldarg.0
    IL_001A: ldarg.1
    IL_001B: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.OpCaptures/BinaryRep`2<Z0.VXTypes/Sub256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>>::Invoke(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0020: ret

}
ulong vcell_0_256x64u(Vector256<ulong> src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: call System.UInt64 zfunc::vcell<System.UInt64>(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Int32)
    IL_0007: ret

}
ulong vcell_1_256x64u(Vector256<ulong> src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0002: call System.UInt64 zfunc::vcell<System.UInt64>(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Int32)
    IL_0007: ret

}
ulong vcell_1_128x8u(Vector128<byte> src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0002: call System.Byte zfunc::vcell<System.Byte>(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Int32)
    IL_0007: conv.u8
    IL_0008: ret

}
ulong vcell_2_256x64u(Vector256<ulong> src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.2
    IL_0002: call System.UInt64 zfunc::vcell<System.UInt64>(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Int32)
    IL_0007: ret

}
byte vcell_3_256x64u(Vector256<byte> src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.3
    IL_0002: call System.Byte zfunc::vcell<System.Byte>(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Int32)
    IL_0007: ret

}
uint vcell_256x32u_1(Vector256<uint> src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0002: call System.UInt32 zfunc::vcell<System.UInt32>(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Int32)
    IL_0007: ret

}
uint vcell_256x32u_2(Vector256<uint> src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.2
    IL_0002: call System.UInt32 zfunc::vcell<System.UInt32>(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Int32)
    IL_0007: ret

}
Vector128<byte> swap_hl(Vector128<byte> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.ginx::vswaphl<System.Byte>(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0006: ret

}
Vector128<ulong> hi_128x64u(Vector128<ulong> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.ginx::vhi<System.UInt64>(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0006: ret

}
Vector128<byte> hi_128x8u(Vector128<byte> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.ginx::vhi<System.Byte>(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0006: ret

}
Vector128<ulong> lo_128x64u(Vector128<ulong> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.ginx::vlo<System.UInt64>(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0006: ret

}
Vector128<byte> lo_128x8u(Vector128<byte> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.ginx::vlo<System.Byte>(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0006: ret

}
void vlo_256x8u_out(Vector256<byte> src, out ulong x0, out ulong x1)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.Void Z0.dinx::vlo(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.UInt64&,System.UInt64&)
    IL_0008: ret

}
ref Pair<ulong> vlo_256x8u_pair(Vector256<byte> src, ref Pair<ulong> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Pair`1<System.UInt64>& Z0.ginx::vlo<System.Byte>(System.Runtime.Intrinsics.Vector256`1<System.Byte>,Z0.Pair`1<System.UInt64>&)
    IL_0007: ret

}
void vlo_256x64u_out(Vector256<ulong> src, out ulong x0, out ulong x1)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.Void Z0.dinx::vlo(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.UInt64&,System.UInt64&)
    IL_0008: ret

}
ref Pair<ulong> vlo_256x64u_pair(Vector256<ulong> src, ref Pair<ulong> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Pair`1<System.UInt64>& Z0.ginx::vlo<System.UInt64>(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,Z0.Pair`1<System.UInt64>&)
    IL_0007: ret

}
void vhi_256x64u_out(Vector256<ulong> src, out ulong x0, out ulong x1)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.Void Z0.ginx::vhi<System.UInt64>(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.UInt64&,System.UInt64&)
    IL_0008: ret

}
ref Pair<ulong> vhi_256x64u_pair(Vector256<ulong> src, ref Pair<ulong> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Pair`1<System.UInt64>& Z0.ginx::vhi<System.UInt64>(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,Z0.Pair`1<System.UInt64>&)
    IL_0007: ret

}
