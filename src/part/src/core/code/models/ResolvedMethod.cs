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

    public readonly struct ResolvedMethod : ITextual, IComparable<ResolvedMethod>
    {
        public OpUri Uri {get;}

        public MethodInfo Method {get;}

        public MemoryAddress EntryPoint {get;}

        [MethodImpl(Inline)]
        public ResolvedMethod(OpUri uri, MethodInfo method, MemoryAddress address)
        {
            Uri = uri;
            Method = method;
            EntryPoint = address;
        }

        [MethodImpl(Inline)]
        public ResolvedMethod(MethodInfo method, OpUri uri, MemoryAddress address)
        {
            Uri = uri;
            Method = method;
            EntryPoint = address;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Method is null;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => !IsEmpty;
        }

        public Assembly Component
        {
            [MethodImpl(Inline)]
            get => HostType.Assembly;
        }

        public Type HostType
        {
            [MethodImpl(Inline)]
            get => Method.DeclaringType;
        }

        public ApiMember ToApiMember()
            => new ApiMember(Uri, Method, EntryPoint);

        public string Format()
            => IsEmpty ? "<empty>" : string.Format("{0}::{1}:{2}:{3}", EntryPoint.Format(), Component.Format(), HostType.Format(), Method.DisplaySig());


        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public int CompareTo(ResolvedMethod src)
            => EntryPoint.CompareTo(src.EntryPoint);
    }
}