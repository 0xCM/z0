// 2019-12-09 22:27:11:595
void unpack(byte src, in Block64<byte> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.0
    IL_0003: call System.Void Z0.inxs::unpack<System.Byte>(System.Byte,Z0.Block64`1<System.Byte>&,System.Int32)
    IL_0008: ret

}
void unpack(ushort src, in Block128<byte> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.0
    IL_0003: call System.Void Z0.inxs::unpack<System.Byte>(System.UInt16,Z0.Block128`1<System.Byte>&,System.Int32)
    IL_0008: ret

}
uint pack64x8u(ConstBlock64<byte> src)
{
    IL_0000: ldarga.s src
    IL_0002: ldc.i4.0
    IL_0003: call System.Byte Z0.inxs::pack<System.Byte>(Z0.ConstBlock64`1<System.Byte>&,System.Int32)
    IL_0008: ret

}
uint pack128x8u(ConstBlock128<byte> src)
{
    IL_0000: ldarga.s src
    IL_0002: ldc.i4.0
    IL_0003: call System.UInt16 Z0.inxs::pack<System.Byte>(Z0.ConstBlock128`1<System.Byte>&,System.Int32)
    IL_0008: ret

}
uint pack256x8u(ConstBlock256<byte> src)
{
    IL_0000: ldarga.s src
    IL_0002: ldc.i4.0
    IL_0003: call System.UInt32 Z0.inxs::pack<System.Byte>(Z0.ConstBlock256`1<System.Byte>&,System.Int32)
    IL_0008: ret

}
ulong pack512x64u(ConstBlock256<byte> lo, ConstBlock256<byte> hi)
{
    IL_0000: ldarga.s lo
    IL_0002: ldarga.s hi
    IL_0004: ldc.i4.0
    IL_0005: call System.UInt64 Z0.inxs::pack<System.Byte>(Z0.ConstBlock256`1<System.Byte>&,Z0.ConstBlock256`1<System.Byte>&,System.Int32)
    IL_000A: ret

}
void unpack(uint src, in Block256<byte> dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.0
    IL_0003: call System.Void Z0.inxs::unpack<System.Byte>(System.UInt32,Z0.Block256`1<System.Byte>&,System.Int32)
    IL_0008: ret

}
void unpack(ulong src, in Block256<byte> lo, in Block256<byte> hi)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: ldc.i4.0
    IL_0004: call System.Void Z0.inxs::unpack<System.Byte>(System.UInt64,Z0.Block256`1<System.Byte>&,Z0.Block256`1<System.Byte>&,System.Int32)
    IL_0009: ret

}
ulong broadcast_8x64(byte pattern)
{
    IL_0000: ldarg.0
    IL_0001: ldloca.s V_0
    IL_0003: call System.UInt64& Z0.ginxs::broadcast<System.Byte,System.UInt64>(System.Byte,System.UInt64&)
    IL_0008: ldind.i8
    IL_0009: ret

}
ulong broadcast_8x64_const()
{
    IL_0000: ldc.i4 204
    IL_0005: ldloca.s V_0
    IL_0007: call System.UInt64& Z0.ginxs::broadcast<System.Byte,System.UInt64>(System.Byte,System.UInt64&)
    IL_000C: ldind.i8
    IL_000D: ret

}
