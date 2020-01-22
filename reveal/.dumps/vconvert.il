// 2020-01-22 01:44:40:355
// Id := 100664441, Name := System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.OpCodes.vconvert::convert(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,Z0.N128,System.UInt32)
// Vector128<uint> convert(Vector256<ulong> src, N128 w, uint t)
// AggressiveInlining
Vector128<uint> convert(Vector256<ulong> src, N128 w, uint t)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.dinx::convert(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,Z0.N128,System.UInt32)
    IL_0008: ret
}

// Id := 100664442, Name := System.SByte Z0.OpCodes.vconvert::vmovelo_8i(System.Runtime.Intrinsics.Vector128`1<System.SByte>,Z0.N8)
// sbyte vmovelo_8i(Vector128<sbyte> src, N8 w)
// AggressiveInlining
sbyte vmovelo_8i(Vector128<sbyte> src, N8 w)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.SByte Z0.dinx::vmovelo(System.Runtime.Intrinsics.Vector128`1<System.SByte>,Z0.N8)
    IL_0007: ret
}

// Id := 100664443, Name := System.Byte Z0.OpCodes.vconvert::vmovelo_8u(System.Runtime.Intrinsics.Vector128`1<System.Byte>,Z0.N8)
// byte vmovelo_8u(Vector128<byte> src, N8 w)
// AggressiveInlining
byte vmovelo_8u(Vector128<byte> src, N8 w)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Byte Z0.dinx::vmovelo(System.Runtime.Intrinsics.Vector128`1<System.Byte>,Z0.N8)
    IL_0007: ret
}

// Id := 100664444, Name := System.Int16 Z0.OpCodes.vconvert::vmovelo_16i(System.Runtime.Intrinsics.Vector128`1<System.Int16>,Z0.N16)
// Int16 vmovelo_16i(Vector128<Int16> src, N16 w)
// AggressiveInlining
Int16 vmovelo_16i(Vector128<Int16> src, N16 w)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Int16 Z0.dinx::vmovelo(System.Runtime.Intrinsics.Vector128`1<System.Int16>,Z0.N16)
    IL_0007: ret
}

// Id := 100664445, Name := System.UInt16 Z0.OpCodes.vconvert::vmovelo_16u(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,Z0.N16)
// ushort vmovelo_16u(Vector128<ushort> src, N16 w)
// AggressiveInlining
ushort vmovelo_16u(Vector128<ushort> src, N16 w)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt16 Z0.dinx::vmovelo(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,Z0.N16)
    IL_0007: ret
}

// Id := 100664446, Name := System.Int32 Z0.OpCodes.vconvert::vmovelo_32i(System.Runtime.Intrinsics.Vector128`1<System.Int32>,Z0.N32)
// int vmovelo_32i(Vector128<int> src, N32 w)
// AggressiveInlining
int vmovelo_32i(Vector128<int> src, N32 w)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Int32 Z0.dinx::vmovelo(System.Runtime.Intrinsics.Vector128`1<System.Int32>,Z0.N32)
    IL_0007: ret
}

// Id := 100664447, Name := System.UInt32 Z0.OpCodes.vconvert::vmovelo_32u(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,Z0.N32)
// uint vmovelo_32u(Vector128<uint> src, N32 w)
// AggressiveInlining
uint vmovelo_32u(Vector128<uint> src, N32 w)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.dinx::vmovelo(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,Z0.N32)
    IL_0007: ret
}

// Id := 100664448, Name := System.Int64 Z0.OpCodes.vconvert::vmovelo_64i(System.Runtime.Intrinsics.Vector128`1<System.Int64>,Z0.N64)
// long vmovelo_64i(Vector128<long> src, N64 w)
// AggressiveInlining
long vmovelo_64i(Vector128<long> src, N64 w)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Int64 Z0.dinx::vmovelo(System.Runtime.Intrinsics.Vector128`1<System.Int64>,Z0.N64)
    IL_0007: ret
}

// Id := 100664449, Name := System.UInt64 Z0.OpCodes.vconvert::vmovelo_64u(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,Z0.N64)
// ulong vmovelo_64u(Vector128<ulong> src, N64 w)
// AggressiveInlining
ulong vmovelo_64u(Vector128<ulong> src, N64 w)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.dinx::vmovelo(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,Z0.N64)
    IL_0007: ret
}

// Id := 100664450, Name := System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.OpCodes.vconvert::vmovelo_32x128x32(System.Int32,System.Runtime.Intrinsics.Vector128`1<System.Single>)
// Vector128<float> vmovelo_32x128x32(int src, Vector128<float> dst)
// AggressiveInlining
Vector128<float> vmovelo_32x128x32(int src, Vector128<float> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.dinx::vmovelo(System.Int32,System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0007: ret
}

// Id := 100664451, Name := System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.OpCodes.vconvert::movelo_32x128x64(System.Int32,System.Runtime.Intrinsics.Vector128`1<System.Double>)
// Vector128<double> movelo_32x128x64(int src, Vector128<double> dst)
// AggressiveInlining
Vector128<double> movelo_32x128x64(int src, Vector128<double> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.dinx::vmovelo(System.Int32,System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0007: ret
}

// Id := 100664452, Name := System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.OpCodes.vconvert::movelo_64x128x64(System.Int64,System.Runtime.Intrinsics.Vector128`1<System.Double>)
// Vector128<double> movelo_64x128x64(long src, Vector128<double> dst)
// AggressiveInlining
Vector128<double> movelo_64x128x64(long src, Vector128<double> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.dinx::vmovelo(System.Int64,System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0007: ret
}

// Id := 100664453, Name := System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.OpCodes.vconvert::vmovelo_32x128x64u(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
// Vector128<ulong> vmovelo_32x128x64u(Vector128<uint> src, Vector128<ulong> dst)
// AggressiveInlining
Vector128<ulong> vmovelo_32x128x64u(Vector128<uint> src, Vector128<ulong> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.dinx::vmovelo(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0007: ret
}

// Id := 100664454, Name := System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.OpCodes.vconvert::vmovelo_32x128x64i(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
// Vector128<long> vmovelo_32x128x64i(Vector128<int> src, Vector128<long> dst)
// AggressiveInlining
Vector128<long> vmovelo_32x128x64i(Vector128<int> src, Vector128<long> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.dinx::vmovelo(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0007: ret
}

// Id := 100664455, Name := System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.OpCodes.vconvert::vmovelo_32x128x64f(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Double>)
// Vector128<double> vmovelo_32x128x64f(Vector128<float> src, Vector128<double> dst)
// AggressiveInlining
Vector128<double> vmovelo_32x128x64f(Vector128<float> src, Vector128<double> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.dinx::vmovelo(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0007: ret
}

