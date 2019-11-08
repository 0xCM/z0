// 2019-11-08 02:45:46:774
float abs_g32f(float x)
{
    IL_0000: ldarg.0
    IL_0001: call System.Single Z0.gfp::abs<System.Single>(System.Single)
    IL_0006: ret

}
float abs_d32f(float x)
{
    IL_0000: ldarg.0
    IL_0001: call System.Single Z0.fmath::abs(System.Single)
    IL_0006: ret

}
float square_g32f(float x)
{
    IL_0000: ldarg.0
    IL_0001: call System.Single Z0.gfp::square<System.Single>(System.Single)
    IL_0006: ret

}
double abs_d64f(double x)
{
    IL_0000: ldarg.0
    IL_0001: call System.Double Z0.fmath::abs(System.Double)
    IL_0006: ret

}
double abs_g64f(double x)
{
    IL_0000: ldarg.0
    IL_0001: call System.Double Z0.gfp::abs<System.Double>(System.Double)
    IL_0006: ret

}
float add_d32f(float lhs, float rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Single Z0.fmath::add(System.Single,System.Single)
    IL_0007: ret

}
float add_g32f(float lhs, float rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Single Z0.gfp::add<System.Single>(System.Single,System.Single)
    IL_0007: ret

}
double add_d64f(double lhs, double rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Double Z0.fmath::add(System.Double,System.Double)
    IL_0007: ret

}
double add_g64f(double lhs, double rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Double Z0.gfp::add<System.Double>(System.Double,System.Double)
    IL_0007: ret

}
bool between_d32f(float x, float a, float b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.Boolean Z0.fmath::between(System.Single,System.Single,System.Single)
    IL_0008: ret

}
bool between_g32f(float x, float a, float b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call Z0.bit Z0.gmath::between<System.Single>(System.Single,System.Single,System.Single)
    IL_0008: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000D: ret

}
bool between_d64f(double x, double a, double b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.Boolean Z0.fmath::between(System.Double,System.Double,System.Double)
    IL_0008: ret

}
bool between_g64f(double x, double a, double b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call Z0.bit Z0.gmath::between<System.Double>(System.Double,System.Double,System.Double)
    IL_0008: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000D: ret

}
float dec_g32f(float x)
{
    IL_0000: ldarg.0
    IL_0001: call System.Single Z0.gfp::dec<System.Single>(System.Single)
    IL_0006: ret

}
float dec_d32f(float x)
{
    IL_0000: ldarg.0
    IL_0001: call System.Single Z0.fmath::dec(System.Single)
    IL_0006: ret

}
double dec_d64f(double x)
{
    IL_0000: ldarg.0
    IL_0001: call System.Double Z0.fmath::dec(System.Double)
    IL_0006: ret

}
double dec_g64f(double x)
{
    IL_0000: ldarg.0
    IL_0001: call System.Double Z0.gfp::dec<System.Double>(System.Double)
    IL_0006: ret

}
float inc_g32f(float x)
{
    IL_0000: ldarg.0
    IL_0001: call System.Single Z0.gfp::inc<System.Single>(System.Single)
    IL_0006: ret

}
float inc_d32f(float x)
{
    IL_0000: ldarg.0
    IL_0001: call System.Single Z0.fmath::inc(System.Single)
    IL_0006: ret

}
double inc_d64f(double x)
{
    IL_0000: ldarg.0
    IL_0001: call System.Double Z0.fmath::inc(System.Double)
    IL_0006: ret

}
double inc_g64f(double x)
{
    IL_0000: ldarg.0
    IL_0001: call System.Double Z0.gfp::inc<System.Double>(System.Double)
    IL_0006: ret

}
bool lt_d32f(float lhs, float rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.fmath::lt(System.Single,System.Single)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret

}
bool lt_g32f(float lhs, float rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.gfp::lt<System.Single>(System.Single,System.Single)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret

}
bool lt_d64f(double lhs, double rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.fmath::lt(System.Double,System.Double)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret

}
bool lt_g64f(double lhs, double rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.gfp::lt<System.Double>(System.Double,System.Double)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret

}
bool lteq_d32f(float lhs, float rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.fmath::lteq(System.Single,System.Single)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret

}
bool lteq_g32f(float lhs, float rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.gfp::lteq<System.Single>(System.Single,System.Single)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret

}
bool lteq_d64f(double lhs, double rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.fmath::lteq(System.Double,System.Double)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret

}
bool lteq_g64f(double lhs, double rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.gfp::lteq<System.Double>(System.Double,System.Double)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret

}
float max_d32f(float lhs, float rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Single Z0.fmath::max(System.Single,System.Single)
    IL_0007: ret

}
float max_g32f(float lhs, float rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Single Z0.gfp::max<System.Single>(System.Single,System.Single)
    IL_0007: ret

}
double max_d64f(double lhs, double rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Double Z0.fmath::max(System.Double,System.Double)
    IL_0007: ret

}
double max_g64f(double lhs, double rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Double Z0.gfp::max<System.Double>(System.Double,System.Double)
    IL_0007: ret

}
float min_d32f(float lhs, float rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Single Z0.fmath::min(System.Single,System.Single)
    IL_0007: ret

}
float min_g32f(float lhs, float rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Single Z0.gfp::min<System.Single>(System.Single,System.Single)
    IL_0007: ret

}
double min_d64f(double lhs, double rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Double Z0.fmath::min(System.Double,System.Double)
    IL_0007: ret

}
double min_g64f(double lhs, double rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Double Z0.gfp::min<System.Double>(System.Double,System.Double)
    IL_0007: ret

}
float mul_d32f(float lhs, float rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Single Z0.fmath::mul(System.Single,System.Single)
    IL_0007: ret

}
float mul_g32f(float lhs, float rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Single Z0.gfp::mul<System.Single>(System.Single,System.Single)
    IL_0007: ret

}
double mul_d64f(double lhs, double rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Double Z0.fmath::mul(System.Double,System.Double)
    IL_0007: ret

}
double mul_g64f(double lhs, double rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Double Z0.gfp::mul<System.Double>(System.Double,System.Double)
    IL_0007: ret

}
bool negative_n32f(float x)
{
    IL_0000: ldarg.0
    IL_0001: ldc.r4 0
    IL_0006: clt
    IL_0008: ret

}
bool negative_g32f(float x)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.bit Z0.gmath::negative<System.Single>(System.Single)
    IL_0006: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000B: ret

}
bool negative_n64f(double x)
{
    IL_0000: ldarg.0
    IL_0001: ldc.r8 0
    IL_000A: clt
    IL_000C: ret

}
bool negative_g64f(double x)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.bit Z0.gmath::negative<System.Double>(System.Double)
    IL_0006: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000B: ret

}
bool nonzero_n32f(float x)
{
    IL_0000: ldarg.0
    IL_0001: ldc.r4 0
    IL_0006: ceq
    IL_0008: ldc.i4.0
    IL_0009: ceq
    IL_000B: ret

}
bool nonzero_g32f(float x)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.bit Z0.gmath::nonzero<System.Single>(System.Single)
    IL_0006: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000B: ret

}
bool nonzero_n64f(double x)
{
    IL_0000: ldarg.0
    IL_0001: ldc.r8 0
    IL_000A: ceq
    IL_000C: ldc.i4.0
    IL_000D: ceq
    IL_000F: ret

}
bool nonzero_g64f(double x)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.bit Z0.gmath::nonzero<System.Double>(System.Double)
    IL_0006: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000B: ret

}
bool positive_n32f(float x)
{
    IL_0000: ldarg.0
    IL_0001: ldc.r4 0
    IL_0006: cgt
    IL_0008: ret

}
bool positive_g32f(float x)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.bit Z0.gmath::positive<System.Single>(System.Single)
    IL_0006: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000B: ret

}
bool positive_n64f(double x)
{
    IL_0000: ldarg.0
    IL_0001: ldc.r8 0
    IL_000A: cgt
    IL_000C: ret

}
bool positive_g64f(double x)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.bit Z0.gmath::positive<System.Double>(System.Double)
    IL_0006: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000B: ret

}
float pow_d32f(float b, uint exp)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: conv.r.un
    IL_0003: conv.r4
    IL_0004: call System.Single Z0.fmath::pow(System.Single,System.Single)
    IL_0009: ret

}
float pow_g32f(float b, uint exp)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Single Z0.gfp::pow<System.Single>(System.Single,System.UInt32)
    IL_0007: ret

}
double pow_d64f(double b, uint exp)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: conv.r.un
    IL_0003: conv.r8
    IL_0004: call System.Double Z0.fmath::pow(System.Double,System.Double)
    IL_0009: ret

}
double pow_g64f(double b, uint exp)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Double Z0.gfp::pow<System.Double>(System.Double,System.UInt32)
    IL_0007: ret

}
float square_d32f(float x)
{
    IL_0000: ldarg.0
    IL_0001: call System.Single Z0.fmath::square(System.Single)
    IL_0006: ret

}
double square_d64f(double x)
{
    IL_0000: ldarg.0
    IL_0001: call System.Double Z0.fmath::square(System.Double)
    IL_0006: ret

}
double square_g64f(double x)
{
    IL_0000: ldarg.0
    IL_0001: call System.Double Z0.gfp::square<System.Double>(System.Double)
    IL_0006: ret

}
Sign:int signum_g32f(float x)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Sign Z0.gfp::signum<System.Single>(System.Single)
    IL_0006: ret

}
Sign:int signum_d32f(float x)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Sign Z0.fmath::signum(System.Single)
    IL_0006: ret

}
Sign:int signum_d64f(double x)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Sign Z0.fmath::signum(System.Double)
    IL_0006: ret

}
Sign:int signum_g64f(double x)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Sign Z0.gfp::signum<System.Double>(System.Double)
    IL_0006: ret

}
float sub_d32f(float lhs, float rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Single Z0.fmath::sub(System.Single,System.Single)
    IL_0007: ret

}
float sub_g32f(float lhs, float rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Single Z0.gfp::sub<System.Single>(System.Single,System.Single)
    IL_0007: ret

}
double sub_d64f(double lhs, double rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Double Z0.fmath::sub(System.Double,System.Double)
    IL_0007: ret

}
double sub_g64f(double lhs, double rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Double Z0.gfp::sub<System.Double>(System.Double,System.Double)
    IL_0007: ret

}
float xor_d32f(float lhs, float rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Single Z0.fmath::xor(System.Single,System.Single)
    IL_0007: ret

}
float xor_g32f(float lhs, float rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Single Z0.gfp::xor<System.Single>(System.Single,System.Single)
    IL_0007: ret

}
double xor_d64f(double lhs, double rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Double Z0.fmath::xor(System.Double,System.Double)
    IL_0007: ret

}
double xor_g64f(double lhs, double rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Double Z0.gfp::xor<System.Double>(System.Double,System.Double)
    IL_0007: ret

}
