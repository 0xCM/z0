//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public static class MessageEmission
    {
        public static IEnumerable<AppMsg> SaveMessages(this IAppEnv context, IEnumerable<AppMsg> src)
        {                    
            var errors = Formattable.items(src.Where(m => m.Kind == AppMsgKind.Error)).ToArray();
            if(errors.Length != 0)
                context.Paths.StandardErrorPath.Append(errors);
                                
            var standard = Formattable.items(src.Where(m => m.Kind != AppMsgKind.Error)).ToArray();

            if(standard.Length != 0)
                context.Paths.StandardOutPath.Append(standard);
            return src;
        }

        internal static IEnumerable<AppMsg> Save(this IEnumerable<AppMsg> src, IAppEnv dst)
            => SaveMessages(dst, src);                            
    }
}