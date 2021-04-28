//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;
    using Microsoft.DiaSymReader;

    using static AppSymbolics;

    public class AppSymReader
    {
        public SymbolSource Source {get;}

        ISymUnmanagedReader5 Reader {get;}

        public AppSymReader(SymbolSource src, ISymUnmanagedReader5 reader)
        {
            Source = src;
            Reader = reader;
        }

        public HResult<Method> Method(CliToken token)
        {
            HResult result = Reader.GetMethod((int)token, out var accessor);
            if(result)
                return method(accessor);
            else
                return result;
        }
    }
}