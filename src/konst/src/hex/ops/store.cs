//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;

    using static z;

    partial class Hex
    {
        [Op]
        public static Span<StringRef> store(N3 n, Span<StringRef> dst)
        {   
            byte i = 0;
            seek(dst,i++) = @ref(Hex3Text.x00);
            seek(dst,i++) = @ref(Hex3Text.x01);
            seek(dst,i++) = @ref(Hex3Text.x02);            
            seek(dst,i++) = @ref(Hex3Text.x03);
            seek(dst,i++) = @ref(Hex3Text.x04);
            seek(dst,i++) = @ref(Hex3Text.x05);
            seek(dst,i++) = @ref(Hex3Text.x06);            
            seek(dst,i++) = @ref(Hex3Text.x07);            
            return dst;
        }
    }
}