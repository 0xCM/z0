// 2020-01-22 01:44:40:115
// Id := 100664635, Name := System.UInt64 Z0.OpCodes.nats::nat_add()
// ulong nat_add()
// IL
ulong nat_add()
{
    IL_0000: call Z0.N12 zfunc::get_n12()
    IL_0005: call Z0.N16 zfunc::get_n16()
    IL_000A: call System.UInt64 Z0.NatMath2::add<Z0.N12,Z0.N16>(Z0.N12,Z0.N16)
    IL_000F: ret
}

// Id := 100664636, Name := System.UInt64 Z0.OpCodes.nats::nat_sub()
// ulong nat_sub()
// IL
ulong nat_sub()
{
    IL_0000: call Z0.N0 zfunc::get_n0()
    IL_0005: call Z0.N256 zfunc::get_n256()
    IL_000A: call System.UInt64 Z0.NatMath2::sub<Z0.N0,Z0.N256>(Z0.N0,Z0.N256)
    IL_000F: ret
}

// Id := 100664637, Name := System.UInt64 Z0.OpCodes.nats::nat_mul()
// ulong nat_mul()
// IL
ulong nat_mul()
{
    IL_0000: call Z0.N12 zfunc::get_n12()
    IL_0005: call Z0.N16 zfunc::get_n16()
    IL_000A: call System.UInt64 Z0.NatMath2::mul<Z0.N12,Z0.N16>(Z0.N12,Z0.N16)
    IL_000F: ret
}

// Id := 100664638, Name := System.UInt64 Z0.OpCodes.nats::nat_div()
// ulong nat_div()
// IL
ulong nat_div()
{
    IL_0000: call Z0.N50 zfunc::get_n50()
    IL_0005: call Z0.N5 zfunc::get_n5()
    IL_000A: call System.UInt64 Z0.NatMath2::div<Z0.N50,Z0.N5>(Z0.N50,Z0.N5)
    IL_000F: ret
}

// Id := 100664639, Name := System.UInt64 Z0.OpCodes.nats::nat_mod()
// ulong nat_mod()
// IL
ulong nat_mod()
{
    IL_0000: call Z0.N50 zfunc::get_n51()
    IL_0005: call Z0.N3 zfunc::get_n3()
    IL_000A: call System.UInt64 Z0.NatMath2::mod<Z0.N50,Z0.N3>(Z0.N50,Z0.N3)
    IL_000F: ret
}

// Id := 100664640, Name := System.UInt64 Z0.OpCodes.nats::digits_encode_1_0()
// ulong digits_encode_1_0()
// IL
ulong digits_encode_1_0()
{
    IL_0000: ldc.i4.s 48
    IL_0002: call System.UInt64 Z0.Digital::digit(System.Char)
    IL_0007: ret
}

// Id := 100664641, Name := System.UInt64 Z0.OpCodes.nats::digits_encode_1()
// ulong digits_encode_1()
// IL
ulong digits_encode_1()
{
    IL_0000: ldc.i4.s 49
    IL_0002: call System.UInt64 Z0.Digital::digit(System.Char)
    IL_0007: ret
}

// Id := 100664642, Name := System.UInt64 Z0.OpCodes.nats::digits_encode_2()
// ulong digits_encode_2()
// IL
ulong digits_encode_2()
{
    IL_0000: ldc.i4.s 50
    IL_0002: call System.UInt64 Z0.Digital::digit(System.Char)
    IL_0007: ret
}

// Id := 100664643, Name := System.UInt64 Z0.OpCodes.nats::digits_encode_3()
// ulong digits_encode_3()
// IL
ulong digits_encode_3()
{
    IL_0000: ldc.i4.s 51
    IL_0002: call System.UInt64 Z0.Digital::digit(System.Char)
    IL_0007: ret
}

// Id := 100664644, Name := System.UInt64 Z0.OpCodes.nats::digits_encode_10()
// ulong digits_encode_10()
// IL
ulong digits_encode_10()
{
    IL_0000: ldc.i4.s 49
    IL_0002: ldc.i4.s 48
    IL_0004: call System.UInt64 Z0.Digital::digits(System.Char,System.Char)
    IL_0009: ret
}

// Id := 100664645, Name := System.UInt64 Z0.OpCodes.nats::digits_encode_210()
// ulong digits_encode_210()
// IL
ulong digits_encode_210()
{
    IL_0000: ldc.i4.s 50
    IL_0002: ldc.i4.s 49
    IL_0004: ldc.i4.s 48
    IL_0006: call System.UInt64 Z0.Digital::digits(System.Char,System.Char,System.Char)
    IL_000B: ret
}

// Id := 100664646, Name := System.UInt64 Z0.OpCodes.nats::digits_encode_3210()
// ulong digits_encode_3210()
// IL
ulong digits_encode_3210()
{
    IL_0000: ldc.i4.s 51
    IL_0002: ldc.i4.s 50
    IL_0004: ldc.i4.s 49
    IL_0006: ldc.i4.s 48
    IL_0008: call System.UInt64 Z0.Digital::digits(System.Char,System.Char,System.Char,System.Char)
    IL_000D: ret
}

// Id := 100664647, Name := System.UInt64 Z0.OpCodes.nats::digits_encode_43210()
// ulong digits_encode_43210()
// IL
ulong digits_encode_43210()
{
    IL_0000: ldc.i4.s 52
    IL_0002: ldc.i4.s 51
    IL_0004: ldc.i4.s 50
    IL_0006: ldc.i4.s 49
    IL_0008: ldc.i4.s 48
    IL_000A: call System.UInt64 Z0.Digital::digits(System.Char,System.Char,System.Char,System.Char,System.Char)
    IL_000F: ret
}

// Id := 100664648, Name := System.UInt64 Z0.OpCodes.nats::digits_encode_76543210()
// ulong digits_encode_76543210()
// IL
ulong digits_encode_76543210()
{
    IL_0000: ldc.i4.s 55
    IL_0002: ldc.i4.s 54
    IL_0004: ldc.i4.s 53
    IL_0006: ldc.i4.s 52
    IL_0008: ldc.i4.s 51
    IL_000A: ldc.i4.s 50
    IL_000C: ldc.i4.s 49
    IL_000E: ldc.i4.s 48
    IL_0010: call System.UInt64 Z0.Digital::digits(System.Char,System.Char,System.Char,System.Char,System.Char,System.Char,System.Char,System.Char)
    IL_0015: ret
}

// Id := 100664649, Name := System.UInt64 Z0.OpCodes.nats::digit_extract_9()
// ulong digit_extract_9()
// IL
ulong digit_extract_9()
{
    IL_0000: ldc.i4 22601
    IL_0005: conv.i8
    IL_0006: ldc.i4.0
    IL_0007: call System.UInt64 Z0.Digital::digit(System.UInt64,System.Int32)
    IL_000C: ret
}

// Id := 100664650, Name := System.UInt64 Z0.OpCodes.nats::digit_extract_4()
// ulong digit_extract_4()
// IL
ulong digit_extract_4()
{
    IL_0000: ldc.i4 22601
    IL_0005: conv.i8
    IL_0006: ldc.i4.1
    IL_0007: call System.UInt64 Z0.Digital::digit(System.UInt64,System.Int32)
    IL_000C: ret
}

// Id := 100664651, Name := System.UInt64 Z0.OpCodes.nats::digit_extract_8()
// ulong digit_extract_8()
// IL
ulong digit_extract_8()
{
    IL_0000: ldc.i4 22601
    IL_0005: conv.i8
    IL_0006: ldc.i4.2
    IL_0007: call System.UInt64 Z0.Digital::digit(System.UInt64,System.Int32)
    IL_000C: ret
}

// Id := 100664652, Name := System.UInt64 Z0.OpCodes.nats::digit_extract_5()
// ulong digit_extract_5()
// IL
ulong digit_extract_5()
{
    IL_0000: ldc.i4 22601
    IL_0005: conv.i8
    IL_0006: ldc.i4.3
    IL_0007: call System.UInt64 Z0.Digital::digit(System.UInt64,System.Int32)
    IL_000C: ret
}

// Id := 100664653, Name := System.Void Z0.OpCodes.nats::digits_extract_5849(System.Byte&,System.Byte&,System.Byte&,System.Byte&)
// void digits_extract_5849(out byte d3, out byte d2, out byte d1, out byte d0)
// IL
void digits_extract_5849(out byte d3, out byte d2, out byte d1, out byte d0)
{
    IL_0000: ldc.i4 22601
    IL_0005: conv.i8
    IL_0006: ldarg.0
    IL_0007: ldarg.1
    IL_0008: ldarg.2
    IL_0009: ldarg.3
    IL_000A: call System.Void Z0.Digital::lo(System.UInt64,System.Byte&,System.Byte&,System.Byte&,System.Byte&)
    IL_000F: ret
}

// Id := 100664654, Name := System.Void Z0.OpCodes.nats::digits_extract_5489_ref(System.Byte&)
// void digits_extract_5489_ref(ref byte dst)
// IL
void digits_extract_5489_ref(ref byte dst)
{
    IL_0000: ldc.i4 22601
    IL_0005: conv.i8
    IL_0006: call Z0.N4 zfunc::get_n4()
    IL_000B: ldarg.0
    IL_000C: call System.Void Z0.Digital::digits(System.UInt64,Z0.N4,System.Byte&)
    IL_0011: ret
}

// Id := 100664655, Name := System.Void Z0.OpCodes.nats::digits_extract_80352178(System.Byte&,System.Byte&,System.Byte&,System.Byte&,System.Byte&,System.Byte&,System.Byte&,System.Byte&)
// void digits_extract_80352178(out byte d7, out byte d6, out byte d5, out byte d4, out byte d3, out byte d2, out byte d1, out byte d0)
// IL
void digits_extract_80352178(out byte d7, out byte d6, out byte d5, out byte d4, out byte d3, out byte d2, out byte d1, out byte d0)
{
    IL_0000: ldc.i4 -2144001672
    IL_0005: conv.u8
    IL_0006: ldarg.s d3
    IL_0008: ldarg.s d2
    IL_000A: ldarg.s d1
    IL_000C: ldarg.s d0
    IL_000E: call System.Void Z0.Digital::lo(System.UInt64,System.Byte&,System.Byte&,System.Byte&,System.Byte&)
    IL_0013: ldc.i4 -2144001672
    IL_0018: conv.u8
    IL_0019: ldarg.0
    IL_001A: ldarg.1
    IL_001B: ldarg.2
    IL_001C: ldarg.3
    IL_001D: call System.Void Z0.Digital::hi(System.UInt64,System.Byte&,System.Byte&,System.Byte&,System.Byte&)
    IL_0022: ret
}

// Id := 100664656, Name := System.Void Z0.OpCodes.nats::chars_5489(System.Char&,System.Char&,System.Char&,System.Char&)
// void chars_5489(out Char c3, out Char c2, out Char c1, out Char c0)
// IL
void chars_5489(out Char c3, out Char c2, out Char c1, out Char c0)
{
    IL_0000: ldc.i4 21641
    IL_0005: ldarg.0
    IL_0006: ldarg.1
    IL_0007: ldarg.2
    IL_0008: ldarg.3
    IL_0009: call System.Void Z0.Digital::chars(System.UInt32,System.Char&,System.Char&,System.Char&,System.Char&)
    IL_000E: ret
}

// Id := 100664657, Name := System.Void Z0.OpCodes.nats::chars_80352178(System.Char&,System.Char&,System.Char&,System.Char&,System.Char&,System.Char&,System.Char&,System.Char&)
// void chars_80352178(out Char c7, out Char c6, out Char c5, out Char c4, out Char c3, out Char c2, out Char c1, out Char c0)
// IL
void chars_80352178(out Char c7, out Char c6, out Char c5, out Char c4, out Char c3, out Char c2, out Char c1, out Char c0)
{
    IL_0000: ldc.i4 -2144001672
    IL_0005: conv.u8
    IL_0006: ldarg.0
    IL_0007: ldarg.1
    IL_0008: ldarg.2
    IL_0009: ldarg.3
    IL_000A: ldarg.s c3
    IL_000C: ldarg.s c2
    IL_000E: ldarg.s c1
    IL_0010: ldarg.s c0
    IL_0012: call System.Void Z0.Digital::chars(System.UInt64,System.Char&,System.Char&,System.Char&,System.Char&,System.Char&,System.Char&,System.Char&,System.Char&)
    IL_0017: ret
}

// Id := 100664658, Name := System.ReadOnlySpan`1<System.Char> Z0.OpCodes.nats::charspan_5489()
// ReadOnlySpan<Char> charspan_5489()
// IL
ReadOnlySpan<Char> charspan_5489()
{
    IL_0000: ldc.i4 21641
    IL_0005: call System.ReadOnlySpan`1<System.Char> Z0.Digital::chars(System.UInt32)
    IL_000A: ret
}

// Id := 100664659, Name := System.Char Z0.OpCodes.nats::digit_decode_0()
// Char digit_decode_0()
// IL
Char digit_decode_0()
{
    IL_0000: ldc.i4.0
    IL_0001: conv.i8
    IL_0002: call System.Char Z0.Digital::character(System.UInt64)
    IL_0007: ret
}

// Id := 100664660, Name := System.Char Z0.OpCodes.nats::digit_decode_1()
// Char digit_decode_1()
// IL
Char digit_decode_1()
{
    IL_0000: ldc.i4.1
    IL_0001: conv.i8
    IL_0002: call System.Char Z0.Digital::character(System.UInt64)
    IL_0007: ret
}

// Id := 100664661, Name := System.Char Z0.OpCodes.nats::digit_decode_2()
// Char digit_decode_2()
// IL
Char digit_decode_2()
{
    IL_0000: ldc.i4.2
    IL_0001: conv.i8
    IL_0002: call System.Char Z0.Digital::character(System.UInt64)
    IL_0007: ret
}

// Id := 100664662, Name := System.Char Z0.OpCodes.nats::digit_decode_3()
// Char digit_decode_3()
// IL
Char digit_decode_3()
{
    IL_0000: ldc.i4.3
    IL_0001: conv.i8
    IL_0002: call System.Char Z0.Digital::character(System.UInt64)
    IL_0007: ret
}

// Id := 100664663, Name := System.Char Z0.OpCodes.nats::digit_decode_4()
// Char digit_decode_4()
// IL
Char digit_decode_4()
{
    IL_0000: ldc.i4.4
    IL_0001: conv.i8
    IL_0002: call System.Char Z0.Digital::character(System.UInt64)
    IL_0007: ret
}

// Id := 100664664, Name := System.Char Z0.OpCodes.nats::digit_decode_n4()
// Char digit_decode_n4()
// IL
Char digit_decode_n4()
{
    IL_0000: call System.Char Z0.Digital::character<Z0.N4>()
    IL_0005: ret
}

// Id := 100664665, Name := System.Char Z0.OpCodes.nats::digit_decode_5()
// Char digit_decode_5()
// IL
Char digit_decode_5()
{
    IL_0000: ldc.i4.5
    IL_0001: conv.i8
    IL_0002: call System.Char Z0.Digital::character(System.UInt64)
    IL_0007: ret
}

// Id := 100664666, Name := System.Char Z0.OpCodes.nats::digit_decode_n5()
// Char digit_decode_n5()
// IL
Char digit_decode_n5()
{
    IL_0000: call System.Char Z0.Digital::character<Z0.N5>()
    IL_0005: ret
}

