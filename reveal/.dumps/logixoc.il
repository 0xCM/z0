// 2019-11-09 03:33:41:751
int work_ring_buffer()
{
    IL_0000: ldc.i4.s 64
    IL_0002: call Z0.RingBuffer`1<System.Byte> Z0.RingBuffer::alloc<System.Byte>(System.Int32)
    IL_0007: stloc.0
    IL_0008: ldloca.s V_0
    IL_000A: ldc.i4.3
    IL_000B: stloc.3
    IL_000C: ldloca.s V_3
    IL_000E: call System.Void Z0.RingBuffer`1<System.Byte>::Push(System.Byte&)
    IL_0013: ldloca.s V_0
    IL_0015: ldc.i4.4
    IL_0016: stloc.3
    IL_0017: ldloca.s V_3
    IL_0019: call System.Void Z0.RingBuffer`1<System.Byte>::Push(System.Byte&)
    IL_001E: ldloca.s V_0
    IL_0020: call System.Byte& modreq(System.Runtime.InteropServices.InAttribute) Z0.RingBuffer`1<System.Byte>::Pop()
    IL_0025: ldind.u1
    IL_0026: stloc.1
    IL_0027: ldloca.s V_0
    IL_0029: call System.Byte& modreq(System.Runtime.InteropServices.InAttribute) Z0.RingBuffer`1<System.Byte>::Pop()
    IL_002E: ldind.u1
    IL_002F: stloc.2
    IL_0030: ldloc.1
    IL_0031: ldloc.2
    IL_0032: add
    IL_0033: ret

}
ref BitStack push(bit src, ref BitStack dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Void Z0.BitStack::Push(Z0.bit)
    IL_0007: ldarg.1
    IL_0008: ret

}
bit pop(ref BitStack src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.bit Z0.BitStack::Pop()
    IL_0006: ret

}
bit and_logic(bit a, bit b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.Logix.LogicOps::and(Z0.bit,Z0.bit)
    IL_0007: ret

}
ulong and_scalar(ulong a, ulong b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.Logix.ScalarOps::and<System.UInt64>(System.UInt64,System.UInt64)
    IL_0007: ret

}
Vector128<ulong> and_v128(Vector128<ulong> a, Vector128<ulong> b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Logix.CpuOps::and<System.UInt64>(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0007: ret

}
Vector256<ulong> and_v256(Vector256<ulong> a, Vector256<ulong> b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Logix.CpuOps::and<System.UInt64>(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0007: ret

}
bit nor_logic(bit a, bit b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.Logix.LogicOps::nor(Z0.bit,Z0.bit)
    IL_0007: ret

}
ulong nor_scalar(ulong a, ulong b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.Logix.ScalarOps::nor<System.UInt64>(System.UInt64,System.UInt64)
    IL_0007: ret

}
Vector128<ulong> nor_v128(Vector128<ulong> a, Vector128<ulong> b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Logix.CpuOps::nor<System.UInt64>(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0007: ret

}
Vector256<ulong> nor_v256(Vector256<ulong> a, Vector256<ulong> b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Logix.CpuOps::nor<System.UInt64>(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0007: ret

}
bit xnor_logic(bit a, bit b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.Logix.LogicOps::xnor(Z0.bit,Z0.bit)
    IL_0007: ret

}
ulong xnor_scalar(ulong a, ulong b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.Logix.ScalarOps::xnor<System.UInt64>(System.UInt64,System.UInt64)
    IL_0007: ret

}
Vector128<ulong> xnor_v128(Vector128<ulong> a, Vector128<ulong> b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Logix.CpuOps::xnor<System.UInt64>(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0007: ret

}
Vector256<ulong> xnor_v256(Vector256<ulong> a, Vector256<ulong> b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Logix.CpuOps::xnor<System.UInt64>(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0007: ret

}
bit imply_logic(bit a, bit b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.Logix.LogicOps::imply(Z0.bit,Z0.bit)
    IL_0007: ret

}
ulong imply_scalar(ulong a, ulong b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.Logix.ScalarOps::imply<System.UInt64>(System.UInt64,System.UInt64)
    IL_0007: ret

}
Vector128<ulong> imply_v128(Vector128<ulong> a, Vector128<ulong> b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Logix.CpuOps::imply<System.UInt64>(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0007: ret

}
Vector256<ulong> imply_v256(Vector256<ulong> a, Vector256<ulong> b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Logix.CpuOps::imply<System.UInt64>(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0007: ret

}
bit notimply_logic(bit a, bit b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.Logix.LogicOps::notimply(Z0.bit,Z0.bit)
    IL_0007: ret

}
ulong notimply_scalar(ulong a, ulong b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.Logix.ScalarOps::notimply<System.UInt64>(System.UInt64,System.UInt64)
    IL_0007: ret

}
Vector128<ulong> notimply_v128(Vector128<ulong> a, Vector128<ulong> b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Logix.CpuOps::notimply<System.UInt64>(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0007: ret

}
Vector256<ulong> notimply_v256(Vector256<ulong> a, Vector256<ulong> b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Logix.CpuOps::notimply<System.UInt64>(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0007: ret

}
bit cimply_logic(bit a, bit b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.Logix.LogicOps::cimply(Z0.bit,Z0.bit)
    IL_0007: ret

}
ulong cimply_scalar(ulong a, ulong b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.Logix.ScalarOps::cimply<System.UInt64>(System.UInt64,System.UInt64)
    IL_0007: ret

}
Vector128<ulong> cimply_v128(Vector128<ulong> a, Vector128<ulong> b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Logix.CpuOps::cimply<System.UInt64>(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0007: ret

}
Vector256<ulong> cimply_v256(Vector256<ulong> a, Vector256<ulong> b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Logix.CpuOps::cimply<System.UInt64>(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0007: ret

}
bit cnotimply_logic(bit a, bit b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.Logix.LogicOps::cnotimply(Z0.bit,Z0.bit)
    IL_0007: ret

}
ulong cnotimply_scalar(ulong a, ulong b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.Logix.ScalarOps::cnotimply<System.UInt64>(System.UInt64,System.UInt64)
    IL_0007: ret

}
Vector128<ulong> cnotimply_v128(Vector128<ulong> a, Vector128<ulong> b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Logix.CpuOps::cnotimply<System.UInt64>(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0007: ret

}
Vector256<ulong> cnotimply_v256(Vector256<ulong> a, Vector256<ulong> b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Logix.CpuOps::cnotimply<System.UInt64>(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0007: ret

}
