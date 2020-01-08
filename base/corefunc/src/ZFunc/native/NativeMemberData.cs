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
            this.Content = content;

        }

        public S Source {get;}

        public MethodInfo Method {get;}

        public AddressSegment Location {get;}

        public byte[] Content {get;}

        public int Length => (int)Location.Length;

        public bool IsEmpty  => Content.Length == 0;

        public ulong StartAddress => Location.Start;

        public ulong EndAddress => Location.End;

        public Moniker Identity => Moniker.define(Method);

        /// <summary>
        /// Queries/manipulates a content byte
        /// </summary>
        public ref byte this[int i]
        {
            [MethodImpl(Inline)]
            get => ref Content[i];
        }
 
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
        byte[] Content {get;}

        /// <summary>
        /// Queries/manipulates a content byte
        /// </summary>
        ref byte this[int i] {get;}

        Moniker Identity
            => Moniker.define(Method);

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
    }

}