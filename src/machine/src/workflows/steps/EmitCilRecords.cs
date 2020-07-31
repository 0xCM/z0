//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    public readonly ref struct EmitCilRecords
    {
        readonly IAppContext Wf;

        readonly EmissionDataType DataType;

        readonly FolderPath TargetDir;

        readonly IPart[] Parts;

        [MethodImpl(Inline)]
        public EmitCilRecords(IAppContext wf, IPart[] parts)
        {
            Wf = wf;
            Parts = parts;
            DataType = EmissionDataType.Il;
            TargetDir = Wf.AppPaths.ResourceRoot + FolderName.Define("il");
            Wf.Running(nameof(EmitCilRecords));
        }

        public void Run()
        {
            foreach(var part in Parts)
            {
                using var emitter = new EmiPartCil(Wf, part, TargetDir + FileName.Define(part.Id.Format(), "il.csv"));
                emitter.Run();
            }                                     

        }

        public void Dispose()
        {
            Wf.Ran(nameof(EmitCilRecords));
        }            
    }
}