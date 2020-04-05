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
        public interface reg256 : reg<W256>
        {

        }

        public interface ymm<F> : reg256, reg<F,W256>
            where F : struct, ymm<F>
        {

        }

        public interface ymm<F,N> : ymm<F>
            where F : struct, ymm<F,N>
            where N : unmanaged, ITypeNat
        {

        }

    }

    partial class AsmTypes
    {

    }
}