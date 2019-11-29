// 2019-11-29 12:55:50:789
ITypeNat natwidth_8u()
{
    IL_0000: ldc.i4.0
    IL_0001: call Z0.ITypeNat zfunc::natwidth<System.Byte>(System.Byte)
    IL_0006: ret

}
ulong digits_encode_1_0()
{
    IL_0000: ldc.i4.s 48
    IL_0002: call System.UInt64 Z0.Digital::digit(System.Char)
    IL_0007: ret

}
ulong digits_encode_1_1()
{
    IL_0000: ldc.i4.s 49
    IL_0002: call System.UInt64 Z0.Digital::digit(System.Char)
    IL_0007: ret

}
ulong digits_encode_1_2()
{
    IL_0000: ldc.i4.s 50
    IL_0002: call System.UInt64 Z0.Digital::digit(System.Char)
    IL_0007: ret

}
ulong digits_encode_1_3()
{
    IL_0000: ldc.i4.s 51
    IL_0002: call System.UInt64 Z0.Digital::digit(System.Char)
    IL_0007: ret

}
ulong digits_encode_2_10()
{
    IL_0000: ldc.i4.s 49
    IL_0002: ldc.i4.s 48
    IL_0004: call System.UInt64 Z0.Digital::digits(System.Char,System.Char)
    IL_0009: ret

}
ulong digits_encode_3_210()
{
    IL_0000: ldc.i4.s 50
    IL_0002: ldc.i4.s 49
    IL_0004: ldc.i4.s 48
    IL_0006: call System.UInt64 Z0.Digital::digits(System.Char,System.Char,System.Char)
    IL_000B: ret

}
ulong digits_encode_4_3210()
{
    IL_0000: ldc.i4.s 51
    IL_0002: ldc.i4.s 50
    IL_0004: ldc.i4.s 49
    IL_0006: ldc.i4.s 48
    IL_0008: call System.UInt64 Z0.Digital::digits(System.Char,System.Char,System.Char,System.Char)
    IL_000D: ret

}
ulong digits_encode_5_43210()
{
    IL_0000: ldc.i4.s 52
    IL_0002: ldc.i4.s 51
    IL_0004: ldc.i4.s 50
    IL_0006: ldc.i4.s 49
    IL_0008: ldc.i4.s 48
    IL_000A: call System.UInt64 Z0.Digital::digits(System.Char,System.Char,System.Char,System.Char,System.Char)
    IL_000F: ret

}
ulong digits_encode_8_76543210()
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
ulong digit_extract_1_0_9()
{
    IL_0000: ldc.i4 22601
    IL_0005: conv.i8
    IL_0006: ldc.i4.0
    IL_0007: call System.UInt64 Z0.Digital::digit(System.UInt64,System.Int32)
    IL_000C: ret

}
ulong digit_extract_1_1_4()
{
    IL_0000: ldc.i4 22601
    IL_0005: conv.i8
    IL_0006: ldc.i4.1
    IL_0007: call System.UInt64 Z0.Digital::digit(System.UInt64,System.Int32)
    IL_000C: ret

}
ulong digit_extract_1_2_8()
{
    IL_0000: ldc.i4 22601
    IL_0005: conv.i8
    IL_0006: ldc.i4.2
    IL_0007: call System.UInt64 Z0.Digital::digit(System.UInt64,System.Int32)
    IL_000C: ret

}
ulong digit_extract_1_3_5()
{
    IL_0000: ldc.i4 22601
    IL_0005: conv.i8
    IL_0006: ldc.i4.3
    IL_0007: call System.UInt64 Z0.Digital::digit(System.UInt64,System.Int32)
    IL_000C: ret

}
void digits_extract_4_5849(out byte d3, out byte d2, out byte d1, out byte d0)
{
    IL_0000: ldc.i4 22601
    IL_0005: conv.i8
    IL_0006: ldarg.0
    IL_0007: ldarg.1
    IL_0008: ldarg.2
    IL_0009: ldarg.3
    IL_000A: call System.Void Z0.Digital::digits(System.UInt64,System.Byte&,System.Byte&,System.Byte&,System.Byte&)
    IL_000F: ret

}
Span<byte> digits_extract_lo(ulong src)
{
    IL_0000: ldc.i4.0
    IL_0001: conv.i8
    IL_0002: stloc.0
    IL_0003: ldloca.s V_1
    IL_0005: ldloca.s V_0
    IL_0007: conv.u
    IL_0008: ldc.i4.8
    IL_0009: call System.Void System.Span`1<System.Byte>::.ctor(System.Void*,System.Int32)
    IL_000E: ldarg.0
    IL_000F: ldloc.1
    IL_0010: call System.Void Z0.Digital::digits(System.UInt64,System.Span`1<System.Byte>)
    IL_0015: ldloc.1
    IL_0016: ret

}
Span<byte> digits_extract_hi(ulong src)
{
    IL_0000: ldc.i4.0
    IL_0001: conv.i8
    IL_0002: stloc.0
    IL_0003: ldloca.s V_1
    IL_0005: ldloca.s V_0
    IL_0007: conv.u
    IL_0008: ldc.i4.8
    IL_0009: call System.Void System.Span`1<System.Byte>::.ctor(System.Void*,System.Int32)
    IL_000E: ldarg.0
    IL_000F: ldc.i4.s 32
    IL_0011: shr.un
    IL_0012: ldloc.1
    IL_0013: call System.Void Z0.Digital::digits(System.UInt64,System.Span`1<System.Byte>)
    IL_0018: ldloc.1
    IL_0019: ret

}
Char digit_decode_1_0()
{
    IL_0000: ldc.i4.0
    IL_0001: conv.i8
    IL_0002: call System.Char Z0.Digital::character(System.UInt64)
    IL_0007: ret

}
Char digit_decode_1_1()
{
    IL_0000: ldc.i4.1
    IL_0001: conv.i8
    IL_0002: call System.Char Z0.Digital::character(System.UInt64)
    IL_0007: ret

}
Char digit_decode_1_2()
{
    IL_0000: ldc.i4.2
    IL_0001: conv.i8
    IL_0002: call System.Char Z0.Digital::character(System.UInt64)
    IL_0007: ret

}
Char digit_decode_1_3()
{
    IL_0000: ldc.i4.3
    IL_0001: conv.i8
    IL_0002: call System.Char Z0.Digital::character(System.UInt64)
    IL_0007: ret

}
