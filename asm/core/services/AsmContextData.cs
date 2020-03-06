//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    class AsmContextData
    {
        public static AsmContextData New(IAssemblyComposition assemblies, IClrIndex clrIndex, 
            DataResourceIndex resources, AsmFormatConfig format, CilFormatConfig cilFormat)
                => new AsmContextData(assemblies, clrIndex, resources, format, cilFormat);

        AsmContextData(IAssemblyComposition assemblies, IClrIndex clrIndex, DataResourceIndex resources, AsmFormatConfig format, CilFormatConfig cilFormat)
        {
            this.Assemblies = assemblies;
            this.ClrIndex = clrIndex;
            this.Resources = resources;
            this.AsmFormat = format;
            this.CilFormat = cilFormat;
        }

        public IClrIndex ClrIndex {get;}

        public DataResourceIndex Resources {get;}

        public IAssemblyComposition Assemblies {get;}

        public CilFormatConfig CilFormat {get;}

        public AsmFormatConfig AsmFormat {get;}
    }
}