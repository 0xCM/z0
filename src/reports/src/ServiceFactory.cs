//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;

    using static Seed;

    public static class ServiceFactory
    {            
        public static IAppDataLog DataLog(this IContext context, FilePath dst, char delimiter = Chars.Pipe, bool header = true)            
            => AppDataLog.Create(dst,delimiter,header);
    }
}