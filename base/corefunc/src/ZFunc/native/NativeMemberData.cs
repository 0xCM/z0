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
        protected NativeMemberData(S source, MethodInfo method, AddressSegment location, byte[] content)
        {
            require((int)location.Length == content.Length);
            this.Source = source;
            this.Method = method;
            this.Location = location;
            this.Code = AsmCode.Define(content, Moniker.define(method), method.Signature().Format());
        }

        public S Source {get;}

        public MethodInfo Method {get;}

        public AddressSegment Location {get;}

        public AsmCode Code {get;}

        // public int Length 
        //     => (int)Location.Length;

        // public bool IsEmpty 
        //     => Code.IsEmpty;

        // public ulong StartAddress 
        //     => Location.Start;

        // public ulong EndAddress 
        //     => Location.End;
 
    }

    public interface INativeMemberData
    {
        /// <summary>
        /// The deconstructed method
        /// </summary>
        MethodInfo Method {get;}

        /// <summary>
        /// The location of the member data relative to the native source
        /// </summary>
        AddressSegment Location {get;}
            
        /// <summary>
        /// The memory content
        /// </summary>
        AsmCode Code {get;}

        /// <summary>
        /// Defines the inclusive lower bound of the block
        /// </summary>
        ulong StartAddress 
            => Location.Start;

        /// <summary>
        /// Defines the inclusive upper bound of the block
        /// </summary>
        ulong EndAddress 
            => Location.End;

        ulong Length 
            => EndAddress -StartAddress;        

        bool IsEmpty 
            => Length == 0;

        Moniker Id 
            => Code.Id;

        string Label 
            => Code.Label;

    }

}