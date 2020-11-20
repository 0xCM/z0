//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Konst;

    partial struct Encoded
    {
        [Op]
        public static bool equals(BinaryCode a, BinaryCode b)
        {
            if(a.IsNonEmpty && b.IsNonEmpty)
                return a.View.SequenceEqual(b.View);
            else
            {
                if(a.Length == 0 && a.Length == 0)
                    return true;
                else
                    return false;
            }
        }
    }
}