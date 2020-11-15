//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Reflection;

    using static Konst;

    /// <summary>
    /// Defines a catalog over <see cref='ApiMember'/> values for a specified <see cref='IApiHost'/>
    /// </summary>
    public readonly struct ApiHostMethods
    {
        [MethodImpl(Inline)]
        public static ApiHostMethods create(IApiHost host, params MethodInfo[] src)
            => new ApiHostMethods(host, src);

        public IApiHost Host {get;}

        public Index<MethodInfo> Methods {get;}

        [MethodImpl(Inline)]
        public ApiHostMethods(IApiHost host, MethodInfo[] src)
        {
            Host = host;
            Methods = src;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Methods.IsEmpty;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Methods.IsNonEmpty;
        }

        public static ApiHostMethods Empty
        {
            [MethodImpl(Inline)]
            get => new ApiHostMethods(ApiHost.Empty, Array.Empty<MethodInfo>());
        }

        [MethodImpl(Inline)]
        public static implicit operator MethodInfo[](ApiHostMethods src)
            => src.Methods;
    }
}