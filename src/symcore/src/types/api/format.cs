//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Types
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static PrimalKind;

    partial struct types
    {
        internal static string format(PrimalKind src)
            => src switch{
                UnsignedInt => "u",
                SignedInt => "i",
                Float => "f",
                _ => EmptyString
            };

        internal static Outcome parse(char src, out PrimalKind dst)
        {
            dst = PrimalKind.None;
            switch(src)
            {
                case 'i':
                    dst = PrimalKind.SignedInt;
                break;
                case 'u':
                    dst = PrimalKind.UnsignedInt;
                break;
                case 'f':
                    dst = PrimalKind.Float;
                break;
            }
            return dst != 0;
        }
    }
}