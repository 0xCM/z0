//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Defines a boxed enumeration literal as the triple (index,identifier,value)
    /// </summary>
    [ApiClass(DataSummary)]
    public struct EnumLiteralDetail : ITable<EnumLiteralDetail>
    {
        public static ReadOnlySpan<byte> RenderWidths
            => new byte[6]{24, 24, 16, 12, 24, 16};

        /// <summary>
        /// The literal's surrogate identifier
        /// </summary>
        public MemberIdentity Id;

        /// <summary>
        /// The name of the declaring type
        /// </summary>
        public StringRef TypeName;

        /// <summary>
        /// The primal kind specialized by the enum
        /// </summary>
        public EnumScalarKind PrimalKind;

        /// <summary>
        /// The literal declaration order, unique within the declaring enum
        /// </summary>
        public uint Position;

        /// <summary>
        /// The literal identifier, unique within the declaring enum
        /// </summary>
        public StringRef LiteralName;

        /// <summary>
        /// The literal value
        /// </summary>
        public variant ScalarValue;
    }
}