//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Collections.Concurrent;

    public static class MessageEmission
    {
        public static IEnumerable<AppMsg> SaveMessages(this IAppEnv context, IEnumerable<AppMsg> src)
        {                    
            var errors = src.Where(m => m.Kind == AppMsgKind.Error).FormatLines().ToArray();
            if(errors.Length != 0)
                context.Paths.StandardErrorPath.Append(errors);
                                
            var standard = src.Where(m => m.Kind != AppMsgKind.Error).FormatLines().ToArray();
            if(standard.Length != 0)
                context.Paths.StandardOutPath.Append(standard);
            return src;
        }

        internal static IEnumerable<AppMsg> Save(this IEnumerable<AppMsg> src, IAppEnv dst)
            => SaveMessages(dst, src);                            
    }
}