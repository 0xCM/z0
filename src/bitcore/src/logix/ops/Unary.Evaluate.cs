//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static LogicSig;

    using ULK = UnaryBitLogicKind;

    partial class BitLogixOps
    {
        [MethodImpl(Inline)]
        public static Bit32 eval(ULK kind, Bit32 a)
        {
            if(kind == ULK.False)
                return Bit32.Off;
            else if(kind == ULK.Not)
                return Bit32.not(a);
            else if(kind == ULK.Identity)
                return a;
            else if(kind == ULK.True)
                return Bit32.On;
            else
                return Unsupported.raise<Bit32>(kind.ToString());
                //return Unsupported.raise<bit>(sig(kind));
        }
    }
}