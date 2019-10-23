// 2019-10-22 17:23:22:853
void bm_and_16x16u(BitMatrix16 A, BitMatrix16 B, BitMatrix16 C)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call Z0.BitMatrix16 Z0.BitMatrix::and(Z0.BitMatrix16,Z0.BitMatrix16,Z0.BitMatrix16)
    IL_0008: pop
    IL_0009: ret

}
void bm_and_32x32u(BitMatrix32 A, BitMatrix32 B, BitMatrix32 C)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call Z0.BitMatrix32 Z0.BitMatrix::and(Z0.BitMatrix32,Z0.BitMatrix32,Z0.BitMatrix32)
    IL_0008: pop
    IL_0009: ret

}
void bm_and_64x64u(BitMatrix64 A, BitMatrix64 B, BitMatrix64 C)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call Z0.BitMatrix64 Z0.BitMatrix::and(Z0.BitMatrix64,Z0.BitMatrix64,Z0.BitMatrix64)
    IL_0008: pop
    IL_0009: ret

}
BitMatrix64 bm_from_natspan_64x64x64u(in Span<N64,ulong> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.BitMatrix64 Z0.BitMatrix64::From(Z0.Span`2<Z0.N64,System.UInt64>&)
    IL_0006: ret

}
