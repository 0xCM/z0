// 2020-01-05 15:03:45:494
RowBits<byte> and_8u(RowBits<byte> x, RowBits<byte> y, RowBits<byte> dst)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: ldarga.s dst
    IL_0006: call Z0.RowBits`1<System.Byte> Z0.RowBits::and<System.Byte>(Z0.RowBits`1<System.Byte>&,Z0.RowBits`1<System.Byte>&,Z0.RowBits`1<System.Byte>&)
    IL_000B: ret

}
RowBits<ushort> and_16u(RowBits<ushort> x, RowBits<ushort> y, RowBits<ushort> dst)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: ldarga.s dst
    IL_0006: call Z0.RowBits`1<System.UInt16> Z0.RowBits::and<System.UInt16>(Z0.RowBits`1<System.UInt16>&,Z0.RowBits`1<System.UInt16>&,Z0.RowBits`1<System.UInt16>&)
    IL_000B: ret

}
RowBits<uint> and_32u(RowBits<uint> x, RowBits<uint> y, RowBits<uint> dst)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: ldarga.s dst
    IL_0006: call Z0.RowBits`1<System.UInt32> Z0.RowBits::and<System.UInt32>(Z0.RowBits`1<System.UInt32>&,Z0.RowBits`1<System.UInt32>&,Z0.RowBits`1<System.UInt32>&)
    IL_000B: ret

}
RowBits<ulong> and_64u(RowBits<ulong> x, RowBits<ulong> y, RowBits<ulong> dst)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: ldarga.s dst
    IL_0006: call Z0.RowBits`1<System.UInt64> Z0.RowBits::and<System.UInt64>(Z0.RowBits`1<System.UInt64>&,Z0.RowBits`1<System.UInt64>&,Z0.RowBits`1<System.UInt64>&)
    IL_000B: ret

}
RowBits<ulong> and_64u_op(RowBits<ulong> x, RowBits<ulong> y)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: call Z0.RowBits`1<System.UInt64> Z0.RowBits`1<System.UInt64>::op_BitwiseAnd(Z0.RowBits`1<System.UInt64>&,Z0.RowBits`1<System.UInt64>&)
    IL_0009: ret

}
RowBits<byte> xor_8u(RowBits<byte> x, RowBits<byte> y, RowBits<byte> dst)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: ldarga.s dst
    IL_0006: call Z0.RowBits`1<System.Byte> Z0.RowBits::xor<System.Byte>(Z0.RowBits`1<System.Byte>&,Z0.RowBits`1<System.Byte>&,Z0.RowBits`1<System.Byte>&)
    IL_000B: ret

}
RowBits<ushort> xor_16u(RowBits<ushort> x, RowBits<ushort> y, RowBits<ushort> dst)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: ldarga.s dst
    IL_0006: call Z0.RowBits`1<System.UInt16> Z0.RowBits::xor<System.UInt16>(Z0.RowBits`1<System.UInt16>&,Z0.RowBits`1<System.UInt16>&,Z0.RowBits`1<System.UInt16>&)
    IL_000B: ret

}
RowBits<uint> xor_32u(RowBits<uint> x, RowBits<uint> y, RowBits<uint> dst)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: ldarga.s dst
    IL_0006: call Z0.RowBits`1<System.UInt32> Z0.RowBits::xor<System.UInt32>(Z0.RowBits`1<System.UInt32>&,Z0.RowBits`1<System.UInt32>&,Z0.RowBits`1<System.UInt32>&)
    IL_000B: ret

}
RowBits<ulong> xor_64u(RowBits<ulong> x, RowBits<ulong> y, RowBits<ulong> dst)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: ldarga.s dst
    IL_0006: call Z0.RowBits`1<System.UInt64> Z0.RowBits::xor<System.UInt64>(Z0.RowBits`1<System.UInt64>&,Z0.RowBits`1<System.UInt64>&,Z0.RowBits`1<System.UInt64>&)
    IL_000B: ret

}
RowBits<byte> xnor_8u(RowBits<byte> x, RowBits<byte> y, RowBits<byte> dst)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: ldarga.s dst
    IL_0006: call Z0.RowBits`1<System.Byte> Z0.RowBits::xnor<System.Byte>(Z0.RowBits`1<System.Byte>&,Z0.RowBits`1<System.Byte>&,Z0.RowBits`1<System.Byte>&)
    IL_000B: ret

}
RowBits<ushort> xnor_16u(RowBits<ushort> x, RowBits<ushort> y, RowBits<ushort> dst)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: ldarga.s dst
    IL_0006: call Z0.RowBits`1<System.UInt16> Z0.RowBits::xnor<System.UInt16>(Z0.RowBits`1<System.UInt16>&,Z0.RowBits`1<System.UInt16>&,Z0.RowBits`1<System.UInt16>&)
    IL_000B: ret

}
RowBits<uint> xnor_32u(RowBits<uint> x, RowBits<uint> y, RowBits<uint> dst)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: ldarga.s dst
    IL_0006: call Z0.RowBits`1<System.UInt32> Z0.RowBits::xnor<System.UInt32>(Z0.RowBits`1<System.UInt32>&,Z0.RowBits`1<System.UInt32>&,Z0.RowBits`1<System.UInt32>&)
    IL_000B: ret

}
RowBits<ulong> xnor_64u(RowBits<ulong> x, RowBits<ulong> y, RowBits<ulong> dst)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s y
    IL_0004: ldarga.s dst
    IL_0006: call Z0.RowBits`1<System.UInt64> Z0.RowBits::xnor<System.UInt64>(Z0.RowBits`1<System.UInt64>&,Z0.RowBits`1<System.UInt64>&,Z0.RowBits`1<System.UInt64>&)
    IL_000B: ret

}
RowBits<byte> not_8u(RowBits<byte> x, RowBits<byte> dst)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s dst
    IL_0004: call Z0.RowBits`1<System.Byte> Z0.RowBits::not<System.Byte>(Z0.RowBits`1<System.Byte>&,Z0.RowBits`1<System.Byte>&)
    IL_0009: ret

}
RowBits<ushort> not_16u(RowBits<ushort> x, RowBits<ushort> dst)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s dst
    IL_0004: call Z0.RowBits`1<System.UInt16> Z0.RowBits::not<System.UInt16>(Z0.RowBits`1<System.UInt16>&,Z0.RowBits`1<System.UInt16>&)
    IL_0009: ret

}
RowBits<uint> not_32u(RowBits<uint> x, RowBits<uint> dst)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s dst
    IL_0004: call Z0.RowBits`1<System.UInt32> Z0.RowBits::not<System.UInt32>(Z0.RowBits`1<System.UInt32>&,Z0.RowBits`1<System.UInt32>&)
    IL_0009: ret

}
RowBits<ulong> not_64u(RowBits<ulong> x, RowBits<ulong> dst)
{
    IL_0000: ldarga.s x
    IL_0002: ldarga.s dst
    IL_0004: call Z0.RowBits`1<System.UInt64> Z0.RowBits::not<System.UInt64>(Z0.RowBits`1<System.UInt64>&,Z0.RowBits`1<System.UInt64>&)
    IL_0009: ret

}
