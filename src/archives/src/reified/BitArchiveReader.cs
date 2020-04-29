//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Seed;

    readonly struct BitArchiveReader : IBitArchiveReader
    {
        public static IBitArchiveReader Service => default(BitArchiveReader);
        
        public IEnumerable<OperationBits> Read(FilePath src)
        {
            foreach(var line in src.ReadLines())
            {
                var hex = EncodedHexLine.Parse(line);
                if(hex)
                    yield return hex.MapRequired(h => OperationBits.Define(h.Uri, h.Encoded));
            }
        }        
    }
}