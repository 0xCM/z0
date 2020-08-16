//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{            
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    public struct AsmTextEmitter
    {
        readonly AsmTextWriterFactory Factory;
        
        [MethodImpl(Inline)]
        public AsmTextEmitter(AsmTextWriterFactory factory)
        {
            Factory = factory;
        }

        public void Emit(AsmRoutine[] src, IAsmFormatter formatter, FilePath dst)
        {
            if(src.Length == 0)
                return;
            
            using var writer = Factory(dst, formatter);
            writer.WriteAsm(src);
        }
    }
}