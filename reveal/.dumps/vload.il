// 2020-01-16 19:14:10:518
// Id := 100664672, Name := System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.OpCodes.vload::vgather_128x8u(System.Span`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
// Vector128<byte> vgather_128x8u(Span<byte> src, Vector128<byte> vix)
// Managed
Vector128<byte> vgather_128x8u(Span<byte> src, Vector128<byte> vix)
{
    IL_0000: ldarg.0
    IL_0001: call System.Byte& zfunc::head<System.Byte>(System.Span`1<System.Byte>)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.ginx::vgather<System.Byte>(System.Byte&,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_000C: ret
}

// Id := 100664673, Name := System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.OpCodes.vload::vgather_128x16u(System.Span`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
// Vector128<ushort> vgather_128x16u(Span<ushort> src, Vector128<ushort> vix)
// Managed
Vector128<ushort> vgather_128x16u(Span<ushort> src, Vector128<ushort> vix)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt16& zfunc::head<System.UInt16>(System.Span`1<System.UInt16>)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.ginx::vgather<System.UInt16>(System.UInt16&,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_000C: ret
}

// Id := 100664674, Name := System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.OpCodes.vload::vgather_256x8u(System.Span`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
// Vector256<byte> vgather_256x8u(Span<byte> src, Vector256<byte> vix)
// Managed
Vector256<byte> vgather_256x8u(Span<byte> src, Vector256<byte> vix)
{
    IL_0000: ldarg.0
    IL_0001: call System.Byte& zfunc::head<System.Byte>(System.Span`1<System.Byte>)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.ginx::vgather<System.Byte>(System.Byte&,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_000C: ret
}

// Id := 100664675, Name := System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.OpCodes.vload::vgather_256x16i(System.Span`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
// Vector256<short> vgather_256x16i(Span<short> src, Vector256<short> vix)
// Managed
Vector256<short> vgather_256x16i(Span<short> src, Vector256<short> vix)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int16& zfunc::head<System.Int16>(System.Span`1<System.Int16>)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.ginx::vgather<System.Int16>(System.Int16&,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_000C: ret
}

// Id := 100664676, Name := System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.OpCodes.vload::vgather_256x16u(System.Span`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
// Vector256<ushort> vgather_256x16u(Span<ushort> src, Vector256<ushort> vix)
// Managed
Vector256<ushort> vgather_256x16u(Span<ushort> src, Vector256<ushort> vix)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt16& zfunc::head<System.UInt16>(System.Span`1<System.UInt16>)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.ginx::vgather<System.UInt16>(System.UInt16&,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_000C: ret
}

// Id := 100664677, Name := System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.OpCodes.vload::vgather_256x32i(System.Span`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
// Vector256<int> vgather_256x32i(Span<int> src, Vector256<int> vix)
// Managed
Vector256<int> vgather_256x32i(Span<int> src, Vector256<int> vix)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int32& zfunc::head<System.Int32>(System.Span`1<System.Int32>)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.ginx::vgather<System.Int32>(System.Int32&,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_000C: ret
}

// Id := 100664678, Name := System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.OpCodes.vload::vpackus_2x128x32(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
// Vector128<ushort> vpackus_2x128x32(Vector128<uint> x, Vector128<uint> y)
// Managed
Vector128<ushort> vpackus_2x128x32(Vector128<uint> x, Vector128<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.dinx::vpackus(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0007: ret
}

// Id := 100664679, Name := System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.OpCodes.vload::vlo_256x16u(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
// Vector128<ushort> vlo_256x16u(Vector256<ushort> x)
// Managed
Vector128<ushort> vlo_256x16u(Vector256<ushort> x)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.dinx::vlo(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0006: ret
}

// Id := 100664680, Name := System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.OpCodes.vload::vconvert_128x16u_256x32u(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
// Vector256<uint> vconvert_128x16u_256x32u(Vector128<ushort> src)
// Managed
Vector256<uint> vconvert_128x16u_256x32u(Vector128<ushort> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.N256 zfunc::get_n256()
    IL_0006: ldc.i4.0
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.dinx::vconvert(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,Z0.N256,System.UInt32)
    IL_000C: ret
}

