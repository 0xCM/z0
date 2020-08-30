//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;

    /// <summary>
    /// Defines an E-V parametric enum value
    /// </summary>
    [ApiClass(DataSummary)]
    public readonly struct EnumLiteralDetail<E,P> : IEnumLiteral<EnumLiteralDetail<E,P>,E,P>
        where E : unmanaged, Enum
        where P : unmanaged
    {
        public readonly EnumLiteralDetail<E> Spec;

        /// <summary>
        /// The literal V-value
        /// </summary>
        public readonly P PrimalValue;

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
        public EnumScalarKind PrimalKind
        {
            [MethodImpl(Inline)]
            get => Enums.@base<E>();
        }

        public ArtifactIdentifier Token
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

        public UserMetadata UserData
        {
            [MethodImpl(Inline)]
            get => Spec.UserData;
        }

        P IEnumLiteral<EnumLiteralDetail<E,P>,E,P>.PrimalValue
            => PrimalValue;

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