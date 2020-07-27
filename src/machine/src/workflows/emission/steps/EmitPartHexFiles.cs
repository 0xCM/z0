//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
        
    public readonly ref struct EmitPartHexFiles
    {    
        public readonly EmissionDataType DataType;

        readonly IWfPartEmission Wf;

        readonly IPart[] Parts;
        
        [MethodImpl(Inline)]
        public EmitPartHexFiles(IWfPartEmission wf, IPart[] parts)
        {
            Wf = wf;
            Parts = parts;
            DataType = EmissionDataType.PartDat;
            DataType.Emitting(Wf);
        }

        public void Run()
        {  
             foreach(var part in Parts)
             {
                var dst = Wf.PartDatDir + FileName.Define(part.Format(), FileExtension.Define("dat"));
                using var step = new EmitHexLineFile(Wf, part, dst);
                step.Run();
             }
        }

        public void Dispose()
        {
            DataType.Emitted(Wf);                          
        }
    }
}