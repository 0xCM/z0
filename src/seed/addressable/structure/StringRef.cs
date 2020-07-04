//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static Root;
    using static As;
    using static V0;

    /// <summary>
    /// A string?
    /// </summary>
    [ApiHost]
    public readonly struct StringRef : ITextual, IConstSpan<StringRef,char>
    {            
        readonly Vector128<ulong> Data;

        [MethodImpl(Inline), Op]
        public static unsafe StringRef create(string src)
            => new StringRef((ulong)pchar(src), src.Length, 1);

        [MethodImpl(Inline), Op]
        public static unsafe StringRef sequence(string src, uint count)
            => new StringRef((ulong)pchar(src), src.Length, count);

        [MethodImpl(Inline), Op]
        public static StringRef from(MemRef src)
            => new StringRef(src);

        [MethodImpl(Inline)]
        public StringRef(in MemRef src)
            => Data = vparts(N128.N, src.Address, ((ulong)src.DataSize | Singleton)); 

        [MethodImpl(Inline)]
        static Vector128<ulong> store(ulong location, uint length, uint count)
            => vparts(N128.N, location, (ulong)length*Scale | ((ulong)count << CountShift));

        [MethodImpl(Inline)]
        public StringRef(in Ref src)
            => Data = vparts(N128.N, src.Location, ((ulong)src.DataSize | Singleton)); 

        [MethodImpl(Inline)]
        public StringRef(ulong location, int length, uint count)
            => Data = store(location, (uint)length, count);

        [MethodImpl(Inline)]
        public StringRef(in Ref src, uint count)
            => Data = vparts(N128.N, src.Location, ((ulong)src.DataSize | (count << CountShift))); 

        [MethodImpl(Inline)]
        internal StringRef(Vector128<ulong> data)
            => Data = data;

        [MethodImpl(Inline)]
        public unsafe StringRef Next(int length)
            => new StringRef(vparts((ulong)(char*)(Lo + UnitSize), (ulong)DataSize | (Count << CountShift)));

        [MethodImpl(Inline), Op]
        public static unsafe string @string(StringRef src)
            => As.@string(src.Chars);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> data(StringRef src)
            => src.Chars;
                
        [MethodImpl(Inline)]
        public static implicit operator string(StringRef src)
            => src.Text;

        [MethodImpl(Inline)]
        public static implicit operator StringRef(string src)
            => create(src);

        /// <summary>
        /// The length of the represented string
        /// </summary>
        public int Length
        {
            [MethodImpl(Inline)]
            get => (int)Hi;
        }

        /// <summary>
        /// The number of strings in the sequence, parhaps only 1
        /// </summary>
        public uint Count
        {
            [MethodImpl(Inline)]
            get => (uint)(Hi >> CountShift);
        }

        public unsafe string Text
        {
            [MethodImpl(Inline)]
            get => @string(this);
        }

        public MemoryAddress Address
        {
            [MethodImpl(Inline)]
            get => Lo;
        }

        public ref readonly char this[int index]
        {
            [MethodImpl(Inline)]
            get => ref skip(Chars,index);
        }

        /// <summary>
        /// The string content presented as a span
        /// </summary>
        public ReadOnlySpan<char> Chars
        {
            [MethodImpl(Inline)]
            get => data(this);
        }

        /// <summary>
        /// Specifies the segment byte count
        /// </summary>
        /// <typeparam name="T">The cell type</typeparam>
        public uint DataSize 
        {
            [MethodImpl(Inline)]
            get => (uint)Hi;
        }

        /// <summary>
        /// The string content presented as a span
        /// </summary>
        ReadOnlySpan<char> IConstSpan<StringRef,char>.Data
        {
            [MethodImpl(Inline)]
            get => data(this);
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Length == 0;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Length != 0;
        }

        public StringRef Zero
        {
            [MethodImpl(Inline)]
            get => Empty;
        }

        public static StringRef Empty 
        {
            [MethodImpl(Inline)]
            get => empty();
        }

        [MethodImpl(Inline), Op]
        public static StringRef empty()
            => new StringRef(MemRef.Empty);

        [MethodImpl(Inline)]
        public string Format()
            => Text;

        public override string ToString()
            => Text;

        ulong Lo
        {
            [MethodImpl(Inline)]
            get => vcell(Data,0);
        }

        ulong Hi
        {
            [MethodImpl(Inline)]
            get => vcell(Data,1);
        }

        const byte CountShift = 32;

        const byte Scale = 2;

        const byte UnitSize = 8;

        const ulong Singleton = 1ul << CountShift;
        
        public string Diagnostic()
            => text.concat(Address, text.bracket(Length), " := ", text.embrace(Text));
    }
}