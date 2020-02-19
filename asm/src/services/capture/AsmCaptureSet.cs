//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    
    using static zfunc;

    public class AsmCaptureSet
    {
        public ApiHostPath Host {get;set;}
        
        public FilePath CapturedPath {get;set;}

        public CapturedEncodings Captured {get;set;}

        public FilePath ParsedPath {get;set;}

        public ParsedEncodings Parsed {get;set;}

        public FilePath DecodedPath {get;set;}

    }

}