//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Seed;

    partial class Control
    {
        public static void require(bool invariant)
        {
            if(!invariant)
                throw new Exception($"Application invaraiant failed");
        }

        public static T require<T>(T src)
            where T : class
        {
            if(src == null)
                throw new NullReferenceException($"Application nullity invaraiant failed for {typeof(T)}");
            return src;
        }

        public static void require(bool invariant, string msg)
        {
            if(!invariant)
                throw new Exception($"Application invaraiant failed: {msg}");
        }        
    }
}