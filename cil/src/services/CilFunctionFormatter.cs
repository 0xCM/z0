//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    readonly struct CilFunctionFormatter : ICilFunctionFormatter
    {
        public ICilContext Context {get;}

        [MethodImpl(Inline)]
        public static ICilFunctionFormatter New(ICilContext context)
            => new CilFunctionFormatter(context);
        
        [MethodImpl(Inline)]
        CilFunctionFormatter(ICilContext context)
        {
            this.Context = context;
        }
        
        static string Comment(string text, string delimiter = "//", int pad = 0)
            => pad == 0 ? $"{delimiter} {text}" : delimiter.PadRight(pad) + text;

        public string Format(CilFunction f)
        {
            var rendered = text.factory.Builder();

            var margin = new string(Chars.Space,4);
            rendered.AppendLine(Comment(f.FullName));
            f.Sig.TryMap(s => rendered.AppendLine(Comment(s.Format())));
            rendered.AppendLine(Comment(f.ImplSpec.ToString()));            
            rendered.AppendLine(f.Sig.MapValueOrElse(s => s.Format(), () => string.Empty));
            rendered.AppendLine(Chars.LBrace);                    
            
            foreach(var i in f.Instructions)
                rendered.AppendLine(margin + i.ToString());
            rendered.AppendLine(Chars.RBrace);                        
            
            return rendered.ToString();
        }
    }
}