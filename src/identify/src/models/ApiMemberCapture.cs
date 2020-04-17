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

    /// <summary>
    ///  Defines the dataset accumulated for an operation-targeted capture workflow
    /// </summary>
    public readonly struct ApiMemberCapture
    {        
        public static ApiMemberCapture Empty => default;

        public readonly OpUri Uri;

        public readonly OpIdentity OpId; 

        public readonly MethodInfo SourceMember;
        
        public readonly ExtractTermCode TermCode;

        public readonly Addressable Extracted;

        public readonly Addressable Parsed;
                
        [MethodImpl(Inline)]
        public static ApiMemberCapture Define(OpIdentity id, MethodInfo method, Addressable extracted, Addressable parsed, ExtractTermCode term)
            => new ApiMemberCapture(id, method, extracted, parsed, term);

        [MethodImpl(Inline)]
        public static ApiMemberCapture Define(OpIdentity id, Delegate src, MethodInfo method, Addressable extracted, Addressable parsed, ExtractTermCode term)
            => new ApiMemberCapture(id, src, method, extracted, parsed, term);

        [MethodImpl(Inline)]
        ApiMemberCapture(OpIdentity id, MethodInfo method, Addressable extracted, Addressable parsed, ExtractTermCode term)
        {
            OpId = id;        
            SourceMember = method;
            Extracted = extracted;            
            Parsed = parsed;
            Uri = OpUri.hex(ApiHostUri.FromHost(method.DeclaringType), method.Name, id);
            TermCode = term;
        }

        [MethodImpl(Inline)]
        ApiMemberCapture(OpIdentity id, Delegate src, MethodInfo method, Addressable extracted, Addressable parsed, ExtractTermCode term)
        {
            Extracted = extracted; 
            Parsed = parsed;
            SourceMember = method;
            OpId = id;        
            Uri = OpUri.hex(ApiHostUri.FromHost(method.DeclaringType), method.Name, id);
            TermCode = term;
        }

        public ApiBits Code 
            => ApiBits.Define(OpId, Parsed);

        public readonly MemoryRange AddressRange    
            => Code.Location;        

        public MethodSig OpSig
            => SourceMember.Signature();
    }
}