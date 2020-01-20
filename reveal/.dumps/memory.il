// 2020-01-20 01:59:21:004
// Id := 100664359, Name := System.Int32 Z0.OpCodes.memory::blockalign_64x8u_var(System.Int32)
// int blockalign_64x8u_var(int cellcount)
// IL
int blockalign_64x8u_var(int cellcount)
{
    IL_0000: call Z0.N64 Z0.OpCodes.memory::get_n64()
    IL_0005: ldarg.0
    IL_0006: call System.Int32 Z0.DataBlocks::minblocks<System.Byte>(Z0.N64,System.Int32)
    IL_000B: ret
}

// Id := 100664360, Name := System.Int32 Z0.OpCodes.memory::blockalign_64x8u_16()
// int blockalign_64x8u_16()
// IL
int blockalign_64x8u_16()
{
    IL_0000: call Z0.N64 Z0.OpCodes.memory::get_n64()
    IL_0005: ldc.i4.s 16
    IL_0007: call System.Int32 Z0.DataBlocks::minblocks<System.Byte>(Z0.N64,System.Int32)
    IL_000C: ret
}

// Id := 100664361, Name := System.Int32 Z0.OpCodes.memory::blockalign_64x8u_17()
// int blockalign_64x8u_17()
// IL
int blockalign_64x8u_17()
{
    IL_0000: call Z0.N64 Z0.OpCodes.memory::get_n64()
    IL_0005: ldc.i4.s 17
    IL_0007: call System.Int32 Z0.DataBlocks::minblocks<System.Byte>(Z0.N64,System.Int32)
    IL_000C: ret
}

// Id := 100664366, Name := System.Char Z0.OpCodes.memory::digit_1()
// Char digit_1()
// IL
Char digit_1()
{
    IL_0000: call System.ReadOnlySpan`1<System.Char> Z0.OpCodes.memory::get_CharSpan()
    IL_0005: ldc.i4.5
    IL_0006: call System.Char& modreq(System.Runtime.InteropServices.InAttribute) zfunc::skip<System.Char>(System.ReadOnlySpan`1<System.Char>,System.Int32)
    IL_000B: ldind.u2
    IL_000C: ret
}

// Id := 100664367, Name := System.Char Z0.OpCodes.memory::digit_2()
// Char digit_2()
// IL
Char digit_2()
{
    IL_0000: ldstr "0123456789ABCDEF"
    IL_0005: ldc.i4.5
    IL_0006: call System.Char System.String::get_Chars(System.Int32)
    IL_000B: ret
}

// Id := 100664368, Name := System.Char Z0.OpCodes.memory::digit(System.Int32)
// Char digit(int i)
// IL
Char digit(int i)
{
    IL_0000: call System.ReadOnlySpan`1<System.Byte> Z0.OpCodes.memory::get_Bytes()
    IL_0005: ldarg.0
    IL_0006: call System.Byte& modreq(System.Runtime.InteropServices.InAttribute) zfunc::skip<System.Byte>(System.ReadOnlySpan`1<System.Byte>,System.Int32)
    IL_000B: ldind.u1
    IL_000C: ret
}

// Id := 100664369, Name := System.Char Z0.OpCodes.memory::bdigit(Z0.bit)
// Char bdigit(bit b)
// IL
Char bdigit(bit b)
{
    IL_0000: ldarga.s b
    IL_0002: call System.Char Z0.bit::ToChar()
    IL_0007: ret
}

