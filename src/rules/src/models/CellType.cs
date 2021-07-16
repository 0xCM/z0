//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Rules
    {
        /// <summary>
        /// Defines a primitive cell type
        /// </summary>
        public readonly struct CellType : IRuleDataType<CellType>
        {
            public BasicTypeKind Kind {get;}

            public BitWidth Width {get;}

            [MethodImpl(Inline)]
            public CellType(BasicTypeKind kind, BitWidth width)
            {
                Kind = kind;
                Width = width;
            }
        }
    }
}