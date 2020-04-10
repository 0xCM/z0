//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
 
    using static Seed;
    using static Memories;

    /// <summary>
    ///  Defines the dataset accumulated for an operation-targeted capture workflow
    /// </summary>
    public readonly struct CapturedOp
    {        
        public readonly OpUri Uri;

        public readonly OpIdentity OpId; 

        public readonly string OpSig;

        public readonly AsmCode Code;
        
        public readonly ExtractTermCode TermCode;

        public readonly MemoryExtract RawBits;
                
        public static CapturedOp Empty => default;

        [MethodImpl(Inline)]
        public static CapturedOp Define(OpIdentity id, MethodInfo src, MemoryRange memsrc, ParsedMemoryExtract bits, ExtractTermCode term)
            => new CapturedOp(id, src.Signature().Format(), null, src, memsrc, bits, term);

        [MethodImpl(Inline)]
        public static CapturedOp Define(OpIdentity id, DynamicDelegate src, MemoryRange memsrc, ParsedMemoryExtract bits, ExtractTermCode term)
            => new CapturedOp(id, id, src, src.SourceMethod, memsrc, bits, term);

        [MethodImpl(Inline)]
        public static CapturedOp Define(OpIdentity id, Delegate src, MemoryRange memsrc, ParsedMemoryExtract bits, ExtractTermCode term)
            => new CapturedOp(id, id, src, src.Method, memsrc, bits, term);

        [MethodImpl(Inline)]
        CapturedOp(OpIdentity id, string label, Delegate src, MethodInfo method, MemoryRange memsrc, ParsedMemoryExtract bits, ExtractTermCode term)
        {
            require((int)memsrc.Length == bits.Parsed.Length);    
            OpId = id;        
            Code = AsmCode.Define(id, bits.Parsed);
            Uri = OpUri.hex(ApiHostUri.FromHost(method.DeclaringType), method.Name, id);
            OpSig = method.Signature().Format();
            TermCode = term;
            RawBits = bits.Source;            
        }

        public readonly MemoryRange AddressRange    
            => Code.Location;        
    }
}