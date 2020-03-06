//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    readonly struct CilFunctionFormatter : ICilFunctionFormatter
    {
        public IAsmContext Context {get;}

        [MethodImpl(Inline)]
        public static ICilFunctionFormatter New(IAsmContext context)
            => new CilFunctionFormatter(context);
        
        [MethodImpl(Inline)]
        CilFunctionFormatter(IAsmContext context)
        {
            this.Context = context;
        }
        
        static string Comment(string text, string delimiter = "//", int pad = 0)
            => pad == 0 ? $"{delimiter} {text}" : delimiter.PadRight(pad) + text;


        public string Format(CilFunction f)
        {
            var rendered = text.factory.Builder();

            var margin = new string(AsciSym.Space,4);
            rendered.AppendLine(Comment(f.FullName));
            f.Sig.TryMap(s => rendered.AppendLine(Comment(s.Format())));
            rendered.AppendLine(Comment(f.ImplSpec.ToString()));            
            rendered.AppendLine(f.Sig.MapValueOrElse(s => s.Format(), () => string.Empty));
            rendered.AppendLine(AsciSym.LBrace);                    
            
            foreach(var i in f.Instructions)
                rendered.AppendLine(margin + i.ToString());
            rendered.AppendLine(AsciSym.RBrace);                        
            
            return rendered.ToString();
        }
    }
}