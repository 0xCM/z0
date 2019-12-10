// 2019-12-10 01:42:50:642
Vector128<byte> makemask_128x8u(BitVector16 src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt16 Z0.BitVector16::op_Implicit(Z0.BitVector16)
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.dinx::vmakemask(System.UInt16)
    IL_000B: ret

}
Vector128<byte> makemask_128x8u_literal()
{
    IL_0000: ldc.i4 64764
    IL_0005: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.dinx::vmakemask(System.UInt16)
    IL_000A: ret

}
Vector256<byte> makemask_256x8u(BitVector32 src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 Z0.BitVector32::op_Implicit(Z0.BitVector32)
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.dinx::vmakemask(System.UInt32)
    IL_000B: ret

}
Vector256<byte> makemask_256x8u_literal()
{
    IL_0000: ldc.i4 -252645184
    IL_0005: call System.Runtime.Intrinsics.Vector256`1<System.Byte> Z0.dinx::vmakemask(System.UInt32)
    IL_000A: ret

}
Vector128<byte> makemask_g128x8u(BitVector16 src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt16 Z0.BitVector16::op_Implicit(Z0.BitVector16)
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.Byte> Z0.ginx::vmakemask<System.Byte>(System.UInt16)
    IL_000B: ret

}
Vector128<ushort> makemask_g128x16u(BitVector16 src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt16 Z0.BitVector16::op_Implicit(Z0.BitVector16)
    IL_0006: call System.Runtime.Intrinsics.Vector128`1<System.UInt16> Z0.ginx::vmakemask<System.UInt16>(System.UInt16)
    IL_000B: ret

}
Vector256<uint> makemask_g256x32u(BitVector32 src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 Z0.BitVector32::op_Implicit(Z0.BitVector32)
    IL_0006: call System.Runtime.Intrinsics.Vector256`1<System.UInt32> Z0.ginx::vmakemask<System.UInt32>(System.UInt32)
    IL_000B: ret

}
