//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Konst;

    /// <summary>
    /// Defines and index over <see cref='ApiMember'/> values for a specified <see cref='IApiHost'/>
    /// </summary>
    public readonly struct ApiHostMembers : ITableSpan<ApiMember>
    {
        public IApiHost Host {get;}

        readonly TableSpan<ApiMember> Data;

        [MethodImpl(Inline)]
        public ApiHostMembers(IApiHost host, params ApiMember[] src)
        {
            Host = host;
            Data = src;
        }

        public Count Count
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        public ReadOnlySpan<ApiMember> Members
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        public ApiMember[] Storage
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public ref ApiMember this[long index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public ref ApiMember this[ulong index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }
    }
}