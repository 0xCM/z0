// 2019-10-15 01:38:29:730
Bit and(Bit a, Bit b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Bit Z0.Bit::op_BitwiseAnd(Z0.Bit,Z0.Bit)
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
    IL_0001: call Z0.Bit Z0.Bit::op_LogicalNot(Z0.Bit)
    IL_0006: ret

}
Bit nor(Bit a, Bit b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Bit Z0.BitOps::or(Z0.Bit,Z0.Bit)
    IL_0007: call Z0.Bit Z0.BitOps::not(Z0.Bit)
    IL_000C: ret

}
Bit xnor(Bit a, Bit b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Bit Z0.BitOps::xor(Z0.Bit,Z0.Bit)
    IL_0007: call Z0.Bit Z0.BitOps::not(Z0.Bit)
    IL_000C: ret

}
Bit nand(Bit a, Bit b)
{
    IL_0000: ldarg.0
    IL_0001: ldsfld Z0.Bit Z0.Bit::Off
    IL_0006: call System.Boolean Z0.Bit::op_Equality(Z0.Bit,Z0.Bit)
    IL_000B: brtrue.s IL_001A
    IL_000D: ldarg.1
    IL_000E: ldsfld Z0.Bit Z0.Bit::Off
    IL_0013: call System.Boolean Z0.Bit::op_Equality(Z0.Bit,Z0.Bit)
    IL_0018: br.s IL_001B
    IL_001A: ldc.i4.1
    IL_001B: call Z0.Bit Z0.Bit::op_Implicit(System.Boolean)
    IL_0020: ret

}
Bit implies(Bit antecedent, Bit consequent)
{
    IL_0000: ldarg.0
    IL_0001: ldsfld Z0.Bit Z0.Bit::On
    IL_0006: call System.Boolean Z0.Bit::op_Equality(Z0.Bit,Z0.Bit)
    IL_000B: brfalse.s IL_001A
    IL_000D: ldarg.1
    IL_000E: ldsfld Z0.Bit Z0.Bit::Off
    IL_0013: call System.Boolean Z0.Bit::op_Equality(Z0.Bit,Z0.Bit)
    IL_0018: br.s IL_001B
    IL_001A: ldc.i4.0
    IL_001B: call Z0.Bit Z0.Bit::op_Implicit(System.Boolean)
    IL_0020: call Z0.Bit Z0.BitOps::not(Z0.Bit)
    IL_0025: ret

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
