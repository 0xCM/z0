//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;
    using static z;
    
    partial struct asci
    {
        public ReadOnlySpan<AsciChar> CharSet
        {
            [MethodImpl(Inline), Op]
            get => recover<char,AsciChar>(AsciStrings.Text(n0));
        }
    }
}