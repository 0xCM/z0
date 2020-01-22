// 2020-01-22 01:44:40:342
// Id := 100664496, Name := System.UInt32& modreq(System.Runtime.InteropServices.InAttribute) Z0.OpCodes.vblockops::reftest_1(System.UInt32&,System.UInt32&,System.UInt32&)
// ref uint reftest_1(in uint x, in uint y, ref uint z)
// IL
ref uint reftest_1(in uint x, in uint y, ref uint z)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: ldind.u4
    IL_0003: ldarg.1
    IL_0004: ldind.u4
    IL_0005: add
    IL_0006: stind.i4
    IL_0007: ldarg.2
    IL_0008: ret
}

// Id := 100664497, Name := System.UInt32& Z0.OpCodes.vblockops::reftest_2(System.UInt32&,System.UInt32&,System.UInt32&)
// ref uint reftest_2(in uint x, in uint y, ref uint z)
// IL
ref uint reftest_2(in uint x, in uint y, ref uint z)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: ldind.u4
    IL_0003: ldarg.1
    IL_0004: ldind.u4
    IL_0005: add
    IL_0006: stind.i4
    IL_0007: ldarg.2
    IL_0008: ret
}

// Id := 100664498, Name := Z0.Block128`1<System.UInt32>& modreq(System.Runtime.InteropServices.InAttribute) Z0.OpCodes.vblockops::vbsll(Z0.Block128`1<System.UInt32>&,Z0.Block128`1<System.UInt32>&)
// ref Block128<uint> vbsll(in Block128<uint> a, in Block128<uint> dst)
// IL
ref Block128<uint> vbsll(in Block128<uint> a, in Block128<uint> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.3
    IL_0002: ldarg.1
    IL_0003: call Z0.Block128`1<System.UInt32>& modreq(System.Runtime.InteropServices.InAttribute) Z0.vblocks::vbsll<System.UInt32>(Z0.Block128`1<System.UInt32>&,System.Byte,Z0.Block128`1<System.UInt32>&)
    IL_0008: ret
}

// Id := 100664499, Name := System.ReadOnlySpan`1<System.Int16> Z0.OpCodes.vblockops::spanconvert(System.Span`1<System.Int16>)
// ReadOnlySpan<Int16> spanconvert(Span<Int16> src)
// IL
ReadOnlySpan<Int16> spanconvert(Span<Int16> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.ReadOnlySpan`1<System.Int16> System.Span`1<System.Int16>::op_Implicit(System.Span`1<System.Int16>)
    IL_0006: ret
}

