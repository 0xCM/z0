// 2020-01-15 03:58:00:439
BitVector<byte> bvand_8(BitVector<byte> x, BitVector<byte> y)
{
//  Id := 100663353, Name := Z0.BitVector`1<System.Byte> Z0.bitvectors::bvand_8(Z0.BitVector`1<System.Byte>,Z0.BitVector`1<System.Byte>)
//  BitVector<byte> bvand_8(BitVector<byte> x, BitVector<byte> y)
//  Managed
{
  IL_0000: ldc.i4.0
  IL_0001: call Z0.BVTypes/And`1<System.Byte> Z0.BV::bvand<System.Byte>(System.Byte)
  IL_0006: stloc.0
  IL_0007: ldloca.s V_0
  IL_0009: ldarg.0
  IL_000A: ldarg.1
  IL_000B: call Z0.BitVector`1<System.Byte> Z0.BVTypes/And`1<System.Byte>::Invoke(Z0.BitVector`1<System.Byte>,Z0.BitVector`1<System.Byte>)
  IL_0010: ret
}

}
BitVector8 bvand_d8(BitVector8 x, BitVector8 y)
{
//  Id := 100663354, Name := Z0.BitVector8 Z0.bitvectors::bvand_d8(Z0.BitVector8,Z0.BitVector8)
//  BitVector8 bvand_d8(BitVector8 x, BitVector8 y)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call Z0.BitVector8 Z0.BitVector::and(Z0.BitVector8,Z0.BitVector8)
  IL_0007: ret
}

}
BitVector<uint> bvand_32(BitVector<uint> x, BitVector<uint> y)
{
//  Id := 100663355, Name := Z0.BitVector`1<System.UInt32> Z0.bitvectors::bvand_32(Z0.BitVector`1<System.UInt32>,Z0.BitVector`1<System.UInt32>)
//  BitVector<uint> bvand_32(BitVector<uint> x, BitVector<uint> y)
//  Managed
{
  IL_0000: ldc.i4.0
  IL_0001: call Z0.BVTypes/And`1<System.UInt32> Z0.BV::bvand<System.UInt32>(System.UInt32)
  IL_0006: stloc.0
  IL_0007: ldloca.s V_0
  IL_0009: ldarg.0
  IL_000A: ldarg.1
  IL_000B: call Z0.BitVector`1<System.UInt32> Z0.BVTypes/And`1<System.UInt32>::Invoke(Z0.BitVector`1<System.UInt32>,Z0.BitVector`1<System.UInt32>)
  IL_0010: ret
}

}
BitVector32 bvand_d32(BitVector32 x, BitVector32 y)
{
//  Id := 100663356, Name := Z0.BitVector32 Z0.bitvectors::bvand_d32(Z0.BitVector32,Z0.BitVector32)
//  BitVector32 bvand_d32(BitVector32 x, BitVector32 y)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call Z0.BitVector32 Z0.BitVector::and(Z0.BitVector32,Z0.BitVector32)
  IL_0007: ret
}

}
BitVector<ulong> bvand_64(BitVector<ulong> x, BitVector<ulong> y)
{
//  Id := 100663357, Name := Z0.BitVector`1<System.UInt64> Z0.bitvectors::bvand_64(Z0.BitVector`1<System.UInt64>,Z0.BitVector`1<System.UInt64>)
//  BitVector<ulong> bvand_64(BitVector<ulong> x, BitVector<ulong> y)
//  Managed
{
  IL_0000: ldc.i4.0
  IL_0001: conv.i8
  IL_0002: call Z0.BVTypes/And`1<System.UInt64> Z0.BV::bvand<System.UInt64>(System.UInt64)
  IL_0007: stloc.0
  IL_0008: ldloca.s V_0
  IL_000A: ldarg.0
  IL_000B: ldarg.1
  IL_000C: call Z0.BitVector`1<System.UInt64> Z0.BVTypes/And`1<System.UInt64>::Invoke(Z0.BitVector`1<System.UInt64>,Z0.BitVector`1<System.UInt64>)
  IL_0011: ret
}

}
BitVector64 bvand_d64(BitVector64 x, BitVector64 y)
{
//  Id := 100663358, Name := Z0.BitVector64 Z0.bitvectors::bvand_d64(Z0.BitVector64,Z0.BitVector64)
//  BitVector64 bvand_d64(BitVector64 x, BitVector64 y)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call Z0.BitVector64 Z0.BitVector::and(Z0.BitVector64,Z0.BitVector64)
  IL_0007: ret
}

}
BitVector<byte> bvxor_8(BitVector<byte> x, BitVector<byte> y)
{
//  Id := 100663359, Name := Z0.BitVector`1<System.Byte> Z0.bitvectors::bvxor_8(Z0.BitVector`1<System.Byte>,Z0.BitVector`1<System.Byte>)
//  BitVector<byte> bvxor_8(BitVector<byte> x, BitVector<byte> y)
//  Managed
{
  IL_0000: ldc.i4.0
  IL_0001: call Z0.BVTypes/Xor`1<System.Byte> Z0.BV::bvxor<System.Byte>(System.Byte)
  IL_0006: stloc.0
  IL_0007: ldloca.s V_0
  IL_0009: ldarg.0
  IL_000A: ldarg.1
  IL_000B: call Z0.BitVector`1<System.Byte> Z0.BVTypes/Xor`1<System.Byte>::Invoke(Z0.BitVector`1<System.Byte>,Z0.BitVector`1<System.Byte>)
  IL_0010: ret
}

}
BitVector<byte> bvxor_g8(BitVector<byte> x, BitVector<byte> y)
{
//  Id := 100663360, Name := Z0.BitVector`1<System.Byte> Z0.bitvectors::bvxor_g8(Z0.BitVector`1<System.Byte>,Z0.BitVector`1<System.Byte>)
//  BitVector<byte> bvxor_g8(BitVector<byte> x, BitVector<byte> y)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call Z0.BitVector`1<System.Byte> Z0.BitVector::xor<System.Byte>(Z0.BitVector`1<System.Byte>,Z0.BitVector`1<System.Byte>)
  IL_0007: ret
}

}
BitVector8 bvxor_d8(BitVector8 x, BitVector8 y)
{
//  Id := 100663361, Name := Z0.BitVector8 Z0.bitvectors::bvxor_d8(Z0.BitVector8,Z0.BitVector8)
//  BitVector8 bvxor_d8(BitVector8 x, BitVector8 y)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call Z0.BitVector8 Z0.BitVector::xor(Z0.BitVector8,Z0.BitVector8)
  IL_0007: ret
}

}
byte xor_d8(byte x, byte y)
{
//  Id := 100663362, Name := System.Byte Z0.bitvectors::xor_d8(System.Byte,System.Byte)
//  byte xor_d8(byte x, byte y)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: xor
  IL_0003: conv.u1
  IL_0004: ret
}

}
byte xor_g8(byte x, byte y)
{
//  Id := 100663363, Name := System.Byte Z0.bitvectors::xor_g8(System.Byte,System.Byte)
//  byte xor_g8(byte x, byte y)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call System.Byte Z0.gmath::xor<System.Byte>(System.Byte,System.Byte)
  IL_0007: ret
}

}
byte xor_d82(byte x, byte y)
{
//  Id := 100663364, Name := System.Byte Z0.bitvectors::xor_d82(System.Byte,System.Byte)
//  byte xor_d82(byte x, byte y)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call System.Byte Z0.math::xor(System.Byte,System.Byte)
  IL_0007: ret
}

}
BitVector32 sll_bv_32u(BitVector32 x, byte offset)
{
//  Id := 100663365, Name := Z0.BitVector32 Z0.bitvectors::sll_bv_32u(Z0.BitVector32,System.Byte)
//  BitVector32 sll_bv_32u(BitVector32 x, byte offset)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call Z0.BitVector32 Z0.BitVector::sll(Z0.BitVector32,System.Byte)
  IL_0007: ret
}

}
BitVector32 sll_bv_o32u(BitVector32 x, byte offset)
{
//  Id := 100663366, Name := Z0.BitVector32 Z0.bitvectors::sll_bv_o32u(Z0.BitVector32,System.Byte)
//  BitVector32 sll_bv_o32u(BitVector32 x, byte offset)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call Z0.BitVector32 Z0.BitVector32::op_LeftShift(Z0.BitVector32,System.Int32)
  IL_0007: ret
}

}
BitVector32 srl_bv_32u(BitVector32 x, byte offset)
{
//  Id := 100663367, Name := Z0.BitVector32 Z0.bitvectors::srl_bv_32u(Z0.BitVector32,System.Byte)
//  BitVector32 srl_bv_32u(BitVector32 x, byte offset)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call Z0.BitVector32 Z0.BitVector::srl(Z0.BitVector32,System.Byte)
  IL_0007: ret
}

}
BitVector32 srl_bv_o32u(BitVector32 x, byte offset)
{
//  Id := 100663368, Name := Z0.BitVector32 Z0.bitvectors::srl_bv_o32u(Z0.BitVector32,System.Byte)
//  BitVector32 srl_bv_o32u(BitVector32 x, byte offset)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call Z0.BitVector32 Z0.BitVector32::op_RightShift(Z0.BitVector32,System.Int32)
  IL_0007: ret
}

}
BitVector32 flip_bv_32u(BitVector32 x)
{
//  Id := 100663369, Name := Z0.BitVector32 Z0.bitvectors::flip_bv_32u(Z0.BitVector32)
//  BitVector32 flip_bv_32u(BitVector32 x)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call Z0.BitVector32 Z0.BitVector::not(Z0.BitVector32)
  IL_0006: ret
}

}
BitVector32 flip_bv_o32u(BitVector32 x)
{
//  Id := 100663370, Name := Z0.BitVector32 Z0.bitvectors::flip_bv_o32u(Z0.BitVector32)
//  BitVector32 flip_bv_o32u(BitVector32 x)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call Z0.BitVector32 Z0.BitVector32::op_OnesComplement(Z0.BitVector32)
  IL_0006: ret
}

}
BitVector32 negate_bv_32u(BitVector32 x)
{
//  Id := 100663371, Name := Z0.BitVector32 Z0.bitvectors::negate_bv_32u(Z0.BitVector32)
//  BitVector32 negate_bv_32u(BitVector32 x)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call Z0.BitVector32 Z0.BitVector::negate(Z0.BitVector32)
  IL_0006: ret
}

}
BitVector32 negate_bv_o32u(BitVector32 x)
{
//  Id := 100663372, Name := Z0.BitVector32 Z0.bitvectors::negate_bv_o32u(Z0.BitVector32)
//  BitVector32 negate_bv_o32u(BitVector32 x)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call Z0.BitVector32 Z0.BitVector32::op_UnaryNegation(Z0.BitVector32)
  IL_0006: ret
}

}
BitVector32 inc_bv_32u(BitVector32 x)
{
//  Id := 100663373, Name := Z0.BitVector32 Z0.bitvectors::inc_bv_32u(Z0.BitVector32)
//  BitVector32 inc_bv_32u(BitVector32 x)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call Z0.BitVector32 Z0.BitVector::inc(Z0.BitVector32)
  IL_0006: ret
}

}
BitVector32 inc_bv_o32u(BitVector32 x)
{
//  Id := 100663374, Name := Z0.BitVector32 Z0.bitvectors::inc_bv_o32u(Z0.BitVector32)
//  BitVector32 inc_bv_o32u(BitVector32 x)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call Z0.BitVector32 Z0.BitVector32::op_Increment(Z0.BitVector32)
  IL_0006: dup
  IL_0007: starg.s x
  IL_0009: ret
}

}
BitVector32 dec_bv_32u(BitVector32 x)
{
//  Id := 100663375, Name := Z0.BitVector32 Z0.bitvectors::dec_bv_32u(Z0.BitVector32)
//  BitVector32 dec_bv_32u(BitVector32 x)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call Z0.BitVector32 Z0.BitVector::dec(Z0.BitVector32)
  IL_0006: ret
}

}
BitVector32 dec_bv_o32u(BitVector32 x)
{
//  Id := 100663376, Name := Z0.BitVector32 Z0.bitvectors::dec_bv_o32u(Z0.BitVector32)
//  BitVector32 dec_bv_o32u(BitVector32 x)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: call Z0.BitVector32 Z0.BitVector32::op_Decrement(Z0.BitVector32)
  IL_0006: dup
  IL_0007: starg.s x
  IL_0009: ret
}

}
BitVector32 rotl_bv_32u(BitVector32 x, byte offset)
{
//  Id := 100663377, Name := Z0.BitVector32 Z0.bitvectors::rotl_bv_32u(Z0.BitVector32,System.Byte)
//  BitVector32 rotl_bv_32u(BitVector32 x, byte offset)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call Z0.BitVector32 Z0.BitVector::rotl(Z0.BitVector32,System.Int32)
  IL_0007: ret
}

}
BitVector32 rotr_bv_32u(BitVector32 x, byte offset)
{
//  Id := 100663378, Name := Z0.BitVector32 Z0.bitvectors::rotr_bv_32u(Z0.BitVector32,System.Byte)
//  BitVector32 rotr_bv_32u(BitVector32 x, byte offset)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call Z0.BitVector32 Z0.BitVector::rotr(Z0.BitVector32,System.Int32)
  IL_0007: ret
}

}
BitVector32 alt_32()
{
//  Id := 100663379, Name := Z0.BitVector32 Z0.bitvectors::alt_32()
//  BitVector32 alt_32()
//  Managed
{
  IL_0000: call Z0.N32 zfunc::get_n32()
  IL_0005: call Z0.bit zfunc::get_off()
  IL_000A: call Z0.BitVector32 Z0.BitVector::alt(Z0.N32,Z0.bit)
  IL_000F: ret
}

}
BitVector<uint> alt_32g()
{
//  Id := 100663380, Name := Z0.BitVector`1<System.UInt32> Z0.bitvectors::alt_32g()
//  BitVector<uint> alt_32g()
//  Managed
{
  IL_0000: call Z0.bit zfunc::get_off()
  IL_0005: call Z0.BitVector`1<System.UInt32> Z0.BitVector::alt<System.UInt32>(Z0.bit)
  IL_000A: ret
}

}
bit dot_32g(BitVector<uint> x, BitVector<uint> y)
{
//  Id := 100663381, Name := Z0.bit Z0.bitvectors::dot_32g(Z0.BitVector`1<System.UInt32>,Z0.BitVector`1<System.UInt32>)
//  bit dot_32g(BitVector<uint> x, BitVector<uint> y)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call Z0.bit Z0.BitVector::dot<System.UInt32>(Z0.BitVector`1<System.UInt32>,Z0.BitVector`1<System.UInt32>)
  IL_0007: ret
}

}
BitMatrix<uint> oprod_1(BitVector32 x, BitVector32 y)
{
//  Id := 100663382, Name := Z0.BitMatrix`1<System.UInt32> Z0.bitvectors::oprod_1(Z0.BitVector32,Z0.BitVector32)
//  BitMatrix<uint> oprod_1(BitVector32 x, BitVector32 y)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call Z0.BitMatrix`1<System.UInt32> Z0.BitMatrix::oprod(Z0.BitVector32,Z0.BitVector32)
  IL_0007: ret
}

}
BitMatrix<uint> oprod_2(BitVector<uint> x, BitVector<uint> y)
{
//  Id := 100663383, Name := Z0.BitMatrix`1<System.UInt32> Z0.bitvectors::oprod_2(Z0.BitVector`1<System.UInt32>,Z0.BitVector`1<System.UInt32>)
//  BitMatrix<uint> oprod_2(BitVector<uint> x, BitVector<uint> y)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: call Z0.BitMatrix`1<System.UInt32> Z0.BitMatrix::oprod<System.UInt32>(Z0.BitVector`1<System.UInt32>,Z0.BitVector`1<System.UInt32>)
  IL_0007: ret
}

}
ref BitMatrix<uint> oprod_3(BitVector<uint> x, BitVector<uint> y, ref BitMatrix<uint> z)
{
//  Id := 100663384, Name := Z0.BitMatrix`1<System.UInt32>& Z0.bitvectors::oprod_3(Z0.BitVector`1<System.UInt32>,Z0.BitVector`1<System.UInt32>,Z0.BitMatrix`1<System.UInt32>&)
//  ref BitMatrix<uint> oprod_3(BitVector<uint> x, BitVector<uint> y, ref BitMatrix<uint> z)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: ldarg.2
  IL_0003: call Z0.BitMatrix`1<System.UInt32>& Z0.BitMatrix::oprod<System.UInt32>(Z0.BitVector`1<System.UInt32>,Z0.BitVector`1<System.UInt32>,Z0.BitMatrix`1<System.UInt32>&)
  IL_0008: ret
}

}
ref BitMatrix<ulong> oprod_4(BitVector<ulong> x, BitVector<ulong> y, ref BitMatrix<ulong> z)
{
//  Id := 100663385, Name := Z0.BitMatrix`1<System.UInt64>& Z0.bitvectors::oprod_4(Z0.BitVector`1<System.UInt64>,Z0.BitVector`1<System.UInt64>,Z0.BitMatrix`1<System.UInt64>&)
//  ref BitMatrix<ulong> oprod_4(BitVector<ulong> x, BitVector<ulong> y, ref BitMatrix<ulong> z)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: ldarg.2
  IL_0003: call Z0.BitMatrix`1<System.UInt64>& Z0.BitMatrix::oprod<System.UInt64>(Z0.BitVector`1<System.UInt64>,Z0.BitVector`1<System.UInt64>,Z0.BitMatrix`1<System.UInt64>&)
  IL_0008: ret
}

}
