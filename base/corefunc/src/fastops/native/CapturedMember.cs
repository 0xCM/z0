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
    public sealed class CapturedMember
    {        
        public static CapturedMember Empty => default;

        public static CapturedMember Define(Moniker id, MethodInfo src, MemoryRange origin, byte[] content, NativeCaptureInfo result)
            => new CapturedMember(id, src.Signature().Format(), null, src, origin, content, result);

        public static CapturedMember Define(Moniker id, Delegate src, MemoryRange origin, byte[] content, NativeCaptureInfo result)
            => new CapturedMember(id, id, src, src.Method, origin, content, result);

        [MethodImpl(Inline)]
        CapturedMember(Moniker id, string label, Delegate src, MethodInfo method, MemoryRange origin, byte[] content, NativeCaptureInfo result)
        {
            require((int)origin.Length == content.Length);
            this.Delegate = src;
            this.Method = method;
            this.Origin = origin;
            this.Code = AsmCode.Define(id, origin, label, content);
            this.CaptureInfo = result;
        }

        public Option<Delegate> Delegate;

        public MethodInfo Method {get;}

        public MemoryRange Origin {get;}

        public AsmCode Code {get;}

        public NativeCaptureInfo CaptureInfo {get;}

        public Moniker Id => Code.Id;

        public string Label => Code.Label;
         
        /// <summary>
        /// Defines the inclusive lower bound of the source location
        /// </summary>
        public ulong StartAddress 
            => Origin.Start;

        /// <summary>
        /// Defines the inclusive upper bound of source location
        /// </summary>
        public ulong EndAddress 
            => Origin.End;

        public ulong Length 
            => Origin.Length;

        public bool IsEmpty 
            => Length == 0;

        public CapturedMember Replicate()
            => new CapturedMember(Id, Label, Delegate.ValueOrDefault(), Method, Origin, Code.Encoded.Replicate(), CaptureInfo);
    }
}