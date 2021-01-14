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

    public readonly struct ClrEnum<T>
        where T : unmanaged, Enum
    {
        public Type Definition => TD;

        [MethodImpl(Inline)]
        public ClrEnumDetailInfo<T> Summary()
            => new ClrEnumDetailInfo<T>(address(_Details), address(_Literals), address(_Fields), FieldCount);

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

        public ReadOnlySpan<T> Literals
        {
            [MethodImpl(Inline)]
            get => _Literals.View;
        }

        public ReadOnlySpan<ClrEnumField<T>> Fields
        {
            [MethodImpl(Inline)]
            get => _Fields.View;
        }

        public ReadOnlySpan<EnumLiteralDetail<T>> Details
        {
            [MethodImpl(Inline)]
            get => _Details.View;
        }

        public EnumDetailProvider<T> DetailProvider
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
        public static implicit operator ClrEnum(ClrEnum<T> src)
            => src.Untyped;

        [MethodImpl(Inline)]
        public static implicit operator Type(ClrEnum<T> src)
            => src.Definition;

        [MethodImpl(Inline)]
        public static implicit operator ClrType<T>(ClrEnum<T> src)
            => default;

        static readonly Type TD = typeof(T);

        static readonly EnumDetailProvider<T> Provider = EnumDetailProvider<T>.create();

        [FixedAddressValueType]
        static readonly Index<EnumLiteralDetail<T>> _Details = Provider.Details;

        [FixedAddressValueType]
        static Index<T> _Literals = Provider.LiteralValues;

        [FixedAddressValueType]
        static Index<ClrEnumField<T>> _Fields = Provider.EnumFields;
    }


}