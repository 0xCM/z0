// 2020-01-11 17:55:30:229
MemStack64 ss_alloc_64()
{
//  Id := 100664581, Name := Z0.Stacked/MemStack64 Z0.OpCodes.stacked::ss_alloc_64()
//  MemStack64 ss_alloc_64()
//  Managed
{
  IL_0000: call Z0.N64 zfunc::get_n64()
  IL_0005: call Z0.Stacked/MemStack64 Z0.Stacks::alloc(Z0.N64)
  IL_000A: ret
}

}
MemStack128 ss_alloc_128()
{
//  Id := 100664582, Name := Z0.Stacked/MemStack128 Z0.OpCodes.stacked::ss_alloc_128()
//  MemStack128 ss_alloc_128()
//  Managed
{
  IL_0000: call Z0.N128 zfunc::get_n128()
  IL_0005: call Z0.Stacked/MemStack128 Z0.Stacks::alloc(Z0.N128)
  IL_000A: ret
}

}
MemStack256 ss_alloc_256()
{
//  Id := 100664583, Name := Z0.Stacked/MemStack256 Z0.OpCodes.stacked::ss_alloc_256()
//  MemStack256 ss_alloc_256()
//  Managed
{
  IL_0000: call Z0.N256 zfunc::get_n256()
  IL_0005: call Z0.Stacked/MemStack256 Z0.Stacks::alloc(Z0.N256)
  IL_000A: ret
}

}
MemStack512 ss_alloc_512()
{
//  Id := 100664584, Name := Z0.Stacked/MemStack512 Z0.OpCodes.stacked::ss_alloc_512()
//  MemStack512 ss_alloc_512()
//  Managed
{
  IL_0000: call Z0.N512 zfunc::get_n512()
  IL_0005: call Z0.Stacked/MemStack512 Z0.Stacks::alloc(Z0.N512)
  IL_000A: ret
}

}
MemStack1024 ss_alloc_1024()
{
//  Id := 100664585, Name := Z0.Stacked/MemStack1024 Z0.OpCodes.stacked::ss_alloc_1024()
//  MemStack1024 ss_alloc_1024()
//  Managed
{
  IL_0000: call Z0.N1024 zfunc::get_n1024()
  IL_0005: call Z0.Stacked/MemStack1024 Z0.Stacks::alloc(Z0.N1024)
  IL_000A: ret
}

}
void ss_store_128(in byte src, uint count, ref MemStack128 dst)
{
//  Id := 100664586, Name := System.Void Z0.OpCodes.stacked::ss_store_128(System.Byte&,System.UInt32,Z0.Stacked/MemStack128&)
//  void ss_store_128(in byte src, uint count, ref MemStack128 dst)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: ldarg.2
  IL_0003: call System.Void Z0.Stacks::store(System.Byte&,System.UInt32,Z0.Stacked/MemStack128&)
  IL_0008: ret
}

}
Span<byte> ss_span_128x8(ref MemStack128 src)
{
//  Id := 100664587, Name := System.Span`1<System.Byte> Z0.OpCodes.stacked::ss_span_128x8(Z0.Stacked/MemStack128&)
//  Span<byte> ss_span_128x8(ref MemStack128 src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldc.i4.0
  IL_0002: call System.Span`1<System.Byte> Z0.Stacks::span<System.Byte>(Z0.Stacked/MemStack128&,System.Byte)
  IL_0007: ret
}

}
Span<byte> ss_span_256x8(ref MemStack256 src)
{
//  Id := 100664588, Name := System.Span`1<System.Byte> Z0.OpCodes.stacked::ss_span_256x8(Z0.Stacked/MemStack256&)
//  Span<byte> ss_span_256x8(ref MemStack256 src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldc.i4.0
  IL_0002: call System.Span`1<System.Byte> Z0.Stacks::span<System.Byte>(Z0.Stacked/MemStack256&,System.Byte)
  IL_0007: ret
}

}
ref byte ss_head_128x8(ref MemStack128 src)
{
//  Id := 100664589, Name := System.Byte& Z0.OpCodes.stacked::ss_head_128x8(Z0.Stacked/MemStack128&)
//  ref byte ss_head_128x8(ref MemStack128 src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldc.i4.0
  IL_0002: call System.Byte& Z0.Stacks::head<System.Byte>(Z0.Stacked/MemStack128&,System.Byte)
  IL_0007: ret
}

}
ref ushort ss_head_128x16(ref MemStack128 src)
{
//  Id := 100664590, Name := System.UInt16& Z0.OpCodes.stacked::ss_head_128x16(Z0.Stacked/MemStack128&)
//  ref ushort ss_head_128x16(ref MemStack128 src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldc.i4.0
  IL_0002: call System.UInt16& Z0.Stacks::head<System.UInt16>(Z0.Stacked/MemStack128&,System.UInt16)
  IL_0007: ret
}

}
ref uint ss_head_128x32(ref MemStack128 src)
{
//  Id := 100664591, Name := System.UInt32& Z0.OpCodes.stacked::ss_head_128x32(Z0.Stacked/MemStack128&)
//  ref uint ss_head_128x32(ref MemStack128 src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldc.i4.0
  IL_0002: call System.UInt32& Z0.Stacks::head<System.UInt32>(Z0.Stacked/MemStack128&,System.UInt32)
  IL_0007: ret
}

}
ref ulong ss_head_128x64(ref MemStack128 src)
{
//  Id := 100664592, Name := System.UInt64& Z0.OpCodes.stacked::ss_head_128x64(Z0.Stacked/MemStack128&)
//  ref ulong ss_head_128x64(ref MemStack128 src)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldc.i4.0
  IL_0002: conv.i8
  IL_0003: call System.UInt64& Z0.Stacks::head<System.UInt64>(Z0.Stacked/MemStack128&,System.UInt64)
  IL_0008: ret
}

}
ref byte ss_value_128x8(ref MemStack128 src, int index)
{
//  Id := 100664593, Name := System.Byte& Z0.OpCodes.stacked::ss_value_128x8(Z0.Stacked/MemStack128&,System.Int32)
//  ref byte ss_value_128x8(ref MemStack128 src, int index)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: ldc.i4.0
  IL_0003: call System.Byte& Z0.Stacks::cell<System.Byte>(Z0.Stacked/MemStack128&,System.Int32,System.Byte)
  IL_0008: ret
}

}
ref ushort ss_value_128x16(ref MemStack128 src, int index)
{
//  Id := 100664594, Name := System.UInt16& Z0.OpCodes.stacked::ss_value_128x16(Z0.Stacked/MemStack128&,System.Int32)
//  ref ushort ss_value_128x16(ref MemStack128 src, int index)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: ldc.i4.0
  IL_0003: call System.UInt16& Z0.Stacks::cell<System.UInt16>(Z0.Stacked/MemStack128&,System.Int32,System.UInt16)
  IL_0008: ret
}

}
ref uint ss_value_128x32(ref MemStack128 src, int index)
{
//  Id := 100664595, Name := System.UInt32& Z0.OpCodes.stacked::ss_value_128x32(Z0.Stacked/MemStack128&,System.Int32)
//  ref uint ss_value_128x32(ref MemStack128 src, int index)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: ldc.i4.0
  IL_0003: call System.UInt32& Z0.Stacks::cell<System.UInt32>(Z0.Stacked/MemStack128&,System.Int32,System.UInt32)
  IL_0008: ret
}

}
ref ulong ss_value_128x64(ref MemStack128 src, int index)
{
//  Id := 100664596, Name := System.UInt64& Z0.OpCodes.stacked::ss_value_128x64(Z0.Stacked/MemStack128&,System.Int32)
//  ref ulong ss_value_128x64(ref MemStack128 src, int index)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: ldc.i4.0
  IL_0003: conv.i8
  IL_0004: call System.UInt64& Z0.Stacks::cell<System.UInt64>(Z0.Stacked/MemStack128&,System.Int32,System.UInt64)
  IL_0009: ret
}

}
ref byte ss_value_256x8(ref MemStack256 src, int index)
{
//  Id := 100664597, Name := System.Byte& Z0.OpCodes.stacked::ss_value_256x8(Z0.Stacked/MemStack256&,System.Int32)
//  ref byte ss_value_256x8(ref MemStack256 src, int index)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: ldc.i4.0
  IL_0003: call System.Byte& Z0.Stacks::cell<System.Byte>(Z0.Stacked/MemStack256&,System.Int32,System.Byte)
  IL_0008: ret
}

}
ref ushort ss_value_256x16(ref MemStack256 src, int index)
{
//  Id := 100664598, Name := System.UInt16& Z0.OpCodes.stacked::ss_value_256x16(Z0.Stacked/MemStack256&,System.Int32)
//  ref ushort ss_value_256x16(ref MemStack256 src, int index)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: ldc.i4.0
  IL_0003: call System.UInt16& Z0.Stacks::cell<System.UInt16>(Z0.Stacked/MemStack256&,System.Int32,System.UInt16)
  IL_0008: ret
}

}
ref uint ss_value_256x32(ref MemStack256 src, int index)
{
//  Id := 100664599, Name := System.UInt32& Z0.OpCodes.stacked::ss_value_256x32(Z0.Stacked/MemStack256&,System.Int32)
//  ref uint ss_value_256x32(ref MemStack256 src, int index)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: ldc.i4.0
  IL_0003: call System.UInt32& Z0.Stacks::cell<System.UInt32>(Z0.Stacked/MemStack256&,System.Int32,System.UInt32)
  IL_0008: ret
}

}
ref ulong ss_value_256x64(ref MemStack256 src, int index)
{
//  Id := 100664600, Name := System.UInt64& Z0.OpCodes.stacked::ss_value_256x64(Z0.Stacked/MemStack256&,System.Int32)
//  ref ulong ss_value_256x64(ref MemStack256 src, int index)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: ldc.i4.0
  IL_0003: conv.i8
  IL_0004: call System.UInt64& Z0.Stacks::cell<System.UInt64>(Z0.Stacked/MemStack256&,System.Int32,System.UInt64)
  IL_0009: ret
}

}
CharStack4 ss_alloc_c4()
{
//  Id := 100664601, Name := Z0.Stacked/CharStack4 Z0.OpCodes.stacked::ss_alloc_c4()
//  CharStack4 ss_alloc_c4()
//  Managed
{
  IL_0000: call Z0.N4 zfunc::get_n4()
  IL_0005: call Z0.Stacked/CharStack4 Z0.Stacks::chars(Z0.N4)
  IL_000A: ret
}

}
CharStack8 ss_alloc_c8()
{
//  Id := 100664602, Name := Z0.Stacked/CharStack8 Z0.OpCodes.stacked::ss_alloc_c8()
//  CharStack8 ss_alloc_c8()
//  Managed
{
  IL_0000: call Z0.N8 zfunc::get_n8()
  IL_0005: call Z0.Stacked/CharStack8 Z0.Stacks::chars(Z0.N8)
  IL_000A: ret
}

}
CharStack32 ss_alloc_c32()
{
//  Id := 100664603, Name := Z0.Stacked/CharStack32 Z0.OpCodes.stacked::ss_alloc_c32()
//  CharStack32 ss_alloc_c32()
//  Managed
{
  IL_0000: call Z0.N32 zfunc::get_n32()
  IL_0005: call Z0.Stacked/CharStack32 Z0.Stacks::chars(Z0.N32)
  IL_000A: ret
}

}
CharStack64 ss_alloc_c64()
{
//  Id := 100664604, Name := Z0.Stacked/CharStack64 Z0.OpCodes.stacked::ss_alloc_c64()
//  CharStack64 ss_alloc_c64()
//  Managed
{
  IL_0000: call Z0.N64 zfunc::get_n64()
  IL_0005: call Z0.Stacked/CharStack64 Z0.Stacks::chars(Z0.N64)
  IL_000A: ret
}

}
CharStack8 ss_concat_8x8(CharStack4 head, CharStack4 tail)
{
//  Id := 100664605, Name := Z0.Stacked/CharStack8 Z0.OpCodes.stacked::ss_concat_8x8(Z0.Stacked/CharStack4,Z0.Stacked/CharStack4)
//  CharStack8 ss_concat_8x8(CharStack4 head, CharStack4 tail)
//  Managed
{
  IL_0000: ldarga.s head
  IL_0002: ldarga.s tail
  IL_0004: call Z0.Stacked/CharStack8 Z0.Stacks::concat(Z0.Stacked/CharStack4&,Z0.Stacked/CharStack4&)
  IL_0009: ret
}

}
ref CharStack32 ss_concat_2x16_buffered(in CharStack16 head, in CharStack16 tail, ref CharStack32 dst)
{
//  Id := 100664606, Name := Z0.Stacked/CharStack32& Z0.OpCodes.stacked::ss_concat_2x16_buffered(Z0.Stacked/CharStack16&,Z0.Stacked/CharStack16&,Z0.Stacked/CharStack32&)
//  ref CharStack32 ss_concat_2x16_buffered(in CharStack16 head, in CharStack16 tail, ref CharStack32 dst)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: ldarg.2
  IL_0003: call Z0.Stacked/CharStack32& Z0.Stacks::concat(Z0.Stacked/CharStack16&,Z0.Stacked/CharStack16&,Z0.Stacked/CharStack32&)
  IL_0008: ret
}

}
ref CharStack32 ss_concat_2x32_buffered(in CharStack16 head, in CharStack16 tail, ref CharStack32 dst)
{
//  Id := 100664607, Name := Z0.Stacked/CharStack32& Z0.OpCodes.stacked::ss_concat_2x32_buffered(Z0.Stacked/CharStack16&,Z0.Stacked/CharStack16&,Z0.Stacked/CharStack32&)
//  ref CharStack32 ss_concat_2x32_buffered(in CharStack16 head, in CharStack16 tail, ref CharStack32 dst)
//  Managed
{
  IL_0000: ldarg.0
  IL_0001: ldarg.1
  IL_0002: ldarg.2
  IL_0003: call Z0.Stacked/CharStack32& Z0.Stacks::concat(Z0.Stacked/CharStack16&,Z0.Stacked/CharStack16&,Z0.Stacked/CharStack32&)
  IL_0008: ret
}

}
MemStack64 init_64x8(in byte src)
{
//  Id := 100664608, Name := Z0.Stacked/MemStack64 Z0.OpCodes.stacked::init_64x8(System.Byte&)
//  MemStack64 init_64x8(in byte src)
//  Managed
{
  IL_0000: call Z0.N64 zfunc::get_n64()
  IL_0005: ldarg.0
  IL_0006: call Z0.Stacked/MemStack64 Z0.Stacks::init<System.Byte>(Z0.N64,System.Byte&)
  IL_000B: ret
}

}
MemStack64 init_64x16(in ushort src)
{
//  Id := 100664609, Name := Z0.Stacked/MemStack64 Z0.OpCodes.stacked::init_64x16(System.UInt16&)
//  MemStack64 init_64x16(in ushort src)
//  Managed
{
  IL_0000: call Z0.N64 zfunc::get_n64()
  IL_0005: ldarg.0
  IL_0006: call Z0.Stacked/MemStack64 Z0.Stacks::init<System.UInt16>(Z0.N64,System.UInt16&)
  IL_000B: ret
}

}
MemStack64 init_64x32(in uint src)
{
//  Id := 100664610, Name := Z0.Stacked/MemStack64 Z0.OpCodes.stacked::init_64x32(System.UInt32&)
//  MemStack64 init_64x32(in uint src)
//  Managed
{
  IL_0000: call Z0.N64 zfunc::get_n64()
  IL_0005: ldarg.0
  IL_0006: call Z0.Stacked/MemStack64 Z0.Stacks::init<System.UInt32>(Z0.N64,System.UInt32&)
  IL_000B: ret
}

}
MemStack64 init_64x64(in ulong src)
{
//  Id := 100664611, Name := Z0.Stacked/MemStack64 Z0.OpCodes.stacked::init_64x64(System.UInt64&)
//  MemStack64 init_64x64(in ulong src)
//  Managed
{
  IL_0000: call Z0.N64 zfunc::get_n64()
  IL_0005: ldarg.0
  IL_0006: call Z0.Stacked/MemStack64 Z0.Stacks::init<System.UInt64>(Z0.N64,System.UInt64&)
  IL_000B: ret
}

}
MemStack128 init_128x8(in byte src)
{
//  Id := 100664612, Name := Z0.Stacked/MemStack128 Z0.OpCodes.stacked::init_128x8(System.Byte&)
//  MemStack128 init_128x8(in byte src)
//  Managed
{
  IL_0000: call Z0.N128 zfunc::get_n128()
  IL_0005: ldarg.0
  IL_0006: call Z0.Stacked/MemStack128 Z0.Stacks::init<System.Byte>(Z0.N128,System.Byte&)
  IL_000B: ret
}

}
MemStack256 init_256x8(in byte src)
{
//  Id := 100664613, Name := Z0.Stacked/MemStack256 Z0.OpCodes.stacked::init_256x8(System.Byte&)
//  MemStack256 init_256x8(in byte src)
//  Managed
{
  IL_0000: call Z0.N256 zfunc::get_n256()
  IL_0005: ldarg.0
  IL_0006: call Z0.Stacked/MemStack256 Z0.Stacks::init<System.Byte>(Z0.N256,System.Byte&)
  IL_000B: ret
}

}
MemStack256 init_256x32(in uint src)
{
//  Id := 100664614, Name := Z0.Stacked/MemStack256 Z0.OpCodes.stacked::init_256x32(System.UInt32&)
//  MemStack256 init_256x32(in uint src)
//  Managed
{
  IL_0000: call Z0.N256 zfunc::get_n256()
  IL_0005: ldarg.0
  IL_0006: call Z0.Stacked/MemStack256 Z0.Stacks::init<System.UInt32>(Z0.N256,System.UInt32&)
  IL_000B: ret
}

}
MemStack512 init_512x8(in byte src)
{
//  Id := 100664615, Name := Z0.Stacked/MemStack512 Z0.OpCodes.stacked::init_512x8(System.Byte&)
//  MemStack512 init_512x8(in byte src)
//  Managed
{
  IL_0000: call Z0.N512 zfunc::get_n512()
  IL_0005: ldarg.0
  IL_0006: call Z0.Stacked/MemStack512 Z0.Stacks::init<System.Byte>(Z0.N512,System.Byte&)
  IL_000B: ret
}

}
MemStack1024 init_1024x8(in byte src)
{
//  Id := 100664616, Name := Z0.Stacked/MemStack1024 Z0.OpCodes.stacked::init_1024x8(System.Byte&)
//  MemStack1024 init_1024x8(in byte src)
//  Managed
{
  IL_0000: call Z0.N1024 zfunc::get_n1024()
  IL_0005: ldarg.0
  IL_0006: call Z0.Stacked/MemStack1024 Z0.Stacks::init<System.Byte>(Z0.N1024,System.Byte&)
  IL_000B: ret
}

}
