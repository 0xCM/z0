//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static AsmTypes;
    using static AsmSpecs;

    using i = AsmOps;
    using r = Registers;

    public static partial class asm
    {

        public static i.mov mov<W>(reg<W> dst, reg<W> src)
            where W : unmanaged, INumericWidth
        {

            return default;
        }
    

    }

}