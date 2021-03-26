//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    public readonly struct ClrEnum<E>
        where E : unmanaged, Enum
    {
        public Type Definition => TD;

        [MethodImpl(Inline)]
        public ClrEnumInfo<E> Describe()
            => new ClrEnumInfo<E>(address(_Details), address(_Literals), address(_Fields), FieldCount);

        public Count FieldCount
        {
            [MethodImpl(Inline)]
            get => _Fields.Count;
        }

        public ClrToken Token
        {
            [MethodImpl(Inline)]
            get => Definition.MetadataToken;
        }

        public ClrEnum Untyped
        {
            [MethodImpl(Inline)]
            get => new ClrEnum(Definition);
        }

        public ReadOnlySpan<E> Literals
        {
            [MethodImpl(Inline)]
            get => _Literals.View;
        }

        public ReadOnlySpan<ClrEnumField<E>> Fields
        {
            [MethodImpl(Inline)]
            get => _Fields.View;
        }

        public ReadOnlySpan<EnumLiteralDetail<E>> Details
        {
            [MethodImpl(Inline)]
            get => _Details.View;
        }

        public SymbolTable<E> SymbolTable
        {
            [MethodImpl(Inline)]
            get => _SymbolTable;
        }

        public Index<Sym<E>> SymbolIndex
        {
            [MethodImpl(Inline)]
            get => _SymIndex;
        }

        public EnumDetailProvider<E> DetailProvider
        {
            [MethodImpl(Inline)]
            get => Provider;
        }

        public ClrTypeName Name
        {
            [MethodImpl(Inline)]
            get => Definition;
        }

        [MethodImpl(Inline)]
        public static implicit operator ClrEnum(ClrEnum<E> src)
            => src.Untyped;

        [MethodImpl(Inline)]
        public static implicit operator Type(ClrEnum<E> src)
            => src.Definition;

        [MethodImpl(Inline)]
        public static implicit operator ClrType<E>(ClrEnum<E> src)
            => default;

        static readonly Type TD = typeof(E);

        static readonly EnumDetailProvider<E> Provider = EnumDetailProvider<E>.create();

        [FixedAddressValueType]
        static readonly Index<EnumLiteralDetail<E>> _Details = Provider.Details;

        [FixedAddressValueType]
        static Index<E> _Literals = Provider.LiteralValues;

        [FixedAddressValueType]
        static Index<ClrEnumField<E>> _Fields = Provider.EnumFields;

        [FixedAddressValueType]
        static Index<Sym<E>> _SymIndex = SymbolStores.symindex<E>();

        [FixedAddressValueType]
        static SymbolTable<E> _SymbolTable = SymbolStores.table<E>();
    }
}