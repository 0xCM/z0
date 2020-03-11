//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Root;

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
            this.IdSep = idsep ?? HexLine.DefaultIdSep;
            this.ByteSep = bytesep ?? HexLine.DefaultByteSep;
        }

        public IEnumerable<AsmCode> Read(FilePath src)
        {
            foreach(var line in src.ReadLines())
            {
                var hex = HexLine.Parse(line,IdSep,ByteSep);
                if(hex.OnNone(() => term.error($"Could not parse the line {line} from {src}")))
                    yield return hex.MapRequired(h => AsmCode.Define(h.Id, h.Encoded));
            }
        }        
    }
}