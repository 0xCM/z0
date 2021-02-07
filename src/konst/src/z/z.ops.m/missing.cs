// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    partial struct z
    {
        [Op]
        public static AppException missing([CallerMemberName] string caller = null, [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            => AppErrors.missing(caller, file, line);
    }
}