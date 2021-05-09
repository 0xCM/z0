//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    using static CliTableKinds;

    partial struct CliRecords
    {
        [Record(CliTableKind.GenericParamConstraint), StructLayout(LayoutKind.Sequential)]
        public struct GenericParamConstraintRow : ICliRecord<GenericParamConstraintRow>
        {
            public CliRowKey<GenericParamConstraint> Key;

            /// <summary>
            /// An index into the GenericParam table, specifying to which generic parameter this row refers
            /// </summary>
            public CliRowKey Owner;

            /// <summary>
            /// An index into the TypeDef, TypeRef, or TypeSpec tables,
            /// specifying from which class this generic parameter is constrained to derive;
            /// or which interface this generic parameter is constrained to implement
            /// </summary>
            public CliRowKey Constraint;
        }
    }
}