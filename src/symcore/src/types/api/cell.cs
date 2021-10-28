//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Types
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct types
    {
        [MethodImpl(Inline), Op]
        public static CellType cell(uint content, uint storage, PrimalKind @class)
            => new CellType(content, storage, @class);

        [MethodImpl(Inline), Op]
        public static CellType icell(uint content, uint storage)
            => new CellType(content, storage, PrimalKind.SignedInt);

        [MethodImpl(Inline), Op]
        public static CellType icell(uint content)
            => new CellType(content, content, PrimalKind.SignedInt);

        [MethodImpl(Inline), Op]
        public static CellType ucell(uint content, uint storage)
            => new CellType(content, storage, PrimalKind.UnsignedInt);

        [MethodImpl(Inline), Op]
        public static CellType ucell(uint content)
            => new CellType(content, content, PrimalKind.UnsignedInt);

        [MethodImpl(Inline), Op]
        public static CellType fcell(uint content, uint storage)
            => new CellType(content, storage, PrimalKind.Float);

        [MethodImpl(Inline), Op]
        public static CellType fcell(uint content)
            => new CellType(content, content, PrimalKind.Float);
    }
}