//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct DataBlock01<T> : IDataBlock<DataBlock01<T>>
        where T : unmanaged
    {
        T Data;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DataBlock02<T> : IDataBlock<DataBlock02<T>>
        where T : unmanaged
    {
        DataBlock01<T> A;

        DataBlock01<T> B;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DataBlock03<T> : IDataBlock<DataBlock03<T>>
        where T : unmanaged
    {
        DataBlock01<T> A;

        DataBlock02<T> B;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DataBlock04<T> : IDataBlock<DataBlock04<T>>
        where T : unmanaged
    {
        DataBlock02<T> A;

        DataBlock02<T> B;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DataBlock05<T> : IDataBlock<DataBlock05<T>>
        where T : unmanaged
    {
        DataBlock04<T> A;

        DataBlock01<T> B;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DataBlock06<T> : IDataBlock<DataBlock06<T>>
        where T : unmanaged
    {
        DataBlock03<T> A;

        DataBlock03<T> B;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DataBlock07<T> : IDataBlock<DataBlock07<T>>
        where T : unmanaged
    {
        DataBlock06<T> A;

        DataBlock01<T> B;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DataBlock08<T> : IDataBlock<DataBlock08<T>>
        where T : unmanaged
    {
        DataBlock04<T> A;

        DataBlock04<T> B;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DataBlock12<T> : IDataBlock<DataBlock12<T>>
        where T : unmanaged
    {
        DataBlock06<T> A;

        DataBlock06<T> B;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DataBlock16<T> : IDataBlock<DataBlock16<T>>
        where T : unmanaged
    {
        DataBlock08<T> A;

        DataBlock08<T> B;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DataBlock32<T> : IDataBlock<DataBlock32<T>>
        where T : unmanaged
    {
        DataBlock16<T> A;

        DataBlock16<T> B;
    }
}