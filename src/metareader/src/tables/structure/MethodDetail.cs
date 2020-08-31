//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    public struct MethodDetail
    {
        public BinaryCode Sig;

        public string Name;

        public Address32 Rva;

        public MethodAttributes Attribs;

        public MethodImplAttributes ImplAttribs;
    }

}