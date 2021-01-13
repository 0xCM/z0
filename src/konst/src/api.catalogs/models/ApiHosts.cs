//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Part;
    using static z;

    public readonly struct ApiHosts : IIndexedView<ApiHosts,uint,IApiHost>
    {
        readonly IApiHost[] Data;

        [MethodImpl(Inline)]
        public ApiHosts(IApiHost[] src)
            => Data = src;

        public uint Count
        {
            [MethodImpl(Inline)]
            get => (uint)(Data?.Length ?? 0);
        }

        public ReadOnlySpan<IApiHost> View
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public ref readonly IApiHost First
        {
            [MethodImpl(Inline)]
            get => ref Data[0];
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Count == 0;
        }

        public IApiHost[] Storage
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        [MethodImpl(Inline)]
        public bool Host(Type t, out IApiHost host)
        {   var count = Count;
            for(var i=0; i<count; i++)
            {
                var terms = @readonly(Data);
                ref readonly var candidate = ref skip(terms,i);
                if(candidate.GetType() == t)
                {
                    host = candidate;
                    return true;
                }
            }
            host = null;
            return false;
        }

        public string Format()
            => Seq.format(Storage);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator ApiHosts(IApiHost[] src)
            => new ApiHosts(src);

        [MethodImpl(Inline)]
        public static implicit operator IApiHost[](ApiHosts src)
            => src.Data;
    }
}