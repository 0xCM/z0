//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    

    partial class Stacked
    {
        public ref struct CharStack2
        {
            public char C0;

            char C1;
        }

        public ref struct CharStack4
        {
            public CharStack2 C0;

            CharStack2 C1;
        }

        public ref struct CharStack8
        {
            public CharStack4 C0;

            CharStack4 C1;
        }

        public ref struct CharStack16
        {
            public CharStack8 C0;

            CharStack8 C1;        
        }

        public ref struct CharStack32
        {
            public CharStack16 C0;

            CharStack16 C1;        
        }

        public ref struct CharStack64
        {
            public CharStack32 C0;

            CharStack32 C1;       
        }
    }
}