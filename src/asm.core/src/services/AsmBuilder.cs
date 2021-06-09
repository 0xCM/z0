//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public class AsmBuilder : EnvService<AsmBuilder>
    {
        readonly AsmRegQuery RegQuery;

        public AsmBuilder()
        {
            RegQuery = AsmRegs.query();
        }
    }
}