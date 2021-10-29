//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Strings;


    public sealed class StringDb
    {
        public static StringDb Service => Instance;


        StringDb()
        {


        }

        static StringDb()
        {
            Instance = new StringDb();
        }

        static readonly StringDb Instance;
    }
}