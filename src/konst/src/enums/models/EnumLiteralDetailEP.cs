//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Part;

    /// <summary>
    /// Defines an E-V parametric enum value
    /// </summary>
    public readonly struct EnumLiteralDetail<E,P> : IEnumLiteral<EnumLiteralDetail<E,P>,E,P>
        where E : unmanaged, Enum
        where P : unmanaged
    {
        public EnumLiteralDetail<E> Spec {get;}

        /// <summary>
        /// The literal V-value
        /// </summary>
        public P PrimalValue {get;}

        [MethodImpl(Inline)]
        public EnumLiteralDetail(EnumLiteralDetail<E> spec, P v)
        {
            Spec = spec;
            PrimalValue = v;
        }

        /// <summary>
        /// The literal declaration order, unique within the declaring enum
        /// </summary>
        public uint Position
        {
            [MethodImpl(Inline)]
            get => Spec.Position;
        }

        /// <summary>
        /// The literal identifier, unique within the declaring enum
        /// </summary>
        public string Name
        {
            [MethodImpl(Inline)]
            get => Spec.Name;
        }

        /// <summary>
        /// The literal E-value
        /// </summary>
        public E LiteralValue
        {
            [MethodImpl(Inline)]
            get => Spec.LiteralValue;
        }

        variant IEnumLiteral.ScalarValue
        {
            [MethodImpl(Inline)]
            get => Variant.from(Spec.LiteralValue);
        }

        /// <summary>
        /// The numeric kind refined by the enum
        /// </summary>
        public EnumLiteralKind PrimalKind
        {
            [MethodImpl(Inline)]
            get => ClrEnums.@base<E>();
        }

        public ClrToken Token
        {
            [MethodImpl(Inline)]
            get => Spec.Id;
        }

        public FieldInfo Field
        {
            [MethodImpl(Inline)]
            get => Spec.BackingField;
        }

        public Type DataType
        {
            [MethodImpl(Inline)]
            get => typeof(P);
        }

        public string Description
        {
            [MethodImpl(Inline)]
            get => Spec.Description;
        }


        [MethodImpl(Inline)]
        public bool Equals(EnumLiteralDetail<E,P> src)
            => Spec.Equals(src.Spec) && PrimalValue.Equals(src.PrimalValue);


        public override bool Equals(object src)
            => src is EnumLiteralDetail<E,P> x && Equals(x);

        public override int GetHashCode()
            => (int)Position;

        public override string ToString()
            => (this as IEnumLiteral).Format();
    }
}