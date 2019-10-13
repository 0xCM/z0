// 2019-10-13 04:28:20:426
Bit identity(Bit a)
{
    IL_0000: ldarg.0
    IL_0001: ret

}
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
    IL_0007: ldsfld Z0.Bit Z0.BitLogic::one
    IL_000C: call Z0.Bit Z0.Bit::op_ExclusiveOr(Z0.Bit,Z0.Bit)
    IL_0011: ldarg.2
    IL_0012: call Z0.Bit Z0.BitLogic::or(Z0.Bit,Z0.Bit)
    IL_0017: call Z0.Bit Z0.BitLogic::and(Z0.Bit,Z0.Bit)
    IL_001C: ret

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
    IL_0008: ldsfld Z0.Bit Z0.BitLogic::one
    IL_000D: call Z0.Bit Z0.BitLogic::xor(Z0.Bit,Z0.Bit)
    IL_0012: call Z0.Bit Z0.BitLogic::or(Z0.Bit,Z0.Bit)
    IL_0017: call Z0.Bit Z0.BitLogic::and(Z0.Bit,Z0.Bit)
    IL_001C: ret

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
    IL_0000: ldarg.0
    IL_0001: ldarg.2
    IL_0002: ldarg.1
    IL_0003: call Z0.Bit Z0.BitLogic::nor(Z0.Bit,Z0.Bit)
    IL_0008: call Z0.Bit Z0.BitLogic::and(Z0.Bit,Z0.Bit)
    IL_000D: ret

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
    IL_0014: ret

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
UnaryOp<Bit> unaryop(OpKind:byte id)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.s 17
    IL_0003: beq.s IL_000C
    IL_0005: ldarg.0
    IL_0006: ldc.i4.s 18
    IL_0008: beq.s IL_0019
    IL_000A: br.s IL_0026
    IL_000C: ldnull
    IL_000D: ldftn Z0.Bit Z0.BitLogic::not(Z0.Bit)
    IL_0013: newobj System.Void Z0.UnaryOp`1<Z0.Bit>::.ctor(System.Object,System.IntPtr)
    IL_0018: ret
    IL_0019: ldnull
    IL_001A: ldftn Z0.Bit Z0.BitLogic::identity(Z0.Bit)
    IL_0020: newobj System.Void Z0.UnaryOp`1<Z0.Bit>::.ctor(System.Object,System.IntPtr)
    IL_0025: ret
    IL_0026: ldstr "J:\\dev\\projects\\z0_release\\bits\\src\\logic\\BitLogic.cs"
    IL_002B: ldstr "J:\\dev\\projects\\z0_release\\bits\\src\\logic\\BitLogic.cs"
    IL_0030: ldc.i4 198
    IL_0035: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_003A: call Z0.AppException zfunc::unsupported<Z0.Bit>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_003F: throw

}
BinaryOp<Bit> binop(OpKind:byte id)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.6
    IL_0002: sub
    IL_0003: switch(IL_0022,IL_002F,IL_003C,IL_0049,IL_0056,IL_0063)
    IL_0020: br.s IL_0070
    IL_0022: ldnull
    IL_0023: ldftn Z0.Bit Z0.BitLogic::and(Z0.Bit,Z0.Bit)
    IL_0029: newobj System.Void Z0.BinaryOp`1<Z0.Bit>::.ctor(System.Object,System.IntPtr)
    IL_002E: ret
    IL_002F: ldnull
    IL_0030: ldftn Z0.Bit Z0.BitLogic::nand(Z0.Bit,Z0.Bit)
    IL_0036: newobj System.Void Z0.BinaryOp`1<Z0.Bit>::.ctor(System.Object,System.IntPtr)
    IL_003B: ret
    IL_003C: ldnull
    IL_003D: ldftn Z0.Bit Z0.BitLogic::or(Z0.Bit,Z0.Bit)
    IL_0043: newobj System.Void Z0.BinaryOp`1<Z0.Bit>::.ctor(System.Object,System.IntPtr)
    IL_0048: ret
    IL_0049: ldnull
    IL_004A: ldftn Z0.Bit Z0.BitLogic::nor(Z0.Bit,Z0.Bit)
    IL_0050: newobj System.Void Z0.BinaryOp`1<Z0.Bit>::.ctor(System.Object,System.IntPtr)
    IL_0055: ret
    IL_0056: ldnull
    IL_0057: ldftn Z0.Bit Z0.BitLogic::xor(Z0.Bit,Z0.Bit)
    IL_005D: newobj System.Void Z0.BinaryOp`1<Z0.Bit>::.ctor(System.Object,System.IntPtr)
    IL_0062: ret
    IL_0063: ldnull
    IL_0064: ldftn Z0.Bit Z0.BitLogic::xnor(Z0.Bit,Z0.Bit)
    IL_006A: newobj System.Void Z0.BinaryOp`1<Z0.Bit>::.ctor(System.Object,System.IntPtr)
    IL_006F: ret
    IL_0070: ldstr "J:\\dev\\projects\\z0_release\\bits\\src\\logic\\BitLogic.cs"
    IL_0075: ldstr "J:\\dev\\projects\\z0_release\\bits\\src\\logic\\BitLogic.cs"
    IL_007A: ldc.i4 213
    IL_007F: newobj System.Void System.Nullable`1<System.Int32>::.ctor(System.Int32)
    IL_0084: call Z0.AppException zfunc::unsupported<Z0.Bit>(System.String,System.String,System.Nullable`1<System.Int32>)
    IL_0089: throw

}
TernaryOp<Bit> ternop(ByteKind:byte id)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0002: sub
    IL_0003: switch(IL_0079,IL_0086,IL_0093,IL_00A0,IL_00AD,IL_00BA,IL_00C7,IL_00D4,IL_00E1,IL_00EE,IL_00FB,IL_0108,IL_0115,IL_0122,IL_012F,IL_013C,IL_0149,IL_0156,IL_0163,IL_0170,IL_017D,IL_018A,IL_0197,IL_01A4,IL_01B1,IL_01BE,IL_01CB)
    IL_0074: br IL_01D8
    IL_0079: ldnull
    IL_007A: ldftn Z0.Bit Z0.BitLogic::f01(Z0.Bit,Z0.Bit,Z0.Bit)
    IL_0080: newobj System.Void Z0.TernaryOp`1<Z0.Bit>::.ctor(System.Object,System.IntPtr)
    IL_0085: ret
    IL_0086: ldnull
    IL_0087: ldftn Z0.Bit Z0.BitLogic::f02(Z0.Bit,Z0.Bit,Z0.Bit)
    IL_008D: newobj System.Void Z0.TernaryOp`1<Z0.Bit>::.ctor(System.Object,System.IntPtr)
    IL_0092: ret
    IL_0093: ldnull
    IL_0094: ldftn Z0.Bit Z0.BitLogic::f03(Z0.Bit,Z0.Bit,Z0.Bit)
    IL_009A: newobj System.Void Z0.TernaryOp`1<Z0.Bit>::.ctor(System.Object,System.IntPtr)
    IL_009F: ret
    IL_00A0: ldnull
    IL_00A1: ldftn Z0.Bit Z0.BitLogic::f04(Z0.Bit,Z0.Bit,Z0.Bit)
    IL_00A7: newobj System.Void Z0.TernaryOp`1<Z0.Bit>::.ctor(System.Object,System.IntPtr)
    IL_00AC: ret
    IL_00AD: ldnull
    IL_00AE: ldftn Z0.Bit Z0.BitLogic::f05(Z0.Bit,Z0.Bit,Z0.Bit)
    IL_00B4: newobj System.Void Z0.TernaryOp`1<Z0.Bit>::.ctor(System.Object,System.IntPtr)
    IL_00B9: ret
    IL_00BA: ldnull
    IL_00BB: ldftn Z0.Bit Z0.BitLogic::f06(Z0.Bit,Z0.Bit,Z0.Bit)
    IL_00C1: newobj System.Void Z0.TernaryOp`1<Z0.Bit>::.ctor(System.Object,System.IntPtr)
    IL_00C6: ret
    IL_00C7: ldnull
    IL_00C8: ldftn Z0.Bit Z0.BitLogic::f07(Z0.Bit,Z0.Bit,Z0.Bit)
    IL_00CE: newobj System.Void Z0.TernaryOp`1<Z0.Bit>::.ctor(System.Object,System.IntPtr)
    IL_00D3: ret
    IL_00D4: ldnull
    IL_00D5: ldftn Z0.Bit Z0.BitLogic::f08(Z0.Bit,Z0.Bit,Z0.Bit)
    IL_00DB: newobj System.Void Z0.TernaryOp`1<Z0.Bit>::.ctor(System.Object,System.IntPtr)
    IL_00E0: ret
    IL_00E1: ldnull
    IL_00E2: ldftn Z0.Bit Z0.BitLogic::f09(Z0.Bit,Z0.Bit,Z0.Bit)
    IL_00E8: newobj System.Void Z0.TernaryOp`1<Z0.Bit>::.ctor(System.Object,System.IntPtr)
    IL_00ED: ret
    IL_00EE: ldnull
    IL_00EF: ldftn Z0.Bit Z0.BitLogic::f0a(Z0.Bit,Z0.Bit,Z0.Bit)
    IL_00F5: newobj System.Void Z0.TernaryOp`1<Z0.Bit>::.ctor(System.Object,System.IntPtr)
    IL_00FA: ret
    IL_00FB: ldnull
    IL_00FC: ldftn Z0.Bit Z0.BitLogic::f0b(Z0.Bit,Z0.Bit,Z0.Bit)
    IL_0102: newobj System.Void Z0.TernaryOp`1<Z0.Bit>::.ctor(System.Object,System.IntPtr)
    IL_0107: ret
    IL_0108: ldnull
    IL_0109: ldftn Z0.Bit Z0.BitLogic::f0c(Z0.Bit,Z0.Bit,Z0.Bit)
    IL_010F: newobj System.Void Z0.TernaryOp`1<Z0.Bit>::.ctor(System.Object,System.IntPtr)
    IL_0114: ret
    IL_0115: ldnull
    IL_0116: ldftn Z0.Bit Z0.BitLogic::f0d(Z0.Bit,Z0.Bit,Z0.Bit)
    IL_011C: newobj System.Void Z0.TernaryOp`1<Z0.Bit>::.ctor(System.Object,System.IntPtr)
    IL_0121: ret
    IL_0122: ldnull
    IL_0123: ldftn Z0.Bit Z0.BitLogic::f0e(Z0.Bit,Z0.Bit,Z0.Bit)
    IL_0129: newobj System.Void Z0.TernaryOp`1<Z0.Bit>::.ctor(System.Object,System.IntPtr)
    IL_012E: ret
    IL_012F: ldnull
    IL_0130: ldftn Z0.Bit Z0.BitLogic::f0f(Z0.Bit,Z0.Bit,Z0.Bit)
    IL_0136: newobj System.Void Z0.TernaryOp`1<Z0.Bit>::.ctor(System.Object,System.IntPtr)
    IL_013B: ret
    IL_013C: ldnull
    IL_013D: ldftn Z0.Bit Z0.BitLogic::f10(Z0.Bit,Z0.Bit,Z0.Bit)
    IL_0143: newobj System.Void Z0.TernaryOp`1<Z0.Bit>::.ctor(System.Object,System.IntPtr)
    IL_0148: ret
    IL_0149: ldnull
    IL_014A: ldftn Z0.Bit Z0.BitLogic::f11(Z0.Bit,Z0.Bit,Z0.Bit)
    IL_0150: newobj System.Void Z0.TernaryOp`1<Z0.Bit>::.ctor(System.Object,System.IntPtr)
    IL_0155: ret
    IL_0156: ldnull
    IL_0157: ldftn Z0.Bit Z0.BitLogic::f12(Z0.Bit,Z0.Bit,Z0.Bit)
    IL_015D: newobj System.Void Z0.TernaryOp`1<Z0.Bit>::.ctor(System.Object,System.IntPtr)
    IL_0162: ret
    IL_0163: ldnull
    IL_0164: ldftn Z0.Bit Z0.BitLogic::f13(Z0.Bit,Z0.Bit,Z0.Bit)
    IL_016A: newobj System.Void Z0.TernaryOp`1<Z0.Bit>::.ctor(System.Object,System.IntPtr)
    IL_016F: ret
    IL_0170: ldnull
    IL_0171: ldftn Z0.Bit Z0.BitLogic::f14(Z0.Bit,Z0.Bit,Z0.Bit)
    IL_0177: newobj System.Void Z0.TernaryOp`1<Z0.Bit>::.ctor(System.Object,System.IntPtr)
    IL_017C: ret
    IL_017D: ldnull
    IL_017E: ldftn Z0.Bit Z0.BitLogic::f15(Z0.Bit,Z0.Bit,Z0.Bit)
    IL_0184: newobj System.Void Z0.TernaryOp`1<Z0.Bit>::.ctor(System.Object,System.IntPtr)
    IL_0189: ret
    IL_018A: ldnull
    IL_018B: ldftn Z0.Bit Z0.BitLogic::f16(Z0.Bit,Z0.Bit,Z0.Bit)
    IL_0191: newobj System.Void Z0.TernaryOp`1<Z0.Bit>::.ctor(System.Object,System.IntPtr)
    IL_0196: ret
    IL_0197: ldnull
    IL_0198: ldftn Z0.Bit Z0.BitLogic::f17(Z0.Bit,Z0.Bit,Z0.Bit)
    IL_019E: newobj System.Void Z0.TernaryOp`1<Z0.Bit>::.ctor(System.Object,System.IntPtr)
    IL_01A3: ret
    IL_01A4: ldnull
    IL_01A5: ldftn Z0.Bit Z0.BitLogic::f18(Z0.Bit,Z0.Bit,Z0.Bit)
    IL_01AB: newobj System.Void Z0.TernaryOp`1<Z0.Bit>::.ctor(System.Object,System.IntPtr)
    IL_01B0: ret
    IL_01B1: ldnull
    IL_01B2: ldftn Z0.Bit Z0.BitLogic::f19(Z0.Bit,Z0.Bit,Z0.Bit)
    IL_01B8: newobj System.Void Z0.TernaryOp`1<Z0.Bit>::.ctor(System.Object,System.IntPtr)
    IL_01BD: ret
    IL_01BE: ldnull
    IL_01BF: ldftn Z0.Bit Z0.BitLogic::f1a(Z0.Bit,Z0.Bit,Z0.Bit)
    IL_01C5: newobj System.Void Z0.TernaryOp`1<Z0.Bit>::.ctor(System.Object,System.IntPtr)
    IL_01CA: ret
    IL_01CB: ldnull
    IL_01CC: ldftn Z0.Bit Z0.BitLogic::f1b(Z0.Bit,Z0.Bit,Z0.Bit)
    IL_01D2: newobj System.Void Z0.TernaryOp`1<Z0.Bit>::.ctor(System.Object,System.IntPtr)
    IL_01D7: ret
    IL_01D8: ldnull
    IL_01D9: ldftn Z0.Bit Z0.BitLogic::select(Z0.Bit,Z0.Bit,Z0.Bit)
    IL_01DF: newobj System.Void Z0.TernaryOp`1<Z0.Bit>::.ctor(System.Object,System.IntPtr)
    IL_01E4: ret

}
