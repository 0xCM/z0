//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;    

    public readonly struct CapturedData
    {        
        public readonly OpIdentity Id;

        public readonly AsmCaptureOutcome Outcome;

        public readonly byte[] Content;

        [MethodImpl(Inline)]
        public static CapturedData Define(OpIdentity id, AsmCaptureOutcome outcome, byte[] content)
            => new CapturedData(id,outcome,content);

        [MethodImpl(Inline)]
        CapturedData(OpIdentity id, AsmCaptureOutcome info, byte[] content)
        {
            this.Id = id;
            this.Outcome = info;
            this.Content = content;
        }        
    }
}