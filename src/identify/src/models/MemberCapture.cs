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
    public readonly struct MemberCapture
    {        
        public static MemberCapture Empty => default;

        public readonly OpUri Uri;

        public readonly OpIdentity OpId; 

        public readonly MethodInfo SourceMember;
        
        public readonly ExtractTermCode TermCode;

        public readonly LocatedCode Extracted;

        public readonly LocatedCode Parsed;
                
        [MethodImpl(Inline)]
        public static MemberCapture Define(OpIdentity id, MethodInfo method, LocatedCode extracted, LocatedCode parsed, ExtractTermCode term)
            => new MemberCapture(id, method, extracted, parsed, term);

        [MethodImpl(Inline)]
        public static MemberCapture Define(OpIdentity id, Delegate src, MethodInfo method, LocatedCode extracted, LocatedCode parsed, ExtractTermCode term)
            => new MemberCapture(id, src, method, extracted, parsed, term);

        [MethodImpl(Inline)]
        MemberCapture(OpIdentity id, MethodInfo method, LocatedCode extracted, LocatedCode parsed, ExtractTermCode term)
        {
            OpId = id;        
            SourceMember = method;
            Extracted = extracted;            
            Parsed = parsed;
            Uri = OpUri.hex(ApiHostUri.FromHost(method.DeclaringType), method.Name, id);
            TermCode = term;
        }

        [MethodImpl(Inline)]
        MemberCapture(OpIdentity id, Delegate src, MethodInfo method, LocatedCode extracted, LocatedCode parsed, ExtractTermCode term)
        {
            Extracted = extracted; 
            Parsed = parsed;
            SourceMember = method;
            OpId = id;        
            Uri = OpUri.hex(ApiHostUri.FromHost(method.DeclaringType), method.Name, id);
            TermCode = term;
        }

        public OperationBits Code 
            => OperationBits.Define(OpId, Parsed);

        public readonly MemoryRange AddressRange    
            => Code.Location;        

        public MethodSig OpSig
            => SourceMember.Signature();
    }
}