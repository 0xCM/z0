//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IDataType : ITextual
    {
        BitSize PhysicalWidth {get;}

        BitSize EffectiveWidth
            => PhysicalWidth;
    }

    [Free]
    public interface IDataType<T> : IDataType
        where T : struct
    {
        T Storage {get;}

        BitSize IDataType.PhysicalWidth
            => Unsafe.SizeOf<T>();

        string ITextual.Format()
            => Storage.ToString();
    }

    [Free]
    public interface IDataType<H,T> : IDataType<T>
        where T : struct
        where H : struct, IDataType<H,T>
    {

    }
}