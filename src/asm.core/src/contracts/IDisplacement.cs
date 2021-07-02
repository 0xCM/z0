//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IDisplacement
    {
        uint Value {get;}

        //MemoryScale Scale {get;}

        byte Width {get;}
    }

    [Free]
    public interface IDisplacement<T> : IDisplacement
        where T : unmanaged
    {
        new T Value {get;}

        byte IDisplacement.Width
            => core.width<T>();

        uint IDisplacement.Value
            => core.bw32(Value);
    }

    [Free]
    public interface IDisplacement<H,T> : IDisplacement<T>
        where T : unmanaged
        where H : unmanaged, IDisplacement<H,T>
    {

    }
}