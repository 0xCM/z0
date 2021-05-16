//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;
    using System.Runtime.CompilerServices;
    using Microsoft.DiaSymReader;

    using static PdbServices;
    using static Part;

    public class PdbReader
    {
        Index<ISymUnmanagedDocument> _Documents;

        DocumentMethods _DocumentMethods;

        public SymbolSource Source {get;}

        internal ISymUnmanagedReader5 Provider {get;}

        [MethodImpl(Inline)]
        internal PdbReader(IWfRuntime wf, SymbolSource src, ISymUnmanagedReader5 provider)
        {
            Source = src;
            Provider = provider;
            _DocumentMethods = methods(provider);
            _Documents = _DocumentMethods.Keys.Array();
        }

        public HResult<Method> Method(CliToken token)
            => method(this, token);
    }
}