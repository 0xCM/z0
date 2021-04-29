//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;
    using Microsoft.DiaSymReader;
    using Microsoft.DiaSymReader.PortablePdb;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct AppSymbolics
    {
        [MethodImpl(Inline), Op]
        internal static Method method(ISymUnmanagedMethod src)
            => new Method(src);

        public static HResult<Method> method(AppSymReader reader, CliToken token)
        {
            HResult result = reader.Provider.GetMethod((int)token, out var accessor);
            if(result)
                return method(accessor);
            else
                return result;
        }
    }
}