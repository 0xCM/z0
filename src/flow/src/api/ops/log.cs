//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Text;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct Flow    
    {        
        [MethodImpl(Inline), Op]
        public static WfEventLog log(IAppContext context, CorrelationToken ct)
        {
            return new WfEventLog(
                    context.AppPaths.AppDataRoot + FileName.Define(context.AppName + ".stdout2", FileExtensions.Csv), 
                    context.AppPaths.AppDataRoot + FileName.Define(context.AppName + ".errout2", FileExtensions.Csv), 
                    WfCore.termsink(ct));
        }        
    }
}