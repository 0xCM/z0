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
        internal static DocumentMethods methods(ISymUnmanagedReader5 src)
        {
            var documents = @readonly(src.GetDocuments());
            var count = documents.Length;
            var dst = new DocumentMethods();
            for(var i=0; i<count; i++)
            {
                ref readonly var doc = ref skip(documents,i);
                var methods = src.GetMethodsInDocument(doc);
                dst[doc] = methods;
            }
            return dst;
        }
    }
}