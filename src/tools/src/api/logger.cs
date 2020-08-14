//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct Tooling
    {
        [Op]
        public static ToolLogger logger<T>(IWfContext context, T id)
            where T : unmanaged, Enum
                => logger(context, id.ToString());
        
        [Op]
        public static ToolLogger logger(IWfContext wf, string name)
        {            
            var dst = wf.AppPaths.AppDataRoot + FileName.Define(name, FileExtensions.Log);
            return new ToolLogger(wf,dst);
        }
    }
}