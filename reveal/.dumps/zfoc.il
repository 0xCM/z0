// 2020-01-16 19:14:11:131
// Id := 100663350, Name := System.Byte Z0.zfoc::hexcode_parse(System.Char)
// byte hexcode_parse(Char c)
// Managed
byte hexcode_parse(Char c)
{
    IL_0000: ldarg.0
    IL_0001: call System.Byte Z0.Hex::parse(System.Char)
    IL_0006: ret
}

// Id := 100663351, Name := Z0.Pair`1<System.UInt64> Z0.zfoc::sub_128u_a(Z0.Pair`1<System.UInt64>,Z0.Pair`1<System.UInt64>)
// Pair<ulong> sub_128u_a(Pair<ulong> a, Pair<ulong> b)
// Managed
Pair<ulong> sub_128u_a(Pair<ulong> a, Pair<ulong> b)
{
    IL_0000: ldarga.s a
    IL_0002: ldarga.s b
    IL_0004: call Z0.Pair`1<System.UInt64> Z0.Math128::sub(Z0.Pair`1<System.UInt64>&,Z0.Pair`1<System.UInt64>&)
    IL_0009: ret
}

// Id := 100663352, Name := System.Void Z0.zfoc::sub_128u_b(System.UInt64&,System.UInt64&,System.UInt64&)
// void sub_128u_b(in ulong a, in ulong b, ref ulong c)
// Managed
void sub_128u_b(in ulong a, in ulong b, ref ulong c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.Void Z0.Math128::sub(System.UInt64&,System.UInt64&,System.UInt64&)
    IL_0008: ret
}

// Id := 100663353, Name := System.Void Z0.zfoc::mul_128u(Z0.Pair`1<System.UInt64>,Z0.Pair`1<System.UInt64>&)
// void mul_128u(Pair<ulong> src, ref Pair<ulong> dst)
// Managed
void mul_128u(Pair<ulong> src, ref Pair<ulong> dst)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: call Z0.Pair`1<System.UInt64>& Z0.Math128::mul(Z0.Pair`1<System.UInt64>&,Z0.Pair`1<System.UInt64>&)
    IL_0008: pop
    IL_0009: ret
}

// Id := 100663354, Name := Z0.Pair`1<System.UInt64> Z0.zfoc::add_128u(Z0.Pair`1<System.UInt64>,Z0.Pair`1<System.UInt64>)
// Pair<ulong> add_128u(Pair<ulong> a, Pair<ulong> b)
// Managed
Pair<ulong> add_128u(Pair<ulong> a, Pair<ulong> b)
{
    IL_0000: ldarga.s a
    IL_0002: ldarga.s b
    IL_0004: call Z0.Pair`1<System.UInt64> Z0.Math128::add(Z0.Pair`1<System.UInt64>&,Z0.Pair`1<System.UInt64>&)
    IL_0009: ret
}

// Id := 100663355, Name := Z0.Pair`1<System.UInt64> Z0.zfoc::xor_128u(Z0.Pair`1<System.UInt64>,Z0.Pair`1<System.UInt64>)
// Pair<ulong> xor_128u(Pair<ulong> a, Pair<ulong> b)
// Managed
Pair<ulong> xor_128u(Pair<ulong> a, Pair<ulong> b)
{
    IL_0000: ldarga.s a
    IL_0002: ldarga.s b
    IL_0004: call Z0.Pair`1<System.UInt64> Z0.Math128::xor(Z0.Pair`1<System.UInt64>&,Z0.Pair`1<System.UInt64>&)
    IL_0009: ret
}

// Id := 100663356, Name := Z0.Pair`1<System.UInt64> Z0.zfoc::xnor_128u(Z0.Pair`1<System.UInt64>,Z0.Pair`1<System.UInt64>)
// Pair<ulong> xnor_128u(Pair<ulong> a, Pair<ulong> b)
// Managed
Pair<ulong> xnor_128u(Pair<ulong> a, Pair<ulong> b)
{
    IL_0000: ldarga.s a
    IL_0002: ldarga.s b
    IL_0004: call Z0.Pair`1<System.UInt64> Z0.Math128::xnor(Z0.Pair`1<System.UInt64>&,Z0.Pair`1<System.UInt64>&)
    IL_0009: ret
}

// Id := 100663357, Name := Z0.Pair`1<System.UInt64> Z0.zfoc::negate_128u(Z0.Pair`1<System.UInt64>)
// Pair<ulong> negate_128u(Pair<ulong> a)
// Managed
Pair<ulong> negate_128u(Pair<ulong> a)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Pair`1<System.UInt64> Z0.Math128::negate(Z0.Pair`1<System.UInt64>)
    IL_0006: ret
}

// Id := 100663358, Name := Z0.Pair`1<System.UInt64>& Z0.zfoc::inc_128u(Z0.Pair`1<System.UInt64>&)
// ref Pair<ulong> inc_128u(ref Pair<ulong> a)
// Managed
ref Pair<ulong> inc_128u(ref Pair<ulong> a)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Pair`1<System.UInt64>& Z0.Math128::inc(Z0.Pair`1<System.UInt64>&)
    IL_0006: ret
}

// Id := 100663359, Name := Z0.Pair`1<System.UInt64> Z0.zfoc::srl_128u(Z0.Pair`1<System.UInt64>,System.Int32)
// Pair<ulong> srl_128u(Pair<ulong> a, int offset)
// Managed
Pair<ulong> srl_128u(Pair<ulong> a, int offset)
{
    IL_0000: ldarga.s a
    IL_0002: ldarg.1
    IL_0003: call Z0.Pair`1<System.UInt64> Z0.Math128::srl(Z0.Pair`1<System.UInt64>&,System.Int32)
    IL_0008: ret
}

// Id := 100663360, Name := Z0.Pair`1<System.UInt64> Z0.zfoc::sll_128u(Z0.Pair`1<System.UInt64>,System.Int32)
// Pair<ulong> sll_128u(Pair<ulong> a, int offset)
// Managed
Pair<ulong> sll_128u(Pair<ulong> a, int offset)
{
    IL_0000: ldarga.s a
    IL_0002: ldarg.1
    IL_0003: call Z0.Pair`1<System.UInt64> Z0.Math128::sll(Z0.Pair`1<System.UInt64>&,System.Int32)
    IL_0008: ret
}

// Id := 100663361, Name := Z0.bit Z0.zfoc::same_128u(Z0.Pair`1<System.UInt64>,Z0.Pair`1<System.UInt64>)
// bit same_128u(Pair<ulong> a, Pair<ulong> b)
// Managed
bit same_128u(Pair<ulong> a, Pair<ulong> b)
{
    IL_0000: ldarga.s a
    IL_0002: ldarga.s b
    IL_0004: call Z0.bit Z0.Math128::same(Z0.Pair`1<System.UInt64>&,Z0.Pair`1<System.UInt64>&)
    IL_0009: ret
}

// Id := 100663362, Name := Z0.bit Z0.zfoc::lt_128u(Z0.Pair`1<System.UInt64>,Z0.Pair`1<System.UInt64>)
// bit lt_128u(Pair<ulong> a, Pair<ulong> b)
// Managed
bit lt_128u(Pair<ulong> a, Pair<ulong> b)
{
    IL_0000: ldarga.s a
    IL_0002: ldarga.s b
    IL_0004: call Z0.bit Z0.Math128::lt(Z0.Pair`1<System.UInt64>&,Z0.Pair`1<System.UInt64>&)
    IL_0009: ret
}

// Id := 100663363, Name := Z0.bit Z0.zfoc::gteq_128u(Z0.Pair`1<System.UInt64>,Z0.Pair`1<System.UInt64>)
// bit gteq_128u(Pair<ulong> a, Pair<ulong> b)
// Managed
bit gteq_128u(Pair<ulong> a, Pair<ulong> b)
{
    IL_0000: ldarga.s a
    IL_0002: ldarga.s b
    IL_0004: call Z0.bit Z0.Math128::gteq(Z0.Pair`1<System.UInt64>&,Z0.Pair`1<System.UInt64>&)
    IL_0009: ret
}

// Id := 100663364, Name := System.Void Z0.zfoc::mul_32u(Z0.Pair`1<System.UInt32>,Z0.Pair`1<System.UInt32>&)
// void mul_32u(Pair<uint> src, ref Pair<uint> dst)
// Managed
void mul_32u(Pair<uint> src, ref Pair<uint> dst)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: call Z0.Pair`1<System.UInt32>& Z0.Math128::mul(Z0.Pair`1<System.UInt32>&,Z0.Pair`1<System.UInt32>&)
    IL_0008: pop
    IL_0009: ret
}

// Id := 100663365, Name := System.UInt32 Z0.zfoc::mod_const_16(System.UInt32)
// uint mod_const_16(uint a)
// Managed
uint mod_const_16(uint a)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 Z0.Mod16::mod(System.UInt32)
    IL_0006: ret
}

// Id := 100663366, Name := System.UInt32 Z0.zfoc::div_const_16(System.UInt32)
// uint div_const_16(uint a)
// Managed
uint div_const_16(uint a)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 Z0.Mod16::div(System.UInt32)
    IL_0006: ret
}

// Id := 100663367, Name := System.UInt32 Z0.zfoc::mod_const_25(System.UInt32)
// uint mod_const_25(uint a)
// Managed
uint mod_const_25(uint a)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 Z0.Mod25::mod(System.UInt32)
    IL_0006: ret
}

// Id := 100663368, Name := System.UInt32 Z0.zfoc::div_const_25(System.UInt32)
// uint div_const_25(uint a)
// Managed
uint div_const_25(uint a)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 Z0.Mod25::div(System.UInt32)
    IL_0006: ret
}

// Id := 100663369, Name := System.UInt32 Z0.zfoc::mod_const_32(System.UInt32)
// uint mod_const_32(uint a)
// Managed
uint mod_const_32(uint a)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 Z0.Mod32::mod(System.UInt32)
    IL_0006: ret
}

// Id := 100663370, Name := System.UInt32 Z0.zfoc::div_const_32(System.UInt32)
// uint div_const_32(uint a)
// Managed
uint div_const_32(uint a)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 Z0.Mod32::div(System.UInt32)
    IL_0006: ret
}

