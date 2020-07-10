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
    using static Typed;

    public readonly struct QString : ITextual
    {
        readonly Vector512<ulong> Locations;

        public StringRef S0
        {
            [MethodImpl(Inline)]
            get => new StringRef(memref(Locations[n0]));
        }  

        public StringRef S1
        {
            [MethodImpl(Inline)]
            get => new StringRef(memref(Locations[n1]));
        }  

        public StringRef S2
        {
            [MethodImpl(Inline)]
            get => new StringRef(memref(Locations[n2]));
        }  

        public StringRef S3
        {
            [MethodImpl(Inline)]
            get => new StringRef(memref(Locations[n3]));
        }  


        [MethodImpl(Inline)]
        public QString(string s0, string s1, string s2, string s3)
            => Locations = v512<ulong>(memref(s0), memref(s1), memref(s2), memref(s3));
        
        public string Format()
            => StringRefs.join(" ", S0, S1, S2, S3);

        public string Format(string delimiter)
            => StringRefs.join(delimiter, S0, S1, S2, S3);

        public string Diagnostic
            => text.concat(
                "s0 = ", S0.Address, text.bracket(S0.Length), Space, text.embrace(S0.Text),
                "s1 = ", S1.Address, text.bracket(S1.Length), Space, text.embrace(S1.Text),
                "s2 = ", S2.Address, text.bracket(S2.Length), Space, text.embrace(S2.Text),
                "s3 = ", S3.Address, text.bracket(S3.Length), Space, text.embrace(S3.Text)
                );            
        
        public override string ToString()
            => Diagnostic;
    }
}