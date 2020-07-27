//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
        
    public readonly ref struct EmitHexFiles
    {    
        readonly IWfPartEmission Wf;

        readonly IPart[] Parts;
        
        [MethodImpl(Inline)]
        public EmitHexFiles(IWfPartEmission wf, IPart[] parts)
        {
            Wf = wf;
            Parts = parts;
            DataType.Emitting(Wf);
        }

        public EmissionDataType DataType 
            => EmissionDataType.HexLine;        

        public void Run()
        {  
             foreach(var part in Parts)
             {
                using var step = new EmitHexFile(Wf, part);
                step.Run();
             }
        }

        public void Dispose()
        {
            DataType.Emitted(Wf);                          
        }
    }
}
