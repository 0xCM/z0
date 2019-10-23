// 2019-10-22 17:23:24:281
bit get_Off()
{
    IL_0000: call Z0.bit Z0.bit::get_Off()
    IL_0005: ret

}
bit get_On()
{
    IL_0000: call Z0.bit Z0.bit::get_On()
    IL_0005: ret

}
bit zero()
{
    IL_0000: call Z0.bit Z0.bit::get_Off()
    IL_0005: ret

}
bit identity(bit a)
{
    IL_0000: ldarg.0
    IL_0001: ret

}
bit one()
{
    IL_0000: call Z0.bit Z0.bit::get_On()
    IL_0005: ret

}
bit false(bit a, bit b)
{
    IL_0000: call Z0.bit Z0.Logix.BitOps::get_Off()
    IL_0005: ret

}
bit and(bit a, bit b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.bit::and(Z0.bit,Z0.bit)
    IL_0007: ret

}
bit nand(bit a, bit b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.bit::nand(Z0.bit,Z0.bit)
    IL_0007: ret

}
bit andnot(bit a, bit b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.bit::andnot(Z0.bit,Z0.bit)
    IL_0007: ret

}
bit or(bit a, bit b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.bit::or(Z0.bit,Z0.bit)
    IL_0007: ret

}
bit nor(bit a, bit b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.bit::nor(Z0.bit,Z0.bit)
    IL_0007: ret

}
bit xor(bit a, bit b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.bit::xor(Z0.bit,Z0.bit)
    IL_0007: ret

}
bit xnor(bit a, bit b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.bit::xnor(Z0.bit,Z0.bit)
    IL_0007: ret

}
bit left(bit a, bit b)
{
    IL_0000: ldarg.0
    IL_0001: ret

}
bit right(bit a, bit b)
{
    IL_0000: ldarg.1
    IL_0001: ret

}
bit leftnot(bit a, bit b)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.bit Z0.Logix.BitOps::not(Z0.bit)
    IL_0006: ret

}
bit rightnot(bit a, bit b)
{
    IL_0000: ldarg.1
    IL_0001: call Z0.bit Z0.Logix.BitOps::not(Z0.bit)
    IL_0006: ret

}
bit true(bit a, bit b)
{
    IL_0000: call Z0.bit Z0.Logix.BitOps::get_On()
    IL_0005: ret

}
bit implies(bit antecedent, bit consequent)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.bit::implies(Z0.bit,Z0.bit)
    IL_0007: ret

}
bit not(bit a)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.bit Z0.bit::op_LogicalNot(Z0.bit)
    IL_0006: ret

}
bit xor1(bit a)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.bit Z0.bit::xor1(Z0.bit)
    IL_0006: ret

}
bit select(bit a, bit b, bit c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call Z0.bit Z0.bit::select(Z0.bit,Z0.bit,Z0.bit)
    IL_0008: ret

}
bit f01(bit a, bit b, bit c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call Z0.bit Z0.Logix.BitOps::or(Z0.bit,Z0.bit)
    IL_0008: call Z0.bit Z0.Logix.BitOps::nor(Z0.bit,Z0.bit)
    IL_000D: ret

}
bit f02(bit a, bit b, bit c)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: call Z0.bit Z0.Logix.BitOps::nor(Z0.bit,Z0.bit)
    IL_0008: call Z0.bit Z0.Logix.BitOps::and(Z0.bit,Z0.bit)
    IL_000D: ret

}
bit f03(bit a, bit b, bit c)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call Z0.bit Z0.Logix.BitOps::nor(Z0.bit,Z0.bit)
    IL_0007: ret

}
bit f04(bit a, bit b, bit c)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldarg.2
    IL_0003: call Z0.bit Z0.Logix.BitOps::nor(Z0.bit,Z0.bit)
    IL_0008: call Z0.bit Z0.Logix.BitOps::and(Z0.bit,Z0.bit)
    IL_000D: ret

}
bit f05(bit a, bit b, bit c)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: call Z0.bit Z0.Logix.BitOps::nor(Z0.bit,Z0.bit)
    IL_0007: ret

}
bit f06(bit a, bit b, bit c)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.bit Z0.Logix.BitOps::not(Z0.bit)
    IL_0006: ldarg.1
    IL_0007: ldarg.2
    IL_0008: call Z0.bit Z0.Logix.BitOps::xor(Z0.bit,Z0.bit)
    IL_000D: call Z0.bit Z0.Logix.BitOps::and(Z0.bit,Z0.bit)
    IL_0012: ret

}
bit f07(bit a, bit b, bit c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call Z0.bit Z0.Logix.BitOps::and(Z0.bit,Z0.bit)
    IL_0008: call Z0.bit Z0.Logix.BitOps::nor(Z0.bit,Z0.bit)
    IL_000D: ret

}
bit f08(bit a, bit b, bit c)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.bit Z0.Logix.BitOps::not(Z0.bit)
    IL_0006: ldarg.1
    IL_0007: call Z0.bit Z0.Logix.BitOps::and(Z0.bit,Z0.bit)
    IL_000C: ldarg.2
    IL_000D: call Z0.bit Z0.Logix.BitOps::and(Z0.bit,Z0.bit)
    IL_0012: ret

}
bit f09(bit a, bit b, bit c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call Z0.bit Z0.Logix.BitOps::xor(Z0.bit,Z0.bit)
    IL_0008: call Z0.bit Z0.Logix.BitOps::nor(Z0.bit,Z0.bit)
    IL_000D: ret

}
bit f0a(bit a, bit b, bit c)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: call Z0.bit Z0.Logix.BitOps::not(Z0.bit)
    IL_0007: call Z0.bit Z0.Logix.BitOps::and(Z0.bit,Z0.bit)
    IL_000C: ret

}
bit f0b(bit a, bit b, bit c)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.bit Z0.Logix.BitOps::not(Z0.bit)
    IL_0006: ldarg.1
    IL_0007: call Z0.bit Z0.Logix.BitOps::one()
    IL_000C: call Z0.bit Z0.bit::op_ExclusiveOr(Z0.bit,Z0.bit)
    IL_0011: ldarg.2
    IL_0012: call Z0.bit Z0.Logix.BitOps::or(Z0.bit,Z0.bit)
    IL_0017: call Z0.bit Z0.Logix.BitOps::and(Z0.bit,Z0.bit)
    IL_001C: ret

}
bit f0c(bit a, bit b, bit c)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call Z0.bit Z0.Logix.BitOps::not(Z0.bit)
    IL_0007: call Z0.bit Z0.Logix.BitOps::and(Z0.bit,Z0.bit)
    IL_000C: ret

}
bit f0d(bit a, bit b, bit c)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.bit Z0.Logix.BitOps::not(Z0.bit)
    IL_0006: ldarg.1
    IL_0007: ldarg.2
    IL_0008: call Z0.bit Z0.Logix.BitOps::one()
    IL_000D: call Z0.bit Z0.Logix.BitOps::xor(Z0.bit,Z0.bit)
    IL_0012: call Z0.bit Z0.Logix.BitOps::or(Z0.bit,Z0.bit)
    IL_0017: call Z0.bit Z0.Logix.BitOps::and(Z0.bit,Z0.bit)
    IL_001C: ret

}
bit f0e(bit a, bit b, bit c)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.bit Z0.Logix.BitOps::not(Z0.bit)
    IL_0006: ldarg.1
    IL_0007: ldarg.2
    IL_0008: call Z0.bit Z0.Logix.BitOps::or(Z0.bit,Z0.bit)
    IL_000D: call Z0.bit Z0.Logix.BitOps::and(Z0.bit,Z0.bit)
    IL_0012: ret

}
bit f0f(bit a, bit b, bit c)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.bit Z0.Logix.BitOps::not(Z0.bit)
    IL_0006: ret

}
bit f10(bit a, bit b, bit c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call Z0.bit Z0.Logix.BitOps::nor(Z0.bit,Z0.bit)
    IL_0008: call Z0.bit Z0.Logix.BitOps::and(Z0.bit,Z0.bit)
    IL_000D: ret

}
bit f11(bit a, bit b, bit c)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.Logix.BitOps::nor(Z0.bit,Z0.bit)
    IL_0007: ret

}
bit f12(bit a, bit b, bit c)
{
    IL_0000: ldarg.1
    IL_0001: call Z0.bit Z0.Logix.BitOps::not(Z0.bit)
    IL_0006: ldarg.0
    IL_0007: ldarg.2
    IL_0008: call Z0.bit Z0.Logix.BitOps::xor(Z0.bit,Z0.bit)
    IL_000D: call Z0.bit Z0.Logix.BitOps::and(Z0.bit,Z0.bit)
    IL_0012: ret

}
bit f13(bit a, bit b, bit c)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldarg.2
    IL_0003: call Z0.bit Z0.Logix.BitOps::and(Z0.bit,Z0.bit)
    IL_0008: call Z0.bit Z0.Logix.BitOps::nor(Z0.bit,Z0.bit)
    IL_000D: ret

}
bit f14(bit a, bit b, bit c)
{
    IL_0000: ldarg.2
    IL_0001: call Z0.bit Z0.Logix.BitOps::not(Z0.bit)
    IL_0006: ldarg.0
    IL_0007: ldarg.1
    IL_0008: call Z0.bit Z0.Logix.BitOps::xor(Z0.bit,Z0.bit)
    IL_000D: call Z0.bit Z0.Logix.BitOps::and(Z0.bit,Z0.bit)
    IL_0012: ret

}
bit f15(bit a, bit b, bit c)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: call Z0.bit Z0.Logix.BitOps::and(Z0.bit,Z0.bit)
    IL_0008: call Z0.bit Z0.Logix.BitOps::nor(Z0.bit,Z0.bit)
    IL_000D: ret

}
bit f16(bit a, bit b, bit c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call Z0.bit Z0.Logix.BitOps::nor(Z0.bit,Z0.bit)
    IL_0008: ldarg.1
    IL_0009: ldarg.2
    IL_000A: call Z0.bit Z0.Logix.BitOps::xor(Z0.bit,Z0.bit)
    IL_000F: call Z0.bit Z0.Logix.BitOps::select(Z0.bit,Z0.bit,Z0.bit)
    IL_0014: ret

}
bit f17(bit a, bit b, bit c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call Z0.bit Z0.Logix.BitOps::or(Z0.bit,Z0.bit)
    IL_0008: ldarg.1
    IL_0009: ldarg.2
    IL_000A: call Z0.bit Z0.Logix.BitOps::and(Z0.bit,Z0.bit)
    IL_000F: call Z0.bit Z0.Logix.BitOps::select(Z0.bit,Z0.bit,Z0.bit)
    IL_0014: call Z0.bit Z0.Logix.BitOps::not(Z0.bit)
    IL_0019: ret

}
bit f18(bit a, bit b, bit c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.Logix.BitOps::xor(Z0.bit,Z0.bit)
    IL_0007: ldarg.0
    IL_0008: ldarg.2
    IL_0009: call Z0.bit Z0.Logix.BitOps::xor(Z0.bit,Z0.bit)
    IL_000E: call Z0.bit Z0.Logix.BitOps::and(Z0.bit,Z0.bit)
    IL_0013: ret

}
bit f19(bit a, bit b, bit c)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.2
    IL_0002: call Z0.bit Z0.Logix.BitOps::xor(Z0.bit,Z0.bit)
    IL_0007: ldarg.0
    IL_0008: ldarg.1
    IL_0009: ldarg.2
    IL_000A: call Z0.bit Z0.Logix.BitOps::and(Z0.bit,Z0.bit)
    IL_000F: call Z0.bit Z0.Logix.BitOps::and(Z0.bit,Z0.bit)
    IL_0014: call Z0.bit Z0.Logix.BitOps::xor(Z0.bit,Z0.bit)
    IL_0019: ret

}
bit f1a(bit a, bit b, bit c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.Logix.BitOps::and(Z0.bit,Z0.bit)
    IL_0007: ldarg.0
    IL_0008: ldarg.2
    IL_0009: call Z0.bit Z0.Logix.BitOps::xor(Z0.bit,Z0.bit)
    IL_000E: call Z0.bit Z0.Logix.BitOps::and(Z0.bit,Z0.bit)
    IL_0013: call Z0.bit Z0.Logix.BitOps::not(Z0.bit)
    IL_0018: ret

}
bit f1b(bit a, bit b, bit c)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: call Z0.bit Z0.Logix.BitOps::not(Z0.bit)
    IL_0007: ldarg.1
    IL_0008: call Z0.bit Z0.Logix.BitOps::not(Z0.bit)
    IL_000D: call Z0.bit Z0.Logix.BitOps::select(Z0.bit,Z0.bit,Z0.bit)
    IL_0012: ret

}
bit f1c(bit a, bit b, bit c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.2
    IL_0002: call Z0.bit Z0.Logix.BitOps::and(Z0.bit,Z0.bit)
    IL_0007: call Z0.bit Z0.Logix.BitOps::not(Z0.bit)
    IL_000C: ldarg.0
    IL_000D: ldarg.1
    IL_000E: call Z0.bit Z0.Logix.BitOps::xor(Z0.bit,Z0.bit)
    IL_0013: call Z0.bit Z0.Logix.BitOps::and(Z0.bit,Z0.bit)
    IL_0018: ret

}
bit f1d(bit a, bit b, bit c)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call Z0.bit Z0.Logix.BitOps::not(Z0.bit)
    IL_0007: ldarg.2
    IL_0008: call Z0.bit Z0.Logix.BitOps::not(Z0.bit)
    IL_000D: call Z0.bit Z0.Logix.BitOps::select(Z0.bit,Z0.bit,Z0.bit)
    IL_0012: ret

}
bit f1e(bit a, bit b, bit c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call Z0.bit Z0.Logix.BitOps::or(Z0.bit,Z0.bit)
    IL_0008: call Z0.bit Z0.Logix.BitOps::xor(Z0.bit,Z0.bit)
    IL_000D: ret

}
bit f1f(bit a, bit b, bit c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call Z0.bit Z0.Logix.BitOps::or(Z0.bit,Z0.bit)
    IL_0008: call Z0.bit Z0.Logix.BitOps::nand(Z0.bit,Z0.bit)
    IL_000D: ret

}
bit f20(bit a, bit b, bit c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.Logix.BitOps::andnot(Z0.bit,Z0.bit)
    IL_0007: ldarg.2
    IL_0008: call Z0.bit Z0.Logix.BitOps::and(Z0.bit,Z0.bit)
    IL_000D: ret

}
bit f21(bit a, bit b, bit c)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldarg.2
    IL_0003: call Z0.bit Z0.Logix.BitOps::xor(Z0.bit,Z0.bit)
    IL_0008: call Z0.bit Z0.Logix.BitOps::nor(Z0.bit,Z0.bit)
    IL_000D: ret

}
bit f22(bit a, bit b, bit c)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.Logix.BitOps::andnot(Z0.bit,Z0.bit)
    IL_0007: ret

}
bit f23(bit a, bit b, bit c)
{
    IL_0000: ldarg.1
    IL_0001: call Z0.bit Z0.Logix.BitOps::not(Z0.bit)
    IL_0006: ldarg.0
    IL_0007: call Z0.bit Z0.Logix.BitOps::xor1(Z0.bit)
    IL_000C: ldarg.2
    IL_000D: call Z0.bit Z0.Logix.BitOps::or(Z0.bit,Z0.bit)
    IL_0012: call Z0.bit Z0.Logix.BitOps::and(Z0.bit,Z0.bit)
    IL_0017: ret

}
bit f24(bit a, bit b, bit c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.Logix.BitOps::xor(Z0.bit,Z0.bit)
    IL_0007: ldarg.1
    IL_0008: ldarg.2
    IL_0009: call Z0.bit Z0.Logix.BitOps::xor(Z0.bit,Z0.bit)
    IL_000E: call Z0.bit Z0.Logix.BitOps::and(Z0.bit,Z0.bit)
    IL_0013: ret

}
bit f25(bit a, bit b, bit c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.Logix.BitOps::and(Z0.bit,Z0.bit)
    IL_0007: call Z0.bit Z0.Logix.BitOps::not(Z0.bit)
    IL_000C: ldarg.0
    IL_000D: ldarg.2
    IL_000E: call Z0.bit Z0.Logix.BitOps::xor1(Z0.bit)
    IL_0013: call Z0.bit Z0.Logix.BitOps::xor(Z0.bit,Z0.bit)
    IL_0018: call Z0.bit Z0.Logix.BitOps::and(Z0.bit,Z0.bit)
    IL_001D: ret

}
bit f26(bit a, bit b, bit c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.Logix.BitOps::and(Z0.bit,Z0.bit)
    IL_0007: call Z0.bit Z0.Logix.BitOps::not(Z0.bit)
    IL_000C: ldarg.1
    IL_000D: ldarg.2
    IL_000E: call Z0.bit Z0.Logix.BitOps::xor(Z0.bit,Z0.bit)
    IL_0013: call Z0.bit Z0.Logix.BitOps::and(Z0.bit,Z0.bit)
    IL_0018: ret

}
bit f27(bit a, bit b, bit c)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.Logix.BitOps::not(Z0.bit)
    IL_0007: ldarg.2
    IL_0008: call Z0.bit Z0.Logix.BitOps::not(Z0.bit)
    IL_000D: call Z0.bit Z0.Logix.BitOps::select(Z0.bit,Z0.bit,Z0.bit)
    IL_0012: ret

}
bit f28(bit a, bit b, bit c)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: call Z0.bit Z0.Logix.BitOps::xor(Z0.bit,Z0.bit)
    IL_0008: call Z0.bit Z0.Logix.BitOps::and(Z0.bit,Z0.bit)
    IL_000D: ret

}
bit f29(bit a, bit b, bit c)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: call Z0.bit Z0.Logix.BitOps::xor(Z0.bit,Z0.bit)
    IL_0008: ldarg.1
    IL_0009: ldarg.0
    IL_000A: call Z0.bit Z0.Logix.BitOps::nor(Z0.bit,Z0.bit)
    IL_000F: call Z0.bit Z0.Logix.BitOps::select(Z0.bit,Z0.bit,Z0.bit)
    IL_0014: ret

}
bit f2a(bit a, bit b, bit c)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: call Z0.bit Z0.Logix.BitOps::nand(Z0.bit,Z0.bit)
    IL_0008: call Z0.bit Z0.Logix.BitOps::and(Z0.bit,Z0.bit)
    IL_000D: ret

}
bit f2b(bit a, bit b, bit c)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: call Z0.bit Z0.Logix.BitOps::nand(Z0.bit,Z0.bit)
    IL_0008: ldarg.1
    IL_0009: ldarg.0
    IL_000A: call Z0.bit Z0.Logix.BitOps::nor(Z0.bit,Z0.bit)
    IL_000F: call Z0.bit Z0.Logix.BitOps::select(Z0.bit,Z0.bit,Z0.bit)
    IL_0014: ret

}
bit f2c(bit a, bit b, bit c)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.2
    IL_0002: call Z0.bit Z0.Logix.BitOps::or(Z0.bit,Z0.bit)
    IL_0007: ldarg.0
    IL_0008: ldarg.1
    IL_0009: call Z0.bit Z0.Logix.BitOps::xor(Z0.bit,Z0.bit)
    IL_000E: call Z0.bit Z0.Logix.BitOps::and(Z0.bit,Z0.bit)
    IL_0013: ret

}
bit f2d(bit a, bit b, bit c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call Z0.bit Z0.Logix.BitOps::not(Z0.bit)
    IL_0008: call Z0.bit Z0.Logix.BitOps::or(Z0.bit,Z0.bit)
    IL_000D: call Z0.bit Z0.Logix.BitOps::xor(Z0.bit,Z0.bit)
    IL_0012: ret

}
bit f2e(bit a, bit b, bit c)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.2
    IL_0002: call Z0.bit Z0.Logix.BitOps::or(Z0.bit,Z0.bit)
    IL_0007: ldarg.0
    IL_0008: ldarg.1
    IL_0009: call Z0.bit Z0.Logix.BitOps::or(Z0.bit,Z0.bit)
    IL_000E: call Z0.bit Z0.Logix.BitOps::xor(Z0.bit,Z0.bit)
    IL_0013: ret

}
bit f2f(bit a, bit b, bit c)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.bit Z0.Logix.BitOps::not(Z0.bit)
    IL_0006: ldarg.1
    IL_0007: call Z0.bit Z0.Logix.BitOps::not(Z0.bit)
    IL_000C: ldarg.2
    IL_000D: call Z0.bit Z0.Logix.BitOps::and(Z0.bit,Z0.bit)
    IL_0012: call Z0.bit Z0.Logix.BitOps::or(Z0.bit,Z0.bit)
    IL_0017: ret

}
bit f30(bit a, bit b, bit c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.Logix.BitOps::andnot(Z0.bit,Z0.bit)
    IL_0007: ret

}
bit f31(bit a, bit b, bit c)
{
    IL_0000: ldarg.1
    IL_0001: call Z0.bit Z0.Logix.BitOps::not(Z0.bit)
    IL_0006: ldarg.0
    IL_0007: ldarg.2
    IL_0008: call Z0.bit Z0.Logix.BitOps::xor1(Z0.bit)
    IL_000D: call Z0.bit Z0.Logix.BitOps::or(Z0.bit,Z0.bit)
    IL_0012: call Z0.bit Z0.Logix.BitOps::and(Z0.bit,Z0.bit)
    IL_0017: ret

}
bit f32(bit a, bit b, bit c)
{
    IL_0000: ldarg.1
    IL_0001: call Z0.bit Z0.Logix.BitOps::not(Z0.bit)
    IL_0006: ldarg.0
    IL_0007: ldarg.2
    IL_0008: call Z0.bit Z0.Logix.BitOps::or(Z0.bit,Z0.bit)
    IL_000D: call Z0.bit Z0.Logix.BitOps::and(Z0.bit,Z0.bit)
    IL_0012: ret

}
bit f33(bit a, bit b, bit c)
{
    IL_0000: ldarg.1
    IL_0001: call Z0.bit Z0.Logix.BitOps::not(Z0.bit)
    IL_0006: ret

}
bit f34(bit a, bit b, bit c)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.2
    IL_0002: call Z0.bit Z0.Logix.BitOps::and(Z0.bit,Z0.bit)
    IL_0007: call Z0.bit Z0.Logix.BitOps::not(Z0.bit)
    IL_000C: ldarg.0
    IL_000D: ldarg.1
    IL_000E: call Z0.bit Z0.Logix.BitOps::xor(Z0.bit,Z0.bit)
    IL_0013: call Z0.bit Z0.Logix.BitOps::and(Z0.bit,Z0.bit)
    IL_0018: ret

}
bit f35(bit a, bit b, bit c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.Logix.BitOps::not(Z0.bit)
    IL_0007: ldarg.2
    IL_0008: call Z0.bit Z0.Logix.BitOps::not(Z0.bit)
    IL_000D: call Z0.bit Z0.Logix.BitOps::select(Z0.bit,Z0.bit,Z0.bit)
    IL_0012: ret

}
bit f36(bit a, bit b, bit c)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldarg.2
    IL_0003: call Z0.bit Z0.Logix.BitOps::or(Z0.bit,Z0.bit)
    IL_0008: call Z0.bit Z0.Logix.BitOps::xor(Z0.bit,Z0.bit)
    IL_000D: ret

}
bit f37(bit a, bit b, bit c)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldarg.2
    IL_0003: call Z0.bit Z0.Logix.BitOps::or(Z0.bit,Z0.bit)
    IL_0008: call Z0.bit Z0.Logix.BitOps::nand(Z0.bit,Z0.bit)
    IL_000D: ret

}
bit f38(bit a, bit b, bit c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.2
    IL_0002: call Z0.bit Z0.Logix.BitOps::or(Z0.bit,Z0.bit)
    IL_0007: ldarg.0
    IL_0008: ldarg.1
    IL_0009: call Z0.bit Z0.Logix.BitOps::xor(Z0.bit,Z0.bit)
    IL_000E: call Z0.bit Z0.Logix.BitOps::and(Z0.bit,Z0.bit)
    IL_0013: ret

}
bit f39(bit a, bit b, bit c)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldarg.2
    IL_0003: call Z0.bit Z0.Logix.BitOps::xor1(Z0.bit)
    IL_0008: call Z0.bit Z0.Logix.BitOps::or(Z0.bit,Z0.bit)
    IL_000D: call Z0.bit Z0.Logix.BitOps::xor(Z0.bit,Z0.bit)
    IL_0012: ret

}
bit f3a(bit a, bit b, bit c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.Logix.BitOps::not(Z0.bit)
    IL_0007: ldarg.2
    IL_0008: call Z0.bit Z0.Logix.BitOps::select(Z0.bit,Z0.bit,Z0.bit)
    IL_000D: ret

}
bit f3b(bit a, bit b, bit c)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.bit Z0.Logix.BitOps::not(Z0.bit)
    IL_0006: ldarg.2
    IL_0007: call Z0.bit Z0.Logix.BitOps::and(Z0.bit,Z0.bit)
    IL_000C: ldarg.1
    IL_000D: call Z0.bit Z0.Logix.BitOps::xor1(Z0.bit)
    IL_0012: call Z0.bit Z0.Logix.BitOps::or(Z0.bit,Z0.bit)
    IL_0017: ret

}
bit f3c(bit a, bit b, bit c)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call Z0.bit Z0.Logix.BitOps::xor(Z0.bit,Z0.bit)
    IL_0007: ret

}
bit f3d(bit a, bit b, bit c)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call Z0.bit Z0.Logix.BitOps::xor(Z0.bit,Z0.bit)
    IL_0007: ldarg.0
    IL_0008: ldarg.2
    IL_0009: call Z0.bit Z0.Logix.BitOps::nor(Z0.bit,Z0.bit)
    IL_000E: call Z0.bit Z0.Logix.BitOps::or(Z0.bit,Z0.bit)
    IL_0013: ret

}
bit f3e(bit a, bit b, bit c)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.bit Z0.Logix.BitOps::not(Z0.bit)
    IL_0006: ldarg.2
    IL_0007: call Z0.bit Z0.Logix.BitOps::and(Z0.bit,Z0.bit)
    IL_000C: ldarg.0
    IL_000D: ldarg.1
    IL_000E: call Z0.bit Z0.Logix.BitOps::xor(Z0.bit,Z0.bit)
    IL_0013: call Z0.bit Z0.Logix.BitOps::or(Z0.bit,Z0.bit)
    IL_0018: ret

}
bit f3f(bit a, bit b, bit c)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call Z0.bit Z0.Logix.BitOps::nand(Z0.bit,Z0.bit)
    IL_0007: ret

}
bit f40(bit a, bit b, bit c)
{
    IL_0000: ldarg.2
    IL_0001: call Z0.bit Z0.Logix.BitOps::not(Z0.bit)
    IL_0006: ldarg.0
    IL_0007: call Z0.bit Z0.Logix.BitOps::and(Z0.bit,Z0.bit)
    IL_000C: ldarg.1
    IL_000D: call Z0.bit Z0.Logix.BitOps::and(Z0.bit,Z0.bit)
    IL_0012: ret

}
bit f41(bit a, bit b, bit c)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: call Z0.bit Z0.Logix.BitOps::xor(Z0.bit,Z0.bit)
    IL_0008: call Z0.bit Z0.Logix.BitOps::nor(Z0.bit,Z0.bit)
    IL_000D: ret

}
bit f42(bit a, bit b, bit c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.2
    IL_0002: call Z0.bit Z0.Logix.BitOps::xor(Z0.bit,Z0.bit)
    IL_0007: ldarg.1
    IL_0008: ldarg.2
    IL_0009: call Z0.bit Z0.Logix.BitOps::xor(Z0.bit,Z0.bit)
    IL_000E: call Z0.bit Z0.Logix.BitOps::and(Z0.bit,Z0.bit)
    IL_0013: ret

}
bit f43(bit a, bit b, bit c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.2
    IL_0002: call Z0.bit Z0.Logix.BitOps::and(Z0.bit,Z0.bit)
    IL_0007: call Z0.bit Z0.Logix.BitOps::not(Z0.bit)
    IL_000C: ldarg.0
    IL_000D: ldarg.1
    IL_000E: call Z0.bit Z0.Logix.BitOps::xor1(Z0.bit)
    IL_0013: call Z0.bit Z0.Logix.BitOps::xor(Z0.bit,Z0.bit)
    IL_0018: call Z0.bit Z0.Logix.BitOps::and(Z0.bit,Z0.bit)
    IL_001D: ret

}
bit f44(bit a, bit b, bit c)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.2
    IL_0002: call Z0.bit Z0.Logix.BitOps::andnot(Z0.bit,Z0.bit)
    IL_0007: ret

}
bit f45(bit a, bit b, bit c)
{
    IL_0000: ldarg.2
    IL_0001: call Z0.bit Z0.Logix.BitOps::not(Z0.bit)
    IL_0006: ldarg.0
    IL_0007: call Z0.bit Z0.Logix.BitOps::xor1(Z0.bit)
    IL_000C: ldarg.1
    IL_000D: call Z0.bit Z0.Logix.BitOps::or(Z0.bit,Z0.bit)
    IL_0012: call Z0.bit Z0.Logix.BitOps::and(Z0.bit,Z0.bit)
    IL_0017: ret

}
bit f46(bit a, bit b, bit c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.2
    IL_0002: call Z0.bit Z0.Logix.BitOps::and(Z0.bit,Z0.bit)
    IL_0007: call Z0.bit Z0.Logix.BitOps::not(Z0.bit)
    IL_000C: ldarg.1
    IL_000D: ldarg.2
    IL_000E: call Z0.bit Z0.Logix.BitOps::xor(Z0.bit,Z0.bit)
    IL_0013: call Z0.bit Z0.Logix.BitOps::and(Z0.bit,Z0.bit)
    IL_0018: ret

}
bit f47(bit a, bit b, bit c)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.2
    IL_0002: call Z0.bit Z0.Logix.BitOps::not(Z0.bit)
    IL_0007: ldarg.0
    IL_0008: call Z0.bit Z0.Logix.BitOps::not(Z0.bit)
    IL_000D: call Z0.bit Z0.Logix.BitOps::select(Z0.bit,Z0.bit,Z0.bit)
    IL_0012: ret

}
bit f48(bit a, bit b, bit c)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldarg.2
    IL_0003: call Z0.bit Z0.Logix.BitOps::xor(Z0.bit,Z0.bit)
    IL_0008: call Z0.bit Z0.Logix.BitOps::and(Z0.bit,Z0.bit)
    IL_000D: ret

}
bit f49(bit a, bit b, bit c)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldarg.2
    IL_0003: call Z0.bit Z0.Logix.BitOps::xor(Z0.bit,Z0.bit)
    IL_0008: ldarg.0
    IL_0009: ldarg.2
    IL_000A: call Z0.bit Z0.Logix.BitOps::nor(Z0.bit,Z0.bit)
    IL_000F: call Z0.bit Z0.Logix.BitOps::select(Z0.bit,Z0.bit,Z0.bit)
    IL_0014: ret

}
bit f4a(bit a, bit b, bit c)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.2
    IL_0002: call Z0.bit Z0.Logix.BitOps::or(Z0.bit,Z0.bit)
    IL_0007: ldarg.0
    IL_0008: ldarg.2
    IL_0009: call Z0.bit Z0.Logix.BitOps::xor(Z0.bit,Z0.bit)
    IL_000E: call Z0.bit Z0.Logix.BitOps::and(Z0.bit,Z0.bit)
    IL_0013: ret

}
bit f4b(bit a, bit b, bit c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.Logix.BitOps::not(Z0.bit)
    IL_0007: ldarg.2
    IL_0008: call Z0.bit Z0.Logix.BitOps::or(Z0.bit,Z0.bit)
    IL_000D: call Z0.bit Z0.Logix.BitOps::xor(Z0.bit,Z0.bit)
    IL_0012: ret

}
bit f4c(bit a, bit b, bit c)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldarg.2
    IL_0003: call Z0.bit Z0.Logix.BitOps::nand(Z0.bit,Z0.bit)
    IL_0008: call Z0.bit Z0.Logix.BitOps::and(Z0.bit,Z0.bit)
    IL_000D: ret

}
bit f4d(bit a, bit b, bit c)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldarg.2
    IL_0003: call Z0.bit Z0.Logix.BitOps::nand(Z0.bit,Z0.bit)
    IL_0008: ldarg.0
    IL_0009: ldarg.2
    IL_000A: call Z0.bit Z0.Logix.BitOps::nor(Z0.bit,Z0.bit)
    IL_000F: call Z0.bit Z0.Logix.BitOps::select(Z0.bit,Z0.bit,Z0.bit)
    IL_0014: ret

}
bit f4e(bit a, bit b, bit c)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: call Z0.bit Z0.Logix.BitOps::not(Z0.bit)
    IL_0007: ldarg.1
    IL_0008: call Z0.bit Z0.Logix.BitOps::select(Z0.bit,Z0.bit,Z0.bit)
    IL_000D: ret

}
bit f4f(bit a, bit b, bit c)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.bit Z0.Logix.BitOps::not(Z0.bit)
    IL_0006: ldarg.1
    IL_0007: ldarg.2
    IL_0008: call Z0.bit Z0.Logix.BitOps::andnot(Z0.bit,Z0.bit)
    IL_000D: call Z0.bit Z0.Logix.BitOps::or(Z0.bit,Z0.bit)
    IL_0012: ret

}
bit f50(bit a, bit b, bit c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.2
    IL_0002: call Z0.bit Z0.Logix.BitOps::andnot(Z0.bit,Z0.bit)
    IL_0007: ret

}
bit f51(bit a, bit b, bit c)
{
    IL_0000: ldarg.2
    IL_0001: call Z0.bit Z0.Logix.BitOps::not(Z0.bit)
    IL_0006: ldarg.0
    IL_0007: ldarg.1
    IL_0008: call Z0.bit Z0.Logix.BitOps::xor1(Z0.bit)
    IL_000D: call Z0.bit Z0.Logix.BitOps::or(Z0.bit,Z0.bit)
    IL_0012: call Z0.bit Z0.Logix.BitOps::and(Z0.bit,Z0.bit)
    IL_0017: ret

}
bit f52(bit a, bit b, bit c)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.2
    IL_0002: call Z0.bit Z0.Logix.BitOps::and(Z0.bit,Z0.bit)
    IL_0007: call Z0.bit Z0.Logix.BitOps::not(Z0.bit)
    IL_000C: ldarg.0
    IL_000D: ldarg.2
    IL_000E: call Z0.bit Z0.Logix.BitOps::xor(Z0.bit,Z0.bit)
    IL_0013: call Z0.bit Z0.Logix.BitOps::and(Z0.bit,Z0.bit)
    IL_0018: ret

}
bit f53(bit a, bit b, bit c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.2
    IL_0002: call Z0.bit Z0.Logix.BitOps::not(Z0.bit)
    IL_0007: ldarg.1
    IL_0008: call Z0.bit Z0.Logix.BitOps::not(Z0.bit)
    IL_000D: call Z0.bit Z0.Logix.BitOps::select(Z0.bit,Z0.bit,Z0.bit)
    IL_0012: ret

}
bit f54(bit a, bit b, bit c)
{
    IL_0000: ldarg.2
    IL_0001: call Z0.bit Z0.Logix.BitOps::not(Z0.bit)
    IL_0006: ldarg.0
    IL_0007: ldarg.1
    IL_0008: call Z0.bit Z0.Logix.BitOps::or(Z0.bit,Z0.bit)
    IL_000D: call Z0.bit Z0.Logix.BitOps::and(Z0.bit,Z0.bit)
    IL_0012: ret

}
bit f55(bit a, bit b, bit c)
{
    IL_0000: ldarg.2
    IL_0001: call Z0.bit Z0.Logix.BitOps::not(Z0.bit)
    IL_0006: ret

}
bit f56(bit a, bit b, bit c)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: call Z0.bit Z0.Logix.BitOps::or(Z0.bit,Z0.bit)
    IL_0008: call Z0.bit Z0.Logix.BitOps::xor(Z0.bit,Z0.bit)
    IL_000D: ret

}
bit f57(bit a, bit b, bit c)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: call Z0.bit Z0.Logix.BitOps::or(Z0.bit,Z0.bit)
    IL_0008: call Z0.bit Z0.Logix.BitOps::nand(Z0.bit,Z0.bit)
    IL_000D: ret

}
bit f58(bit a, bit b, bit c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.Logix.BitOps::or(Z0.bit,Z0.bit)
    IL_0007: ldarg.0
    IL_0008: ldarg.2
    IL_0009: call Z0.bit Z0.Logix.BitOps::xor(Z0.bit,Z0.bit)
    IL_000E: call Z0.bit Z0.Logix.BitOps::and(Z0.bit,Z0.bit)
    IL_0013: ret

}
bit f59(bit a, bit b, bit c)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: call Z0.bit Z0.Logix.BitOps::xor1(Z0.bit)
    IL_0008: call Z0.bit Z0.Logix.BitOps::or(Z0.bit,Z0.bit)
    IL_000D: call Z0.bit Z0.Logix.BitOps::xor(Z0.bit,Z0.bit)
    IL_0012: ret

}
bit f5a(bit a, bit b, bit c)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: call Z0.bit Z0.Logix.BitOps::xor(Z0.bit,Z0.bit)
    IL_0007: ret

}
bit f5b(bit a, bit b, bit c)
{
    IL_0000: ldloca.s V_0
    IL_0002: initobj Z0.bit
    IL_0008: ldloc.0
    IL_0009: ret

}
bit f5c(bit a, bit b, bit c)
{
    IL_0000: ldloca.s V_0
    IL_0002: initobj Z0.bit
    IL_0008: ldloc.0
    IL_0009: ret

}
bit f5d(bit a, bit b, bit c)
{
    IL_0000: ldloca.s V_0
    IL_0002: initobj Z0.bit
    IL_0008: ldloc.0
    IL_0009: ret

}
bit f5e(bit a, bit b, bit c)
{
    IL_0000: ldloca.s V_0
    IL_0002: initobj Z0.bit
    IL_0008: ldloc.0
    IL_0009: ret

}
bit f5f(bit a, bit b, bit c)
{
    IL_0000: ldloca.s V_0
    IL_0002: initobj Z0.bit
    IL_0008: ldloc.0
    IL_0009: ret

}
bit faa(bit a, bit b, bit c)
{
    IL_0000: ldarg.2
    IL_0001: ret

}
