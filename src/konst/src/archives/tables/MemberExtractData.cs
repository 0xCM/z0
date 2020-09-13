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

    using static Konst;

    public readonly struct MemberExtractData
    {
        readonly ExtractRecord[] Data;

        /// <summary>
        /// Hydrates from a file
        /// </summary>
        /// <param name="src">The source path</param>
        public static MemberExtractData Load(FilePath src)
            => new MemberExtractData(Read(src).ToArray());

        /// <summary>
        /// Reads extract records from a saved report
        /// </summary>
        /// <param name="src">The report path</param>
        static IEnumerable<ExtractRecord> Read(FilePath src)
        {
            var count = 0;
            foreach(var line in src.ReadLines())
            {
                if(count++ != 0)
                    yield return ExtractRecord.Parse(line);
            }
        }        

        [MethodImpl(Inline)]
        public static implicit operator ExtractRecord[](MemberExtractData src)
            => src.Data;

        [MethodImpl(Inline)]
        public static implicit operator MemberExtractData(ExtractRecord[] src)
            => new MemberExtractData(src);

        [MethodImpl(Inline)]
        public MemberExtractData(ExtractRecord[] data)
        {
            Data = data;
        }

        public int Length 
            => Data.Length;

        public ref readonly ExtractRecord this[int index] 
        { 
            [MethodImpl(Inline)] 
            get =>  ref Data[index]; 
        }
    }
}