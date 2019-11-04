// 2019-11-04 04:06:02:600
void and_lean(ReadOnlySpan<uint> a, ReadOnlySpan<uint> b, Span<uint> c)
{
    IL_0000: call Z0.N128 zfunc::get_n128()
    IL_0005: ldarg.0
    IL_0006: call System.UInt32& modreq(System.Runtime.InteropServices.InAttribute) zfunc::head<System.UInt32>(System.ReadOnlySpan`1<System.UInt32>)
    IL_000B: call System.UInt32* Z0.As::constptr(System.UInt32&)
    IL_0010: ldarg.1
    IL_0011: call System.UInt32& modreq(System.Runtime.InteropServices.InAttribute) zfunc::head<System.UInt32>(System.ReadOnlySpan`1<System.UInt32>)
    IL_0016: call System.UInt32* Z0.As::constptr(System.UInt32&)
    IL_001B: ldarg.2
    IL_001C: call System.UInt32& zfunc::head<System.UInt32>(System.Span`1<System.UInt32>)
    IL_0021: call System.UInt32* Z0.As::refptr(System.UInt32&)
    IL_0026: call System.Void Z0.ginx::vand<System.UInt32>(Z0.N128,System.UInt32*,System.UInt32*,System.UInt32*)
    IL_002B: ret

}
void and_lean_2(ReadOnlySpan<uint> a, ReadOnlySpan<uint> b, Span<uint> c)
{
    IL_0000: call Z0.N128 zfunc::get_n128()
    IL_0005: call Z0.N2 zfunc::get_n2()
    IL_000A: ldarg.0
    IL_000B: call System.UInt32& modreq(System.Runtime.InteropServices.InAttribute) zfunc::head<System.UInt32>(System.ReadOnlySpan`1<System.UInt32>)
    IL_0010: call System.UInt32* Z0.As::constptr(System.UInt32&)
    IL_0015: ldarg.1
    IL_0016: call System.UInt32& modreq(System.Runtime.InteropServices.InAttribute) zfunc::head<System.UInt32>(System.ReadOnlySpan`1<System.UInt32>)
    IL_001B: call System.UInt32* Z0.As::constptr(System.UInt32&)
    IL_0020: ldarg.2
    IL_0021: call System.UInt32& zfunc::head<System.UInt32>(System.Span`1<System.UInt32>)
    IL_0026: call System.UInt32* Z0.As::refptr(System.UInt32&)
    IL_002B: call System.Void Z0.ginx::vand<System.UInt32>(Z0.N128,Z0.N2,System.UInt32*,System.UInt32*,System.UInt32*)
    IL_0030: ret

}
ref BitGrid<N32,N32,uint> and_awful(in BitGrid<N32,N32,uint> g1, in BitGrid<N32,N32,uint> g2, ref BitGrid<N32,N32,uint> g3)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call Z0.BitGrid`3<Z0.N32,Z0.N32,System.UInt32>& Z0.BitGrid::and<Z0.N32,Z0.N32,System.UInt32>(Z0.BitGrid`3<Z0.N32,Z0.N32,System.UInt32>&,Z0.BitGrid`3<Z0.N32,Z0.N32,System.UInt32>&,Z0.BitGrid`3<Z0.N32,Z0.N32,System.UInt32>&)
    IL_0008: ret

}
BitMatrix64 bm_from_natspan_64x64x64u(in Span<N64,ulong> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.BitMatrix64 Z0.BitMatrix64::From(Z0.Span`2<Z0.N64,System.UInt64>&)
    IL_0006: ret

}
ref BitMatrix<byte> gbm_and_8x8(in BitMatrix<byte> A, in BitMatrix<byte> B, ref BitMatrix<byte> C)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call Z0.BitMatrix`1<System.Byte>& Z0.BitMatrix::and<System.Byte>(Z0.BitMatrix`1<System.Byte>&,Z0.BitMatrix`1<System.Byte>&,Z0.BitMatrix`1<System.Byte>&)
    IL_0008: ret

}
ref BitMatrix<ushort> gbm_and_16x16(in BitMatrix<ushort> A, in BitMatrix<ushort> B, ref BitMatrix<ushort> C)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call Z0.BitMatrix`1<System.UInt16>& Z0.BitMatrix::and<System.UInt16>(Z0.BitMatrix`1<System.UInt16>&,Z0.BitMatrix`1<System.UInt16>&,Z0.BitMatrix`1<System.UInt16>&)
    IL_0008: ret

}
BitMatrix<ushort> gbm_and_16x16_alloc(in BitMatrix<ushort> A, in BitMatrix<ushort> B)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.BitMatrix`1<System.UInt16> Z0.BitMatrix::and<System.UInt16>(Z0.BitMatrix`1<System.UInt16>&,Z0.BitMatrix`1<System.UInt16>&)
    IL_0007: ret

}
ref BitMatrix16 pbm_and_16x16(in BitMatrix16 A, in BitMatrix16 B, ref BitMatrix16 C)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call Z0.BitMatrix16& Z0.BitMatrix::and(Z0.BitMatrix16&,Z0.BitMatrix16&,Z0.BitMatrix16&)
    IL_0008: ret

}
BitMatrix16 pbm_and_16x16_alloc(in BitMatrix16 A, in BitMatrix16 B)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.BitMatrix16 Z0.BitMatrix::and(Z0.BitMatrix16&,Z0.BitMatrix16&)
    IL_0007: ret

}
ref BitMatrix<uint> gbm_and_32x32(in BitMatrix<uint> A, in BitMatrix<uint> B, ref BitMatrix<uint> C)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call Z0.BitMatrix`1<System.UInt32>& Z0.BitMatrix::and<System.UInt32>(Z0.BitMatrix`1<System.UInt32>&,Z0.BitMatrix`1<System.UInt32>&,Z0.BitMatrix`1<System.UInt32>&)
    IL_0008: ret

}
ref BitMatrix<ulong> gbm_and_64x64(in BitMatrix<ulong> A, in BitMatrix<ulong> B, ref BitMatrix<ulong> C)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call Z0.BitMatrix`1<System.UInt64>& Z0.BitMatrix::and<System.UInt64>(Z0.BitMatrix`1<System.UInt64>&,Z0.BitMatrix`1<System.UInt64>&,Z0.BitMatrix`1<System.UInt64>&)
    IL_0008: ret

}
