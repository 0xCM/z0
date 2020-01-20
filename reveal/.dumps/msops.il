// 2020-01-20 01:59:20:667
// Id := 100664414, Name := System.Span`1<System.UInt32> Z0.OpCodes.msops::msand_32u(System.ReadOnlySpan`1<System.UInt32>,System.ReadOnlySpan`1<System.UInt32>,System.Span`1<System.UInt32>)
// Span<uint> msand_32u(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs, Span<uint> dst)
// IL
Span<uint> msand_32u(ReadOnlySpan<uint> lhs, ReadOnlySpan<uint> rhs, Span<uint> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.Span`1<System.UInt32> Z0.mathspan::and<System.UInt32>(System.ReadOnlySpan`1<System.UInt32>,System.ReadOnlySpan`1<System.UInt32>,System.Span`1<System.UInt32>)
    IL_0008: ret
}

