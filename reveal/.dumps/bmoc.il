// 2019-11-23 02:41:19:546
BitVector16 bm_16x4_col_literal(in BitMatrix16x4 A)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.BitMatrix16x4
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: ldc.i4.2
    IL_000A: call Z0.BitVector16 Z0.BitMatrix16x4::Col(System.Int32)
    IL_000F: ret

}
BitVector8 bm_8x8_col_literal(in BitMatrix8 A)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.2
    IL_0002: call Z0.BitVector8 Z0.BitMatrix8::Col(System.Int32)
    IL_0007: ret

}
BitVector16 bm_16x4_col_index(in BitMatrix16x4 A, int index)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.BitMatrix16x4
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: ldarg.1
    IL_000A: call Z0.BitVector16 Z0.BitMatrix16x4::Col(System.Int32)
    IL_000F: ret

}
void transpose_8x8_1(in BitMatrix8 A, ref BitMatrix8 Z)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.BitMatrix8& Z0.BitMatrix::transpose_v1(Z0.BitMatrix8&,Z0.BitMatrix8&)
    IL_0007: pop
    IL_0008: ret

}
void transpose_8x8_2(in BitMatrix8 A, ref BitMatrix8 Z)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Void Z0.BitMatrix::transpose_v2(Z0.BitMatrix8&,Z0.BitMatrix8&)
    IL_0007: ret

}
void transpose_8x8_3(in BitMatrix8 A, ref BitMatrix8 Z)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Void Z0.BitMatrix::transpose_v3(Z0.BitMatrix8&,Z0.BitMatrix8&)
    IL_0007: ret

}
void transpose_8x8_4(in BitMatrix8 A, ref BitMatrix8 Z)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Void Z0.BitMatrix::transpose_v4(Z0.BitMatrix8&,Z0.BitMatrix8&)
    IL_0007: ret

}
BitMatrix4x16 transpose_16x4(in BitMatrix16x4 A)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.BitMatrix16x4
    IL_0006: call Z0.BitMatrix4x16 Z0.BitMatrix::transpose(Z0.BitMatrix16x4)
    IL_000B: ret

}
BitMatrix4 pbm_and_4x4(in BitMatrix4 A, in BitMatrix4 B)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.BitMatrix4 Z0.BitMatrix::and(Z0.BitMatrix4&,Z0.BitMatrix4&)
    IL_0007: ret

}
void pbm_and_8x8(in BitMatrix8 A, in BitMatrix8 B, ref BitMatrix8 Z)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call Z0.BitMatrix8& Z0.BitMatrix::and(Z0.BitMatrix8&,Z0.BitMatrix8&,Z0.BitMatrix8&)
    IL_0008: pop
    IL_0009: ret

}
void gbm_and_8x8(in BitMatrix<byte> A, in BitMatrix<byte> B, ref BitMatrix<byte> Z)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call Z0.BitMatrix`1<System.Byte>& Z0.BitMatrix::and<System.Byte>(Z0.BitMatrix`1<System.Byte>&,Z0.BitMatrix`1<System.Byte>&,Z0.BitMatrix`1<System.Byte>&)
    IL_0008: pop
    IL_0009: ret

}
void pbm_and_16x16(in BitMatrix16 A, in BitMatrix16 B, ref BitMatrix16 Z)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call Z0.BitMatrix16& Z0.BitMatrix::and(Z0.BitMatrix16&,Z0.BitMatrix16&,Z0.BitMatrix16&)
    IL_0008: pop
    IL_0009: ret

}
void gbm_and_16x16(in BitMatrix<ushort> A, in BitMatrix<ushort> B, ref BitMatrix<ushort> Z)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call Z0.BitMatrix`1<System.UInt16>& Z0.BitMatrix::and<System.UInt16>(Z0.BitMatrix`1<System.UInt16>&,Z0.BitMatrix`1<System.UInt16>&,Z0.BitMatrix`1<System.UInt16>&)
    IL_0008: pop
    IL_0009: ret

}
void pbm_and_32x32(in BitMatrix32 A, in BitMatrix32 B, ref BitMatrix32 Z)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call Z0.BitMatrix32& Z0.BitMatrix::and(Z0.BitMatrix32&,Z0.BitMatrix32&,Z0.BitMatrix32&)
    IL_0008: pop
    IL_0009: ret

}
void gbm_and_32x32(in BitMatrix<uint> A, in BitMatrix<uint> B, ref BitMatrix<uint> Z)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call Z0.BitMatrix`1<System.UInt32>& Z0.BitMatrix::and<System.UInt32>(Z0.BitMatrix`1<System.UInt32>&,Z0.BitMatrix`1<System.UInt32>&,Z0.BitMatrix`1<System.UInt32>&)
    IL_0008: pop
    IL_0009: ret

}
void pbm_and_64x64(in BitMatrix64 A, in BitMatrix64 B, ref BitMatrix64 Z)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call Z0.BitMatrix64& Z0.BitMatrix::and(Z0.BitMatrix64&,Z0.BitMatrix64&,Z0.BitMatrix64&)
    IL_0008: pop
    IL_0009: ret

}
void gbm_and_64x64(in BitMatrix<ulong> A, in BitMatrix<ulong> B, ref BitMatrix<ulong> Z)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call Z0.BitMatrix`1<System.UInt64>& Z0.BitMatrix::and<System.UInt64>(Z0.BitMatrix`1<System.UInt64>&,Z0.BitMatrix`1<System.UInt64>&,Z0.BitMatrix`1<System.UInt64>&)
    IL_0008: pop
    IL_0009: ret

}
