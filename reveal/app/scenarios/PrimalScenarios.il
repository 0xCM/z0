// 2019-09-26 00:47:44:334
ulong div_64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: div.un
    IL_0003: ret

}
ulong div_g64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.gmath::div<System.UInt64>(System.UInt64,System.UInt64)
    IL_0007: ret

}
ulong inc_64u(ulong x)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0002: conv.i8
    IL_0003: add
    IL_0004: dup
    IL_0005: starg.s x
    IL_0007: ret

}
ulong inc_g64u(ulong x)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt64 Z0.gmath::inc<System.UInt64>(System.UInt64)
    IL_0006: ret

}
ref ulong inc_g64u_ref(ref ulong x)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt64& Z0.gmath::inc<System.UInt64>(System.UInt64&)
    IL_0006: ret

}
ref ulong inc_64u_ref(ref ulong x)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt64& Z0.math::inc(System.UInt64&)
    IL_0006: ret

}
bool gt_64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: cgt.un
    IL_0004: ret

}
bool gt_g64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.gmath::gt<System.UInt64>(System.UInt64,System.UInt64)
    IL_0007: ret

}
bool gteq_64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: clt.un
    IL_0004: ldc.i4.0
    IL_0005: ceq
    IL_0007: ret

}
bool gteq_g64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.gmath::gteq<System.UInt64>(System.UInt64,System.UInt64)
    IL_0007: ret

}
bool eq_64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ceq
    IL_0004: ret

}
bool eq_g64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.gmath::eq<System.UInt64>(System.UInt64,System.UInt64)
    IL_0007: ret

}
byte add_8u(byte x, byte y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: add
    IL_0003: conv.u1
    IL_0004: ret

}
byte add_g8u(byte x, byte y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Byte Z0.gmath::add<System.Byte>(System.Byte,System.Byte)
    IL_0007: ret

}
ulong mul_64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: mul
    IL_0003: ret

}
ulong mul_g64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.gmath::mul<System.UInt64>(System.UInt64,System.UInt64)
    IL_0007: ret

}
byte mul_8u(byte x, byte y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: mul
    IL_0003: conv.u1
    IL_0004: ret

}
byte mul_g8u(byte x, byte y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Byte Z0.gmath::mul<System.Byte>(System.Byte,System.Byte)
    IL_0007: ret

}
ulong and_64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: and
    IL_0003: ret

}
ulong and_g64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.gmath::and<System.UInt64>(System.UInt64,System.UInt64)
    IL_0007: ret

}
ulong mod_64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: rem.un
    IL_0003: ret

}
ulong mod_g64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.gmath::mod<System.UInt64>(System.UInt64,System.UInt64)
    IL_0007: ret

}
long abs_64i(long x)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int64 Z0.math::abs(System.Int64)
    IL_0006: ret

}
long abs_g64i(long x)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int64 Z0.gmath::abs<System.Int64>(System.Int64)
    IL_0006: ret

}
ulong or_64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: or
    IL_0003: ret

}
ulong or_g64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.gmath::or<System.UInt64>(System.UInt64,System.UInt64)
    IL_0007: ret

}
ulong xor_64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: xor
    IL_0003: ret

}
ulong xor_g64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.gmath::xor<System.UInt64>(System.UInt64,System.UInt64)
    IL_0007: ret

}
double dec_64f(double x)
{
    IL_0000: ldarg.0
    IL_0001: ldc.r8 1
    IL_000A: sub
    IL_000B: dup
    IL_000C: starg.s x
    IL_000E: ret

}
double dec_g64f(double x)
{
    IL_0000: ldarg.0
    IL_0001: call System.Double Z0.gfp::dec<System.Double>(System.Double)
    IL_0006: ret

}
double dec_64f(ref double x)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldind.r8
    IL_0003: ldc.r8 1
    IL_000C: sub
    IL_000D: stloc.0
    IL_000E: ldloc.0
    IL_000F: stind.r8
    IL_0010: ldloc.0
    IL_0011: ret

}
ref double dec_g64f(ref double x)
{
    IL_0000: ldarg.0
    IL_0001: call System.Double& Z0.gfp::dec<System.Double>(System.Double&)
    IL_0006: ret

}
bool gteq_32i(int x, int y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ceq
    IL_0004: ret

}
bool gteq_g32i(int x, int y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.gmath::gteq<System.Int32>(System.Int32,System.Int32)
    IL_0007: ret

}
