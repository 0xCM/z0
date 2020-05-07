//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{

    using static AsmSpecs;

    partial class AsmOps
    {            
        public readonly struct mov : func<mov>
        {
            
        }


        public readonly struct movzx 
        {

        }


        public readonly struct movzx<S,T>
        {
            public movzx(S src, T dst)
            {
                this.Source = src;
                this.Target = dst;
            }

            public readonly S Source;

            public readonly T Target;
        }
    }
}