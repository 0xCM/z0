//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static zfunc;

    public readonly struct NativeFormatConfig
    {
        public static NativeFormatConfig Default => new NativeFormatConfig(4,true);
        
        public NativeFormatConfig(int linebytes, bool linelabels)
        {
            this.BytesPerLine = linebytes;
            this.LineLabels = linelabels;
        }

        public readonly int BytesPerLine;

        public readonly bool LineLabels;

        public NativeFormatConfig WithBytesPerLine(int count)
            => new NativeFormatConfig(count,LineLabels);

        public NativeFormatConfig WithLineLabels(bool labels)
            => new NativeFormatConfig(BytesPerLine,labels);
    }
}