//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static zfunc;

    class AsmContextData
    {
        public static AsmContextData Create(
                IAssemblyComposition assemblies, 
                IClrIndex clrIndex, 
                DataResourceIndex resources, 
                AsmFormatConfig format, 
                CilFormatConfig cilFormat)
                    => new AsmContextData(assemblies, clrIndex, resources, format, cilFormat);

        AsmContextData(IAssemblyComposition assemblies, IClrIndex clrIndex, DataResourceIndex resources, AsmFormatConfig format, CilFormatConfig cilFormat)
        {
            this.Assemblies = assemblies;
            this.ClrIndex = clrIndex;
            this.Resources = resources;
            this.AsmFormat = format;
            this.CilFormat = cilFormat;
        }

        public IClrIndex ClrIndex {get; set;}

        public DataResourceIndex Resources {get;set;}
        
        public AsmFormatConfig AsmFormat {get;set;}

        public CilFormatConfig CilFormat {get;set;}

        public IAssemblyComposition Assemblies {get;set;}

        public AsmContextData WithFormat(AsmFormatConfig config)
        {
            this.AsmFormat = config;
            return this;
        }                

        public AsmContextData WithAssemblies(IAssemblyComposition assemblies)
        {
            Assemblies = assemblies;
            return this;
        }                

        public AsmContextData WithFormat(CilFormatConfig config)
        {
            CilFormat = config;
            return this;
        }

        public AsmContextData WithEmptyClrIndex()
        {
            ClrIndex = ClrMetadataIndex.Empty;
            return this;
        }                

        public AsmContextData WithClrIndex(IClrIndex index)
        {
            ClrIndex = index;
            return this;
        }                
    }
}