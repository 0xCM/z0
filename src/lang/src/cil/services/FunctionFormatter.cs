//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct Cil
    {
        public readonly struct FunctionFormatter : ICilFunctionFormatter
        {
            readonly FormatConfig Config;

            [MethodImpl(Inline)]
            public FunctionFormatter(FormatConfig? config = null)
                => Config = config ?? FormatConfig.Default;

            static string comment(string text, string delimiter = "//", int pad = 0)
                => pad == 0 ? $"{delimiter} {text}" : delimiter.PadRight(pad) + text;

            public string Format(CilFunctionInfo f)
            {
                const string Margin = "    ";

                var rendered = text.build();
                rendered.AppendLine(comment(f.Identifier));
                rendered.AppendLine(comment(f.Attributes.ToString()));
                rendered.AppendLine(RP.OpenSlot);
                foreach(var i in f.Instructions)
                    rendered.AppendLine(Margin +  i.Format());
                rendered.AppendLine(RP.CloseSlot);
                return rendered.ToString();
            }
        }
    }
}