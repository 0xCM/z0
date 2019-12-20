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


    public interface IMethodData
    {
        /// <summary>
        /// The deconstructed method
        /// </summary>
        MethodInfo Method {get;}

        /// <summary>
        /// Defines the inclusive lower bound of the block
        /// </summary>
        ulong StartAddress {get;}

        /// <summary>
        /// Defines the inclusive upper bound of the block
        /// </summary>
        ulong EndAddress {get;}

        /// <summary>
        /// The memory content
        /// </summary>
        byte[] Body {get;}

        ulong Length 
            => EndAddress -StartAddress;        

        bool IsEmpty {get;}
    }

    public static class MethodDataX
    {
        static string MethodSep => new string('_',80);

        public static string Format<T>(this T data, int linebytes = 8, bool linelabels = true)
            where T : IMethodData
        {
            if(data.IsEmpty)
                return "<no_data>";

            var format = text();
            var range = bracket(concat(data.StartAddress.FormatHex(false,true), AsciSym.Comma, data.EndAddress.FormatHex(false,true)));
            format.AppendLine($"; function: {data.Method.MethodSig().Format()}");
            format.AppendLine($"; location: {range}, code length: {data.Length} bytes");

            for(ushort i=0; i< data.Length; i++)
            {
                if(i % linebytes == 0)
                {
                    if(i != 0)
                        format.AppendLine();

                    if(linelabels)
                    {
                        format.Append(i.FormatHex(true,false));
                        format.Append(AsciLower.h);
                        format.Append(AsciSym.Space);
                    }
                }
                format.Append(data.Body[i].FormatHex(true, true));
                format.Append(AsciSym.Space);
            }
            format.AppendLine();   
            format.AppendLine(MethodSep);
            return format.ToString();
        }

    }

    /// <summary>
    /// Represents a contiguous block of memory that represents the machine code for a method
    /// </summary>
    public readonly struct DelegateData : IMethodData
    {        

        public static DelegateData Empty => default;

        [MethodImpl(Inline)]
        public DelegateData(Delegate Delegate, ulong StartAddress, ulong EndAddress, byte[] body)
        {
            this.Delegate = Delegate;
            this.StartAddress = StartAddress;
            this.EndAddress = EndAddress;
            this.Body = body.ToArray();
        }

        /// <summary>
        /// The deconstructed delegate
        /// </summary>
        public readonly Delegate Delegate;

        /// <summary>
        /// Defines the inclusive lower bound of the block
        /// </summary>
        public readonly ulong StartAddress {get;}

        /// <summary>
        /// Defines the inclusive upper bound of the block
        /// </summary>
        public readonly ulong EndAddress {get;}

        /// <summary>
        /// The memory content
        /// </summary>
        public readonly byte[] Body {get;}
        
        public ref readonly byte this[int ix]
        {
            [MethodImpl(Inline)]
            get => ref Body[ix];
        }

        public ulong Length 
            => EndAddress -StartAddress;

        /// <summary>
        /// The method for the deconstructed delegate
        /// </summary>
        public MethodInfo Method    
            => Delegate.Method;

       public bool IsEmpty
            => Method == null || Body == null;

    }

    /// <summary>
    /// Represents a contiguous block of memory that represents the machine code for a method
    /// </summary>
    public readonly struct MethodData : IMethodData
    {        
        public static MethodData Empty => default;

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
        public readonly MethodInfo Method {get;}

        /// <summary>
        /// Defines the inclusive lower bound of the block
        /// </summary>
        public readonly ulong StartAddress {get;}

        /// <summary>
        /// Defines the inclusive upper bound of the block
        /// </summary>
        public readonly ulong EndAddress {get;}

        /// <summary>
        /// The memory content
        /// </summary>
        public readonly byte[] Body {get;}
        
        public ulong Length 
            => EndAddress -StartAddress;

        public bool IsEmpty
            => Method == null || Body == null;


    }
}