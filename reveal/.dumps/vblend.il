// 2020-01-08 22:54:01:254
byte natcompute()
{
    IL_0000: call Z0.N2 zfunc::get_n2()
    IL_0005: call Z0.N1 zfunc::get_n1()
    IL_000A: call Z0.N0 zfunc::get_n0()
    IL_000F: call Z0.N3 zfunc::get_n3()
    IL_0014: call System.Byte Z0.OpCodes.vblend::makespec<Z0.N2,Z0.N1,Z0.N0,Z0.N3>(Z0.N2,Z0.N1,Z0.N0,Z0.N3)
    IL_0019: ret

}
Vector512<ushort> vblendp_256x16u(Vector256<ushort> x, Vector256<ushort> y, Vector256<ushort> spec)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call Z0.Vector512`1<System.UInt16> Z0.ginx::vblendp<System.UInt16>(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0008: ret

}
Vector128<ulong> vreverse_128x64u(Vector128<ulong> x)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.dinx::vreverse(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0006: ret

}
Vector128<byte> vreverse_128x8u(Vector128<byte> x)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.dinx::vreverse(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0006: ret

}
Vector256<byte> vreverse_256x8u(Vector256<byte> x)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.dinx::vreverse(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0006: ret

}
Vector128<short> vblend_128x16u_LLLLLLLL(Vector128<short> x, Vector128<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.0
    IL_0003: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.dinx::vblend(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>,Z0.Blend8x16)
    IL_0008: ret

}
Vector128<short> vblend_128x16u_RRRRRRRR(Vector128<short> x, Vector128<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4 255
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.dinx::vblend(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>,Z0.Blend8x16)
    IL_000C: ret

}
Vector128<short> vblend_128x16u_LLLLRRRR(Vector128<short> x, Vector128<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4 240
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.dinx::vblend(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>,Z0.Blend8x16)
    IL_000C: ret

}
Vector128<short> vblend_128x16u_RRRRLLLL(Vector128<short> x, Vector128<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 15
    IL_0004: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.dinx::vblend(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>,Z0.Blend8x16)
    IL_0009: ret

}
Vector128<short> vblend_128x16u_LRLRLRLR(Vector128<short> x, Vector128<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4 170
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.dinx::vblend(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>,Z0.Blend8x16)
    IL_000C: ret

}
Vector128<short> vblend_128x16u_RLRLRLRL(Vector128<short> x, Vector128<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 85
    IL_0004: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.dinx::vblend(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>,Z0.Blend8x16)
    IL_0009: ret

}
