//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial struct RegMachines
    {
        public struct Grid8x64
        {
            ByteBlock64 Names;

            Store8x64 Values;

            [MethodImpl(Inline)]
            public ref AsmRegName RegName(byte index)
                => ref seek(recover<AsmRegName>(Names.Bytes), index);

            [MethodImpl(Inline)]
            public ref ulong RegVal(byte index)
                => ref Values[index];

            public AsmRegValue<ulong> this[byte index]
            {
                [MethodImpl(Inline)]
                get => paired(RegName(index), RegVal(index));

                [MethodImpl(Inline)]
                set => Define(index, value.Name, value.Value);
            }

            [MethodImpl(Inline)]
            void Define(byte index, AsmRegName name, ulong value)
            {
                RegName(index) = name;
                RegVal(index) = value;
            }
        }
    }
}