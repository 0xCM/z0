//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Root;
    using static Typed;

    using Z0.Asm.Data;

    public readonly struct OpCodeEncoder
    {
        public static OpCodeEncoder Service() 
            => new OpCodeEncoder(0);
        
        readonly OpCodeTokens Tokens;

        readonly OpCodeRecord[] Records;
        
        OpCodeEncoder(int i)
        {
            Tokens = OpCodeServices.tokens();
            var resource = AsmD.Service.OpCodeSpecDoc;
            Records = new OpCodeRecord[resource.RowCount];
            CommandInfoParser.Service.Parse(resource, Records);
        }
        
        [MethodImpl(Inline)]
        public void Encode(Span<EncodedOpCode> dst)
        {
            var src = span(Records);
            for(var i=0; i<Records.Length; i++)
                seek(dst,i) = Encode(skip(src,i));
            
        }

        [MethodImpl(Inline)]
        public EncodedOpCode[] Encode()
        {
            var dst = alloc<EncodedOpCode>(Records.Length);
            Encode(dst);
            return dst;
        }
        

        [MethodImpl(Inline)]
        public EncodedOpCode Encode(in OpCodeRecord src)
        {
            ref readonly var code = ref src.OpCode;
            var lead = code[0,n4];
            return new EncodedOpCode((uint)lead);
        }
    }
}