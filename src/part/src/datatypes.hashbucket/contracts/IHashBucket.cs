//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IHashBucket<K,V>
        where K : unmanaged, IHashCode
    {
        K Key {get;}

        V Value {get;}

        bool IsEmpty {get;}

        IHashBucket<K,V> Next {get;}
    }
}