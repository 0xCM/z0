// 2020-01-16 19:14:10:135
// Id := 100664313, Name := System.Void Z0.OpCodes.pop::part64x1_byte(System.UInt64,System.Span`1<System.Byte>)
// void part64x1_byte(ulong src, Span<byte> dst)
// Managed
void part64x1_byte(ulong src, Span<byte> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Void Z0.Bits::part64x1(System.UInt64,System.Span`1<System.Byte>)
    IL_0007: ret
}

// Id := 100664314, Name := System.Void Z0.OpCodes.pop::part64x1_bit(System.UInt64,System.Span`1<Z0.bit>)
// void part64x1_bit(ulong src, Span<bit> dst)
// Managed
void part64x1_bit(ulong src, Span<bit> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Void Z0.Bits::part64x1(System.UInt64,System.Span`1<Z0.bit>)
    IL_0007: ret
}

