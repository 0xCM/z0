// 2019-10-12 06:44:41:128
Bit and(Bit a, Bit b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Bit Z0.Bit::op_BitwiseOr(Z0.Bit,Z0.Bit)
    IL_0007: ret

}
Bit or(Bit a, Bit b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Bit Z0.Bit::op_BitwiseOr(Z0.Bit,Z0.Bit)
    IL_0007: ret

}
Bit xor(Bit a, Bit b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Bit Z0.Bit::op_ExclusiveOr(Z0.Bit,Z0.Bit)
    IL_0007: ret

}
Bit not(Bit a)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Bit Z0.Bit::op_OnesComplement(Z0.Bit)
    IL_0006: ret

}
Bit nand(Bit a, Bit b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Bit Z0.Bit::op_BitwiseAnd(Z0.Bit,Z0.Bit)
    IL_0007: call Z0.Bit Z0.Bit::op_OnesComplement(Z0.Bit)
    IL_000C: ret

}
Bit nor(Bit a, Bit b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Bit Z0.Bit::op_BitwiseOr(Z0.Bit,Z0.Bit)
    IL_0007: call Z0.Bit Z0.Bit::op_OnesComplement(Z0.Bit)
    IL_000C: ret

}
Bit xnor(Bit a, Bit b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Bit Z0.Bit::op_ExclusiveOr(Z0.Bit,Z0.Bit)
    IL_0007: call Z0.Bit Z0.Bit::op_OnesComplement(Z0.Bit)
    IL_000C: ret

}
Bit select(Bit a, Bit b, Bit c)
{
    IL_0000: ldarg.0
    IL_0001: call System.Boolean Z0.Bit::op_Implicit(Z0.Bit)
    IL_0006: brtrue.s IL_000A
    IL_0008: ldarg.2
    IL_0009: ret
    IL_000A: ldarg.1
    IL_000B: ret

}
Bit f01(Bit a, Bit b, Bit c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call Z0.Bit Z0.BitLogic::or(Z0.Bit,Z0.Bit)
    IL_0008: call Z0.Bit Z0.BitLogic::nor(Z0.Bit,Z0.Bit)
    IL_000D: ret

}
Bit f02(Bit a, Bit b, Bit c)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: call Z0.Bit Z0.BitLogic::nor(Z0.Bit,Z0.Bit)
    IL_0008: call Z0.Bit Z0.BitLogic::and(Z0.Bit,Z0.Bit)
    IL_000D: ret

}
Bit f03(Bit a, Bit b, Bit c)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call Z0.Bit Z0.BitLogic::nor(Z0.Bit,Z0.Bit)
    IL_0007: ret

}
Bit f04(Bit a, Bit b, Bit c)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldarg.2
    IL_0003: call Z0.Bit Z0.BitLogic::nor(Z0.Bit,Z0.Bit)
    IL_0008: call Z0.Bit Z0.BitLogic::and(Z0.Bit,Z0.Bit)
    IL_000D: ret

}
Bit f05(Bit a, Bit b, Bit c)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: call Z0.Bit Z0.BitLogic::nor(Z0.Bit,Z0.Bit)
    IL_0007: ret

}
Bit f06(Bit a, Bit b, Bit c)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Bit Z0.BitLogic::not(Z0.Bit)
    IL_0006: ldarg.1
    IL_0007: ldarg.2
    IL_0008: call Z0.Bit Z0.BitLogic::xor(Z0.Bit,Z0.Bit)
    IL_000D: call Z0.Bit Z0.BitLogic::and(Z0.Bit,Z0.Bit)
    IL_0012: ret

}
Bit f07(Bit a, Bit b, Bit c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call Z0.Bit Z0.BitLogic::and(Z0.Bit,Z0.Bit)
    IL_0008: call Z0.Bit Z0.BitLogic::nor(Z0.Bit,Z0.Bit)
    IL_000D: ret

}
Bit f08(Bit a, Bit b, Bit c)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Bit Z0.BitLogic::not(Z0.Bit)
    IL_0006: ldarg.1
    IL_0007: call Z0.Bit Z0.BitLogic::and(Z0.Bit,Z0.Bit)
    IL_000C: ldarg.2
    IL_000D: call Z0.Bit Z0.BitLogic::and(Z0.Bit,Z0.Bit)
    IL_0012: ret

}
Bit f09(Bit a, Bit b, Bit c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call Z0.Bit Z0.BitLogic::xor(Z0.Bit,Z0.Bit)
    IL_0008: call Z0.Bit Z0.BitLogic::nor(Z0.Bit,Z0.Bit)
    IL_000D: ret

}
Bit f0A(Bit a, Bit b, Bit c)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: call Z0.Bit Z0.BitLogic::not(Z0.Bit)
    IL_0007: call Z0.Bit Z0.BitLogic::and(Z0.Bit,Z0.Bit)
    IL_000C: ret

}
Bit f0B(Bit a, Bit b, Bit c)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Bit Z0.BitLogic::not(Z0.Bit)
    IL_0006: ldarg.1
    IL_0007: ldsfld Z0.Bit Z0.BitLogic::one
    IL_000C: call Z0.Bit Z0.Bit::op_ExclusiveOr(Z0.Bit,Z0.Bit)
    IL_0011: ldarg.2
    IL_0012: call Z0.Bit Z0.BitLogic::or(Z0.Bit,Z0.Bit)
    IL_0017: call Z0.Bit Z0.BitLogic::and(Z0.Bit,Z0.Bit)
    IL_001C: ret

}
Bit f0C(Bit a, Bit b, Bit c)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call Z0.Bit Z0.BitLogic::not(Z0.Bit)
    IL_0007: call Z0.Bit Z0.BitLogic::and(Z0.Bit,Z0.Bit)
    IL_000C: ret

}
Bit f0D(Bit a, Bit b, Bit c)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Bit Z0.BitLogic::not(Z0.Bit)
    IL_0006: ldarg.1
    IL_0007: ldarg.2
    IL_0008: ldsfld Z0.Bit Z0.BitLogic::one
    IL_000D: call Z0.Bit Z0.BitLogic::xor(Z0.Bit,Z0.Bit)
    IL_0012: call Z0.Bit Z0.BitLogic::or(Z0.Bit,Z0.Bit)
    IL_0017: call Z0.Bit Z0.BitLogic::and(Z0.Bit,Z0.Bit)
    IL_001C: ret

}
Bit f0E(Bit a, Bit b, Bit c)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Bit Z0.BitLogic::not(Z0.Bit)
    IL_0006: ldarg.1
    IL_0007: ldarg.2
    IL_0008: call Z0.Bit Z0.BitLogic::or(Z0.Bit,Z0.Bit)
    IL_000D: call Z0.Bit Z0.BitLogic::and(Z0.Bit,Z0.Bit)
    IL_0012: ret

}
Bit f0F(Bit a, Bit b, Bit c)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Bit Z0.BitLogic::not(Z0.Bit)
    IL_0006: ret

}
Bit f10(Bit a, Bit b, Bit c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call Z0.Bit Z0.BitLogic::nor(Z0.Bit,Z0.Bit)
    IL_0008: call Z0.Bit Z0.BitLogic::and(Z0.Bit,Z0.Bit)
    IL_000D: ret

}
Bit f11(Bit a, Bit b, Bit c)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.1
    IL_0002: call Z0.Bit Z0.BitLogic::nor(Z0.Bit,Z0.Bit)
    IL_0007: ret

}
Bit f12(Bit a, Bit b, Bit c)
{
    IL_0000: ldarg.1
    IL_0001: call Z0.Bit Z0.BitLogic::not(Z0.Bit)
    IL_0006: ldarg.0
    IL_0007: ldarg.2
    IL_0008: call Z0.Bit Z0.BitLogic::xor(Z0.Bit,Z0.Bit)
    IL_000D: call Z0.Bit Z0.BitLogic::and(Z0.Bit,Z0.Bit)
    IL_0012: ret

}
