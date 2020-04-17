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


        public t_asm_explicit()
        {
                
        }
   
        public void Execute(params string[] args)
        {

            using var buffers = Context.Buffers(Pow2.T14, 3);
            OnExecute(buffers);
        }

        protected abstract void OnExecute(in BufferSeq buffers);

    }
}