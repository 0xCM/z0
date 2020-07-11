//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    partial struct SemanticRender
    {
        public string Render(AsmMemDirect src)        
        {
            var dst = text.build();
            if(src.Base.IsSome())
                dst.Append(Render(src.Base));
            else
                dst.Append("UNK");
                
            if(src.Scale.NonUnital && src.Scale.NonZero)
            {
                var scale = Render(src.Scale);
                dst.Append(text.concat(Chars.Star, scale));
            }

            if(src.Dx.NonZero)
                dst.Append(text.concat(Chars.Space, Chars.Plus, Chars.Space, Render(src.Dx)));

            return dst.ToString();
        }
    }
}