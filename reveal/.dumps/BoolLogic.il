// 2019-10-14 04:37:04:458
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
bool xor1(bool a)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: ceq
    IL_0004: ret

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
bool andnot(bool a, bool b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.0
    IL_0003: ceq
    IL_0005: and
    IL_0006: ret

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
bool f0a(bool a, bool b, bool c)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: call System.Boolean Z0.BoolLogic::not(System.Boolean)
    IL_0007: call System.Boolean Z0.BoolLogic::and(System.Boolean,System.Boolean)
    IL_000C: ret

}
bool f0b(bool a, bool b, bool c)
{
    IL_0000: ldarg.0
    IL_0001: call System.Boolean Z0.BoolLogic::not(System.Boolean)
    IL_0006: ldarg.1
    IL_0007: call System.Boolean Z0.BoolLogic::xor1(System.Boolean)
    IL_000C: ldarg.2
    IL_000D: call System.Boolean Z0.BoolLogic::or(System.Boolean,System.Boolean)
    IL_0012: call System.Boolean Z0.BoolLogic::and(System.Boolean,System.Boolean)
    IL_0017: ret

}
bool f0c(bool a, bool b, bool c)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Boolean Z0.BoolLogic::not(System.Boolean)
    IL_0007: call System.Boolean Z0.BoolLogic::and(System.Boolean,System.Boolean)
    IL_000C: ret

}
bool f0d(bool a, bool b, bool c)
{
    IL_0000: ldarg.0
    IL_0001: call System.Boolean Z0.BoolLogic::not(System.Boolean)
    IL_0006: ldarg.1
    IL_0007: ldarg.2
    IL_0008: call System.Boolean Z0.BoolLogic::xor1(System.Boolean)
    IL_000D: call System.Boolean Z0.BoolLogic::or(System.Boolean,System.Boolean)
    IL_0012: call System.Boolean Z0.BoolLogic::and(System.Boolean,System.Boolean)
    IL_0017: ret

}
bool f0e(bool a, bool b, bool c)
{
    IL_0000: ldarg.0
    IL_0001: call System.Boolean Z0.BoolLogic::not(System.Boolean)
    IL_0006: ldarg.1
    IL_0007: ldarg.2
    IL_0008: call System.Boolean Z0.BoolLogic::or(System.Boolean,System.Boolean)
    IL_000D: call System.Boolean Z0.BoolLogic::and(System.Boolean,System.Boolean)
    IL_0012: ret

}
bool f0f(bool a, bool b, bool c)
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
    IL_0014: call System.Boolean Z0.BoolLogic::not(System.Boolean)
    IL_0019: ret

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
bool f1c(bool a, bool b, bool c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.2
    IL_0002: call System.Boolean Z0.BoolLogic::and(System.Boolean,System.Boolean)
    IL_0007: call System.Boolean Z0.BoolLogic::not(System.Boolean)
    IL_000C: ldarg.0
    IL_000D: ldarg.1
    IL_000E: call System.Boolean Z0.BoolLogic::xor(System.Boolean,System.Boolean)
    IL_0013: call System.Boolean Z0.BoolLogic::and(System.Boolean,System.Boolean)
    IL_0018: ret

}
bool f1d(bool a, bool b, bool c)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Boolean Z0.BoolLogic::not(System.Boolean)
    IL_0007: ldarg.2
    IL_0008: call System.Boolean Z0.BoolLogic::not(System.Boolean)
    IL_000D: call System.Boolean Z0.BoolLogic::select(System.Boolean,System.Boolean,System.Boolean)
    IL_0012: ret

}
bool f1e(bool a, bool b, bool c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.Boolean Z0.BoolLogic::or(System.Boolean,System.Boolean)
    IL_0008: call System.Boolean Z0.BoolLogic::xor(System.Boolean,System.Boolean)
    IL_000D: ret

}
bool f1f(bool a, bool b, bool c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.Boolean Z0.BoolLogic::or(System.Boolean,System.Boolean)
    IL_0008: call System.Boolean Z0.BoolLogic::nand(System.Boolean,System.Boolean)
    IL_000D: ret

}
bool f20(bool a, bool b, bool c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.BoolLogic::andnot(System.Boolean,System.Boolean)
    IL_0007: ldarg.2
    IL_0008: call System.Boolean Z0.BoolLogic::and(System.Boolean,System.Boolean)
    IL_000D: ret

}
bool f21(bool a, bool b, bool c)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldarg.2
    IL_0003: call System.Boolean Z0.BoolLogic::xor(System.Boolean,System.Boolean)
    IL_0008: call System.Boolean Z0.BoolLogic::nor(System.Boolean,System.Boolean)
    IL_000D: ret

}
bool f22(bool a, bool b, bool c)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.BoolLogic::andnot(System.Boolean,System.Boolean)
    IL_0007: ret

}
bool f23(bool a, bool b, bool c)
{
    IL_0000: ldarg.1
    IL_0001: call System.Boolean Z0.BoolLogic::not(System.Boolean)
    IL_0006: ldarg.0
    IL_0007: call System.Boolean Z0.BoolLogic::xor1(System.Boolean)
    IL_000C: ldarg.2
    IL_000D: call System.Boolean Z0.BoolLogic::or(System.Boolean,System.Boolean)
    IL_0012: call System.Boolean Z0.BoolLogic::and(System.Boolean,System.Boolean)
    IL_0017: ret

}
bool f24(bool a, bool b, bool c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.BoolLogic::xor(System.Boolean,System.Boolean)
    IL_0007: ldarg.1
    IL_0008: ldarg.2
    IL_0009: call System.Boolean Z0.BoolLogic::xor(System.Boolean,System.Boolean)
    IL_000E: call System.Boolean Z0.BoolLogic::and(System.Boolean,System.Boolean)
    IL_0013: ret

}
bool f25(bool a, bool b, bool c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.BoolLogic::and(System.Boolean,System.Boolean)
    IL_0007: call System.Boolean Z0.BoolLogic::not(System.Boolean)
    IL_000C: ldarg.0
    IL_000D: ldarg.2
    IL_000E: call System.Boolean Z0.BoolLogic::xor1(System.Boolean)
    IL_0013: call System.Boolean Z0.BoolLogic::xor(System.Boolean,System.Boolean)
    IL_0018: call System.Boolean Z0.BoolLogic::and(System.Boolean,System.Boolean)
    IL_001D: ret

}
UnaryOp<bool> unaryop(UnaryLogic:uint id)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0002: beq.s IL_000A
    IL_0004: ldarg.0
    IL_0005: ldc.i4.2
    IL_0006: beq.s IL_0017
    IL_0008: br.s IL_0024
    IL_000A: ldnull
    IL_000B: ldftn System.Boolean Z0.BoolLogic::not(System.Boolean)
    IL_0011: newobj System.Void Z0.UnaryOp`1<System.Boolean>::.ctor(System.Object,System.IntPtr)
    IL_0016: ret
    IL_0017: ldnull
    IL_0018: ldftn System.Boolean zfunc::identity<System.Boolean>(System.Boolean)
    IL_001E: newobj System.Void Z0.UnaryOp`1<System.Boolean>::.ctor(System.Object,System.IntPtr)
    IL_0023: ret
    IL_0024: ldstr "J:\\dev\\projects\\z0_release\\bits\\src\\logic\\BoolLogic.cs"
    IL_0029: ldstr "J:\\dev\\projects\\z0_release\\bits\\src\\logic\\BoolLogic.cs"
    IL_002E: ldc.i4 257
    IL_0033: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0038: call Z0.AppException zfunc::unsupported<System.Boolean>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_003D: throw

}
BinaryOp<bool> binop(BinaryLogic:uint id)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0002: sub
    IL_0003: switch(IL_005A,IL_0081,IL_0081,IL_0081,IL_0081,IL_0067,IL_0040,IL_0033,IL_0074)
    IL_002C: ldarg.0
    IL_002D: ldc.i4.s 14
    IL_002F: beq.s IL_004D
    IL_0031: br.s IL_0081
    IL_0033: ldnull
    IL_0034: ldftn System.Boolean Z0.BoolLogic::and(System.Boolean,System.Boolean)
    IL_003A: newobj System.Void Z0.BinaryOp`1<System.Boolean>::.ctor(System.Object,System.IntPtr)
    IL_003F: ret
    IL_0040: ldnull
    IL_0041: ldftn System.Boolean Z0.BoolLogic::nand(System.Boolean,System.Boolean)
    IL_0047: newobj System.Void Z0.BinaryOp`1<System.Boolean>::.ctor(System.Object,System.IntPtr)
    IL_004C: ret
    IL_004D: ldnull
    IL_004E: ldftn System.Boolean Z0.BoolLogic::or(System.Boolean,System.Boolean)
    IL_0054: newobj System.Void Z0.BinaryOp`1<System.Boolean>::.ctor(System.Object,System.IntPtr)
    IL_0059: ret
    IL_005A: ldnull
    IL_005B: ldftn System.Boolean Z0.BoolLogic::nor(System.Boolean,System.Boolean)
    IL_0061: newobj System.Void Z0.BinaryOp`1<System.Boolean>::.ctor(System.Object,System.IntPtr)
    IL_0066: ret
    IL_0067: ldnull
    IL_0068: ldftn System.Boolean Z0.BoolLogic::xor(System.Boolean,System.Boolean)
    IL_006E: newobj System.Void Z0.BinaryOp`1<System.Boolean>::.ctor(System.Object,System.IntPtr)
    IL_0073: ret
    IL_0074: ldnull
    IL_0075: ldftn System.Boolean Z0.BoolLogic::xnor(System.Boolean,System.Boolean)
    IL_007B: newobj System.Void Z0.BinaryOp`1<System.Boolean>::.ctor(System.Object,System.IntPtr)
    IL_0080: ret
    IL_0081: ldstr "J:\\dev\\projects\\z0_release\\bits\\src\\logic\\BoolLogic.cs"
    IL_0086: ldstr "J:\\dev\\projects\\z0_release\\bits\\src\\logic\\BoolLogic.cs"
    IL_008B: ldc.i4 272
    IL_0090: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0095: call Z0.AppException zfunc::unsupported<System.Boolean>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_009A: throw

}
TernaryOp<bool> ternop(TernaryLogic:byte id)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0002: sub
    IL_0003: switch(IL_00A1,IL_00AE,IL_00BB,IL_00C8,IL_00D5,IL_00E2,IL_00EF,IL_00FC,IL_0109,IL_0116,IL_0123,IL_0130,IL_013D,IL_014A,IL_0157,IL_0164,IL_0171,IL_017E,IL_018B,IL_0198,IL_01A5,IL_01B2,IL_01BF,IL_01CC,IL_01D9,IL_01E6,IL_01F3,IL_0200,IL_020D,IL_021A,IL_0227,IL_0234,IL_0241,IL_024E,IL_025B,IL_0268,IL_0275)
    IL_009C: br IL_0282
    IL_00A1: ldnull
    IL_00A2: ldftn System.Boolean Z0.BoolLogic::f01(System.Boolean,System.Boolean,System.Boolean)
    IL_00A8: newobj System.Void Z0.TernaryOp`1<System.Boolean>::.ctor(System.Object,System.IntPtr)
    IL_00AD: ret
    IL_00AE: ldnull
    IL_00AF: ldftn System.Boolean Z0.BoolLogic::f02(System.Boolean,System.Boolean,System.Boolean)
    IL_00B5: newobj System.Void Z0.TernaryOp`1<System.Boolean>::.ctor(System.Object,System.IntPtr)
    IL_00BA: ret
    IL_00BB: ldnull
    IL_00BC: ldftn System.Boolean Z0.BoolLogic::f03(System.Boolean,System.Boolean,System.Boolean)
    IL_00C2: newobj System.Void Z0.TernaryOp`1<System.Boolean>::.ctor(System.Object,System.IntPtr)
    IL_00C7: ret
    IL_00C8: ldnull
    IL_00C9: ldftn System.Boolean Z0.BoolLogic::f04(System.Boolean,System.Boolean,System.Boolean)
    IL_00CF: newobj System.Void Z0.TernaryOp`1<System.Boolean>::.ctor(System.Object,System.IntPtr)
    IL_00D4: ret
    IL_00D5: ldnull
    IL_00D6: ldftn System.Boolean Z0.BoolLogic::f05(System.Boolean,System.Boolean,System.Boolean)
    IL_00DC: newobj System.Void Z0.TernaryOp`1<System.Boolean>::.ctor(System.Object,System.IntPtr)
    IL_00E1: ret
    IL_00E2: ldnull
    IL_00E3: ldftn System.Boolean Z0.BoolLogic::f06(System.Boolean,System.Boolean,System.Boolean)
    IL_00E9: newobj System.Void Z0.TernaryOp`1<System.Boolean>::.ctor(System.Object,System.IntPtr)
    IL_00EE: ret
    IL_00EF: ldnull
    IL_00F0: ldftn System.Boolean Z0.BoolLogic::f07(System.Boolean,System.Boolean,System.Boolean)
    IL_00F6: newobj System.Void Z0.TernaryOp`1<System.Boolean>::.ctor(System.Object,System.IntPtr)
    IL_00FB: ret
    IL_00FC: ldnull
    IL_00FD: ldftn System.Boolean Z0.BoolLogic::f08(System.Boolean,System.Boolean,System.Boolean)
    IL_0103: newobj System.Void Z0.TernaryOp`1<System.Boolean>::.ctor(System.Object,System.IntPtr)
    IL_0108: ret
    IL_0109: ldnull
    IL_010A: ldftn System.Boolean Z0.BoolLogic::f09(System.Boolean,System.Boolean,System.Boolean)
    IL_0110: newobj System.Void Z0.TernaryOp`1<System.Boolean>::.ctor(System.Object,System.IntPtr)
    IL_0115: ret
    IL_0116: ldnull
    IL_0117: ldftn System.Boolean Z0.BoolLogic::f0a(System.Boolean,System.Boolean,System.Boolean)
    IL_011D: newobj System.Void Z0.TernaryOp`1<System.Boolean>::.ctor(System.Object,System.IntPtr)
    IL_0122: ret
    IL_0123: ldnull
    IL_0124: ldftn System.Boolean Z0.BoolLogic::f0b(System.Boolean,System.Boolean,System.Boolean)
    IL_012A: newobj System.Void Z0.TernaryOp`1<System.Boolean>::.ctor(System.Object,System.IntPtr)
    IL_012F: ret
    IL_0130: ldnull
    IL_0131: ldftn System.Boolean Z0.BoolLogic::f0c(System.Boolean,System.Boolean,System.Boolean)
    IL_0137: newobj System.Void Z0.TernaryOp`1<System.Boolean>::.ctor(System.Object,System.IntPtr)
    IL_013C: ret
    IL_013D: ldnull
    IL_013E: ldftn System.Boolean Z0.BoolLogic::f0d(System.Boolean,System.Boolean,System.Boolean)
    IL_0144: newobj System.Void Z0.TernaryOp`1<System.Boolean>::.ctor(System.Object,System.IntPtr)
    IL_0149: ret
    IL_014A: ldnull
    IL_014B: ldftn System.Boolean Z0.BoolLogic::f0e(System.Boolean,System.Boolean,System.Boolean)
    IL_0151: newobj System.Void Z0.TernaryOp`1<System.Boolean>::.ctor(System.Object,System.IntPtr)
    IL_0156: ret
    IL_0157: ldnull
    IL_0158: ldftn System.Boolean Z0.BoolLogic::f0f(System.Boolean,System.Boolean,System.Boolean)
    IL_015E: newobj System.Void Z0.TernaryOp`1<System.Boolean>::.ctor(System.Object,System.IntPtr)
    IL_0163: ret
    IL_0164: ldnull
    IL_0165: ldftn System.Boolean Z0.BoolLogic::f10(System.Boolean,System.Boolean,System.Boolean)
    IL_016B: newobj System.Void Z0.TernaryOp`1<System.Boolean>::.ctor(System.Object,System.IntPtr)
    IL_0170: ret
    IL_0171: ldnull
    IL_0172: ldftn System.Boolean Z0.BoolLogic::f11(System.Boolean,System.Boolean,System.Boolean)
    IL_0178: newobj System.Void Z0.TernaryOp`1<System.Boolean>::.ctor(System.Object,System.IntPtr)
    IL_017D: ret
    IL_017E: ldnull
    IL_017F: ldftn System.Boolean Z0.BoolLogic::f12(System.Boolean,System.Boolean,System.Boolean)
    IL_0185: newobj System.Void Z0.TernaryOp`1<System.Boolean>::.ctor(System.Object,System.IntPtr)
    IL_018A: ret
    IL_018B: ldnull
    IL_018C: ldftn System.Boolean Z0.BoolLogic::f13(System.Boolean,System.Boolean,System.Boolean)
    IL_0192: newobj System.Void Z0.TernaryOp`1<System.Boolean>::.ctor(System.Object,System.IntPtr)
    IL_0197: ret
    IL_0198: ldnull
    IL_0199: ldftn System.Boolean Z0.BoolLogic::f14(System.Boolean,System.Boolean,System.Boolean)
    IL_019F: newobj System.Void Z0.TernaryOp`1<System.Boolean>::.ctor(System.Object,System.IntPtr)
    IL_01A4: ret
    IL_01A5: ldnull
    IL_01A6: ldftn System.Boolean Z0.BoolLogic::f15(System.Boolean,System.Boolean,System.Boolean)
    IL_01AC: newobj System.Void Z0.TernaryOp`1<System.Boolean>::.ctor(System.Object,System.IntPtr)
    IL_01B1: ret
    IL_01B2: ldnull
    IL_01B3: ldftn System.Boolean Z0.BoolLogic::f16(System.Boolean,System.Boolean,System.Boolean)
    IL_01B9: newobj System.Void Z0.TernaryOp`1<System.Boolean>::.ctor(System.Object,System.IntPtr)
    IL_01BE: ret
    IL_01BF: ldnull
    IL_01C0: ldftn System.Boolean Z0.BoolLogic::f17(System.Boolean,System.Boolean,System.Boolean)
    IL_01C6: newobj System.Void Z0.TernaryOp`1<System.Boolean>::.ctor(System.Object,System.IntPtr)
    IL_01CB: ret
    IL_01CC: ldnull
    IL_01CD: ldftn System.Boolean Z0.BoolLogic::f18(System.Boolean,System.Boolean,System.Boolean)
    IL_01D3: newobj System.Void Z0.TernaryOp`1<System.Boolean>::.ctor(System.Object,System.IntPtr)
    IL_01D8: ret
    IL_01D9: ldnull
    IL_01DA: ldftn System.Boolean Z0.BoolLogic::f19(System.Boolean,System.Boolean,System.Boolean)
    IL_01E0: newobj System.Void Z0.TernaryOp`1<System.Boolean>::.ctor(System.Object,System.IntPtr)
    IL_01E5: ret
    IL_01E6: ldnull
    IL_01E7: ldftn System.Boolean Z0.BoolLogic::f1a(System.Boolean,System.Boolean,System.Boolean)
    IL_01ED: newobj System.Void Z0.TernaryOp`1<System.Boolean>::.ctor(System.Object,System.IntPtr)
    IL_01F2: ret
    IL_01F3: ldnull
    IL_01F4: ldftn System.Boolean Z0.BoolLogic::f1b(System.Boolean,System.Boolean,System.Boolean)
    IL_01FA: newobj System.Void Z0.TernaryOp`1<System.Boolean>::.ctor(System.Object,System.IntPtr)
    IL_01FF: ret
    IL_0200: ldnull
    IL_0201: ldftn System.Boolean Z0.BoolLogic::f1c(System.Boolean,System.Boolean,System.Boolean)
    IL_0207: newobj System.Void Z0.TernaryOp`1<System.Boolean>::.ctor(System.Object,System.IntPtr)
    IL_020C: ret
    IL_020D: ldnull
    IL_020E: ldftn System.Boolean Z0.BoolLogic::f1d(System.Boolean,System.Boolean,System.Boolean)
    IL_0214: newobj System.Void Z0.TernaryOp`1<System.Boolean>::.ctor(System.Object,System.IntPtr)
    IL_0219: ret
    IL_021A: ldnull
    IL_021B: ldftn System.Boolean Z0.BoolLogic::f1e(System.Boolean,System.Boolean,System.Boolean)
    IL_0221: newobj System.Void Z0.TernaryOp`1<System.Boolean>::.ctor(System.Object,System.IntPtr)
    IL_0226: ret
    IL_0227: ldnull
    IL_0228: ldftn System.Boolean Z0.BoolLogic::f1f(System.Boolean,System.Boolean,System.Boolean)
    IL_022E: newobj System.Void Z0.TernaryOp`1<System.Boolean>::.ctor(System.Object,System.IntPtr)
    IL_0233: ret
    IL_0234: ldnull
    IL_0235: ldftn System.Boolean Z0.BoolLogic::f20(System.Boolean,System.Boolean,System.Boolean)
    IL_023B: newobj System.Void Z0.TernaryOp`1<System.Boolean>::.ctor(System.Object,System.IntPtr)
    IL_0240: ret
    IL_0241: ldnull
    IL_0242: ldftn System.Boolean Z0.BoolLogic::f21(System.Boolean,System.Boolean,System.Boolean)
    IL_0248: newobj System.Void Z0.TernaryOp`1<System.Boolean>::.ctor(System.Object,System.IntPtr)
    IL_024D: ret
    IL_024E: ldnull
    IL_024F: ldftn System.Boolean Z0.BoolLogic::f22(System.Boolean,System.Boolean,System.Boolean)
    IL_0255: newobj System.Void Z0.TernaryOp`1<System.Boolean>::.ctor(System.Object,System.IntPtr)
    IL_025A: ret
    IL_025B: ldnull
    IL_025C: ldftn System.Boolean Z0.BoolLogic::f23(System.Boolean,System.Boolean,System.Boolean)
    IL_0262: newobj System.Void Z0.TernaryOp`1<System.Boolean>::.ctor(System.Object,System.IntPtr)
    IL_0267: ret
    IL_0268: ldnull
    IL_0269: ldftn System.Boolean Z0.BoolLogic::f24(System.Boolean,System.Boolean,System.Boolean)
    IL_026F: newobj System.Void Z0.TernaryOp`1<System.Boolean>::.ctor(System.Object,System.IntPtr)
    IL_0274: ret
    IL_0275: ldnull
    IL_0276: ldftn System.Boolean Z0.BoolLogic::f25(System.Boolean,System.Boolean,System.Boolean)
    IL_027C: newobj System.Void Z0.TernaryOp`1<System.Boolean>::.ctor(System.Object,System.IntPtr)
    IL_0281: ret
    IL_0282: ldnull
    IL_0283: ldftn System.Boolean Z0.BoolLogic::select(System.Boolean,System.Boolean,System.Boolean)
    IL_0289: newobj System.Void Z0.TernaryOp`1<System.Boolean>::.ctor(System.Object,System.IntPtr)
    IL_028E: ret

}
Byte[] rows(BinaryLogic:uint op)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.BinaryOp`1<System.Boolean> Z0.BoolLogic::binop(Z0.BinaryLogic)
    IL_0006: stloc.0
    IL_0007: ldc.i4.8
    IL_0008: newarr System.Byte
    IL_000D: stloc.1
    IL_000E: ldloc.1
    IL_000F: ldc.i4.0
    IL_0010: ldloc.0
    IL_0011: ldc.i4.0
    IL_0012: ldc.i4.0
    IL_0013: callvirt System.Boolean Z0.BinaryOp`1<System.Boolean>::Invoke(System.Boolean,System.Boolean)
    IL_0018: ldc.i4.0
    IL_0019: ldc.i4.0
    IL_001A: call System.Byte Z0.Bits::pack3(System.Boolean,System.Boolean,System.Boolean)
    IL_001F: stelem.i1
    IL_0020: ldloc.1
    IL_0021: ldc.i4.1
    IL_0022: ldloc.0
    IL_0023: ldc.i4.1
    IL_0024: ldc.i4.0
    IL_0025: callvirt System.Boolean Z0.BinaryOp`1<System.Boolean>::Invoke(System.Boolean,System.Boolean)
    IL_002A: ldc.i4.0
    IL_002B: ldc.i4.1
    IL_002C: call System.Byte Z0.Bits::pack3(System.Boolean,System.Boolean,System.Boolean)
    IL_0031: stelem.i1
    IL_0032: ldloc.1
    IL_0033: ldc.i4.2
    IL_0034: ldloc.0
    IL_0035: ldc.i4.0
    IL_0036: ldc.i4.1
    IL_0037: callvirt System.Boolean Z0.BinaryOp`1<System.Boolean>::Invoke(System.Boolean,System.Boolean)
    IL_003C: ldc.i4.1
    IL_003D: ldc.i4.0
    IL_003E: call System.Byte Z0.Bits::pack3(System.Boolean,System.Boolean,System.Boolean)
    IL_0043: stelem.i1
    IL_0044: ldloc.1
    IL_0045: ldc.i4.3
    IL_0046: ldloc.0
    IL_0047: ldc.i4.1
    IL_0048: ldc.i4.1
    IL_0049: callvirt System.Boolean Z0.BinaryOp`1<System.Boolean>::Invoke(System.Boolean,System.Boolean)
    IL_004E: ldc.i4.1
    IL_004F: ldc.i4.1
    IL_0050: call System.Byte Z0.Bits::pack3(System.Boolean,System.Boolean,System.Boolean)
    IL_0055: stelem.i1
    IL_0056: ldloc.1
    IL_0057: ret

}
BitMatrix<N4,N3,byte> table(BinaryLogic:uint op)
{
    IL_0000: ldarg.0
    IL_0001: call System.Byte[] Z0.BoolLogic::rows(Z0.BinaryLogic)
    IL_0006: ldloca.s V_0
    IL_0008: initobj Z0.N4
    IL_000E: ldloc.0
    IL_000F: ldloca.s V_1
    IL_0011: initobj Z0.N3
    IL_0017: ldloc.1
    IL_0018: call Z0.BitMatrix`3<Z0.N4,Z0.N3,System.Byte> Z0.BitMatrix::Load<Z0.N4,Z0.N3,System.Byte>(System.Byte[],Z0.N4,Z0.N3)
    IL_001D: ret

}
Byte[] rows(TernaryLogic:byte op)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.TernaryOp`1<System.Boolean> Z0.BoolLogic::ternop(Z0.TernaryLogic)
    IL_0006: stloc.0
    IL_0007: ldc.i4.8
    IL_0008: newarr System.Byte
    IL_000D: stloc.1
    IL_000E: ldloc.1
    IL_000F: ldc.i4.0
    IL_0010: ldloc.0
    IL_0011: ldc.i4.0
    IL_0012: ldc.i4.0
    IL_0013: ldc.i4.0
    IL_0014: callvirt System.Boolean Z0.TernaryOp`1<System.Boolean>::Invoke(System.Boolean,System.Boolean,System.Boolean)
    IL_0019: ldc.i4.0
    IL_001A: ldc.i4.0
    IL_001B: ldc.i4.0
    IL_001C: call System.Byte Z0.Bits::pack4(System.Boolean,System.Boolean,System.Boolean,System.Boolean)
    IL_0021: stelem.i1
    IL_0022: ldloc.1
    IL_0023: ldc.i4.1
    IL_0024: ldloc.0
    IL_0025: ldc.i4.0
    IL_0026: ldc.i4.0
    IL_0027: ldc.i4.1
    IL_0028: callvirt System.Boolean Z0.TernaryOp`1<System.Boolean>::Invoke(System.Boolean,System.Boolean,System.Boolean)
    IL_002D: ldc.i4.0
    IL_002E: ldc.i4.0
    IL_002F: ldc.i4.1
    IL_0030: call System.Byte Z0.Bits::pack4(System.Boolean,System.Boolean,System.Boolean,System.Boolean)
    IL_0035: stelem.i1
    IL_0036: ldloc.1
    IL_0037: ldc.i4.2
    IL_0038: ldloc.0
    IL_0039: ldc.i4.0
    IL_003A: ldc.i4.1
    IL_003B: ldc.i4.0
    IL_003C: callvirt System.Boolean Z0.TernaryOp`1<System.Boolean>::Invoke(System.Boolean,System.Boolean,System.Boolean)
    IL_0041: ldc.i4.0
    IL_0042: ldc.i4.1
    IL_0043: ldc.i4.0
    IL_0044: call System.Byte Z0.Bits::pack4(System.Boolean,System.Boolean,System.Boolean,System.Boolean)
    IL_0049: stelem.i1
    IL_004A: ldloc.1
    IL_004B: ldc.i4.3
    IL_004C: ldloc.0
    IL_004D: ldc.i4.0
    IL_004E: ldc.i4.1
    IL_004F: ldc.i4.1
    IL_0050: callvirt System.Boolean Z0.TernaryOp`1<System.Boolean>::Invoke(System.Boolean,System.Boolean,System.Boolean)
    IL_0055: ldc.i4.0
    IL_0056: ldc.i4.1
    IL_0057: ldc.i4.1
    IL_0058: call System.Byte Z0.Bits::pack4(System.Boolean,System.Boolean,System.Boolean,System.Boolean)
    IL_005D: stelem.i1
    IL_005E: ldloc.1
    IL_005F: ldc.i4.4
    IL_0060: ldloc.0
    IL_0061: ldc.i4.1
    IL_0062: ldc.i4.0
    IL_0063: ldc.i4.0
    IL_0064: callvirt System.Boolean Z0.TernaryOp`1<System.Boolean>::Invoke(System.Boolean,System.Boolean,System.Boolean)
    IL_0069: ldc.i4.1
    IL_006A: ldc.i4.0
    IL_006B: ldc.i4.0
    IL_006C: call System.Byte Z0.Bits::pack4(System.Boolean,System.Boolean,System.Boolean,System.Boolean)
    IL_0071: stelem.i1
    IL_0072: ldloc.1
    IL_0073: ldc.i4.5
    IL_0074: ldloc.0
    IL_0075: ldc.i4.1
    IL_0076: ldc.i4.0
    IL_0077: ldc.i4.1
    IL_0078: callvirt System.Boolean Z0.TernaryOp`1<System.Boolean>::Invoke(System.Boolean,System.Boolean,System.Boolean)
    IL_007D: ldc.i4.1
    IL_007E: ldc.i4.0
    IL_007F: ldc.i4.1
    IL_0080: call System.Byte Z0.Bits::pack4(System.Boolean,System.Boolean,System.Boolean,System.Boolean)
    IL_0085: stelem.i1
    IL_0086: ldloc.1
    IL_0087: ldc.i4.6
    IL_0088: ldloc.0
    IL_0089: ldc.i4.1
    IL_008A: ldc.i4.1
    IL_008B: ldc.i4.0
    IL_008C: callvirt System.Boolean Z0.TernaryOp`1<System.Boolean>::Invoke(System.Boolean,System.Boolean,System.Boolean)
    IL_0091: ldc.i4.0
    IL_0092: ldc.i4.1
    IL_0093: ldc.i4.1
    IL_0094: call System.Byte Z0.Bits::pack4(System.Boolean,System.Boolean,System.Boolean,System.Boolean)
    IL_0099: stelem.i1
    IL_009A: ldloc.1
    IL_009B: ldc.i4.7
    IL_009C: ldloc.0
    IL_009D: ldc.i4.1
    IL_009E: ldc.i4.1
    IL_009F: ldc.i4.1
    IL_00A0: callvirt System.Boolean Z0.TernaryOp`1<System.Boolean>::Invoke(System.Boolean,System.Boolean,System.Boolean)
    IL_00A5: ldc.i4.1
    IL_00A6: ldc.i4.1
    IL_00A7: ldc.i4.1
    IL_00A8: call System.Byte Z0.Bits::pack4(System.Boolean,System.Boolean,System.Boolean,System.Boolean)
    IL_00AD: stelem.i1
    IL_00AE: ldloc.1
    IL_00AF: ret

}
BitMatrix<N8,N4,byte> table(TernaryLogic:byte op)
{
    IL_0000: ldarg.0
    IL_0001: call System.Byte[] Z0.BoolLogic::rows(Z0.TernaryLogic)
    IL_0006: ldloca.s V_0
    IL_0008: initobj Z0.N8
    IL_000E: ldloc.0
    IL_000F: ldloca.s V_1
    IL_0011: initobj Z0.N4
    IL_0017: ldloc.1
    IL_0018: call Z0.BitMatrix`3<Z0.N8,Z0.N4,System.Byte> Z0.BitMatrix::Load<Z0.N8,Z0.N4,System.Byte>(System.Byte[],Z0.N8,Z0.N4)
    IL_001D: ret

}
