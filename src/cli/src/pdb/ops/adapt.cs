//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using Microsoft.DiaSymReader;

    using static Part;
    using static memory;

    partial struct PdbServices
    {
        [MethodImpl(Inline), Op]
        internal static Method adapt(ISymUnmanagedMethod src)
            => new Method(src);

        [Op]
        internal static SequencePoint adapt(SymUnmanagedSequencePoint src)
        {
            return new SequencePoint((uint)src.Offset,
                ((uint)src.StartLine, (uint)src.StartColumn),
                ((uint)src.EndLine, (uint)src.EndColumn));
        }

        [Op]
        internal static Document adapt(ISymUnmanagedDocument src)
        {
            var name = src.GetName();
            var type = src.GetDocumentType();
            return new Document(name,type);
        }
    }
}