// 2019-11-15 15:23:02:401
Vector128<uint> pack(ReadOnlySpan<N128,bit> src)
{
    IL_0000: call Z0.N1 zfunc::get_n1()
    IL_0005: call Z0.N32 zfunc::get_n32()
    IL_000A: ldarga.s src
    IL_000C: call Z0.ReadOnlySpan`2<Z0.N128,System.UInt32> Z0.ReadOnlySpan`2<Z0.N128,Z0.bit>::As<System.UInt32>()
    IL_0011: call System.UInt32& modreq(System.Runtime.InteropServices.InAttribute) zfunc::head<Z0.N128,System.UInt32>(Z0.ReadOnlySpan`2<Z0.N128,System.UInt32>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.SimdPack::pack(Z0.N1,Z0.N32,System.UInt32&)
    IL_001B: ret

}
Vector128<uint> pack(N1 width, ReadOnlySpan<N128,uint> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.N32 zfunc::get_n32()
    IL_0006: ldarg.1
    IL_0007: call System.UInt32& modreq(System.Runtime.InteropServices.InAttribute) zfunc::head<Z0.N128,System.UInt32>(Z0.ReadOnlySpan`2<Z0.N128,System.UInt32>)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.SimdPack::pack(Z0.N1,Z0.N32,System.UInt32&)
    IL_0011: ret

}
void pack1(ref Vector128<uint> xmm0, ref Vector128<uint> xmm1, in uint src, byte step, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldobj System.Runtime.Intrinsics.Vector128`1<System.UInt32>
    IL_0007: ldarg.1
    IL_0008: ldobj System.Runtime.Intrinsics.Vector128`1<System.UInt32>
    IL_000D: ldarg.3
    IL_000E: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.dinx::vsll(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Byte)
    IL_0013: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.dinx::vor(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0018: stobj System.Runtime.Intrinsics.Vector128`1<System.UInt32>
    IL_001D: ldarg.1
    IL_001E: call Z0.N128 zfunc::get_n128()
    IL_0023: ldarg.2
    IL_0024: ldarg.s offset
    IL_0026: call System.UInt32& modreq(System.Runtime.InteropServices.InAttribute) zfunc::skip<System.UInt32>(System.UInt32&,System.Int32)
    IL_002B: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.dinx::vload(Z0.N128,System.UInt32&)
    IL_0030: stobj System.Runtime.Intrinsics.Vector128`1<System.UInt32>
    IL_0035: ret

}
Vector128<uint> pack(N1 width, N32 n, in uint src)
{
    IL_0000: call Z0.N128 zfunc::get_n128()
    IL_0005: stloc.0
    IL_0006: ldc.i4.0
    IL_0007: stloc.1
    IL_0008: ldloc.0
    IL_0009: ldarg.2
    IL_000A: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.dinx::vload(Z0.N128,System.UInt32&)
    IL_000F: stloc.2
    IL_0010: ldloc.2
    IL_0011: stloc.3
    IL_0012: ldloc.0
    IL_0013: ldarg.2
    IL_0014: ldloc.1
    IL_0015: ldc.i4.4
    IL_0016: add
    IL_0017: dup
    IL_0018: stloc.1
    IL_0019: call System.UInt32& modreq(System.Runtime.InteropServices.InAttribute) zfunc::skip<System.UInt32>(System.UInt32&,System.Int32)
    IL_001E: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.dinx::vload(Z0.N128,System.UInt32&)
    IL_0023: stloc.2
    IL_0024: ldloca.s V_3
    IL_0026: ldloca.s V_2
    IL_0028: ldarg.2
    IL_0029: ldc.i4.1
    IL_002A: ldloc.1
    IL_002B: ldc.i4.4
    IL_002C: add
    IL_002D: dup
    IL_002E: stloc.1
    IL_002F: call System.Void Z0.SimdPack::pack1(System.Runtime.Intrinsics.Vector128`1<System.UInt32>&,System.Runtime.Intrinsics.Vector128`1<System.UInt32>&,System.UInt32&,System.Byte,System.Int32)
    IL_0034: ldloca.s V_3
    IL_0036: ldloca.s V_2
    IL_0038: ldarg.2
    IL_0039: ldc.i4.2
    IL_003A: ldloc.1
    IL_003B: ldc.i4.4
    IL_003C: add
    IL_003D: dup
    IL_003E: stloc.1
    IL_003F: call System.Void Z0.SimdPack::pack1(System.Runtime.Intrinsics.Vector128`1<System.UInt32>&,System.Runtime.Intrinsics.Vector128`1<System.UInt32>&,System.UInt32&,System.Byte,System.Int32)
    IL_0044: ldloca.s V_3
    IL_0046: ldloca.s V_2
    IL_0048: ldarg.2
    IL_0049: ldc.i4.3
    IL_004A: ldloc.1
    IL_004B: ldc.i4.4
    IL_004C: add
    IL_004D: dup
    IL_004E: stloc.1
    IL_004F: call System.Void Z0.SimdPack::pack1(System.Runtime.Intrinsics.Vector128`1<System.UInt32>&,System.Runtime.Intrinsics.Vector128`1<System.UInt32>&,System.UInt32&,System.Byte,System.Int32)
    IL_0054: ldloca.s V_3
    IL_0056: ldloca.s V_2
    IL_0058: ldarg.2
    IL_0059: ldc.i4.4
    IL_005A: ldloc.1
    IL_005B: ldc.i4.4
    IL_005C: add
    IL_005D: dup
    IL_005E: stloc.1
    IL_005F: call System.Void Z0.SimdPack::pack1(System.Runtime.Intrinsics.Vector128`1<System.UInt32>&,System.Runtime.Intrinsics.Vector128`1<System.UInt32>&,System.UInt32&,System.Byte,System.Int32)
    IL_0064: ldloca.s V_3
    IL_0066: ldloca.s V_2
    IL_0068: ldarg.2
    IL_0069: ldc.i4.5
    IL_006A: ldloc.1
    IL_006B: ldc.i4.4
    IL_006C: add
    IL_006D: dup
    IL_006E: stloc.1
    IL_006F: call System.Void Z0.SimdPack::pack1(System.Runtime.Intrinsics.Vector128`1<System.UInt32>&,System.Runtime.Intrinsics.Vector128`1<System.UInt32>&,System.UInt32&,System.Byte,System.Int32)
    IL_0074: ldloca.s V_3
    IL_0076: ldloca.s V_2
    IL_0078: ldarg.2
    IL_0079: ldc.i4.6
    IL_007A: ldloc.1
    IL_007B: ldc.i4.4
    IL_007C: add
    IL_007D: dup
    IL_007E: stloc.1
    IL_007F: call System.Void Z0.SimdPack::pack1(System.Runtime.Intrinsics.Vector128`1<System.UInt32>&,System.Runtime.Intrinsics.Vector128`1<System.UInt32>&,System.UInt32&,System.Byte,System.Int32)
    IL_0084: ldloca.s V_3
    IL_0086: ldloca.s V_2
    IL_0088: ldarg.2
    IL_0089: ldc.i4.7
    IL_008A: ldloc.1
    IL_008B: ldc.i4.4
    IL_008C: add
    IL_008D: dup
    IL_008E: stloc.1
    IL_008F: call System.Void Z0.SimdPack::pack1(System.Runtime.Intrinsics.Vector128`1<System.UInt32>&,System.Runtime.Intrinsics.Vector128`1<System.UInt32>&,System.UInt32&,System.Byte,System.Int32)
    IL_0094: ldloca.s V_3
    IL_0096: ldloca.s V_2
    IL_0098: ldarg.2
    IL_0099: ldc.i4.8
    IL_009A: ldloc.1
    IL_009B: ldc.i4.4
    IL_009C: add
    IL_009D: dup
    IL_009E: stloc.1
    IL_009F: call System.Void Z0.SimdPack::pack1(System.Runtime.Intrinsics.Vector128`1<System.UInt32>&,System.Runtime.Intrinsics.Vector128`1<System.UInt32>&,System.UInt32&,System.Byte,System.Int32)
    IL_00A4: ldloca.s V_3
    IL_00A6: ldloca.s V_2
    IL_00A8: ldarg.2
    IL_00A9: ldc.i4.s 9
    IL_00AB: ldloc.1
    IL_00AC: ldc.i4.4
    IL_00AD: add
    IL_00AE: dup
    IL_00AF: stloc.1
    IL_00B0: call System.Void Z0.SimdPack::pack1(System.Runtime.Intrinsics.Vector128`1<System.UInt32>&,System.Runtime.Intrinsics.Vector128`1<System.UInt32>&,System.UInt32&,System.Byte,System.Int32)
    IL_00B5: ldloca.s V_3
    IL_00B7: ldloca.s V_2
    IL_00B9: ldarg.2
    IL_00BA: ldc.i4.s 10
    IL_00BC: ldloc.1
    IL_00BD: ldc.i4.4
    IL_00BE: add
    IL_00BF: dup
    IL_00C0: stloc.1
    IL_00C1: call System.Void Z0.SimdPack::pack1(System.Runtime.Intrinsics.Vector128`1<System.UInt32>&,System.Runtime.Intrinsics.Vector128`1<System.UInt32>&,System.UInt32&,System.Byte,System.Int32)
    IL_00C6: ldloca.s V_3
    IL_00C8: ldloca.s V_2
    IL_00CA: ldarg.2
    IL_00CB: ldc.i4.s 11
    IL_00CD: ldloc.1
    IL_00CE: ldc.i4.4
    IL_00CF: add
    IL_00D0: dup
    IL_00D1: stloc.1
    IL_00D2: call System.Void Z0.SimdPack::pack1(System.Runtime.Intrinsics.Vector128`1<System.UInt32>&,System.Runtime.Intrinsics.Vector128`1<System.UInt32>&,System.UInt32&,System.Byte,System.Int32)
    IL_00D7: ldloca.s V_3
    IL_00D9: ldloca.s V_2
    IL_00DB: ldarg.2
    IL_00DC: ldc.i4.s 12
    IL_00DE: ldloc.1
    IL_00DF: ldc.i4.4
    IL_00E0: add
    IL_00E1: dup
    IL_00E2: stloc.1
    IL_00E3: call System.Void Z0.SimdPack::pack1(System.Runtime.Intrinsics.Vector128`1<System.UInt32>&,System.Runtime.Intrinsics.Vector128`1<System.UInt32>&,System.UInt32&,System.Byte,System.Int32)
    IL_00E8: ldloca.s V_3
    IL_00EA: ldloca.s V_2
    IL_00EC: ldarg.2
    IL_00ED: ldc.i4.s 13
    IL_00EF: ldloc.1
    IL_00F0: ldc.i4.4
    IL_00F1: add
    IL_00F2: dup
    IL_00F3: stloc.1
    IL_00F4: call System.Void Z0.SimdPack::pack1(System.Runtime.Intrinsics.Vector128`1<System.UInt32>&,System.Runtime.Intrinsics.Vector128`1<System.UInt32>&,System.UInt32&,System.Byte,System.Int32)
    IL_00F9: ldloca.s V_3
    IL_00FB: ldloca.s V_2
    IL_00FD: ldarg.2
    IL_00FE: ldc.i4.s 14
    IL_0100: ldloc.1
    IL_0101: ldc.i4.4
    IL_0102: add
    IL_0103: dup
    IL_0104: stloc.1
    IL_0105: call System.Void Z0.SimdPack::pack1(System.Runtime.Intrinsics.Vector128`1<System.UInt32>&,System.Runtime.Intrinsics.Vector128`1<System.UInt32>&,System.UInt32&,System.Byte,System.Int32)
    IL_010A: ldloca.s V_3
    IL_010C: ldloca.s V_2
    IL_010E: ldarg.2
    IL_010F: ldc.i4.s 15
    IL_0111: ldloc.1
    IL_0112: ldc.i4.4
    IL_0113: add
    IL_0114: dup
    IL_0115: stloc.1
    IL_0116: call System.Void Z0.SimdPack::pack1(System.Runtime.Intrinsics.Vector128`1<System.UInt32>&,System.Runtime.Intrinsics.Vector128`1<System.UInt32>&,System.UInt32&,System.Byte,System.Int32)
    IL_011B: ldloca.s V_3
    IL_011D: ldloca.s V_2
    IL_011F: ldarg.2
    IL_0120: ldc.i4.s 16
    IL_0122: ldloc.1
    IL_0123: ldc.i4.4
    IL_0124: add
    IL_0125: dup
    IL_0126: stloc.1
    IL_0127: call System.Void Z0.SimdPack::pack1(System.Runtime.Intrinsics.Vector128`1<System.UInt32>&,System.Runtime.Intrinsics.Vector128`1<System.UInt32>&,System.UInt32&,System.Byte,System.Int32)
    IL_012C: ldloca.s V_3
    IL_012E: ldloca.s V_2
    IL_0130: ldarg.2
    IL_0131: ldc.i4.s 17
    IL_0133: ldloc.1
    IL_0134: ldc.i4.4
    IL_0135: add
    IL_0136: dup
    IL_0137: stloc.1
    IL_0138: call System.Void Z0.SimdPack::pack1(System.Runtime.Intrinsics.Vector128`1<System.UInt32>&,System.Runtime.Intrinsics.Vector128`1<System.UInt32>&,System.UInt32&,System.Byte,System.Int32)
    IL_013D: ldloca.s V_3
    IL_013F: ldloca.s V_2
    IL_0141: ldarg.2
    IL_0142: ldc.i4.s 18
    IL_0144: ldloc.1
    IL_0145: ldc.i4.4
    IL_0146: add
    IL_0147: dup
    IL_0148: stloc.1
    IL_0149: call System.Void Z0.SimdPack::pack1(System.Runtime.Intrinsics.Vector128`1<System.UInt32>&,System.Runtime.Intrinsics.Vector128`1<System.UInt32>&,System.UInt32&,System.Byte,System.Int32)
    IL_014E: ldloca.s V_3
    IL_0150: ldloca.s V_2
    IL_0152: ldarg.2
    IL_0153: ldc.i4.s 19
    IL_0155: ldloc.1
    IL_0156: ldc.i4.4
    IL_0157: add
    IL_0158: dup
    IL_0159: stloc.1
    IL_015A: call System.Void Z0.SimdPack::pack1(System.Runtime.Intrinsics.Vector128`1<System.UInt32>&,System.Runtime.Intrinsics.Vector128`1<System.UInt32>&,System.UInt32&,System.Byte,System.Int32)
    IL_015F: ldloca.s V_3
    IL_0161: ldloca.s V_2
    IL_0163: ldarg.2
    IL_0164: ldc.i4.s 20
    IL_0166: ldloc.1
    IL_0167: ldc.i4.4
    IL_0168: add
    IL_0169: dup
    IL_016A: stloc.1
    IL_016B: call System.Void Z0.SimdPack::pack1(System.Runtime.Intrinsics.Vector128`1<System.UInt32>&,System.Runtime.Intrinsics.Vector128`1<System.UInt32>&,System.UInt32&,System.Byte,System.Int32)
    IL_0170: ldloca.s V_3
    IL_0172: ldloca.s V_2
    IL_0174: ldarg.2
    IL_0175: ldc.i4.s 21
    IL_0177: ldloc.1
    IL_0178: ldc.i4.4
    IL_0179: add
    IL_017A: dup
    IL_017B: stloc.1
    IL_017C: call System.Void Z0.SimdPack::pack1(System.Runtime.Intrinsics.Vector128`1<System.UInt32>&,System.Runtime.Intrinsics.Vector128`1<System.UInt32>&,System.UInt32&,System.Byte,System.Int32)
    IL_0181: ldloca.s V_3
    IL_0183: ldloca.s V_2
    IL_0185: ldarg.2
    IL_0186: ldc.i4.s 22
    IL_0188: ldloc.1
    IL_0189: ldc.i4.4
    IL_018A: add
    IL_018B: dup
    IL_018C: stloc.1
    IL_018D: call System.Void Z0.SimdPack::pack1(System.Runtime.Intrinsics.Vector128`1<System.UInt32>&,System.Runtime.Intrinsics.Vector128`1<System.UInt32>&,System.UInt32&,System.Byte,System.Int32)
    IL_0192: ldloca.s V_3
    IL_0194: ldloca.s V_2
    IL_0196: ldarg.2
    IL_0197: ldc.i4.s 23
    IL_0199: ldloc.1
    IL_019A: ldc.i4.4
    IL_019B: add
    IL_019C: dup
    IL_019D: stloc.1
    IL_019E: call System.Void Z0.SimdPack::pack1(System.Runtime.Intrinsics.Vector128`1<System.UInt32>&,System.Runtime.Intrinsics.Vector128`1<System.UInt32>&,System.UInt32&,System.Byte,System.Int32)
    IL_01A3: ldloca.s V_3
    IL_01A5: ldloca.s V_2
    IL_01A7: ldarg.2
    IL_01A8: ldc.i4.s 24
    IL_01AA: ldloc.1
    IL_01AB: ldc.i4.4
    IL_01AC: add
    IL_01AD: dup
    IL_01AE: stloc.1
    IL_01AF: call System.Void Z0.SimdPack::pack1(System.Runtime.Intrinsics.Vector128`1<System.UInt32>&,System.Runtime.Intrinsics.Vector128`1<System.UInt32>&,System.UInt32&,System.Byte,System.Int32)
    IL_01B4: ldloca.s V_3
    IL_01B6: ldloca.s V_2
    IL_01B8: ldarg.2
    IL_01B9: ldc.i4.s 25
    IL_01BB: ldloc.1
    IL_01BC: ldc.i4.4
    IL_01BD: add
    IL_01BE: dup
    IL_01BF: stloc.1
    IL_01C0: call System.Void Z0.SimdPack::pack1(System.Runtime.Intrinsics.Vector128`1<System.UInt32>&,System.Runtime.Intrinsics.Vector128`1<System.UInt32>&,System.UInt32&,System.Byte,System.Int32)
    IL_01C5: ldloca.s V_3
    IL_01C7: ldloca.s V_2
    IL_01C9: ldarg.2
    IL_01CA: ldc.i4.s 26
    IL_01CC: ldloc.1
    IL_01CD: ldc.i4.4
    IL_01CE: add
    IL_01CF: dup
    IL_01D0: stloc.1
    IL_01D1: call System.Void Z0.SimdPack::pack1(System.Runtime.Intrinsics.Vector128`1<System.UInt32>&,System.Runtime.Intrinsics.Vector128`1<System.UInt32>&,System.UInt32&,System.Byte,System.Int32)
    IL_01D6: ldloca.s V_3
    IL_01D8: ldloca.s V_2
    IL_01DA: ldarg.2
    IL_01DB: ldc.i4.s 27
    IL_01DD: ldloc.1
    IL_01DE: ldc.i4.4
    IL_01DF: add
    IL_01E0: dup
    IL_01E1: stloc.1
    IL_01E2: call System.Void Z0.SimdPack::pack1(System.Runtime.Intrinsics.Vector128`1<System.UInt32>&,System.Runtime.Intrinsics.Vector128`1<System.UInt32>&,System.UInt32&,System.Byte,System.Int32)
    IL_01E7: ldloca.s V_3
    IL_01E9: ldloca.s V_2
    IL_01EB: ldarg.2
    IL_01EC: ldc.i4.s 28
    IL_01EE: ldloc.1
    IL_01EF: ldc.i4.4
    IL_01F0: add
    IL_01F1: dup
    IL_01F2: stloc.1
    IL_01F3: call System.Void Z0.SimdPack::pack1(System.Runtime.Intrinsics.Vector128`1<System.UInt32>&,System.Runtime.Intrinsics.Vector128`1<System.UInt32>&,System.UInt32&,System.Byte,System.Int32)
    IL_01F8: ldloca.s V_3
    IL_01FA: ldloca.s V_2
    IL_01FC: ldarg.2
    IL_01FD: ldc.i4.s 29
    IL_01FF: ldloc.1
    IL_0200: ldc.i4.4
    IL_0201: add
    IL_0202: dup
    IL_0203: stloc.1
    IL_0204: call System.Void Z0.SimdPack::pack1(System.Runtime.Intrinsics.Vector128`1<System.UInt32>&,System.Runtime.Intrinsics.Vector128`1<System.UInt32>&,System.UInt32&,System.Byte,System.Int32)
    IL_0209: ldloca.s V_3
    IL_020B: ldloca.s V_2
    IL_020D: ldarg.2
    IL_020E: ldc.i4.s 30
    IL_0210: ldloc.1
    IL_0211: ldc.i4.4
    IL_0212: add
    IL_0213: dup
    IL_0214: stloc.1
    IL_0215: call System.Void Z0.SimdPack::pack1(System.Runtime.Intrinsics.Vector128`1<System.UInt32>&,System.Runtime.Intrinsics.Vector128`1<System.UInt32>&,System.UInt32&,System.Byte,System.Int32)
    IL_021A: ldloca.s V_3
    IL_021C: ldloca.s V_2
    IL_021E: ldarg.2
    IL_021F: ldc.i4.s 31
    IL_0221: ldloc.1
    IL_0222: ldc.i4.4
    IL_0223: add
    IL_0224: dup
    IL_0225: stloc.1
    IL_0226: call System.Void Z0.SimdPack::pack1(System.Runtime.Intrinsics.Vector128`1<System.UInt32>&,System.Runtime.Intrinsics.Vector128`1<System.UInt32>&,System.UInt32&,System.Byte,System.Int32)
    IL_022B: ldloc.3
    IL_022C: ret

}
