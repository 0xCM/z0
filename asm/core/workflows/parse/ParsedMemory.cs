//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;    

    public readonly struct ParsedMemory
    {        
        public readonly OpIdentity Id;

        public readonly ExtractionOutcome Outcome;

        public readonly byte[] Content;

        [MethodImpl(Inline)]
        public static ParsedMemory Define(OpIdentity id, ExtractionOutcome outcome, byte[] content)
            => new ParsedMemory(id,outcome,content);

        [MethodImpl(Inline)]
        ParsedMemory(OpIdentity id, ExtractionOutcome info, byte[] content)
        {
            this.Id = id;
            this.Outcome = info;
            this.Content = content;
        }        
    }
}