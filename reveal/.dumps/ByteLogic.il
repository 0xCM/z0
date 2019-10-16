// 2019-10-15 01:38:29:334
ByteKind:byte and(ByteKind:byte a, ByteKind:byte b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: or
    IL_0003: ret

}
ByteKind:byte or(ByteKind:byte a, ByteKind:byte b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: or
    IL_0003: ret

}
ByteKind:byte xor(ByteKind:byte a, ByteKind:byte b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: xor
    IL_0003: ret

}
ByteKind:byte not(ByteKind:byte a)
{
    IL_0000: ldarg.0
    IL_0001: not
    IL_0002: conv.u1
    IL_0003: ret

}
ByteKind:byte nand(ByteKind:byte a, ByteKind:byte b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: and
    IL_0003: not
    IL_0004: conv.u1
    IL_0005: ret

}
ByteKind:byte nor(ByteKind:byte a, ByteKind:byte b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: or
    IL_0003: not
    IL_0004: conv.u1
    IL_0005: ret

}
ByteKind:byte xnor(ByteKind:byte a, ByteKind:byte b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: xor
    IL_0003: not
    IL_0004: conv.u1
    IL_0005: ret

}
ByteKind:byte select(ByteKind:byte a, ByteKind:byte b, ByteKind:byte c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: and
    IL_0003: ldarg.0
    IL_0004: not
    IL_0005: conv.u1
    IL_0006: ldarg.2
    IL_0007: and
    IL_0008: or
    IL_0009: ret

}
ByteKind:byte f01(ByteKind:byte a, ByteKind:byte b, ByteKind:byte c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call Z0.ByteKind Z0.ByteLogic::or(Z0.ByteKind,Z0.ByteKind)
    IL_0008: call Z0.ByteKind Z0.ByteLogic::nor(Z0.ByteKind,Z0.ByteKind)
    IL_000D: ret

}
ByteKind:byte f02(ByteKind:byte a, ByteKind:byte b, ByteKind:byte c)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: call Z0.ByteKind Z0.ByteLogic::nor(Z0.ByteKind,Z0.ByteKind)
    IL_0008: call Z0.ByteKind Z0.ByteLogic::and(Z0.ByteKind,Z0.ByteKind)
    IL_000D: ret

}
ByteKind:byte f03(ByteKind:byte a, ByteKind:byte b, ByteKind:byte c)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call Z0.ByteKind Z0.ByteLogic::nor(Z0.ByteKind,Z0.ByteKind)
    IL_0007: ret

}
ByteKind:byte f04(ByteKind:byte a, ByteKind:byte b, ByteKind:byte c)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldarg.2
    IL_0003: call Z0.ByteKind Z0.ByteLogic::nor(Z0.ByteKind,Z0.ByteKind)
    IL_0008: call Z0.ByteKind Z0.ByteLogic::and(Z0.ByteKind,Z0.ByteKind)
    IL_000D: ret

}
ByteKind:byte f05(ByteKind:byte a, ByteKind:byte b, ByteKind:byte c)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: call Z0.ByteKind Z0.ByteLogic::nor(Z0.ByteKind,Z0.ByteKind)
    IL_0007: ret

}
ByteKind:byte f06(ByteKind:byte a, ByteKind:byte b, ByteKind:byte c)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.ByteKind Z0.ByteLogic::not(Z0.ByteKind)
    IL_0006: ldarg.1
    IL_0007: ldarg.2
    IL_0008: call Z0.ByteKind Z0.ByteLogic::xor(Z0.ByteKind,Z0.ByteKind)
    IL_000D: call Z0.ByteKind Z0.ByteLogic::and(Z0.ByteKind,Z0.ByteKind)
    IL_0012: ret

}
ByteKind:byte f07(ByteKind:byte a, ByteKind:byte b, ByteKind:byte c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call Z0.ByteKind Z0.ByteLogic::and(Z0.ByteKind,Z0.ByteKind)
    IL_0008: call Z0.ByteKind Z0.ByteLogic::nor(Z0.ByteKind,Z0.ByteKind)
    IL_000D: ret

}
ByteKind:byte f08(ByteKind:byte a, ByteKind:byte b, ByteKind:byte c)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.ByteKind Z0.ByteLogic::not(Z0.ByteKind)
    IL_0006: ldarg.1
    IL_0007: call Z0.ByteKind Z0.ByteLogic::and(Z0.ByteKind,Z0.ByteKind)
    IL_000C: ldarg.2
    IL_000D: call Z0.ByteKind Z0.ByteLogic::and(Z0.ByteKind,Z0.ByteKind)
    IL_0012: ret

}
ByteKind:byte f09(ByteKind:byte a, ByteKind:byte b, ByteKind:byte c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call Z0.ByteKind Z0.ByteLogic::xor(Z0.ByteKind,Z0.ByteKind)
    IL_0008: call Z0.ByteKind Z0.ByteLogic::nor(Z0.ByteKind,Z0.ByteKind)
    IL_000D: ret

}
ByteKind:byte f0A(ByteKind:byte a, ByteKind:byte b, ByteKind:byte c)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: call Z0.ByteKind Z0.ByteLogic::not(Z0.ByteKind)
    IL_0007: call Z0.ByteKind Z0.ByteLogic::and(Z0.ByteKind,Z0.ByteKind)
    IL_000C: ret

}
ByteKind:byte f0B(ByteKind:byte a, ByteKind:byte b, ByteKind:byte c)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.ByteKind Z0.ByteLogic::not(Z0.ByteKind)
    IL_0006: ldarg.1
    IL_0007: ldsfld Z0.ByteKind Z0.ByteLogic::one
    IL_000C: xor
    IL_000D: ldarg.2
    IL_000E: call Z0.ByteKind Z0.ByteLogic::or(Z0.ByteKind,Z0.ByteKind)
    IL_0013: call Z0.ByteKind Z0.ByteLogic::and(Z0.ByteKind,Z0.ByteKind)
    IL_0018: ret

}
ByteKind:byte f0C(ByteKind:byte a, ByteKind:byte b, ByteKind:byte c)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call Z0.ByteKind Z0.ByteLogic::not(Z0.ByteKind)
    IL_0007: call Z0.ByteKind Z0.ByteLogic::and(Z0.ByteKind,Z0.ByteKind)
    IL_000C: ret

}
ByteKind:byte f0D(ByteKind:byte a, ByteKind:byte b, ByteKind:byte c)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.ByteKind Z0.ByteLogic::not(Z0.ByteKind)
    IL_0006: ldarg.1
    IL_0007: ldarg.2
    IL_0008: ldsfld Z0.ByteKind Z0.ByteLogic::one
    IL_000D: call Z0.ByteKind Z0.ByteLogic::xor(Z0.ByteKind,Z0.ByteKind)
    IL_0012: call Z0.ByteKind Z0.ByteLogic::or(Z0.ByteKind,Z0.ByteKind)
    IL_0017: call Z0.ByteKind Z0.ByteLogic::and(Z0.ByteKind,Z0.ByteKind)
    IL_001C: ret

}
ByteKind:byte f0E(ByteKind:byte a, ByteKind:byte b, ByteKind:byte c)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.ByteKind Z0.ByteLogic::not(Z0.ByteKind)
    IL_0006: ldarg.1
    IL_0007: ldarg.2
    IL_0008: call Z0.ByteKind Z0.ByteLogic::or(Z0.ByteKind,Z0.ByteKind)
    IL_000D: call Z0.ByteKind Z0.ByteLogic::and(Z0.ByteKind,Z0.ByteKind)
    IL_0012: ret

}
ByteKind:byte f0F(ByteKind:byte a, ByteKind:byte b, ByteKind:byte c)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.ByteKind Z0.ByteLogic::not(Z0.ByteKind)
    IL_0006: ret

}
ByteKind:byte f10(ByteKind:byte a, ByteKind:byte b, ByteKind:byte c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call Z0.ByteKind Z0.ByteLogic::nor(Z0.ByteKind,Z0.ByteKind)
    IL_0008: call Z0.ByteKind Z0.ByteLogic::and(Z0.ByteKind,Z0.ByteKind)
    IL_000D: ret

}
ByteKind:byte f11(ByteKind:byte a, ByteKind:byte b, ByteKind:byte c)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.1
    IL_0002: call Z0.ByteKind Z0.ByteLogic::nor(Z0.ByteKind,Z0.ByteKind)
    IL_0007: ret

}
ByteKind:byte f12(ByteKind:byte a, ByteKind:byte b, ByteKind:byte c)
{
    IL_0000: ldarg.1
    IL_0001: call Z0.ByteKind Z0.ByteLogic::not(Z0.ByteKind)
    IL_0006: ldarg.0
    IL_0007: ldarg.2
    IL_0008: call Z0.ByteKind Z0.ByteLogic::xor(Z0.ByteKind,Z0.ByteKind)
    IL_000D: call Z0.ByteKind Z0.ByteLogic::and(Z0.ByteKind,Z0.ByteKind)
    IL_0012: ret

}
ByteKind:byte f13(ByteKind:byte a, ByteKind:byte b, ByteKind:byte c)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldarg.2
    IL_0003: call Z0.ByteKind Z0.ByteLogic::and(Z0.ByteKind,Z0.ByteKind)
    IL_0008: call Z0.ByteKind Z0.ByteLogic::nor(Z0.ByteKind,Z0.ByteKind)
    IL_000D: ret

}
ByteKind:byte f14(ByteKind:byte a, ByteKind:byte b, ByteKind:byte c)
{
    IL_0000: ldarg.2
    IL_0001: call Z0.ByteKind Z0.ByteLogic::not(Z0.ByteKind)
    IL_0006: ldarg.0
    IL_0007: ldarg.1
    IL_0008: call Z0.ByteKind Z0.ByteLogic::xor(Z0.ByteKind,Z0.ByteKind)
    IL_000D: call Z0.ByteKind Z0.ByteLogic::and(Z0.ByteKind,Z0.ByteKind)
    IL_0012: ret

}
ByteKind:byte f15(ByteKind:byte a, ByteKind:byte b, ByteKind:byte c)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: call Z0.ByteKind Z0.ByteLogic::and(Z0.ByteKind,Z0.ByteKind)
    IL_0008: call Z0.ByteKind Z0.ByteLogic::nor(Z0.ByteKind,Z0.ByteKind)
    IL_000D: ret

}
ByteKind:byte f16(ByteKind:byte a, ByteKind:byte b, ByteKind:byte c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call Z0.ByteKind Z0.ByteLogic::nor(Z0.ByteKind,Z0.ByteKind)
    IL_0008: ldarg.1
    IL_0009: ldarg.2
    IL_000A: call Z0.ByteKind Z0.ByteLogic::xor(Z0.ByteKind,Z0.ByteKind)
    IL_000F: call Z0.ByteKind Z0.ByteLogic::select(Z0.ByteKind,Z0.ByteKind,Z0.ByteKind)
    IL_0014: ret

}
ByteKind:byte f17(ByteKind:byte a, ByteKind:byte b, ByteKind:byte c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call Z0.ByteKind Z0.ByteLogic::or(Z0.ByteKind,Z0.ByteKind)
    IL_0008: ldarg.1
    IL_0009: ldarg.2
    IL_000A: call Z0.ByteKind Z0.ByteLogic::and(Z0.ByteKind,Z0.ByteKind)
    IL_000F: call Z0.ByteKind Z0.ByteLogic::select(Z0.ByteKind,Z0.ByteKind,Z0.ByteKind)
    IL_0014: call Z0.ByteKind Z0.ByteLogic::not(Z0.ByteKind)
    IL_0019: ret

}
ByteKind:byte f18(ByteKind:byte a, ByteKind:byte b, ByteKind:byte c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.ByteKind Z0.ByteLogic::xor(Z0.ByteKind,Z0.ByteKind)
    IL_0007: ldarg.0
    IL_0008: ldarg.2
    IL_0009: call Z0.ByteKind Z0.ByteLogic::xor(Z0.ByteKind,Z0.ByteKind)
    IL_000E: call Z0.ByteKind Z0.ByteLogic::and(Z0.ByteKind,Z0.ByteKind)
    IL_0013: ret

}
ByteKind:byte f19(ByteKind:byte a, ByteKind:byte b, ByteKind:byte c)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.2
    IL_0002: call Z0.ByteKind Z0.ByteLogic::xor(Z0.ByteKind,Z0.ByteKind)
    IL_0007: ldarg.0
    IL_0008: ldarg.1
    IL_0009: ldarg.2
    IL_000A: call Z0.ByteKind Z0.ByteLogic::and(Z0.ByteKind,Z0.ByteKind)
    IL_000F: call Z0.ByteKind Z0.ByteLogic::and(Z0.ByteKind,Z0.ByteKind)
    IL_0014: call Z0.ByteKind Z0.ByteLogic::xor(Z0.ByteKind,Z0.ByteKind)
    IL_0019: ret

}
ByteKind:byte f1a(ByteKind:byte a, ByteKind:byte b, ByteKind:byte c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.ByteKind Z0.ByteLogic::and(Z0.ByteKind,Z0.ByteKind)
    IL_0007: ldarg.0
    IL_0008: ldarg.2
    IL_0009: call Z0.ByteKind Z0.ByteLogic::xor(Z0.ByteKind,Z0.ByteKind)
    IL_000E: call Z0.ByteKind Z0.ByteLogic::and(Z0.ByteKind,Z0.ByteKind)
    IL_0013: call Z0.ByteKind Z0.ByteLogic::not(Z0.ByteKind)
    IL_0018: ret

}
ByteKind:byte f1b(ByteKind:byte a, ByteKind:byte b, ByteKind:byte c)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: call Z0.ByteKind Z0.ByteLogic::not(Z0.ByteKind)
    IL_0007: ldarg.1
    IL_0008: call Z0.ByteKind Z0.ByteLogic::not(Z0.ByteKind)
    IL_000D: call Z0.ByteKind Z0.ByteLogic::select(Z0.ByteKind,Z0.ByteKind,Z0.ByteKind)
    IL_0012: ret

}
