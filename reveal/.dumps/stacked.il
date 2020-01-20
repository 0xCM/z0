// 2020-01-20 01:59:20:927
// Id := 100664370, Name := Z0.Stacked/MemStack64 Z0.OpCodes.stacked::ss_alloc_64()
// MemStack64 ss_alloc_64()
// IL
MemStack64 ss_alloc_64()
{
    IL_0000: call Z0.N64 zfunc::get_n64()
    IL_0005: call Z0.Stacked/MemStack64 Z0.Stacks::alloc(Z0.N64)
    IL_000A: ret
}

// Id := 100664371, Name := Z0.Stacked/MemStack128 Z0.OpCodes.stacked::ss_alloc_128()
// MemStack128 ss_alloc_128()
// IL
MemStack128 ss_alloc_128()
{
    IL_0000: call Z0.N128 zfunc::get_n128()
    IL_0005: call Z0.Stacked/MemStack128 Z0.Stacks::alloc(Z0.N128)
    IL_000A: ret
}

// Id := 100664372, Name := Z0.Stacked/MemStack256 Z0.OpCodes.stacked::ss_alloc_256()
// MemStack256 ss_alloc_256()
// IL
MemStack256 ss_alloc_256()
{
    IL_0000: call Z0.N256 zfunc::get_n256()
    IL_0005: call Z0.Stacked/MemStack256 Z0.Stacks::alloc(Z0.N256)
    IL_000A: ret
}

// Id := 100664373, Name := Z0.Stacked/MemStack512 Z0.OpCodes.stacked::ss_alloc_512()
// MemStack512 ss_alloc_512()
// IL
MemStack512 ss_alloc_512()
{
    IL_0000: call Z0.N512 zfunc::get_n512()
    IL_0005: call Z0.Stacked/MemStack512 Z0.Stacks::alloc(Z0.N512)
    IL_000A: ret
}

// Id := 100664374, Name := Z0.Stacked/MemStack1024 Z0.OpCodes.stacked::ss_alloc_1024()
// MemStack1024 ss_alloc_1024()
// IL
MemStack1024 ss_alloc_1024()
{
    IL_0000: call Z0.N1024 zfunc::get_n1024()
    IL_0005: call Z0.Stacked/MemStack1024 Z0.Stacks::alloc(Z0.N1024)
    IL_000A: ret
}

// Id := 100664375, Name := System.Void Z0.OpCodes.stacked::ss_store_128(System.Byte&,System.UInt32,Z0.Stacked/MemStack128&)
// void ss_store_128(in byte src, uint count, ref MemStack128 dst)
// IL
void ss_store_128(in byte src, uint count, ref MemStack128 dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call System.Void Z0.Stacks::store(System.Byte&,System.UInt32,Z0.Stacked/MemStack128&)
    IL_0008: ret
}

// Id := 100664376, Name := System.Span`1<System.Byte> Z0.OpCodes.stacked::ss_span_128x8(Z0.Stacked/MemStack128&)
// Span<byte> ss_span_128x8(ref MemStack128 src)
// IL
Span<byte> ss_span_128x8(ref MemStack128 src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: call System.Span`1<System.Byte> Z0.Stacks::span<System.Byte>(Z0.Stacked/MemStack128&,System.Byte)
    IL_0007: ret
}

// Id := 100664377, Name := System.Span`1<System.Byte> Z0.OpCodes.stacked::ss_span_256x8(Z0.Stacked/MemStack256&)
// Span<byte> ss_span_256x8(ref MemStack256 src)
// IL
Span<byte> ss_span_256x8(ref MemStack256 src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: call System.Span`1<System.Byte> Z0.Stacks::span<System.Byte>(Z0.Stacked/MemStack256&,System.Byte)
    IL_0007: ret
}

// Id := 100664378, Name := System.Byte& Z0.OpCodes.stacked::ss_head_128x8(Z0.Stacked/MemStack128&)
// ref byte ss_head_128x8(ref MemStack128 src)
// IL
ref byte ss_head_128x8(ref MemStack128 src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: call System.Byte& Z0.Stacks::head<System.Byte>(Z0.Stacked/MemStack128&,System.Byte)
    IL_0007: ret
}

// Id := 100664379, Name := System.UInt16& Z0.OpCodes.stacked::ss_head_128x16(Z0.Stacked/MemStack128&)
// ref ushort ss_head_128x16(ref MemStack128 src)
// IL
ref ushort ss_head_128x16(ref MemStack128 src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: call System.UInt16& Z0.Stacks::head<System.UInt16>(Z0.Stacked/MemStack128&,System.UInt16)
    IL_0007: ret
}

// Id := 100664380, Name := System.UInt32& Z0.OpCodes.stacked::ss_head_128x32(Z0.Stacked/MemStack128&)
// ref uint ss_head_128x32(ref MemStack128 src)
// IL
ref uint ss_head_128x32(ref MemStack128 src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: call System.UInt32& Z0.Stacks::head<System.UInt32>(Z0.Stacked/MemStack128&,System.UInt32)
    IL_0007: ret
}

// Id := 100664381, Name := System.UInt64& Z0.OpCodes.stacked::ss_head_128x64(Z0.Stacked/MemStack128&)
// ref ulong ss_head_128x64(ref MemStack128 src)
// IL
ref ulong ss_head_128x64(ref MemStack128 src)
{
    IL_0000: ldarg.0
    IL_0001: ldc.i4.0
    IL_0002: conv.i8
    IL_0003: call System.UInt64& Z0.Stacks::head<System.UInt64>(Z0.Stacked/MemStack128&,System.UInt64)
    IL_0008: ret
}

// Id := 100664382, Name := System.Byte& Z0.OpCodes.stacked::ss_value_128x8(Z0.Stacked/MemStack128&,System.Int32)
// ref byte ss_value_128x8(ref MemStack128 src, int index)
// IL
ref byte ss_value_128x8(ref MemStack128 src, int index)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.0
    IL_0003: call System.Byte& Z0.Stacks::cell<System.Byte>(Z0.Stacked/MemStack128&,System.Int32,System.Byte)
    IL_0008: ret
}

// Id := 100664383, Name := System.UInt16& Z0.OpCodes.stacked::ss_value_128x16(Z0.Stacked/MemStack128&,System.Int32)
// ref ushort ss_value_128x16(ref MemStack128 src, int index)
// IL
ref ushort ss_value_128x16(ref MemStack128 src, int index)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.0
    IL_0003: call System.UInt16& Z0.Stacks::cell<System.UInt16>(Z0.Stacked/MemStack128&,System.Int32,System.UInt16)
    IL_0008: ret
}

// Id := 100664384, Name := System.UInt32& Z0.OpCodes.stacked::ss_value_128x32(Z0.Stacked/MemStack128&,System.Int32)
// ref uint ss_value_128x32(ref MemStack128 src, int index)
// IL
ref uint ss_value_128x32(ref MemStack128 src, int index)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.0
    IL_0003: call System.UInt32& Z0.Stacks::cell<System.UInt32>(Z0.Stacked/MemStack128&,System.Int32,System.UInt32)
    IL_0008: ret
}

// Id := 100664385, Name := System.UInt64& Z0.OpCodes.stacked::ss_value_128x64(Z0.Stacked/MemStack128&,System.Int32)
// ref ulong ss_value_128x64(ref MemStack128 src, int index)
// IL
ref ulong ss_value_128x64(ref MemStack128 src, int index)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.0
    IL_0003: conv.i8
    IL_0004: call System.UInt64& Z0.Stacks::cell<System.UInt64>(Z0.Stacked/MemStack128&,System.Int32,System.UInt64)
    IL_0009: ret
}

// Id := 100664386, Name := System.Byte& Z0.OpCodes.stacked::ss_value_256x8(Z0.Stacked/MemStack256&,System.Int32)
// ref byte ss_value_256x8(ref MemStack256 src, int index)
// IL
ref byte ss_value_256x8(ref MemStack256 src, int index)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.0
    IL_0003: call System.Byte& Z0.Stacks::cell<System.Byte>(Z0.Stacked/MemStack256&,System.Int32,System.Byte)
    IL_0008: ret
}

// Id := 100664387, Name := System.UInt16& Z0.OpCodes.stacked::ss_value_256x16(Z0.Stacked/MemStack256&,System.Int32)
// ref ushort ss_value_256x16(ref MemStack256 src, int index)
// IL
ref ushort ss_value_256x16(ref MemStack256 src, int index)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.0
    IL_0003: call System.UInt16& Z0.Stacks::cell<System.UInt16>(Z0.Stacked/MemStack256&,System.Int32,System.UInt16)
    IL_0008: ret
}

// Id := 100664388, Name := System.UInt32& Z0.OpCodes.stacked::ss_value_256x32(Z0.Stacked/MemStack256&,System.Int32)
// ref uint ss_value_256x32(ref MemStack256 src, int index)
// IL
ref uint ss_value_256x32(ref MemStack256 src, int index)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.0
    IL_0003: call System.UInt32& Z0.Stacks::cell<System.UInt32>(Z0.Stacked/MemStack256&,System.Int32,System.UInt32)
    IL_0008: ret
}

// Id := 100664389, Name := System.UInt64& Z0.OpCodes.stacked::ss_value_256x64(Z0.Stacked/MemStack256&,System.Int32)
// ref ulong ss_value_256x64(ref MemStack256 src, int index)
// IL
ref ulong ss_value_256x64(ref MemStack256 src, int index)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldc.i4.0
    IL_0003: conv.i8
    IL_0004: call System.UInt64& Z0.Stacks::cell<System.UInt64>(Z0.Stacked/MemStack256&,System.Int32,System.UInt64)
    IL_0009: ret
}

// Id := 100664390, Name := Z0.Stacked/CharStack4 Z0.OpCodes.stacked::ss_alloc_c4()
// CharStack4 ss_alloc_c4()
// IL
CharStack4 ss_alloc_c4()
{
    IL_0000: call Z0.N4 zfunc::get_n4()
    IL_0005: call Z0.Stacked/CharStack4 Z0.Stacks::chars(Z0.N4)
    IL_000A: ret
}

// Id := 100664391, Name := Z0.Stacked/CharStack8 Z0.OpCodes.stacked::ss_alloc_c8()
// CharStack8 ss_alloc_c8()
// IL
CharStack8 ss_alloc_c8()
{
    IL_0000: call Z0.N8 zfunc::get_n8()
    IL_0005: call Z0.Stacked/CharStack8 Z0.Stacks::chars(Z0.N8)
    IL_000A: ret
}

// Id := 100664392, Name := Z0.Stacked/CharStack32 Z0.OpCodes.stacked::ss_alloc_c32()
// CharStack32 ss_alloc_c32()
// IL
CharStack32 ss_alloc_c32()
{
    IL_0000: call Z0.N32 zfunc::get_n32()
    IL_0005: call Z0.Stacked/CharStack32 Z0.Stacks::chars(Z0.N32)
    IL_000A: ret
}

// Id := 100664393, Name := Z0.Stacked/CharStack64 Z0.OpCodes.stacked::ss_alloc_c64()
// CharStack64 ss_alloc_c64()
// IL
CharStack64 ss_alloc_c64()
{
    IL_0000: call Z0.N64 zfunc::get_n64()
    IL_0005: call Z0.Stacked/CharStack64 Z0.Stacks::chars(Z0.N64)
    IL_000A: ret
}

// Id := 100664394, Name := Z0.Stacked/CharStack8 Z0.OpCodes.stacked::ss_concat_8x8(Z0.Stacked/CharStack4,Z0.Stacked/CharStack4)
// CharStack8 ss_concat_8x8(CharStack4 head, CharStack4 tail)
// IL
CharStack8 ss_concat_8x8(CharStack4 head, CharStack4 tail)
{
    IL_0000: ldarga.s head
    IL_0002: ldarga.s tail
    IL_0004: call Z0.Stacked/CharStack8 Z0.Stacks::concat(Z0.Stacked/CharStack4&,Z0.Stacked/CharStack4&)
    IL_0009: ret
}

// Id := 100664395, Name := Z0.Stacked/CharStack32& Z0.OpCodes.stacked::ss_concat_2x16_buffered(Z0.Stacked/CharStack16&,Z0.Stacked/CharStack16&,Z0.Stacked/CharStack32&)
// ref CharStack32 ss_concat_2x16_buffered(in CharStack16 head, in CharStack16 tail, ref CharStack32 dst)
// IL
ref CharStack32 ss_concat_2x16_buffered(in CharStack16 head, in CharStack16 tail, ref CharStack32 dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call Z0.Stacked/CharStack32& Z0.Stacks::concat(Z0.Stacked/CharStack16&,Z0.Stacked/CharStack16&,Z0.Stacked/CharStack32&)
    IL_0008: ret
}

// Id := 100664396, Name := Z0.Stacked/CharStack32& Z0.OpCodes.stacked::ss_concat_2x32_buffered(Z0.Stacked/CharStack16&,Z0.Stacked/CharStack16&,Z0.Stacked/CharStack32&)
// ref CharStack32 ss_concat_2x32_buffered(in CharStack16 head, in CharStack16 tail, ref CharStack32 dst)
// IL
ref CharStack32 ss_concat_2x32_buffered(in CharStack16 head, in CharStack16 tail, ref CharStack32 dst)
{
    IL_0000: ldarg.0
    IL_0001: ldarg.1
    IL_0002: ldarg.2
    IL_0003: call Z0.Stacked/CharStack32& Z0.Stacks::concat(Z0.Stacked/CharStack16&,Z0.Stacked/CharStack16&,Z0.Stacked/CharStack32&)
    IL_0008: ret
}

// Id := 100664397, Name := Z0.Stacked/MemStack64 Z0.OpCodes.stacked::init_64x8(System.Byte&)
// MemStack64 init_64x8(in byte src)
// IL
MemStack64 init_64x8(in byte src)
{
    IL_0000: call Z0.N64 zfunc::get_n64()
    IL_0005: ldarg.0
    IL_0006: call Z0.Stacked/MemStack64 Z0.Stacks::init<System.Byte>(Z0.N64,System.Byte&)
    IL_000B: ret
}

// Id := 100664398, Name := Z0.Stacked/MemStack64 Z0.OpCodes.stacked::init_64x16(System.UInt16&)
// MemStack64 init_64x16(in ushort src)
// IL
MemStack64 init_64x16(in ushort src)
{
    IL_0000: call Z0.N64 zfunc::get_n64()
    IL_0005: ldarg.0
    IL_0006: call Z0.Stacked/MemStack64 Z0.Stacks::init<System.UInt16>(Z0.N64,System.UInt16&)
    IL_000B: ret
}

// Id := 100664399, Name := Z0.Stacked/MemStack64 Z0.OpCodes.stacked::init_64x32(System.UInt32&)
// MemStack64 init_64x32(in uint src)
// IL
MemStack64 init_64x32(in uint src)
{
    IL_0000: call Z0.N64 zfunc::get_n64()
    IL_0005: ldarg.0
    IL_0006: call Z0.Stacked/MemStack64 Z0.Stacks::init<System.UInt32>(Z0.N64,System.UInt32&)
    IL_000B: ret
}

// Id := 100664400, Name := Z0.Stacked/MemStack64 Z0.OpCodes.stacked::init_64x64(System.UInt64&)
// MemStack64 init_64x64(in ulong src)
// IL
MemStack64 init_64x64(in ulong src)
{
    IL_0000: call Z0.N64 zfunc::get_n64()
    IL_0005: ldarg.0
    IL_0006: call Z0.Stacked/MemStack64 Z0.Stacks::init<System.UInt64>(Z0.N64,System.UInt64&)
    IL_000B: ret
}

// Id := 100664401, Name := Z0.Stacked/MemStack128 Z0.OpCodes.stacked::init_128x8(System.Byte&)
// MemStack128 init_128x8(in byte src)
// IL
MemStack128 init_128x8(in byte src)
{
    IL_0000: call Z0.N128 zfunc::get_n128()
    IL_0005: ldarg.0
    IL_0006: call Z0.Stacked/MemStack128 Z0.Stacks::init<System.Byte>(Z0.N128,System.Byte&)
    IL_000B: ret
}

// Id := 100664402, Name := Z0.Stacked/MemStack256 Z0.OpCodes.stacked::init_256x8(System.Byte&)
// MemStack256 init_256x8(in byte src)
// IL
MemStack256 init_256x8(in byte src)
{
    IL_0000: call Z0.N256 zfunc::get_n256()
    IL_0005: ldarg.0
    IL_0006: call Z0.Stacked/MemStack256 Z0.Stacks::init<System.Byte>(Z0.N256,System.Byte&)
    IL_000B: ret
}

// Id := 100664403, Name := Z0.Stacked/MemStack256 Z0.OpCodes.stacked::init_256x32(System.UInt32&)
// MemStack256 init_256x32(in uint src)
// IL
MemStack256 init_256x32(in uint src)
{
    IL_0000: call Z0.N256 zfunc::get_n256()
    IL_0005: ldarg.0
    IL_0006: call Z0.Stacked/MemStack256 Z0.Stacks::init<System.UInt32>(Z0.N256,System.UInt32&)
    IL_000B: ret
}

// Id := 100664404, Name := Z0.Stacked/MemStack512 Z0.OpCodes.stacked::init_512x8(System.Byte&)
// MemStack512 init_512x8(in byte src)
// IL
MemStack512 init_512x8(in byte src)
{
    IL_0000: call Z0.N512 zfunc::get_n512()
    IL_0005: ldarg.0
    IL_0006: call Z0.Stacked/MemStack512 Z0.Stacks::init<System.Byte>(Z0.N512,System.Byte&)
    IL_000B: ret
}

// Id := 100664405, Name := Z0.Stacked/MemStack1024 Z0.OpCodes.stacked::init_1024x8(System.Byte&)
// MemStack1024 init_1024x8(in byte src)
// IL
MemStack1024 init_1024x8(in byte src)
{
    IL_0000: call Z0.N1024 zfunc::get_n1024()
    IL_0005: ldarg.0
    IL_0006: call Z0.Stacked/MemStack1024 Z0.Stacks::init<System.Byte>(Z0.N1024,System.Byte&)
    IL_000B: ret
}

