// 2020-01-05 02:30:51:058
void deposit(in ulong src, ref Fixed128 dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Void Z0.FixedStore::deposit<System.UInt64>(System.UInt64&,Z0.FixedContainers/Fixed128&)
    IL_0007: ret

}
void deposit_4_0(in uint src, ref Fixed128 dst)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.4
    IL_0002: ldarg.1
    IL_0003: ldc.i4.0
    IL_0004: call System.Void Z0.FixedStore::deposit<System.UInt32>(System.UInt32&,System.Int32,Z0.FixedContainers/Fixed128&,System.Int32)
    IL_0009: ret

}
void deposit_2_2(in uint src, ref Fixed128 dst)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.2
    IL_0002: ldarg.1
    IL_0003: ldc.i4.2
    IL_0004: call System.Void Z0.FixedStore::deposit<System.UInt32>(System.UInt32&,System.Int32,Z0.FixedContainers/Fixed128&,System.Int32)
    IL_0009: ret

}
Span<byte> bc_bytes_16u(ushort a)
{
    IL_0000: ldarga.s a
    IL_0002: call System.Span`1<System.Byte> Z0.BitConvert::GetBytes<System.UInt16>(System.UInt16&)
    IL_0007: ret

}
Span<byte> bc_bytes_64u(ulong a)
{
    IL_0000: ldarga.s a
    IL_0002: call System.Span`1<System.Byte> Z0.BitConvert::GetBytes<System.UInt64>(System.UInt64&)
    IL_0007: ret

}
Span<byte> bc_bytes_fixed256(Fixed256 a)
{
    IL_0000: ldarga.s a
    IL_0002: call System.Span`1<System.Byte> Z0.BitConvert::GetBytes<Z0.FixedContainers/Fixed256>(Z0.FixedContainers/Fixed256&)
    IL_0007: ret

}
Span<byte> bc_bytes_fixed512(Fixed512 a)
{
    IL_0000: ldarga.s a
    IL_0002: call System.Span`1<System.Byte> Z0.BitConvert::GetBytes<Z0.FixedContainers/Fixed512>(Z0.FixedContainers/Fixed512&)
    IL_0007: ret

}
Span<byte> bc_bytes_fixed1024(Fixed1024 a)
{
    IL_0000: ldarga.s a
    IL_0002: call System.Span`1<System.Byte> Z0.BitConvert::GetBytes<Z0.FixedContainers/Fixed1024>(Z0.FixedContainers/Fixed1024&)
    IL_0007: ret

}
Span<byte> bc_bytes_fixed2048(Fixed2048 a)
{
    IL_0000: ldarga.s a
    IL_0002: call System.Span`1<System.Byte> Z0.BitConvert::GetBytes<Z0.FixedContainers/Fixed2048>(Z0.FixedContainers/Fixed2048&)
    IL_0007: ret

}
Span<byte> bc_bytes_fixed4096(Fixed4096 a)
{
    IL_0000: ldarga.s a
    IL_0002: call System.Span`1<System.Byte> Z0.BitConvert::GetBytes<Z0.FixedContainers/Fixed4096>(Z0.FixedContainers/Fixed4096&)
    IL_0007: ret

}
