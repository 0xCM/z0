// 2019-11-28 20:16:39:809
BitGrid64<N8,N8,ulong> bg_fw64_transpose_8x8x64(BitGrid64<N8,N8,ulong> g)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.BitGrid64`3<Z0.N8,Z0.N8,System.UInt64> Z0.BitGrid::transpose<System.UInt64>(Z0.BitGrid64`3<Z0.N8,Z0.N8,System.UInt64>)
    IL_0006: ret

}
BitGrid64<N8,N8,ulong> bg_fw64_transpose_8x8x64_ur(BitGrid64<N8,N8,ulong> g)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt64 Z0.BitGrid64`3<Z0.N8,Z0.N8,System.UInt64>::op_Implicit(Z0.BitGrid64`3<Z0.N8,Z0.N8,System.UInt64>)
    IL_0006: stloc.0
    IL_0007: call Z0.N64 zfunc::get_n64()
    IL_000C: call Z0.N8 zfunc::get_n8()
    IL_0011: call Z0.N8 zfunc::get_n8()
    IL_0016: call Z0.BitGrid64`3<Z0.N8,Z0.N8,System.Byte> Z0.BitGrid::alloc<System.Byte>(Z0.N64,Z0.N8,Z0.N8)
    IL_001B: stloc.1
    IL_001C: call Z0.N128 zfunc::get_n128()
    IL_0021: ldloc.0
    IL_0022: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.dinx::vmov(Z0.N128,System.UInt64)
    IL_0027: stloc.2
    IL_0028: ldloca.s V_1
    IL_002A: ldc.i4.7
    IL_002B: call System.Byte& Z0.BitGrid64`3<Z0.N8,Z0.N8,System.Byte>::get_Item(System.Int32)
    IL_0030: ldloc.2
    IL_0031: call System.Runtime.Intrinsics.Vector128`1<System.Byte> zfunc::v8u<System.UInt64>(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0036: call System.UInt32 Z0.dinx::vmovemask(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_003B: conv.u1
    IL_003C: stind.i1
    IL_003D: ldloc.2
    IL_003E: ldc.i4.1
    IL_003F: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.dinx::vsll(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Byte)
    IL_0044: stloc.2
    IL_0045: ldloca.s V_1
    IL_0047: ldc.i4.6
    IL_0048: call System.Byte& Z0.BitGrid64`3<Z0.N8,Z0.N8,System.Byte>::get_Item(System.Int32)
    IL_004D: ldloc.2
    IL_004E: call System.Runtime.Intrinsics.Vector128`1<System.Byte> zfunc::v8u<System.UInt64>(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0053: call System.UInt32 Z0.dinx::vmovemask(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0058: conv.u1
    IL_0059: stind.i1
    IL_005A: ldloc.2
    IL_005B: ldc.i4.1
    IL_005C: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.dinx::vsll(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Byte)
    IL_0061: stloc.2
    IL_0062: ldloca.s V_1
    IL_0064: ldc.i4.5
    IL_0065: call System.Byte& Z0.BitGrid64`3<Z0.N8,Z0.N8,System.Byte>::get_Item(System.Int32)
    IL_006A: ldloc.2
    IL_006B: call System.Runtime.Intrinsics.Vector128`1<System.Byte> zfunc::v8u<System.UInt64>(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0070: call System.UInt32 Z0.dinx::vmovemask(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0075: conv.u1
    IL_0076: stind.i1
    IL_0077: ldloc.2
    IL_0078: ldc.i4.1
    IL_0079: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.dinx::vsll(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Byte)
    IL_007E: stloc.2
    IL_007F: ldloca.s V_1
    IL_0081: ldc.i4.4
    IL_0082: call System.Byte& Z0.BitGrid64`3<Z0.N8,Z0.N8,System.Byte>::get_Item(System.Int32)
    IL_0087: ldloc.2
    IL_0088: call System.Runtime.Intrinsics.Vector128`1<System.Byte> zfunc::v8u<System.UInt64>(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_008D: call System.UInt32 Z0.dinx::vmovemask(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0092: conv.u1
    IL_0093: stind.i1
    IL_0094: ldloc.2
    IL_0095: ldc.i4.1
    IL_0096: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.dinx::vsll(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Byte)
    IL_009B: stloc.2
    IL_009C: ldloca.s V_1
    IL_009E: ldc.i4.3
    IL_009F: call System.Byte& Z0.BitGrid64`3<Z0.N8,Z0.N8,System.Byte>::get_Item(System.Int32)
    IL_00A4: ldloc.2
    IL_00A5: call System.Runtime.Intrinsics.Vector128`1<System.Byte> zfunc::v8u<System.UInt64>(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_00AA: call System.UInt32 Z0.dinx::vmovemask(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_00AF: conv.u1
    IL_00B0: stind.i1
    IL_00B1: ldloc.2
    IL_00B2: ldc.i4.1
    IL_00B3: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.dinx::vsll(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Byte)
    IL_00B8: stloc.2
    IL_00B9: ldloca.s V_1
    IL_00BB: ldc.i4.2
    IL_00BC: call System.Byte& Z0.BitGrid64`3<Z0.N8,Z0.N8,System.Byte>::get_Item(System.Int32)
    IL_00C1: ldloc.2
    IL_00C2: call System.Runtime.Intrinsics.Vector128`1<System.Byte> zfunc::v8u<System.UInt64>(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_00C7: call System.UInt32 Z0.dinx::vmovemask(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_00CC: conv.u1
    IL_00CD: stind.i1
    IL_00CE: ldloc.2
    IL_00CF: ldc.i4.1
    IL_00D0: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.dinx::vsll(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Byte)
    IL_00D5: stloc.2
    IL_00D6: ldloca.s V_1
    IL_00D8: ldc.i4.1
    IL_00D9: call System.Byte& Z0.BitGrid64`3<Z0.N8,Z0.N8,System.Byte>::get_Item(System.Int32)
    IL_00DE: ldloc.2
    IL_00DF: call System.Runtime.Intrinsics.Vector128`1<System.Byte> zfunc::v8u<System.UInt64>(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_00E4: call System.UInt32 Z0.dinx::vmovemask(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_00E9: conv.u1
    IL_00EA: stind.i1
    IL_00EB: ldloc.2
    IL_00EC: ldc.i4.1
    IL_00ED: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.dinx::vsll(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Byte)
    IL_00F2: stloc.2
    IL_00F3: ldloca.s V_1
    IL_00F5: ldc.i4.0
    IL_00F6: call System.Byte& Z0.BitGrid64`3<Z0.N8,Z0.N8,System.Byte>::get_Item(System.Int32)
    IL_00FB: ldloc.2
    IL_00FC: call System.Runtime.Intrinsics.Vector128`1<System.Byte> zfunc::v8u<System.UInt64>(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0101: call System.UInt32 Z0.dinx::vmovemask(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0106: conv.u1
    IL_0107: stind.i1
    IL_0108: ldloca.s V_1
    IL_010A: call Z0.BitGrid64`1<System.UInt64> Z0.BitGrid64`3<Z0.N8,Z0.N8,System.Byte>::As<System.UInt64>()
    IL_010F: call Z0.BitGrid64`3<Z0.N8,Z0.N8,System.UInt64> Z0.BitGrid64`3<Z0.N8,Z0.N8,System.UInt64>::op_Implicit(Z0.BitGrid64`1<System.UInt64>)
    IL_0114: ret

}
BitGrid64<uint> bg64_and_32(BitGrid64<uint> gx, BitGrid64<uint> gy)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.BitGrid64`1<System.UInt32> Z0.BitGrid::and<System.UInt32>(Z0.BitGrid64`1<System.UInt32>,Z0.BitGrid64`1<System.UInt32>)
    IL_0007: ret

}
BitGrid64<N16,N4,uint> bg64_and_32(BitGrid64<N16,N4,uint> gx, BitGrid64<N16,N4,uint> gy)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.BitGrid64`1<System.UInt32> Z0.BitGrid64`3<Z0.N16,Z0.N4,System.UInt32>::op_Implicit(Z0.BitGrid64`3<Z0.N16,Z0.N4,System.UInt32>)
    IL_0006: ldarg.1
    IL_0007: call Z0.BitGrid64`1<System.UInt32> Z0.BitGrid64`3<Z0.N16,Z0.N4,System.UInt32>::op_Implicit(Z0.BitGrid64`3<Z0.N16,Z0.N4,System.UInt32>)
    IL_000C: call Z0.BitGrid64`1<System.UInt32> Z0.BitGrid::and<System.UInt32>(Z0.BitGrid64`1<System.UInt32>,Z0.BitGrid64`1<System.UInt32>)
    IL_0011: call Z0.BitGrid64`3<Z0.N16,Z0.N4,System.UInt32> Z0.BitGrid64`3<Z0.N16,Z0.N4,System.UInt32>::op_Implicit(Z0.BitGrid64`1<System.UInt32>)
    IL_0016: ret

}
BitGrid128<uint> bg_and_128x32(BitGrid128<uint> gx, BitGrid128<uint> gy)
{
    IL_0000: ldarga.s gx
    IL_0002: ldarga.s gy
    IL_0004: call Z0.BitGrid128`1<System.UInt32> Z0.BitGrid::and<System.UInt32>(Z0.BitGrid128`1<System.UInt32>&,Z0.BitGrid128`1<System.UInt32>&)
    IL_0009: ret

}
BitGrid128<N16,N4,uint> bg_and_16x4_128x32(BitGrid128<N16,N4,uint> gx, BitGrid128<N16,N4,uint> gy)
{
    IL_0000: ldarga.s gx
    IL_0002: call Z0.BitGrid128`1<System.UInt32> Z0.BitGrid128`3<Z0.N16,Z0.N4,System.UInt32>::op_Implicit(Z0.BitGrid128`3<Z0.N16,Z0.N4,System.UInt32>&)
    IL_0007: stloc.0
    IL_0008: ldloca.s V_0
    IL_000A: ldarga.s gy
    IL_000C: call Z0.BitGrid128`1<System.UInt32> Z0.BitGrid128`3<Z0.N16,Z0.N4,System.UInt32>::op_Implicit(Z0.BitGrid128`3<Z0.N16,Z0.N4,System.UInt32>&)
    IL_0011: stloc.1
    IL_0012: ldloca.s V_1
    IL_0014: call Z0.BitGrid128`1<System.UInt32> Z0.BitGrid::and<System.UInt32>(Z0.BitGrid128`1<System.UInt32>&,Z0.BitGrid128`1<System.UInt32>&)
    IL_0019: stloc.2
    IL_001A: ldloca.s V_2
    IL_001C: call Z0.BitGrid128`3<Z0.N16,Z0.N4,System.UInt32> Z0.BitGrid128`3<Z0.N16,Z0.N4,System.UInt32>::op_Implicit(Z0.BitGrid128`1<System.UInt32>&)
    IL_0021: ret

}
BitGrid256<N32,N8,uint> bg_and_16x4_128x32(BitGrid256<N32,N8,uint> gx, BitGrid256<N32,N8,uint> gy)
{
    IL_0000: ldarga.s gx
    IL_0002: call Z0.BitGrid256`1<System.UInt32> Z0.BitGrid256`3<Z0.N32,Z0.N8,System.UInt32>::op_Implicit(Z0.BitGrid256`3<Z0.N32,Z0.N8,System.UInt32>&)
    IL_0007: stloc.0
    IL_0008: ldloca.s V_0
    IL_000A: ldarga.s gy
    IL_000C: call Z0.BitGrid256`1<System.UInt32> Z0.BitGrid256`3<Z0.N32,Z0.N8,System.UInt32>::op_Implicit(Z0.BitGrid256`3<Z0.N32,Z0.N8,System.UInt32>&)
    IL_0011: stloc.1
    IL_0012: ldloca.s V_1
    IL_0014: call Z0.BitGrid256`1<System.UInt32> Z0.BitGrid::and<System.UInt32>(Z0.BitGrid256`1<System.UInt32>&,Z0.BitGrid256`1<System.UInt32>&)
    IL_0019: stloc.2
    IL_001A: ldloca.s V_2
    IL_001C: call Z0.BitGrid256`3<Z0.N32,Z0.N8,System.UInt32> Z0.BitGrid256`3<Z0.N32,Z0.N8,System.UInt32>::op_Implicit(Z0.BitGrid256`1<System.UInt32>&)
    IL_0021: ret

}
void set_bit(ref uint src, byte pos, bit state)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.UInt32& Z0.gbits::set<System.UInt32>(System.UInt32&,System.Byte,Z0.bit)
    IL_0008: pop
    IL_0009: ret

}
void set_bit_on(ref uint src, byte pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.bit::get_On()
    IL_0007: call System.UInt32& Z0.gbits::set<System.UInt32>(System.UInt32&,System.Byte,Z0.bit)
    IL_000C: pop
    IL_000D: ret

}
void set_bit_off(ref uint src, byte pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.bit::get_Off()
    IL_0007: call System.UInt32& Z0.gbits::set<System.UInt32>(System.UInt32&,System.Byte,Z0.bit)
    IL_000C: pop
    IL_000D: ret

}
bit read_bit_from_vector(in BitCells<N23,byte> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Byte& Z0.BitCells`2<Z0.N23,System.Byte>::get_Head()
    IL_0006: ldc.i4.3
    IL_0007: call Z0.bit Z0.BitGrid::readbit<System.Byte>(System.Byte&,System.Int32)
    IL_000C: ret

}
int segments()
{
    IL_0000: call System.Int32 Z0.BitCells`2<Z0.N23,System.Byte>::get_SegCount()
    IL_0005: ret

}
int count_segs()
{
    IL_0000: ldloca.s V_0
    IL_0002: initobj Z0.N20
    IL_0008: ldloc.0
    IL_0009: ldloca.s V_1
    IL_000B: initobj Z0.N30
    IL_0011: ldloc.1
    IL_0012: ldc.i4.0
    IL_0013: call System.Int32 Z0.BitCalcs::cellcount<Z0.N20,Z0.N30,System.UInt32>(Z0.N20,Z0.N30,System.UInt32)
    IL_0018: ret

}
bit readbit_row_col_2(int n, ulong src, int row, int col)
{
    IL_0000: ldarg.0
    IL_0001: ldarga.s src
    IL_0003: ldarg.2
    IL_0004: ldarg.3
    IL_0005: call Z0.bit Z0.BitGrid::readbit<System.UInt64>(System.Int32,System.UInt64&,System.Int32,System.Int32)
    IL_000A: ret

}
bit readbit_g_position(in ulong src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.BitGrid::readbit<System.UInt64>(System.UInt64&,System.Int32)
    IL_0007: ret

}
