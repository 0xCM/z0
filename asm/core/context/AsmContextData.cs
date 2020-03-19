//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;


    public class AsmContextData
    {
        public static AsmContextData New(IAssemblyComposition assemblies, AsmFormatConfig format = null, IAppSettings settings = null, IPolyrand random = null)
            => new AsmContextData(assemblies, format ?? AsmFormatConfig.New,  settings, random);

        AsmContextData(IAssemblyComposition assemblies, AsmFormatConfig format, IAppSettings settings, IPolyrand random)
        {
            this.Assemblies = assemblies;
            this.AsmFormat = format;
            this.Settings = settings ?? AppSettings.Empty;
            this.Random = random != null ? Option.some(random) : default;
        }

        public IAssemblyComposition Assemblies {get;}

        public AsmFormatConfig AsmFormat {get;}

        public IAppSettings Settings {get;}

        public Option<IPolyrand> Random {get;}

    }
}