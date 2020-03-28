//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
 
    using static root;

    /// <summary>
    ///  Defines the dataset accumulated for an operation-targeted capture workflow
    /// </summary>
    public readonly struct CapturedOp
    {        
        public readonly OpIdentity Id; 

        public readonly ApiMemberInfo Operation;

        public readonly AsmCode Code;
        
        public readonly ExtractTermCode TermCode;

        public readonly MemoryExtract RawBits {get;}
                
        public readonly MethodInfo Method;

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
            this.Id = id;        
            this.Code = AsmCode.Define(id, bits.Parsed);
            this.Operation = ApiMemberInfo.Define(OpUri.hex(ApiHostUri.FromHost(method.DeclaringType), method.Name, id), method.Signature().Format());
            this.Method = method;
            this.TermCode = term;
            this.RawBits = bits.Source;            
        }

        public readonly MemoryRange AddressRange    
            => Code.AddressRange;        
    }

    public readonly struct CapturedOps : IFiniteSeq<CapturedOp>
    {
        [MethodImpl(Inline)]
        public static implicit operator CapturedOps(CapturedOp[] src)
            => new CapturedOps(src);
        
        [MethodImpl(Inline)]
        public CapturedOps(CapturedOp[] content)
        {
            this.Content = content;
        }
        
        public CapturedOp[] Content {get;}
    }    
}