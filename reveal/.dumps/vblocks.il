// 2020-01-05 02:30:51:974
ReadOnlySpan<short> spanconvert(Span<short> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.ReadOnlySpan`1<System.Int16> System.Span`1<System.Int16>::op_Implicit(System.Span`1<System.Int16>)
    IL_0006: ret

}
void vblock_xor_128x8u_blocks(Block128<byte> xb, Block128<byte> yb, in Block128<byte> zb)
{
    IL_0000: ldarga.s xb
    IL_0002: ldarga.s yb
    IL_0004: ldarg.2
    IL_0005: call Z0.Block128`1<System.Byte>& modreq(System.Runtime.InteropServices.InAttribute) Z0.ginx::vxor<System.Byte>(Z0.Block128`1<System.Byte>&,Z0.Block128`1<System.Byte>&,Z0.Block128`1<System.Byte>&)
    IL_000A: pop
    IL_000B: ret

}
void vblock_xor_128x16u_blocks(Block128<ushort> xb, Block128<ushort> yb, in Block128<ushort> zb)
{
    IL_0000: ldarga.s xb
    IL_0002: ldarga.s yb
    IL_0004: ldarg.2
    IL_0005: call Z0.Block128`1<System.UInt16>& modreq(System.Runtime.InteropServices.InAttribute) Z0.ginx::vxor<System.UInt16>(Z0.Block128`1<System.UInt16>&,Z0.Block128`1<System.UInt16>&,Z0.Block128`1<System.UInt16>&)
    IL_000A: pop
    IL_000B: ret

}
void vblock_xor_128x32u_blocks(Block128<uint> xb, Block128<uint> yb, in Block128<uint> zb)
{
    IL_0000: ldarga.s xb
    IL_0002: ldarga.s yb
    IL_0004: ldarg.2
    IL_0005: call Z0.Block128`1<System.UInt32>& modreq(System.Runtime.InteropServices.InAttribute) Z0.ginx::vxor<System.UInt32>(Z0.Block128`1<System.UInt32>&,Z0.Block128`1<System.UInt32>&,Z0.Block128`1<System.UInt32>&)
    IL_000A: pop
    IL_000B: ret

}
void vblock_xor_128x64u_blocks(Block128<ulong> xb, Block128<ulong> yb, in Block128<ulong> zb)
{
    IL_0000: ldarga.s xb
    IL_0002: ldarga.s yb
    IL_0004: ldarg.2
    IL_0005: call Z0.Block128`1<System.UInt64>& modreq(System.Runtime.InteropServices.InAttribute) Z0.ginx::vxor<System.UInt64>(Z0.Block128`1<System.UInt64>&,Z0.Block128`1<System.UInt64>&,Z0.Block128`1<System.UInt64>&)
    IL_000A: pop
    IL_000B: ret

}
void vblock_xor_256x8u_blocks(Block256<byte> xb, Block256<byte> yb, in Block256<byte> zb)
{
    IL_0000: ldarga.s xb
    IL_0002: ldarga.s yb
    IL_0004: ldarg.2
    IL_0005: call Z0.Block256`1<System.Byte>& modreq(System.Runtime.InteropServices.InAttribute) Z0.ginx::vxor<System.Byte>(Z0.Block256`1<System.Byte>&,Z0.Block256`1<System.Byte>&,Z0.Block256`1<System.Byte>&)
    IL_000A: pop
    IL_000B: ret

}
void vblock_xor_256x16u_blocks(Block256<ushort> xb, Block256<ushort> yb, in Block256<ushort> zb)
{
    IL_0000: ldarga.s xb
    IL_0002: ldarga.s yb
    IL_0004: ldarg.2
    IL_0005: call Z0.Block256`1<System.UInt16>& modreq(System.Runtime.InteropServices.InAttribute) Z0.ginx::vxor<System.UInt16>(Z0.Block256`1<System.UInt16>&,Z0.Block256`1<System.UInt16>&,Z0.Block256`1<System.UInt16>&)
    IL_000A: pop
    IL_000B: ret

}
void vblock_xor_256x32u_blocks(Block256<uint> xb, Block256<uint> yb, in Block256<uint> zb)
{
    IL_0000: ldarga.s xb
    IL_0002: ldarga.s yb
    IL_0004: ldarg.2
    IL_0005: call Z0.Block256`1<System.UInt32>& modreq(System.Runtime.InteropServices.InAttribute) Z0.ginx::vxor<System.UInt32>(Z0.Block256`1<System.UInt32>&,Z0.Block256`1<System.UInt32>&,Z0.Block256`1<System.UInt32>&)
    IL_000A: pop
    IL_000B: ret

}
void vblock_xor_256x64u_blocks(Block256<ulong> xb, Block256<ulong> yb, in Block256<ulong> zb)
{
    IL_0000: ldarga.s xb
    IL_0002: ldarga.s yb
    IL_0004: ldarg.2
    IL_0005: call Z0.Block256`1<System.UInt64>& modreq(System.Runtime.InteropServices.InAttribute) Z0.ginx::vxor<System.UInt64>(Z0.Block256`1<System.UInt64>&,Z0.Block256`1<System.UInt64>&,Z0.Block256`1<System.UInt64>&)
    IL_000A: pop
    IL_000B: ret

}
