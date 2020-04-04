//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Types
{
    public interface location
    {

    }
    public interface relative : location
    {
        
    }

    public interface relative<T> : relative
        where T : unmanaged
    {
        T offset {get;}
    }

    public interface absolute : location
    {
        
    }

    public interface absolute<T> : absolute
        where T : unmanaged
    {
        T address {get;}        
    }

    public interface offset
    {
        
    }

    public interface offset<W> : offset
        where W : unmanaged, ITypeWidth
    {
        
    }

    public interface offset8 : offset<W8>
    {

    }

    public interface offset16 : offset<W16>
    {
        
    }

    public interface offset32 : offset<W32>
    {
        
    }

    public interface offset64 : offset<W64>
    {
        
    }

    public interface ishort
    {
        
    }    

    public interface near
    {
        
    }

    public interface near<W>
        where W : unmanaged, ITypeWidth
    {
        
    }

    public interface far
    {
        
    }


}