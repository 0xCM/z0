; 2020-01-24 20:46:47:573
// Id := 100664127, Name := System.UInt64 Z0.PrimalScenarios::min_n64u(System.UInt64,System.UInt64)
// ulong min_n64u(ulong x, ulong y)
// IL
ulong min_n64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 System.Math::Min(System.UInt64,System.UInt64)
    IL_0007: ret
}

// Id := 100664128, Name := System.UInt64 Z0.PrimalScenarios::min_d64u(System.UInt64,System.UInt64)
// ulong min_d64u(ulong x, ulong y)
// IL
ulong min_d64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.math::min(System.UInt64,System.UInt64)
    IL_0007: ret
}

// Id := 100664129, Name := System.UInt64 Z0.PrimalScenarios::min_g64u(System.UInt64,System.UInt64)
// ulong min_g64u(ulong x, ulong y)
// IL
ulong min_g64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.gmath::min<System.UInt64>(System.UInt64,System.UInt64)
    IL_0007: ret
}

// Id := 100664130, Name := System.Int64 Z0.PrimalScenarios::abs_n64i(System.Int64)
// long abs_n64i(long x)
// IL
long abs_n64i(long x)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int64 System.Math::Abs(System.Int64)
    IL_0006: ret
}

// Id := 100664131, Name := System.Int64 Z0.PrimalScenarios::abs_d64i(System.Int64)
// long abs_d64i(long x)
// IL
long abs_d64i(long x)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int64 Z0.math::abs(System.Int64)
    IL_0006: ret
}

// Id := 100664132, Name := System.Int64 Z0.PrimalScenarios::abs_g64i(System.Int64)
// long abs_g64i(long x)
// IL
long abs_g64i(long x)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int64 Z0.gmath::abs<System.Int64>(System.Int64)
    IL_0006: ret
}

// Id := 100664133, Name := System.Int64 Z0.PrimalScenarios::negate_n64i(System.Int64)
// long negate_n64i(long x)
// IL
long negate_n64i(long x)
{
    IL_0000: ldarg.0
    IL_0001: neg
    IL_0002: ret
}

// Id := 100664134, Name := System.Int64 Z0.PrimalScenarios::negate_g64i(System.Int64)
// long negate_g64i(long x)
// IL
long negate_g64i(long x)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int64 Z0.gmath::negate<System.Int64>(System.Int64)
    IL_0006: ret
}

// Id := 100664135, Name := System.Int64 Z0.PrimalScenarios::negate_d64i(System.Int64)
// long negate_d64i(long x)
// IL
long negate_d64i(long x)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int64 Z0.math::negate(System.Int64)
    IL_0006: ret
}

// Id := 100664136, Name := System.UInt64 Z0.PrimalScenarios::negate_g64u(System.UInt64)
// ulong negate_g64u(ulong x)
// IL
ulong negate_g64u(ulong x)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt64 Z0.gmath::negate<System.UInt64>(System.UInt64)
    IL_0006: ret
}

// Id := 100664137, Name := System.UInt64 Z0.PrimalScenarios::negate_d64i(System.UInt64)
// ulong negate_d64i(ulong x)
// IL
ulong negate_d64i(ulong x)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt64 Z0.math::negate(System.UInt64)
    IL_0006: ret
}

// Id := 100664138, Name := System.UInt64 Z0.PrimalScenarios::add_n64u(System.UInt64,System.UInt64)
// ulong add_n64u(ulong x, ulong y)
// IL
ulong add_n64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: add
    IL_0003: ret
}

// Id := 100664139, Name := System.UInt64 Z0.PrimalScenarios::add_d64u(System.UInt64,System.UInt64)
// ulong add_d64u(ulong x, ulong y)
// IL
ulong add_d64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.math::add(System.UInt64,System.UInt64)
    IL_0007: ret
}

// Id := 100664140, Name := System.UInt64 Z0.PrimalScenarios::add_g64u(System.UInt64,System.UInt64)
// ulong add_g64u(ulong x, ulong y)
// IL
ulong add_g64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.gmath::add<System.UInt64>(System.UInt64,System.UInt64)
    IL_0007: ret
}

// Id := 100664141, Name := System.UInt64 Z0.PrimalScenarios::div_n64u(System.UInt64,System.UInt64)
// ulong div_n64u(ulong x, ulong y)
// IL
ulong div_n64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: div.un
    IL_0003: ret
}

// Id := 100664142, Name := System.UInt64 Z0.PrimalScenarios::div_d64u(System.UInt64,System.UInt64)
// ulong div_d64u(ulong x, ulong y)
// IL
ulong div_d64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.math::div(System.UInt64,System.UInt64)
    IL_0007: ret
}

// Id := 100664143, Name := System.UInt64 Z0.PrimalScenarios::div_g64u(System.UInt64,System.UInt64)
// ulong div_g64u(ulong x, ulong y)
// IL
ulong div_g64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.gmath::div<System.UInt64>(System.UInt64,System.UInt64)
    IL_0007: ret
}

// Id := 100664144, Name := System.UInt64 Z0.PrimalScenarios::mod_n64u(System.UInt64,System.UInt64)
// ulong mod_n64u(ulong x, ulong y)
// IL
ulong mod_n64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: rem.un
    IL_0003: ret
}

// Id := 100664145, Name := System.UInt64 Z0.PrimalScenarios::mod_d64u(System.UInt64,System.UInt64)
// ulong mod_d64u(ulong x, ulong y)
// IL
ulong mod_d64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.math::mod(System.UInt64,System.UInt64)
    IL_0007: ret
}

// Id := 100664146, Name := System.UInt64 Z0.PrimalScenarios::mod_g64u(System.UInt64,System.UInt64)
// ulong mod_g64u(ulong x, ulong y)
// IL
ulong mod_g64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.gmath::mod<System.UInt64>(System.UInt64,System.UInt64)
    IL_0007: ret
}

// Id := 100664147, Name := System.UInt64 Z0.PrimalScenarios::inc_n64u(System.UInt64)
// ulong inc_n64u(ulong x)
// IL
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

// Id := 100664148, Name := System.UInt64 Z0.PrimalScenarios::inc_d64u(System.UInt64)
// ulong inc_d64u(ulong x)
// IL
ulong inc_d64u(ulong x)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt64 Z0.math::inc(System.UInt64)
    IL_0006: ret
}

// Id := 100664149, Name := System.UInt64 Z0.PrimalScenarios::inc_g64u(System.UInt64)
// ulong inc_g64u(ulong x)
// IL
ulong inc_g64u(ulong x)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt64 Z0.gmath::inc<System.UInt64>(System.UInt64)
    IL_0006: ret
}

// Id := 100664150, Name := System.Boolean Z0.PrimalScenarios::gt_n64u(System.UInt64,System.UInt64)
// bool gt_n64u(ulong x, ulong y)
// IL
bool gt_n64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: cgt.un
    IL_0004: ret
}

// Id := 100664151, Name := System.Boolean Z0.PrimalScenarios::gt_d64u(System.UInt64,System.UInt64)
// bool gt_d64u(ulong x, ulong y)
// IL
bool gt_d64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.math::gt(System.UInt64,System.UInt64)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret
}

// Id := 100664152, Name := System.Boolean Z0.PrimalScenarios::gt_g64u(System.UInt64,System.UInt64)
// bool gt_g64u(ulong x, ulong y)
// IL
bool gt_g64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.gmath::gt<System.UInt64>(System.UInt64,System.UInt64)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret
}

// Id := 100664153, Name := System.Boolean Z0.PrimalScenarios::gteq_n64u(System.UInt64,System.UInt64)
// bool gteq_n64u(ulong x, ulong y)
// IL
bool gteq_n64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: clt.un
    IL_0004: ldc.i4.0
    IL_0005: ceq
    IL_0007: ret
}

// Id := 100664154, Name := System.Boolean Z0.PrimalScenarios::gteq_d64u(System.UInt64,System.UInt64)
// bool gteq_d64u(ulong x, ulong y)
// IL
bool gteq_d64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.math::gteq(System.UInt64,System.UInt64)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret
}

// Id := 100664155, Name := System.Boolean Z0.PrimalScenarios::gteq_g64u(System.UInt64,System.UInt64)
// bool gteq_g64u(ulong x, ulong y)
// IL
bool gteq_g64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.gmath::gteq<System.UInt64>(System.UInt64,System.UInt64)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret
}

// Id := 100664156, Name := System.Boolean Z0.PrimalScenarios::eq_n64u(System.UInt64,System.UInt64)
// bool eq_n64u(ulong x, ulong y)
// IL
bool eq_n64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ceq
    IL_0004: ret
}

// Id := 100664157, Name := System.Boolean Z0.PrimalScenarios::eq_d64u(System.UInt64,System.UInt64)
// bool eq_d64u(ulong x, ulong y)
// IL
bool eq_d64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.math::eq(System.UInt64,System.UInt64)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret
}

// Id := 100664158, Name := System.Boolean Z0.PrimalScenarios::eq_g64u(System.UInt64,System.UInt64)
// bool eq_g64u(ulong x, ulong y)
// IL
bool eq_g64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.gmath::eq<System.UInt64>(System.UInt64,System.UInt64)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret
}

// Id := 100664159, Name := System.UInt64 Z0.PrimalScenarios::mul_n64u(System.UInt64,System.UInt64)
// ulong mul_n64u(ulong x, ulong y)
// IL
ulong mul_n64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: mul
    IL_0003: ret
}

// Id := 100664160, Name := System.UInt64 Z0.PrimalScenarios::mul_d64u(System.UInt64,System.UInt64)
// ulong mul_d64u(ulong x, ulong y)
// IL
ulong mul_d64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.math::mul(System.UInt64,System.UInt64)
    IL_0007: ret
}

// Id := 100664161, Name := System.UInt64 Z0.PrimalScenarios::mul_g64u(System.UInt64,System.UInt64)
// ulong mul_g64u(ulong x, ulong y)
// IL
ulong mul_g64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.gmath::mul<System.UInt64>(System.UInt64,System.UInt64)
    IL_0007: ret
}

// Id := 100664162, Name := System.UInt64 Z0.PrimalScenarios::and_n64u(System.UInt64,System.UInt64)
// ulong and_n64u(ulong x, ulong y)
// IL
ulong and_n64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: and
    IL_0003: ret
}

// Id := 100664163, Name := System.UInt64 Z0.PrimalScenarios::and_d64u(System.UInt64,System.UInt64)
// ulong and_d64u(ulong x, ulong y)
// IL
ulong and_d64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.math::and(System.UInt64,System.UInt64)
    IL_0007: ret
}

// Id := 100664164, Name := System.UInt64 Z0.PrimalScenarios::and_g64u(System.UInt64,System.UInt64)
// ulong and_g64u(ulong x, ulong y)
// IL
ulong and_g64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.gmath::and<System.UInt64>(System.UInt64,System.UInt64)
    IL_0007: ret
}

// Id := 100664165, Name := System.UInt64 Z0.PrimalScenarios::or_n64u(System.UInt64,System.UInt64)
// ulong or_n64u(ulong x, ulong y)
// IL
ulong or_n64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: or
    IL_0003: ret
}

// Id := 100664166, Name := System.UInt64 Z0.PrimalScenarios::or_d64u(System.UInt64,System.UInt64)
// ulong or_d64u(ulong x, ulong y)
// IL
ulong or_d64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.math::or(System.UInt64,System.UInt64)
    IL_0007: ret
}

// Id := 100664167, Name := System.UInt64 Z0.PrimalScenarios::or_g64u(System.UInt64,System.UInt64)
// ulong or_g64u(ulong x, ulong y)
// IL
ulong or_g64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.gmath::or<System.UInt64>(System.UInt64,System.UInt64)
    IL_0007: ret
}

// Id := 100664168, Name := System.UInt64 Z0.PrimalScenarios::xor_n64u(System.UInt64,System.UInt64)
// ulong xor_n64u(ulong x, ulong y)
// IL
ulong xor_n64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: xor
    IL_0003: ret
}

// Id := 100664169, Name := System.UInt64 Z0.PrimalScenarios::xor_d64u(System.UInt64,System.UInt64)
// ulong xor_d64u(ulong x, ulong y)
// IL
ulong xor_d64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.math::xor(System.UInt64,System.UInt64)
    IL_0007: ret
}

// Id := 100664170, Name := System.UInt64 Z0.PrimalScenarios::xor_g64u(System.UInt64,System.UInt64)
// ulong xor_g64u(ulong x, ulong y)
// IL
ulong xor_g64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.gmath::xor<System.UInt64>(System.UInt64,System.UInt64)
    IL_0007: ret
}

