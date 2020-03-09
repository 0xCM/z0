//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    class AsmContextData
    {
        public static AsmContextData New(IAssemblyComposition assemblies, DataResourceIndex resources, AsmFormatConfig format)
                => new AsmContextData(assemblies, resources, format);

        AsmContextData(IAssemblyComposition assemblies, DataResourceIndex resources, AsmFormatConfig format)
        {
            this.Assemblies = assemblies;
            this.Resources = resources;
            this.AsmFormat = format;
        }

        public DataResourceIndex Resources {get;}

        public IAssemblyComposition Assemblies {get;}

        public AsmFormatConfig AsmFormat {get;}
    }
}