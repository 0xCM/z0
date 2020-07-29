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
        readonly IEmissionWorkflow Wf;
        
        readonly EmissionDataType DataType;

        readonly IPart[] Parts;
        
        readonly FilePath TargetPath;
        
        [MethodImpl(Inline)]        
        public EmitPeRecords(IEmissionWorkflow wf, IPart[] src, FilePath dst)
        {
            Wf = wf;
            Parts = src;
            TargetPath = dst;
            DataType = EmissionDataType.Pe;
            DataType.Emitting(Wf);
        }

        public void Run()
        {
            using var writer = TargetPath.Writer();

            foreach(var part in Parts)
            {
                var id = part.Id;
                var path = Wf.TargetPath(id, DataType);
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
            DataType.Emitted(Wf);
        }
    }
}