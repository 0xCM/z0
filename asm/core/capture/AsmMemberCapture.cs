//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
 
    using static Root;

    /// <summary>
    ///  Encapsulates all aspects of a member capture operation
    /// </summary>
    public readonly struct AsmMemberCapture
    {        
        public readonly OpIdentity Id; 

        public readonly OpDescriptor Operation;

        public readonly AsmCode Code;
        
        public readonly CaptureTermCode TermCode;

        public readonly EncodedData RawBits {get;}
                
        public readonly MethodInfo Method;

        public static AsmMemberCapture Empty => default;

        [MethodImpl(Inline)]
        public static AsmMemberCapture Define(OpIdentity id, MethodInfo src, MemoryRange memsrc, AsmCaptureBits bits, CaptureTermCode term)
            => new AsmMemberCapture(id, src.Signature().Format(), null, src, memsrc, bits, term);

        [MethodImpl(Inline)]
        public static AsmMemberCapture Define(OpIdentity id, Delegate src, MemoryRange memsrc, AsmCaptureBits bits, CaptureTermCode term)
            => new AsmMemberCapture(id, id, src, src.Method, memsrc, bits, term);

        [MethodImpl(Inline)]
        AsmMemberCapture(OpIdentity id, string label, Delegate src, MethodInfo method, MemoryRange memsrc, AsmCaptureBits bits, CaptureTermCode term)
        {
            require((int)memsrc.Length == bits.Parsed.Length);    
            this.Id = id;        
            this.Code = AsmCode.Define(id, bits.Parsed);
            this.Operation = OpDescriptor.Define(OpUri.Hex(ApiHostPath.FromHost(method.DeclaringType), method.Name, id), method.Signature().Format());
            this.Method = method;
            this.TermCode = term;
            this.RawBits = bits.Raw;
        }

        public readonly MemoryRange AddressRange    
            => Code.AddressRange;        
    }
}