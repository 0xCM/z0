//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct IntelSdm
    {
        public readonly struct PageFooter
        {
            public string Left0 {get;}

            public string Left1 {get;}

            public string Right0 {get;}

            public string Right1 {get;}

            [MethodImpl(Inline)]
            public PageFooter(string l0, string l1, string r0, string r1)
            {
                Left0 = l0;
                Left1 = l1;
                Right0 = r0;
                Right1 = r1;
            }

            public string Format()
                => string.Format("{0} {1} {2} {3}",Left0,Left1,Right0,Right1);

            public override string ToString()
                => Format();
        }
    }
}