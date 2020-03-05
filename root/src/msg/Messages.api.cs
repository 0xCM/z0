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

    public static class Messages
    {
        public static IEnumerable<AppMsg> emit(IContext context, IEnumerable<AppMsg> src)
        {                    
            var errors = src.Where(m => m.Kind == AppMsgKind.Error).FormatLines().ToArray();
            if(errors.Length != 0)
                context.Paths.StandardErrorPath.AppendAsync(errors);
                                
            var standard = src.Where(m => m.Kind != AppMsgKind.Error).FormatLines().ToArray();
            if(standard.Length != 0)
                context.Paths.StandardOutPath.AppendAsync(standard);
            return src;
        }
    }
}