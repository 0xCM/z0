//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public struct AsmStatementParser
    {
        AsmStatement Statement;

        bool Succeeded;


        [MethodImpl(Inline)]
        public AsmStatementParser(byte i)
        {
            Statement = default;
            Succeeded = false;
        }

        public bool Parse(string src, ref AsmStatement dst)
        {
            RunParser(src);
            if(Succeeded)
            {
                dst = Statement;
                return true;
            }
            else
            {
                return false;
            }

        }

        void RunParser(ReadOnlySpan<char> src)
        {

        }
    }
}