// 2019-10-16 02:15:32:846
Vec256<short> vcmpeq(in Vec256<short> lhs, in Vec256<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Int16>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_001B: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0020: ret

}
Vec256<ushort> vcmpeq(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt16>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.UInt16>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_001B: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0020: ret

}
Vec256<int> vcmpeq(in Vec256<int> lhs, in Vec256<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Int32>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_001B: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0020: ret

}
Vec256<uint> vcmpeq(in Vec256<uint> lhs, in Vec256<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt32>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.UInt32>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_001B: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0020: ret

}
Vec256<long> vcmpeq(in Vec256<long> lhs, in Vec256<long> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int64>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Int64>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_001B: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0020: ret

}
Vec256<ulong> vcmpeq(in Vec256<ulong> lhs, in Vec256<ulong> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt64>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.UInt64>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_001B: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0020: ret

}
Vec128<sbyte> cmpgt(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.SByte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.SByte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::CompareGreaterThan(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_001B: call Z0.Vec128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0020: ret

}
Vec128<short> cmpgt(in Vec128<short> lhs, in Vec128<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int16>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::CompareGreaterThan(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_001B: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0020: ret

}
Vec128<int> cmpgt(in Vec128<int> lhs, in Vec128<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int32>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::CompareGreaterThan(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_001B: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0020: ret

}
Vec256<sbyte> cmpgt(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.SByte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.SByte>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::CompareGreaterThan(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_001B: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0020: ret

}
Vec256<short> cmpgt(in Vec256<short> lhs, in Vec256<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Int16>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::CompareGreaterThan(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_001B: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0020: ret

}
Vec256<int> cmpgt(in Vec256<int> lhs, in Vec256<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Int32>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::CompareGreaterThan(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_001B: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0020: ret

}
Vec256<long> cmpgt(in Vec256<long> lhs, in Vec256<long> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int64>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Int64>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::CompareGreaterThan(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_001B: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0020: ret

}
Vec128<sbyte> cmplt(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.SByte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.SByte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::CompareLessThan(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_001B: call Z0.Vec128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0020: ret

}
Vec128<short> cmplt(in Vec128<short> lhs, in Vec128<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int16>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::CompareLessThan(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_001B: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0020: ret

}
Vec128<int> cmplt(in Vec128<int> lhs, in Vec128<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int32>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::CompareLessThan(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_001B: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0020: ret

}
Vec256<sbyte> cmplt(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
{
    IL_0000: ldarg.1
    IL_0001: ldobj Z0.Vec256`1<System.SByte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>)
    IL_000B: ldarg.0
    IL_000C: ldobj Z0.Vec256`1<System.SByte>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::CompareGreaterThan(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_001B: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0020: ret

}
Vec256<short> cmplt(in Vec256<short> lhs, in Vec256<short> rhs)
{
    IL_0000: ldarg.1
    IL_0001: ldobj Z0.Vec256`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>)
    IL_000B: ldarg.0
    IL_000C: ldobj Z0.Vec256`1<System.Int16>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::CompareGreaterThan(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_001B: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0020: ret

}
Vec256<int> cmplt(in Vec256<int> lhs, in Vec256<int> rhs)
{
    IL_0000: ldarg.1
    IL_0001: ldobj Z0.Vec256`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_000B: ldarg.0
    IL_000C: ldobj Z0.Vec256`1<System.Int32>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::CompareGreaterThan(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_001B: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0020: ret

}
Vec256<long> cmplt(in Vec256<long> lhs, in Vec256<long> rhs)
{
    IL_0000: ldarg.1
    IL_0001: ldobj Z0.Vec256`1<System.Int64>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>)
    IL_000B: ldarg.0
    IL_000C: ldobj Z0.Vec256`1<System.Int64>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::CompareGreaterThan(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_001B: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0020: ret

}
Vec128Cmp<sbyte> eq(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0011: call Z0.Vec128Cmp`1<System.SByte> Z0.Vec128Cmp::Define<System.SByte>(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0016: ret

}
Vec128Cmp<byte> eq(in Vec128<byte> lhs, in Vec128<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0011: call Z0.Vec128Cmp`1<System.Byte> Z0.Vec128Cmp::Define<System.Byte>(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0016: ret

}
Vec128Cmp<short> eq(in Vec128<short> lhs, in Vec128<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0011: call Z0.Vec128Cmp`1<System.Int16> Z0.Vec128Cmp::Define<System.Int16>(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0016: ret

}
Vec128Cmp<ushort> eq(in Vec128<ushort> lhs, in Vec128<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0011: call Z0.Vec128Cmp`1<System.UInt16> Z0.Vec128Cmp::Define<System.UInt16>(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0016: ret

}
Vec128Cmp<int> eq(in Vec128<int> lhs, in Vec128<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0011: call Z0.Vec128Cmp`1<System.Int32> Z0.Vec128Cmp::Define<System.Int32>(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0016: ret

}
Vec128Cmp<uint> eq(in Vec128<uint> lhs, in Vec128<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0011: call Z0.Vec128Cmp`1<System.UInt32> Z0.Vec128Cmp::Define<System.UInt32>(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0016: ret

}
Vec128Cmp<long> eq(in Vec128<long> lhs, in Vec128<long> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse41::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0011: call Z0.Vec128Cmp`1<System.Int64> Z0.Vec128Cmp::Define<System.Int64>(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0016: ret

}
Vec128Cmp<ulong> eq(in Vec128<ulong> lhs, in Vec128<ulong> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse41::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0011: call Z0.Vec128Cmp`1<System.UInt64> Z0.Vec128Cmp::Define<System.UInt64>(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0016: ret

}
Vec256Cmp<sbyte> eq(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0011: call Z0.Vec256Cmp`1<System.SByte> Z0.Vec256Cmp::Define<System.SByte>(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0016: ret

}
Vec256Cmp<byte> eq(in Vec256<byte> lhs, in Vec256<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0011: call Z0.Vec256Cmp`1<System.Byte> Z0.Vec256Cmp::Define<System.Byte>(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0016: ret

}
Vec256Cmp<short> eq(in Vec256<short> lhs, in Vec256<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0011: call Z0.Vec256Cmp`1<System.Int16> Z0.Vec256Cmp::Define<System.Int16>(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0016: ret

}
Vec256Cmp<ushort> eq(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0011: call Z0.Vec256Cmp`1<System.UInt16> Z0.Vec256Cmp::Define<System.UInt16>(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0016: ret

}
Vec256Cmp<int> eq(in Vec256<int> lhs, in Vec256<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: call Z0.Vec256Cmp`1<System.Int32> Z0.Vec256Cmp::Define<System.Int32>(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0016: ret

}
Vec256Cmp<uint> eq(in Vec256<uint> lhs, in Vec256<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0011: call Z0.Vec256Cmp`1<System.UInt32> Z0.Vec256Cmp::Define<System.UInt32>(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0016: ret

}
Vec256Cmp<long> eq(in Vec256<long> lhs, in Vec256<long> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0011: call Z0.Vec256Cmp`1<System.Int64> Z0.Vec256Cmp::Define<System.Int64>(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0016: ret

}
Vec256Cmp<ulong> eq(in Vec256<ulong> lhs, in Vec256<ulong> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0011: call Z0.Vec256Cmp`1<System.UInt64> Z0.Vec256Cmp::Define<System.UInt64>(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0016: ret

}
Vec128<byte> vvones_128x8u()
{
    IL_0000: ldloca.s V_0
    IL_0002: initobj System.Runtime.Intrinsics.Vector128`1<System.Byte>
    IL_0008: ldloc.0
    IL_0009: ldloca.s V_0
    IL_000B: initobj System.Runtime.Intrinsics.Vector128`1<System.Byte>
    IL_0011: ldloc.0
    IL_0012: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0017: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_001C: ret

}
Vec128<sbyte> vones_128x8i()
{
    IL_0000: ldloca.s V_0
    IL_0002: initobj System.Runtime.Intrinsics.Vector128`1<System.SByte>
    IL_0008: ldloc.0
    IL_0009: ldloca.s V_0
    IL_000B: initobj System.Runtime.Intrinsics.Vector128`1<System.SByte>
    IL_0011: ldloc.0
    IL_0012: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0017: call Z0.Vec128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_001C: ret

}
Vec128<short> vones_128x16i()
{
    IL_0000: ldloca.s V_0
    IL_0002: initobj System.Runtime.Intrinsics.Vector128`1<System.Int16>
    IL_0008: ldloc.0
    IL_0009: ldloca.s V_0
    IL_000B: initobj System.Runtime.Intrinsics.Vector128`1<System.Int16>
    IL_0011: ldloc.0
    IL_0012: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0017: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_001C: ret

}
Vec128<ushort> vones_128x16u()
{
    IL_0000: ldloca.s V_0
    IL_0002: initobj System.Runtime.Intrinsics.Vector128`1<System.UInt16>
    IL_0008: ldloc.0
    IL_0009: ldloca.s V_0
    IL_000B: initobj System.Runtime.Intrinsics.Vector128`1<System.UInt16>
    IL_0011: ldloc.0
    IL_0012: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0017: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_001C: ret

}
Vec128<int> vones_128x32i()
{
    IL_0000: ldloca.s V_0
    IL_0002: initobj Z0.Vec128`1<System.Int32>
    IL_0008: ldloc.0
    IL_0009: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_000E: ldloca.s V_0
    IL_0010: initobj Z0.Vec128`1<System.Int32>
    IL_0016: ldloc.0
    IL_0017: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_001C: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0021: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0026: ret

}
Vec128<uint> vones_128x32u()
{
    IL_0000: ldloca.s V_0
    IL_0002: initobj Z0.Vec128`1<System.UInt32>
    IL_0008: ldloc.0
    IL_0009: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_000E: ldloca.s V_0
    IL_0010: initobj Z0.Vec128`1<System.UInt32>
    IL_0016: ldloc.0
    IL_0017: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_001C: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0021: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0026: ret

}
Vec128<long> vones_128x64i()
{
    IL_0000: ldloca.s V_0
    IL_0002: initobj Z0.Vec128`1<System.Int64>
    IL_0008: ldloc.0
    IL_0009: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(Z0.Vec128`1<System.Int64>)
    IL_000E: ldloca.s V_0
    IL_0010: initobj Z0.Vec128`1<System.Int64>
    IL_0016: ldloc.0
    IL_0017: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(Z0.Vec128`1<System.Int64>)
    IL_001C: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse41::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0021: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0026: ret

}
Vec128<ulong> vones_128x64u()
{
    IL_0000: ldloca.s V_0
    IL_0002: initobj Z0.Vec128`1<System.UInt64>
    IL_0008: ldloc.0
    IL_0009: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_000E: ldloca.s V_0
    IL_0010: initobj Z0.Vec128`1<System.UInt64>
    IL_0016: ldloc.0
    IL_0017: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_001C: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse41::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0021: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0026: ret

}
Vec256<byte> vones_256x8u()
{
    IL_0000: ldloca.s V_0
    IL_0002: initobj System.Runtime.Intrinsics.Vector256`1<System.Byte>
    IL_0008: ldloc.0
    IL_0009: ldloca.s V_0
    IL_000B: initobj System.Runtime.Intrinsics.Vector256`1<System.Byte>
    IL_0011: ldloc.0
    IL_0012: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0017: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_001C: ret

}
Vec256<sbyte> vones_256x8i()
{
    IL_0000: ldloca.s V_0
    IL_0002: initobj System.Runtime.Intrinsics.Vector256`1<System.SByte>
    IL_0008: ldloc.0
    IL_0009: ldloca.s V_0
    IL_000B: initobj System.Runtime.Intrinsics.Vector256`1<System.SByte>
    IL_0011: ldloc.0
    IL_0012: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0017: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_001C: ret

}
Vec256<short> vones_256x16i()
{
    IL_0000: ldloca.s V_0
    IL_0002: initobj System.Runtime.Intrinsics.Vector256`1<System.Int16>
    IL_0008: ldloc.0
    IL_0009: ldloca.s V_0
    IL_000B: initobj System.Runtime.Intrinsics.Vector256`1<System.Int16>
    IL_0011: ldloc.0
    IL_0012: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0017: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_001C: ret

}
Vec256<ushort> vones_256x16u()
{
    IL_0000: ldloca.s V_0
    IL_0002: initobj System.Runtime.Intrinsics.Vector256`1<System.UInt16>
    IL_0008: ldloc.0
    IL_0009: ldloca.s V_0
    IL_000B: initobj System.Runtime.Intrinsics.Vector256`1<System.UInt16>
    IL_0011: ldloc.0
    IL_0012: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0017: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_001C: ret

}
Vec256<int> vones_256x32i()
{
    IL_0000: ldloca.s V_0
    IL_0002: initobj Z0.Vec256`1<System.Int32>
    IL_0008: ldloc.0
    IL_0009: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_000E: ldloca.s V_0
    IL_0010: initobj Z0.Vec256`1<System.Int32>
    IL_0016: ldloc.0
    IL_0017: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_001C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0021: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0026: ret

}
Vec256<uint> vones_256x32u()
{
    IL_0000: ldloca.s V_0
    IL_0002: initobj Z0.Vec256`1<System.UInt32>
    IL_0008: ldloc.0
    IL_0009: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>)
    IL_000E: ldloca.s V_0
    IL_0010: initobj Z0.Vec256`1<System.UInt32>
    IL_0016: ldloc.0
    IL_0017: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>)
    IL_001C: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0021: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0026: ret

}
Vec256<long> vones_256x64i()
{
    IL_0000: ldloca.s V_0
    IL_0002: initobj Z0.Vec256`1<System.Int64>
    IL_0008: ldloc.0
    IL_0009: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>)
    IL_000E: ldloca.s V_0
    IL_0010: initobj Z0.Vec256`1<System.Int64>
    IL_0016: ldloc.0
    IL_0017: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>)
    IL_001C: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0021: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0026: ret

}
Vec256<ulong> vones_256x64u()
{
    IL_0000: ldloca.s V_0
    IL_0002: initobj Z0.Vec256`1<System.UInt64>
    IL_0008: ldloc.0
    IL_0009: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>)
    IL_000E: ldloca.s V_0
    IL_0010: initobj Z0.Vec256`1<System.UInt64>
    IL_0016: ldloc.0
    IL_0017: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>)
    IL_001C: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0021: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0026: ret

}
bool testc(in Vec128<sbyte> src, in Vec128<sbyte> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::xmm
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestC(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0011: ret

}
bool testc(in Vec128<byte> src, in Vec128<byte> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::xmm
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestC(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0011: ret

}
bool testc(in Vec128<short> src, in Vec128<short> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::xmm
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestC(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0011: ret

}
bool testc(in Vec128<ushort> src, in Vec128<ushort> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::xmm
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestC(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0011: ret

}
bool testc(in Vec128<int> src, in Vec128<int> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::xmm
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestC(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0011: ret

}
bool testc(in Vec128<uint> src, in Vec128<uint> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::xmm
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestC(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0011: ret

}
bool testc(in Vec128<long> src, in Vec128<long> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::xmm
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestC(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0011: ret

}
bool testc(in Vec128<ulong> src, in Vec128<ulong> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::xmm
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestC(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0011: ret

}
bool testc(in Vec256<sbyte> src, in Vec256<sbyte> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::ymm
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestC(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0011: ret

}
bool testc(in Vec256<byte> src, in Vec256<byte> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::ymm
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestC(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0011: ret

}
bool testc(in Vec256<short> src, in Vec256<short> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::ymm
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestC(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0011: ret

}
bool testc(in Vec256<ushort> src, in Vec256<ushort> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::ymm
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestC(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0011: ret

}
bool testc(in Vec256<int> src, in Vec256<int> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::ymm
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestC(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: ret

}
bool testc(in Vec256<uint> src, in Vec256<uint> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::ymm
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestC(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0011: ret

}
bool testc(in Vec256<long> src, in Vec256<long> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::ymm
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestC(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0011: ret

}
bool testc(in Vec256<ulong> src, in Vec256<ulong> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::ymm
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestC(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0011: ret

}
bool testz(in Vec128<byte> src, in Vec128<byte> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::xmm
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestZ(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0011: ret

}
bool testz(in Vec128<sbyte> src, in Vec128<sbyte> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::xmm
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestZ(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0011: ret

}
bool testz(in Vec128<short> src, in Vec128<short> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::xmm
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestZ(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0011: ret

}
bool testz(in Vec128<ushort> src, in Vec128<ushort> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::xmm
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestZ(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0011: ret

}
bool testz(in Vec128<int> src, in Vec128<int> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::xmm
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestZ(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0011: ret

}
bool testz(in Vec128<uint> src, in Vec128<uint> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::xmm
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestZ(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0011: ret

}
bool testz(in Vec128<long> src, in Vec128<long> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::xmm
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestZ(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0011: ret

}
bool testz(in Vec128<ulong> src, in Vec128<ulong> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::xmm
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestZ(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0011: ret

}
bool testz(in Vec256<sbyte> src, in Vec256<sbyte> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::ymm
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestZ(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0011: ret

}
bool testz(in Vec256<byte> src, in Vec256<byte> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::ymm
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestZ(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0011: ret

}
bool testz(in Vec256<short> src, in Vec256<short> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::ymm
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestZ(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0011: ret

}
bool testz(in Vec256<ushort> src, in Vec256<ushort> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::ymm
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestZ(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0011: ret

}
bool testz(in Vec256<int> src, in Vec256<int> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::ymm
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestZ(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: ret

}
bool testz(in Vec256<uint> src, in Vec256<uint> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::ymm
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestZ(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0011: ret

}
bool testz(in Vec256<long> src, in Vec256<long> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::ymm
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestZ(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0011: ret

}
bool testz(in Vec256<ulong> src, in Vec256<ulong> mask)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::ymm
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestZ(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0011: ret

}
bool testznc(in Vec128<sbyte> x, in Vec128<sbyte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::xmm
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestNotZAndNotC(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0011: ret

}
bool testznc(in Vec128<byte> x, in Vec128<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::xmm
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestNotZAndNotC(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0011: ret

}
bool testznc(in Vec128<short> x, in Vec128<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::xmm
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestNotZAndNotC(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0011: ret

}
bool testznc(in Vec128<ushort> x, in Vec128<ushort> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::xmm
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestNotZAndNotC(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0011: ret

}
bool testznc(in Vec128<int> x, in Vec128<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::xmm
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestNotZAndNotC(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0011: ret

}
bool testznc(in Vec128<uint> x, in Vec128<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::xmm
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestNotZAndNotC(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0011: ret

}
bool testznc(in Vec256<sbyte> x, in Vec256<sbyte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::ymm
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestNotZAndNotC(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0011: ret

}
bool testznc(in Vec256<byte> x, in Vec256<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::ymm
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestNotZAndNotC(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0011: ret

}
bool testznc(in Vec256<short> x, in Vec256<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::ymm
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestNotZAndNotC(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0011: ret

}
bool testznc(in Vec256<ushort> x, in Vec256<ushort> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::ymm
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestNotZAndNotC(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0011: ret

}
bool testznc(in Vec256<int> x, in Vec256<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::ymm
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestNotZAndNotC(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: ret

}
bool testznc(in Vec256<uint> x, in Vec256<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::ymm
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestNotZAndNotC(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0011: ret

}
int movemask(in Vec128<float> src)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::xmm
    IL_0006: call System.Int32 System.Runtime.Intrinsics.X86.Sse::MoveMask(System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_000B: ret

}
int movemask(in Vec128<double> src)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::xmm
    IL_0006: call System.Int32 System.Runtime.Intrinsics.X86.Sse2::MoveMask(System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_000B: ret

}
int movemask(in Vec256<float> src)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::ymm
    IL_0006: call System.Int32 System.Runtime.Intrinsics.X86.Avx::MoveMask(System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_000B: ret

}
int movemask(in Vec256<double> src)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::ymm
    IL_0006: call System.Int32 System.Runtime.Intrinsics.X86.Avx::MoveMask(System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_000B: ret

}
Vec128<uint> vsrl(in Vec128<uint> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::xmm
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::ShiftRightLogical(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Byte)
    IL_000C: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0011: ret

}
Vec128<long> vsrl(in Vec128<long> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::xmm
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse2::ShiftRightLogical(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Byte)
    IL_000C: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0011: ret

}
Vec128<ulong> vsrl(in Vec128<ulong> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::xmm
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::ShiftRightLogical(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Byte)
    IL_000C: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0011: ret

}
Vec256<byte> vsrl(in Vec256<byte> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.Byte> Z0.dinx::vlo(Z0.Vec256`1<System.Byte>&)
    IL_0006: stloc.s V_11
    IL_0008: ldloca.s V_11
    IL_000A: ldloca.s V_10
    IL_000C: call Z0.Vec256`1<System.UInt16>& Z0.dinx::vconvert(Z0.Vec128`1<System.Byte>&,Z0.Vec256`1<System.UInt16>&)
    IL_0011: ldobj Z0.Vec256`1<System.UInt16>
    IL_0016: stloc.0
    IL_0017: ldarg.0
    IL_0018: call Z0.Vec128`1<System.Byte> Z0.dinx::vhi(Z0.Vec256`1<System.Byte>&)
    IL_001D: stloc.s V_11
    IL_001F: ldloca.s V_11
    IL_0021: ldloca.s V_10
    IL_0023: call Z0.Vec256`1<System.UInt16>& Z0.dinx::vconvert(Z0.Vec128`1<System.Byte>&,Z0.Vec256`1<System.UInt16>&)
    IL_0028: ldobj Z0.Vec256`1<System.UInt16>
    IL_002D: stloc.1
    IL_002E: ldloca.s V_0
    IL_0030: ldarg.1
    IL_0031: call Z0.Vec256`1<System.UInt16> Z0.dinx::vsrl(Z0.Vec256`1<System.UInt16>&,System.Byte)
    IL_0036: stloc.s V_10
    IL_0038: ldloca.s V_10
    IL_003A: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.UInt16>::As<System.Byte>()
    IL_003F: stloc.2
    IL_0040: ldloca.s V_1
    IL_0042: ldarg.1
    IL_0043: call Z0.Vec256`1<System.UInt16> Z0.dinx::vsrl(Z0.Vec256`1<System.UInt16>&,System.Byte)
    IL_0048: stloc.s V_10
    IL_004A: ldloca.s V_10
    IL_004C: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.UInt16>::As<System.Byte>()
    IL_0051: stloc.3
    IL_0052: call Z0.Vec256`1<System.Byte> Z0.Vec256Pattern::ClearAlt<System.Byte>()
    IL_0057: stloc.s V_4
    IL_0059: ldloca.s V_2
    IL_005B: ldloca.s V_4
    IL_005D: call Z0.Vec256`1<System.Byte> Z0.dinx::vshuffle(Z0.Vec256`1<System.Byte>&,Z0.Vec256`1<System.Byte>&)
    IL_0062: stloc.s V_5
    IL_0064: ldloca.s V_3
    IL_0066: ldloca.s V_4
    IL_0068: call Z0.Vec256`1<System.Byte> Z0.dinx::vshuffle(Z0.Vec256`1<System.Byte>&,Z0.Vec256`1<System.Byte>&)
    IL_006D: stloc.s V_6
    IL_006F: call Z0.Vec256`1<System.Byte> Z0.Vec256Pattern::LaneMerge<System.Byte>()
    IL_0074: stloc.s V_7
    IL_0076: ldloca.s V_5
    IL_0078: ldloca.s V_7
    IL_007A: call Z0.Vec256`1<System.Byte> Z0.dinx::vpermvar32x8(Z0.Vec256`1<System.Byte>&,Z0.Vec256`1<System.Byte>&)
    IL_007F: stloc.s V_8
    IL_0081: ldloca.s V_6
    IL_0083: ldloca.s V_7
    IL_0085: call Z0.Vec256`1<System.Byte> Z0.dinx::vpermvar32x8(Z0.Vec256`1<System.Byte>&,Z0.Vec256`1<System.Byte>&)
    IL_008A: stloc.s V_9
    IL_008C: ldloca.s V_8
    IL_008E: call Z0.Vec128`1<System.Byte> Z0.dinx::vlo(Z0.Vec256`1<System.Byte>&)
    IL_0093: stloc.s V_11
    IL_0095: ldloca.s V_11
    IL_0097: ldloca.s V_9
    IL_0099: call Z0.Vec128`1<System.Byte> Z0.dinx::vlo(Z0.Vec256`1<System.Byte>&)
    IL_009E: stloc.s V_13
    IL_00A0: ldloca.s V_13
    IL_00A2: ldloca.s V_12
    IL_00A4: call Z0.Vec256`1<System.Byte>& Z0.dinx::insert(Z0.Vec128`1<System.Byte>&,Z0.Vec128`1<System.Byte>&,Z0.Vec256`1<System.Byte>&)
    IL_00A9: ldobj Z0.Vec256`1<System.Byte>
    IL_00AE: ret

}
Vec256<short> vsrl(in Vec256<short> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::ymm
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::ShiftRightLogical(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Byte)
    IL_000C: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0011: ret

}
Vec256<ushort> vsrl(in Vec256<ushort> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::ymm
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::ShiftRightLogical(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Byte)
    IL_000C: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0011: ret

}
Vec256<int> vsrl(in Vec256<int> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::ymm
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::ShiftRightLogical(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Byte)
    IL_000C: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: ret

}
Vec256<uint> vsrl(in Vec256<uint> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::ymm
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::ShiftRightLogical(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Byte)
    IL_000C: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0011: ret

}
Vec256<long> vsrl(in Vec256<long> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::ymm
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::ShiftRightLogical(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Byte)
    IL_000C: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0011: ret

}
Vec256<ulong> vsrl(in Vec256<ulong> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::ymm
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::ShiftRightLogical(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Byte)
    IL_000C: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0011: ret

}
Vec128<int> vsrlv(in Vec128<int> src, in Vec128<uint> control)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::ShiftRightLogicalVariable(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0011: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0016: ret

}
Vec128<uint> vsrlv(in Vec128<uint> src, in Vec128<uint> offset)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::ShiftRightLogicalVariable(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0011: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0016: ret

}
Vec128<long> vsrlv(in Vec128<long> src, in Vec128<ulong> offset)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::ShiftRightLogicalVariable(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0011: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0016: ret

}
Vec128<ulong> vsrlv(in Vec128<ulong> src, in Vec128<ulong> offset)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::ShiftRightLogicalVariable(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0011: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0016: ret

}
Vec256<int> vsrlv(in Vec256<int> src, in Vec256<uint> offset)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::ShiftRightLogicalVariable(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0011: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0016: ret

}
Vec256<uint> vsrlv(in Vec256<uint> src, in Vec256<uint> offset)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::ShiftRightLogicalVariable(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0011: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0016: ret

}
Vec256<long> vsrlv(in Vec256<long> src, in Vec256<ulong> offset)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::ShiftRightLogicalVariable(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0011: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0016: ret

}
Vec256<ulong> vsrlv(in Vec256<ulong> src, in Vec256<ulong> offset)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::ShiftRightLogicalVariable(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0011: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0016: ret

}
Vec128<sbyte> vxnor(in Vec128<sbyte> x, in Vec128<sbyte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0016: call Z0.Vec128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_001B: ret

}
Vec128<byte> vxnor(in Vec128<byte> x, in Vec128<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0016: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_001B: ret

}
Vec128<short> vxnor(in Vec128<short> x, in Vec128<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0016: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_001B: ret

}
Vec128<ushort> vxnor(in Vec128<ushort> x, in Vec128<ushort> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0016: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_001B: ret

}
Vec128<int> vxnor(in Vec128<int> x, in Vec128<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0016: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_001B: ret

}
Vec128<uint> vxnor(in Vec128<uint> x, in Vec128<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0016: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_001B: ret

}
Vec128<long> vxnor(in Vec128<long> x, in Vec128<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0016: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_001B: ret

}
Vec128<ulong> vxnor(in Vec128<ulong> x, in Vec128<ulong> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0011: call Z0.Vec128`1<System.UInt64> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0016: ret

}
Vec256<byte> vxnor(in Vec256<byte> x, in Vec256<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0016: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_001B: ret

}
Vec256<short> vxnor(in Vec256<short> x, in Vec256<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0016: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_001B: ret

}
Vec256<sbyte> vxnor(in Vec256<sbyte> x, in Vec256<sbyte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0016: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_001B: ret

}
Vec256<ushort> vxnor(in Vec256<ushort> x, in Vec256<ushort> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0016: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_001B: ret

}
Vec256<int> vxnor(in Vec256<int> x, in Vec256<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0016: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_001B: ret

}
Vec256<uint> vxnor(in Vec256<uint> x, in Vec256<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0016: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_001B: ret

}
Vec256<long> vxnor(in Vec256<long> x, in Vec256<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0016: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_001B: ret

}
Vec256<ulong> vxnor(in Vec256<ulong> x, in Vec256<ulong> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0016: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_001B: ret

}
Vector128<sbyte> vxnor(Vector128<sbyte> x, Vector128<sbyte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_000C: ret

}
Vector128<byte> vxnor(Vector128<byte> x, Vector128<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_000C: ret

}
Vector128<short> vxnor(Vector128<short> x, Vector128<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_000C: ret

}
Vector128<ushort> vxnor(Vector128<ushort> x, Vector128<ushort> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_000C: ret

}
Vector128<int> vxnor(Vector128<int> x, Vector128<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_000C: ret

}
Vector128<uint> vxnor(Vector128<uint> x, Vector128<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_000C: ret

}
Vector128<long> vxnor(Vector128<long> x, Vector128<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_000C: ret

}
Vector128<ulong> vxnor(Vector128<ulong> x, Vector128<ulong> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0007: call Z0.Vec128`1<System.UInt64> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_0011: ret

}
Vector256<byte> vxnor(Vector256<byte> x, Vector256<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_000C: ret

}
Vector256<short> vxnor(Vector256<short> x, Vector256<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_000C: ret

}
Vector256<sbyte> vxnor(Vector256<sbyte> x, Vector256<sbyte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_000C: ret

}
Vector256<ushort> vxnor(Vector256<ushort> x, Vector256<ushort> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_000C: ret

}
Vector256<int> vxnor(Vector256<int> x, Vector256<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_000C: ret

}
Vector256<uint> vxnor(Vector256<uint> x, Vector256<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_000C: ret

}
Vector256<long> vxnor(Vector256<long> x, Vector256<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_000C: ret

}
Vector256<ulong> vxnor(Vector256<ulong> x, Vector256<ulong> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_000C: ret

}
Vec128<sbyte> vxor(in Vec128<sbyte> x, in Vec128<sbyte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0011: call Z0.Vec128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0016: ret

}
Vec128<byte> vxor(in Vec128<byte> x, in Vec128<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0011: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0016: ret

}
Vec128<short> vxor(in Vec128<short> x, in Vec128<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0011: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0016: ret

}
Vec128<ushort> vxor(in Vec128<ushort> x, in Vec128<ushort> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0011: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0016: ret

}
Vec128<int> vxor(in Vec128<int> x, in Vec128<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0011: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0016: ret

}
Vec128<uint> vxor(in Vec128<uint> x, in Vec128<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0011: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0016: ret

}
Vec128<long> vxor(in Vec128<long> x, in Vec128<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0011: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0016: ret

}
Vec128<ulong> vxor(in Vec128<ulong> x, in Vec128<ulong> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0011: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0016: ret

}
Vec256<byte> vxor(in Vec256<byte> x, in Vec256<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0011: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0016: ret

}
Vec256<short> vxor(in Vec256<short> x, in Vec256<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0011: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0016: ret

}
Vec256<sbyte> vxor(in Vec256<sbyte> x, in Vec256<sbyte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0011: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0016: ret

}
Vec256<ushort> vxor(in Vec256<ushort> x, in Vec256<ushort> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0011: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0016: ret

}
Vec256<int> vxor(in Vec256<int> x, in Vec256<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0016: ret

}
Vec256<uint> vxor(in Vec256<uint> x, in Vec256<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0011: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0016: ret

}
Vec256<long> vxor(in Vec256<long> x, in Vec256<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0011: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0016: ret

}
Vec256<ulong> vxor(in Vec256<ulong> x, in Vec256<ulong> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0011: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0016: ret

}
Vector128<sbyte> vxor(Vector128<sbyte> x, Vector128<sbyte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0007: ret

}
Vector128<byte> vxor(Vector128<byte> x, Vector128<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0007: ret

}
Vector128<short> vxor(Vector128<short> x, Vector128<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0007: ret

}
Vector128<ushort> vxor(Vector128<ushort> x, Vector128<ushort> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0007: ret

}
Vector128<int> vxor(Vector128<int> x, Vector128<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0007: ret

}
Vector128<uint> vxor(Vector128<uint> x, Vector128<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0007: ret

}
Vector128<long> vxor(Vector128<long> x, Vector128<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0007: ret

}
Vector128<ulong> vxor(Vector128<ulong> x, Vector128<ulong> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0007: ret

}
Vector256<byte> vxor(Vector256<byte> x, Vector256<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0007: ret

}
Vector256<short> vxor(Vector256<short> x, Vector256<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0007: ret

}
Vector256<sbyte> vxor(Vector256<sbyte> x, Vector256<sbyte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0007: ret

}
Vector256<ushort> vxor(Vector256<ushort> x, Vector256<ushort> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0007: ret

}
Vector256<int> vxor(Vector256<int> x, Vector256<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0007: ret

}
Vector256<uint> vxor(Vector256<uint> x, Vector256<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0007: ret

}
Vector256<long> vxor(Vector256<long> x, Vector256<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0007: ret

}
Vector256<ulong> vxor(Vector256<ulong> x, Vector256<ulong> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0007: ret

}
Vector128<sbyte> vxor1(Vector128<sbyte> x)
{
    IL_0000: ldarg.0
    IL_0001: ldloca.s V_0
    IL_0003: initobj System.Runtime.Intrinsics.Vector128`1<System.SByte>
    IL_0009: ldloc.0
    IL_000A: ldloca.s V_0
    IL_000C: initobj System.Runtime.Intrinsics.Vector128`1<System.SByte>
    IL_0012: ldloc.0
    IL_0013: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0018: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_001D: ret

}
Vector128<byte> vxor1(Vector128<byte> x)
{
    IL_0000: ldarg.0
    IL_0001: ldloca.s V_0
    IL_0003: initobj System.Runtime.Intrinsics.Vector128`1<System.Byte>
    IL_0009: ldloc.0
    IL_000A: ldloca.s V_0
    IL_000C: initobj System.Runtime.Intrinsics.Vector128`1<System.Byte>
    IL_0012: ldloc.0
    IL_0013: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0018: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_001D: ret

}
Vector128<short> vxor1(Vector128<short> x)
{
    IL_0000: ldarg.0
    IL_0001: ldloca.s V_0
    IL_0003: initobj System.Runtime.Intrinsics.Vector128`1<System.Int16>
    IL_0009: ldloc.0
    IL_000A: ldloca.s V_0
    IL_000C: initobj System.Runtime.Intrinsics.Vector128`1<System.Int16>
    IL_0012: ldloc.0
    IL_0013: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0018: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_001D: ret

}
Vector128<ushort> vxor1(Vector128<ushort> x)
{
    IL_0000: ldarg.0
    IL_0001: ldloca.s V_0
    IL_0003: initobj System.Runtime.Intrinsics.Vector128`1<System.UInt16>
    IL_0009: ldloc.0
    IL_000A: ldloca.s V_0
    IL_000C: initobj System.Runtime.Intrinsics.Vector128`1<System.UInt16>
    IL_0012: ldloc.0
    IL_0013: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0018: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_001D: ret

}
Vector128<int> vxor1(Vector128<int> x)
{
    IL_0000: ldarg.0
    IL_0001: ldloca.s V_0
    IL_0003: initobj System.Runtime.Intrinsics.Vector128`1<System.Int32>
    IL_0009: ldloc.0
    IL_000A: ldloca.s V_0
    IL_000C: initobj System.Runtime.Intrinsics.Vector128`1<System.Int32>
    IL_0012: ldloc.0
    IL_0013: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0018: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_001D: ret

}
Vector128<uint> vxor1(Vector128<uint> x)
{
    IL_0000: ldarg.0
    IL_0001: ldloca.s V_0
    IL_0003: initobj System.Runtime.Intrinsics.Vector128`1<System.UInt32>
    IL_0009: ldloc.0
    IL_000A: ldloca.s V_0
    IL_000C: initobj System.Runtime.Intrinsics.Vector128`1<System.UInt32>
    IL_0012: ldloc.0
    IL_0013: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0018: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_001D: ret

}
Vector128<long> vxor1(Vector128<long> x)
{
    IL_0000: ldarg.0
    IL_0001: ldloca.s V_0
    IL_0003: initobj System.Runtime.Intrinsics.Vector128`1<System.Int64>
    IL_0009: ldloc.0
    IL_000A: ldloca.s V_0
    IL_000C: initobj System.Runtime.Intrinsics.Vector128`1<System.Int64>
    IL_0012: ldloc.0
    IL_0013: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse41::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0018: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_001D: ret

}
Vector128<ulong> vxor1(Vector128<ulong> x)
{
    IL_0000: ldarg.0
    IL_0001: ldloca.s V_0
    IL_0003: initobj System.Runtime.Intrinsics.Vector128`1<System.UInt64>
    IL_0009: ldloc.0
    IL_000A: ldloca.s V_0
    IL_000C: initobj System.Runtime.Intrinsics.Vector128`1<System.UInt64>
    IL_0012: ldloc.0
    IL_0013: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse41::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0018: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_001D: ret

}
Vector256<sbyte> vxor1(Vector256<sbyte> x)
{
    IL_0000: ldarg.0
    IL_0001: ldloca.s V_0
    IL_0003: initobj System.Runtime.Intrinsics.Vector256`1<System.SByte>
    IL_0009: ldloc.0
    IL_000A: ldloca.s V_0
    IL_000C: initobj System.Runtime.Intrinsics.Vector256`1<System.SByte>
    IL_0012: ldloc.0
    IL_0013: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0018: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_001D: ret

}
Vector256<byte> vxor1(Vector256<byte> x)
{
    IL_0000: ldarg.0
    IL_0001: ldloca.s V_0
    IL_0003: initobj System.Runtime.Intrinsics.Vector256`1<System.Byte>
    IL_0009: ldloc.0
    IL_000A: ldloca.s V_0
    IL_000C: initobj System.Runtime.Intrinsics.Vector256`1<System.Byte>
    IL_0012: ldloc.0
    IL_0013: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0018: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_001D: ret

}
Vector256<short> vxor1(Vector256<short> x)
{
    IL_0000: ldarg.0
    IL_0001: ldloca.s V_0
    IL_0003: initobj System.Runtime.Intrinsics.Vector256`1<System.Int16>
    IL_0009: ldloc.0
    IL_000A: ldloca.s V_0
    IL_000C: initobj System.Runtime.Intrinsics.Vector256`1<System.Int16>
    IL_0012: ldloc.0
    IL_0013: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0018: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_001D: ret

}
Vector256<ushort> vxor1(Vector256<ushort> x)
{
    IL_0000: ldarg.0
    IL_0001: ldloca.s V_0
    IL_0003: initobj System.Runtime.Intrinsics.Vector256`1<System.UInt16>
    IL_0009: ldloc.0
    IL_000A: ldloca.s V_0
    IL_000C: initobj System.Runtime.Intrinsics.Vector256`1<System.UInt16>
    IL_0012: ldloc.0
    IL_0013: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0018: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_001D: ret

}
Vector256<int> vxor1(Vector256<int> x)
{
    IL_0000: ldarg.0
    IL_0001: ldloca.s V_0
    IL_0003: initobj System.Runtime.Intrinsics.Vector256`1<System.Int32>
    IL_0009: ldloc.0
    IL_000A: ldloca.s V_0
    IL_000C: initobj System.Runtime.Intrinsics.Vector256`1<System.Int32>
    IL_0012: ldloc.0
    IL_0013: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0018: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_001D: ret

}
Vector256<uint> vxor1(Vector256<uint> x)
{
    IL_0000: ldarg.0
    IL_0001: ldloca.s V_0
    IL_0003: initobj System.Runtime.Intrinsics.Vector256`1<System.UInt32>
    IL_0009: ldloc.0
    IL_000A: ldloca.s V_0
    IL_000C: initobj System.Runtime.Intrinsics.Vector256`1<System.UInt32>
    IL_0012: ldloc.0
    IL_0013: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0018: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_001D: ret

}
Vector256<long> vxor1(Vector256<long> x)
{
    IL_0000: ldarg.0
    IL_0001: ldloca.s V_0
    IL_0003: initobj System.Runtime.Intrinsics.Vector256`1<System.Int64>
    IL_0009: ldloc.0
    IL_000A: ldloca.s V_0
    IL_000C: initobj System.Runtime.Intrinsics.Vector256`1<System.Int64>
    IL_0012: ldloc.0
    IL_0013: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0018: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_001D: ret

}
Vector256<ulong> vxor1(Vector256<ulong> x)
{
    IL_0000: ldarg.0
    IL_0001: ldloca.s V_0
    IL_0003: initobj System.Runtime.Intrinsics.Vector256`1<System.UInt64>
    IL_0009: ldloc.0
    IL_000A: ldloca.s V_0
    IL_000C: initobj System.Runtime.Intrinsics.Vector256`1<System.UInt64>
    IL_0012: ldloc.0
    IL_0013: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0018: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_001D: ret

}
Vec128<ushort> vxorsl(in Vec128<ushort> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: call Z0.Vec128`1<System.UInt16> Z0.dinx::vsll(Z0.Vec128`1<System.UInt16>&,System.Byte)
    IL_0008: stloc.0
    IL_0009: ldloca.s V_0
    IL_000B: call Z0.Vec128`1<System.UInt16> Z0.dinx::vxor(Z0.Vec128`1<System.UInt16>&,Z0.Vec128`1<System.UInt16>&)
    IL_0010: ret

}
Vec128<uint> vxorsl(in Vec128<uint> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: call Z0.Vec128`1<System.UInt32> Z0.dinx::vsll(Z0.Vec128`1<System.UInt32>&,System.Byte)
    IL_0008: stloc.0
    IL_0009: ldloca.s V_0
    IL_000B: call Z0.Vec128`1<System.UInt32> Z0.dinx::vxor(Z0.Vec128`1<System.UInt32>&,Z0.Vec128`1<System.UInt32>&)
    IL_0010: ret

}
Vec128<ulong> vxorsl(in Vec128<ulong> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: call Z0.Vec128`1<System.UInt64> Z0.dinx::vsll(Z0.Vec128`1<System.UInt64>&,System.Byte)
    IL_0008: stloc.0
    IL_0009: ldloca.s V_0
    IL_000B: call Z0.Vec128`1<System.UInt64> Z0.dinx::vxor(Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&)
    IL_0010: ret

}
Vec256<ushort> vxorsl(in Vec256<ushort> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: call Z0.Vec256`1<System.UInt16> Z0.dinx::vsll(Z0.Vec256`1<System.UInt16>&,System.Byte)
    IL_0008: stloc.0
    IL_0009: ldloca.s V_0
    IL_000B: call Z0.Vec256`1<System.UInt16> Z0.dinx::vxor(Z0.Vec256`1<System.UInt16>&,Z0.Vec256`1<System.UInt16>&)
    IL_0010: ret

}
Vec256<uint> vxorsl(in Vec256<uint> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: call Z0.Vec256`1<System.UInt32> Z0.dinx::vsll(Z0.Vec256`1<System.UInt32>&,System.Byte)
    IL_0008: stloc.0
    IL_0009: ldloca.s V_0
    IL_000B: call Z0.Vec256`1<System.UInt32> Z0.dinx::vxor(Z0.Vec256`1<System.UInt32>&,Z0.Vec256`1<System.UInt32>&)
    IL_0010: ret

}
Vec256<ulong> vxorsl(in Vec256<ulong> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: call Z0.Vec256`1<System.UInt64> Z0.dinx::vsll(Z0.Vec256`1<System.UInt64>&,System.Byte)
    IL_0008: stloc.0
    IL_0009: ldloca.s V_0
    IL_000B: call Z0.Vec256`1<System.UInt64> Z0.dinx::vxor(Z0.Vec256`1<System.UInt64>&,Z0.Vec256`1<System.UInt64>&)
    IL_0010: ret

}
Vec128<uint> vxorslv(in Vec128<uint> src, in Vec128<uint> offsets)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: call Z0.Vec128`1<System.UInt32> Z0.dinx::vsllv(Z0.Vec128`1<System.UInt32>&,Z0.Vec128`1<System.UInt32>&)
    IL_0008: stloc.0
    IL_0009: ldloca.s V_0
    IL_000B: call Z0.Vec128`1<System.UInt32> Z0.dinx::vxor(Z0.Vec128`1<System.UInt32>&,Z0.Vec128`1<System.UInt32>&)
    IL_0010: ret

}
Vec128<ulong> vxorslv(in Vec128<ulong> src, in Vec128<ulong> offsets)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: call Z0.Vec128`1<System.UInt64> Z0.dinx::vsllv(Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&)
    IL_0008: stloc.0
    IL_0009: ldloca.s V_0
    IL_000B: call Z0.Vec128`1<System.UInt64> Z0.dinx::vxor(Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&)
    IL_0010: ret

}
Vec256<uint> vxorslv(in Vec256<uint> src, in Vec256<uint> offsets)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: call Z0.Vec256`1<System.UInt32> Z0.dinx::vsllv(Z0.Vec256`1<System.UInt32>&,Z0.Vec256`1<System.UInt32>&)
    IL_0008: stloc.0
    IL_0009: ldloca.s V_0
    IL_000B: call Z0.Vec256`1<System.UInt32> Z0.dinx::vxor(Z0.Vec256`1<System.UInt32>&,Z0.Vec256`1<System.UInt32>&)
    IL_0010: ret

}
Vec256<ulong> vxorslv(in Vec256<ulong> src, in Vec256<ulong> offsets)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: call Z0.Vec256`1<System.UInt64> Z0.dinx::vsllv(Z0.Vec256`1<System.UInt64>&,Z0.Vec256`1<System.UInt64>&)
    IL_0008: stloc.0
    IL_0009: ldloca.s V_0
    IL_000B: call Z0.Vec256`1<System.UInt64> Z0.dinx::vxor(Z0.Vec256`1<System.UInt64>&,Z0.Vec256`1<System.UInt64>&)
    IL_0010: ret

}
Vec128<ushort> vxorsr(in Vec128<ushort> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: call Z0.Vec128`1<System.UInt16> Z0.dinx::vsrl(Z0.Vec128`1<System.UInt16>&,System.Byte)
    IL_0008: stloc.0
    IL_0009: ldloca.s V_0
    IL_000B: call Z0.Vec128`1<System.UInt16> Z0.dinx::vxor(Z0.Vec128`1<System.UInt16>&,Z0.Vec128`1<System.UInt16>&)
    IL_0010: ret

}
Vec128<uint> vxorsr(in Vec128<uint> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: call Z0.Vec128`1<System.UInt32> Z0.dinx::vsrl(Z0.Vec128`1<System.UInt32>&,System.Byte)
    IL_0008: stloc.0
    IL_0009: ldloca.s V_0
    IL_000B: call Z0.Vec128`1<System.UInt32> Z0.dinx::vxor(Z0.Vec128`1<System.UInt32>&,Z0.Vec128`1<System.UInt32>&)
    IL_0010: ret

}
Vec128<ulong> vxorsr(in Vec128<ulong> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: call Z0.Vec128`1<System.UInt64> Z0.dinx::vsrl(Z0.Vec128`1<System.UInt64>&,System.Byte)
    IL_0008: stloc.0
    IL_0009: ldloca.s V_0
    IL_000B: call Z0.Vec128`1<System.UInt64> Z0.dinx::vxor(Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&)
    IL_0010: ret

}
Vec256<ushort> vxorsr(in Vec256<ushort> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: call Z0.Vec256`1<System.UInt16> Z0.dinx::vsrl(Z0.Vec256`1<System.UInt16>&,System.Byte)
    IL_0008: stloc.0
    IL_0009: ldloca.s V_0
    IL_000B: call Z0.Vec256`1<System.UInt16> Z0.dinx::vxor(Z0.Vec256`1<System.UInt16>&,Z0.Vec256`1<System.UInt16>&)
    IL_0010: ret

}
Vec256<uint> vxorsr(in Vec256<uint> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: call Z0.Vec256`1<System.UInt32> Z0.dinx::vsrl(Z0.Vec256`1<System.UInt32>&,System.Byte)
    IL_0008: stloc.0
    IL_0009: ldloca.s V_0
    IL_000B: call Z0.Vec256`1<System.UInt32> Z0.dinx::vxor(Z0.Vec256`1<System.UInt32>&,Z0.Vec256`1<System.UInt32>&)
    IL_0010: ret

}
Vec256<ulong> vxorsr(in Vec256<ulong> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: call Z0.Vec256`1<System.UInt64> Z0.dinx::vsrl(Z0.Vec256`1<System.UInt64>&,System.Byte)
    IL_0008: stloc.0
    IL_0009: ldloca.s V_0
    IL_000B: call Z0.Vec256`1<System.UInt64> Z0.dinx::vxor(Z0.Vec256`1<System.UInt64>&,Z0.Vec256`1<System.UInt64>&)
    IL_0010: ret

}
Vec128<uint> vxorsrv(in Vec128<uint> src, in Vec128<uint> offsets)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: call Z0.Vec128`1<System.UInt32> Z0.dinx::vsrlv(Z0.Vec128`1<System.UInt32>&,Z0.Vec128`1<System.UInt32>&)
    IL_0008: stloc.0
    IL_0009: ldloca.s V_0
    IL_000B: call Z0.Vec128`1<System.UInt32> Z0.dinx::vxor(Z0.Vec128`1<System.UInt32>&,Z0.Vec128`1<System.UInt32>&)
    IL_0010: ret

}
Vec128<ulong> vxorsrv(in Vec128<ulong> src, in Vec128<ulong> offsets)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: call Z0.Vec128`1<System.UInt64> Z0.dinx::vsrlv(Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&)
    IL_0008: stloc.0
    IL_0009: ldloca.s V_0
    IL_000B: call Z0.Vec128`1<System.UInt64> Z0.dinx::vxor(Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&)
    IL_0010: ret

}
Vec256<uint> vxorsrv(in Vec256<uint> src, in Vec256<uint> offsets)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: call Z0.Vec256`1<System.UInt32> Z0.dinx::vsrlv(Z0.Vec256`1<System.UInt32>&,Z0.Vec256`1<System.UInt32>&)
    IL_0008: stloc.0
    IL_0009: ldloca.s V_0
    IL_000B: call Z0.Vec256`1<System.UInt32> Z0.dinx::vxor(Z0.Vec256`1<System.UInt32>&,Z0.Vec256`1<System.UInt32>&)
    IL_0010: ret

}
Vec256<ulong> vxorsrv(in Vec256<ulong> src, in Vec256<ulong> offsets)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: call Z0.Vec256`1<System.UInt64> Z0.dinx::vsrlv(Z0.Vec256`1<System.UInt64>&,Z0.Vec256`1<System.UInt64>&)
    IL_0008: stloc.0
    IL_0009: ldloca.s V_0
    IL_000B: call Z0.Vec256`1<System.UInt64> Z0.dinx::vxor(Z0.Vec256`1<System.UInt64>&,Z0.Vec256`1<System.UInt64>&)
    IL_0010: ret

}
Vec128<sbyte> vcmpeq(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.SByte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.SByte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_001B: call Z0.Vec128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0020: ret

}
Vec128<byte> vcmpeq(in Vec128<byte> lhs, in Vec128<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_001B: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0020: ret

}
Vec128<short> vcmpeq(in Vec128<short> lhs, in Vec128<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int16>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_001B: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0020: ret

}
Vec128<ushort> vcmpeq(in Vec128<ushort> lhs, in Vec128<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt16>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_001B: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0020: ret

}
Vec128<int> vcmpeq(in Vec128<int> lhs, in Vec128<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int32>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_001B: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0020: ret

}
Vec128<uint> vcmpeq(in Vec128<uint> lhs, in Vec128<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt32>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_001B: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0020: ret

}
Vec128<long> vcmpeq(in Vec128<long> lhs, in Vec128<long> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int64>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(Z0.Vec128`1<System.Int64>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int64>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(Z0.Vec128`1<System.Int64>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse41::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_001B: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0020: ret

}
Vec128<ulong> vcmpeq(in Vec128<ulong> lhs, in Vec128<ulong> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt64>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt64>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse41::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_001B: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0020: ret

}
Vec256<sbyte> vcmpeq(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.SByte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.SByte>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_001B: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0020: ret

}
Vec256<byte> vcmpeq(in Vec256<byte> lhs, in Vec256<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_001B: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0020: ret

}
Vec256<long> vnor(in Vec256<long> x, in Vec256<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::Or(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0016: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_001B: ret

}
Vec256<ulong> vnor(in Vec256<ulong> x, in Vec256<ulong> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::Or(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0016: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_001B: ret

}
Vec256<float> vnor(in Vec256<float> x, in Vec256<float> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Single> System.Runtime.Intrinsics.X86.Avx::Or(System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.dfp::vnot(System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_0016: call Z0.Vec256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_001B: ret

}
Vec256<double> vnor(in Vec256<double> x, in Vec256<double> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Double> System.Runtime.Intrinsics.X86.Avx::Or(System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.dfp::vnot(System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_0016: call Z0.Vec256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_001B: ret

}
Vec128<sbyte> vnot(in Vec128<sbyte> src)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::xmm
    IL_0006: ldarg.0
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::xmm
    IL_000C: ldarg.0
    IL_000D: ldfld System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::xmm
    IL_0012: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0017: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_001C: call Z0.Vec128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0021: ret

}
Vec128<byte> vnot(in Vec128<byte> src)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::xmm
    IL_0006: ldarg.0
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::xmm
    IL_000C: ldarg.0
    IL_000D: ldfld System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::xmm
    IL_0012: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0017: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_001C: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0021: ret

}
Vec128<short> vnot(in Vec128<short> src)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::xmm
    IL_0006: ldarg.0
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::xmm
    IL_000C: ldarg.0
    IL_000D: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::xmm
    IL_0012: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0017: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_001C: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0021: ret

}
Vec128<ushort> vnot(in Vec128<ushort> src)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::xmm
    IL_0006: ldarg.0
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::xmm
    IL_000C: ldarg.0
    IL_000D: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::xmm
    IL_0012: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0017: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_001C: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0021: ret

}
Vec128<int> vnot(in Vec128<int> src)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::xmm
    IL_0006: ldarg.0
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::xmm
    IL_000C: ldarg.0
    IL_000D: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::xmm
    IL_0012: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0017: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_001C: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0021: ret

}
Vec128<uint> vnot(in Vec128<uint> src)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::xmm
    IL_0006: ldarg.0
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::xmm
    IL_000C: ldarg.0
    IL_000D: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::xmm
    IL_0012: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0017: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_001C: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0021: ret

}
Vec128<long> vnot(in Vec128<long> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.Int64>::As<System.UInt32>()
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: call Z0.Vec128`1<System.UInt32> Z0.dinx::vnot(Z0.Vec128`1<System.UInt32>&)
    IL_000E: stloc.1
    IL_000F: ldloca.s V_1
    IL_0011: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.UInt32>::As<System.Int64>()
    IL_0016: ret

}
Vec128<ulong> vnot(Vector128<ulong> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.Vector128::AsUInt32<System.UInt64>(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0006: ldarg.0
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.Vector128::AsUInt32<System.UInt64>(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_000C: ldarg.0
    IL_000D: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.Vector128::AsUInt32<System.UInt64>(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0012: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0017: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_001C: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.Vector128::AsUInt64<System.UInt32>(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0021: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0026: ret

}
Vec128<ulong> vnot(in Vec128<ulong> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt64>::As<System.UInt32>()
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: call Z0.Vec128`1<System.UInt32> Z0.dinx::vnot(Z0.Vec128`1<System.UInt32>&)
    IL_000E: stloc.1
    IL_000F: ldloca.s V_1
    IL_0011: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt32>::As<System.UInt64>()
    IL_0016: ret

}
Vec256<sbyte> vnot(in Vec256<sbyte> src)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::ymm
    IL_0006: ldarg.0
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::ymm
    IL_000C: ldarg.0
    IL_000D: ldfld System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::ymm
    IL_0012: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0017: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_001C: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0021: ret

}
Vec256<byte> vnot(in Vec256<byte> src)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::ymm
    IL_0006: ldarg.0
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::ymm
    IL_000C: ldarg.0
    IL_000D: ldfld System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::ymm
    IL_0012: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0017: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_001C: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0021: ret

}
Vec256<short> vnot(in Vec256<short> src)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::ymm
    IL_0006: ldarg.0
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::ymm
    IL_000C: ldarg.0
    IL_000D: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::ymm
    IL_0012: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0017: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_001C: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0021: ret

}
Vec256<ushort> vnot(in Vec256<ushort> src)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::ymm
    IL_0006: ldarg.0
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::ymm
    IL_000C: ldarg.0
    IL_000D: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::ymm
    IL_0012: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0017: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_001C: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0021: ret

}
Vec256<int> vnot(in Vec256<int> src)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::ymm
    IL_0006: ldarg.0
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::ymm
    IL_000C: ldarg.0
    IL_000D: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::ymm
    IL_0012: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0017: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_001C: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0021: ret

}
Vec256<uint> vnot(in Vec256<uint> src)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::ymm
    IL_0006: ldarg.0
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::ymm
    IL_000C: ldarg.0
    IL_000D: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::ymm
    IL_0012: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0017: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_001C: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0021: ret

}
Vec256<long> vnot(in Vec256<long> src)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::ymm
    IL_0006: ldarg.0
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::ymm
    IL_000C: ldarg.0
    IL_000D: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::ymm
    IL_0012: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0017: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_001C: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0021: ret

}
Vec256<ulong> vnot(in Vec256<ulong> src)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::ymm
    IL_0006: ldarg.0
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::ymm
    IL_000C: ldarg.0
    IL_000D: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::ymm
    IL_0012: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0017: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_001C: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0021: ret

}
Vector128<sbyte> vnot(Vector128<sbyte> src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldarg.0
    IL_0003: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0008: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_000D: ret

}
Vector128<byte> vnot(Vector128<byte> src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldarg.0
    IL_0003: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0008: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_000D: ret

}
Vector128<short> vnot(Vector128<short> src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldarg.0
    IL_0003: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0008: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_000D: ret

}
Vector128<ushort> vnot(Vector128<ushort> src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldarg.0
    IL_0003: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0008: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_000D: ret

}
Vector128<int> vnot(Vector128<int> src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldarg.0
    IL_0003: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0008: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_000D: ret

}
Vector128<uint> vnot(Vector128<uint> src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldarg.0
    IL_0003: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0008: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_000D: ret

}
Vector128<long> vnot(Vector128<long> src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.Vector128::AsUInt32<System.Int64>(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0006: stloc.0
    IL_0007: ldloc.0
    IL_0008: ldloc.0
    IL_0009: ldloc.0
    IL_000A: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::CompareEqual(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_000F: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::Xor(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0014: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.Vector128::AsInt64<System.UInt32>(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0019: ret

}
Vector256<sbyte> vnot(Vector256<sbyte> src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldarg.0
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0008: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_000D: ret

}
Vector256<byte> vnot(Vector256<byte> src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldarg.0
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0008: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_000D: ret

}
Vector256<short> vnot(Vector256<short> src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldarg.0
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0008: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_000D: ret

}
Vector256<ushort> vnot(Vector256<ushort> src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldarg.0
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0008: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_000D: ret

}
Vector256<int> vnot(Vector256<int> src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldarg.0
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0008: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_000D: ret

}
Vector256<uint> vnot(Vector256<uint> src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldarg.0
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0008: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_000D: ret

}
Vector256<long> vnot(Vector256<long> src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldarg.0
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0008: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_000D: ret

}
Vector256<ulong> vnot(Vector256<ulong> src)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldarg.0
    IL_0003: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::CompareEqual(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0008: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::Xor(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_000D: ret

}
Vec128<byte> vor(in Vec128<byte> x, in Vec128<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::Or(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0011: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0016: ret

}
Vec128<short> vor(in Vec128<short> x, in Vec128<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::Or(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0011: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0016: ret

}
Vec128<sbyte> vor(in Vec128<sbyte> x, in Vec128<sbyte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::Or(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0011: call Z0.Vec128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0016: ret

}
Vec128<ushort> vor(in Vec128<ushort> x, in Vec128<ushort> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::Or(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0011: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0016: ret

}
Vec128<int> vor(in Vec128<int> x, in Vec128<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::Or(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0011: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0016: ret

}
Vec128<uint> vor(in Vec128<uint> x, in Vec128<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::Or(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0011: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0016: ret

}
Vec128<long> vor(in Vec128<long> x, in Vec128<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse2::Or(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0011: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0016: ret

}
Vec128<ulong> vor(in Vec128<ulong> x, in Vec128<ulong> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::Or(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0011: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0016: ret

}
Vec256<byte> vor(in Vec256<byte> x, in Vec256<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::Or(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0011: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0016: ret

}
Vec256<short> vor(in Vec256<short> x, in Vec256<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::Or(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0011: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0016: ret

}
Vec256<sbyte> vor(in Vec256<sbyte> x, in Vec256<sbyte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::Or(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0011: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0016: ret

}
Vec256<ushort> vor(in Vec256<ushort> x, in Vec256<ushort> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::Or(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0011: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0016: ret

}
Vec256<int> vor(in Vec256<int> x, in Vec256<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::Or(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0016: ret

}
Vec256<uint> vor(in Vec256<uint> x, in Vec256<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::Or(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0011: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0016: ret

}
Vec256<long> vor(in Vec256<long> x, in Vec256<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::Or(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0011: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0016: ret

}
Vec256<ulong> vor(in Vec256<ulong> x, in Vec256<ulong> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::Or(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0011: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0016: ret

}
Vector128<byte> vor(Vector128<byte> x, Vector128<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::Or(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0007: ret

}
Vector128<short> vor(Vector128<short> x, Vector128<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::Or(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0007: ret

}
Vector128<sbyte> vor(Vector128<sbyte> x, Vector128<sbyte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::Or(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0007: ret

}
Vector128<ushort> vor(Vector128<ushort> x, Vector128<ushort> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::Or(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0007: ret

}
Vector128<int> vor(Vector128<int> x, Vector128<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::Or(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0007: ret

}
Vector128<uint> vor(Vector128<uint> x, Vector128<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::Or(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0007: ret

}
Vector128<long> vor(Vector128<long> x, Vector128<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse2::Or(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0007: ret

}
Vector128<ulong> vor(Vector128<ulong> x, Vector128<ulong> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::Or(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0007: ret

}
Vector256<byte> vor(Vector256<byte> x, Vector256<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::Or(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0007: ret

}
Vector256<short> vor(Vector256<short> x, Vector256<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::Or(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0007: ret

}
Vector256<sbyte> vor(Vector256<sbyte> x, Vector256<sbyte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::Or(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0007: ret

}
Vector256<ushort> vor(Vector256<ushort> x, Vector256<ushort> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::Or(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0007: ret

}
Vector256<int> vor(Vector256<int> x, Vector256<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::Or(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0007: ret

}
Vector256<uint> vor(Vector256<uint> x, Vector256<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::Or(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0007: ret

}
Vector256<long> vor(Vector256<long> x, Vector256<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::Or(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0007: ret

}
Vector256<ulong> vor(Vector256<ulong> x, Vector256<ulong> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::Or(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0007: ret

}
Vec128<byte> vrotl(in Vec128<byte> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.Byte> Z0.dinx::vsll(Z0.Vec128`1<System.Byte>&,System.Byte)
    IL_0007: stloc.0
    IL_0008: ldloca.s V_0
    IL_000A: ldarg.0
    IL_000B: ldc.i4.8
    IL_000C: ldarg.1
    IL_000D: sub
    IL_000E: conv.u1
    IL_000F: call Z0.Vec128`1<System.Byte> Z0.dinx::vsrl(Z0.Vec128`1<System.Byte>&,System.Byte)
    IL_0014: stloc.1
    IL_0015: ldloca.s V_1
    IL_0017: call Z0.Vec128`1<System.Byte> Z0.dinx::vor(Z0.Vec128`1<System.Byte>&,Z0.Vec128`1<System.Byte>&)
    IL_001C: ret

}
Vec128<ushort> vrotl(in Vec128<ushort> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.UInt16> Z0.dinx::vsll(Z0.Vec128`1<System.UInt16>&,System.Byte)
    IL_0007: stloc.0
    IL_0008: ldloca.s V_0
    IL_000A: ldarg.0
    IL_000B: ldc.i4.s 16
    IL_000D: ldarg.1
    IL_000E: sub
    IL_000F: conv.u1
    IL_0010: call Z0.Vec128`1<System.UInt16> Z0.dinx::vsrl(Z0.Vec128`1<System.UInt16>&,System.Byte)
    IL_0015: stloc.1
    IL_0016: ldloca.s V_1
    IL_0018: call Z0.Vec128`1<System.UInt16> Z0.dinx::vor(Z0.Vec128`1<System.UInt16>&,Z0.Vec128`1<System.UInt16>&)
    IL_001D: ret

}
Vec128<uint> vrotl(in Vec128<uint> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.UInt32> Z0.dinx::vsll(Z0.Vec128`1<System.UInt32>&,System.Byte)
    IL_0007: stloc.0
    IL_0008: ldarg.0
    IL_0009: ldc.i4.s 32
    IL_000B: ldarg.1
    IL_000C: sub
    IL_000D: conv.u1
    IL_000E: call Z0.Vec128`1<System.UInt32> Z0.dinx::vsrl(Z0.Vec128`1<System.UInt32>&,System.Byte)
    IL_0013: stloc.1
    IL_0014: ldloca.s V_0
    IL_0016: ldloca.s V_1
    IL_0018: call Z0.Vec128`1<System.UInt32> Z0.dinx::vor(Z0.Vec128`1<System.UInt32>&,Z0.Vec128`1<System.UInt32>&)
    IL_001D: ret

}
Vec128<ulong> vrotl(in Vec128<ulong> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.UInt64> Z0.dinx::vsll(Z0.Vec128`1<System.UInt64>&,System.Byte)
    IL_0007: stloc.0
    IL_0008: ldarg.0
    IL_0009: ldc.i4.s 64
    IL_000B: ldarg.1
    IL_000C: sub
    IL_000D: conv.u1
    IL_000E: call Z0.Vec128`1<System.UInt64> Z0.dinx::vsrl(Z0.Vec128`1<System.UInt64>&,System.Byte)
    IL_0013: stloc.1
    IL_0014: ldloca.s V_0
    IL_0016: ldloca.s V_1
    IL_0018: call Z0.Vec128`1<System.UInt64> Z0.dinx::vor(Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&)
    IL_001D: ret

}
Vec256<byte> vrotl(in Vec256<byte> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.Byte> Z0.dinx::vsll(Z0.Vec256`1<System.Byte>&,System.Byte)
    IL_0007: stloc.0
    IL_0008: ldarg.0
    IL_0009: ldc.i4.8
    IL_000A: ldarg.1
    IL_000B: sub
    IL_000C: conv.u1
    IL_000D: call Z0.Vec256`1<System.Byte> Z0.dinx::vsrl(Z0.Vec256`1<System.Byte>&,System.Byte)
    IL_0012: stloc.1
    IL_0013: ldloca.s V_0
    IL_0015: ldloca.s V_1
    IL_0017: call Z0.Vec256`1<System.Byte> Z0.dinx::vor(Z0.Vec256`1<System.Byte>&,Z0.Vec256`1<System.Byte>&)
    IL_001C: ret

}
Vec256<ushort> vrotl(in Vec256<ushort> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.UInt16> Z0.dinx::vsll(Z0.Vec256`1<System.UInt16>&,System.Byte)
    IL_0007: stloc.0
    IL_0008: ldarg.0
    IL_0009: ldc.i4.s 16
    IL_000B: ldarg.1
    IL_000C: sub
    IL_000D: conv.u1
    IL_000E: call Z0.Vec256`1<System.UInt16> Z0.dinx::vsrl(Z0.Vec256`1<System.UInt16>&,System.Byte)
    IL_0013: stloc.1
    IL_0014: ldloca.s V_0
    IL_0016: ldloca.s V_1
    IL_0018: call Z0.Vec256`1<System.UInt16> Z0.dinx::vor(Z0.Vec256`1<System.UInt16>&,Z0.Vec256`1<System.UInt16>&)
    IL_001D: ret

}
Vec256<uint> vrotl(in Vec256<uint> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.UInt32> Z0.dinx::vsll(Z0.Vec256`1<System.UInt32>&,System.Byte)
    IL_0007: stloc.0
    IL_0008: ldarg.0
    IL_0009: ldc.i4.s 32
    IL_000B: ldarg.1
    IL_000C: sub
    IL_000D: conv.u1
    IL_000E: call Z0.Vec256`1<System.UInt32> Z0.dinx::vsrl(Z0.Vec256`1<System.UInt32>&,System.Byte)
    IL_0013: stloc.1
    IL_0014: ldloca.s V_0
    IL_0016: ldloca.s V_1
    IL_0018: call Z0.Vec256`1<System.UInt32> Z0.dinx::vor(Z0.Vec256`1<System.UInt32>&,Z0.Vec256`1<System.UInt32>&)
    IL_001D: ret

}
Vec256<ulong> vrotl(in Vec256<ulong> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.UInt64> Z0.dinx::vsll(Z0.Vec256`1<System.UInt64>&,System.Byte)
    IL_0007: stloc.0
    IL_0008: ldarg.0
    IL_0009: ldc.i4.s 64
    IL_000B: ldarg.1
    IL_000C: sub
    IL_000D: conv.u1
    IL_000E: call Z0.Vec256`1<System.UInt64> Z0.dinx::vsrl(Z0.Vec256`1<System.UInt64>&,System.Byte)
    IL_0013: stloc.1
    IL_0014: ldloca.s V_0
    IL_0016: ldloca.s V_1
    IL_0018: call Z0.Vec256`1<System.UInt64> Z0.dinx::vor(Z0.Vec256`1<System.UInt64>&,Z0.Vec256`1<System.UInt64>&)
    IL_001D: ret

}
Vec128<ulong> vrotl(in Vec128<ulong> src, in Vec128<ulong> offsets)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.UInt64> Z0.dinx::vsllv(Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&)
    IL_0007: stloc.0
    IL_0008: ldarg.0
    IL_0009: ldsflda Z0.Vec128`1<System.UInt64> Z0.dinx::Vec128u64
    IL_000E: ldarg.1
    IL_000F: call Z0.Vec128`1<System.UInt64> Z0.dinx::vsub(Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&)
    IL_0014: stloc.2
    IL_0015: ldloca.s V_2
    IL_0017: call Z0.Vec128`1<System.UInt64> Z0.dinx::vsrlv(Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&)
    IL_001C: stloc.1
    IL_001D: ldloca.s V_0
    IL_001F: ldloca.s V_1
    IL_0021: call Z0.Vec128`1<System.UInt64> Z0.dinx::vor(Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&)
    IL_0026: ret

}
Vec128<uint> vrotl(in Vec128<uint> src, in Vec128<uint> offsets)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.UInt32> Z0.dinx::vsllv(Z0.Vec128`1<System.UInt32>&,Z0.Vec128`1<System.UInt32>&)
    IL_0007: stloc.0
    IL_0008: ldarg.0
    IL_0009: ldsflda Z0.Vec128`1<System.UInt32> Z0.dinx::Vec128u32
    IL_000E: ldarg.1
    IL_000F: call Z0.Vec128`1<System.UInt32> Z0.dinx::vsub(Z0.Vec128`1<System.UInt32>&,Z0.Vec128`1<System.UInt32>&)
    IL_0014: stloc.2
    IL_0015: ldloca.s V_2
    IL_0017: call Z0.Vec128`1<System.UInt32> Z0.dinx::vsrlv(Z0.Vec128`1<System.UInt32>&,Z0.Vec128`1<System.UInt32>&)
    IL_001C: stloc.1
    IL_001D: ldloca.s V_0
    IL_001F: ldloca.s V_1
    IL_0021: call Z0.Vec128`1<System.UInt32> Z0.dinx::vor(Z0.Vec128`1<System.UInt32>&,Z0.Vec128`1<System.UInt32>&)
    IL_0026: ret

}
Vec256<ulong> vrotl(in Vec256<ulong> src, in Vec256<ulong> offsets)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.UInt64> Z0.dinx::vsllv(Z0.Vec256`1<System.UInt64>&,Z0.Vec256`1<System.UInt64>&)
    IL_0007: stloc.0
    IL_0008: ldarg.0
    IL_0009: ldsflda Z0.Vec256`1<System.UInt64> Z0.dinx::Vec256u64
    IL_000E: ldarg.1
    IL_000F: call Z0.Vec256`1<System.UInt64> Z0.dinx::vsub(Z0.Vec256`1<System.UInt64>&,Z0.Vec256`1<System.UInt64>&)
    IL_0014: stloc.2
    IL_0015: ldloca.s V_2
    IL_0017: call Z0.Vec256`1<System.UInt64> Z0.dinx::vsrlv(Z0.Vec256`1<System.UInt64>&,Z0.Vec256`1<System.UInt64>&)
    IL_001C: stloc.1
    IL_001D: ldloca.s V_0
    IL_001F: ldloca.s V_1
    IL_0021: call Z0.Vec256`1<System.UInt64> Z0.dinx::vor(Z0.Vec256`1<System.UInt64>&,Z0.Vec256`1<System.UInt64>&)
    IL_0026: ret

}
Vec256<uint> vrotl(in Vec256<uint> src, in Vec256<uint> offsets)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.UInt32> Z0.dinx::vsllv(Z0.Vec256`1<System.UInt32>&,Z0.Vec256`1<System.UInt32>&)
    IL_0007: stloc.0
    IL_0008: ldarg.0
    IL_0009: ldsflda Z0.Vec256`1<System.UInt32> Z0.dinx::Vec256u32
    IL_000E: ldarg.1
    IL_000F: call Z0.Vec256`1<System.UInt32> Z0.dinx::vsub(Z0.Vec256`1<System.UInt32>&,Z0.Vec256`1<System.UInt32>&)
    IL_0014: stloc.2
    IL_0015: ldloca.s V_2
    IL_0017: call Z0.Vec256`1<System.UInt32> Z0.dinx::vsrlv(Z0.Vec256`1<System.UInt32>&,Z0.Vec256`1<System.UInt32>&)
    IL_001C: stloc.1
    IL_001D: ldloca.s V_0
    IL_001F: ldloca.s V_1
    IL_0021: call Z0.Vec256`1<System.UInt32> Z0.dinx::vor(Z0.Vec256`1<System.UInt32>&,Z0.Vec256`1<System.UInt32>&)
    IL_0026: ret

}
Vec128<byte> vrotr(in Vec128<byte> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.Byte> Z0.dinx::vsrl(Z0.Vec128`1<System.Byte>&,System.Byte)
    IL_0007: stloc.0
    IL_0008: ldarg.0
    IL_0009: ldc.i4.8
    IL_000A: ldarg.1
    IL_000B: sub
    IL_000C: conv.u1
    IL_000D: call Z0.Vec128`1<System.Byte> Z0.dinx::vsll(Z0.Vec128`1<System.Byte>&,System.Byte)
    IL_0012: stloc.1
    IL_0013: ldloca.s V_0
    IL_0015: ldloca.s V_1
    IL_0017: call Z0.Vec128`1<System.Byte> Z0.dinx::vor(Z0.Vec128`1<System.Byte>&,Z0.Vec128`1<System.Byte>&)
    IL_001C: ret

}
Vec128<ushort> vrotr(in Vec128<ushort> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.UInt16> Z0.dinx::vsrl(Z0.Vec128`1<System.UInt16>&,System.Byte)
    IL_0007: stloc.0
    IL_0008: ldarg.0
    IL_0009: ldc.i4.s 16
    IL_000B: ldarg.1
    IL_000C: sub
    IL_000D: conv.u1
    IL_000E: call Z0.Vec128`1<System.UInt16> Z0.dinx::vsll(Z0.Vec128`1<System.UInt16>&,System.Byte)
    IL_0013: stloc.1
    IL_0014: ldloca.s V_0
    IL_0016: ldloca.s V_1
    IL_0018: call Z0.Vec128`1<System.UInt16> Z0.dinx::vor(Z0.Vec128`1<System.UInt16>&,Z0.Vec128`1<System.UInt16>&)
    IL_001D: ret

}
Vec128<uint> vrotr(in Vec128<uint> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.UInt32> Z0.dinx::vsrl(Z0.Vec128`1<System.UInt32>&,System.Byte)
    IL_0007: stloc.0
    IL_0008: ldarg.0
    IL_0009: ldc.i4.s 32
    IL_000B: ldarg.1
    IL_000C: sub
    IL_000D: conv.u1
    IL_000E: call Z0.Vec128`1<System.UInt32> Z0.dinx::vsll(Z0.Vec128`1<System.UInt32>&,System.Byte)
    IL_0013: stloc.1
    IL_0014: ldloca.s V_0
    IL_0016: ldloca.s V_1
    IL_0018: call Z0.Vec128`1<System.UInt32> Z0.dinx::vor(Z0.Vec128`1<System.UInt32>&,Z0.Vec128`1<System.UInt32>&)
    IL_001D: ret

}
Vec128<ulong> vrotr(in Vec128<ulong> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.UInt64> Z0.dinx::vsrl(Z0.Vec128`1<System.UInt64>&,System.Byte)
    IL_0007: stloc.0
    IL_0008: ldarg.0
    IL_0009: ldc.i4.s 64
    IL_000B: ldarg.1
    IL_000C: sub
    IL_000D: conv.u1
    IL_000E: call Z0.Vec128`1<System.UInt64> Z0.dinx::vsll(Z0.Vec128`1<System.UInt64>&,System.Byte)
    IL_0013: stloc.1
    IL_0014: ldloca.s V_0
    IL_0016: ldloca.s V_1
    IL_0018: call Z0.Vec128`1<System.UInt64> Z0.dinx::vor(Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&)
    IL_001D: ret

}
Vec256<byte> vrotr(in Vec256<byte> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.Byte> Z0.dinx::vsrl(Z0.Vec256`1<System.Byte>&,System.Byte)
    IL_0007: stloc.0
    IL_0008: ldarg.0
    IL_0009: ldc.i4.8
    IL_000A: ldarg.1
    IL_000B: sub
    IL_000C: conv.u1
    IL_000D: call Z0.Vec256`1<System.Byte> Z0.dinx::vsll(Z0.Vec256`1<System.Byte>&,System.Byte)
    IL_0012: stloc.1
    IL_0013: ldloca.s V_0
    IL_0015: ldloca.s V_1
    IL_0017: call Z0.Vec256`1<System.Byte> Z0.dinx::vor(Z0.Vec256`1<System.Byte>&,Z0.Vec256`1<System.Byte>&)
    IL_001C: ret

}
Vec256<ushort> vrotr(in Vec256<ushort> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.UInt16> Z0.dinx::vsrl(Z0.Vec256`1<System.UInt16>&,System.Byte)
    IL_0007: stloc.0
    IL_0008: ldarg.0
    IL_0009: ldc.i4.s 16
    IL_000B: ldarg.1
    IL_000C: sub
    IL_000D: conv.u1
    IL_000E: call Z0.Vec256`1<System.UInt16> Z0.dinx::vsll(Z0.Vec256`1<System.UInt16>&,System.Byte)
    IL_0013: stloc.1
    IL_0014: ldloca.s V_0
    IL_0016: ldloca.s V_1
    IL_0018: call Z0.Vec256`1<System.UInt16> Z0.dinx::vor(Z0.Vec256`1<System.UInt16>&,Z0.Vec256`1<System.UInt16>&)
    IL_001D: ret

}
Vec256<uint> vrotr(in Vec256<uint> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.UInt32> Z0.dinx::vsrl(Z0.Vec256`1<System.UInt32>&,System.Byte)
    IL_0007: stloc.0
    IL_0008: ldarg.0
    IL_0009: ldc.i4.s 32
    IL_000B: ldarg.1
    IL_000C: sub
    IL_000D: conv.u1
    IL_000E: call Z0.Vec256`1<System.UInt32> Z0.dinx::vsll(Z0.Vec256`1<System.UInt32>&,System.Byte)
    IL_0013: stloc.1
    IL_0014: ldloca.s V_0
    IL_0016: ldloca.s V_1
    IL_0018: call Z0.Vec256`1<System.UInt32> Z0.dinx::vor(Z0.Vec256`1<System.UInt32>&,Z0.Vec256`1<System.UInt32>&)
    IL_001D: ret

}
Vec256<ulong> vrotr(in Vec256<ulong> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.UInt64> Z0.dinx::vsrl(Z0.Vec256`1<System.UInt64>&,System.Byte)
    IL_0007: stloc.0
    IL_0008: ldarg.0
    IL_0009: ldc.i4.s 64
    IL_000B: ldarg.1
    IL_000C: sub
    IL_000D: conv.u1
    IL_000E: call Z0.Vec256`1<System.UInt64> Z0.dinx::vsll(Z0.Vec256`1<System.UInt64>&,System.Byte)
    IL_0013: stloc.1
    IL_0014: ldloca.s V_0
    IL_0016: ldloca.s V_1
    IL_0018: call Z0.Vec256`1<System.UInt64> Z0.dinx::vor(Z0.Vec256`1<System.UInt64>&,Z0.Vec256`1<System.UInt64>&)
    IL_001D: ret

}
Vec128<uint> rotr(in Vec128<uint> src, Vec128<uint> offsets)
{
    IL_0000: ldarg.0
    IL_0001: ldarga.s offsets
    IL_0003: call Z0.Vec128`1<System.UInt32> Z0.dinx::vsrlv(Z0.Vec128`1<System.UInt32>&,Z0.Vec128`1<System.UInt32>&)
    IL_0008: stloc.0
    IL_0009: ldarg.0
    IL_000A: ldsflda Z0.Vec128`1<System.UInt32> Z0.dinx::Vec128u32
    IL_000F: ldarga.s offsets
    IL_0011: call Z0.Vec128`1<System.UInt32> Z0.dinx::vsub(Z0.Vec128`1<System.UInt32>&,Z0.Vec128`1<System.UInt32>&)
    IL_0016: stloc.2
    IL_0017: ldloca.s V_2
    IL_0019: call Z0.Vec128`1<System.UInt32> Z0.dinx::vsllv(Z0.Vec128`1<System.UInt32>&,Z0.Vec128`1<System.UInt32>&)
    IL_001E: stloc.1
    IL_001F: ldloca.s V_0
    IL_0021: ldloca.s V_1
    IL_0023: call Z0.Vec128`1<System.UInt32> Z0.dinx::vor(Z0.Vec128`1<System.UInt32>&,Z0.Vec128`1<System.UInt32>&)
    IL_0028: ret

}
Vec128<ulong> rotr(in Vec128<ulong> src, in Vec128<ulong> offsets)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.UInt64> Z0.dinx::vsrlv(Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&)
    IL_0007: stloc.0
    IL_0008: ldarg.0
    IL_0009: ldsflda Z0.Vec128`1<System.UInt64> Z0.dinx::Vec128u64
    IL_000E: ldarg.1
    IL_000F: call Z0.Vec128`1<System.UInt64> Z0.dinx::vsub(Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&)
    IL_0014: stloc.2
    IL_0015: ldloca.s V_2
    IL_0017: call Z0.Vec128`1<System.UInt64> Z0.dinx::vsllv(Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&)
    IL_001C: stloc.1
    IL_001D: ldloca.s V_0
    IL_001F: ldloca.s V_1
    IL_0021: call Z0.Vec128`1<System.UInt64> Z0.dinx::vor(Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&)
    IL_0026: ret

}
Vec256<uint> rotr(in Vec256<uint> src, in Vec256<uint> offsets)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.UInt32> Z0.dinx::vsrlv(Z0.Vec256`1<System.UInt32>&,Z0.Vec256`1<System.UInt32>&)
    IL_0007: stloc.0
    IL_0008: ldarg.0
    IL_0009: ldsflda Z0.Vec256`1<System.UInt32> Z0.dinx::Vec256u32
    IL_000E: ldarg.1
    IL_000F: call Z0.Vec256`1<System.UInt32> Z0.dinx::vsub(Z0.Vec256`1<System.UInt32>&,Z0.Vec256`1<System.UInt32>&)
    IL_0014: stloc.2
    IL_0015: ldloca.s V_2
    IL_0017: call Z0.Vec256`1<System.UInt32> Z0.dinx::vsllv(Z0.Vec256`1<System.UInt32>&,Z0.Vec256`1<System.UInt32>&)
    IL_001C: stloc.1
    IL_001D: ldloca.s V_0
    IL_001F: ldloca.s V_1
    IL_0021: call Z0.Vec256`1<System.UInt32> Z0.dinx::vor(Z0.Vec256`1<System.UInt32>&,Z0.Vec256`1<System.UInt32>&)
    IL_0026: ret

}
Vec256<ulong> rotr(in Vec256<ulong> src, in Vec256<ulong> offsets)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.UInt64> Z0.dinx::vsrlv(Z0.Vec256`1<System.UInt64>&,Z0.Vec256`1<System.UInt64>&)
    IL_0007: stloc.0
    IL_0008: ldarg.0
    IL_0009: ldsflda Z0.Vec256`1<System.UInt64> Z0.dinx::Vec256u64
    IL_000E: ldarg.1
    IL_000F: call Z0.Vec256`1<System.UInt64> Z0.dinx::vsub(Z0.Vec256`1<System.UInt64>&,Z0.Vec256`1<System.UInt64>&)
    IL_0014: stloc.2
    IL_0015: ldloca.s V_2
    IL_0017: call Z0.Vec256`1<System.UInt64> Z0.dinx::vsllv(Z0.Vec256`1<System.UInt64>&,Z0.Vec256`1<System.UInt64>&)
    IL_001C: stloc.1
    IL_001D: ldloca.s V_0
    IL_001F: ldloca.s V_1
    IL_0021: call Z0.Vec256`1<System.UInt64> Z0.dinx::vor(Z0.Vec256`1<System.UInt64>&,Z0.Vec256`1<System.UInt64>&)
    IL_0026: ret

}
Vec128<ulong> vsllx(in Vec128<ulong> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.8
    IL_0002: call Z0.Vec128`1<System.UInt64> Z0.dinx::vbsll(Z0.Vec128`1<System.UInt64>&,System.Byte)
    IL_0007: stloc.0
    IL_0008: ldarg.0
    IL_0009: ldarg.1
    IL_000A: call Z0.Vec128`1<System.UInt64> Z0.dinx::vsll(Z0.Vec128`1<System.UInt64>&,System.Byte)
    IL_000F: stloc.1
    IL_0010: ldloca.s V_0
    IL_0012: ldc.i4.s 64
    IL_0014: ldarg.1
    IL_0015: sub
    IL_0016: conv.u1
    IL_0017: call Z0.Vec128`1<System.UInt64> Z0.dinx::vsrl(Z0.Vec128`1<System.UInt64>&,System.Byte)
    IL_001C: stloc.0
    IL_001D: ldloca.s V_1
    IL_001F: ldloca.s V_0
    IL_0021: call Z0.Vec128`1<System.UInt64> Z0.dinx::vor(Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&)
    IL_0026: ret

}
Vec128<ulong> vslrx(in Vec128<ulong> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.8
    IL_0002: call Z0.Vec128`1<System.UInt64> Z0.dinx::vbsrl(Z0.Vec128`1<System.UInt64>&,System.Byte)
    IL_0007: stloc.0
    IL_0008: ldarg.0
    IL_0009: ldarg.1
    IL_000A: call Z0.Vec128`1<System.UInt64> Z0.dinx::vsrl(Z0.Vec128`1<System.UInt64>&,System.Byte)
    IL_000F: stloc.1
    IL_0010: ldloca.s V_0
    IL_0012: ldc.i4.s 64
    IL_0014: ldarg.1
    IL_0015: sub
    IL_0016: conv.u1
    IL_0017: call Z0.Vec128`1<System.UInt64> Z0.dinx::vsll(Z0.Vec128`1<System.UInt64>&,System.Byte)
    IL_001C: stloc.0
    IL_001D: ldloca.s V_1
    IL_001F: ldloca.s V_0
    IL_0021: call Z0.Vec128`1<System.UInt64> Z0.dinx::vor(Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&)
    IL_0026: ret

}
Vec128<sbyte> vsll(in Vec128<sbyte> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldloca.s V_0
    IL_0003: call Z0.Vec256`1<System.Int16>& Z0.dinx::vconvert(Z0.Vec128`1<System.SByte>&,Z0.Vec256`1<System.Int16>&)
    IL_0008: pop
    IL_0009: ldsfld System.Int32 Z0.Vec256`1<System.Int16>::Length
    IL_000E: stloc.3
    IL_000F: ldloc.3
    IL_0010: conv.u
    IL_0011: ldc.i4.2
    IL_0012: mul.ovf.un
    IL_0013: localloc
    IL_0015: ldloc.3
    IL_0016: newobj System.Void System.Span`1<System.Int16>::.ctor(System.Void*,System.Int32)
    IL_001B: stloc.s V_4
    IL_001D: ldloc.s V_4
    IL_001F: stloc.1
    IL_0020: ldloca.s V_0
    IL_0022: ldarg.1
    IL_0023: call Z0.Vec256`1<System.Int16> Z0.dinx::vsll(Z0.Vec256`1<System.Int16>&,System.Byte)
    IL_0028: stloc.s V_5
    IL_002A: ldloca.s V_5
    IL_002C: ldloca.s V_1
    IL_002E: ldc.i4.0
    IL_002F: call System.Int16& System.Span`1<System.Int16>::get_Item(System.Int32)
    IL_0034: call System.Void zfunc::vstore<System.Int16>(Z0.Vec256`1<System.Int16>&,System.Int16&)
    IL_0039: ldc.i4.0
    IL_003A: stloc.2
    IL_003B: ldloca.s V_1
    IL_003D: ldloc.2
    IL_003E: dup
    IL_003F: ldc.i4.1
    IL_0040: add
    IL_0041: stloc.2
    IL_0042: call System.Int16& System.Span`1<System.Int16>::get_Item(System.Int32)
    IL_0047: ldind.i2
    IL_0048: conv.i1
    IL_0049: ldloca.s V_1
    IL_004B: ldloc.2
    IL_004C: dup
    IL_004D: ldc.i4.1
    IL_004E: add
    IL_004F: stloc.2
    IL_0050: call System.Int16& System.Span`1<System.Int16>::get_Item(System.Int32)
    IL_0055: ldind.i2
    IL_0056: conv.i1
    IL_0057: ldloca.s V_1
    IL_0059: ldloc.2
    IL_005A: dup
    IL_005B: ldc.i4.1
    IL_005C: add
    IL_005D: stloc.2
    IL_005E: call System.Int16& System.Span`1<System.Int16>::get_Item(System.Int32)
    IL_0063: ldind.i2
    IL_0064: conv.i1
    IL_0065: ldloca.s V_1
    IL_0067: ldloc.2
    IL_0068: dup
    IL_0069: ldc.i4.1
    IL_006A: add
    IL_006B: stloc.2
    IL_006C: call System.Int16& System.Span`1<System.Int16>::get_Item(System.Int32)
    IL_0071: ldind.i2
    IL_0072: conv.i1
    IL_0073: ldloca.s V_1
    IL_0075: ldloc.2
    IL_0076: dup
    IL_0077: ldc.i4.1
    IL_0078: add
    IL_0079: stloc.2
    IL_007A: call System.Int16& System.Span`1<System.Int16>::get_Item(System.Int32)
    IL_007F: ldind.i2
    IL_0080: conv.i1
    IL_0081: ldloca.s V_1
    IL_0083: ldloc.2
    IL_0084: dup
    IL_0085: ldc.i4.1
    IL_0086: add
    IL_0087: stloc.2
    IL_0088: call System.Int16& System.Span`1<System.Int16>::get_Item(System.Int32)
    IL_008D: ldind.i2
    IL_008E: conv.i1
    IL_008F: ldloca.s V_1
    IL_0091: ldloc.2
    IL_0092: dup
    IL_0093: ldc.i4.1
    IL_0094: add
    IL_0095: stloc.2
    IL_0096: call System.Int16& System.Span`1<System.Int16>::get_Item(System.Int32)
    IL_009B: ldind.i2
    IL_009C: conv.i1
    IL_009D: ldloca.s V_1
    IL_009F: ldloc.2
    IL_00A0: dup
    IL_00A1: ldc.i4.1
    IL_00A2: add
    IL_00A3: stloc.2
    IL_00A4: call System.Int16& System.Span`1<System.Int16>::get_Item(System.Int32)
    IL_00A9: ldind.i2
    IL_00AA: conv.i1
    IL_00AB: ldloca.s V_1
    IL_00AD: ldloc.2
    IL_00AE: dup
    IL_00AF: ldc.i4.1
    IL_00B0: add
    IL_00B1: stloc.2
    IL_00B2: call System.Int16& System.Span`1<System.Int16>::get_Item(System.Int32)
    IL_00B7: ldind.i2
    IL_00B8: conv.i1
    IL_00B9: ldloca.s V_1
    IL_00BB: ldloc.2
    IL_00BC: dup
    IL_00BD: ldc.i4.1
    IL_00BE: add
    IL_00BF: stloc.2
    IL_00C0: call System.Int16& System.Span`1<System.Int16>::get_Item(System.Int32)
    IL_00C5: ldind.i2
    IL_00C6: conv.i1
    IL_00C7: ldloca.s V_1
    IL_00C9: ldloc.2
    IL_00CA: dup
    IL_00CB: ldc.i4.1
    IL_00CC: add
    IL_00CD: stloc.2
    IL_00CE: call System.Int16& System.Span`1<System.Int16>::get_Item(System.Int32)
    IL_00D3: ldind.i2
    IL_00D4: conv.i1
    IL_00D5: ldloca.s V_1
    IL_00D7: ldloc.2
    IL_00D8: dup
    IL_00D9: ldc.i4.1
    IL_00DA: add
    IL_00DB: stloc.2
    IL_00DC: call System.Int16& System.Span`1<System.Int16>::get_Item(System.Int32)
    IL_00E1: ldind.i2
    IL_00E2: conv.i1
    IL_00E3: ldloca.s V_1
    IL_00E5: ldloc.2
    IL_00E6: dup
    IL_00E7: ldc.i4.1
    IL_00E8: add
    IL_00E9: stloc.2
    IL_00EA: call System.Int16& System.Span`1<System.Int16>::get_Item(System.Int32)
    IL_00EF: ldind.i2
    IL_00F0: conv.i1
    IL_00F1: ldloca.s V_1
    IL_00F3: ldloc.2
    IL_00F4: dup
    IL_00F5: ldc.i4.1
    IL_00F6: add
    IL_00F7: stloc.2
    IL_00F8: call System.Int16& System.Span`1<System.Int16>::get_Item(System.Int32)
    IL_00FD: ldind.i2
    IL_00FE: conv.i1
    IL_00FF: ldloca.s V_1
    IL_0101: ldloc.2
    IL_0102: dup
    IL_0103: ldc.i4.1
    IL_0104: add
    IL_0105: stloc.2
    IL_0106: call System.Int16& System.Span`1<System.Int16>::get_Item(System.Int32)
    IL_010B: ldind.i2
    IL_010C: conv.i1
    IL_010D: ldloca.s V_1
    IL_010F: ldloc.2
    IL_0110: dup
    IL_0111: ldc.i4.1
    IL_0112: add
    IL_0113: stloc.2
    IL_0114: call System.Int16& System.Span`1<System.Int16>::get_Item(System.Int32)
    IL_0119: ldind.i2
    IL_011A: conv.i1
    IL_011B: call Z0.Vec128`1<System.SByte> Z0.Vec128::FromParts(System.SByte,System.SByte,System.SByte,System.SByte,System.SByte,System.SByte,System.SByte,System.SByte,System.SByte,System.SByte,System.SByte,System.SByte,System.SByte,System.SByte,System.SByte,System.SByte)
    IL_0120: ret

}
Vec256<ushort> get_VByteMask()
{
    IL_0000: ldc.i4 255
    IL_0005: call Z0.Vec256`1<System.UInt16> Z0.dinx::vbroadcast256(System.UInt16)
    IL_000A: ret

}
Vec256<ushort> vsll_2(in Vec128<byte> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldloca.s V_0
    IL_0003: call Z0.Vec256`1<System.UInt16>& Z0.dinx::vconvert(Z0.Vec128`1<System.Byte>&,Z0.Vec256`1<System.UInt16>&)
    IL_0008: pop
    IL_0009: ldloca.s V_0
    IL_000B: ldarg.1
    IL_000C: call Z0.Vec256`1<System.UInt16> Z0.dinx::vsll(Z0.Vec256`1<System.UInt16>&,System.Byte)
    IL_0011: stloc.2
    IL_0012: ldloca.s V_2
    IL_0014: call Z0.Vec256`1<System.UInt16> Z0.dinx::get_VByteMask()
    IL_0019: stloc.3
    IL_001A: ldloca.s V_3
    IL_001C: call Z0.Vec256`1<System.UInt16> Z0.dinx::vand(Z0.Vec256`1<System.UInt16>&,Z0.Vec256`1<System.UInt16>&)
    IL_0021: stloc.1
    IL_0022: ldloc.1
    IL_0023: ret

}
Vec128<byte> vsll(in Vec128<byte> src, byte offset)
{
    IL_0000: ldsfld System.Int32 Z0.Vec256`1<System.UInt16>::Length
    IL_0005: stloc.3
    IL_0006: ldloc.3
    IL_0007: conv.u
    IL_0008: ldc.i4.2
    IL_0009: mul.ovf.un
    IL_000A: localloc
    IL_000C: ldloc.3
    IL_000D: newobj System.Void System.Span`1<System.UInt16>::.ctor(System.Void*,System.Int32)
    IL_0012: stloc.s V_4
    IL_0014: ldloc.s V_4
    IL_0016: stloc.0
    IL_0017: ldarg.0
    IL_0018: ldloca.s V_1
    IL_001A: call Z0.Vec256`1<System.UInt16>& Z0.dinx::vconvert(Z0.Vec128`1<System.Byte>&,Z0.Vec256`1<System.UInt16>&)
    IL_001F: pop
    IL_0020: ldloca.s V_1
    IL_0022: ldarg.1
    IL_0023: call Z0.Vec256`1<System.UInt16> Z0.dinx::vsll(Z0.Vec256`1<System.UInt16>&,System.Byte)
    IL_0028: stloc.s V_5
    IL_002A: ldloca.s V_5
    IL_002C: ldloca.s V_0
    IL_002E: ldc.i4.0
    IL_002F: call System.UInt16& System.Span`1<System.UInt16>::get_Item(System.Int32)
    IL_0034: call System.Void zfunc::vstore<System.UInt16>(Z0.Vec256`1<System.UInt16>&,System.UInt16&)
    IL_0039: ldc.i4.0
    IL_003A: stloc.2
    IL_003B: ldloca.s V_0
    IL_003D: ldloc.2
    IL_003E: dup
    IL_003F: ldc.i4.1
    IL_0040: add
    IL_0041: stloc.2
    IL_0042: call System.UInt16& System.Span`1<System.UInt16>::get_Item(System.Int32)
    IL_0047: ldind.u2
    IL_0048: conv.u1
    IL_0049: ldloca.s V_0
    IL_004B: ldloc.2
    IL_004C: dup
    IL_004D: ldc.i4.1
    IL_004E: add
    IL_004F: stloc.2
    IL_0050: call System.UInt16& System.Span`1<System.UInt16>::get_Item(System.Int32)
    IL_0055: ldind.u2
    IL_0056: conv.u1
    IL_0057: ldloca.s V_0
    IL_0059: ldloc.2
    IL_005A: dup
    IL_005B: ldc.i4.1
    IL_005C: add
    IL_005D: stloc.2
    IL_005E: call System.UInt16& System.Span`1<System.UInt16>::get_Item(System.Int32)
    IL_0063: ldind.u2
    IL_0064: conv.u1
    IL_0065: ldloca.s V_0
    IL_0067: ldloc.2
    IL_0068: dup
    IL_0069: ldc.i4.1
    IL_006A: add
    IL_006B: stloc.2
    IL_006C: call System.UInt16& System.Span`1<System.UInt16>::get_Item(System.Int32)
    IL_0071: ldind.u2
    IL_0072: conv.u1
    IL_0073: ldloca.s V_0
    IL_0075: ldloc.2
    IL_0076: dup
    IL_0077: ldc.i4.1
    IL_0078: add
    IL_0079: stloc.2
    IL_007A: call System.UInt16& System.Span`1<System.UInt16>::get_Item(System.Int32)
    IL_007F: ldind.u2
    IL_0080: conv.u1
    IL_0081: ldloca.s V_0
    IL_0083: ldloc.2
    IL_0084: dup
    IL_0085: ldc.i4.1
    IL_0086: add
    IL_0087: stloc.2
    IL_0088: call System.UInt16& System.Span`1<System.UInt16>::get_Item(System.Int32)
    IL_008D: ldind.u2
    IL_008E: conv.u1
    IL_008F: ldloca.s V_0
    IL_0091: ldloc.2
    IL_0092: dup
    IL_0093: ldc.i4.1
    IL_0094: add
    IL_0095: stloc.2
    IL_0096: call System.UInt16& System.Span`1<System.UInt16>::get_Item(System.Int32)
    IL_009B: ldind.u2
    IL_009C: conv.u1
    IL_009D: ldloca.s V_0
    IL_009F: ldloc.2
    IL_00A0: dup
    IL_00A1: ldc.i4.1
    IL_00A2: add
    IL_00A3: stloc.2
    IL_00A4: call System.UInt16& System.Span`1<System.UInt16>::get_Item(System.Int32)
    IL_00A9: ldind.u2
    IL_00AA: conv.u1
    IL_00AB: ldloca.s V_0
    IL_00AD: ldloc.2
    IL_00AE: dup
    IL_00AF: ldc.i4.1
    IL_00B0: add
    IL_00B1: stloc.2
    IL_00B2: call System.UInt16& System.Span`1<System.UInt16>::get_Item(System.Int32)
    IL_00B7: ldind.u2
    IL_00B8: conv.u1
    IL_00B9: ldloca.s V_0
    IL_00BB: ldloc.2
    IL_00BC: dup
    IL_00BD: ldc.i4.1
    IL_00BE: add
    IL_00BF: stloc.2
    IL_00C0: call System.UInt16& System.Span`1<System.UInt16>::get_Item(System.Int32)
    IL_00C5: ldind.u2
    IL_00C6: conv.u1
    IL_00C7: ldloca.s V_0
    IL_00C9: ldloc.2
    IL_00CA: dup
    IL_00CB: ldc.i4.1
    IL_00CC: add
    IL_00CD: stloc.2
    IL_00CE: call System.UInt16& System.Span`1<System.UInt16>::get_Item(System.Int32)
    IL_00D3: ldind.u2
    IL_00D4: conv.u1
    IL_00D5: ldloca.s V_0
    IL_00D7: ldloc.2
    IL_00D8: dup
    IL_00D9: ldc.i4.1
    IL_00DA: add
    IL_00DB: stloc.2
    IL_00DC: call System.UInt16& System.Span`1<System.UInt16>::get_Item(System.Int32)
    IL_00E1: ldind.u2
    IL_00E2: conv.u1
    IL_00E3: ldloca.s V_0
    IL_00E5: ldloc.2
    IL_00E6: dup
    IL_00E7: ldc.i4.1
    IL_00E8: add
    IL_00E9: stloc.2
    IL_00EA: call System.UInt16& System.Span`1<System.UInt16>::get_Item(System.Int32)
    IL_00EF: ldind.u2
    IL_00F0: conv.u1
    IL_00F1: ldloca.s V_0
    IL_00F3: ldloc.2
    IL_00F4: dup
    IL_00F5: ldc.i4.1
    IL_00F6: add
    IL_00F7: stloc.2
    IL_00F8: call System.UInt16& System.Span`1<System.UInt16>::get_Item(System.Int32)
    IL_00FD: ldind.u2
    IL_00FE: conv.u1
    IL_00FF: ldloca.s V_0
    IL_0101: ldloc.2
    IL_0102: dup
    IL_0103: ldc.i4.1
    IL_0104: add
    IL_0105: stloc.2
    IL_0106: call System.UInt16& System.Span`1<System.UInt16>::get_Item(System.Int32)
    IL_010B: ldind.u2
    IL_010C: conv.u1
    IL_010D: ldloca.s V_0
    IL_010F: ldloc.2
    IL_0110: dup
    IL_0111: ldc.i4.1
    IL_0112: add
    IL_0113: stloc.2
    IL_0114: call System.UInt16& System.Span`1<System.UInt16>::get_Item(System.Int32)
    IL_0119: ldind.u2
    IL_011A: conv.u1
    IL_011B: call Z0.Vec128`1<System.Byte> Z0.Vec128::FromBytes(System.Byte,System.Byte,System.Byte,System.Byte,System.Byte,System.Byte,System.Byte,System.Byte,System.Byte,System.Byte,System.Byte,System.Byte,System.Byte,System.Byte,System.Byte,System.Byte)
    IL_0120: ret

}
Vec128<short> vsll(in Vec128<short> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::xmm
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::ShiftLeftLogical(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Byte)
    IL_000C: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0011: ret

}
Vec128<ushort> vsll(in Vec128<ushort> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::xmm
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::ShiftLeftLogical(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Byte)
    IL_000C: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0011: ret

}
Vec128<int> vsll(in Vec128<int> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::xmm
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::ShiftLeftLogical(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Byte)
    IL_000C: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0011: ret

}
Vec128<uint> vsll(in Vec128<uint> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::xmm
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::ShiftLeftLogical(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Byte)
    IL_000C: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0011: ret

}
Vec128<long> vsll(in Vec128<long> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::xmm
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse2::ShiftLeftLogical(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Byte)
    IL_000C: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0011: ret

}
Vec128<ulong> vsll(in Vec128<ulong> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::xmm
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::ShiftLeftLogical(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Byte)
    IL_000C: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0011: ret

}
Vec256<byte> vsll(in Vec256<byte> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.Byte> Z0.dinx::vlo(Z0.Vec256`1<System.Byte>&)
    IL_0006: stloc.s V_11
    IL_0008: ldloca.s V_11
    IL_000A: ldloca.s V_10
    IL_000C: call Z0.Vec256`1<System.UInt16>& Z0.dinx::vconvert(Z0.Vec128`1<System.Byte>&,Z0.Vec256`1<System.UInt16>&)
    IL_0011: ldobj Z0.Vec256`1<System.UInt16>
    IL_0016: stloc.0
    IL_0017: ldarg.0
    IL_0018: call Z0.Vec128`1<System.Byte> Z0.dinx::vhi(Z0.Vec256`1<System.Byte>&)
    IL_001D: stloc.s V_11
    IL_001F: ldloca.s V_11
    IL_0021: ldloca.s V_10
    IL_0023: call Z0.Vec256`1<System.UInt16>& Z0.dinx::vconvert(Z0.Vec128`1<System.Byte>&,Z0.Vec256`1<System.UInt16>&)
    IL_0028: ldobj Z0.Vec256`1<System.UInt16>
    IL_002D: stloc.1
    IL_002E: ldloca.s V_0
    IL_0030: ldarg.1
    IL_0031: call Z0.Vec256`1<System.UInt16> Z0.dinx::vsll(Z0.Vec256`1<System.UInt16>&,System.Byte)
    IL_0036: stloc.s V_10
    IL_0038: ldloca.s V_10
    IL_003A: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.UInt16>::As<System.Byte>()
    IL_003F: stloc.2
    IL_0040: ldloca.s V_1
    IL_0042: ldarg.1
    IL_0043: call Z0.Vec256`1<System.UInt16> Z0.dinx::vsll(Z0.Vec256`1<System.UInt16>&,System.Byte)
    IL_0048: stloc.s V_10
    IL_004A: ldloca.s V_10
    IL_004C: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.UInt16>::As<System.Byte>()
    IL_0051: stloc.3
    IL_0052: call Z0.Vec256`1<System.Byte> Z0.Vec256Pattern::ClearAlt<System.Byte>()
    IL_0057: stloc.s V_4
    IL_0059: ldloca.s V_2
    IL_005B: ldloca.s V_4
    IL_005D: call Z0.Vec256`1<System.Byte> Z0.dinx::vshuffle(Z0.Vec256`1<System.Byte>&,Z0.Vec256`1<System.Byte>&)
    IL_0062: stloc.s V_5
    IL_0064: ldloca.s V_3
    IL_0066: ldloca.s V_4
    IL_0068: call Z0.Vec256`1<System.Byte> Z0.dinx::vshuffle(Z0.Vec256`1<System.Byte>&,Z0.Vec256`1<System.Byte>&)
    IL_006D: stloc.s V_6
    IL_006F: call Z0.Vec256`1<System.Byte> Z0.Vec256Pattern::LaneMerge<System.Byte>()
    IL_0074: stloc.s V_7
    IL_0076: ldloca.s V_5
    IL_0078: ldloca.s V_7
    IL_007A: call Z0.Vec256`1<System.Byte> Z0.dinx::vpermvar32x8(Z0.Vec256`1<System.Byte>&,Z0.Vec256`1<System.Byte>&)
    IL_007F: stloc.s V_8
    IL_0081: ldloca.s V_6
    IL_0083: ldloca.s V_7
    IL_0085: call Z0.Vec256`1<System.Byte> Z0.dinx::vpermvar32x8(Z0.Vec256`1<System.Byte>&,Z0.Vec256`1<System.Byte>&)
    IL_008A: stloc.s V_9
    IL_008C: ldloca.s V_8
    IL_008E: call Z0.Vec128`1<System.Byte> Z0.dinx::vlo(Z0.Vec256`1<System.Byte>&)
    IL_0093: stloc.s V_11
    IL_0095: ldloca.s V_11
    IL_0097: ldloca.s V_9
    IL_0099: call Z0.Vec128`1<System.Byte> Z0.dinx::vlo(Z0.Vec256`1<System.Byte>&)
    IL_009E: stloc.s V_13
    IL_00A0: ldloca.s V_13
    IL_00A2: ldloca.s V_12
    IL_00A4: call Z0.Vec256`1<System.Byte>& Z0.dinx::insert(Z0.Vec128`1<System.Byte>&,Z0.Vec128`1<System.Byte>&,Z0.Vec256`1<System.Byte>&)
    IL_00A9: ldobj Z0.Vec256`1<System.Byte>
    IL_00AE: ret

}
Vec256<short> vsll(in Vec256<short> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::ymm
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::ShiftLeftLogical(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Byte)
    IL_000C: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0011: ret

}
Vec256<ushort> vsll(in Vec256<ushort> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::ymm
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::ShiftLeftLogical(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Byte)
    IL_000C: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0011: ret

}
Vec256<int> vsll(in Vec256<int> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::ymm
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::ShiftLeftLogical(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Byte)
    IL_000C: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: ret

}
Vec256<uint> vsll(in Vec256<uint> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::ymm
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::ShiftLeftLogical(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Byte)
    IL_000C: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0011: ret

}
Vec256<long> vsll(in Vec256<long> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::ymm
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::ShiftLeftLogical(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Byte)
    IL_000C: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0011: ret

}
Vec256<ulong> vsll(in Vec256<ulong> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::ymm
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::ShiftLeftLogical(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Byte)
    IL_000C: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0011: ret

}
Vec128<int> vsllv(in Vec128<int> src, in Vec128<uint> offset)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::ShiftLeftLogicalVariable(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0011: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0016: ret

}
Vec128<uint> vsllv(in Vec128<uint> src, in Vec128<uint> offset)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::ShiftLeftLogicalVariable(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0011: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0016: ret

}
Vec128<long> vsllv(in Vec128<long> src, in Vec128<ulong> offset)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::ShiftLeftLogicalVariable(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0011: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0016: ret

}
Vec128<ulong> vsllv(in Vec128<ulong> src, in Vec128<ulong> offset)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::ShiftLeftLogicalVariable(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0011: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0016: ret

}
Vec256<int> vsllv(in Vec256<int> src, in Vec256<uint> offset)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::ShiftLeftLogicalVariable(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0011: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0016: ret

}
Vec256<uint> vsllv(in Vec256<uint> src, in Vec256<uint> offset)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::ShiftLeftLogicalVariable(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0011: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0016: ret

}
Vec256<long> vsllv(in Vec256<long> src, in Vec256<ulong> offset)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::ShiftLeftLogicalVariable(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0011: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0016: ret

}
Vec256<ulong> vsllv(in Vec256<ulong> src, in Vec256<ulong> offset)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::ShiftLeftLogicalVariable(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0011: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0016: ret

}
Vec256<short> vsra(in Vec256<short> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::ShiftRightArithmetic(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Byte)
    IL_0011: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0016: ret

}
Vec256<int> vsra(in Vec256<int> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::ShiftRightArithmetic(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Byte)
    IL_0011: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0016: ret

}
Vec128<int> vsrav(in Vec128<int> src, in Vec128<uint> control)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt32>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::ShiftRightArithmeticVariable(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_001B: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0020: ret

}
Vec256<int> vsrav(in Vec256<int> src, in Vec256<uint> control)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.UInt32>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::ShiftRightArithmeticVariable(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_001B: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0020: ret

}
Vec128<sbyte> vsrl(in Vec128<sbyte> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldloca.s V_0
    IL_0003: call Z0.Vec256`1<System.Int16>& Z0.dinx::vconvert(Z0.Vec128`1<System.SByte>&,Z0.Vec256`1<System.Int16>&)
    IL_0008: pop
    IL_0009: ldsfld System.Int32 Z0.Vec256`1<System.Int16>::Length
    IL_000E: stloc.3
    IL_000F: ldloc.3
    IL_0010: conv.u
    IL_0011: ldc.i4.2
    IL_0012: mul.ovf.un
    IL_0013: localloc
    IL_0015: ldloc.3
    IL_0016: newobj System.Void System.Span`1<System.Int16>::.ctor(System.Void*,System.Int32)
    IL_001B: stloc.s V_4
    IL_001D: ldloc.s V_4
    IL_001F: stloc.1
    IL_0020: ldloca.s V_0
    IL_0022: ldarg.1
    IL_0023: call Z0.Vec256`1<System.Int16> Z0.dinx::vsrl(Z0.Vec256`1<System.Int16>&,System.Byte)
    IL_0028: stloc.s V_5
    IL_002A: ldloca.s V_5
    IL_002C: ldloca.s V_1
    IL_002E: ldc.i4.0
    IL_002F: call System.Int16& System.Span`1<System.Int16>::get_Item(System.Int32)
    IL_0034: call System.Void zfunc::vstore<System.Int16>(Z0.Vec256`1<System.Int16>&,System.Int16&)
    IL_0039: ldc.i4.0
    IL_003A: stloc.2
    IL_003B: ldloca.s V_1
    IL_003D: ldloc.2
    IL_003E: dup
    IL_003F: ldc.i4.1
    IL_0040: add
    IL_0041: stloc.2
    IL_0042: call System.Int16& System.Span`1<System.Int16>::get_Item(System.Int32)
    IL_0047: ldind.i2
    IL_0048: conv.i1
    IL_0049: ldloca.s V_1
    IL_004B: ldloc.2
    IL_004C: dup
    IL_004D: ldc.i4.1
    IL_004E: add
    IL_004F: stloc.2
    IL_0050: call System.Int16& System.Span`1<System.Int16>::get_Item(System.Int32)
    IL_0055: ldind.i2
    IL_0056: conv.i1
    IL_0057: ldloca.s V_1
    IL_0059: ldloc.2
    IL_005A: dup
    IL_005B: ldc.i4.1
    IL_005C: add
    IL_005D: stloc.2
    IL_005E: call System.Int16& System.Span`1<System.Int16>::get_Item(System.Int32)
    IL_0063: ldind.i2
    IL_0064: conv.i1
    IL_0065: ldloca.s V_1
    IL_0067: ldloc.2
    IL_0068: dup
    IL_0069: ldc.i4.1
    IL_006A: add
    IL_006B: stloc.2
    IL_006C: call System.Int16& System.Span`1<System.Int16>::get_Item(System.Int32)
    IL_0071: ldind.i2
    IL_0072: conv.i1
    IL_0073: ldloca.s V_1
    IL_0075: ldloc.2
    IL_0076: dup
    IL_0077: ldc.i4.1
    IL_0078: add
    IL_0079: stloc.2
    IL_007A: call System.Int16& System.Span`1<System.Int16>::get_Item(System.Int32)
    IL_007F: ldind.i2
    IL_0080: conv.i1
    IL_0081: ldloca.s V_1
    IL_0083: ldloc.2
    IL_0084: dup
    IL_0085: ldc.i4.1
    IL_0086: add
    IL_0087: stloc.2
    IL_0088: call System.Int16& System.Span`1<System.Int16>::get_Item(System.Int32)
    IL_008D: ldind.i2
    IL_008E: conv.i1
    IL_008F: ldloca.s V_1
    IL_0091: ldloc.2
    IL_0092: dup
    IL_0093: ldc.i4.1
    IL_0094: add
    IL_0095: stloc.2
    IL_0096: call System.Int16& System.Span`1<System.Int16>::get_Item(System.Int32)
    IL_009B: ldind.i2
    IL_009C: conv.i1
    IL_009D: ldloca.s V_1
    IL_009F: ldloc.2
    IL_00A0: dup
    IL_00A1: ldc.i4.1
    IL_00A2: add
    IL_00A3: stloc.2
    IL_00A4: call System.Int16& System.Span`1<System.Int16>::get_Item(System.Int32)
    IL_00A9: ldind.i2
    IL_00AA: conv.i1
    IL_00AB: ldloca.s V_1
    IL_00AD: ldloc.2
    IL_00AE: dup
    IL_00AF: ldc.i4.1
    IL_00B0: add
    IL_00B1: stloc.2
    IL_00B2: call System.Int16& System.Span`1<System.Int16>::get_Item(System.Int32)
    IL_00B7: ldind.i2
    IL_00B8: conv.i1
    IL_00B9: ldloca.s V_1
    IL_00BB: ldloc.2
    IL_00BC: dup
    IL_00BD: ldc.i4.1
    IL_00BE: add
    IL_00BF: stloc.2
    IL_00C0: call System.Int16& System.Span`1<System.Int16>::get_Item(System.Int32)
    IL_00C5: ldind.i2
    IL_00C6: conv.i1
    IL_00C7: ldloca.s V_1
    IL_00C9: ldloc.2
    IL_00CA: dup
    IL_00CB: ldc.i4.1
    IL_00CC: add
    IL_00CD: stloc.2
    IL_00CE: call System.Int16& System.Span`1<System.Int16>::get_Item(System.Int32)
    IL_00D3: ldind.i2
    IL_00D4: conv.i1
    IL_00D5: ldloca.s V_1
    IL_00D7: ldloc.2
    IL_00D8: dup
    IL_00D9: ldc.i4.1
    IL_00DA: add
    IL_00DB: stloc.2
    IL_00DC: call System.Int16& System.Span`1<System.Int16>::get_Item(System.Int32)
    IL_00E1: ldind.i2
    IL_00E2: conv.i1
    IL_00E3: ldloca.s V_1
    IL_00E5: ldloc.2
    IL_00E6: dup
    IL_00E7: ldc.i4.1
    IL_00E8: add
    IL_00E9: stloc.2
    IL_00EA: call System.Int16& System.Span`1<System.Int16>::get_Item(System.Int32)
    IL_00EF: ldind.i2
    IL_00F0: conv.i1
    IL_00F1: ldloca.s V_1
    IL_00F3: ldloc.2
    IL_00F4: dup
    IL_00F5: ldc.i4.1
    IL_00F6: add
    IL_00F7: stloc.2
    IL_00F8: call System.Int16& System.Span`1<System.Int16>::get_Item(System.Int32)
    IL_00FD: ldind.i2
    IL_00FE: conv.i1
    IL_00FF: ldloca.s V_1
    IL_0101: ldloc.2
    IL_0102: dup
    IL_0103: ldc.i4.1
    IL_0104: add
    IL_0105: stloc.2
    IL_0106: call System.Int16& System.Span`1<System.Int16>::get_Item(System.Int32)
    IL_010B: ldind.i2
    IL_010C: conv.i1
    IL_010D: ldloca.s V_1
    IL_010F: ldloc.2
    IL_0110: dup
    IL_0111: ldc.i4.1
    IL_0112: add
    IL_0113: stloc.2
    IL_0114: call System.Int16& System.Span`1<System.Int16>::get_Item(System.Int32)
    IL_0119: ldind.i2
    IL_011A: conv.i1
    IL_011B: call Z0.Vec128`1<System.SByte> Z0.Vec128::FromParts(System.SByte,System.SByte,System.SByte,System.SByte,System.SByte,System.SByte,System.SByte,System.SByte,System.SByte,System.SByte,System.SByte,System.SByte,System.SByte,System.SByte,System.SByte,System.SByte)
    IL_0120: ret

}
Vec128<byte> vsrl(in Vec128<byte> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldloca.s V_0
    IL_0003: call Z0.Vec256`1<System.UInt16>& Z0.dinx::vconvert(Z0.Vec128`1<System.Byte>&,Z0.Vec256`1<System.UInt16>&)
    IL_0008: pop
    IL_0009: ldsfld System.Int32 Z0.Vec256`1<System.UInt16>::Length
    IL_000E: stloc.3
    IL_000F: ldloc.3
    IL_0010: conv.u
    IL_0011: ldc.i4.2
    IL_0012: mul.ovf.un
    IL_0013: localloc
    IL_0015: ldloc.3
    IL_0016: newobj System.Void System.Span`1<System.UInt16>::.ctor(System.Void*,System.Int32)
    IL_001B: stloc.s V_4
    IL_001D: ldloc.s V_4
    IL_001F: stloc.1
    IL_0020: ldloca.s V_0
    IL_0022: ldarg.1
    IL_0023: call Z0.Vec256`1<System.UInt16> Z0.dinx::vsrl(Z0.Vec256`1<System.UInt16>&,System.Byte)
    IL_0028: stloc.s V_5
    IL_002A: ldloca.s V_5
    IL_002C: ldloca.s V_1
    IL_002E: ldc.i4.0
    IL_002F: call System.UInt16& System.Span`1<System.UInt16>::get_Item(System.Int32)
    IL_0034: call System.Void zfunc::vstore<System.UInt16>(Z0.Vec256`1<System.UInt16>&,System.UInt16&)
    IL_0039: ldc.i4.0
    IL_003A: stloc.2
    IL_003B: ldloca.s V_1
    IL_003D: ldloc.2
    IL_003E: dup
    IL_003F: ldc.i4.1
    IL_0040: add
    IL_0041: stloc.2
    IL_0042: call System.UInt16& System.Span`1<System.UInt16>::get_Item(System.Int32)
    IL_0047: ldind.u2
    IL_0048: conv.u1
    IL_0049: ldloca.s V_1
    IL_004B: ldloc.2
    IL_004C: dup
    IL_004D: ldc.i4.1
    IL_004E: add
    IL_004F: stloc.2
    IL_0050: call System.UInt16& System.Span`1<System.UInt16>::get_Item(System.Int32)
    IL_0055: ldind.u2
    IL_0056: conv.u1
    IL_0057: ldloca.s V_1
    IL_0059: ldloc.2
    IL_005A: dup
    IL_005B: ldc.i4.1
    IL_005C: add
    IL_005D: stloc.2
    IL_005E: call System.UInt16& System.Span`1<System.UInt16>::get_Item(System.Int32)
    IL_0063: ldind.u2
    IL_0064: conv.u1
    IL_0065: ldloca.s V_1
    IL_0067: ldloc.2
    IL_0068: dup
    IL_0069: ldc.i4.1
    IL_006A: add
    IL_006B: stloc.2
    IL_006C: call System.UInt16& System.Span`1<System.UInt16>::get_Item(System.Int32)
    IL_0071: ldind.u2
    IL_0072: conv.u1
    IL_0073: ldloca.s V_1
    IL_0075: ldloc.2
    IL_0076: dup
    IL_0077: ldc.i4.1
    IL_0078: add
    IL_0079: stloc.2
    IL_007A: call System.UInt16& System.Span`1<System.UInt16>::get_Item(System.Int32)
    IL_007F: ldind.u2
    IL_0080: conv.u1
    IL_0081: ldloca.s V_1
    IL_0083: ldloc.2
    IL_0084: dup
    IL_0085: ldc.i4.1
    IL_0086: add
    IL_0087: stloc.2
    IL_0088: call System.UInt16& System.Span`1<System.UInt16>::get_Item(System.Int32)
    IL_008D: ldind.u2
    IL_008E: conv.u1
    IL_008F: ldloca.s V_1
    IL_0091: ldloc.2
    IL_0092: dup
    IL_0093: ldc.i4.1
    IL_0094: add
    IL_0095: stloc.2
    IL_0096: call System.UInt16& System.Span`1<System.UInt16>::get_Item(System.Int32)
    IL_009B: ldind.u2
    IL_009C: conv.u1
    IL_009D: ldloca.s V_1
    IL_009F: ldloc.2
    IL_00A0: dup
    IL_00A1: ldc.i4.1
    IL_00A2: add
    IL_00A3: stloc.2
    IL_00A4: call System.UInt16& System.Span`1<System.UInt16>::get_Item(System.Int32)
    IL_00A9: ldind.u2
    IL_00AA: conv.u1
    IL_00AB: ldloca.s V_1
    IL_00AD: ldloc.2
    IL_00AE: dup
    IL_00AF: ldc.i4.1
    IL_00B0: add
    IL_00B1: stloc.2
    IL_00B2: call System.UInt16& System.Span`1<System.UInt16>::get_Item(System.Int32)
    IL_00B7: ldind.u2
    IL_00B8: conv.u1
    IL_00B9: ldloca.s V_1
    IL_00BB: ldloc.2
    IL_00BC: dup
    IL_00BD: ldc.i4.1
    IL_00BE: add
    IL_00BF: stloc.2
    IL_00C0: call System.UInt16& System.Span`1<System.UInt16>::get_Item(System.Int32)
    IL_00C5: ldind.u2
    IL_00C6: conv.u1
    IL_00C7: ldloca.s V_1
    IL_00C9: ldloc.2
    IL_00CA: dup
    IL_00CB: ldc.i4.1
    IL_00CC: add
    IL_00CD: stloc.2
    IL_00CE: call System.UInt16& System.Span`1<System.UInt16>::get_Item(System.Int32)
    IL_00D3: ldind.u2
    IL_00D4: conv.u1
    IL_00D5: ldloca.s V_1
    IL_00D7: ldloc.2
    IL_00D8: dup
    IL_00D9: ldc.i4.1
    IL_00DA: add
    IL_00DB: stloc.2
    IL_00DC: call System.UInt16& System.Span`1<System.UInt16>::get_Item(System.Int32)
    IL_00E1: ldind.u2
    IL_00E2: conv.u1
    IL_00E3: ldloca.s V_1
    IL_00E5: ldloc.2
    IL_00E6: dup
    IL_00E7: ldc.i4.1
    IL_00E8: add
    IL_00E9: stloc.2
    IL_00EA: call System.UInt16& System.Span`1<System.UInt16>::get_Item(System.Int32)
    IL_00EF: ldind.u2
    IL_00F0: conv.u1
    IL_00F1: ldloca.s V_1
    IL_00F3: ldloc.2
    IL_00F4: dup
    IL_00F5: ldc.i4.1
    IL_00F6: add
    IL_00F7: stloc.2
    IL_00F8: call System.UInt16& System.Span`1<System.UInt16>::get_Item(System.Int32)
    IL_00FD: ldind.u2
    IL_00FE: conv.u1
    IL_00FF: ldloca.s V_1
    IL_0101: ldloc.2
    IL_0102: dup
    IL_0103: ldc.i4.1
    IL_0104: add
    IL_0105: stloc.2
    IL_0106: call System.UInt16& System.Span`1<System.UInt16>::get_Item(System.Int32)
    IL_010B: ldind.u2
    IL_010C: conv.u1
    IL_010D: ldloca.s V_1
    IL_010F: ldloc.2
    IL_0110: dup
    IL_0111: ldc.i4.1
    IL_0112: add
    IL_0113: stloc.2
    IL_0114: call System.UInt16& System.Span`1<System.UInt16>::get_Item(System.Int32)
    IL_0119: ldind.u2
    IL_011A: conv.u1
    IL_011B: call Z0.Vec128`1<System.Byte> Z0.Vec128::FromBytes(System.Byte,System.Byte,System.Byte,System.Byte,System.Byte,System.Byte,System.Byte,System.Byte,System.Byte,System.Byte,System.Byte,System.Byte,System.Byte,System.Byte,System.Byte,System.Byte)
    IL_0120: ret

}
Vec128<short> vsrl(in Vec128<short> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::xmm
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::ShiftRightLogical(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Byte)
    IL_000C: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0011: ret

}
Vec128<ushort> vsrl(in Vec128<ushort> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::xmm
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::ShiftRightLogical(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Byte)
    IL_000C: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0011: ret

}
Vec128<int> vsrl(in Vec128<int> src, byte offset)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::xmm
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::ShiftRightLogical(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Byte)
    IL_000C: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0011: ret

}
Vector128<byte> vand(Vector128<byte> x, Vector128<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::And(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0007: ret

}
Vector128<short> vand(Vector128<short> x, Vector128<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::And(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0007: ret

}
Vector128<sbyte> vand(Vector128<sbyte> x, Vector128<sbyte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::And(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0007: ret

}
Vector128<ushort> vand(Vector128<ushort> x, Vector128<ushort> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::And(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0007: ret

}
Vector128<int> vand(Vector128<int> x, Vector128<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::And(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0007: ret

}
Vector128<uint> vand(Vector128<uint> x, Vector128<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::And(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0007: ret

}
Vector128<long> vand(Vector128<long> x, Vector128<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse2::And(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0007: ret

}
Vector128<ulong> vand(Vector128<ulong> x, Vector128<ulong> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::And(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0007: ret

}
Vector256<byte> vand(Vector256<byte> x, Vector256<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::And(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0007: ret

}
Vector256<short> vand(Vector256<short> x, Vector256<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::And(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0007: ret

}
Vector256<sbyte> vand(Vector256<sbyte> x, Vector256<sbyte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::And(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0007: ret

}
Vector256<ushort> vand(Vector256<ushort> x, Vector256<ushort> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::And(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0007: ret

}
Vector256<int> vand(Vector256<int> x, Vector256<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::And(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0007: ret

}
Vector256<uint> vand(Vector256<uint> x, Vector256<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::And(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0007: ret

}
Vector256<long> vand(Vector256<long> x, Vector256<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::And(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0007: ret

}
Vector256<ulong> vand(Vector256<ulong> x, Vector256<ulong> y)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::And(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0007: ret

}
Vec128<sbyte> vandn(in Vec128<sbyte> x, in Vec128<sbyte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::AndNot(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0011: call Z0.Vec128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0016: ret

}
Vec128<byte> vandn(in Vec128<byte> x, in Vec128<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::AndNot(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0011: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0016: ret

}
Vec128<short> vandn(in Vec128<short> x, in Vec128<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::AndNot(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0011: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0016: ret

}
Vec128<ushort> vandn(in Vec128<ushort> x, in Vec128<ushort> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::AndNot(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0011: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0016: ret

}
Vec128<int> vandn(in Vec128<int> x, in Vec128<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::AndNot(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0011: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0016: ret

}
Vec128<uint> vandn(in Vec128<uint> x, in Vec128<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::AndNot(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0011: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0016: ret

}
Vec128<long> vandn(in Vec128<long> x, in Vec128<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse2::AndNot(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0011: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0016: ret

}
Vec128<ulong> vandn(in Vec128<ulong> x, in Vec128<ulong> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::AndNot(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0011: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0016: ret

}
Vec128<float> vandn(in Vec128<float> x, in Vec128<float> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Sse::AndNot(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0011: call Z0.Vec128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0016: ret

}
Vec128<double> vandn(in Vec128<double> x, in Vec128<double> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Double> System.Runtime.Intrinsics.X86.Sse2::AndNot(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0011: call Z0.Vec128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0016: ret

}
Vec256<sbyte> vandn(in Vec256<sbyte> x, in Vec256<sbyte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::AndNot(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0011: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0016: ret

}
Vec256<byte> vandn(in Vec256<byte> x, in Vec256<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::AndNot(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0011: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0016: ret

}
Vec256<short> vandn(in Vec256<short> x, in Vec256<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::AndNot(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0011: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0016: ret

}
Vec256<ushort> vandn(in Vec256<ushort> x, in Vec256<ushort> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::AndNot(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0011: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0016: ret

}
Vec256<int> vandn(in Vec256<int> x, in Vec256<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::AndNot(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0016: ret

}
Vec256<uint> vandn(in Vec256<uint> x, in Vec256<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::AndNot(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0011: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0016: ret

}
Vec256<long> vandn(in Vec256<long> x, in Vec256<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::AndNot(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0011: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0016: ret

}
Vec256<ulong> vandn(in Vec256<ulong> x, in Vec256<ulong> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::AndNot(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0011: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0016: ret

}
Vec256<float> vandn(in Vec256<float> x, in Vec256<float> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Single> System.Runtime.Intrinsics.X86.Avx::AndNot(System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_0011: call Z0.Vec256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_0016: ret

}
Vec256<double> vandn(in Vec256<double> x, in Vec256<double> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Double> System.Runtime.Intrinsics.X86.Avx::AndNot(System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_0011: call Z0.Vec256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_0016: ret

}
Vec128<sbyte> vandnot(in Vec128<sbyte> x, in Vec128<sbyte> y)
{
    IL_0000: ldarg.1
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::xmm
    IL_0006: ldarg.0
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::AndNot(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0011: call Z0.Vec128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0016: ret

}
Vec128<byte> vandnot(in Vec128<byte> x, in Vec128<byte> y)
{
    IL_0000: ldarg.1
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::xmm
    IL_0006: ldarg.0
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::AndNot(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0011: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0016: ret

}
Vec128<short> vandnot(in Vec128<short> x, in Vec128<short> y)
{
    IL_0000: ldarg.1
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::xmm
    IL_0006: ldarg.0
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::AndNot(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0011: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0016: ret

}
Vec128<ushort> vandnot(in Vec128<ushort> x, in Vec128<ushort> y)
{
    IL_0000: ldarg.1
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::xmm
    IL_0006: ldarg.0
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::AndNot(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0011: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0016: ret

}
Vec128<int> vandnot(in Vec128<int> x, in Vec128<int> y)
{
    IL_0000: ldarg.1
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::xmm
    IL_0006: ldarg.0
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::AndNot(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0011: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0016: ret

}
Vec128<uint> vandnot(in Vec128<uint> x, in Vec128<uint> y)
{
    IL_0000: ldarg.1
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::xmm
    IL_0006: ldarg.0
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::AndNot(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0011: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0016: ret

}
Vec128<long> vandnot(in Vec128<long> x, in Vec128<long> y)
{
    IL_0000: ldarg.1
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::xmm
    IL_0006: ldarg.0
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse2::AndNot(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0011: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0016: ret

}
Vec128<ulong> vandnot(in Vec128<ulong> x, in Vec128<ulong> y)
{
    IL_0000: ldarg.1
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::xmm
    IL_0006: ldarg.0
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::AndNot(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0011: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0016: ret

}
Vec256<sbyte> vandnot(in Vec256<sbyte> x, in Vec256<sbyte> y)
{
    IL_0000: ldarg.1
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::ymm
    IL_0006: ldarg.0
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::AndNot(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0011: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0016: ret

}
Vec256<byte> vandnot(in Vec256<byte> x, in Vec256<byte> y)
{
    IL_0000: ldarg.1
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::ymm
    IL_0006: ldarg.0
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::AndNot(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0011: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0016: ret

}
Vec256<short> vandnot(in Vec256<short> x, in Vec256<short> y)
{
    IL_0000: ldarg.1
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::ymm
    IL_0006: ldarg.0
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::AndNot(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0011: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0016: ret

}
Vec256<ushort> vandnot(in Vec256<ushort> x, in Vec256<ushort> y)
{
    IL_0000: ldarg.1
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::ymm
    IL_0006: ldarg.0
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::AndNot(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0011: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0016: ret

}
Vec256<int> vandnot(in Vec256<int> x, in Vec256<int> y)
{
    IL_0000: ldarg.1
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::ymm
    IL_0006: ldarg.0
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::AndNot(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0016: ret

}
Vec256<uint> vandnot(in Vec256<uint> x, in Vec256<uint> y)
{
    IL_0000: ldarg.1
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::ymm
    IL_0006: ldarg.0
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::AndNot(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0011: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0016: ret

}
Vec256<long> vandnot(in Vec256<long> x, in Vec256<long> y)
{
    IL_0000: ldarg.1
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::ymm
    IL_0006: ldarg.0
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::AndNot(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0011: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0016: ret

}
Vec256<ulong> vandnot(in Vec256<ulong> x, in Vec256<ulong> y)
{
    IL_0000: ldarg.1
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::ymm
    IL_0006: ldarg.0
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::AndNot(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0011: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0016: ret

}
Vector128<sbyte> vandnot(Vector128<sbyte> x, Vector128<sbyte> y)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::AndNot(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0007: ret

}
Vector128<byte> vandnot(Vector128<byte> x, Vector128<byte> y)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::AndNot(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0007: ret

}
Vector128<short> vandnot(Vector128<short> x, Vector128<short> y)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::AndNot(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0007: ret

}
Vector128<ushort> vandnot(Vector128<ushort> x, Vector128<ushort> y)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::AndNot(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0007: ret

}
Vector128<int> vandnot(Vector128<int> x, Vector128<int> y)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::AndNot(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0007: ret

}
Vector128<uint> vandnot(Vector128<uint> x, Vector128<uint> y)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::AndNot(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0007: ret

}
Vector128<long> vandnot(Vector128<long> x, Vector128<long> y)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse2::AndNot(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0007: ret

}
Vector128<ulong> vandnot(Vector128<ulong> x, Vector128<ulong> y)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::AndNot(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0007: ret

}
Vector256<sbyte> vandnot(Vector256<sbyte> x, Vector256<sbyte> y)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::AndNot(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0007: ret

}
Vector256<byte> vandnot(Vector256<byte> x, Vector256<byte> y)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::AndNot(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0007: ret

}
Vector256<short> vandnot(Vector256<short> x, Vector256<short> y)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::AndNot(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0007: ret

}
Vector256<ushort> vandnot(Vector256<ushort> x, Vector256<ushort> y)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::AndNot(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0007: ret

}
Vector256<int> vandnot(Vector256<int> x, Vector256<int> y)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::AndNot(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0007: ret

}
Vector256<uint> vandnot(Vector256<uint> x, Vector256<uint> y)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::AndNot(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0007: ret

}
Vector256<long> vandnot(Vector256<long> x, Vector256<long> y)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::AndNot(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0007: ret

}
Vector256<ulong> vandnot(Vector256<ulong> x, Vector256<ulong> y)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::AndNot(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0007: ret

}
Vec128<short> vbsll(in Vec128<short> src, byte bytes)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::ShiftLeftLogical128BitLane(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0016: ret

}
Vec128<ushort> vbsll(in Vec128<ushort> src, byte bytes)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::ShiftLeftLogical128BitLane(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0016: ret

}
Vec128<int> vbsll(in Vec128<int> src, byte bytes)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::ShiftLeftLogical128BitLane(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0016: ret

}
Vec128<uint> vbsll(in Vec128<uint> src, byte bytes)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::ShiftLeftLogical128BitLane(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0016: ret

}
Vec128<long> vbsll(in Vec128<long> src, byte bytes)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int64>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(Z0.Vec128`1<System.Int64>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse2::ShiftLeftLogical128BitLane(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0016: ret

}
Vec128<ulong> vbsll(in Vec128<ulong> src, byte bytes)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt64>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::ShiftLeftLogical128BitLane(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0016: ret

}
Vec256<short> vbsll(in Vec256<short> src, byte bytes)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::ShiftLeftLogical128BitLane(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Byte)
    IL_0011: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0016: ret

}
Vec256<ushort> vbsll(in Vec256<ushort> src, byte bytes)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt16>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::ShiftLeftLogical128BitLane(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Byte)
    IL_0011: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0016: ret

}
Vec256<int> vbsll(in Vec256<int> src, byte bytes)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::ShiftLeftLogical128BitLane(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Byte)
    IL_0011: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0016: ret

}
Vec256<uint> vbsll(in Vec256<uint> src, byte bytes)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt32>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::ShiftLeftLogical128BitLane(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Byte)
    IL_0011: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0016: ret

}
Vec256<long> vbsll(in Vec256<long> src, byte bytes)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int64>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::ShiftLeftLogical128BitLane(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Byte)
    IL_0011: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0016: ret

}
Vec256<ulong> vbsll(in Vec256<ulong> src, byte bytes)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt64>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::ShiftLeftLogical128BitLane(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Byte)
    IL_0011: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0016: ret

}
Vec128<short> vbsrl(in Vec128<short> src, byte bytes)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::ShiftRightLogical128BitLane(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0016: ret

}
Vec128<ushort> vbsrl(in Vec128<ushort> src, byte bytes)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::ShiftRightLogical128BitLane(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0016: ret

}
Vec128<int> vbsrl(in Vec128<int> src, byte bytes)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::ShiftRightLogical128BitLane(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0016: ret

}
Vec128<uint> vbsrl(in Vec128<uint> src, byte bytes)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::ShiftRightLogical128BitLane(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0016: ret

}
Vec128<long> vbsrl(in Vec128<long> src, byte bytes)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int64>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(Z0.Vec128`1<System.Int64>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse2::ShiftRightLogical128BitLane(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0016: ret

}
Vec128<ulong> vbsrl(in Vec128<ulong> src, byte bytes)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt64>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::ShiftRightLogical128BitLane(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0016: ret

}
Vec256<short> vbsrl(in Vec256<short> src, byte bytes)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::ShiftRightLogical128BitLane(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Byte)
    IL_0011: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0016: ret

}
Vec256<ushort> vbsrl(in Vec256<ushort> src, byte bytes)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt16>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::ShiftRightLogical128BitLane(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Byte)
    IL_0011: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0016: ret

}
Vec256<int> vbsrl(in Vec256<int> src, byte bytes)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::ShiftRightLogical128BitLane(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Byte)
    IL_0011: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0016: ret

}
Vec256<uint> vbsrl(in Vec256<uint> src, byte bytes)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt32>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::ShiftRightLogical128BitLane(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Byte)
    IL_0011: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0016: ret

}
Vec256<long> vbsrl(in Vec256<long> src, byte bytes)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int64>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::ShiftRightLogical128BitLane(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Byte)
    IL_0011: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0016: ret

}
Vec256<ulong> vbsrl(in Vec256<ulong> src, byte bytes)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt64>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>)
    IL_000B: ldarg.1
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::ShiftRightLogical128BitLane(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Byte)
    IL_0011: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0016: ret

}
Vec128<sbyte> vnand(in Vec128<sbyte> x, in Vec128<sbyte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::And(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0016: call Z0.Vec128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_001B: ret

}
Vec128<byte> vnand(in Vec128<byte> x, in Vec128<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::And(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0016: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_001B: ret

}
Vec128<short> vnand(in Vec128<short> x, in Vec128<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::And(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0016: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_001B: ret

}
Vec128<ushort> vnand(in Vec128<ushort> x, in Vec128<ushort> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::And(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0016: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_001B: ret

}
Vec128<int> vnand(in Vec128<int> x, in Vec128<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::And(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0016: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_001B: ret

}
Vec128<uint> vnand(in Vec128<uint> x, in Vec128<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::And(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0016: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_001B: ret

}
Vec128<long> vnand(in Vec128<long> x, in Vec128<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse2::And(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0016: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_001B: ret

}
Vec128<ulong> vnand(in Vec128<ulong> x, in Vec128<ulong> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::And(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0011: call Z0.Vec128`1<System.UInt64> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0016: ret

}
Vec128<float> vnand(in Vec128<float> x, in Vec128<float> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Sse::And(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.dfp::vnot(System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0016: call Z0.Vec128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_001B: ret

}
Vec128<double> vnand(in Vec128<double> x, in Vec128<double> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Double> System.Runtime.Intrinsics.X86.Sse2::And(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.dfp::vnot(System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0016: call Z0.Vec128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_001B: ret

}
Vec256<byte> vnand(in Vec256<byte> x, in Vec256<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::And(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0016: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_001B: ret

}
Vec256<short> vnand(in Vec256<short> x, in Vec256<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::And(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0016: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_001B: ret

}
Vec256<sbyte> vnand(in Vec256<sbyte> x, in Vec256<sbyte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::And(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0016: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_001B: ret

}
Vec256<ushort> vnand(in Vec256<ushort> x, in Vec256<ushort> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::And(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0016: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_001B: ret

}
Vec256<int> vnand(in Vec256<int> x, in Vec256<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::And(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0016: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_001B: ret

}
Vec256<uint> vnand(in Vec256<uint> x, in Vec256<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::And(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0016: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_001B: ret

}
Vec256<long> vnand(in Vec256<long> x, in Vec256<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::And(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0016: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_001B: ret

}
Vec256<ulong> vnand(in Vec256<ulong> x, in Vec256<ulong> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::And(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0016: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_001B: ret

}
Vec256<float> vnand(in Vec256<float> x, in Vec256<float> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Single> System.Runtime.Intrinsics.X86.Avx::And(System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.dfp::vnot(System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_0016: call Z0.Vec256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_001B: ret

}
Vec256<double> vnand(in Vec256<double> x, in Vec256<double> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Double> System.Runtime.Intrinsics.X86.Avx::And(System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.dfp::vnot(System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_0016: call Z0.Vec256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_001B: ret

}
Vec128<sbyte> vnor(in Vec128<sbyte> x, in Vec128<sbyte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::Or(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0016: call Z0.Vec128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_001B: ret

}
Vec128<byte> vnor(in Vec128<byte> x, in Vec128<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::Or(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0016: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_001B: ret

}
Vec128<short> vnor(in Vec128<short> x, in Vec128<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::Or(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0016: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_001B: ret

}
Vec128<ushort> vnor(in Vec128<ushort> x, in Vec128<ushort> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::Or(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0016: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_001B: ret

}
Vec128<int> vnor(in Vec128<int> x, in Vec128<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::Or(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0016: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_001B: ret

}
Vec128<uint> vnor(in Vec128<uint> x, in Vec128<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::Or(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0016: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_001B: ret

}
Vec128<long> vnor(in Vec128<long> x, in Vec128<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse2::Or(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0016: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_001B: ret

}
Vec128<ulong> vnor(in Vec128<ulong> x, in Vec128<ulong> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::Or(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0011: call Z0.Vec128`1<System.UInt64> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0016: ret

}
Vec128<float> vnor(in Vec128<float> x, in Vec128<float> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Single> System.Runtime.Intrinsics.X86.Sse::Or(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.dfp::vnot(System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0016: call Z0.Vec128`1<System.Single> Z0.Vec128`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_001B: ret

}
Vec128<double> vnor(in Vec128<double> x, in Vec128<double> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Double> System.Runtime.Intrinsics.X86.Sse2::Or(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.dfp::vnot(System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0016: call Z0.Vec128`1<System.Double> Z0.Vec128`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_001B: ret

}
Vec256<byte> vnor(in Vec256<byte> x, in Vec256<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::Or(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0016: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_001B: ret

}
Vec256<short> vnor(in Vec256<short> x, in Vec256<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::Or(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0016: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_001B: ret

}
Vec256<sbyte> vnor(in Vec256<sbyte> x, in Vec256<sbyte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::Or(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0016: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_001B: ret

}
Vec256<ushort> vnor(in Vec256<ushort> x, in Vec256<ushort> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::Or(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0016: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_001B: ret

}
Vec256<int> vnor(in Vec256<int> x, in Vec256<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::Or(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0016: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_001B: ret

}
Vec256<uint> vnor(in Vec256<uint> x, in Vec256<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::Or(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.dinx::vnot(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0016: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_001B: ret

}
Vec256<ushort> vmov256(in ushort src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt16* Z0.As::constptr(System.UInt16&)
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx::LoadVector256(System.UInt16*)
    IL_000B: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0010: ret

}
Vec256<int> vmov256(in int src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int32* Z0.As::constptr(System.Int32&)
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx::LoadVector256(System.Int32*)
    IL_000B: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0010: ret

}
Vec256<uint> vmov256(in uint src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32* Z0.As::constptr(System.UInt32&)
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx::LoadVector256(System.UInt32*)
    IL_000B: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0010: ret

}
Vec256<long> vmov256(in long src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int64* Z0.As::constptr(System.Int64&)
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx::LoadVector256(System.Int64*)
    IL_000B: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0010: ret

}
Vec256<ulong> vmov256(in ulong src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt64* Z0.As::constptr(System.UInt64&)
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx::LoadVector256(System.UInt64*)
    IL_000B: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0010: ret

}
void movdqa(in Vec128<sbyte> src, ref sbyte dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.SByte* Z0.As::refptr(System.SByte&)
    IL_0006: ldarg.0
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::xmm
    IL_000C: call System.Void System.Runtime.Intrinsics.X86.Sse2::StoreAligned(System.SByte*,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0011: ret

}
void movdqa(in Vec128<byte> src, ref byte dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.Byte* Z0.As::refptr(System.Byte&)
    IL_0006: ldarg.0
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::xmm
    IL_000C: call System.Void System.Runtime.Intrinsics.X86.Sse2::StoreAligned(System.Byte*,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0011: ret

}
void movdqa(in Vec128<short> src, ref short dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.Int16* Z0.As::refptr(System.Int16&)
    IL_0006: ldarg.0
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::xmm
    IL_000C: call System.Void System.Runtime.Intrinsics.X86.Sse2::StoreAligned(System.Int16*,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0011: ret

}
void movdqa(in Vec128<ushort> src, ref ushort dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.UInt16* Z0.As::refptr(System.UInt16&)
    IL_0006: ldarg.0
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::xmm
    IL_000C: call System.Void System.Runtime.Intrinsics.X86.Sse2::StoreAligned(System.UInt16*,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0011: ret

}
void movdqa(in Vec128<int> src, ref int dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.Int32* Z0.As::refptr(System.Int32&)
    IL_0006: ldarg.0
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::xmm
    IL_000C: call System.Void System.Runtime.Intrinsics.X86.Sse2::StoreAligned(System.Int32*,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0011: ret

}
void movdqa(in Vec128<uint> src, ref uint dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.UInt32* Z0.As::refptr(System.UInt32&)
    IL_0006: ldarg.0
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::xmm
    IL_000C: call System.Void System.Runtime.Intrinsics.X86.Sse2::StoreAligned(System.UInt32*,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0011: ret

}
void movdqa(in Vec128<long> src, ref long dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.Int64* Z0.As::refptr(System.Int64&)
    IL_0006: ldarg.0
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::xmm
    IL_000C: call System.Void System.Runtime.Intrinsics.X86.Sse2::StoreAligned(System.Int64*,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0011: ret

}
void movdqa(in Vec128<ulong> src, ref ulong dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.UInt64* Z0.As::refptr(System.UInt64&)
    IL_0006: ldarg.0
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::xmm
    IL_000C: call System.Void System.Runtime.Intrinsics.X86.Sse2::StoreAligned(System.UInt64*,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0011: ret

}
void movdqa(in Vec256<sbyte> src, ref sbyte dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.SByte* Z0.As::refptr(System.SByte&)
    IL_0006: ldarg.0
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::ymm
    IL_000C: call System.Void System.Runtime.Intrinsics.X86.Avx::StoreAligned(System.SByte*,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0011: ret

}
void movdqa(in Vec256<byte> src, ref byte dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.Byte* Z0.As::refptr(System.Byte&)
    IL_0006: ldarg.0
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::ymm
    IL_000C: call System.Void System.Runtime.Intrinsics.X86.Avx::StoreAligned(System.Byte*,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0011: ret

}
void movdqa(in Vec256<short> src, ref short dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.Int16* Z0.As::refptr(System.Int16&)
    IL_0006: ldarg.0
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::ymm
    IL_000C: call System.Void System.Runtime.Intrinsics.X86.Avx::StoreAligned(System.Int16*,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0011: ret

}
void movdqa(in Vec256<ushort> src, ref ushort dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.UInt16* Z0.As::refptr(System.UInt16&)
    IL_0006: ldarg.0
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::ymm
    IL_000C: call System.Void System.Runtime.Intrinsics.X86.Avx::StoreAligned(System.UInt16*,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0011: ret

}
void movdqa(in Vec256<int> src, ref int dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.Int32* Z0.As::refptr(System.Int32&)
    IL_0006: ldarg.0
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::ymm
    IL_000C: call System.Void System.Runtime.Intrinsics.X86.Avx::StoreAligned(System.Int32*,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: ret

}
void movdqa(in Vec256<uint> src, ref uint dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.UInt32* Z0.As::refptr(System.UInt32&)
    IL_0006: ldarg.0
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::ymm
    IL_000C: call System.Void System.Runtime.Intrinsics.X86.Avx::StoreAligned(System.UInt32*,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0011: ret

}
void movdqa(in Vec256<long> src, ref long dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.Int64* Z0.As::refptr(System.Int64&)
    IL_0006: ldarg.0
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::ymm
    IL_000C: call System.Void System.Runtime.Intrinsics.X86.Avx::StoreAligned(System.Int64*,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0011: ret

}
void movdqa(in Vec256<ulong> src, ref ulong dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.UInt64* Z0.As::refptr(System.UInt64&)
    IL_0006: ldarg.0
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::ymm
    IL_000C: call System.Void System.Runtime.Intrinsics.X86.Avx::StoreAligned(System.UInt64*,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0011: ret

}
int movemask(in Vec128<byte> src)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::xmm
    IL_0006: call System.Int32 System.Runtime.Intrinsics.X86.Sse2::MoveMask(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_000B: ret

}
int movemask(in Vec128<sbyte> src)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::xmm
    IL_0006: call System.Int32 System.Runtime.Intrinsics.X86.Sse2::MoveMask(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_000B: ret

}
int movemask(in Vec256<sbyte> src)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::ymm
    IL_0006: call System.Int32 System.Runtime.Intrinsics.X86.Avx2::MoveMask(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_000B: ret

}
int movemask(in Vec256<byte> src)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::ymm
    IL_0006: call System.Int32 System.Runtime.Intrinsics.X86.Avx2::MoveMask(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_000B: ret

}
Vec256<sbyte> vperm2x128(in Vec256<sbyte> x, in Vec256<sbyte> y, Perm2x128:byte spec)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::ymm
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::Permute2x128(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Byte)
    IL_0012: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0017: ret

}
Vec256<byte> vperm2x128(in Vec256<byte> x, in Vec256<byte> y, Perm2x128:byte spec)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::ymm
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::Permute2x128(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Byte)
    IL_0012: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0017: ret

}
Vec256<short> vperm2x128(in Vec256<short> x, in Vec256<short> y, Perm2x128:byte spec)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::ymm
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::Permute2x128(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Byte)
    IL_0012: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0017: ret

}
Vec256<ushort> vperm2x128(in Vec256<ushort> x, in Vec256<ushort> y, Perm2x128:byte spec)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::ymm
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::Permute2x128(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Byte)
    IL_0012: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0017: ret

}
Vec256<int> vperm2x128(in Vec256<int> x, in Vec256<int> y, Perm2x128:byte spec)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::ymm
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::Permute2x128(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Byte)
    IL_0012: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0017: ret

}
Vec256<uint> vperm2x128(in Vec256<uint> x, in Vec256<uint> y, Perm2x128:byte spec)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt32>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.UInt32>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>)
    IL_0016: ldarg.2
    IL_0017: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::Permute2x128(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Byte)
    IL_001C: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0021: ret

}
Vec256<long> vperm2x128(in Vec256<long> x, in Vec256<long> y, Perm2x128:byte spec)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::ymm
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::Permute2x128(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Byte)
    IL_0012: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0017: ret

}
Vec256<ulong> vperm2x128(in Vec256<ulong> x, in Vec256<ulong> y, Perm2x128:byte spec)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::ymm
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::Permute2x128(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Byte)
    IL_0012: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0017: ret

}
Vec256<float> vperm2x128(in Vec256<float> x, in Vec256<float> y, Perm2x128:byte spec)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::ymm
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.Single> System.Runtime.Intrinsics.X86.Avx::Permute2x128(System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Byte)
    IL_0012: call Z0.Vec256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_0017: ret

}
Vec256<double> vperm2x128(in Vec256<double> x, in Vec256<double> y, Perm2x128:byte spec)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::ymm
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.Double> System.Runtime.Intrinsics.X86.Avx::Permute2x128(System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Byte)
    IL_0012: call Z0.Vec256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_0017: ret

}
ReadOnlySpan<byte> get_K0Bytes()
{
    IL_0000: ldsflda <PrivateImplementationDetails>/__StaticArrayInitTypeSize=32 <PrivateImplementationDetails>::4A299332C06147F0009A9D8E29D782BB553EA2F4
    IL_0005: ldc.i4.s 32
    IL_0007: newobj System.Void System.ReadOnlySpan`1<System.Byte>::.ctor(System.Void*,System.Int32)
    IL_000C: ret

}
ReadOnlySpan<byte> get_K1Bytes()
{
    IL_0000: ldsflda <PrivateImplementationDetails>/__StaticArrayInitTypeSize=32 <PrivateImplementationDetails>::B1EF5D80A615BADD252B8C90AE9907B7F19690B8
    IL_0005: ldc.i4.s 32
    IL_0007: newobj System.Void System.ReadOnlySpan`1<System.Byte>::.ctor(System.Void*,System.Int32)
    IL_000C: ret

}
Vec256<byte> get_K0()
{
    IL_0000: call System.ReadOnlySpan`1<System.Byte> Z0.dinx::get_K0Bytes()
    IL_0005: stloc.0
    IL_0006: ldloca.s V_0
    IL_0008: ldc.i4.0
    IL_0009: call System.Byte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Byte>::get_Item(System.Int32)
    IL_000E: call Z0.Vec256`1<System.Byte> Z0.dinx::vloadu256(System.Byte&)
    IL_0013: ret

}
Vec256<byte> get_K1()
{
    IL_0000: call System.ReadOnlySpan`1<System.Byte> Z0.dinx::get_K1Bytes()
    IL_0005: stloc.0
    IL_0006: ldloca.s V_0
    IL_0008: ldc.i4.0
    IL_0009: call System.Byte& modreq(System.Runtime.InteropServices.InAttribute) System.ReadOnlySpan`1<System.Byte>::get_Item(System.Int32)
    IL_000E: call Z0.Vec256`1<System.Byte> Z0.dinx::vloadu256(System.Byte&)
    IL_0013: ret

}
Vec256<byte> vpermvar32x8(in Vec256<byte> a, in Vec256<byte> spec)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec256`1<System.Byte> Z0.dinx::get_K0()
    IL_0007: stloc.2
    IL_0008: ldloca.s V_2
    IL_000A: call Z0.Vec256`1<System.Byte> Z0.dinx::vadd(Z0.Vec256`1<System.Byte>&,Z0.Vec256`1<System.Byte>&)
    IL_000F: stloc.3
    IL_0010: ldloca.s V_3
    IL_0012: call Z0.Vec256`1<System.Byte> Z0.dinx::vshuffle(Z0.Vec256`1<System.Byte>&,Z0.Vec256`1<System.Byte>&)
    IL_0017: stloc.0
    IL_0018: ldarg.0
    IL_0019: call Z0.Vec256`1<System.Byte> Z0.dinx::vswaphl(Z0.Vec256`1<System.Byte>&)
    IL_001E: stloc.2
    IL_001F: ldloca.s V_2
    IL_0021: ldarg.1
    IL_0022: call Z0.Vec256`1<System.Byte> Z0.dinx::get_K1()
    IL_0027: stloc.3
    IL_0028: ldloca.s V_3
    IL_002A: call Z0.Vec256`1<System.Byte> Z0.dinx::vadd(Z0.Vec256`1<System.Byte>&,Z0.Vec256`1<System.Byte>&)
    IL_002F: stloc.s V_4
    IL_0031: ldloca.s V_4
    IL_0033: call Z0.Vec256`1<System.Byte> Z0.dinx::vshuffle(Z0.Vec256`1<System.Byte>&,Z0.Vec256`1<System.Byte>&)
    IL_0038: stloc.1
    IL_0039: ldloca.s V_0
    IL_003B: ldloca.s V_1
    IL_003D: call Z0.Vec256`1<System.Byte> Z0.dinx::vor(Z0.Vec256`1<System.Byte>&,Z0.Vec256`1<System.Byte>&)
    IL_0042: ret

}
Vec256<long> vperm4x64(in Vec256<long> x, Perm4:byte spec)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::ymm
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::Permute4x64(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Byte)
    IL_000C: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0011: ret

}
Vec256<ulong> vperm4x64(in Vec256<ulong> x, Perm4:byte spec)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::ymm
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::Permute4x64(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Byte)
    IL_000C: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0011: ret

}
Vec256<double> vperm4x64(in Vec256<double> x, Perm4:byte spec)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::ymm
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Double> System.Runtime.Intrinsics.X86.Avx2::Permute4x64(System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Byte)
    IL_000C: call Z0.Vec256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_0011: ret

}
Vec256<int> vpermvar8x32(in Vec256<int> src, in Vec256<int> spec)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::PermuteVar8x32(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0016: ret

}
Vec256<uint> vpermvar8x32(in Vec256<uint> src, in Vec256<uint> spec)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::PermuteVar8x32(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0011: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0016: ret

}
Vec256<float> vpermvar8x32(in Vec256<float> src, in Vec256<int> spec)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Single> System.Runtime.Intrinsics.X86.Avx2::PermuteVar8x32(System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: call Z0.Vec256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_0016: ret

}
Vec128<byte> swap(in Vec128<byte> src, Swap[] swaps)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.Byte> Z0.Vec128Pattern::Swap<System.Byte>(Z0.Swap[])
    IL_0007: stloc.0
    IL_0008: ldloca.s V_0
    IL_000A: call Z0.Vec128`1<System.Byte> Z0.dinx::vshuffle(Z0.Vec128`1<System.Byte>&,Z0.Vec128`1<System.Byte>&)
    IL_000F: ret

}
Vec128<byte> reverse(in Vec128<byte> src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.s 15
    IL_0003: call Z0.Swap[] System.Array::Empty<Z0.Swap>()
    IL_0008: call Z0.Vec128`1<System.Byte> Z0.Vec128Pattern::decrements<System.Byte>(System.Byte,Z0.Swap[])
    IL_000D: stloc.0
    IL_000E: ldloca.s V_0
    IL_0010: call Z0.Vec128`1<System.Byte> Z0.dinx::vshuffle(Z0.Vec128`1<System.Byte>&,Z0.Vec128`1<System.Byte>&)
    IL_0015: ret

}
Vec128<sbyte> reverse(in Vec128<sbyte> src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.s 15
    IL_0003: call Z0.Swap[] System.Array::Empty<Z0.Swap>()
    IL_0008: call Z0.Vec128`1<System.SByte> Z0.Vec128Pattern::decrements<System.SByte>(System.SByte,Z0.Swap[])
    IL_000D: stloc.0
    IL_000E: ldloca.s V_0
    IL_0010: call Z0.Vec128`1<System.SByte> Z0.dinx::vshuffle(Z0.Vec128`1<System.SByte>&,Z0.Vec128`1<System.SByte>&)
    IL_0015: ret

}
Vec128<int> reverse(in Vec128<int> src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.s 27
    IL_0003: call Z0.Vec128`1<System.Int32> Z0.dinx::vshuffle(Z0.Vec128`1<System.Int32>&,Z0.Perm4)
    IL_0008: ret

}
Vec128<uint> reverse(in Vec128<uint> src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.s 27
    IL_0003: call Z0.Vec128`1<System.UInt32> Z0.dinx::vshuffle(Z0.Vec128`1<System.UInt32>&,Z0.Perm4)
    IL_0008: ret

}
Vec256<byte> reverse(in Vec256<byte> src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.s 31
    IL_0003: call Z0.Vec256`1<System.Byte> Z0.Vec256Pattern::Decrements<System.Byte>(System.Byte)
    IL_0008: stloc.0
    IL_0009: ldloca.s V_0
    IL_000B: call Z0.Vec256`1<System.Byte> Z0.dinx::vpermvar32x8(Z0.Vec256`1<System.Byte>&,Z0.Vec256`1<System.Byte>&)
    IL_0010: ret

}
Vec256<int> reverse(in Vec256<int> src)
{
    IL_0000: ldarg.0
    IL_0001: ldsflda Z0.Vec256`1<System.Int32> Z0.dinx::MRev256i32
    IL_0006: call Z0.Vec256`1<System.Int32> Z0.dinx::vpermvar8x32(Z0.Vec256`1<System.Int32>&,Z0.Vec256`1<System.Int32>&)
    IL_000B: ret

}
Vec256<uint> reverse(in Vec256<uint> src)
{
    IL_0000: ldarg.0
    IL_0001: ldsflda Z0.Vec256`1<System.UInt32> Z0.dinx::MRev256u32
    IL_0006: call Z0.Vec256`1<System.UInt32> Z0.dinx::vpermvar8x32(Z0.Vec256`1<System.UInt32>&,Z0.Vec256`1<System.UInt32>&)
    IL_000B: ret

}
Vec256<float> reverse(in Vec256<float> src)
{
    IL_0000: ldarg.0
    IL_0001: ldsflda Z0.Vec256`1<System.Int32> Z0.dinx::MRev256f32
    IL_0006: call Z0.Vec256`1<System.Single> Z0.dinx::vpermvar8x32(Z0.Vec256`1<System.Single>&,Z0.Vec256`1<System.Int32>&)
    IL_000B: ret

}
Vec128<short> vshufflehi(in Vec128<short> src, Perm4:byte control)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::xmm
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::ShuffleHigh(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Byte)
    IL_000C: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0011: ret

}
Vec128<ushort> vshufflehi(in Vec128<ushort> src, Perm4:byte spec)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::xmm
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::ShuffleHigh(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Byte)
    IL_000C: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0011: ret

}
Vec128<short> vshufflelo(in Vec128<short> src, Perm4:byte control)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::xmm
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::ShuffleLow(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Byte)
    IL_000C: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0011: ret

}
Vec128<ushort> vshufflelo(in Vec128<ushort> src, Perm4:byte control)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::xmm
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::ShuffleLow(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Byte)
    IL_000C: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0011: ret

}
Vec128<short> vshuffle(in Vec128<short> src, Perm4:byte lo, Perm4:byte hi)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.Int16> Z0.dinx::vshufflelo(Z0.Vec128`1<System.Int16>&,Z0.Perm4)
    IL_0007: stloc.0
    IL_0008: ldloca.s V_0
    IL_000A: ldarg.2
    IL_000B: call Z0.Vec128`1<System.Int16> Z0.dinx::vshufflehi(Z0.Vec128`1<System.Int16>&,Z0.Perm4)
    IL_0010: ret

}
Vec128<ushort> vshuffle(in Vec128<ushort> src, Perm4:byte lo, Perm4:byte hi)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.UInt16> Z0.dinx::vshufflelo(Z0.Vec128`1<System.UInt16>&,Z0.Perm4)
    IL_0007: stloc.0
    IL_0008: ldloca.s V_0
    IL_000A: ldarg.2
    IL_000B: call Z0.Vec128`1<System.UInt16> Z0.dinx::vshufflehi(Z0.Vec128`1<System.UInt16>&,Z0.Perm4)
    IL_0010: ret

}
Vec128<int> vshuffle(in Vec128<int> src, Perm4:byte spec)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::xmm
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::Shuffle(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Byte)
    IL_000C: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0011: ret

}
Vec128<uint> vshuffle(in Vec128<uint> src, Perm4:byte spec)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::xmm
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::Shuffle(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Byte)
    IL_000C: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0011: ret

}
Vec256<int> vshuffle(in Vec256<int> src, Perm4:byte spec)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::ymm
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::Shuffle(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Byte)
    IL_000C: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: ret

}
Vec256<uint> vshuffle(in Vec256<uint> src, Perm4:byte spec)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::ymm
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::Shuffle(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Byte)
    IL_000C: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0011: ret

}
Vec128<ushort> vshufflehi(in Vec128<ushort> src, byte control)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::xmm
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::ShuffleHigh(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Byte)
    IL_000C: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0011: ret

}
Vec128<ushort> vshufflelo(in Vec128<ushort> src, byte control)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::xmm
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::ShuffleLow(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Byte)
    IL_000C: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0011: ret

}
Vec128<byte> vshuffle(in Vec128<byte> src, in Vec128<byte> spec)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::xmm
    IL_0006: ldarg.1
    IL_0007: ldobj Z0.Vec128`1<System.Byte>
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Ssse3::Shuffle(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0016: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_001B: ret

}
Vec128<sbyte> vshuffle(in Vec128<sbyte> src, in Vec128<sbyte> spec)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::xmm
    IL_0006: ldarg.1
    IL_0007: ldobj Z0.Vec128`1<System.SByte>
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Ssse3::Shuffle(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0016: call Z0.Vec128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_001B: ret

}
Vec256<byte> vshuffle(in Vec256<byte> src, in Vec256<byte> spec)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::ymm
    IL_0006: ldarg.1
    IL_0007: ldobj Z0.Vec256`1<System.Byte>
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::Shuffle(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0016: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_001B: ret

}
Vec256<sbyte> vshuffle(in Vec256<sbyte> src, in Vec256<sbyte> spec)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::ymm
    IL_0006: ldarg.1
    IL_0007: ldobj Z0.Vec256`1<System.SByte>
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>)
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::Shuffle(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0016: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_001B: ret

}
Vec256<int> vswap(Vec256<int> src, byte i, byte j)
{
    IL_0000: ldsfld System.Int32 Z0.Vec256`1<System.Int32>::Length
    IL_0005: stloc.1
    IL_0006: ldloc.1
    IL_0007: conv.u
    IL_0008: ldc.i4.4
    IL_0009: mul.ovf.un
    IL_000A: localloc
    IL_000C: ldloc.1
    IL_000D: newobj System.Void System.Span`1<System.Int32>::.ctor(System.Void*,System.Int32)
    IL_0012: stloc.2
    IL_0013: ldloc.2
    IL_0014: stloc.0
    IL_0015: ldc.i4.0
    IL_0016: stloc.3
    IL_0017: br.s IL_0048
    IL_0019: ldloc.3
    IL_001A: ldarg.1
    IL_001B: bne.un.s IL_0029
    IL_001D: ldloca.s V_0
    IL_001F: ldloc.3
    IL_0020: call System.Int32& System.Span`1<System.Int32>::get_Item(System.Int32)
    IL_0025: ldarg.2
    IL_0026: stind.i4
    IL_0027: br.s IL_0043
    IL_0029: ldloc.3
    IL_002A: ldarg.2
    IL_002B: bne.un.s IL_0039
    IL_002D: ldloca.s V_0
    IL_002F: ldloc.3
    IL_0030: call System.Int32& System.Span`1<System.Int32>::get_Item(System.Int32)
    IL_0035: ldarg.1
    IL_0036: stind.i4
    IL_0037: br.s IL_0043
    IL_0039: ldloca.s V_0
    IL_003B: ldloc.3
    IL_003C: call System.Int32& System.Span`1<System.Int32>::get_Item(System.Int32)
    IL_0041: ldloc.3
    IL_0042: stind.i4
    IL_0043: ldloc.3
    IL_0044: ldc.i4.1
    IL_0045: add
    IL_0046: conv.u1
    IL_0047: stloc.3
    IL_0048: ldloc.3
    IL_0049: ldloca.s V_0
    IL_004B: call System.Int32 System.Span`1<System.Int32>::get_Length()
    IL_0050: blt.s IL_0019
    IL_0052: ldarga.s src
    IL_0054: ldloc.0
    IL_0055: call Z0.Vec256`1<System.Int32> Z0.Vec256::Load<System.Int32>(System.Span`1<System.Int32>)
    IL_005A: stloc.s V_4
    IL_005C: ldloca.s V_4
    IL_005E: call Z0.Vec256`1<System.Int32> Z0.dinx::vpermvar8x32(Z0.Vec256`1<System.Int32>&,Z0.Vec256`1<System.Int32>&)
    IL_0063: ret

}
Vec256<byte> vswaphl_ref(in Vec256<byte> x)
{
    IL_0000: ldloca.s V_0
    IL_0002: initobj Z0.Vec256`1<System.Byte>
    IL_0008: ldarg.0
    IL_0009: call Z0.Vec128`1<System.Byte> Z0.dinx::vhi(Z0.Vec256`1<System.Byte>&)
    IL_000E: stloc.1
    IL_000F: ldloca.s V_1
    IL_0011: ldloca.s V_0
    IL_0013: ldc.i4.0
    IL_0014: call Z0.Vec256`1<System.Byte> Z0.dinx::vinsert(Z0.Vec128`1<System.Byte>&,Z0.Vec256`1<System.Byte>&,System.Byte)
    IL_0019: stloc.0
    IL_001A: ldarg.0
    IL_001B: call Z0.Vec128`1<System.Byte> Z0.dinx::vlo(Z0.Vec256`1<System.Byte>&)
    IL_0020: stloc.1
    IL_0021: ldloca.s V_1
    IL_0023: ldloca.s V_0
    IL_0025: ldc.i4.1
    IL_0026: call Z0.Vec256`1<System.Byte> Z0.dinx::vinsert(Z0.Vec128`1<System.Byte>&,Z0.Vec256`1<System.Byte>&,System.Byte)
    IL_002B: stloc.0
    IL_002C: ldloc.0
    IL_002D: ret

}
Vec256<byte> vswaphl(in Vec256<byte> x)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldc.i4.3
    IL_0003: call Z0.Vec256`1<System.Byte> Z0.dinx::vperm2x128(Z0.Vec256`1<System.Byte>&,Z0.Vec256`1<System.Byte>&,Z0.Perm2x128)
    IL_0008: ret

}
Vec256<sbyte> vswaphl(in Vec256<sbyte> x)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldc.i4.3
    IL_0003: call Z0.Vec256`1<System.SByte> Z0.dinx::vperm2x128(Z0.Vec256`1<System.SByte>&,Z0.Vec256`1<System.SByte>&,Z0.Perm2x128)
    IL_0008: ret

}
Vec256<short> vswaphl(in Vec256<short> x)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldc.i4.s 48
    IL_0004: call Z0.Vec256`1<System.Int16> Z0.dinx::vperm2x128(Z0.Vec256`1<System.Int16>&,Z0.Vec256`1<System.Int16>&,Z0.Perm2x128)
    IL_0009: ret

}
Vec256<ushort> vswaphl(in Vec256<ushort> x)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldc.i4.3
    IL_0003: call Z0.Vec256`1<System.UInt16> Z0.dinx::vperm2x128(Z0.Vec256`1<System.UInt16>&,Z0.Vec256`1<System.UInt16>&,Z0.Perm2x128)
    IL_0008: ret

}
Vec256<long> vswaphl(in Vec256<long> x)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldc.i4.3
    IL_0003: call Z0.Vec256`1<System.Int64> Z0.dinx::vperm2x128(Z0.Vec256`1<System.Int64>&,Z0.Vec256`1<System.Int64>&,Z0.Perm2x128)
    IL_0008: ret

}
Vec256<ulong> vswaphl(in Vec256<ulong> x)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldc.i4.3
    IL_0003: call Z0.Vec256`1<System.UInt64> Z0.dinx::vperm2x128(Z0.Vec256`1<System.UInt64>&,Z0.Vec256`1<System.UInt64>&,Z0.Perm2x128)
    IL_0008: ret

}
Vec256<double> vswaphl(in Vec256<double> x)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.0
    IL_0002: ldc.i4.3
    IL_0003: call Z0.Vec256`1<System.Double> Z0.dinx::vperm2x128(Z0.Vec256`1<System.Double>&,Z0.Vec256`1<System.Double>&,Z0.Perm2x128)
    IL_0008: ret

}
Vec128<sbyte> vunpackhi(in Vec128<sbyte> x, in Vec128<sbyte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::UnpackHigh(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0011: call Z0.Vec128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0016: ret

}
Vec128<byte> vunpackhi(in Vec128<byte> x, in Vec128<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::UnpackHigh(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0011: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0016: ret

}
Vec128<short> vunpackhi(in Vec128<short> x, in Vec128<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::UnpackHigh(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0011: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0016: ret

}
Vec128<ushort> vunpackhi(in Vec128<ushort> x, in Vec128<ushort> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::UnpackHigh(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0011: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0016: ret

}
Vec128<int> vunpackhi(in Vec128<int> x, in Vec128<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::UnpackHigh(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0011: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0016: ret

}
Vec128<uint> vunpackhi(in Vec128<uint> x, in Vec128<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::UnpackHigh(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0011: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0016: ret

}
Vec128<long> vunpackhi(in Vec128<long> x, in Vec128<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse2::UnpackHigh(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0011: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0016: ret

}
Vec128<ulong> vunpackhi(in Vec128<ulong> x, in Vec128<ulong> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::UnpackHigh(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0011: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0016: ret

}
Vec256<sbyte> vunpackhi(in Vec256<sbyte> x, in Vec256<sbyte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::UnpackHigh(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0011: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0016: ret

}
Vec256<byte> vunpackhi(in Vec256<byte> x, in Vec256<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::UnpackHigh(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0011: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0016: ret

}
Vec256<short> vunpackhi(in Vec256<short> x, in Vec256<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::UnpackHigh(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0011: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0016: ret

}
Vec256<ushort> vunpackhi(in Vec256<ushort> x, in Vec256<ushort> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::UnpackHigh(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0011: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0016: ret

}
Vec256<int> vunpackhi(in Vec256<int> x, in Vec256<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::UnpackHigh(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0016: ret

}
Vec256<uint> vunpackhi(in Vec256<uint> x, in Vec256<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::UnpackHigh(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0011: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0016: ret

}
Vec256<long> vunpackhi(in Vec256<long> x, in Vec256<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::UnpackHigh(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0011: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0016: ret

}
Vec256<ulong> vunpackhi(in Vec256<ulong> x, in Vec256<ulong> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::UnpackHigh(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0011: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0016: ret

}
Vec128<sbyte> vunpacklo(in Vec128<sbyte> x, in Vec128<sbyte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::UnpackLow(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0011: call Z0.Vec128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0016: ret

}
Vec128<byte> vunpacklo(in Vec128<byte> x, in Vec128<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::UnpackLow(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0011: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0016: ret

}
Vec128<short> vunpacklo(in Vec128<short> x, in Vec128<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::UnpackLow(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0011: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0016: ret

}
Vec128<ushort> vunpacklo(in Vec128<ushort> x, in Vec128<ushort> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::UnpackLow(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0011: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0016: ret

}
Vec128<int> vunpacklo(in Vec128<int> x, in Vec128<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::UnpackLow(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0011: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0016: ret

}
Vec128<uint> vunpacklo(in Vec128<uint> x, in Vec128<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::UnpackLow(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0011: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0016: ret

}
Vec128<long> vunpacklo(in Vec128<long> x, in Vec128<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse2::UnpackLow(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0011: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0016: ret

}
Vec128<ulong> vunpacklo(in Vec128<ulong> x, in Vec128<ulong> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::UnpackLow(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0011: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0016: ret

}
Vec256<byte> vunpacklo(in Vec256<byte> x, in Vec256<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::UnpackLow(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0011: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0016: ret

}
Vec256<sbyte> vunpacklo(in Vec256<sbyte> x, in Vec256<sbyte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::UnpackLow(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0011: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0016: ret

}
Vec256<short> vunpacklo(in Vec256<short> x, in Vec256<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::UnpackLow(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0011: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0016: ret

}
Vec256<ushort> vunpacklo(in Vec256<ushort> x, in Vec256<ushort> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::UnpackLow(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0011: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0016: ret

}
Vec256<int> vunpacklo(in Vec256<int> x, in Vec256<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::UnpackLow(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0016: ret

}
Vec256<uint> vunpacklo(in Vec256<uint> x, in Vec256<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::UnpackLow(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0011: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0016: ret

}
Vec256<long> vunpacklo(in Vec256<long> x, in Vec256<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::UnpackLow(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0011: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0016: ret

}
Vec256<ulong> vunpacklo(in Vec256<ulong> x, in Vec256<ulong> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::UnpackLow(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0011: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0016: ret

}
Vec128<byte> vand(in Vec128<byte> x, in Vec128<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldfld System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::xmm
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::And(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0016: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_001B: ret

}
Vec128<short> vand(in Vec128<short> x, in Vec128<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::And(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0011: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0016: ret

}
Vec128<sbyte> vand(in Vec128<sbyte> x, in Vec128<sbyte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::And(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0011: call Z0.Vec128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0016: ret

}
Vec128<ushort> vand(in Vec128<ushort> x, in Vec128<ushort> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::And(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0011: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0016: ret

}
Vec128<int> vand(in Vec128<int> x, in Vec128<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::And(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0011: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0016: ret

}
Vec128<uint> vand(in Vec128<uint> x, in Vec128<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::And(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0011: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0016: ret

}
Vec128<long> vand(in Vec128<long> x, in Vec128<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse2::And(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0011: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0016: ret

}
Vec128<ulong> vand(in Vec128<ulong> x, in Vec128<ulong> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::And(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0011: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0016: ret

}
Vec256<byte> vand(in Vec256<byte> x, in Vec256<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::And(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0011: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0016: ret

}
Vec256<short> vand(in Vec256<short> x, in Vec256<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::And(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0011: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0016: ret

}
Vec256<sbyte> vand(in Vec256<sbyte> x, in Vec256<sbyte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::And(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0011: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0016: ret

}
Vec256<ushort> vand(in Vec256<ushort> x, in Vec256<ushort> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::And(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0011: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0016: ret

}
Vec256<int> vand(in Vec256<int> x, in Vec256<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::And(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0016: ret

}
Vec256<uint> vand(in Vec256<uint> x, in Vec256<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::And(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0011: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0016: ret

}
Vec256<long> vand(in Vec256<long> x, in Vec256<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::And(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0011: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0016: ret

}
Vec256<ulong> vand(in Vec256<ulong> x, in Vec256<ulong> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::And(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0011: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0016: ret

}
ref Vec128<ushort> vconvert(in Vec128<byte> src, out Vec128<ushort> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.Vec128`1<System.Byte>
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse41::ConvertToVector128Int16(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.Vector128::AsUInt16<System.Int16>(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0016: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_001B: stobj Z0.Vec128`1<System.UInt16>
    IL_0020: ldarg.1
    IL_0021: ret

}
ref Vec128<int> vconvert(in Vec128<byte> src, out Vec128<int> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.Vec128`1<System.Byte>
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse41::ConvertToVector128Int32(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0011: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0016: stobj Z0.Vec128`1<System.Int32>
    IL_001B: ldarg.1
    IL_001C: ret

}
ref Vec128<uint> vconvert(in Vec128<byte> src, out Vec128<uint> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.Vec128`1<System.Byte>
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse41::ConvertToVector128Int32(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.Vector128::AsUInt32<System.Int32>(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0016: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_001B: stobj Z0.Vec128`1<System.UInt32>
    IL_0020: ldarg.1
    IL_0021: ret

}
ref Vec128<long> vconvert(in Vec128<byte> src, out Vec128<long> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.Vec128`1<System.Byte>
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse41::ConvertToVector128Int64(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0011: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0016: stobj Z0.Vec128`1<System.Int64>
    IL_001B: ldarg.1
    IL_001C: ret

}
ref Vec128<ulong> vconvert(in Vec128<byte> src, out Vec128<ulong> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.Vec128`1<System.Byte>
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse41::ConvertToVector128Int64(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.Vector128::AsUInt64<System.Int64>(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0016: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_001B: stobj Z0.Vec128`1<System.UInt64>
    IL_0020: ldarg.1
    IL_0021: ret

}
ref Vec128<int> vconvert(in Vec128<short> src, out Vec128<int> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.Vec128`1<System.Int16>
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse41::ConvertToVector128Int32(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0011: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0016: stobj Z0.Vec128`1<System.Int32>
    IL_001B: ldarg.1
    IL_001C: ret

}
ref Vec128<long> vconvert(in Vec128<short> src, out Vec128<long> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.Vec128`1<System.Int16>
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse41::ConvertToVector128Int64(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0011: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0016: stobj Z0.Vec128`1<System.Int64>
    IL_001B: ldarg.1
    IL_001C: ret

}
ref Vec128<int> vconvert(in Vec128<ushort> src, out Vec128<int> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.Vec128`1<System.UInt16>
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse41::ConvertToVector128Int32(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0011: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0016: stobj Z0.Vec128`1<System.Int32>
    IL_001B: ldarg.1
    IL_001C: ret

}
ref Vec128<uint> vconvert(in Vec128<ushort> src, out Vec128<uint> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.Vec128`1<System.UInt16>
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse41::ConvertToVector128Int32(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.Vector128::AsUInt32<System.Int32>(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0016: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_001B: stobj Z0.Vec128`1<System.UInt32>
    IL_0020: ldarg.1
    IL_0021: ret

}
ref Vec128<long> vconvert(in Vec128<ushort> src, out Vec128<long> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.Vec128`1<System.UInt16>
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse41::ConvertToVector128Int64(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0011: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0016: stobj Z0.Vec128`1<System.Int64>
    IL_001B: ldarg.1
    IL_001C: ret

}
ref Vec128<ulong> vconvert(in Vec128<ushort> src, out Vec128<ulong> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.Vec128`1<System.UInt16>
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse41::ConvertToVector128Int64(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.Vector128::AsUInt64<System.Int64>(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0016: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_001B: stobj Z0.Vec128`1<System.UInt64>
    IL_0020: ldarg.1
    IL_0021: ret

}
ref Vec128<long> vconvert(in Vec128<int> src, out Vec128<long> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.Vec128`1<System.Int32>
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse41::ConvertToVector128Int64(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0011: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0016: stobj Z0.Vec128`1<System.Int64>
    IL_001B: ldarg.1
    IL_001C: ret

}
ref Vec128<long> vconvert(in Vec128<uint> src, out Vec128<long> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.Vec128`1<System.UInt32>
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse41::ConvertToVector128Int64(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0011: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0016: stobj Z0.Vec128`1<System.Int64>
    IL_001B: ldarg.1
    IL_001C: ret

}
ref Vec128<ulong> vconvert(in Vec128<uint> src, out Vec128<ulong> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.Vec128`1<System.UInt32>
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse41::ConvertToVector128Int64(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.Vector128::AsUInt64<System.Int64>(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0016: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_001B: stobj Z0.Vec128`1<System.UInt64>
    IL_0020: ldarg.1
    IL_0021: ret

}
ref Vec256<short> vconvert(in Vec128<sbyte> src, out Vec256<short> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.Vec128`1<System.SByte>
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::ConvertToVector256Int16(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0011: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0016: stobj Z0.Vec256`1<System.Int16>
    IL_001B: ldarg.1
    IL_001C: ret

}
ref Vec256<int> vconvert(in Vec128<sbyte> src, out Vec256<int> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.Vec128`1<System.SByte>
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::ConvertToVector256Int32(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0011: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0016: stobj Z0.Vec256`1<System.Int32>
    IL_001B: ldarg.1
    IL_001C: ret

}
ref Vec256<long> vconvert(in Vec128<sbyte> src, out Vec256<long> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.Vec128`1<System.SByte>
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::ConvertToVector256Int64(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0011: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0016: stobj Z0.Vec256`1<System.Int64>
    IL_001B: ldarg.1
    IL_001C: ret

}
ref Vec256<short> vconvert(in Vec128<byte> src, out Vec256<short> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.Vec128`1<System.Byte>
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::ConvertToVector256Int16(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0011: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0016: stobj Z0.Vec256`1<System.Int16>
    IL_001B: ldarg.1
    IL_001C: ret

}
ref Vec256<ushort> vconvert(in Vec128<byte> src, out Vec256<ushort> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldfld System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::xmm
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::ConvertToVector256Int16(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.Vector256::AsUInt16<System.Int16>(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0011: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0016: stobj Z0.Vec256`1<System.UInt16>
    IL_001B: ldarg.1
    IL_001C: ret

}
ref Vec256<int> vconvert(in Vec128<byte> src, out Vec256<int> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.Vec128`1<System.Byte>
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::ConvertToVector256Int32(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0011: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0016: stobj Z0.Vec256`1<System.Int32>
    IL_001B: ldarg.1
    IL_001C: ret

}
ref Vec256<uint> vconvert(in Vec128<byte> src, out Vec256<uint> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.Vec128`1<System.Byte>
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::ConvertToVector256Int32(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.Vector256::AsUInt32<System.Int32>(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0016: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_001B: stobj Z0.Vec256`1<System.UInt32>
    IL_0020: ldarg.1
    IL_0021: ret

}
ref Vec256<long> vconvert(in Vec128<byte> src, out Vec256<long> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.Vec128`1<System.Byte>
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::ConvertToVector256Int64(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0011: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0016: stobj Z0.Vec256`1<System.Int64>
    IL_001B: ldarg.1
    IL_001C: ret

}
ref Vec256<ulong> vconvert(in Vec128<byte> src, out Vec256<ulong> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.Vec128`1<System.Byte>
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::ConvertToVector256Int64(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.Vector256::AsUInt64<System.Int64>(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0016: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_001B: stobj Z0.Vec256`1<System.UInt64>
    IL_0020: ldarg.1
    IL_0021: ret

}
ref Vec256<int> vconvert(in Vec128<short> src, out Vec256<int> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.Vec128`1<System.Int16>
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::ConvertToVector256Int32(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0011: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0016: stobj Z0.Vec256`1<System.Int32>
    IL_001B: ldarg.1
    IL_001C: ret

}
ref Vec256<long> vconvert(in Vec128<int> src, out Vec256<long> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.Vec128`1<System.Int32>
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::ConvertToVector256Int64(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0011: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0016: stobj Z0.Vec256`1<System.Int64>
    IL_001B: ldarg.1
    IL_001C: ret

}
ref Vec256<long> vconvert(in Vec128<short> src, out Vec256<long> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.Vec128`1<System.Int16>
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::ConvertToVector256Int64(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0011: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0016: stobj Z0.Vec256`1<System.Int64>
    IL_001B: ldarg.1
    IL_001C: ret

}
ref Vec256<int> vconvert(in Vec128<ushort> src, out Vec256<int> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.Vec128`1<System.UInt16>
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::ConvertToVector256Int32(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0011: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0016: stobj Z0.Vec256`1<System.Int32>
    IL_001B: ldarg.1
    IL_001C: ret

}
ref Vec256<uint> vconvert(in Vec128<ushort> src, out Vec256<uint> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.Vec128`1<System.UInt16>
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::ConvertToVector256Int32(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.Vector256::AsUInt32<System.Int32>(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0016: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_001B: stobj Z0.Vec256`1<System.UInt32>
    IL_0020: ldarg.1
    IL_0021: ret

}
ref Vec256<long> vconvert(in Vec128<ushort> src, out Vec256<long> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.Vec128`1<System.UInt16>
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::ConvertToVector256Int64(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0011: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0016: stobj Z0.Vec256`1<System.Int64>
    IL_001B: ldarg.1
    IL_001C: ret

}
ref Vec256<ulong> vconvert(in Vec128<ushort> src, out Vec256<ulong> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.Vec128`1<System.UInt16>
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::ConvertToVector256Int64(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.Vector256::AsUInt64<System.Int64>(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0016: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_001B: stobj Z0.Vec256`1<System.UInt64>
    IL_0020: ldarg.1
    IL_0021: ret

}
ref Vec256<long> vconvert(in Vec128<uint> src, out Vec256<long> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.Vec128`1<System.UInt32>
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::ConvertToVector256Int64(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0011: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0016: stobj Z0.Vec256`1<System.Int64>
    IL_001B: ldarg.1
    IL_001C: ret

}
ref Vec256<ulong> vconvert(in Vec128<uint> src, out Vec256<ulong> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.Vec128`1<System.UInt32>
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::ConvertToVector256Int64(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.Vector256::AsUInt64<System.Int64>(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0016: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_001B: stobj Z0.Vec256`1<System.UInt64>
    IL_0020: ldarg.1
    IL_0021: ret

}
byte vextract(in Vec128<byte> src, byte pos)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::xmm
    IL_0006: ldarg.1
    IL_0007: call System.Byte System.Runtime.Intrinsics.X86.Sse41::Extract(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Byte)
    IL_000C: ret

}
sbyte vextract(in Vec128<sbyte> src, byte pos)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::xmm
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.Vector128::AsByte<System.SByte>(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_000B: ldarg.1
    IL_000C: call System.Byte System.Runtime.Intrinsics.X86.Sse41::Extract(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Byte)
    IL_0011: conv.i1
    IL_0012: ret

}
short vextract(in Vec128<short> src, byte pos)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::xmm
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.Vector128::AsUInt16<System.Int16>(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: call System.UInt16 System.Runtime.Intrinsics.X86.Sse2::Extract(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Byte)
    IL_0011: conv.i2
    IL_0012: ret

}
ushort vextract(in Vec128<ushort> src, byte pos)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::xmm
    IL_0006: ldarg.1
    IL_0007: call System.UInt16 System.Runtime.Intrinsics.X86.Sse2::Extract(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Byte)
    IL_000C: ret

}
int vextract(in Vec128<int> src, byte pos)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::xmm
    IL_0006: ldarg.1
    IL_0007: call System.Int32 System.Runtime.Intrinsics.X86.Sse41::Extract(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Byte)
    IL_000C: ret

}
uint vextract(in Vec128<uint> src, byte pos)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::xmm
    IL_0006: ldarg.1
    IL_0007: call System.UInt32 System.Runtime.Intrinsics.X86.Sse41::Extract(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Byte)
    IL_000C: ret

}
long vextract(in Vec128<long> src, byte pos)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::xmm
    IL_0006: ldarg.1
    IL_0007: call System.Int64 System.Runtime.Intrinsics.X86.Sse41/X64::Extract(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Byte)
    IL_000C: ret

}
ulong vextract(in Vec128<ulong> src, byte pos)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::xmm
    IL_0006: ldarg.1
    IL_0007: call System.UInt64 System.Runtime.Intrinsics.X86.Sse41/X64::Extract(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Byte)
    IL_000C: ret

}
Vec128<sbyte> vhi(in Vec256<sbyte> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.SByte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>)
    IL_000B: ldc.i4.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Avx::ExtractVector128(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0016: ret

}
Vec128<byte> vhi(in Vec256<byte> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_000B: ldc.i4.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Avx::ExtractVector128(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0016: ret

}
Vec128<short> vhi(in Vec256<short> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>)
    IL_000B: ldc.i4.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Avx::ExtractVector128(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0016: ret

}
Vec128<ushort> vhi(in Vec256<ushort> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt16>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>)
    IL_000B: ldc.i4.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx::ExtractVector128(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0016: ret

}
Vec128<int> vhi(in Vec256<int> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_000B: ldc.i4.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Avx::ExtractVector128(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0016: ret

}
Vec128<uint> vhi(in Vec256<uint> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt32>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>)
    IL_000B: ldc.i4.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx::ExtractVector128(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0016: ret

}
Vec128<long> vhi(in Vec256<long> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int64>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>)
    IL_000B: ldc.i4.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Avx::ExtractVector128(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0016: ret

}
Vec128<ulong> vhi(in Vec256<ulong> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt64>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>)
    IL_000B: ldc.i4.1
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx::ExtractVector128(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0016: ret

}
Vec128<byte> vinsert(byte src, in Vec128<byte> dst, byte index)
{
    IL_0000: ldarg.1
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::xmm
    IL_0006: ldarg.0
    IL_0007: ldarg.2
    IL_0008: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse41::Insert(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Byte,System.Byte)
    IL_000D: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0012: ret

}
Vec128<sbyte> vinsert(sbyte src, in Vec128<sbyte> dst, byte index)
{
    IL_0000: ldarg.1
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::xmm
    IL_0006: ldarg.0
    IL_0007: ldarg.2
    IL_0008: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse41::Insert(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.SByte,System.Byte)
    IL_000D: call Z0.Vec128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0012: ret

}
Vec128<short> vinsert(short src, in Vec128<short> dst, byte index)
{
    IL_0000: ldarg.1
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::xmm
    IL_0006: ldarg.0
    IL_0007: ldarg.2
    IL_0008: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::Insert(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Int16,System.Byte)
    IL_000D: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0012: ret

}
Vec128<ushort> vinsert(ushort src, in Vec128<ushort> dst, byte index)
{
    IL_0000: ldarg.1
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::xmm
    IL_0006: ldarg.0
    IL_0007: ldarg.2
    IL_0008: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::Insert(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.UInt16,System.Byte)
    IL_000D: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0012: ret

}
Vec128<int> vinsert(int src, in Vec128<int> dst, byte index)
{
    IL_0000: ldarg.1
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::xmm
    IL_0006: ldarg.0
    IL_0007: ldarg.2
    IL_0008: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse41::Insert(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Int32,System.Byte)
    IL_000D: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0012: ret

}
Vec128<uint> vinsert(uint src, in Vec128<uint> dst, byte index)
{
    IL_0000: ldarg.1
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::xmm
    IL_0006: ldarg.0
    IL_0007: ldarg.2
    IL_0008: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse41::Insert(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.UInt32,System.Byte)
    IL_000D: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0012: ret

}
Vec128<long> vinsert(long src, in Vec128<long> dst, byte index)
{
    IL_0000: ldarg.1
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::xmm
    IL_0006: ldarg.0
    IL_0007: ldarg.2
    IL_0008: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse41/X64::Insert(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Int64,System.Byte)
    IL_000D: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0012: ret

}
Vec128<ulong> vinsert(ulong src, in Vec128<ulong> dst, byte index)
{
    IL_0000: ldarg.1
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::xmm
    IL_0006: ldarg.0
    IL_0007: ldarg.2
    IL_0008: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse41/X64::Insert(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.UInt64,System.Byte)
    IL_000D: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0012: ret

}
Vec256<sbyte> vinsert(in Vec128<sbyte> src, in Vec256<sbyte> dst, byte index)
{
    IL_0000: ldarg.1
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::ymm
    IL_0006: ldarg.0
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::xmm
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::InsertVector128(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Byte)
    IL_0012: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0017: ret

}
Vec256<byte> vinsert(in Vec128<byte> src, in Vec256<byte> dst, byte index)
{
    IL_0000: ldarg.1
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::ymm
    IL_0006: ldarg.0
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::xmm
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::InsertVector128(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Byte)
    IL_0012: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0017: ret

}
Vec256<short> vinsert(in Vec128<short> src, in Vec256<short> dst, byte index)
{
    IL_0000: ldarg.1
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::ymm
    IL_0006: ldarg.0
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::xmm
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::InsertVector128(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Byte)
    IL_0012: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0017: ret

}
Vec256<ushort> vinsert(in Vec128<ushort> src, in Vec256<ushort> dst, byte index)
{
    IL_0000: ldarg.1
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::ymm
    IL_0006: ldarg.0
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::xmm
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::InsertVector128(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Byte)
    IL_0012: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0017: ret

}
Vec256<int> vinsert(in Vec128<int> src, in Vec256<int> dst, byte index)
{
    IL_0000: ldarg.1
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::ymm
    IL_0006: ldarg.0
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::xmm
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::InsertVector128(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Byte)
    IL_0012: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0017: ret

}
Vec256<uint> insert(in Vec128<uint> src, in Vec256<uint> dst, byte index)
{
    IL_0000: ldarg.1
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::ymm
    IL_0006: ldarg.0
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::xmm
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::InsertVector128(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Byte)
    IL_0012: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0017: ret

}
Vec256<long> vinsert(in Vec128<long> src, in Vec256<long> dst, byte index)
{
    IL_0000: ldarg.1
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::ymm
    IL_0006: ldarg.0
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::xmm
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::InsertVector128(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Byte)
    IL_0012: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0017: ret

}
Vec256<ulong> vinsert(in Vec128<ulong> src, in Vec256<ulong> dst, byte index)
{
    IL_0000: ldarg.1
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::ymm
    IL_0006: ldarg.0
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::xmm
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::InsertVector128(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Byte)
    IL_0012: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0017: ret

}
ref Vec256<byte> insert(in Vec128<byte> lo, in Vec128<byte> hi, out Vec256<byte> dst)
{
    IL_0000: ldarg.2
    IL_0001: ldloca.s V_0
    IL_0003: initobj System.Runtime.Intrinsics.Vector256`1<System.Byte>
    IL_0009: ldloc.0
    IL_000A: ldarg.0
    IL_000B: ldfld System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::xmm
    IL_0010: ldc.i4.0
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::InsertVector128(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Byte)
    IL_0016: ldarg.1
    IL_0017: ldfld System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::xmm
    IL_001C: ldc.i4.1
    IL_001D: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::InsertVector128(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Byte)
    IL_0022: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0027: stobj Z0.Vec256`1<System.Byte>
    IL_002C: ldarg.2
    IL_002D: ret

}
Vec128<sbyte> vlo(in Vec256<sbyte> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.SByte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>)
    IL_000B: ldc.i4.0
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Avx::ExtractVector128(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0016: ret

}
Vec128<byte> vlo(in Vec256<byte> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_000B: ldc.i4.0
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Avx::ExtractVector128(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0016: ret

}
Vec128<short> vlo(in Vec256<short> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>)
    IL_000B: ldc.i4.0
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Avx::ExtractVector128(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0016: ret

}
Vec128<ushort> vlo(in Vec256<ushort> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt16>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>)
    IL_000B: ldc.i4.0
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx::ExtractVector128(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0016: ret

}
Vec128<int> vlo(in Vec256<int> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_000B: ldc.i4.0
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Avx::ExtractVector128(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0016: ret

}
Vec128<uint> vlo(in Vec256<uint> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt32>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>)
    IL_000B: ldc.i4.0
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx::ExtractVector128(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0016: ret

}
Vec128<long> vlo(in Vec256<long> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int64>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>)
    IL_000B: ldc.i4.0
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Avx::ExtractVector128(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0016: ret

}
Vec128<ulong> vlo(in Vec256<ulong> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt64>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>)
    IL_000B: ldc.i4.0
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx::ExtractVector128(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Byte)
    IL_0011: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0016: ret

}
Vec128<byte> vloada128(in byte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Byte* Z0.As::constptr(System.Byte&)
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::LoadAlignedVector128(System.Byte*)
    IL_000B: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0010: ret

}
Vec128<sbyte> vloada128(in sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.SByte* Z0.As::constptr(System.SByte&)
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::LoadAlignedVector128(System.SByte*)
    IL_000B: call Z0.Vec128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0010: ret

}
Vec128<short> vloada128(in short src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int16* Z0.As::constptr(System.Int16&)
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::LoadAlignedVector128(System.Int16*)
    IL_000B: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0010: ret

}
Vec128<ushort> vloada128(in ushort src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt16* Z0.As::constptr(System.UInt16&)
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::LoadAlignedVector128(System.UInt16*)
    IL_000B: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0010: ret

}
Vec128<int> vloada128(in int src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int32* Z0.As::constptr(System.Int32&)
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::LoadAlignedVector128(System.Int32*)
    IL_000B: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0010: ret

}
Vec128<uint> vloada128(in uint src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32* Z0.As::constptr(System.UInt32&)
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::LoadAlignedVector128(System.UInt32*)
    IL_000B: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0010: ret

}
Vec128<long> vloada128(in long src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int64* Z0.As::constptr(System.Int64&)
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse2::LoadAlignedVector128(System.Int64*)
    IL_000B: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0010: ret

}
Vec128<ulong> vloada128(in ulong src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt64* Z0.As::constptr(System.UInt64&)
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::LoadAlignedVector128(System.UInt64*)
    IL_000B: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0010: ret

}
Vec256<byte> vloada256(in byte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Byte* Z0.As::constptr(System.Byte&)
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx::LoadAlignedVector256(System.Byte*)
    IL_000B: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0010: ret

}
Vec256<sbyte> vloada256(in sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.SByte* Z0.As::constptr(System.SByte&)
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx::LoadAlignedVector256(System.SByte*)
    IL_000B: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0010: ret

}
Vec256<short> vloada256(in short src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int16* Z0.As::constptr(System.Int16&)
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx::LoadAlignedVector256(System.Int16*)
    IL_000B: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0010: ret

}
Vec256<ushort> vloada256(in ushort src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt16* Z0.As::constptr(System.UInt16&)
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx::LoadAlignedVector256(System.UInt16*)
    IL_000B: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0010: ret

}
Vec256<int> vloada256(in int src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int32* Z0.As::constptr(System.Int32&)
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx::LoadAlignedVector256(System.Int32*)
    IL_000B: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0010: ret

}
Vec256<uint> vloada256(in uint src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32* Z0.As::constptr(System.UInt32&)
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx::LoadAlignedVector256(System.UInt32*)
    IL_000B: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0010: ret

}
Vec256<long> vloada256(in long src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int64* Z0.As::constptr(System.Int64&)
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx::LoadAlignedVector256(System.Int64*)
    IL_000B: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0010: ret

}
Vec256<ulong> vloada256(in ulong src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt64* Z0.As::constptr(System.UInt64&)
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx::LoadAlignedVector256(System.UInt64*)
    IL_000B: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0010: ret

}
Vec128<byte> vloadu128(in byte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Byte* Z0.As::constptr(System.Byte&)
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse3::LoadDquVector128(System.Byte*)
    IL_000B: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0010: ret

}
Vec128<sbyte> vloadu128(in sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.SByte* Z0.As::constptr(System.SByte&)
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse3::LoadDquVector128(System.SByte*)
    IL_000B: call Z0.Vec128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0010: ret

}
Vec128<short> vloadu128(in short src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int16* Z0.As::constptr(System.Int16&)
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse3::LoadDquVector128(System.Int16*)
    IL_000B: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0010: ret

}
Vec128<ushort> vloadu128(in ushort src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt16* Z0.As::constptr(System.UInt16&)
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse3::LoadDquVector128(System.UInt16*)
    IL_000B: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0010: ret

}
Vec128<int> vloadu128(in int src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int32* Z0.As::constptr(System.Int32&)
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse3::LoadDquVector128(System.Int32*)
    IL_000B: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0010: ret

}
Vec128<uint> vloadu128(in uint src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32* Z0.As::constptr(System.UInt32&)
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse3::LoadDquVector128(System.UInt32*)
    IL_000B: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0010: ret

}
Vec128<long> vloadu128(in long src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int64* Z0.As::constptr(System.Int64&)
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse3::LoadDquVector128(System.Int64*)
    IL_000B: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0010: ret

}
Vec128<ulong> vloadu128(in ulong src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt64* Z0.As::constptr(System.UInt64&)
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse3::LoadDquVector128(System.UInt64*)
    IL_000B: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0010: ret

}
Vec256<byte> vloadu256(in byte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Byte* Z0.As::constptr(System.Byte&)
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx::LoadDquVector256(System.Byte*)
    IL_000B: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0010: ret

}
Vec256<sbyte> vloadu256(in sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.SByte* Z0.As::constptr(System.SByte&)
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx::LoadDquVector256(System.SByte*)
    IL_000B: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0010: ret

}
Vec256<short> vloadu256(in short src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int16* Z0.As::constptr(System.Int16&)
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx::LoadDquVector256(System.Int16*)
    IL_000B: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0010: ret

}
Vec256<ushort> vloadu256(in ushort src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt16* Z0.As::constptr(System.UInt16&)
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx::LoadDquVector256(System.UInt16*)
    IL_000B: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0010: ret

}
Vec256<int> vloadu256(in int src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int32* Z0.As::constptr(System.Int32&)
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx::LoadDquVector256(System.Int32*)
    IL_000B: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0010: ret

}
Vec256<uint> vloadu256(in uint src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32* Z0.As::constptr(System.UInt32&)
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx::LoadDquVector256(System.UInt32*)
    IL_000B: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0010: ret

}
Vec256<long> vloadu256(in long src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int64* Z0.As::constptr(System.Int64&)
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx::LoadDquVector256(System.Int64*)
    IL_000B: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0010: ret

}
Vec256<ulong> vloadu256(in ulong src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt64* Z0.As::constptr(System.UInt64&)
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx::LoadDquVector256(System.UInt64*)
    IL_000B: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0010: ret

}
Vec128<int> vmaskload(ref int src, Vec128<int> mask)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int32* Z0.As::refptr(System.Int32&)
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::MaskLoad(System.Int32*,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0011: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0016: ret

}
Vec256<int> vmaskload(ref int src, Vec256<int> mask)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int32* Z0.As::refptr(System.Int32&)
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::MaskLoad(System.Int32*,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0016: ret

}
Vec256<uint> vmaskload(ref uint src, Vec256<uint> mask)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32* Z0.As::refptr(System.UInt32&)
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::MaskLoad(System.UInt32*,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0011: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0016: ret

}
Vec256<long> vmaskload(ref long src, Vec256<long> mask)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int64* Z0.As::refptr(System.Int64&)
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::MaskLoad(System.Int64*,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0011: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0016: ret

}
Vec256<ulong> vmaskload(ref ulong src, Vec256<ulong> mask)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt64* Z0.As::refptr(System.UInt64&)
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::MaskLoad(System.UInt64*,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0011: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0016: ret

}
void vmaskmove(in Vec128<sbyte> src, in Vec128<sbyte> mask, ref sbyte dst)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::xmm
    IL_000C: ldarg.2
    IL_000D: call System.SByte* Z0.As::refptr(System.SByte&)
    IL_0012: call System.Void System.Runtime.Intrinsics.X86.Sse2::MaskMove(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.SByte*)
    IL_0017: ret

}
void vmaskmove(in Vec128<byte> src, in Vec128<byte> mask, ref byte dst)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::xmm
    IL_000C: ldarg.2
    IL_000D: call System.Byte* Z0.As::refptr(System.Byte&)
    IL_0012: call System.Void System.Runtime.Intrinsics.X86.Sse2::MaskMove(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Byte*)
    IL_0017: ret

}
void vmaskstore(Vec128<int> src, Vec128<int> mask, ref int dst)
{
    IL_0000: ldarg.2
    IL_0001: call System.Int32* Z0.As::refptr(System.Int32&)
    IL_0006: ldarg.0
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_000C: ldarg.1
    IL_000D: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_0012: call System.Void System.Runtime.Intrinsics.X86.Avx2::MaskStore(System.Int32*,System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0017: ret

}
void vmaskstore(Vec256<int> src, Vec256<int> mask, ref int dst)
{
    IL_0000: ldarg.2
    IL_0001: call System.Int32* Z0.As::refptr(System.Int32&)
    IL_0006: ldarg.0
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_000C: ldarg.1
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_0012: call System.Void System.Runtime.Intrinsics.X86.Avx2::MaskStore(System.Int32*,System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0017: ret

}
void vmaskstore(Vec256<uint> src, Vec256<uint> mask, ref uint dst)
{
    IL_0000: ldarg.2
    IL_0001: call System.UInt32* Z0.As::refptr(System.UInt32&)
    IL_0006: ldarg.0
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>)
    IL_000C: ldarg.1
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>)
    IL_0012: call System.Void System.Runtime.Intrinsics.X86.Avx2::MaskStore(System.UInt32*,System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0017: ret

}
void vmaskstore(Vec256<long> src, Vec256<long> mask, ref long dst)
{
    IL_0000: ldarg.2
    IL_0001: call System.Int64* Z0.As::refptr(System.Int64&)
    IL_0006: ldarg.0
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>)
    IL_000C: ldarg.1
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>)
    IL_0012: call System.Void System.Runtime.Intrinsics.X86.Avx2::MaskStore(System.Int64*,System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0017: ret

}
void vmaskstore(Vec256<ulong> src, Vec256<ulong> mask, ref ulong dst)
{
    IL_0000: ldarg.2
    IL_0001: call System.UInt64* Z0.As::refptr(System.UInt64&)
    IL_0006: ldarg.0
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>)
    IL_000C: ldarg.1
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>)
    IL_0012: call System.Void System.Runtime.Intrinsics.X86.Avx2::MaskStore(System.UInt64*,System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0017: ret

}
Vec128<byte> vmov128(in byte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Byte* Z0.As::constptr(System.Byte&)
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::LoadVector128(System.Byte*)
    IL_000B: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0010: ret

}
Vec128<sbyte> vmov128(in sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.SByte* Z0.As::constptr(System.SByte&)
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::LoadVector128(System.SByte*)
    IL_000B: call Z0.Vec128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0010: ret

}
Vec128<short> vmov128(in short src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int16* Z0.As::constptr(System.Int16&)
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::LoadVector128(System.Int16*)
    IL_000B: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0010: ret

}
Vec128<ushort> vmov128(in ushort src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt16* Z0.As::constptr(System.UInt16&)
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::LoadVector128(System.UInt16*)
    IL_000B: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0010: ret

}
Vec128<int> vmov128(in int src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int32* Z0.As::constptr(System.Int32&)
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::LoadVector128(System.Int32*)
    IL_000B: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0010: ret

}
Vec128<uint> vmov128(in uint src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32* Z0.As::constptr(System.UInt32&)
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::LoadVector128(System.UInt32*)
    IL_000B: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0010: ret

}
Vec128<long> vmov128(in long src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int64* Z0.As::constptr(System.Int64&)
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse2::LoadVector128(System.Int64*)
    IL_000B: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0010: ret

}
Vec128<ulong> vmov128(in ulong src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt64* Z0.As::constptr(System.UInt64&)
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::LoadVector128(System.UInt64*)
    IL_000B: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0010: ret

}
Vec256<sbyte> vmov256(in sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.SByte* Z0.As::constptr(System.SByte&)
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx::LoadVector256(System.SByte*)
    IL_000B: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0010: ret

}
Vec256<byte> vmov256(in byte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Byte* Z0.As::constptr(System.Byte&)
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx::LoadVector256(System.Byte*)
    IL_000B: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0010: ret

}
Vec256<short> vmov256(in short src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int16* Z0.As::constptr(System.Int16&)
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx::LoadVector256(System.Int16*)
    IL_000B: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0010: ret

}
Vec256<int> vnegate(in Vec256<int> src)
{
    IL_0000: ldsflda Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::Zero
    IL_0005: ldarg.0
    IL_0006: call Z0.Vec256`1<System.Int32> Z0.dinx::vsub(Z0.Vec256`1<System.Int32>&,Z0.Vec256`1<System.Int32>&)
    IL_000B: ret

}
Vec256<uint> vnegate(in Vec256<uint> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec256`1<System.UInt32> Z0.BitUtil::flip(Z0.Vec256`1<System.UInt32>&)
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: call Z0.Vec256`1<System.UInt32>& modreq(System.Runtime.InteropServices.InAttribute) Z0.Vec256::Ones<System.UInt32>()
    IL_000E: call Z0.Vec256`1<System.UInt32> Z0.dinx::vadd(Z0.Vec256`1<System.UInt32>&,Z0.Vec256`1<System.UInt32>&)
    IL_0013: ret

}
Vec256<long> vnegate(in Vec256<long> src)
{
    IL_0000: ldsflda Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::Zero
    IL_0005: ldarg.0
    IL_0006: call Z0.Vec256`1<System.Int64> Z0.dinx::vsub(Z0.Vec256`1<System.Int64>&,Z0.Vec256`1<System.Int64>&)
    IL_000B: ret

}
Vec256<ulong> vnegate(in Vec256<ulong> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec256`1<System.UInt64> Z0.BitUtil::flip(Z0.Vec256`1<System.UInt64>&)
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: call Z0.Vec256`1<System.UInt64>& modreq(System.Runtime.InteropServices.InAttribute) Z0.Vec256::Ones<System.UInt64>()
    IL_000E: call Z0.Vec256`1<System.UInt64> Z0.dinx::vadd(Z0.Vec256`1<System.UInt64>&,Z0.Vec256`1<System.UInt64>&)
    IL_0013: ret

}
bool vnonz(in Vec128<byte> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000B: ldarg.0
    IL_000C: ldobj Z0.Vec128`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_0016: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestZ(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_001B: ldc.i4.0
    IL_001C: ceq
    IL_001E: ret

}
bool vnonz(in Vec128<sbyte> src)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::xmm
    IL_0006: ldarg.0
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::xmm
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestZ(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0011: ldc.i4.0
    IL_0012: ceq
    IL_0014: ret

}
bool vnonz(in Vec128<short> src)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::xmm
    IL_0006: ldarg.0
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::xmm
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestZ(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0011: ldc.i4.0
    IL_0012: ceq
    IL_0014: ret

}
bool vnonz(in Vec128<ushort> src)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::xmm
    IL_0006: ldarg.0
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::xmm
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestZ(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0011: ldc.i4.0
    IL_0012: ceq
    IL_0014: ret

}
bool vnonz(in Vec128<int> src)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::xmm
    IL_0006: ldarg.0
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::xmm
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestZ(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0011: ldc.i4.0
    IL_0012: ceq
    IL_0014: ret

}
bool vnonz(in Vec128<uint> src)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::xmm
    IL_0006: ldarg.0
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::xmm
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestZ(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0011: ldc.i4.0
    IL_0012: ceq
    IL_0014: ret

}
bool vnonz(in Vec128<long> src)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::xmm
    IL_0006: ldarg.0
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::xmm
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestZ(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0011: ldc.i4.0
    IL_0012: ceq
    IL_0014: ret

}
bool vnonz(in Vec128<ulong> src)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::xmm
    IL_0006: ldarg.0
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::xmm
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Sse41::TestZ(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0011: ldc.i4.0
    IL_0012: ceq
    IL_0014: ret

}
bool vnonz(in Vec128<float> src)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::xmm
    IL_0006: ldarg.0
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Single> Z0.Vec128`1<System.Single>::xmm
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestZ(System.Runtime.Intrinsics.Vector128`1<System.Single>,System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_0011: ldc.i4.0
    IL_0012: ceq
    IL_0014: ret

}
bool vnonz(in Vec128<double> src)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::xmm
    IL_0006: ldarg.0
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Double> Z0.Vec128`1<System.Double>::xmm
    IL_000C: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestZ(System.Runtime.Intrinsics.Vector128`1<System.Double>,System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_0011: ldc.i4.0
    IL_0012: ceq
    IL_0014: ret

}
bool vnonz(in Vec256<byte> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_000B: ldarg.0
    IL_000C: ldobj Z0.Vec256`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_0016: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestZ(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_001B: ldc.i4.0
    IL_001C: ceq
    IL_001E: ret

}
bool vnonz(in Vec256<sbyte> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.SByte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>)
    IL_000B: ldarg.0
    IL_000C: ldobj Z0.Vec256`1<System.SByte>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>)
    IL_0016: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestZ(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_001B: ldc.i4.0
    IL_001C: ceq
    IL_001E: ret

}
bool vnonz(in Vec256<short> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>)
    IL_000B: ldarg.0
    IL_000C: ldobj Z0.Vec256`1<System.Int16>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>)
    IL_0016: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestZ(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_001B: ldc.i4.0
    IL_001C: ceq
    IL_001E: ret

}
bool vnonz(in Vec256<ushort> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt16>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>)
    IL_000B: ldarg.0
    IL_000C: ldobj Z0.Vec256`1<System.UInt16>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>)
    IL_0016: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestZ(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_001B: ldc.i4.0
    IL_001C: ceq
    IL_001E: ret

}
bool vnonz(in Vec256<int> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_000B: ldarg.0
    IL_000C: ldobj Z0.Vec256`1<System.Int32>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_0016: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestZ(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_001B: ldc.i4.0
    IL_001C: ceq
    IL_001E: ret

}
bool vnonz(in Vec256<uint> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt32>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>)
    IL_000B: ldarg.0
    IL_000C: ldobj Z0.Vec256`1<System.UInt32>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>)
    IL_0016: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestZ(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_001B: ldc.i4.0
    IL_001C: ceq
    IL_001E: ret

}
bool vnonz(in Vec256<long> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int64>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>)
    IL_000B: ldarg.0
    IL_000C: ldobj Z0.Vec256`1<System.Int64>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>)
    IL_0016: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestZ(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_001B: ldc.i4.0
    IL_001C: ceq
    IL_001E: ret

}
bool vnonz(in Vec256<ulong> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt64>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>)
    IL_000B: ldarg.0
    IL_000C: ldobj Z0.Vec256`1<System.UInt64>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>)
    IL_0016: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestZ(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_001B: ldc.i4.0
    IL_001C: ceq
    IL_001E: ret

}
bool vnonz(in Vec256<float> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Single>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>)
    IL_000B: ldarg.0
    IL_000C: ldobj Z0.Vec256`1<System.Single>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Single> Z0.Vec256`1<System.Single>::op_Implicit(Z0.Vec256`1<System.Single>)
    IL_0016: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestZ(System.Runtime.Intrinsics.Vector256`1<System.Single>,System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_001B: ldc.i4.0
    IL_001C: ceq
    IL_001E: ret

}
bool vnonz(in Vec256<double> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Double>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>)
    IL_000B: ldarg.0
    IL_000C: ldobj Z0.Vec256`1<System.Double>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Double> Z0.Vec256`1<System.Double>::op_Implicit(Z0.Vec256`1<System.Double>)
    IL_0016: call System.Boolean System.Runtime.Intrinsics.X86.Avx::TestZ(System.Runtime.Intrinsics.Vector256`1<System.Double>,System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_001B: ldc.i4.0
    IL_001C: ceq
    IL_001E: ret

}
Vec128<ushort> vsad(in Vec128<byte> lhs, in Vec128<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::SumAbsoluteDifferences(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0011: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0016: ret

}
Vec256<ushort> vsad(in Vec256<byte> lhs, in Vec256<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::SumAbsoluteDifferences(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0011: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0016: ret

}
Vector128<sbyte> vsign(Vector128<sbyte> lhs, Vector128<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Ssse3::Sign(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0007: ret

}
Vector128<short> vsign(Vector128<short> lhs, Vector128<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Ssse3::Sign(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0007: ret

}
Vector128<int> vsign(Vector128<int> lhs, Vector128<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Ssse3::Sign(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0007: ret

}
Vector256<sbyte> vsign(Vector256<sbyte> lhs, Vector256<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::Sign(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0007: ret

}
Vector256<short> vsign(Vector256<short> lhs, Vector256<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::Sign(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0007: ret

}
Vector256<int> vsign(Vector256<int> lhs, Vector256<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::Sign(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0007: ret

}
Vec128<byte> vsub(in Vec128<byte> x, in Vec128<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::Subtract(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_001B: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0020: ret

}
Vec128<sbyte> vsub(in Vec128<sbyte> x, in Vec128<sbyte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.SByte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.SByte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::Subtract(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_001B: call Z0.Vec128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0020: ret

}
Vec128<short> vsub(in Vec128<short> x, in Vec128<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int16>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::Subtract(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_001B: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0020: ret

}
Vec128<ushort> vsub(in Vec128<ushort> x, in Vec128<ushort> y)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt16>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::Subtract(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_001B: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0020: ret

}
Vec128<int> vsub(in Vec128<int> x, in Vec128<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int32>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::Subtract(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_001B: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0020: ret

}
Vec128<uint> vsub(in Vec128<uint> x, in Vec128<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt32>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(Z0.Vec128`1<System.UInt32>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::Subtract(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_001B: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0020: ret

}
Vec128<long> vsub(in Vec128<long> x, in Vec128<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int64>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(Z0.Vec128`1<System.Int64>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int64>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(Z0.Vec128`1<System.Int64>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse2::Subtract(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_001B: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0020: ret

}
Vec128<ulong> vsub(in Vec128<ulong> x, in Vec128<ulong> y)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt64>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt64>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::Subtract(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_001B: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0020: ret

}
Vec256<byte> vsub(in Vec256<byte> x, in Vec256<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::Subtract(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_001B: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0020: ret

}
Vec256<sbyte> vsub(in Vec256<sbyte> x, in Vec256<sbyte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.SByte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.SByte>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::Subtract(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_001B: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0020: ret

}
Vec256<short> vsub(in Vec256<short> x, in Vec256<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Int16>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::Subtract(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_001B: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0020: ret

}
Vec256<ushort> vsub(in Vec256<ushort> x, in Vec256<ushort> y)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt16>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.UInt16>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::Subtract(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_001B: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0020: ret

}
Vec256<int> vsub(in Vec256<int> x, in Vec256<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Int32>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::Subtract(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_001B: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0020: ret

}
Vec256<uint> vsub(in Vec256<uint> x, in Vec256<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt32>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.UInt32>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::Subtract(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_001B: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0020: ret

}
Vec256<long> vsub(in Vec256<long> x, in Vec256<long> y)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int64>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Int64>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::Subtract(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_001B: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0020: ret

}
Vec256<ulong> vsub(in Vec256<ulong> x, in Vec256<ulong> y)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt64>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.UInt64>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::Subtract(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_001B: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0020: ret

}
Vec128<short> vhsub(in Vec128<short> lhs, in Vec128<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Ssse3::HorizontalSubtract(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0011: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0016: ret

}
Vec128<int> vhsub(in Vec128<int> lhs, in Vec128<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Ssse3::HorizontalSubtract(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0011: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0016: ret

}
Vec256<short> vhsub(in Vec256<short> lhs, in Vec256<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::HorizontalSubtract(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0011: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0016: ret

}
Vec256<int> vhsub(in Vec256<int> lhs, in Vec256<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::HorizontalSubtract(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0016: ret

}
Vec128<byte> subs(in Vec128<byte> x, in Vec128<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::SubtractSaturate(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0011: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0016: ret

}
Vec128<sbyte> subs(in Vec128<sbyte> x, in Vec128<sbyte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::SubtractSaturate(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0011: call Z0.Vec128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0016: ret

}
Vec128<short> subs(in Vec128<short> x, in Vec128<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::SubtractSaturate(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0011: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0016: ret

}
Vec128<ushort> subs(in Vec128<ushort> x, in Vec128<ushort> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::SubtractSaturate(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0011: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0016: ret

}
Vec256<byte> subs(in Vec256<byte> x, in Vec256<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::SubtractSaturate(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0011: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0016: ret

}
Vec256<sbyte> subs(in Vec256<sbyte> x, in Vec256<sbyte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::SubtractSaturate(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0011: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0016: ret

}
Vec256<short> subs(in Vec256<short> x, in Vec256<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::SubtractSaturate(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0011: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0016: ret

}
Vec256<ushort> subs(in Vec256<ushort> x, in Vec256<ushort> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::SubtractSaturate(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0011: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0016: ret

}
Vec128<byte> valignr(in Vec128<byte> x, in Vec128<byte> y, N1 n)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_0016: ldc.i4.1
    IL_0017: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Ssse3::AlignRight(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Byte)
    IL_001C: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0021: ret

}
Vec128<byte> valignr(in Vec128<byte> x, in Vec128<byte> y, N2 n)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_0016: ldc.i4.2
    IL_0017: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Ssse3::AlignRight(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Byte)
    IL_001C: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0021: ret

}
Vec128<byte> valignr(in Vec128<byte> x, in Vec128<byte> y, N3 n)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_0016: ldc.i4.3
    IL_0017: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Ssse3::AlignRight(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Byte)
    IL_001C: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0021: ret

}
Vec128<byte> valignr(in Vec128<byte> x, in Vec128<byte> y, N4 n)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_0016: ldc.i4.4
    IL_0017: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Ssse3::AlignRight(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Byte)
    IL_001C: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0021: ret

}
Vec128<byte> valignr(in Vec128<byte> x, in Vec128<byte> y, N5 n)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_0016: ldc.i4.5
    IL_0017: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Ssse3::AlignRight(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Byte)
    IL_001C: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0021: ret

}
Vec128<byte> valignr(in Vec128<byte> x, in Vec128<byte> y, N6 n)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_0016: ldc.i4.6
    IL_0017: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Ssse3::AlignRight(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Byte)
    IL_001C: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0021: ret

}
Vec128<byte> valignr(in Vec128<byte> x, in Vec128<byte> y, N7 n)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_0016: ldc.i4.7
    IL_0017: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Ssse3::AlignRight(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Byte)
    IL_001C: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0021: ret

}
Vec128<byte> valignr(in Vec128<byte> x, in Vec128<byte> y, N8 n)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_0016: ldc.i4.8
    IL_0017: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Ssse3::AlignRight(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Byte)
    IL_001C: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0021: ret

}
Vec128<byte> valignr(in Vec128<byte> x, in Vec128<byte> y, N9 n)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_0016: ldc.i4.s 9
    IL_0018: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Ssse3::AlignRight(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Byte)
    IL_001D: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0022: ret

}
Vec128<byte> valignr(in Vec128<byte> x, in Vec128<byte> y, N10 n)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_0016: ldc.i4.s 10
    IL_0018: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Ssse3::AlignRight(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Byte)
    IL_001D: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0022: ret

}
Vec256<byte> valignr(in Vec256<byte> x, in Vec256<byte> y, N0 n)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_0016: ldc.i4.0
    IL_0017: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::AlignRight(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Byte)
    IL_001C: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0021: ret

}
Vec256<byte> valignr(in Vec256<byte> x, in Vec256<byte> y, N1 n)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_0016: ldc.i4.1
    IL_0017: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::AlignRight(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Byte)
    IL_001C: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0021: ret

}
Vec256<byte> valignr(in Vec256<byte> x, in Vec256<byte> y, N2 n)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_0016: ldc.i4.2
    IL_0017: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::AlignRight(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Byte)
    IL_001C: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0021: ret

}
Vec256<byte> valignr(in Vec256<byte> x, in Vec256<byte> y, N3 n)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_0016: ldc.i4.3
    IL_0017: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::AlignRight(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Byte)
    IL_001C: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0021: ret

}
Vec256<byte> valignr(in Vec256<byte> x, in Vec256<byte> y, N4 n)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_0016: ldc.i4.4
    IL_0017: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::AlignRight(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Byte)
    IL_001C: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0021: ret

}
Vec256<byte> valignr(in Vec256<byte> x, in Vec256<byte> y, N5 n)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_0016: ldc.i4.5
    IL_0017: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::AlignRight(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Byte)
    IL_001C: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0021: ret

}
Vec256<byte> valignr(in Vec256<byte> x, in Vec256<byte> y, N6 n)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_0016: ldc.i4.6
    IL_0017: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::AlignRight(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Byte)
    IL_001C: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0021: ret

}
Vec256<byte> valignr(in Vec256<byte> x, in Vec256<byte> y, N7 n)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_0016: ldc.i4.7
    IL_0017: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::AlignRight(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Byte)
    IL_001C: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0021: ret

}
Vec256<byte> valignr(in Vec256<byte> x, in Vec256<byte> y, N8 n)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_0016: ldc.i4.8
    IL_0017: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::AlignRight(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Byte)
    IL_001C: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0021: ret

}
Vec256<byte> valignr(in Vec256<byte> x, in Vec256<byte> y, N9 n)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_0016: ldc.i4.s 9
    IL_0018: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::AlignRight(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Byte)
    IL_001D: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0022: ret

}
Vec256<byte> valignr(in Vec256<byte> x, in Vec256<byte> y, N10 n)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_0016: ldc.i4.s 10
    IL_0018: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::AlignRight(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Byte)
    IL_001D: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0022: ret

}
Vec256<byte> valignr(in Vec256<byte> x, in Vec256<byte> y, N11 n)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_0016: ldc.i4.s 11
    IL_0018: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::AlignRight(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Byte)
    IL_001D: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0022: ret

}
Vec128<short> arrangehi(in Vec128<short> src, Arrange4:byte spec)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::xmm
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::ShuffleHigh(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Byte)
    IL_000C: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0011: ret

}
Vec128<ushort> arrangehi(in Vec128<ushort> src, Arrange4:byte spec)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::xmm
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::ShuffleHigh(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Byte)
    IL_000C: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0011: ret

}
Vec128<short> arrangelo(in Vec128<short> src, Arrange4:byte spec)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::xmm
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::ShuffleLow(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Byte)
    IL_000C: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0011: ret

}
Vec128<ushort> arrangelo(in Vec128<ushort> src, Arrange4:byte spec)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::xmm
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::ShuffleLow(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Byte)
    IL_000C: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0011: ret

}
Vec128<short> arrange(in Vec128<short> src, Arrange4:byte lo, Arrange4:byte hi)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.Int16> Z0.dinx::arrangelo(Z0.Vec128`1<System.Int16>&,Z0.Arrange4)
    IL_0007: stloc.0
    IL_0008: ldloca.s V_0
    IL_000A: ldarg.2
    IL_000B: call Z0.Vec128`1<System.Int16> Z0.dinx::arrangehi(Z0.Vec128`1<System.Int16>&,Z0.Arrange4)
    IL_0010: ret

}
Vec128<ushort> arrange(in Vec128<ushort> src, Arrange4:byte lo, Arrange4:byte hi)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.UInt16> Z0.dinx::arrangelo(Z0.Vec128`1<System.UInt16>&,Z0.Arrange4)
    IL_0007: stloc.0
    IL_0008: ldloca.s V_0
    IL_000A: ldarg.2
    IL_000B: call Z0.Vec128`1<System.UInt16> Z0.dinx::arrangehi(Z0.Vec128`1<System.UInt16>&,Z0.Arrange4)
    IL_0010: ret

}
Vec128<uint> arrange(in Vec128<uint> src, Arrange4:byte spec)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::xmm
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::Shuffle(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Byte)
    IL_000C: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0011: ret

}
Vec256<int> arrange(in Vec256<int> src, Arrange4:byte control)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::ymm
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::Shuffle(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Byte)
    IL_000C: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: ret

}
Vec256<uint> arrange(in Vec256<uint> src, Arrange4:byte control)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::ymm
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::Shuffle(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Byte)
    IL_000C: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0011: ret

}
Vec128<short> vblend(in Vec128<short> x, in Vec128<short> y, Blend16x8:byte spec)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::xmm
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse41::Blend(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Byte)
    IL_0012: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0017: ret

}
Vec128<ushort> vblend(in Vec128<ushort> x, in Vec128<ushort> y, Blend16x8:byte spec)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::xmm
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse41::Blend(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Byte)
    IL_0012: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0017: ret

}
Vec128<int> vblend(in Vec128<int> x, in Vec128<int> y, Blend32x4:byte spec)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::xmm
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::Blend(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Byte)
    IL_0012: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0017: ret

}
Vec128<uint> vblend(in Vec128<uint> x, in Vec128<uint> y, Blend32x4:byte spec)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::xmm
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::Blend(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Byte)
    IL_0012: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0017: ret

}
Vec256<short> vblend(in Vec256<short> x, in Vec256<short> y, Blend16x8:byte spec)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::ymm
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::Blend(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Byte)
    IL_0012: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0017: ret

}
Vec256<ushort> vblend(in Vec256<ushort> x, in Vec256<ushort> y, Blend16x8:byte spec)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::ymm
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::Blend(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Byte)
    IL_0012: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0017: ret

}
Vec256<int> vblend(in Vec256<int> x, in Vec256<int> y, Blend32x8:byte spec)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::ymm
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::Blend(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Byte)
    IL_0012: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0017: ret

}
Vec256<uint> vblend(in Vec256<uint> x, in Vec256<uint> y, Blend32x8:byte spec)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::ymm
    IL_000C: ldarg.2
    IL_000D: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::Blend(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Byte)
    IL_0012: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0017: ret

}
Vec128<byte> vblendvar(in Vec128<byte> x, in Vec128<byte> y, in Vec128<byte> spec)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::xmm
    IL_000C: ldarg.2
    IL_000D: ldobj Z0.Vec128`1<System.Byte>
    IL_0012: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_0017: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse41::BlendVariable(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_001C: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0021: ret

}
Vec256<sbyte> vblendvar(in Vec256<sbyte> x, in Vec256<sbyte> y, in Vec256<sbyte> spec)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::ymm
    IL_000C: ldarg.2
    IL_000D: ldobj Z0.Vec256`1<System.SByte>
    IL_0012: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>)
    IL_0017: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::BlendVariable(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_001C: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0021: ret

}
Vec256<byte> vblendvar(in Vec256<byte> x, in Vec256<byte> y, in Vec256<byte> spec)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::ymm
    IL_000C: ldarg.2
    IL_000D: ldobj Z0.Vec256`1<System.Byte>
    IL_0012: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_0017: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::BlendVariable(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_001C: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0021: ret

}
Vec256<short> vblendvar(in Vec256<short> x, in Vec256<short> y, in Vec256<short> spec)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::ymm
    IL_000C: ldarg.2
    IL_000D: ldobj Z0.Vec256`1<System.Int16>
    IL_0012: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>)
    IL_0017: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::BlendVariable(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_001C: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0021: ret

}
Vec256<ushort> vblendvar(in Vec256<ushort> x, in Vec256<ushort> y, in Vec256<ushort> spec)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::ymm
    IL_000C: ldarg.2
    IL_000D: ldobj Z0.Vec256`1<System.UInt16>
    IL_0012: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>)
    IL_0017: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::BlendVariable(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_001C: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0021: ret

}
Vec256<int> vblendvar(in Vec256<int> x, in Vec256<int> y, in Vec256<int> spec)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::ymm
    IL_000C: ldarg.2
    IL_000D: ldobj Z0.Vec256`1<System.Int32>
    IL_0012: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_0017: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::BlendVariable(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_001C: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0021: ret

}
Vec256<uint> vblendvar(in Vec256<uint> x, in Vec256<uint> y, in Vec256<uint> spec)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::ymm
    IL_000C: ldarg.2
    IL_000D: ldobj Z0.Vec256`1<System.UInt32>
    IL_0012: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(Z0.Vec256`1<System.UInt32>)
    IL_0017: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::BlendVariable(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_001C: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0021: ret

}
Vec256<long> vblendvar(in Vec256<long> x, in Vec256<long> y, in Vec256<long> spec)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::ymm
    IL_000C: ldarg.2
    IL_000D: ldobj Z0.Vec256`1<System.Int64>
    IL_0012: call System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(Z0.Vec256`1<System.Int64>)
    IL_0017: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::BlendVariable(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_001C: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0021: ret

}
Vec256<ulong> vblendvar(in Vec256<ulong> x, in Vec256<ulong> y, in Vec256<ulong> spec)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::ymm
    IL_000C: ldarg.2
    IL_000D: ldobj Z0.Vec256`1<System.UInt64>
    IL_0012: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(Z0.Vec256`1<System.UInt64>)
    IL_0017: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::BlendVariable(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_001C: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0021: ret

}
Vec128<sbyte> vbroadcast128(sbyte src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.SByte& Z0.As::asRef<System.SByte>(System.SByte&)
    IL_0007: call System.SByte* Z0.As::refptr(System.SByte&)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::BroadcastScalarToVector128(System.SByte*)
    IL_0011: call Z0.Vec128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0016: ret

}
Vec128<byte> vbroadcast128(byte src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Byte& Z0.As::asRef<System.Byte>(System.Byte&)
    IL_0007: call System.Byte* Z0.As::refptr(System.Byte&)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::BroadcastScalarToVector128(System.Byte*)
    IL_0011: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0016: ret

}
Vec128<short> vbroadcast128(short src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Int16& Z0.As::asRef<System.Int16>(System.Int16&)
    IL_0007: call System.Int16* Z0.As::refptr(System.Int16&)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::BroadcastScalarToVector128(System.Int16*)
    IL_0011: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0016: ret

}
Vec128<ushort> vbroadcast128(ushort src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.UInt16& Z0.As::asRef<System.UInt16>(System.UInt16&)
    IL_0007: call System.UInt16* Z0.As::refptr(System.UInt16&)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::BroadcastScalarToVector128(System.UInt16*)
    IL_0011: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0016: ret

}
Vec128<int> vbroadcast128(int src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Int32& Z0.As::asRef<System.Int32>(System.Int32&)
    IL_0007: call System.Int32* Z0.As::refptr(System.Int32&)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::BroadcastScalarToVector128(System.Int32*)
    IL_0011: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0016: ret

}
Vec128<uint> vbroadcast128(uint src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.UInt32& Z0.As::asRef<System.UInt32>(System.UInt32&)
    IL_0007: call System.UInt32* Z0.As::refptr(System.UInt32&)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::BroadcastScalarToVector128(System.UInt32*)
    IL_0011: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0016: ret

}
Vec128<long> vbroadcast128(long src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Int64& Z0.As::asRef<System.Int64>(System.Int64&)
    IL_0007: call System.Int64* Z0.As::refptr(System.Int64&)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::BroadcastScalarToVector128(System.Int64*)
    IL_0011: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0016: ret

}
Vec128<ulong> vbroadcast128(ulong src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.UInt64& Z0.As::asRef<System.UInt64>(System.UInt64&)
    IL_0007: call System.UInt64* Z0.As::refptr(System.UInt64&)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::BroadcastScalarToVector128(System.UInt64*)
    IL_0011: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0016: ret

}
Vec256<sbyte> vbroadcast256(sbyte src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.SByte& Z0.As::asRef<System.SByte>(System.SByte&)
    IL_0007: call System.SByte* Z0.As::refptr(System.SByte&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::BroadcastScalarToVector256(System.SByte*)
    IL_0011: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0016: ret

}
Vec256<byte> vbroadcast256(byte src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Byte& Z0.As::asRef<System.Byte>(System.Byte&)
    IL_0007: call System.Byte* Z0.As::refptr(System.Byte&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::BroadcastScalarToVector256(System.Byte*)
    IL_0011: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0016: ret

}
Vec256<short> vbroadcast256(short src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Int16& Z0.As::asRef<System.Int16>(System.Int16&)
    IL_0007: call System.Int16* Z0.As::refptr(System.Int16&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::BroadcastScalarToVector256(System.Int16*)
    IL_0011: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0016: ret

}
Vec256<ushort> vbroadcast256(ushort src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.UInt16& Z0.As::asRef<System.UInt16>(System.UInt16&)
    IL_0007: call System.UInt16* Z0.As::refptr(System.UInt16&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::BroadcastScalarToVector256(System.UInt16*)
    IL_0011: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0016: ret

}
Vec256<int> vbroadcast256(int src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Int32& Z0.As::asRef<System.Int32>(System.Int32&)
    IL_0007: call System.Int32* Z0.As::refptr(System.Int32&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::BroadcastScalarToVector256(System.Int32*)
    IL_0011: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0016: ret

}
Vec256<uint> vbroadcast256(uint src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.UInt32& Z0.As::asRef<System.UInt32>(System.UInt32&)
    IL_0007: call System.UInt32* Z0.As::refptr(System.UInt32&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::BroadcastScalarToVector256(System.UInt32*)
    IL_0011: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0016: ret

}
Vec256<long> vbroadcast256(long src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Int64& Z0.As::asRef<System.Int64>(System.Int64&)
    IL_0007: call System.Int64* Z0.As::refptr(System.Int64&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::BroadcastScalarToVector256(System.Int64*)
    IL_0011: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0016: ret

}
Vec256<ulong> vbroadcast256(ulong src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.UInt64& Z0.As::asRef<System.UInt64>(System.UInt64&)
    IL_0007: call System.UInt64* Z0.As::refptr(System.UInt64&)
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::BroadcastScalarToVector256(System.UInt64*)
    IL_0011: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0016: ret

}
ref Vec128<short> vconvert(in Vec128<sbyte> src, out Vec128<short> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.Vec128`1<System.SByte>
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse41::ConvertToVector128Int16(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0011: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0016: stobj Z0.Vec128`1<System.Int16>
    IL_001B: ldarg.1
    IL_001C: ret

}
ref Vec128<int> vconvert(in Vec128<sbyte> src, out Vec128<int> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.Vec128`1<System.SByte>
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse41::ConvertToVector128Int32(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0011: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0016: stobj Z0.Vec128`1<System.Int32>
    IL_001B: ldarg.1
    IL_001C: ret

}
ref Vec128<long> vconvert(in Vec128<sbyte> src, out Vec128<long> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.Vec128`1<System.SByte>
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse41::ConvertToVector128Int64(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0011: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0016: stobj Z0.Vec128`1<System.Int64>
    IL_001B: ldarg.1
    IL_001C: ret

}
ref Vec128<short> vconvert(in Vec128<byte> src, out Vec128<short> dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: ldobj Z0.Vec128`1<System.Byte>
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse41::ConvertToVector128Int16(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0011: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0016: stobj Z0.Vec128`1<System.Int16>
    IL_001B: ldarg.1
    IL_001C: ret

}
Vec128<byte> abs(in Vec128<sbyte> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.SByte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_000B: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Ssse3::Abs(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0010: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0015: ret

}
Vec128<ushort> abs(in Vec128<short> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_000B: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Ssse3::Abs(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0010: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0015: ret

}
Vec128<uint> abs(in Vec128<int> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(Z0.Vec128`1<System.Int32>)
    IL_000B: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Ssse3::Abs(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0010: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0015: ret

}
Vec128<long> abs(in Vec128<long> src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.s 63
    IL_0003: call Z0.Vec128`1<System.Int64> Z0.dinx::vsrl(Z0.Vec128`1<System.Int64>&,System.Byte)
    IL_0008: stloc.1
    IL_0009: ldloca.s V_1
    IL_000B: call Z0.Vec128`1<System.Int64> Z0.dinx::vnegate(Z0.Vec128`1<System.Int64>&)
    IL_0010: stloc.0
    IL_0011: ldloca.s V_0
    IL_0013: ldarg.0
    IL_0014: call Z0.Vec128`1<System.Int64> Z0.dinx::vxor(Z0.Vec128`1<System.Int64>&,Z0.Vec128`1<System.Int64>&)
    IL_0019: stloc.1
    IL_001A: ldloca.s V_1
    IL_001C: ldloca.s V_0
    IL_001E: call Z0.Vec128`1<System.Int64> Z0.dinx::vsub(Z0.Vec128`1<System.Int64>&,Z0.Vec128`1<System.Int64>&)
    IL_0023: ret

}
Vec256<byte> abs(in Vec256<sbyte> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.SByte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>)
    IL_000B: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::Abs(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0010: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0015: ret

}
Vec256<ushort> abs(in Vec256<short> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>)
    IL_000B: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::Abs(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0010: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0015: ret

}
Vec256<uint> abs(in Vec256<int> src)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int32>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(Z0.Vec256`1<System.Int32>)
    IL_000B: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::Abs(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0010: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0015: ret

}
Vec256<long> abs(in Vec256<long> src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.s 63
    IL_0003: call Z0.Vec256`1<System.Int64> Z0.dinx::vsrl(Z0.Vec256`1<System.Int64>&,System.Byte)
    IL_0008: stloc.1
    IL_0009: ldloca.s V_1
    IL_000B: call Z0.Vec256`1<System.Int64> Z0.dinx::vnegate(Z0.Vec256`1<System.Int64>&)
    IL_0010: stloc.0
    IL_0011: ldloca.s V_0
    IL_0013: ldarg.0
    IL_0014: call Z0.Vec256`1<System.Int64> Z0.dinx::vxor(Z0.Vec256`1<System.Int64>&,Z0.Vec256`1<System.Int64>&)
    IL_0019: stloc.1
    IL_001A: ldloca.s V_1
    IL_001C: ldloca.s V_0
    IL_001E: call Z0.Vec256`1<System.Int64> Z0.dinx::vsub(Z0.Vec256`1<System.Int64>&,Z0.Vec256`1<System.Int64>&)
    IL_0023: ret

}
Vec128<byte> vadd(in Vec128<byte> lhs, in Vec128<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::Add(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0011: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0016: ret

}
Vec128<sbyte> vadd(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::Add(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0011: call Z0.Vec128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0016: ret

}
Vec128<short> vadd(in Vec128<short> lhs, in Vec128<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::Add(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0011: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0016: ret

}
Vec128<ushort> vadd(in Vec128<ushort> lhs, in Vec128<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::Add(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0011: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0016: ret

}
Vec128<int> vadd(in Vec128<int> lhs, in Vec128<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse2::Add(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0011: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0016: ret

}
Vec128<uint> vadd(in Vec128<uint> lhs, in Vec128<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse2::Add(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0011: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0016: ret

}
Vec128<long> vadd(in Vec128<long> lhs, in Vec128<long> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int64> Z0.Vec128`1<System.Int64>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse2::Add(System.Runtime.Intrinsics.Vector128`1<System.Int64>,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0011: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0016: ret

}
Vec128<ulong> vadd(in Vec128<ulong> lhs, in Vec128<ulong> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::Add(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0011: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0016: ret

}
Vec256<byte> vadd(in Vec256<byte> lhs, in Vec256<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::Add(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0011: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0016: ret

}
Vec256<sbyte> vadd(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::Add(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0011: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0016: ret

}
Vec256<short> vadd(in Vec256<short> lhs, in Vec256<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::Add(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0011: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0016: ret

}
Vec256<ushort> vadd(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::Add(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0011: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0016: ret

}
Vec256<int> vadd(in Vec256<int> lhs, in Vec256<int> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::Add(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0016: ret

}
Vec256<uint> vadd(in Vec256<uint> lhs, in Vec256<uint> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::Add(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0011: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0016: ret

}
Vec256<long> vadd(in Vec256<long> lhs, in Vec256<long> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int64> Z0.Vec256`1<System.Int64>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::Add(System.Runtime.Intrinsics.Vector256`1<System.Int64>,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0011: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0016: ret

}
Vec256<ulong> vadd(in Vec256<ulong> lhs, in Vec256<ulong> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::Add(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0011: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0016: ret

}
Vec128<byte> vadds(in Vec128<byte> lhs, in Vec128<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::AddSaturate(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_001B: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0020: ret

}
Vec128<sbyte> vadds(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.SByte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.SByte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(Z0.Vec128`1<System.SByte>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse2::AddSaturate(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_001B: call Z0.Vec128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0020: ret

}
Vec128<short> vadds(in Vec128<short> lhs, in Vec128<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Int16>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(Z0.Vec128`1<System.Int16>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::AddSaturate(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_001B: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0020: ret

}
Vec128<ushort> vadds(in Vec128<ushort> lhs, in Vec128<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt16>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::AddSaturate(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_001B: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0020: ret

}
Vec256<byte> vadds(in Vec256<byte> lhs, in Vec256<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::AddSaturate(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_001B: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0020: ret

}
Vec256<sbyte> vadds(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.SByte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.SByte>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(Z0.Vec256`1<System.SByte>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::AddSaturate(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_001B: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0020: ret

}
Vec256<short> vadds(in Vec256<short> lhs, in Vec256<short> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Int16>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Int16>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(Z0.Vec256`1<System.Int16>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::AddSaturate(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_001B: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0020: ret

}
Vec256<ushort> vadds(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt16>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.UInt16>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::AddSaturate(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_001B: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0020: ret

}
Vec128<byte> vavg(in Vec128<byte> lhs, in Vec128<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(Z0.Vec128`1<System.Byte>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::Average(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_001B: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0020: ret

}
Vec128<ushort> vavg(in Vec128<ushort> lhs, in Vec128<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt16>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt16>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(Z0.Vec128`1<System.UInt16>)
    IL_0016: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse2::Average(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_001B: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0020: ret

}
Vec256<byte> vavg(in Vec256<byte> lhs, in Vec256<byte> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.Byte>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.Byte>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(Z0.Vec256`1<System.Byte>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::Average(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_001B: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0020: ret

}
Vec256<ushort> vavg(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec256`1<System.UInt16>
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec256`1<System.UInt16>
    IL_0011: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(Z0.Vec256`1<System.UInt16>)
    IL_0016: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::Average(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_001B: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0020: ret

}
byte clmulr(byte a, byte b, ushort poly)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt16 Z0.dinx::clmul(System.Byte,System.Byte)
    IL_0007: stloc.0
    IL_0008: ldloc.0
    IL_0009: ldloc.0
    IL_000A: ldc.i4.8
    IL_000B: shr
    IL_000C: conv.u2
    IL_000D: ldarg.2
    IL_000E: call System.UInt32 Z0.dinx::clmul(System.UInt16,System.UInt16)
    IL_0013: conv.u2
    IL_0014: xor
    IL_0015: conv.u2
    IL_0016: stloc.0
    IL_0017: ldloc.0
    IL_0018: ldloc.0
    IL_0019: ldc.i4.8
    IL_001A: shr
    IL_001B: conv.u2
    IL_001C: ldarg.2
    IL_001D: call System.UInt32 Z0.dinx::clmul(System.UInt16,System.UInt16)
    IL_0022: conv.u2
    IL_0023: xor
    IL_0024: conv.u2
    IL_0025: stloc.0
    IL_0026: ldloc.0
    IL_0027: conv.u1
    IL_0028: ret

}
ushort clmulr(ushort a, ushort b, uint poly)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.dinx::clmul(System.UInt16,System.UInt16)
    IL_0007: stloc.0
    IL_0008: ldloc.0
    IL_0009: ldloc.0
    IL_000A: ldc.i4.s 16
    IL_000C: shr.un
    IL_000D: ldarg.2
    IL_000E: call System.UInt64 Z0.dinx::clmul(System.UInt32,System.UInt32)
    IL_0013: conv.u4
    IL_0014: xor
    IL_0015: stloc.0
    IL_0016: ldloc.0
    IL_0017: ldloc.0
    IL_0018: ldc.i4.s 16
    IL_001A: shr.un
    IL_001B: ldarg.2
    IL_001C: call System.UInt64 Z0.dinx::clmul(System.UInt32,System.UInt32)
    IL_0021: conv.u4
    IL_0022: xor
    IL_0023: stloc.0
    IL_0024: ldloc.0
    IL_0025: conv.u2
    IL_0026: ret

}
uint clmulr(uint a, uint b, ulong poly)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.dinx::clmul(System.UInt32,System.UInt32)
    IL_0007: stloc.0
    IL_0008: ldloc.0
    IL_0009: ldloc.0
    IL_000A: ldc.i4.s 32
    IL_000C: shr.un
    IL_000D: ldarg.2
    IL_000E: call Z0.UInt128 Z0.dinx::clmul(System.UInt64,System.UInt64)
    IL_0013: ldfld System.UInt64 Z0.UInt128::lo
    IL_0018: xor
    IL_0019: stloc.0
    IL_001A: ldloc.0
    IL_001B: ldloc.0
    IL_001C: ldc.i4.s 32
    IL_001E: shr.un
    IL_001F: ldarg.2
    IL_0020: call Z0.UInt128 Z0.dinx::clmul(System.UInt64,System.UInt64)
    IL_0025: ldfld System.UInt64 Z0.UInt128::lo
    IL_002A: xor
    IL_002B: stloc.0
    IL_002C: ldloc.0
    IL_002D: conv.u4
    IL_002E: ret

}
UInt128 clmul(ulong lhs, ulong rhs)
{
    IL_0000: ldarga.s lhs
    IL_0002: call Z0.Vec128`1<System.UInt64> Z0.Vec128::LoadScalar<System.UInt64>(System.UInt64&)
    IL_0007: stloc.0
    IL_0008: ldarga.s rhs
    IL_000A: call Z0.Vec128`1<System.UInt64> Z0.Vec128::LoadScalar<System.UInt64>(System.UInt64&)
    IL_000F: stloc.1
    IL_0010: ldloc.0
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_0016: ldloc.1
    IL_0017: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_001C: ldc.i4.0
    IL_001D: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Pclmulqdq::CarrylessMultiply(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Byte)
    IL_0022: stloc.2
    IL_0023: ldloca.s V_2
    IL_0025: call Z0.UInt128 Z0.UInt128::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>&)
    IL_002A: ret

}
Vec128<ulong> clmul(Scalar128<ulong> a, Scalar128<ulong> b)
{
    IL_0000: ldarg.0
    IL_0001: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Scalar128`1<System.UInt64>::op_Implicit(Z0.Scalar128`1<System.UInt64>)
    IL_0006: ldarg.1
    IL_0007: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Scalar128`1<System.UInt64>::op_Implicit(Z0.Scalar128`1<System.UInt64>)
    IL_000C: ldc.i4.0
    IL_000D: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Pclmulqdq::CarrylessMultiply(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Byte)
    IL_0012: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0017: ret

}
Vec128<ulong> clmul(in Vec128<ulong> lhs, in Vec128<ulong> rhs, ClMulMask:byte mask)
{
    IL_0000: ldarg.0
    IL_0001: ldobj Z0.Vec128`1<System.UInt64>
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_000B: ldarg.1
    IL_000C: ldobj Z0.Vec128`1<System.UInt64>
    IL_0011: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_0016: ldarg.2
    IL_0017: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Pclmulqdq::CarrylessMultiply(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Byte)
    IL_001C: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0021: ret

}
ushort clmul(byte lhs, byte rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.dinx::clmul(System.UInt32,System.UInt32)
    IL_0007: conv.u2
    IL_0008: ret

}
uint clmul(ushort lhs, ushort rhs)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.dinx::clmul(System.UInt32,System.UInt32)
    IL_0007: conv.u4
    IL_0008: ret

}
ulong clmul(uint lhs, uint rhs)
{
    IL_0000: ldarg.0
    IL_0001: conv.u8
    IL_0002: ldarg.1
    IL_0003: conv.u8
    IL_0004: call Z0.UInt128 Z0.dinx::clmul(System.UInt64,System.UInt64)
    IL_0009: ldfld System.UInt64 Z0.UInt128::lo
    IL_000E: ret

}
Scalar128<ulong> clmulr(Scalar128<ulong> a, Scalar128<ulong> b, Vec128<ulong> poly)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.Vec128`1<System.UInt64> Z0.dinx::clmul(Z0.Scalar128`1<System.UInt64>,Z0.Scalar128`1<System.UInt64>)
    IL_0007: stloc.0
    IL_0008: ldloca.s V_0
    IL_000A: ldloca.s V_0
    IL_000C: ldc.i4.s 64
    IL_000E: call Z0.Vec128`1<System.UInt64> Z0.dinx::vsrl(Z0.Vec128`1<System.UInt64>&,System.Byte)
    IL_0013: stloc.1
    IL_0014: ldloca.s V_1
    IL_0016: ldarga.s poly
    IL_0018: ldc.i4.0
    IL_0019: call Z0.Vec128`1<System.UInt64> Z0.dinx::clmul(Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&,Z0.ClMulMask)
    IL_001E: stloc.2
    IL_001F: ldloca.s V_2
    IL_0021: call Z0.Vec128`1<System.UInt64> Z0.dinx::vxor(Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&)
    IL_0026: stloc.0
    IL_0027: ldloca.s V_0
    IL_0029: ldloca.s V_0
    IL_002B: ldc.i4.s 64
    IL_002D: call Z0.Vec128`1<System.UInt64> Z0.dinx::vsrl(Z0.Vec128`1<System.UInt64>&,System.Byte)
    IL_0032: stloc.1
    IL_0033: ldloca.s V_1
    IL_0035: ldarga.s poly
    IL_0037: ldc.i4.0
    IL_0038: call Z0.Vec128`1<System.UInt64> Z0.dinx::clmul(Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&,Z0.ClMulMask)
    IL_003D: stloc.2
    IL_003E: ldloca.s V_2
    IL_0040: call Z0.Vec128`1<System.UInt64> Z0.dinx::vxor(Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&)
    IL_0045: stloc.0
    IL_0046: ldloc.0
    IL_0047: call Z0.Scalar128`1<System.UInt64> Z0.Scalar128`1<System.UInt64>::op_Implicit(Z0.Vec128`1<System.UInt64>)
    IL_004C: ret

}
ref Vec512<ulong> clmul(in Vec128<ulong> lhs, in Vec128<ulong> rhs, out Vec512<ulong> dst)
{
    IL_0000: ldarg.2
    IL_0001: ldarg.0
    IL_0002: ldarg.1
    IL_0003: ldc.i4.0
    IL_0004: call Z0.Vec128`1<System.UInt64> Z0.dinx::clmul(Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&,Z0.ClMulMask)
    IL_0009: ldarg.0
    IL_000A: ldarg.1
    IL_000B: ldc.i4.1
    IL_000C: call Z0.Vec128`1<System.UInt64> Z0.dinx::clmul(Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&,Z0.ClMulMask)
    IL_0011: ldarg.0
    IL_0012: ldarg.1
    IL_0013: ldc.i4.s 16
    IL_0015: call Z0.Vec128`1<System.UInt64> Z0.dinx::clmul(Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&,Z0.ClMulMask)
    IL_001A: ldarg.0
    IL_001B: ldarg.1
    IL_001C: ldc.i4.s 17
    IL_001E: call Z0.Vec128`1<System.UInt64> Z0.dinx::clmul(Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&,Z0.ClMulMask)
    IL_0023: call Z0.Vec512`1<System.UInt64> Z0.Vec512::FromParts<System.UInt64>(Z0.Vec128`1<System.UInt64>,Z0.Vec128`1<System.UInt64>,Z0.Vec128`1<System.UInt64>,Z0.Vec128`1<System.UInt64>)
    IL_0028: stobj Z0.Vec512`1<System.UInt64>
    IL_002D: ldarg.2
    IL_002E: ret

}
Vec128<sbyte> vdec(in Vec128<sbyte> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.SByte>& modreq(System.Runtime.InteropServices.InAttribute) Z0.Vec128Pattern::units<System.SByte>()
    IL_0006: call Z0.Vec128`1<System.SByte> Z0.dinx::vsub(Z0.Vec128`1<System.SByte>&,Z0.Vec128`1<System.SByte>&)
    IL_000B: ret

}
Vec128<byte> vdec(in Vec128<byte> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.Byte>& modreq(System.Runtime.InteropServices.InAttribute) Z0.Vec128Pattern::units<System.Byte>()
    IL_0006: call Z0.Vec128`1<System.Byte> Z0.dinx::vsub(Z0.Vec128`1<System.Byte>&,Z0.Vec128`1<System.Byte>&)
    IL_000B: ret

}
Vec128<short> vdec(in Vec128<short> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.Int16>& modreq(System.Runtime.InteropServices.InAttribute) Z0.Vec128Pattern::units<System.Int16>()
    IL_0006: call Z0.Vec128`1<System.Int16> Z0.dinx::vsub(Z0.Vec128`1<System.Int16>&,Z0.Vec128`1<System.Int16>&)
    IL_000B: ret

}
Vec128<ushort> vdec(in Vec128<ushort> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.UInt16>& modreq(System.Runtime.InteropServices.InAttribute) Z0.Vec128Pattern::units<System.UInt16>()
    IL_0006: call Z0.Vec128`1<System.UInt16> Z0.dinx::vsub(Z0.Vec128`1<System.UInt16>&,Z0.Vec128`1<System.UInt16>&)
    IL_000B: ret

}
Vec128<int> vdec(in Vec128<int> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.Int32>& modreq(System.Runtime.InteropServices.InAttribute) Z0.Vec128Pattern::units<System.Int32>()
    IL_0006: call Z0.Vec128`1<System.Int32> Z0.dinx::vsub(Z0.Vec128`1<System.Int32>&,Z0.Vec128`1<System.Int32>&)
    IL_000B: ret

}
Vec128<uint> vdec(in Vec128<uint> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.UInt32>& modreq(System.Runtime.InteropServices.InAttribute) Z0.Vec128Pattern::units<System.UInt32>()
    IL_0006: call Z0.Vec128`1<System.UInt32> Z0.dinx::vsub(Z0.Vec128`1<System.UInt32>&,Z0.Vec128`1<System.UInt32>&)
    IL_000B: ret

}
Vec128<long> vdec(in Vec128<long> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.Int64>& modreq(System.Runtime.InteropServices.InAttribute) Z0.Vec128Pattern::units<System.Int64>()
    IL_0006: call Z0.Vec128`1<System.Int64> Z0.dinx::vsub(Z0.Vec128`1<System.Int64>&,Z0.Vec128`1<System.Int64>&)
    IL_000B: ret

}
Vec128<ulong> vdec(in Vec128<ulong> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.UInt64>& modreq(System.Runtime.InteropServices.InAttribute) Z0.Vec128Pattern::units<System.UInt64>()
    IL_0006: call Z0.Vec128`1<System.UInt64> Z0.dinx::vsub(Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&)
    IL_000B: ret

}
Vec256<sbyte> vdec(in Vec256<sbyte> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec256`1<System.SByte>& modreq(System.Runtime.InteropServices.InAttribute) Z0.Vec256Pattern::Units<System.SByte>()
    IL_0006: call Z0.Vec256`1<System.SByte> Z0.dinx::vsub(Z0.Vec256`1<System.SByte>&,Z0.Vec256`1<System.SByte>&)
    IL_000B: ret

}
Vec256<byte> vdec(in Vec256<byte> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec256`1<System.Byte>& modreq(System.Runtime.InteropServices.InAttribute) Z0.Vec256Pattern::Units<System.Byte>()
    IL_0006: call Z0.Vec256`1<System.Byte> Z0.dinx::vsub(Z0.Vec256`1<System.Byte>&,Z0.Vec256`1<System.Byte>&)
    IL_000B: ret

}
Vec256<short> vdec(in Vec256<short> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec256`1<System.Int16>& modreq(System.Runtime.InteropServices.InAttribute) Z0.Vec256Pattern::Units<System.Int16>()
    IL_0006: call Z0.Vec256`1<System.Int16> Z0.dinx::vsub(Z0.Vec256`1<System.Int16>&,Z0.Vec256`1<System.Int16>&)
    IL_000B: ret

}
Vec256<ushort> vdec(in Vec256<ushort> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec256`1<System.UInt16>& modreq(System.Runtime.InteropServices.InAttribute) Z0.Vec256Pattern::Units<System.UInt16>()
    IL_0006: call Z0.Vec256`1<System.UInt16> Z0.dinx::vsub(Z0.Vec256`1<System.UInt16>&,Z0.Vec256`1<System.UInt16>&)
    IL_000B: ret

}
Vec256<int> vdec(in Vec256<int> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec256`1<System.Int32>& modreq(System.Runtime.InteropServices.InAttribute) Z0.Vec256Pattern::Units<System.Int32>()
    IL_0006: call Z0.Vec256`1<System.Int32> Z0.dinx::vsub(Z0.Vec256`1<System.Int32>&,Z0.Vec256`1<System.Int32>&)
    IL_000B: ret

}
Vec256<uint> vdec(in Vec256<uint> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec256`1<System.UInt32>& modreq(System.Runtime.InteropServices.InAttribute) Z0.Vec256Pattern::Units<System.UInt32>()
    IL_0006: call Z0.Vec256`1<System.UInt32> Z0.dinx::vsub(Z0.Vec256`1<System.UInt32>&,Z0.Vec256`1<System.UInt32>&)
    IL_000B: ret

}
Vec256<long> vdec(in Vec256<long> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec256`1<System.Int64>& modreq(System.Runtime.InteropServices.InAttribute) Z0.Vec256Pattern::Units<System.Int64>()
    IL_0006: call Z0.Vec256`1<System.Int64> Z0.dinx::vsub(Z0.Vec256`1<System.Int64>&,Z0.Vec256`1<System.Int64>&)
    IL_000B: ret

}
Vec256<ulong> vdec(in Vec256<ulong> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec256`1<System.UInt64>& modreq(System.Runtime.InteropServices.InAttribute) Z0.Vec256Pattern::Units<System.UInt64>()
    IL_0006: call Z0.Vec256`1<System.UInt64> Z0.dinx::vsub(Z0.Vec256`1<System.UInt64>&,Z0.Vec256`1<System.UInt64>&)
    IL_000B: ret

}
long vdot(Vec256<int> lhs, Vec256<int> rhs)
{
    IL_0000: ldarga.s lhs
    IL_0002: ldarga.s rhs
    IL_0004: call Z0.Vec256`1<System.Int64> Z0.dinx::vmul(Z0.Vec256`1<System.Int32>&,Z0.Vec256`1<System.Int32>&)
    IL_0009: stloc.0
    IL_000A: ldloca.s V_0
    IL_000C: call Z0.Vec128`1<System.Int64> Z0.dinx::vlo(Z0.Vec256`1<System.Int64>&)
    IL_0011: stloc.3
    IL_0012: ldloca.s V_3
    IL_0014: ldloca.s V_0
    IL_0016: call Z0.Vec128`1<System.Int64> Z0.dinx::vhi(Z0.Vec256`1<System.Int64>&)
    IL_001B: stloc.s V_4
    IL_001D: ldloca.s V_4
    IL_001F: call Z0.Vec128`1<System.Int64> Z0.dinx::vadd(Z0.Vec128`1<System.Int64>&,Z0.Vec128`1<System.Int64>&)
    IL_0024: stloc.1
    IL_0025: ldloc.1
    IL_0026: call Z0.Span128`1<System.Int64> Z0.VSpanX::ToSpan128<System.Int64>(Z0.Vec128`1<System.Int64>)
    IL_002B: stloc.2
    IL_002C: ldloca.s V_2
    IL_002E: ldc.i4.0
    IL_002F: call System.Int64& Z0.Span128`1<System.Int64>::get_Item(System.Int32)
    IL_0034: ldind.i8
    IL_0035: ldloca.s V_2
    IL_0037: ldc.i4.1
    IL_0038: call System.Int64& Z0.Span128`1<System.Int64>::get_Item(System.Int32)
    IL_003D: ldind.i8
    IL_003E: add
    IL_003F: ret

}
ulong vdot(Vec256<uint> lhs, Vec256<uint> rhs)
{
    IL_0000: ldarga.s lhs
    IL_0002: ldarga.s rhs
    IL_0004: call Z0.Vec256`1<System.UInt64> Z0.dinx::vmul(Z0.Vec256`1<System.UInt32>&,Z0.Vec256`1<System.UInt32>&)
    IL_0009: stloc.0
    IL_000A: ldloca.s V_0
    IL_000C: call Z0.Vec128`1<System.UInt64> Z0.dinx::vlo(Z0.Vec256`1<System.UInt64>&)
    IL_0011: stloc.3
    IL_0012: ldloca.s V_3
    IL_0014: ldloca.s V_0
    IL_0016: call Z0.Vec128`1<System.UInt64> Z0.dinx::vhi(Z0.Vec256`1<System.UInt64>&)
    IL_001B: stloc.s V_4
    IL_001D: ldloca.s V_4
    IL_001F: call Z0.Vec128`1<System.UInt64> Z0.dinx::vadd(Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&)
    IL_0024: stloc.1
    IL_0025: ldloc.1
    IL_0026: call Z0.Span128`1<System.UInt64> Z0.VSpanX::ToSpan128<System.UInt64>(Z0.Vec128`1<System.UInt64>)
    IL_002B: stloc.2
    IL_002C: ldloca.s V_2
    IL_002E: ldc.i4.0
    IL_002F: call System.UInt64& Z0.Span128`1<System.UInt64>::get_Item(System.Int32)
    IL_0034: ldind.i8
    IL_0035: ldloca.s V_2
    IL_0037: ldc.i4.1
    IL_0038: call System.UInt64& Z0.Span128`1<System.UInt64>::get_Item(System.Int32)
    IL_003D: ldind.i8
    IL_003E: add
    IL_003F: ret

}
Vec128<short> vhadd(in Vec128<short> x, in Vec128<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Ssse3::HorizontalAdd(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0011: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0016: ret

}
Vec128<int> vhadd(in Vec128<int> x, in Vec128<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Ssse3::HorizontalAdd(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0011: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0016: ret

}
Vec256<short> vhadd(in Vec256<short> x, in Vec256<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::HorizontalAdd(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0011: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0016: ret

}
Vec256<int> vhadd(in Vec256<int> x, in Vec256<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::HorizontalAdd(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0016: ret

}
Vec128<sbyte> vinc(in Vec128<sbyte> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.SByte>& modreq(System.Runtime.InteropServices.InAttribute) Z0.Vec128Pattern::units<System.SByte>()
    IL_0006: call Z0.Vec128`1<System.SByte> Z0.dinx::vadd(Z0.Vec128`1<System.SByte>&,Z0.Vec128`1<System.SByte>&)
    IL_000B: ret

}
Vec128<byte> vinc(in Vec128<byte> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.Byte>& modreq(System.Runtime.InteropServices.InAttribute) Z0.Vec128Pattern::units<System.Byte>()
    IL_0006: call Z0.Vec128`1<System.Byte> Z0.dinx::vadd(Z0.Vec128`1<System.Byte>&,Z0.Vec128`1<System.Byte>&)
    IL_000B: ret

}
Vec128<short> vinc(in Vec128<short> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.Int16>& modreq(System.Runtime.InteropServices.InAttribute) Z0.Vec128Pattern::units<System.Int16>()
    IL_0006: call Z0.Vec128`1<System.Int16> Z0.dinx::vadd(Z0.Vec128`1<System.Int16>&,Z0.Vec128`1<System.Int16>&)
    IL_000B: ret

}
Vec128<ushort> vinc(in Vec128<ushort> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.UInt16>& modreq(System.Runtime.InteropServices.InAttribute) Z0.Vec128Pattern::units<System.UInt16>()
    IL_0006: call Z0.Vec128`1<System.UInt16> Z0.dinx::vadd(Z0.Vec128`1<System.UInt16>&,Z0.Vec128`1<System.UInt16>&)
    IL_000B: ret

}
Vec128<int> vinc(in Vec128<int> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.Int32>& modreq(System.Runtime.InteropServices.InAttribute) Z0.Vec128Pattern::units<System.Int32>()
    IL_0006: call Z0.Vec128`1<System.Int32> Z0.dinx::vadd(Z0.Vec128`1<System.Int32>&,Z0.Vec128`1<System.Int32>&)
    IL_000B: ret

}
Vec128<uint> vinc(in Vec128<uint> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.UInt32>& modreq(System.Runtime.InteropServices.InAttribute) Z0.Vec128Pattern::units<System.UInt32>()
    IL_0006: call Z0.Vec128`1<System.UInt32> Z0.dinx::vadd(Z0.Vec128`1<System.UInt32>&,Z0.Vec128`1<System.UInt32>&)
    IL_000B: ret

}
Vec128<long> vinc(in Vec128<long> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.Int64>& modreq(System.Runtime.InteropServices.InAttribute) Z0.Vec128Pattern::units<System.Int64>()
    IL_0006: call Z0.Vec128`1<System.Int64> Z0.dinx::vadd(Z0.Vec128`1<System.Int64>&,Z0.Vec128`1<System.Int64>&)
    IL_000B: ret

}
Vec128<ulong> vinc(in Vec128<ulong> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.UInt64>& modreq(System.Runtime.InteropServices.InAttribute) Z0.Vec128Pattern::units<System.UInt64>()
    IL_0006: call Z0.Vec128`1<System.UInt64> Z0.dinx::vadd(Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&)
    IL_000B: ret

}
Vec256<sbyte> vinc(in Vec256<sbyte> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec256`1<System.SByte>& modreq(System.Runtime.InteropServices.InAttribute) Z0.Vec256Pattern::Units<System.SByte>()
    IL_0006: call Z0.Vec256`1<System.SByte> Z0.dinx::vadd(Z0.Vec256`1<System.SByte>&,Z0.Vec256`1<System.SByte>&)
    IL_000B: ret

}
Vec256<byte> vinc(in Vec256<byte> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec256`1<System.Byte>& modreq(System.Runtime.InteropServices.InAttribute) Z0.Vec256Pattern::Units<System.Byte>()
    IL_0006: call Z0.Vec256`1<System.Byte> Z0.dinx::vadd(Z0.Vec256`1<System.Byte>&,Z0.Vec256`1<System.Byte>&)
    IL_000B: ret

}
Vec256<short> vinc(in Vec256<short> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec256`1<System.Int16>& modreq(System.Runtime.InteropServices.InAttribute) Z0.Vec256Pattern::Units<System.Int16>()
    IL_0006: call Z0.Vec256`1<System.Int16> Z0.dinx::vadd(Z0.Vec256`1<System.Int16>&,Z0.Vec256`1<System.Int16>&)
    IL_000B: ret

}
Vec256<ushort> vinc(in Vec256<ushort> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec256`1<System.UInt16>& modreq(System.Runtime.InteropServices.InAttribute) Z0.Vec256Pattern::Units<System.UInt16>()
    IL_0006: call Z0.Vec256`1<System.UInt16> Z0.dinx::vadd(Z0.Vec256`1<System.UInt16>&,Z0.Vec256`1<System.UInt16>&)
    IL_000B: ret

}
Vec256<int> vinc(in Vec256<int> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec256`1<System.Int32>& modreq(System.Runtime.InteropServices.InAttribute) Z0.Vec256Pattern::Units<System.Int32>()
    IL_0006: call Z0.Vec256`1<System.Int32> Z0.dinx::vadd(Z0.Vec256`1<System.Int32>&,Z0.Vec256`1<System.Int32>&)
    IL_000B: ret

}
Vec256<uint> vinc(in Vec256<uint> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec256`1<System.UInt32>& modreq(System.Runtime.InteropServices.InAttribute) Z0.Vec256Pattern::Units<System.UInt32>()
    IL_0006: call Z0.Vec256`1<System.UInt32> Z0.dinx::vadd(Z0.Vec256`1<System.UInt32>&,Z0.Vec256`1<System.UInt32>&)
    IL_000B: ret

}
Vec256<long> vinc(in Vec256<long> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec256`1<System.Int64>& modreq(System.Runtime.InteropServices.InAttribute) Z0.Vec256Pattern::Units<System.Int64>()
    IL_0006: call Z0.Vec256`1<System.Int64> Z0.dinx::vadd(Z0.Vec256`1<System.Int64>&,Z0.Vec256`1<System.Int64>&)
    IL_000B: ret

}
Vec256<ulong> vinc(in Vec256<ulong> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec256`1<System.UInt64>& modreq(System.Runtime.InteropServices.InAttribute) Z0.Vec256Pattern::Units<System.UInt64>()
    IL_0006: call Z0.Vec256`1<System.UInt64> Z0.dinx::vadd(Z0.Vec256`1<System.UInt64>&,Z0.Vec256`1<System.UInt64>&)
    IL_000B: ret

}
Vec128<byte> vmax(in Vec128<byte> x, in Vec128<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::Max(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0011: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0016: ret

}
Vec128<sbyte> vmax(in Vec128<sbyte> x, in Vec128<sbyte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse41::Max(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0011: call Z0.Vec128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0016: ret

}
Vec128<short> vmax(in Vec128<short> x, in Vec128<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::Max(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0011: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0016: ret

}
Vec128<ushort> vmax(in Vec128<ushort> x, in Vec128<ushort> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse41::Max(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0011: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0016: ret

}
Vec128<int> vmax(in Vec128<int> x, in Vec128<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse41::Max(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0011: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0016: ret

}
Vec128<uint> vmax(in Vec128<uint> x, in Vec128<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse41::Max(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0011: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0016: ret

}
Vec256<byte> vmax(in Vec256<byte> x, in Vec256<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::Max(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0011: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0016: ret

}
Vec256<sbyte> vmax(in Vec256<sbyte> x, in Vec256<sbyte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::Max(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0011: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0016: ret

}
Vec256<short> vmax(in Vec256<short> x, in Vec256<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::Max(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0011: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0016: ret

}
Vec256<ushort> vmax(in Vec256<ushort> x, in Vec256<ushort> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::Max(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0011: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0016: ret

}
Vec256<int> vmax(in Vec256<int> x, in Vec256<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::Max(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0016: ret

}
Vec256<uint> vmax(in Vec256<uint> x, in Vec256<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::Max(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0011: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0016: ret

}
Vec128<byte> vmin(in Vec128<byte> x, in Vec128<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.Vec128`1<System.Byte>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Byte> System.Runtime.Intrinsics.X86.Sse2::Min(System.Runtime.Intrinsics.Vector128`1<System.Byte>,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0011: call Z0.Vec128`1<System.Byte> Z0.Vec128`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_0016: ret

}
Vec128<sbyte> vmin(in Vec128<sbyte> x, in Vec128<sbyte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.SByte> Z0.Vec128`1<System.SByte>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.SByte> System.Runtime.Intrinsics.X86.Sse41::Min(System.Runtime.Intrinsics.Vector128`1<System.SByte>,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0011: call Z0.Vec128`1<System.SByte> Z0.Vec128`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_0016: ret

}
Vec128<short> vmin(in Vec128<short> x, in Vec128<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Sse2::Min(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0011: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0016: ret

}
Vec128<ushort> vmin(in Vec128<ushort> x, in Vec128<ushort> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> System.Runtime.Intrinsics.X86.Sse41::Min(System.Runtime.Intrinsics.Vector128`1<System.UInt16>,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0011: call Z0.Vec128`1<System.UInt16> Z0.Vec128`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_0016: ret

}
Vec128<int> vmin(in Vec128<int> x, in Vec128<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int32> System.Runtime.Intrinsics.X86.Sse41::Min(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0011: call Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0016: ret

}
Vec128<uint> vmin(in Vec128<uint> x, in Vec128<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt32> System.Runtime.Intrinsics.X86.Sse41::Min(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0011: call Z0.Vec128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0016: ret

}
Vec256<byte> vmin(in Vec256<byte> x, in Vec256<byte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.Vec256`1<System.Byte>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Byte> System.Runtime.Intrinsics.X86.Avx2::Min(System.Runtime.Intrinsics.Vector256`1<System.Byte>,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0011: call Z0.Vec256`1<System.Byte> Z0.Vec256`1<System.Byte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_0016: ret

}
Vec256<sbyte> vmin(in Vec256<sbyte> x, in Vec256<sbyte> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.SByte> Z0.Vec256`1<System.SByte>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.SByte> System.Runtime.Intrinsics.X86.Avx2::Min(System.Runtime.Intrinsics.Vector256`1<System.SByte>,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0011: call Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_0016: ret

}
Vec256<short> vmin(in Vec256<short> x, in Vec256<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::Min(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0011: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0016: ret

}
Vec256<ushort> vmin(in Vec256<ushort> x, in Vec256<ushort> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt16> System.Runtime.Intrinsics.X86.Avx2::Min(System.Runtime.Intrinsics.Vector256`1<System.UInt16>,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0011: call Z0.Vec256`1<System.UInt16> Z0.Vec256`1<System.UInt16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_0016: ret

}
Vec256<int> vmin(in Vec256<int> x, in Vec256<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int32> System.Runtime.Intrinsics.X86.Avx2::Min(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: call Z0.Vec256`1<System.Int32> Z0.Vec256`1<System.Int32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0016: ret

}
Vec256<uint> vmin(in Vec256<uint> x, in Vec256<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> System.Runtime.Intrinsics.X86.Avx2::Min(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0011: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0016: ret

}
Vec256<short> vmulhrs(in Vec256<short> x, in Vec256<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int16> Z0.Vec256`1<System.Int16>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int16> System.Runtime.Intrinsics.X86.Avx2::MultiplyHighRoundScale(System.Runtime.Intrinsics.Vector256`1<System.Int16>,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0011: call Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_0016: ret

}
Vec128<short> vmulhrs(in Vec128<short> x, in Vec128<short> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int16> Z0.Vec128`1<System.Int16>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int16> System.Runtime.Intrinsics.X86.Ssse3::MultiplyHighRoundScale(System.Runtime.Intrinsics.Vector128`1<System.Int16>,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0011: call Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_0016: ret

}
Vec128<long> vmul(in Vec128<int> x, in Vec128<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.Int32> Z0.Vec128`1<System.Int32>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.Int64> System.Runtime.Intrinsics.X86.Sse41::Multiply(System.Runtime.Intrinsics.Vector128`1<System.Int32>,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_0011: call Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_0016: ret

}
Vec128<ulong> vmul(in Vec128<uint> x, in Vec128<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::xmm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector128`1<System.UInt32> Z0.Vec128`1<System.UInt32>::xmm
    IL_000C: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> System.Runtime.Intrinsics.X86.Sse2::Multiply(System.Runtime.Intrinsics.Vector128`1<System.UInt32>,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_0011: call Z0.Vec128`1<System.UInt64> Z0.Vec128`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0016: ret

}
Vec256<long> vmul(in Vec256<int> x, in Vec256<int> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.Int32> Z0.Vec256`1<System.Int32>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.Int64> System.Runtime.Intrinsics.X86.Avx2::Multiply(System.Runtime.Intrinsics.Vector256`1<System.Int32>,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_0011: call Z0.Vec256`1<System.Int64> Z0.Vec256`1<System.Int64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_0016: ret

}
Vec256<ulong> vmul(in Vec256<uint> x, in Vec256<uint> y)
{
    IL_0000: ldarg.0
    IL_0001: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::ymm
    IL_0006: ldarg.1
    IL_0007: ldfld System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.Vec256`1<System.UInt32>::ymm
    IL_000C: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> System.Runtime.Intrinsics.X86.Avx2::Multiply(System.Runtime.Intrinsics.Vector256`1<System.UInt32>,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_0011: call Z0.Vec256`1<System.UInt64> Z0.Vec256`1<System.UInt64>::op_Implicit(System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0016: ret

}
Vec256<ulong> vmul(in Vec256<ulong> x, in Vec256<ulong> y)
{
    IL_0000: ldc.i4.m1
    IL_0001: conv.u8
    IL_0002: call Z0.Vec256`1<System.UInt64> Z0.Vec256::Fill<System.UInt64>(System.UInt64)
    IL_0007: stloc.0
    IL_0008: ldarg.0
    IL_0009: ldloca.s V_0
    IL_000B: call Z0.Vec256`1<System.UInt64> Z0.dinx::vand(Z0.Vec256`1<System.UInt64>&,Z0.Vec256`1<System.UInt64>&)
    IL_0010: stloc.s V_12
    IL_0012: ldloca.s V_12
    IL_0014: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt64>::As<System.UInt32>()
    IL_0019: stloc.1
    IL_001A: ldarg.0
    IL_001B: ldc.i4.s 32
    IL_001D: call Z0.Vec256`1<System.UInt64> Z0.dinx::vsrl(Z0.Vec256`1<System.UInt64>&,System.Byte)
    IL_0022: stloc.s V_12
    IL_0024: ldloca.s V_12
    IL_0026: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt64>::As<System.UInt32>()
    IL_002B: stloc.2
    IL_002C: ldarg.1
    IL_002D: ldloca.s V_0
    IL_002F: call Z0.Vec256`1<System.UInt64> Z0.dinx::vand(Z0.Vec256`1<System.UInt64>&,Z0.Vec256`1<System.UInt64>&)
    IL_0034: stloc.s V_12
    IL_0036: ldloca.s V_12
    IL_0038: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt64>::As<System.UInt32>()
    IL_003D: stloc.3
    IL_003E: ldarg.1
    IL_003F: ldc.i4.s 32
    IL_0041: call Z0.Vec256`1<System.UInt64> Z0.dinx::vsrl(Z0.Vec256`1<System.UInt64>&,System.Byte)
    IL_0046: stloc.s V_12
    IL_0048: ldloca.s V_12
    IL_004A: call Z0.Vec256`1<System.UInt32> Z0.Vec256`1<System.UInt64>::As<System.UInt32>()
    IL_004F: stloc.s V_4
    IL_0051: ldloca.s V_2
    IL_0053: ldloca.s V_3
    IL_0055: call Z0.Vec256`1<System.UInt64> Z0.dinx::vmul(Z0.Vec256`1<System.UInt32>&,Z0.Vec256`1<System.UInt32>&)
    IL_005A: stloc.s V_5
    IL_005C: ldloca.s V_5
    IL_005E: ldc.i4.s 32
    IL_0060: call Z0.Vec256`1<System.UInt64> Z0.dinx::vsll(Z0.Vec256`1<System.UInt64>&,System.Byte)
    IL_0065: stloc.s V_6
    IL_0067: ldloca.s V_2
    IL_0069: ldloca.s V_4
    IL_006B: call Z0.Vec256`1<System.UInt64> Z0.dinx::vmul(Z0.Vec256`1<System.UInt32>&,Z0.Vec256`1<System.UInt32>&)
    IL_0070: stloc.s V_7
    IL_0072: ldloca.s V_7
    IL_0074: ldc.i4.s 32
    IL_0076: call Z0.Vec256`1<System.UInt64> Z0.dinx::vsll(Z0.Vec256`1<System.UInt64>&,System.Byte)
    IL_007B: stloc.s V_8
    IL_007D: ldloca.s V_1
    IL_007F: ldloca.s V_3
    IL_0081: call Z0.Vec256`1<System.UInt64> Z0.dinx::vmul(Z0.Vec256`1<System.UInt32>&,Z0.Vec256`1<System.UInt32>&)
    IL_0086: stloc.s V_9
    IL_0088: ldloca.s V_6
    IL_008A: ldloca.s V_8
    IL_008C: call Z0.Vec256`1<System.UInt64> Z0.dinx::vadd(Z0.Vec256`1<System.UInt64>&,Z0.Vec256`1<System.UInt64>&)
    IL_0091: stloc.s V_10
    IL_0093: ldloca.s V_9
    IL_0095: ldloca.s V_10
    IL_0097: call Z0.Vec256`1<System.UInt64> Z0.dinx::vadd(Z0.Vec256`1<System.UInt64>&,Z0.Vec256`1<System.UInt64>&)
    IL_009C: stloc.s V_11
    IL_009E: ldloc.s V_11
    IL_00A0: ret

}
Vec128<sbyte> vnegate(in Vec128<sbyte> src)
{
    IL_0000: ldsflda Z0.Vec128`1<System.SByte> Z0.Vec128`1<System.SByte>::Zero
    IL_0005: ldarg.0
    IL_0006: call Z0.Vec128`1<System.SByte> Z0.dinx::vsub(Z0.Vec128`1<System.SByte>&,Z0.Vec128`1<System.SByte>&)
    IL_000B: ret

}
Vec128<byte> vnegate(in Vec128<byte> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.Byte> Z0.BitUtil::flip(Z0.Vec128`1<System.Byte>&)
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: call Z0.Vec128`1<System.Byte>& modreq(System.Runtime.InteropServices.InAttribute) Z0.Vec128::Ones<System.Byte>()
    IL_000E: call Z0.Vec128`1<System.Byte> Z0.dinx::vadd(Z0.Vec128`1<System.Byte>&,Z0.Vec128`1<System.Byte>&)
    IL_0013: ret

}
Vec128<short> vnegate(in Vec128<short> src)
{
    IL_0000: ldsflda Z0.Vec128`1<System.Int16> Z0.Vec128`1<System.Int16>::Zero
    IL_0005: ldarg.0
    IL_0006: call Z0.Vec128`1<System.Int16> Z0.dinx::vsub(Z0.Vec128`1<System.Int16>&,Z0.Vec128`1<System.Int16>&)
    IL_000B: ret

}
Vec128<ushort> vnegate(in Vec128<ushort> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.UInt16> Z0.BitUtil::flip(Z0.Vec128`1<System.UInt16>&)
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: call Z0.Vec128`1<System.UInt16>& modreq(System.Runtime.InteropServices.InAttribute) Z0.Vec128::Ones<System.UInt16>()
    IL_000E: call Z0.Vec128`1<System.UInt16> Z0.dinx::vadd(Z0.Vec128`1<System.UInt16>&,Z0.Vec128`1<System.UInt16>&)
    IL_0013: ret

}
Vec128<int> vnegate(in Vec128<int> src)
{
    IL_0000: ldsflda Z0.Vec128`1<System.Int32> Z0.Vec128`1<System.Int32>::Zero
    IL_0005: ldarg.0
    IL_0006: call Z0.Vec128`1<System.Int32> Z0.dinx::vsub(Z0.Vec128`1<System.Int32>&,Z0.Vec128`1<System.Int32>&)
    IL_000B: ret

}
Vec128<uint> vnegate(in Vec128<uint> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.UInt32> Z0.BitUtil::flip(Z0.Vec128`1<System.UInt32>&)
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: call Z0.Vec128`1<System.UInt32>& modreq(System.Runtime.InteropServices.InAttribute) Z0.Vec128::Ones<System.UInt32>()
    IL_000E: call Z0.Vec128`1<System.UInt32> Z0.dinx::vadd(Z0.Vec128`1<System.UInt32>&,Z0.Vec128`1<System.UInt32>&)
    IL_0013: ret

}
Vec128<long> vnegate(in Vec128<long> src)
{
    IL_0000: ldsflda Z0.Vec128`1<System.Int64> Z0.Vec128`1<System.Int64>::Zero
    IL_0005: ldarg.0
    IL_0006: call Z0.Vec128`1<System.Int64> Z0.dinx::vsub(Z0.Vec128`1<System.Int64>&,Z0.Vec128`1<System.Int64>&)
    IL_000B: ret

}
Vec128<ulong> vnegate(in Vec128<ulong> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec128`1<System.UInt64> Z0.BitUtil::flip(Z0.Vec128`1<System.UInt64>&)
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: call Z0.Vec128`1<System.UInt64>& modreq(System.Runtime.InteropServices.InAttribute) Z0.Vec128::Ones<System.UInt64>()
    IL_000E: call Z0.Vec128`1<System.UInt64> Z0.dinx::vadd(Z0.Vec128`1<System.UInt64>&,Z0.Vec128`1<System.UInt64>&)
    IL_0013: ret

}
Vec256<sbyte> vnegate(in Vec256<sbyte> src)
{
    IL_0000: ldsflda Z0.Vec256`1<System.SByte> Z0.Vec256`1<System.SByte>::Zero
    IL_0005: ldarg.0
    IL_0006: call Z0.Vec256`1<System.SByte> Z0.dinx::vsub(Z0.Vec256`1<System.SByte>&,Z0.Vec256`1<System.SByte>&)
    IL_000B: ret

}
Vec256<byte> vnegate(in Vec256<byte> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec256`1<System.Byte> Z0.BitUtil::flip(Z0.Vec256`1<System.Byte>&)
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: call Z0.Vec256`1<System.Byte>& modreq(System.Runtime.InteropServices.InAttribute) Z0.Vec256::Ones<System.Byte>()
    IL_000E: call Z0.Vec256`1<System.Byte> Z0.dinx::vadd(Z0.Vec256`1<System.Byte>&,Z0.Vec256`1<System.Byte>&)
    IL_0013: ret

}
Vec256<short> vnegate(in Vec256<short> src)
{
    IL_0000: ldsflda Z0.Vec256`1<System.Int16> Z0.Vec256`1<System.Int16>::Zero
    IL_0005: ldarg.0
    IL_0006: call Z0.Vec256`1<System.Int16> Z0.dinx::vsub(Z0.Vec256`1<System.Int16>&,Z0.Vec256`1<System.Int16>&)
    IL_000B: ret

}
Vec256<ushort> vnegate(in Vec256<ushort> src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.Vec256`1<System.UInt16> Z0.BitUtil::flip(Z0.Vec256`1<System.UInt16>&)
    IL_0006: stloc.0
    IL_0007: ldloca.s V_0
    IL_0009: call Z0.Vec256`1<System.UInt16>& modreq(System.Runtime.InteropServices.InAttribute) Z0.Vec256::Ones<System.UInt16>()
    IL_000E: call Z0.Vec256`1<System.UInt16> Z0.dinx::vadd(Z0.Vec256`1<System.UInt16>&,Z0.Vec256`1<System.UInt16>&)
    IL_0013: ret

}
