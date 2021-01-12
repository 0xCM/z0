//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Part;

    public readonly struct ClrDisplaySig
    {
        [Op]
        public static ClrDisplaySig from(in ClrMethodMetadata src)
        {
            var dst = new TextBuffer(new StringBuilder());
            format(src, dst);
            return new ClrDisplaySig(dst.Emit());
        }

        [Op]
        static void format(in ClrMethodMetadata src, ITextBuffer dst)
        {
            dst.Append(src.ReturnType.Format());
            dst.Append(Chars.Space);
            dst.Append(src.MethodName);
            dst.Append(Chars.LParen);
            var parameters = src.ValueParams.View;
            var count = parameters.Length;
            for(var i=0; i<count; i++)
            {
                dst.Append(memory.skip(parameters,i).Format());
                if(i != count - 1)
                {
                    dst.Append(Chars.Comma);
                    dst.Append(Chars.Space);
                }
            }
            dst.Append(Chars.RParen);
        }

        readonly TextBlock Content;

        [MethodImpl(Inline)]
        ClrDisplaySig(TextBlock src)
            => Content = src;

        [MethodImpl(Inline)]
        public string Format()
            => Content.Format();

        public override string ToString()
            => Format();

        public static ClrDisplaySig Empty
        {
            [MethodImpl(Inline)]
            get => new ClrDisplaySig(TextBlock.Empty);
        }
    }
}