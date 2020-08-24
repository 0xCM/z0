//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public struct CharBlock1
    {
        public char Data;
    }

    public struct CharBlock2
    {
        public CharBlock1 Lo;

        public CharBlock1 Hi;
    }

    public struct CharBlock3
    {
        public CharBlock2 A;

        public CharBlock1 B;
    }

    public struct CharBlock4
    {
        public CharBlock2 Lo;

        public CharBlock2 Hi;
    }

    public struct CharBlock5
    {
        public CharBlock4 A;

        public CharBlock1 B;
    }

    public struct CharBlock6
    {
        public CharBlock5 A;

        public CharBlock1 B;
    }

    public struct CharBlock7
    {
        public CharBlock6 A;

        public CharBlock1 B;
    }

    public struct CharBlock8
    {
        public CharBlock4 Lo;

        public CharBlock4 Hi;
    }

    public struct CharBlock9
    {
        public CharBlock8 A;

        public CharBlock1 B;
    }

    public struct CharBlock10
    {
        public CharBlock8 A;

        public CharBlock2 B;
    }

    public struct CharBlock11
    {
        public CharBlock10 A;

        public CharBlock1 B;
    }

    public struct CharBlock12
    {
        public CharBlock8 A;

        public CharBlock4 B;
    }

    public struct CharBlock13
    {
        public CharBlock12 A;

        public CharBlock1 B;
    }

    public struct CharBlock14
    {
        public CharBlock7 Lo;

        public CharBlock7 Hi;
    }

    public struct CharBlock15
    {
        public CharBlock10 A;

        public CharBlock5 B;
    }

    public struct CharBlock16
    {
        public CharBlock8 Lo;

        public CharBlock8 Hi;
    }

    public struct CharBlock32
    {
        public CharBlock16 Lo;

        public CharBlock16 Hi;
    }

    public struct CharBlock64
    {
        public CharBlock32 Lo;

        public CharBlock32 Hi;
    }

}