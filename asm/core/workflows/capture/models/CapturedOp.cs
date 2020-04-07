//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
 
    using static Core;

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
        public static CapturedOp Define(OpIdentity id, Delegate src, MemoryRange memsrc, ParsedMemoryExtract bits, ExtractTermCode term)
            => new CapturedOp(id, id, src, src.Method, memsrc, bits, term);

        [MethodImpl(Inline)]
        CapturedOp(OpIdentity id, string label, Delegate src, MethodInfo method, MemoryRange memsrc, ParsedMemoryExtract bits, ExtractTermCode term)
        {
            require((int)memsrc.Length == bits.Parsed.Length);    
            this.OpId = id;        
            this.Code = AsmCode.Define(id, bits.Parsed);
            this.Uri = OpUri.hex(ApiHostUri.FromHost(method.DeclaringType), method.Name, id);
            this.OpSig = method.Signature().Format();
            this.TermCode = term;
            this.RawBits = bits.Source;            
        }

        public readonly MemoryRange AddressRange    
            => Code.Location;        
    }
}