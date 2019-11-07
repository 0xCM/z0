//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Text;
    using static nfunc;
    using static zfunc;

    /// <summary>
    /// Defines the matrix api surface
    /// </summary>
    public static class Matrix
    {
        /// <summary>
        /// Allocates a square matrix of natual dimension
        /// </summary>
        /// <param name="n">The square dimension; specified, if desired, to aid type inference</param>
        /// <param name="fill">A value to which each cell is initialized</param>
        /// <typeparam name="N">The natural dimension type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Matrix<N,T> alloc<N,T>(N n = default, T fill = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new Matrix<N, T>(zfunc.alloc(zfunc.natval<N>()* zfunc.natval<N>(), fill));

        /// <summary>
        /// Allocates a matrix of natual dimensions
        /// </summary>
        /// <param name="m">The row count, specified if desired to aid type inference</param>
        /// <param name="n">The column count, specified if desired to aid type inference</param>
        /// <param name="fill">A value to which each cell is initialized</param>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The col count type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Matrix<M,N,T> alloc<M,N,T>(M m = default, N n = default, T fill = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new Matrix<M, N, T>(MemorySpan.Alloc<T>(nati<M>()* nati<N>(),fill));
         
        /// <summary>
        /// Loads a matrix of natural dimensions from an array
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The col count type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Matrix<M,N,T> load<M,N,T>(T[] src, M m = default, N n = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new Matrix<M, N, T>(src);

        /// <summary>
        /// Loads a square matrix of natural order from an array
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The col count type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Matrix<N,T> load<N,T>(N n, params T[] src)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new Matrix<N, T>(src);

        /// <summary>
        /// Defines the canonical filename for a matrix data file
        /// </summary>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The column count type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static FileName filename<M,N,T>(string fileId = null)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged    
                => FileName.Define($" {fileId ?? "mat"}_{PrimalKinds.kind<T>()}[{nati<M>()}x{nati<N>()}].csv");
        
        /// <summary>
        /// Writes the matrix to a delimited file
        /// </summary>
        /// <param name="src">The source matrix</param>
        /// <param name="dst">The target file</param>
        /// <typeparam name="M">The natural row count type</typeparam>
        /// <typeparam name="N">The natural column count type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        public static void write<M,N,T>(BlockMatrix<M,N,T> src, FilePath dst, bool overwrite = true, TextFormat? fmt = null)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            var _fmt = fmt ?? TextFormat.Default;
            var sep = _fmt.Delimiter;
            var rows = nati<M>();
            var cols = nati<N>();
            var sb = new StringBuilder();                        
            sb.AppendLine($"{_fmt.CommentPrefix} {typeof(T).Name}[{rows}x{cols}]");
            if(_fmt.HasHeader)
            {
                for(var i = 0; i<cols; i++)
                {
                    sb.Append($"Col{i}");
                    if(i != cols - 1)
                        sb.Append(sep);
                }
                sb.AppendLine();
            }
            sb.Append(src.Format(sep));
            
            if(overwrite)
                dst.Overwrite(sb.ToString());
            else
                dst.Append(sb.ToString());
        }

        /// <summary>
        /// Reads a matrix from a delimited file
        /// </summary>
        /// <param name="src">The source file</param>
        /// <param name="format">The file format</param>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The column count type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        public static Matrix<M,N,T> read<M,N,T>(FilePath src, TextFormat? format = null)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged    
        {
            var doc = src.ReadTextDoc().Require();
            var m = nati<M>();
            var n = nati<N>();

            if(m != doc.DataLineCount)
                return default;

            if(n != doc.Rows[0].Cells.Length)
                return default;

            var dst =  load<M,N,T>(MemorySpan.Alloc<T>(m * n));
            for(var i = 0; i<doc.Rows.Length; i++)
            {
                ref readonly var row = ref doc[i];
                for(var j = 0; j<row.Cells.Length; j++)
                {
                    gmath.parse<T>(row.Cells[j].CellValue, out T cell);
                    dst[i,j] = cell;
                }                
            }

            return dst;
        }
   }

}