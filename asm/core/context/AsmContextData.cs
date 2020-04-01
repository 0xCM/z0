//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using static Core;

    public class AsmContextData
    {
        public static AsmContextData Create(IApiComposition assemblies, IAppSettings settings, IAppMsgExchange exchange,  IPolyrand random, AsmFormatConfig format)
            => new AsmContextData(assemblies, settings, exchange, random, format);

        AsmContextData(IApiComposition assemblies, IAppSettings settings, IAppMsgExchange exchange,  IPolyrand random, AsmFormatConfig format)
        {
            this.Assemblies = assemblies;
            this.AsmFormat = format;
            this.Settings = settings ?? AppSettings.Empty;
            
            require(exchange != null);
            this.Messaging = exchange;
            
            require(random != null);
            this.Random = random;
        }

        public IApiComposition Assemblies {get;}

        public IAppSettings Settings {get;}

        public IAppMsgExchange Messaging {get;}

        public IPolyrand Random {get;}

        public AsmFormatConfig AsmFormat {get;}
    }
}