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

    public readonly struct ExtensionMap<F,X> : IExtensionMap<F>
        where F : unmanaged, Enum
        where X : unmanaged, Enum
    {
        readonly Dictionary<F,FileExtension> Index;

        readonly F[] FlagValues;

        readonly X[] Map;

        readonly FileExtension[] ExtValues;
        
        public ExtensionMap(int m)
        {
            Index = new Dictionary<F,FileExtension>();
            FlagValues = Enums.literals<F>();
            Map = Enums.literals<X>();
            ExtValues = z.alloc<FileExtension>(FlagValues.Length);
            for(var j=0; j< ExtValues.Length; j++)
            {
                var flag = FlagValues[j];
                var xmap = Map.Where(x => z.u64(x) == z.u64(flag));
                if(xmap.Length != 0)
                    ExtValues[j] = FileExtension.Define(xmap[0].ToString().ToLower());
                else
                    ExtValues[j] = FileExtension.Define(flag.ToString().ToLower());
                
                Index[flag] = ExtValues[j];
            }
        }

        public ReadOnlySpan<FileExtension> Extensions
        {
            [MethodImpl(Inline)]
            get => Index.Values.Array();
        }        

        public ReadOnlySpan<F> Flags
        {
            [MethodImpl(Inline)]
            get => FlagValues;

        }

        [MethodImpl(Inline)]
        public FileExtension Ext(F f)   
            => Index[f];        

        [MethodImpl(Inline)]
        public void MapExtension(F flag, FileExtension ext)
        {
            Index[flag] = ext;
        }


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
                dst.Append(text.format("{0}: {1}", flag, Index[flag]));
            }
            dst.Append("]");
            
            return dst.ToString();
        }

    }

}