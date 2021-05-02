//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IApiClass : ITextual
    {
        ApiClassKind ClassId {get;}

        string ITextual.Format()
            => ClassId.ToString().ToLower();
    }

    public interface IApiClass<K> : IApiClass
        where K : unmanaged
    {
        K Kind  {get;}

        ApiClassKind IApiClass.ClassId
            => Root.@as<K,ApiClassKind>(Kind);
    }
}