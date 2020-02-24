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

        public readonly OpDescriptor SourceOp;

        public readonly MemoryRange SourceMemory;

        public readonly AsmCode Code;
        
        public readonly CaptureOutcome Outcome;

        public readonly byte[] RawBits {get;}
                
        public readonly MethodInfo Method;

        public static CapturedMember Empty => default;

        [MethodImpl(Inline)]
        public static CapturedMember Define(OpIdentity id, MethodInfo src, MemoryRange memsrc, CaptureBits bits, CaptureOutcome result)
            => new CapturedMember(id, src.Signature().Format(), null, src, memsrc, bits, result);

        [MethodImpl(Inline)]
        public static CapturedMember Define(OpIdentity id, Delegate src, MemoryRange memsrc, CaptureBits bits, CaptureOutcome result)
            => new CapturedMember(id, id, src, src.Method, memsrc, bits, result);

        [MethodImpl(Inline)]
        CapturedMember(OpIdentity id, string label, Delegate src, MethodInfo method, MemoryRange memsrc, CaptureBits bits, CaptureOutcome result)
        {
            require((int)memsrc.Length == bits.Trimmed.Length);    
            this.Id = id;        
            this.SourceOp = OpDescriptor.Define(OpUri.Hex(ApiHostPath.FromHost(method.DeclaringType), method.Name, id), method.Signature().Format());
            this.Method = method;
            this.SourceMemory = memsrc;
            this.Code = AsmCode.Define(id, memsrc, bits.Trimmed);
            this.Outcome = result;
            this.RawBits = bits.Raw;
        }
                     
        public ulong Length 
            => SourceMemory.Length;

        public bool IsEmpty 
            => Length == 0;
    }
}