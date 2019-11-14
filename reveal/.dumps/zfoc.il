// 2019-11-13 14:17:00:447
bit testbit_d8i(sbyte src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.BitMask::test(System.SByte,System.Int32)
    IL_0007: ret

}
bit testbit_g8i(sbyte src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.BitMaskG::testbit<System.SByte>(System.SByte,System.Int32)
    IL_0007: ret

}
bit testbit_d8u(byte src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.BitMask::test(System.Byte,System.Int32)
    IL_0007: ret

}
bit testbit_g8u(byte src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.BitMaskG::testbit<System.Byte>(System.Byte,System.Int32)
    IL_0007: ret

}
bit testbit_d16i(short src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.BitMask::test(System.Int16,System.Int32)
    IL_0007: ret

}
bit testbit_g16i(short src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.BitMaskG::testbit<System.Int16>(System.Int16,System.Int32)
    IL_0007: ret

}
bit testbit_d16u(ushort src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.BitMask::test(System.UInt16,System.Int32)
    IL_0007: ret

}
bit testbit_g16u(ushort src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.BitMaskG::testbit<System.UInt16>(System.UInt16,System.Int32)
    IL_0007: ret

}
bit testbit_d32i(int src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.BitMask::test(System.Int32,System.Int32)
    IL_0007: ret

}
bit testbit_g32i(int src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.BitMaskG::testbit<System.Int32>(System.Int32,System.Int32)
    IL_0007: ret

}
bit testbit_d32u(uint src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.BitMask::test(System.UInt32,System.Int32)
    IL_0007: ret

}
bit testbit_g32u(uint src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.BitMaskG::testbit<System.UInt32>(System.UInt32,System.Int32)
    IL_0007: ret

}
bit testbit_d64i(long src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Boolean Z0.BitMask::test(System.Int64,System.Int32)
    IL_0007: call Z0.bit Z0.bit::op_Implicit(System.Boolean)
    IL_000C: ret

}
bit testbit_g64i(long src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.BitMaskG::testbit<System.Int64>(System.Int64,System.Int32)
    IL_0007: ret

}
bit testbit_d64u(ulong src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.BitMask::test(System.UInt64,System.Int32)
    IL_0007: ret

}
bit testbit_g64u(ulong src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.BitMaskG::testbit<System.UInt64>(System.UInt64,System.Int32)
    IL_0007: ret

}
bit testbit_d32f(float src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.BitMask::test(System.Single,System.Int32)
    IL_0007: ret

}
bit testbit_g32f(float src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.BitMaskG::testbit<System.Single>(System.Single,System.Int32)
    IL_0007: ret

}
bit testbit_d64f(double src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.BitMask::test(System.Double,System.Int32)
    IL_0007: ret

}
bit testbit_g64f(double src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.BitMaskG::testbit<System.Double>(System.Double,System.Int32)
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
ReadOnlySpan<Char> hexdigits(ushort a)
{
    IL_0000: ldarg.0
    IL_0001: call System.ReadOnlySpan`1<System.Char> Z0.Hex::digits(System.UInt16)
    IL_0006: ret

}
Char hexdigit(byte a)
{
    IL_0000: ldarg.0
    IL_0001: call System.Char Z0.Hex::digit(System.Byte)
    IL_0006: ret

}
void hexdigits(byte a, out Char d0, out Char d1)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.Void Z0.Hex::digits(System.Byte,System.Char&,System.Char&)
    IL_0008: ret

}
void datablock_store(in byte src, uint count, ref Block128 dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.Void Z0.DataBlocks::store(System.Byte&,System.UInt32,Z0.BlockStorage/Block128&)
    IL_0008: ret

}
void datablock_bytes(ref Block128 src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Span`1<System.Byte> Z0.DataBlocks::bytes(Z0.BlockStorage/Block128&)
    IL_0006: pop
    IL_0007: ret

}
ReadOnlySpan<byte> bitseq(byte value)
{
    IL_0000: ldarg.0
    IL_0001: call System.ReadOnlySpan`1<System.Byte> Z0.BitStore::select(System.Byte)
    IL_0006: ret

}
Span<byte> bitseq2(ulong value)
{
    IL_0000: ldarg.0
    IL_0001: call System.Span`1<System.Byte> Z0.BitStore::bitseq2<System.UInt64>(System.UInt64)
    IL_0006: ret

}
ReadOnlySpan<byte> bitseq(int offset, int count)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.ReadOnlySpan`1<System.Byte> Z0.BitStore::select(System.Int32,System.Int32)
    IL_0007: ret

}
ReadOnlySpan<byte> bitseq8u(byte src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.ReadOnlySpan`1<System.Byte> Z0.BitStore::bitseq<System.Byte>(System.Byte&)
    IL_0007: ret

}
UInt8 mul_8u(UInt8 a, UInt8 b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.UInt8 Z0.UInt8::op_Multiply(Z0.UInt8,Z0.UInt8)
    IL_0007: ret

}
void mul_128u(Pair<ulong> src, ref Pair<ulong> dst)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: call Z0.Pair`1<System.UInt64>& Z0.Math128::mul(Z0.Pair`1<System.UInt64>&,Z0.Pair`1<System.UInt64>&)
    IL_0008: pop
    IL_0009: ret

}
Pair<ulong> add_128u(Pair<ulong> a, Pair<ulong> b)
{
    IL_0000: ldarga.s a
    IL_0002: ldarga.s b
    IL_0004: call Z0.Pair`1<System.UInt64> Z0.Math128::add(Z0.Pair`1<System.UInt64>&,Z0.Pair`1<System.UInt64>&)
    IL_0009: ret

}
Pair<ulong> xor_128u(Pair<ulong> a, Pair<ulong> b)
{
    IL_0000: ldarga.s a
    IL_0002: ldarga.s b
    IL_0004: call Z0.Pair`1<System.UInt64> Z0.Math128::xor(Z0.Pair`1<System.UInt64>&,Z0.Pair`1<System.UInt64>&)
    IL_0009: ret

}
Pair<ulong> xnor_128u(Pair<ulong> a, Pair<ulong> b)
{
    IL_0000: ldarga.s a
    IL_0002: ldarga.s b
    IL_0004: call Z0.Pair`1<System.UInt64> Z0.Math128::xnor(Z0.Pair`1<System.UInt64>&,Z0.Pair`1<System.UInt64>&)
    IL_0009: ret

}
Pair<ulong> negate_128u(Pair<ulong> a)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Pair`1<System.UInt64> Z0.Math128::negate(Z0.Pair`1<System.UInt64>)
    IL_0006: ret

}
Pair<ulong> sub_128u(Pair<ulong> a, Pair<ulong> b)
{
    IL_0000: ldarga.s a
    IL_0002: ldarga.s b
    IL_0004: call Z0.Pair`1<System.UInt64> Z0.Math128::sub(Z0.Pair`1<System.UInt64>&,Z0.Pair`1<System.UInt64>&)
    IL_0009: ret

}
ref Pair<ulong> inc_128u(ref Pair<ulong> a)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Pair`1<System.UInt64>& Z0.Math128::inc(Z0.Pair`1<System.UInt64>&)
    IL_0006: ret

}
Pair<ulong> srl_128u(Pair<ulong> a, int offset)
{
    IL_0000: ldarga.s a
    IL_0002: ldarg.1
    IL_0003: call Z0.Pair`1<System.UInt64> Z0.Math128::srl(Z0.Pair`1<System.UInt64>&,System.Int32)
    IL_0008: ret

}
Pair<ulong> sll_128u(Pair<ulong> a, int offset)
{
    IL_0000: ldarga.s a
    IL_0002: ldarg.1
    IL_0003: call Z0.Pair`1<System.UInt64> Z0.Math128::sll(Z0.Pair`1<System.UInt64>&,System.Int32)
    IL_0008: ret

}
bit same_128u(Pair<ulong> a, Pair<ulong> b)
{
    IL_0000: ldarga.s a
    IL_0002: ldarga.s b
    IL_0004: call Z0.bit Z0.Math128::same(Z0.Pair`1<System.UInt64>&,Z0.Pair`1<System.UInt64>&)
    IL_0009: ret

}
bit lt_128u(Pair<ulong> a, Pair<ulong> b)
{
    IL_0000: ldarga.s a
    IL_0002: ldarga.s b
    IL_0004: call Z0.bit Z0.Math128::lt(Z0.Pair`1<System.UInt64>&,Z0.Pair`1<System.UInt64>&)
    IL_0009: ret

}
bit gteq_128u(Pair<ulong> a, Pair<ulong> b)
{
    IL_0000: ldarga.s a
    IL_0002: ldarga.s b
    IL_0004: call Z0.bit Z0.Math128::gteq(Z0.Pair`1<System.UInt64>&,Z0.Pair`1<System.UInt64>&)
    IL_0009: ret

}
void mul_32u(Pair<uint> src, ref Pair<uint> dst)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: call Z0.Pair`1<System.UInt32>& Z0.Math128::mul(Z0.Pair`1<System.UInt32>&,Z0.Pair`1<System.UInt32>&)
    IL_0008: pop
    IL_0009: ret

}
UInt8 or_8u(UInt8 a, UInt8 b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.UInt8 Z0.UInt8::op_BitwiseOr(Z0.UInt8,Z0.UInt8)
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
