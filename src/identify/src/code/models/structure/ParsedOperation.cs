//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ParsedOperation
    {        
        public readonly OpIdentity Id;

        public readonly CaptureOutcome Outcome;

        public readonly byte[] Content;

        [MethodImpl(Inline)]
        public static ParsedOperation Define(OpIdentity id, CaptureOutcome outcome, byte[] content)
            => new ParsedOperation(id,outcome,content);

        [MethodImpl(Inline)]
        ParsedOperation(OpIdentity id, CaptureOutcome info, byte[] content)
        {
            this.Id = id;
            this.Outcome = info;
            this.Content = content;
        }        
    }
}