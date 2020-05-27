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
    using static BitLogix;

    using ULK = UnaryBitLogic;

    partial class BitLogixOps
    {
        public static UnaryOp<bit> lookup(ULK kind)
        {
            switch(kind)
            {
                case ULK.False: return @false;
                case ULK.Not: return not;
                case ULK.Identity: return identity;
                case ULK.True: return @true;
                default: throw Unsupported.value(sig(kind));
            }
        }
    }
}