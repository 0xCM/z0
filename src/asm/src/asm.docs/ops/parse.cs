//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct AsmDocParts
    {
        public static bool parse(DocLine src, out object dst)
        {
            dst = 0;
            return true;
        }
    }

    public abstract class AsmDocPart<T>
        where T : AsmDocPart<T>
    {

    }
}