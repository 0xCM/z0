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
        public static WfEventLog wflog(IAppContext context, CorrelationToken ct)
        {
            return new WfEventLog(
                    context.AppPaths.AppDataRoot + FileName.Define(context.AppName + ".stdout2", FileExtensions.Csv), 
                    context.AppPaths.AppDataRoot + FileName.Define(context.AppName + ".errout2", FileExtensions.Csv), 
                    termsink(ct));
        }        
    }
}