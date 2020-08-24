//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// 1 byte of storage
    /// </summary>
    public struct CellBlock1
    {
        public byte Data;
    }

    /// <summary>
    /// 2 bytes of storage
    /// </summary>
    public struct CellBlock2
    {
        public CellBlock1 Lo;

        public CellBlock1 Hi;
    }

    /// <summary>
    /// 3 bytes of storage
    /// </summary>
    public struct CellBlock3
    {
        public CellBlock2 A;

        public CellBlock1 B;
    }

    /// <summary>
    /// 4 bytes of storage
    /// </summary>
    public struct CellBlock4
    {
        public CellBlock2 Lo;

        public CellBlock2 Hi;
    }

    /// <summary>
    /// 5 bytes of storage
    /// </summary>
    public struct CellBlock5
    {
        public CellBlock4 A;

        public CellBlock1 B;
    }

    /// <summary>
    /// 6 bytes of storage
    /// </summary>
    public struct CellBlock6
    {
        public CellBlock5 A;

        public CellBlock1 B;
    }

    /// <summary>
    /// 7 bytes of storage
    /// </summary>
    public struct CellBlock7
    {
        public CellBlock6 A;

        public CellBlock1 B;
    }

    /// <summary>
    /// 8 bytes of storage
    /// </summary>
    public struct CellBlock8
    {
        public CellBlock4 Lo;

        public CellBlock4 Hi;
    }

    /// <summary>
    /// 9 bytes of storage
    /// </summary>
    public struct CellBlock9
    {
        public CellBlock8 A;

        public CellBlock1 B;
    }

    /// <summary>
    /// 10 bytes of storage
    /// </summary>
    public struct CellBlock10
    {
        public CellBlock8 A;

        public CellBlock2 B;
    }

    /// <summary>
    /// 11 bytes of storage
    /// </summary>
    public struct CellBlock11
    {
        public CellBlock10 A;

        public CellBlock1 B;
    }

    /// <summary>
    /// 12 bytes of storage
    /// </summary>
    public struct CellBlock12
    {
        public CellBlock8 A;

        public CellBlock4 B;
    }

    /// <summary>
    /// 13 bytes of storage
    /// </summary>
    public struct CellBlock13
    {
        public CellBlock12 A;

        public CellBlock1 B;
    }

    /// <summary>
    /// 14 bytes of storage
    /// </summary>
    public struct CellBlock14
    {
        public CellBlock7 Lo;

        public CellBlock7 Hi;
    }

    /// <summary>
    /// 15 bytes of storage
    /// </summary>
    public struct CellBlock15
    {
        public CellBlock10 A;

        public CellBlock5 B;
    }

    /// <summary>
    /// 16 bytes of storage
    /// </summary>
    public struct CellBlock16
    {
        public CellBlock8 Lo;

        public CellBlock8 Hi;
    }

    /// <summary>
    /// 32 bytes of storage
    /// </summary>
    public struct CellBlock32
    {
        public CellBlock16 Lo;

        public CellBlock16 Hi;
    }

    /// <summary>
    /// 64 bytes of storage
    /// </summary>
    public struct CellBlock64
    {
        public CellBlock32 Lo;

        public CellBlock32 Hi;
    }

    /// <summary>
    /// 128 bytes of storage
    /// </summary>
    public struct CellBlock128
    {
        public CellBlock64 Lo;

        public CellBlock64 Hi;
    }

    /// <summary>
    /// 256 bytes of storage
    /// </summary>
    public struct CellBlock256
    {
        public CellBlock128 Lo;

        public CellBlock128 Hi;
    }

}