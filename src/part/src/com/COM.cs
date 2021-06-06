//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;


    public readonly partial struct COM
    {
        public interface IVTable
        {

        }

        public interface IVTable<T> : IVTable
            where T : unmanaged, IVTable<T>
        {

        }

        public readonly struct IUnknownVTable : IVTable<IUnknownVTable>
        {
            public const string Identifier = "00000000-0000-0000-C000-000000000046";

            [Free]
            unsafe delegate HResult QueryInterfaceD(void* pSrc, Guid id, out void* pDst);

            [Free]
            unsafe delegate ulong AddRefD(void* pSrc);

            [Free]
            unsafe delegate ulong ReleaseD(void* pSrc);
        }
    }
}