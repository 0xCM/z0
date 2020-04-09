//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct ParsedBuffer
    {        
        public readonly OpIdentity Id;

        public readonly ExtractResult Outcome;

        public readonly byte[] Content;

        [MethodImpl(Inline)]
        public static ParsedBuffer Define(OpIdentity id, ExtractResult outcome, byte[] content)
            => new ParsedBuffer(id,outcome,content);

        [MethodImpl(Inline)]
        ParsedBuffer(OpIdentity id, ExtractResult info, byte[] content)
        {
            this.Id = id;
            this.Outcome = info;
            this.Content = content;
        }        
    }
}