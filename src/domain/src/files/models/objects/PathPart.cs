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
        public readonly struct PathPart : ITextual
        {               
            public string Name {get;}

            [MethodImpl(Inline)]
            public static implicit operator PathPart(char[] data)   
                => new PathPart(data);

            [MethodImpl(Inline)]
            public static implicit operator PathPart(string data)   
                => new PathPart(data);

            [MethodImpl(Inline)]
            public PathPart(string name)
                => Name = name;

            [MethodImpl(Inline)]
            public PathPart(params char[] name)
                => Name = new string(name);
            
            public ReadOnlySpan<char> View
            {
                [MethodImpl(Inline)]
                get => Name;
            }

            public string Format()
                => View.ToString();
            
            public bool IsEmpty
            {
                [MethodImpl(Inline)]
                get => text.empty(Name);
            }

            public bool IsNonEmpty
            {
                [MethodImpl(Inline)]
                get => text.nonempty(Name) && Name.Length > 0;
            }                                    
            
            public static PathPart Empty 
            {
                [MethodImpl(Inline)]
                get => new PathPart(EmptyString);
            }        
        }
    }
}