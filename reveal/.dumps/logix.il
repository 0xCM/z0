// 2020-01-16 19:14:10:172
// Id := 100664806, Name := System.Int32 Z0.OpCodes.logix::work_ring_buffer()
// int work_ring_buffer()
// Managed
int work_ring_buffer()
{
    IL_0000: ldc.i4.s 64
    IL_0002: call Z0.RingBuffer`1<System.Byte> Z0.MicroBuffers::ring<System.Byte>(System.Int32)
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

// Id := 100664807, Name := Z0.BitStack& Z0.OpCodes.logix::push(Z0.bit,Z0.BitStack&)
// ref BitStack push(bit src, ref BitStack dst)
// Managed
ref BitStack push(bit src, ref BitStack dst)
{
    IL_0000: ldarg.1
    IL_0001: ldarg.0
    IL_0002: call System.Void Z0.BitStack::Push(Z0.bit)
    IL_0007: ldarg.1
    IL_0008: ret
}

// Id := 100664808, Name := Z0.bit Z0.OpCodes.logix::pop(Z0.BitStack&)
// bit pop(ref BitStack src)
// Managed
bit pop(ref BitStack src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.bit Z0.BitStack::Pop()
    IL_0006: ret
}

// Id := 100664809, Name := Z0.bit Z0.OpCodes.logix::and_logic(Z0.bit,Z0.bit)
// bit and_logic(bit a, bit b)
// Managed
bit and_logic(bit a, bit b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.Logix.LogicOps::and(Z0.bit,Z0.bit)
    IL_0007: ret
}

// Id := 100664810, Name := System.UInt64 Z0.OpCodes.logix::and_scalar(System.UInt64,System.UInt64)
// ulong and_scalar(ulong a, ulong b)
// Managed
ulong and_scalar(ulong a, ulong b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.Logix.ScalarOps::and<System.UInt64>(System.UInt64,System.UInt64)
    IL_0007: ret
}

// Id := 100664811, Name := System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.OpCodes.logix::and_v128(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
// Vector128<ulong> and_v128(Vector128<ulong> a, Vector128<ulong> b)
// Managed
Vector128<ulong> and_v128(Vector128<ulong> a, Vector128<ulong> b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Logix.CpuOps::and<System.UInt64>(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0007: ret
}

// Id := 100664812, Name := System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.OpCodes.logix::and_v256(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
// Vector256<ulong> and_v256(Vector256<ulong> a, Vector256<ulong> b)
// Managed
Vector256<ulong> and_v256(Vector256<ulong> a, Vector256<ulong> b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Logix.CpuOps::and<System.UInt64>(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0007: ret
}

// Id := 100664813, Name := Z0.bit Z0.OpCodes.logix::nor_logic(Z0.bit,Z0.bit)
// bit nor_logic(bit a, bit b)
// Managed
bit nor_logic(bit a, bit b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.Logix.LogicOps::nor(Z0.bit,Z0.bit)
    IL_0007: ret
}

// Id := 100664814, Name := System.UInt64 Z0.OpCodes.logix::nor_scalar(System.UInt64,System.UInt64)
// ulong nor_scalar(ulong a, ulong b)
// Managed
ulong nor_scalar(ulong a, ulong b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.Logix.ScalarOps::nor<System.UInt64>(System.UInt64,System.UInt64)
    IL_0007: ret
}

// Id := 100664815, Name := System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.OpCodes.logix::nor_v128(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
// Vector128<ulong> nor_v128(Vector128<ulong> a, Vector128<ulong> b)
// Managed
Vector128<ulong> nor_v128(Vector128<ulong> a, Vector128<ulong> b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Logix.CpuOps::nor<System.UInt64>(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0007: ret
}

// Id := 100664816, Name := System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.OpCodes.logix::nor_v256(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
// Vector256<ulong> nor_v256(Vector256<ulong> a, Vector256<ulong> b)
// Managed
Vector256<ulong> nor_v256(Vector256<ulong> a, Vector256<ulong> b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Logix.CpuOps::nor<System.UInt64>(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0007: ret
}

// Id := 100664817, Name := Z0.bit Z0.OpCodes.logix::xnor_logic(Z0.bit,Z0.bit)
// bit xnor_logic(bit a, bit b)
// Managed
bit xnor_logic(bit a, bit b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.Logix.LogicOps::xnor(Z0.bit,Z0.bit)
    IL_0007: ret
}

// Id := 100664818, Name := System.UInt64 Z0.OpCodes.logix::xnor_scalar(System.UInt64,System.UInt64)
// ulong xnor_scalar(ulong a, ulong b)
// Managed
ulong xnor_scalar(ulong a, ulong b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.Logix.ScalarOps::xnor<System.UInt64>(System.UInt64,System.UInt64)
    IL_0007: ret
}

// Id := 100664819, Name := System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.OpCodes.logix::xnor_v128(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
// Vector128<ulong> xnor_v128(Vector128<ulong> a, Vector128<ulong> b)
// Managed
Vector128<ulong> xnor_v128(Vector128<ulong> a, Vector128<ulong> b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Logix.CpuOps::xnor<System.UInt64>(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0007: ret
}

// Id := 100664820, Name := System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.OpCodes.logix::xnor_v256(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
// Vector256<ulong> xnor_v256(Vector256<ulong> a, Vector256<ulong> b)
// Managed
Vector256<ulong> xnor_v256(Vector256<ulong> a, Vector256<ulong> b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Logix.CpuOps::xnor<System.UInt64>(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0007: ret
}

// Id := 100664821, Name := Z0.bit Z0.OpCodes.logix::imply_logic(Z0.bit,Z0.bit)
// bit imply_logic(bit a, bit b)
// Managed
bit imply_logic(bit a, bit b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.Logix.LogicOps::impl(Z0.bit,Z0.bit)
    IL_0007: ret
}

// Id := 100664822, Name := System.UInt64 Z0.OpCodes.logix::imply_scalar(System.UInt64,System.UInt64)
// ulong imply_scalar(ulong a, ulong b)
// Managed
ulong imply_scalar(ulong a, ulong b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.Logix.ScalarOps::impl<System.UInt64>(System.UInt64,System.UInt64)
    IL_0007: ret
}

// Id := 100664823, Name := System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.OpCodes.logix::imply_v128(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
// Vector128<ulong> imply_v128(Vector128<ulong> a, Vector128<ulong> b)
// Managed
Vector128<ulong> imply_v128(Vector128<ulong> a, Vector128<ulong> b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Logix.CpuOps::impl<System.UInt64>(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0007: ret
}

// Id := 100664824, Name := System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.OpCodes.logix::imply_v256(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
// Vector256<ulong> imply_v256(Vector256<ulong> a, Vector256<ulong> b)
// Managed
Vector256<ulong> imply_v256(Vector256<ulong> a, Vector256<ulong> b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Logix.CpuOps::impl<System.UInt64>(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0007: ret
}

// Id := 100664825, Name := Z0.bit Z0.OpCodes.logix::notimply_logic(Z0.bit,Z0.bit)
// bit notimply_logic(bit a, bit b)
// Managed
bit notimply_logic(bit a, bit b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.Logix.LogicOps::nonimpl(Z0.bit,Z0.bit)
    IL_0007: ret
}

// Id := 100664826, Name := System.UInt64 Z0.OpCodes.logix::notimply_scalar(System.UInt64,System.UInt64)
// ulong notimply_scalar(ulong a, ulong b)
// Managed
ulong notimply_scalar(ulong a, ulong b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.Logix.ScalarOps::nonimpl<System.UInt64>(System.UInt64,System.UInt64)
    IL_0007: ret
}

// Id := 100664827, Name := System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.OpCodes.logix::notimply_v128(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
// Vector128<ulong> notimply_v128(Vector128<ulong> a, Vector128<ulong> b)
// Managed
Vector128<ulong> notimply_v128(Vector128<ulong> a, Vector128<ulong> b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Logix.CpuOps::nonimpl<System.UInt64>(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0007: ret
}

// Id := 100664828, Name := System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.OpCodes.logix::notimply_v256(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
// Vector256<ulong> notimply_v256(Vector256<ulong> a, Vector256<ulong> b)
// Managed
Vector256<ulong> notimply_v256(Vector256<ulong> a, Vector256<ulong> b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Logix.CpuOps::nonimpl<System.UInt64>(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0007: ret
}

// Id := 100664829, Name := Z0.bit Z0.OpCodes.logix::cimply_logic(Z0.bit,Z0.bit)
// bit cimply_logic(bit a, bit b)
// Managed
bit cimply_logic(bit a, bit b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.Logix.LogicOps::cimpl(Z0.bit,Z0.bit)
    IL_0007: ret
}

// Id := 100664830, Name := System.UInt64 Z0.OpCodes.logix::cimply_scalar(System.UInt64,System.UInt64)
// ulong cimply_scalar(ulong a, ulong b)
// Managed
ulong cimply_scalar(ulong a, ulong b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.Logix.ScalarOps::cimpl<System.UInt64>(System.UInt64,System.UInt64)
    IL_0007: ret
}

// Id := 100664831, Name := System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.OpCodes.logix::cimply_v128(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
// Vector128<ulong> cimply_v128(Vector128<ulong> a, Vector128<ulong> b)
// Managed
Vector128<ulong> cimply_v128(Vector128<ulong> a, Vector128<ulong> b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Logix.CpuOps::cimpl<System.UInt64>(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0007: ret
}

// Id := 100664832, Name := System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.OpCodes.logix::cimply_v256(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
// Vector256<ulong> cimply_v256(Vector256<ulong> a, Vector256<ulong> b)
// Managed
Vector256<ulong> cimply_v256(Vector256<ulong> a, Vector256<ulong> b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Logix.CpuOps::cimpl<System.UInt64>(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0007: ret
}

// Id := 100664833, Name := Z0.bit Z0.OpCodes.logix::cnotimply_logic(Z0.bit,Z0.bit)
// bit cnotimply_logic(bit a, bit b)
// Managed
bit cnotimply_logic(bit a, bit b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call Z0.bit Z0.Logix.LogicOps::cnonimpl(Z0.bit,Z0.bit)
    IL_0007: ret
}

// Id := 100664834, Name := System.UInt64 Z0.OpCodes.logix::cnotimply_scalar(System.UInt64,System.UInt64)
// ulong cnotimply_scalar(ulong a, ulong b)
// Managed
ulong cnotimply_scalar(ulong a, ulong b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.Logix.ScalarOps::cnonimpl<System.UInt64>(System.UInt64,System.UInt64)
    IL_0007: ret
}

// Id := 100664835, Name := System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.OpCodes.logix::cnotimply_v128(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
// Vector128<ulong> cnotimply_v128(Vector128<ulong> a, Vector128<ulong> b)
// Managed
Vector128<ulong> cnotimply_v128(Vector128<ulong> a, Vector128<ulong> b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector128`1<System.UInt64> Z0.Logix.CpuOps::cnonimpl<System.UInt64>(System.Runtime.Intrinsics.Vector128`1<System.UInt64>,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_0007: ret
}

// Id := 100664836, Name := System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.OpCodes.logix::cnotimply_v256(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
// Vector256<ulong> cnotimply_v256(Vector256<ulong> a, Vector256<ulong> b)
// Managed
Vector256<ulong> cnotimply_v256(Vector256<ulong> a, Vector256<ulong> b)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Runtime.Intrinsics.Vector256`1<System.UInt64> Z0.Logix.CpuOps::cnonimpl<System.UInt64>(System.Runtime.Intrinsics.Vector256`1<System.UInt64>,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_0007: ret
}

