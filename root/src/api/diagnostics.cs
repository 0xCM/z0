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

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    partial class Root
    {        
        public static AppException unsupported(object feature, [Caller] string caller = null, [File] string file = null,  [Line] int? line = null)
            => errors.FeatureUnsupported(feature, caller,file,line);

        public static AppException unsupported<T>([Caller] string caller = null, [File] string file = null,  [Line] int? line = null)
            => errors.TypeUnsupported<T>(caller,file,line);

        public static void require(bool test, string info = null, [Caller] string caller = null, [File] string file = null,  [Line] int? line = null)
            => errors.ThrowIfFalse(test, info, caller, file, line);
    }
}