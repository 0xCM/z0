//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly ref struct EmitStringRecords
    {
        readonly IAppContext Wf;

        readonly IPart[] Parts;
        
        readonly FolderPath TargetDir;

        readonly EmissionDataType DataType;
        
        [MethodImpl(Inline)]
        public EmitStringRecords(IAppContext wf, IPart[] parts)
        {
            Wf = wf;
            Parts = parts;
            TargetDir = wf.AppPaths.ResourceRoot + FolderName.Define("strings");
            DataType = EmissionDataType.Strings;
            PartDataEmitters.emitting(DataType,Wf);
        }
        
        public void Run()
        {
            foreach(var part in Parts)
            {
                var dst = TargetDir + FileName.Define(part.Id.Format(), "strings.csv");
                using var emitter = new EmitPartStrings(Wf, part, dst);
                emitter.Run();                
            }
                
        }

        public void Dispose()
        {
            PartDataEmitters.emitted(DataType,Wf);
        }
    }
}