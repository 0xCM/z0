//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct EnumLiteralSummary
    {
        public static ReadOnlySpan<byte> RenderWidths
            => new byte[6]{24, 24, 16, 12, 24, 16};

        /// <summary>
        /// The literal's surrogate identifier
        /// </summary>
        public ClrMemberIdentity Id;

        /// <summary>
        /// The name of the declaring type
        /// </summary>
        public string TypeName;

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
        public string LiteralName;

        /// <summary>
        /// The literal value
        /// </summary>
        public variant ScalarValue;
    }
}