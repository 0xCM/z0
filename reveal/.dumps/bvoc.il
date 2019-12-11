// 2019-12-10 22:52:53:592
uint max_val_nbv_4()
{
    IL_0000: call System.UInt32 Z0.BitVector`2<Z0.N4,System.UInt32>::get_MaxValue()
    IL_0005: ret

}
uint max_val_nbv_8()
{
    IL_0000: call System.UInt32 Z0.BitVector`2<Z0.N8,System.UInt32>::get_MaxValue()
    IL_0005: ret

}
BitVector<N8,uint> add(BitVector<N8,uint> x, BitVector<N8,uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.BitVector`2<Z0.N8,System.UInt32> Z0.BitVector`2<Z0.N8,System.UInt32>::op_Addition(Z0.BitVector`2<Z0.N8,System.UInt32>,Z0.BitVector`2<Z0.N8,System.UInt32>)
    IL_0007: ret

}
BitVector<N8,uint> inc(BitVector<N8,uint> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.BitVector`2<Z0.N8,System.UInt32> Z0.BitVector`2<Z0.N8,System.UInt32>::op_Increment(Z0.BitVector`2<Z0.N8,System.UInt32>)
    IL_0006: dup
    IL_0007: starg.s src
    IL_0009: ret

}
BitVector<N8,uint> dec(BitVector<N8,uint> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.BitVector`2<Z0.N8,System.UInt32> Z0.BitVector`2<Z0.N8,System.UInt32>::op_Decrement(Z0.BitVector`2<Z0.N8,System.UInt32>)
    IL_0006: dup
    IL_0007: starg.s src
    IL_0009: ret

}
bit mod_prod_nbv(BitVector<N23,uint> x, BitVector<N23,uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.BitVector::modprod<Z0.N23,System.UInt32>(Z0.BitVector`2<Z0.N23,System.UInt32>,Z0.BitVector`2<Z0.N23,System.UInt32>)
    IL_0007: ret

}
BitVector32 bitrange_32_a(BitVector32 src, int i, int j)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: ldarg.2
    IL_0004: call Z0.BitVector32 Z0.BitVector32::get_Item(System.Int32,System.Int32)
    IL_0009: ret

}
uint pop_3x64(ulong x, ulong y, ulong z)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.UInt32 Z0.Bits::pop(System.UInt64,System.UInt64,System.UInt64)
    IL_0008: ret

}
uint pop_3x128(Vector128<ulong> x, Vector128<ulong> y, Vector128<ulong> z)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.UInt32 Z0.CpuBits::vpop(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0008: ret

}
uint pop_3x256(Vector256<ulong> x, Vector256<ulong> y, Vector256<ulong> z)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.UInt32 Z0.CpuBits::vpop(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0008: ret

}
void part64x1_byte(ulong src, Span<byte> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Void Z0.Bits::part64x1(System.UInt64,System.Span`1<System.Byte>)
    IL_0007: ret

}
void part64x1_bit(ulong src, Span<bit> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Void Z0.Bits::part64x1(System.UInt64,System.Span`1<Z0.bit>)
    IL_0007: ret

}
