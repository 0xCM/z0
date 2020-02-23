//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    

    public static class Converters
    {
        [MethodImpl(Inline)]
        public static BitConversion.BiConverter BitConverter()
            => BitConversion.Converter;
    }

}