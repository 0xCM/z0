//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    public class AsmContextData
    {
        public static AsmContextData New(IAssemblyComposition assemblies, AsmFormatConfig format = null)
            => new AsmContextData(assemblies, format ?? AsmFormatConfig.New);

        AsmContextData(IAssemblyComposition assemblies, AsmFormatConfig format)
        {
            this.Assemblies = assemblies;
            this.AsmFormat = format;
        }

        public IAssemblyComposition Assemblies {get;}

        public AsmFormatConfig AsmFormat {get;}
    }
}