// 2019-11-14 10:18:55:363
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
