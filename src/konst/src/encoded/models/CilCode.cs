//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct CilCode
    {
        public readonly string Name;

        public readonly BinaryCode Data;

        public readonly MethodImplAttributes ImplSpec;

        [MethodImpl(Inline)]
        public static CilCode define(string name, byte[] data, MethodImplAttributes attribs)
            => new CilCode(name,data,attribs);

        [MethodImpl(Inline)]
        public CilCode(string name, byte[] data, MethodImplAttributes impl)
        {
            Name = name;
            Data = data;
            ImplSpec = impl;
        }
    }
}