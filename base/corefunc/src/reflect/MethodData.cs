//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using static zfunc;

    /// <summary>
    /// Represents a contiguous block of memory that represents the machine code for a method
    /// </summary>
    public readonly struct MethodData
    {        

        [MethodImpl(Inline)]
        public MethodData(MethodInfo method, ulong StartAddress, ulong EndAddress, byte[] body)
        {
            this.Method = method;
            this.StartAddress = StartAddress;
            this.EndAddress = EndAddress;
            this.Body = body.ToArray();
        }

        /// <summary>
        /// The deconstructed method
        /// </summary>
        public readonly MethodInfo Method;

        /// <summary>
        /// Defines the inclusive lower bound of the block
        /// </summary>
        public readonly ulong StartAddress;

        /// <summary>
        /// Defines the inclusive upper bound of the block
        /// </summary>
        public readonly ulong EndAddress;

        /// <summary>
        /// The memory content
        /// </summary>
        public readonly byte[] Body;
        
        public ref readonly byte this[int ix]
        {
            [MethodImpl(Inline)]
            get => ref Body[ix];
        }

        public ulong Length 
            => EndAddress -StartAddress;

        public string Format()
        {
            var format = text();
            var title = Method.Name;
            format.Append(StartAddress.FormatHex(false,true));
            format.Append(AsciSym.Colon);
            format.Append(AsciSym.Space);
            format.AppendLine($"{title} Begin, {Length} bytes");
            for(ushort i=0; i< Length; i++)
            {
                if(i % 2 == 0)
                {
                    if(i != 0)
                        format.AppendLine();

                    format.Append(i.FormatHex(true,false));
                    format.Append(AsciLower.h);
                    format.Append(AsciSym.Space);
                }
                format.Append(Body[i].FormatHex(true, true));
                format.Append(AsciSym.Space);
            }
            format.AppendLine();   
            format.Append(EndAddress.FormatHex(false,true));
            format.Append(AsciSym.Colon);
            format.Append(AsciSym.Space);
            format.Append($"{title} End");
            return format.ToString();
        }
    }
}