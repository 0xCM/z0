// 2019-12-10 22:52:53:539
Vector128<byte> vsllv_128x8u(Vector128<byte> x, Vector128<byte> offsets)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.ginx::vsllv<System.Byte>(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0007: ret

}
Vector128<ushort> vsllv_128x16u(Vector128<ushort> x, Vector128<ushort> offsets)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.ginx::vsllv<System.UInt16>(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0007: ret

}
Vector128<uint> vsllv_128x32u(Vector128<uint> x, Vector128<uint> offsets)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.ginx::vsllv<System.UInt32>(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0007: ret

}
Vector256<byte> vsllv_256x8u(Vector256<byte> x, Vector256<byte> offsets)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.ginx::vsllv<System.Byte>(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0007: ret

}
void vsllv_256x8u_blocked(ConstBlock256<byte> x, ConstBlock256<byte> offsets, Block256<byte> dst)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s offsets
    IL_0004: ldarga.s dst
    IL_0006: call System.Void Z0.ginx::vsllv<System.Byte>(Z0.ConstBlock256`1<System.Byte>&,Z0.ConstBlock256`1<System.Byte>&,Z0.Block256`1<System.Byte>&)
    IL_000B: ret

}
Vector256<ushort> vsllv_256x16u(Vector256<ushort> x, Vector256<ushort> offsets)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.ginx::vsllv<System.UInt16>(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0007: ret

}
Vector256<uint> vsllv_256x32u(Vector256<uint> x, Vector256<uint> offsets)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.ginx::vsllv<System.UInt32>(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0007: ret

}
Vector128<byte> vsrlv_128x8u(Vector128<byte> x, Vector128<byte> offsets)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.ginx::vsrlv<System.Byte>(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0007: ret

}
Vector128<ushort> vsrlv_128x16u(Vector128<ushort> x, Vector128<ushort> offsets)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.ginx::vsrlv<System.UInt16>(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0007: ret

}
Vector128<uint> vsrlv_128x32u(Vector128<uint> x, Vector128<uint> offsets)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.ginx::vsrlv<System.UInt32>(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0007: ret

}
Vector256<byte> vsrlv_256x8u(Vector256<byte> x, Vector256<byte> offsets)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.ginx::vsrlv<System.Byte>(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0007: ret

}
Vector256<ushort> vsrlv_256x16u(Vector256<ushort> x, Vector256<ushort> offsets)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.ginx::vsrlv<System.UInt16>(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0007: ret

}
Vector256<uint> vsrlv_256x32u(Vector256<uint> x, Vector256<uint> offsets)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.ginx::vsrlv<System.UInt32>(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0007: ret

}
Vector128<byte> vsllx_128x8u(Vector128<byte> x)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.s 15
    IL_0003: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.ginx::vsllx<System.Byte>(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Byte)
    IL_0008: ret

}
Vector128<ushort> vsllx_128x16u(Vector128<ushort> x)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.s 15
    IL_0003: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.ginx::vsllx<System.UInt16>(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Byte)
    IL_0008: ret

}
Vector128<uint> vsllx_128x32u(Vector128<uint> x)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.s 15
    IL_0003: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.ginx::vsllx<System.UInt32>(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Byte)
    IL_0008: ret

}
Vector128<ulong> vsllx_128x64u(Vector128<ulong> x)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.8
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.ginx::vsllx<System.UInt64>(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Byte)
    IL_0007: ret

}
Vector256<byte> vsllx_256x8u(Vector256<byte> x)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.s 13
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.ginx::vsllx<System.Byte>(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Byte)
    IL_0008: ret

}
Vector256<ulong> vsllx_256x64u(Vector256<ulong> x)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.s 13
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.ginx::vsllx<System.UInt64>(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Byte)
    IL_0008: ret

}
Vector128<byte> vsrlx_128x8u(Vector128<byte> x)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.8
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.dinx::vsrlx(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Byte)
    IL_0007: ret

}
Vector128<ulong> vsrlx_128x64u(Vector128<ulong> x)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.8
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.ginx::vsrlx<System.UInt64>(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Byte)
    IL_0007: ret

}
Vector256<ulong> vsrlx_256x64u(Vector256<ulong> x)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.s 13
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.ginx::vsrlx<System.UInt64>(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Byte)
    IL_0008: ret

}
void vsrlx_256x64u_blocked(ConstBlock256<ulong> x, Block256<ulong> dst)
{
    IL_0000: ldarga.s x
    IL_0002: ldc.i4.s 13
    IL_0004: ldarga.s dst
    IL_0006: call System.Void Z0.ginx::vsrlx<System.UInt64>(Z0.ConstBlock256`1<System.UInt64>&,System.Byte,Z0.Block256`1<System.UInt64>&)
    IL_000B: ret

}
Vector128<ulong> vrotlx_128x64u(Vector128<ulong> x)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.s 14
    IL_0003: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.ginx::vrotlx<System.UInt64>(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Byte)
    IL_0008: ret

}
Vector256<ulong> vrotlx_256x64u(Vector256<ulong> x)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.s 14
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.ginx::vrotlx<System.UInt64>(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Byte)
    IL_0008: ret

}
Vector128<byte> rotl_g128x8u(Vector128<byte> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.ginx::vrotl<System.Byte>(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Byte)
    IL_0007: ret

}
Vector128<ulong> rotl_g128x64u(Vector128<ulong> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.ginx::vrotl<System.UInt64>(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Byte)
    IL_0007: ret

}
Vector256<byte> rotl_g256x8u(Vector256<byte> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.ginx::vrotl<System.Byte>(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Byte)
    IL_0007: ret

}
Vector256<ulong> rotl_g256x64u(Vector256<ulong> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.ginx::vrotl<System.UInt64>(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Byte)
    IL_0007: ret

}
