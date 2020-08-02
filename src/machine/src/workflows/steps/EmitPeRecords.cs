//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    public readonly ref struct EmitPeRecords
    {
        readonly WfContext Wf;
        
        readonly EmissionDataType DataType;

        readonly IPart[] Parts;
        
        readonly FilePath TargetPath;
        
        [MethodImpl(Inline)]        
        public EmitPeRecords(WfContext wf, IPart[] src)
        {
            Wf = wf;
            Parts = src;
            TargetPath = wf.AppPaths.ResourceRoot + FileName.Define("z0", "pe.csv");
            DataType = EmissionDataType.Pe;
            Wf.Running(nameof(EmitPeRecords), TargetPath.Name);
        }

        public void Run()
        {
            using var writer = TargetPath.Writer();

            foreach(var part in Parts)
            {
                var id = part.Id;
                var assembly = part.Owner;                                
                var data = PartReader.headers(FilePath.Define(assembly.Location));
                var rendered = HeaderInfo.render(data);
                var count = rendered.Length;
                
                for(var i=0; i<count; i++)
                    writer.WriteLine(Root.skip(rendered,i));
            }  
        }

        public void Dispose()
        {
             Wf.Ran(nameof(EmitPeRecords));
        }
    }
}