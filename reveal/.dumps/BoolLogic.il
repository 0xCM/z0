// 2019-10-13 04:28:20:543
bool and(bool a, bool b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: and
    IL_0003: ret

}
bool or(bool a, bool b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: or
    IL_0003: ret

}
bool xor(bool a, bool b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: xor
    IL_0003: ret

}
bool not(bool a)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: ceq
    IL_0004: ret

}
bool nand(bool a, bool b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: and
    IL_0003: ldc.i4.0
    IL_0004: ceq
    IL_0006: ret

}
bool nor(bool a, bool b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: or
    IL_0003: ldc.i4.0
    IL_0004: ceq
    IL_0006: ret

}
bool xnor(bool a, bool b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ceq
    IL_0004: ret

}
bool select(bool a, bool b, bool c)
{
    IL_0000: ldarg.0
    IL_0001: brtrue.s IL_0005
    IL_0003: ldarg.2
    IL_0004: ret
    IL_0005: ldarg.1
    IL_0006: ret

}
bool f01(bool a, bool b, bool c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.Boolean Z0.BoolLogic::or(System.Boolean,System.Boolean)
    IL_0008: call System.Boolean Z0.BoolLogic::nor(System.Boolean,System.Boolean)
    IL_000D: ret

}
bool f02(bool a, bool b, bool c)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.1
    IL_0002: ldarg.0
    IL_0003: call System.Boolean Z0.BoolLogic::nor(System.Boolean,System.Boolean)
    IL_0008: call System.Boolean Z0.BoolLogic::and(System.Boolean,System.Boolean)
    IL_000D: ret

}
bool f03(bool a, bool b, bool c)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Boolean Z0.BoolLogic::nor(System.Boolean,System.Boolean)
    IL_0007: ret

}
bool f04(bool a, bool b, bool c)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldarg.2
    IL_0003: call System.Boolean Z0.BoolLogic::nor(System.Boolean,System.Boolean)
    IL_0008: call System.Boolean Z0.BoolLogic::and(System.Boolean,System.Boolean)
    IL_000D: ret

}
bool f05(bool a, bool b, bool c)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: call System.Boolean Z0.BoolLogic::nor(System.Boolean,System.Boolean)
    IL_0007: ret

}
bool f06(bool a, bool b, bool c)
{
    IL_0000: ldarg.0
    IL_0001: call System.Boolean Z0.BoolLogic::not(System.Boolean)
    IL_0006: ldarg.1
    IL_0007: ldarg.2
    IL_0008: call System.Boolean Z0.BoolLogic::xor(System.Boolean,System.Boolean)
    IL_000D: call System.Boolean Z0.BoolLogic::and(System.Boolean,System.Boolean)
    IL_0012: ret

}
bool f07(bool a, bool b, bool c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.Boolean Z0.BoolLogic::and(System.Boolean,System.Boolean)
    IL_0008: call System.Boolean Z0.BoolLogic::nor(System.Boolean,System.Boolean)
    IL_000D: ret

}
bool f08(bool a, bool b, bool c)
{
    IL_0000: ldarg.0
    IL_0001: call System.Boolean Z0.BoolLogic::not(System.Boolean)
    IL_0006: ldarg.1
    IL_0007: call System.Boolean Z0.BoolLogic::and(System.Boolean,System.Boolean)
    IL_000C: ldarg.2
    IL_000D: call System.Boolean Z0.BoolLogic::and(System.Boolean,System.Boolean)
    IL_0012: ret

}
bool f09(bool a, bool b, bool c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.Boolean Z0.BoolLogic::xor(System.Boolean,System.Boolean)
    IL_0008: call System.Boolean Z0.BoolLogic::nor(System.Boolean,System.Boolean)
    IL_000D: ret

}
bool f0A(bool a, bool b, bool c)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: call System.Boolean Z0.BoolLogic::not(System.Boolean)
    IL_0007: call System.Boolean Z0.BoolLogic::and(System.Boolean,System.Boolean)
    IL_000C: ret

}
bool f0B(bool a, bool b, bool c)
{
    IL_0000: ldarg.0
    IL_0001: call System.Boolean Z0.BoolLogic::not(System.Boolean)
    IL_0006: ldarg.1
    IL_0007: ldc.i4.0
    IL_0008: ceq
    IL_000A: ldarg.2
    IL_000B: call System.Boolean Z0.BoolLogic::or(System.Boolean,System.Boolean)
    IL_0010: call System.Boolean Z0.BoolLogic::and(System.Boolean,System.Boolean)
    IL_0015: ret

}
bool f0C(bool a, bool b, bool c)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Boolean Z0.BoolLogic::not(System.Boolean)
    IL_0007: call System.Boolean Z0.BoolLogic::and(System.Boolean,System.Boolean)
    IL_000C: ret

}
bool f0D(bool a, bool b, bool c)
{
    IL_0000: ldarg.0
    IL_0001: call System.Boolean Z0.BoolLogic::not(System.Boolean)
    IL_0006: ldarg.1
    IL_0007: ldarg.2
    IL_0008: ldc.i4.1
    IL_0009: call System.Boolean Z0.BoolLogic::xor(System.Boolean,System.Boolean)
    IL_000E: call System.Boolean Z0.BoolLogic::or(System.Boolean,System.Boolean)
    IL_0013: call System.Boolean Z0.BoolLogic::and(System.Boolean,System.Boolean)
    IL_0018: ret

}
bool f0E(bool a, bool b, bool c)
{
    IL_0000: ldarg.0
    IL_0001: call System.Boolean Z0.BoolLogic::not(System.Boolean)
    IL_0006: ldarg.1
    IL_0007: ldarg.2
    IL_0008: call System.Boolean Z0.BoolLogic::or(System.Boolean,System.Boolean)
    IL_000D: call System.Boolean Z0.BoolLogic::and(System.Boolean,System.Boolean)
    IL_0012: ret

}
bool f0F(bool a, bool b, bool c)
{
    IL_0000: ldarg.0
    IL_0001: call System.Boolean Z0.BoolLogic::not(System.Boolean)
    IL_0006: ret

}
bool f10(bool a, bool b, bool c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.Boolean Z0.BoolLogic::nor(System.Boolean,System.Boolean)
    IL_0008: call System.Boolean Z0.BoolLogic::and(System.Boolean,System.Boolean)
    IL_000D: ret

}
bool f11(bool a, bool b, bool c)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.BoolLogic::nor(System.Boolean,System.Boolean)
    IL_0007: ret

}
bool f12(bool a, bool b, bool c)
{
    IL_0000: ldarg.1
    IL_0001: call System.Boolean Z0.BoolLogic::not(System.Boolean)
    IL_0006: ldarg.0
    IL_0007: ldarg.2
    IL_0008: call System.Boolean Z0.BoolLogic::xor(System.Boolean,System.Boolean)
    IL_000D: call System.Boolean Z0.BoolLogic::and(System.Boolean,System.Boolean)
    IL_0012: ret

}
bool f13(bool a, bool b, bool c)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldarg.2
    IL_0003: call System.Boolean Z0.BoolLogic::and(System.Boolean,System.Boolean)
    IL_0008: call System.Boolean Z0.BoolLogic::nor(System.Boolean,System.Boolean)
    IL_000D: ret

}
bool f14(bool a, bool b, bool c)
{
    IL_0000: ldarg.2
    IL_0001: call System.Boolean Z0.BoolLogic::not(System.Boolean)
    IL_0006: ldarg.0
    IL_0007: ldarg.1
    IL_0008: call System.Boolean Z0.BoolLogic::xor(System.Boolean,System.Boolean)
    IL_000D: call System.Boolean Z0.BoolLogic::and(System.Boolean,System.Boolean)
    IL_0012: ret

}
bool f15(bool a, bool b, bool c)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: call System.Boolean Z0.BoolLogic::and(System.Boolean,System.Boolean)
    IL_0008: call System.Boolean Z0.BoolLogic::nor(System.Boolean,System.Boolean)
    IL_000D: ret

}
bool f16(bool a, bool b, bool c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.Boolean Z0.BoolLogic::nor(System.Boolean,System.Boolean)
    IL_0008: ldarg.1
    IL_0009: ldarg.2
    IL_000A: call System.Boolean Z0.BoolLogic::xor(System.Boolean,System.Boolean)
    IL_000F: call System.Boolean Z0.BoolLogic::select(System.Boolean,System.Boolean,System.Boolean)
    IL_0014: ret

}
bool f17(bool a, bool b, bool c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.Boolean Z0.BoolLogic::or(System.Boolean,System.Boolean)
    IL_0008: ldarg.1
    IL_0009: ldarg.2
    IL_000A: call System.Boolean Z0.BoolLogic::and(System.Boolean,System.Boolean)
    IL_000F: call System.Boolean Z0.BoolLogic::select(System.Boolean,System.Boolean,System.Boolean)
    IL_0014: ret

}
bool f18(bool a, bool b, bool c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.BoolLogic::xor(System.Boolean,System.Boolean)
    IL_0007: ldarg.0
    IL_0008: ldarg.2
    IL_0009: call System.Boolean Z0.BoolLogic::xor(System.Boolean,System.Boolean)
    IL_000E: call System.Boolean Z0.BoolLogic::and(System.Boolean,System.Boolean)
    IL_0013: ret

}
bool f19(bool a, bool b, bool c)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.2
    IL_0002: call System.Boolean Z0.BoolLogic::xor(System.Boolean,System.Boolean)
    IL_0007: ldarg.0
    IL_0008: ldarg.1
    IL_0009: ldarg.2
    IL_000A: call System.Boolean Z0.BoolLogic::and(System.Boolean,System.Boolean)
    IL_000F: call System.Boolean Z0.BoolLogic::and(System.Boolean,System.Boolean)
    IL_0014: call System.Boolean Z0.BoolLogic::xor(System.Boolean,System.Boolean)
    IL_0019: ret

}
bool f1a(bool a, bool b, bool c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.BoolLogic::and(System.Boolean,System.Boolean)
    IL_0007: ldarg.0
    IL_0008: ldarg.2
    IL_0009: call System.Boolean Z0.BoolLogic::xor(System.Boolean,System.Boolean)
    IL_000E: call System.Boolean Z0.BoolLogic::and(System.Boolean,System.Boolean)
    IL_0013: call System.Boolean Z0.BoolLogic::not(System.Boolean)
    IL_0018: ret

}
bool f1b(bool a, bool b, bool c)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: call System.Boolean Z0.BoolLogic::not(System.Boolean)
    IL_0007: ldarg.1
    IL_0008: call System.Boolean Z0.BoolLogic::not(System.Boolean)
    IL_000D: call System.Boolean Z0.BoolLogic::select(System.Boolean,System.Boolean,System.Boolean)
    IL_0012: ret

}
