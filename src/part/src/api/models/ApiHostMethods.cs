//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Root;

    /// <summary>
    /// Defines a catalog over <see cref='ApiMember'/> values for a specified <see cref='IApiHost'/>
    /// </summary>
    public readonly struct ApiHostMethods : IIndex<MethodInfo>
    {
        public IApiHost Host {get;}

        public MethodInfo[] Storage {get;}

        [MethodImpl(Inline)]
        public ApiHostMethods(IApiHost host, MethodInfo[] src)
        {
            Host = host;
            Storage = src;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Storage?.Length ?? 0;
        }

        public uint OpCount
        {
            [MethodImpl(Inline)]
            get => (uint)Length;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Length == 0;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => !IsEmpty;
        }

        public ReadOnlySpan<ClrMethodAdapter> View
        {
            [MethodImpl(Inline)]
            get => memory.recover<MethodInfo,ClrMethodAdapter>(memory.@readonly(Storage));
        }

        public static ApiHostMethods Empty
        {
            [MethodImpl(Inline)]
            get => new ApiHostMethods(ApiHost.Empty, Array.Empty<MethodInfo>());
        }

        [MethodImpl(Inline)]
        public static implicit operator MethodInfo[](ApiHostMethods src)
            => src.Storage;
    }
}