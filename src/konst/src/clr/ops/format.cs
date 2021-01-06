//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static memory;
    partial struct Clr
    {
        [Op]
        public static string format(in MethodMetadata src)
        {
            var dst = Buffers.text();
            format(src, dst);
            return dst.Emit();
        }

        [Op]
        public static void format(in MethodMetadata src, ITextBuffer dst)
        {
            dst.Append(src.ReturnType.Format());
            dst.Append(Chars.Space);
            dst.Append(src.MethodName);
            dst.Append(Chars.LParen);
            var parameters = src.ValueParams.View;
            var count = parameters.Length;
            for(var i=0; i<count; i++)
            {
                dst.Append(skip(parameters,i).Format());
                if(i != count - 1)
                {
                    dst.Append(Chars.Comma);
                    dst.Append(Chars.Space);
                }
            }
            dst.Append(Chars.RParen);
        }
    }
}