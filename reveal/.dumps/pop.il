// 2020-01-05 20:14:02:374
void part64x1_byte(ulong src, Span<byte> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Void Z0.Bits::part64x1(System.UInt64,System.Span`1<System.Byte>)
    IL_0007: ret

}
void part64x1_bit(ulong src, Span<bit> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Void Z0.Bits::part64x1(System.UInt64,System.Span`1<Z0.bit>)
    IL_0007: ret

}
