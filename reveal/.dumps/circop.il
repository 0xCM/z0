// 2019-10-12 06:44:40:116
void cir_fa_8b(Bit x1, Bit x2, Bit x3, out Bit x7, out Bit x8)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: ldarg.3
    IL_0004: ldarg.s x8
    IL_0006: call System.Void Z0.FullAdder::Compute(Z0.Bit,Z0.Bit,Z0.Bit,Z0.Bit&,Z0.Bit&)
    IL_000B: ret

}
OutPair<Bit> cir_fa_8b_pair(Bit x1, Bit x2, Bit x3)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call Z0.OutPair`1<Z0.Bit> Z0.FullAdder::Compute(Z0.Bit,Z0.Bit,Z0.Bit)
    IL_0008: ret

}
void cir_fa_8u(byte x1, byte x2, byte x3, out byte x7, out byte x8)
{
    IL_0000: ldarga.s x1
    IL_0002: ldarga.s x2
    IL_0004: ldarga.s x3
    IL_0006: ldarg.3
    IL_0007: ldarg.s x8
    IL_0009: call System.Void Z0.FullAdder::Compute<System.Byte>(System.Byte&,System.Byte&,System.Byte&,System.Byte&,System.Byte&)
    IL_000E: ret

}
void cir_fa_32u(uint x1, uint x2, uint x3, out uint x7, out uint x8)
{
    IL_0000: ldarga.s x1
    IL_0002: ldarga.s x2
    IL_0004: ldarga.s x3
    IL_0006: ldarg.3
    IL_0007: ldarg.s x8
    IL_0009: call System.Void Z0.FullAdder::Compute<System.UInt32>(System.UInt32&,System.UInt32&,System.UInt32&,System.UInt32&,System.UInt32&)
    IL_000E: ret

}
void cir_fa_64u(ulong x1, ulong x2, ulong x3, out ulong x7, out ulong x8)
{
    IL_0000: ldarga.s x1
    IL_0002: ldarga.s x2
    IL_0004: ldarga.s x3
    IL_0006: ldarg.3
    IL_0007: ldarg.s x8
    IL_0009: call System.Void Z0.FullAdder::Compute<System.UInt64>(System.UInt64&,System.UInt64&,System.UInt64&,System.UInt64&,System.UInt64&)
    IL_000E: ret

}
BitVector64 cir_fa_bv32x64(BitVector32 x1, BitVector32 x2, BitVector32 x3)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call Z0.BitVector64 Z0.FullAdder::Compute(Z0.BitVector32,Z0.BitVector32,Z0.BitVector32)
    IL_0008: ret

}
void cir_fa_128x8u(Vec128<byte> x1, Vec128<byte> x2, Vec128<byte> x3, out Vec128<byte> x7, out Vec128<byte> x8)
{
    IL_0000: ldarga.s x1
    IL_0002: ldarga.s x2
    IL_0004: ldarga.s x3
    IL_0006: ldarg.3
    IL_0007: ldarg.s x8
    IL_0009: call System.Void Z0.FullAdder::Compute<System.Byte>(Z0.Vec128`1<System.Byte>&,Z0.Vec128`1<System.Byte>&,Z0.Vec128`1<System.Byte>&,Z0.Vec128`1<System.Byte>&,Z0.Vec128`1<System.Byte>&)
    IL_000E: ret

}
void cir_fa_128x32u(Vec128<uint> x1, Vec128<uint> x2, Vec128<uint> x3, out Vec128<uint> x7, out Vec128<uint> x8)
{
    IL_0000: ldarga.s x1
    IL_0002: ldarga.s x2
    IL_0004: ldarga.s x3
    IL_0006: ldarg.3
    IL_0007: ldarg.s x8
    IL_0009: call System.Void Z0.FullAdder::Compute<System.UInt32>(Z0.Vec128`1<System.UInt32>&,Z0.Vec128`1<System.UInt32>&,Z0.Vec128`1<System.UInt32>&,Z0.Vec128`1<System.UInt32>&,Z0.Vec128`1<System.UInt32>&)
    IL_000E: ret

}
void cir_fa_128x64u(Vec128<ulong> x1, Vec128<ulong> x2, Vec128<ulong> x3, out Vec128<ulong> x7, out Vec128<ulong> x8)
{
    IL_0000: ldarga.s x1
    IL_0002: ldarga.s x2
    IL_0004: ldarga.s x3
    IL_0006: ldarg.3
    IL_0007: ldarg.s x8
    IL_0009: call System.Void Z0.FullAdder::Compute<System.UInt64>(Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&)
    IL_000E: ret

}
void cir_fa_256x8u(Vec256<byte> x1, Vec256<byte> x2, Vec256<byte> x3, out Vec256<byte> x7, out Vec256<byte> x8)
{
    IL_0000: ldarga.s x1
    IL_0002: ldarga.s x2
    IL_0004: ldarga.s x3
    IL_0006: ldarg.3
    IL_0007: ldarg.s x8
    IL_0009: call System.Void Z0.FullAdder::Compute<System.Byte>(Z0.Vec256`1<System.Byte>&,Z0.Vec256`1<System.Byte>&,Z0.Vec256`1<System.Byte>&,Z0.Vec256`1<System.Byte>&,Z0.Vec256`1<System.Byte>&)
    IL_000E: ret

}
void cir_fa_256x32u(Vec256<uint> x1, Vec256<uint> x2, Vec256<uint> x3, out Vec256<uint> x7, out Vec256<uint> x8)
{
    IL_0000: ldarga.s x1
    IL_0002: ldarga.s x2
    IL_0004: ldarga.s x3
    IL_0006: ldarg.3
    IL_0007: ldarg.s x8
    IL_0009: call System.Void Z0.FullAdder::Compute<System.UInt32>(Z0.Vec256`1<System.UInt32>&,Z0.Vec256`1<System.UInt32>&,Z0.Vec256`1<System.UInt32>&,Z0.Vec256`1<System.UInt32>&,Z0.Vec256`1<System.UInt32>&)
    IL_000E: ret

}
void cir_fa_256x64u(Vec256<ulong> x1, Vec256<ulong> x2, Vec256<ulong> x3, out Vec256<ulong> x7, out Vec256<ulong> x8)
{
    IL_0000: ldarga.s x1
    IL_0002: ldarga.s x2
    IL_0004: ldarga.s x3
    IL_0006: ldarg.3
    IL_0007: ldarg.s x8
    IL_0009: call System.Void Z0.FullAdder::Compute<System.UInt64>(Z0.Vec256`1<System.UInt64>&,Z0.Vec256`1<System.UInt64>&,Z0.Vec256`1<System.UInt64>&,Z0.Vec256`1<System.UInt64>&,Z0.Vec256`1<System.UInt64>&)
    IL_000E: ret

}
