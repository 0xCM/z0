// 2019-12-04 23:04:08:307
ulong lsb_64x8x3(ulong src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt64 Z0.BitMasks::lsb8x3<System.UInt64>(System.UInt64)
    IL_0006: ret

}
uint lsb_32x8x3(uint src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 Z0.BitMasks::lsb8x3<System.UInt32>(System.UInt32)
    IL_0006: ret

}
ushort lsb_16x8x3(ushort src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt16 Z0.BitMasks::lsb8x3<System.UInt16>(System.UInt16)
    IL_0006: ret

}
byte lsb_8x3(byte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Byte Z0.BitMasks::lsb8x3<System.Byte>(System.Byte)
    IL_0006: ret

}
ulong mask_1x64u(int exp0)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt64 Z0.Bits::mask(System.Int32)
    IL_0006: ret

}
ulong mask_loop(Span<int> exponents)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt64 Z0.Bits::mask(System.Span`1<System.Int32>)
    IL_0006: ret

}
ulong mask_2x64u(int exp0, int exp1)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.Bits::mask(System.Int32,System.Int32)
    IL_0007: ret

}
ulong mask_3x64u(int exp0, int exp1, int exp2)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.UInt64 Z0.Bits::mask(System.Int32,System.Int32,System.Int32)
    IL_0008: ret

}
ulong mask_4x64u_loop(Span<int> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt64 Z0.Bits::mask(System.Span`1<System.Int32>)
    IL_0006: ret

}
ulong mask_5x64u(int exp0, int exp1, int exp2, int exp3, int exp4)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: ldarg.3
    IL_0004: ldarg.s exp4
    IL_0006: call System.UInt64 Z0.Bits::mask(System.Int32,System.Int32,System.Int32,System.Int32,System.Int32)
    IL_000B: ret

}
ulong mask_5x64u_loop(Span<int> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt64 Z0.Bits::mask(System.Span`1<System.Int32>)
    IL_0006: ret

}
ulong mask_6x64u(int exp0, int exp1, int exp2, int exp3, int exp4, int exp5)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: ldarg.3
    IL_0004: ldarg.s exp4
    IL_0006: ldarg.s exp5
    IL_0008: call System.UInt64 Z0.Bits::mask(System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32)
    IL_000D: ret

}
ulong mask_7x64u(int exp0, int exp1, int exp2, int exp3, int exp4, int exp5, int exp6)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: ldarg.3
    IL_0004: ldarg.s exp4
    IL_0006: ldarg.s exp5
    IL_0008: ldarg.s exp6
    IL_000A: call System.UInt64 Z0.Bits::mask(System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32)
    IL_000F: ret

}
void set_bit(ref uint src, byte pos, bit state)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.UInt32& Z0.gbits::set<System.UInt32>(System.UInt32&,System.Byte,Z0.bit)
    IL_0008: pop
    IL_0009: ret

}
void set_bit_on(ref uint src, byte pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.bit::get_On()
    IL_0007: call System.UInt32& Z0.gbits::set<System.UInt32>(System.UInt32&,System.Byte,Z0.bit)
    IL_000C: pop
    IL_000D: ret

}
void set_bit_off(ref uint src, byte pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.bit::get_Off()
    IL_0007: call System.UInt32& Z0.gbits::set<System.UInt32>(System.UInt32&,System.Byte,Z0.bit)
    IL_000C: pop
    IL_000D: ret

}
