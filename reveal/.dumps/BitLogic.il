// 2019-10-18 00:25:29:487
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
    IL_0003: call Z0.bit Z0.BitLogic::or(Z0.bit,Z0.bit)
    IL_0008: call Z0.bit Z0.BitLogic::nor(Z0.bit,Z0.bit)
    IL_000D: ret

}
bit f02(bit a, bit b, bit c)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: call Z0.bit Z0.BitLogic::nor(Z0.bit,Z0.bit)
    IL_0008: call Z0.bit Z0.BitLogic::and(Z0.bit,Z0.bit)
    IL_000D: ret

}
bit f03(bit a, bit b, bit c)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call Z0.bit Z0.BitLogic::nor(Z0.bit,Z0.bit)
    IL_0007: ret

}
bit f04(bit a, bit b, bit c)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldarg.2
    IL_0003: call Z0.bit Z0.BitLogic::nor(Z0.bit,Z0.bit)
    IL_0008: call Z0.bit Z0.BitLogic::and(Z0.bit,Z0.bit)
    IL_000D: ret

}
bit f05(bit a, bit b, bit c)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: call Z0.bit Z0.BitLogic::nor(Z0.bit,Z0.bit)
    IL_0007: ret

}
bit f06(bit a, bit b, bit c)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.bit Z0.BitLogic::not(Z0.bit)
    IL_0006: ldarg.1
    IL_0007: ldarg.2
    IL_0008: call Z0.bit Z0.BitLogic::xor(Z0.bit,Z0.bit)
    IL_000D: call Z0.bit Z0.BitLogic::and(Z0.bit,Z0.bit)
    IL_0012: ret

}
bit f07(bit a, bit b, bit c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call Z0.bit Z0.BitLogic::and(Z0.bit,Z0.bit)
    IL_0008: call Z0.bit Z0.BitLogic::nor(Z0.bit,Z0.bit)
    IL_000D: ret

}
bit f08(bit a, bit b, bit c)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.bit Z0.BitLogic::not(Z0.bit)
    IL_0006: ldarg.1
    IL_0007: call Z0.bit Z0.BitLogic::and(Z0.bit,Z0.bit)
    IL_000C: ldarg.2
    IL_000D: call Z0.bit Z0.BitLogic::and(Z0.bit,Z0.bit)
    IL_0012: ret

}
bit f09(bit a, bit b, bit c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call Z0.bit Z0.BitLogic::xor(Z0.bit,Z0.bit)
    IL_0008: call Z0.bit Z0.BitLogic::nor(Z0.bit,Z0.bit)
    IL_000D: ret

}
bit f0a(bit a, bit b, bit c)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: call Z0.bit Z0.BitLogic::not(Z0.bit)
    IL_0007: call Z0.bit Z0.BitLogic::and(Z0.bit,Z0.bit)
    IL_000C: ret

}
bit f0b(bit a, bit b, bit c)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.bit Z0.BitLogic::not(Z0.bit)
    IL_0006: ldarg.1
    IL_0007: call Z0.bit Z0.BitLogic::one()
    IL_000C: call Z0.bit Z0.bit::op_ExclusiveOr(Z0.bit,Z0.bit)
    IL_0011: ldarg.2
    IL_0012: call Z0.bit Z0.BitLogic::or(Z0.bit,Z0.bit)
    IL_0017: call Z0.bit Z0.BitLogic::and(Z0.bit,Z0.bit)
    IL_001C: ret

}
bit f0c(bit a, bit b, bit c)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call Z0.bit Z0.BitLogic::not(Z0.bit)
    IL_0007: call Z0.bit Z0.BitLogic::and(Z0.bit,Z0.bit)
    IL_000C: ret

}
bit f0d(bit a, bit b, bit c)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.bit Z0.BitLogic::not(Z0.bit)
    IL_0006: ldarg.1
    IL_0007: ldarg.2
    IL_0008: call Z0.bit Z0.BitLogic::one()
    IL_000D: call Z0.bit Z0.BitLogic::xor(Z0.bit,Z0.bit)
    IL_0012: call Z0.bit Z0.BitLogic::or(Z0.bit,Z0.bit)
    IL_0017: call Z0.bit Z0.BitLogic::and(Z0.bit,Z0.bit)
    IL_001C: ret

}
bit f0e(bit a, bit b, bit c)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.bit Z0.BitLogic::not(Z0.bit)
    IL_0006: ldarg.1
    IL_0007: ldarg.2
    IL_0008: call Z0.bit Z0.BitLogic::or(Z0.bit,Z0.bit)
    IL_000D: call Z0.bit Z0.BitLogic::and(Z0.bit,Z0.bit)
    IL_0012: ret

}
bit f0f(bit a, bit b, bit c)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.bit Z0.BitLogic::not(Z0.bit)
    IL_0006: ret

}
bit f10(bit a, bit b, bit c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call Z0.bit Z0.BitLogic::nor(Z0.bit,Z0.bit)
    IL_0008: call Z0.bit Z0.BitLogic::and(Z0.bit,Z0.bit)
    IL_000D: ret

}
bit f11(bit a, bit b, bit c)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.BitLogic::nor(Z0.bit,Z0.bit)
    IL_0007: ret

}
bit f12(bit a, bit b, bit c)
{
    IL_0000: ldarg.1
    IL_0001: call Z0.bit Z0.BitLogic::not(Z0.bit)
    IL_0006: ldarg.0
    IL_0007: ldarg.2
    IL_0008: call Z0.bit Z0.BitLogic::xor(Z0.bit,Z0.bit)
    IL_000D: call Z0.bit Z0.BitLogic::and(Z0.bit,Z0.bit)
    IL_0012: ret

}
bit f13(bit a, bit b, bit c)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldarg.2
    IL_0003: call Z0.bit Z0.BitLogic::and(Z0.bit,Z0.bit)
    IL_0008: call Z0.bit Z0.BitLogic::nor(Z0.bit,Z0.bit)
    IL_000D: ret

}
bit f14(bit a, bit b, bit c)
{
    IL_0000: ldarg.2
    IL_0001: call Z0.bit Z0.BitLogic::not(Z0.bit)
    IL_0006: ldarg.0
    IL_0007: ldarg.1
    IL_0008: call Z0.bit Z0.BitLogic::xor(Z0.bit,Z0.bit)
    IL_000D: call Z0.bit Z0.BitLogic::and(Z0.bit,Z0.bit)
    IL_0012: ret

}
bit f15(bit a, bit b, bit c)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: call Z0.bit Z0.BitLogic::and(Z0.bit,Z0.bit)
    IL_0008: call Z0.bit Z0.BitLogic::nor(Z0.bit,Z0.bit)
    IL_000D: ret

}
bit f16(bit a, bit b, bit c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call Z0.bit Z0.BitLogic::nor(Z0.bit,Z0.bit)
    IL_0008: ldarg.1
    IL_0009: ldarg.2
    IL_000A: call Z0.bit Z0.BitLogic::xor(Z0.bit,Z0.bit)
    IL_000F: call Z0.bit Z0.BitLogic::select(Z0.bit,Z0.bit,Z0.bit)
    IL_0014: ret

}
bit f17(bit a, bit b, bit c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call Z0.bit Z0.BitLogic::or(Z0.bit,Z0.bit)
    IL_0008: ldarg.1
    IL_0009: ldarg.2
    IL_000A: call Z0.bit Z0.BitLogic::and(Z0.bit,Z0.bit)
    IL_000F: call Z0.bit Z0.BitLogic::select(Z0.bit,Z0.bit,Z0.bit)
    IL_0014: call Z0.bit Z0.BitLogic::not(Z0.bit)
    IL_0019: ret

}
bit f18(bit a, bit b, bit c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.BitLogic::xor(Z0.bit,Z0.bit)
    IL_0007: ldarg.0
    IL_0008: ldarg.2
    IL_0009: call Z0.bit Z0.BitLogic::xor(Z0.bit,Z0.bit)
    IL_000E: call Z0.bit Z0.BitLogic::and(Z0.bit,Z0.bit)
    IL_0013: ret

}
bit f19(bit a, bit b, bit c)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.2
    IL_0002: call Z0.bit Z0.BitLogic::xor(Z0.bit,Z0.bit)
    IL_0007: ldarg.0
    IL_0008: ldarg.1
    IL_0009: ldarg.2
    IL_000A: call Z0.bit Z0.BitLogic::and(Z0.bit,Z0.bit)
    IL_000F: call Z0.bit Z0.BitLogic::and(Z0.bit,Z0.bit)
    IL_0014: call Z0.bit Z0.BitLogic::xor(Z0.bit,Z0.bit)
    IL_0019: ret

}
bit f1a(bit a, bit b, bit c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.BitLogic::and(Z0.bit,Z0.bit)
    IL_0007: ldarg.0
    IL_0008: ldarg.2
    IL_0009: call Z0.bit Z0.BitLogic::xor(Z0.bit,Z0.bit)
    IL_000E: call Z0.bit Z0.BitLogic::and(Z0.bit,Z0.bit)
    IL_0013: call Z0.bit Z0.BitLogic::not(Z0.bit)
    IL_0018: ret

}
bit f1b(bit a, bit b, bit c)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: call Z0.bit Z0.BitLogic::not(Z0.bit)
    IL_0007: ldarg.1
    IL_0008: call Z0.bit Z0.BitLogic::not(Z0.bit)
    IL_000D: call Z0.bit Z0.BitLogic::select(Z0.bit,Z0.bit,Z0.bit)
    IL_0012: ret

}
bit f1c(bit a, bit b, bit c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.2
    IL_0002: call Z0.bit Z0.BitLogic::and(Z0.bit,Z0.bit)
    IL_0007: call Z0.bit Z0.BitLogic::not(Z0.bit)
    IL_000C: ldarg.0
    IL_000D: ldarg.1
    IL_000E: call Z0.bit Z0.BitLogic::xor(Z0.bit,Z0.bit)
    IL_0013: call Z0.bit Z0.BitLogic::and(Z0.bit,Z0.bit)
    IL_0018: ret

}
bit f1d(bit a, bit b, bit c)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call Z0.bit Z0.BitLogic::not(Z0.bit)
    IL_0007: ldarg.2
    IL_0008: call Z0.bit Z0.BitLogic::not(Z0.bit)
    IL_000D: call Z0.bit Z0.BitLogic::select(Z0.bit,Z0.bit,Z0.bit)
    IL_0012: ret

}
bit f1e(bit a, bit b, bit c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call Z0.bit Z0.BitLogic::or(Z0.bit,Z0.bit)
    IL_0008: call Z0.bit Z0.BitLogic::xor(Z0.bit,Z0.bit)
    IL_000D: ret

}
bit f1f(bit a, bit b, bit c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call Z0.bit Z0.BitLogic::or(Z0.bit,Z0.bit)
    IL_0008: call Z0.bit Z0.BitLogic::nand(Z0.bit,Z0.bit)
    IL_000D: ret

}
bit f20(bit a, bit b, bit c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.BitLogic::andnot(Z0.bit,Z0.bit)
    IL_0007: ldarg.2
    IL_0008: call Z0.bit Z0.BitLogic::and(Z0.bit,Z0.bit)
    IL_000D: ret

}
bit f21(bit a, bit b, bit c)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldarg.2
    IL_0003: call Z0.bit Z0.BitLogic::xor(Z0.bit,Z0.bit)
    IL_0008: call Z0.bit Z0.BitLogic::nor(Z0.bit,Z0.bit)
    IL_000D: ret

}
bit f22(bit a, bit b, bit c)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.BitLogic::andnot(Z0.bit,Z0.bit)
    IL_0007: ret

}
bit f23(bit a, bit b, bit c)
{
    IL_0000: ldarg.1
    IL_0001: call Z0.bit Z0.BitLogic::not(Z0.bit)
    IL_0006: ldarg.0
    IL_0007: call Z0.bit Z0.BitLogic::xor1(Z0.bit)
    IL_000C: ldarg.2
    IL_000D: call Z0.bit Z0.BitLogic::or(Z0.bit,Z0.bit)
    IL_0012: call Z0.bit Z0.BitLogic::and(Z0.bit,Z0.bit)
    IL_0017: ret

}
bit f24(bit a, bit b, bit c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.BitLogic::xor(Z0.bit,Z0.bit)
    IL_0007: ldarg.1
    IL_0008: ldarg.2
    IL_0009: call Z0.bit Z0.BitLogic::xor(Z0.bit,Z0.bit)
    IL_000E: call Z0.bit Z0.BitLogic::and(Z0.bit,Z0.bit)
    IL_0013: ret

}
bit f25(bit a, bit b, bit c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.BitLogic::and(Z0.bit,Z0.bit)
    IL_0007: call Z0.bit Z0.BitLogic::not(Z0.bit)
    IL_000C: ldarg.0
    IL_000D: ldarg.2
    IL_000E: call Z0.bit Z0.BitLogic::xor1(Z0.bit)
    IL_0013: call Z0.bit Z0.BitLogic::xor(Z0.bit,Z0.bit)
    IL_0018: call Z0.bit Z0.BitLogic::and(Z0.bit,Z0.bit)
    IL_001D: ret

}
bit f26(bit a, bit b, bit c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.BitLogic::and(Z0.bit,Z0.bit)
    IL_0007: call Z0.bit Z0.BitLogic::not(Z0.bit)
    IL_000C: ldarg.1
    IL_000D: ldarg.2
    IL_000E: call Z0.bit Z0.BitLogic::xor(Z0.bit,Z0.bit)
    IL_0013: call Z0.bit Z0.BitLogic::and(Z0.bit,Z0.bit)
    IL_0018: ret

}
bit f27(bit a, bit b, bit c)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.BitLogic::not(Z0.bit)
    IL_0007: ldarg.2
    IL_0008: call Z0.bit Z0.BitLogic::not(Z0.bit)
    IL_000D: call Z0.bit Z0.BitLogic::select(Z0.bit,Z0.bit,Z0.bit)
    IL_0012: ret

}
bit f28(bit a, bit b, bit c)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: call Z0.bit Z0.BitLogic::xor(Z0.bit,Z0.bit)
    IL_0008: call Z0.bit Z0.BitLogic::and(Z0.bit,Z0.bit)
    IL_000D: ret

}
bit f29(bit a, bit b, bit c)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: call Z0.bit Z0.BitLogic::xor(Z0.bit,Z0.bit)
    IL_0008: ldarg.1
    IL_0009: ldarg.0
    IL_000A: call Z0.bit Z0.BitLogic::nor(Z0.bit,Z0.bit)
    IL_000F: call Z0.bit Z0.BitLogic::select(Z0.bit,Z0.bit,Z0.bit)
    IL_0014: ret

}
bit f2a(bit a, bit b, bit c)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: call Z0.bit Z0.BitLogic::nand(Z0.bit,Z0.bit)
    IL_0008: call Z0.bit Z0.BitLogic::and(Z0.bit,Z0.bit)
    IL_000D: ret

}
bit f2b(bit a, bit b, bit c)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: call Z0.bit Z0.BitLogic::nand(Z0.bit,Z0.bit)
    IL_0008: ldarg.1
    IL_0009: ldarg.0
    IL_000A: call Z0.bit Z0.BitLogic::nor(Z0.bit,Z0.bit)
    IL_000F: call Z0.bit Z0.BitLogic::select(Z0.bit,Z0.bit,Z0.bit)
    IL_0014: ret

}
bit f2c(bit a, bit b, bit c)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.2
    IL_0002: call Z0.bit Z0.BitLogic::or(Z0.bit,Z0.bit)
    IL_0007: ldarg.0
    IL_0008: ldarg.1
    IL_0009: call Z0.bit Z0.BitLogic::xor(Z0.bit,Z0.bit)
    IL_000E: call Z0.bit Z0.BitLogic::and(Z0.bit,Z0.bit)
    IL_0013: ret

}
bit f2d(bit a, bit b, bit c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call Z0.bit Z0.BitLogic::not(Z0.bit)
    IL_0008: call Z0.bit Z0.BitLogic::or(Z0.bit,Z0.bit)
    IL_000D: call Z0.bit Z0.BitLogic::xor(Z0.bit,Z0.bit)
    IL_0012: ret

}
bit f2e(bit a, bit b, bit c)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.2
    IL_0002: call Z0.bit Z0.BitLogic::or(Z0.bit,Z0.bit)
    IL_0007: ldarg.0
    IL_0008: ldarg.1
    IL_0009: call Z0.bit Z0.BitLogic::or(Z0.bit,Z0.bit)
    IL_000E: call Z0.bit Z0.BitLogic::xor(Z0.bit,Z0.bit)
    IL_0013: ret

}
bit f2f(bit a, bit b, bit c)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.bit Z0.BitLogic::not(Z0.bit)
    IL_0006: ldarg.1
    IL_0007: call Z0.bit Z0.BitLogic::not(Z0.bit)
    IL_000C: ldarg.2
    IL_000D: call Z0.bit Z0.BitLogic::and(Z0.bit,Z0.bit)
    IL_0012: call Z0.bit Z0.BitLogic::or(Z0.bit,Z0.bit)
    IL_0017: ret

}
bit f30(bit a, bit b, bit c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.BitLogic::not(Z0.bit)
    IL_0007: call Z0.bit Z0.BitLogic::and(Z0.bit,Z0.bit)
    IL_000C: ret

}
bit f31(bit a, bit b, bit c)
{
    IL_0000: ldarg.1
    IL_0001: call Z0.bit Z0.BitLogic::not(Z0.bit)
    IL_0006: ldarg.0
    IL_0007: ldarg.2
    IL_0008: call Z0.bit Z0.BitLogic::xor1(Z0.bit)
    IL_000D: call Z0.bit Z0.BitLogic::or(Z0.bit,Z0.bit)
    IL_0012: call Z0.bit Z0.BitLogic::and(Z0.bit,Z0.bit)
    IL_0017: ret

}
bit f32(bit a, bit b, bit c)
{
    IL_0000: ldarg.1
    IL_0001: call Z0.bit Z0.BitLogic::not(Z0.bit)
    IL_0006: ldarg.0
    IL_0007: ldarg.2
    IL_0008: call Z0.bit Z0.BitLogic::or(Z0.bit,Z0.bit)
    IL_000D: call Z0.bit Z0.BitLogic::and(Z0.bit,Z0.bit)
    IL_0012: ret

}
bit f55(bit a, bit b, bit c)
{
    IL_0000: ldarg.2
    IL_0001: call Z0.bit Z0.BitLogic::not(Z0.bit)
    IL_0006: ret

}
bit faa(bit a, bit b, bit c)
{
    IL_0000: ldarg.2
    IL_0001: ret

}
