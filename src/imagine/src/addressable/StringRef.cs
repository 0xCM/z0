//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static System.Runtime.Intrinsics.Vector128;
    using static System.Runtime.Intrinsics.Vector256;

    using static Konst;
    using static core;

    /// <summary>
    /// A string?
    /// </summary>
    [ApiHost]
    public readonly struct StringRef : ITextual, IConstSpan<StringRef,char>
    {            
        internal readonly Vector128<ulong> Location;

        [MethodImpl(Inline), Op]
        public static unsafe StringRef create(string src)
            => new StringRef((ulong)pchar(src), src.Length);

        [MethodImpl(Inline), Op]
        public static StringRef from(MemRef src)
            => new StringRef(src);

        /// <summary>
        /// Defines a 128-bit vector by explicit component specification, from least -> most significant
        /// </summary>
        /// <param name="w">The vector width selector</param>
        [MethodImpl(Inline),Op]
        static Vector128<ulong> vparts(W128 w, ulong x0, ulong x1)
            => Create(x0,x1);

        [MethodImpl(Inline)]
        public StringRef(in MemRef src)
            => Location = vparts(N128.N, src.Address, (ulong)src.DataSize); 

        [MethodImpl(Inline)]
        static Vector128<ulong> store(ulong location, uint length)
            => vparts(N128.N, location, (ulong)length*Scale);

        [MethodImpl(Inline)]
        public StringRef(in Ref src)
            => Location = vparts(N128.N, src.Location, (ulong)src.DataSize); 

        [MethodImpl(Inline)]
        public StringRef(ulong location, int length)
            => Location = vparts(N128.N, location, (ulong)(length*Scale)); 

        [MethodImpl(Inline)]
        internal StringRef(Vector128<ulong> data)
            => Location = data;

        [MethodImpl(Inline), Op]
        public static unsafe string @string(StringRef src)
            => src.Text;

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
            get => (int)Hi/Scale;
        }

        public unsafe string Text
        {
            [MethodImpl(Inline)]
            get => sys.@string(Address.Pointer<char>());
        }

        public MemoryAddress Address
        {
            [MethodImpl(Inline)]
            get => Lo;
        }

        public ref readonly char this[int index]
        {
            [MethodImpl(Inline)]
            get => ref skip(Chars,(uint)index);
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
            get => vcell(Location,0);
        }

        ulong Hi
        {
            [MethodImpl(Inline)]
            get => vcell(Location,1);
        }

        const byte Scale = 2;

        // public string Diagnostic()
        //     => String.Concat(Address.Format().PadRight(14), 
        //         text.bracket(text.concat(text.squote(Text), text.spaced(Pipe), Length)));

        // public string Diagnostic(in StringRef prior)
        //     => String.Concat((Address - prior.Address).Format().PadRight(4), 
        //         text.bracket(text.concat(text.squote(Text), text.spaced(Pipe), Length)));             
    }
}