//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.IO;
    using AsmSpecs;
    using System.Runtime.CompilerServices;

    using static zfunc;

    readonly struct CilFormatter : ICilFormatter
    {
        [MethodImpl(Inline)]
        public static ICilFormatter Create(IAsmContext context)
            => new CilFormatter(context);
        
        CilFormatter(IAsmContext context)
        {
            this.Context = context;
        }

        public IAsmContext Context {get;}

        public string Format(CilFunction f)
        {
            var rendered = text();

            var margin = new string(AsciSym.Space,4);
            rendered.AppendLine(f.FullName.Comment());
            f.Sig.TryMap(s => rendered.AppendLine(s.Format().Comment()));
            rendered.AppendLine(f.ImplSpec.ToString().Comment());            
            rendered.AppendLine(f.Sig.MapValueOrElse(s => s.Format(), () => string.Empty));
            rendered.AppendLine(AsciSym.LBrace);                    
            
            foreach(var i in f.Instructions)
                rendered.AppendLine(margin + i.ToString());
            rendered.AppendLine(AsciSym.RBrace);                        
            
            return rendered.ToString();
        }
    }
}


