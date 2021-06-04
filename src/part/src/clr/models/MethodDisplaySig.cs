//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public readonly struct MethodDisplaySig
    {
        [Op]
        public static MethodDisplaySig from(in ClrMethodArtifact src)
            => new MethodDisplaySig(format(src));

        [Op]
        public static string format(in ClrTypeSigInfo src)
            => src.IsArray ? src.DisplayName + "[]" : $"{src.Modifier}{src.DisplayName}";

        [Op]
        public static string format(in ClrParamInfo src)
            => string.Format("{0} {1}", format(src.Type), src.Name);

        [Op]
        public static string format(in ClrMethodArtifact src)
        {
            var dst = text.buffer();
            dst.Append(format(src.ReturnType));
            dst.Append(Chars.Space);
            dst.Append(src.MethodName);
            dst.Append(Chars.LParen);
            var parameters = src.Args.View;
            var count = parameters.Length;
            for(var i=0; i<count; i++)
            {
                dst.Append(format(skip(parameters,i)));
                if(i != count - 1)
                {
                    dst.Append(Chars.Comma);
                    dst.Append(Chars.Space);
                }
            }
            dst.Append(Chars.RParen);
            return dst.Emit();
        }

        readonly TextBlock Content;

        [MethodImpl(Inline)]
        MethodDisplaySig(TextBlock src)
            => Content = src;

        [MethodImpl(Inline)]
        public string Format()
            => Content.Format();

        public override string ToString()
            => Format();

        public static MethodDisplaySig Empty
        {
            [MethodImpl(Inline)]
            get => new MethodDisplaySig(TextBlock.Empty);
        }
    }
}