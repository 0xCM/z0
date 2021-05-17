//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Root;
    using static core;

    public class EnumDetailProvider<E>
        where E : unmanaged, Enum
    {
        readonly Index<FieldInfo> _FieldDefs;

        readonly uint _FieldCount;

        readonly ClrEnumKind _EnumKind;

        readonly Index<E> _Values;

        readonly Index<ClrEnumField<E>> _EnumFields;

        readonly Index<EnumLiteralDetail<E>> _Details;

        readonly Type _EnumType;

        public static EnumDetailProvider<E> create()
            => new EnumDetailProvider<E>();

        public Index<EnumLiteralDetail<E>> Details
        {
            [MethodImpl(Inline)]
            get => _Details.Storage;
        }

        public Index<ClrEnumField<E>> EnumFields
        {
            [MethodImpl(Inline)]
            get => _EnumFields;
        }

        public Index<E> LiteralValues
        {
            [MethodImpl(Inline)]
            get => _Values;
        }

        public uint FieldCount
        {
            [MethodImpl(Inline)]
            get => _FieldCount;
        }

        public ClrType EnumType
        {
            [MethodImpl(Inline)]
            get => _EnumType;
        }

        EnumDetailProvider()
        {
            _EnumType = typeof(E);
            _FieldDefs = _EnumType.LiteralFields();
            _FieldCount = _FieldDefs.Count;
            _EnumKind = ClrEnums.@base<E>();
            _Values = values();
            _EnumFields = fields();
            _Details = details();
        }

        /// <summary>
        /// Gets the literals defined by an enumeration
        /// </summary>
        /// <typeparam name="E">The enum type</typeparam>
        Index<E> values()
        {
            var fields = _FieldDefs.View;
            var buffer = alloc<E>(_FieldCount);
            ref var target = ref first(buffer);
            for(var i=0u; i<_FieldCount; i++)
                seek(target,i) = (E)skip(fields,i).GetRawConstantValue();
            return buffer;
        }

        Index<ClrEnumField<E>> fields()
        {
            var values = _Values.View;
            var defs = _FieldDefs.View;
            var buffer = alloc<ClrEnumField<E>>(_FieldCount);
            ref var dst = ref first(buffer);
            for(var i=0u; i<_FieldCount; i++)
                seek(dst,i) = ClrEnums.field(i, skip(defs,i),  skip(values,i));
            return buffer;
        }

        Index<EnumLiteralDetail<E>> details()
        {
            var type = ClrEnums.@base<E>();
            var fields = _FieldDefs.View;
            var values = _Values.View;

            var buffer = alloc<EnumLiteralDetail<E>>(_FieldCount);
            ref var dst = ref first(buffer);
            for(var i=0u; i<_FieldCount; i++)
            {
                ref readonly var field = ref skip(fields,i);
                seek(dst,i) = new EnumLiteralDetail<E>(field, type, i, field.Name, skip(values,i));
            }
            return buffer;
        }
    }
}