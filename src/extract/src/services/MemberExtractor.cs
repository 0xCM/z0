//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    
    using static Seed;
    using static Memories;

    /// <summary>
    /// Extracts operations from an api host
    /// </summary>
    public readonly struct MemberExtractor : IMemberExtractor
    {
        readonly int BufferLength;

        [MethodImpl(Inline)]
        public static IMemberExtractor Create(int bufferlen)
            => new MemberExtractor(bufferlen);
            
        [MethodImpl(Inline)]
        internal MemberExtractor(int bufferlen)            
        {
            BufferLength = bufferlen;
        }

        /// <summary>
        /// Extracts encoded content that defines executable code for a located member
        /// </summary>
        /// <param name="src">The source member</param>
        public ExtractedMember Extract(Member src)
        {
            Span<byte> buffer = stackalloc byte[BufferLength];
            return Extract(src, MemoryReader.Service, buffer);
        }

        public ExtractedMember[] Extract(Member[] members)
        {
            var dst = new ExtractedMember[members.Length];
            Span<byte> buffer = stackalloc byte[BufferLength];            
            var reader = MemoryReader.Service;
            for(var i=0; i<members.Length; i++)
                dst[i] = Extract(members[i], reader, buffer);
            return dst;
        }

        /// <summary>
        /// Extracts encoded content for all operations defined by a host
        /// </summary>
        /// <param name="src">The source member</param>
        public ExtractedMember[] Extract(IApiHost src)
            => Extract(Identities.Services.ApiLocator.Located(src));

        [MethodImpl(Inline)]
        ExtractedMember Extract(Member src, IMemoryReader reader, Span<byte> buffer)
        {
            buffer.Clear();      
            var address = src.Address;          
            var length = reader.Read(address, buffer);
            return ExtractedMember.Define(src, 
                LocatedCode.Define(address, buffer.Slice(0,length).ToArray()));
        }
    }
}