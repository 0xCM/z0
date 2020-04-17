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
        [MethodImpl(Inline)]
        public static IBitArchiveReader New(IContext context)
            => default(BitArchiveReader);

        public IEnumerable<ApiBits> Read(FilePath src)
        {
            foreach(var line in src.ReadLines())
            {
                var hex = EncodedHexLine.Parse(line);
                if(hex.OnNone(() => term.error($"Could not parse the line {line} from {src}")))
                    yield return hex.MapRequired(h => ApiBits.Define(h.Id, h.Encoded));
            }
        }        
    }
}