//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;
    using static As;

    public unsafe readonly ref struct BitCharSeq32
    {
        readonly char* ps0;

        readonly char* ps1;

        readonly char* ps2;

        readonly char* ps3;

        public BitCharSeq32(char* ps0, char* ps1, char* ps2, char* ps3)
        {
            this.ps0 = ps0;
            this.ps1 = ps1;
            this.ps2 = ps2;
            this.ps3 = ps3;
        }

        public ReadOnlySpan<char> S0
        {
            [MethodImpl(Inline)]
            get => new ReadOnlySpan<char>(ps0,8);
        }

        public ReadOnlySpan<char> S1
        {
            [MethodImpl(Inline)]
            get => new ReadOnlySpan<char>(ps1,8);
        }

        public ReadOnlySpan<char> S2
        {
            [MethodImpl(Inline)]
            get => new ReadOnlySpan<char>(ps2,8);
        }

        public ReadOnlySpan<char> S3
        {
            [MethodImpl(Inline)]
            get => new ReadOnlySpan<char>(ps3,8);
        }

    }

}