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

    using static Part;
    using static memory;

    partial struct AppSymbolics
    {
        [Op]
        public static CliToken token(Method src)
        {
            HResult result = src.Source.GetToken(out var token);
            return result ? token : CliToken.Empty;
        }
    }
}