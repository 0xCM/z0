//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public readonly struct AsmServices : IAsmServices
    {
        public static IAsmServices Services => default(AsmServices);
    }
}