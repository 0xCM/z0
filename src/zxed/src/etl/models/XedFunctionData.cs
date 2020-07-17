//-----------------------------------------------------------------------------
// Copyright   : (c) 2019 Intel Corporation
// Copyright   : (c) Chris Moore, 2020
// License     : Apache
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using Xed;

    public readonly struct XedFunctionData
    {        
        public FileName SourceFile {get;}
        
        public string Name {get;}

        public string ReturnType {get;}

        public string[] Body {get;}

        public string Declaration
            => text.concat(SourceFile, Chars.FSlash, XedSourceMarkers.FuncHeader(Name), ReturnType);

        [MethodImpl(Inline)]
        public XedFunctionData(FileName src, string name, string returns, string[] body)
        {
            SourceFile = src;
            Name = name;
            ReturnType = returns;
            Body = body;
        }
    }
}