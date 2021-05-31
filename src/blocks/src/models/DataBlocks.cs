//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct DataBlock1<T> : IDataBlock<DataBlock1<T>>
        where T : unmanaged
    {
        T Data;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DataBlock2<T> : IDataBlock<DataBlock2<T>>
        where T : unmanaged
    {
        DataBlock1<T> A;

        DataBlock1<T> B;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DataBlock3<T> : IDataBlock<DataBlock3<T>>
        where T : unmanaged
    {
        DataBlock1<T> A;

        DataBlock2<T> B;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DataBlock4<T> : IDataBlock<DataBlock4<T>>
        where T : unmanaged
    {
        DataBlock2<T> A;

        DataBlock2<T> B;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DataBlock5<T> : IDataBlock<DataBlock5<T>>
        where T : unmanaged
    {
        DataBlock4<T> A;

        DataBlock1<T> B;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DataBlock6<T> : IDataBlock<DataBlock6<T>>
        where T : unmanaged
    {
        DataBlock3<T> A;

        DataBlock3<T> B;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DataBlock7<T> : IDataBlock<DataBlock7<T>>
        where T : unmanaged
    {
        DataBlock6<T> A;

        DataBlock1<T> B;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DataBlock8<T> : IDataBlock<DataBlock8<T>>
        where T : unmanaged
    {
        DataBlock4<T> A;

        DataBlock4<T> B;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DataBlock9<T> : IDataBlock<DataBlock9<T>>
        where T : unmanaged
    {
        DataBlock8<T> A;

        DataBlock1<T> B;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DataBlock10<T> : IDataBlock<DataBlock10<T>>
        where T : unmanaged
    {
        DataBlock8<T> A;

        DataBlock2<T> B;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DataBlock11<T> : IDataBlock<DataBlock11<T>>
        where T : unmanaged
    {
        DataBlock10<T> A;

        DataBlock1<T> B;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DataBlock12<T> : IDataBlock<DataBlock12<T>>
        where T : unmanaged
    {
        DataBlock6<T> A;

        DataBlock6<T> B;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DataBlock16<T> : IDataBlock<DataBlock16<T>>
        where T : unmanaged
    {
        DataBlock8<T> A;

        DataBlock8<T> B;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DataBlock32<T> : IDataBlock<DataBlock32<T>>
        where T : unmanaged
    {
        DataBlock16<T> A;

        DataBlock16<T> B;
    }
}