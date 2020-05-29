//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    [ApiHost("api")]
    public class AsmD : IApiHost<AsmD>
    {

        void ParseRex()
        {

            var mrm = Prefixes.ParseModRM(0b110110);
            term.print(mrm.Format());
        }

    }
}