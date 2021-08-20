//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;
    using static Blit;

    partial struct RegMachines
    {
        public struct Grid8x64
        {
            ByteBlock64 Names;

            Store8x64 Values;

            [MethodImpl(Inline)]
            public ref name64 RegName(byte index)
                => ref seek(recover<name64>(Names.Bytes), index);

            [MethodImpl(Inline)]
            public ref ulong RegVal(byte index)
                => ref Values[index];

            public NamedRegValue<ulong> this[byte index]
            {
                [MethodImpl(Inline)]
                get => paired(RegName(index), RegVal(index));

                [MethodImpl(Inline)]
                set => Define(index, value.Name, value.Value);
            }

            [MethodImpl(Inline)]
            void Define(byte index, name64 name, ulong value)
            {
                RegName(index) = name;
                RegVal(index) = value;
            }
        }
    }
}