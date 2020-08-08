//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Konst;
    using static z;

    public readonly struct ExtensionMap<F> : IExtensionMap<F>
        where F : unmanaged, Enum
    {
        readonly Dictionary<F,FileExtension> Data;

        readonly F[] FlagValues;

        public ExtensionMap(int i)
        {
            Data = new Dictionary<F, FileExtension>();
            FlagValues = Enums.literals<F>();
            foreach(var f in FlagValues)
                MapExtension(f, FileExtension.Define(f.ToString().ToLower()));            
        }

        [MethodImpl(Inline)]
        public void MapExtension(F flag, FileExtension ext)
        {
            Data[flag] = ext;
        }

        public ReadOnlySpan<FileExtension> Extensions
        {
            [MethodImpl(Inline)]
            get => Data.Values.Array();
        }        

        public ReadOnlySpan<F> Flags
        {
            [MethodImpl(Inline)]
            get => FlagValues;

        }
        
        [MethodImpl(Inline)]
        public FileExtension Ext(F f)   
            => Data[f];        

        public string Format()
        {
            var dst = text.build();
            dst.Append(text.format("{0}Map[",typeof(F).Name));

            var flags = Flags;
            var count = flags.Length;
            for(var i=1u; i<count; i++)
            {                
                if(i != 1)
                    dst.Append(", ");
                var flag = z.skip(flags,i);
                dst.Append(text.format("{0}: {1}", flag, Data[flag]));
            }
            dst.Append("]");
            
            return dst.ToString();
        }
    }
}