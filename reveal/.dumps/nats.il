// 2020-01-18 18:18:33:873
// Id := 100664850, Name := System.UInt64 Z0.OpCodes.nats::nat_add()
// ulong nat_add()
// Managed
ulong nat_add()
{
    IL_0000: call Z0.N12 zfunc::get_n12()
    IL_0005: call Z0.N16 zfunc::get_n16()
    IL_000A: call System.UInt64 Z0.NatMath2::add<Z0.N12,Z0.N16>(Z0.N12,Z0.N16)
    IL_000F: ret
}

// Id := 100664851, Name := System.UInt64 Z0.OpCodes.nats::nat_sub()
// ulong nat_sub()
// Managed
ulong nat_sub()
{
    IL_0000: call Z0.N0 zfunc::get_n0()
    IL_0005: call Z0.N256 zfunc::get_n256()
    IL_000A: call System.UInt64 Z0.NatMath2::sub<Z0.N0,Z0.N256>(Z0.N0,Z0.N256)
    IL_000F: ret
}

// Id := 100664852, Name := System.UInt64 Z0.OpCodes.nats::nat_mul()
// ulong nat_mul()
// Managed
ulong nat_mul()
{
    IL_0000: call Z0.N12 zfunc::get_n12()
    IL_0005: call Z0.N16 zfunc::get_n16()
    IL_000A: call System.UInt64 Z0.NatMath2::mul<Z0.N12,Z0.N16>(Z0.N12,Z0.N16)
    IL_000F: ret
}

// Id := 100664853, Name := System.UInt64 Z0.OpCodes.nats::nat_div()
// ulong nat_div()
// Managed
ulong nat_div()
{
    IL_0000: call Z0.N50 zfunc::get_n50()
    IL_0005: call Z0.N5 zfunc::get_n5()
    IL_000A: call System.UInt64 Z0.NatMath2::div<Z0.N50,Z0.N5>(Z0.N50,Z0.N5)
    IL_000F: ret
}

// Id := 100664854, Name := System.UInt64 Z0.OpCodes.nats::nat_mod()
// ulong nat_mod()
// Managed
ulong nat_mod()
{
    IL_0000: call Z0.N50 zfunc::get_n51()
    IL_0005: call Z0.N3 zfunc::get_n3()
    IL_000A: call System.UInt64 Z0.NatMath2::mod<Z0.N50,Z0.N3>(Z0.N50,Z0.N3)
    IL_000F: ret
}

// Id := 100664855, Name := System.UInt64 Z0.OpCodes.nats::digits_encode_1_0()
// ulong digits_encode_1_0()
// Managed
ulong digits_encode_1_0()
{
    IL_0000: ldc.i4.s 48
    IL_0002: call System.UInt64 Z0.Digital::digit(System.Char)
    IL_0007: ret
}

// Id := 100664856, Name := System.UInt64 Z0.OpCodes.nats::digits_encode_1()
// ulong digits_encode_1()
// Managed
ulong digits_encode_1()
{
    IL_0000: ldc.i4.s 49
    IL_0002: call System.UInt64 Z0.Digital::digit(System.Char)
    IL_0007: ret
}

// Id := 100664857, Name := System.UInt64 Z0.OpCodes.nats::digits_encode_2()
// ulong digits_encode_2()
// Managed
ulong digits_encode_2()
{
    IL_0000: ldc.i4.s 50
    IL_0002: call System.UInt64 Z0.Digital::digit(System.Char)
    IL_0007: ret
}

// Id := 100664858, Name := System.UInt64 Z0.OpCodes.nats::digits_encode_3()
// ulong digits_encode_3()
// Managed
ulong digits_encode_3()
{
    IL_0000: ldc.i4.s 51
    IL_0002: call System.UInt64 Z0.Digital::digit(System.Char)
    IL_0007: ret
}

// Id := 100664859, Name := System.UInt64 Z0.OpCodes.nats::digits_encode_10()
// ulong digits_encode_10()
// Managed
ulong digits_encode_10()
{
    IL_0000: ldc.i4.s 49
    IL_0002: ldc.i4.s 48
    IL_0004: call System.UInt64 Z0.Digital::digits(System.Char,System.Char)
    IL_0009: ret
}

// Id := 100664860, Name := System.UInt64 Z0.OpCodes.nats::digits_encode_210()
// ulong digits_encode_210()
// Managed
ulong digits_encode_210()
{
    IL_0000: ldc.i4.s 50
    IL_0002: ldc.i4.s 49
    IL_0004: ldc.i4.s 48
    IL_0006: call System.UInt64 Z0.Digital::digits(System.Char,System.Char,System.Char)
    IL_000B: ret
}

// Id := 100664861, Name := System.UInt64 Z0.OpCodes.nats::digits_encode_3210()
// ulong digits_encode_3210()
// Managed
ulong digits_encode_3210()
{
    IL_0000: ldc.i4.s 51
    IL_0002: ldc.i4.s 50
    IL_0004: ldc.i4.s 49
    IL_0006: ldc.i4.s 48
    IL_0008: call System.UInt64 Z0.Digital::digits(System.Char,System.Char,System.Char,System.Char)
    IL_000D: ret
}

// Id := 100664862, Name := System.UInt64 Z0.OpCodes.nats::digits_encode_43210()
// ulong digits_encode_43210()
// Managed
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

// Id := 100664863, Name := System.UInt64 Z0.OpCodes.nats::digits_encode_76543210()
// ulong digits_encode_76543210()
// Managed
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

// Id := 100664864, Name := System.UInt64 Z0.OpCodes.nats::digit_extract_9()
// ulong digit_extract_9()
// Managed
ulong digit_extract_9()
{
    IL_0000: ldc.i4 22601
    IL_0005: conv.i8
    IL_0006: ldc.i4.0
    IL_0007: call System.UInt64 Z0.Digital::digit(System.UInt64,System.Int32)
    IL_000C: ret
}

// Id := 100664865, Name := System.UInt64 Z0.OpCodes.nats::digit_extract_4()
// ulong digit_extract_4()
// Managed
ulong digit_extract_4()
{
    IL_0000: ldc.i4 22601
    IL_0005: conv.i8
    IL_0006: ldc.i4.1
    IL_0007: call System.UInt64 Z0.Digital::digit(System.UInt64,System.Int32)
    IL_000C: ret
}

// Id := 100664866, Name := System.UInt64 Z0.OpCodes.nats::digit_extract_8()
// ulong digit_extract_8()
// Managed
ulong digit_extract_8()
{
    IL_0000: ldc.i4 22601
    IL_0005: conv.i8
    IL_0006: ldc.i4.2
    IL_0007: call System.UInt64 Z0.Digital::digit(System.UInt64,System.Int32)
    IL_000C: ret
}

// Id := 100664867, Name := System.UInt64 Z0.OpCodes.nats::digit_extract_5()
// ulong digit_extract_5()
// Managed
ulong digit_extract_5()
{
    IL_0000: ldc.i4 22601
    IL_0005: conv.i8
    IL_0006: ldc.i4.3
    IL_0007: call System.UInt64 Z0.Digital::digit(System.UInt64,System.Int32)
    IL_000C: ret
}

// Id := 100664868, Name := System.Void Z0.OpCodes.nats::digits_extract_5849(System.Byte&,System.Byte&,System.Byte&,System.Byte&)
// void digits_extract_5849(out byte d3, out byte d2, out byte d1, out byte d0)
// Managed
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

// Id := 100664869, Name := System.Void Z0.OpCodes.nats::digits_extract_5489_ref(System.Byte&)
// void digits_extract_5489_ref(ref byte dst)
// Managed
void digits_extract_5489_ref(ref byte dst)
{
    IL_0000: ldc.i4 22601
    IL_0005: conv.i8
    IL_0006: call Z0.N4 zfunc::get_n4()
    IL_000B: ldarg.0
    IL_000C: call System.Void Z0.Digital::digits(System.UInt64,Z0.N4,System.Byte&)
    IL_0011: ret
}

// Id := 100664870, Name := System.Void Z0.OpCodes.nats::digits_extract_80352178(System.Byte&,System.Byte&,System.Byte&,System.Byte&,System.Byte&,System.Byte&,System.Byte&,System.Byte&)
// void digits_extract_80352178(out byte d7, out byte d6, out byte d5, out byte d4, out byte d3, out byte d2, out byte d1, out byte d0)
// Managed
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

// Id := 100664871, Name := System.Void Z0.OpCodes.nats::chars_5489(System.Char&,System.Char&,System.Char&,System.Char&)
// void chars_5489(out Char c3, out Char c2, out Char c1, out Char c0)
// Managed
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

// Id := 100664872, Name := System.Void Z0.OpCodes.nats::chars_80352178(System.Char&,System.Char&,System.Char&,System.Char&,System.Char&,System.Char&,System.Char&,System.Char&)
// void chars_80352178(out Char c7, out Char c6, out Char c5, out Char c4, out Char c3, out Char c2, out Char c1, out Char c0)
// Managed
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

// Id := 100664873, Name := System.ReadOnlySpan`1<System.Char> Z0.OpCodes.nats::charspan_5489()
// ReadOnlySpan<Char> charspan_5489()
// Managed
ReadOnlySpan<Char> charspan_5489()
{
    IL_0000: ldc.i4 21641
    IL_0005: call System.ReadOnlySpan`1<System.Char> Z0.Digital::chars(System.UInt32)
    IL_000A: ret
}

// Id := 100664874, Name := System.Char Z0.OpCodes.nats::digit_decode_0()
// Char digit_decode_0()
// Managed
Char digit_decode_0()
{
    IL_0000: ldc.i4.0
    IL_0001: conv.i8
    IL_0002: call System.Char Z0.Digital::character(System.UInt64)
    IL_0007: ret
}

// Id := 100664875, Name := System.Char Z0.OpCodes.nats::digit_decode_1()
// Char digit_decode_1()
// Managed
Char digit_decode_1()
{
    IL_0000: ldc.i4.1
    IL_0001: conv.i8
    IL_0002: call System.Char Z0.Digital::character(System.UInt64)
    IL_0007: ret
}

// Id := 100664876, Name := System.Char Z0.OpCodes.nats::digit_decode_2()
// Char digit_decode_2()
// Managed
Char digit_decode_2()
{
    IL_0000: ldc.i4.2
    IL_0001: conv.i8
    IL_0002: call System.Char Z0.Digital::character(System.UInt64)
    IL_0007: ret
}

// Id := 100664877, Name := System.Char Z0.OpCodes.nats::digit_decode_3()
// Char digit_decode_3()
// Managed
Char digit_decode_3()
{
    IL_0000: ldc.i4.3
    IL_0001: conv.i8
    IL_0002: call System.Char Z0.Digital::character(System.UInt64)
    IL_0007: ret
}

// Id := 100664878, Name := System.Char Z0.OpCodes.nats::digit_decode_4()
// Char digit_decode_4()
// Managed
Char digit_decode_4()
{
    IL_0000: ldc.i4.4
    IL_0001: conv.i8
    IL_0002: call System.Char Z0.Digital::character(System.UInt64)
    IL_0007: ret
}

// Id := 100664879, Name := System.Char Z0.OpCodes.nats::digit_decode_n4()
// Char digit_decode_n4()
// Managed
Char digit_decode_n4()
{
    IL_0000: call System.Char Z0.Digital::character<Z0.N4>()
    IL_0005: ret
}

// Id := 100664880, Name := System.Char Z0.OpCodes.nats::digit_decode_5()
// Char digit_decode_5()
// Managed
Char digit_decode_5()
{
    IL_0000: ldc.i4.5
    IL_0001: conv.i8
    IL_0002: call System.Char Z0.Digital::character(System.UInt64)
    IL_0007: ret
}

// Id := 100664881, Name := System.Char Z0.OpCodes.nats::digit_decode_n5()
// Char digit_decode_n5()
// Managed
Char digit_decode_n5()
{
    IL_0000: call System.Char Z0.Digital::character<Z0.N5>()
    IL_0005: ret
}

