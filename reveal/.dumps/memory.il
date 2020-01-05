// 2020-01-05 02:30:51:312
bit iskind_16u()
{
    IL_0000: ldc.i4 30840
    IL_0005: ldc.i4.0
    IL_0006: call Z0.bit Z0.Primitive::iskind<System.UInt16>(Z0.PrimalKind,System.UInt16)
    IL_000B: ret

}
PrimalKind:uint getkind_16u()
{
    IL_0000: ldc.i4.0
    IL_0001: call Z0.PrimalKind Z0.Primitive::kind<System.UInt16>(System.UInt16)
    IL_0006: ret

}
int blockalign_64x8u_var(int cellcount)
{
    IL_0000: call Z0.N64 Z0.OpCodes.memory::get_n64()
    IL_0005: ldarg.0
    IL_0006: call System.Int32 Z0.DataBlocks::minblocks<System.Byte>(Z0.N64,System.Int32)
    IL_000B: ret

}
int blockalign_64x8u_16()
{
    IL_0000: call Z0.N64 Z0.OpCodes.memory::get_n64()
    IL_0005: ldc.i4.s 16
    IL_0007: call System.Int32 Z0.DataBlocks::minblocks<System.Byte>(Z0.N64,System.Int32)
    IL_000C: ret

}
int blockalign_64x8u_17()
{
    IL_0000: call Z0.N64 Z0.OpCodes.memory::get_n64()
    IL_0005: ldc.i4.s 17
    IL_0007: call System.Int32 Z0.DataBlocks::minblocks<System.Byte>(Z0.N64,System.Int32)
    IL_000C: ret

}
Char digit_1()
{
    IL_0000: call System.ReadOnlySpan`1<System.Char> Z0.OpCodes.memory::get_CharSpan()
    IL_0005: ldc.i4.5
    IL_0006: call System.Char& modreq(System.Runtime.InteropServices.InAttribute) zfunc::skip<System.Char>(System.ReadOnlySpan`1<System.Char>,System.Int32)
    IL_000B: ldind.u2
    IL_000C: ret

}
Char digit_2()
{
    IL_0000: ldstr "0123456789ABCDEF"
    IL_0005: ldc.i4.5
    IL_0006: call System.Char System.String::get_Chars(System.Int32)
    IL_000B: ret

}
Char digit(int i)
{
    IL_0000: call System.ReadOnlySpan`1<System.Byte> Z0.OpCodes.memory::get_Bytes()
    IL_0005: ldarg.0
    IL_0006: call System.Byte& modreq(System.Runtime.InteropServices.InAttribute) zfunc::skip<System.Byte>(System.ReadOnlySpan`1<System.Byte>,System.Int32)
    IL_000B: ldind.u1
    IL_000C: ret

}
Char bdigit(bit b)
{
    IL_0000: ldarga.s b
    IL_0002: call System.Char Z0.bit::ToChar()
    IL_0007: ret

}
