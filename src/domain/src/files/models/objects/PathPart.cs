//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct FileSystem
    {        
        /// <summary>
        /// Defines the content of file path component
        /// </summary>
        public readonly struct PathPart
        {               
            public static PathPart Empty 
            {
                [MethodImpl(Inline)]
                get => new PathPart(NullChar);
            }
            
            public readonly char[] Data;

            [MethodImpl(Inline)]
            public static implicit operator PathPart(char[] data)   
                => new PathPart(data);

            [MethodImpl(Inline)]
            public static implicit operator PathPart(string data)   
                => new PathPart(data.ToCharArray());

            [MethodImpl(Inline)]
            unsafe PathPart(char src)
            {
                var @null = z.address(NullText).Pointer<char>();
                ref var data = ref z.@ref(@null);
                Data = z.@as<char,char[]>(data);
            }
            
            [MethodImpl(Inline)]
            public PathPart(params char[] name)
                => Data = name;
            
            public ReadOnlySpan<char> View
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            public Span<char> Edit
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            public bool IsEmpty
            {
                [MethodImpl(Inline)]
                get => Data == null || Data[0] == NullChar;
            }

            public bool IsNonEmpty
            {
                [MethodImpl(Inline)]
                get => Data != null & Data.Length >= 1 && Data[0] != NullChar;
            }

            const char NullChar = '\0';

            const string NullText = "\0";         
        }
    }
}