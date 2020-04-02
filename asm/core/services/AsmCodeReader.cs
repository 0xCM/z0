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
        public IAsmContext Context {get;}

        readonly char IdSep;
        
        readonly char ByteSep;

        [MethodImpl(Inline)]
        public static IAsmCodeReader New(IAsmContext context, char? idsep = null, char? bytesep = null)
            => new AsmCodeReader(context, idsep, bytesep);

        [MethodImpl(Inline)]
        AsmCodeReader(IAsmContext context, char? idsep = null, char? bytesep = null)
        {
            this.Context = context;
            this.IdSep = idsep ?? AsmHexLine.DefaultIdSep;
            this.ByteSep = bytesep ?? AsmHexLine.DefaultByteSep;
        }

        public IEnumerable<AsmCode> Read(FilePath src)
        {
            foreach(var line in src.ReadLines())
            {
                var hex = AsmHexLine.Parse(line,IdSep,ByteSep);
                if(hex.OnNone(() => term.error($"Could not parse the line {line} from {src}")))
                    yield return hex.MapRequired(h => AsmCode.Define(h.Id, h.Encoded));
            }
        }        
    }
}