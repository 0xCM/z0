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

    abstract class NativeMemberData<S> : INativeMemberData
    {
        protected NativeMemberData(S source, MethodInfo method, MemoryRange location, byte[] content)
        {
            require((int)location.Length == content.Length);
            this.Source = source;
            this.Method = method;
            this.Location = location;
            this.Code = AsmCode.Define(OpIdentity.Provider.Define(method), method.Signature().Format(), content);
        }

        public S Source {get;}

        public MethodInfo Method {get;}

        public MemoryRange Location {get;}

        public AsmCode Code {get;}
    }
}