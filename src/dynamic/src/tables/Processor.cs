//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Runtime.InteropServices;

    public readonly struct Processor<T>
    {
        public static void Process(in T src, ref T dst)
        {

        }

    }

    public readonly struct Processor<S,T>
    {
        public static void Process(in S src, ref T dst)
        {

        }

    }


    public readonly struct DataDynamic
    {

    }
}