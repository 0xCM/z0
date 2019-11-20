// 2019-11-20 15:08:31:064
Span<byte> GetBytes(in int src)
{
    IL_0000: ldarg.1
    IL_0001: call System.Span`1<System.Byte> Z0.xfunc::AsBytes(System.Int32&)
    IL_0006: ret

}
Span<byte> GetBytes(in ulong src)
{
    IL_0000: ldarg.1
    IL_0001: call System.Span`1<System.Byte> Z0.xfunc::AsBytes(System.UInt64&)
    IL_0006: ret

}
Span<byte> GetBytes(in double src)
{
    IL_0000: ldarg.1
    IL_0001: call System.Span`1<System.Byte> Z0.xfunc::AsBytes(System.Double&)
    IL_0006: ret

}
N3 nat3()
{
    IL_0000: call Z0.N3 Z0.N3::get_Rep()
    IL_0005: ret

}
ulong nat3val()
{
    IL_0000: call Z0.N3 Z0.N3::get_Rep()
    IL_0005: stloc.0
    IL_0006: ldloca.s V_0
    IL_0008: call System.UInt64 Z0.N3::get_NatValue()
    IL_000D: ret

}
int natval()
{
    IL_0000: ldloca.s V_0
    IL_0002: initobj Z0.N30
    IL_0008: ldloc.0
    IL_0009: call Z0.NatVal Z0.NatMath::natval<Z0.N30>(Z0.N30)
    IL_000E: call System.Int32 Z0.NatVal::op_Implicit(Z0.NatVal)
    IL_0013: ret

}
int natseq2()
{
    IL_0000: ldloca.s V_0
    IL_0002: initobj Z0.N3
    IL_0008: ldloc.0
    IL_0009: ldloca.s V_1
    IL_000B: initobj Z0.N7
    IL_0011: ldloc.1
    IL_0012: call Z0.NatVal Z0.NatMath::natval<Z0.N3,Z0.N7>(Z0.N3,Z0.N7)
    IL_0017: call System.Int32 Z0.NatVal::op_Implicit(Z0.NatVal)
    IL_001C: ret

}
int natseq3()
{
    IL_0000: ldloca.s V_0
    IL_0002: initobj Z0.N3
    IL_0008: ldloc.0
    IL_0009: ldloca.s V_1
    IL_000B: initobj Z0.N7
    IL_0011: ldloc.1
    IL_0012: ldloca.s V_2
    IL_0014: initobj Z0.N1
    IL_001A: ldloc.2
    IL_001B: call Z0.NatVal Z0.NatMath::natval<Z0.N3,Z0.N7,Z0.N1>(Z0.N3,Z0.N7,Z0.N1)
    IL_0020: call System.Int32 Z0.NatVal::op_Implicit(Z0.NatVal)
    IL_0025: ret

}
int natseq4()
{
    IL_0000: ldloca.s V_0
    IL_0002: initobj Z0.N1
    IL_0008: ldloc.0
    IL_0009: ldloca.s V_1
    IL_000B: initobj Z0.N0
    IL_0011: ldloc.1
    IL_0012: ldloca.s V_2
    IL_0014: initobj Z0.N2
    IL_001A: ldloc.2
    IL_001B: ldloca.s V_3
    IL_001D: initobj Z0.N4
    IL_0023: ldloc.3
    IL_0024: call Z0.NatVal Z0.NatMath::natval<Z0.N1,Z0.N0,Z0.N2,Z0.N4>(Z0.N1,Z0.N0,Z0.N2,Z0.N4)
    IL_0029: call System.Int32 Z0.NatVal::op_Implicit(Z0.NatVal)
    IL_002E: ret

}
int add()
{
    IL_0000: ldloca.s V_0
    IL_0002: initobj Z0.N32
    IL_0008: ldloc.0
    IL_0009: ldloca.s V_1
    IL_000B: initobj Z0.N4
    IL_0011: ldloc.1
    IL_0012: call Z0.NatVal Z0.NatMath::add<Z0.N32,Z0.N4>(Z0.N32,Z0.N4)
    IL_0017: call System.Int32 Z0.NatVal::op_Implicit(Z0.NatVal)
    IL_001C: ret

}
int sub()
{
    IL_0000: ldloca.s V_0
    IL_0002: initobj Z0.N1024
    IL_0008: ldloc.0
    IL_0009: ldloca.s V_1
    IL_000B: initobj Z0.N512
    IL_0011: ldloc.1
    IL_0012: call Z0.NatVal Z0.NatMath::sub<Z0.N1024,Z0.N512>(Z0.N1024,Z0.N512)
    IL_0017: call System.Int32 Z0.NatVal::op_Implicit(Z0.NatVal)
    IL_001C: ret

}
int mul()
{
    IL_0000: ldloca.s V_0
    IL_0002: initobj Z0.N32
    IL_0008: ldloc.0
    IL_0009: ldloca.s V_0
    IL_000B: initobj Z0.N32
    IL_0011: ldloc.0
    IL_0012: call Z0.NatVal Z0.NatMath::mul<Z0.N32,Z0.N32>(Z0.N32,Z0.N32)
    IL_0017: call System.Int32 Z0.NatVal::op_Implicit(Z0.NatVal)
    IL_001C: ret

}
int div()
{
    IL_0000: ldloca.s V_0
    IL_0002: initobj Z0.N32
    IL_0008: ldloc.0
    IL_0009: ldloca.s V_1
    IL_000B: initobj Z0.N4
    IL_0011: ldloc.1
    IL_0012: call Z0.NatVal Z0.NatMath::div<Z0.N32,Z0.N4>(Z0.N32,Z0.N4)
    IL_0017: call System.Int32 Z0.NatVal::op_Implicit(Z0.NatVal)
    IL_001C: ret

}
int mod()
{
    IL_0000: ldloca.s V_0
    IL_0002: initobj Z0.N32
    IL_0008: ldloc.0
    IL_0009: ldloca.s V_1
    IL_000B: initobj Z0.N4
    IL_0011: ldloc.1
    IL_0012: call Z0.NatVal Z0.NatMath::mod<Z0.N32,Z0.N4>(Z0.N32,Z0.N4)
    IL_0017: call System.Int32 Z0.NatVal::op_Implicit(Z0.NatVal)
    IL_001C: ret

}
ulong pow2()
{
    IL_0000: ldloca.s V_0
    IL_0002: initobj Z0.N16
    IL_0008: ldloc.0
    IL_0009: call Z0.NatVal Z0.NatMath::pow2<Z0.N16>(Z0.N16)
    IL_000E: call System.UInt64 Z0.NatVal::op_Implicit(Z0.NatVal)
    IL_0013: ret

}
ulong sll()
{
    IL_0000: ldloca.s V_0
    IL_0002: initobj Z0.N32
    IL_0008: ldloc.0
    IL_0009: ldloca.s V_0
    IL_000B: initobj Z0.N32
    IL_0011: ldloc.0
    IL_0012: call Z0.NatVal Z0.NatMath::sll<Z0.N32,Z0.N32>(Z0.N32,Z0.N32)
    IL_0017: call System.UInt64 Z0.NatVal::op_Implicit(Z0.NatVal)
    IL_001C: ret

}
ulong srl()
{
    IL_0000: ldloca.s V_0
    IL_0002: initobj Z0.N1024
    IL_0008: ldloc.0
    IL_0009: ldloca.s V_1
    IL_000B: initobj Z0.N8
    IL_0011: ldloc.1
    IL_0012: call Z0.NatVal Z0.NatMath::sll<Z0.N1024,Z0.N8>(Z0.N1024,Z0.N8)
    IL_0017: call System.UInt64 Z0.NatVal::op_Implicit(Z0.NatVal)
    IL_001C: ret

}
ulong rotr64u()
{
    IL_0000: call System.UInt64 Z0.NatMath::rotr<System.UInt64,Z0.N1024,Z0.N8>()
    IL_0005: ret

}
byte rotr8u_1()
{
    IL_0000: call System.Byte Z0.NatMath::rotr<System.Byte,Z0.N128,Z0.N1>()
    IL_0005: ret

}
byte rotr8u_2()
{
    IL_0000: call System.Byte Z0.NatMath::rotr<System.Byte,Z0.N128,Z0.N2>()
    IL_0005: ret

}
byte rotr8u_3()
{
    IL_0000: call System.Byte Z0.NatMath::rotr<System.Byte,Z0.N128,Z0.N3>()
    IL_0005: ret

}
Vec256<ulong> perm4x64_256x64(Vec256<ulong> src)
{
    IL_0000: ldarg.1
    IL_0001: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>)
    IL_0006: ldc.i4 228
    IL_000B: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::vperm4x64(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,Z0.Perm4)
    IL_0010: stloc.0
    IL_0011: ldloc.0
    IL_0012: ldc.i4 180
    IL_0017: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::vperm4x64(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,Z0.Perm4)
    IL_001C: stloc.0
    IL_001D: ldloc.0
    IL_001E: ldc.i4 216
    IL_0023: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::vperm4x64(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,Z0.Perm4)
    IL_0028: stloc.0
    IL_0029: ldloc.0
    IL_002A: ldc.i4.s 120
    IL_002C: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::vperm4x64(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,Z0.Perm4)
    IL_0031: stloc.0
    IL_0032: ldloc.0
    IL_0033: ldc.i4 156
    IL_0038: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::vperm4x64(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,Z0.Perm4)
    IL_003D: stloc.0
    IL_003E: ldloc.0
    IL_003F: ldc.i4.s 108
    IL_0041: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::vperm4x64(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,Z0.Perm4)
    IL_0046: stloc.0
    IL_0047: ldloc.0
    IL_0048: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_004D: ret

}
Vec256<ulong> perm4x64_256x64(ulong a, ulong b, ulong c, ulong d)
{
    IL_0000: call Z0.N256 zfunc::get_n256()
    IL_0005: ldarg.1
    IL_0006: ldarg.2
    IL_0007: ldarg.3
    IL_0008: ldarg.s d
    IL_000A: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::vparts(Z0.N256,System.UInt64,System.UInt64,System.UInt64,System.UInt64)
    IL_000F: stloc.0
    IL_0010: ldloc.0
    IL_0011: ldc.i4 228
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::vperm4x64(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,Z0.Perm4)
    IL_001B: stloc.1
    IL_001C: ldloc.1
    IL_001D: ldc.i4 180
    IL_0022: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::vperm4x64(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,Z0.Perm4)
    IL_0027: stloc.1
    IL_0028: ldloc.1
    IL_0029: ldc.i4 216
    IL_002E: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::vperm4x64(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,Z0.Perm4)
    IL_0033: stloc.1
    IL_0034: ldloc.1
    IL_0035: ldc.i4.s 120
    IL_0037: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::vperm4x64(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,Z0.Perm4)
    IL_003C: stloc.1
    IL_003D: ldloc.1
    IL_003E: ldc.i4 156
    IL_0043: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::vperm4x64(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,Z0.Perm4)
    IL_0048: stloc.1
    IL_0049: ldloc.1
    IL_004A: ldc.i4.s 108
    IL_004C: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::vperm4x64(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,Z0.Perm4)
    IL_0051: stloc.1
    IL_0052: ldloc.1
    IL_0053: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0058: ret

}
int Switch14(int x)
{
    IL_0000: ldarg.1
    IL_0001: ldc.i4.1
    IL_0002: sub
    IL_0003: switch(IL_0062,IL_0064,IL_0066,IL_0068,IL_006B,IL_006E,IL_0071,IL_0077,IL_007D,IL_0083,IL_0089,IL_008F,IL_0092,IL_0095)
    IL_0040: ldarg.1
    IL_0041: ldc.i4 7000
    IL_0046: sub
    IL_0047: switch(IL_0098,IL_009E,IL_00A4,IL_00A7,IL_00AA)
    IL_0060: br.s IL_00AD
    IL_0062: ldc.i4.1
    IL_0063: ret
    IL_0064: ldc.i4.4
    IL_0065: ret
    IL_0066: ldc.i4.8
    IL_0067: ret
    IL_0068: ldc.i4.s 16
    IL_006A: ret
    IL_006B: ldc.i4.s 32
    IL_006D: ret
    IL_006E: ldc.i4.s 64
    IL_0070: ret
    IL_0071: ldc.i4 128
    IL_0076: ret
    IL_0077: ldc.i4 256
    IL_007C: ret
    IL_007D: ldc.i4 512
    IL_0082: ret
    IL_0083: ldc.i4 1024
    IL_0088: ret
    IL_0089: ldc.i4 2028
    IL_008E: ret
    IL_008F: ldc.i4.s 10
    IL_0091: ret
    IL_0092: ldc.i4.s 20
    IL_0094: ret
    IL_0095: ldc.i4.s 30
    IL_0097: ret
    IL_0098: ldc.i4 1024
    IL_009D: ret
    IL_009E: ldc.i4 2028
    IL_00A3: ret
    IL_00A4: ldc.i4.s 10
    IL_00A6: ret
    IL_00A7: ldc.i4.s 20
    IL_00A9: ret
    IL_00AA: ldc.i4.s 30
    IL_00AC: ret
    IL_00AD: ldc.i4.0
    IL_00AE: ret

}
int IfElse10(int x)
{
    IL_0000: ldarg.1
    IL_0001: ldc.i4.1
    IL_0002: bne.un.s IL_0006
    IL_0004: ldc.i4.1
    IL_0005: ret
    IL_0006: ldarg.1
    IL_0007: ldc.i4.2
    IL_0008: bne.un.s IL_000C
    IL_000A: ldc.i4.4
    IL_000B: ret
    IL_000C: ldarg.1
    IL_000D: ldc.i4.3
    IL_000E: bne.un.s IL_0012
    IL_0010: ldc.i4.8
    IL_0011: ret
    IL_0012: ldarg.1
    IL_0013: ldc.i4.4
    IL_0014: bne.un.s IL_0019
    IL_0016: ldc.i4.s 16
    IL_0018: ret
    IL_0019: ldarg.1
    IL_001A: ldc.i4.5
    IL_001B: bne.un.s IL_0020
    IL_001D: ldc.i4.s 32
    IL_001F: ret
    IL_0020: ldarg.1
    IL_0021: ldc.i4.6
    IL_0022: bne.un.s IL_0027
    IL_0024: ldc.i4.s 64
    IL_0026: ret
    IL_0027: ldarg.1
    IL_0028: ldc.i4.7
    IL_0029: bne.un.s IL_0031
    IL_002B: ldc.i4 128
    IL_0030: ret
    IL_0031: ldarg.1
    IL_0032: ldc.i4.8
    IL_0033: bne.un.s IL_003B
    IL_0035: ldc.i4 256
    IL_003A: ret
    IL_003B: ldarg.1
    IL_003C: ldc.i4.s 9
    IL_003E: bne.un.s IL_0046
    IL_0040: ldc.i4 512
    IL_0045: ret
    IL_0046: ldarg.1
    IL_0047: ldc.i4.s 10
    IL_0049: bne.un.s IL_0051
    IL_004B: ldc.i4 1024
    IL_0050: ret
    IL_0051: ldc.i4.0
    IL_0052: ret

}
ReadOnlySpan<byte> get_U8Data()
{
    IL_0000: ldsflda <PrivateImplementationDetails>/__StaticArrayInitTypeSize=64 <PrivateImplementationDetails>::4C95376F0126070C5E113DDFB17BBF8C2071FC7B
    IL_0005: ldc.i4.s 64
    IL_0007: newobj System.Void System.ReadOnlySpan`1<System.Byte>::.ctor(System.Void*,System.Int32)
    IL_000C: ret

}
ReadOnlySpan<uint> get_U32Data()
{
    IL_0000: ldc.i4.s 16
    IL_0002: newarr System.UInt32
    IL_0007: dup
    IL_0008: ldtoken <PrivateImplementationDetails>/__StaticArrayInitTypeSize=64 <PrivateImplementationDetails>::2609FDA7513B2554C91B1C8B04A5DE75A8ED6688
    IL_000D: call System.Void System.Runtime.CompilerServices.RuntimeHelpers::InitializeArray(System.Array,System.RuntimeFieldHandle)
    IL_0012: call System.ReadOnlySpan`1<System.UInt32> System.ReadOnlySpan`1<System.UInt32>::op_Implicit(System.UInt32[])
    IL_0017: ret

}
uint Or8Inline(uint x0, uint x1, uint x2, uint x3, uint x4, uint x5, uint x6, uint x7)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: or
    IL_0003: ldarg.2
    IL_0004: or
    IL_0005: ldarg.3
    IL_0006: or
    IL_0007: ldarg.s x4
    IL_0009: or
    IL_000A: ldarg.s x5
    IL_000C: or
    IL_000D: ldarg.s x6
    IL_000F: or
    IL_0010: ldarg.s x7
    IL_0012: or
    IL_0013: ret

}
uint RotLU32Inline(uint x, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.s 31
    IL_0004: and
    IL_0005: shl
    IL_0006: ldarg.0
    IL_0007: ldc.i4.s 32
    IL_0009: ldarg.1
    IL_000A: sub
    IL_000B: ldc.i4.s 31
    IL_000D: and
    IL_000E: shr.un
    IL_000F: or
    IL_0010: ret

}
int ChoiceIfElse5Inline(int x)
{
    IL_0000: ldarg.1
    IL_0001: ldc.i4.1
    IL_0002: bne.un.s IL_0006
    IL_0004: ldc.i4.1
    IL_0005: ret
    IL_0006: ldarg.1
    IL_0007: ldc.i4.2
    IL_0008: bne.un.s IL_000C
    IL_000A: ldc.i4.4
    IL_000B: ret
    IL_000C: ldarg.1
    IL_000D: ldc.i4.3
    IL_000E: bne.un.s IL_0012
    IL_0010: ldc.i4.8
    IL_0011: ret
    IL_0012: ldarg.1
    IL_0013: ldc.i4.4
    IL_0014: bne.un.s IL_0019
    IL_0016: ldc.i4.s 16
    IL_0018: ret
    IL_0019: ldarg.1
    IL_001A: ldc.i4.5
    IL_001B: bne.un.s IL_0020
    IL_001D: ldc.i4.s 32
    IL_001F: ret
    IL_0020: ldc.i4.0
    IL_0021: ret

}
int CheckMatches()
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: ldloc.0
    IL_0003: ldarg.0
    IL_0004: call System.Int32 Z0.ExperimentalScenarios::CheckMatches<System.SByte>()
    IL_0009: or
    IL_000A: stloc.0
    IL_000B: ldloc.0
    IL_000C: ldarg.0
    IL_000D: call System.Int32 Z0.ExperimentalScenarios::CheckMatches<System.Byte>()
    IL_0012: or
    IL_0013: stloc.0
    IL_0014: ldloc.0
    IL_0015: ldarg.0
    IL_0016: call System.Int32 Z0.ExperimentalScenarios::CheckMatches<System.Int16>()
    IL_001B: or
    IL_001C: stloc.0
    IL_001D: ldloc.0
    IL_001E: ldarg.0
    IL_001F: call System.Int32 Z0.ExperimentalScenarios::CheckMatches<System.UInt16>()
    IL_0024: or
    IL_0025: stloc.0
    IL_0026: ldloc.0
    IL_0027: ldarg.0
    IL_0028: call System.Int32 Z0.ExperimentalScenarios::CheckMatches<System.Int32>()
    IL_002D: or
    IL_002E: stloc.0
    IL_002F: ldloc.0
    IL_0030: ldarg.0
    IL_0031: call System.Int32 Z0.ExperimentalScenarios::CheckMatches<System.UInt32>()
    IL_0036: or
    IL_0037: stloc.0
    IL_0038: ldloc.0
    IL_0039: ldarg.0
    IL_003A: call System.Int32 Z0.ExperimentalScenarios::CheckMatches<System.Int64>()
    IL_003F: or
    IL_0040: stloc.0
    IL_0041: ldloc.0
    IL_0042: ldarg.0
    IL_0043: call System.Int32 Z0.ExperimentalScenarios::CheckMatches<System.UInt64>()
    IL_0048: or
    IL_0049: stloc.0
    IL_004A: ldloc.0
    IL_004B: ldarg.0
    IL_004C: call System.Int32 Z0.ExperimentalScenarios::CheckMatches<System.Single>()
    IL_0051: or
    IL_0052: stloc.0
    IL_0053: ldloc.0
    IL_0054: ldarg.0
    IL_0055: call System.Int32 Z0.ExperimentalScenarios::CheckMatches<System.Double>()
    IL_005A: or
    IL_005B: stloc.0
    IL_005C: ldloc.0
    IL_005D: ret

}
ReadOnlySpan<byte> ReadU8Data(int count)
{
    IL_0000: call System.ReadOnlySpan`1<System.Byte> Z0.ExperimentalScenarios::get_U8Data()
    IL_0005: ret

}
ReadOnlySpan<uint> ReadU32Data(int count)
{
    IL_0000: call System.ReadOnlySpan`1<System.UInt32> Z0.ExperimentalScenarios::get_U32Data()
    IL_0005: ret

}
void VoidReturn()
{
    IL_0000: ldstr ""
    IL_0005: call System.Void System.Console::Write(System.String)
    IL_000A: ret

}
int SizeTest()
{
    IL_0000: ldc.i4.0
    IL_0001: stloc.0
    IL_0002: ldc.i4.1
    IL_0003: stloc.1
    IL_0004: ldc.i4.2
    IL_0005: stloc.2
    IL_0006: ldc.i4.1
    IL_0007: stloc.3
    IL_0008: ldc.i4.2
    IL_0009: stloc.s V_4
    IL_000B: ldc.i4.2
    IL_000C: stloc.s V_5
    IL_000E: ldloc.3
    IL_000F: ldloc.s V_4
    IL_0011: mul
    IL_0012: ldloc.s V_5
    IL_0014: mul
    IL_0015: stloc.s V_6
    IL_0017: ldloc.0
    IL_0018: ldloc.1
    IL_0019: add
    IL_001A: ldloc.2
    IL_001B: add
    IL_001C: stloc.s V_7
    IL_001E: ldloc.s V_6
    IL_0020: ldloc.s V_7
    IL_0022: add
    IL_0023: ret

}
void VoidCalls1()
{
    IL_0000: ldarg.0
    IL_0001: call System.Void Z0.ExperimentalScenarios::VoidReturn()
    IL_0006: ret

}
void VoidCalls2()
{
    IL_0000: ldarg.0
    IL_0001: call System.Void Z0.ExperimentalScenarios::VoidReturn()
    IL_0006: ldarg.0
    IL_0007: call System.Void Z0.ExperimentalScenarios::VoidReturn()
    IL_000C: ret

}
void VoidCalls3()
{
    IL_0000: ldarg.0
    IL_0001: call System.Void Z0.ExperimentalScenarios::VoidReturn()
    IL_0006: ldarg.0
    IL_0007: call System.Void Z0.ExperimentalScenarios::VoidReturn()
    IL_000C: ldarg.0
    IL_000D: call System.Void Z0.ExperimentalScenarios::VoidReturn()
    IL_0012: ret

}
void VoidCalls4()
{
    IL_0000: ldarg.0
    IL_0001: call System.Void Z0.ExperimentalScenarios::VoidReturn()
    IL_0006: ldarg.0
    IL_0007: call System.Void Z0.ExperimentalScenarios::VoidReturn()
    IL_000C: ldarg.0
    IL_000D: call System.Void Z0.ExperimentalScenarios::VoidReturn()
    IL_0012: ldarg.0
    IL_0013: call System.Void Z0.ExperimentalScenarios::VoidReturn()
    IL_0018: ret

}
int InvokeBinOp(Func<int,int,int> f, int x, int y)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.2
    IL_0002: ldarg.3
    IL_0003: callvirt System.Int32 System.Func`3<System.Int32,System.Int32,System.Int32>::Invoke(System.Int32,System.Int32)
    IL_0008: ret

}
int AddMulInline(int x, int y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: add
    IL_0003: ldarg.0
    IL_0004: mul
    IL_0005: ldarg.0
    IL_0006: ldarg.1
    IL_0007: add
    IL_0008: ldarg.1
    IL_0009: mul
    IL_000A: add
    IL_000B: ret

}
int CallInvokeBinOp(int x, int y)
{
    IL_0000: ldarg.0
    IL_0001: ldnull
    IL_0002: ldftn System.Int32 Z0.ExperimentalScenarios::AddMulInline(System.Int32,System.Int32)
    IL_0008: newobj System.Void System.Func`3<System.Int32,System.Int32,System.Int32>::.ctor(System.Object,System.IntPtr)
    IL_000D: ldarg.1
    IL_000E: ldarg.2
    IL_000F: call System.Int32 Z0.ExperimentalScenarios::InvokeBinOp(System.Func`3<System.Int32,System.Int32,System.Int32>,System.Int32,System.Int32)
    IL_0014: ret

}
int And(int a, int b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: and
    IL_0003: ret

}
int Or(int a, int b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: or
    IL_0003: ret

}
int Xor(int a, int b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: xor
    IL_0003: ret

}
int Nand(int a, int b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Int32 Z0.ExperimentalScenarios::And(System.Int32,System.Int32)
    IL_0007: not
    IL_0008: ret

}
int Jump(int target, int a, int b)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.1
    IL_0002: beq.s IL_0024
    IL_0004: ldarg.0
    IL_0005: ldc.i4.2
    IL_0006: beq.s IL_001C
    IL_0008: ldarg.0
    IL_0009: ldc.i4.3
    IL_000A: beq.s IL_0014
    IL_000C: ldarg.1
    IL_000D: ldarg.2
    IL_000E: call System.Int32 Z0.ExperimentalScenarios::Nand(System.Int32,System.Int32)
    IL_0013: ret
    IL_0014: ldarg.1
    IL_0015: ldarg.2
    IL_0016: call System.Int32 Z0.ExperimentalScenarios::Xor(System.Int32,System.Int32)
    IL_001B: ret
    IL_001C: ldarg.1
    IL_001D: ldarg.2
    IL_001E: call System.Int32 Z0.ExperimentalScenarios::Or(System.Int32,System.Int32)
    IL_0023: ret
    IL_0024: ldarg.1
    IL_0025: ldarg.2
    IL_0026: call System.Int32 Z0.ExperimentalScenarios::And(System.Int32,System.Int32)
    IL_002B: ret

}
int Jump()
{
    IL_0000: ldc.i4.3
    IL_0001: ldc.i4.s 11
    IL_0003: ldc.i4.s 12
    IL_0005: call System.Int32 Z0.ExperimentalScenarios::Jump(System.Int32,System.Int32,System.Int32)
    IL_000A: ret

}
int Mul(int a, int b)
{
    IL_0000: call Z0.IOp`1<System.Int32> Z0.OpFactory::Mul<System.Int32>()
    IL_0005: ldarg.0
    IL_0006: ldarg.1
    IL_0007: call System.Int32 Z0.ExperimentalScenarios::Apply<System.Int32>(Z0.IOp`1<System.Int32>,System.Int32,System.Int32)
    IL_000C: ret

}
