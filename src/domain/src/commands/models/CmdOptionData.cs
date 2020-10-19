//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Konst;
    using static z;

    [StructLayout(LayoutKind.Sequential)]
    public struct CmdOptionData
    {
        public asci32 Id;

        public string Value;
    }


    [StructLayout(LayoutKind.Sequential)]
    public struct CmdOptionData<T>
    {
        public asci32 Id;

        public T Value;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CmdOptionData<K,T>
    {
        public K Id;

        public T Value;
    }
}