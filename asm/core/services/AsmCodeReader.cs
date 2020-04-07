//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Seed;

    readonly struct AsmCodeReader : IAsmCodeReader
    {
        [MethodImpl(Inline)]
        public static IAsmCodeReader New(IContext context)
            => default(AsmCodeReader);

        public IEnumerable<AsmCode> Read(FilePath src)
        {
            foreach(var line in src.ReadLines())
            {
                var hex = AsmHexLine.Parse(line);
                if(hex.OnNone(() => term.error($"Could not parse the line {line} from {src}")))
                    yield return hex.MapRequired(h => AsmCode.Define(h.Id, h.Encoded));
            }
        }        
    }
}