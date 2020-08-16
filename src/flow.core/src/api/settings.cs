//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static Konst;

    partial struct Flow    
    {        
        [Op]
        public static WfSettings settings(IAppContext context, CorrelationToken ct)
        {

            FilePath configPath()
            {
                var assname = Assembly.GetEntryAssembly().GetSimpleName();
                var filename = FileName.Define(assname, FileExtensions.Json);
                var src = context.AppPaths.ConfigRoot + filename;
                return src;
            }        

            var path = configPath();
            termsink(ct).Deposit(new LoadingWfConfig("Flow", path, ct));

            var dst = z.dict<string,string>();
            AppSettings.absorb(path,dst);
            var config = new WfSettings(dst);
                        
            termsink(ct).Deposit(new LoadedWfConfig("Flow", path, config, ct));            
            return config;
        }        
    }
}