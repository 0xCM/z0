// 2019-10-12 22:52:02:473
BitVector32 and_bv_32u(BitVector32 x, BitVector32 y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.BitVector32 Z0.bitvector::and(Z0.BitVector32&,Z0.BitVector32&)
    IL_0009: ret

}
BitVector32 and_bv_g32u(BitVector32 x, BitVector32 y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.BitVector32 Z0.gbv::and<Z0.BitVector32>(Z0.BitVector32,Z0.BitVector32)
    IL_0007: ret

}
BitVector32 and_bvop_32u(BitVector32 x, BitVector32 y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.BitVector32 Z0.BitVector32::op_BitwiseAnd(Z0.BitVector32&,Z0.BitVector32&)
    IL_0009: ret

}
BitVector32 and_bv_pg32u(PrimalBits<BitVector32,uint> x, PrimalBits<BitVector32,uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.PrimalBits`2<Z0.BitVector32,System.UInt32> Z0.PrimalBits::and<Z0.BitVector32,System.UInt32>(Z0.PrimalBits`2<Z0.BitVector32,System.UInt32>,Z0.PrimalBits`2<Z0.BitVector32,System.UInt32>)
    IL_0007: call Z0.BitVector32 Z0.PrimalBits`2<Z0.BitVector32,System.UInt32>::op_Implicit(Z0.PrimalBits`2<Z0.BitVector32,System.UInt32>)
    IL_000C: ret

}
BitVector32 and_bvop_pg32u(PrimalBits<BitVector32,uint> x, PrimalBits<BitVector32,uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.PrimalBits`2<Z0.BitVector32,System.UInt32> Z0.PrimalBits`2<Z0.BitVector32,System.UInt32>::op_BitwiseAnd(Z0.PrimalBits`2<Z0.BitVector32,System.UInt32>,Z0.PrimalBits`2<Z0.BitVector32,System.UInt32>)
    IL_0007: call Z0.BitVector32 Z0.PrimalBits`2<Z0.BitVector32,System.UInt32>::op_Implicit(Z0.PrimalBits`2<Z0.BitVector32,System.UInt32>)
    IL_000C: ret

}
BitVector32 or_bv_32u(BitVector32 x, BitVector32 y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.BitVector32 Z0.bitvector::or(Z0.BitVector32,Z0.BitVector32)
    IL_0007: ret

}
BitVector32 or_bv_g32u(BitVector32 x, BitVector32 y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.BitVector32 Z0.gbv::or<Z0.BitVector32>(Z0.BitVector32,Z0.BitVector32)
    IL_0007: ret

}
BitVector32 or_bvop_32u(BitVector32 x, BitVector32 y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.BitVector32 Z0.BitVector32::op_BitwiseOr(Z0.BitVector32&,Z0.BitVector32&)
    IL_0009: ret

}
BitVector32 or_bv_pg32u(PrimalBits<BitVector32,uint> x, PrimalBits<BitVector32,uint> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.PrimalBits`2<Z0.BitVector32,System.UInt32> Z0.PrimalBits::or<Z0.BitVector32,System.UInt32>(Z0.PrimalBits`2<Z0.BitVector32,System.UInt32>&,Z0.PrimalBits`2<Z0.BitVector32,System.UInt32>&)
    IL_0009: call Z0.BitVector32 Z0.PrimalBits`2<Z0.BitVector32,System.UInt32>::op_Implicit(Z0.PrimalBits`2<Z0.BitVector32,System.UInt32>)
    IL_000E: ret

}
BitVector32 or_bvop_pg32u(PrimalBits<BitVector32,uint> x, PrimalBits<BitVector32,uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.PrimalBits`2<Z0.BitVector32,System.UInt32> Z0.PrimalBits`2<Z0.BitVector32,System.UInt32>::op_BitwiseOr(Z0.PrimalBits`2<Z0.BitVector32,System.UInt32>,Z0.PrimalBits`2<Z0.BitVector32,System.UInt32>)
    IL_0007: call Z0.BitVector32 Z0.PrimalBits`2<Z0.BitVector32,System.UInt32>::op_Implicit(Z0.PrimalBits`2<Z0.BitVector32,System.UInt32>)
    IL_000C: ret

}
BitVector32 xor_bv_32u(BitVector32 x, BitVector32 y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.BitVector32 Z0.bitvector::xor(Z0.BitVector32,Z0.BitVector32)
    IL_0007: ret

}
BitVector32 xor_bv_g32u(BitVector32 x, BitVector32 y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.BitVector32 Z0.gbv::xor<Z0.BitVector32>(Z0.BitVector32,Z0.BitVector32)
    IL_0007: ret

}
BitVector32 xor_bvop_32u(BitVector32 x, BitVector32 y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.BitVector32 Z0.BitVector32::op_ExclusiveOr(Z0.BitVector32&,Z0.BitVector32&)
    IL_0009: ret

}
BitVector32 xor_bv_pg32u(PrimalBits<BitVector32,uint> x, PrimalBits<BitVector32,uint> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.PrimalBits`2<Z0.BitVector32,System.UInt32> Z0.PrimalBits::xor<Z0.BitVector32,System.UInt32>(Z0.PrimalBits`2<Z0.BitVector32,System.UInt32>&,Z0.PrimalBits`2<Z0.BitVector32,System.UInt32>&)
    IL_0009: call Z0.BitVector32 Z0.PrimalBits`2<Z0.BitVector32,System.UInt32>::op_Implicit(Z0.PrimalBits`2<Z0.BitVector32,System.UInt32>)
    IL_000E: ret

}
BitVector32 xor_bvop_pg32u(PrimalBits<BitVector32,uint> x, PrimalBits<BitVector32,uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.PrimalBits`2<Z0.BitVector32,System.UInt32> Z0.PrimalBits`2<Z0.BitVector32,System.UInt32>::op_ExclusiveOr(Z0.PrimalBits`2<Z0.BitVector32,System.UInt32>,Z0.PrimalBits`2<Z0.BitVector32,System.UInt32>)
    IL_0007: call Z0.BitVector32 Z0.PrimalBits`2<Z0.BitVector32,System.UInt32>::op_Implicit(Z0.PrimalBits`2<Z0.BitVector32,System.UInt32>)
    IL_000C: ret

}
BitVector32 sll_bv_32u(BitVector32 x, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.BitVector32 Z0.bitvector::sll(Z0.BitVector32,System.Int32)
    IL_0007: ret

}
BitVector32 sll_bv_g32u(BitVector32 x, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.BitVector32 Z0.gbv::sll<Z0.BitVector32>(Z0.BitVector32,System.Int32)
    IL_0007: ret

}
BitVector32 sll_bvop_32u(BitVector32 x, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.BitVector32 Z0.BitVector32::op_LeftShift(Z0.BitVector32,System.Int32)
    IL_0007: ret

}
BitVector32 sll_bv_pg32u(PrimalBits<BitVector32,uint> x, int offset)
{
    IL_0000: ldarga.s x
    IL_0002: ldarg.1
    IL_0003: call Z0.PrimalBits`2<Z0.BitVector32,System.UInt32> Z0.PrimalBits::sll<Z0.BitVector32,System.UInt32>(Z0.PrimalBits`2<Z0.BitVector32,System.UInt32>&,System.Int32)
    IL_0008: call Z0.BitVector32 Z0.PrimalBits`2<Z0.BitVector32,System.UInt32>::op_Implicit(Z0.PrimalBits`2<Z0.BitVector32,System.UInt32>)
    IL_000D: ret

}
BitVector32 sll_bvop_pg32u(PrimalBits<BitVector32,uint> x, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.PrimalBits`2<Z0.BitVector32,System.UInt32> Z0.PrimalBits`2<Z0.BitVector32,System.UInt32>::op_LeftShift(Z0.PrimalBits`2<Z0.BitVector32,System.UInt32>,System.Int32)
    IL_0007: call Z0.BitVector32 Z0.PrimalBits`2<Z0.BitVector32,System.UInt32>::op_Implicit(Z0.PrimalBits`2<Z0.BitVector32,System.UInt32>)
    IL_000C: ret

}
BitVector32 srl_bv_32u(BitVector32 x, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.BitVector32 Z0.bitvector::srl(Z0.BitVector32,System.Int32)
    IL_0007: ret

}
BitVector32 srl_bv_g32u(BitVector32 x, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.BitVector32 Z0.gbv::srl<Z0.BitVector32>(Z0.BitVector32,System.Int32)
    IL_0007: ret

}
BitVector32 srl_bvop_32u(BitVector32 x, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.BitVector32 Z0.BitVector32::op_RightShift(Z0.BitVector32,System.Int32)
    IL_0007: ret

}
BitVector32 srl_bv_pg32u(PrimalBits<BitVector32,uint> x, int offset)
{
    IL_0000: ldarga.s x
    IL_0002: ldarg.1
    IL_0003: call Z0.PrimalBits`2<Z0.BitVector32,System.UInt32> Z0.PrimalBits::srl<Z0.BitVector32,System.UInt32>(Z0.PrimalBits`2<Z0.BitVector32,System.UInt32>&,System.Int32)
    IL_0008: call Z0.BitVector32 Z0.PrimalBits`2<Z0.BitVector32,System.UInt32>::op_Implicit(Z0.PrimalBits`2<Z0.BitVector32,System.UInt32>)
    IL_000D: ret

}
BitVector32 srl_bvop_pg32u(PrimalBits<BitVector32,uint> x, int offset)
{
    IL_0000: ldarga.s x
    IL_0002: ldarg.1
    IL_0003: call Z0.PrimalBits`2<Z0.BitVector32,System.UInt32> Z0.PrimalBits`2<Z0.BitVector32,System.UInt32>::op_RightShift(Z0.PrimalBits`2<Z0.BitVector32,System.UInt32>&,System.Int32)
    IL_0008: call Z0.BitVector32 Z0.PrimalBits`2<Z0.BitVector32,System.UInt32>::op_Implicit(Z0.PrimalBits`2<Z0.BitVector32,System.UInt32>)
    IL_000D: ret

}
BitVector32 rotl_bv_32u(BitVector32 x, int offset)
{
    IL_0000: ldarga.s x
    IL_0002: ldarg.1
    IL_0003: call Z0.BitVector32 Z0.BitVector32::Rotl(System.Int32)
    IL_0008: ret

}
BitVector32 rotl_bv_g32u(BitVector32 x, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.BitVector32 Z0.gbv::rotl<Z0.BitVector32>(Z0.BitVector32,System.Int32)
    IL_0007: ret

}
BitVector32 rotl_bv_pg32u(PrimalBits<BitVector32,uint> x, int offset)
{
    IL_0000: ldarga.s x
    IL_0002: ldarg.1
    IL_0003: call Z0.PrimalBits`2<Z0.BitVector32,System.UInt32> Z0.PrimalBits::rotl<Z0.BitVector32,System.UInt32>(Z0.PrimalBits`2<Z0.BitVector32,System.UInt32>&,System.Int32)
    IL_0008: call Z0.BitVector32 Z0.PrimalBits`2<Z0.BitVector32,System.UInt32>::op_Implicit(Z0.PrimalBits`2<Z0.BitVector32,System.UInt32>)
    IL_000D: ret

}
BitVector32 rotr_bv_32u(BitVector32 x, int offset)
{
    IL_0000: ldarga.s x
    IL_0002: ldarg.1
    IL_0003: call Z0.BitVector32 Z0.BitVector32::Rotr(System.Int32)
    IL_0008: ret

}
BitVector32 rotr_bv_g32u(BitVector32 x, int offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.BitVector32 Z0.gbv::rotr<Z0.BitVector32>(Z0.BitVector32,System.Int32)
    IL_0007: ret

}
BitVector32 rotr_bv_pg32u(PrimalBits<BitVector32,uint> x, int offset)
{
    IL_0000: ldarga.s x
    IL_0002: ldarg.1
    IL_0003: call Z0.PrimalBits`2<Z0.BitVector32,System.UInt32> Z0.PrimalBits::rotr<Z0.BitVector32,System.UInt32>(Z0.PrimalBits`2<Z0.BitVector32,System.UInt32>&,System.Int32)
    IL_0008: call Z0.BitVector32 Z0.PrimalBits`2<Z0.BitVector32,System.UInt32>::op_Implicit(Z0.PrimalBits`2<Z0.BitVector32,System.UInt32>)
    IL_000D: ret

}
BitVector32 flip_bv_32u(BitVector32 x)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.BitVector32 Z0.bitvector::flip(Z0.BitVector32)
    IL_0006: ret

}
BitVector32 flip_bv_g32u(BitVector32 x)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.BitVector32 Z0.gbv::flip<Z0.BitVector32>(Z0.BitVector32)
    IL_0006: ret

}
BitVector32 flip_bvop_32u(BitVector32 x)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.BitVector32 Z0.BitVector32::op_OnesComplement(Z0.BitVector32)
    IL_0006: ret

}
BitVector32 flip_bv_pg32u(PrimalBits<BitVector32,uint> x)
{
    IL_0000: ldarga.s x
    IL_0002: call Z0.PrimalBits`2<Z0.BitVector32,System.UInt32> Z0.PrimalBits::flip<Z0.BitVector32,System.UInt32>(Z0.PrimalBits`2<Z0.BitVector32,System.UInt32>&)
    IL_0007: call Z0.BitVector32 Z0.PrimalBits`2<Z0.BitVector32,System.UInt32>::op_Implicit(Z0.PrimalBits`2<Z0.BitVector32,System.UInt32>)
    IL_000C: ret

}
BitVector32 flip_bvop_pg32u(PrimalBits<BitVector32,uint> x)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.PrimalBits`2<Z0.BitVector32,System.UInt32> Z0.PrimalBits`2<Z0.BitVector32,System.UInt32>::op_OnesComplement(Z0.PrimalBits`2<Z0.BitVector32,System.UInt32>)
    IL_0006: call Z0.BitVector32 Z0.PrimalBits`2<Z0.BitVector32,System.UInt32>::op_Implicit(Z0.PrimalBits`2<Z0.BitVector32,System.UInt32>)
    IL_000B: ret

}
BitVector32 negate_bv_32u(BitVector32 x)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.BitVector32 Z0.bitvector::negate(Z0.BitVector32)
    IL_0006: ret

}
BitVector32 negate_bv_g32u(BitVector32 x)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.BitVector32 Z0.gbv::negate<Z0.BitVector32>(Z0.BitVector32)
    IL_0006: ret

}
BitVector32 negate_bvop_32u(BitVector32 x)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.BitVector32 Z0.BitVector32::op_UnaryNegation(Z0.BitVector32)
    IL_0006: ret

}
BitVector32 negate_bv_pg32u(PrimalBits<BitVector32,uint> x)
{
    IL_0000: ldarga.s x
    IL_0002: call Z0.PrimalBits`2<Z0.BitVector32,System.UInt32> Z0.PrimalBits::negate<Z0.BitVector32,System.UInt32>(Z0.PrimalBits`2<Z0.BitVector32,System.UInt32>&)
    IL_0007: call Z0.BitVector32 Z0.PrimalBits`2<Z0.BitVector32,System.UInt32>::op_Implicit(Z0.PrimalBits`2<Z0.BitVector32,System.UInt32>)
    IL_000C: ret

}
BitVector32 negate_bvop_pg32u(PrimalBits<BitVector32,uint> x)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.PrimalBits`2<Z0.BitVector32,System.UInt32> Z0.PrimalBits`2<Z0.BitVector32,System.UInt32>::op_UnaryNegation(Z0.PrimalBits`2<Z0.BitVector32,System.UInt32>)
    IL_0006: call Z0.BitVector32 Z0.PrimalBits`2<Z0.BitVector32,System.UInt32>::op_Implicit(Z0.PrimalBits`2<Z0.BitVector32,System.UInt32>)
    IL_000B: ret

}
BitVector32 inc_bv_32u(BitVector32 x)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.BitVector32 Z0.bitvector::inc(Z0.BitVector32)
    IL_0006: ret

}
BitVector32 inc_bv_g32u(BitVector32 x)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.BitVector32 Z0.gbv::inc<Z0.BitVector32>(Z0.BitVector32)
    IL_0006: ret

}
BitVector32 inc_bvop_32u(BitVector32 x)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.BitVector32 Z0.BitVector32::op_Increment(Z0.BitVector32)
    IL_0006: dup
    IL_0007: starg.s x
    IL_0009: ret

}
BitVector32 inc_bv_pg32u(PrimalBits<BitVector32,uint> x)
{
    IL_0000: ldarga.s x
    IL_0002: call Z0.PrimalBits`2<Z0.BitVector32,System.UInt32> Z0.PrimalBits::inc<Z0.BitVector32,System.UInt32>(Z0.PrimalBits`2<Z0.BitVector32,System.UInt32>&)
    IL_0007: call Z0.BitVector32 Z0.PrimalBits`2<Z0.BitVector32,System.UInt32>::op_Implicit(Z0.PrimalBits`2<Z0.BitVector32,System.UInt32>)
    IL_000C: ret

}
BitVector32 inc_bvop_pg32u(PrimalBits<BitVector32,uint> x)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.PrimalBits`2<Z0.BitVector32,System.UInt32> Z0.PrimalBits`2<Z0.BitVector32,System.UInt32>::op_Increment(Z0.PrimalBits`2<Z0.BitVector32,System.UInt32>)
    IL_0006: dup
    IL_0007: starg.s x
    IL_0009: call Z0.BitVector32 Z0.PrimalBits`2<Z0.BitVector32,System.UInt32>::op_Implicit(Z0.PrimalBits`2<Z0.BitVector32,System.UInt32>)
    IL_000E: ret

}
BitVector32 dec_bv_32u(BitVector32 x)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.BitVector32 Z0.bitvector::dec(Z0.BitVector32)
    IL_0006: ret

}
BitVector32 dec_bv_g32u(BitVector32 x)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.BitVector32 Z0.gbv::dec<Z0.BitVector32>(Z0.BitVector32)
    IL_0006: ret

}
BitVector32 dec_bvop_32u(BitVector32 x)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.BitVector32 Z0.BitVector32::op_Decrement(Z0.BitVector32)
    IL_0006: dup
    IL_0007: starg.s x
    IL_0009: ret

}
BitVector32 dec_bv_pg32u(PrimalBits<BitVector32,uint> x)
{
    IL_0000: ldarga.s x
    IL_0002: call Z0.PrimalBits`2<Z0.BitVector32,System.UInt32> Z0.PrimalBits::dec<Z0.BitVector32,System.UInt32>(Z0.PrimalBits`2<Z0.BitVector32,System.UInt32>&)
    IL_0007: call Z0.BitVector32 Z0.PrimalBits`2<Z0.BitVector32,System.UInt32>::op_Implicit(Z0.PrimalBits`2<Z0.BitVector32,System.UInt32>)
    IL_000C: ret

}
BitVector32 dec_bvop_pg32u(PrimalBits<BitVector32,uint> x)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.PrimalBits`2<Z0.BitVector32,System.UInt32> Z0.PrimalBits`2<Z0.BitVector32,System.UInt32>::op_Decrement(Z0.PrimalBits`2<Z0.BitVector32,System.UInt32>)
    IL_0006: dup
    IL_0007: starg.s x
    IL_0009: call Z0.BitVector32 Z0.PrimalBits`2<Z0.BitVector32,System.UInt32>::op_Implicit(Z0.PrimalBits`2<Z0.BitVector32,System.UInt32>)
    IL_000E: ret

}
ref sbyte bitmap_d8i_to_8i(in sbyte src, byte srcOffset, byte len, byte dstOffset, ref sbyte dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: ldarg.3
    IL_0004: ldarg.s dst
    IL_0006: call System.SByte& Z0.Bits::bitmap(System.SByte&,System.Byte,System.Byte,System.Byte,System.SByte&)
    IL_000B: ret

}
ref sbyte bitmap_g8i_to_8i(in sbyte src, byte srcOffset, byte len, byte dstOffset, ref sbyte dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: ldarg.3
    IL_0004: ldarg.s dst
    IL_0006: call System.SByte& Z0.gbits::bitmap<System.SByte>(System.SByte&,System.Byte,System.Byte,System.Byte,System.SByte&)
    IL_000B: ret

}
ref byte bitmap_d8u_to_8u(in byte src, byte srcOffset, byte len, byte dstOffset, ref byte dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: ldarg.3
    IL_0004: ldarg.s dst
    IL_0006: call System.Byte& Z0.Bits::bitmap(System.Byte&,System.Byte,System.Byte,System.Byte,System.Byte&)
    IL_000B: ret

}
ref byte bitmap_g8u_to_8u(in byte src, byte srcOffset, byte len, byte dstOffset, ref byte dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: ldarg.3
    IL_0004: ldarg.s dst
    IL_0006: call System.Byte& Z0.gbits::bitmap<System.Byte>(System.Byte&,System.Byte,System.Byte,System.Byte,System.Byte&)
    IL_000B: ret

}
ref short bitmap_d16i_to_16i(in short src, byte srcOffset, byte len, byte dstOffset, ref short dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: ldarg.3
    IL_0004: ldarg.s dst
    IL_0006: call System.Int16& Z0.Bits::bitmap(System.Int16&,System.Byte,System.Byte,System.Byte,System.Int16&)
    IL_000B: ret

}
ref short bitmap_g16i_to_16i(in short src, byte srcOffset, byte len, byte dstOffset, ref short dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: ldarg.3
    IL_0004: ldarg.s dst
    IL_0006: call System.Int16& Z0.gbits::bitmap<System.Int16>(System.Int16&,System.Byte,System.Byte,System.Byte,System.Int16&)
    IL_000B: ret

}
ref ushort bitmapd_16u_to_16u(in ushort src, byte srcOffset, byte len, byte dstOffset, ref ushort dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: ldarg.3
    IL_0004: ldarg.s dst
    IL_0006: call System.UInt16& Z0.Bits::bitmap(System.UInt16&,System.Byte,System.Byte,System.Byte,System.UInt16&)
    IL_000B: ret

}
ref ushort bitmap_g16u_to_16u(in ushort src, byte srcOffset, byte len, byte dstOffset, ref ushort dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: ldarg.3
    IL_0004: ldarg.s dst
    IL_0006: call System.UInt16& Z0.gbits::bitmap<System.UInt16>(System.UInt16&,System.Byte,System.Byte,System.Byte,System.UInt16&)
    IL_000B: ret

}
ref int bitmap_d32i_to_32i(in int src, byte srcOffset, byte len, byte dstOffset, ref int dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: ldarg.3
    IL_0004: ldarg.s dst
    IL_0006: call System.Int32& Z0.Bits::bitmap(System.Int32&,System.Byte,System.Byte,System.Byte,System.Int32&)
    IL_000B: ret

}
ref int bitmap_g32i_to_32i(in int src, byte srcOffset, byte len, byte dstOffset, ref int dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: ldarg.3
    IL_0004: ldarg.s dst
    IL_0006: call System.Int32& Z0.gbits::bitmap<System.Int32>(System.Int32&,System.Byte,System.Byte,System.Byte,System.Int32&)
    IL_000B: ret

}
ref uint bitmap_d32u_to_32u(in uint src, byte srcOffset, byte len, byte dstOffset, ref uint dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: ldarg.3
    IL_0004: ldarg.s dst
    IL_0006: call System.UInt32& Z0.Bits::bitmap(System.UInt32&,System.Byte,System.Byte,System.Byte,System.UInt32&)
    IL_000B: ret

}
ref uint bitmap_g32u_to_32u(in uint src, byte srcOffset, byte len, byte dstOffset, ref uint dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: ldarg.3
    IL_0004: ldarg.s dst
    IL_0006: call System.UInt32& Z0.gbits::bitmap<System.UInt32>(System.UInt32&,System.Byte,System.Byte,System.Byte,System.UInt32&)
    IL_000B: ret

}
ref long bitmap_d64i_to_64i(in long src, byte srcOffset, byte len, byte dstOffset, ref long dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: ldarg.3
    IL_0004: ldarg.s dst
    IL_0006: call System.Int64& Z0.Bits::bitmap(System.Int64&,System.Byte,System.Byte,System.Byte,System.Int64&)
    IL_000B: ret

}
ref long bitmap_g64i_to_64i(in long src, byte srcOffset, byte len, byte dstOffset, ref long dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: ldarg.3
    IL_0004: ldarg.s dst
    IL_0006: call System.Int64& Z0.gbits::bitmap<System.Int64>(System.Int64&,System.Byte,System.Byte,System.Byte,System.Int64&)
    IL_000B: ret

}
ref ulong bitmap_d64u_to_64u(in ulong src, byte srcOffset, byte len, byte dstOffset, ref ulong dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: ldarg.3
    IL_0004: ldarg.s dst
    IL_0006: call System.UInt64& Z0.Bits::bitmap(System.UInt64&,System.Byte,System.Byte,System.Byte,System.UInt64&)
    IL_000B: ret

}
ref ulong bitmap_g64u_to_64u(in ulong src, byte srcOffset, byte len, byte dstOffset, ref ulong dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: ldarg.3
    IL_0004: ldarg.s dst
    IL_0006: call System.UInt64& Z0.gbits::bitmap<System.UInt64>(System.UInt64&,System.Byte,System.Byte,System.Byte,System.UInt64&)
    IL_000B: ret

}
ref float bitmapbit_d32f_to_32f(in float src, byte srcOffset, byte len, byte dstOffset, ref float dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: ldarg.3
    IL_0004: ldarg.s dst
    IL_0006: call System.Single& Z0.Bits::bitmap(System.Single&,System.Byte,System.Byte,System.Byte,System.Single&)
    IL_000B: ret

}
ref float bitmap_g32f_to_32f(in float src, byte srcOffset, byte len, byte dstOffset, ref float dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: ldarg.3
    IL_0004: ldarg.s dst
    IL_0006: call System.Single& Z0.gbits::bitmap<System.Single>(System.Single&,System.Byte,System.Byte,System.Byte,System.Single&)
    IL_000B: ret

}
ref double bitmapbit_d64f_to_64f(in double src, byte srcOffset, byte len, byte dstOffset, ref double dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: ldarg.3
    IL_0004: ldarg.s dst
    IL_0006: call System.Double& Z0.Bits::bitmap(System.Double&,System.Byte,System.Byte,System.Byte,System.Double&)
    IL_000B: ret

}
ref double bitmap_g64f_to_64f(in double src, byte srcOffset, byte len, byte dstOffset, ref double dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: ldarg.3
    IL_0004: ldarg.s dst
    IL_0006: call System.Double& Z0.gbits::bitmap<System.Double>(System.Double&,System.Byte,System.Byte,System.Byte,System.Double&)
    IL_000B: ret

}
byte blsmsk_d8u(byte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Byte Z0.Bits::blsmsk(System.Byte)
    IL_0006: ret

}
byte blsmsk_g8u(byte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Byte Z0.gbits::blsmsk<System.Byte>(System.Byte)
    IL_0006: ret

}
ushort blsmsk_d16u(ushort src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt16 Z0.Bits::blsmsk(System.UInt16)
    IL_0006: ret

}
ushort blsmsk_g16u(ushort src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt16 Z0.gbits::blsmsk<System.UInt16>(System.UInt16)
    IL_0006: ret

}
uint blsmsk_d32u(uint src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 Z0.Bits::blsmsk(System.UInt32)
    IL_0006: ret

}
uint blsmsk_g32u(uint src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 Z0.gbits::blsmsk<System.UInt32>(System.UInt32)
    IL_0006: ret

}
ulong blsmsk_g64u(ulong src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt64 Z0.gbits::blsmsk<System.UInt64>(System.UInt64)
    IL_0006: ret

}
ulong blsmsk_d64u(ulong src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt64 Z0.Bits::blsmsk(System.UInt64)
    IL_0006: ret

}
byte bzhi_d8u(byte src, uint index)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Byte Z0.Bits::bzhi(System.Byte,System.UInt32)
    IL_0007: ret

}
byte bzhi_g8u(byte src, uint index)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Byte Z0.gbits::bzhi<System.Byte>(System.Byte,System.UInt32)
    IL_0007: ret

}
ref byte bzhi_g8u_ref(ref byte src, uint index)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Byte& Z0.gbits::bzhi<System.Byte>(System.Byte&,System.UInt32)
    IL_0007: ret

}
ushort bzhi_d16u(ushort src, ushort index)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt16 Z0.Bits::bzhi(System.UInt16,System.UInt32)
    IL_0007: ret

}
ushort bzhi_g16u(ushort src, ushort index)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt16 Z0.gbits::bzhi<System.UInt16>(System.UInt16,System.UInt32)
    IL_0007: ret

}
ref ushort bzhi_g16u_ref(ref ushort src, ushort index)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt16& Z0.gbits::bzhi<System.UInt16>(System.UInt16&,System.UInt32)
    IL_0007: ret

}
uint bzhi_d32u(uint src, uint index)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::bzhi(System.UInt32,System.UInt32)
    IL_0007: ret

}
uint bzhi_g32u(uint src, uint index)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.gbits::bzhi<System.UInt32>(System.UInt32,System.UInt32)
    IL_0007: ret

}
ref uint bzhi_g32u_ref(ref uint src, uint index)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32& Z0.gbits::bzhi<System.UInt32>(System.UInt32&,System.UInt32)
    IL_0007: ret

}
ulong bzhi_d64u(ulong src, uint index)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.Bits::bzhi(System.UInt64,System.UInt32)
    IL_0007: ret

}
ulong bzhi_g64u(ulong src, uint index)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.gbits::bzhi<System.UInt64>(System.UInt64,System.UInt32)
    IL_0007: ret

}
ref ulong bzhi_g64u_ref(ref ulong src, uint index)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64& Z0.gbits::bzhi<System.UInt64>(System.UInt64&,System.UInt32)
    IL_0007: ret

}
byte gather_d8u(byte src, byte mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Byte Z0.Bits::gather(System.Byte,System.Byte)
    IL_0007: ret

}
byte gather_g8u(byte src, byte mask)
{
    IL_0000: ldarga.s src
    IL_0002: ldarga.s mask
    IL_0004: call System.Byte Z0.gbits::gather<System.Byte>(System.Byte&,System.Byte&)
    IL_0009: ret

}
ushort gather_d16u(ushort src, ushort mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt16 Z0.Bits::gather(System.UInt16,System.UInt16)
    IL_0007: ret

}
ushort gather_g16u(ushort src, ushort mask)
{
    IL_0000: ldarga.s src
    IL_0002: ldarga.s mask
    IL_0004: call System.UInt16 Z0.gbits::gather<System.UInt16>(System.UInt16&,System.UInt16&)
    IL_0009: ret

}
uint gather_d32u(uint src, uint mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::gather(System.UInt32,System.UInt32)
    IL_0007: ret

}
uint gather_g32u(uint src, uint mask)
{
    IL_0000: ldarga.s src
    IL_0002: ldarga.s mask
    IL_0004: call System.UInt32 Z0.gbits::gather<System.UInt32>(System.UInt32&,System.UInt32&)
    IL_0009: ret

}
ulong gather_d64u(ulong src, ulong mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.Bits::gather(System.UInt64,System.UInt64)
    IL_0007: ret

}
ulong gather_g64u(ulong src, ulong mask)
{
    IL_0000: ldarga.s src
    IL_0002: ldarga.s mask
    IL_0004: call System.UInt64 Z0.gbits::gather<System.UInt64>(System.UInt64&,System.UInt64&)
    IL_0009: ret

}
sbyte bitrange_d8i(sbyte src, BitPos i0, BitPos i1)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.SByte Z0.Bits::range(System.SByte,Z0.BitPos,Z0.BitPos)
    IL_0008: ret

}
sbyte bitrange_g8i(sbyte src, BitPos i0, BitPos i1)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: ldarg.2
    IL_0004: call System.SByte Z0.gbits::range<System.SByte>(System.SByte&,Z0.BitPos,Z0.BitPos)
    IL_0009: ret

}
byte bitrange_d8u(byte src, BitPos i0, BitPos i1)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.Byte Z0.Bits::range(System.Byte,Z0.BitPos,Z0.BitPos)
    IL_0008: ret

}
byte bitrange_g8u(byte src, BitPos i0, BitPos i1)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: ldarg.2
    IL_0004: call System.Byte Z0.gbits::range<System.Byte>(System.Byte&,Z0.BitPos,Z0.BitPos)
    IL_0009: ret

}
short bitrange_d16i(short src, BitPos i0, BitPos i1)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.Int16 Z0.Bits::range(System.Int16,Z0.BitPos,Z0.BitPos)
    IL_0008: ret

}
short bitrange_g16i(short src, BitPos i0, BitPos i1)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: ldarg.2
    IL_0004: call System.Int16 Z0.gbits::range<System.Int16>(System.Int16&,Z0.BitPos,Z0.BitPos)
    IL_0009: ret

}
ushort bitrange_d16u(ushort src, BitPos i0, BitPos i1)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.UInt16 Z0.Bits::range(System.UInt16,Z0.BitPos,Z0.BitPos)
    IL_0008: ret

}
ushort bitrange_g16u(ushort src, BitPos i0, BitPos i1)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: ldarg.2
    IL_0004: call System.UInt16 Z0.gbits::range<System.UInt16>(System.UInt16&,Z0.BitPos,Z0.BitPos)
    IL_0009: ret

}
int bitrange_d32i(int src, BitPos i0, BitPos i1)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.Int32 Z0.Bits::range(System.Int32,Z0.BitPos,Z0.BitPos)
    IL_0008: ret

}
int bitrange_g32i(int src, BitPos i0, BitPos i1)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: ldarg.2
    IL_0004: call System.Int32 Z0.gbits::range<System.Int32>(System.Int32&,Z0.BitPos,Z0.BitPos)
    IL_0009: ret

}
uint bitrange_d32u(uint src, BitPos i0, BitPos i1)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.UInt32 Z0.Bits::range(System.UInt32,Z0.BitPos,Z0.BitPos)
    IL_0008: ret

}
uint bitrange_g32u(uint src, BitPos i0, BitPos i1)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: ldarg.2
    IL_0004: call System.UInt32 Z0.gbits::range<System.UInt32>(System.UInt32&,Z0.BitPos,Z0.BitPos)
    IL_0009: ret

}
long bitrange_d64i(long src, BitPos i0, BitPos i1)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.Int64 Z0.Bits::range(System.Int64,Z0.BitPos,Z0.BitPos)
    IL_0008: ret

}
long bitrange_g64i(long src, BitPos i0, BitPos i1)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: ldarg.2
    IL_0004: call System.Int64 Z0.gbits::range<System.Int64>(System.Int64&,Z0.BitPos,Z0.BitPos)
    IL_0009: ret

}
ulong bitrange_d64u(ulong src, BitPos i0, BitPos i1)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.UInt64 Z0.Bits::range(System.UInt64,Z0.BitPos,Z0.BitPos)
    IL_0008: ret

}
ulong bitrange_g64u(ulong src, BitPos i0, BitPos i1)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: ldarg.2
    IL_0004: call System.UInt64 Z0.gbits::range<System.UInt64>(System.UInt64&,Z0.BitPos,Z0.BitPos)
    IL_0009: ret

}
float bitrange_g32f(float src, BitPos i0, BitPos i1)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: ldarg.2
    IL_0004: call System.Single Z0.gbits::range<System.Single>(System.Single&,Z0.BitPos,Z0.BitPos)
    IL_0009: ret

}
double bitrange_g64f(double src, BitPos i0, BitPos i1)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: ldarg.2
    IL_0004: call System.Double Z0.gbits::range<System.Double>(System.Double&,Z0.BitPos,Z0.BitPos)
    IL_0009: ret

}
