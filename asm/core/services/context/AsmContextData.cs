//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    public class AsmContextData
    {
        public static AsmContextData Create(IApiComposition composition, IAppSettings settings, IAppMsgExchange exchange,  IPolyrand random, AsmFormatConfig format)
            => new AsmContextData(composition, settings, exchange, random, format);

        AsmContextData(IApiComposition composition, IAppSettings settings, IAppMsgExchange exchange,  IPolyrand random, AsmFormatConfig format)
        {
            this.AsmFormat = format;
            this.Settings = settings ?? AppSettings.Empty;
            this.ApiSet = Z0.ApiSet.Create(composition);
            
            Control.require(exchange != null);
            this.Messaging = exchange;
            
            Control.require(random != null);
            this.Random = random;
        }

        public IApiSet ApiSet {get;}

        public IAppSettings Settings {get;}

        public IAppMsgExchange Messaging {get;}

        public IPolyrand Random {get;}

        public AsmFormatConfig AsmFormat {get;}
    }
}