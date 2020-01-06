// 2020-01-05 20:14:02:850
Vector128<uint> convert(Vector256<ulong> src, N128 w, uint t)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.dinx::convert(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,Z0.N128,System.UInt32)
    IL_0008: ret

}
sbyte vmovelo_8i(Vector128<sbyte> src, N8 w)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.SByte Z0.dinx::vmovelo(System.Runtime.Intrinsics.Vector128`1<System.SByte>,Z0.N8)
    IL_0007: ret

}
byte vmovelo_8u(Vector128<byte> src, N8 w)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Byte Z0.dinx::vmovelo(System.Runtime.Intrinsics.Vector128`1<System.Byte>,Z0.N8)
    IL_0007: ret

}
short vmovelo_16i(Vector128<short> src, N16 w)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Int16 Z0.dinx::vmovelo(System.Runtime.Intrinsics.Vector128`1<System.Int16>,Z0.N16)
    IL_0007: ret

}
ushort vmovelo_16u(Vector128<ushort> src, N16 w)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt16 Z0.dinx::vmovelo(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,Z0.N16)
    IL_0007: ret

}
int vmovelo_32i(Vector128<int> src, N32 w)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Int32 Z0.dinx::vmovelo(System.Runtime.Intrinsics.Vector128`1<System.Int32>,Z0.N32)
    IL_0007: ret

}
uint vmovelo_32u(Vector128<uint> src, N32 w)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.dinx::vmovelo(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,Z0.N32)
    IL_0007: ret

}
long vmovelo_64i(Vector128<long> src, N64 w)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Int64 Z0.dinx::vmovelo(System.Runtime.Intrinsics.Vector128`1<System.Int64>,Z0.N64)
    IL_0007: ret

}
ulong vmovelo_64u(Vector128<ulong> src, N64 w)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.dinx::vmovelo(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,Z0.N64)
    IL_0007: ret

}
Vector128<float> vmovelo_32x128x32(int src, Vector128<float> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.dinx::vmovelo(System.Int32,System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0007: ret

}
Vector128<double> movelo_32x128x64(int src, Vector128<double> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.dinx::vmovelo(System.Int32,System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0007: ret

}
Vector128<double> movelo_64x128x64(long src, Vector128<double> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.dinx::vmovelo(System.Int64,System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0007: ret

}
Vector128<ulong> vmovelo_32x128x64u(Vector128<uint> src, Vector128<ulong> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.dinx::vmovelo(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0007: ret

}
Vector128<long> vmovelo_32x128x64i(Vector128<int> src, Vector128<long> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.dinx::vmovelo(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0007: ret

}
Vector128<double> vmovelo_32x128x64f(Vector128<float> src, Vector128<double> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.dinx::vmovelo(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0007: ret

}
