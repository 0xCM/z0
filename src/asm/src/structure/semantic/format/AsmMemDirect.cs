//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    partial struct AsmFormatServices
    {
        public static string Format(AsmMemDirect src)        
        {
            var dst = text.build();
            if(src.Base.IsSome())
                dst.Append(Format(src.Base));
            else
                dst.Append("UNK");
                
            var scaled = false;    
            if(src.Scale.IsNonUnital && src.Scale.IsNonEmpty)
            {
                var scale = RenderContent(src.Scale);
                dst.Append(text.concat(Chars.Star, scale));
                scaled = true;
            }

            var dx = Format(src.Dx);
            if(text.nonempty(dx))
                dst.Append(text.concat(Chars.Space, Chars.Plus, Chars.Space, dx));
            return dst.ToString();
        }            

    }
}