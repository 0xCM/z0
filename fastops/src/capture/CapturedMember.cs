//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Linq;
    using System.Runtime.CompilerServices;
 
    using static zfunc;    

    /// <summary>
    ///  Encapsulates all aspects of a member capture operation
    /// </summary>
    public readonly struct CapturedMember
    {        
        public readonly OpIdentity Id; 

        public readonly OpDescriptor Operation;

        public readonly AsmCode Code;
        
        public readonly CaptureTermCode TermCode;

        public readonly byte[] RawBits {get;}
                
        public readonly MethodInfo Method;

        public static CapturedMember Empty => default;

        [MethodImpl(Inline)]
        public static CapturedMember Define(OpIdentity id, MethodInfo src, MemoryRange memsrc, CaptureBits bits, CaptureTermCode term)
            => new CapturedMember(id, src.Signature().Format(), null, src, memsrc, bits, term);

        [MethodImpl(Inline)]
        public static CapturedMember Define(OpIdentity id, Delegate src, MemoryRange memsrc, CaptureBits bits, CaptureTermCode term)
            => new CapturedMember(id, id, src, src.Method, memsrc, bits, term);

        [MethodImpl(Inline)]
        CapturedMember(OpIdentity id, string label, Delegate src, MethodInfo method, MemoryRange memsrc, CaptureBits bits, CaptureTermCode term)
        {
            require((int)memsrc.Length == bits.Trimmed.Length);    
            this.Id = id;        
            this.Code = AsmCode.Define(id, EncodedData.Define(memsrc.Start, bits.Trimmed));
            this.Operation = OpDescriptor.Define(OpUri.Hex(ApiHostPath.FromHost(method.DeclaringType), method.Name, id), method.Signature().Format());
            this.Method = method;
            this.TermCode = term;
            this.RawBits = bits.Raw;
        }

        public readonly MemoryRange AddressRange    
            => Code.AddressRange;
        
    }
}