//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static root;    

    public readonly struct ParsedBuffer
    {        
        public readonly OpIdentity Id;

        public readonly ExtractionOutcome Outcome;

        public readonly byte[] Content;

        [MethodImpl(Inline)]
        public static ParsedBuffer Define(OpIdentity id, ExtractionOutcome outcome, byte[] content)
            => new ParsedBuffer(id,outcome,content);

        [MethodImpl(Inline)]
        ParsedBuffer(OpIdentity id, ExtractionOutcome info, byte[] content)
        {
            this.Id = id;
            this.Outcome = info;
            this.Content = content;
        }        
    }
}