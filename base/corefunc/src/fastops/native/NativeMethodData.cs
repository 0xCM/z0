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
    /// Represents a contiguous block of memory that represents native data that defines a method
    /// </summary>
    public sealed class NativeMethodData :  INativeMemberData
    {        
        public static NativeMethodData Empty => default;

        public static NativeMethodData Define(Moniker id, MethodInfo src, MemoryRange location, byte[] content, CaptureResult result)
            => new NativeMethodData(id, src, location, content, result);

        [MethodImpl(Inline)]
        NativeMethodData(Moniker id, MethodInfo src, MemoryRange location, byte[] content, CaptureResult result)
        {
            require((int)location.Length == content.Length);
            this.Method = src;
            this.Location = location;
            this.Code = AsmCode.Define(id, src.Signature().Format(), content);
            this.CaptureInfo = result;

        }

        public MethodInfo Method {get;}

        public MemoryRange Location {get;}

        public AsmCode Code {get;}

        public CaptureResult CaptureInfo {get;}

    }
}