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
    public readonly struct HostCodeExtractor : IHostCodeExtractor
    {
        public int BufferLength {get;}

        [MethodImpl(Inline)]
        public static IHostCodeExtractor Create(int bufferlen)
            => new HostCodeExtractor(bufferlen);
            
        [MethodImpl(Inline)]
        internal HostCodeExtractor(int bufferlen)            
        {
            BufferLength = bufferlen;
        }

        /// <summary>
        /// Extracts encoded content that defines executable code for a located member
        /// </summary>
        /// <param name="src">The source member</param>
        public MemberExtract Extract(in Member src)
        {
            Span<byte> buffer = stackalloc byte[BufferLength];
            var reader =  MemoryReader.Service;
            return Extract(src, reader, buffer);
        }

        public MemberExtract[] Extract(Member[] members)
        {
            var dst = new MemberExtract[members.Length];
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
        public MemberExtract[] Extract(IApiHost src)
        {
            var locator = StatelessIdentity.Services.MemberLocator();
            var members = locator.Located(src).ToArray();
            return Extract(members);
        }

        [MethodImpl(Inline)]
        MemberExtract Extract(in Member src, IMemoryReader reader, Span<byte> buffer)
        {
            buffer.Clear();                
            var length = reader.Read(src.Address, buffer);
            var data = LocatedCode.Define(src.Address, buffer.Slice(0,length).ToArray());
            return MemberExtract.Define(src, data);
        }
    }
}