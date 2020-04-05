//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{

    using static AsmSpecs;
    using static AsmTypes;

    partial class AsmSpecs
    {
        public interface jmp
        {

        }

    }

    partial class AsmOps
    {
        public readonly struct ja : action<ja>
        {

        }    

        public readonly struct je : action<je>
        {
            
        }
    }
}