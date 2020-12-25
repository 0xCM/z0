//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial struct GenSpecs
    {
        public struct EnumSpec
        {
            /// <summary>
            /// The primal type under refinement by the enum
            /// </summary>
            public EnumLiteralKind BaseType;
        }

        public struct NamedLiteral
        {
            Name Name;

        }
    }
}