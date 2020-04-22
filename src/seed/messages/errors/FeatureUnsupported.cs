//-----------------------------------------------------------------------------
// CPrimalyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;
    
    partial class AppErrors
    {        
        public static AppException FeatureUnsupported(object feature, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => AppException.Define(AppErrorMsg.FeatureUnsupported(feature, caller, file, line));

        public static void ThrowFeatureUnsupported(string feature, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => throw FeatureUnsupported(feature, caller, file, line);
    }
}