//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;

    using static Konst;
    using static Memories;

    public class t_tokens : t_asmd<t_tokens>
    {
        
        public void opcode_resource_doc()
        {
            const char TextDelimiter = Chars.Pipe;
            var svc = AsmD.Service;
            var count1 = svc.OpCodeSpecDoc.CharCount(TextDelimiter);
            var count2 = Symbolic.count(svc.OpCodeSpecText, 1, TextDelimiter);
            Claim.eq(count1,count2);
        }

        string Format<S>(Symbol<S> symbol)
            where S : unmanaged, Enum
        {
            return symbol.Value.ToString();
        }
        
        public void symbolic_digits()
        {
            var symbols = octet.Symbols;
            var dstPath = CasePath($"octets");
            using var writer = dstPath.Writer();
            for(var i=0; i<symbols.Count; i++)
            {
                ref readonly var s = ref symbols[i];
                writer.WriteLine(Format(s.Simplified));
            }            
           
        }
    }
}