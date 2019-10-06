// 2019-10-05 19:16:28:817
long convert_64f_to_g64i(double src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int64 Z0.Converter::convert<System.Int64>(System.Double)
    IL_0006: ret

}
long convert_g64f_to_g64i(double src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Int64 Z0.Converter::convert<System.Double,System.Int64>(System.Double&)
    IL_0007: ret

}
ulong convert_64f_to_g64u(double src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt64 Z0.Converter::convert<System.UInt64>(System.Double)
    IL_0006: ret

}
ulong convert_g64f_to_g64u(double src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.UInt64 Z0.Converter::convert<System.Double,System.UInt64>(System.Double&)
    IL_0007: ret

}
float convert_64f_to_g32f(double src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Single Z0.Converter::convert<System.Single>(System.Double)
    IL_0006: ret

}
double convert_64f_to_g64f(double src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Double Z0.Converter::convert<System.Double>(System.Double)
    IL_0006: ret

}
Char convert_64f_to_gch16(double src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Char Z0.Converter::convert<System.Char>(System.Double)
    IL_0006: ret

}
sbyte convert_ch16_to_8i(Char src)
{
    IL_0000: ldarg.0
    IL_0001: conv.i1
    IL_0002: ret

}
sbyte convert_ch16_to_g8i(Char src)
{
    IL_0000: ldarg.0
    IL_0001: call System.SByte Z0.Converter::convert<System.SByte>(System.Char)
    IL_0006: ret

}
byte convert_ch16_to_g8u(Char src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Byte Z0.Converter::convert<System.Byte>(System.Char)
    IL_0006: ret

}
short convert_ch16_to_16i(Char src)
{
    IL_0000: ldarg.0
    IL_0001: conv.i2
    IL_0002: ret

}
short convert_ch16_to_g16i(Char src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int16 Z0.Converter::convert<System.Int16>(System.Char)
    IL_0006: ret

}
ushort convert_ch16_to_16u(Char src)
{
    IL_0000: ldarg.0
    IL_0001: ret

}
ushort convert_ch16_to_g16u(Char src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt16 Z0.Converter::convert<System.UInt16>(System.Char)
    IL_0006: ret

}
int convert_ch16_to_g32i(Char src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int32 Z0.Converter::convert<System.Int32>(System.Char)
    IL_0006: ret

}
uint convert_ch16_to_g32u(Char src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 Z0.Converter::convert<System.UInt32>(System.Char)
    IL_0006: ret

}
long convert_ch16_to_g64i(Char src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int64 Z0.Converter::convert<System.Int64>(System.Char)
    IL_0006: ret

}
ulong convert_ch16_to_g64u(Char src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt64 Z0.Converter::convert<System.UInt64>(System.Char)
    IL_0006: ret

}
float convert_ch16_to_g32f(Char src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Single Z0.Converter::convert<System.Single>(System.Char)
    IL_0006: ret

}
double convert_ch16_to_g64f(Char src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Double Z0.Converter::convert<System.Double>(System.Char)
    IL_0006: ret

}
Char convert_ch16_to_gch16(Char src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Char Z0.Converter::convert<System.Char>(System.Char)
    IL_0006: ret

}
void vstore_n128x8u(Vector128<byte> src, ref byte dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.Byte* Z0.As::refptr(System.Byte&)
    IL_0006: ldarg.0
    IL_0007: call System.Void System.Runtime.Intrinsics.X86.Sse2::Store(System.Byte*,System.Runtime.Intrinsics.Vector128`1<System.Byte>)
    IL_000C: ret

}
void vstore_d128x8u(Vec128<byte> src, ref byte dst)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: call System.Void Z0.cpuvec::vstore(Z0.Vec128`1<System.Byte>&,System.Byte&)
    IL_0008: ret

}
void vstore_g128x8u(Vec128<byte> src, ref byte dst)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: call System.Void zfunc::vstore<System.Byte>(Z0.Vec128`1<System.Byte>&,System.Byte&)
    IL_0008: ret

}
void vstore_n128x8i(Vector128<sbyte> src, ref sbyte dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.SByte* Z0.As::refptr(System.SByte&)
    IL_0006: ldarg.0
    IL_0007: call System.Void System.Runtime.Intrinsics.X86.Sse2::Store(System.SByte*,System.Runtime.Intrinsics.Vector128`1<System.SByte>)
    IL_000C: ret

}
void vstore_d128x8i(Vec128<sbyte> src, ref sbyte dst)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: call System.Void Z0.cpuvec::vstore(Z0.Vec128`1<System.SByte>&,System.SByte&)
    IL_0008: ret

}
void vstore_g128x8i(Vec128<sbyte> src, ref sbyte dst)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: call System.Void zfunc::vstore<System.SByte>(Z0.Vec128`1<System.SByte>&,System.SByte&)
    IL_0008: ret

}
void vstore_n128x16i(Vector128<short> src, ref short dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.Int16* Z0.As::refptr(System.Int16&)
    IL_0006: ldarg.0
    IL_0007: call System.Void System.Runtime.Intrinsics.X86.Sse2::Store(System.Int16*,System.Runtime.Intrinsics.Vector128`1<System.Int16>)
    IL_000C: ret

}
void vstore_d128x16i(Vec128<short> src, ref short dst)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: call System.Void Z0.cpuvec::vstore(Z0.Vec128`1<System.Int16>&,System.Int16&)
    IL_0008: ret

}
void vstore_g128x16i(Vec128<short> src, ref short dst)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: call System.Void zfunc::vstore<System.Int16>(Z0.Vec128`1<System.Int16>&,System.Int16&)
    IL_0008: ret

}
void vstore_n128x16u(Vector128<ushort> src, ref ushort dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.UInt16* Z0.As::refptr(System.UInt16&)
    IL_0006: ldarg.0
    IL_0007: call System.Void System.Runtime.Intrinsics.X86.Sse2::Store(System.UInt16*,System.Runtime.Intrinsics.Vector128`1<System.UInt16>)
    IL_000C: ret

}
void vstore_d128x16u(Vec128<ushort> src, ref ushort dst)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: call System.Void Z0.cpuvec::vstore(Z0.Vec128`1<System.UInt16>&,System.UInt16&)
    IL_0008: ret

}
void vstore_g128x16u(Vec128<ushort> src, ref ushort dst)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: call System.Void zfunc::vstore<System.UInt16>(Z0.Vec128`1<System.UInt16>&,System.UInt16&)
    IL_0008: ret

}
void vstore_n128x32i(Vector128<int> src, ref int dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.Int32* Z0.As::refptr(System.Int32&)
    IL_0006: ldarg.0
    IL_0007: call System.Void System.Runtime.Intrinsics.X86.Sse2::Store(System.Int32*,System.Runtime.Intrinsics.Vector128`1<System.Int32>)
    IL_000C: ret

}
void vstore_d128x32i(Vec128<int> src, ref int dst)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: call System.Void Z0.cpuvec::vstore(Z0.Vec128`1<System.Int32>&,System.Int32&)
    IL_0008: ret

}
void vstore_g128x32i(Vec128<int> src, ref int dst)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: call System.Void zfunc::vstore<System.Int32>(Z0.Vec128`1<System.Int32>&,System.Int32&)
    IL_0008: ret

}
void vstore_n128x32u(Vector128<uint> src, ref uint dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.UInt32* Z0.As::refptr(System.UInt32&)
    IL_0006: ldarg.0
    IL_0007: call System.Void System.Runtime.Intrinsics.X86.Sse2::Store(System.UInt32*,System.Runtime.Intrinsics.Vector128`1<System.UInt32>)
    IL_000C: ret

}
void vstore_d128x32u(Vec128<uint> src, ref uint dst)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: call System.Void Z0.cpuvec::vstore(Z0.Vec128`1<System.UInt32>&,System.UInt32&)
    IL_0008: ret

}
void vstore_g128x32u(Vec128<uint> src, ref uint dst)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: call System.Void zfunc::vstore<System.UInt32>(Z0.Vec128`1<System.UInt32>&,System.UInt32&)
    IL_0008: ret

}
void vstore_n128x64i(Vector128<long> src, ref long dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.Int64* Z0.As::refptr(System.Int64&)
    IL_0006: ldarg.0
    IL_0007: call System.Void System.Runtime.Intrinsics.X86.Sse2::Store(System.Int64*,System.Runtime.Intrinsics.Vector128`1<System.Int64>)
    IL_000C: ret

}
void vstore_d128x64i(Vec128<long> src, ref long dst)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: call System.Void Z0.cpuvec::vstore(Z0.Vec128`1<System.Int64>&,System.Int64&)
    IL_0008: ret

}
void vstore_g128x64i(Vec128<long> src, ref long dst)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: call System.Void zfunc::vstore<System.Int64>(Z0.Vec128`1<System.Int64>&,System.Int64&)
    IL_0008: ret

}
void vstore_n128x64u(Vector128<ulong> src, ref ulong dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.UInt64* Z0.As::refptr(System.UInt64&)
    IL_0006: ldarg.0
    IL_0007: call System.Void System.Runtime.Intrinsics.X86.Sse2::Store(System.UInt64*,System.Runtime.Intrinsics.Vector128`1<System.UInt64>)
    IL_000C: ret

}
void vstore_d128x64u(Vec128<ulong> src, ref ulong dst)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: call System.Void Z0.cpuvec::vstore(Z0.Vec128`1<System.UInt64>&,System.UInt64&)
    IL_0008: ret

}
void vstore_g128x64u(Vec128<ulong> src, ref ulong dst)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: call System.Void zfunc::vstore<System.UInt64>(Z0.Vec128`1<System.UInt64>&,System.UInt64&)
    IL_0008: ret

}
void vstore_n128x32f(Vector128<float> src, ref float dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.Single* Z0.As::refptr(System.Single&)
    IL_0006: ldarg.0
    IL_0007: call System.Void System.Runtime.Intrinsics.X86.Sse::Store(System.Single*,System.Runtime.Intrinsics.Vector128`1<System.Single>)
    IL_000C: ret

}
void vstore_d128x32f(Vec128<float> src, ref float dst)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: call System.Void Z0.cpuvec::vstore(Z0.Vec128`1<System.Single>&,System.Single&)
    IL_0008: ret

}
void vstore_g128x32f(Vec128<float> src, ref float dst)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: call System.Void zfunc::vstore<System.Single>(Z0.Vec128`1<System.Single>&,System.Single&)
    IL_0008: ret

}
void vstore_n128x64f(Vector128<double> src, ref double dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.Double* Z0.As::refptr(System.Double&)
    IL_0006: ldarg.0
    IL_0007: call System.Void System.Runtime.Intrinsics.X86.Sse2::Store(System.Double*,System.Runtime.Intrinsics.Vector128`1<System.Double>)
    IL_000C: ret

}
void vstore_d128x64f(Vec128<double> src, ref double dst)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: call System.Void Z0.cpuvec::vstore(Z0.Vec128`1<System.Double>&,System.Double&)
    IL_0008: ret

}
void vstore_g128x64f(Vec128<double> src, ref double dst)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: call System.Void zfunc::vstore<System.Double>(Z0.Vec128`1<System.Double>&,System.Double&)
    IL_0008: ret

}
void vstore_n256x8u(Vector256<byte> src, ref byte dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.Byte* Z0.As::refptr(System.Byte&)
    IL_0006: ldarg.0
    IL_0007: call System.Void System.Runtime.Intrinsics.X86.Avx::Store(System.Byte*,System.Runtime.Intrinsics.Vector256`1<System.Byte>)
    IL_000C: ret

}
void vstore_d256x8u(Vec256<byte> src, ref byte dst)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: call System.Void Z0.cpuvec::vstore(Z0.Vec256`1<System.Byte>&,System.Byte&)
    IL_0008: ret

}
void vstore_g256x8u(Vec256<byte> src, ref byte dst)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: call System.Void zfunc::vstore<System.Byte>(Z0.Vec256`1<System.Byte>&,System.Byte&)
    IL_0008: ret

}
void vstore_n256x8i(Vector256<sbyte> src, ref sbyte dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.SByte* Z0.As::refptr(System.SByte&)
    IL_0006: ldarg.0
    IL_0007: call System.Void System.Runtime.Intrinsics.X86.Avx::Store(System.SByte*,System.Runtime.Intrinsics.Vector256`1<System.SByte>)
    IL_000C: ret

}
void vstore_d256x8i(Vec256<sbyte> src, ref sbyte dst)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: call System.Void Z0.cpuvec::vstore(Z0.Vec256`1<System.SByte>&,System.SByte&)
    IL_0008: ret

}
void vstore_g256x8i(Vec256<sbyte> src, ref sbyte dst)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: call System.Void zfunc::vstore<System.SByte>(Z0.Vec256`1<System.SByte>&,System.SByte&)
    IL_0008: ret

}
void vstore_n256x16i(Vector256<short> src, ref short dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.Int16* Z0.As::refptr(System.Int16&)
    IL_0006: ldarg.0
    IL_0007: call System.Void System.Runtime.Intrinsics.X86.Avx::Store(System.Int16*,System.Runtime.Intrinsics.Vector256`1<System.Int16>)
    IL_000C: ret

}
void vstore_d256x16i(Vec256<short> src, ref short dst)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: call System.Void Z0.cpuvec::vstore(Z0.Vec256`1<System.Int16>&,System.Int16&)
    IL_0008: ret

}
void vstore_g256x16i(Vec256<short> src, ref short dst)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: call System.Void zfunc::vstore<System.Int16>(Z0.Vec256`1<System.Int16>&,System.Int16&)
    IL_0008: ret

}
void vstore_n256x16u(Vector256<ushort> src, ref ushort dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.UInt16* Z0.As::refptr(System.UInt16&)
    IL_0006: ldarg.0
    IL_0007: call System.Void System.Runtime.Intrinsics.X86.Avx::Store(System.UInt16*,System.Runtime.Intrinsics.Vector256`1<System.UInt16>)
    IL_000C: ret

}
void vstore_d256x16u(Vec256<ushort> src, ref ushort dst)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: call System.Void Z0.cpuvec::vstore(Z0.Vec256`1<System.UInt16>&,System.UInt16&)
    IL_0008: ret

}
void vstore_g256x16u(Vec256<ushort> src, ref ushort dst)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: call System.Void zfunc::vstore<System.UInt16>(Z0.Vec256`1<System.UInt16>&,System.UInt16&)
    IL_0008: ret

}
void vstore_n256x32i(Vector256<int> src, ref int dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.Int32* Z0.As::refptr(System.Int32&)
    IL_0006: ldarg.0
    IL_0007: call System.Void System.Runtime.Intrinsics.X86.Avx::Store(System.Int32*,System.Runtime.Intrinsics.Vector256`1<System.Int32>)
    IL_000C: ret

}
void vstore_d256x32i(Vec256<int> src, ref int dst)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: call System.Void Z0.cpuvec::vstore(Z0.Vec256`1<System.Int32>&,System.Int32&)
    IL_0008: ret

}
void vstore_g256x32i(Vec256<int> src, ref int dst)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: call System.Void zfunc::vstore<System.Int32>(Z0.Vec256`1<System.Int32>&,System.Int32&)
    IL_0008: ret

}
void vstore_n256x32u(Vector256<uint> src, ref uint dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.UInt32* Z0.As::refptr(System.UInt32&)
    IL_0006: ldarg.0
    IL_0007: call System.Void System.Runtime.Intrinsics.X86.Avx::Store(System.UInt32*,System.Runtime.Intrinsics.Vector256`1<System.UInt32>)
    IL_000C: ret

}
void vstore_d256x32u(Vec256<uint> src, ref uint dst)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: call System.Void Z0.cpuvec::vstore(Z0.Vec256`1<System.UInt32>&,System.UInt32&)
    IL_0008: ret

}
void vstore_g256x32u(Vec256<uint> src, ref uint dst)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: call System.Void zfunc::vstore<System.UInt32>(Z0.Vec256`1<System.UInt32>&,System.UInt32&)
    IL_0008: ret

}
void vstore_n256x64i(Vector256<long> src, ref long dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.Int64* Z0.As::refptr(System.Int64&)
    IL_0006: ldarg.0
    IL_0007: call System.Void System.Runtime.Intrinsics.X86.Avx::Store(System.Int64*,System.Runtime.Intrinsics.Vector256`1<System.Int64>)
    IL_000C: ret

}
void vstore_d256x64i(Vec256<long> src, ref long dst)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: call System.Void Z0.cpuvec::vstore(Z0.Vec256`1<System.Int64>&,System.Int64&)
    IL_0008: ret

}
void vstore_g256x64i(Vec256<long> src, ref long dst)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: call System.Void zfunc::vstore<System.Int64>(Z0.Vec256`1<System.Int64>&,System.Int64&)
    IL_0008: ret

}
void vstore_n256x64u(Vector256<ulong> src, ref ulong dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.UInt64* Z0.As::refptr(System.UInt64&)
    IL_0006: ldarg.0
    IL_0007: call System.Void System.Runtime.Intrinsics.X86.Avx::Store(System.UInt64*,System.Runtime.Intrinsics.Vector256`1<System.UInt64>)
    IL_000C: ret

}
void vstore_d256x64u(Vec256<ulong> src, ref ulong dst)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: call System.Void Z0.cpuvec::vstore(Z0.Vec256`1<System.UInt64>&,System.UInt64&)
    IL_0008: ret

}
void vstore_g256x64u(Vec256<ulong> src, ref ulong dst)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: call System.Void zfunc::vstore<System.UInt64>(Z0.Vec256`1<System.UInt64>&,System.UInt64&)
    IL_0008: ret

}
void vstore_n256x32f(Vector256<float> src, ref float dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.Single* Z0.As::refptr(System.Single&)
    IL_0006: ldarg.0
    IL_0007: call System.Void System.Runtime.Intrinsics.X86.Avx::Store(System.Single*,System.Runtime.Intrinsics.Vector256`1<System.Single>)
    IL_000C: ret

}
void vstore_d256x32f(Vec256<float> src, ref float dst)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: call System.Void Z0.cpuvec::vstore(Z0.Vec256`1<System.Single>&,System.Single&)
    IL_0008: ret

}
void vstore_g256x32f(Vec256<float> src, ref float dst)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: call System.Void zfunc::vstore<System.Single>(Z0.Vec256`1<System.Single>&,System.Single&)
    IL_0008: ret

}
void vstore_n256x64f(Vector256<double> src, ref double dst)
{
    IL_0000: ldarg.1
    IL_0001: call System.Double* Z0.As::refptr(System.Double&)
    IL_0006: ldarg.0
    IL_0007: call System.Void System.Runtime.Intrinsics.X86.Avx::Store(System.Double*,System.Runtime.Intrinsics.Vector256`1<System.Double>)
    IL_000C: ret

}
void vstore_d256x64f(Vec256<double> src, ref double dst)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: call System.Void Z0.cpuvec::vstore(Z0.Vec256`1<System.Double>&,System.Double&)
    IL_0008: ret

}
void vstore_g256x64f(Vec256<double> src, ref double dst)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: call System.Void zfunc::vstore<System.Double>(Z0.Vec256`1<System.Double>&,System.Double&)
    IL_0008: ret

}
ushort convert_16u_to_g16u(ushort src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt16 Z0.Converter::convert<System.UInt16>(System.UInt16)
    IL_0006: ret

}
int convert_16u_to_g32i(ushort src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int32 Z0.Converter::convert<System.Int32>(System.UInt16)
    IL_0006: ret

}
uint convert_16u_to_g32u(ushort src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 Z0.Converter::convert<System.UInt32>(System.UInt16)
    IL_0006: ret

}
long convert_16u_to_g64i(ushort src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int64 Z0.Converter::convert<System.Int64>(System.UInt16)
    IL_0006: ret

}
ulong convert_16u_to_g64u(ushort src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt64 Z0.Converter::convert<System.UInt64>(System.UInt16)
    IL_0006: ret

}
float convert_16u_to_g32f(ushort src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Single Z0.Converter::convert<System.Single>(System.UInt16)
    IL_0006: ret

}
double convert_16u_to_g64f(ushort src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Double Z0.Converter::convert<System.Double>(System.UInt16)
    IL_0006: ret

}
double convert_g16u_to_g64f(ushort src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Double Z0.Converter::convert<System.UInt16,System.Double>(System.UInt16&)
    IL_0007: ret

}
Char convert_16u_to_gch16(ushort src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Char Z0.Converter::convert<System.Char>(System.UInt16)
    IL_0006: ret

}
sbyte convert_32i_to_gi(int src)
{
    IL_0000: ldarg.0
    IL_0001: conv.i1
    IL_0002: ret

}
sbyte convert_32i_to_g8i(int src)
{
    IL_0000: ldarg.0
    IL_0001: call System.SByte Z0.Converter::convert<System.SByte>(System.Int32)
    IL_0006: ret

}
sbyte convert_g32i_to_g8i(int src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.SByte Z0.Converter::convert<System.Int32,System.SByte>(System.Int32&)
    IL_0007: ret

}
byte convert_32i_to_8u(int src)
{
    IL_0000: ldarg.0
    IL_0001: conv.u1
    IL_0002: ret

}
byte convert_32i_to_g8u(int src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Byte Z0.Converter::convert<System.Byte>(System.Int32)
    IL_0006: ret

}
byte convert_g32i_to_g8u(int src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Byte Z0.Converter::convert<System.Int32,System.Byte>(System.Int32&)
    IL_0007: ret

}
short convert_32i_to_16i(int src)
{
    IL_0000: ldarg.0
    IL_0001: conv.i2
    IL_0002: ret

}
short convert_32i_to_g16i(int src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int16 Z0.Converter::convert<System.Int16>(System.Int32)
    IL_0006: ret

}
short convert_g32i_to_g16i(int src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Int16 Z0.Converter::convert<System.Int32,System.Int16>(System.Int32&)
    IL_0007: ret

}
ushort convert_32i_to_16u(int src)
{
    IL_0000: ldarg.0
    IL_0001: conv.u2
    IL_0002: ret

}
ushort convert_32i_to_g16u(int src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt16 Z0.Converter::convert<System.UInt16>(System.Int32)
    IL_0006: ret

}
ushort convert_g32i_to_g16u(int src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.UInt16 Z0.Converter::convert<System.Int32,System.UInt16>(System.Int32&)
    IL_0007: ret

}
int convert_32i_to_32i(int src)
{
    IL_0000: ldarg.0
    IL_0001: ret

}
int convert_32i_to_g32i(int src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int32 Z0.Converter::convert<System.Int32>(System.Int32)
    IL_0006: ret

}
int convert_g32i_to_g32i(int src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Int32 Z0.Converter::convert<System.Int32,System.Int32>(System.Int32&)
    IL_0007: ret

}
uint convert_32i_to_32u(int src)
{
    IL_0000: ldarg.0
    IL_0001: ret

}
uint convert_32i_to_g32u(int src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 Z0.Converter::convert<System.UInt32>(System.Int32)
    IL_0006: ret

}
uint convert_g32i_to_g32u(int src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.UInt32 Z0.Converter::convert<System.Int32,System.UInt32>(System.Int32&)
    IL_0007: ret

}
long convert_32i_to_64i(int src)
{
    IL_0000: ldarg.0
    IL_0001: conv.i8
    IL_0002: ret

}
long convert_32i_to_g64i(int src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int64 Z0.Converter::convert<System.Int64>(System.Int32)
    IL_0006: ret

}
long convert_g32i_to_g64i(int src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Int64 Z0.Converter::convert<System.Int32,System.Int64>(System.Int32&)
    IL_0007: ret

}
ulong convert_32i_to_64u(int src)
{
    IL_0000: ldarg.0
    IL_0001: conv.i8
    IL_0002: ret

}
ulong convert_32i_to_g64u(int src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt64 Z0.Converter::convert<System.UInt64>(System.Int32)
    IL_0006: ret

}
ulong convert_g32i_to_g64u(int src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.UInt64 Z0.Converter::convert<System.Int32,System.UInt64>(System.Int32&)
    IL_0007: ret

}
float convert_32i_to_32f(int src)
{
    IL_0000: ldarg.0
    IL_0001: conv.r4
    IL_0002: ret

}
float convert_32i_to_g32f(int src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Single Z0.Converter::convert<System.Single>(System.Int32)
    IL_0006: ret

}
float convert_g32i_to_g32f(int src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Single Z0.Converter::convert<System.Int32,System.Single>(System.Int32&)
    IL_0007: ret

}
double convert_32i_to_64f(int src)
{
    IL_0000: ldarg.0
    IL_0001: conv.r8
    IL_0002: ret

}
double convert_32i_to_g64f(int src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Double Z0.Converter::convert<System.Double>(System.Int32)
    IL_0006: ret

}
double convert_g32i_to_g64f(int src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Double Z0.Converter::convert<System.Int32,System.Double>(System.Int32&)
    IL_0007: ret

}
Char convert_32i_to_ch16(int src)
{
    IL_0000: ldarg.0
    IL_0001: conv.u2
    IL_0002: ret

}
Char convert_32i_to_gch16(int src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Char Z0.Converter::convert<System.Char>(System.Int32)
    IL_0006: ret

}
Char convert_g32i_to_gch16(int src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Char Z0.Converter::convert<System.Int32,System.Char>(System.Int32&)
    IL_0007: ret

}
sbyte convert_32u_to_8i(uint src)
{
    IL_0000: ldarg.0
    IL_0001: conv.i1
    IL_0002: ret

}
sbyte convert_32u_to_g8i(uint src)
{
    IL_0000: ldarg.0
    IL_0001: call System.SByte Z0.Converter::convert<System.SByte>(System.UInt32)
    IL_0006: ret

}
sbyte convert_g32u_to_g8i(uint src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.SByte Z0.Converter::convert<System.UInt32,System.SByte>(System.UInt32&)
    IL_0007: ret

}
byte convert_32u_to_8u(uint src)
{
    IL_0000: ldarg.0
    IL_0001: conv.u1
    IL_0002: ret

}
byte convert_32u_to_g8u(uint src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Byte Z0.Converter::convert<System.Byte>(System.UInt32)
    IL_0006: ret

}
byte convert_g32u_to_g8u(uint src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Byte Z0.Converter::convert<System.UInt32,System.Byte>(System.UInt32&)
    IL_0007: ret

}
short convert_32u_to_16i(uint src)
{
    IL_0000: ldarg.0
    IL_0001: conv.i2
    IL_0002: ret

}
short convert_32u_to_g16i(uint src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int16 Z0.Converter::convert<System.Int16>(System.UInt32)
    IL_0006: ret

}
short convert_g32u_to_g16i(uint src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Int16 Z0.Converter::convert<System.UInt32,System.Int16>(System.UInt32&)
    IL_0007: ret

}
ushort convert_32u_to_16u(uint src)
{
    IL_0000: ldarg.0
    IL_0001: conv.u2
    IL_0002: ret

}
ushort convert_32u_to_g16u(uint src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt16 Z0.Converter::convert<System.UInt16>(System.UInt32)
    IL_0006: ret

}
ushort convert_g32u_to_g16u(uint src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.UInt16 Z0.Converter::convert<System.UInt32,System.UInt16>(System.UInt32&)
    IL_0007: ret

}
int convert_32u_to_32i(uint src)
{
    IL_0000: ldarg.0
    IL_0001: ret

}
int convert_32u_to_g32i(uint src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int32 Z0.Converter::convert<System.Int32>(System.UInt32)
    IL_0006: ret

}
int convert_g32u_to_g32i(uint src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Int32 Z0.Converter::convert<System.UInt32,System.Int32>(System.UInt32&)
    IL_0007: ret

}
uint convert_32u_to_32u(uint src)
{
    IL_0000: ldarg.0
    IL_0001: ret

}
uint convert_32u_to_g32u(uint src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 Z0.Converter::convert<System.UInt32>(System.UInt32)
    IL_0006: ret

}
uint convert_g32u_to_g32u(uint src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.UInt32 Z0.Converter::convert<System.UInt32,System.UInt32>(System.UInt32&)
    IL_0007: ret

}
long convert_32u_to_64i(uint src)
{
    IL_0000: ldarg.0
    IL_0001: conv.u8
    IL_0002: ret

}
long convert_32u_to_g64i(uint src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int64 Z0.Converter::convert<System.Int64>(System.UInt32)
    IL_0006: ret

}
long convert_g32u_to_g64i(uint src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Int64 Z0.Converter::convert<System.UInt32,System.Int64>(System.UInt32&)
    IL_0007: ret

}
ulong convert_32u_to_64u(uint src)
{
    IL_0000: ldarg.0
    IL_0001: conv.u8
    IL_0002: ret

}
ulong convert_32u_to_g64u(uint src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt64 Z0.Converter::convert<System.UInt64>(System.UInt32)
    IL_0006: ret

}
ulong convert_g32u_to_g64u(uint src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.UInt64 Z0.Converter::convert<System.UInt32,System.UInt64>(System.UInt32&)
    IL_0007: ret

}
float convert_32u_to_32f(uint src)
{
    IL_0000: ldarg.0
    IL_0001: conv.r.un
    IL_0002: conv.r4
    IL_0003: ret

}
float convert_32u_to_g32f(uint src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Single Z0.Converter::convert<System.Single>(System.UInt32)
    IL_0006: ret

}
float convert_g32u_to_g32f(uint src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Single Z0.Converter::convert<System.UInt32,System.Single>(System.UInt32&)
    IL_0007: ret

}
double convert_32u_to_64f(uint src)
{
    IL_0000: ldarg.0
    IL_0001: conv.r.un
    IL_0002: conv.r8
    IL_0003: ret

}
double convert_32u_to_g64f(uint src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Double Z0.Converter::convert<System.Double>(System.UInt32)
    IL_0006: ret

}
double convert_g32u_to_g64f(uint src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Double Z0.Converter::convert<System.UInt32,System.Double>(System.UInt32&)
    IL_0007: ret

}
Char convert_32u_to_ch(uint src)
{
    IL_0000: ldarg.0
    IL_0001: conv.u2
    IL_0002: ret

}
Char convert_32u_to_gch16(uint src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Char Z0.Converter::convert<System.Char>(System.UInt32)
    IL_0006: ret

}
Char convert_g32u_to_gch16(uint src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Char Z0.Converter::convert<System.UInt32,System.Char>(System.UInt32&)
    IL_0007: ret

}
byte convert_64i_to_g8u(long src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Byte Z0.Converter::convert<System.Byte>(System.Int64)
    IL_0006: ret

}
sbyte convert_64i_to_g8i(long src)
{
    IL_0000: ldarg.0
    IL_0001: call System.SByte Z0.Converter::convert<System.SByte>(System.Int64)
    IL_0006: ret

}
ushort convert_64i_to_g16u(long src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt16 Z0.Converter::convert<System.UInt16>(System.Int64)
    IL_0006: ret

}
short convert_64i_to_g16i(long src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int16 Z0.Converter::convert<System.Int16>(System.Int64)
    IL_0006: ret

}
int convert_64i_to_g32i(long src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int32 Z0.Converter::convert<System.Int32>(System.Int64)
    IL_0006: ret

}
uint convert_64i_to_g32u(long src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 Z0.Converter::convert<System.UInt32>(System.Int64)
    IL_0006: ret

}
long convert_64i_to_g64i(long src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int64 Z0.Converter::convert<System.Int64>(System.Int64)
    IL_0006: ret

}
ulong convert_64i_to_g64u(long src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt64 Z0.Converter::convert<System.UInt64>(System.Int64)
    IL_0006: ret

}
float convert_64i_to_g32f(long src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Single Z0.Converter::convert<System.Single>(System.Int64)
    IL_0006: ret

}
double convert_64i_to_g64f(long src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Double Z0.Converter::convert<System.Double>(System.Int64)
    IL_0006: ret

}
Char convert_64i_to_gch16(long src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Char Z0.Converter::convert<System.Char>(System.Int64)
    IL_0006: ret

}
sbyte convert_64u_to_g8i(ulong src)
{
    IL_0000: ldarg.0
    IL_0001: call System.SByte Z0.Converter::convert<System.SByte>(System.UInt64)
    IL_0006: ret

}
byte convert_64u_to_g8u(ulong src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Byte Z0.Converter::convert<System.Byte>(System.UInt64)
    IL_0006: ret

}
short convert_64u_to_g16i(ulong src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int16 Z0.Converter::convert<System.Int16>(System.UInt64)
    IL_0006: ret

}
ushort convert_64u_to_g16u(ulong src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt16 Z0.Converter::convert<System.UInt16>(System.UInt64)
    IL_0006: ret

}
ushort convert_g64u_to_g16u(ulong src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.UInt16 Z0.Converter::convert<System.UInt64,System.UInt16>(System.UInt64&)
    IL_0007: ret

}
int convert_64u_to_g32i(ulong src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int32 Z0.Converter::convert<System.Int32>(System.UInt64)
    IL_0006: ret

}
uint convert_64u_to_g32u(ulong src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 Z0.Converter::convert<System.UInt32>(System.UInt64)
    IL_0006: ret

}
uint convert_64u_to_32u(ulong src)
{
    IL_0000: ldarg.0
    IL_0001: conv.u4
    IL_0002: ret

}
uint convert_g64u_to_g32u(ulong src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.UInt32 Z0.Converter::convert<System.UInt64,System.UInt32>(System.UInt64&)
    IL_0007: ret

}
long convert_64u_to_g64i(ulong src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int64 Z0.Converter::convert<System.Int64>(System.UInt64)
    IL_0006: ret

}
ulong convert_64u_to_g64u(ulong src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt64 Z0.Converter::convert<System.UInt64>(System.UInt64)
    IL_0006: ret

}
float convert_64u_to_g32f(ulong src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Single Z0.Converter::convert<System.Single>(System.UInt64)
    IL_0006: ret

}
double convert_64u_to_64f(ulong src)
{
    IL_0000: ldarg.0
    IL_0001: conv.r8
    IL_0002: ret

}
double convert_64u_to_g64f(ulong src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Double Z0.Converter::convert<System.Double>(System.UInt64)
    IL_0006: ret

}
double convert_g64u_to_g64f(ulong src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Double Z0.Converter::convert<System.UInt64,System.Double>(System.UInt64&)
    IL_0007: ret

}
Char convert_64u_to_gch16(ulong src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Char Z0.Converter::convert<System.Char>(System.UInt64)
    IL_0006: ret

}
sbyte convert_32f_to_g8i(float src)
{
    IL_0000: ldarg.0
    IL_0001: call System.SByte Z0.Converter::convert<System.SByte>(System.Single)
    IL_0006: ret

}
byte convert_32f_to_g8u(float src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Byte Z0.Converter::convert<System.Byte>(System.Single)
    IL_0006: ret

}
short convert_32f_to_g16i(float src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int16 Z0.Converter::convert<System.Int16>(System.Single)
    IL_0006: ret

}
ushort convert_32f_to_g16u(float src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt16 Z0.Converter::convert<System.UInt16>(System.Single)
    IL_0006: ret

}
int convert_32f_to_g32i(float src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int32 Z0.Converter::convert<System.Int32>(System.Single)
    IL_0006: ret

}
uint convert_32f_to_g32u(float src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 Z0.Converter::convert<System.UInt32>(System.Single)
    IL_0006: ret

}
long convert_32f_to_g64i(float src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int64 Z0.Converter::convert<System.Int64>(System.Single)
    IL_0006: ret

}
ulong convert_32f_to_g64u(float src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt64 Z0.Converter::convert<System.UInt64>(System.Single)
    IL_0006: ret

}
float convert_32f_to_g32f(float src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Single Z0.Converter::convert<System.Single>(System.Single)
    IL_0006: ret

}
double convert_32f_to_g64f(float src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Double Z0.Converter::convert<System.Double>(System.Single)
    IL_0006: ret

}
Char convert_32f_to_gch16(float src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Char Z0.Converter::convert<System.Char>(System.Single)
    IL_0006: ret

}
sbyte convert_64f_to_8i(double src)
{
    IL_0000: ldarg.0
    IL_0001: conv.i1
    IL_0002: ret

}
sbyte convert_64f_to_g8i(double src)
{
    IL_0000: ldarg.0
    IL_0001: call System.SByte Z0.Converter::convert<System.SByte>(System.Double)
    IL_0006: ret

}
sbyte convert_g64f_to_g8i(double src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.SByte Z0.Converter::convert<System.Double,System.SByte>(System.Double&)
    IL_0007: ret

}
byte convert_64f_to_8u(double src)
{
    IL_0000: ldarg.0
    IL_0001: conv.i8
    IL_0002: conv.u1
    IL_0003: ret

}
byte convert_64f_to_g8u(double src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Byte Z0.Converter::convert<System.Byte>(System.Double)
    IL_0006: ret

}
byte convert_g64f_to_g8u(double src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Byte Z0.Converter::convert<System.Double,System.Byte>(System.Double&)
    IL_0007: ret

}
short convert_64f_to_16i(double src)
{
    IL_0000: ldarg.0
    IL_0001: conv.i2
    IL_0002: ret

}
short convert_64f_to_g16i(double src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int16 Z0.Converter::convert<System.Int16>(System.Double)
    IL_0006: ret

}
short convert_g64f_to_g16i(double src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Int16 Z0.Converter::convert<System.Double,System.Int16>(System.Double&)
    IL_0007: ret

}
ushort convert_64f_to_g16u(double src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt16 Z0.Converter::convert<System.UInt16>(System.Double)
    IL_0006: ret

}
ushort convert_g64f_to_g16u(double src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.UInt16 Z0.Converter::convert<System.Double,System.UInt16>(System.Double&)
    IL_0007: ret

}
int convert_64f_to_g32i(double src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int32 Z0.Converter::convert<System.Int32>(System.Double)
    IL_0006: ret

}
int convert_g64f_to_g32i(double src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Int32 Z0.Converter::convert<System.Double,System.Int32>(System.Double&)
    IL_0007: ret

}
uint convert_64f_to_g32u(double src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 Z0.Converter::convert<System.UInt32>(System.Double)
    IL_0006: ret

}
uint convert_g64f_to_g32u(double src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.UInt32 Z0.Converter::convert<System.Double,System.UInt32>(System.Double&)
    IL_0007: ret

}
ReadOnlySpan<byte> bitseq(byte value)
{
    IL_0000: ldarg.0
    IL_0001: call System.ReadOnlySpan`1<System.Byte> Z0.BitStore::select(System.Byte)
    IL_0006: ret

}
ReadOnlySpan<byte> bitseq(BitSize offset, BitSize count)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.ReadOnlySpan`1<System.Byte> Z0.BitStore::select(Z0.BitSize,Z0.BitSize)
    IL_0007: ret

}
ByteInfo byteinfo(byte src)
{
    IL_0000: ldarg.0
    IL_0001: call Z0.ByteInfo Z0.BitStore::info(System.Byte)
    IL_0006: ret

}
ReadOnlySpan<byte> bitseq8i(sbyte src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.ReadOnlySpan`1<System.Byte> Z0.BitStore::bitseq<System.SByte>(System.SByte&)
    IL_0007: ret

}
ReadOnlySpan<byte> bitseq8u(byte src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.ReadOnlySpan`1<System.Byte> Z0.BitStore::bitseq<System.Byte>(System.Byte&)
    IL_0007: ret

}
ReadOnlySpan<byte> bitseq16i(short src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.ReadOnlySpan`1<System.Byte> Z0.BitStore::bitseq<System.Int16>(System.Int16&)
    IL_0007: ret

}
ReadOnlySpan<byte> bitseq16u(ushort src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.ReadOnlySpan`1<System.Byte> Z0.BitStore::bitseq<System.UInt16>(System.UInt16&)
    IL_0007: ret

}
ReadOnlySpan<byte> bitseq32i(int src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.ReadOnlySpan`1<System.Byte> Z0.BitStore::bitseq<System.Int32>(System.Int32&)
    IL_0007: ret

}
ReadOnlySpan<byte> bitseq32u(uint src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.ReadOnlySpan`1<System.Byte> Z0.BitStore::bitseq<System.UInt32>(System.UInt32&)
    IL_0007: ret

}
ReadOnlySpan<byte> bitseq64i(long src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.ReadOnlySpan`1<System.Byte> Z0.BitStore::bitseq<System.Int64>(System.Int64&)
    IL_0007: ret

}
ReadOnlySpan<byte> bitseq64u(ulong src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.ReadOnlySpan`1<System.Byte> Z0.BitStore::bitseq<System.UInt64>(System.UInt64&)
    IL_0007: ret

}
ReadOnlySpan<byte> bitseq32f(float src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.ReadOnlySpan`1<System.Byte> Z0.BitStore::bitseq<System.Single>(System.Single&)
    IL_0007: ret

}
ReadOnlySpan<byte> bitseq64f(double src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.ReadOnlySpan`1<System.Byte> Z0.BitStore::bitseq<System.Double>(System.Double&)
    IL_0007: ret

}
ref sbyte enable_d8i(ref sbyte src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.SByte& Z0.BitMask::enable(System.SByte&,System.Int32)
    IL_0007: ret

}
ref sbyte enable_g8i(ref sbyte src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.SByte& Z0.BitMaskG::enable<System.SByte>(System.SByte&,System.Int32)
    IL_0007: ret

}
ref byte enable_d8u(ref byte src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Byte& Z0.BitMask::enable(System.Byte&,System.Int32)
    IL_0007: ret

}
ref byte enable_g8u(ref byte src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Byte& Z0.BitMaskG::enable<System.Byte>(System.Byte&,System.Int32)
    IL_0007: ret

}
ref short enable_d16i(ref short src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Int16& Z0.BitMask::enable(System.Int16&,System.Int32)
    IL_0007: ret

}
ref short enable_g16i(ref short src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Int16& Z0.BitMaskG::enable<System.Int16>(System.Int16&,System.Int32)
    IL_0007: ret

}
ref ushort enable_d16u(ref ushort src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt16& Z0.BitMask::enable(System.UInt16&,System.Int32)
    IL_0007: ret

}
ref ushort enable_g16u(ref ushort src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt16& Z0.BitMaskG::enable<System.UInt16>(System.UInt16&,System.Int32)
    IL_0007: ret

}
ref int enable_d32i(ref int src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Int32& Z0.BitMask::enable(System.Int32&,System.Int32)
    IL_0007: ret

}
ref int enable_g32i(ref int src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Int32& Z0.BitMaskG::enable<System.Int32>(System.Int32&,System.Int32)
    IL_0007: ret

}
ref uint enable_d32u(ref uint src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32& Z0.BitMask::enable(System.UInt32&,System.Int32)
    IL_0007: ret

}
ref uint enable_g32u(ref uint src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt32& Z0.BitMaskG::enable<System.UInt32>(System.UInt32&,System.Int32)
    IL_0007: ret

}
ref long enable_d64i(ref long src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Int64& Z0.BitMask::enable(System.Int64&,System.Int32)
    IL_0007: ret

}
ref long enable_g64i(ref long src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Int64& Z0.BitMaskG::enable<System.Int64>(System.Int64&,System.Int32)
    IL_0007: ret

}
ref ulong enable_d64u(ref ulong src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64& Z0.BitMask::enable(System.UInt64&,System.Int32)
    IL_0007: ret

}
ref ulong enable_g64u(ref ulong src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.UInt64& Z0.BitMaskG::enable<System.UInt64>(System.UInt64&,System.Int32)
    IL_0007: ret

}
ref float enable_d32f(ref float src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Single& Z0.BitMask::enable(System.Single&,System.Int32)
    IL_0007: ret

}
ref float enable_g32f(ref float src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Single& Z0.BitMaskG::enable<System.Single>(System.Single&,System.Int32)
    IL_0007: ret

}
ref double enable_d64f(ref double src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Double& Z0.BitMask::enable(System.Double&,System.Int32)
    IL_0007: ret

}
ref double enable_g64f(ref double src, int pos)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: call System.Double& Z0.BitMaskG::enable<System.Double>(System.Double&,System.Int32)
    IL_0007: ret

}
bool testbit_d8i(sbyte src, int pos)
{
    IL_0000: ldarga.s src
    IL_0002: ldarga.s pos
    IL_0004: call System.Boolean Z0.BitMask::test(System.SByte&,System.Int32&)
    IL_0009: ret

}
bool testbit_g8i(sbyte src, int pos)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: call System.Boolean Z0.BitMaskG::testbit<System.SByte>(System.SByte&,System.Int32)
    IL_0008: ret

}
bool testbit_d8u(byte src, int pos)
{
    IL_0000: ldarga.s src
    IL_0002: ldarga.s pos
    IL_0004: call System.Boolean Z0.BitMask::test(System.Byte&,System.Int32&)
    IL_0009: ret

}
bool testbit_g8u(byte src, int pos)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: call System.Boolean Z0.BitMaskG::testbit<System.Byte>(System.Byte&,System.Int32)
    IL_0008: ret

}
bool testbit_d16i(short src, int pos)
{
    IL_0000: ldarga.s src
    IL_0002: ldarga.s pos
    IL_0004: call System.Boolean Z0.BitMask::test(System.Int16&,System.Int32&)
    IL_0009: ret

}
bool testbit_g16i(short src, int pos)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: call System.Boolean Z0.BitMaskG::testbit<System.Int16>(System.Int16&,System.Int32)
    IL_0008: ret

}
bool testbit_d16u(ushort src, int pos)
{
    IL_0000: ldarga.s src
    IL_0002: ldarga.s pos
    IL_0004: call System.Boolean Z0.BitMask::test(System.UInt16&,System.Int32&)
    IL_0009: ret

}
bool testbit_g16u(ushort src, int pos)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: call System.Boolean Z0.BitMaskG::testbit<System.UInt16>(System.UInt16&,System.Int32)
    IL_0008: ret

}
bool testbit_d32i(int src, int pos)
{
    IL_0000: ldarga.s src
    IL_0002: ldarga.s pos
    IL_0004: call System.Boolean Z0.BitMask::test(System.Int32&,System.Int32&)
    IL_0009: ret

}
bool testbit_g32i(int src, int pos)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: call System.Boolean Z0.BitMaskG::testbit<System.Int32>(System.Int32&,System.Int32)
    IL_0008: ret

}
bool testbit_d32u(uint src, int pos)
{
    IL_0000: ldarga.s src
    IL_0002: ldarga.s pos
    IL_0004: call System.Boolean Z0.BitMask::test(System.UInt32&,System.Int32&)
    IL_0009: ret

}
bool testbit_g32u(uint src, int pos)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: call System.Boolean Z0.BitMaskG::testbit<System.UInt32>(System.UInt32&,System.Int32)
    IL_0008: ret

}
bool testbit_d64i(long src, int pos)
{
    IL_0000: ldarga.s src
    IL_0002: ldarga.s pos
    IL_0004: call System.Boolean Z0.BitMask::test(System.Int64&,System.Int32&)
    IL_0009: ret

}
bool testbit_g64i(long src, int pos)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: call System.Boolean Z0.BitMaskG::testbit<System.Int64>(System.Int64&,System.Int32)
    IL_0008: ret

}
bool testbit_d64u(ulong src, int pos)
{
    IL_0000: ldarga.s src
    IL_0002: ldarga.s pos
    IL_0004: call System.Boolean Z0.BitMask::test(System.UInt64&,System.Int32&)
    IL_0009: ret

}
bool testbit_g64u(ulong src, int pos)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: call System.Boolean Z0.BitMaskG::testbit<System.UInt64>(System.UInt64&,System.Int32)
    IL_0008: ret

}
bool testbit_d32f(float src, int pos)
{
    IL_0000: ldarga.s src
    IL_0002: ldarga.s pos
    IL_0004: call System.Boolean Z0.BitMask::test(System.Single&,System.Int32&)
    IL_0009: ret

}
bool testbit_g32f(float src, int pos)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: call System.Boolean Z0.BitMaskG::testbit<System.Single>(System.Single&,System.Int32)
    IL_0008: ret

}
bool testbit_d64f(double src, int pos)
{
    IL_0000: ldarga.s src
    IL_0002: ldarga.s pos
    IL_0004: call System.Boolean Z0.BitMask::test(System.Double&,System.Int32&)
    IL_0009: ret

}
bool testbit_g64f(double src, int pos)
{
    IL_0000: ldarga.s src
    IL_0002: ldarg.1
    IL_0003: call System.Boolean Z0.BitMaskG::testbit<System.Double>(System.Double&,System.Int32)
    IL_0008: ret

}
byte convert_8i_to_8u(sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: conv.u1
    IL_0002: ret

}
byte convert_8i_to_g8u(sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Byte Z0.Converter::convert<System.Byte>(System.SByte)
    IL_0006: ret

}
byte convert_g8i_to_g8u(sbyte src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Byte Z0.Converter::convert<System.SByte,System.Byte>(System.SByte&)
    IL_0007: ret

}
sbyte convert_8i_to_8i(sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: ret

}
sbyte convert_8i_to_g8i(sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.SByte Z0.Converter::convert<System.SByte>(System.SByte)
    IL_0006: ret

}
byte convert_g8i_to_g8i(sbyte src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Byte Z0.Converter::convert<System.SByte,System.Byte>(System.SByte&)
    IL_0007: ret

}
short convert_8i_to_16i(sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: ret

}
short convert_8i_to_g16i(sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int16 Z0.Converter::convert<System.Int16>(System.SByte)
    IL_0006: ret

}
short convert_g8i_to_g16i(sbyte src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Int16 Z0.Converter::convert<System.SByte,System.Int16>(System.SByte&)
    IL_0007: ret

}
ushort convert_8i_to_16u(sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: conv.u2
    IL_0002: ret

}
ushort convert_8i_to_g16u(sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt16 Z0.Converter::convert<System.UInt16>(System.SByte)
    IL_0006: ret

}
ushort convert_g8i_to_g16u(sbyte src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.UInt16 Z0.Converter::convert<System.SByte,System.UInt16>(System.SByte&)
    IL_0007: ret

}
int convert_8i_to_32i(sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: ret

}
int convert_8i_to_g32i(sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int32 Z0.Converter::convert<System.Int32>(System.SByte)
    IL_0006: ret

}
int convert_g8i_to_g32i(sbyte src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Int32 Z0.Converter::convert<System.SByte,System.Int32>(System.SByte&)
    IL_0007: ret

}
uint convert_8i_to_g32(sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: ret

}
uint convert_8i_to_g32u(sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 Z0.Converter::convert<System.UInt32>(System.SByte)
    IL_0006: ret

}
uint convert_g8i_to_g32u(sbyte src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.UInt32 Z0.Converter::convert<System.SByte,System.UInt32>(System.SByte&)
    IL_0007: ret

}
long convert_8i_to_64i(sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: conv.i8
    IL_0002: ret

}
long convert_8i_to_g64i(sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int64 Z0.Converter::convert<System.Int64>(System.SByte)
    IL_0006: ret

}
long convert_g8i_to_g64i(sbyte src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Int64 Z0.Converter::convert<System.SByte,System.Int64>(System.SByte&)
    IL_0007: ret

}
ulong convert_8i_to_64u(sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: conv.i8
    IL_0002: ret

}
ulong convert_8i_to_g64u(sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt64 Z0.Converter::convert<System.UInt64>(System.SByte)
    IL_0006: ret

}
ulong convert_g8i_to_g64u(sbyte src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.UInt64 Z0.Converter::convert<System.SByte,System.UInt64>(System.SByte&)
    IL_0007: ret

}
float convert_8i_to_32f(sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: conv.r4
    IL_0002: ret

}
float convert_8i_to_g32f(sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Single Z0.Converter::convert<System.Single>(System.SByte)
    IL_0006: ret

}
float convert_g8i_to_g32f(sbyte src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Single Z0.Converter::convert<System.SByte,System.Single>(System.SByte&)
    IL_0007: ret

}
double convert_8i_to_64f(sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: conv.r8
    IL_0002: ret

}
double convert_8i_to_g64f(sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Double Z0.Converter::convert<System.Double>(System.SByte)
    IL_0006: ret

}
double convert_g8i_to_g64f(sbyte src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Double Z0.Converter::convert<System.SByte,System.Double>(System.SByte&)
    IL_0007: ret

}
Char convert_8i_to_ch16(sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: conv.u2
    IL_0002: ret

}
Char convert_8i_to_gch16(sbyte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Char Z0.Converter::convert<System.Char>(System.SByte)
    IL_0006: ret

}
Char convert_g8i_to_gch16(sbyte src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Char Z0.Converter::convert<System.SByte,System.Char>(System.SByte&)
    IL_0007: ret

}
sbyte convert_8u_to_8i(byte src)
{
    IL_0000: ldarg.0
    IL_0001: conv.i1
    IL_0002: ret

}
sbyte convert_8u_to_g8i(byte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.SByte Z0.Converter::convert<System.SByte>(System.Byte)
    IL_0006: ret

}
sbyte convert_g8u_to_g8i(byte src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.SByte Z0.Converter::convert<System.Byte,System.SByte>(System.Byte&)
    IL_0007: ret

}
byte convert_8u_to_g8u(byte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Byte Z0.Converter::convert<System.Byte>(System.Byte)
    IL_0006: ret

}
byte convert_g8u_to_g8u(byte src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Byte Z0.Converter::convert<System.Byte,System.Byte>(System.Byte&)
    IL_0007: ret

}
short convert_8u_to_16i(byte src)
{
    IL_0000: ldarg.0
    IL_0001: ret

}
short convert_8u_to_g16i(byte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int16 Z0.Converter::convert<System.Int16>(System.Byte)
    IL_0006: ret

}
ushort convert_8u_to_16u(byte src)
{
    IL_0000: ldarg.0
    IL_0001: ret

}
ushort convert_8u_to_g16u(byte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt16 Z0.Converter::convert<System.UInt16>(System.Byte)
    IL_0006: ret

}
ushort convert_g8u_to_g16u(byte src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.UInt16 Z0.Converter::convert<System.Byte,System.UInt16>(System.Byte&)
    IL_0007: ret

}
int convert_8u_to_g32i(byte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int32 Z0.Converter::convert<System.Int32>(System.Byte)
    IL_0006: ret

}
int convert_g8u_to_g32i(byte src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Int32 Z0.Converter::convert<System.Byte,System.Int32>(System.Byte&)
    IL_0007: ret

}
uint convert_8u_to_g32u(byte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 Z0.Converter::convert<System.UInt32>(System.Byte)
    IL_0006: ret

}
uint convert_g8u_to_g32u(byte src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.UInt32 Z0.Converter::convert<System.Byte,System.UInt32>(System.Byte&)
    IL_0007: ret

}
long convert_8u_to_g64i(byte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int64 Z0.Converter::convert<System.Int64>(System.Byte)
    IL_0006: ret

}
long convert_g8u_to_g64i(byte src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Int64 Z0.Converter::convert<System.Byte,System.Int64>(System.Byte&)
    IL_0007: ret

}
ulong convert_8u_to_g64u(byte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt64 Z0.Converter::convert<System.UInt64>(System.Byte)
    IL_0006: ret

}
ulong convert_g8u_to_g64u(byte src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.UInt64 Z0.Converter::convert<System.Byte,System.UInt64>(System.Byte&)
    IL_0007: ret

}
float convert_8u_to_g32f(byte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Single Z0.Converter::convert<System.Single>(System.Byte)
    IL_0006: ret

}
float convert_g8u_to_g32f(byte src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Single Z0.Converter::convert<System.Byte,System.Single>(System.Byte&)
    IL_0007: ret

}
double convert_8u_to_g64f(byte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Double Z0.Converter::convert<System.Double>(System.Byte)
    IL_0006: ret

}
double convert_g8u_to_g64f(byte src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Double Z0.Converter::convert<System.Byte,System.Double>(System.Byte&)
    IL_0007: ret

}
Char convert_8u_to_gch16(byte src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Char Z0.Converter::convert<System.Char>(System.Byte)
    IL_0006: ret

}
Char convert_g8u_to_gch16(byte src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Char Z0.Converter::convert<System.Byte,System.Char>(System.Byte&)
    IL_0007: ret

}
byte convert_16i_to_g8u(short src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Byte Z0.Converter::convert<System.Byte>(System.Int16)
    IL_0006: ret

}
sbyte convert_16i_to_g8i(short src)
{
    IL_0000: ldarg.0
    IL_0001: call System.SByte Z0.Converter::convert<System.SByte>(System.Int16)
    IL_0006: ret

}
ushort convert_16i_to_g16u(short src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt16 Z0.Converter::convert<System.UInt16>(System.Int16)
    IL_0006: ret

}
short convert_16i_to_g16i(short src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int16 Z0.Converter::convert<System.Int16>(System.Int16)
    IL_0006: ret

}
int convert_16i_to_g32i(short src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int32 Z0.Converter::convert<System.Int32>(System.Int16)
    IL_0006: ret

}
uint convert_16i_to_g32u(short src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt32 Z0.Converter::convert<System.UInt32>(System.Int16)
    IL_0006: ret

}
long convert_16i_to_g64i(short src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int64 Z0.Converter::convert<System.Int64>(System.Int16)
    IL_0006: ret

}
ulong convert_16i_to_g64u(short src)
{
    IL_0000: ldarg.0
    IL_0001: call System.UInt64 Z0.Converter::convert<System.UInt64>(System.Int16)
    IL_0006: ret

}
ulong convert_g16i_to_g64u(short src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.UInt64 Z0.Converter::convert<System.Int16,System.UInt64>(System.Int16&)
    IL_0007: ret

}
float convert_16i_to_g32f(short src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Single Z0.Converter::convert<System.Single>(System.Int16)
    IL_0006: ret

}
float convert_g16i_to_g32f(short src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Single Z0.Converter::convert<System.Int16,System.Single>(System.Int16&)
    IL_0007: ret

}
double convert_16i_to_g64f(short src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Double Z0.Converter::convert<System.Double>(System.Int16)
    IL_0006: ret

}
double convert_g16i_to_g64f(short src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Double Z0.Converter::convert<System.Int16,System.Double>(System.Int16&)
    IL_0007: ret

}
Char convert_16i_to_gch16(short src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Char Z0.Converter::convert<System.Char>(System.Int16)
    IL_0006: ret

}
Char convert_g16i_to_gch16(short src)
{
    IL_0000: ldarga.s src
    IL_0002: call System.Char Z0.Converter::convert<System.Int16,System.Char>(System.Int16&)
    IL_0007: ret

}
sbyte convert_16u_to_g8i(ushort src)
{
    IL_0000: ldarg.0
    IL_0001: call System.SByte Z0.Converter::convert<System.SByte>(System.UInt16)
    IL_0006: ret

}
byte convert_16u_to_g8u(ushort src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Byte Z0.Converter::convert<System.Byte>(System.UInt16)
    IL_0006: ret

}
short convert_16u_to_g16i(ushort src)
{
    IL_0000: ldarg.0
    IL_0001: call System.Int16 Z0.Converter::convert<System.Int16>(System.UInt16)
    IL_0006: ret

}
