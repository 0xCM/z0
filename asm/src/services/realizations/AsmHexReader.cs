//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;
    using AsmSpecs;

    using static zfunc;

    readonly struct AsmHexReader : IAsmHexReader
    {
        public static IAsmHexReader Create(IAsmContext context, char? idsep = null, char? bytesep = null)
            => new AsmHexReader(context, idsep, bytesep);

        public IAsmContext Context {get;}

        readonly char IdSep;
        
        readonly char ByteSep;

        AsmHexReader(IAsmContext context, char? idsep = null, char? bytesep = null)
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
                if(hex.OnNone(() => errout($"Could not parse the line {line} from {src}")))
                    yield return hex.MapRequired(h => AsmCode.Define(h.Id, h.Encoded));
            }
        }
        
    }


}