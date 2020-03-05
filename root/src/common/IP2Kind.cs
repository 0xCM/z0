//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Root;

    public interface IP2Kind<T>
        where T : IP2Kind<T>
    {
        byte Exponent {get;}

        ulong Value {get;}
    }

    public interface IP2m1Kind<T> : IP2Kind<T>
        where T : IP2Kind<T>
    {

    }


}