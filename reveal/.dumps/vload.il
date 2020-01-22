// 2020-01-22 01:43:39:578
// Id := 100664456, Name := System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.OpCodes.vload::vgather_128x8u(System.Span`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
// Vector128<byte> vgather_128x8u(Span<byte> src, Vector128<byte> vix)
// IL
Vector128<byte> vgather_128x8u(Span<byte> src, Vector128<byte> vix)
{
    IL_0000: ldarg.0
    IL_0001: call System.Byte& zfunc::head<System.Byte>(System.Span`1<System.Byte>)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.ginx::vgather<System.Byte>(System.Byte&,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_000C: ret
}

// Id := 100664457, Name := System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.OpCodes.vload::vgather_128x16u(System.Span`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
// Vector128<ushort> vgather_128x16u(Span<ushort> src, Vector128<ushort> vix)
// IL
Vector128<ushort> vgather_128x16u(Span<ushort> src, Vector128<ushort> vix)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt16& zfunc::head<System.UInt16>(System.Span`1<System.UInt16>)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.ginx::vgather<System.UInt16>(System.UInt16&,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_000C: ret
}

// Id := 100664458, Name := System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.OpCodes.vload::vgather_256x8u(System.Span`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
// Vector256<byte> vgather_256x8u(Span<byte> src, Vector256<byte> vix)
// IL
Vector256<byte> vgather_256x8u(Span<byte> src, Vector256<byte> vix)
{
    IL_0000: ldarg.0
    IL_0001: call System.Byte& zfunc::head<System.Byte>(System.Span`1<System.Byte>)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.ginx::vgather<System.Byte>(System.Byte&,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_000C: ret
}

// Id := 100664462, Name := System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.OpCodes.vload::vpackus_2x128x32(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
// Vector128<ushort> vpackus_2x128x32(Vector128<uint> x, Vector128<uint> y)
// IL
Vector128<ushort> vpackus_2x128x32(Vector128<uint> x, Vector128<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.dinx::vpackus(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0007: ret
}

// Id := 100664463, Name := System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.OpCodes.vload::vlo_256x16u(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
// Vector128<ushort> vlo_256x16u(Vector256<ushort> x)
// IL
Vector128<ushort> vlo_256x16u(Vector256<ushort> x)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.dinx::vlo(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0006: ret
}

// Id := 100664464, Name := System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.OpCodes.vload::vconvert_128x16u_256x32u(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
// Vector256<uint> vconvert_128x16u_256x32u(Vector128<ushort> src)
// IL
Vector256<uint> vconvert_128x16u_256x32u(Vector128<ushort> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.N256 zfunc::get_n256()
    IL_0006: ldc.i4.0
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.dinx::vconvert(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,Z0.N256,System.UInt32)
    IL_000C: ret
}

