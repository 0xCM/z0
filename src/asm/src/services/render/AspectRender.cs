//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Linq;

    using static OpKind;

    partial struct SemanticRender 
    {
        const string AspectDelimiter = CharText.Space + CharText.Pipe + CharText.Space;

        public string RenderAspects<T>(object src)
        {
            var dst = text.build();
            var props = typeof(T).Properties().Instance();
            var count = 0;
            for(var i=0; i< props.Length; i++)
            {
                var val = props[i].GetValue(src);
                if(val is null)
                    continue;

                if(count++ != 0)
                    dst.Append(AspectDelimiter);

                if(val is ITextual t)
                    dst.Append(t.Format());
                else
                    dst.Append(val.ToString());
            }

            return dst.ToString();
        }
    }
}