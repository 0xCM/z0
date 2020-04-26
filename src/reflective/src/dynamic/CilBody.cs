//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct CilBody
    {
        public readonly string Name;

        public readonly byte[] Data;

        public readonly MethodImplAttributes ImplSpec;

        [MethodImpl(Inline)]
        public static CilBody Define(string name, byte[] data, MethodImplAttributes attribs)
            => new CilBody(name,data,attribs);

        [MethodImpl(Inline)]
        CilBody(string name, byte[] data, MethodImplAttributes impl)
        {
            this.Name = name;
            this.Data = data;
            this.ImplSpec = impl;
        }
    }
}