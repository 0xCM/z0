//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using Microsoft.DiaSymReader;

    using static Part;
    using static memory;

    partial struct PdbServices
    {
        [Op]
        internal static Index<ISymUnmanagedDocument> documents(ISymUnmanagedMethod src)
            => src.GetDocumentsForMethod();
    }
}