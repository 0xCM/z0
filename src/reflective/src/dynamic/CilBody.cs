//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Reflection.Emit;

    public readonly struct CilBody
    {
        public readonly string Name;

        public readonly byte[] Data;

        public readonly MethodImplAttributes ImplSpec;

        public static CilBody Define(string name, byte[] data, MethodImplAttributes attribs)
            => new CilBody(name,data,attribs);

        CilBody(string name, byte[] data, MethodImplAttributes impl)
        {
            this.Name = name;
            this.Data = data;
            this.ImplSpec = impl;
        }
    }
}