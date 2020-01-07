//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Linq;
    using System.Runtime.CompilerServices;
 
    using static zfunc;

    /// <summary>
    /// Defines an inclusive address range
    /// </summary>
    public readonly struct AddressSegment
    {
        public readonly ulong Start;

        public readonly ulong End;

        [MethodImpl(Inline)]
        public static AddressSegment Define(ulong start, ulong end)
            => new AddressSegment(start,end);

        [MethodImpl(Inline)]
        public static implicit operator AddressSegment((ulong start, ulong end) src)
            => new AddressSegment(src.start, src.end);

        [MethodImpl(Inline)]
        AddressSegment(ulong start, ulong end)
        {
            this.Start = start;
            this.End = end;
        }
        
        [MethodImpl(Inline)]
        public void Deconstruct(out ulong start, out ulong end)
        {
            start = this.Start;
            end = this.End;
        }

        public ulong Length 
        {
            [MethodImpl(Inline)]
            get => End - Start;
        }

        public string Format()
            => bracket(concat(
                Start.FormatHex(false), 
                AsciSym.Comma, 
                AsciSym.Space, 
                End.FormatHex(false,false))
                );

        public override string ToString()
            => Format();
    }


}