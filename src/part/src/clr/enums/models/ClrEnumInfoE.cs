//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public readonly struct ClrEnumInfo<E>
        where E : unmanaged, Enum
    {
        readonly MemoryAddress DetailAddress;

        readonly MemoryAddress LiteralAddress;

        readonly MemoryAddress FieldAddress;

        public uint FieldCount {get;}

        readonly uint Filler;

        [MethodImpl(Inline)]
        internal ClrEnumInfo(MemoryAddress details, MemoryAddress literals, MemoryAddress fields, uint count)
        {
            DetailAddress = details;
            LiteralAddress = literals;
            FieldAddress = fields;
            FieldCount = count;
            Filler = 0;
        }

        ref EnumLiteralDetail<E> FirstDetailCell
        {
            [MethodImpl(Inline)]
            get => ref memory.@ref<Index<EnumLiteralDetail<E>>>(DetailAddress).First;
        }

        ref ClrEnumField<E> FirstFieldCell
        {
            [MethodImpl(Inline)]
            get => ref memory.@ref<Index<ClrEnumField<E>>>(DetailAddress).First;
        }

        ref E FirstLiteralCell
        {
            [MethodImpl(Inline)]
            get => ref memory.@ref<Index<E>>(DetailAddress).First;
        }

        public ReadOnlySpan<EnumLiteralDetail<E>> LiteralDetails
        {
            [MethodImpl(Inline)]
            get => memory.cover<EnumLiteralDetail<E>>(address(FirstDetailCell), FieldCount);
        }

        public ReadOnlySpan<ClrEnumField<E>> EnumFields
        {
            [MethodImpl(Inline)]
            get => memory.cover<ClrEnumField<E>>(address(FirstFieldCell), FieldCount);
        }

        public ReadOnlySpan<E> LiteralValues
        {
            [MethodImpl(Inline)]
            get => memory.cover<E>(address(FirstLiteralCell), FieldCount);
        }
    }
}