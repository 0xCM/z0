//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Linq;
    using System.Runtime.CompilerServices;
 
    using static zfunc;    

    public readonly struct CapturedData
    {        
        public static CapturedData Define(OpIdentity id, CaptureOutcome outcome, byte[] content)
            => new CapturedData(id,outcome,content);

        CapturedData(OpIdentity id, CaptureOutcome info, byte[] content)
        {
            this.Id = id;
            this.Outcome = info;
            this.Content = content;
        }
        
        public readonly OpIdentity Id;

        public readonly CaptureOutcome Outcome;

        public readonly byte[] Content;
    }


}