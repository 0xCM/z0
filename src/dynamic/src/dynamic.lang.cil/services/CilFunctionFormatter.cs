//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Konst;

    public readonly struct CilFunctionFormatter : ICilFunctionFormatter
    {
        readonly CilFormatConfig Config;

        [MethodImpl(Inline)]
        public CilFunctionFormatter(CilFormatConfig? config = null)
            => Config = config ?? CilFormatConfig.Default;

        static string comment(string text, string delimiter = "//", int pad = 0)
            => pad == 0 ? $"{delimiter} {text}" : delimiter.PadRight(pad) + text;

        public string Format(CilFunction f)
        {
            const string Margin = "    ";

            var rendered = text.build();
            rendered.AppendLine(comment(f.FullName));
            rendered.AppendLine(comment(f.Attributes.ToString()));
            rendered.AppendLine(RP.OpenSlot);
            foreach(var i in f.Instructions)
                rendered.AppendLine(Margin + i.Formatted);
            rendered.AppendLine(RP.CloseSlot);
            return rendered.ToString();
        }
    }
}