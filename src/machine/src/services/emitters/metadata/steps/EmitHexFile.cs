//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    public readonly ref struct EmitHexFile
    {
        readonly IWfPartEmission Wf;

        readonly IPart Part;

        [MethodImpl(Inline)]
        public EmitHexFile(IWfPartEmission wf, IPart part)
        {
            Wf = wf;
            Part = part;
            DataType.Emitting(Wf);

        }

        public EmissionDataType DataType 
            => EmissionDataType.HexLine;        

        public void Run()
        {
            var id = Part.Id;
            var path = Wf.TargetPath(id, DataType);
            var assembly = Part.Owner;                
            var count = 0;

            DataType.Emitting(path, Wf);
            using var emitter = new EmitHexLines(Wf, Part);
            emitter.Run();
            DataEmitters.emitted(Wf, DataType, id, count);
        }

        public void Dispose()
        {
            DataType.Emitted(Wf);
        }
    }
}