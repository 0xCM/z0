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
    /// Represents a contiguous block of memory that represents the machine code for a delate
    /// </summary>
    public sealed class NativeMemberCapture : INativeMemberData
    {        
        public static NativeMemberCapture Empty => default;

        public static NativeMemberCapture Define(Moniker id, MethodInfo src, MemoryRange location, byte[] content, CaptureResult result)
            => new NativeMemberCapture(id, src.Signature().Format(), null, src, location, content, result);

        public static NativeMemberCapture Define(Moniker id, Delegate src, MemoryRange location, byte[] content, CaptureResult result)
            => new NativeMemberCapture(id, id, src, src.Method, location, content, result);

        [MethodImpl(Inline)]
        NativeMemberCapture(Moniker id, string label, Delegate src, MethodInfo method, MemoryRange location, byte[] content, CaptureResult result)
        {
            require((int)location.Length == content.Length);
            this.Delegate = src;
            this.Method = method;
            this.Location = location;
            this.Code = AsmCode.Define(id, label, content);
            this.CaptureInfo = result;

        }

        public Option<Delegate> Delegate;

        public MethodInfo Method {get;}

        public MemoryRange Location {get;}

        public AsmCode Code {get;}

        public CaptureResult CaptureInfo {get;}

        /// <summary>
        /// Defines the inclusive lower bound of the source location
        /// </summary>
        public ulong StartAddress 
            => Location.Start;

        /// <summary>
        /// Defines the inclusive upper bound of source location
        /// </summary>
        public ulong EndAddress 
            => Location.End;

        public ulong Length 
            => Location.Length;

        public bool IsEmpty 
            => Length == 0;

        public Moniker Id 
            => Code.Id;

        public string Label 
            => Code.Label;
        
    }
}