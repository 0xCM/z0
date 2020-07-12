//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;


    partial struct Konst
    {
        [MethodImpl(Inline)]
        internal static ref readonly T view<S,T>(in S src)
            => ref Unsafe.As<S,T>(ref Unsafe.AsRef(src));                
         
        [MethodImpl(Inline), Op]
        public static void Require(bool invariant)
        {
            if(!invariant)
                ThrowInvariantFailure();
        }

        [MethodImpl(Inline), Op]
        public static void Require(bool invariant, string msg)
        {
            if(!invariant)
                ThrowInvariantFailure(msg);
        }        

        [MethodImpl(Inline)]
        public static T Require<T>(T src)
            where T : class
        {
            if(src == null)
                ThrowNullRefError<T>();
            return src;
        }
    }
}