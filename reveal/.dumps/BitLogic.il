// 2019-10-14 04:37:04:259
Bit identity(Bit a)
{
    IL_0000: ldarg.0
    IL_0001: ret

}
Bit not(Bit a)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Bit Z0.Bit::op_OnesComplement(Z0.Bit)
    IL_0006: ret

}
Bit xor1(Bit a)
{
    IL_0000: ldarga.s a
    IL_0002: call Z0.Bit Z0.Bit::Xor1()
    IL_0007: ret

}
Bit and(Bit a, Bit b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Bit Z0.Bit::op_BitwiseAnd(Z0.Bit,Z0.Bit)
    IL_0007: ret

}
Bit nand(Bit a, Bit b)
{
    IL_0000: ldarga.s a
    IL_0002: ldarg.1
    IL_0003: call Z0.Bit Z0.Bit::Nand(Z0.Bit)
    IL_0008: ret

}
Bit or(Bit a, Bit b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Bit Z0.Bit::op_BitwiseOr(Z0.Bit,Z0.Bit)
    IL_0007: ret

}
Bit nor(Bit a, Bit b)
{
    IL_0000: ldarga.s a
    IL_0002: ldarg.1
    IL_0003: call Z0.Bit Z0.Bit::Nor(Z0.Bit)
    IL_0008: ret

}
Bit xor(Bit a, Bit b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Bit Z0.Bit::op_ExclusiveOr(Z0.Bit,Z0.Bit)
    IL_0007: ret

}
Bit xnor(Bit a, Bit b)
{
    IL_0000: ldarga.s a
    IL_0002: ldarg.1
    IL_0003: call Z0.Bit Z0.Bit::Xnor(Z0.Bit)
    IL_0008: ret

}
Bit andnot(Bit a, Bit b)
{
    IL_0000: ldarga.s a
    IL_0002: ldarg.1
    IL_0003: call Z0.Bit Z0.Bit::AndNot(Z0.Bit)
    IL_0008: ret

}
Bit select(Bit a, Bit b, Bit c)
{
    IL_0000: ldarga.s a
    IL_0002: ldarg.1
    IL_0003: ldarg.2
    IL_0004: call Z0.Bit Z0.Bit::Select(Z0.Bit,Z0.Bit)
    IL_0009: ret

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
Bit f0a(Bit a, Bit b, Bit c)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: call Z0.Bit Z0.BitLogic::not(Z0.Bit)
    IL_0007: call Z0.Bit Z0.BitLogic::and(Z0.Bit,Z0.Bit)
    IL_000C: ret

}
Bit f0b(Bit a, Bit b, Bit c)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Bit Z0.BitLogic::not(Z0.Bit)
    IL_0006: ldarg.1
    IL_0007: ldc.i4.1
    IL_0008: call Z0.Bit Z0.Bit::op_Implicit(System.Boolean)
    IL_000D: call Z0.Bit Z0.Bit::op_ExclusiveOr(Z0.Bit,Z0.Bit)
    IL_0012: ldarg.2
    IL_0013: call Z0.Bit Z0.BitLogic::or(Z0.Bit,Z0.Bit)
    IL_0018: call Z0.Bit Z0.BitLogic::and(Z0.Bit,Z0.Bit)
    IL_001D: ret

}
Bit f0c(Bit a, Bit b, Bit c)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call Z0.Bit Z0.BitLogic::not(Z0.Bit)
    IL_0007: call Z0.Bit Z0.BitLogic::and(Z0.Bit,Z0.Bit)
    IL_000C: ret

}
Bit f0d(Bit a, Bit b, Bit c)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Bit Z0.BitLogic::not(Z0.Bit)
    IL_0006: ldarg.1
    IL_0007: ldarg.2
    IL_0008: ldc.i4.1
    IL_0009: call Z0.Bit Z0.Bit::op_Implicit(System.Boolean)
    IL_000E: call Z0.Bit Z0.BitLogic::xor(Z0.Bit,Z0.Bit)
    IL_0013: call Z0.Bit Z0.BitLogic::or(Z0.Bit,Z0.Bit)
    IL_0018: call Z0.Bit Z0.BitLogic::and(Z0.Bit,Z0.Bit)
    IL_001D: ret

}
Bit f0e(Bit a, Bit b, Bit c)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Bit Z0.BitLogic::not(Z0.Bit)
    IL_0006: ldarg.1
    IL_0007: ldarg.2
    IL_0008: call Z0.Bit Z0.BitLogic::or(Z0.Bit,Z0.Bit)
    IL_000D: call Z0.Bit Z0.BitLogic::and(Z0.Bit,Z0.Bit)
    IL_0012: ret

}
Bit f0f(Bit a, Bit b, Bit c)
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
Bit f13(Bit a, Bit b, Bit c)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldarg.2
    IL_0003: call Z0.Bit Z0.BitLogic::and(Z0.Bit,Z0.Bit)
    IL_0008: call Z0.Bit Z0.BitLogic::nor(Z0.Bit,Z0.Bit)
    IL_000D: ret

}
Bit f14(Bit a, Bit b, Bit c)
{
    IL_0000: ldarg.2
    IL_0001: call Z0.Bit Z0.BitLogic::not(Z0.Bit)
    IL_0006: ldarg.0
    IL_0007: ldarg.1
    IL_0008: call Z0.Bit Z0.BitLogic::xor(Z0.Bit,Z0.Bit)
    IL_000D: call Z0.Bit Z0.BitLogic::and(Z0.Bit,Z0.Bit)
    IL_0012: ret

}
Bit f15(Bit a, Bit b, Bit c)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: call Z0.Bit Z0.BitLogic::and(Z0.Bit,Z0.Bit)
    IL_0008: call Z0.Bit Z0.BitLogic::nor(Z0.Bit,Z0.Bit)
    IL_000D: ret

}
Bit f16(Bit a, Bit b, Bit c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call Z0.Bit Z0.BitLogic::nor(Z0.Bit,Z0.Bit)
    IL_0008: ldarg.1
    IL_0009: ldarg.2
    IL_000A: call Z0.Bit Z0.BitLogic::xor(Z0.Bit,Z0.Bit)
    IL_000F: call Z0.Bit Z0.BitLogic::select(Z0.Bit,Z0.Bit,Z0.Bit)
    IL_0014: ret

}
Bit f17(Bit a, Bit b, Bit c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call Z0.Bit Z0.BitLogic::or(Z0.Bit,Z0.Bit)
    IL_0008: ldarg.1
    IL_0009: ldarg.2
    IL_000A: call Z0.Bit Z0.BitLogic::and(Z0.Bit,Z0.Bit)
    IL_000F: call Z0.Bit Z0.BitLogic::select(Z0.Bit,Z0.Bit,Z0.Bit)
    IL_0014: call Z0.Bit Z0.BitLogic::not(Z0.Bit)
    IL_0019: ret

}
Bit f18(Bit a, Bit b, Bit c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Bit Z0.BitLogic::xor(Z0.Bit,Z0.Bit)
    IL_0007: ldarg.0
    IL_0008: ldarg.2
    IL_0009: call Z0.Bit Z0.BitLogic::xor(Z0.Bit,Z0.Bit)
    IL_000E: call Z0.Bit Z0.BitLogic::and(Z0.Bit,Z0.Bit)
    IL_0013: ret

}
Bit f19(Bit a, Bit b, Bit c)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.2
    IL_0002: call Z0.Bit Z0.BitLogic::xor(Z0.Bit,Z0.Bit)
    IL_0007: ldarg.0
    IL_0008: ldarg.1
    IL_0009: ldarg.2
    IL_000A: call Z0.Bit Z0.BitLogic::and(Z0.Bit,Z0.Bit)
    IL_000F: call Z0.Bit Z0.BitLogic::and(Z0.Bit,Z0.Bit)
    IL_0014: call Z0.Bit Z0.BitLogic::xor(Z0.Bit,Z0.Bit)
    IL_0019: ret

}
Bit f1a(Bit a, Bit b, Bit c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Bit Z0.BitLogic::and(Z0.Bit,Z0.Bit)
    IL_0007: ldarg.0
    IL_0008: ldarg.2
    IL_0009: call Z0.Bit Z0.BitLogic::xor(Z0.Bit,Z0.Bit)
    IL_000E: call Z0.Bit Z0.BitLogic::and(Z0.Bit,Z0.Bit)
    IL_0013: call Z0.Bit Z0.BitLogic::not(Z0.Bit)
    IL_0018: ret

}
Bit f1b(Bit a, Bit b, Bit c)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: call Z0.Bit Z0.BitLogic::not(Z0.Bit)
    IL_0007: ldarg.1
    IL_0008: call Z0.Bit Z0.BitLogic::not(Z0.Bit)
    IL_000D: call Z0.Bit Z0.BitLogic::select(Z0.Bit,Z0.Bit,Z0.Bit)
    IL_0012: ret

}
Bit f1c(Bit a, Bit b, Bit c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.2
    IL_0002: call Z0.Bit Z0.BitLogic::and(Z0.Bit,Z0.Bit)
    IL_0007: call Z0.Bit Z0.BitLogic::not(Z0.Bit)
    IL_000C: ldarg.0
    IL_000D: ldarg.1
    IL_000E: call Z0.Bit Z0.BitLogic::xor(Z0.Bit,Z0.Bit)
    IL_0013: call Z0.Bit Z0.BitLogic::and(Z0.Bit,Z0.Bit)
    IL_0018: ret

}
Bit f1d(Bit a, Bit b, Bit c)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call Z0.Bit Z0.BitLogic::not(Z0.Bit)
    IL_0007: ldarg.2
    IL_0008: call Z0.Bit Z0.BitLogic::not(Z0.Bit)
    IL_000D: call Z0.Bit Z0.BitLogic::select(Z0.Bit,Z0.Bit,Z0.Bit)
    IL_0012: ret

}
Bit f1e(Bit a, Bit b, Bit c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call Z0.Bit Z0.BitLogic::or(Z0.Bit,Z0.Bit)
    IL_0008: call Z0.Bit Z0.BitLogic::xor(Z0.Bit,Z0.Bit)
    IL_000D: ret

}
Bit f1f(Bit a, Bit b, Bit c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call Z0.Bit Z0.BitLogic::or(Z0.Bit,Z0.Bit)
    IL_0008: call Z0.Bit Z0.BitLogic::nand(Z0.Bit,Z0.Bit)
    IL_000D: ret

}
Bit f20(Bit a, Bit b, Bit c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Bit Z0.BitLogic::andnot(Z0.Bit,Z0.Bit)
    IL_0007: ldarg.2
    IL_0008: call Z0.Bit Z0.BitLogic::and(Z0.Bit,Z0.Bit)
    IL_000D: ret

}
Bit f21(Bit a, Bit b, Bit c)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldarg.2
    IL_0003: call Z0.Bit Z0.BitLogic::xor(Z0.Bit,Z0.Bit)
    IL_0008: call Z0.Bit Z0.BitLogic::nor(Z0.Bit,Z0.Bit)
    IL_000D: ret

}
Bit f22(Bit a, Bit b, Bit c)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.1
    IL_0002: call Z0.Bit Z0.BitLogic::andnot(Z0.Bit,Z0.Bit)
    IL_0007: ret

}
Bit f23(Bit a, Bit b, Bit c)
{
    IL_0000: ldarg.1
    IL_0001: call Z0.Bit Z0.BitLogic::not(Z0.Bit)
    IL_0006: ldarg.0
    IL_0007: call Z0.Bit Z0.BitLogic::xor1(Z0.Bit)
    IL_000C: ldarg.2
    IL_000D: call Z0.Bit Z0.BitLogic::or(Z0.Bit,Z0.Bit)
    IL_0012: call Z0.Bit Z0.BitLogic::and(Z0.Bit,Z0.Bit)
    IL_0017: ret

}
Bit f24(Bit a, Bit b, Bit c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Bit Z0.BitLogic::xor(Z0.Bit,Z0.Bit)
    IL_0007: ldarg.1
    IL_0008: ldarg.2
    IL_0009: call Z0.Bit Z0.BitLogic::xor(Z0.Bit,Z0.Bit)
    IL_000E: call Z0.Bit Z0.BitLogic::and(Z0.Bit,Z0.Bit)
    IL_0013: ret

}
Bit f25(Bit a, Bit b, Bit c)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Bit Z0.BitLogic::and(Z0.Bit,Z0.Bit)
    IL_0007: call Z0.Bit Z0.BitLogic::not(Z0.Bit)
    IL_000C: ldarg.0
    IL_000D: ldarg.2
    IL_000E: call Z0.Bit Z0.BitLogic::xor1(Z0.Bit)
    IL_0013: call Z0.Bit Z0.BitLogic::xor(Z0.Bit,Z0.Bit)
    IL_0018: call Z0.Bit Z0.BitLogic::and(Z0.Bit,Z0.Bit)
    IL_001D: ret

}
UnaryOp<Bit> unaryop(UnaryLogic:uint id)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0002: beq.s IL_000A
    IL_0004: ldarg.0
    IL_0005: ldc.i4.2
    IL_0006: beq.s IL_0017
    IL_0008: br.s IL_0024
    IL_000A: ldnull
    IL_000B: ldftn Z0.Bit Z0.BitLogic::not(Z0.Bit)
    IL_0011: newobj System.Void Z0.UnaryOp`1<Z0.Bit>::.ctor(System.Object,System.IntPtr)
    IL_0016: ret
    IL_0017: ldnull
    IL_0018: ldftn Z0.Bit Z0.BitLogic::identity(Z0.Bit)
    IL_001E: newobj System.Void Z0.UnaryOp`1<Z0.Bit>::.ctor(System.Object,System.IntPtr)
    IL_0023: ret
    IL_0024: ldstr "J:\\dev\\projects\\z0_release\\bits\\src\\logic\\BitLogic.cs"
    IL_0029: ldstr "J:\\dev\\projects\\z0_release\\bits\\src\\logic\\BitLogic.cs"
    IL_002E: ldc.i4 258
    IL_0033: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0038: call Z0.AppException zfunc::unsupported<Z0.Bit>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_003D: throw

}
BinaryOp<Bit> binop(BinaryLogic:uint id)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0002: sub
    IL_0003: switch(IL_005A,IL_0081,IL_008E,IL_008E,IL_008E,IL_0067,IL_0040,IL_0033,IL_0074)
    IL_002C: ldarg.0
    IL_002D: ldc.i4.s 14
    IL_002F: beq.s IL_004D
    IL_0031: br.s IL_008E
    IL_0033: ldnull
    IL_0034: ldftn Z0.Bit Z0.BitLogic::and(Z0.Bit,Z0.Bit)
    IL_003A: newobj System.Void Z0.BinaryOp`1<Z0.Bit>::.ctor(System.Object,System.IntPtr)
    IL_003F: ret
    IL_0040: ldnull
    IL_0041: ldftn Z0.Bit Z0.BitLogic::nand(Z0.Bit,Z0.Bit)
    IL_0047: newobj System.Void Z0.BinaryOp`1<Z0.Bit>::.ctor(System.Object,System.IntPtr)
    IL_004C: ret
    IL_004D: ldnull
    IL_004E: ldftn Z0.Bit Z0.BitLogic::or(Z0.Bit,Z0.Bit)
    IL_0054: newobj System.Void Z0.BinaryOp`1<Z0.Bit>::.ctor(System.Object,System.IntPtr)
    IL_0059: ret
    IL_005A: ldnull
    IL_005B: ldftn Z0.Bit Z0.BitLogic::nor(Z0.Bit,Z0.Bit)
    IL_0061: newobj System.Void Z0.BinaryOp`1<Z0.Bit>::.ctor(System.Object,System.IntPtr)
    IL_0066: ret
    IL_0067: ldnull
    IL_0068: ldftn Z0.Bit Z0.BitLogic::xor(Z0.Bit,Z0.Bit)
    IL_006E: newobj System.Void Z0.BinaryOp`1<Z0.Bit>::.ctor(System.Object,System.IntPtr)
    IL_0073: ret
    IL_0074: ldnull
    IL_0075: ldftn Z0.Bit Z0.BitLogic::xnor(Z0.Bit,Z0.Bit)
    IL_007B: newobj System.Void Z0.BinaryOp`1<Z0.Bit>::.ctor(System.Object,System.IntPtr)
    IL_0080: ret
    IL_0081: ldnull
    IL_0082: ldftn Z0.Bit Z0.BitLogic::andnot(Z0.Bit,Z0.Bit)
    IL_0088: newobj System.Void Z0.BinaryOp`1<Z0.Bit>::.ctor(System.Object,System.IntPtr)
    IL_008D: ret
    IL_008E: ldstr "J:\\dev\\projects\\z0_release\\bits\\src\\logic\\BitLogic.cs"
    IL_0093: ldstr "J:\\dev\\projects\\z0_release\\bits\\src\\logic\\BitLogic.cs"
    IL_0098: ldc.i4 274
    IL_009D: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_00A2: call Z0.AppException zfunc::unsupported<Z0.Bit>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_00A7: throw

}
IEnumerable<TernaryLogic:byte> get_ternops()
{
    IL_0000: ldc.i4.1
    IL_0001: ldc.i4 3867
    IL_0006: ldloca.s V_0
    IL_0008: initobj System.Nullable`1<System.Int32>
    IL_000E: ldloc.0
    IL_000F: call System.Collections.Generic.IEnumerable`1<System.Int32> zfunc::range<System.Int32>(System.Int32,System.Int32,System.Nullable`1<System.Int32>)
    IL_0014: call System.Collections.Generic.IEnumerable`1<Z0.TernaryLogic> System.Linq.Enumerable::Cast<Z0.TernaryLogic>(System.Collections.IEnumerable)
    IL_0019: ret

}
TernaryOp<Bit> ternop(TernaryLogic:byte id)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0002: sub
    IL_0003: switch(IL_00A1,IL_00AE,IL_00BB,IL_00C8,IL_00D5,IL_00E2,IL_00EF,IL_00FC,IL_0109,IL_0116,IL_0123,IL_0130,IL_013D,IL_014A,IL_0157,IL_0164,IL_0171,IL_017E,IL_018B,IL_0198,IL_01A5,IL_01B2,IL_01BF,IL_01CC,IL_01D9,IL_01E6,IL_01F3,IL_0200,IL_020D,IL_021A,IL_0227,IL_0234,IL_0241,IL_024E,IL_025B,IL_0268,IL_0275)
    IL_009C: br IL_0282
    IL_00A1: ldnull
    IL_00A2: ldftn Z0.Bit Z0.BitLogic::f01(Z0.Bit,Z0.Bit,Z0.Bit)
    IL_00A8: newobj System.Void Z0.TernaryOp`1<Z0.Bit>::.ctor(System.Object,System.IntPtr)
    IL_00AD: ret
    IL_00AE: ldnull
    IL_00AF: ldftn Z0.Bit Z0.BitLogic::f02(Z0.Bit,Z0.Bit,Z0.Bit)
    IL_00B5: newobj System.Void Z0.TernaryOp`1<Z0.Bit>::.ctor(System.Object,System.IntPtr)
    IL_00BA: ret
    IL_00BB: ldnull
    IL_00BC: ldftn Z0.Bit Z0.BitLogic::f03(Z0.Bit,Z0.Bit,Z0.Bit)
    IL_00C2: newobj System.Void Z0.TernaryOp`1<Z0.Bit>::.ctor(System.Object,System.IntPtr)
    IL_00C7: ret
    IL_00C8: ldnull
    IL_00C9: ldftn Z0.Bit Z0.BitLogic::f04(Z0.Bit,Z0.Bit,Z0.Bit)
    IL_00CF: newobj System.Void Z0.TernaryOp`1<Z0.Bit>::.ctor(System.Object,System.IntPtr)
    IL_00D4: ret
    IL_00D5: ldnull
    IL_00D6: ldftn Z0.Bit Z0.BitLogic::f05(Z0.Bit,Z0.Bit,Z0.Bit)
    IL_00DC: newobj System.Void Z0.TernaryOp`1<Z0.Bit>::.ctor(System.Object,System.IntPtr)
    IL_00E1: ret
    IL_00E2: ldnull
    IL_00E3: ldftn Z0.Bit Z0.BitLogic::f06(Z0.Bit,Z0.Bit,Z0.Bit)
    IL_00E9: newobj System.Void Z0.TernaryOp`1<Z0.Bit>::.ctor(System.Object,System.IntPtr)
    IL_00EE: ret
    IL_00EF: ldnull
    IL_00F0: ldftn Z0.Bit Z0.BitLogic::f07(Z0.Bit,Z0.Bit,Z0.Bit)
    IL_00F6: newobj System.Void Z0.TernaryOp`1<Z0.Bit>::.ctor(System.Object,System.IntPtr)
    IL_00FB: ret
    IL_00FC: ldnull
    IL_00FD: ldftn Z0.Bit Z0.BitLogic::f08(Z0.Bit,Z0.Bit,Z0.Bit)
    IL_0103: newobj System.Void Z0.TernaryOp`1<Z0.Bit>::.ctor(System.Object,System.IntPtr)
    IL_0108: ret
    IL_0109: ldnull
    IL_010A: ldftn Z0.Bit Z0.BitLogic::f09(Z0.Bit,Z0.Bit,Z0.Bit)
    IL_0110: newobj System.Void Z0.TernaryOp`1<Z0.Bit>::.ctor(System.Object,System.IntPtr)
    IL_0115: ret
    IL_0116: ldnull
    IL_0117: ldftn Z0.Bit Z0.BitLogic::f0a(Z0.Bit,Z0.Bit,Z0.Bit)
    IL_011D: newobj System.Void Z0.TernaryOp`1<Z0.Bit>::.ctor(System.Object,System.IntPtr)
    IL_0122: ret
    IL_0123: ldnull
    IL_0124: ldftn Z0.Bit Z0.BitLogic::f0b(Z0.Bit,Z0.Bit,Z0.Bit)
    IL_012A: newobj System.Void Z0.TernaryOp`1<Z0.Bit>::.ctor(System.Object,System.IntPtr)
    IL_012F: ret
    IL_0130: ldnull
    IL_0131: ldftn Z0.Bit Z0.BitLogic::f0c(Z0.Bit,Z0.Bit,Z0.Bit)
    IL_0137: newobj System.Void Z0.TernaryOp`1<Z0.Bit>::.ctor(System.Object,System.IntPtr)
    IL_013C: ret
    IL_013D: ldnull
    IL_013E: ldftn Z0.Bit Z0.BitLogic::f0d(Z0.Bit,Z0.Bit,Z0.Bit)
    IL_0144: newobj System.Void Z0.TernaryOp`1<Z0.Bit>::.ctor(System.Object,System.IntPtr)
    IL_0149: ret
    IL_014A: ldnull
    IL_014B: ldftn Z0.Bit Z0.BitLogic::f0e(Z0.Bit,Z0.Bit,Z0.Bit)
    IL_0151: newobj System.Void Z0.TernaryOp`1<Z0.Bit>::.ctor(System.Object,System.IntPtr)
    IL_0156: ret
    IL_0157: ldnull
    IL_0158: ldftn Z0.Bit Z0.BitLogic::f0f(Z0.Bit,Z0.Bit,Z0.Bit)
    IL_015E: newobj System.Void Z0.TernaryOp`1<Z0.Bit>::.ctor(System.Object,System.IntPtr)
    IL_0163: ret
    IL_0164: ldnull
    IL_0165: ldftn Z0.Bit Z0.BitLogic::f10(Z0.Bit,Z0.Bit,Z0.Bit)
    IL_016B: newobj System.Void Z0.TernaryOp`1<Z0.Bit>::.ctor(System.Object,System.IntPtr)
    IL_0170: ret
    IL_0171: ldnull
    IL_0172: ldftn Z0.Bit Z0.BitLogic::f11(Z0.Bit,Z0.Bit,Z0.Bit)
    IL_0178: newobj System.Void Z0.TernaryOp`1<Z0.Bit>::.ctor(System.Object,System.IntPtr)
    IL_017D: ret
    IL_017E: ldnull
    IL_017F: ldftn Z0.Bit Z0.BitLogic::f12(Z0.Bit,Z0.Bit,Z0.Bit)
    IL_0185: newobj System.Void Z0.TernaryOp`1<Z0.Bit>::.ctor(System.Object,System.IntPtr)
    IL_018A: ret
    IL_018B: ldnull
    IL_018C: ldftn Z0.Bit Z0.BitLogic::f13(Z0.Bit,Z0.Bit,Z0.Bit)
    IL_0192: newobj System.Void Z0.TernaryOp`1<Z0.Bit>::.ctor(System.Object,System.IntPtr)
    IL_0197: ret
    IL_0198: ldnull
    IL_0199: ldftn Z0.Bit Z0.BitLogic::f14(Z0.Bit,Z0.Bit,Z0.Bit)
    IL_019F: newobj System.Void Z0.TernaryOp`1<Z0.Bit>::.ctor(System.Object,System.IntPtr)
    IL_01A4: ret
    IL_01A5: ldnull
    IL_01A6: ldftn Z0.Bit Z0.BitLogic::f15(Z0.Bit,Z0.Bit,Z0.Bit)
    IL_01AC: newobj System.Void Z0.TernaryOp`1<Z0.Bit>::.ctor(System.Object,System.IntPtr)
    IL_01B1: ret
    IL_01B2: ldnull
    IL_01B3: ldftn Z0.Bit Z0.BitLogic::f16(Z0.Bit,Z0.Bit,Z0.Bit)
    IL_01B9: newobj System.Void Z0.TernaryOp`1<Z0.Bit>::.ctor(System.Object,System.IntPtr)
    IL_01BE: ret
    IL_01BF: ldnull
    IL_01C0: ldftn Z0.Bit Z0.BitLogic::f17(Z0.Bit,Z0.Bit,Z0.Bit)
    IL_01C6: newobj System.Void Z0.TernaryOp`1<Z0.Bit>::.ctor(System.Object,System.IntPtr)
    IL_01CB: ret
    IL_01CC: ldnull
    IL_01CD: ldftn Z0.Bit Z0.BitLogic::f18(Z0.Bit,Z0.Bit,Z0.Bit)
    IL_01D3: newobj System.Void Z0.TernaryOp`1<Z0.Bit>::.ctor(System.Object,System.IntPtr)
    IL_01D8: ret
    IL_01D9: ldnull
    IL_01DA: ldftn Z0.Bit Z0.BitLogic::f19(Z0.Bit,Z0.Bit,Z0.Bit)
    IL_01E0: newobj System.Void Z0.TernaryOp`1<Z0.Bit>::.ctor(System.Object,System.IntPtr)
    IL_01E5: ret
    IL_01E6: ldnull
    IL_01E7: ldftn Z0.Bit Z0.BitLogic::f1a(Z0.Bit,Z0.Bit,Z0.Bit)
    IL_01ED: newobj System.Void Z0.TernaryOp`1<Z0.Bit>::.ctor(System.Object,System.IntPtr)
    IL_01F2: ret
    IL_01F3: ldnull
    IL_01F4: ldftn Z0.Bit Z0.BitLogic::f1b(Z0.Bit,Z0.Bit,Z0.Bit)
    IL_01FA: newobj System.Void Z0.TernaryOp`1<Z0.Bit>::.ctor(System.Object,System.IntPtr)
    IL_01FF: ret
    IL_0200: ldnull
    IL_0201: ldftn Z0.Bit Z0.BitLogic::f1c(Z0.Bit,Z0.Bit,Z0.Bit)
    IL_0207: newobj System.Void Z0.TernaryOp`1<Z0.Bit>::.ctor(System.Object,System.IntPtr)
    IL_020C: ret
    IL_020D: ldnull
    IL_020E: ldftn Z0.Bit Z0.BitLogic::f1d(Z0.Bit,Z0.Bit,Z0.Bit)
    IL_0214: newobj System.Void Z0.TernaryOp`1<Z0.Bit>::.ctor(System.Object,System.IntPtr)
    IL_0219: ret
    IL_021A: ldnull
    IL_021B: ldftn Z0.Bit Z0.BitLogic::f1e(Z0.Bit,Z0.Bit,Z0.Bit)
    IL_0221: newobj System.Void Z0.TernaryOp`1<Z0.Bit>::.ctor(System.Object,System.IntPtr)
    IL_0226: ret
    IL_0227: ldnull
    IL_0228: ldftn Z0.Bit Z0.BitLogic::f1f(Z0.Bit,Z0.Bit,Z0.Bit)
    IL_022E: newobj System.Void Z0.TernaryOp`1<Z0.Bit>::.ctor(System.Object,System.IntPtr)
    IL_0233: ret
    IL_0234: ldnull
    IL_0235: ldftn Z0.Bit Z0.BitLogic::f20(Z0.Bit,Z0.Bit,Z0.Bit)
    IL_023B: newobj System.Void Z0.TernaryOp`1<Z0.Bit>::.ctor(System.Object,System.IntPtr)
    IL_0240: ret
    IL_0241: ldnull
    IL_0242: ldftn Z0.Bit Z0.BitLogic::f21(Z0.Bit,Z0.Bit,Z0.Bit)
    IL_0248: newobj System.Void Z0.TernaryOp`1<Z0.Bit>::.ctor(System.Object,System.IntPtr)
    IL_024D: ret
    IL_024E: ldnull
    IL_024F: ldftn Z0.Bit Z0.BitLogic::f22(Z0.Bit,Z0.Bit,Z0.Bit)
    IL_0255: newobj System.Void Z0.TernaryOp`1<Z0.Bit>::.ctor(System.Object,System.IntPtr)
    IL_025A: ret
    IL_025B: ldnull
    IL_025C: ldftn Z0.Bit Z0.BitLogic::f23(Z0.Bit,Z0.Bit,Z0.Bit)
    IL_0262: newobj System.Void Z0.TernaryOp`1<Z0.Bit>::.ctor(System.Object,System.IntPtr)
    IL_0267: ret
    IL_0268: ldnull
    IL_0269: ldftn Z0.Bit Z0.BitLogic::f24(Z0.Bit,Z0.Bit,Z0.Bit)
    IL_026F: newobj System.Void Z0.TernaryOp`1<Z0.Bit>::.ctor(System.Object,System.IntPtr)
    IL_0274: ret
    IL_0275: ldnull
    IL_0276: ldftn Z0.Bit Z0.BitLogic::f25(Z0.Bit,Z0.Bit,Z0.Bit)
    IL_027C: newobj System.Void Z0.TernaryOp`1<Z0.Bit>::.ctor(System.Object,System.IntPtr)
    IL_0281: ret
    IL_0282: ldnull
    IL_0283: ldftn Z0.Bit Z0.BitLogic::select(Z0.Bit,Z0.Bit,Z0.Bit)
    IL_0289: newobj System.Void Z0.TernaryOp`1<Z0.Bit>::.ctor(System.Object,System.IntPtr)
    IL_028E: ret

}
BitMatrix<N4,N3,byte> table(BinaryLogic:uint op)
{
    IL_0000: ldloca.s V_2
    IL_0002: initobj Z0.N4
    IL_0008: ldloc.2
    IL_0009: ldloca.s V_3
    IL_000B: initobj Z0.N3
    IL_0011: ldloc.3
    IL_0012: call Z0.BitMatrix`3<Z0.N4,Z0.N3,System.Byte> Z0.BitMatrix::Alloc<Z0.N4,Z0.N3,System.Byte>(Z0.N4,Z0.N3)
    IL_0017: stloc.0
    IL_0018: ldarg.0
    IL_0019: call Z0.BinaryOp`1<Z0.Bit> Z0.BitLogic::binop(Z0.BinaryLogic)
    IL_001E: stloc.1
    IL_001F: ldloca.s V_0
    IL_0021: ldc.i4.0
    IL_0022: ldc.i4.1
    IL_0023: newarr System.Byte
    IL_0028: dup
    IL_0029: ldc.i4.0
    IL_002A: ldloc.1
    IL_002B: ldsfld Z0.Bit Z0.Bit::Off
    IL_0030: ldsfld Z0.Bit Z0.Bit::Off
    IL_0035: callvirt Z0.Bit Z0.BinaryOp`1<Z0.Bit>::Invoke(Z0.Bit,Z0.Bit)
    IL_003A: call System.Boolean Z0.Bit::op_Implicit(Z0.Bit)
    IL_003F: ldsfld Z0.Bit Z0.Bit::Off
    IL_0044: call System.Boolean Z0.Bit::op_Implicit(Z0.Bit)
    IL_0049: ldsfld Z0.Bit Z0.Bit::Off
    IL_004E: call System.Boolean Z0.Bit::op_Implicit(Z0.Bit)
    IL_0053: call System.Byte Z0.Bits::pack3(System.Boolean,System.Boolean,System.Boolean)
    IL_0058: stelem.i1
    IL_0059: call Z0.BitVector`2<Z0.N3,System.Byte> Z0.BitVector::Define<Z0.N3,System.Byte>(System.Byte[])
    IL_005E: call System.Void Z0.BitMatrix`3<Z0.N4,Z0.N3,System.Byte>::set_Item(System.Int32,Z0.BitVector`2<Z0.N3,System.Byte>)
    IL_0063: ldloca.s V_0
    IL_0065: ldc.i4.1
    IL_0066: ldc.i4.1
    IL_0067: newarr System.Byte
    IL_006C: dup
    IL_006D: ldc.i4.0
    IL_006E: ldloc.1
    IL_006F: ldsfld Z0.Bit Z0.Bit::On
    IL_0074: ldsfld Z0.Bit Z0.Bit::Off
    IL_0079: callvirt Z0.Bit Z0.BinaryOp`1<Z0.Bit>::Invoke(Z0.Bit,Z0.Bit)
    IL_007E: call System.Boolean Z0.Bit::op_Implicit(Z0.Bit)
    IL_0083: ldsfld Z0.Bit Z0.Bit::Off
    IL_0088: call System.Boolean Z0.Bit::op_Implicit(Z0.Bit)
    IL_008D: ldsfld Z0.Bit Z0.Bit::On
    IL_0092: call System.Boolean Z0.Bit::op_Implicit(Z0.Bit)
    IL_0097: call System.Byte Z0.Bits::pack3(System.Boolean,System.Boolean,System.Boolean)
    IL_009C: stelem.i1
    IL_009D: call Z0.BitVector`2<Z0.N3,System.Byte> Z0.BitVector::Define<Z0.N3,System.Byte>(System.Byte[])
    IL_00A2: call System.Void Z0.BitMatrix`3<Z0.N4,Z0.N3,System.Byte>::set_Item(System.Int32,Z0.BitVector`2<Z0.N3,System.Byte>)
    IL_00A7: ldloca.s V_0
    IL_00A9: ldc.i4.2
    IL_00AA: ldc.i4.1
    IL_00AB: newarr System.Byte
    IL_00B0: dup
    IL_00B1: ldc.i4.0
    IL_00B2: ldloc.1
    IL_00B3: ldsfld Z0.Bit Z0.Bit::Off
    IL_00B8: ldsfld Z0.Bit Z0.Bit::On
    IL_00BD: callvirt Z0.Bit Z0.BinaryOp`1<Z0.Bit>::Invoke(Z0.Bit,Z0.Bit)
    IL_00C2: call System.Boolean Z0.Bit::op_Implicit(Z0.Bit)
    IL_00C7: ldsfld Z0.Bit Z0.Bit::On
    IL_00CC: call System.Boolean Z0.Bit::op_Implicit(Z0.Bit)
    IL_00D1: ldsfld Z0.Bit Z0.Bit::Off
    IL_00D6: call System.Boolean Z0.Bit::op_Implicit(Z0.Bit)
    IL_00DB: call System.Byte Z0.Bits::pack3(System.Boolean,System.Boolean,System.Boolean)
    IL_00E0: stelem.i1
    IL_00E1: call Z0.BitVector`2<Z0.N3,System.Byte> Z0.BitVector::Define<Z0.N3,System.Byte>(System.Byte[])
    IL_00E6: call System.Void Z0.BitMatrix`3<Z0.N4,Z0.N3,System.Byte>::set_Item(System.Int32,Z0.BitVector`2<Z0.N3,System.Byte>)
    IL_00EB: ldloca.s V_0
    IL_00ED: ldc.i4.3
    IL_00EE: ldc.i4.1
    IL_00EF: newarr System.Byte
    IL_00F4: dup
    IL_00F5: ldc.i4.0
    IL_00F6: ldloc.1
    IL_00F7: ldsfld Z0.Bit Z0.Bit::On
    IL_00FC: ldsfld Z0.Bit Z0.Bit::On
    IL_0101: callvirt Z0.Bit Z0.BinaryOp`1<Z0.Bit>::Invoke(Z0.Bit,Z0.Bit)
    IL_0106: call System.Boolean Z0.Bit::op_Implicit(Z0.Bit)
    IL_010B: ldsfld Z0.Bit Z0.Bit::On
    IL_0110: call System.Boolean Z0.Bit::op_Implicit(Z0.Bit)
    IL_0115: ldsfld Z0.Bit Z0.Bit::On
    IL_011A: call System.Boolean Z0.Bit::op_Implicit(Z0.Bit)
    IL_011F: call System.Byte Z0.Bits::pack3(System.Boolean,System.Boolean,System.Boolean)
    IL_0124: stelem.i1
    IL_0125: call Z0.BitVector`2<Z0.N3,System.Byte> Z0.BitVector::Define<Z0.N3,System.Byte>(System.Byte[])
    IL_012A: call System.Void Z0.BitMatrix`3<Z0.N4,Z0.N3,System.Byte>::set_Item(System.Int32,Z0.BitVector`2<Z0.N3,System.Byte>)
    IL_012F: ldloc.0
    IL_0130: ret

}
BitMatrix<N8,N4,byte> table(TernaryLogic:byte op)
{
    IL_0000: ldloca.s V_2
    IL_0002: initobj Z0.N8
    IL_0008: ldloc.2
    IL_0009: ldloca.s V_3
    IL_000B: initobj Z0.N4
    IL_0011: ldloc.3
    IL_0012: call Z0.BitMatrix`3<Z0.N8,Z0.N4,System.Byte> Z0.BitMatrix::Alloc<Z0.N8,Z0.N4,System.Byte>(Z0.N8,Z0.N4)
    IL_0017: stloc.0
    IL_0018: ldarg.0
    IL_0019: call Z0.TernaryOp`1<Z0.Bit> Z0.BitLogic::ternop(Z0.TernaryLogic)
    IL_001E: stloc.1
    IL_001F: ldloca.s V_0
    IL_0021: ldc.i4.0
    IL_0022: ldc.i4.1
    IL_0023: newarr System.Byte
    IL_0028: dup
    IL_0029: ldc.i4.0
    IL_002A: ldloc.1
    IL_002B: ldsfld Z0.Bit Z0.BitLogic::off
    IL_0030: ldsfld Z0.Bit Z0.BitLogic::off
    IL_0035: ldsfld Z0.Bit Z0.BitLogic::off
    IL_003A: callvirt Z0.Bit Z0.TernaryOp`1<Z0.Bit>::Invoke(Z0.Bit,Z0.Bit,Z0.Bit)
    IL_003F: call System.Boolean Z0.Bit::op_Implicit(Z0.Bit)
    IL_0044: ldsfld Z0.Bit Z0.BitLogic::off
    IL_0049: call System.Boolean Z0.Bit::op_Implicit(Z0.Bit)
    IL_004E: ldsfld Z0.Bit Z0.BitLogic::off
    IL_0053: call System.Boolean Z0.Bit::op_Implicit(Z0.Bit)
    IL_0058: ldsfld Z0.Bit Z0.BitLogic::off
    IL_005D: call System.Boolean Z0.Bit::op_Implicit(Z0.Bit)
    IL_0062: call System.Byte Z0.Bits::pack4(System.Boolean,System.Boolean,System.Boolean,System.Boolean)
    IL_0067: stelem.i1
    IL_0068: call Z0.BitVector`2<Z0.N4,System.Byte> Z0.BitVector::Define<Z0.N4,System.Byte>(System.Byte[])
    IL_006D: call System.Void Z0.BitMatrix`3<Z0.N8,Z0.N4,System.Byte>::set_Item(System.Int32,Z0.BitVector`2<Z0.N4,System.Byte>)
    IL_0072: ldloca.s V_0
    IL_0074: ldc.i4.1
    IL_0075: ldc.i4.1
    IL_0076: newarr System.Byte
    IL_007B: dup
    IL_007C: ldc.i4.0
    IL_007D: ldloc.1
    IL_007E: ldsfld Z0.Bit Z0.BitLogic::off
    IL_0083: ldsfld Z0.Bit Z0.BitLogic::off
    IL_0088: ldsfld Z0.Bit Z0.BitLogic::on
    IL_008D: callvirt Z0.Bit Z0.TernaryOp`1<Z0.Bit>::Invoke(Z0.Bit,Z0.Bit,Z0.Bit)
    IL_0092: call System.Boolean Z0.Bit::op_Implicit(Z0.Bit)
    IL_0097: ldsfld Z0.Bit Z0.BitLogic::off
    IL_009C: call System.Boolean Z0.Bit::op_Implicit(Z0.Bit)
    IL_00A1: ldsfld Z0.Bit Z0.BitLogic::off
    IL_00A6: call System.Boolean Z0.Bit::op_Implicit(Z0.Bit)
    IL_00AB: ldsfld Z0.Bit Z0.BitLogic::on
    IL_00B0: call System.Boolean Z0.Bit::op_Implicit(Z0.Bit)
    IL_00B5: call System.Byte Z0.Bits::pack4(System.Boolean,System.Boolean,System.Boolean,System.Boolean)
    IL_00BA: stelem.i1
    IL_00BB: call Z0.BitVector`2<Z0.N4,System.Byte> Z0.BitVector::Define<Z0.N4,System.Byte>(System.Byte[])
    IL_00C0: call System.Void Z0.BitMatrix`3<Z0.N8,Z0.N4,System.Byte>::set_Item(System.Int32,Z0.BitVector`2<Z0.N4,System.Byte>)
    IL_00C5: ldloca.s V_0
    IL_00C7: ldc.i4.2
    IL_00C8: ldc.i4.1
    IL_00C9: newarr System.Byte
    IL_00CE: dup
    IL_00CF: ldc.i4.0
    IL_00D0: ldloc.1
    IL_00D1: ldsfld Z0.Bit Z0.BitLogic::off
    IL_00D6: ldsfld Z0.Bit Z0.BitLogic::on
    IL_00DB: ldsfld Z0.Bit Z0.BitLogic::off
    IL_00E0: callvirt Z0.Bit Z0.TernaryOp`1<Z0.Bit>::Invoke(Z0.Bit,Z0.Bit,Z0.Bit)
    IL_00E5: call System.Boolean Z0.Bit::op_Implicit(Z0.Bit)
    IL_00EA: ldsfld Z0.Bit Z0.BitLogic::off
    IL_00EF: call System.Boolean Z0.Bit::op_Implicit(Z0.Bit)
    IL_00F4: ldsfld Z0.Bit Z0.BitLogic::on
    IL_00F9: call System.Boolean Z0.Bit::op_Implicit(Z0.Bit)
    IL_00FE: ldsfld Z0.Bit Z0.BitLogic::off
    IL_0103: call System.Boolean Z0.Bit::op_Implicit(Z0.Bit)
    IL_0108: call System.Byte Z0.Bits::pack4(System.Boolean,System.Boolean,System.Boolean,System.Boolean)
    IL_010D: stelem.i1
    IL_010E: call Z0.BitVector`2<Z0.N4,System.Byte> Z0.BitVector::Define<Z0.N4,System.Byte>(System.Byte[])
    IL_0113: call System.Void Z0.BitMatrix`3<Z0.N8,Z0.N4,System.Byte>::set_Item(System.Int32,Z0.BitVector`2<Z0.N4,System.Byte>)
    IL_0118: ldloca.s V_0
    IL_011A: ldc.i4.3
    IL_011B: ldc.i4.1
    IL_011C: newarr System.Byte
    IL_0121: dup
    IL_0122: ldc.i4.0
    IL_0123: ldloc.1
    IL_0124: ldsfld Z0.Bit Z0.BitLogic::off
    IL_0129: ldsfld Z0.Bit Z0.BitLogic::on
    IL_012E: ldsfld Z0.Bit Z0.BitLogic::on
    IL_0133: callvirt Z0.Bit Z0.TernaryOp`1<Z0.Bit>::Invoke(Z0.Bit,Z0.Bit,Z0.Bit)
    IL_0138: call System.Boolean Z0.Bit::op_Implicit(Z0.Bit)
    IL_013D: ldsfld Z0.Bit Z0.BitLogic::off
    IL_0142: call System.Boolean Z0.Bit::op_Implicit(Z0.Bit)
    IL_0147: ldsfld Z0.Bit Z0.BitLogic::on
    IL_014C: call System.Boolean Z0.Bit::op_Implicit(Z0.Bit)
    IL_0151: ldsfld Z0.Bit Z0.BitLogic::on
    IL_0156: call System.Boolean Z0.Bit::op_Implicit(Z0.Bit)
    IL_015B: call System.Byte Z0.Bits::pack4(System.Boolean,System.Boolean,System.Boolean,System.Boolean)
    IL_0160: stelem.i1
    IL_0161: call Z0.BitVector`2<Z0.N4,System.Byte> Z0.BitVector::Define<Z0.N4,System.Byte>(System.Byte[])
    IL_0166: call System.Void Z0.BitMatrix`3<Z0.N8,Z0.N4,System.Byte>::set_Item(System.Int32,Z0.BitVector`2<Z0.N4,System.Byte>)
    IL_016B: ldloca.s V_0
    IL_016D: ldc.i4.4
    IL_016E: ldc.i4.1
    IL_016F: newarr System.Byte
    IL_0174: dup
    IL_0175: ldc.i4.0
    IL_0176: ldloc.1
    IL_0177: ldsfld Z0.Bit Z0.BitLogic::on
    IL_017C: ldsfld Z0.Bit Z0.BitLogic::off
    IL_0181: ldsfld Z0.Bit Z0.BitLogic::off
    IL_0186: callvirt Z0.Bit Z0.TernaryOp`1<Z0.Bit>::Invoke(Z0.Bit,Z0.Bit,Z0.Bit)
    IL_018B: call System.Boolean Z0.Bit::op_Implicit(Z0.Bit)
    IL_0190: ldsfld Z0.Bit Z0.BitLogic::on
    IL_0195: call System.Boolean Z0.Bit::op_Implicit(Z0.Bit)
    IL_019A: ldsfld Z0.Bit Z0.BitLogic::off
    IL_019F: call System.Boolean Z0.Bit::op_Implicit(Z0.Bit)
    IL_01A4: ldsfld Z0.Bit Z0.BitLogic::off
    IL_01A9: call System.Boolean Z0.Bit::op_Implicit(Z0.Bit)
    IL_01AE: call System.Byte Z0.Bits::pack4(System.Boolean,System.Boolean,System.Boolean,System.Boolean)
    IL_01B3: stelem.i1
    IL_01B4: call Z0.BitVector`2<Z0.N4,System.Byte> Z0.BitVector::Define<Z0.N4,System.Byte>(System.Byte[])
    IL_01B9: call System.Void Z0.BitMatrix`3<Z0.N8,Z0.N4,System.Byte>::set_Item(System.Int32,Z0.BitVector`2<Z0.N4,System.Byte>)
    IL_01BE: ldloca.s V_0
    IL_01C0: ldc.i4.5
    IL_01C1: ldc.i4.1
    IL_01C2: newarr System.Byte
    IL_01C7: dup
    IL_01C8: ldc.i4.0
    IL_01C9: ldloc.1
    IL_01CA: ldsfld Z0.Bit Z0.BitLogic::on
    IL_01CF: ldsfld Z0.Bit Z0.BitLogic::off
    IL_01D4: ldsfld Z0.Bit Z0.BitLogic::on
    IL_01D9: callvirt Z0.Bit Z0.TernaryOp`1<Z0.Bit>::Invoke(Z0.Bit,Z0.Bit,Z0.Bit)
    IL_01DE: call System.Boolean Z0.Bit::op_Implicit(Z0.Bit)
    IL_01E3: ldsfld Z0.Bit Z0.BitLogic::on
    IL_01E8: call System.Boolean Z0.Bit::op_Implicit(Z0.Bit)
    IL_01ED: ldsfld Z0.Bit Z0.BitLogic::off
    IL_01F2: call System.Boolean Z0.Bit::op_Implicit(Z0.Bit)
    IL_01F7: ldsfld Z0.Bit Z0.BitLogic::on
    IL_01FC: call System.Boolean Z0.Bit::op_Implicit(Z0.Bit)
    IL_0201: call System.Byte Z0.Bits::pack4(System.Boolean,System.Boolean,System.Boolean,System.Boolean)
    IL_0206: stelem.i1
    IL_0207: call Z0.BitVector`2<Z0.N4,System.Byte> Z0.BitVector::Define<Z0.N4,System.Byte>(System.Byte[])
    IL_020C: call System.Void Z0.BitMatrix`3<Z0.N8,Z0.N4,System.Byte>::set_Item(System.Int32,Z0.BitVector`2<Z0.N4,System.Byte>)
    IL_0211: ldloca.s V_0
    IL_0213: ldc.i4.6
    IL_0214: ldc.i4.1
    IL_0215: newarr System.Byte
    IL_021A: dup
    IL_021B: ldc.i4.0
    IL_021C: ldloc.1
    IL_021D: ldsfld Z0.Bit Z0.BitLogic::on
    IL_0222: ldsfld Z0.Bit Z0.BitLogic::on
    IL_0227: ldsfld Z0.Bit Z0.BitLogic::off
    IL_022C: callvirt Z0.Bit Z0.TernaryOp`1<Z0.Bit>::Invoke(Z0.Bit,Z0.Bit,Z0.Bit)
    IL_0231: call System.Boolean Z0.Bit::op_Implicit(Z0.Bit)
    IL_0236: ldsfld Z0.Bit Z0.BitLogic::off
    IL_023B: call System.Boolean Z0.Bit::op_Implicit(Z0.Bit)
    IL_0240: ldsfld Z0.Bit Z0.BitLogic::on
    IL_0245: call System.Boolean Z0.Bit::op_Implicit(Z0.Bit)
    IL_024A: ldsfld Z0.Bit Z0.BitLogic::on
    IL_024F: call System.Boolean Z0.Bit::op_Implicit(Z0.Bit)
    IL_0254: call System.Byte Z0.Bits::pack4(System.Boolean,System.Boolean,System.Boolean,System.Boolean)
    IL_0259: stelem.i1
    IL_025A: call Z0.BitVector`2<Z0.N4,System.Byte> Z0.BitVector::Define<Z0.N4,System.Byte>(System.Byte[])
    IL_025F: call System.Void Z0.BitMatrix`3<Z0.N8,Z0.N4,System.Byte>::set_Item(System.Int32,Z0.BitVector`2<Z0.N4,System.Byte>)
    IL_0264: ldloca.s V_0
    IL_0266: ldc.i4.7
    IL_0267: ldc.i4.1
    IL_0268: newarr System.Byte
    IL_026D: dup
    IL_026E: ldc.i4.0
    IL_026F: ldloc.1
    IL_0270: ldsfld Z0.Bit Z0.BitLogic::on
    IL_0275: ldsfld Z0.Bit Z0.BitLogic::on
    IL_027A: ldsfld Z0.Bit Z0.BitLogic::on
    IL_027F: callvirt Z0.Bit Z0.TernaryOp`1<Z0.Bit>::Invoke(Z0.Bit,Z0.Bit,Z0.Bit)
    IL_0284: call System.Boolean Z0.Bit::op_Implicit(Z0.Bit)
    IL_0289: ldsfld Z0.Bit Z0.BitLogic::on
    IL_028E: call System.Boolean Z0.Bit::op_Implicit(Z0.Bit)
    IL_0293: ldsfld Z0.Bit Z0.BitLogic::on
    IL_0298: call System.Boolean Z0.Bit::op_Implicit(Z0.Bit)
    IL_029D: ldsfld Z0.Bit Z0.BitLogic::on
    IL_02A2: call System.Boolean Z0.Bit::op_Implicit(Z0.Bit)
    IL_02A7: call System.Byte Z0.Bits::pack4(System.Boolean,System.Boolean,System.Boolean,System.Boolean)
    IL_02AC: stelem.i1
    IL_02AD: call Z0.BitVector`2<Z0.N4,System.Byte> Z0.BitVector::Define<Z0.N4,System.Byte>(System.Byte[])
    IL_02B2: call System.Void Z0.BitMatrix`3<Z0.N8,Z0.N4,System.Byte>::set_Item(System.Int32,Z0.BitVector`2<Z0.N4,System.Byte>)
    IL_02B7: ldloc.0
    IL_02B8: ret

}
