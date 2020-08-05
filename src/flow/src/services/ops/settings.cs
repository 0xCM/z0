//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;

    partial struct Flow    
    {
        public static WfSettings settings(IAppContext context, CorrelationToken ct)
        {
            var path = Flow.ConfigPath(context);
            termsink(ct).Deposit(new LoadingWfConfig(nameof(Flow), path, ct));

            var dst = z.dict<string,string>();
            AppSettings.absorb(path,dst);
            var config = new WfSettings(dst);
                        
            termsink(ct).Deposit(new LoadedWfConfig(nameof(Flow), path, config, ct));            
            return config;
        }        
    }
}