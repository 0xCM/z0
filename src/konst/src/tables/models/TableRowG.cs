//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public struct TableRow<C0,C1,C2>
    {
        public C0 Col0;

        public C1 Col1;

        public C2 Col2;
    }

    public readonly ref struct TableRows<C0,C1,C2>
    {
        public readonly Span<TableRow<C0,C1,C2>> Data;

        [MethodImpl(Inline)]
        public TableRows(Span<TableRow<C0,C1,C2>> src)
        {
            Data = src;
        }

        public ref TableRow<C0,C1,C2> this[ulong index]
        {
            [MethodImpl(Inline)]
            get => ref seek(Data, index);
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => (uint)Data.Length;
        }
    }

    public struct TableRow<C0,C1,C2,C3>
    {
        public C0 Col0;

        public C1 Col1;

        public C2 Col2;

        public C3 Col3;
    }

    public readonly ref struct TableRows<T,C0,C1,C2>
    {
        public readonly Span<TableRow<T,C0,C1,C2>> Data;

        [MethodImpl(Inline)]
        public TableRows(Span<TableRow<T,C0,C1,C2>> src)
        {
            Data = src;
        }

        public ref TableRow<T,C0,C1,C2> this[ulong index]
        {
            [MethodImpl(Inline)]
            get => ref seek(Data, index);
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => (uint)Data.Length;
        }
    }

    public struct TableRow<C0,C1,C2,C3,C4>
    {
        public C0 Col0;

        public C1 Col1;

        public C2 Col2;

        public C3 Col3;

        public C4 Col4;

    }

    public readonly ref struct TableRows<T,C0,C1,C2,C3>
    {
        public readonly Span<TableRow<T,C0,C1,C2,C3>> Data;

        [MethodImpl(Inline)]
        public TableRows(Span<TableRow<T,C0,C1,C2,C3>> src)
        {
            Data = src;
        }

        public ref TableRow<T,C0,C1,C2,C3> this[ulong index]
        {
            [MethodImpl(Inline)]
            get => ref seek(Data, index);
        }


        public uint Count
        {
            [MethodImpl(Inline)]
            get => (uint)Data.Length;
        }

    }

    public struct TableRow<C0,C1,C2,C3,C4,C5>
    {
        public C0 Cell0;

        public C1 Cell1;

        public C2 Cell2;

        public C3 Cell3;

        public C4 Cell4;

        public C5 Source;
    }

    public readonly ref struct TableRows<T,C0,C1,C2,C3,C4>
    {
        public readonly Span<TableRow<T,C0,C1,C2,C3,C4>> Data;

        [MethodImpl(Inline)]
        public TableRows(Span<TableRow<T,C0,C1,C2,C3,C4>> src)
        {
            Data = src;
        }

        public ref TableRow<T,C0,C1,C2,C3,C4> this[ulong index]
        {
            [MethodImpl(Inline)]
            get => ref seek(Data, index);
        }


        public uint Count
        {
            [MethodImpl(Inline)]
            get => (uint)Data.Length;
        }
    }

    public struct TableRow<T,C0,C1,C2,C3,C4,C5>
    {
        public T Source;

        public C0 Cell0;

        public C1 Cell1;

        public C2 Cell2;

        public C3 Cell3;

        public C4 Cell4;

        public C5 Cell5;
    }

    public readonly ref struct TableRows<T,C0,C1,C2,C3,C4,C5>
    {
        public readonly Span<TableRow<T,C0,C1,C2,C3,C4,C5>> Data;

        [MethodImpl(Inline)]
        public TableRows(Span<TableRow<T,C0,C1,C2,C3,C4,C5>> src)
        {
            Data = src;
        }

        public ref TableRow<T,C0,C1,C2,C3,C4,C5> this[ulong index]
        {
            [MethodImpl(Inline)]
            get => ref seek(Data, index);
        }


        public uint Count
        {
            [MethodImpl(Inline)]
            get => (uint)Data.Length;
        }

    }

    public struct TableRow<T,C0,C1,C2,C3,C4,C5,C6>
        where T : struct
    {
        public T Source;

        public C0 Cell0;

        public C1 Cell1;

        public C2 Cell2;

        public C3 Cell3;

        public C4 Cell4;

        public C5 Cell5;

        public C6 Cell6;
    }

    public struct TableRow<T,C0,C1,C2,C3,C4,C5,C6,C7,C8,C9,CA>
        where T : struct
    {
        public T Source;

        public C0 Cell0;

        public C1 Cell1;

        public C2 Cell2;

        public C3 Cell3;

        public C4 Cell4;

        public C5 Cell5;

        public C6 Cell6;

        public C7 Cell7;

        public C8 Cell8;

        public C9 Cell9;

        public CA CellA;
    }

    public struct TableRow<T,C0,C1,C2,C3,C4,C5,C6,C7,C8,C9,CA,CB>
        where T : struct
    {
        public T Source;

        public C0 Cell0;

        public C1 Cell1;

        public C2 Cell2;

        public C3 Cell3;

        public C4 Cell4;

        public C5 Cell5;

        public C6 Cell6;

        public C7 Cell7;

        public C8 Cell8;

        public C9 Cell9;

        public CA CellA;

        public CB CellB;
    }


    public struct TableRow<T,C0,C1,C2,C3,C4,C5,C6,C7,C8,C9,CA,CB,CC>
        where T : struct
    {
        public T Source;

        public C0 Cell0;

        public C1 Cell1;

        public C2 Cell2;

        public C3 Cell3;

        public C4 Cell4;

        public C5 Cell5;

        public C6 Cell6;

        public C7 Cell7;

        public C8 Cell8;

        public C9 Cell9;

        public CA CellA;

        public CB CellB;

        public CC CellC;
    }

    public struct TableRow<T,C0,C1,C2,C3,C4,C5,C6,C7,C8,C9,CA,CB,CC,CD>
        where T : struct
    {
        public T Source;

        public C0 Cell0;

        public C1 Cell1;

        public C2 Cell2;

        public C3 Cell3;

        public C4 Cell4;

        public C5 Cell5;

        public C6 Cell6;

        public C7 Cell7;

        public C8 Cell8;

        public C9 Cell9;

        public CA CellA;

        public CB CellB;

        public CC CellC;

        public CD CellD;

    }

    public struct TableRow<T,C0,C1,C2,C3,C4,C5,C6,C7,C8,C9,CA,CB,CC,CD,CE>
        where T : struct
    {
        public T Source;

        public C0 Cell0;

        public C1 Cell1;

        public C2 Cell2;

        public C3 Cell3;

        public C4 Cell4;

        public C5 Cell5;

        public C6 Cell6;

        public C7 Cell7;

        public C8 Cell8;

        public C9 Cell9;

        public CA CellA;

        public CB CellB;

        public CC CellC;

        public CD CellD;

        public CE CellE;
    }

    public struct TableRow<T,C0,C1,C2,C3,C4,C5,C6,C7,C8,C9,CA,CB,CC,CD,CE,CF>
        where T : struct
    {
        public T Source;

        public C0 Cell0;

        public C1 Cell1;

        public C2 Cell2;

        public C3 Cell3;

        public C4 Cell4;

        public C5 Cell5;

        public C6 Cell6;

        public C7 Cell7;

        public C8 Cell8;

        public C9 Cell9;

        public CA CellA;

        public CB CellB;

        public CC CellC;

        public CD CellD;

        public CE CellE;

        public CF CellF;
    }
}