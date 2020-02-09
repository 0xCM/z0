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
        public static CapturedMember Empty => default;

        public static CapturedMember Define(OpIdentity id, MethodInfo src, MemoryRange origin, byte[] content, CaptureOutcome result)
            => new CapturedMember(id, src.Signature().Format(), null, src, origin, content, result);

        public static CapturedMember Define(OpIdentity id, Delegate src, MemoryRange origin, byte[] content, CaptureOutcome result)
            => new CapturedMember(id, id, src, src.Method, origin, content, result);

        [MethodImpl(Inline)]
        CapturedMember(OpIdentity id, string label, Delegate src, MethodInfo method, MemoryRange origin, byte[] content, CaptureOutcome result)
        {
            require((int)origin.Length == content.Length);
            this.Delegate = src;
            this.Method = method;
            this.Origin = origin;
            this.Code = AsmCode.Define(id, origin, label, content);
            this.Outcome = result;
        }

        public readonly Option<Delegate> Delegate;

        public readonly MethodInfo Method;

        public readonly MemoryRange Origin;

        public readonly AsmCode Code;

        public readonly CaptureOutcome Outcome;

        public OpIdentity Id 
            => Code.Id;

        public string Label 
            => Code.Label;
         
        public ulong Length 
            => Origin.Length;

        public bool IsEmpty 
            => Length == 0;

        public CapturedMember Replicate()
            => new CapturedMember(Id, Label, Delegate.ValueOrDefault(), Method, Origin, Code.Encoded.Replicate(), Outcome);
    }
}