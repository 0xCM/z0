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

    partial struct PdbServices
    {
        [Op]
        public static CliToken token(Method src)
        {
            HResult result = src.Source.GetToken(out var token);
            return result ? token : CliToken.Empty;
        }

        [Op]
        public static uint SeqPointCount(Method src)
        {
            HResult result = src.Source.GetSequencePointCount(out var count);
            return result ? (uint)count : 0;
        }
    }
}