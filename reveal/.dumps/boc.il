// 2019-10-05 19:16:27:928
byte bzhi_d8u(byte src, uint index)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Byte Z0.Bits::bzhi(System.Byte,System.UInt32)
    IL_0007: ret

}
byte bzhi_g8u(byte src, uint index)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Byte Z0.gbits::bzhi<System.Byte>(System.Byte,System.UInt32)
    IL_0007: ret

}
ref byte bzhi_g8u_ref(ref byte src, uint index)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Byte& Z0.gbits::bzhi<System.Byte>(System.Byte&,System.UInt32)
    IL_0007: ret

}
ushort bzhi_d16u(ushort src, ushort index)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt16 Z0.Bits::bzhi(System.UInt16,System.UInt32)
    IL_0007: ret

}
ushort bzhi_g16u(ushort src, ushort index)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt16 Z0.gbits::bzhi<System.UInt16>(System.UInt16,System.UInt32)
    IL_0007: ret

}
ref ushort bzhi_g16u_ref(ref ushort src, ushort index)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt16& Z0.gbits::bzhi<System.UInt16>(System.UInt16&,System.UInt32)
    IL_0007: ret

}
uint bzhi_d32u(uint src, uint index)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::bzhi(System.UInt32,System.UInt32)
    IL_0007: ret

}
uint bzhi_g32u(uint src, uint index)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.gbits::bzhi<System.UInt32>(System.UInt32,System.UInt32)
    IL_0007: ret

}
ref uint bzhi_g32u_ref(ref uint src, uint index)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32& Z0.gbits::bzhi<System.UInt32>(System.UInt32&,System.UInt32)
    IL_0007: ret

}
ulong bzhi_d64u(ulong src, uint index)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.Bits::bzhi(System.UInt64,System.UInt32)
    IL_0007: ret

}
ulong bzhi_g64u(ulong src, uint index)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.gbits::bzhi<System.UInt64>(System.UInt64,System.UInt32)
    IL_0007: ret

}
ref ulong bzhi_g64u_ref(ref ulong src, uint index)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64& Z0.gbits::bzhi<System.UInt64>(System.UInt64&,System.UInt32)
    IL_0007: ret

}
byte gather_d8u(byte src, byte mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Byte Z0.Bits::gather(System.Byte,System.Byte)
    IL_0007: ret

}
byte gather_g8u(byte src, byte mask)
{
    IL_0000: ldarga.s src
    IL_0002: ldarga.s mask
    IL_0004: call System.Byte Z0.gbits::gather<System.Byte>(System.Byte&,System.Byte&)
    IL_0009: ret

}
ushort gather_d16u(ushort src, ushort mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt16 Z0.Bits::gather(System.UInt16,System.UInt16)
    IL_0007: ret

}
ushort gather_g16u(ushort src, ushort mask)
{
    IL_0000: ldarga.s src
    IL_0002: ldarga.s mask
    IL_0004: call System.UInt16 Z0.gbits::gather<System.UInt16>(System.UInt16&,System.UInt16&)
    IL_0009: ret

}
uint gather_d32u(uint src, uint mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32 Z0.Bits::gather(System.UInt32,System.UInt32)
    IL_0007: ret

}
uint gather_g32u(uint src, uint mask)
{
    IL_0000: ldarga.s src
    IL_0002: ldarga.s mask
    IL_0004: call System.UInt32 Z0.gbits::gather<System.UInt32>(System.UInt32&,System.UInt32&)
    IL_0009: ret

}
ulong gather_d64u(ulong src, ulong mask)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64 Z0.Bits::gather(System.UInt64,System.UInt64)
    IL_0007: ret

}
ulong gather_g64u(ulong src, ulong mask)
{
    IL_0000: ldarga.s src
    IL_0002: ldarga.s mask
    IL_0004: call System.UInt64 Z0.gbits::gather<System.UInt64>(System.UInt64&,System.UInt64&)
    IL_0009: ret

}
