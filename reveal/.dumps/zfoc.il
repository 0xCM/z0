// 2019-10-27 16:51:33:629
ReadOnlySpan<byte> bitseq(byte value)
{
    IL_0000: ldarg.0
    IL_0001: call System.ReadOnlySpan`1<System.Byte> Z0.BitStore::select(System.Byte)
    IL_0006: ret

}
ReadOnlySpan<byte> bitseq(BitSize offset, BitSize count)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.ReadOnlySpan`1<System.Byte> Z0.BitStore::select(Z0.BitSize,Z0.BitSize)
    IL_0007: ret

}
ByteInfo byteinfo(byte src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.ByteInfo Z0.BitStore::info(System.Byte)
    IL_0006: ret

}
ReadOnlySpan<byte> bitseq8i(sbyte src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.ReadOnlySpan`1<System.Byte> Z0.BitStore::bitseq<System.SByte>(System.SByte&)
    IL_0007: ret

}
ReadOnlySpan<byte> bitseq8u(byte src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.ReadOnlySpan`1<System.Byte> Z0.BitStore::bitseq<System.Byte>(System.Byte&)
    IL_0007: ret

}
ReadOnlySpan<byte> bitseq16i(short src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.ReadOnlySpan`1<System.Byte> Z0.BitStore::bitseq<System.Int16>(System.Int16&)
    IL_0007: ret

}
ReadOnlySpan<byte> bitseq16u(ushort src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.ReadOnlySpan`1<System.Byte> Z0.BitStore::bitseq<System.UInt16>(System.UInt16&)
    IL_0007: ret

}
ReadOnlySpan<byte> bitseq32i(int src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.ReadOnlySpan`1<System.Byte> Z0.BitStore::bitseq<System.Int32>(System.Int32&)
    IL_0007: ret

}
ReadOnlySpan<byte> bitseq32u(uint src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.ReadOnlySpan`1<System.Byte> Z0.BitStore::bitseq<System.UInt32>(System.UInt32&)
    IL_0007: ret

}
ReadOnlySpan<byte> bitseq64i(long src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.ReadOnlySpan`1<System.Byte> Z0.BitStore::bitseq<System.Int64>(System.Int64&)
    IL_0007: ret

}
ReadOnlySpan<byte> bitseq64u(ulong src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.ReadOnlySpan`1<System.Byte> Z0.BitStore::bitseq<System.UInt64>(System.UInt64&)
    IL_0007: ret

}
ReadOnlySpan<byte> bitseq32f(float src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.ReadOnlySpan`1<System.Byte> Z0.BitStore::bitseq<System.Single>(System.Single&)
    IL_0007: ret

}
ReadOnlySpan<byte> bitseq64f(double src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.ReadOnlySpan`1<System.Byte> Z0.BitStore::bitseq<System.Double>(System.Double&)
    IL_0007: ret

}
ref sbyte enable_d8i(ref sbyte src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.SByte& Z0.BitMask::enable(System.SByte&,System.Int32)
    IL_0007: ret

}
ref sbyte enable_g8i(ref sbyte src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.SByte& Z0.BitMaskG::enable<System.SByte>(System.SByte&,System.Int32)
    IL_0007: ret

}
ref byte enable_d8u(ref byte src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Byte& Z0.BitMask::enable(System.Byte&,System.Int32)
    IL_0007: ret

}
ref byte enable_g8u(ref byte src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Byte& Z0.BitMaskG::enable<System.Byte>(System.Byte&,System.Int32)
    IL_0007: ret

}
ref short enable_d16i(ref short src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Int16& Z0.BitMask::enable(System.Int16&,System.Int32)
    IL_0007: ret

}
ref short enable_g16i(ref short src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Int16& Z0.BitMaskG::enable<System.Int16>(System.Int16&,System.Int32)
    IL_0007: ret

}
ref ushort enable_d16u(ref ushort src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt16& Z0.BitMask::enable(System.UInt16&,System.Int32)
    IL_0007: ret

}
ref ushort enable_g16u(ref ushort src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt16& Z0.BitMaskG::enable<System.UInt16>(System.UInt16&,System.Int32)
    IL_0007: ret

}
ref int enable_d32i(ref int src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Int32& Z0.BitMask::enable(System.Int32&,System.Int32)
    IL_0007: ret

}
ref int enable_g32i(ref int src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Int32& Z0.BitMaskG::enable<System.Int32>(System.Int32&,System.Int32)
    IL_0007: ret

}
ref uint enable_d32u(ref uint src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32& Z0.BitMask::enable(System.UInt32&,System.Int32)
    IL_0007: ret

}
ref uint enable_g32u(ref uint src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32& Z0.BitMaskG::enable<System.UInt32>(System.UInt32&,System.Int32)
    IL_0007: ret

}
ref long enable_d64i(ref long src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Int64& Z0.BitMask::enable(System.Int64&,System.Int32)
    IL_0007: ret

}
ref long enable_g64i(ref long src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Int64& Z0.BitMaskG::enable<System.Int64>(System.Int64&,System.Int32)
    IL_0007: ret

}
ref ulong enable_d64u(ref ulong src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64& Z0.BitMask::enable(System.UInt64&,System.Int32)
    IL_0007: ret

}
ref ulong enable_g64u(ref ulong src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64& Z0.BitMaskG::enable<System.UInt64>(System.UInt64&,System.Int32)
    IL_0007: ret

}
ref float enable_d32f(ref float src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Single& Z0.BitMask::enable(System.Single&,System.Int32)
    IL_0007: ret

}
ref float enable_g32f(ref float src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Single& Z0.BitMaskG::enable<System.Single>(System.Single&,System.Int32)
    IL_0007: ret

}
ref double enable_d64f(ref double src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Double& Z0.BitMask::enable(System.Double&,System.Int32)
    IL_0007: ret

}
ref double enable_g64f(ref double src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Double& Z0.BitMaskG::enable<System.Double>(System.Double&,System.Int32)
    IL_0007: ret

}
bool testbit_d8i(sbyte src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.BitMask::test(System.SByte,System.Int32)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret

}
bool testbit_g8i(sbyte src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.BitMaskG::testbit<System.SByte>(System.SByte,System.Int32)
    IL_0007: ret

}
bool testbit_d8u(byte src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.BitMask::test(System.Byte,System.Int32)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret

}
bool testbit_g8u(byte src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.BitMaskG::testbit<System.Byte>(System.Byte,System.Int32)
    IL_0007: ret

}
bool testbit_d16i(short src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.BitMask::test(System.Int16,System.Int32)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret

}
bool testbit_g16i(short src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.BitMaskG::testbit<System.Int16>(System.Int16,System.Int32)
    IL_0007: ret

}
bool testbit_d16u(ushort src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.BitMask::test(System.UInt16,System.Int32)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret

}
bool testbit_g16u(ushort src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.BitMaskG::testbit<System.UInt16>(System.UInt16,System.Int32)
    IL_0007: ret

}
bool testbit_d32i(int src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.BitMask::test(System.Int32,System.Int32)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret

}
bool testbit_g32i(int src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.BitMaskG::testbit<System.Int32>(System.Int32,System.Int32)
    IL_0007: ret

}
bool testbit_d32u(uint src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.BitMask::test(System.UInt32,System.Int32)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret

}
bool testbit_g32u(uint src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.BitMaskG::testbit<System.UInt32>(System.UInt32,System.Int32)
    IL_0007: ret

}
bool testbit_d64i(long src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.BitMask::test(System.Int64,System.Int32)
    IL_0007: ret

}
bool testbit_g64i(long src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.BitMaskG::testbit<System.Int64>(System.Int64,System.Int32)
    IL_0007: ret

}
bool testbit_d64u(ulong src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.BitMask::test(System.UInt64,System.Int32)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret

}
bool testbit_g64u(ulong src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.BitMaskG::testbit<System.UInt64>(System.UInt64,System.Int32)
    IL_0007: ret

}
bool testbit_d32f(float src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.BitMask::test(System.Single,System.Int32)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret

}
bool testbit_g32f(float src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.BitMaskG::testbit<System.Single>(System.Single,System.Int32)
    IL_0007: ret

}
bool testbit_d64f(double src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.BitMask::test(System.Double,System.Int32)
    IL_0007: call System.Boolean Z0.bit::op_Implicit(Z0.bit)
    IL_000C: ret

}
bool testbit_g64f(double src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.BitMaskG::testbit<System.Double>(System.Double,System.Int32)
    IL_0007: ret

}
uint mod_const_16(uint a)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 Z0.Mod16::mod(System.UInt32)
    IL_0006: ret

}
uint div_const_16(uint a)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 Z0.Mod16::div(System.UInt32)
    IL_0006: ret

}
uint mod_const_25(uint a)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 Z0.Mod25::mod(System.UInt32)
    IL_0006: ret

}
uint div_const_25(uint a)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 Z0.Mod25::div(System.UInt32)
    IL_0006: ret

}
uint mod_const_32(uint a)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 Z0.Mod32::mod(System.UInt32)
    IL_0006: ret

}
uint div_const_32(uint a)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 Z0.Mod32::div(System.UInt32)
    IL_0006: ret

}
uint mul_lo_32u(uint x, uint y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.MulOps::lo(System.UInt32,System.UInt32)
    IL_0007: ret

}
ulong mul_lo_64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.MulOps::lo(System.UInt64,System.UInt64)
    IL_0007: ret

}
uint mul_hi_32u(uint x, uint y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.MulOps::hi(System.UInt32,System.UInt32)
    IL_0007: ret

}
ulong mul_hi_64u(ulong x, ulong y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.MulOps::hi(System.UInt64,System.UInt64)
    IL_0007: ret

}
void mul_full_32u(uint a, uint b, out uint lo, out uint hi)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: ldarg.3
    IL_0004: call System.Void Z0.MulOps::full(System.UInt32,System.UInt32,System.UInt32&,System.UInt32&)
    IL_0009: ret

}
void mul_full_64u(ulong x, ulong y, out ulong lo, out ulong hi)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: ldarg.3
    IL_0004: call System.Void Z0.MulOps::full(System.UInt64,System.UInt64,System.UInt64&,System.UInt64&)
    IL_0009: ret

}
UInt8 bitview8_and(UInt8 a, UInt8 b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.UInt8 Z0.UInt8::op_BitwiseAnd(Z0.UInt8,Z0.UInt8)
    IL_0007: ret

}
UInt8 bitview8_sll(UInt8 a, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.UInt8 Z0.UInt8::op_LeftShift(Z0.UInt8,System.Int32)
    IL_0007: ret

}
UInt8 bitview8_rotl(UInt8 a, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.UInt8 Z0.UInt8::rotl(Z0.UInt8,System.Int32)
    IL_0007: ret

}
UInt8 bitview8_rotr(UInt8 a, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.UInt8 Z0.UInt8::rotr(Z0.UInt8,System.Int32)
    IL_0007: ret

}
UInt8 bitview8_mul(UInt8 a, UInt8 b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.UInt8 Z0.UInt8::op_Multiply(Z0.UInt8,Z0.UInt8)
    IL_0007: ret

}
UInt8 bitview8_or(UInt8 a, UInt8 b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.UInt8 Z0.UInt8::op_BitwiseOr(Z0.UInt8,Z0.UInt8)
    IL_0007: ret

}
Span<byte> tospan_128x8i(Vector128<byte> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Span`1<System.Byte> Z0.VSpanX::ToSpan<System.Byte>(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0006: ret

}
void vstore_g128x8u(Vector128<byte> src, ref byte dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Void zfunc::vstore<System.Byte>(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Byte&)
    IL_0007: ret

}
void vstore_g128x8i(Vector128<sbyte> src, ref sbyte dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Void zfunc::vstore<System.SByte>(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.SByte&)
    IL_0007: ret

}
void vstore_g128x16i(Vector128<short> src, ref short dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Void zfunc::vstore<System.Int16>(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Int16&)
    IL_0007: ret

}
void vstore_g128x16u(Vector128<ushort> src, ref ushort dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Void zfunc::vstore<System.UInt16>(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.UInt16&)
    IL_0007: ret

}
void vstore_d128x16u(Vector128<ushort> src, ref ushort dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Void Z0.cpufunc::vstore(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.UInt16&)
    IL_0007: ret

}
void vstore_g128x32i(Vector128<int> src, ref int dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Void zfunc::vstore<System.Int32>(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Int32&)
    IL_0007: ret

}
void vstore_g128x32u(Vector128<uint> src, ref uint dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Void zfunc::vstore<System.UInt32>(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.UInt32&)
    IL_0007: ret

}
void vstore_g128x64i(Vector128<long> src, ref long dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Void zfunc::vstore<System.Int64>(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Int64&)
    IL_0007: ret

}
void vstore_g128x64u(Vector128<ulong> src, ref ulong dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Void zfunc::vstore<System.UInt64>(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.UInt64&)
    IL_0007: ret

}
void vstore_g128x32f(Vector128<float> src, ref float dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Void zfunc::vstore<System.Single>(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Single&)
    IL_0007: ret

}
void vstore_g128x64f(Vector128<double> src, ref double dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Void zfunc::vstore<System.Double>(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Double&)
    IL_0007: ret

}
void vstore_g256x8u(Vector256<byte> src, ref byte dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Void zfunc::vstore<System.Byte>(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Byte&)
    IL_0007: ret

}
void vstore_g256x8i(Vector256<sbyte> src, ref sbyte dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Void zfunc::vstore<System.SByte>(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.SByte&)
    IL_0007: ret

}
void vstore_g256x16i(Vector256<short> src, ref short dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Void zfunc::vstore<System.Int16>(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Int16&)
    IL_0007: ret

}
void vstore_g256x16u(Vector256<ushort> src, ref ushort dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Void zfunc::vstore<System.UInt16>(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.UInt16&)
    IL_0007: ret

}
void vstore_g256x32i(Vector256<int> src, ref int dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Void zfunc::vstore<System.Int32>(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Int32&)
    IL_0007: ret

}
void vstore_g256x32u(Vector256<uint> src, ref uint dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Void zfunc::vstore<System.UInt32>(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.UInt32&)
    IL_0007: ret

}
void vstore_g256x64i(Vector256<long> src, ref long dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Void zfunc::vstore<System.Int64>(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Int64&)
    IL_0007: ret

}
void vstore_g256x64u(Vector256<ulong> src, ref ulong dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Void zfunc::vstore<System.UInt64>(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.UInt64&)
    IL_0007: ret

}
void vstore_g256x32f(Vector256<float> src, ref float dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Void zfunc::vstore<System.Single>(System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Single&)
    IL_0007: ret

}
void vstore_g256x64f(Vector256<double> src, ref double dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Void zfunc::vstore<System.Double>(System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Double&)
    IL_0007: ret

}
