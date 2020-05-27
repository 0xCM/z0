//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Seed;

    public readonly struct CilFunctionFormatter : ICilFunctionFormatter
    {
        readonly CilFormatConfig config;

        [MethodImpl(Inline)]
        public static ICilFunctionFormatter Create(CilFormatConfig config = null)
            => new CilFunctionFormatter(config ?? CilFormatConfig.Default);
        
        [MethodImpl(Inline)]
        internal CilFunctionFormatter(CilFormatConfig config)
        {
            this.config = config;
        }
        
        static string Comment(string text, string delimiter = "//", int pad = 0)
            => pad == 0 ? $"{delimiter} {text}" : delimiter.PadRight(pad) + text;

        public string Format(CilFunction f)
        {
            var rendered = new StringBuilder();

            var margin = new string(Chars.Space,4);
            rendered.AppendLine(Comment(f.FullName));
            f.Sig.TryMap(s => rendered.AppendLine(Comment(s.Format())));
            rendered.AppendLine(Comment(f.ImplSpec.ToString()));            
            rendered.AppendLine(f.Sig.MapValueOrElse(s => s.Format(), () => string.Empty));
            rendered.AppendLine(Chars.LBrace.ToString());                    
            
            foreach(var i in f.Instructions)
                rendered.AppendLine(margin + i.ToString());
            rendered.AppendLine(Chars.RBrace.ToString());                        
            
            return rendered.ToString();
        }
    }
}