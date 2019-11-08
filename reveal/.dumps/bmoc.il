// 2019-11-08 02:45:47:121
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
