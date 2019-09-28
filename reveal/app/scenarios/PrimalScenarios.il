// 2019-09-27 16:58:02:065
int polyadd_int32(int x, int y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Int32 Z0.StructOps::add<System.Int32>(System.Int32,System.Int32)
    IL_0007: ret

}
ulong min_n64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 System.Math::Min(System.UInt64,System.UInt64)
    IL_0007: ret

}
ulong min_d64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.math::min(System.UInt64,System.UInt64)
    IL_0007: ret

}
ulong min_g64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.gmath::min<System.UInt64>(System.UInt64,System.UInt64)
    IL_0007: ret

}
long abs_n64i(long x)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int64 System.Math::Abs(System.Int64)
    IL_0006: ret

}
long abs_d64i(long x)
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
long negate_n64i(long x)
{
    IL_0000: ldarg.0
    IL_0001: neg
    IL_0002: ret

}
long negate_g64i(long x)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int64 Z0.gmath::negate<System.Int64>(System.Int64)
    IL_0006: ret

}
long negate_d64i(long x)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int64 Z0.math::negate(System.Int64)
    IL_0006: ret

}
ulong negate_g64u(ulong x)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt64 Z0.gmath::negate<System.UInt64>(System.UInt64)
    IL_0006: ret

}
ulong negate_d64i(ulong x)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt64 Z0.math::negate(System.UInt64)
    IL_0006: ret

}
ulong add_n64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: add
    IL_0003: ret

}
ulong add_d64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.math::add(System.UInt64,System.UInt64)
    IL_0007: ret

}
ulong add_g64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.gmath::add<System.UInt64>(System.UInt64,System.UInt64)
    IL_0007: ret

}
ulong div_n64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: div.un
    IL_0003: ret

}
ulong div_d64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.math::div(System.UInt64,System.UInt64)
    IL_0007: ret

}
ulong div_g64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.gmath::div<System.UInt64>(System.UInt64,System.UInt64)
    IL_0007: ret

}
ulong mod_n64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: rem.un
    IL_0003: ret

}
ulong mod_d64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.math::mod(System.UInt64,System.UInt64)
    IL_0007: ret

}
ulong mod_g64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.gmath::mod<System.UInt64>(System.UInt64,System.UInt64)
    IL_0007: ret

}
ulong inc_n64u(ulong x)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0002: conv.i8
    IL_0003: add
    IL_0004: dup
    IL_0005: starg.s x
    IL_0007: ret

}
ulong inc_d64u(ulong x)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt64 Z0.math::inc(System.UInt64)
    IL_0006: ret

}
ulong inc_g64u(ulong x)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt64 Z0.gmath::inc<System.UInt64>(System.UInt64)
    IL_0006: ret

}
bool gt_n64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: cgt.un
    IL_0004: ret

}
bool gt_d64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.math::gt(System.UInt64,System.UInt64)
    IL_0007: ret

}
bool gt_g64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.gmath::gt<System.UInt64>(System.UInt64,System.UInt64)
    IL_0007: ret

}
bool gteq_n64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: clt.un
    IL_0004: ldc.i4.0
    IL_0005: ceq
    IL_0007: ret

}
bool gteq_d64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.math::gteq(System.UInt64,System.UInt64)
    IL_0007: ret

}
bool gteq_g64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.gmath::gteq<System.UInt64>(System.UInt64,System.UInt64)
    IL_0007: ret

}
bool eq_n64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ceq
    IL_0004: ret

}
bool eq_d64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.math::eq(System.UInt64,System.UInt64)
    IL_0007: ret

}
bool eq_g64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.gmath::eq<System.UInt64>(System.UInt64,System.UInt64)
    IL_0007: ret

}
ulong mul_n64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: mul
    IL_0003: ret

}
ulong mul_d64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.math::mul(System.UInt64,System.UInt64)
    IL_0007: ret

}
ulong mul_g64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.gmath::mul<System.UInt64>(System.UInt64,System.UInt64)
    IL_0007: ret

}
ulong and_n64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: and
    IL_0003: ret

}
ulong and_d64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.math::and(System.UInt64,System.UInt64)
    IL_0007: ret

}
ulong and_g64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.gmath::and<System.UInt64>(System.UInt64,System.UInt64)
    IL_0007: ret

}
ulong or_n64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: or
    IL_0003: ret

}
ulong or_d64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.math::or(System.UInt64,System.UInt64)
    IL_0007: ret

}
ulong or_g64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.gmath::or<System.UInt64>(System.UInt64,System.UInt64)
    IL_0007: ret

}
ulong xor_n64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: xor
    IL_0003: ret

}
ulong xor_d64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.math::xor(System.UInt64,System.UInt64)
    IL_0007: ret

}
ulong xor_g64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.gmath::xor<System.UInt64>(System.UInt64,System.UInt64)
    IL_0007: ret

}
