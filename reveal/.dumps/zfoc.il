// 2020-01-05 15:03:46:612
byte hexcode_parse(Char c)
{
    IL_0000: ldarg.0
    IL_0001: call System.Byte Z0.Hex::parse(System.Char)
    IL_0006: ret

}
Pair<ulong> sub_128u_a(Pair<ulong> a, Pair<ulong> b)
{
    IL_0000: ldarga.s a
    IL_0002: ldarga.s b
    IL_0004: call Z0.Pair`1<System.UInt64> Z0.Math128::sub(Z0.Pair`1<System.UInt64>&,Z0.Pair`1<System.UInt64>&)
    IL_0009: ret

}
void sub_128u_b(in ulong a, in ulong b, ref ulong c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.Void Z0.Math128::sub(System.UInt64&,System.UInt64&,System.UInt64&)
    IL_0008: ret

}
void mul_128u(Pair<ulong> src, ref Pair<ulong> dst)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: call Z0.Pair`1<System.UInt64>& Z0.Math128::mul(Z0.Pair`1<System.UInt64>&,Z0.Pair`1<System.UInt64>&)
    IL_0008: pop
    IL_0009: ret

}
Pair<ulong> add_128u(Pair<ulong> a, Pair<ulong> b)
{
    IL_0000: ldarga.s a
    IL_0002: ldarga.s b
    IL_0004: call Z0.Pair`1<System.UInt64> Z0.Math128::add(Z0.Pair`1<System.UInt64>&,Z0.Pair`1<System.UInt64>&)
    IL_0009: ret

}
Pair<ulong> xor_128u(Pair<ulong> a, Pair<ulong> b)
{
    IL_0000: ldarga.s a
    IL_0002: ldarga.s b
    IL_0004: call Z0.Pair`1<System.UInt64> Z0.Math128::xor(Z0.Pair`1<System.UInt64>&,Z0.Pair`1<System.UInt64>&)
    IL_0009: ret

}
Pair<ulong> xnor_128u(Pair<ulong> a, Pair<ulong> b)
{
    IL_0000: ldarga.s a
    IL_0002: ldarga.s b
    IL_0004: call Z0.Pair`1<System.UInt64> Z0.Math128::xnor(Z0.Pair`1<System.UInt64>&,Z0.Pair`1<System.UInt64>&)
    IL_0009: ret

}
Pair<ulong> negate_128u(Pair<ulong> a)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Pair`1<System.UInt64> Z0.Math128::negate(Z0.Pair`1<System.UInt64>)
    IL_0006: ret

}
ref Pair<ulong> inc_128u(ref Pair<ulong> a)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Pair`1<System.UInt64>& Z0.Math128::inc(Z0.Pair`1<System.UInt64>&)
    IL_0006: ret

}
Pair<ulong> srl_128u(Pair<ulong> a, int offset)
{
    IL_0000: ldarga.s a
    IL_0002: ldarg.1
    IL_0003: call Z0.Pair`1<System.UInt64> Z0.Math128::srl(Z0.Pair`1<System.UInt64>&,System.Int32)
    IL_0008: ret

}
Pair<ulong> sll_128u(Pair<ulong> a, int offset)
{
    IL_0000: ldarga.s a
    IL_0002: ldarg.1
    IL_0003: call Z0.Pair`1<System.UInt64> Z0.Math128::sll(Z0.Pair`1<System.UInt64>&,System.Int32)
    IL_0008: ret

}
bit same_128u(Pair<ulong> a, Pair<ulong> b)
{
    IL_0000: ldarga.s a
    IL_0002: ldarga.s b
    IL_0004: call Z0.bit Z0.Math128::same(Z0.Pair`1<System.UInt64>&,Z0.Pair`1<System.UInt64>&)
    IL_0009: ret

}
bit lt_128u(Pair<ulong> a, Pair<ulong> b)
{
    IL_0000: ldarga.s a
    IL_0002: ldarga.s b
    IL_0004: call Z0.bit Z0.Math128::lt(Z0.Pair`1<System.UInt64>&,Z0.Pair`1<System.UInt64>&)
    IL_0009: ret

}
bit gteq_128u(Pair<ulong> a, Pair<ulong> b)
{
    IL_0000: ldarga.s a
    IL_0002: ldarga.s b
    IL_0004: call Z0.bit Z0.Math128::gteq(Z0.Pair`1<System.UInt64>&,Z0.Pair`1<System.UInt64>&)
    IL_0009: ret

}
void mul_32u(Pair<uint> src, ref Pair<uint> dst)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: call Z0.Pair`1<System.UInt32>& Z0.Math128::mul(Z0.Pair`1<System.UInt32>&,Z0.Pair`1<System.UInt32>&)
    IL_0008: pop
    IL_0009: ret

}
uint mod_const_16(uint a)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 Z0.Mod16::mod(System.UInt32)
    IL_0006: ret

}
uint div_const_16(uint a)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 Z0.Mod16::div(System.UInt32)
    IL_0006: ret

}
uint mod_const_25(uint a)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 Z0.Mod25::mod(System.UInt32)
    IL_0006: ret

}
uint div_const_25(uint a)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 Z0.Mod25::div(System.UInt32)
    IL_0006: ret

}
uint mod_const_32(uint a)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 Z0.Mod32::mod(System.UInt32)
    IL_0006: ret

}
uint div_const_32(uint a)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 Z0.Mod32::div(System.UInt32)
    IL_0006: ret

}
