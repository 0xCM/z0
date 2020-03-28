//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    partial class Root
    {        
        public static AppException unsupported(object feature, [Caller] string caller = null, [File] string file = null,  [Line] int? line = null)
            => AppErrors.FeatureUnsupported(feature, caller,file,line);

        public static AppException unsupported<T>([Caller] string caller = null, [File] string file = null,  [Line] int? line = null)
            => AppErrors.TypeUnsupported<T>(caller,file,line);
    }
}