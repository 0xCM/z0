//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;    
    using static LogicSig;

    using ULK = UnaryLogicKind;

    partial class BitLogixOps
    {
        public static bit eval(ULK kind, bit a)
        {        
            switch(kind)
            {
                case ULK.False: return bit.Off;
                case ULK.Not: return bit.not(a);
                case ULK.Identity: return a;
                case ULK.True: return bit.On;
                default: throw Unsupported.value(sig(kind));
            }
        }    
    }
}