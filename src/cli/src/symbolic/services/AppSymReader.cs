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

    using static AppSymbolics;
    using static Part;

    public class AppSymReader
    {
        public SymbolSource Source {get;}

        internal ISymUnmanagedReader5 Provider {get;}

        [MethodImpl(Inline)]
        public AppSymReader(SymbolSource src, ISymUnmanagedReader5 provider)
        {
            Source = src;
            Provider = provider;
        }

        public HResult<Method> Method(CliToken token)
            => method(this,token);
    }
}