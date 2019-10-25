// 2019-10-25 06:35:13:391
BitMatrix<byte> alloc_8x8u()
{
    IL_0000: call Z0.BitMatrix`1<System.Byte> Z0.BitMatrix::alloc<System.Byte>()
    IL_0005: ret

}
BitMatrix<ushort> alloc_16x16u()
{
    IL_0000: call Z0.BitMatrix`1<System.UInt16> Z0.BitMatrix::alloc<System.UInt16>()
    IL_0005: ret

}
BitMatrix<uint> alloc_32x32u()
{
    IL_0000: call Z0.BitMatrix`1<System.UInt32> Z0.BitMatrix::alloc<System.UInt32>()
    IL_0005: ret

}
BitMatrix<ulong> alloc_g64x64u()
{
    IL_0000: call Z0.BitMatrix`1<System.UInt64> Z0.BitMatrix::alloc<System.UInt64>()
    IL_0005: ret

}
ref BitMatrix<byte> and_bm8x8u(in BitMatrix<byte> A, in BitMatrix<byte> B, ref BitMatrix<byte> C)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call Z0.BitMatrix`1<System.Byte>& Z0.BitMatrix::and<System.Byte>(Z0.BitMatrix`1<System.Byte>&,Z0.BitMatrix`1<System.Byte>&,Z0.BitMatrix`1<System.Byte>&)
    IL_0008: ret

}
ref BitMatrix<byte> andg_bm8x8u(in BitMatrix<byte> A, in BitMatrix<byte> B, ref BitMatrix<byte> C)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call Z0.BitMatrix`1<System.Byte>& Z0.BitMatrix::and<System.Byte>(Z0.BitMatrix`1<System.Byte>&,Z0.BitMatrix`1<System.Byte>&,Z0.BitMatrix`1<System.Byte>&)
    IL_0008: ret

}
ref BitMatrix<ushort> and_bm16x16u(in BitMatrix<ushort> A, in BitMatrix<ushort> B, ref BitMatrix<ushort> C)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call Z0.BitMatrix`1<System.UInt16>& Z0.BitMatrix::and<System.UInt16>(Z0.BitMatrix`1<System.UInt16>&,Z0.BitMatrix`1<System.UInt16>&,Z0.BitMatrix`1<System.UInt16>&)
    IL_0008: ret

}
ref BitMatrix<ushort> andg_bm16x16u(in BitMatrix<ushort> A, in BitMatrix<ushort> B, ref BitMatrix<ushort> C)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call Z0.BitMatrix`1<System.UInt16>& Z0.BitMatrix::and<System.UInt16>(Z0.BitMatrix`1<System.UInt16>&,Z0.BitMatrix`1<System.UInt16>&,Z0.BitMatrix`1<System.UInt16>&)
    IL_0008: ret

}
ref BitMatrix<uint> and_bm32x32u(in BitMatrix<uint> A, in BitMatrix<uint> B, ref BitMatrix<uint> C)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call Z0.BitMatrix`1<System.UInt32>& Z0.BitMatrix::and<System.UInt32>(Z0.BitMatrix`1<System.UInt32>&,Z0.BitMatrix`1<System.UInt32>&,Z0.BitMatrix`1<System.UInt32>&)
    IL_0008: ret

}
ref BitMatrix<uint> andg_bm32x32u(in BitMatrix<uint> A, in BitMatrix<uint> B, ref BitMatrix<uint> C)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call Z0.BitMatrix`1<System.UInt32>& Z0.BitMatrix::and<System.UInt32>(Z0.BitMatrix`1<System.UInt32>&,Z0.BitMatrix`1<System.UInt32>&,Z0.BitMatrix`1<System.UInt32>&)
    IL_0008: ret

}
ref BitMatrix<ulong> and_bm64x64u(in BitMatrix<ulong> A, in BitMatrix<ulong> B, ref BitMatrix<ulong> C)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call Z0.BitMatrix`1<System.UInt64>& Z0.BitMatrix::and<System.UInt64>(Z0.BitMatrix`1<System.UInt64>&,Z0.BitMatrix`1<System.UInt64>&,Z0.BitMatrix`1<System.UInt64>&)
    IL_0008: ret

}
ref BitMatrix<ulong> andg_bm64x64u(in BitMatrix<ulong> A, in BitMatrix<ulong> B, ref BitMatrix<ulong> C)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call Z0.BitMatrix`1<System.UInt64>& Z0.BitMatrix::and<System.UInt64>(Z0.BitMatrix`1<System.UInt64>&,Z0.BitMatrix`1<System.UInt64>&,Z0.BitMatrix`1<System.UInt64>&)
    IL_0008: ret

}
BitMatrix64 bm_from_natspan_64x64x64u(in Span<N64,ulong> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.BitMatrix64 Z0.BitMatrix64::From(Z0.Span`2<Z0.N64,System.UInt64>&)
    IL_0006: ret

}
