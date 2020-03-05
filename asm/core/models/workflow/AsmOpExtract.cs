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
    ///  Defines the dataset accumulated for an operation-targeted capture workflow
    /// </summary>
    public readonly struct AsmOpExtract
    {        
        public readonly OpIdentity Id; 

        public readonly OpDescriptor Operation;

        public readonly AsmCode Code;
        
        public readonly CaptureTermCode TermCode;

        public readonly MemoryEncoding RawBits {get;}
                
        public readonly MethodInfo Method;

        public static AsmOpExtract Empty => default;

        [MethodImpl(Inline)]
        public static AsmOpExtract Define(OpIdentity id, MethodInfo src, MemoryRange memsrc, AsmCaptureBits bits, CaptureTermCode term)
            => new AsmOpExtract(id, src.Signature().Format(), null, src, memsrc, bits, term);

        [MethodImpl(Inline)]
        public static AsmOpExtract Define(OpIdentity id, Delegate src, MemoryRange memsrc, AsmCaptureBits bits, CaptureTermCode term)
            => new AsmOpExtract(id, id, src, src.Method, memsrc, bits, term);

        [MethodImpl(Inline)]
        AsmOpExtract(OpIdentity id, string label, Delegate src, MethodInfo method, MemoryRange memsrc, AsmCaptureBits bits, CaptureTermCode term)
        {
            require((int)memsrc.Length == bits.Parsed.Length);    
            this.Id = id;        
            this.Code = AsmCode.Define(id, bits.Parsed);
            this.Operation = OpDescriptor.Define(OpUri.Hex(ApiHostUri.FromHost(method.DeclaringType), method.Name, id), method.Signature().Format());
            this.Method = method;
            this.TermCode = term;
            this.RawBits = bits.Raw;
        }

        public readonly MemoryRange AddressRange    
            => Code.AddressRange;        
    }
}