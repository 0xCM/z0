// 2019-10-29 02:32:28:170
BitMatrix8 bm_transpose_8x8(BitMatrix8 A, ref BitMatrix8 Z)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.BitMatrix8& Z0.BitMatrix::transpose(Z0.BitMatrix8,Z0.BitMatrix8&)
    IL_0007: ldobj Z0.BitMatrix8
    IL_000C: ret

}
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
