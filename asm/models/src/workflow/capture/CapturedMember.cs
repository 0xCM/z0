//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
 
    using static Seed;
    using static Memories;
    using Z0.Asm;

    /// <summary>
    ///  Defines the dataset accumulated for an operation-targeted capture workflow
    /// </summary>
    public readonly struct CapturedMember
    {        
        public static CapturedMember Empty => default;

        public readonly OpUri Uri;

        public readonly OpIdentity OpId; 

        public readonly MethodInfo SourceMember;
        
        public readonly ExtractTermCode TermCode;

        public readonly MemoryExtract Extracted;

        public readonly MemoryExtract Parsed;
                
        [MethodImpl(Inline)]
        public static CapturedMember Define(OpIdentity id, MethodInfo src, ParsedMemoryExtract bits, ExtractTermCode term)
            => new CapturedMember(id, null, src, bits, term);

        [MethodImpl(Inline)]
        public static CapturedMember Define(OpIdentity id, DynamicDelegate src, ParsedMemoryExtract bits, ExtractTermCode term)
            => new CapturedMember(id, src, src.SourceMethod, bits, term);

        [MethodImpl(Inline)]
        public static CapturedMember Define(OpIdentity id, Delegate src, ParsedMemoryExtract bits, ExtractTermCode term)
            => new CapturedMember(id, src, src.Method, bits, term);

        [MethodImpl(Inline)]
        public static CapturedMember Define(OpIdentity id, MethodInfo method, MemoryExtract extracted, MemoryExtract parsed, ExtractTermCode term)
            => new CapturedMember(id, method, extracted, parsed, term);

        [MethodImpl(Inline)]
        CapturedMember(OpIdentity id, MethodInfo method, MemoryExtract extracted, MemoryExtract parsed, ExtractTermCode term)
        {
            OpId = id;        
            SourceMember = method;
            Extracted = extracted;            
            Parsed = parsed;
            Uri = OpUri.hex(ApiHostUri.FromHost(method.DeclaringType), method.Name, id);
            TermCode = term;
        }

        [MethodImpl(Inline)]
        CapturedMember(OpIdentity id, Delegate src, MethodInfo method, ParsedMemoryExtract bits, ExtractTermCode term)
        {
            Extracted = bits.Source;            
            Parsed = bits.Parsed;
            SourceMember = method;
            OpId = id;        
            Uri = OpUri.hex(ApiHostUri.FromHost(method.DeclaringType), method.Name, id);
            TermCode = term;
        }

        public AsmCode Code 
            => AsmCode.Define(OpId, Parsed);

        public readonly MemoryRange AddressRange    
            => Code.Location;        

        public MethodSig OpSig
            => SourceMember.Signature();
    }
}