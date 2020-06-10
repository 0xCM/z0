//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class Control
    {
        [MethodImpl(Inline), Op]
        public static void require(bool invariant)
        {
            if(!invariant)
                ThrowInvariantFailure();
        }

        [MethodImpl(Inline), Op]
        public static void require(bool invariant, string msg)
        {
            if(!invariant)
                ThrowInvariantFailure(msg);
        }        

        public static T require<T>(T src)
            where T : class
        {
            if(src == null)
                ThrowNullRefError<T>();
            return src;
        }

        static void ThrowInvariantFailure(string msg)
            => throw new Exception($"Application invaraiant failed: {msg}");

        static void ThrowInvariantFailure()
            => throw new Exception($"Application invaraiant failed");

        static void ThrowNullRefError<T>()
            => throw new NullReferenceException($"Application nullity invaraiant failed for {typeof(T)}");
    }
}