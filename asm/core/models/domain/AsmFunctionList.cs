//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct AsmFunctionList : IFiniteSeq<AsmFunctionList, AsmFunction>
    {        
        
        public static AsmFunctionList Empty = new AsmFunctionList(new AsmFunction[]{});
        
        [MethodImpl(Inline)]
        public static AsmFunctionList Define(params AsmFunction[] src)
            => new AsmFunctionList(src);

        public string Format()
        {
            var dst = text.factory.Builder();
            for(var i=0; i<Content.Length; i++)
            {
                dst.Append(Content[i].FormatAsmLines().Concat());
                dst.AppendLine(text.pagebreak);
            }
            return dst.ToString();
        }

        [MethodImpl(Inline)]
        AsmFunctionList(AsmFunction[] src)
            => Content = src;
        
        public AsmFunction[] Content {get;}

        public FiniteSeqFactory<AsmFunction, AsmFunctionList> Factory
            => Define;        
    }
}