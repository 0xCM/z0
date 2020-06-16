//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Control;
    using static Konst;
    using static asci;

    public class t_digital : t_symbolic<t_digital>
    {        

        public void unpack_4()
        {
            void check(char x, AsciCharCode y)
                => Claim.eq(encode(x), y);
            
            var src = span(array('1','2','3','4'));
            var dst = span(alloc<AsciCharCode>(4));
            encode(src,dst);
            iter(src, dst, check);            
        }
    }
}