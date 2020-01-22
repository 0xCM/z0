// 2020-01-22 01:44:40:043
// Id := 100664309, Name := System.Void Z0.OpCodes.bitconvert::deposit(System.UInt64&,Z0.Fixed128&)
// void deposit(in ulong src, ref Fixed128 dst)
// IL
void deposit(in ulong src, ref Fixed128 dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Void Z0.FixedStore::deposit<System.UInt64>(System.UInt64&,Z0.Fixed128&)
    IL_0007: ret
}

// Id := 100664310, Name := System.Void Z0.OpCodes.bitconvert::deposit_4_0(System.UInt32&,Z0.Fixed128&)
// void deposit_4_0(in uint src, ref Fixed128 dst)
// IL
void deposit_4_0(in uint src, ref Fixed128 dst)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.4
    IL_0002: ldarg.1
    IL_0003: ldc.i4.0
    IL_0004: call System.Void Z0.FixedStore::deposit<System.UInt32>(System.UInt32&,System.Int32,Z0.Fixed128&,System.Int32)
    IL_0009: ret
}

// Id := 100664311, Name := System.Void Z0.OpCodes.bitconvert::deposit_2_2(System.UInt32&,Z0.Fixed128&)
// void deposit_2_2(in uint src, ref Fixed128 dst)
// IL
void deposit_2_2(in uint src, ref Fixed128 dst)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.2
    IL_0002: ldarg.1
    IL_0003: ldc.i4.2
    IL_0004: call System.Void Z0.FixedStore::deposit<System.UInt32>(System.UInt32&,System.Int32,Z0.Fixed128&,System.Int32)
    IL_0009: ret
}

// Id := 100664312, Name := System.Span`1<System.Byte> Z0.OpCodes.bitconvert::bc_bytes_16u(System.UInt16)
// Span<byte> bc_bytes_16u(ushort a)
// IL
Span<byte> bc_bytes_16u(ushort a)
{
    IL_0000: ldarga.s a
    IL_0002: call System.Span`1<System.Byte> Z0.BitConvert::GetBytes<System.UInt16>(System.UInt16&)
    IL_0007: ret
}

// Id := 100664313, Name := System.Span`1<System.Byte> Z0.OpCodes.bitconvert::bc_bytes_64u(System.UInt64)
// Span<byte> bc_bytes_64u(ulong a)
// IL
Span<byte> bc_bytes_64u(ulong a)
{
    IL_0000: ldarga.s a
    IL_0002: call System.Span`1<System.Byte> Z0.BitConvert::GetBytes<System.UInt64>(System.UInt64&)
    IL_0007: ret
}

// Id := 100664314, Name := System.Span`1<System.Byte> Z0.OpCodes.bitconvert::bc_bytes_fixed256(Z0.Fixed256)
// Span<byte> bc_bytes_fixed256(Fixed256 a)
// IL
Span<byte> bc_bytes_fixed256(Fixed256 a)
{
    IL_0000: ldarga.s a
    IL_0002: call System.Span`1<System.Byte> Z0.BitConvert::GetBytes<Z0.Fixed256>(Z0.Fixed256&)
    IL_0007: ret
}

// Id := 100664315, Name := System.Span`1<System.Byte> Z0.OpCodes.bitconvert::bc_bytes_fixed512(Z0.Fixed512)
// Span<byte> bc_bytes_fixed512(Fixed512 a)
// IL
Span<byte> bc_bytes_fixed512(Fixed512 a)
{
    IL_0000: ldarga.s a
    IL_0002: call System.Span`1<System.Byte> Z0.BitConvert::GetBytes<Z0.Fixed512>(Z0.Fixed512&)
    IL_0007: ret
}

// Id := 100664316, Name := System.Span`1<System.Byte> Z0.OpCodes.bitconvert::bc_bytes_fixed1024(Z0.Fixed1024)
// Span<byte> bc_bytes_fixed1024(Fixed1024 a)
// IL
Span<byte> bc_bytes_fixed1024(Fixed1024 a)
{
    IL_0000: ldarga.s a
    IL_0002: call System.Span`1<System.Byte> Z0.BitConvert::GetBytes<Z0.Fixed1024>(Z0.Fixed1024&)
    IL_0007: ret
}

// Id := 100664317, Name := System.Span`1<System.Byte> Z0.OpCodes.bitconvert::bc_bytes_fixed2048(Z0.Fixed2048)
// Span<byte> bc_bytes_fixed2048(Fixed2048 a)
// IL
Span<byte> bc_bytes_fixed2048(Fixed2048 a)
{
    IL_0000: ldarga.s a
    IL_0002: call System.Span`1<System.Byte> Z0.BitConvert::GetBytes<Z0.Fixed2048>(Z0.Fixed2048&)
    IL_0007: ret
}

// Id := 100664318, Name := System.Span`1<System.Byte> Z0.OpCodes.bitconvert::bc_bytes_fixed4096(Z0.Fixed4096)
// Span<byte> bc_bytes_fixed4096(Fixed4096 a)
// IL
Span<byte> bc_bytes_fixed4096(Fixed4096 a)
{
    IL_0000: ldarga.s a
    IL_0002: call System.Span`1<System.Byte> Z0.BitConvert::GetBytes<Z0.Fixed4096>(Z0.Fixed4096&)
    IL_0007: ret
}

