//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    public abstract class t_asm_explicit<E> : t_asm<E>, IExplicitTest
        where E : t_asm_explicit<E>
    {

        FolderPath LogDir;

        public t_asm_explicit()
        {
            //Context = AsmContext.Rooted(this,DefaultComposition.Create());
            this.LogDir = Context.EmissionPaths().DataSubDir(FolderName.Define(GetType().Name));
                                    
        }
   
        public void Execute(params string[] args)
        {
            void OnCaptureEvent(in AsmCaptureEvent data)
            {
                //Trace($"{data.CaptureState}");
            }

            using var buffers = Context.Buffers(OnCaptureEvent);
            OnExecute(buffers);
        }

        protected abstract void OnExecute(in AsmBuffers buffers);

    }
}