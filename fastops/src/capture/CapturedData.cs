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

    /// <summary>
    /// Defines a capture outcome/content package to collect capture results for subjects not known as members
    /// </summary>
    public readonly struct CapturedData
    {        
        public static CapturedData Define(OpIdentity id, CaptureOutcome info, byte[] content)
            => new CapturedData(id,info,content);

        CapturedData(OpIdentity id, CaptureOutcome info, byte[] content)
        {
            this.Id = id;
            this.CaptureInfo = info;
            this.Content = content;
        }
        
        public readonly OpIdentity Id;

        public readonly CaptureOutcome CaptureInfo;

        public readonly byte[] Content;
    }

}